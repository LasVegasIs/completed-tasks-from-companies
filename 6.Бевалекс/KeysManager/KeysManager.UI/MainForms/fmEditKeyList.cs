using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Concrete;
using KeysManager.Domain.Concrete;
using KeysManager.Domain.Entities;
using KeysManager.UI.PublicFunctions;

namespace KeysManager.UI.MainForms
{
    public partial class fmEditKeyList : Form
    {        
        private EFKeysRepository KeyRep; 
        private EFOrganizationsRepository OrgRep = new EFOrganizationsRepository();//репозиторий для заполнени выпадающего меню Организаций
        private EFDevicesRepository DevRep = new EFDevicesRepository();//репозиторий для заполнени выпадающего меню Устрйств
       
        tbKey KeyOldData;//для сравнения знаений входных и выходных данных
        //private DateTime dateEndOld = DateTime.MaxValue;
        //св-во для проверки состояния вставка/обновление
        public Boolean StateInsert {get; set;}

        //св-во для проверки продлевается ли ключ
        //Boolean prolong;        
        private Boolean Prolong { get { return ((KeyOldData.DATE_END < dtpDateEnd.Value) && (!StateInsert)); } set {} }       
        

        public fmEditKeyList(EFKeysRepository kr)
        {
            InitializeComponent();          
            KeyRep = kr;//берем существующй репозиторий и контекст
            FillDropDownOrgList();//заполняем дроп даун лист Org
            FillDropDownDevList();//заполняем дроп даун лист Dev
        }

        
        public fmEditKeyList(tbKey tkey, EFKeysRepository kr)
            : this(kr)
        {   
            
            //заполняем поля переданными данными             
            KeyOldData = tkey;
            //заполнение компонентов текущим значениями
            tbDevice td = DevRep.FindDeviceById(tkey.ID_DEV);//находим устройство с нашим айди

            cbNameOrg.SelectedValue = td.ID_ORG;//становимся на выбранную запись организации за которым закреплено данное устройство
            FillDropDownDevList();//заполняем дроп даун лист Dev новыми значениями в зависимости от выбранной организации
            cbCodeDev.SelectedValue = tkey.ID_DEV;//становимся на выбранную запись устройства
            dtpDateStart.Value = tkey.DATE_START;
            dtpDateEnd.Value = tkey.DATE_END;
            cbTest.Checked = tkey.TEST;
            tbCodeKey.Text = tkey.VALUE;
            
        }

        private void fmEditKeyList_Load(object sender, EventArgs e)
        {
            if (StateInsert)
                this.Text = "Добавление Ключа";
            else
            {
                this.Text = "Изменение Ключа";
                cbNameOrg.Enabled = false;//если меняем ключ то закрепленное устройство мы менять не можем
                cbCodeDev.Enabled = false;
            }
        }

        public void FillDropDownOrgList()
        {
            cbNameOrg.DisplayMember = "NAME";//Отображаемое значение   
            cbNameOrg.ValueMember = "ID";//Значение для Value            
            cbNameOrg.DataSource = OrgRep.OrganizationsList.ToList();//к гриду подключаем сорс содержащий значения организаций

        }

        public void FillDropDownDevList()
        {
            cbCodeDev.DisplayMember = "CODE_KEY";//Отображаемое значение   
            cbCodeDev.ValueMember = "ID";//Значение для Value
            IEnumerable<tbDevice> tbl = DevRep.DevicesLisByOrganization((int)cbNameOrg.SelectedValue);
            cbCodeDev.DataSource = tbl.ToList();
            //cbCodeDev.DataSource = tbl;
            if (tbl.Count() != 0)
                cbCodeDev.DataSource = tbl.ToList();
            else
            {
                cbCodeDev.DataSource = null;
                cbCodeDev.Text = string.Empty;
            }

        }

        //вставка/редактирование записи
        private void bSave_Click(object sender, EventArgs e)
        {
            tbKey KeyNewData = new tbKey();
            //заполняем основные поля апдейта/вставки записи                  
            KeyNewData.DATE_START = dtpDateStart.Value;
            KeyNewData.DATE_END = dtpDateEnd.Value;
            KeyNewData.TEST = cbTest.Checked;
            KeyNewData.ID_DEV = (int)cbCodeDev.SelectedValue;
            KeyNewData.VALUE = tbCodeKey.Text;

            //если небыло изменений выходим
            if (!StateInsert)
            { 
                if (CompareChanges(KeyNewData,KeyOldData))
                { 
                    this.Close();
                    return;
                }
            }
               

            bool CheckEr = false;

            if (cbNameOrg.Text == string.Empty)
            {
                epShowError.SetError(cbNameOrg, "Поле 'Наименование Организации' не может быть пустым.");
                CheckEr = true;
            }

            if (cbCodeDev.Text == string.Empty)
            {
                epShowError.SetError(cbCodeDev, "Поле 'Код устройства' не может быть пустым.");
                CheckEr = true;
            }

            if (dtpDateStart.Text == string.Empty)
            {
                epShowError.SetError(dtpDateStart, "Поле 'Дата начала периода ' не может быть пустым.");
                CheckEr = true;
            }

            if (dtpDateEnd.Text == string.Empty)
            {
                epShowError.SetError(dtpDateEnd, "Поле 'Дата окончания периода' не может быть пустым.");
                CheckEr = true;
            }

            //проверка условий при вставке
            if (StateInsert)
            {
                int idOrg = (int)cbNameOrg.SelectedValue;
                tbOrganization tbo = OrgRep.FindOrganizationById(idOrg);

                int keysByOrg = KeyRep.CountLicKeysByOrganization(idOrg);

                //проверка на лимит лиц. ключей за организацией
                if ((tbo.LIM_KEYS == keysByOrg) && (!cbTest.Checked))
                {
                    epShowError.SetError(cbNameOrg, "Количество лицензионных ключей для данной организации исчерпано!");
                    CheckEr = true;
                }

                int CountDev = DevRep.CountDevicesByOrganization((int)cbNameOrg.SelectedValue);
                if (CountDev == 0)
                {
                    epShowError.SetError(cbNameOrg, "Вы не можете назначить ключ т.к за данной организацией нет устройств!");
                    CheckEr = true;
                }

                int keysByDev = KeyRep.CountKeyByDevice((int)cbCodeDev.SelectedValue);

                //за устройством может быть только 1 ключ
                if (keysByDev == 1)
                {
                    epShowError.SetError(cbCodeDev, "За данным устройством уже закреплен ключ!");
                    CheckEr = true;
                }
            }
            else //проверки при обновлении
            {
                if ((KeyOldData.TEST) && (!KeyNewData.TEST))//если пытаемся изменить ключ на лицензионный
                {
                    if ((Prolong) && (tbCause.Text == string.Empty))
                    {
                        epShowError.SetError(tbCause, "Необходимо заполнить причину продления ключа!");
                        CheckEr = true;
                    }

                    int idOrg = (int)cbNameOrg.SelectedValue;
                    int keysByOrg = KeyRep.CountLicKeysByOrganization(idOrg);
                    tbOrganization tbo = OrgRep.FindOrganizationById(idOrg);
                    //проверка на лимит лиц. ключей за организацией
                    if ((tbo.LIM_KEYS == keysByOrg) && (!cbTest.Checked))
                    {
                        epShowError.SetError(cbNameOrg, "Количество лицензионных ключей для данной организации исчерпано!");
                        CheckEr = true;
                    }
                 }
             }

            //если нет ошибок то
            if (!CheckEr)
            {             
               if (StateInsert) //блок для вставки данных 
                {
                    KeyNewData.VALUE = KeyF.GetNewValueKey();
                    KeyRep.InsertKey(KeyNewData);//Вставка данных
                }
                else //блок для апдейта данных 
               {
                   if (Prolong)// меняем значение ключа если продлеваем его действие
                   {
                       KeyNewData.VALUE = KeyF.GetNewValueKey();

                       //заполнение данных для истории                     
                       HistoryF.AddDataToHistory(KeyOldData, "Продлен по причине - " + tbCause.Text.Trim());//запись старого значения в историю
                   }

                   KeyNewData.ID = KeyOldData.ID;
                   KeyRep.UpdateKey(KeyNewData);                                       
                  
                }
                this.Close();
            }
        }



        private bool CompareChanges(tbKey KeyNew, tbKey KeyOld)
        {
            bool b = ((KeyNew.VALUE == KeyOld.VALUE) && (KeyNew.DATE_START == KeyOld.DATE_START) &&
                (KeyNew.DATE_START == KeyOld.DATE_START) && (KeyNew.DATE_END == KeyOld.DATE_END) &&
                 (KeyNew.TEST == KeyOld.TEST) && (KeyNew.ID_DEV == KeyOld.ID_DEV));
           return b;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbNameOrg_DropDownClosed(object sender, EventArgs e)
        {
            FillDropDownDevList();
        }

        //В случае изменения даты отображаем поле причины ее изменения 
        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
          if (!StateInsert)
          { 
            if (Prolong)
            {
                lCause.Visible = true;
                tbCause.Visible = true;
            }
          }
        }



    }
}
