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
    public partial class Employee_Form : Form
    {
        Document_Class document = new Document_Class();
        List<TextBox> tbs = new List<TextBox>();
        static gridWork gridwork = new gridWork();
        public Employee_Form()
        {
            InitializeComponent();
            tbs.Add(tbName);
            tbs.Add(tbMiddle_Name);
            tbs.Add(tbFirst_Name);
            tbs.Add(tbLogin);
            tbs.Add(tbPassword);
            tbs.Add(tbConfernPassword);
        }
        //Переменные для вывода данных в поле ввода и проверки на уникальность и заменение данных
        string Card_Number = "", Card_Create = "", Klient_First_Name = "", Klient_Name = "", Klient_Middle_Name = "", 
            Login = "", Password = "", position ="" ,listPos = "", ID_Pos ="";

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DocCreate();
        }

        
        private void DocCreate()
        {
            
            Table_Class tabProduct = new Table_Class("select [Product_Name], [Product_Amount],[Product_Price] from [dbo].[Product]");

            document.Document_Create(Document_Class.Document_Type.Statistic,Document_Class.Document_format.Word,"Отчет о таблице2",(tabProduct.table));
        }
        private void ChartFill()
        {
            Table_Class table_Class = new Table_Class("select [ID_Employee], [Employee_Name], [Employee_MiddleName], " +
                    "[Employee_Lastname], [Login_Employee], [Password_Employee] " +
                    " from [dbo].[Employee]");
            chrExpensens.DataSource = table_Class.table.DefaultView.ToTable();
            try
            {
                chrExpensens.Series["srExpens"].XValueMember = (table_Class.table.Rows[0][0]).ToString();
                chrExpensens.Series["srExpens"].YValueMembers = (table_Class.table.Rows[0][1]).ToString();

                chrExpensens.DataBind();
            }
            catch { }
        }
        private void Personal_Profile_Klient_Load(object sender, EventArgs e)
        {
            Klient_Data_Fill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Personal_Profile_Klient_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Вы действительно хотите выйти из профиля и \nерейти в авторизацию?", "Продажа товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    ((Navigation)Owner).Show();
                    e.Cancel = false;
                    Program.intID = "";
                    Program.strStatus = "";
                    Program.intDropStatic = 0;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            //Объявление экземпляра класса работы с хранимыми процедурами
            Procedure_Class procedure = new Procedure_Class();
            //Объявляем не типизированный лист
            ArrayList Employee_Update = new ArrayList();
            Employee_Update.Add(Program.intID);
            //Проверка заполнения плей ввода данных
            if (gridwork.NullCheck(tbs) == 0)
            {
                if (tbPassword.Text == tbConfernPassword.Text)
                {
                    Cyphering cyph = new Cyphering();
                    string logCyph = Cyphering.Code_Message(tbLogin.Text);
                    string passCyph = Cyphering.Code_Message(tbPassword.Text);
                    Employee_Update.Add(logCyph);
                    Employee_Update.Add(passCyph);
                    Employee_Update.Add(tbName.Text);
                    Employee_Update.Add(tbMiddle_Name.Text);
                    Employee_Update.Add(tbFirst_Name.Text);
                    Employee_Update.Add(Convert.ToInt32(tbPosition.SelectedValue));
                    procedure.procedure_Execution("Employee_Update", Employee_Update);
                }
                else MessageBox.Show("Не правильный пароль","",MessageBoxButtons.OK);
            }

            tbConfernPassword.Clear();
            tbPassword.Clear();
        }


        /// <summary>
        /// Метод вывод данных из БД на форму
        /// </summary>
        private void Klient_Data_Fill()
        {
            Action action = () =>
             {
                //Выгрузка данных о авторизированном клиенте
                Table_Class table_Class = new Table_Class("select [Employee_Name], [Employee_MiddleName], " +
                     "[Employee_Lastname], [Position_Name], [Login_Employee], [Password_Employee] " +
                     " from [dbo].[Employee] INNER JOIN" +
                 "[dbo].[Position] ON [dbo].[Employee].[Position_ID]= [dbo].[Position].[ID_Position] where [dbo].[Employee].[ID_Employee] = " + Program.intID);
                 Table_Class tablePos = new Table_Class("select [ID_Position], [Position_Name] from [dbo].[Position]");
                 tbPosition.DataSource = tablePos.table.DefaultView;
                 tbPosition.DisplayMember = "Position_Name";
                 tbPosition.ValueMember = "ID_Position";
                //Организация прослушивания сервера
                table_Class.Dependency.OnChange += Dependency_OnChange;
                //Присоение значений из table класса DateTable
                //Значений 0 строки и с 0 по шестой столбец
                Klient_First_Name = table_Class.table.Rows[0][2].ToString();
                 Klient_Name = table_Class.table.Rows[0][0].ToString();
                 Klient_Middle_Name = table_Class.table.Rows[0][1].ToString();
                 Login = table_Class.table.Rows[0][4].ToString();
                 Password = table_Class.table.Rows[0][5].ToString();
                 position = table_Class.table.Rows[0][3].ToString();
                //Перезапись значений в надписях форме
                lblKlient_Surname.Text = "Фамилия: " + Klient_First_Name;
                 lblKlient_Name.Text = "Имя: " + Klient_Name;
                 lblKlient_Middlename.Text = "Отчество: " + Klient_Middle_Name;
                 lblKlient_Create.Text = "" + Card_Create;
                 tbFirst_Name.Text = Klient_First_Name;
                 tbName.Text = Klient_Name;
                 tbMiddle_Name.Text = Klient_Middle_Name;
                 tbLogin.Text = Login;
                 lbPosition.Text = "Должность:" + position;
                 
                 ChartFill();
             };
            Invoke(action);
            
            //tbPosition.SelectedValue = "ID_Position";
            //dtpStartDate.Value = Convert.ToDateTime(Card_Create);
            
        }
        /// <summary>
        /// Метод динамического формирования чеков, у клиентов
        /// </summary>

        private void Dependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                Klient_Data_Fill();
        }

    }
}
