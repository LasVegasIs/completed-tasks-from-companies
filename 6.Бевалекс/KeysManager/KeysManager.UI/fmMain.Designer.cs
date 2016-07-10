namespace KeysManager.UI
{
    partial class fmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mManagerKey = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOrganization = new System.Windows.Forms.ToolStripMenuItem();
            this.mDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalPlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalPlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.окнаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mManagerKey,
            this.mExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // mManagerKey
            // 
            this.mManagerKey.Name = "mManagerKey";
            this.mManagerKey.Size = new System.Drawing.Size(145, 22);
            this.mManagerKey.Text = "Учет ключей";
            this.mManagerKey.Click += new System.EventHandler(this.mManagerKey_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(145, 22);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOrganization,
            this.mDevices});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // mOrganization
            // 
            this.mOrganization.Name = "mOrganization";
            this.mOrganization.Size = new System.Drawing.Size(147, 22);
            this.mOrganization.Text = "Организации";
            this.mOrganization.Click += new System.EventHandler(this.mOrganization_Click);
            // 
            // mDevices
            // 
            this.mDevices.Name = "mDevices";
            this.mDevices.Size = new System.Drawing.Size(147, 22);
            this.mDevices.Text = "Устройства";
            this.mDevices.Click += new System.EventHandler(this.mDevices_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUsers,
            this.mGroups});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // mUsers
            // 
            this.mUsers.Name = "mUsers";
            this.mUsers.Size = new System.Drawing.Size(152, 22);
            this.mUsers.Text = "Пользователи";
            this.mUsers.Click += new System.EventHandler(this.mUsers_Click);
            // 
            // mGroups
            // 
            this.mGroups.Name = "mGroups";
            this.mGroups.Size = new System.Drawing.Size(152, 22);
            this.mGroups.Text = "Группы";
            this.mGroups.Click += new System.EventHandler(this.mGroups_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeToolStripMenuItem,
            this.VerticalPlToolStripMenuItem,
            this.HorizontalPlToolStripMenuItem,
            this.CloseAllToolStripMenuItem});
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // CascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.CascadeToolStripMenuItem.Text = "Каскадом";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // VerticalPlToolStripMenuItem
            // 
            this.VerticalPlToolStripMenuItem.Name = "VerticalPlToolStripMenuItem";
            this.VerticalPlToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.VerticalPlToolStripMenuItem.Text = "Вертикальной плиткой";
            this.VerticalPlToolStripMenuItem.Click += new System.EventHandler(this.VerticalPlToolStripMenuItem_Click);
            // 
            // HorizontalPlToolStripMenuItem
            // 
            this.HorizontalPlToolStripMenuItem.Name = "HorizontalPlToolStripMenuItem";
            this.HorizontalPlToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.HorizontalPlToolStripMenuItem.Text = "Горизонтальной плиткой";
            this.HorizontalPlToolStripMenuItem.Click += new System.EventHandler(this.HorizontalPlToolStripMenuItem_Click);
            // 
            // CloseAllToolStripMenuItem
            // 
            this.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem";
            this.CloseAllToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.CloseAllToolStripMenuItem.Text = "Закрыть все";
            this.CloseAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(433, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 300);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOrganization;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDevices;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerticalPlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HorizontalPlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mManagerKey;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mUsers;
        private System.Windows.Forms.ToolStripMenuItem mGroups;
    }
}

