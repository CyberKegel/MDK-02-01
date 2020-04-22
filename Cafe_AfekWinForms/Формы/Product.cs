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
    public partial class Product : Form

    {
        List<TextBox> tbs = new List<TextBox>();
        public Product()
        {
            InitializeComponent();
            tbs.Add(
                tbName);
            tbs.Add(tbAmount);
            tbs.Add(tbPrice);
        }
        gridWork gridwork = new gridWork();
        private void gridFill()
        {
            Action action = () =>
            {
                Table_Class table = new Table_Class("SELECT [ID_Product] as \'Номер\', [Product_Name] as \'Наименование\'" +
                    ", [Product_Amount] as \'Количество\', [Product_Price] as\'Цена\', [Type_of_Product] as \'Тип\' FROM [dbo].[Product] INNER JOIN [dbo].[Type_of_Product] ON [dbo].[Product].[Type_of_Product_ID]= " +
                    "[dbo].[Type_of_Product].[ID_Type_of_Product]");
                Table_Class tableType = new Table_Class("SELECT [ID_Type_of_Product], [Type_of_Product] FROM [dbo].[Type_of_Product]");
                cbType.DataSource = tableType.table.DefaultView;
                cbType.DisplayMember = "Type_of_Product";
                cbType.ValueMember = "ID_Type_of_Product";
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
            ArrayList Position_Insert = new ArrayList();
            if(gridwork.NullCheck(tbs) == 1)
            {
                Position_Insert.Add(tbName.Text);
                Position_Insert.Add(tbAmount.Text);
                Position_Insert.Add(tbPrice.Text);
                Position_Insert.Add(Convert.ToInt32(cbType.SelectedValue));
                Position_Insert.Add(tbName.Text);
                procedure.procedure_Execution("Product_Insert", Position_Insert);
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
            proc.procedure_Execution("Product_Delete", ar);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            gridFill();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            gridwork.gridSearch(dataGridView1, tbSearch);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    try
            //    {
            //        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
            //            string.Format("[Product_Name] like '{0}%'", tbSearch.Text);
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            //    }
            //}
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
                ar.Add(tbAmount.Text);
                ar.Add(tbPrice.Text);
                ar.Add(Convert.ToInt32(cbType.SelectedValue));
                proc.procedure_Execution("Product_Update", ar);
            }
            gridFill();
        }
    }
}
