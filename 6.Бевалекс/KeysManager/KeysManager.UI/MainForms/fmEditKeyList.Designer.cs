namespace KeysManager.UI.MainForms
{
    partial class fmEditKeyList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCause = new System.Windows.Forms.TextBox();
            this.lCause = new System.Windows.Forms.Label();
            this.cbTest = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCodeDev = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodeKey = new System.Windows.Forms.TextBox();
            this.cbNameOrg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.epShowError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epShowError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbCause);
            this.panel1.Controls.Add(this.lCause);
            this.panel1.Controls.Add(this.cbTest);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpDateEnd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpDateStart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbCodeDev);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbCodeKey);
            this.panel1.Controls.Add(this.cbNameOrg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 259);
            this.panel1.TabIndex = 19;
            // 
            // tbCause
            // 
            this.tbCause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCause.Location = new System.Drawing.Point(127, 185);
            this.tbCause.Name = "tbCause";
            this.tbCause.Size = new System.Drawing.Size(210, 20);
            this.tbCause.TabIndex = 42;
            this.tbCause.Visible = false;
            // 
            // lCause
            // 
            this.lCause.AutoSize = true;
            this.lCause.Location = new System.Drawing.Point(8, 192);
            this.lCause.Name = "lCause";
            this.lCause.Size = new System.Drawing.Size(107, 13);
            this.lCause.TabIndex = 41;
            this.lCause.Text = "Причина продления";
            this.lCause.Visible = false;
            // 
            // cbTest
            // 
            this.cbTest.AutoSize = true;
            this.cbTest.Location = new System.Drawing.Point(11, 162);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(104, 17);
            this.cbTest.TabIndex = 39;
            this.cbTest.Text = "Тестовый ключ";
            this.cbTest.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 26);
            this.label8.TabIndex = 38;
            this.label8.Text = "Дата окончания\r\nпериода";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateEnd.Location = new System.Drawing.Point(127, 125);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(210, 20);
            this.dtpDateEnd.TabIndex = 37;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Дата начала периода";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateStart.Location = new System.Drawing.Point(127, 87);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(210, 20);
            this.dtpDateStart.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Код устройства";
            // 
            // cbCodeDev
            // 
            this.cbCodeDev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCodeDev.FormattingEnabled = true;
            this.cbCodeDev.Location = new System.Drawing.Point(127, 51);
            this.cbCodeDev.Name = "cbCodeDev";
            this.cbCodeDev.Size = new System.Drawing.Size(210, 21);
            this.cbCodeDev.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Организация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Значение ключа генерится автоматически";
            this.label3.Visible = false;
            // 
            // tbCodeKey
            // 
            this.tbCodeKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodeKey.Location = new System.Drawing.Point(142, 221);
            this.tbCodeKey.Name = "tbCodeKey";
            this.tbCodeKey.Size = new System.Drawing.Size(189, 20);
            this.tbCodeKey.TabIndex = 1;
            this.tbCodeKey.Visible = false;
            // 
            // cbNameOrg
            // 
            this.cbNameOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNameOrg.FormattingEnabled = true;
            this.cbNameOrg.Location = new System.Drawing.Point(127, 14);
            this.cbNameOrg.Name = "cbNameOrg";
            this.cbNameOrg.Size = new System.Drawing.Size(210, 21);
            this.cbNameOrg.TabIndex = 30;
            this.cbNameOrg.DropDownClosed += new System.EventHandler(this.cbNameOrg_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(306, 287);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 21;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(225, 287);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 20;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // epShowError
            // 
            this.epShowError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epShowError.ContainerControl = this;
            // 
            // fmEditKeyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 322);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.panel1);
            this.Name = "fmEditKeyList";
            this.Text = "fmEditKeyList";
            this.Load += new System.EventHandler(this.fmEditKeyList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epShowError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNameOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCodeDev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodeKey;
        private System.Windows.Forms.CheckBox cbTest;
        private System.Windows.Forms.ErrorProvider epShowError;
        private System.Windows.Forms.TextBox tbCause;
        private System.Windows.Forms.Label lCause;
    }
}