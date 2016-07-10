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
    public partial class fmLoginForm : Form
    {
        private EFUsersRepository UserRep = new EFUsersRepository(); //объект репозитория и контекст
        public fmLoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                tbUser tu = UserRep.FindUserByName(tbUserr.Text.Trim());
                if (tu != null)
                {
                    if (tu.LOGIN != tbUserr.Text.Trim())
                    {
                        this.DialogResult = DialogResult.Ignore;
                        MessageBox.Show("Введен неверный логин.");
                        return;
                    }

                    if (tu.PASSWORD != tbPassword.Text.Trim())
                    {
                        this.DialogResult = DialogResult.Ignore;
                        MessageBox.Show("Введен неверный пароль.");
                        return;
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Ignore;
                }

                    //WriteServer(cbServer.Text);
                    //WriteLogin(cbUser.Text.Trim());

                    //SetDefaultRegistry();

                    //EmployeesRes = User.FindTrueAuthorization(cbUser.Text.Trim(), tbPassword.Text.Trim());
                    //User.UserId = EmployeesRes.EmployeeID;
                    //User.UserName = EmployeesRes.EmployeeName;
                    //User.UserFirstName = EmployeesRes.EmployeeFirstName;
                    //User.UserPatronymic = EmployeesRes.EmployeePatronymic;
                    //User.UserCategoryID = EmployeesRes.EmployeeCategoryID;
                    //User.UserLogin = EmployeesRes.EmployeeLogin;

                    this.DialogResult = DialogResult.OK;
                
            }
        }

        bool CheckFields()
        {
            bool result = true;
            if (string.Compare(tbUserr.Text.Trim(), string.Empty) == 0 ||
                string.Compare(tbPassword.Text.Trim(), string.Empty) == 0) result = false;
            errorProvider1.SetError(label1,
                string.Compare(tbUserr.Text.Trim(), string.Empty) == 0 ?
                        "Поле не должно быть пустым" :
                        string.Empty);
            errorProvider1.SetError(label2,
                string.Compare(tbPassword.Text.Trim(), string.Empty) == 0 ?
                        "Поле не должно быть пустым" :
                        string.Empty);
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
