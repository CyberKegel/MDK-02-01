using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_AfekWinForms.Формы
{
    public partial class Connection_Form : Form
    {
        public Connection_Form()
        {
            InitializeComponent();
        }
        

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Connection_Form_Load(object sender, EventArgs e)
        {
            //Вызов класса конфигурации
            Configuration_Class configuration = new Configuration_Class();
            //Присовение event action событие
            configuration.Server_Collection += Configuration_Server_Collection;
            //Объявлеие экземпляра потока
            Thread threadServers = new Thread(configuration.SQL_Server_Enumuretor);
            //Запуск потока
            threadServers.Start();
        }

        private void Configuration_Server_Collection(DataTable obj)
        {
            //Вызов делегата для присовоения в него фрагмента кода
            //Через лямбда выражение => в делегат присваивается код
            Action action = () =>
            {
                //Для каждой стороки таблицы в выпадающий список
                //Дополнить коллекцию пунктов Server Name\Machine Name
                foreach (DataRow r in obj.Rows)
                {
                    cbServers.Items.Add(string.Format(@"{0}\{1}", r[0], r[1]));
                }
                cbServers.Enabled = true;
                btChecked.Enabled = true;
            };
            //Присвоение фонового потока в основной
            Invoke(action);
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            //Закрытие окна
            Close();
        }
        /// <summary>
        /// Метод вызова доступных баз данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration_Class configuration = new Configuration_Class();
            configuration.ds = cbServers.SelectedItem.ToString();
            configuration.Connection_Checked += Configuration_Connection_Checked;
            Thread thread = new Thread(configuration.SQL_Data_Base_Checking);
            thread.Start();
        }
        private void Configuration_Connection_Checked(bool obj)
        {
            switch (obj)
            {
                //Если подключение выполнено верно то появляется сообщение
                case true:
                    MessageBox.Show("Проверка выполнена!");
                    Action action = () =>
                    {
                        //Проверка метода выбора
                        Configuration_Class configuration_coll = new Configuration_Class();
                        configuration_coll.Data_Base_Collection += Configuration_Data_Base_Collection;
                        Thread threadBases = new Thread(configuration_coll.SQL_Data_Base_Collection);
                        threadBases.Start();
                        btConnecti.Enabled = true;
                    };
                    Invoke(action);
                    break;
                case false:
                    //Вслучае если нет подключения повторяется сбор данных
                    //о сервере
                    Configuration_Class configuration = new Configuration_Class();
                    configuration.Server_Collection += Configuration_Server_Collection;
                    Thread threadServers = new Thread(configuration.SQL_Server_Enumuretor);
                    threadServers.Start();
                    break;
            }
        }
        //Получение списка таблиц БД
        private void Configuration_Data_Base_Collection(DataTable obj)
        {
            Action action = () =>
            {
                foreach (DataRow r in obj.Rows)
                {
                    cbDatabases.Items.Add(r[0]);
                }
                cbDatabases.Enabled = true;
                btChecked.Enabled = true;
            };
            Invoke(action);
        }
        //Кнопка проверка подключения к источнику и базе данных
        private void BtChecked_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection(
            string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = true;", cbServers.Text, cbDatabases.Text));
            try
            {
                sql.Open();
                btConnecti.Enabled = true;
            }
            catch
            {

            }
            finally
            {
                sql.Close();
            }
        }
        //Подключение к источнику данных
        private void BtConnecti_Click(object sender, EventArgs e)
        {
            switch (cbDatabases.Text == "")
            {
                case true:
                    //В случае если поле не заполнено
                    MessageBox.Show("Не выбрана нужная база данных!", "Продажа товара", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbDatabases.Focus();
                    break;
                case false:
                    Configuration_Class configuration = new Configuration_Class();
                    //Присовение конфигурации в реестр ОС
                    configuration.SQL_Server_Configuration_Set(cbServers.Text, cbDatabases.Text);
                    //Присвоение в переменную значение
                    //о правильности подключения
                    Program.connect = true;
                    //Перезапуск программы
                    Application.Restart();
                    break;
            }
        }

    }
}
