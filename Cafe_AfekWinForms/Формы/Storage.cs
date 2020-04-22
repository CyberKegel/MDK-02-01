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
    public partial class Storage : Form

    {
        List<TextBox> tbs = new List<TextBox>();
        public Storage()
        {
            InitializeComponent();
            tbs.Add(tbType);
        }
        gridWork gridwork = new gridWork();
        private void gridFill()
        {
            Action action = () =>
            {
                Table_Class table = new Table_Class("SELECT [ID_Storage] as \'Номер\', [Storage_Place] as \'Место хранения\'," +
                    "[Product_Name] as \'Товар\' FROM [dbo].[Storage] INNER JOIN [dbo].[Product] on [dbo].[Storage].[Product_ID] = " +
                    "[dbo].[Product].[ID_Product]");
                Table_Class tableProduct = new Table_Class("SELECT [ID_Product], [Product_Name] FROM [dbo].[Product]");
                cbProduct.DataSource = tableProduct.table.DefaultView;
                cbProduct.DisplayMember = "Product_Name";
                cbProduct.ValueMember = "ID_Product";
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
                Insert.Add(tbType.Text);
                Insert.Add(cbProduct.SelectedValue);
                procedure.procedure_Execution("Storage_Insert", Insert);
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
            proc.procedure_Execution("Storage_Delete", ar);
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
                        string.Format("[Storage_Place] like '{0}' || [Product_Name] like '{0}'  '", tbSearch.Text);
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
                ar.Add(tbType.Text);
                ar.Add(Convert.ToInt32(cbProduct.SelectedValue));
                proc.procedure_Execution("Storage_Update", ar);
            }
            gridFill();
        }
    }
}
