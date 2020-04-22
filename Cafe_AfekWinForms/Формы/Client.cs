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
    public partial class Client : Form

    {
        List<TextBox> tbs = new List<TextBox>();
        public Client()
        {
            InitializeComponent();
            tbs.Add(tbName);
            tbs.Add(tbMiddlename);
            tbs.Add(tbLastname);
            tbs.Add(tbDiscount);
        }
        gridWork gridwork = new gridWork();
        private void gridFill()
        {
            Action action = () =>
            {
                Table_Class table = new Table_Class("SELECT [ID_Client] as \'Номер\', [Client_Name] as \'Имя\'" +
                    ", [Client_MiddleName] as \'Отчество\', [Client_LastName] as\'Фамилия\', [Discount] as \'Скидка\' FROM [dbo].[Client]");
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
                Insert.Add(tbName.Text);
                Insert.Add(tbMiddlename.Text);
                Insert.Add(tbLastname.Text);
                Insert.Add(Convert.ToInt32(tbDiscount.Text));
                procedure.procedure_Execution("Client_Insert", Insert);
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
            proc.procedure_Execution("Client_Delete", ar);
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
                        string.Format("[Client_Name] =0 '{0}'", tbSearch.Text);
                }
                catch { }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList ar = new ArrayList();
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ar.Add(ID);
            Procedure_Class proc = new Procedure_Class();
            if (gridwork.NullCheck(tbs) == 0)
            {
                ar.Add(tbName.Text);
                ar.Add(tbMiddlename.Text);
                ar.Add(tbLastname.Text);
                ar.Add(Convert.ToInt32(tbDiscount.Text));
                proc.procedure_Execution("Client_Update", ar);
            }
            gridFill();
        }
    }
}
