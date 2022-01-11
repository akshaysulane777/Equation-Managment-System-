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
using JIDBFramwork.Windows;

namespace StudentManagement.Screens.Employees
{
    public partial class EmployeeInfoForm : TempletForm
    {
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        public int EmployeeId { get; set; }    

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            if (this.IsUpdate)
            {
                // Update Process code
            }
            else
            {
                GenerateEmployeeId();
            }
        }

        private void LoadDataIntoComboBoxes()
        {
            ListData.LoadDataIntoComboBox(BranchComboBox, "ups_BranchesGetAllBranchNames");

            ListData.LoadDataIntoComboBox(GenderComboBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.Gender });
            
            ListData.LoadDataIntoComboBox(CityComboBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.City });
            ListData.LoadDataIntoComboBox(DistricsComboBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.Districs });

            ListData.LoadDataIntoComboBox(JobTitleBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.EmployeeJobTitle });

            ListData.LoadDataIntoComboBox(HasLeftComboBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.YesNo});

            ListData.LoadDataIntoComboBox(EmployeeReasonLeftComboBox, new DbParameter { Parameter = "@ListTypeId", value = ListTypes.EmployeeReasonLeft});
        }

        private void GenerateEmployeeId()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            EmployeeIdTextBox.Text = db.GetScalarValue("usp_EmployeesGenerateNewEmployeeId").ToString();

        }

        private void EmployeePhotoPictureBox_DoubleClick(object sender, EventArgs e)
        {
            GetPhoto();
        }

        private void GetPhotoPictureBox_Click(object sender, EventArgs e)
        {
            GetPhoto();
        }

        private void GetPhoto()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Photo";
            ofd.Filter = "Photo File(*.png; *.jpg *.bmp; *.gif)|*.png; *.jpg *.bmp; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PhotoPictureBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void ClearPictureBox_Click(object sender, EventArgs e)
        {
            PhotoPictureBox.Image = null;
        }

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            { 
            
            }
        }

        private bool IsFormValid()
        {
            if (FullNameTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("Full Name is required.");
                FullNameTextBox.Focus();
                return false;
            }

            if (NICNumberTextBox.Text.Trim() == string.Empty)
            {
                JIMessageBox.ShowErrorMessage("NIC Number is required.");
                NICNumberTextBox.Focus();
                return false;
            }

            if ((MobileTextBox.Text.Trim() == string.Empty) && (TelephoneTextBox.Text.Trim() == string.Empty))
            {
                JIMessageBox.ShowErrorMessage("Mobile or Telephone Number is required.");
                MobileTextBox.Focus();
                return false;
            }

            if (GenderComboBox.SelectedIndex == -1)
            {
                JIMessageBox.ShowErrorMessage("Gender is required");
                return false;
            }




            return true;
        }

        


       
    }
}
