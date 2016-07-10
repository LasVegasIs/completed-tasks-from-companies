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
    public partial class fmEditOrganization : Form
    {
        private tbOrganization Org;
        private EFOrganizationsRepository OrgRep; //= new EFOrganizationsRepository();//создаем объект репозитория и контекст
        private Boolean StateInsert = true;
        private int IdOrg = 0;
        public fmEditOrganization(EFOrganizationsRepository or)
        {
            InitializeComponent();
            this.Text = "Добавление Организации";
            OrgRep = or;//берем существующй репозиторий и контекст
        }

        public fmEditOrganization(tbOrganization Org, EFOrganizationsRepository or)//еще один конструктор для обновления данных
            :this(or)
        {
           this.Text = "Изменение Организации";
           StateInsert = false;
           //заполняем поля переданными данными 
           IdOrg = Org.ID;
           tbName.Text = Org.NAME;
           tbNumberOfContr.Text = Org.NUM_CONTR;
           tbLimitKeys.Text = Org.LIM_KEYS.ToString();
             
        }
  
        //вставка/изменение - сохранение
        private void bSave_Click(object sender, EventArgs e)
        {
            bool CheckEr = false;



            if (tbName.Text == string.Empty)
            {
                epShowError.SetError(tbName, "Поле 'Наименование организации' не может быть пустым.");
                CheckEr = true;
            }

            if (tbNumberOfContr.Text == string.Empty)
            {
                epShowError.SetError(tbNumberOfContr, "Поле 'Количество контрактов' не может быть пустым.");
                CheckEr = true;
            }

            if (tbLimitKeys.Text == string.Empty)
            {
                epShowError.SetError(tbLimitKeys, "Поле 'Лимит Ключей' не может быть пустым.");
                CheckEr = true;
            }
            //если нет ошибок то
            if (!CheckEr)
            {
                if (Org == null) Org = new tbOrganization();
                //заполняем основные поля
                Org.NAME = tbName.Text.Trim();
                Org.NUM_CONTR = tbNumberOfContr.Text.Trim();
                Org.LIM_KEYS = int.Parse(tbLimitKeys.Text);

                if (StateInsert) //блок для вставки данных 
                {            
                   
                    OrgRep.InsertOrganization(Org);//Вставка данных
                        
                 }
                else 
                {
                    Org.ID = IdOrg;
                    OrgRep.UpdateOrganization(Org);
                }                
                this.Close();
            }
        }

        //проверка что можно вводить только числа
        private void tbNumberOfContr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
