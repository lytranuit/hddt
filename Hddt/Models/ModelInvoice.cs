using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace DAIHOI.Models
{
	//public partial class Customer
	//{
	//    public string Name { get; set; }
	//    public string Code { get; set; }
	//    public string TaxCode { get; set; }
	//    public string Address { get; set; }
	//    public string BankAccountName { get; set; }
	//    public string BankName { get; set; }
	//    public string BankNumber { get; set; }
	//    public string Email { get; set; }
	//    public string Fax { get; set; }
	//    public string Phone { get; set; }
	//    public string ContactPerson { get; set; }
	//    public string RepresentPerson { get; set; }
	//    public int CusType { get; set; }
	//}

	//[XmlRoot(ElementName = "Item")]
	//public class Item
	//{
	//	[XmlElement(ElementName = "index")]
	//	public string Index { get; set; }
	//	[XmlElement(ElementName = "invToken")]
	//	public string InvToken { get; set; }
	//	[XmlElement(ElementName = "fkey")]
	//	public string Fkey { get; set; }
	//	[XmlElement(ElementName = "name")]
	//	public string Name { get; set; }
	//	[XmlElement(ElementName = "publishDate")]
	//	public string PublishDate { get; set; }
	//	[XmlElement(ElementName = "Dateconvert")]
	//	public string Dateconvert { get; set; }
	//	[XmlElement(ElementName = "signStatus")]
	//	public int SignStatus { get; set; }
	//	[XmlElement(ElementName = "total")]
	//	public decimal Total { get; set; }
	//	[XmlElement(ElementName = "amount")]
	//	public decimal Amount { get; set; }
	//	[XmlElement(ElementName = "pattern")]
	//	public string Pattern { get; set; }
	//	[XmlElement(ElementName = "serial")]
	//	public string Serial { get; set; }
	//	[XmlElement(ElementName = "status")]
	//	public int Status { get; set; }
	//	[XmlElement(ElementName = "invNum")]
	//	public string InvNum { get; set; }
	//	[XmlElement(ElementName = "cusname")]
	//	public string Cusname { get; set; }
	//	[XmlElement(ElementName = "payment")]
	//	public string Payment { get; set; }
	//}
	[XmlRoot(ElementName = "Item")]
	public class Item
	{

		[XmlElement(ElementName = "Fkey")]
		public string Fkey { get; set; }

		[XmlElement(ElementName = "Pattern")]
		public string Pattern { get; set; }

		[XmlElement(ElementName = "Serial")]
		public string Serial { get; set; }

		[XmlElement(ElementName = "InvoiceNo")]
		public string InvoiceNo { get; set; }

		[XmlElement(ElementName = "PublishDate")]
		public string PublishDate { get; set; }

		[XmlElement(ElementName = "ArisingDate")]
		public string ArisingDate { get; set; }

		[XmlElement(ElementName = "SignDate")]
		public string SignDate { get; set; }

		[AllowHtml]
		[XmlElement(ElementName = "CusName")]
		public string CusName { get; set; }

		[XmlElement(ElementName = "CusCode")]
		public string CusCode { get; set; }

		[XmlElement(ElementName = "Buyer")]
		public string Buyer { get; set; }

		[XmlElement(ElementName = "Amount")]
		public decimal Amount { get; set; }

		[XmlElement(ElementName = "Total")]
		public decimal Total { get; set; }

		[XmlElement(ElementName = "VATAmount")]
		public decimal VATAmount { get; set; }

		[XmlElement(ElementName = "VATRate")]
		public int VATRate { get; set; }

		[XmlElement(ElementName = "SignStatus")]
		public string SignStatus { get; set; }

		[XmlElement(ElementName = "DiscountAmount")]
		public decimal DiscountAmount { get; set; }

		[XmlElement(ElementName = "PaymentMethod")]
		public string PaymentMethod { get; set; }

		[XmlElement(ElementName = "PaymentStatus")]
		public string PaymentStatus { get; set; }

		[XmlElement(ElementName = "Status")]
		public int Status { get; set; }
		[XmlElement(ElementName = "TThai")]
		public int TThai { get; set; }
	}

	[XmlRoot(ElementName = "Data")]
	public class Data
	{
		[XmlElement(ElementName = "Item")]
		public List<Item> Item { get; set; }
		[XmlElement(ElementName = "Total")]
		public int? Total { get; set; }

		[XmlElement(ElementName = "PageIndex")]
		public int? PageIndex { get; set; }

		[XmlElement(ElementName = "PageSize")]
		public int? PageSize { get; set; }
	}


	[XmlRoot(ElementName = "Invoice")]
	public class InvoiceReplace
	{
		[XmlElement(ElementName = "Content")]
		public Content Content { get; set; }
	}



	public partial class ResultAPI
	{
		public string Message { get; set; }
		public int Status { get; set; }
		public string sohddt { get; set; }
		public HDon Hdon { get; set; }
		public DSHDonCheck DSHDonCheck { get; set; }
	}
	public partial class FkeyStatus
	{
		public string fkey { get; set; }
		public int status { get; set; }

	}
	public partial class Token
	{
		public string pattern { get; set; }
		public string serial { get; set; }
		public string sohoadon { get; set; }

	}
	public partial class TokenFkey
	{
		public string pattern { get; set; }
		public string serial { get; set; }
		public string fkey { get; set; }

	}
	public partial class TokenListFkey
	{
		public string pattern { get; set; }
		public string serial { get; set; }
		public List<string> fkey { get; set; }

	}
	[XmlRoot(ElementName = "Products")]
	public partial class Products
	{
		[XmlElement(ElementName = "Product")]
		public List<Product> Product { get; set; }
	}
	public partial class HOADONMAU
	{
		public TBL_DANHMUCTAIKHOAN thongtin { get; set; }
		public Invoice Invoice { get; set; }
	}
	[XmlRoot(ElementName = "ReplaceInv")]
	public class ReplaceInv
	{
		[XmlElement(ElementName = "key")]
		public string key { get; set; }
		[XmlElement(ElementName = "InvoiceNo")]
		public string InvoiceNo { get; set; }

		[XmlElement(ElementName = "CusCode")]
		public string CusCode { get; set; }

		[XmlElement(ElementName = "CusName")]
		public string CusName { get; set; }
		[XmlElement(ElementName = "CusBankNo")]
		public string CusBankNo { get; set; }
		[XmlElement(ElementName = "CusBankName")]
		public string CusBankName { get; set; }

		[XmlElement(ElementName = "CusAddress")]
		public string CusAddress { get; set; }

		[XmlElement(ElementName = "CusPhone")]
		public string CusPhone { get; set; }

		[XmlElement(ElementName = "CusTaxCode")]
		public string CusTaxCode { get; set; }

		[XmlElement(ElementName = "PaymentMethod")]
		public string PaymentMethod { get; set; }

		[XmlElement(ElementName = "KindOfService")]
		public int KindOfService { get; set; }

		[XmlElement(ElementName = "Products")]
		public Products Products { get; set; }

		[XmlElement(ElementName = "Total")]
		public decimal Total { get; set; }

		[XmlElement(ElementName = "DiscountAmount")]
		public decimal DiscountAmount { get; set; }

		[XmlElement(ElementName = "VATRate")]
		public int VATRate { get; set; }

		[XmlElement(ElementName = "VATAmount")]
		public decimal VATAmount { get; set; }

		[XmlElement(ElementName = "Amount")]
		public decimal Amount { get; set; }

		[XmlElement(ElementName = "AmountInWords")]
		public string AmountInWords { get; set; }

		[XmlElement(ElementName = "Extra")]
		public string Extra { get; set; }
		[XmlElement(ElementName = "Extra9")]
		public string Extra9 { get; set; }
		[XmlElement(ElementName = "Extra10")]
		public string Extra10 { get; set; }

		[XmlElement(ElementName = "ArisingDate")]
		public string ArisingDate { get; set; }

		[XmlElement(ElementName = "PaymentStatus")]
		public string PaymentStatus { get; set; }

		[XmlElement(ElementName = "EmailDeliver")]
		public string EmailDeliver { get; set; }

		[XmlElement(ElementName = "ResourceCode")]
		public string ResourceCode { get; set; }

		[XmlElement(ElementName = "GrossValue")]
		public decimal GrossValue { get; set; }

		[XmlElement(ElementName = "GrossValue0")]
		public decimal GrossValue0 { get; set; }

		[XmlElement(ElementName = "VatAmount0")]
		public decimal VatAmount0 { get; set; }

		[XmlElement(ElementName = "GrossValue5")]
		public decimal GrossValue5 { get; set; }

		[XmlElement(ElementName = "VatAmount5")]
		public decimal VatAmount5 { get; set; }
		[XmlElement(ElementName = "GrossValue8")]
		public decimal GrossValue8 { get; set; }

		[XmlElement(ElementName = "VatAmount8")]
		public decimal VatAmount8 { get; set; }

		[XmlElement(ElementName = "GrossValue10")]
		public decimal GrossValue10 { get; set; }

		[XmlElement(ElementName = "VatAmount10")]
		public decimal? VatAmount10 { get; set; }

		[XmlElement(ElementName = "Buyer")]
		public string Buyer { get; set; }

		[XmlElement(ElementName = "DiscountRate")]
		public int DiscountRate { get; set; }

		[XmlElement(ElementName = "Fkey")]
		public string Fkey { get; set; }

		[XmlElement(ElementName = "GrossValue_NonTax")]
		public object GrossValueNonTax { get; set; }

		[XmlElement(ElementName = "CurrencyUnit")]
		public string CurrencyUnit { get; set; }

		[XmlElement(ElementName = "ExchangeRate")]
		public string ExchangeRate { get; set; }

		[XmlElement(ElementName = "ConvertedAmount")]
		public string ConvertedAmount { get; set; }
	}
	[XmlRoot(ElementName = "AdjustInv")]
	public class AdjustInv
	{
		[XmlElement(ElementName = "key")]
		public string key { get; set; }
		[XmlElement(ElementName = "InvoiceNo")]
		public string InvoiceNo { get; set; }

		[XmlElement(ElementName = "CusCode")]
		public string CusCode { get; set; }

		[XmlElement(ElementName = "CusName")]
		public string CusName { get; set; }
		[XmlElement(ElementName = "CusBankNo")]
		public string CusBankNo { get; set; }
		[XmlElement(ElementName = "CusBankName")]
		public string CusBankName { get; set; }

		[XmlElement(ElementName = "CusAddress")]
		public string CusAddress { get; set; }

		[XmlElement(ElementName = "CusPhone")]
		public string CusPhone { get; set; }

		[XmlElement(ElementName = "CusTaxCode")]
		public string CusTaxCode { get; set; }

		[XmlElement(ElementName = "PaymentMethod")]
		public string PaymentMethod { get; set; }

		[XmlElement(ElementName = "KindOfService")]
		public int KindOfService { get; set; }

		[XmlElement(ElementName = "Products")]
		public Products Products { get; set; }

		[XmlElement(ElementName = "Total")]
		public decimal Total { get; set; }

		[XmlElement(ElementName = "DiscountAmount")]
		public decimal DiscountAmount { get; set; }

		[XmlElement(ElementName = "VATRate")]
		public int VATRate { get; set; }

		[XmlElement(ElementName = "VATAmount")]
		public decimal VATAmount { get; set; }

		[XmlElement(ElementName = "Amount")]
		public decimal Amount { get; set; }

		[XmlElement(ElementName = "AmountInWords")]
		public string AmountInWords { get; set; }

		[XmlElement(ElementName = "Extra")]
		public string Extra { get; set; }
		[XmlElement(ElementName = "Extra9")]
		public string Extra9 { get; set; }
		[XmlElement(ElementName = "Extra10")]
		public string Extra10 { get; set; }

		[XmlElement(ElementName = "ArisingDate")]
		public string ArisingDate { get; set; }

		[XmlElement(ElementName = "PaymentStatus")]
		public string PaymentStatus { get; set; }

		[XmlElement(ElementName = "EmailDeliver")]
		public string EmailDeliver { get; set; }

		[XmlElement(ElementName = "ResourceCode")]
		public string ResourceCode { get; set; }

		[XmlElement(ElementName = "GrossValue")]
		public decimal GrossValue { get; set; }

		[XmlElement(ElementName = "GrossValue0")]
		public decimal GrossValue0 { get; set; }

		[XmlElement(ElementName = "VatAmount0")]
		public decimal VatAmount0 { get; set; }

		[XmlElement(ElementName = "GrossValue5")]
		public decimal GrossValue5 { get; set; }

		[XmlElement(ElementName = "VatAmount5")]
		public decimal VatAmount5 { get; set; }
		[XmlElement(ElementName = "GrossValue8")]
		public decimal GrossValue8 { get; set; }

		[XmlElement(ElementName = "VatAmount8")]
		public decimal VatAmount8 { get; set; }

		[XmlElement(ElementName = "GrossValue10")]
		public decimal GrossValue10 { get; set; }

		[XmlElement(ElementName = "VatAmount10")]
		public decimal? VatAmount10 { get; set; }

		[XmlElement(ElementName = "Buyer")]
		public string Buyer { get; set; }
		[XmlElement(ElementName = "Type")]
		public int Type { get; set; }

		[XmlElement(ElementName = "DiscountRate")]
		public int DiscountRate { get; set; }

		[XmlElement(ElementName = "Fkey")]
		public string Fkey { get; set; }

		[XmlElement(ElementName = "GrossValue_NonTax")]
		public object GrossValueNonTax { get; set; }

		[XmlElement(ElementName = "CurrencyUnit")]
		public string CurrencyUnit { get; set; }

		[XmlElement(ElementName = "ExchangeRate")]
		public string ExchangeRate { get; set; }

		[XmlElement(ElementName = "ConvertedAmount")]
		public string ConvertedAmount { get; set; }
	}
	[XmlRoot(ElementName = "Invoice")]
	public class Invoice
	{
		[XmlElement(ElementName = "InvoiceNo")]
		public string InvoiceNo { get; set; }

		[XmlElement(ElementName = "CusCode")]
		public string CusCode { get; set; }

		[XmlElement(ElementName = "CusName")]
		public string CusName { get; set; }
		[XmlElement(ElementName = "CusBankNo")]
		public string CusBankNo { get; set; }
		[XmlElement(ElementName = "CusBankName")]
		public string CusBankName { get; set; }

		[XmlElement(ElementName = "CusAddress")]
		public string CusAddress { get; set; }

		[XmlElement(ElementName = "CusPhone")]
		public string CusPhone { get; set; }

		[XmlElement(ElementName = "CusTaxCode")]
		public string CusTaxCode { get; set; }

		[XmlElement(ElementName = "PaymentMethod")]
		public string PaymentMethod { get; set; }

		[XmlElement(ElementName = "KindOfService")]
		public int KindOfService { get; set; }

		[XmlElement(ElementName = "Products")]
		public Products Products { get; set; }

		[XmlElement(ElementName = "Total")]
		public decimal Total { get; set; }

		[XmlElement(ElementName = "DiscountAmount")]
		public decimal DiscountAmount { get; set; }

		[XmlElement(ElementName = "VATRate")]
		public int VATRate { get; set; }

		[XmlElement(ElementName = "VATAmount")]
		public decimal VATAmount { get; set; }

		[XmlElement(ElementName = "Amount")]
		public decimal Amount { get; set; }

		[XmlElement(ElementName = "AmountInWords")]
		public string AmountInWords { get; set; }

		[XmlElement(ElementName = "Extra")]
		public string Extra { get; set; }
		[XmlElement(ElementName = "Extra9")]
		public string Extra9 { get; set; }
		[XmlElement(ElementName = "Extra10")]
		public string Extra10 { get; set; }

		[XmlElement(ElementName = "ArisingDate")]
		public string ArisingDate { get; set; }

		[XmlElement(ElementName = "PaymentStatus")]
		public string PaymentStatus { get; set; }

		[XmlElement(ElementName = "EmailDeliver")]
		public string EmailDeliver { get; set; }

		[XmlElement(ElementName = "ResourceCode")]
		public string ResourceCode { get; set; }

		[XmlElement(ElementName = "GrossValue")]
		public decimal GrossValue { get; set; }

		[XmlElement(ElementName = "GrossValue0")]
		public decimal GrossValue0 { get; set; }

		[XmlElement(ElementName = "VatAmount0")]
		public decimal VatAmount0 { get; set; }

		[XmlElement(ElementName = "GrossValue5")]
		public decimal GrossValue5 { get; set; }

		[XmlElement(ElementName = "VatAmount5")]
		public decimal VatAmount5 { get; set; }
		[XmlElement(ElementName = "GrossValue8")]
		public decimal GrossValue8 { get; set; }

		[XmlElement(ElementName = "VatAmount8")]
		public decimal VatAmount8 { get; set; }

		[XmlElement(ElementName = "GrossValue10")]
		public decimal GrossValue10 { get; set; }

		[XmlElement(ElementName = "VatAmount10")]
		public decimal? VatAmount10 { get; set; }

		[XmlElement(ElementName = "Buyer")]
		public string Buyer { get; set; }

		[XmlElement(ElementName = "DiscountRate")]
		public int DiscountRate { get; set; }

		[XmlElement(ElementName = "Fkey")]
		public string Fkey { get; set; }

		[XmlElement(ElementName = "GrossValue_NonTax")]
		public object GrossValueNonTax { get; set; }

		[XmlElement(ElementName = "CurrencyUnit")]
		public string CurrencyUnit { get; set; }

		[XmlElement(ElementName = "ExchangeRate")]
		public string ExchangeRate { get; set; }

		[XmlElement(ElementName = "ConvertedAmount")]
		public string ConvertedAmount { get; set; }
	}
	//public partial class Product
	//{
	//    [AllowHtml]
	//    public string ProdName { get; set; }
	//    public string Code { get; set; }
	//    [AllowHtml]
	//    public string ProdUnit { get; set; }
	//    public decimal ProdQuantity { get; set; }
	//    public decimal ProdPrice { get; set; }
	//    public decimal DiscountAmount { get; set; }
	//    public string Extra2 { get; set; }
	//    public decimal Total { get; set; }
	//}
	[XmlRoot(ElementName = "Product")]
	public class Product
	{
		[AllowHtml]
		[XmlElement(ElementName = "ProdName")]
		public string ProdName { get; set; }
		[AllowHtml]
		[XmlElement(ElementName = "ProdUnit")]
		public string ProdUnit { get; set; }
		[XmlElement(ElementName = "Code")]
		public string Code { get; set; }

		[XmlElement(ElementName = "ProdQuantity")]
		public decimal ProdQuantity { get; set; }

		[XmlElement(ElementName = "ProdPrice")]
		public decimal ProdPrice { get; set; }

		[XmlElement(ElementName = "Amount")]
		public decimal Amount { get; set; }

		[XmlElement(ElementName = "Total")]
		public decimal Total { get; set; }

		[XmlElement(ElementName = "VATRate")]
		public int? VATRate { get; set; }

		[XmlElement(ElementName = "VATAmount")]
		public decimal? VATAmount { get; set; }

		[XmlElement(ElementName = "Extra1")]
		public string Extra1 { get; set; }

		[XmlElement(ElementName = "Remark")]
		public string Remark { get; set; }
		[XmlElement(ElementName = "Extra2")]
		public string Extra2 { get; set; }

		[XmlElement(ElementName = "Discount")]
		public decimal Discount { get; set; }

		[XmlElement(ElementName = "DiscountAmount")]
		public decimal DiscountAmount { get; set; }

		[XmlElement(ElementName = "IsSum")]
		public int IsSum { get; set; }
	}

	public partial class InvresendemailPattern
	{
		public string Fkey { get; set; }
		public string EmailDeliver { get; set; }
		public string pattern { get; set; }
		public string serial { get; set; }
	}
	[XmlRoot(ElementName = "Invoices")]
	public partial class Invoicesresendemail
	{
		public Invresendemail Inv { get; set; }
	}
	[XmlRoot(ElementName = "Inv")]
	public partial class Invresendemail
	{
		public string Fkey { get; set; }
		public string EmailDeliver { get; set; }
	}
	public partial class Inv
	{
		public string key { get; set; }

		public Invoice Invoice { get; set; }
	}
	[XmlRoot(ElementName = "Invoices")]
	public partial class Invoices
	{
		[XmlElement(ElementName = "Inv")]
		public Inv Inv { get; set; }
	}




	[XmlRoot(ElementName = "Content")]
	public class Content
	{

		[XmlElement(ElementName = "ArisingDate")]
		public string ArisingDate { get; set; }


		[XmlElement(ElementName = "InvoiceName")]
		public string InvoiceName { get; set; }

		[XmlElement(ElementName = "InvoicePattern")]
		public string InvoicePattern { get; set; }

		[XmlElement(ElementName = "SerialNo")]
		public string SerialNo { get; set; }

		[XmlElement(ElementName = "InvoiceNo")]
		public int InvoiceNo { get; set; }

		[XmlElement(ElementName = "Kind_of_Payment")]
		public string KindOfPayment { get; set; }

		[XmlElement(ElementName = "ComName")]
		public string ComName { get; set; }

		[XmlElement(ElementName = "ComTaxCode")]
		public string ComTaxCode { get; set; }

		[XmlElement(ElementName = "ComAddress")]
		public string ComAddress { get; set; }

		[XmlElement(ElementName = "ComPhone")]
		public string ComPhone { get; set; }

		[XmlElement(ElementName = "ComBankNo")]
		public string ComBankNo { get; set; }

		[XmlElement(ElementName = "ComBankName")]
		public string ComBankName { get; set; }

		[XmlElement(ElementName = "CusCode")]
		public string CusCode { get; set; }

		[XmlElement(ElementName = "CusName")]
		public string CusName { get; set; }

		[XmlElement(ElementName = "CusTaxCode")]
		public string CusTaxCode { get; set; }

		[XmlElement(ElementName = "CusPhone")]
		public string CusPhone { get; set; }

		[XmlElement(ElementName = "CusAddress")]
		public string CusAddress { get; set; }

		[XmlElement(ElementName = "CusBankName")]
		public string CusBankName { get; set; }

		[XmlElement(ElementName = "CusBankNo")]
		public string CusBankNo { get; set; }

		[XmlElement(ElementName = "Total")]
		public double Total { get; set; }

		[XmlElement(ElementName = "VAT_Amount")]
		public double VATAmount { get; set; }

		[XmlElement(ElementName = "Amount")]
		public double Amount { get; set; }

		[XmlElement(ElementName = "Amount_words")]
		public string AmountWords { get; set; }

		[XmlElement(ElementName = "Extras")]
		public object Extras { get; set; }

		[XmlElement(ElementName = "Buyer")]
		public string Buyer { get; set; }



		[XmlElement(ElementName = "VatAmount0")]
		public int VatAmount0 { get; set; }



		[XmlElement(ElementName = "VatAmount5")]
		public int VatAmount5 { get; set; }



		[XmlElement(ElementName = "VatAmount10")]
		public int VatAmount10 { get; set; }



		[XmlElement(ElementName = "CurrencyUnit")]
		public object CurrencyUnit { get; set; }

		[XmlElement(ElementName = "ExchangeRate")]
		public int ExchangeRate { get; set; }

		[XmlElement(ElementName = "ConvertedAmount")]
		public int ConvertedAmount { get; set; }

		[XmlElement(ElementName = "VAT_Rate")]
		public int VATRate { get; set; }

		[XmlElement(ElementName = "KindOfService")]
		public int KindOfService { get; set; }

		[XmlElement(ElementName = "Discount_Rate")]
		public decimal DiscountRate { get; set; }

		[XmlElement(ElementName = "Discount_Amount")]
		public double DiscountAmount { get; set; }

		[XmlElement(ElementName = "Products")]
		public Products Products { get; set; }

		[XmlElement(ElementName = "SignDate")]
		public string SignDate { get; set; }
		[XmlElement(ElementName = "isReplace")]
		public string IsReplace { get; set; }

		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Customer")]
	public class Customer
	{

		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }

		[XmlElement(ElementName = "Code")]
		public string Code { get; set; }

		[XmlElement(ElementName = "Account")]
		public string Account { get; set; }

		[XmlElement(ElementName = "TaxCode")]
		public string TaxCode { get; set; }

		[XmlElement(ElementName = "Address")]
		public string Address { get; set; }

		[XmlElement(ElementName = "BankAccountName")]
		public string BankAccountName { get; set; }

		[XmlElement(ElementName = "BankName")]
		public string BankName { get; set; }

		[XmlElement(ElementName = "BankNumber")]
		public string BankNumber { get; set; }

		[XmlElement(ElementName = "Email")]
		public string Email { get; set; }

		[XmlElement(ElementName = "Fax")]
		public string Fax { get; set; }

		[XmlElement(ElementName = "Phone")]
		public string Phone { get; set; }

		[XmlElement(ElementName = "ContactPerson")]
		public string ContactPerson { get; set; }

		[XmlElement(ElementName = "RepresentPerson")]
		public string RepresentPerson { get; set; }

		[XmlElement(ElementName = "CusType")]
		public int CusType { get; set; }

		[XmlElement(ElementName = "IsEmail")]
		public int IsEmail { get; set; }
	}

	[XmlRoot(ElementName = "Customers")]
	public class Customers
	{

		[XmlElement(ElementName = "Customer")]
		public List<Customer> Customer { get; set; }
	}


	[XmlRoot(ElementName = "DSHDon")]
	public class DSHDon
	{

		[XmlElement(ElementName = "HDon")]
		public HDon HDon { get; set; }
	}


	[XmlRoot(ElementName = "DieuChinhHD")]
	public class DieuChinhHD
	{

		[XmlElement(ElementName = "key")]
		public string Key { get; set; }

		[XmlElement(ElementName = "Type")]
		public string Type { get; set; }

		[XmlElement(ElementName = "TTChung")]
		public TTChung TTChung { get; set; }

		[XmlElement(ElementName = "NDHDon")]
		public NDHDon NDHDon { get; set; }
	}

	[XmlRoot(ElementName = "ThayTheHD")]
	public class ThayTheHD
	{

		[XmlElement(ElementName = "key")]
		public string Key { get; set; }

		[XmlElement(ElementName = "TTChung")]
		public TTChung TTChung { get; set; }

		[XmlElement(ElementName = "NDHDon")]
		public NDHDon NDHDon { get; set; }
	}
	public partial class InvoicesPattern
	{
		public string pattern { get; set; }
		public string serial { get; set; }
		public Invoices Invoices { get; set; }
		public Inv Inv { get; set; }
	}
	public partial class ReplaceInvPattern
	{
		public string pattern { get; set; }
		public string serial { get; set; }
		public ReplaceInv ReplaceInv { get; set; }
		public string fkey { get; set; }
	}
	public partial class AdjustInvPattern
	{
		public string pattern { get; set; }
		public string serial { get; set; }
		public AdjustInv AdjustInv { get; set; }
		public string fkey { get; set; }
	}
	public partial class ModelFromNotoNo
	{
		public string pattern { get; set; }
		public string serial { get; set; }
		public string fromno { get; set; }
		public string tono { get; set; }
	}

    public partial class ModelByCus
    {
        public string cuscode { get; set; }
        public string fromdate { get; set; }
        public string todate { get; set; }
    }
    public partial class ModelSearch
	{
		public string extra10 { get; set; }
		public string cuscode { get; set; }
		public string pattern { get; set; }
		public string serial { get; set; }
		public string fromno { get; set; }
		public string tono { get; set; }
		public int? page { get; set; }
		public int? pagesize { get; set; }
		public string fromdate { get; set; }
		public string todate { get; set; }

	}

	public partial class ModelFromDatetoDate
	{
		public string makh { get; set; }
		public string fromdate { get; set; }
		public string todate { get; set; }
		public string fkey { get; set; }
	}
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(HDon));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (HDon)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "TTHDLQuan")]
	public class TTHDLQuan
	{

		[XmlElement(ElementName = "TCHDon")]
		public int TCHDon { get; set; }

		[XmlElement(ElementName = "LHDCLQuan")]
		public int LHDCLQuan { get; set; }

		[XmlElement(ElementName = "KHMSHDCLQuan")]
		public int KHMSHDCLQuan { get; set; }

		[XmlElement(ElementName = "KHHDCLQuan")]
		public string KHHDCLQuan { get; set; }

		[XmlElement(ElementName = "SHDCLQuan")]
		public string SHDCLQuan { get; set; }

		[XmlElement(ElementName = "NLHDCLQuan")]
		public DateTime NLHDCLQuan { get; set; }

		[XmlElement(ElementName = "GChu")]
		public string GChu { get; set; }
	}

	[XmlRoot(ElementName = "TTChung")]
	public class TTChung
	{

		[XmlElement(ElementName = "PBan")]
		public string PBan { get; set; }

		[XmlElement(ElementName = "THDon")]
		public string THDon { get; set; }

		[XmlElement(ElementName = "KHMSHDon")]
		public string KHMSHDon { get; set; }

		[XmlElement(ElementName = "KHHDon")]
		public string KHHDon { get; set; }

		[XmlElement(ElementName = "SHDon")]
		public string SHDon { get; set; }

		[XmlElement(ElementName = "NLap")]
		public string NLap { get; set; }

		[XmlElement(ElementName = "DVTTe")]
		public string DVTTe { get; set; }

		[XmlElement(ElementName = "TGia")]
		public int TGia { get; set; }

		[XmlElement(ElementName = "HTTToan")]
		public string HTTToan { get; set; }

		[XmlElement(ElementName = "TTHDLQuan")]
		public TTHDLQuan TTHDLQuan { get; set; }
	}





	[XmlRoot(ElementName = "NBan")]
	public class NBan
	{

		[XmlElement(ElementName = "Ten")]
		public string Ten { get; set; }

		[XmlElement(ElementName = "MST")]
		public string MST { get; set; }

		[XmlElement(ElementName = "DChi")]
		public string DChi { get; set; }

		[XmlElement(ElementName = "SDThoai")]
		public string SDThoai { get; set; }

		[XmlElement(ElementName = "STKNHang")]
		public string STKNHang { get; set; }

		[XmlElement(ElementName = "TNHang")]
		public string TNHang { get; set; }


	}

	[XmlRoot(ElementName = "NMua")]
	public class NMua
	{



		[XmlElement(ElementName = "Ten")]
		public string Ten { get; set; }

		[XmlElement(ElementName = "DChi")]
		public string DChi { get; set; }
		[XmlElement(ElementName = "MST")]
		public string MST { get; set; }

		[XmlElement(ElementName = "MKHang")]
		public string MKHang { get; set; }

		[XmlElement(ElementName = "SDThoai")]
		public string SDThoai { get; set; }

		[XmlElement(ElementName = "STKNHang")]
		public string STKNHang { get; set; }

		[XmlElement(ElementName = "TNHang")]
		public string TNHang { get; set; }
	}

	[XmlRoot(ElementName = "HHDVu")]
	public class HHDVu
	{

		[XmlElement(ElementName = "TChat")]
		public int TChat { get; set; }

		[XmlElement(ElementName = "STT")]
		public int STT { get; set; }

		[XmlElement(ElementName = "MHHDVu")]
		public string MHHDVu { get; set; }

		[XmlElement(ElementName = "THHDVu")]
		public string THHDVu { get; set; }

		[XmlElement(ElementName = "DVTinh")]
		public string DVTinh { get; set; }

		[XmlElement(ElementName = "SLuong")]
		public decimal SLuong { get; set; }

		[XmlElement(ElementName = "DGia")]
		public decimal DGia { get; set; }

		[XmlElement(ElementName = "TLCKhau")]
		public decimal TLCKhau { get; set; }

		[XmlElement(ElementName = "STCKhau")]
		public decimal STCKhau { get; set; }

		[XmlElement(ElementName = "TSuat")]
		public string TSuat { get; set; }

		[XmlElement(ElementName = "ThTien")]
		public decimal ThTien { get; set; }

		[XmlElement(ElementName = "TSThue")]
		public decimal TSThue { get; set; }
	}

	[XmlRoot(ElementName = "DSHHDVu")]
	public class DSHHDVu
	{

		[XmlElement(ElementName = "HHDVu")]
		public List<HHDVu> HHDVu { get; set; }
	}

	[XmlRoot(ElementName = "LTSuat")]
	public class LTSuat
	{

		[XmlElement(ElementName = "TSuat")]
		public string TSuat { get; set; }

		[XmlElement(ElementName = "TThue")]
		public decimal TThue { get; set; }

		[XmlElement(ElementName = "ThTien")]
		public decimal ThTien { get; set; }
	}

	[XmlRoot(ElementName = "THTTLTSuat")]
	public class THTTLTSuat
	{

		[XmlElement(ElementName = "LTSuat")]
		public LTSuat LTSuat { get; set; }
	}

	[XmlRoot(ElementName = "TToan")]
	public class TToan
	{

		[XmlElement(ElementName = "THTTLTSuat")]
		public THTTLTSuat THTTLTSuat { get; set; }

		[XmlElement(ElementName = "TgTCThue")]
		public decimal TgTCThue { get; set; }

		[XmlElement(ElementName = "TgTThue")]
		public decimal TgTThue { get; set; }

		[XmlElement(ElementName = "TTCKTMai")]
		public decimal TTCKTMai { get; set; }

		[XmlElement(ElementName = "TgTTTBSo")]
		public decimal TgTTTBSo { get; set; }

		[XmlElement(ElementName = "TgTTTBChu")]
		public string TgTTTBChu { get; set; }
	}

	[XmlRoot(ElementName = "NDHDon")]
	public class NDHDon
	{



		[XmlElement(ElementName = "NBan")]
		public NBan NBan { get; set; }

		[XmlElement(ElementName = "NMua")]
		public NMua NMua { get; set; }

		[XmlElement(ElementName = "DSHHDVu")]
		public DSHHDVu DSHHDVu { get; set; }

		[XmlElement(ElementName = "TToan")]
		public TToan TToan { get; set; }
	}

	[XmlRoot(ElementName = "DLHDon")]
	public class DLHDon
	{

		[XmlElement(ElementName = "TTChung")]
		public TTChung TTChung { get; set; }

		[XmlElement(ElementName = "NDHDon")]
		public NDHDon NDHDon { get; set; }

		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}


	[XmlRoot(ElementName = "HDon")]
	public class HDon
	{

		[XmlElement(ElementName = "DLHDon")]
		public DLHDon DLHDon { get; set; }


		[XmlElement(ElementName = "Fkey")]
		public string Fkey { get; set; }
	}
	[XmlRoot(ElementName = "HDon")]
	public class HDonCheck
	{

		[XmlElement(ElementName = "KHMSHDon")]
		public string KHMSHDon { get; set; }

		[XmlElement(ElementName = "KHHDon")]
		public string KHHDon { get; set; }

		[XmlElement(ElementName = "SHDon")]
		public string SHDon { get; set; }

		[XmlElement(ElementName = "DLKy")]
		public string DLKy { get; set; }

		[XmlElement(ElementName = "MCCQThue")]
		public string MCCQThue { get; set; }

		[XmlElement(ElementName = "TThai")]
		public int TThai { get; set; }

		[XmlElement(ElementName = "MTLoi")]
		public string MTLoi { get; set; }

		[XmlElement(ElementName = "Fkey")]
		public string Fkey { get; set; }
	}
	[XmlRoot(ElementName = "DSHDon")]
	public class DSHDonCheck
	{

		[XmlElement(ElementName = "HDon")]
		public HDonCheck HDonCheck { get; set; }
	}
	[XmlRoot(ElementName = "HDon")]
	public class HDonSS
	{

		[XmlElement(ElementName = "STT")]
		public int STT { get; set; }

		[XmlElement(ElementName = "MCQTCap")]
		public string MCQTCap { get; set; }

		[XmlElement(ElementName = "KHMSHDon")]
		public string KHMSHDon { get; set; }

		[XmlElement(ElementName = "KHHDon")]
		public string KHHDon { get; set; }

		[XmlElement(ElementName = "SHDon")]
		public string SHDon { get; set; }

		[XmlElement(ElementName = "Ngay")]
		public string Ngay { get; set; }

		[XmlElement(ElementName = "LADHDDT")]
		public int LADHDDT { get; set; }

		[XmlElement(ElementName = "TCTBao")]
		public int TCTBao { get; set; }

		[XmlElement(ElementName = "LDo")]
		public string LDo { get; set; }

		[XmlElement(ElementName = "Fkey")]
		public string Fkey { get; set; }
	}

	[XmlRoot(ElementName = "DSHDon")]
	public class DSHDonSS
	{

		[XmlElement(ElementName = "HDon")]
		public HDonSS HDon { get; set; }
	}

	[XmlRoot(ElementName = "DLTBao")]
	public class DLTBao
	{

		[XmlElement(ElementName = "TNNT")]
		public string TNNT { get; set; }

		[XmlElement(ElementName = "TCQT")]
		public string TCQT { get; set; }

		[XmlElement(ElementName = "NTBao")]
		public string NTBao { get; set; }

		[XmlElement(ElementName = "DDanh")]
		public string DDanh { get; set; }

		[XmlElement(ElementName = "Loai")]
		public int Loai { get; set; }

		[XmlElement(ElementName = "So")]
		public string So { get; set; }

		[XmlElement(ElementName = "NTBCCQT")]
		public string NTBCCQT { get; set; }

		[XmlElement(ElementName = "DSHDon")]
		public DSHDonSS DSHDon { get; set; }
	}

}