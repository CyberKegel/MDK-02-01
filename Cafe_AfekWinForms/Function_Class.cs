using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Utils;

namespace Cafe_AfekWinForms
{
    public class Function_Class
    {
        
        
        
        public DataTable Resttable = new DataTable();
        /// <summary>
        /// Вызов функций авторизации пользователя в системе для открытия сессии
        /// работы в программе
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        public void Authorization(string Login, string Password)
        {
            //Обращение к табличной функции
            Table_Class table = new Table_Class(string.Format("select [ID_Record] from [dbo].[AuthorizationViewBased] ('{0}', '{1}')", Login, Password));


            //Присвоение в статическую строковую переменную значений первичного ключа
            try
            {
                Program.intID = table.table.Rows[0][0].ToString();
            }
            catch { }
                //Проверка на пустоту первичного ключа
                //if (Program.intID != "")
                //{
                //    //Присвоение в статическую строковую переменную
                //    //статус значения Klient или Employee
                //    Program.strStatus = table.table.Rows[0][1].ToString();
                //    //Присовение статическую целочисленную в статус удаления либо 0 либо 1
                //    Program.intDropStatic = Convert.ToInt32(table.table.Rows[0][2].ToString());
                //}
                
            
        }
        public Function_Class()
        {

        }
        /// <summary>
        /// Вызов перегрузки метода собращения к функциям Microsoft SQL
        /// без формальных параметров
        /// </summary>
        /// <param name="Function_name"></param>
        /// <param name="tyзe_function"></param>
        public Function_Class(string Function_name, string type_function)
        {
            //Переменная нового запроса
            string query = "";
            //Сценарий заполнения query
            switch (type_function)
            {
                case "scalar":
                    //Формирование запроса на вывод данныз из скалярной функциии
                    query = string.Format(@"select [dbo].[{0}]()", Function_name);
                    break;
                case "table":
                    //Формирование запроса на вывод всех столбцов из табличной функции
                    query = string.Format(@"select * from [dbo].[{0}]()", Function_name);
                    break;
            }
            try
            {
                //Вызов класса Table_Data со сформированными запросами
                Table_Class table = new Table_Class(query);
                //Присвоение результата в табличную переменную
                Resttable = table.table;
            }
            catch
            {

            }
        }
        /// <summary>
        /// Вызов перегрузки класса с функциями Microsoft SQL Server
        /// для функций которые имеют в себе формальные параметры
        /// </summary>
        /// <param name="Function_name">Название функции</param>
        /// <param name="type_function">Тип функции: table или scalar</param>
        /// <param name="paramets">Не типизированный список аередаваемых параметров</param>
        public Function_Class(string Function_name, string type_function, ArrayList paramets)
        {
            //Объявление строковой переменной для формирования запроса
            string query = "";
            
                //Провеерка на тип функций
                switch (type_function)
                {
                    case "scalar":
                        //Формирование первой части скалярного запроса
                        query = string.Format(@"select [dbo].[{0}](", Function_name);
                        break;
                    case "table":
                        //Формирование первичной части табличного запроса
                        query = string.Format(@"select * from [dbo].[{0}](", Function_name);
                        break;
                }
                //Строковая переменная колекции параметров
                //Вторая часть любого запроса
                string list_param = "";
                //Условие на проверку количества параметров
                switch (paramets.Count)
                {
                    case 1:
                        //В случае если парасетров один запрос завершается
                        list_param += paramets[0].ToString() + ")";
                        break;
                    default:
                        //Перебор всех параметров из колекции ArrayList
                        foreach (object param in paramets)
                        {
                            //Присвоение в строковую переменную
                            //Полученный список параметров из перегрузки
                            list_param += param + ",";
                        }
                        //Удаление из полученной строки после запятой
                        list_param = list_param.Remove(list_param.Length);
                        //Закрывающая скобка запроса обращения к функции
                        list_param += ")";
                        break;
                }
                //Конкатенирование первой и второй части запроса
                query += list_param;
                //занесение запроса в класс Table_Class
                Table_Class table = new Table_Class(query);
                //Присовение результирующей таблицы в выходную таблицу
                Resttable = table.table;
            
            
        }
    }
}
