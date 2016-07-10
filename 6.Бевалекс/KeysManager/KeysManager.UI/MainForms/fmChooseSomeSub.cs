using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysManager.UI.MainForms
{  
    public partial class fmChooseSomeSub : Form
    {
        
      
        public fmChooseSomeSub()
        {
            InitializeComponent();
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fmChooseSomeSub_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }
    }
}
