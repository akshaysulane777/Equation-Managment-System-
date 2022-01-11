using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentManagement.Screens.Templets;
using JIDBFramwork;
using StudentManagement.Utilities;
using StudentManagement.Utilities.Lists;
using StudentManagement.Models.Users;
using JIDBFramwork.Windows;

namespace StudentManagement.Screens.Branches
{
    public partial class BranchInfoForm : TempletForm
    {
        public BranchInfoForm()
        {
            InitializeComponent();
        }

        public int BranchId { get; set; }

        private void BranchInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            LoadDataAndBindToControlIfUpdate();
        }

        private void LoadDataIntoComboBoxes()
        {
            ListData.LoadDataIntoComboBox(CityNameComboBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.City });
            ListData.LoadDataIntoComboBox(DistrictComboBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.Districs });
        }

        private void LoadDataAndBindToControlIfUpdate()
        {
            if (this.IsUpdate)
            { 
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString()); 
                // DbParameter para =new DbParameter();
                // para.Parameter = "@BranchId";
                // para.value = this.BranchId;
                
                 DataTable dtBranch = db.GetDataList("usp_BranchesGetBranchDetailByBrachId", new DbParameter { Parameter = "@BranchId", value = this.BranchId });
                DataRow row = dtBranch.Rows[0];

                BranchNameTextBox.Text = row["BranchName"].ToString();
                EmailAddressTextBox.Text = row["Email"].ToString();
                TelephoneTextBox.Text = row["Telephone"].ToString();
                WebAddressTextBox.Text = row["Website"].ToString();
                AddressLineTextBox.Text = row["AdreessLine"].ToString();
                LogoPictureBox.Image = (row["BranchImage"] is DBNull)? null : ImageManipulations.PutPhoto((Byte[])row["BranchImage"]);
                CityNameComboBox.SelectedValue = row["CityId"];
                DistrictComboBox.SelectedValue = row["DistrictId"];
                PostCodeTextBox.Text = row["PostCode"].ToString();



            }
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BranchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelLabel.Text = BranchNameTextBox.Text;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Logo";
            ofd.Filter = "Logo File(*.png; *.jpg *.bmp; *.gif)|*.png; *.jpg *.bmp; *.gif";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                LogoPictureBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValidated())
            {
                if (this.IsUpdate)
                {
                    UpdateRecord();
                    JIMessageBox.ShowSuccessMessage("Record is update successfully");
                    //MessageBox.Show("Record is update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SaveRecord();
                    JIMessageBox.ShowSuccessMessage("Record is Added successfully");
                   // MessageBox.Show("Record is Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }

           
        }

        private void SaveRecord()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_BranchesAddNewBranch", GetObject());
        }

        private Branch GetObject()
        {
            Branch branch = new Branch();
            branch.BranchId = (this.IsUpdate) ? this.BranchId : 0;
            branch.BranchName = BranchNameTextBox.Text;
            branch.Email = EmailAddressTextBox.Text;
            branch.Telephone = TelephoneTextBox.Text;
            branch.Website = WebAddressTextBox.Text;
            branch.AdreessLine = AddressLineTextBox.Text;
            branch.CityId = Convert.ToInt32 (CityNameComboBox.SelectedValue);
            branch.DistrictId = Convert.ToInt32(DistrictComboBox.SelectedValue);
            branch.PostCode = PostCodeTextBox.Text;
            branch.BranchImage = (LogoPictureBox.Image == null ) ? null :ImageManipulations.GetPhoto(LogoPictureBox);
            branch.CreatedBy = LoggedInUser.UserName;


            return branch;
        }

        private void UpdateRecord()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_BranchesUpdateBranchDetails", GetObject());
        }

        private bool IsFormValidated()
        {
            if (BranchNameTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Branch name is required");
              //  MessageBox.Show("Branch name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BranchNameTextBox.Focus();
                return false;
            }

            if (EmailAddressTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Email is required");
                //MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailAddressTextBox.Focus();
                return false;
            }

            if (TelephoneTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Telephone required");
                //MessageBox.Show("Telephone required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TelephoneTextBox.Focus();
                return false;
            }

            return true;

        }
    }
}
