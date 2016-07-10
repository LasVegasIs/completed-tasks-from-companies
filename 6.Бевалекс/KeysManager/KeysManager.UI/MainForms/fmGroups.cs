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
    public partial class fmGroups : Form
    {
        EFGroupsRepository GroupRep = new EFGroupsRepository();//создаем объект репозитория и контекст
        public Boolean ForSelect { get { return tsGroups.Visible; } set { tsGroups.Visible = !value; } }
        public int IdGroup { get { return (int)dgvGroups.SelectedRows[0].Cells["ID"].Value; } }
        public fmGroups()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void fmGroups_Load(object sender, EventArgs e)
        {
            RefreshData();//загружаем данные из БД
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Создаем и выводим форму редактировния           
            fmEditGroup fmEditGroup = new fmEditGroup(GroupRep);
            fmEditGroup.StateInsert = true;
            fmEditGroup.ShowDialog();
            RefreshData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            tbGroup Group;

            Group = (tbGroup)dgvGroups.SelectedRows[0].DataBoundItem;

            if (Group != null)
            {
                DialogResult r = MessageBox.Show("Вы уверены, что хотите удалить группу!", "Удаление", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    GroupRep.DeleteGroup(Group);
                    RefreshData();
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var IdGroup = dgvGroups.SelectedRows[0].Cells["ID"].Value;
            if (IdGroup != null)
            {
                fmEditGroup fmEditGroup = new fmEditGroup(GroupRep.FindGroupById((int)IdGroup), GroupRep);
                fmEditGroup.StateInsert = false;
                fmEditGroup.ShowDialog();
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
            this.dgvGroups.DataSource = GroupRep.GroupsList.ToList();//к гриду подключаем сорс содержащий значения организаций            
            dgvGroups.Columns["ID"].Visible = false;//id 
            dgvGroups.Columns["NAME"].HeaderText = "Наименование";
            dgvGroups.Columns["ID_RIGHT"].HeaderText = "ID права";
            dgvGroups.Columns["tbMemberOfs"].Visible = false;
            dgvGroups.Columns["tbRight"].Visible = false;
            this.dgvGroups.Refresh();
        }

    }
}
