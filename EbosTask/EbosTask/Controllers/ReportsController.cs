using EbosTask.Models;
using EbosTask.Repositories;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using iTextSharp.tool.xml;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace EbosTask.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ICallsRepository _CallRepository = null;

        public ReportsController(ICallsRepository repository)
        {
            this._CallRepository = repository;
        }
        public IActionResult Index()
        {
            var result = _CallRepository.GetCalls();
            return View(result.ToList());
        }
        [HttpPost]
        public FileResult ExportExcel(string ExportData)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader reader = new StringReader(ExportData);
                iTextSharp.text.Document PdfFile = new iTextSharp.text.Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(PdfFile, stream);
                PdfFile.Open();
                iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(writer, PdfFile, reader);
                PdfFile.Close();
                return File(stream.ToArray(), "application/pdf", "ExportData.pdf");
            }
        }
     
    }
}
