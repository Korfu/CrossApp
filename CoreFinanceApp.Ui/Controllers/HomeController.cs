using LinqToExcel;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreFinanceApp.Ui.Logic;

namespace CoreFinanceApp.Ui.Controllers
{
    public class HomeController : Controller
    {
           //GET: //HOME
           
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadExcel(HttpPostedFileBase FileUpload)
        {
            var path = System.IO.Path.GetTempPath() + "excel" + DateTime.Now.Ticks + ".xlsx";
            FileUpload.SaveAs(path);

            new ExcelOperations().GetExcel(path);

            ViewBag.ExcelUploadMessage = "Upload Successful!";

            return View("Index");
        }


    }
}