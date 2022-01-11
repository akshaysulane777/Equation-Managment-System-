namespace StudentManagement.Screens.Branches
{
    partial class BranchInfoForm
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.CityNameComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressLineTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.BranchNameTextBox = new System.Windows.Forms.TextBox();
            this.PostCodeTextBox = new System.Windows.Forms.TextBox();
            this.WebAddressTextBox = new System.Windows.Forms.TextBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelTopPanel = new System.Windows.Forms.Panel();
            this.TopPanelLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.LabelTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.saveRecordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveRecordToolStripMenuItem
            // 
            this.saveRecordToolStripMenuItem.Name = "saveRecordToolStripMenuItem";
            this.saveRecordToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.saveRecordToolStripMenuItem.Text = "Save Record";
            this.saveRecordToolStripMenuItem.Click += new System.EventHandler(this.saveRecordToolStripMenuItem_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.DistrictComboBox);
            this.TopPanel.Controls.Add(this.CityNameComboBox);
            this.TopPanel.Controls.Add(this.label9);
            this.TopPanel.Controls.Add(this.label8);
            this.TopPanel.Controls.Add(this.label7);
            this.TopPanel.Controls.Add(this.label6);
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Controls.Add(this.label4);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.AddressLineTextBox);
            this.TopPanel.Controls.Add(this.TelephoneTextBox);
            this.TopPanel.Controls.Add(this.EmailAddressTextBox);
            this.TopPanel.Controls.Add(this.BranchNameTextBox);
            this.TopPanel.Controls.Add(this.PostCodeTextBox);
            this.TopPanel.Controls.Add(this.WebAddressTextBox);
            this.TopPanel.Controls.Add(this.LogoPictureBox);
            this.TopPanel.Controls.Add(this.LabelTopPanel);
            this.TopPanel.Location = new System.Drawing.Point(10, 38);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1051, 455);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // DistrictComboBox
            // 
            this.DistrictComboBox.FormattingEnabled = true;
            this.DistrictComboBox.Location = new System.Drawing.Point(599, 369);
            this.DistrictComboBox.Name = "DistrictComboBox";
            this.DistrictComboBox.Size = new System.Drawing.Size(185, 28);
            this.DistrictComboBox.TabIndex = 6;
            // 
            // CityNameComboBox
            // 
            this.CityNameComboBox.FormattingEnabled = true;
            this.CityNameComboBox.Location = new System.Drawing.Point(599, 326);
            this.CityNameComboBox.Name = "CityNameComboBox";
            this.CityNameComboBox.Size = new System.Drawing.Size(185, 28);
            this.CityNameComboBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Address Line :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Website Address : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Branch Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telephone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Post Code ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "District Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "City Name :";
            // 
            // AddressLineTextBox
            // 
            this.AddressLineTextBox.Location = new System.Drawing.Point(599, 274);
            this.AddressLineTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressLineTextBox.Name = "AddressLineTextBox";
            this.AddressLineTextBox.Size = new System.Drawing.Size(223, 26);
            this.AddressLineTextBox.TabIndex = 4;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(599, 177);
            this.TelephoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(193, 26);
            this.TelephoneTextBox.TabIndex = 2;
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(599, 137);
            this.EmailAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(245, 26);
            this.EmailAddressTextBox.TabIndex = 1;
            // 
            // BranchNameTextBox
            // 
            this.BranchNameTextBox.Location = new System.Drawing.Point(599, 89);
            this.BranchNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BranchNameTextBox.Name = "BranchNameTextBox";
            this.BranchNameTextBox.Size = new System.Drawing.Size(259, 26);
            this.BranchNameTextBox.TabIndex = 0;
            this.BranchNameTextBox.TextChanged += new System.EventHandler(this.BranchNameTextBox_TextChanged);
            // 
            // PostCodeTextBox
            // 
            this.PostCodeTextBox.Location = new System.Drawing.Point(599, 411);
            this.PostCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PostCodeTextBox.Name = "PostCodeTextBox";
            this.PostCodeTextBox.Size = new System.Drawing.Size(124, 26);
            this.PostCodeTextBox.TabIndex = 7;
            // 
            // WebAddressTextBox
            // 
            this.WebAddressTextBox.Location = new System.Drawing.Point(599, 226);
            this.WebAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WebAddressTextBox.Name = "WebAddressTextBox";
            this.WebAddressTextBox.Size = new System.Drawing.Size(223, 26);
            this.WebAddressTextBox.TabIndex = 3;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.White;
            this.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPictureBox.Location = new System.Drawing.Point(38, 13);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(264, 253);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox1_Click);
            // 
            // LabelTopPanel
            // 
            this.LabelTopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LabelTopPanel.Controls.Add(this.TopPanelLabel);
            this.LabelTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTopPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelTopPanel.Name = "LabelTopPanel";
            this.LabelTopPanel.Size = new System.Drawing.Size(1049, 59);
            this.LabelTopPanel.TabIndex = 0;
            // 
            // TopPanelLabel
            // 
            this.TopPanelLabel.AutoSize = true;
            this.TopPanelLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanelLabel.ForeColor = System.Drawing.Color.White;
            this.TopPanelLabel.Location = new System.Drawing.Point(432, 13);
            this.TopPanelLabel.Name = "TopPanelLabel";
            this.TopPanelLabel.Size = new System.Drawing.Size(334, 34);
            this.TopPanelLabel.TabIndex = 0;
            this.TopPanelLabel.Text = "ABC Standard School";
            // 
            // BranchInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 505);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BranchInfoForm";
            this.Text = "Branch Info Screen";
            this.Load += new System.EventHandler(this.BranchInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.LabelTopPanel.ResumeLayout(false);
            this.LabelTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRecordToolStripMenuItem;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel LabelTopPanel;
        private System.Windows.Forms.Label TopPanelLabel;
        private System.Windows.Forms.TextBox AddressLineTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox BranchNameTextBox;
        private System.Windows.Forms.TextBox PostCodeTextBox;
        private System.Windows.Forms.TextBox WebAddressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DistrictComboBox;
        private System.Windows.Forms.ComboBox CityNameComboBox;
    }
}