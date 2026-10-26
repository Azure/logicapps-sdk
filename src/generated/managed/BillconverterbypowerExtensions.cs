//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Billconverterbypower
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BillconverterbypowerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf, ApiConnectionActionConfiguration> T10A002AV01CV01ExtractXmlFromInvoicePdf(Expression<Func<T10A002AV01CV01ExtractXmlFromInvoicePdfInput>> dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf)
        {
            var __workflow_dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf = WorkflowExpression.Compile(dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf, nameof(dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf), required: true);
            return new DeferredBodyAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V01/T10_A002_AV01_CV01_ExtractXmlFromInvoicePdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf);
                return new ApiConnectionAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf, ApiConnectionActionConfiguration> T10A003AV01CV01ConvertXmlInvoiceToPdf(Expression<Func<T10A003AV01CV01ConvertXmlInvoiceToPdfInput>> dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf)
        {
            var __workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf = WorkflowExpression.Compile(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf, nameof(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf), required: true);
            return new DeferredBodyAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V01/T10_A003_AV01_CV01_ConvertXmlInvoiceToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf);
                return new ApiConnectionAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf, ApiConnectionActionConfiguration> T10A001AV02CV02ConvertInvoiceToZugferdPdf(Expression<Func<T10A001AV02CV02ConvertInvoiceToZugferdPdfInput>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf)
        {
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf), required: true);
            return new DeferredBodyAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A001_AV02_CV02_ConvertInvoiceToZugferdPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf);
                return new ApiConnectionAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan, ApiConnectionActionConfiguration> T10A004AV01CV02ExtractInvoiceDataFromScan(Expression<Func<T10A004AV01CV02ExtractInvoiceDataFromScanInput>> dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan)
        {
            var __workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan = WorkflowExpression.Compile(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan, nameof(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan), required: true);
            return new DeferredBodyAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A004_AV01_CV02_ExtractInvoiceDataFromScan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan);
                return new ApiConnectionAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A005AV01CV02ValidateIban, ApiConnectionActionConfiguration> T10A005AV01CV02ValidateIban(Expression<Func<T10A005AV01CV02ValidateIbanInput>> dtoRequestT10A005AV01CV02ValidateIban)
        {
            var __workflow_dtoRequestT10A005AV01CV02ValidateIban = WorkflowExpression.Compile(dtoRequestT10A005AV01CV02ValidateIban, nameof(dtoRequestT10A005AV01CV02ValidateIban), required: true);
            return new DeferredBodyAction<DtoResponseT10A005AV01CV02ValidateIban, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A005_AV01_CV02_ValidateIban";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A005AV01CV02ValidateIban);
                return new ApiConnectionAction<DtoResponseT10A005AV01CV02ValidateIban>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A006AV01CV02ValidateVatId, ApiConnectionActionConfiguration> T10A006AV01CV02ValidateVatId(Expression<Func<T10A006AV01CV02ValidateVatIdInput>> dtoRequestT10A006AV01CV02ValidateVatId)
        {
            var __workflow_dtoRequestT10A006AV01CV02ValidateVatId = WorkflowExpression.Compile(dtoRequestT10A006AV01CV02ValidateVatId, nameof(dtoRequestT10A006AV01CV02ValidateVatId), required: true);
            return new DeferredBodyAction<DtoResponseT10A006AV01CV02ValidateVatId, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A006_AV01_CV02_ValidateVatId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A006AV01CV02ValidateVatId);
                return new ApiConnectionAction<DtoResponseT10A006AV01CV02ValidateVatId>(callPayload);
            });
        }
    }

    public class BillconverterbypowerTriggers([ConnectionName] string connectionId)
    {
    }

    public class DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf
    {
        [JsonProperty("xml")]
        public string XML { get; set; }
    }

    public class T10A002AV01CV01ExtractXmlFromInvoicePdfInput
    {
        [JsonProperty("invoicePdf")]
        public string InvoicePDF { get; set; }
    }

    public class DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf
    {
        [JsonProperty("pdf")]
        public string VisualizedInvoicePDF { get; set; }
    }

    public class T10A003AV01CV01ConvertXmlInvoiceToPdfInput
    {
        [JsonProperty("xml")]
        public string InvoiceXML { get; set; }

        [JsonProperty("type")]
        public string InvoiceType { get; set; }
    }

    public class DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf
    {
        [JsonProperty("zugferdPdf")]
        public string ZUGFeRDPDF { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class T10A001AV02CV02ConvertInvoiceToZugferdPdfInput
    {
        [JsonProperty("invoicePdf")]
        public string InvoicePDF { get; set; }

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonProperty("invoiceTypeCode")]
        public string InvoiceType { get; set; }

        [JsonProperty("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonProperty("servicePeriodStart")]
        public string ServicePeriodStart { get; set; }

        [JsonProperty("servicePeriodEnd")]
        public string ServicePeriodEnd { get; set; }

        [JsonProperty("currencyCode")]
        public string Currency { get; set; }

        [JsonProperty("businessProcess")]
        public string BusinessProcess { get; set; }

        [JsonProperty("buyerReference")]
        public string BuyerReference { get; set; }

        [JsonProperty("buyerOrderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("contractReference")]
        public string ContractReference { get; set; }

        [JsonProperty("projectReference")]
        public string ProjectReference { get; set; }

        [JsonProperty("invoiceNote")]
        public string InvoiceNote { get; set; }

        [JsonProperty("precedingInvoices")]
        public DtoPrecedingInvoice[] PrecedingInvoices { get; set; }

        [JsonProperty("sellerName")]
        public string SellerName { get; set; }

        [JsonProperty("sellerIdentifier")]
        public string SellerIdentifier { get; set; }

        [JsonProperty("sellerVatId")]
        public string SellerVATId { get; set; }

        [JsonProperty("sellerTaxNumber")]
        public string SellerTaxNumber { get; set; }

        [JsonProperty("sellerLegalRegistrationId")]
        public string SellerRegistrationId { get; set; }

        [JsonProperty("sellerStreet")]
        public string SellerStreet { get; set; }

        [JsonProperty("sellerPostcode")]
        public string SellerPostcode { get; set; }

        [JsonProperty("sellerCity")]
        public string SellerCity { get; set; }

        [JsonProperty("sellerCountry")]
        public string SellerCountry { get; set; }

        [JsonProperty("sellerEmail")]
        public string SellerEmail { get; set; }

        [JsonProperty("sellerContactName")]
        public string SellerContactName { get; set; }

        [JsonProperty("sellerContactPhone")]
        public string SellerContactPhone { get; set; }

        [JsonProperty("sellerContactEmail")]
        public string SellerContactEmail { get; set; }

        [JsonProperty("buyerName")]
        public string BuyerName { get; set; }

        [JsonProperty("buyerVatId")]
        public string BuyerVATId { get; set; }

        [JsonProperty("buyerStreet")]
        public string BuyerStreet { get; set; }

        [JsonProperty("buyerPostcode")]
        public string BuyerPostcode { get; set; }

        [JsonProperty("buyerCity")]
        public string BuyerCity { get; set; }

        [JsonProperty("buyerCountry")]
        public string BuyerCountry { get; set; }

        [JsonProperty("buyerEmail")]
        public string BuyerEmail { get; set; }

        [JsonProperty("buyerContactName")]
        public string BuyerContactName { get; set; }

        [JsonProperty("buyerContactEmail")]
        public string BuyerContactEmail { get; set; }

        [JsonProperty("deliveryName")]
        public string DeliveryName { get; set; }

        [JsonProperty("deliveryStreet")]
        public string DeliveryStreet { get; set; }

        [JsonProperty("deliveryPostcode")]
        public string DeliveryPostcode { get; set; }

        [JsonProperty("deliveryCity")]
        public string DeliveryCity { get; set; }

        [JsonProperty("deliveryCountry")]
        public string DeliveryCountry { get; set; }

        [JsonProperty("iban")]
        public string IBAN { get; set; }

        [JsonProperty("bic")]
        public string BIC { get; set; }

        [JsonProperty("paymentRecipient")]
        public string PaymentRecipient { get; set; }

        [JsonProperty("paymentInfo")]
        public string PaymentInfo { get; set; }

        [JsonProperty("paymentMeansCode")]
        public string PaymentMeans { get; set; }

        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        [JsonProperty("paymentDueDate")]
        public string PaymentDueDate { get; set; }

        [JsonProperty("skontoTerms")]
        public DtoSkontoTerm[] CashDiscountTerms { get; set; }

        [JsonProperty("prepaidAmount")]
        public double? PrepaidAmount { get; set; }

        [JsonProperty("taxExemptionReason")]
        public string TaxExemptionReason { get; set; }

        [JsonProperty("taxExemptionReasonCode")]
        public string TaxExemptionReasonCode { get; set; }

        [JsonProperty("invoiceLines")]
        public DtoInvoiceLineV2[] InvoiceItems { get; set; }

        [JsonProperty("documentAllowances")]
        public DtoAllowanceCharge[] DocumentDiscounts { get; set; }

        [JsonProperty("documentCharges")]
        public DtoAllowanceCharge[] DocumentCharges { get; set; }

        [JsonProperty("attachments")]
        public DtoAttachment[] Attachments { get; set; }

        [JsonProperty("autoAdjustAttachments")]
        public bool? AutoAdjustAttachments { get; set; }
    }

    public class DtoPrecedingInvoice
    {
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }
    }

    public class DtoSkontoTerm
    {
        [JsonProperty("days")]
        public int Days { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("baseAmount")]
        public double BaseAmount { get; set; }
    }

    public class DtoInvoiceLineV2
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("vatPercent")]
        public double VATPercent { get; set; }

        [JsonProperty("categoryCode")]
        public string TaxCategoryCode { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class DtoAllowanceCharge
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("vatPercent")]
        public double VATPercent { get; set; }

        [JsonProperty("categoryCode")]
        public string TaxCategoryCode { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class DtoAttachment
    {
        [JsonProperty("content")]
        public string FileContent { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan
    {
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonProperty("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonProperty("currencyCode")]
        public string Currency { get; set; }

        [JsonProperty("buyerReference")]
        public string BuyerReference { get; set; }

        [JsonProperty("buyerOrderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("sellerName")]
        public string SellerName { get; set; }

        [JsonProperty("sellerStreet")]
        public string SellerStreet { get; set; }

        [JsonProperty("sellerPostcode")]
        public string SellerPostcode { get; set; }

        [JsonProperty("sellerCity")]
        public string SellerCity { get; set; }

        [JsonProperty("sellerCountry")]
        public string SellerCountry { get; set; }

        [JsonProperty("sellerVatId")]
        public string SellerVATId { get; set; }

        [JsonProperty("sellerEmail")]
        public string SellerEmail { get; set; }

        [JsonProperty("buyerName")]
        public string BuyerName { get; set; }

        [JsonProperty("buyerStreet")]
        public string BuyerStreet { get; set; }

        [JsonProperty("buyerPostcode")]
        public string BuyerPostcode { get; set; }

        [JsonProperty("buyerCity")]
        public string BuyerCity { get; set; }

        [JsonProperty("buyerCountry")]
        public string BuyerCountry { get; set; }

        [JsonProperty("buyerVatId")]
        public string BuyerVATId { get; set; }

        [JsonProperty("iban")]
        public string IBAN { get; set; }

        [JsonProperty("bic")]
        public string BIC { get; set; }

        [JsonProperty("paymentRecipient")]
        public string PaymentRecipient { get; set; }

        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        [JsonProperty("paymentDueDate")]
        public string PaymentDueDate { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalVatAmount")]
        public double TotalVATAmount { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("invoiceLines")]
        public DtoRecognizedInvoiceLine[] InvoiceItems { get; set; }

        [JsonProperty("isReadyForEInvoice")]
        public bool ReadyForEInvoice { get; set; }

        [JsonProperty("missingRequiredFields")]
        public string[] MissingRequiredFields { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class DtoRecognizedInvoiceLine
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("vatPercent")]
        public double VATPercent { get; set; }

        [JsonProperty("lineNetAmount")]
        public double LineNetAmount { get; set; }
    }

    public class T10A004AV01CV02ExtractInvoiceDataFromScanInput
    {
        [JsonProperty("invoiceFile")]
        public string InvoiceFile { get; set; }

        [JsonProperty("additionalInstructions")]
        public string AdditionalInstructions { get; set; }
    }

    public class DtoResponseT10A005AV01CV02ValidateIban
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("compactIban")]
        public string CompactIBAN { get; set; }

        [JsonProperty("formattedIban")]
        public string FormattedIBAN { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("isSepaCountry")]
        public bool IsSEPACountry { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bic")]
        public string BICSWIFTCode { get; set; }

        [JsonProperty("bankCity")]
        public string BankCity { get; set; }

        [JsonProperty("bankPostcode")]
        public string BankPostalCode { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("bban")]
        public string BBAN { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class T10A005AV01CV02ValidateIbanInput
    {
        [JsonProperty("iban", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IBAN { get; set; }
    }

    public class DtoResponseT10A006AV01CV02ValidateVatId
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("isFormatValid")]
        public bool IsFormatValid { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("compactVatId")]
        public string CompactVATId { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyAddress")]
        public string CompanyAddress { get; set; }

        [JsonProperty("consultationNumber")]
        public string ConsultationNumber { get; set; }

        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        [JsonProperty("vatNumber")]
        public string VATNumber { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class T10A006AV01CV02ValidateVatIdInput
    {
        [JsonProperty("vatId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VATId { get; set; }

        [JsonProperty("requesterVatId")]
        public string YourCompanyVATId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Billconverterbypower;

    public partial class WorkflowManagedActions
    {
        public BillconverterbypowerActions Billconverterbypower(string connectionId) => new BillconverterbypowerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BillconverterbypowerTriggers Billconverterbypower(string connectionId) => new BillconverterbypowerTriggers(connectionId);
    }
}