using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_AfekWinForms
{
    public class Procedure_Class
    {
        public Form form = new Form();
        SqlCommand command = new SqlCommand("", Configuration_Class.connection);
        /// <summary>
        /// Сетод обращения к любой хранимой процедуре Microsoft SQL Server
        /// </summary>
        /// <param name="Procedure_name"></param>
        /// <param name="fileld_value"></param>
        public void procedure_Execution(string Procedure_name, ArrayList fileld_value)
        {
            //Запрос на вывод списка параметров, конкретной хранимой процедуры
            //в зависимости от введенного разработчиком название Stored Procedure
            Table_Class table = new Table_Class(String.Format("select name from sys.parameters " +
            "where " +
            "object_id =" +
            " (select object_id from sys.procedures where name = '{0}')", Procedure_name));
            try
            {
                //Настройка SQLCommand для работы с хранимыми процедурами
                command.CommandType = CommandType.StoredProcedure;
                //Присвоение в текст команды названия хранимой процедуры
                command.CommandText = string.Format("[dbo].[{0}]", Procedure_name);
                //Отчистка параметров
                command.Parameters.Clear();
                for (int i = 0; i < table.table.Rows.Count; i++)
                {
                    //Сопоставление значимой коллекций в значения параметров
                    command.Parameters.AddWithValue(table.table.Rows[i][0].ToString(), fileld_value[i]);
                }
                //Открытия подключения
                Configuration_Class.connection.Open();
                //Объявление события на перехват сообщения из БД
                Configuration_Class.connection.InfoMessage += Connection_InfoMessage; ;
                //Выполнение запроса процедуры
                command.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                //Закрытие подключения
                Configuration_Class.connection.Close();
            }
        }
        /// <summary>
        /// Обработчик события о получении собщения с сервера БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            //Вывод сообщения с свервера в диалоговое окно
            System.Windows.Forms.MessageBox.Show(e.Message);
            //Снятие с события обработчика метода
            Configuration_Class.connection.InfoMessage -= Connection_InfoMessage;
        }
    }
}
