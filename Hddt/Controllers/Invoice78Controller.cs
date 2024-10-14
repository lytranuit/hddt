using DAIHOI.Models;
using Microsoft.Security.Application;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Services.Protocols;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace DAIHOI.Controllers
{
    [BasicAuthentication]
    public class Invoice78Controller : ApiController
    {
        VNPTINVOICEEntities data = new VNPTINVOICEEntities();
        CultureInfo culture = new CultureInfo("ca-ES");

        //List<>

        Dictionary<string, ContextDetails> parameters = new Dictionary<string, ContextDetails>();

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

        public Invoice78Controller()
        {

        }
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
        [HttpPost]
        public ResultAPI capnhatkhachhang([FromBody] Customer Customer, string macn)
        {
            var Customers = new Customers() { Customer = new List<Customer>() { Customer } };
            var xml = ToXml(Customers); // Your xml
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            int? result = null;

            var str = $"{macn}_publish";
            result = GetClass(str).UpdateCus(xml, tv.accservice, tv.passservice, 0);
            if (result == -1)
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
            }
            else if (result == -2)
            {
                return new ResultAPI { Message = "Không import được khách hàng vào db", Status = 0 };
            }
            else if (result == -3)
            {
                return new ResultAPI { Message = "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
            }
            else
            {
                return new ResultAPI { Message = "Thêm và cập nhật thành công " + result + " khách hàng", Status = 1 };
            }
        }

        [HttpPost]
        public ResultAPI capnhatnhieukhachhang([FromBody] Customers Customers, string macn)
        {
            var xml = ToXml(Customers); // Your xml
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            int? result = null;
            var str = $"{macn}_publish";
            result = GetClass(str).UpdateCus(xml, tv.accservice, tv.passservice, 0);

            if (result == -1)
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
            }
            else if (result == -2)
            {
                return new ResultAPI { Message = "Không import được khách hàng vào db", Status = 0 };
            }
            else if (result == -3)
            {
                return new ResultAPI { Message = "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
            }
            else
            {
                return new ResultAPI { Message = "Thêm và cập nhật thành công " + result + " khách hàng", Status = 1 };
            }
        }

        [HttpPost]
        public ResultAPI taovaphathanhhoadon([FromBody] InvoicesPattern InvoicesPattern, string macn)
        {
            try
            {
                var DSHDon = new Invoices { Inv = InvoicesPattern.Inv };
                DSHDon.Inv.Invoice.CusBankNo = (DSHDon.Inv.Invoice.CusBankNo != null) ? DSHDon.Inv.Invoice.CusBankNo.Replace(System.Environment.NewLine, "").Trim() : null;
                DSHDon.Inv.Invoice.CusBankName = (DSHDon.Inv.Invoice.CusBankName != null) ? DSHDon.Inv.Invoice.CusBankName.Replace(System.Environment.NewLine, "").Trim() : null;
                DSHDon.Inv.Invoice.CusTaxCode = (DSHDon.Inv.Invoice.CusTaxCode != null) ? DSHDon.Inv.Invoice.CusTaxCode.Replace(" ", "").Replace(System.Environment.NewLine, "").Trim() : null;
                foreach (var i in DSHDon.Inv.Invoice.Products.Product)
                {
                    i.Extra2 = (i.Extra2 != null) ? Regex.Replace(i.Extra2.Replace(System.Environment.NewLine, "").Trim(), @"\r\n?|\n", "") : null;
                    i.ProdName = i.ProdName.Replace(System.Environment.NewLine, "").Trim();
                    i.ProdUnit = i.ProdUnit.Replace(System.Environment.NewLine, "").Trim();
                }
                var xml = ToXml(DSHDon); // Your xml
                //File.WriteAllText("test.xml", xml);+
                //File.WriteAllText(@"E:\myXml.xml", xml);
                var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
                string result = null;
                var str = $"{macn}_publish";
                result = GetClass(str).ImportAndPublishInv(tv.accadmin, tv.passadmin, xml, tv.accservice, tv.passservice, InvoicesPattern.pattern, InvoicesPattern.serial, 0);
                try
                {
                    data.DTA_LICHSUPHATHANH.Add(new DTA_LICHSUPHATHANH() { macn = macn, fkey = InvoicesPattern.Inv.key, result = result, sohddt = String.Format("{0:00000000}", Int32.Parse(result.Split('_').Last())) });
                    data.SaveChanges();
                }
                catch (Exception ex)
                {
                    data.DTA_LICHSUPHATHANH.Add(new DTA_LICHSUPHATHANH() { macn = macn, fkey = InvoicesPattern.Inv.key, result = result + "_" + xml });
                    data.SaveChanges();
                }

                if (result == "ERR:1")
                {
                    return new ResultAPI { Message = result + "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
                }
                else if (result == "ERR:3")
                {
                    return new ResultAPI { Message = result + "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
                }
                else if (result == "ERR:7")
                {
                    return new ResultAPI { Message = result + "User name không phù hợp, không tìm thấy company tương ứng cho user.", Status = 0 };
                }
                else if (result == "ERR:20")
                {
                    return new ResultAPI { Message = result + "Pattern và serial không phù hợp, hoặc không tồn tại hóa đơn đã đăng kí có sử dụng Pattern và serial truyền vào", Status = 0 };
                }
                else if (result == "ERR:5")
                {
                    if (macn == "PYP" || macn == "SGP")
                    {
                        return new ResultAPI { Message = xml, Status = 0 };
                    }
                    else
                    {
                        return new ResultAPI { Message = result + "Không phát hành được hóa đơn", Status = 0 };
                    }

                }
                else if (result == "ERR:10")
                {
                    return new ResultAPI { Message = result + "Lô có số hóa đơn vượt quá max cho phép", Status = 0 };
                }
                else if (result == "ERR:13")
                {
                    return new ResultAPI { Message = result + "FKey đã tồn tại", Status = 0 };
                }

                else if (result.Substring(0, 2) == "OK")
                {
                    var stringhd = result.Split('-').Last();
                    return new ResultAPI { Message = stringhd, Status = 1, sohddt = String.Format("{0:00000000}", Int32.Parse(result.Split('_').Last())) };
                }
                else
                {
                    return new ResultAPI { Message = result, Status = 0 };
                }
            }
            catch (Exception ex)
            {
                return new ResultAPI { Message = ex.Message, Status = 0 };
            }

        }
        [HttpPost]
        public ResultAPI guilaiemail([FromBody] InvresendemailPattern InvoicesPattern, string macn)
        {
            var x = new Invoicesresendemail { Inv = new Invresendemail { EmailDeliver = InvoicesPattern.EmailDeliver, Fkey = InvoicesPattern.Fkey } };
            var xml = ToXml(x); // Your xml
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            string result = null;

            var str = $"{macn}_publish";
            result = GetClass(str).SendAgainEmailServ(tv.accadmin, tv.passadmin, tv.accservice, tv.passservice, xml, InvoicesPattern.pattern, InvoicesPattern.serial);

            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
            }
            else if (result == "ERR:3")
            {
                return new ResultAPI { Message = "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
            }
            else if (result == "ERR:7")
            {
                return new ResultAPI { Message = "User name không phù hợp, không tìm thấy company tương ứng cho user.", Status = 0 };
            }
            else if (result == "ERR:20")
            {
                return new ResultAPI { Message = "Pattern và serial không phù hợp, hoặc không tồn tại hóa đơn đã đăng kí có sử dụng Pattern và serial truyền vào", Status = 0 };
            }
            else if (result == "ERR:5")
            {
                return new ResultAPI { Message = "Không phát hành được hóa đơn", Status = 0 };
            }
            else if (result == "ERR:10")
            {
                return new ResultAPI { Message = "Lô có số hóa đơn vượt quá max cho phép", Status = 0 };
            }
            else if (result == "ERR:13")
            {
                return new ResultAPI { Message = "FKey đã tồn tại", Status = 0 };
            }
            else if (result.Substring(0, 2) == "OK")
            {

                return new ResultAPI { Message = "Thành công", Status = 1 };
            }
            else
            {
                return new ResultAPI { Message = result, Status = 0 };
            }
        }
        [HttpPost]
        public ResultAPI taohoadon([FromBody] InvoicesPattern InvoicesPattern, string macn)
        {

            try
            {
                var DSHDon = new Invoices { Inv = InvoicesPattern.Inv };
                DSHDon.Inv.Invoice.CusBankNo = (DSHDon.Inv.Invoice.CusBankNo != null) ? DSHDon.Inv.Invoice.CusBankNo.Replace(System.Environment.NewLine, "").Trim() : null;
                DSHDon.Inv.Invoice.CusBankName = (DSHDon.Inv.Invoice.CusBankName != null) ? DSHDon.Inv.Invoice.CusBankName.Replace(System.Environment.NewLine, "").Trim() : null;
                foreach (var i in DSHDon.Inv.Invoice.Products.Product)
                {

                    i.Extra2 = (i.Extra2 != null) ? i.Extra2.Replace(System.Environment.NewLine, "").Trim() : null;
                    i.ProdName = i.ProdName.Replace(System.Environment.NewLine, "").Trim();
                    i.ProdUnit = i.ProdUnit.Replace(System.Environment.NewLine, "").Trim();


                }
                var xml = ToXml(DSHDon); // Your xml
                var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);

                string result = null;
                var str = $"{macn}_publish";
                result = GetClass(str).ImportInv(xml, tv.accservice, tv.passservice, 0);

                if (result == "ERR:1")
                {
                    return new ResultAPI { Message = "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
                }
                else if (result == "ERR:3")
                {
                    return new ResultAPI { Message = "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
                }
                else if (result == "ERR:7")
                {
                    return new ResultAPI { Message = "User name không phù hợp, không tìm thấy company tương ứng cho user.", Status = 0 };
                }
                else if (result == "ERR:20")
                {
                    return new ResultAPI { Message = "Pattern và serial không phù hợp, hoặc không tồn tại hóa đơn đã đăng kí có sử dụng Pattern và serial truyền vào", Status = 0 };
                }
                else if (result == "ERR:5")
                {
                    return new ResultAPI { Message = "Không phát hành được hóa đơn", Status = 0 };
                }
                else if (result == "ERR:10")
                {
                    return new ResultAPI { Message = "Lô có số hóa đơn vượt quá max cho phép", Status = 0 };
                }
                else if (result == "ERR:13")
                {
                    return new ResultAPI { Message = "FKey đã tồn tại", Status = 0 };
                }
                else if (result.Substring(0, 2) == "OK")
                {
                    var stringhd = result.Split('-').Last();
                    return new ResultAPI { Message = stringhd, Status = 1 };
                }
                else
                {
                    return new ResultAPI { Message = result, Status = 0 };
                }
            }
            catch (Exception ex)
            {
                return new ResultAPI { Message = ex.Message, Status = 0 };
            }

        }
        [HttpPost]
        public ResultAPI guithongdiepsaisot([FromBody] DLTBao DLTBao, string macn)
        {

            var xml = ToXml(DLTBao); // Your xml
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            string result = null;
            var str = $"{macn}_publish";
            result = GetClass(str).SendInvNoticeErrors(tv.accadmin, tv.passadmin, xml, tv.accservice, tv.passservice, DLTBao.DSHDon.HDon.KHMSHDon, 0);

            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
            }
            else if (result == "ERR:3")
            {
                return new ResultAPI { Message = "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
            }
            else if (result == "ERR:7")
            {
                return new ResultAPI { Message = "User name không phù hợp, không tìm thấy company tương ứng cho user.", Status = 0 };
            }
            else if (result == "ERR:20")
            {
                return new ResultAPI { Message = "Pattern và serial không phù hợp, hoặc không tồn tại hóa đơn đã đăng kí có sử dụng Pattern và serial truyền vào", Status = 0 };
            }
            else if (result == "ERR:5")
            {
                return new ResultAPI { Message = "Không phát hành được hóa đơn", Status = 0 };
            }
            else if (result == "ERR:10")
            {
                return new ResultAPI { Message = "Lô có số hóa đơn vượt quá max cho phép", Status = 0 };
            }
            else if (result == "ERR:13")
            {
                return new ResultAPI { Message = "FKey đã tồn tại", Status = 0 };
            }
            else if (result.Substring(0, 2) == "OK")
            {

                return new ResultAPI { Message = "Gửi thông điệp thành công", Status = 1 };
            }
            else
            {
                return new ResultAPI { Message = result, Status = 0 };
            }
        }
        [HttpPost]
        public ResultAPI huyhoadondaphathanh([FromBody] string fkey, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            string result = null;
            var str = $"{macn}_business";
            result = GetClass(str).cancelInvNoPay(tv.accadmin, tv.passadmin, fkey, tv.accservice, tv.passservice);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:2")
            {
                return new ResultAPI { Message = "Chuỗi token không chính xác", Status = 0 };
            }
            else if (result == "ERR:7")
            {
                return new ResultAPI { Message = "Không phân phối được", Status = 0 };
            }
            else if (result == "OK:")
            {
                return new ResultAPI { Message = "Hủy thành công hóa đơn", Status = 1 };
            }
            return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        [HttpPost]
        public ResultAPI downloadhdfkey([FromBody] string fkey, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).downloadInvPDFFkeyNoPay(fkey, tv.accservice, tv.passservice);

            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác, hóa đơn không tồn tại", Status = 0 };
            }
            else if (result == "ERR:7")
            {
                return new ResultAPI { Message = "Công ty không tồn tại", Status = 0 };
            }
            else
            {
                return new ResultAPI { Message = result, Status = 1 };
            }
            //return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        [HttpPost]
        public ResultAPI thaythehoadon([FromBody] ReplaceInvPattern ReplaceInvPattern, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            ReplaceInvPattern.ReplaceInv.CusBankNo = (ReplaceInvPattern.ReplaceInv.CusBankNo != null) ? ReplaceInvPattern.ReplaceInv.CusBankNo.Replace(System.Environment.NewLine, "").Trim() : null;
            ReplaceInvPattern.ReplaceInv.CusBankName = (ReplaceInvPattern.ReplaceInv.CusBankName != null) ? ReplaceInvPattern.ReplaceInv.CusBankName.Replace(System.Environment.NewLine, "").Trim() : null;
            ReplaceInvPattern.ReplaceInv.CusTaxCode = (ReplaceInvPattern.ReplaceInv.CusTaxCode != null) ? ReplaceInvPattern.ReplaceInv.CusTaxCode.Replace(" ", "").Replace(System.Environment.NewLine, "").Trim() : null;
            foreach (var i in ReplaceInvPattern.ReplaceInv.Products.Product)
            {
                i.Extra2 = (i.Extra2 != null) ? Regex.Replace(i.Extra2.Replace(System.Environment.NewLine, "").Trim(), @"\r\n?|\n", "") : null;
                i.ProdName = i.ProdName.Replace(System.Environment.NewLine, "").Trim();
                i.ProdUnit = i.ProdUnit.Replace(System.Environment.NewLine, "").Trim();
            }
            var xml = ToXml(ReplaceInvPattern.ReplaceInv); // Your xml
            var result = "";
            var str = $"{macn}_business";
            result = GetClass(str).ReplaceInvoiceAction(tv.accadmin, tv.passadmin, xml, tv.accservice, tv.passservice, ReplaceInvPattern.fkey, "", 0, ReplaceInvPattern.pattern, ReplaceInvPattern.serial);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = result + "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
            }
            if (result == "ERR:2")
            {
                return new ResultAPI { Message = result + "Hóa đơn cần điều chỉnh không tồn tại", Status = 0 };
            }
            else if (result == "ERR:3")
            {
                return new ResultAPI { Message = result + "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
            }
            else if (result == "ERR:5")
            {
                return new ResultAPI { Message = result + "Không phát hành được hóa đơn", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = result + "Dải hóa đơn cũ đã hết", Status = 0 };
            }
            else if (result == "ERR:7")
            {
                return new ResultAPI { Message = result + "User name không phù hợp, không tìm thấy company tương ứng cho user.", Status = 0 };
            }
            else if (result == "ERR:8")
            {
                return new ResultAPI { Message = result + "Hóa đơn cần điều chỉnh đã bị thay thế. Không thể điều chỉnh được nữa.", Status = 0 };
            }
            else if (result == "ERR:9")
            {
                return new ResultAPI { Message = result + "Trạng thái hóa đơn không được điều chỉnh", Status = 0 };
            }
            else if (result == "ERR:13")
            {
                return new ResultAPI { Message = result + "Trùng Fkey", Status = 0 };
            }
            else if (result == "ERR:20")
            {
                return new ResultAPI { Message = result + "Pattern và serial không phù hợp", Status = 0 };
            }
            else if (result.Substring(0, 2) == "OK")
            {
                var stringhd = result.Split(';').Last();
                return new ResultAPI { Message = stringhd, Status = 1, sohddt = String.Format("{0:00000000}", Int32.Parse(stringhd.Split('_').Last())) };
            }
            else
            {
                return new ResultAPI { Message = result, Status = 0 };
            }
        }
        [HttpPost]
        public ResultAPI dieuchinhhoadon([FromBody] AdjustInvPattern AdjustInvPattern, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            AdjustInvPattern.AdjustInv.CusBankNo = (AdjustInvPattern.AdjustInv.CusBankNo != null) ? AdjustInvPattern.AdjustInv.CusBankNo.Replace(System.Environment.NewLine, "").Trim() : null;
            AdjustInvPattern.AdjustInv.CusBankName = (AdjustInvPattern.AdjustInv.CusBankName != null) ? AdjustInvPattern.AdjustInv.CusBankName.Replace(System.Environment.NewLine, "").Trim() : null;
            AdjustInvPattern.AdjustInv.CusTaxCode = (AdjustInvPattern.AdjustInv.CusTaxCode != null) ? AdjustInvPattern.AdjustInv.CusTaxCode.Replace(" ", "").Replace(System.Environment.NewLine, "").Trim() : null;
            foreach (var i in AdjustInvPattern.AdjustInv.Products.Product)
            {
                i.Extra2 = (i.Extra2 != null) ? Regex.Replace(i.Extra2.Replace(System.Environment.NewLine, "").Trim(), @"\r\n?|\n", "") : null;
                i.ProdName = i.ProdName.Replace(System.Environment.NewLine, "").Trim();
                i.ProdUnit = i.ProdUnit.Replace(System.Environment.NewLine, "").Trim();
            }
            var xml = ToXml(AdjustInvPattern.AdjustInv); // Your xml
            var result = "";
            var str = $"{macn}_business";
            result = GetClass(str).AdjustInvoiceAction(tv.accadmin, tv.passadmin, xml, tv.accservice, tv.passservice, AdjustInvPattern.fkey, "", 0, AdjustInvPattern.pattern, AdjustInvPattern.serial);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = result + "Tài khoản đăng nhập sai hoặc không có quyền thêm khách hàng", Status = 0 };
            }
            if (result == "ERR:2")
            {
                return new ResultAPI { Message = result + "Hóa đơn cần điều chỉnh không tồn tại", Status = 0 };
            }
            else if (result == "ERR:3")
            {
                return new ResultAPI { Message = result + "Dữ liệu xml đầu vào không đúng quy định", Status = 0 };
            }
            else if (result == "ERR:5")
            {
                return new ResultAPI { Message = result + "Không phát hành được hóa đơn", Status = 0 };
            }
            else if (result == "ERR:5")
            {
                return new ResultAPI { Message = result + "Dải hóa đơn cũ đã hết", Status = 0 };
            }
            else if (result == "ERR:7")
            {
                return new ResultAPI { Message = result + "User name không phù hợp, không tìm thấy company tương ứng cho user.", Status = 0 };
            }
            else if (result == "ERR:8")
            {
                return new ResultAPI { Message = result + "Hóa đơn cần điều chỉnh đã bị thay thế. Không thể điều chỉnh được nữa.", Status = 0 };
            }
            else if (result == "ERR:9")
            {
                return new ResultAPI { Message = result + "Trạng thái hóa đơn không được điều chỉnh", Status = 0 };
            }
            else if (result == "ERR:13")
            {
                return new ResultAPI { Message = result + "Fkey điền vào không tồn tại hoặc đã điều chỉnh", Status = 0 };
            }
            else if (result.Substring(0, 2) == "OK")
            {
                var stringhd = result.Split(';').Last();
                return new ResultAPI { Message = stringhd, Status = 1, sohddt = String.Format("{0:00000000}", Int32.Parse(stringhd.Split('_').Last())) };
            }
            else
            {
                return new ResultAPI { Message = result, Status = 0 };
            }
        }
        [HttpPost]
        public Data tracuuhoadon([FromBody] ModelSearch ModelSearch, string macn)
        {
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
                return new Data() { };
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                using (TextReader reader = new StringReader(result.Replace('&', ' ')))
                {
                    Data ketqua = (Data)serializer.Deserialize(reader);

                    return ketqua;
                }
            }
        }
        [HttpPost]
        public Data tracuuhoadonFromNoToNo([FromBody] ModelFromNotoNo ModelFromNotoNo, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            string result = null;
            var str = $"{macn}_portal";
            result = GetClass(str).listInvFromNoToNo(ModelFromNotoNo.fromno, ModelFromNotoNo.tono, ModelFromNotoNo.pattern, ModelFromNotoNo.serial, tv.accservice, tv.passservice);

            if (result == "ERR:1")
            {
                return new Data() { };
            }
            else if (result == "ERR:7")
            {
                return new Data() { };
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                using (TextReader reader = new StringReader(result.Replace('&', ' ')))
                {
                    Data ketqua = (Data)serializer.Deserialize(reader);

                    return ketqua;
                }
            }
        }
        [HttpPost]
        public Data tracuuhoadonByCus([FromBody] ModelByCus ModelByCus, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            if (ModelByCus.todate != null)
            {
                try
                {
                    ModelByCus.todate = DateTime.ParseExact(ModelByCus.todate, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(-1).ToString("dd/MM/yyyy");
                    //ModelSearch.todate = DateTime.ParseExact(ModelSearch.todate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            string result = null;
            var str = $"{macn}_portal";
            result = GetClass(str).listInvByCus(ModelByCus.cuscode, ModelByCus.fromdate, ModelByCus.todate, tv.accservice, tv.passservice);


            if (result == "ERR:1")
            {
                return new Data() { };
            }
            else if (result == "ERR:3")
            {
                ///Không tồn tài khách hàng tương ứng với cusCode
                return new Data() { };
            }
            else if (result == "ERR:4")
            {
                ///Công ty chưa được đăng ký mẫ hóa đơ nào
                return new Data() { };
            }
            else if (result == "ERR:7")
            {
                ///Không tìm thấy thông tin công ty
                return new Data() { };
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                using (TextReader reader = new StringReader(result.Replace('&', ' ')))
                {
                    Data ketqua = (Data)serializer.Deserialize(reader);

                    return ketqua;
                }
            }
        }
        [HttpPost]
        public ResultAPI layhtmlhoadon([FromBody] string fkey, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).getInvViewFkeyNoPay(fkey, tv.accservice, tv.passservice);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác", Status = 0 };
            }
            else if (result != "")
            {
                return new ResultAPI { Message = result, Status = 1 };
            }
            return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        [HttpPost]
        public Inv laythongtinhoadonfkey([FromBody] string fkey, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).downloadInvFkeyNoPay(fkey, tv.accservice, tv.passservice);


            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(HDon));
                using (StringReader reader = new StringReader(result))
                {
                    HDon ketqua = (HDon)serializer.Deserialize(reader);
                    var data = new Inv() { };
                    data.key = ketqua.Fkey;
                    data.Invoice = new Invoice()
                    {
                        InvoiceNo = ketqua.DLHDon.TTChung.SHDon,
                        ArisingDate = DateTime.ParseExact(Sanitizer.GetSafeHtmlFragment(ketqua.DLHDon.TTChung.NLap), "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                        PaymentMethod = ketqua.DLHDon.TTChung.HTTToan,
                        CusName = ketqua.DLHDon.NDHDon.NMua.Ten,
                        CusCode = ketqua.DLHDon.NDHDon.NMua.MKHang,
                        CusTaxCode = ketqua.DLHDon.NDHDon.NMua.MST,
                        CusAddress = ketqua.DLHDon.NDHDon.NMua.DChi,
                        CusPhone = ketqua.DLHDon.NDHDon.NMua.SDThoai,
                        CusBankName = ketqua.DLHDon.NDHDon.NMua.TNHang,
                        CusBankNo = ketqua.DLHDon.NDHDon.NMua.STKNHang,
                        Amount = ketqua.DLHDon.NDHDon.TToan.TgTTTBSo,
                        AmountInWords = ketqua.DLHDon.NDHDon.TToan.TgTTTBChu,
                        VATRate = Int32.Parse(ketqua.DLHDon.NDHDon.TToan.THTTLTSuat.LTSuat.TSuat.Replace("%", "")),
                        Total = ketqua.DLHDon.NDHDon.TToan.TgTCThue,
                        VATAmount = ketqua.DLHDon.NDHDon.TToan.THTTLTSuat.LTSuat.TThue,
                        DiscountAmount = ketqua.DLHDon.NDHDon.TToan.TTCKTMai,
                        Products = new Products
                        {
                            Product = new List<Product> { }
                        }
                    };
                    var listhh = new List<Product>();
                    foreach (var i in ketqua.DLHDon.NDHDon.DSHHDVu.HHDVu)
                    {
                        data.Invoice.Products.Product.Add(new Product { Code = i.MHHDVu, ProdName = i.THHDVu, ProdUnit = i.DVTinh, ProdQuantity = i.SLuong, ProdPrice = i.DGia, Discount = i.TLCKhau, DiscountAmount = i.STCKhau, Amount = i.ThTien, Total = i.ThTien, IsSum = i.TChat });
                    }
                    return data;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return new Inv() { };
            }
        }
        [HttpPost]
        public Inv laythongtinhoadonsohd([FromBody] Token token, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            string result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).downloadInvNoPay(converttokentostring(token), tv.accservice, tv.passservice);


            XmlSerializer serializer = new XmlSerializer(typeof(HDon));
            using (StringReader reader = new StringReader(result))
            {

                HDon ketqua = (HDon)serializer.Deserialize(reader);
                var data = new Inv() { };
                data.key = ketqua.Fkey;
                data.Invoice = new Invoice()
                {
                    InvoiceNo = ketqua.DLHDon.TTChung.SHDon,
                    ArisingDate = DateTime.ParseExact(Sanitizer.GetSafeHtmlFragment(ketqua.DLHDon.TTChung.NLap), "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                    PaymentMethod = ketqua.DLHDon.TTChung.HTTToan,
                    CusName = ketqua.DLHDon.NDHDon.NMua.Ten,
                    CusCode = ketqua.DLHDon.NDHDon.NMua.MKHang,
                    CusTaxCode = ketqua.DLHDon.NDHDon.NMua.MST,
                    CusAddress = ketqua.DLHDon.NDHDon.NMua.DChi,
                    CusPhone = ketqua.DLHDon.NDHDon.NMua.SDThoai,
                    CusBankName = ketqua.DLHDon.NDHDon.NMua.TNHang,
                    CusBankNo = ketqua.DLHDon.NDHDon.NMua.STKNHang,
                    Amount = ketqua.DLHDon.NDHDon.TToan.TgTTTBSo,
                    AmountInWords = ketqua.DLHDon.NDHDon.TToan.TgTTTBChu,
                    VATRate = Int32.Parse(ketqua.DLHDon.NDHDon.TToan.THTTLTSuat.LTSuat.TSuat.Replace("%", "")),
                    Total = ketqua.DLHDon.NDHDon.TToan.TgTCThue,
                    VATAmount = ketqua.DLHDon.NDHDon.TToan.THTTLTSuat.LTSuat.TThue,
                    DiscountAmount = ketqua.DLHDon.NDHDon.TToan.TTCKTMai,
                    Products = new Products
                    {
                        Product = new List<Product> { }
                    }
                };
                var listhh = new List<Product>();
                foreach (var i in ketqua.DLHDon.NDHDon.DSHHDVu.HHDVu)
                {
                    data.Invoice.Products.Product.Add(new Product { Code = i.MHHDVu, ProdName = i.THHDVu, ProdUnit = i.DVTinh, ProdQuantity = i.SLuong, ProdPrice = i.DGia, Discount = i.TLCKhau, DiscountAmount = i.STCKhau, Amount = i.ThTien, Total = i.ThTien, IsSum = i.TChat });
                }

                return data;
            }
        }
        [HttpPost]
        public ResultAPI layhtmlchuyendoistatus([FromBody] FkeyStatus x, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).convertForStoreFkey(x.fkey, tv.accservice, tv.passservice);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác", Status = 0 };
            }
            else
            {
                if (x.status == 3 || x.status == 5)
                {
                    return new ResultAPI { Message = result + "<img style='position: absolute;left: 0px;top: 0px;width: 100%;height: auto;z-index: 3;' width='100%' height='900px' src='data:image/png;base64,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'>", Status = 1 };
                }
                else
                {
                    return new ResultAPI { Message = result, Status = 1 };
                }
            }
            //return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        [HttpPost]
        public ResultAPI layhtmlchuyendoi([FromBody] string fkey, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).convertForStoreFkey(fkey, tv.accservice, tv.passservice);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác", Status = 0 };
            }
            else
            {
                return new ResultAPI { Message = result, Status = 1 };
            }
            //return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        [HttpPost]
        public ResultAPI layxmlhoadonfkey([FromBody] string fkey, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).downloadInvFkeyNoPay(fkey, tv.accservice, tv.passservice);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác", Status = 0 };
            }
            else
            {
                return new ResultAPI { Message = result, Status = 1 };
            }
            //return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        public ResultAPI laytrangthaihoadoncqt([FromBody] Token token, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_publish";
            result = GetClass(str).GetMCCQThueByInvTokens(tv.accadmin, tv.passadmin, tv.accservice, tv.passservice, converttokentostring(token));


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:2")
            {
                return new ResultAPI { Message = "Không tìm thấy hóa đơn tương ứng", Status = 0 };
            }
            else if (result == "ERR:5")
            {
                return new ResultAPI { Message = "Lỗi không xác định, không lấy được dữ liệu hóa đơn cấp mã theo dữ liệu truyền vào", Status = 0 };
            }
            else if (result == "ERR:20")
            {
                return new ResultAPI { Message = "Không lấy được thông tin người dùng", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác", Status = 0 };
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DSHDonCheck));
                using (TextReader reader = new StringReader(Base64Decode(result)))
                {
                    var DSHDonCheck = (DSHDonCheck)serializer.Deserialize(reader);
                    if (DSHDonCheck.HDonCheck.TThai == 2)
                    {
                        return new ResultAPI { Message = "Đã nhận phản hồi từ thuế", Status = DSHDonCheck.HDonCheck.TThai };
                    }
                    else if (DSHDonCheck.HDonCheck.TThai == 3)
                    {
                        return new ResultAPI { Message = "Lỗi kết nối Thuế (" + DSHDonCheck.HDonCheck.MTLoi + ")", Status = DSHDonCheck.HDonCheck.TThai, };
                    }
                    else if (DSHDonCheck.HDonCheck.TThai == 1)
                    {
                        return new ResultAPI { Message = "Thuế chưa phản hồi", Status = DSHDonCheck.HDonCheck.TThai };
                    }
                }
            }
            return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        public ResultAPI laytrangthaihoadoncqtfkey([FromBody] TokenFkey fkeys, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_publish";
            result = GetClass(str).GetMCCQThueByFkeys(tv.accadmin, tv.passadmin, tv.accservice, tv.passservice, fkeys.pattern, fkeys.fkey);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:2")
            {
                return new ResultAPI { Message = "Không tìm thấy hóa đơn tương ứng", Status = 0 };
            }
            else if (result == "ERR:5")
            {
                return new ResultAPI { Message = "Lỗi không xác định, không lấy được dữ liệu hóa đơn cấp mã theo dữ liệu truyền vào", Status = 0 };
            }
            else if (result == "ERR:20")
            {
                return new ResultAPI { Message = "Không lấy được thông tin người dùng", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác", Status = 0 };
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DSHDonCheck));
                using (TextReader reader = new StringReader(Base64Decode(result)))
                {
                    var DSHDonCheck = (DSHDonCheck)serializer.Deserialize(reader);
                    if (DSHDonCheck.HDonCheck.TThai == 2)
                    {
                        return new ResultAPI { Message = "Đã nhận phản hồi từ thuế", Status = DSHDonCheck.HDonCheck.TThai };
                    }
                    else if (DSHDonCheck.HDonCheck.TThai == 3)
                    {
                        return new ResultAPI { Message = "Lỗi kết nối Thuế (" + DSHDonCheck.HDonCheck.MTLoi + ")", Status = DSHDonCheck.HDonCheck.TThai, };
                    }
                    else if (DSHDonCheck.HDonCheck.TThai == 1)
                    {
                        return new ResultAPI { Message = "Thuế chưa phản hồi", Status = DSHDonCheck.HDonCheck.TThai };
                    }
                }
            }
            return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        [HttpPost]
        public Token layhoadonthaythefkey([FromBody] string fkey, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).downloadInvFkeyNoPay(fkey, tv.accservice, tv.passservice);


            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(HDon));
                using (TextReader reader = new StringReader(result))
                {
                    HDon ketqua = (HDon)serializer.Deserialize(reader);

                    return new Token() { sohoadon = ketqua.DLHDon.TTChung.TTHDLQuan.SHDCLQuan, serial = ketqua.DLHDon.TTChung.TTHDLQuan.KHHDCLQuan };
                }
            }
            catch (Exception)
            {
                return new Token() { };
            }
        }
        [HttpPost]
        public Token layhoadonthaythe([FromBody] Token token, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            string result = null;
            var str = $"{macn}_portal";
            result = GetClass(str).downloadInvNoPay(converttokentostring(token), tv.accservice, tv.passservice);


            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(HDon));
                using (TextReader reader = new StringReader(result))
                {
                    HDon ketqua = (HDon)serializer.Deserialize(reader);

                    return new Token() { sohoadon = ketqua.DLHDon.TTChung.TTHDLQuan.SHDCLQuan, serial = ketqua.DLHDon.TTChung.TTHDLQuan.KHHDCLQuan };
                }
            }
            catch (Exception)
            {
                return new Token() { };
            }
        }
        [HttpPost]
        public ResultAPI layhtmlhoadonstatus([FromBody] FkeyStatus x, string macn)
        {
            var tv = data.TBL_DANHMUCTAIKHOAN.SingleOrDefault(n => n.macn == macn);
            var result = "";
            var str = $"{macn}_portal";
            result = GetClass(str).getInvViewFkeyNoPay(x.fkey, tv.accservice, tv.passservice);


            if (result == "ERR:1")
            {
                return new ResultAPI { Message = "Tài khoản đăng nhập sai", Status = 0 };
            }
            else if (result == "ERR:6")
            {
                return new ResultAPI { Message = "Chuỗi fkey không chính xác", Status = 0 };
            }
            else
            {
                if (x.status == 3 || x.status == 5)
                {
                    return new ResultAPI { Message = result + "<img style='position: absolute;left: 0px;top: 0px;width: 100%;height: auto;z-index: 3;' width='100%' height='900px' src='data:image/png;base64,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'>", Status = 1 };
                }
                else
                {
                    return new ResultAPI { Message = result, Status = 1 };
                }
            }
            //return new ResultAPI { Message = "Lỗi" + result, Status = 0 };
        }
        public string converttokentostring(Token token)
        {
            return token.pattern + ";" + token.serial + ";" + token.sohoadon;
        }
        internal static string ToXml(object obj)
        {
            string retval = null;
            if (obj != null)
            {
                var xns = new XmlSerializerNamespaces();
                xns.Add(string.Empty, string.Empty);
                StringBuilder sb = new StringBuilder();
                using (XmlWriter writer = XmlWriter.Create(sb, new XmlWriterSettings() { OmitXmlDeclaration = true }))
                {
                    new XmlSerializer(obj.GetType()).Serialize(writer, obj, xns);
                }
                retval = sb.ToString();
            }
            return retval;
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }

    class ContextDetails
    {
        //public

        // todo: add constructor to simplify constructing items when adding
    }
}
