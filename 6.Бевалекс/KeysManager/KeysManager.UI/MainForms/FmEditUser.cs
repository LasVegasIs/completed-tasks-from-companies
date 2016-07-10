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
    public partial class FmEditUser : Form
    {
        private EFUsersRepository UserRep; //объект репозитория и контекст
        private EFRightsRepository RightRep = new EFRightsRepository();
        private EFGroupsRepository GroupRep = new EFGroupsRepository();
        private EFMemberOfRepository MemberRep = new EFMemberOfRepository(); 

        private int CurIdGroup { get { return (int)dgvUserGroups.SelectedRows[0].Cells["ID"].Value; } } 
        private tbUser UserOldData;//для сравнения знаений входных и выходных данных
        public Boolean StateInsert { get; set; }

        public FmEditUser(EFUsersRepository ur)
        {
            InitializeComponent();
            UserRep = ur;//берем существующй репозиторий и контекст            
            FillDropDownRightsList();//заполняем дроп даун лист
        }

        public FmEditUser(tbUser tbUser, EFUsersRepository ur)
            : this(ur)
        {
            //заполняем поля переданными данными             
            tbLogin.Text = tbUser.LOGIN;
            tbPassword.Text = tbUser.PASSWORD;

           if (tbUser.ID_RIGHT != null) //право может быть не назначено за пользователем
            cbRight.SelectedValue = tbUser.ID_RIGHT;//становимся на выбранную запись организации           

            UserOldData = tbUser;//запоминаем входные данные перед их изменением
        }

        private void FmEditUser_Load(object sender, EventArgs e)
        {
            if (StateInsert)
                this.Text = "Добавление Устройства";
            else
            {
                this.Text = "Изменение Устройства";
            }
            
            tpMemberOf.Parent = StateInsert ? null : tcUsers;
        }

        public void FillDropDownRightsList()
        {
            
            cbRight.DisplayMember = "Description";//Отображаемое значение   
            cbRight.ValueMember = "ID";//Значение для Value
            cbRight.DataSource = RightRep.RightsList.ToList();//к гриду подключаем сорс содержащий значенияорганизаций
            cbRight.SelectedIndex = -1;

        }

        private void tcUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcUsers.SelectedTab.Name == tpMemberOf.Name)
            {
                    if (UserOldData != null)
                    {
                        RefreshUserGroups();
                    }
                }
        }

        private void RefreshUserGroups()
        {
            if (!StateInsert)
            {       
            dgvUserGroups.DataSource = GroupRep.FindGroupsByUserId(UserOldData.ID).ToList();//ищем группы в которые входит пользователь            
            dgvUserGroups.Columns["ID"].Visible = false;//id 
            dgvUserGroups.Columns["NAME"].HeaderText = "Наименоване группы";
            dgvUserGroups.Columns["ID_RIGHT"].Visible = Visible;
            dgvUserGroups.Columns["tbMemberOfs"].Visible = false;
            dgvUserGroups.Columns["tbRight"].Visible = false;       
            dgvUserGroups.Refresh();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bool CheckEr = false;

            tbUser UserNewData = new tbUser();
            //заполняем основные поля
            if (cbRight.SelectedIndex != -1)
             UserNewData.ID_RIGHT = (int)cbRight.SelectedValue;
            UserNewData.LOGIN = tbLogin.Text.Trim();
            UserNewData.PASSWORD = tbPassword.Text.Trim();            

            //если небыло изменений выходим
            if (!StateInsert)
            {
                if (CompareChanges(UserNewData, UserOldData))
                {
                    this.Close();
                    return;
                }
            }

            if (tbLogin.Text == string.Empty)
            {
                epShowError.SetError(tbLogin, "Поле 'Имя пользователя' не может быть пустым.");
                CheckEr = true;
            }

            if (tbPassword.Text == string.Empty)
            {
                epShowError.SetError(tbPassword, "Поле 'Пароль' не может быть пустым.");
                CheckEr = true;
            }

            
            //если нет ошибок то
            if (!CheckEr)
            {

                if (StateInsert) //блок для вставки данных 
                {
                    UserRep.InsertUser(UserNewData);//Вставка данных
                }
                else //обновление данных 
                {                                        
                    //апдетим сам девайс
                    UserNewData.ID = UserOldData.ID;
                    UserRep.UpdateUser(UserNewData);
                }
                this.Close();
            }
        }

        private bool CompareChanges(tbUser UserNewData, tbUser UserOldData)
        {
            return ((UserNewData.ID_RIGHT == UserOldData.ID_RIGHT) && (UserNewData.LOGIN == UserOldData.LOGIN) &&
                (UserNewData.PASSWORD == UserOldData.PASSWORD));
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bAddGroup_Click(object sender, EventArgs e)
        {            
            fmChooseSomeSub fmChoose = new fmChooseSomeSub();            
            fmGroups fGr = new fmGroups();     
      
            fGr.MdiParent = fmChoose;
            fGr.ForSelect = true;
            fGr.Show();

            DialogResult result = fmChoose.ShowDialog();
            //вставка принадлежной группы
            if (result == DialogResult.OK)
            {
                int id = fGr.IdGroup;
                   
                    tbMemberOf tm = new tbMemberOf();
                    tm.ID_GROUP = id;
                    tm.ID_USER = UserOldData.ID;
                    MemberRep.InsertMemberOf(tm);
    
                RefreshUserGroups();

               
            }

        }

        private void bDeleteGroup_Click(object sender, EventArgs e)
        {
            tbMemberOf tm = new tbMemberOf();

            tm = MemberRep.FindByUserIdGroupID(CurIdGroup, UserOldData.ID);
            if (tm != null)
            {            
            MemberRep.DeleteMemberOf(tm);
            RefreshUserGroups();
             }
           
        }

    }
}
