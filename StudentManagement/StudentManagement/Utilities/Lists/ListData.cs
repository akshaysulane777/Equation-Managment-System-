using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JIDBFramwork;

namespace StudentManagement.Utilities.Lists
{
      public class ListData
    {
          public static void LoadDataIntoDataGridView(DataGridView dgv, String StoredProceName)
          {
              DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

              dgv.DataSource = db.GetDataList(StoredProceName);
              dgv.MultiSelect = false;
              dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
              dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

          }

          public static void LoadDataIntoComboBox(ComboBox cb, DbParameter parameter)
          {
              DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
              cb.DataSource = db.GetDataList("usp_ListTypesDataGetDataByListTypeId", parameter);
              cb.DisplayMember = "Description";
              cb.ValueMember = "Id";

              cb.SelectedIndex = -1;
              cb.DropDownStyle = ComboBoxStyle.DropDownList;

          }

          public static void LoadDataIntoComboBox(ComboBox cb, string strodProceName )
          {
              DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
              cb.DataSource = db.GetDataList(strodProceName);
              cb.DisplayMember = "Description";
              cb.ValueMember = "Id";

              cb.SelectedIndex = -1;
              cb.DropDownStyle = ComboBoxStyle.DropDownList;

          }


          public static void LoadDataIntoComboBox(ComboBox cb, string strodProceName, DbParameter parameter)
          {
              DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
              cb.DataSource = db.GetDataList(strodProceName, parameter);
              cb.DisplayMember = "Description";
              cb.ValueMember = "Id";

              cb.SelectedIndex = -1;
              cb.DropDownStyle = ComboBoxStyle.DropDownList;

          }

          
          public static void LoadDataIntoComboBox(ComboBox cb, string strodProceName, DbParameter[] parameters)
          {
              DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
              cb.DataSource = db.GetDataList(strodProceName, parameters);
              cb.DisplayMember = "Description";
              cb.ValueMember = "Id";

              cb.SelectedIndex = -1;
              cb.DropDownStyle = ComboBoxStyle.DropDownList;

          }
    }
}
