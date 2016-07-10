namespace KeysManager.UI.MainForms
{
    partial class FmEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcUsers = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.cbRight = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tpMemberOf = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bDeleteGroup = new System.Windows.Forms.Button();
            this.bAddGroup = new System.Windows.Forms.Button();
            this.dgvUserGroups = new System.Windows.Forms.DataGridView();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.epShowError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcUsers.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpMemberOf.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroups)).BeginInit();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epShowError)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsers
            // 
            this.tcUsers.Controls.Add(this.tpGeneral);
            this.tcUsers.Controls.Add(this.tpMemberOf);
            this.tcUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsers.Location = new System.Drawing.Point(0, 0);
            this.tcUsers.Name = "tcUsers";
            this.tcUsers.SelectedIndex = 0;
            this.tcUsers.Size = new System.Drawing.Size(420, 319);
            this.tcUsers.TabIndex = 0;
            this.tcUsers.SelectedIndexChanged += new System.EventHandler(this.tcUsers_SelectedIndexChanged);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.panel1);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(412, 293);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Основные";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.cbRight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 287);
            this.panel1.TabIndex = 19;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(26, 24);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(103, 13);
            this.lName.TabIndex = 32;
            this.lName.Text = "Имя пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Location = new System.Drawing.Point(148, 17);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(233, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // cbRight
            // 
            this.cbRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRight.FormattingEnabled = true;
            this.cbRight.Location = new System.Drawing.Point(148, 88);
            this.cbRight.Name = "cbRight";
            this.cbRight.Size = new System.Drawing.Size(233, 21);
            this.cbRight.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Право";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(148, 52);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(233, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tpMemberOf
            // 
            this.tpMemberOf.Controls.Add(this.panel2);
            this.tpMemberOf.Controls.Add(this.dgvUserGroups);
            this.tpMemberOf.Location = new System.Drawing.Point(4, 22);
            this.tpMemberOf.Name = "tpMemberOf";
            this.tpMemberOf.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberOf.Size = new System.Drawing.Size(412, 293);
            this.tpMemberOf.TabIndex = 1;
            this.tpMemberOf.Text = "Членство в группах";
            this.tpMemberOf.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bDeleteGroup);
            this.panel2.Controls.Add(this.bAddGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 64);
            this.panel2.TabIndex = 11;
            // 
            // bDeleteGroup
            // 
            this.bDeleteGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteGroup.Location = new System.Drawing.Point(110, 3);
            this.bDeleteGroup.Name = "bDeleteGroup";
            this.bDeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.bDeleteGroup.TabIndex = 21;
            this.bDeleteGroup.Text = "Удалить";
            this.bDeleteGroup.UseVisualStyleBackColor = true;
            this.bDeleteGroup.Click += new System.EventHandler(this.bDeleteGroup_Click);
            // 
            // bAddGroup
            // 
            this.bAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddGroup.Location = new System.Drawing.Point(29, 3);
            this.bAddGroup.Name = "bAddGroup";
            this.bAddGroup.Size = new System.Drawing.Size(75, 23);
            this.bAddGroup.TabIndex = 20;
            this.bAddGroup.Text = "Добавить";
            this.bAddGroup.UseVisualStyleBackColor = true;
            this.bAddGroup.Click += new System.EventHandler(this.bAddGroup_Click);
            // 
            // dgvUserGroups
            // 
            this.dgvUserGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserGroups.Location = new System.Drawing.Point(3, 3);
            this.dgvUserGroups.MultiSelect = false;
            this.dgvUserGroups.Name = "dgvUserGroups";
            this.dgvUserGroups.ReadOnly = true;
            this.dgvUserGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserGroups.Size = new System.Drawing.Size(406, 287);
            this.dgvUserGroups.TabIndex = 10;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bCancel);
            this.pButtons.Controls.Add(this.bSave);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 278);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(420, 41);
            this.pButtons.TabIndex = 1;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(333, 6);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 19;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(252, 6);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // epShowError
            // 
            this.epShowError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epShowError.ContainerControl = this;
            // 
            // FmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 319);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.tcUsers);
            this.Name = "FmEditUser";
            this.Text = "FmEditUser";
            this.Load += new System.EventHandler(this.FmEditUser_Load);
            this.tcUsers.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpMemberOf.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroups)).EndInit();
            this.pButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epShowError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUsers;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpMemberOf;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.ComboBox cbRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.DataGridView dgvUserGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bDeleteGroup;
        private System.Windows.Forms.Button bAddGroup;
        private System.Windows.Forms.ErrorProvider epShowError;

    }
}