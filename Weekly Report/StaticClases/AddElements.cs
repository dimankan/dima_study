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

namespace add_jpg_v1.StaticClases
{
    static class AddElements
    {

        public static PdfPTable GetTableJPEG(string[] pathImgArray)
        {
            PdfPTable result = new PdfPTable(2);
            result.WidthPercentage = 100;



            foreach (var item in pathImgArray)
            {
                var jpg = iTextSharp.text.Image.GetInstance(item);
                var image = System.Drawing.Image.FromFile(item);
                if (image.Width > image.Height)
                {
                    jpg.RotationDegrees = 270f;
                }

                result.AddCell(jpg);
            }

            if (pathImgArray.Length % 2 == 1)
            {
                result.AddCell(new Phrase(""));

            }
            return result;
        }

        public static PdfPTable GetTableJPEGWithPlus(string[] pathImgArray)
        {
            PdfPTable result = new PdfPTable(1);
            result.WidthPercentage = 100;



            foreach (var item in pathImgArray)
            {
                var jpg = iTextSharp.text.Image.GetInstance(item);
                var image = System.Drawing.Image.FromFile(item);
                if (image.Width > image.Height)
                {
                    jpg.RotationDegrees = 270f;
                }

                result.AddCell(jpg);
            }

            return result;
        }

        public static Paragraph AddText(string str, float sizeText = 20)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");

            BaseFont baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);


            Paragraph result = new Paragraph(str, font);
            result.Alignment = Element.ALIGN_CENTER;

            return result;
        }


        #region Неактуально
        public static void AddImage(Document document, string pathImage)
        {
            System.Drawing.Image pImage = System.Drawing.Image.FromFile(pathImage);
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            image.Alignment = Element.SUBJECT;
            document.Add(image);
        }

        public static void AddImg(Document document, string pathImage)
        {
            var jpg = iTextSharp.text.Image.GetInstance(pathImage);

            // Устанавливаем нужный размер
            jpg.ScaleToFit(500, 460);

            // Добавляем пространство снизу, сверху
            jpg.SpacingBefore = 10f;
            jpg.SpacingAfter = 1f;
            //jpg.SetAbsolutePosition(430, 750);
            //jpg.Annotation = new Annotation("Title", "Text");
            document.Add(jpg);

        }
        #endregion
    }

    #region Черновик
    /*
      public static void AddImage(Document document, string pathImage)
        {
            System.Drawing.Image pImage = System.Drawing.Image.FromFile(pathImage);
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            image.Alignment = Element.SUBJECT;
            document.Add(image);
        }
        public static void AddText(Document document, string str, float sizeText = 20)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


            //string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            //var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);


            //iTextSharp.text.Font pfont1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), sizeText, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
            //string arialuniTff = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");

            //BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //  string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            //            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);


            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");

            BaseFont baseFont = BaseFont.CreateFont(    ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);


                 Paragraph pgraph1 = new Paragraph(str, font);
               pgraph1.Alignment = Element.ALIGN_CENTER;

            document.Add(pgraph1);
        }
*/
    #endregion
}
