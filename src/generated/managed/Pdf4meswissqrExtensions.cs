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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateSwissQrBill(Expression<Func<CreateSwissQrBillBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ReadSwissQrBill(Expression<Func<ReadSwissQrBillBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<SplitDocBySwissQrCodeResponse, ApiConnectionActionConfiguration> SplitDocBySwissQrCode(Expression<Func<SplitDocBySwissQrCodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SplitDocBySwissQrCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitDocBySwissQrCodeResponse>(callPayload);
            });
        }
    }

    public class Pdf4meswissqrTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateSwissQrBillBodyInput
    {
        public CreateSwissQrBillBodyInput(string crName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document, string iban)
        {
            this.CrName = crName;
            this.DocContent = docContent;
            this.Document = document;
            this.Iban = iban;
        }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("av1Parameters")]
        public string Av1Parameters { get; set; }

        [JsonProperty("av2Parameters")]
        public string Av2Parameters { get; set; }

        [JsonProperty("billingInfo")]
        public string BillingInfo { get; set; }

        [JsonProperty("crAddressType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCrAddressTypeType CrAddressType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputCrAddressTypeType.S;

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
        public BodyInputCurrencyType? Currency { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputCurrencyType.Chf;

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("iban", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Iban { get; set; }

        [JsonProperty("languageType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLanguageTypeType? LanguageType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputLanguageTypeType.English;

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("referenceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputReferenceTypeType? ReferenceType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputReferenceTypeType.Qrr;

        [JsonProperty("seperatorLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSeperatorLineType? SeperatorLine { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputSeperatorLineType.LineWithScissor;

        [JsonProperty("udAddressType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputUdAddressTypeType? UdAddressType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputUdAddressTypeType.S;

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
    public enum BodyInputCrAddressTypeType
    {
        S,
        K
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCurrencyType
    {
        [EnumMember(Value = "CHF")]
        Chf,
        [EnumMember(Value = "EUR")]
        Eur
    }

    public class BodyInputDocumentType
    {
        public BodyInputDocumentType(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLanguageTypeType
    {
        German,
        French,
        Italian,
        English
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputReferenceTypeType
    {
        [EnumMember(Value = "QRR")]
        Qrr,
        [EnumMember(Value = "SCOR")]
        Scor,
        [EnumMember(Value = "NON")]
        Non
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSeperatorLineType
    {
        LineWithScissor,
        Line,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputUdAddressTypeType
    {
        S,
        K
    }

    public class ReadSwissQrBillBodyInput
    {
        public ReadSwissQrBillBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }
    }

    public class SplitDocBySwissQrCodeResponse
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocBySwissQrCodeResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocBySwissQrCodeResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitDocBySwissQrCodeBodyInput
    {
        public SplitDocBySwissQrCodeBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("barcodeFilter", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputBarcodeFilterType BarcodeFilter { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputBarcodeFilterType.StartsWith;

        [JsonProperty("barcodeString", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string BarcodeString { get; set; } = "SPC";

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputBarcodeTypeType.Qrcode;

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("splitBarcodePage", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSplitBarcodePageType SplitBarcodePage { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr.BodyInputSplitBarcodePageType.Before;

        [JsonProperty("combinePagesWithSameConsecutiveBarcodes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CombinePagesWithSameConsecutiveBarcodes { get; set; } = false;

        [JsonProperty("pdfRenderDpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfRenderDpi { get; set; } = "150";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputBarcodeFilterType
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
    public enum BodyInputBarcodeTypeType
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "datamatrix")]
        Datamatrix,
        [EnumMember(Value = "qrcode")]
        Qrcode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSplitBarcodePageType
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