using DAIHOI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAIHOI.Controllers
{
    public class HoadonviewController : Controller
    {
        VNPTINVOICEEntities data = new VNPTINVOICEEntities();
        // GET: Hoadonview
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult layhtmlmau(string key, Invoice Invoice)
        {
            try
            {
                ViewBag.CurrentNumberFormat = new CultureInfo("de-DE");
                var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == key);
                var datamau = new HOADONMAU() { thongtin = tv, Invoice = Invoice };

                if (key == "QT")
                {
                    return View("/Views/Hoadonview/QT.cshtml", datamau);
                }
                else if (key == "ASTA" || key == "PYP_TEST")
                {
                    return View("/Views/Hoadonview/ASTA.cshtml", datamau);
                }
                return View("/Views/Hoadonview/PYP.cshtml", datamau);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
        [HttpPost]
        public ActionResult layhtmphieuxuatmau(string key, Invoice Invoice)
        {
            ViewBag.CurrentNumberFormat = new CultureInfo("de-DE");
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == key);
            var datamau = new HOADONMAU() { thongtin = tv, Invoice = Invoice };
            return View("/Views/Hoadonview/PHIEUXUAT.cshtml", datamau);
        }
        public ActionResult view(string key)
        {
            try
            {
                ViewBag.CurrentNumberFormat = new CultureInfo("de-DE");
                var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == key);
                var datamau = new HOADONMAU() { thongtin = tv, Invoice = new Invoice() };

                if (key == "QT")
                {
                    return View("/Views/Hoadonview/QT.cshtml", datamau);
                }
                else if (key == "ASTA" || key == "PYP_TEST")
                {
                    return View("/Views/Hoadonview/ASTA.cshtml", datamau);
                }
                return View("/Views/Hoadonview/PYP.cshtml", datamau);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
    }
}