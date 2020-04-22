using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Data.Sql;

namespace Cafe_AfekWinForms
{
    public class Configuration_Class
    {
        public event Action<DataTable> Server_Collection;
        public event Action<DataTable> Data_Base_Collection;
        public event Action<bool> Connection_Checked;
        public string DS = "Empty", IC = "Empty";
        public string ds = "";
        public static SqlConnection connection = new SqlConnection();

        public void SQL_Server_Configuration_Get()
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("Server_Configuration");
            try
            {
                DS = key.GetValue("DS").ToString();
                IC = key.GetValue("IC").ToString();
            }
            catch
            {
                DS = "Empty";
                IC = "Empty";
            }
            finally
            {
                connection.ConnectionString = "Data Source = " + DS + "; Initial Catalog = " + IC + "; Integrated Security = true;";
            }
        }
        public void SQL_Server_Configuration_Set(string ds, string ic)
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("Server_Configuration");
            key.SetValue("DS", ds);
            key.SetValue("IC", ic);
            SQL_Server_Configuration_Get();
        }
        public void SQL_Server_Enumuretor()
        {
            SqlDataSourceEnumerator sourceEnumerator = SqlDataSourceEnumerator.Instance;
            Server_Collection(sourceEnumerator.GetDataSources());
        }
        public void SQL_Data_Base_Checking()
        {
            connection.ConnectionString = "Data Source = " + ds + "; Initial Catalog = master; Integrated Security = True;";
            try
            {
                connection.Open();
                Connection_Checked(true);
            }
            catch
            {
                Connection_Checked(false);
            }
            finally
            {
                connection.Close();
            }
        }
        public void SQL_Data_Base_Collection()
        {
            SqlCommand command = new SqlCommand("select name from sys.databases where name not in ('master', 'tempdb', 'model', 'msdb')", connection);
            try
            {
                connection.Open();
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                Data_Base_Collection(table);
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
        }

        public static string Organization_Name, Save_Files_Path, Machine_Name;

        public static Int32 doc_Left_Merge, doc_Right_Merge, doc_Top_Merge, doc_Bottom_Merge;

        public void Document_configuration_Get()
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("Server_Configuration");
            try
            {
                Organization_Name = key.GetValue("Organization_Name").ToString();
                doc_Left_Merge = Convert.ToInt32(key.GetValue("doc_Left_Merge").ToString());
                doc_Right_Merge = Convert.ToInt32(key.GetValue("doc_Right_Merge").ToString());
                doc_Top_Merge = Convert.ToInt32(key.GetValue("doc_Top_Merge").ToString());
                doc_Bottom_Merge = Convert.ToInt32(key.GetValue("doc_Bottom_Merge").ToString());
            }
            catch
            {
                Organization_Name = "Empty";
                doc_Left_Merge = 0;
                doc_Right_Merge = 0;
                doc_Top_Merge = 0;
                doc_Bottom_Merge = 0;
            }

        }
    }
}
