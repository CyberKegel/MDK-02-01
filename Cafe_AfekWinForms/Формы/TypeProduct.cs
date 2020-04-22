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
    public partial class TypeProduct : Form

    {
        List<TextBox> tbs = new List<TextBox>();
        public TypeProduct()
        {
            InitializeComponent();
            tbs.Add(tbType);
        }
        gridWork gridwork = new gridWork();
        private void gridFill()
        {
            Action action = () =>
            {
                Table_Class table = new Table_Class("SELECT [ID_Type_of_Product] as \'Номер\', [Type_of_Product] as \'Тип товара\'" +
                    " FROM [dbo].[Type_of_Product]");
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
                procedure.procedure_Execution("Type_of_Product_Insert", Insert);
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
            proc.procedure_Execution("Type_of_Product_Delete", ar);
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
                        string.Format("[Position_Name] like '{0}%'", tbSearch.Text);
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
                proc.procedure_Execution("Type_of_Product_Update", ar);
            }
            gridFill();
        }
    }
}
