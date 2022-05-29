using iTextSharp.text;
using iTextSharp.text.pdf;
using Ookii.Dialogs.Wpf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.ViewModel
{
    public class ReportViewModel : StaticViewModel
    {
        public static void CreateA()
        {
            try
            {
                if (Service.DNVM.SelectedRecord != null)
                {
                    VistaFolderBrowserDialog dlg = new VistaFolderBrowserDialog();
                    dlg.ShowNewFolderButton = true;
                    string path = null;
                    string filename = null;
                    if (dlg.ShowDialog() == true)
                    {
                        path = dlg.SelectedPath;
                    }
                    if (path != null)
                    {
                        filename = path + "\\" + "ReportGG.pdf";
                    }
                    string doctor = Service.ClientSession.SecondName + " " + Service.ClientSession.FirstName + " " + Service.ClientSession.LastName;
                    string s = Service.DNVM.SelectedRecord.Symptom;
                    string p = Service.DNVM.SelectedRecord.Procedures;
                    string m = Service.DNVM.SelectedRecord.Medicament;
                    string r = "Обращение от " + Service.DNVM.SelectedRecord.RecordTime;
                    string patient = ">>" + Service.DNVM.SelectedRecord.PatientNavigation.SecondName + " " +
                            Service.DNVM.SelectedRecord.PatientNavigation.FirstName + " " +
                            Service.DNVM.SelectedRecord.PatientNavigation.LastName;
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                    string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                    var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    doc.Open();
                    doc.Add(new Paragraph(doctor, font));
                    doc.Add(new Paragraph(patient, font));
                    doc.Add(new Paragraph(r, font));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Заявленные симптомы:", font));
                    doc.Add(new Paragraph(s, font));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Рекомендованные лекарства:", font));
                    doc.Add(new Paragraph(m, font));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Рекомендуемые процедуры:", font));
                    doc.Add(new Paragraph(p, font));
                    doc.Close();
                }
            }

            //int height = 50;
            //    int width = 20;
            //    PdfDocument document = new PdfDocument();
            //    PdfPage page = document.AddPage();
            //    XGraphics gfx = XGraphics.FromPdfPage(page);
            //    XFont font = new XFont("Calibri", 14);
            //    XRect rect = new XRect(40, 100, 250, 220);
            //    gfx.DrawRectangle(XBrushes.SeaShell, rect);
            //    string doctor = Service.ClientSession.SecondName + " " + Service.ClientSession.FirstName + " " + Service.ClientSession.LastName;
            //gfx.DrawString(doctor, font, XBrushes.Black, new XRect(width, height, 0, 0), XStringFormats.BaseLineLeft);
            //    height = height + 20;

            //gfx.DrawString(patient, font, XBrushes.Black, new XRect(width, height, 0, 0), XStringFormats.BaseLineLeft);
            //    height = height + 20;

            //gfx.DrawString($"Обращение от {Service.DNVM.SelectedRecord.RecordTime}", font, XBrushes.Black, new XRect(width, height, 0, 0), XStringFormats.BaseLineLeft);
            //    height = height + 20;

            //    string s = Service.DNVM.SelectedRecord.Symptom;
            //gfx.DrawString(s, font, XBrushes.Black, new XRect(width, height, 0, 0), XStringFormats.BaseLineLeft);
            //    height = height + 100;

            //    string m = Service.DNVM.SelectedRecord.Medicament;
            //gfx.DrawString(m, font, XBrushes.Black, new XRect(width, height, 0, 0), XStringFormats.BaseLineLeft);
            //    height = height + 100;

            //    string p = Service.DNVM.SelectedRecord.Procedures;
            //gfx.DrawString(p, font, XBrushes.Black, new XRect(width, height, 0, 0), XStringFormats.BaseLineLeft);
            //    height = height + 100;


            //}
            //}
            catch (Exception)
            {

                MessageBox.Show("Выберите запись");
            }

        }
    }
}
