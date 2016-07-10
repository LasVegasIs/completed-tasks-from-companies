namespace KeysManager.UI.MainForms
{
    partial class fmOrganizations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmOrganizations));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.dgvOrganization = new System.Windows.Forms.DataGridView();
            this.pStatKeys = new System.Windows.Forms.Panel();
            this.dgvStatKeys = new System.Windows.Forms.DataGridView();
            this.pStatLabel = new System.Windows.Forms.Panel();
            this.lKeyStat = new System.Windows.Forms.Label();
            this.spStatKey = new System.Windows.Forms.Splitter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).BeginInit();
            this.pStatKeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatKeys)).BeginInit();
            this.pStatLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.deleteButton,
            this.editButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(656, 25);
            this.toolStrip1.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 22);
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 22);
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(85, 22);
            this.editButton.Text = "Изменить";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // dgvOrganization
            // 
            this.dgvOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrganization.Location = new System.Drawing.Point(0, 25);
            this.dgvOrganization.MultiSelect = false;
            this.dgvOrganization.Name = "dgvOrganization";
            this.dgvOrganization.ReadOnly = true;
            this.dgvOrganization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganization.Size = new System.Drawing.Size(656, 215);
            this.dgvOrganization.TabIndex = 11;
            this.dgvOrganization.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrganization_CellClick);
            // 
            // pStatKeys
            // 
            this.pStatKeys.Controls.Add(this.dgvStatKeys);
            this.pStatKeys.Controls.Add(this.pStatLabel);
            this.pStatKeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pStatKeys.Location = new System.Drawing.Point(0, 118);
            this.pStatKeys.Name = "pStatKeys";
            this.pStatKeys.Size = new System.Drawing.Size(656, 122);
            this.pStatKeys.TabIndex = 12;
            // 
            // dgvStatKeys
            // 
            this.dgvStatKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatKeys.Location = new System.Drawing.Point(0, 27);
            this.dgvStatKeys.MultiSelect = false;
            this.dgvStatKeys.Name = "dgvStatKeys";
            this.dgvStatKeys.ReadOnly = true;
            this.dgvStatKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatKeys.Size = new System.Drawing.Size(656, 95);
            this.dgvStatKeys.TabIndex = 17;
            // 
            // pStatLabel
            // 
            this.pStatLabel.Controls.Add(this.lKeyStat);
            this.pStatLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatLabel.Location = new System.Drawing.Point(0, 0);
            this.pStatLabel.Name = "pStatLabel";
            this.pStatLabel.Size = new System.Drawing.Size(656, 27);
            this.pStatLabel.TabIndex = 14;
            // 
            // lKeyStat
            // 
            this.lKeyStat.AutoSize = true;
            this.lKeyStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lKeyStat.Location = new System.Drawing.Point(247, 4);
            this.lKeyStat.Name = "lKeyStat";
            this.lKeyStat.Size = new System.Drawing.Size(188, 18);
            this.lKeyStat.TabIndex = 1;
            this.lKeyStat.Text = "Статистика по ключам";
            // 
            // spStatKey
            // 
            this.spStatKey.BackColor = System.Drawing.SystemColors.ControlDark;
            this.spStatKey.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spStatKey.Location = new System.Drawing.Point(0, 110);
            this.spStatKey.Name = "spStatKey";
            this.spStatKey.Size = new System.Drawing.Size(656, 8);
            this.spStatKey.TabIndex = 14;
            this.spStatKey.TabStop = false;
            // 
            // fmOrganizations
            // 
            this.ClientSize = new System.Drawing.Size(656, 240);
            this.Controls.Add(this.spStatKey);
            this.Controls.Add(this.pStatKeys);
            this.Controls.Add(this.dgvOrganization);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fmOrganizations";
            this.Text = "Организации";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmOrganizations_Load);
            this.Resize += new System.EventHandler(this.fmOrganizations_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).EndInit();
            this.pStatKeys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatKeys)).EndInit();
            this.pStatLabel.ResumeLayout(false);
            this.pStatLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.DataGridView dgvOrganization;
        private System.Windows.Forms.Panel pStatKeys;
        private System.Windows.Forms.Panel pStatLabel;
        private System.Windows.Forms.DataGridView dgvStatKeys;
        private System.Windows.Forms.Label lKeyStat;
        private System.Windows.Forms.Splitter spStatKey;
    }
}