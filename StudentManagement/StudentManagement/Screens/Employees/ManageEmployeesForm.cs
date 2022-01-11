using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentManagement.Screens.Templets;

namespace StudentManagement.Screens.Employees
{
    public partial class ManageEmployeesForm : TempletForm
    {
        public ManageEmployeesForm()
        {
            InitializeComponent();
        }

        private void ManageEmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployeeInfoScreen(0, false);
        }

        private void ShowEmployeeInfoScreen(int employeeId, bool isUpdate)
        {
            EmployeeInfoForm eif = new EmployeeInfoForm();
            eif.EmployeeId = employeeId;
            eif.IsUpdate = isUpdate;
            eif.ShowDialog();
        }
    }
}
