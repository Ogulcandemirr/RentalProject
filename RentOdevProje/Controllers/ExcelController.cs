using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using RentOdevProje.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RentOdevProje.Controllers
{
	public class ExcelController : Controller
	{
		private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
		{
			return View();	
		}
		public List<CarModel> CarList()
		{
			List<CarModel> carModels = new List<CarModel>();
			using (var c = new Context())
			{
				carModels = c.Cars.Select(x => new CarModel
				{
					Name = x.Name,
					Date = x.Date,
					Capacity = x.Capacity,
					Price = x.Price
				}).ToList();
			}
			return carModels;
		}

		public IActionResult StaticExcelReport()
		{
            return File(_excelService.ExcelList(CarList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");

        }

		public IActionResult CarExcelReport()
		{
			using (var workBook = new XLWorkbook())
			{
				var workSheet = workBook.Worksheets.Add("Araç Listesi");
				workSheet.Cell(1, 1).Value = "Araç Adı";
				workSheet.Cell(1, 2).Value = "Süre";
				workSheet.Cell(1, 3).Value = "Fiyat";
				workSheet.Cell(1, 4).Value = "Kapasite";

				int rowCount = 2;
				foreach (var item in CarList())
				{
					workSheet.Cell(rowCount,1).Value = item.Name;
					workSheet.Cell(rowCount,1).Value = item.Date;
					workSheet.Cell(rowCount,1).Value = item.Price;
					workSheet.Cell(rowCount,1).Value = item.Capacity;
					rowCount++;
				}

				using (var stream=new MemoryStream())
				{
					workBook.SaveAs(stream);
					var content = stream.ToArray();
					return File(content, "application/vnd.openxlmformats-officedocument.spreadsheetmi.sheet", "Yeniliste.xlsx");
				}
			}
		}
	}
}
