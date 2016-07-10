using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysManager.UI.MainForms;

namespace KeysManager.UI
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void mOrganization_Click(object sender, EventArgs e)
        {
            if (!FormExist("fmOrganizations"))
            {
                fmOrganizations fmOrg = new fmOrganizations();
                fmOrg.MdiParent = this;
                fmOrg.Show();
            }

        }
        private void mDevices_Click(object sender, EventArgs e)
        {
            if (!FormExist("fmDevices"))
            {
                fmDevices fmOrg = new fmDevices();
                fmOrg.MdiParent = this;
                fmOrg.Show();
            }

        }

        private void mManagerKey_Click(object sender, EventArgs e)
        {
            if (!FormExist("fmKeyList"))
            {
                fmKeyList fmOrg = new fmKeyList();
                fmOrg.MdiParent = this;
                fmOrg.Show();
            }
        }

        private void mUsers_Click(object sender, EventArgs e)
        {
            if (!FormExist("fmUsers"))
            {
                fmUsers fmUser = new fmUsers();
                fmUser.MdiParent = this;
                fmUser.Show();
            }

        }

        private void mGroups_Click(object sender, EventArgs e)
        {
            if (!FormExist("fmGroups"))
            {
                fmGroups fmGroup = new fmGroups();
                fmGroup.MdiParent = this;
                fmGroup.Show();
            }
        }

        private bool FormExist(string fmName)
        {
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.Name == fmName)
                {
                    childForm.BringToFront();
                    return true;
                };
            }
            return false;
        }



        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void VerticalPlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void HorizontalPlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }





        
    }
}
