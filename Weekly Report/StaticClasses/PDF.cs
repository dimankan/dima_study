using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Text.RegularExpressions;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;

namespace add_jpg_v1.StaticClases
{
    static class CreatePDF
    {
        public static bool MergePDFs(IEnumerable<string> fileNames, string targetPdf)
        {
            bool merged = true;
            using (FileStream stream = new FileStream(targetPdf, FileMode.Create))
            {
                Document document = new Document();
                PdfCopy pdf = new PdfCopy(document, stream);
                iTextSharp.text.pdf.PdfReader reader = null;
                try
                {
                    document.Open();
                    foreach (string file in fileNames)
                    {
                        reader = new iTextSharp.text.pdf.PdfReader(file);
                        pdf.AddDocument(reader);
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    merged = false;
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
                finally
                {
                    if (document != null)
                    {
                        document.Close();
                    }
                }
            }
            return merged;
        }
        public static void Numeric(string putFile)
        {
            byte[] bytes = File.ReadAllBytes(putFile);
            iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 22, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            using (MemoryStream stream = new MemoryStream())
            {
                iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(bytes);
                using (PdfStamper stamper = new PdfStamper(reader, stream))
                {
                    int pages = reader.NumberOfPages;
                    for (int i = 1; i <= pages; i++)
                    {

                        ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase((i + 1).ToString(), blackFont), 590f, 15f, 0);
                    }
                }
                bytes = stream.ToArray();
            }
            File.WriteAllBytes(putFile, bytes);
        }

        public static bool CreateWeekReport(string pathFolder)
        {
            List<string> mainList = new List<string>();

            string[] mainFolders = Directory.GetDirectories(pathFolder);
            foreach (var item in mainFolders)
            {
                bool flag = CreateReport(item);

                if (!flag) return false;

                mainList.Add(item + @"\Report.pdf");
            }

            string lastNameFolder = new DirectoryInfo(pathFolder).Name;

            try
            {

                MergePDFs(mainList, pathFolder + $@"\Weekly Report {lastNameFolder}.pdf");
                Numeric(pathFolder + $@"\Weekly Report {lastNameFolder}.pdf");

               // CompressPdf(pathFolder + $@"\Weekly Report {lastNameFolder}.pdf");

            }
            catch
            {
                MergePDFs(mainList, pathFolder + @"\Report Week.pdf");
                Numeric(pathFolder + @"\Report Week.pdf");
            }


            return true;
        }

        ////public static void CompressPdf(string targetPath)
        ////{
        ////    using (var stream = new MemoryStream(File.ReadAllBytes(targetPath)) { Position = 0 })
        ////    using (var source = PdfSharp.Pdf.IO.PdfReader.Open(stream, PdfDocumentOpenMode.Import))
        ////    using (var document = new PdfSharp.Pdf.PdfDocument())
        ////    {
        ////        var options = document.Options;
        ////        options.FlateEncodeMode = PdfFlateEncodeMode.BestCompression;
        ////        options.UseFlateDecoderForJpegImages = PdfUseFlateDecoderForJpegImages.Automatic;
        ////        options.CompressContentStreams = true;
        ////        options.NoCompression = false;
        ////        foreach (var page in source.Pages)
        ////        {
        ////            document.AddPage(page);
        ////        }

        ////        document.Save(targetPath);
        ////    }
        ////}

        private static bool CreateReport(string pathFolder)
        {
            List<string> mainList = new List<string>();

            string[] mainFolders = Directory.GetDirectories(pathFolder);
            foreach (var item in mainFolders)
            {
                bool flag = CreatMiddleReportCollection(item);

                if (!flag) return false;

                mainList.Add(item + @"\middle report.pdf");
            }

            CreatePDF.MergePDFs(mainList, pathFolder + @"\Report.pdf");

            return true;
        }

        public static bool CreatMiddleReportCollection(string pathFolder)
        {
            List<string> listPdf = new List<string>();
            List<string> listPdfEnd = new List<string>();



            #region Получение Титул1 pdf с папки с адресом
            // Получение файла pdf с папки с адресом
            string[] firstPdf = Directory.GetFiles(pathFolder, "*+*.pdf");

            if (firstPdf.Length == 0)
            {
                MessageBox.Show($"В папке:\n{pathFolder}\nотуствует pdf файл Титул 1. \n\nИмя файла должно содержать символ \"+\"", "Ошибка: Титул 1", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            // Добавление в list
            listPdf.Add(firstPdf[0]);
            #endregion

            // Получение папки с осмотрами (предпоследняя папка)
            string[] secondFolderArr = Directory.GetDirectories(pathFolder);


            foreach (var secondFolder in secondFolderArr)
            {
                // Нужно запихнуть проверку, на то что это папка услуги.

                string[] secondFolders = Directory.GetDirectories(secondFolder);

                if (secondFolders.Length == 0)
                {
                    bool flag = MiniReport(secondFolder);

                    if (flag == false)
                    {
                        return false;
                    }

                    listPdfEnd.Add(secondFolder + @"\mini report.pdf");
                }
                else
                {
                    #region Получение Титул2
                    // Забираем от туда pdf
                    string[] secondPdf = Directory.GetFiles(secondFolder, "*+*.pdf");

                    if (secondPdf.Length == 0)
                    {
                        DialogResult result = MessageBox.Show($"В папке:\n{pathFolder}\nотуствует pdf файл Титул 2. \n\nИмя файла должно содержать содержать символ \"+\"\nПродолжить формирование отчёта?", "Ошибка: Титул 2", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if(result != DialogResult.Yes)
                        {
                        return false;

                        }

                    }


                    if(secondPdf.Length != 0)
                    {

                    listPdf.Add(secondPdf[0]);

                    }
                    #endregion

                    #region Создаем mini report, и добавляем в коллекцию

                    // Получаем список папок с репортами.
                    secondFolders = Directory.GetDirectories(secondFolder);

                    // создаем мини отчёт pdf и добавляем его в список.
                    foreach (var item in secondFolders)
                    {
                        bool flag = MiniReport(item);

                        if (flag == false)
                        {
                            return false;
                        }

                        listPdf.Add(item + @"\mini report.pdf");
                    }

                }





                #endregion

            }

            var resultList = listPdf.Concat(listPdfEnd).ToList();

            CreatePDF.MergePDFs(resultList, pathFolder + @"\middle report.pdf");

            return true;
        }

        public static bool MiniReport(string pathFolder)
        {
            string pathFileSave = pathFolder + @"\mini report.pdf";

            string descrText = String.Empty;

            //string[] pathImgArray = { pathImg, pathImg1, pathImg };

            string[] pathImgArray = Directory.GetFiles(pathFolder, "*.jpg");




            string[] pathTxt = Directory.GetFiles(pathFolder, "*.txt");

            if (pathTxt.Length == 0)
            {
                MessageBox.Show($"В папке\n{pathFolder}\nотуствует txt файла с № услуги!", "Ошибка: № Услуги", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }




            using (StreamReader sr = new StreamReader(pathTxt[0]))
            {
                descrText = sr.ReadToEnd();
            }


            FillPDF(pathFileSave, pathImgArray, descrText);

            return true;
        }

        public static void FillPDF(string pathFileSave, string[] pathImgArray, string descrText)
        {
            //var document = CreateDoc(pathFileSave);

            List<string> listImgWithPlus = new List<string>();
            List<string> listImgWithoutPlus = new List<string>();


            foreach (var item in pathImgArray)
            {
                if (Path.GetFileName(item).Contains('+'))
                {
                    listImgWithPlus.Add(item);
                }
                else
                {
                    listImgWithoutPlus.Add(item);
                }

            }


            using (FileStream stream = new FileStream(pathFileSave, FileMode.Create))
            {
                Document document = new Document(PageSize.A4, 20f, 20f, 10f, 10f);

                PdfWriter? pWriter = PdfWriter.GetInstance(document, stream);

                document.Open();


                var table = AddElements.GetTableJPEG(listImgWithoutPlus.ToArray());

                PdfPTable tableWithPlus = null;

                if (listImgWithPlus.Count != 0)
                    tableWithPlus = AddElements.GetTableJPEGWithPlus(listImgWithPlus.ToArray());

                var text = AddElements.AddText(descrText);
                var text1 = AddElements.AddText("\n");


                document.Add(text);
                document.Add(text1);

                if (listImgWithPlus.Count != 0)
                {
                    document.Add(tableWithPlus);
                }
                document.Add(table);

                document.Close();

            }



        }
    }
}
