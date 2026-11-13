//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitskout
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitskoutActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ListPluginsResponseItem[], ApiConnectionActionConfiguration> ListPlugins()
        {
            return new DeferredBodyAction<ListPluginsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerauto/plugins";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListPluginsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<RunPluginForFileResponse, ApiConnectionActionConfiguration> RunPluginForFile(Expression<Func<RunPluginForFileBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RunPluginForFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerauto/run_file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunPluginForFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<RunPluginTextResponse, ApiConnectionActionConfiguration> RunPluginText(Expression<Func<RunPluginTextBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RunPluginTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerauto/run_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunPluginTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataFromInvoiceResponse, ApiConnectionActionConfiguration> ExtractDataFromInvoice(Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractDataFromInvoiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractDataFromInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataPurchaseOrdersResponse, ApiConnectionActionConfiguration> ExtractDataPurchaseOrders(Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractDataPurchaseOrdersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/purchase_order";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractDataPurchaseOrdersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataBillofLadingResponse, ApiConnectionActionConfiguration> ExtractDataBillofLading(Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractDataBillofLadingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/bill_of_lading";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractDataBillofLadingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataCVResponse, ApiConnectionActionConfiguration> ExtractDataCV(Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractDataCVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/cv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractDataCVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<DetectDocumentTypeResponse, ApiConnectionActionConfiguration> DetectDocumentType(Expression<Func<DoctypeInput>> doctype, Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_doctype = WorkflowExpression.Compile(doctype, nameof(doctype), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DetectDocumentTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/actions/doctype_{0}", __workflow_doctype.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DetectDocumentTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataBusinessCardsResponse, ApiConnectionActionConfiguration> ExtractDataBusinessCards(Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractDataBusinessCardsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/business_cards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractDataBusinessCardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractQRCodeResponse, ApiConnectionActionConfiguration> ExtractQRCode(Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractQRCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/qrcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractQRCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractBarcodeFromFileResponse, ApiConnectionActionConfiguration> ExtractBarcodeFromFile(Expression<Func<DetectDocumentTypeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractBarcodeFromFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/barcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractBarcodeFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<DetectResponseColdEmailResponse, ApiConnectionActionConfiguration> DetectResponseColdEmail(Expression<Func<DetectResponseColdEmailBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DetectResponseColdEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/cold_response";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DetectResponseColdEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataHaroResponse, ApiConnectionActionConfiguration> ExtractDataHaro(Expression<Func<DetectResponseColdEmailBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractDataHaroResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/actions/haro";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractDataHaroResponse>(callPayload);
            });
        }
    }

    public class BitskoutTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListPluginsResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }
    }

    public class RunPluginForFileResponse
    {
        [JsonProperty("outputs")]
        public JToken Outputs { get; set; }
    }

    public class RunPluginForFileBodyInput
    {
        [JsonProperty("plugin")]
        public string Plugin { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }
    }

    public class RunPluginTextResponse
    {
        [JsonProperty("outputs")]
        public JToken Outputs { get; set; }
    }

    public class RunPluginTextBodyInput
    {
        [JsonProperty("plugin")]
        public string Plugin { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ExtractDataFromInvoiceResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataFromInvoiceResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataFromInvoiceResponseOutputsType
    {
        [JsonProperty("CURRENCY")]
        public string Currency { get; set; }

        [JsonProperty("CUSTOMER_ADDRESS")]
        public string CustomerAddress { get; set; }

        [JsonProperty("CUSTOMER_NAME")]
        public string CustomerName { get; set; }

        [JsonProperty("DISCOUNT")]
        public string Discount { get; set; }

        [JsonProperty("DUE_DATE")]
        public string DueDate { get; set; }

        [JsonProperty("INVOICE_RECEIPT_DATE")]
        public string InvoiceReceiptDate { get; set; }

        [JsonProperty("INVOICE_RECEIPT_ID")]
        public string InvoiceReceiptId { get; set; }

        [JsonProperty("LINE_ITEMS")]
        public string LineItems { get; set; }

        [JsonProperty("NUMBER_OF_PAGES")]
        public int NumberOfPages { get; set; }

        [JsonProperty("RECEIVER_ADDRESS")]
        public string ReceiverAddress { get; set; }

        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }

        [JsonProperty("SUBTOTAL")]
        public string Subtotal { get; set; }

        [JsonProperty("SUPPLIER_ADDRESS")]
        public string SupplierAddress { get; set; }

        [JsonProperty("TAX")]
        public string Tax { get; set; }

        [JsonProperty("TOTAL")]
        public string Total { get; set; }

        [JsonProperty("VENDOR_NAME")]
        public string VendorName { get; set; }

        [JsonProperty("VENDOR_VAT_NUMBER")]
        public string VendorVatNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DetectDocumentTypeBodyInput
    {
        [JsonProperty("file_url")]
        public string FileUrl { get; set; }
    }

    public class ExtractDataPurchaseOrdersResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataPurchaseOrdersResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataPurchaseOrdersResponseOutputsType
    {
        [JsonProperty("ACCOUNT_NUMBER")]
        public string AccountNumber { get; set; }

        [JsonProperty("CUSTOMER_NAME")]
        public string CustomerName { get; set; }

        [JsonProperty("LINE_ITEMS")]
        public string LineItems { get; set; }

        [JsonProperty("NUMBER_OF_PAGES")]
        public int NumberOfPages { get; set; }

        [JsonProperty("PURCHASE_ORDER_DATE")]
        public string PurchaseOrderDate { get; set; }

        [JsonProperty("PURCHASE_ORDER_ID")]
        public string PurchaseOrderId { get; set; }

        [JsonProperty("PURCHASE_ORDER_NUMBER")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty("RECEIVER_ADDRESS")]
        public string ReceiverAddress { get; set; }

        [JsonProperty("RECEIVER_NAME")]
        public string ReceiverName { get; set; }

        [JsonProperty("REFERENCE_NUMBER")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }

        [JsonProperty("TAX_ID")]
        public string TaxId { get; set; }

        [JsonProperty("TOTAL")]
        public string Total { get; set; }

        [JsonProperty("TRACKING_NUMBER")]
        public string TrackingNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ExtractDataBillofLadingResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataBillofLadingResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataBillofLadingResponseOutputsType
    {
        [JsonProperty("BL Number")]
        public string BLNumber { get; set; }

        [JsonProperty("BOL Type")]
        public string BolType { get; set; }

        [JsonProperty("Booking N")]
        public string BookingN { get; set; }
        public string Consignee { get; set; }

        [JsonProperty("Notify Party")]
        public string NotifyParty { get; set; }

        [JsonProperty("Port of Discharge")]
        public string PortOfDischarge { get; set; }

        [JsonProperty("Port of Loading")]
        public string PortOfLoading { get; set; }

        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }
        public string ShippedOnBoard { get; set; }
        public string Shipper { get; set; }
        public string Vessel { get; set; }
        public string VoyageN { get; set; }
        public string Weight { get; set; }
    }

    public class ExtractDataCVResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataCVResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataCVResponseOutputsType
    {
        [JsonProperty("EDUCATION")]
        public string Education { get; set; }

        [JsonProperty("EMAILS")]
        public string Emails { get; set; }

        [JsonProperty("EXPERIENCE")]
        public string Experience { get; set; }

        [JsonProperty("JOB_TITLE")]
        public string JobTitle { get; set; }

        [JsonProperty("LINKEDIN")]
        public string Linkedin { get; set; }

        [JsonProperty("LOCATION")]
        public string Location { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("PHONE_NUMBERS")]
        public string PhoneNumbers { get; set; }

        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }

        [JsonProperty("SKILLS")]
        public string Skills { get; set; }

        [JsonProperty("TOTAL_YEARS_EXPERIENCE")]
        public string TotalYearsExperience { get; set; }
    }

    public class DetectDocumentTypeResponse
    {
        [JsonProperty("outputs")]
        public DetectDocumentTypeResponseOutputsType Outputs { get; set; }
    }

    public class DetectDocumentTypeResponseOutputsType
    {
        [JsonProperty("Document Type")]
        public string DocumentType { get; set; }

        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DoctypeInput
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "logistics")]
        Logistics
    }

    public class ExtractDataBusinessCardsResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataBusinessCardsResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataBusinessCardsResponseOutputsType
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("COMPANY_NAME")]
        public string CompanyName { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EmailAddress { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("LOCATION")]
        public string Location { get; set; }

        [JsonProperty("LOGO_URL")]
        public string LogoUrl { get; set; }

        [JsonProperty("MOBILE")]
        public string Mobile { get; set; }

        [JsonProperty("PERSON_NAME")]
        public string PersonName { get; set; }

        [JsonProperty("PERSON_POSITION")]
        public string PersonPosition { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }

        [JsonProperty("WEBSITE")]
        public string Website { get; set; }
    }

    public class ExtractQRCodeResponse
    {
        [JsonProperty("outputs")]
        public ExtractQRCodeResponseOutputsType Outputs { get; set; }
    }

    public class ExtractQRCodeResponseOutputsType
    {
        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }

        [JsonProperty("qrcode")]
        public string Qrcode { get; set; }
    }

    public class ExtractBarcodeFromFileResponse
    {
        [JsonProperty("outputs")]
        public ExtractBarcodeFromFileResponseOutputsType Outputs { get; set; }
    }

    public class ExtractBarcodeFromFileResponseOutputsType
    {
        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }

    public class DetectResponseColdEmailResponse
    {
        [JsonProperty("outputs")]
        public DetectResponseColdEmailResponseOutputsType Outputs { get; set; }
    }

    public class DetectResponseColdEmailResponseOutputsType
    {
        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }
        public string Result { get; set; }
    }

    public class DetectResponseColdEmailBodyInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ExtractDataHaroResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataHaroResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataHaroResponseOutputsType
    {
        [JsonProperty("CATEGORY")]
        public string Category { get; set; }

        [JsonProperty("DEADLINE")]
        public string Deadline { get; set; }

        [JsonProperty("EMAIL")]
        public string Email { get; set; }

        [JsonProperty("MEDIA OUTLET")]
        public string MediaOutlet { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("QUERY")]
        public string Query { get; set; }

        [JsonProperty("REQUIREMENTS")]
        public string Requirements { get; set; }

        [JsonProperty("RawJSON")]
        public string RawJson { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bitskout;

    public partial class WorkflowManagedActions
    {
        public BitskoutActions Bitskout(string connectionId) => new BitskoutActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BitskoutTriggers Bitskout(string connectionId) => new BitskoutTriggers(connectionId);
    }
}