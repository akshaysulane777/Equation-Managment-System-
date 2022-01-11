using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentManagement.Screens.Templets;
using StudentManagement.Utilities.Lists;

namespace StudentManagement.Screens.Branches
{
    public partial class ManageBranchesForm : TempletForm
    {
        public ManageBranchesForm()
        {
            InitializeComponent();
        }

        private void ManageBranchesForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(); 

        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(BranchesDataGridView, "usp_BranchGetAllBranchs");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewBrachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBranchInfoScreen(0, false);
        }

        private void ShowBranchInfoScreen(int BranchId, bool isUpdate)
        {
            BranchInfoForm bif = new BranchInfoForm();
            bif.BranchId = BranchId;
            bif.IsUpdate = isUpdate;
            bif.ShowDialog();

            LoadDataIntoDataGridView();
        }

        private void BranchesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = BranchesDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int branchId = Convert.ToInt32(BranchesDataGridView.Rows[rowIndex].Cells["BranchId"].Value);
            ShowBranchInfoScreen(branchId, true);
        }
    }
}
