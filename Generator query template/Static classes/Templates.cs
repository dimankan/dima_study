using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_игры_с_дизайнером.Static_classes
{
    /// <summary>
    /// Работа с шаблоном
    /// </summary>
    public class Templates
    {
        /// <summary>
        /// Генерация string с готовым query
        /// </summary>
        /// <param name="nameTemp"></param>
        /// <param name="listAlias"></param>
        /// <param name="listFields"></param>
        /// <param name="listType"></param>
        /// <returns></returns>
        private static string FormationColumns(string nameTemp, List<string> listAlias, List<string> listFields, List<string> listType)
        {

            #region Вверхняя часть шаблона
            string upText = $@"<?xml version=""1.0"" encoding=""utf-8"" ?>
<QueryTemplateContainer xmlns=""http://CommonComponents/Templates/QueryTemplate.xsd""
                        name=""{nameTemp}""
                        version=""""
                        dalProvider=""Oracle""
                        dalModule=""RvcVio.ThesAccess.Oracle.Dal""
                        dalScheme=""empty""
                        dalObject=""empty"">
  <Description xmlns=""http://CommonComponents/Templates/Templates.xsd"">
    Navigator test
  </Description>
  <!--Опционально Permissions - Разрешения-->
  <!--<Permissions xmlns=""http://CommonComponents/Templates/Templates.xsd"">
    <Permission type=""O""
      name=""AdmNar.O_AdmNar_VK""
    	access=""allow""/>
  </Permissions>-->
  <Query name=""{nameTemp}""
  			 defaultSelect=""select0"">
    <!--Опцианальны Parameters-->
    <!--<Parameters>
      <Parameter name=""code_no"" type=""string""/>
      <Parameter name=""datefrom"" type=""datetime"" />
      <Parameter name=""dateto"" type=""datetime"" />
    </Parameters>-->
    <Select name=""select0"">
      <!--Опцианально SqlParameter-->
      <!--<SqlParameter name=""code_no"" oraDbType=""varchar2"" type=""string""/>
      <SqlParameter name=""datefrom"" oraDbType=""date"" type=""datetime"" />
      <SqlParameter name=""dateto"" oraDbType=""date"" type=""datetime"" />-->
";
            #endregion
            #region Нижняя часть шаблона
            string downText = $@"      <!--From и Join нужно доделать-->
      <From>
        <!--<Table scheme=""VIO$INF"" name=""rfn_doc"" alias=""d""/>-->
      </From>
      <Join mode=""LEFT"">
        <!--<Table scheme=""VIO$INF"" name=""R$RFN_DOC"" alias=""rd"" />
        <On>d.doc_type = rd.id</On>-->
      </Join>
      <!--Опционально-->
      <!--<Where>
        <Expression>
          (dvk.CODE_NO=:code_no OR '9965'=:code_no OR '0000'=:code_no OR '9961'=:code_no OR
          dvk.CODE_NO IN  (SELECT KOD
          FROM MDM_LOCAL.THES_SOUN SOUN
          WHERE SOUN.KODV = :code_no AND
          SOUN.IS_CLOSED = 0 AND SOUN.IS_ANNULED = 0 AND SOUN.TRS_CANCEL_ID IS NULL AND SYSDATE BETWEEN DATE_FROM AND DATE_TO
          )
          )
          and (d.doc_date between :datefrom and :dateto or d.doc_date is null)
          and (ds.status_doc = 30)
        </Expression>
      </Where>-->
      <!--Опционально-->
      <!--Order>
        <Item>
          <Field table=""d""  column=""doc_date"" />
        </Item>
      </Order>-->
    </Select>
  </Query>
</QueryTemplateContainer>";
            #endregion


            string columns = String.Empty;
            for (int i = 0; i < listAlias.Count(); i++)
            {
                switch (listType[i])
                {
                    case "string":
                    case "decimal":
                        columns += $"<Column name=\"{listFields[i]}\" type=\"{listType[i]}\" column=\"{listFields[i]}\" table=\"{listAlias[i]}\"/>\n";
                        break;
                    case "date":
                        columns += $"<Column name=\"{listFields[i]}\" type=\"{listType[i]}\" column=\"{listFields[i]}\" table=\"{listAlias[i]}\" options=\"DataSetDateTime.Unspecified\"/>\n";
                        break;
                    default:
                        break;
                }
            }
            return $"{upText}\n<Columns>\n{columns}\n</Columns>\n{downText}";
        }
        /// <summary>
        /// Генерация и сохранение шаблона по определенному адресу
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <param name="listAlias"></param>
        /// <param name="listFields"></param>
        /// <param name="listType"></param>
        public static void SaveFiles(string path, string name, List<string> listAlias, List<string> listFields, List<string> listType)
        {
            string fullName = $"{path}/{name}.txt";

            string text = FormationColumns(name, listAlias, listFields, listType);

            using (FileStream file = new FileStream(fullName, FileMode.Create))
            {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    stream.WriteLine(text);
                }
            }

        }
    }
}
