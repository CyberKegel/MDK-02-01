using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Cafe_AfekWinForms.Формы
{
    public partial class Work_Client : Form

    {
        List<TextBox> tbs = new List<TextBox>();
        public Work_Client()
        {
            InitializeComponent();
        }
        gridWork gridwork = new gridWork();
        private void gridFill()
        {
            Action action = () =>
            {
                Table_Class table = new Table_Class("SELECT [ID_Work] as \'Номер\',"+
                    "[Client_Name] +' '+ [Client_MiddleName] +' '+ [Client_LastName] as \'Клиент\'," +
                    "[Employee_Name] + ' ' + [Employee_MiddleName] + ' ' + " +
                    "[Employee_LastName] as\'Сотрудник\' FROM [dbo].[Work_Client]" +
                    " " +
                    "INNER JOIN [dbo].[Client] on [dbo].[Work_Client].[Client_ID] = " +
                    "[dbo].[Client].[ID_Client] INNER JOIN [dbo].[Employee] on [dbo].[Work_Client].[Employee_ID] = [dbo].[Employee].[ID_Employee]");
                Table_Class tableEmployee = new Table_Class("SELECT [ID_Employee], [Employee_Name] + ' ' + [Employee_MiddleName] + ' ' + " +
                    "[Employee_LastName] as\'Employee\' " +
                    "FROM [dbo].[Employee]");
                Table_Class tableClient = new Table_Class("SELECT [ID_Client], [Client_Name] +' '+ [Client_MiddleName] +' '+ " +
                    "[Client_LastName] as\'Client\' " +
                    "FROM [dbo].[Client]");
                cbClient.DataSource = tableClient.table.DefaultView;
                cbClient.DisplayMember = "Client";
                cbClient.ValueMember = "ID_Client";
                cbEmployee.DataSource = tableEmployee.table.DefaultView;
                cbEmployee.DisplayMember = "Employee";
                cbEmployee.ValueMember = "ID_Employee";
                table.Dependency.OnChange += Dependency_OnChange;
                dataGridView1.DataSource = table.table.DefaultView;
            };
            Invoke(action);
        }

        private void Product_Load(object sender, EventArgs e)
        {
            gridFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            ArrayList Insert = new ArrayList();
            if(gridwork.NullCheck(tbs) == 0)
            {
                Insert.Add(Convert.ToInt32(cbClient.SelectedValue));
                Insert.Add(Convert.ToInt32(cbEmployee.SelectedValue));
                procedure.procedure_Execution("Work_Client_Insert", Insert);
                gridFill();
            }
        }
        private void Dependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                gridFill();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ArrayList ar = new ArrayList();
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ar.Add(ID);
            Procedure_Class proc = new Procedure_Class();
            proc.procedure_Execution("Work_Client_Delete", ar);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            gridFill();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            gridwork.gridSearch(dataGridView1, tbSearch);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                try
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                        string.Format("[Employee] like '{0}' || [Client] like '{0}'", tbSearch.Text);
                }
                catch { }
            }
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList ar = new ArrayList();
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ar.Add(ID);
            Procedure_Class proc = new Procedure_Class();
            if (gridwork.NullCheck(tbs) == 0)
            {
                ar.Add(Convert.ToInt32(cbClient.SelectedValue));
                ar.Add(Convert.ToInt32(cbEmployee.SelectedValue));
                proc.procedure_Execution("Work_Client_Update", ar);
            }
            gridFill();
        }
    }
}
