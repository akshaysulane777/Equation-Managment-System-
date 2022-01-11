using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentManagement.Screens.Templets;
using StudentManagement.Screens.Branches;
using StudentManagement.Screens.Employees;

namespace StudentManagement.Screens
{
    public partial class DashboardForm : TempletForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageBranchsToolStripButton_Click(object sender, EventArgs e)
        {
            ManageBranchesForm mbf = new ManageBranchesForm();
            mbf.ShowDialog();
        }

        private void NewStudentToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ManageUsersToolStripButton_Click(object sender, EventArgs e)
        {
            ManageEmployeesForm mef = new ManageEmployeesForm();
            mef.ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
