using HWAssignment06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWAssignment06.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        BikeStoresContext db = new BikeStoresContext();
        ReportViewModel report = new ReportViewModel();
        public ActionResult Index()
        {
            report.January = db.OrderItems.Count(x => x.Order.OrderDate.Month == 1 && x.Product.CategoryId == 6);
            report.February = db.OrderItems.Count(x => x.Order.OrderDate.Month == 2 && x.Product.CategoryId == 6);
            report.March = db.OrderItems.Count(x => x.Order.OrderDate.Month == 3 && x.Product.CategoryId == 6);
            report.April = db.OrderItems.Count(x => x.Order.OrderDate.Month == 4 && x.Product.CategoryId == 6);
            report.May = db.OrderItems.Count(x => x.Order.OrderDate.Month == 5 && x.Product.CategoryId == 6);
            report.June = db.OrderItems.Count(x => x.Order.OrderDate.Month == 6 && x.Product.CategoryId == 6);
            report.July = db.OrderItems.Count(x => x.Order.OrderDate.Month == 7 && x.Product.CategoryId == 6);
            report.August = db.OrderItems.Count(x => x.Order.OrderDate.Month == 8 && x.Product.CategoryId == 6);
            report.September = db.OrderItems.Count(x => x.Order.OrderDate.Month == 9 && x.Product.CategoryId == 6);
            report.October = db.OrderItems.Count(x => x.Order.OrderDate.Month == 10 && x.Product.CategoryId == 6);
            report.November = db.OrderItems.Count(x => x.Order.OrderDate.Month == 11 && x.Product.CategoryId == 6);
            report.December = db.OrderItems.Count(x => x.Order.OrderDate.Month == 12 && x.Product.CategoryId == 6);


            return View(report);
        }

    }
}
