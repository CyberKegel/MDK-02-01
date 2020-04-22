using Cafe_AfekWinForms.Формы;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_AfekWinForms
{
    static class Program
    {
        public static Int32 intDropStatic = 0;
        //Проверка статуса учетной записи бан или небан
        public static string intID = "";
        public static string strStatus = "Null";
        public static bool connect = false;
        private static Mutex _instanse;
        private const string _app_Name = "Продажа_товаров";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            //Переменная переключатель определения запуска приложения
            bool Create_app;
            //Объявление эеземпляра класса нового виртуального процесса
            _instanse = new Mutex(true, _app_Name, out Create_app);
            if (Create_app)
            {
                try
                {
                    //В случае если процесс не найден в системе
                    //Сохдается экземпляр класса конфигурирации подключения
                    //к источнику данных
                    Configuration_Class configuration = new Configuration_Class();
                    //вызвается метод получения информации из реестра
                    configuration.SQL_Server_Configuration_Get();
                    //Попытка открыть подключения к источнику данных
                    Configuration_Class.connection.Open();
                    //В случае если подключение открыто
                    //в переменную присваетвается значения истины
                    connect = true;
                }
                catch
                {
                    //Стилистика элементов управления ОС
                    Application.EnableVisualStyles();
                    //Обязательная дрянь, хер зачем она нужна
                    Application.SetCompatibleTextRenderingDefault(false);
                    //конфигурация подключения к источнику данныз
                    Connection_Form connection = new Connection_Form();
                   // вывод окна подключения к источнику данных в режиме диалогового окна
                    connection.ShowDialog();
                }
                finally
                {
                    Configuration_Class.connection.Close();
                    //проверка состояния подключения к источнику данных
                    switch (connect)
                    {
                        case false:
                            MessageBox.Show("Ошибка подключения к источнику данных!", "Продажа товара", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(0);
                            break;
                        case true:
                            try
                            {
                                Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                Application.Run(new Authorization_Form());
                            }
                            catch
                            {
                                
                                
                                    //Application.EnableVisualStyles();
                                    //Application.SetCompatibleTextRenderingDefault(false);
                                    //Connection_Form connection = new Connection_Form();
                                    //connection.ShowDialog();
                            }
                            break;
                    }
                }
            }
            

            
           
        }
    }
}
