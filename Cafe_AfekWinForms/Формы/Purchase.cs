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
    public partial class Purchase : Form

    {
        List<TextBox> tbs = new List<TextBox>();
        public Purchase()
        {
            InitializeComponent();
            tbs.Add(tbAmount);
            tbs.Add(tbCheck);
            tbs.Add(tbCash);
        }
        gridWork gridwork = new gridWork();
        private void gridFill()
        {
            Action action = () =>
            {
                Table_Class table = new Table_Class("SELECT [ID_Purchase] as \'Номер\', [Purchase_Amount] as \'Количетсво\'," +
                    "[ID_Check] as \'Номер чека\',[ID_Cash] as \'Номер кассы\', [Product_Name] as \'Товар\', " +
                    "[Client_Name] +' '+ [Client_MiddleName] +' '+ [Client_LastName] as \'Клиент\' FROM [dbo].[Purchase] " +
                    "INNER JOIN [dbo].[Client] on [dbo].[Purchase].[Client_ID] = " +
                    "[dbo].[Client].[ID_Client] INNER JOIN [dbo].[Product] on [dbo].[Purchase].[Product_ID] = [dbo].[Product].[ID_Product]");
                Table_Class tableProduct = new Table_Class("SELECT [ID_Product], [Product_Name] from [dbo].[Product]");
                Table_Class tableClient = new Table_Class("SELECT [ID_Client], [Client_Name] +' '+ [Client_MiddleName] +' '+ " +
                    "[Client_LastName] as\'Client\' " +
                    "FROM [dbo].[Client]");
                cbProduct.DataSource = tableProduct.table.DefaultView;
                cbProduct.DisplayMember = "Product_Name";
                cbProduct.ValueMember = "ID_Product";
                cbClient.DataSource = tableClient.table.DefaultView;
                cbClient.DisplayMember = "Client";
                cbClient.ValueMember = "ID_Client";
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
                Insert.Add(tbAmount.Text);
                Insert.Add(Convert.ToInt32(tbCheck.Text));
                Insert.Add(Convert.ToInt32(tbCash.Text));
                Insert.Add(Convert.ToInt32(cbProduct.SelectedValue));
                Insert.Add(Convert.ToInt32(cbClient.SelectedValue));
                procedure.procedure_Execution("Purchase_Insert", Insert);
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
            proc.procedure_Execution("Purchase_Delete", ar);
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
                        string.Format("[Amount] like '{0}' || [Type_of_Product] like '{0}'|| [Client] like '{0}'|| ", tbSearch.Text);
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
                ar.Add(tbAmount.Text);
                ar.Add(Convert.ToInt32(tbCheck.Text));
                ar.Add(Convert.ToInt32(tbCash.Text));
                ar.Add(Convert.ToInt32(cbProduct.SelectedValue));
                ar.Add(Convert.ToInt32(cbClient.SelectedValue));
                proc.procedure_Execution("Purchase_Update", ar);
            }
            gridFill();
        }
    }
}
