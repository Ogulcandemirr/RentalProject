﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace RentOdevProje.Controllers
{
	public class PdfReportController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult StaticPdfReport()
		{
			string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
			var stream = new FileStream(path, FileMode.Create);

			Document document = new Document(PageSize.A4);
			PdfWriter.GetInstance(document, stream);

			document.Open();

			Paragraph paragraph = new Paragraph("RentOdev Proje Pdf Reports");

			document.Add(paragraph);
			document.Close();
			return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
		}

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("TC");

            pdfPTable.AddCell("Oğulcan");
            pdfPTable.AddCell("Demir");
            pdfPTable.AddCell("12345678901");

            pdfPTable.AddCell("Adem");
            pdfPTable.AddCell("Demir");
            pdfPTable.AddCell("22222222222");

            pdfPTable.AddCell("Ayten");
            pdfPTable.AddCell("Demir");
            pdfPTable.AddCell("11111111111");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}