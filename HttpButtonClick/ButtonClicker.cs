using System.Net;
using System;
using hap = HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

namespace HttpButtonClick
{
    public class ButtonClicker
    {
        public string ButtonClick(string URI, string ButtonValue)
        {


            Uri uri = new Uri(URI);

            using (WebClient wc = new WebClient())
            {

                //Загружаем страницу HTML в string
                string HtmlString = wc.DownloadString(uri);


                //Создаем HtmlAgilityPack
                hap.HtmlDocument HtmlDoc = new hap.HtmlDocument();

                //Загружаем Html документ из строки
                HtmlDoc.LoadHtml(HtmlString);

                //Выбираем все формы на странице
                hap.HtmlNodeCollection formNodes = HtmlDoc.DocumentNode.SelectNodes("//form");

                List<HtmlFormValue> HtmlForms = new List<HtmlFormValue>();
                var AllInputs = new List<Inputitem>();
                if (formNodes != null)
                {
                    foreach (var formAtribute in formNodes)
                    {

                        HtmlFormValue FormAtribute = new HtmlFormValue
                        {
                            ActionForm = formAtribute.Attributes["action"].Value,
                            MethodForm = formAtribute.Attributes["method"].Value,
                            NameForm = formAtribute.Attributes["name"].Value
                        };

                        //Выбираем все imputs на форме
                        hap.HtmlNodeCollection inputsNodes = formAtribute?.SelectNodes("//input");

                        if (inputsNodes != null)
                        {
                            AllInputs = inputsNodes
                                .Select(x => new Inputitem
                                {
                                    InputName = x.Attributes["name"]?.Value ?? "",
                                    InputType = x.Attributes["type"].Value,
                                    InputValue = x.Attributes["value"]?.Value ?? "",
                                    FormAtribute = FormAtribute
                                }
                         ).ToList();
                        }
                        FormAtribute.ListInputs = AllInputs;
                        HtmlForms.Add(FormAtribute);
                    }


                    HtmlFormValue FindForm = AllInputs.First(x => x.InputName == ButtonValue).FormAtribute;


                    if (FindForm != null)
                    {
                        //Собираем запрос
                        //Указываем способ кодировки
                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        //добавляем параметры
                        string myParameters = string.Join("&", FindForm.GetInputsNameValue());
                        //Формируем строку на указанный ресурс
                        string uripath = $"{uri.AbsoluteUri}{FindForm.ActionForm}";
                        //отправляем и получаем результат
                        string HtmlResult = wc.UploadString(uripath, myParameters);
                        return HtmlResult;
                    }
                    else { return ""; }

                }
                else
                {

                    return "";
                }
            }
        }
    }
}