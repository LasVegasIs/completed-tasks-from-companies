namespace KeysManager.UI.MainForms
{
    partial class fmKeyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmKeyList));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TabConKey = new System.Windows.Forms.TabControl();
            this.tpKeyEdit = new System.Windows.Forms.TabPage();
            this.spSerch = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.spHistory = new System.Windows.Forms.Splitter();
            this.pHistory = new System.Windows.Forms.Panel();
            this.dgvHistList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lHistory = new System.Windows.Forms.Label();
            this.dgvKeyList = new System.Windows.Forms.DataGridView();
            this.pSerch = new System.Windows.Forms.Panel();
            this.cbEnableDatePanel = new System.Windows.Forms.CheckBox();
            this.pDates = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.bCancelSerch = new System.Windows.Forms.Button();
            this.cbTest = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.tbKeyVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSerch = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.tpKeyAdditInfo = new System.Windows.Forms.TabPage();
            this.dgvAdditInfo = new System.Windows.Forms.DataGridView();
            this.TabConKey.SuspendLayout();
            this.tpKeyEdit.SuspendLayout();
            this.pHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyList)).BeginInit();
            this.pSerch.SuspendLayout();
            this.pDates.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tpKeyAdditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // TabConKey
            // 
            this.TabConKey.Controls.Add(this.tpKeyEdit);
            this.TabConKey.Controls.Add(this.tpKeyAdditInfo);
            this.TabConKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabConKey.Location = new System.Drawing.Point(0, 0);
            this.TabConKey.Name = "TabConKey";
            this.TabConKey.SelectedIndex = 0;
            this.TabConKey.Size = new System.Drawing.Size(845, 346);
            this.TabConKey.TabIndex = 10;
            this.TabConKey.SelectedIndexChanged += new System.EventHandler(this.TabConKey_SelectedIndexChanged);
            // 
            // tpKeyEdit
            // 
            this.tpKeyEdit.Controls.Add(this.spSerch);
            this.tpKeyEdit.Controls.Add(this.splitter1);
            this.tpKeyEdit.Controls.Add(this.spHistory);
            this.tpKeyEdit.Controls.Add(this.pHistory);
            this.tpKeyEdit.Controls.Add(this.dgvKeyList);
            this.tpKeyEdit.Controls.Add(this.pSerch);
            this.tpKeyEdit.Controls.Add(this.toolStrip1);
            this.tpKeyEdit.Location = new System.Drawing.Point(4, 22);
            this.tpKeyEdit.Name = "tpKeyEdit";
            this.tpKeyEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpKeyEdit.Size = new System.Drawing.Size(837, 320);
            this.tpKeyEdit.TabIndex = 0;
            this.tpKeyEdit.Text = "Редактирование ключей";
            this.tpKeyEdit.UseVisualStyleBackColor = true;
            // 
            // spSerch
            // 
            this.spSerch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.spSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.spSerch.Location = new System.Drawing.Point(6, 75);
            this.spSerch.Name = "spSerch";
            this.spSerch.Size = new System.Drawing.Size(828, 8);
            this.spSerch.TabIndex = 15;
            this.spSerch.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 75);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 134);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // spHistory
            // 
            this.spHistory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.spHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spHistory.Location = new System.Drawing.Point(3, 209);
            this.spHistory.Name = "spHistory";
            this.spHistory.Size = new System.Drawing.Size(831, 8);
            this.spHistory.TabIndex = 13;
            this.spHistory.TabStop = false;
            // 
            // pHistory
            // 
            this.pHistory.Controls.Add(this.dgvHistList);
            this.pHistory.Controls.Add(this.panel2);
            this.pHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pHistory.Location = new System.Drawing.Point(3, 217);
            this.pHistory.Name = "pHistory";
            this.pHistory.Size = new System.Drawing.Size(831, 100);
            this.pHistory.TabIndex = 12;
            // 
            // dgvHistList
            // 
            this.dgvHistList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistList.Location = new System.Drawing.Point(0, 27);
            this.dgvHistList.MultiSelect = false;
            this.dgvHistList.Name = "dgvHistList";
            this.dgvHistList.ReadOnly = true;
            this.dgvHistList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistList.Size = new System.Drawing.Size(831, 73);
            this.dgvHistList.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 27);
            this.panel2.TabIndex = 0;
            // 
            // lHistory
            // 
            this.lHistory.AutoSize = true;
            this.lHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHistory.Location = new System.Drawing.Point(317, 7);
            this.lHistory.Name = "lHistory";
            this.lHistory.Size = new System.Drawing.Size(163, 18);
            this.lHistory.TabIndex = 0;
            this.lHistory.Text = "История изменения";
            // 
            // dgvKeyList
            // 
            this.dgvKeyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKeyList.Location = new System.Drawing.Point(3, 75);
            this.dgvKeyList.MultiSelect = false;
            this.dgvKeyList.Name = "dgvKeyList";
            this.dgvKeyList.ReadOnly = true;
            this.dgvKeyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeyList.Size = new System.Drawing.Size(831, 242);
            this.dgvKeyList.TabIndex = 11;
            this.dgvKeyList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeyList_CellClick);
            this.dgvKeyList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeyList_RowEnter);
            // 
            // pSerch
            // 
            this.pSerch.Controls.Add(this.cbEnableDatePanel);
            this.pSerch.Controls.Add(this.pDates);
            this.pSerch.Controls.Add(this.bCancelSerch);
            this.pSerch.Controls.Add(this.cbTest);
            this.pSerch.Controls.Add(this.label6);
            this.pSerch.Controls.Add(this.dtpDateStart);
            this.pSerch.Controls.Add(this.tbKeyVal);
            this.pSerch.Controls.Add(this.label1);
            this.pSerch.Controls.Add(this.bSerch);
            this.pSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSerch.Location = new System.Drawing.Point(3, 34);
            this.pSerch.Name = "pSerch";
            this.pSerch.Size = new System.Drawing.Size(831, 41);
            this.pSerch.TabIndex = 10;
            // 
            // cbEnableDatePanel
            // 
            this.cbEnableDatePanel.AutoSize = true;
            this.cbEnableDatePanel.Location = new System.Drawing.Point(222, 14);
            this.cbEnableDatePanel.Name = "cbEnableDatePanel";
            this.cbEnableDatePanel.Size = new System.Drawing.Size(15, 14);
            this.cbEnableDatePanel.TabIndex = 53;
            this.cbEnableDatePanel.UseVisualStyleBackColor = true;
            this.cbEnableDatePanel.CheckedChanged += new System.EventHandler(this.cbEnableDatePanel_CheckedChanged);
            // 
            // pDates
            // 
            this.pDates.Controls.Add(this.dtpEnd);
            this.pDates.Controls.Add(this.label2);
            this.pDates.Controls.Add(this.dtpStart);
            this.pDates.Controls.Add(this.label8);
            this.pDates.Enabled = false;
            this.pDates.Location = new System.Drawing.Point(237, 0);
            this.pDates.Name = "pDates";
            this.pDates.Size = new System.Drawing.Size(342, 41);
            this.pDates.TabIndex = 49;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(262, 11);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(73, 20);
            this.dtpEnd.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "Дата начала\r\nпериода";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(83, 11);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(72, 20);
            this.dtpStart.TabIndex = 49;
            this.dtpStart.Value = new System.DateTime(2016, 3, 4, 2, 45, 45, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 26);
            this.label8.TabIndex = 48;
            this.label8.Text = "Дата окончания\r\nпериода";
            // 
            // bCancelSerch
            // 
            this.bCancelSerch.Location = new System.Drawing.Point(695, 8);
            this.bCancelSerch.Name = "bCancelSerch";
            this.bCancelSerch.Size = new System.Drawing.Size(75, 23);
            this.bCancelSerch.TabIndex = 48;
            this.bCancelSerch.Text = "Отмена";
            this.bCancelSerch.UseVisualStyleBackColor = true;
            this.bCancelSerch.Click += new System.EventHandler(this.bCancelSerch_Click);
            // 
            // cbTest
            // 
            this.cbTest.AutoSize = true;
            this.cbTest.Location = new System.Drawing.Point(585, 11);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(104, 17);
            this.cbTest.TabIndex = 44;
            this.cbTest.Text = "Тестовый ключ";
            this.cbTest.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, -19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Дата начала периода";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateStart.Location = new System.Drawing.Point(227, -25);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(496, 20);
            this.dtpDateStart.TabIndex = 40;
            // 
            // tbKeyVal
            // 
            this.tbKeyVal.Location = new System.Drawing.Point(112, 9);
            this.tbKeyVal.Name = "tbKeyVal";
            this.tbKeyVal.Size = new System.Drawing.Size(100, 20);
            this.tbKeyVal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение \r\nключа";
            // 
            // bSerch
            // 
            this.bSerch.Location = new System.Drawing.Point(3, 3);
            this.bSerch.Name = "bSerch";
            this.bSerch.Size = new System.Drawing.Size(50, 32);
            this.bSerch.TabIndex = 0;
            this.bSerch.Text = "Поиск";
            this.bSerch.UseVisualStyleBackColor = true;
            this.bSerch.Click += new System.EventHandler(this.bSerch_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.deleteButton,
            this.editButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 8);
            this.toolStrip1.Size = new System.Drawing.Size(831, 31);
            this.toolStrip1.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 20);
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 20);
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(85, 20);
            this.editButton.Text = "Изменить";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // tpKeyAdditInfo
            // 
            this.tpKeyAdditInfo.Controls.Add(this.dgvAdditInfo);
            this.tpKeyAdditInfo.Location = new System.Drawing.Point(4, 22);
            this.tpKeyAdditInfo.Name = "tpKeyAdditInfo";
            this.tpKeyAdditInfo.Size = new System.Drawing.Size(837, 320);
            this.tpKeyAdditInfo.TabIndex = 2;
            this.tpKeyAdditInfo.Text = "Полный список выданных ключей";
            this.tpKeyAdditInfo.UseVisualStyleBackColor = true;
            // 
            // dgvAdditInfo
            // 
            this.dgvAdditInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdditInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvAdditInfo.MultiSelect = false;
            this.dgvAdditInfo.Name = "dgvAdditInfo";
            this.dgvAdditInfo.ReadOnly = true;
            this.dgvAdditInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdditInfo.Size = new System.Drawing.Size(837, 320);
            this.dgvAdditInfo.TabIndex = 11;
            // 
            // fmKeyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 346);
            this.Controls.Add(this.TabConKey);
            this.Name = "fmKeyList";
            this.Text = "Менеджер ключей";
            this.Load += new System.EventHandler(this.fmKeyList_Load);
            this.Resize += new System.EventHandler(this.fmKeyList_Resize);
            this.TabConKey.ResumeLayout(false);
            this.tpKeyEdit.ResumeLayout(false);
            this.tpKeyEdit.PerformLayout();
            this.pHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyList)).EndInit();
            this.pSerch.ResumeLayout(false);
            this.pSerch.PerformLayout();
            this.pDates.ResumeLayout(false);
            this.pDates.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpKeyAdditInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl TabConKey;
        private System.Windows.Forms.TabPage tpKeyEdit;
        private System.Windows.Forms.DataGridView dgvKeyList;
        private System.Windows.Forms.Panel pSerch;
        private System.Windows.Forms.Button bCancelSerch;
        private System.Windows.Forms.CheckBox cbTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.TextBox tbKeyVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSerch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.TabPage tpKeyAdditInfo;
        private System.Windows.Forms.DataGridView dgvAdditInfo;
        private System.Windows.Forms.CheckBox cbEnableDatePanel;
        private System.Windows.Forms.Panel pDates;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pHistory;
        private System.Windows.Forms.DataGridView dgvHistList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lHistory;
        private System.Windows.Forms.Splitter spHistory;
        private System.Windows.Forms.Splitter spSerch;
        private System.Windows.Forms.Splitter splitter1;
    }
}