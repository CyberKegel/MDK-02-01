using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using word = Microsoft.Office.Interop.Word;
using excel = Microsoft.Office.Interop.Excel;
using System.Data;
using static Utils.Document_Class;
using Cafe_AfekWinForms;

namespace Utils
{
    public class Document_Class
    {
        public enum Document_Type
        {
            Report, Statistic
        }

        public enum Document_format
        {
            Word, Excel, PDF
        }

        public void Document_Create(Document_Type type, Document_format format, string name, DataTable table)
        {
            Configuration_Class configuration_Class = new Configuration_Class();
            configuration_Class.Document_configuration_Get();
            switch (name != "" || name != null)
            {
                case true:
                    switch (format)
                    {
                        case Document_format.Word:
                            word.Application application = new word.Application();
                            word.Document document = application.Documents.Add(Visible: true);
                            try
                            {
                                word.Range range = document.Range(0, 0);
                                document.Sections.PageSetup.LeftMargin = application.CentimetersToPoints((float)Configuration_Class.doc_Left_Merge);
                                document.Sections.PageSetup.TopMargin = application.CentimetersToPoints((float)Configuration_Class.doc_Top_Merge);
                                document.Sections.PageSetup.RightMargin = application.CentimetersToPoints((float)Configuration_Class.doc_Right_Merge);
                                range.Text = Configuration_Class.Organization_Name;
                                //Выравнивание
                                range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                                //Интревал
                                range.ParagraphFormat.SpaceAfter = 1;
                                range.ParagraphFormat.SpaceBefore = 1;
                                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                                range.Font.Name = "Times New Roman";
                                range.Font.Size = 12;
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                word.Paragraph Document_Name = document.Paragraphs.Add();
                                Document_Name.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                                Document_Name.Range.Font.Name = "Times New Roman";
                                Document_Name.Range.Font.Size = 16;





                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                word.Paragraph statparg = document.Paragraphs.Add();
                                //Создание области таблицы в документе
                                word.Table stat_table
                                //ие таблицы в области документа
                                //указывается  параграф в котором документ создан
                                //Количество строк и столбцов
                                = document.Tables.Add(statparg.Range, table.Rows.Count, table.Columns.Count);
                                //Настройка границ таблицы внутренние
                                stat_table.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                                //Настройка границ таблицы внешние
                                stat_table.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                                //Выравнивание текста внутри ячеек по ширине
                                stat_table.Rows.Alignment = word.WdRowAlignment.wdAlignRowCenter;
                                //Выравнивание текста внутри ячеек по высоте
                                stat_table.Range.Cells.VerticalAlignment = word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                stat_table.Range.Font.Size = 11;
                                stat_table.Range.Font.Name = "Times New Romman";
                                //Индексикация столбцов и строк в Word начинается с 1,1
                                for (int row = 1; row <= table.Rows.Count; row++)
                                    for (int col = 1; col <= table.Columns.Count; col++)
                                    {
                                        stat_table.Cell(row, col).Range.Text = table.Rows[row - 1][col - 1].ToString();
                                    }
                                document.Paragraphs.Add();
                                document.Paragraphs.Add();
                                //Параграф с фиксацией даты слздания документа
                                word.Paragraph Footparg = document.Paragraphs.Add();
                                Footparg.Range.Text = string.Format("Дата создания \t\t\t{0}", DateTime.Now.ToString("dd.MM.yyyy"));
                            }
                            catch
                            {

                            }
                            finally
                            {
                                switch (format)
                                {
                                    case Document_format.Word:
                                        //Сохранение документа с названием из метода и формата doc
                                        document.SaveAs2(name, word.WdSaveFormat.wdFormatDocument);
                                        break;
                                    case Document_format.PDF:
                                        //Сохранение документа в формате PDF
                                        document.SaveAs2(name, word.WdSaveFormat.wdFormatPDF);
                                        break;
                                }
                                //Закрываем документ
                                document.Close();
                                //Выходим из процесса с его закрытием
                                application.Quit();
                            }
                            break;
                        case Document_format.Excel:
                            //Создание процесса Excel
                            excel.Application application_ex = new excel.Application();
                            //Создание книги
                            excel.Workbook workbook = application_ex.Workbooks.Add();
                            //Создание страницы
                            excel.Worksheet worksheet = (excel.Worksheet)workbook.ActiveSheet;
                            try
                            {
                                switch (type)
                                {
                                    case Document_Type.Report:
                                        //Название страницы
                                        worksheet.Name = "Отчёт";
                                        for (int row = 0; row < table.Rows.Count; row++)
                                            for (int col = 0; col < table.Columns.Count; col++)
                                            {
                                                worksheet.Cells[row + 1][col + 1] = table.Rows[row][col].ToString();
                                                //Указание диапазона работы с ячееками листа
                                                excel.Range border
                                                  //Начало диапазона
                                                  = worksheet.Range[worksheet.Cells[1, 1],
                                                  //Динамический конец диапазона в зависимости от выходимых данных
                                                  worksheet.Cells[table.Rows.Count + 1]
                                                  [table.Columns.Count + 1]];
                                                //Стиль линий границ ячеек
                                                border.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                                                //Выравнивание во высоте
                                                border.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                                                //Выравнивание по ширине
                                                border.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                                                //Внесение даты создания документа
                                                worksheet.Cells[table.Rows.Count + 3][2] = string.Format("Дата создания {0}", DateTime.Now.ToString());
                                                //Объединение ячеек
                                                worksheet.Range[worksheet.Cells[table.Rows.Count + 3, 2], worksheet.Cells[table.Rows.Count + 2, table.Columns.Count + 2]].Merge();
                                            }
                                        break;
                                    case Document_Type.Statistic:
                                        worksheet.Name = "Статический отчёт";
                                        for (int row = 0; row < table.Rows.Count; row++)
                                        {
                                            for (int col = 0; col < table.Columns.Count; col++)
                                            {
                                                worksheet.Cells[row + 1][col + 1] = table.Rows[row][col].ToString();
                                            }
                                        }
                                        excel.Range border1 = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[table.Rows.Count + 1][table.Columns.Count + 1]];
                                        border1.Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                                        border1.VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                                        border1.HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                                        worksheet.Cells[table.Rows.Count + 3][2] = string.Format("Дата создания {0}", DateTime.Now.ToString());
                                        worksheet.Range[worksheet.Cells[table.Rows.Count + 3, 2], worksheet.Cells[table.Rows.Count + 2, table.Columns.Count + 2]].Merge();
                                        //Класс области графики
                                        excel.ChartObjects chartObjects = (excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
                                        //Область размещения графиков: отступы слева сверху, размер ширина и высота
                                        excel.ChartObject chartObject = chartObjects.Add(300, 50, 250, 250);
                                        //Объявление области графики
                                        excel.Chart chart = chartObject.Chart;
                                        //Объявление коллекции построений графиков
                                        excel.SeriesCollection seriesCollection = (excel.SeriesCollection)chart.SeriesCollection(Type.Missing);
                                        //Объявление построения графиков
                                        excel.Series series = seriesCollection.NewSeries();
                                        //Тип графика
                                        chart.ChartType = excel.XlChartType.xl3DColumn;
                                        //Диапазон значений по оси Х
                                        series.XValues = worksheet.get_Range("B2", "B" + table.Rows.Count + 1);
                                        //Диапазон значений по оси У
                                        series.Values = worksheet.get_Range("C2", "C" + table.Rows.Count + 1);
                                        break;

                                }
                            }
                            catch
                            {


                            }
                            finally
                            {
                                //Сохранение книги
                                worksheet.SaveAs(name, application_ex.DefaultSaveFormat);
                                //Закрытие книги
                                workbook.Close();
                                //Завершение процесса
                                application_ex.Quit();
                            }
                            break;


                    }
                    break;
                case false:
                    System.Windows.Forms.MessageBox.Show("Введите название документа");
                    break;

            }
        }
    }
}
