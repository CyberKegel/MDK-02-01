using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cafe_AfekWinForms
{
    public class Table_Class
    {
        public DataTable table = new DataTable();
        //Локальная переменная SqlCommand
        private SqlCommand command = new SqlCommand("", Configuration_Class.connection);
        //Глобальная переменная организации зависимости и прослушивания сервера
        public SqlDependency Dependency = new SqlDependency();
        /// <summary>
        /// Заполнение DataTable в зависимости от введенного SQL запросв
        /// </summary>
        /// <param name="SQL_Select_Query"></param>
        public Table_Class(string SQL_Select_Query)
        {
            command.Notification = null; //Отключение оповещений у команды
            command.CommandText = SQL_Select_Query; //Присвоение SQL запроса SqlCommand
            Dependency.AddCommandDependency(command); //Присвоение команды в связку
            try //Прослушивание
            {
                //Запуск прослушивания
                SqlDependency.Start(Configuration_Class.connection.ConnectionString);
                //Открытие подключения
                Configuration_Class.connection.Open();
                //Запись данных в табличном виде в виртуальную таблицу
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                //Вывод сообщения об ошибке
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрытие подключения
                Configuration_Class.connection.Close();
            }
        }
    }
}
