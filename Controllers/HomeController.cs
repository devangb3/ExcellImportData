using ClosedXML.Excel;
using ExcellImportData.Models;
using ExcellImportData.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace ExcellImportData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Import()
        {
            return View(new ImportData());
        }

        [HttpPost]
        public IActionResult Import(ImportData data)
        {
            using (var stream = data.File.OpenReadStream())
            {
                using (var workbook = new XLWorkbook(stream))
                {
                    var worksheet = workbook.Worksheet(1);
                    var totalrows = worksheet.RowsUsed().Count();
                    for (var row = 2; row <= totalrows; row++)
                    {
                        /*Household household = new Household()
                        {
                            HouseholdId = Convert.ToInt32(worksheet.Cell(row, 1).Value.GetNumber()),
                            CurrentMarketValue = Convert.ToDecimal(worksheet.Cell(row, 2).Value.GetNumber()),
                            Description = worksheet.Cell(row, 3).Value.ToString().Trim(),
                            TotalMarketValue = Convert.ToDecimal(worksheet.Cell(row, 4).Value.GetNumber()),
                            EndMarketValue = Convert.ToDecimal(worksheet.Cell(row, 5).Value.GetNumber()),
                            CashAvailable = Convert.ToDecimal(worksheet.Cell(row, 6).Value.GetNumber()),
                            Excluded = worksheet.Cell(row, 7).Value.GetBoolean(),
                            MinCash = Convert.ToDecimal(worksheet.Cell(row, 8).Value.GetNumber()),
                            MaxCash = Convert.ToDecimal(worksheet.Cell(row, 9).Value.GetNumber()),
                            Symbol = worksheet.Cell(row, 11).Value.ToString().Trim(),
                        };*/
                        Record record = new Record();   
                        var recordId=ManageIndividualInformation(worksheet,record,row);


                    }
                }
            }


            return View();
        }


        public Guid ManageIndividualInformation(IXLWorksheet worksheet,Record record,int row) 
        {
            record.HouseholdDeliveryPreference = worksheet.Cell(row, 101).Value.ToString();  
            return Guid.NewGuid();  
        
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
