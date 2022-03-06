using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinForms_игры_с_дизайнером
{
    /// <summary>
    /// Получение массива элементов (Алиас или поле)
    /// </summary>
    public static class Separated
    {
        /// <summary>
        /// Создаем массив слов, в которых есть точка.
        /// </summary>
        /// <param name="str">Первичный запрос</param>
        /// <returns></returns>
        private static string[] FiltredTrash(string query)
        {

            string[] mas1 = query.Split(' ', ',', '\r', '\n');
            List<string> list = new List<string>();

            foreach (var item in mas1)
            {
                Regex regex = new Regex("[.]");
                bool match = regex.IsMatch(item);
                if (match)
                    list.Add(item.ToLower());
            }
            return list.ToArray();
        }
        /// <summary>
        /// Получаем с общего запроса массив алиасов
        /// </summary>
        /// <param name="mas"></param>
        /// <returns></returns>
        public static string[] GetAlias(string query)
        {
            string[] firstSepar = FiltredTrash(query);

            string[] result = new string[firstSepar.Length];

            for (int i = 0; i < firstSepar.Length; i++)
            {
                int index = firstSepar[i].IndexOf('.');
                result[i] = firstSepar[i].Substring(0, index);
            }
            return result;
        }
        /// <summary>
        /// Получаем массив полей
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static string[] GetFields(string query)
        {
            string[] firstSepar = FiltredTrash(query);

            string[] result = new string[firstSepar.Length];

            for (int i = 0; i < firstSepar.Length; i++)
            {
                int index = firstSepar[i].IndexOf('.');
                result[i] = firstSepar[i].Substring(index + 1);
            }
            return result;
        }
    }

}
