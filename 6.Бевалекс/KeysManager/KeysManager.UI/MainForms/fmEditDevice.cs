using Domain.Concrete;
using KeysManager.Domain.Concrete;
using KeysManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysManager.UI.PublicFunctions;

namespace KeysManager.UI.MainForms
{
    public partial class fmEditDevice : Form
    {
        private EFDevicesRepository DevRep; //объект репозитория и контекст
        private EFOrganizationsRepository OrgRep = new EFOrganizationsRepository();//репозиторий для заполнени выпадающего меню
        private EFHistoryChangeKeyValRepository HistChangeKey = new EFHistoryChangeKeyValRepository();//для сохранения истории
        private EFKeysRepository KeyRep = new EFKeysRepository();

        private tbDevice DevOldData;//для сравнения знаений входных и выходных данных
        public Boolean StateInsert {get; set;}
        private Boolean CodeDevChanged { get { return DevOldData.CODE_KEY != tbCodeKey.Text; } set { } }
       
        public fmEditDevice(EFDevicesRepository dr)
        {
            InitializeComponent();            
            DevRep = dr;//берем существующй репозиторий и контекст
            FillDropDownOrgList();//заполняем дроп даун лист
        }

        public fmEditDevice(tbDevice dev, EFDevicesRepository dr)
            : this(dr)
        {
            //заполняем поля переданными данными             
            tbCodeKey.Text = dev.CODE_KEY;
            tbNameOwner.Text = dev.NAME_OWNER;
            tbJobPos.Text = dev.JOB_POSITION;//.ToString()            
            cbNameOrg.SelectedValue = dev.ID_ORG;//становимся на выбранную запись организации

            DevOldData = dev;//запоминаем входные данные перед их изменением
        }

        private void fmEditDevice_Load(object sender, EventArgs e)
        {
            if (StateInsert)
                this.Text = "Добавление Устройства";
            else
            {
                this.Text = "Изменение Устройства";
            }
        }

       

        public void FillDropDownOrgList()
        {
            cbNameOrg.DisplayMember = "NAME";//Отображаемое значение   
            cbNameOrg.ValueMember = "ID";//Значение для Value
            cbNameOrg.DataSource = OrgRep.OrganizationsList.ToList();//к гриду подключаем сорс содержащий значенияорганизаций
            
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bool CheckEr = false;

            tbDevice DevNewData = new tbDevice();
            //заполняем основные поля
            DevNewData.CODE_KEY = tbCodeKey.Text.Trim();
            DevNewData.NAME_OWNER = tbNameOwner.Text.Trim();
            DevNewData.JOB_POSITION = tbJobPos.Text.Trim();
            DevNewData.ID_ORG = (int)cbNameOrg.SelectedValue;

            //если небыло изменений выходим
            if (!StateInsert)
            {
                if (CompareChanges(DevNewData, DevOldData))
                {
                    this.Close();
                    return;
                }
            }

            if (tbCodeKey.Text == string.Empty)
            {
                epShowError.SetError(tbCodeKey, "Поле 'Код ключа устройства' не может быть пустым.");
                CheckEr = true;
            }

            if (tbNameOwner.Text == string.Empty)
            {
                epShowError.SetError(tbNameOwner, "Поле 'Фамилия владельца устройства' не может быть пустым.");
                CheckEr = true;
            }

            if (tbJobPos.Text == string.Empty)
            {
                epShowError.SetError(tbJobPos, "Поле 'Должность владельца устройства' не может быть пустым.");
                CheckEr = true;
            }

            if (cbNameOrg.Text == string.Empty)
            {
                epShowError.SetError(cbNameOrg, "Поле 'Наименование Организации' не может быть пустым.");
                CheckEr = true;
            }
            //если нет ошибок то
            if (!CheckEr)
            {              

                if (StateInsert) //блок для вставки данных 
                {
                    DevRep.InsertDevice(DevNewData);//Вставка данных
                }
                else //обновление данных 
                {
                    if (CodeDevChanged)
                    {
                        tbKey  KeyToHist =  KeyRep.FindKeyByDeviceID(DevOldData.ID);
                        if (KeyToHist != null)
                        { 
                            HistoryF.AddDataToHistory(KeyToHist, "Код устройства изменен");
                        //генерируем новое знач. ключа как требует бизнес логика и обнавляем его
                        KeyToHist.VALUE = KeyF.GetNewValueKey();
                        KeyRep.UpdateKey(KeyToHist);
                        }
                    }
                    //апдетим сам девайс
                    DevNewData.ID = DevOldData.ID;
                    DevRep.UpdateDevice(DevNewData);
                }
                this.Close();
            }
        }

        private bool CompareChanges(tbDevice DevNewData, tbDevice DevOldData)
        {
            return ((DevNewData.CODE_KEY == DevOldData.CODE_KEY) && (DevNewData.ID_ORG == DevOldData.ID_ORG) &&
                     (DevNewData.JOB_POSITION == DevOldData.JOB_POSITION) && (DevNewData.NAME_OWNER == DevOldData.NAME_OWNER));
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
