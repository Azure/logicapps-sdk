//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meswissqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateSwissQrBill(Expression<Func<CreateSwissQrBillV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ReadSwissQrBill(Expression<Func<ReadSwissQrBillV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<SplitDocBySwissQrCodeV1Response, ApiConnectionActionConfiguration> SplitDocBySwissQrCode(Expression<Func<SplitDocBySwissQrCodeV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SplitDocBySwissQrCodeV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitDocBySwissQrCodeV1Response>(callPayload);
            });
        }
    }

    public class Pdf4meswissqrTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateSwissQrBillV1Input
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("av1Parameters")]
        public string Av1Parameters { get; set; }

        [JsonProperty("av2Parameters")]
        public string Av2Parameters { get; set; }

        [JsonProperty("billingInfo")]
        public string BillingInfo { get; set; }

        [JsonProperty("crAddressType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSwissQrBillV1InputCrAddressTypeType CrAddressType { get; set; } = CreateSwissQrBillV1InputCrAddressTypeType.S;

        [JsonProperty("crCity")]
        public string CrCity { get; set; }

        [JsonProperty("crName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CrName { get; set; }

        [JsonProperty("crPostalCode")]
        public string CrPostalCode { get; set; }

        [JsonProperty("crStreetOrAddressLine1")]
        public string CrStreetOrAddressLine1 { get; set; }

        [JsonProperty("crStreetOrAddressLine2")]
        public string CrStreetOrAddressLine2 { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSwissQrBillV1InputCurrencyType? Currency { get; set; } = CreateSwissQrBillV1InputCurrencyType.CHF;

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSwissQrBillV1InputDocumentType Document { get; set; }

        [JsonProperty("iban", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Iban { get; set; }

        [JsonProperty("languageType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSwissQrBillV1InputLanguageTypeType? LanguageType { get; set; } = CreateSwissQrBillV1InputLanguageTypeType.English;

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("referenceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSwissQrBillV1InputReferenceTypeType? ReferenceType { get; set; } = CreateSwissQrBillV1InputReferenceTypeType.QRR;

        [JsonProperty("seperatorLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSwissQrBillV1InputSeperatorLineType? SeperatorLine { get; set; } = CreateSwissQrBillV1InputSeperatorLineType.LineWithScissor;

        [JsonProperty("udAddressType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSwissQrBillV1InputUdAddressTypeType? UdAddressType { get; set; } = CreateSwissQrBillV1InputUdAddressTypeType.S;

        [JsonProperty("udCity")]
        public string UdCity { get; set; }

        [JsonProperty("udName")]
        public string UdName { get; set; }

        [JsonProperty("udPostalCode")]
        public string UdPostalCode { get; set; }

        [JsonProperty("udStreetOrAddressLine1")]
        public string UdStreetOrAddressLine1 { get; set; }

        [JsonProperty("udStreetOrAddressLine2")]
        public string UdStreetOrAddressLine2 { get; set; }

        [JsonProperty("unstructuredMessage")]
        public string UnstructuredMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSwissQrBillV1InputCrAddressTypeType
    {
        S,
        K
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSwissQrBillV1InputCurrencyType
    {
        CHF,
        EUR
    }

    public class CreateSwissQrBillV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSwissQrBillV1InputLanguageTypeType
    {
        German,
        French,
        Italian,
        English
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSwissQrBillV1InputReferenceTypeType
    {
        QRR,
        SCOR,
        NON
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSwissQrBillV1InputSeperatorLineType
    {
        LineWithScissor,
        Line,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSwissQrBillV1InputUdAddressTypeType
    {
        S,
        K
    }

    public class ReadSwissQrBillV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadSwissQrBillV1InputDocumentType Document { get; set; }
    }

    public class ReadSwissQrBillV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class SplitDocBySwissQrCodeV1Response
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocBySwissQrCodeV1ResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocBySwissQrCodeV1ResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitDocBySwissQrCodeV1Input
    {
        [JsonProperty("barcodeFilter", DefaultValueHandling = DefaultValueHandling.Include)]
        internal SplitDocBySwissQrCodeV1InputBarcodeFilterType BarcodeFilter { get; set; } = SplitDocBySwissQrCodeV1InputBarcodeFilterType.StartsWith;

        [JsonProperty("barcodeString", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string BarcodeString { get; set; } = "SPC";

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal SplitDocBySwissQrCodeV1InputBarcodeTypeType BarcodeType { get; set; } = SplitDocBySwissQrCodeV1InputBarcodeTypeType.Qrcode;

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocBySwissQrCodeV1InputDocumentType Document { get; set; }

        [JsonProperty("splitBarcodePage", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocBySwissQrCodeV1InputSplitBarcodePageType SplitBarcodePage { get; set; } = SplitDocBySwissQrCodeV1InputSplitBarcodePageType.Before;

        [JsonProperty("combinePagesWithSameConsecutiveBarcodes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CombinePagesWithSameConsecutiveBarcodes { get; set; } = false;

        [JsonProperty("pdfRenderDpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfRenderDpi { get; set; } = "150";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocBySwissQrCodeV1InputBarcodeFilterType
    {
        [EnumMember(Value = "startsWith")]
        StartsWith,
        [EnumMember(Value = "endsWith")]
        EndsWith,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "exact")]
        Exact
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocBySwissQrCodeV1InputBarcodeTypeType
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "datamatrix")]
        Datamatrix,
        [EnumMember(Value = "qrcode")]
        Qrcode
    }

    public class SplitDocBySwissQrCodeV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocBySwissQrCodeV1InputSplitBarcodePageType
    {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr;

    public partial class WorkflowManagedActions
    {
        public Pdf4meswissqrActions Pdf4meswissqr(string connectionId) => new Pdf4meswissqrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meswissqrTriggers Pdf4meswissqr(string connectionId) => new Pdf4meswissqrTriggers(connectionId);
    }
}