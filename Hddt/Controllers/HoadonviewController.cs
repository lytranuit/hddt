using DAIHOI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace DAIHOI.Controllers
{
    public class HoadonviewController : Controller
    {
        VNPTINVOICEEntities data = new VNPTINVOICEEntities();

        //Asta
        asta.publish.PublishService publishasta = new asta.publish.PublishService();
        asta.portal.PortalService portalasta = new asta.portal.PortalService();
        asta.business.BusinessService businessasta = new asta.business.BusinessService();
        asta.extmientrung.ExtMienTrungService extasta = new asta.extmientrung.ExtMienTrungService();
        //Astatest
        astatest.publish.PublishService publishastatest = new astatest.publish.PublishService();
        astatest.portal.PortalService portalastatest = new astatest.portal.PortalService();
        astatest.business.BusinessService businessastatest = new astatest.business.BusinessService();
        astatest.extmientrung.ExtMienTrungService extastatest = new astatest.extmientrung.ExtMienTrungService();
        //PYPHARM
        pypharm.publish.PublishService publishpypharm = new pypharm.publish.PublishService();
        pypharm.portal.PortalService portalpypharm = new pypharm.portal.PortalService();
        pypharm.business.BusinessService businesspypharm = new pypharm.business.BusinessService();
        pypharm.extmientrung.ExtMienTrungService extpypharm = new pypharm.extmientrung.ExtMienTrungService();
        //PYPHARM
        pypharmhcm.publish.PublishService publishpypharmhcm = new pypharmhcm.publish.PublishService();
        pypharmhcm.portal.PortalService portalpypharmhcm = new pypharmhcm.portal.PortalService();
        pypharmhcm.business.BusinessService businesspypharmhcm = new pypharmhcm.business.BusinessService();
        pypharmhcm.extmientrung.ExtMienTrungService extpypharmhcm = new pypharmhcm.extmientrung.ExtMienTrungService();
        //QUẢNG TRỊ
        quangtri.publish.PublishService publishquangtri = new quangtri.publish.PublishService();
        quangtri.portal.PortalService portalquangtri = new quangtri.portal.PortalService();
        quangtri.business.BusinessService businessquangtri = new quangtri.business.BusinessService();
        quangtri.extmientrung.ExtMienTrungService extquangtri = new quangtri.extmientrung.ExtMienTrungService();

        //PYPHARM TEST
        pypharmtest.publish.PublishService publishpypharmtest = new pypharmtest.publish.PublishService();
        pypharmtest.portal.PortalService portalpypharmtest = new pypharmtest.portal.PortalService();
        pypharmtest.business.BusinessService businesspypharmtest = new pypharmtest.business.BusinessService();
        pypharmtest.extmientrung.ExtMienTrungService extpypharmtest = new pypharmtest.extmientrung.ExtMienTrungService();
        //nghinhphong
        nghinhphong.publish.PublishService publishnghinhphong = new nghinhphong.publish.PublishService();
        nghinhphong.portal.PortalService portalnghinhphong = new nghinhphong.portal.PortalService();
        nghinhphong.business.BusinessService businessnghinhphong = new nghinhphong.business.BusinessService();
        nghinhphong.extmientrung.ExtMienTrungService extnghinhphong = new nghinhphong.extmientrung.ExtMienTrungService();
        //FYA
        fya.publish.PublishService publishfya = new fya.publish.PublishService();
        fya.portal.PortalService portalfya = new fya.portal.PortalService();
        fya.business.BusinessService businessfya = new fya.business.BusinessService();
        fya.extmientrung.ExtMienTrungService extfya = new fya.extmientrung.ExtMienTrungService();
        //FP
        fp.publish.PublishService publishfp = new fp.publish.PublishService();
        fp.portal.PortalService portalfp = new fp.portal.PortalService();
        fp.business.BusinessService businessfp = new fp.business.BusinessService();
        fp.extmientrung.ExtMienTrungService extfp = new fp.extmientrung.ExtMienTrungService();

        private dynamic GetClass(string macn_type)
        {
            switch (macn_type)
            {
                case "ASTA_publish":
                    return publishasta;
                    break;
                case "ASTA_portal":
                    return portalasta;
                    break;
                case "ASTA_business":
                    return businessasta;
                    break;
                case "ASTA_extmientrung":
                    return extasta;
                    break;

                case "ASTA_TEST_publish":
                    return publishastatest;
                    break;
                case "ASTA_TEST_portal":
                    return portalastatest;
                    break;
                case "ASTA_TEST_business":
                    return businessastatest;
                    break;
                case "ASTA_TEST_extmientrung":
                    return extastatest;
                    break;

                case "FYA_publish":
                    return publishfya;
                    break;
                case "FYA_portal":
                    return portalfya;
                    break;
                case "FYA_business":
                    return businessfya;
                    break;
                case "FYA_extmientrung":
                    return extfya;
                    break;

                case "FP_publish":
                    return publishfp;
                    break;
                case "FP_portal":
                    return portalfp;
                    break;
                case "FP_business":
                    return businessfp;
                    break;
                case "FP_extmientrung":
                    return extfp;
                    break;

                case "PYP_publish":
                    return publishpypharm;
                    break;
                case "PYP_portal":
                    return portalpypharm;
                    break;
                case "PYP_business":
                    return businesspypharm;
                    break;
                case "PYP_extmientrung":
                    return extpypharm;
                    break;

                case "SGP_publish":
                    return publishpypharmhcm;
                    break;
                case "SGP_portal":
                    return portalpypharmhcm;
                    break;
                case "SGP_business":
                    return businesspypharmhcm;
                    break;
                case "SGP_extmientrung":
                    return extpypharmhcm;
                    break;

                case "QT_publish":
                    return publishquangtri;
                    break;
                case "QT_portal":
                    return portalquangtri;
                    break;
                case "QT_business":
                    return businessquangtri;
                    break;
                case "QT_extmientrung":
                    return extquangtri;
                    break;

                case "PYP_TEST_publish":
                    return publishpypharmtest;
                    break;
                case "PYP_TEST_portal":
                    return portalpypharmtest;
                    break;
                case "PYP_TEST_business":
                    return businesspypharmtest;
                    break;
                case "PYP_TEST_extmientrung":
                    return extpypharmtest;
                    break;

                case "NP_publish":
                    return publishnghinhphong;
                    break;
                case "NP_portal":
                    return portalnghinhphong;
                    break;
                case "NP_business":
                    return businessnghinhphong;
                    break;
                case "NP_extmientrung":
                    return extnghinhphong;
                    break;
                default:
                    return publishpypharmtest;
                    break;

            }
            return publishpypharmtest;
        }
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
                else if (key == "ASTA" || key == "ASTA_TEST")
                {
                    return View("/Views/Hoadonview/ASTA.cshtml", datamau);
                }
                else if (key == "FP")
                {
                    return View("/Views/Hoadonview/FP.cshtml", datamau);
                }
                else if (key == "FYA")
                {
                    return View("/Views/Hoadonview/FYA.cshtml", datamau);
                }
                else if (key == "NP")
                {
                    return View("/Views/Hoadonview/NP.cshtml", datamau);
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
                else if (key == "ASTA" || key == "ASTA_TEST")
                {
                    return View("/Views/Hoadonview/ASTA.cshtml", datamau);
                }
                else if (key == "FP")
                {
                    return View("/Views/Hoadonview/FP.cshtml", datamau);
                }
                else if (key == "FYA")
                {
                    return View("/Views/Hoadonview/FYA.cshtml", datamau);
                }
                else if (key == "NP")
                {
                    return View("/Views/Hoadonview/NP.cshtml", datamau);
                }
                else
                {

                    return View("/Views/Hoadonview/PYP.cshtml", datamau);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }

        public ActionResult tracuuhoadon()
        {
            var macn = "PYP";
            ModelSearch ModelSearch = new ModelSearch()
            {
                extra10 = "",
                cuscode = "",
                fromno = "",
                tono = "",
                pattern = "1/001",
                serial = "K25TPP",
                fromdate = "01/06/2025",
                todate = "10/06/20025",
                page = 1,
                pagesize = 2000
            };
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            if (ModelSearch.todate != null)
            {
                try
                {
                    ModelSearch.todate = DateTime.ParseExact(ModelSearch.todate, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(-1).ToString("dd/MM/yyyy");
                    //ModelSearch.todate = DateTime.ParseExact(ModelSearch.todate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            string result = null;
            var str = $"{macn}_extmientrung";
            result = GetClass(str).SearchInv(ModelSearch.extra10, ModelSearch.cuscode, ModelSearch.pattern, ModelSearch.serial, ModelSearch.fromdate, ModelSearch.todate, ModelSearch.fromno, ModelSearch.tono, ModelSearch.page, ModelSearch.pagesize, tv.accservice, tv.passservice);

            if (result == "ERR:1")
            {
                return Json(new Data() { });
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                using (TextReader reader = new StringReader(result.Replace('&', ' ')))
                {
                    Data ketqua = (Data)serializer.Deserialize(reader);

                    return Json(ketqua);
                }
            }
        }

    }
}