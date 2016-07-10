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
    public partial class fmUsers : Form
    {
        EFUsersRepository UserRep = new EFUsersRepository();//создаем объект репозитория и контекст
        public fmUsers()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void fmUsers_Load(object sender, EventArgs e)
        {
            RefreshData();//загружаем данные из БД
        }

        //добавление записи
        private void addButton_Click(object sender, EventArgs e)
        {
            //Создаем и выводим форму редактировния           
            FmEditUser fmEditUser = new FmEditUser(UserRep);
            fmEditUser.StateInsert = true;
            fmEditUser.ShowDialog();
            RefreshData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            tbUser User;

            User = (tbUser)dgvUsers.SelectedRows[0].DataBoundItem;

            if (User != null)
            {
                DialogResult r = MessageBox.Show("Вы уверены, что хотите удалить пользователя!", "Удаление", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    UserRep.DeleteUser(User);
                    RefreshData();
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var IdUser = dgvUsers.SelectedRows[0].Cells[0].Value;
            if (IdUser != null)
            {
                FmEditUser fmEditUser = new FmEditUser(UserRep.FindUserById((int)IdUser), UserRep);
                fmEditUser.StateInsert = false;
                fmEditUser.ShowDialog();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Не выбрана запись. Выберите запись", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //рефреш записей из БД
        private void RefreshData()
        {        
            this.dgvUsers.DataSource = UserRep.UsersList.ToList();//к гриду подключаем сорс содержащий значения организаций            
            dgvUsers.Columns["ID"].Visible = false;//id 
            dgvUsers.Columns["LOGIN"].HeaderText = "Логин";
            dgvUsers.Columns["PASSWORD"].HeaderText = "Пароль";
            dgvUsers.Columns["ID_RIGHT"].HeaderText = "ID права";
            dgvUsers.Columns["tbRight"].Visible = false;            
            this.dgvUsers.Refresh();
        }




    }
}
