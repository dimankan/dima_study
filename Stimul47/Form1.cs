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

namespace Stimul47
{
    public partial class Form1 : Form
    {
        private Stimulsoft.Report.StiReport stiReport1;
        private DataSet ds;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            stiReport1 = new Stimulsoft.Report.StiReport();
            ds = new DataSet();


        }
        private void button1_Click(object sender, EventArgs e)
        {

            stiReport1.Load(@"D:\Req.mrt");
            stiReport1.Design();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                Dictionary<string, string> data = new Dictionary<string, string>(){
                {"Face_short_NAME", "first" },
                {"Face_short_INN", "second" },
                {"Face_short_KPP", "thirt" },
                {"Face_short_KIO", "four" },
                {"Face_short_ADR", "five" },
                {"doc_num", "six" },
                {"perv_doc","seven" },
                {"perv_doc_num", "восемь"},
                {"perv_doc_date", "девять"},
                {"doc_date","десять" },
                {"Face", "одиннадцать"},
                {"reason_doc", "пятнат"},
                {"doc_srokd", "ййййййййй"},
                {"type_request", "цццццццццццц"},
                {"doc_org_naim_code", "ууууууууу"},
                {"doc_org_adres", "ккккккккккк"},
                {"Docs", "ффффффффффф"},
                {"doc_dolruk", "ыыыыыыыыы"},
                {"doc_org_naimR", "ввввввввв"},
                {"doc_chinruk", "ааааааааааа"},
                {"doc_fioruk", "яяяяяяяяяяяяя"},
                {"doc_poluchil", "ччччччччччч"},
                {"doc_srok", "сссссссссс"},
                {"DocUserFio", "мммммммммм"},
                {"DocUserPhone", "ииииииииии"},
                {" DocUserEmail", "ттттттттт" }
                };

                dt = FillDataTable(data);

                GetXML(dt);

                ds.Tables.Add(dt);

                stiReport1.RegData(ds);
                stiReport1.Load(@"C:\Users\ASUS\OneDrive\Рабочий стол\from rtf.mrt");
                stiReport1.Compile();
            }

            stiReport1.Show();
        }


        public static DataTable FillDataTable(Dictionary<string, string> dict)
        {
            DataTable dt = new DataTable();
            List<object> obj = new List<object>();

            foreach (var item in dict)
            {
                dt.Columns.Add(new DataColumn($"{item.Key}", typeof(string)));
                obj.Add(item.Value);
            }

            dt.Rows.Add(obj.ToArray());
            dt.AcceptChanges();

            return dt;
        }

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

        private static void GetXML(DataTable dataTable1)
        {
            dataTable1.TableName = "DataTable";
            string path = @"D:\1.txt";
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                dataTable1.WriteXml(stream);
            }
        }

        #region Old Filling
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
    }
}
