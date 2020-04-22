using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils
{
    public class gridWork
    {
        public void gridSearch(DataGridView grid, TextBox tb)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Selected = false;
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    if (grid.Rows[i].Cells[j].Value != null)
                    {
                        if (grid.Rows[i].Cells[j].Value.ToString().Contains(tb.Text))
                        {
                            grid.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        public void Filtration(DataGridView grid,TextBox tb)
        {
            
        }
        public int NullCheck(List<TextBox> textBoxes)
        {
            int check = 0;
            foreach(var tb in textBoxes)
            {
                if (tb.Text == "")
                {
                    tb.BackColor = Color.Red;
                    check = 1;
                }
                else
                {
                    check = 0;
                    tb.BackColor = Color.White;
                }
            }
            return check;
        }
    }
}
