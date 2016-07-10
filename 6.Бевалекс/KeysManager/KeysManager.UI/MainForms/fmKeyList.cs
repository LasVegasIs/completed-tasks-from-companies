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
using KeysManager.Domain.Entities;
using KeysManager.Domain.Concrete;

namespace KeysManager.UI.MainForms
{
    public partial class fmKeyList : Form
    {
        EFKeysRepository KeyRep = new EFKeysRepository();//создаем объект репозитория и контекст        
        public fmKeyList()
        {           
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //dgvKeyList.AutoGenerateColumns = false;//отключаем автогенерацию колонок 
          
        }
        private void fmKeyList_Load(object sender, EventArgs e)
        {
            RefreshData();//загружаем данные из БД            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Создаем и выводим форму вставки данных
            fmEditKeyList fmEditKeyList = new fmEditKeyList(KeyRep);
            fmEditKeyList.StateInsert = true;
            fmEditKeyList.ShowDialog();
            RefreshData();
        }       

        private void deleteButton_Click(object sender, EventArgs e)
        {
            tbKey tKey;

            tKey = (tbKey)dgvKeyList.SelectedRows[0].DataBoundItem;

            if (tKey != null)
            {
                DialogResult r = MessageBox.Show("Вы уверены, что хотите удалить ключ!", "Удаление", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    KeyRep.DeleteKey(tKey);
                    RefreshData();
                }
            }
        }

        //рефреш записей из БД
        private void RefreshData()
        {
            //EFKeysRepository KeyRep = new EFKeysRepository();
            this.dgvKeyList.DataSource = KeyRep.KeysList.ToList();//к гриду подключаем сорс содержащий значения организаций            
            dgvKeyList.Columns["ID"].Visible = false;//id 
            dgvKeyList.Columns["VALUE"].HeaderText = "Значение ключа";
            dgvKeyList.Columns["DATE_START"].HeaderText = "Дата начала периода";
            dgvKeyList.Columns["DATE_END"].HeaderText = "Дата окончания периода";
            dgvKeyList.Columns["TEST"].HeaderText = "Тестовый ключ";
            dgvKeyList.Columns["ID_DEV"].Visible = false;//Id_dev
            dgvKeyList.Columns["tbDevice"].Visible = false; 
            this.dgvKeyList.Refresh();
            this.RefreshHistoryData();       
        }

        //поиск ключа по основным его параметрам
        private void bSerch_Click(object sender, EventArgs e)
        {   //создаем и заполняем объект для поиска 
            tbKey tk = new tbKey();
            tk.VALUE = tbKeyVal.Text;
            tk.DATE_START = dtpStart.Value;
            tk.DATE_END = dtpEnd.Value;
            tk.TEST = cbTest.Checked;
            bool qWithDate = pDates.Enabled;
            //ищем данный тип объекта
            dgvKeyList.DataSource = KeyRep.FilterDataKeys(tk, qWithDate);
        }

        //апдейт
        private void editButton_Click(object sender, EventArgs e)
        {
            var IdKey = dgvKeyList.SelectedRows[0].Cells[0].Value;
            if (IdKey != null)
            {
                fmEditKeyList fmEditKey= new fmEditKeyList(KeyRep.FindKeyById((int)IdKey), KeyRep);
                fmEditKey.StateInsert = false;
                fmEditKey.ShowDialog();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Не выбрана запись. Выберите запись", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bCancelSerch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }



        private void TabConKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabConKey.SelectedTab.Name == tpKeyAdditInfo.Name)
                RefreshAdditInfoData();//загружаем данные из БД 
            if (TabConKey.SelectedTab.Name == tpKeyEdit.Name)
                RefreshData();//загружаем данные из БД 
        }

        private void RefreshAdditInfoData()
        { 
            this.dgvAdditInfo.DataSource = KeyRep.KeysListWithAdditInfo().ToList();//к гриду подключаем сорс содержащий значения организаций          
            dgvAdditInfo.Columns[0].Visible = false;//id     
            this.dgvAdditInfo.Refresh();
        }

        private void RefreshHistoryData()
        {
            var IdKey = dgvKeyList.SelectedRows[0].Cells[0].Value;
            if (IdKey != null)
            {
                EFHistoryChangeKeyValRepository HistRep = new EFHistoryChangeKeyValRepository();//создаем объект репозитория и контекст
                this.dgvHistList.DataSource = HistRep.HistoryByIdKey((int)IdKey).ToList();//к гриду подключаем сорс содержащий значения организаций          
                dgvHistList.Columns["ID"].Visible = false;//id 
                dgvHistList.Columns["ID_KEY"].Visible = false;//id 
                dgvHistList.Columns["ID_DEV"].Visible = false;//id 
                dgvHistList.Columns["VALUE"].HeaderText = "Значение ключа";
                dgvHistList.Columns["DATE_START"].HeaderText = "Дата начала периода";
                dgvHistList.Columns["DATE_END"].HeaderText = "Дата окончания периода";
                dgvHistList.Columns["TEST"].HeaderText = "Тестовый ключ";
                dgvHistList.Columns["CAUSE"].HeaderText = "Причина";
                dgvHistList.Columns["MODIFY_DATE"].HeaderText = "Дата изменения";
                this.dgvHistList.Refresh();     

            }
        }

        private void cbEnableDatePanel_CheckedChanged(object sender, EventArgs e)
        {
            pDates.Enabled = cbEnableDatePanel.Checked;
        }

        private void dgvKeyList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvKeyList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshHistoryData();
        }

        private void fmKeyList_Resize(object sender, EventArgs e)
        {
            lHistory.Left = this.Width / 2 - lHistory.Width / 2;//центрируем лабел

        }

    }
}
