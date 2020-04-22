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
    public partial class Registration : Form
    {
        gridWork gridwork = new gridWork();
        public Registration()
        {
            InitializeComponent();
            tbs.Add(tbName);
            tbs.Add(tbMiddle_Name);
            tbs.Add(tbFirst_Name);
            tbs.Add(tbLogin);
            tbs.Add(tbPassword);
            tbs.Add(tbConfernPassword);
            filll();
        }
        private void filll()
        {
            Table_Class tablePos = new Table_Class("select [ID_Position], [Position_Name] from [dbo].[Position]");
            tbPosition.DataSource = tablePos.table.DefaultView;
            tbPosition.DisplayMember = "Position_Name";
            tbPosition.ValueMember = "ID_Position";
        }
        List<TextBox> tbs = new List<TextBox>();
        private void BtSave_Click(object sender, EventArgs e)
        {
            Procedure_Class procedure = new Procedure_Class();
            ArrayList Employee_Insert = new ArrayList();
            if (gridwork.NullCheck(tbs) == 0)
            {
                if (tbPassword.Text == tbConfernPassword.Text)
                {
                    Cyphering cyph = new Cyphering();
                    string logCyph = Cyphering.Code_Message(tbLogin.Text);
                    string passCyph = Cyphering.Code_Message(tbPassword.Text);
                    Employee_Insert.Add(logCyph);
                    Employee_Insert.Add(passCyph);
                    Employee_Insert.Add(tbName.Text);
                    Employee_Insert.Add(tbMiddle_Name.Text);
                    Employee_Insert.Add(tbFirst_Name.Text);
                    Employee_Insert.Add(Convert.ToInt32(tbPosition.SelectedValue));
                    procedure.procedure_Execution("Employee_Insert", Employee_Insert);
                }
                else MessageBox.Show("Не верный пароль", "", MessageBoxButtons.OK);
            }

            tbConfernPassword.Clear();
            tbPassword.Clear();
            MessageBox.Show("Успешная регистрация", "", MessageBoxButtons.OK);
            this.Close();
        }
    }
    
}
