namespace StudentManagement.Screens
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewStudentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageBranchsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditProfileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageEmployeesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageReportsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SystemSetupToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.HelpandSupportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 333);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStudentToolStripButton,
            this.toolStripSeparator1,
            this.ManageBranchsToolStripButton,
            this.toolStripSeparator2,
            this.EditProfileToolStripButton,
            this.toolStripSeparator3,
            this.ManageEmployeesToolStripButton,
            this.toolStripSeparator4,
            this.ManageReportsToolStripButton,
            this.toolStripSeparator5,
            this.SystemSetupToolStripButton6,
            this.toolStripSeparator6,
            this.HelpandSupportToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1082, 155);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewStudentToolStripButton
            // 
            this.NewStudentToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewStudentToolStripButton.Image")));
            this.NewStudentToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewStudentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewStudentToolStripButton.Name = "NewStudentToolStripButton";
            this.NewStudentToolStripButton.Size = new System.Drawing.Size(132, 152);
            this.NewStudentToolStripButton.Text = "New Student";
            this.NewStudentToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewStudentToolStripButton.Click += new System.EventHandler(this.NewStudentToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 155);
            // 
            // ManageBranchsToolStripButton
            // 
            this.ManageBranchsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageBranchsToolStripButton.Image")));
            this.ManageBranchsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageBranchsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageBranchsToolStripButton.Name = "ManageBranchsToolStripButton";
            this.ManageBranchsToolStripButton.Size = new System.Drawing.Size(132, 152);
            this.ManageBranchsToolStripButton.Text = "Manage Branchs";
            this.ManageBranchsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManageBranchsToolStripButton.Click += new System.EventHandler(this.ManageBranchsToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 155);
            // 
            // EditProfileToolStripButton
            // 
            this.EditProfileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditProfileToolStripButton.Image")));
            this.EditProfileToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditProfileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditProfileToolStripButton.Name = "EditProfileToolStripButton";
            this.EditProfileToolStripButton.Size = new System.Drawing.Size(132, 152);
            this.EditProfileToolStripButton.Text = "Edit Profile";
            this.EditProfileToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 155);
            // 
            // ManageEmployeesToolStripButton
            // 
            this.ManageEmployeesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageEmployeesToolStripButton.Image")));
            this.ManageEmployeesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageEmployeesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageEmployeesToolStripButton.Name = "ManageEmployeesToolStripButton";
            this.ManageEmployeesToolStripButton.Size = new System.Drawing.Size(143, 152);
            this.ManageEmployeesToolStripButton.Text = "Manage Employees";
            this.ManageEmployeesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManageEmployeesToolStripButton.Click += new System.EventHandler(this.ManageUsersToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 155);
            // 
            // ManageReportsToolStripButton
            // 
            this.ManageReportsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageReportsToolStripButton.Image")));
            this.ManageReportsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageReportsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageReportsToolStripButton.Name = "ManageReportsToolStripButton";
            this.ManageReportsToolStripButton.Size = new System.Drawing.Size(132, 152);
            this.ManageReportsToolStripButton.Text = "Manage Reports";
            this.ManageReportsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 155);
            // 
            // SystemSetupToolStripButton6
            // 
            this.SystemSetupToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("SystemSetupToolStripButton6.Image")));
            this.SystemSetupToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SystemSetupToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SystemSetupToolStripButton6.Name = "SystemSetupToolStripButton6";
            this.SystemSetupToolStripButton6.Size = new System.Drawing.Size(132, 152);
            this.SystemSetupToolStripButton6.Text = "System Setup";
            this.SystemSetupToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 155);
            // 
            // HelpandSupportToolStripButton
            // 
            this.HelpandSupportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpandSupportToolStripButton.Image")));
            this.HelpandSupportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HelpandSupportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpandSupportToolStripButton.Name = "HelpandSupportToolStripButton";
            this.HelpandSupportToolStripButton.Size = new System.Drawing.Size(132, 152);
            this.HelpandSupportToolStripButton.Text = "Help and Support";
            this.HelpandSupportToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStudentToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutStudentToolStripMenuItem
            // 
            this.aboutStudentToolStripMenuItem.Name = "aboutStudentToolStripMenuItem";
            this.aboutStudentToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.aboutStudentToolStripMenuItem.Text = "About Student Manager";
            this.aboutStudentToolStripMenuItem.Click += new System.EventHandler(this.aboutStudentToolStripMenuItem_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "DashboardForm";
            this.ShowInTaskbar = true;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewStudentToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ManageBranchsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EditProfileToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ManageEmployeesToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ManageReportsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton SystemSetupToolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton HelpandSupportToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}