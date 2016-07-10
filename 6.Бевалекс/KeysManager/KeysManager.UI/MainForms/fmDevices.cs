using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysManager.Domain.Entities;

namespace KeysManager.UI.MainForms
{
    public partial class fmDevices : Form
    {
        EFDevicesRepository DevRep = new EFDevicesRepository();//создаем объект репозитория и контекст
        public fmDevices()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void fmDevices_Load(object sender, EventArgs e)
        {
            RefreshData();//загружаем данные из БД
        }

        //добавление записи
        private void addButton_Click(object sender, EventArgs e)
        {
            //Создаем и выводим форму редактировния           
            fmEditDevice fmEditDev = new fmEditDevice(DevRep);
            fmEditDev.StateInsert = true;
            fmEditDev.ShowDialog();
            RefreshData();
        }      

        //удаление записи
        private void deleteButton_Click(object sender, EventArgs e)
        {
            tbDevice Device;

            Device = (tbDevice)dgvDevice.SelectedRows[0].DataBoundItem;

            if (Device != null)
            {
                DialogResult r = MessageBox.Show("Вы уверены, что хотите удалить устройство!", "Удаление", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    DevRep.DeleteDevice(Device);
                    RefreshData();
                }
            }
        }

        //редактирование записи
        private void editButton_Click(object sender, EventArgs e)
        {
            var IdDev = dgvDevice.SelectedRows[0].Cells[0].Value;
            if (IdDev != null)
            {
                fmEditDevice fmEditDev = new fmEditDevice(DevRep.FindDeviceById((int)IdDev), DevRep);
                fmEditDev.StateInsert = false;
                fmEditDev.ShowDialog();
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
            this.dgvDevice.DataSource = DevRep.DevicesList.ToList();//к гриду подключаем сорс содержащий значения организаций            
            dgvDevice.Columns["ID"].Visible = false;//id 
            dgvDevice.Columns["CODE_KEY"].HeaderText = "Код ключа устройства";
            dgvDevice.Columns["NAME_OWNER"].HeaderText = "Фамилия владельца устройства";
            dgvDevice.Columns["JOB_POSITION"].HeaderText = "Должность владельца устройства";
            dgvDevice.Columns["ID_ORG"].Visible = false;
            dgvDevice.Columns["tbOrganization"].Visible = false;
            dgvDevice.Columns["tbKeys"].Visible = false;
            this.dgvDevice.Refresh();
        }

    }
}
