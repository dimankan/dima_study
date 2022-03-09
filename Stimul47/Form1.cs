using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using System.IO;
using System.Diagnostics;
using Stimul47.StaticClasses;

namespace Stimul47
{
    public partial class Form1 : Form
    {
        #region Данные

        private Stimulsoft.Report.StiReport stiReport1;
        private DataSet ds;

        Dictionary<string, string> dataRFNDocRequestOrg;
        Dictionary<string, string> dataRFNDocRequestBank;

        DataTable dtRFNDocRequestOrg;
        DataTable dtRFNDocRequestBank;

        #endregion

        #region Инициализация
        public Form1()
        {
            InitializeComponent();
            InitialData();
        }

        void InitialData()
        {
            stiReport1 = new Stimulsoft.Report.StiReport();

            ds = new DataSet();

            dataRFNDocRequestOrg = new Dictionary<string, string>(){
                {"Face_short_NAME", "Общество с ограниченной ответственностью Перонос"},
                {"Face_short_INN", " ИНН: 5252000625"},
                {"Face_short_KPP", " КПП: 525201001"},
                {"Face_short_KIO", " "},
                {"Face_short_ADR", "606107,РОССИЯ,Нижегородская обл, Павлово г, Цветочная ул,3, "},
                {"doc_num", "52002206700094"},
                {"perv_doc", " "},
                {"perv_doc_num", " "},
                {"perv_doc_date", " "},
                {"doc_date", "08.03.2022"},
                {"reason_doc", "c подготовкой к проведению проверки соблюдения требований валютного законодательства Российской Федерации и актов органов валютного регулирования"},
                {"Face", "Общество с ограниченной ответственностью Перонос,  ИНН: 5252000625 КПП: 525201001 ОГРН: 1145252237778"},
                {"doc_srokd", "23"},
                {"type_request", "запроса"},
                {"doc_org_naim_code", "Управление Федеральной налоговой службы по Нижегородской области код: 5200"},
                {"doc_org_adres", "603005,Нижегородская обл,Нижний Новгород г,Минина ул,20"},
                {"Docs", "2) информацию (сведения): 2.1 23, "},
                {"doc_dolruk", "Начальник"},
                {"doc_org_naimR", "Управления Федеральной налоговой службы по Нижегородской области"},
                {"doc_chinruk", "Действительный государственный советник Российской Федерации 1 класса"},
                {"doc_fioruk", "Воробьев Дмитрий "},
                {"doc_poluchil", " "},
                {"doc_srok", " "},
                {"DocUserFio", "Воробьев Д."},
                {"DocUserPhone", " "},
                {"DocUserEmail", " "}
                };
            dataRFNDocRequestBank = new Dictionary<string, string>(){
                {"vno_naim", " "},
                {"head_org_naim", "УПРАВЛЕНИЕ ФЕДЕРАЛЬНОЙ НАЛОГОВОЙ СЛУЖБЫ ПО НИЖЕГОРОДСКОЙ ОБЛАСТИ"},
                {"head_org_naimk", "УФНС России по Нижегородской области"},
                {"head_org_adres", "603005,Нижегородская обл,Нижний Новгород г,Минина ул,20"},
                {"head_org_tel", "831 439-01-11, факс: 831 439-05-95"},
                {"doc_bank_naim", "ПУБЛИЧНОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО \"СОВКОМБАНК\""},
                {"doc_bank_inn", "ИНН: 4401116480"},
                {"doc_bank_kpp", "КПП: 440101001"},
                {"doc_bank_bik", "БИК: 043469743"},
                {"doc_bank_adres", "156000,РОССИЯ,КОСТРОМСКАЯ ОБЛ,,КОСТРОМА Г,,ТЕКСТИЛЬЩИКОВ ПР-КТ,ДОМ 46,,"},
                {"doc_num", "52002206700095"},
                {"perv_doc", " "},
                {"perv_doc_num", " "},
                {"perv_doc_date", " "},
                {"doc_date", "08.03.2022"},
                {"reason_doc", "c подготовкой к проведению проверки соблюдения требований валютного законодательства Российской Федерации и актов органов валютного регулирования"},
                {"Face", "Абросимова Александра Александровна,  ИНН: 525208242572"},
                {"doc_srokd", "7"},
                {"type_request", "запроса"},
                {"doc_org_naim_code", "Управление Федеральной налоговой службы по Нижегородской области код: 5200"},
                {"doc_org_adres", "603005,Нижегородская обл,Нижний Новгород г,Минина ул,20"},
                {"Docs", "1) документы:\n 1.1 ываыв,  от 25.11.2021"},
                {"doc_dolruk", "Начальник"},
                {"doc_org_naimR", "Управления Федеральной налоговой службы по Нижегородской области"},
                {"doc_chinruk", "Действительный государственный советник Российской Федерации 1 класса"},
                {"doc_fioruk", "Воробьев Дмитрий "},
                {"DocUserFio", "Воробьев Д."},
                {"DocUserPhone", " "},
                {"DocUserEmail", " "}
                };
        }


        #endregion

        #region Действия

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "1125008 RFNDocRequestOrg";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1123303 RFNDocRequestBank")
            {
                DataTable dt = Table.Create(dataRFNDocRequestBank);

                tbPath.Text = "..\\Data\\1123303 RFNDocRequestBank.mrt";

                ds.Tables.Clear();
                ds.Tables.Add(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "1125008 RFNDocRequestOrg")
            {
                DataTable dt = Table.Create(dataRFNDocRequestOrg);

                tbPath.Text = "..\\Data\\1125008 RFNDocRequestOrg.mrt";

                ds.Tables.Clear();
                ds.Tables.Add(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            tbPath.Text = Selector.ChooseFile("Шаблон Stimulsoft |*.mrt");
        }
        private void buttonWriteXml_Click(object sender, EventArgs e)
        {
            try
            {
                XML.Get(dataGridView1.DataSource as DataTable);

            }
            catch (Exception)
            {

            }
        }
        private void buttonRunDesign_Click(object sender, EventArgs e)
        {
            stiReport1.Load(tbPath.Text);
            stiReport1.Design();
        }
        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource as DataTable == null)
            {
                MessageBox.Show("Грид пустой. Выберите шаблон, и в гриде появятся данные.");
                return;
            }
            try
            {
                stiReport1.RegData(dataGridView1.DataSource as DataTable);
                stiReport1.Load(tbPath.Text);
                stiReport1.Compile();


                stiReport1.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonExportPDF_Click(object sender, EventArgs e)
        {
            stiReport1.RegData(dataGridView1.DataSource as DataTable);
            stiReport1.Load(tbPath.Text);
            stiReport1.Compile();
            stiReport1.Render();

            string path = Selector.SaveFile("PDF files (*.pdf)|*.pdf");
            stiReport1.ExportDocument(StiExportFormat.Pdf, path);
            Selector.DialogOpenFile(path);
        }


        #endregion


        #region Черновик
        #region Old Filling. Before FillDataTable()
        /// <summary>
        /// Заполнение шаблона, в котором используются переменные (Не по XSD схеме)
        /// </summary>
        private void WithoutXML()
        {
            stiReport1.Load(@"C:\Users\ASUS\OneDrive\Рабочий стол\from rtf.mrt");
            stiReport1.Compile();
            //Set Variables
            stiReport1["Face_short_NAME"] = "Name ololName ololName ololName ololName ololName ololName olol";
            stiReport1["Face_short_INN"] = "INN olol";
            stiReport1["Face_short_KPP"] = "KPP olol";
            stiReport1["Face_short_KIO"] = "KIO olol";
            stiReport1["Face_short_ADR"] = "ADR olol";
            stiReport1["doc_num"] = "sad 2222";
        }



        /*
        dataTable1.Columns.Add("Key", type: typeof(string));
        dataTable1.Columns.Add("Value", type: typeof(string));

        dataTable1.Rows.Add(new object[] { "Face_short_NAME", "ssssssssss" });
        dataTable1.Rows.Add(new object[] { "Face_short_INN", "qqqqqqqqqqqqq" });
        dataTable1.Rows.Add(new object[] { "Face_short_KPP", "zzzzzzzzzzzz" });
        dataTable1.Rows.Add(new object[] { "Face_short_KIO", "sssssssssssdd" });
        dataTable1.Rows.Add(new object[] { "Face_short_ADR", "ggggggggggggg" });
        dataTable1.Rows.Add(new object[] { "doc_num", "hhhhhhhhhhhhh" });
        dataTable1.AcceptChanges(); 
        */
        #endregion

        //        /*
        //          public partial class Form1 : Form
        //    {
        //        #region Данные

        //        private Stimulsoft.Report.StiReport stiReport1;
        //        private DataSet ds;

        //        Dictionary<string, string> dataRFNDocRequestOrg;
        //        Dictionary<string, string> dataRFNDocRequestBank;

        //        DataTable dtRFNDocRequestOrg;
        //        DataTable dtRFNDocRequestBank;

        //        #endregion

        //        #region Инициализация
        //        public Form1()
        //        {
        //            InitializeComponent();

        //            InitialData();
        //        }
        //        void InitialData()
        //        {
        //            stiReport1 = new Stimulsoft.Report.StiReport();

        //            ds = new DataSet();

        //            dataRFNDocRequestOrg = new Dictionary<string, string>(){
        //                {"Face_short_NAME", "Общество с ограниченной ответственностью Перонос"},
        //                {"Face_short_INN", " ИНН: 5252000625"},
        //                {"Face_short_KPP", " КПП: 525201001"},
        //                {"Face_short_KIO", " "},
        //                {"Face_short_ADR", "606107,РОССИЯ,Нижегородская обл, Павлово г, Цветочная ул,3, "},
        //                {"doc_num", "52002206700094"},
        //                {"perv_doc", " "},
        //                {"perv_doc_num", " "},
        //                {"perv_doc_date", " "},
        //                {"doc_date", "08.03.2022"},
        //                {"reason_doc", "c подготовкой к проведению проверки соблюдения требований валютного законодательства Российской Федерации и актов органов валютного регулирования"},
        //                {"Face", "Общество с ограниченной ответственностью Перонос,  ИНН: 5252000625 КПП: 525201001 ОГРН: 1145252237778"},
        //                {"doc_srokd", "23"},
        //                {"type_request", "запроса"},
        //                {"doc_org_naim_code", "Управление Федеральной налоговой службы по Нижегородской области код: 5200"},
        //                {"doc_org_adres", "603005,Нижегородская обл,Нижний Новгород г,Минина ул,20"},
        //                {"Docs", "2) информацию (сведения): 2.1 23, "},
        //                {"doc_dolruk", "Начальник"},
        //                {"doc_org_naimR", "Управления Федеральной налоговой службы по Нижегородской области"},
        //                {"doc_chinruk", "Действительный государственный советник Российской Федерации 1 класса"},
        //                {"doc_fioruk", "Воробьев Дмитрий "},
        //                {"doc_poluchil", " "},
        //                {"doc_srok", " "},
        //                {"DocUserFio", "Воробьев Д."},
        //                {"DocUserPhone", " "},
        //                {"DocUserEmail", " "}
        //                };
        //            dataRFNDocRequestBank = new Dictionary<string, string>(){
        //                {"vno_naim", " "},
        //                {"head_org_naim", "УПРАВЛЕНИЕ ФЕДЕРАЛЬНОЙ НАЛОГОВОЙ СЛУЖБЫ ПО НИЖЕГОРОДСКОЙ ОБЛАСТИ"},
        //                {"head_org_naimk", "УФНС России по Нижегородской области"},
        //                {"head_org_adres", "603005,Нижегородская обл,Нижний Новгород г,Минина ул,20"},
        //                {"head_org_tel", "831 439-01-11, факс: 831 439-05-95"},
        //                {"doc_bank_naim", "ПУБЛИЧНОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО \"СОВКОМБАНК\""},
        //                {"doc_bank_inn", "ИНН: 4401116480"},
        //                {"doc_bank_kpp", "КПП: 440101001"},
        //                {"doc_bank_bik", "БИК: 043469743"},
        //                {"doc_bank_adres", "156000,РОССИЯ,КОСТРОМСКАЯ ОБЛ,,КОСТРОМА Г,,ТЕКСТИЛЬЩИКОВ ПР-КТ,ДОМ 46,,"},
        //                {"doc_num", "52002206700095"},
        //                {"perv_doc", " "},
        //                {"perv_doc_num", " "},
        //                {"perv_doc_date", " "},
        //                {"doc_date", "08.03.2022"},
        //                {"reason_doc", "c подготовкой к проведению проверки соблюдения требований валютного законодательства Российской Федерации и актов органов валютного регулирования"},
        //                {"Face", "Абросимова Александра Александровна,  ИНН: 525208242572"},
        //                {"doc_srokd", "7"},
        //                {"type_request", "запроса"},
        //                {"doc_org_naim_code", "Управление Федеральной налоговой службы по Нижегородской области код: 5200"},
        //                {"doc_org_adres", "603005,Нижегородская обл,Нижний Новгород г,Минина ул,20"},
        //                {"Docs", "1) документы:\n 1.1 ываыв,  от 25.11.2021"},
        //                {"doc_dolruk", "Начальник"},
        //                {"doc_org_naimR", "Управления Федеральной налоговой службы по Нижегородской области"},
        //                {"doc_chinruk", "Действительный государственный советник Российской Федерации 1 класса"},
        //                {"doc_fioruk", "Воробьев Дмитрий "},
        //                {"DocUserFio", "Воробьев Д."},
        //                {"DocUserPhone", " "},
        //                {"DocUserEmail", " "}
        //                };

        //            dtRFNDocRequestOrg = CreateDataTable(dataRFNDocRequestOrg);
        //            dtRFNDocRequestBank = CreateDataTable(dataRFNDocRequestBank);
        //        }





        //        #endregion

        //        #region Действия


        //        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //        {
        //            if (comboBox1.Text == "1123303 RFNDocRequestBank")
        //            {
        //                tbPath.Text = "..\\Data\\1123303 RFNDocRequestBank.mrt";

        //                //if (ds.Tables.Count != 0)
        //                //{
        //                //    ds.Tables.Clear();
        //                //}
        //                //if (dt.Rows.Count != 0)
        //                //{
        //                //    dt.Rows.Clear();
        //                //}
        //                //DataTable dt = new DataTable();
        //                //AddRowDt(dt, dataRFNDocRequestBank);
        //                //ds.Tables.Add(dt);
        //                //dataGridView1.Columns.AddRange();
        //                //dataGridView1.DataSource = ds;

        //                dataGridView1.DataSource = dtRFNDocRequestBank;
        //            }
        //            if (comboBox1.Text == "1125008 RFNDocRequestOrg")
        //            {
        //                tbPath.Text = "..\\Data\\1125008 RFNDocRequestOrg.mrt";

        //                //if (ds.Tables.Count != 0)
        //                //{
        //                //    ds.Tables.Clear();
        //                //}
        //                ////if (dt.Rows.Count != 0)
        //                ////{
        //                ////    dt.Rows.Clear();
        //                ////}
        //                //DataTable dt = new DataTable();
        //                //AddRowDt(dt, dataRFNDocRequestOrg);
        //                //ds.Tables.Add(dt);
        //                //dataGridView1.DataSource = ds;

        //                dataGridView1.DataSource = dtRFNDocRequestOrg;
        //            }
        //        }

        //        private void buttonChooseFile_Click(object sender, EventArgs e)
        //        {
        //            tbPath.Text = StaticClasses.Select.ChooseFile("Шаблон Stimulsoft |*.mrt");
        //        }
        //        private void buttonWriteXml_Click(object sender, EventArgs e)
        //        {
        //            if (ds.Tables.Count != 0)
        //            {
        //                ds.Tables.Clear();
        //            }
        //            try
        //            {
        //                //String s=datagridview1[1, dataGridView1.CurrentRow.Index].Value.ToString();
        //                DataGridView dgv2 = new DataGridView();

        //                //dgv2 = dataGridView1.CurrentRow;
        //                var dtFromDs = dataGridView1.DataSource as DataTable;
        //                var colum = dtFromDs.Columns;
        //                //var row = x.Rows[0];

        //                DataTable dt = dtFromDs.Clone();
        //                object[] copyrow = dt.Rows[dataGridView1.CurrentRow.Index].ItemArray; // отвязываю строку от таблицы, переводя в массив объектов
        //                dt.Rows.Add(copyrow); // добавляю созданный массив объектов назад в таблицу

        //                //dt.Rows.Add(row);
        //                GetXML(dt);
        //                //dgv2.Columns.AddRange(dataGridView1.Columns);
        //                //dgv2.Rows.Add(dataGridView1.CurrentRow);
        //                ////GetXML((DataTable)dataGridView1.DataSource);
        //                //GetXML((DataTable)dgv2.DataSource);
        //            }
        //            catch (Exception)
        //            {
        //                return;
        //            }
        //        }
        //        private void buttonRunDesign_Click(object sender, EventArgs e)
        //        {
        //            stiReport1.Load(tbPath.Text);
        //            stiReport1.Design();
        //        }
        //        private void buttonShowReport_Click(object sender, EventArgs e)
        //        {

        //            try
        //            {
        //                stiReport1.RegData(dataGridView1.DataSource as DataTable);
        //                stiReport1.Load(tbPath.Text);
        //                stiReport1.Compile();

        //                stiReport1.Show();
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Грид пустой. Выбери шаблон, и в гриде появятся данные.");
        //            }            //stiReport1.RegData(dataGridView1.CurrentRow.Clone() as DataTable);


        //            #region old
        //            /*
        //            DataTable dataTable = new DataTable();
        //            //var row = dataTable.NewRow();
        //            //row = ;

        //            //dataTable.Rows.Add(dataGridView1.CurrentRow.Clone() as DataRow);
        //            //dataTable.AcceptChanges();
        //            //ds.Tables.Add(dataTable);
        //            ds.Tables.Add(dataGridView1.DataSource as DataTable);

        //            stiReport1.RegData(ds);
        //            //stiReport1.RegData(dataGridView1.CurrentRow.Clone() as DataTable);
        //            stiReport1.Load(tbPath.Text);
        //            stiReport1.Compile();

        //            stiReport1.Show(); 
        //            */
        //            #endregion
        //        }
        //        #endregion

        //        #region Вспомогательные методы

        //        private DataTable CreateDataTable()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add(new DataColumn($"vno_naim", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"head_org_naim", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"head_org_naimk", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"head_org_adres", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"head_org_tel", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_num", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_date", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_num_ish", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_naimFU", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_naimFUT", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_naim", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_naimR", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_naimV", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_naimT", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_naim_code", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_adres", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_org_tel", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_nasel", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"FaceR", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"FaceD", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"FaceT", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face_shortR", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"FaceADR", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face_short", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"DocUserDol", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"DocUserFio", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"DocUserPhone", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"DocUserEmail", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"face_inn", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"face_kpp", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"ckpp", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_chinruk", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_chinrukFL", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_chinrukRFL", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_dolrukR", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_dolrukD", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_dolrukRFL", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_dolruk", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_dolrukFL", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_dolrukFU", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_fioruk", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_fiorukR", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_fiorukRFU", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_fiorukD", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"reason_doc", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"perv_doc", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"perv_doc_num", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"perv_doc_date", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"type_request", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Docs", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face_short_NAME", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face_short_INN", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face_short_KPP", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face_short_KIO", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"Face_short_ADR", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_srokd", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_bank_inn", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_bank_kpp", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_bank_naim", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_bank_bik", typeof(string)));
        //    dt.Columns.Add(new DataColumn($"doc_bank_adres", typeof(string)));

        //    return dt;
        //}

        //private DataTable CreateDataTable(Dictionary<string, string> dict)
        //{
        //    DataTable dt = new DataTable();

        //    List<object> obj = new List<object>();
        //    var row = dt.NewRow();

        //    foreach (var item in dict)
        //    {
        //        try
        //        {
        //            row[$"{item.Key}"] = item.Value;
        //        }
        //        catch (Exception)
        //        {

        //            dt.Columns.Add(new DataColumn($"{item.Key}", typeof(string)));
        //            row[$"{item.Key}"] = item.Value;

        //        }
        //    }
        //    dt.Rows.Add(row);

        //    return dt;
        //}

        ///// <summary>
        ///// Формирование DataTable из словаря
        ///// </summary>
        ///// <param name="dict"></param>
        ///// <returns></returns>
        //public static DataTable FillDataTable(Dictionary<string, string> dict)
        //{
        //    DataTable dt = new DataTable();
        //    List<object> obj = new List<object>();


        //    foreach (var item in dict)
        //    {
        //        dt.Columns.Add(new DataColumn($"{item.Key}", typeof(string)));
        //        obj.Add(item.Value);
        //    }

        //    dt.Rows.Add(obj.ToArray());
        //    dt.AcceptChanges();

        //    return dt;
        //}

        ///// <summary>
        ///// Записать данные из DataTable в txt или xml
        ///// </summary>
        ///// <param name="dataTable1"></param>
        //private static void GetXML(DataTable dataTable1)
        //{
        //    dataTable1.TableName = "DataTable";
        //    string path = StaticClasses.Select.SaveFile("txt files (*.txt)|*.txt|xml files (*.xml)|*.xml");
        //    using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
        //    {
        //        dataTable1.WriteXml(stream);
        //    }

        //    StaticClasses.Select.DialogOpenFile(path);
        //}

        //#endregion




        //#region Old Filling. Before FillDataTable()
        ///// <summary>
        ///// Заполнение шаблона, в котором используются переменные (Не по XSD схеме)
        ///// </summary>
        //private void WithoutXML()
        //{
        //    stiReport1.Load(@"C:\Users\ASUS\OneDrive\Рабочий стол\from rtf.mrt");
        //    stiReport1.Compile();
        //    //Set Variables
        //    stiReport1["Face_short_NAME"] = "Name ololName ololName ololName ololName ololName ololName olol";
        //    stiReport1["Face_short_INN"] = "INN olol";
        //    stiReport1["Face_short_KPP"] = "KPP olol";
        //    stiReport1["Face_short_KIO"] = "KIO olol";
        //    stiReport1["Face_short_ADR"] = "ADR olol";
        //    stiReport1["doc_num"] = "sad 2222";
        //}


        //        /*
        //        dataTable1.Columns.Add("Key", type: typeof(string));
        //        dataTable1.Columns.Add("Value", type: typeof(string));

        //        dataTable1.Rows.Add(new object[] { "Face_short_NAME", "ssssssssss" });
        //        dataTable1.Rows.Add(new object[] { "Face_short_INN", "qqqqqqqqqqqqq" });
        //        dataTable1.Rows.Add(new object[] { "Face_short_KPP", "zzzzzzzzzzzz" });
        //        dataTable1.Rows.Add(new object[] { "Face_short_KIO", "sssssssssssdd" });
        //        dataTable1.Rows.Add(new object[] { "Face_short_ADR", "ggggggggggggg" });
        //        dataTable1.Rows.Add(new object[] { "doc_num", "hhhhhhhhhhhhh" });
        //        dataTable1.AcceptChanges(); 
        //        */
        //        #endregion
        //    }



        #endregion


    }
}


