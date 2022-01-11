using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace JIDBFramwork
{
     public class DbSQLServer
    {
         // ExcuteReader, ExcuteScalar and ExcuteNoQuary

         private string _connstring;

         public DbSQLServer(string connstring)
         {
             _connstring = connstring;
         }

         // Array, Collection, Ganerics, DataSet and DataTable

         public DataTable GetDataList(String storedProceName)
         {
             DataTable dtData = new DataTable();

             using (SqlConnection conn = new SqlConnection(_connstring))
             {

                 using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                     cmd.CommandType = CommandType.StoredProcedure;

                     conn.Open();

                     SqlDataReader reader = cmd.ExecuteReader();

                     dtData.Load(reader);
                 }
             }
             return dtData;  
         }



         public DataTable GetDataList(String storedProceName, DbParameter parameter)
         {
             DataTable dtData = new DataTable();

             using (SqlConnection conn = new SqlConnection(_connstring))
             {

                 using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                     cmd.CommandType = CommandType.StoredProcedure;

                     conn.Open();

                     cmd.Parameters.AddWithValue(parameter.Parameter, parameter.value);

                     SqlDataReader reader = cmd.ExecuteReader();

                     dtData.Load(reader);
                 }
             }
             return dtData;

         }

         public DataTable GetDataList(String storedProceName, DbParameter[] parameters)
         {
             DataTable dtData = new DataTable();

             using (SqlConnection conn = new SqlConnection(_connstring))
             {

                 using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                     cmd.CommandType = CommandType.StoredProcedure;

                     conn.Open();

                     foreach (var para in parameters)
                     {

                         cmd.Parameters.AddWithValue(para.Parameter, para.value);

                     }
                         SqlDataReader reader = cmd.ExecuteReader();

                     dtData.Load(reader);
                 }
             }
             return dtData;

         }


         public void SaveOrUpdateRecord(string storedProceName, object obj)
         {
             using (SqlConnection conn = new SqlConnection(_connstring))
             {
                 using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                     cmd.CommandType = CommandType.StoredProcedure;
                     conn.Open();
                     //Parameter
                     Type type = obj.GetType();
                     BindingFlags   flages = BindingFlags.Public | BindingFlags.Instance;
                     PropertyInfo[] properties = type.GetProperties(flages);

                     foreach (var property in properties)
                     {
                         cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj, null));
                     }

                     cmd.ExecuteNonQuery();
                 }
             }
         
         }

         // Overloading function
         public object GetScalarValue(string storedProceName)
         {
             object value = null;

             using (SqlConnection conn = new SqlConnection(_connstring))
             {
                 using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                     cmd.CommandType = System.Data.CommandType.StoredProcedure;

                     conn.Open();

                     value = cmd.ExecuteScalar();
                 }
             
             }
             return value;
         }

         public object GetScalarValue(string storedProceName, DbParameter parameter)
         {
             object value = null;

             using (SqlConnection conn = new SqlConnection(_connstring))
             {
                 using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                     cmd.CommandType = System.Data.CommandType.StoredProcedure;

                     conn.Open();

                     cmd.Parameters.AddWithValue(parameter.Parameter, parameter.value);

                     value = cmd.ExecuteScalar();
                 }

             }
             return value;
         }


         public object GetScalarValue(string storedProceName, DbParameter[] parameters)
         {
             object value = null;

             using (SqlConnection conn = new SqlConnection(_connstring))
             {
                 using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                 {
                     cmd.CommandType = System.Data.CommandType.StoredProcedure;

                     conn.Open();

                     foreach (var para in parameters)
                     {
                         cmd.Parameters.AddWithValue(para.Parameter, para.value);
                     }
                     value = cmd.ExecuteScalar();
                 }

             }
             return value;
         }
    }
}
