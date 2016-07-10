using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysManager.Domain.Concrete;
using KeysManager.Domain.Entities;

namespace KeysManager.UI.MainForms
{
    public partial class fmEditGroup : Form
    {
        private EFGroupsRepository GroupRep; //объект репозитория и контекст
        private EFRightsRepository RightRep = new EFRightsRepository();

        private tbGroup GroupOldData;//для сравнения знаений входных и выходных данных
        public Boolean StateInsert { get; set; }
        public fmEditGroup(EFGroupsRepository gr)
        {
            InitializeComponent();
            GroupRep = gr;//берем существующй репозиторий и контекст
            FillDropDownRightsList();//заполняем дроп даун лист
        }

        public fmEditGroup(tbGroup tbGroup, EFGroupsRepository gr)
            : this(gr)
        {
            //заполняем поля переданными данными             
            tbNameGroup.Text = tbGroup.NAME;            
            cbRight.SelectedValue = tbGroup.ID_RIGHT;//становимся на выбранную запись организации

            GroupOldData = tbGroup;//запоминаем входные данные перед их изменением
        }

        private void fmEditGroup_Load(object sender, EventArgs e)
        {
            if (StateInsert)
                this.Text = "Добавление Устройства";
            else
            {
                this.Text = "Изменение Устройства";
            }
        }

        public void FillDropDownRightsList()
        {

            cbRight.DisplayMember = "Description";//Отображаемое значение   
            cbRight.ValueMember = "ID";//Значение для Value
            cbRight.DataSource = RightRep.RightsList.ToList();//к гриду подключаем сорс содержащий значенияорганизаций
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bool CheckEr = false;

            tbGroup GroupNewData = new tbGroup();
            //заполняем основные поля
            GroupNewData.ID_RIGHT = (int)cbRight.SelectedValue;
            GroupNewData.NAME = tbNameGroup.Text.Trim();           

            //если небыло изменений выходим
            if (!StateInsert)
            {
                if (CompareChanges(GroupNewData, GroupOldData))
                {
                    this.Close();
                    return;
                }
            }

            if (tbNameGroup.Text == string.Empty)
            {
                epShowError.SetError(tbNameGroup, "Поле 'Наименование' не может быть пустым.");
                CheckEr = true;
            }

            if (cbRight.Text == string.Empty)
            {
                epShowError.SetError(cbRight, "Поле 'Право' не может быть пустым.");
                CheckEr = true;
            }


            //если нет ошибок то
            if (!CheckEr)
            {

                if (StateInsert) //блок для вставки данных 
                {
                    GroupRep.InsertGroup(GroupNewData);//Вставка данных
                }
                else //обновление данных 
                {
                    //апдетим сам девайс
                    GroupNewData.ID = GroupOldData.ID;
                    GroupRep.UpdateGroup(GroupNewData);
                }
                this.Close();
            }
        }

        private bool CompareChanges(tbGroup GroupNewData, tbGroup GroupOldData)
        {
            return ((GroupNewData.ID_RIGHT == GroupOldData.ID_RIGHT) && (GroupNewData.NAME == GroupOldData.NAME));
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
