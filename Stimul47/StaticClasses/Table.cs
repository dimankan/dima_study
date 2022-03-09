using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stimul47.StaticClasses
{
    internal static class Table
    {
        public static DataTable Create(Dictionary<string, string> dict)
        {
            DataTable dt = new DataTable();
            dt.TableName = "DataTable1";
            List<object> obj = new List<object>();
            var row = dt.NewRow();

            foreach (var item in dict)
            {
                try
                {
                    row[$"{item.Key}"] = item.Value;
                }
                catch (Exception)
                {

                    dt.Columns.Add(new DataColumn($"{item.Key}", typeof(string)));
                    row[$"{item.Key}"] = item.Value;

                }
            }
            dt.Rows.Add(row);

            return dt;
        }

        #region Неактуальные методы
        /// <summary>
        /// Формирование DataTable из словаря
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
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
        private static DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn($"vno_naim", typeof(string)));
            dt.Columns.Add(new DataColumn($"head_org_naim", typeof(string)));
            dt.Columns.Add(new DataColumn($"head_org_naimk", typeof(string)));
            dt.Columns.Add(new DataColumn($"head_org_adres", typeof(string)));
            dt.Columns.Add(new DataColumn($"head_org_tel", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_num", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_date", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_num_ish", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_naimFU", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_naimFUT", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_naim", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_naimR", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_naimV", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_naimT", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_naim_code", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_adres", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_org_tel", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_nasel", typeof(string)));
            dt.Columns.Add(new DataColumn($"FaceR", typeof(string)));
            dt.Columns.Add(new DataColumn($"FaceD", typeof(string)));
            dt.Columns.Add(new DataColumn($"FaceT", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face_shortR", typeof(string)));
            dt.Columns.Add(new DataColumn($"FaceADR", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face_short", typeof(string)));
            dt.Columns.Add(new DataColumn($"DocUserDol", typeof(string)));
            dt.Columns.Add(new DataColumn($"DocUserFio", typeof(string)));
            dt.Columns.Add(new DataColumn($"DocUserPhone", typeof(string)));
            dt.Columns.Add(new DataColumn($"DocUserEmail", typeof(string)));
            dt.Columns.Add(new DataColumn($"face_inn", typeof(string)));
            dt.Columns.Add(new DataColumn($"face_kpp", typeof(string)));
            dt.Columns.Add(new DataColumn($"ckpp", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_chinruk", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_chinrukFL", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_chinrukRFL", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_dolrukR", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_dolrukD", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_dolrukRFL", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_dolruk", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_dolrukFL", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_dolrukFU", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_fioruk", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_fiorukR", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_fiorukRFU", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_fiorukD", typeof(string)));
            dt.Columns.Add(new DataColumn($"reason_doc", typeof(string)));
            dt.Columns.Add(new DataColumn($"perv_doc", typeof(string)));
            dt.Columns.Add(new DataColumn($"perv_doc_num", typeof(string)));
            dt.Columns.Add(new DataColumn($"perv_doc_date", typeof(string)));
            dt.Columns.Add(new DataColumn($"type_request", typeof(string)));
            dt.Columns.Add(new DataColumn($"Docs", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face_short_NAME", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face_short_INN", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face_short_KPP", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face_short_KIO", typeof(string)));
            dt.Columns.Add(new DataColumn($"Face_short_ADR", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_srokd", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_bank_inn", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_bank_kpp", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_bank_naim", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_bank_bik", typeof(string)));
            dt.Columns.Add(new DataColumn($"doc_bank_adres", typeof(string)));

            return dt;
        }

        #endregion
    }
}
