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
    public partial class Authorization_Form : Form
    {
        public Authorization_Form()
        {
            InitializeComponent();
        }
        private void BtEnter_Click(object sender, EventArgs e)
        {
            //Проверка на заполнение полей ввода
            switch (tbUser_Login.Text == "")
            {
                case true:
                    tbUser_Login.BackColor = Color.Red;
                    break;
                case false:
                    switch (tbUser_Password.Text == "")
                    {
                        case true:
                            tbUser_Password.BackColor = Color.Red;
                            break;
                        case false:
                           Function_Class function = new Function_Class();
                            string log = Cyphering.Code_Message(tbUser_Login.Text);
                            string pass = Cyphering.Code_Message(tbUser_Password.Text);
                            function.Authorization(log, pass);
                            
                            switch (Program.intID == "")
                            {
                                //Не верно введенные данные
                                case true:
                                    MessageBox.Show("Введенные данные не верны! Повторите ввод!", "Продажа товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    tbUser_Login.Clear();
                                    tbUser_Password.Clear();
                                    tbUser_Login.Focus();
                                    break;
                                case false:
                                    //Проверка на блокировку учеетной записи
                                    //switch (Program.intDropStatic)
                                   // {
                                       // case 1:
                                         //   MessageBox.Show("Вы временно заблокрованы в системе!\nОбратитесь к администратору!", "Продажа товаров", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        //    break;
                                       // case 0:
                                            Navigation profile_Klient = new Navigation();
                                            profile_Klient.Show(this);
                                            Hide();
                                         //   break;
                                   // }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }


        private void BtLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void back_Color(object sender, EventArgs e)
        {
            if (sender is TextBox)
                (sender as TextBox).BackColor = Color.White;
        }
      
        private void Button1_Click(object sender, EventArgs e)
        {
       
                Registration regis = new Registration();
                regis.ShowDialog(this);
                //Hide();
        
        }
    }
}
