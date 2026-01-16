//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bitskout
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BitskoutActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ListPluginsResponseItem[]> ListPlugins()
        {
            var apiCallPath = "/powerauto/plugins";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListPluginsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<RunPluginForFileResponse> RunPluginForFile(Expression<Func<string>> bodyplugin = null, Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/powerauto/run_file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyplugin != null)
            {
                body["plugin"] = ExpressionConverter.ConvertO(bodyplugin);
                bodypropCount++;
            }

            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RunPluginForFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<RunPluginTextResponse> RunPluginText(Expression<Func<string>> bodyplugin = null, Expression<Func<string>> bodytext = null)
        {
            var apiCallPath = "/powerauto/run_text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyplugin != null)
            {
                body["plugin"] = ExpressionConverter.ConvertO(bodyplugin);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RunPluginTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataFromInvoiceResponse> ExtractDataFromInvoice(Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/actions/invoices";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractDataFromInvoiceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataPurchaseOrdersResponse> ExtractDataPurchaseOrders(Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/actions/purchase_order";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractDataPurchaseOrdersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataBillofLadingResponse> ExtractDataBillofLading(Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/actions/bill_of_lading";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractDataBillofLadingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataCVResponse> ExtractDataCV(Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/actions/cv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractDataCVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<DetectDocumentTypeResponse> DetectDocumentType(Expression<Func<doctypeInput>> doctype, Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = String.Format("/actions/doctype_{0}", ExpressionConverter.ConvertWithUrlEncoding(doctype, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DetectDocumentTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataBusinessCardsResponse> ExtractDataBusinessCards(Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/actions/business_cards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractDataBusinessCardsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractQRCodeResponse> ExtractQRCode(Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/actions/qrcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractQRCodeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractBarcodeFromFileResponse> ExtractBarcodeFromFile(Expression<Func<string>> bodyfileUrl = null)
        {
            var apiCallPath = "/actions/barcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileUrl != null)
            {
                body["file_url"] = ExpressionConverter.ConvertO(bodyfileUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractBarcodeFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<DetectResponseColdEmailResponse> DetectResponseColdEmail(Expression<Func<string>> bodytext = null)
        {
            var apiCallPath = "/actions/cold_response";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DetectResponseColdEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bitskout")]
        public IBodyWorkflowAction<ExtractDataHAROResponse> ExtractDataHARO(Expression<Func<string>> bodytext = null)
        {
            var apiCallPath = "/actions/haro";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractDataHAROResponse>(callPayload);
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

    public class RunPluginTextResponse
    {
        [JsonProperty("outputs")]
        public JToken Outputs { get; set; }
    }

    public class ExtractDataFromInvoiceResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataFromInvoiceResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataFromInvoiceResponseOutputsType
    {
        public string CURRENCY { get; set; }

        [JsonProperty("CUSTOMER_ADDRESS")]
        public string CUSTOMERADDRESS { get; set; }

        [JsonProperty("CUSTOMER_NAME")]
        public string CUSTOMERNAME { get; set; }
        public string DISCOUNT { get; set; }

        [JsonProperty("DUE_DATE")]
        public string DUEDATE { get; set; }

        [JsonProperty("INVOICE_RECEIPT_DATE")]
        public string INVOICERECEIPTDATE { get; set; }

        [JsonProperty("INVOICE_RECEIPT_ID")]
        public string INVOICERECEIPTID { get; set; }

        [JsonProperty("LINE_ITEMS")]
        public string LINEITEMS { get; set; }

        [JsonProperty("NUMBER_OF_PAGES")]
        public int NUMBEROFPAGES { get; set; }

        [JsonProperty("RECEIVER_ADDRESS")]
        public string RECEIVERADDRESS { get; set; }
        public string RawJSON { get; set; }
        public string SUBTOTAL { get; set; }

        [JsonProperty("SUPPLIER_ADDRESS")]
        public string SUPPLIERADDRESS { get; set; }
        public string TAX { get; set; }
        public string TOTAL { get; set; }

        [JsonProperty("VENDOR_NAME")]
        public string VENDORNAME { get; set; }

        [JsonProperty("VENDOR_VAT_NUMBER")]
        public string VENDORVATNUMBER { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ExtractDataPurchaseOrdersResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataPurchaseOrdersResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataPurchaseOrdersResponseOutputsType
    {
        [JsonProperty("ACCOUNT_NUMBER")]
        public string ACCOUNTNUMBER { get; set; }

        [JsonProperty("CUSTOMER_NAME")]
        public string CUSTOMERNAME { get; set; }

        [JsonProperty("LINE_ITEMS")]
        public string LINEITEMS { get; set; }

        [JsonProperty("NUMBER_OF_PAGES")]
        public int NUMBEROFPAGES { get; set; }

        [JsonProperty("PURCHASE_ORDER_DATE")]
        public string PURCHASEORDERDATE { get; set; }

        [JsonProperty("PURCHASE_ORDER_ID")]
        public string PURCHASEORDERID { get; set; }

        [JsonProperty("PURCHASE_ORDER_NUMBER")]
        public string PURCHASEORDERNUMBER { get; set; }

        [JsonProperty("RECEIVER_ADDRESS")]
        public string RECEIVERADDRESS { get; set; }

        [JsonProperty("RECEIVER_NAME")]
        public string RECEIVERNAME { get; set; }

        [JsonProperty("REFERENCE_NUMBER")]
        public string REFERENCENUMBER { get; set; }
        public string RawJSON { get; set; }

        [JsonProperty("TAX_ID")]
        public string TAXID { get; set; }
        public string TOTAL { get; set; }

        [JsonProperty("TRACKING_NUMBER")]
        public string TRACKINGNUMBER { get; set; }

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
        public string BOLType { get; set; }

        [JsonProperty("Booking N")]
        public string BookingN { get; set; }
        public string Consignee { get; set; }

        [JsonProperty("Notify Party")]
        public string NotifyParty { get; set; }

        [JsonProperty("Port of Discharge")]
        public string PortOfDischarge { get; set; }

        [JsonProperty("Port of Loading")]
        public string PortOfLoading { get; set; }
        public string RawJSON { get; set; }
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
        public string EDUCATION { get; set; }
        public string EMAILS { get; set; }
        public string EXPERIENCE { get; set; }

        [JsonProperty("JOB_TITLE")]
        public string JOBTITLE { get; set; }
        public string LINKEDIN { get; set; }
        public string LOCATION { get; set; }
        public string NAME { get; set; }

        [JsonProperty("PHONE_NUMBERS")]
        public string PHONENUMBERS { get; set; }
        public string RawJSON { get; set; }
        public string SKILLS { get; set; }

        [JsonProperty("TOTAL_YEARS_EXPERIENCE")]
        public string TOTALYEARSEXPERIENCE { get; set; }
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
        public string RawJSON { get; set; }
    }

    public enum doctypeInput
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
        public string ADDRESS { get; set; }

        [JsonProperty("COMPANY_NAME")]
        public string COMPANYNAME { get; set; }

        [JsonProperty("EMAIL_ADDRESS")]
        public string EMAILADDRESS { get; set; }
        public string FAX { get; set; }
        public string LOCATION { get; set; }

        [JsonProperty("LOGO_URL")]
        public string LOGOURL { get; set; }
        public string MOBILE { get; set; }

        [JsonProperty("PERSON_NAME")]
        public string PERSONNAME { get; set; }

        [JsonProperty("PERSON_POSITION")]
        public string PERSONPOSITION { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
        public string RawJSON { get; set; }
        public string WEBSITE { get; set; }
    }

    public class ExtractQRCodeResponse
    {
        [JsonProperty("outputs")]
        public ExtractQRCodeResponseOutputsType Outputs { get; set; }
    }

    public class ExtractQRCodeResponseOutputsType
    {
        public string RawJSON { get; set; }

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
        public string RawJSON { get; set; }

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
        public string RawJSON { get; set; }
        public string Result { get; set; }
    }

    public class ExtractDataHAROResponse
    {
        [JsonProperty("outputs")]
        public ExtractDataHAROResponseOutputsType Outputs { get; set; }
    }

    public class ExtractDataHAROResponseOutputsType
    {
        public string CATEGORY { get; set; }
        public string DEADLINE { get; set; }
        public string EMAIL { get; set; }

        [JsonProperty("MEDIA OUTLET")]
        public string MEDIAOUTLET { get; set; }
        public string NAME { get; set; }
        public string QUERY { get; set; }
        public string REQUIREMENTS { get; set; }
        public string RawJSON { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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