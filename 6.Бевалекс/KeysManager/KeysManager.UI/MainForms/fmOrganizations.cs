using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysManager.Domain;
using Domain.Concrete;
using KeysManager.Domain.Entities;


namespace KeysManager.UI.MainForms
{
    public partial class fmOrganizations : Form
    {
        EFOrganizationsRepository OrgRep = new EFOrganizationsRepository();//создаем объект репозитория и контекст
        public fmOrganizations()
        {
            InitializeComponent();            
        }

        private void fmOrganizations_Load(object sender, EventArgs e)
        {
            RefreshData();//загружаем данные из БД            
        }
        
        //вставка записи
        private void addButton_Click(object sender, EventArgs e)
        {   //Создаем и выводим форму редактировния
            fmEditOrganization fmEditOrg = new fmEditOrganization(OrgRep);            
            fmEditOrg.ShowDialog();
            RefreshData();
        }

        //удаление записи
        private void deleteButton_Click(object sender, EventArgs e)
        {
            tbOrganization Organization;

            Organization = (tbOrganization)dgvOrganization.SelectedRows[0].DataBoundItem;

            if (Organization != null)
            {               
                DialogResult r = MessageBox.Show("Вы уверены, что хотите удалить организацию!","Удаление", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    OrgRep.DeleteOrganization(Organization);                    
                    RefreshData();
                }
            }
        }

        //Изменение записи
        private void editButton_Click(object sender, EventArgs e)
        {           
            var IdOrg = dgvOrganization.SelectedRows[0].Cells[0].Value;
            if (IdOrg != null)
            {
                fmEditOrganization fmEditOrg = new fmEditOrganization(OrgRep.FindOrganizationById((int)IdOrg), OrgRep);
                fmEditOrg.ShowDialog();
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
            this.dgvOrganization.DataSource = OrgRep.OrganizationsList.ToList();//к гриду подключаем сорс содержащий значения организаций            
            dgvOrganization.Columns["ID"].Visible = false;//id 
            dgvOrganization.Columns["NAME"].HeaderText = "Название организации";
            dgvOrganization.Columns["NUM_CONTR"].HeaderText = "Номер договора";
            dgvOrganization.Columns["LIM_KEYS"].HeaderText = "Лимит ключей";
            dgvOrganization.Columns["tbDevices"].Visible = false;
            this.dgvOrganization.Refresh();
            this.RefreshKeysStatData();        
        }

        private void RefreshKeysStatData()
        {
            var idOrg = dgvOrganization.SelectedRows[0].Cells[0].Value;
            if (idOrg != null)
            {
                EFKeysRepository KeyRep = new EFKeysRepository();//создаем объект репозитория и контекст
                this.dgvStatKeys.DataSource = KeyRep.StatKeysByOrg((int)idOrg).ToList();//к гриду подключаем сорс содержащий значения организаций             
                this.dgvStatKeys.Refresh();
            }
        }         

        private void dgvOrganization_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshKeysStatData();
        }

        private void fmOrganizations_Resize(object sender, EventArgs e)
        {
            lKeyStat.Left = lKeyStat.Left = this.Width / 2 - lKeyStat.Width / 2;//центрируем лабел
        }
    }
}
