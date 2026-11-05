//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4mebarcodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddBarcode(Expression<Func<AddBarcodeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Createbarcode(Expression<Func<CreatebarcodeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateEpcQrCode(Expression<Func<CreateEpcQrCodeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateEpcQrCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateSwissQrBill(Expression<Func<SchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBillV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("PDF");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> contentType, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = WorkflowExpression.Compile(featurePath, nameof(featurePath), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/FlowV2/{0}", __workflow_featurePath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesResponse, ApiConnectionActionConfiguration> ReadBarcodes(Expression<Func<ReadBarcodesBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadBarcodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadBarcodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesFromImageResponse, ApiConnectionActionConfiguration> ReadBarcodesFromImage(Expression<Func<ReadBarcodesFromImageBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadBarcodesFromImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodesFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadBarcodesFromImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ReadSwissQrBill(Expression<Func<ReadBarcodesFromImageBodyInput>> body = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<SplitDocByBarcodeResponse, ApiConnectionActionConfiguration> SplitDocByBarcode(Expression<Func<SplitDocByBarcodeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SplitDocByBarcodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitDocByBarcodeResponse>(callPayload);
            });
        }
    }

    public class Pdf4mebarcodeTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddBarcodeBodyInput
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeBodyInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.AddBarcodeBodyInputBarcodeTypeType.QrCode;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "1";

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputAlignYType.Top;

        [JsonProperty("heightInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeightInMM { get; set; } = "0";

        [JsonProperty("widthInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WidthInMM { get; set; } = "0";

        [JsonProperty("marginXInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginXInMM { get; set; } = "0";

        [JsonProperty("marginYInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginYInMM { get; set; } = "0";

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Opacity { get; set; } = 100;

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("isTextAbove", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsTextAbove { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddBarcodeBodyInputBarcodeTypeType
    {
        QrCode,
        Datamatrix,
        Code128,
        Aztec,
        Pdf417,
        Hanxin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAlignXType
    {
        Left,
        Center,
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAlignYType
    {
        Top,
        Middle,
        Bottom
    }

    public class CreatebarcodeBodyInput
    {
        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeBodyInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.AddBarcodeBodyInputBarcodeTypeType.QrCode;

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("hideText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideText { get; set; } = true;
    }

    public class CreateEpcQrCodeBodyInput
    {
        [JsonProperty("epcQrCodeAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEpcQrCodeActionType EpcQrCodeAction { get; set; } = new BodyInputEpcQrCodeActionType();
    }

    public class BodyInputEpcQrCodeActionType
    {
        [JsonProperty("serviceTag", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEpcQrCodeActionTypeServiceTagType ServiceTag { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputEpcQrCodeActionTypeServiceTagType.BCD;

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEpcQrCodeActionTypeVersionType Version { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputEpcQrCodeActionTypeVersionType.V2;

        [JsonProperty("characterSet", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEpcQrCodeActionTypeCharacterSetType? CharacterSet { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputEpcQrCodeActionTypeCharacterSetType.UTF8;

        [JsonProperty("identificationCode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEpcQrCodeActionTypeIdentificationCodeType IdentificationCode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputEpcQrCodeActionTypeIdentificationCodeType.SCT;

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("receiverName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReceiverName { get; set; }

        [JsonProperty("iban", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Iban { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEpcQrCodeActionTypeCurrencyType Currency { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputEpcQrCodeActionTypeCurrencyType.EUR;

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("remittanceReference")]
        public string RemittanceReference { get; set; }

        [JsonProperty("remittanceText")]
        public string RemittanceText { get; set; }

        [JsonProperty("information")]
        public string Information { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeServiceTagType
    {
        BCD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeVersionType
    {
        V1,
        V2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeCharacterSetType
    {
        UTF8,
        [EnumMember(Value = "ISO8859_1")]
        ISO88591,
        [EnumMember(Value = "ISO8859_2")]
        ISO88592,
        [EnumMember(Value = "ISO8859_4")]
        ISO88594,
        [EnumMember(Value = "ISO8859_5")]
        ISO88595,
        [EnumMember(Value = "ISO8859_7")]
        ISO88597,
        [EnumMember(Value = "ISO8859_10")]
        ISO885910,
        [EnumMember(Value = "ISO8859_15")]
        ISO885915
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeIdentificationCodeType
    {
        SCT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeCurrencyType
    {
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SchemaValInput
    {
        PDF,
        PNG,
        JPEG,
        Tiff
    }

    public class ReadBarcodesResponse
    {
        [JsonProperty("barcodes")]
        public ReadBarcodesResponseBarcodesTypeItem[] Barcodes { get; set; }
    }

    public class ReadBarcodesResponseBarcodesTypeItem
    {
        [JsonProperty("barcodeType")]
        public string BarcodeType { get; set; }
        public string Value { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    public class ReadBarcodesBodyInput
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputBarcodeTypeTypeItem[] BarcodeType { get; set; }

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "all";
    }

    public class BodyInputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputBarcodeTypeTypeItem
    {
        All,
        QrCode,
        Datamatrix,
        Code128,
        Code39,
        Pdf417,
        Code93
    }

    public class ReadBarcodesFromImageResponse
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }

    public class ReadBarcodesFromImageBodyInput
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }
    }

    public class SplitDocByBarcodeResponse
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocByBarcodeResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocByBarcodeResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("barcodeText")]
        public string BarcodeText { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitDocByBarcodeBodyInput
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("barcodeFilter", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputBarcodeFilterType BarcodeFilter { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputBarcodeFilterType.StartsWith;

        [JsonProperty("barcodeString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BarcodeString { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocByBarcodeBodyInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.SplitDocByBarcodeBodyInputBarcodeTypeType.Any;

        [JsonProperty("splitBarcodePage", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSplitBarcodePageType SplitBarcodePage { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode.BodyInputSplitBarcodePageType.Before;

        [JsonProperty("combinePagesWithSameConsecutiveBarcodes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CombinePagesWithSameConsecutiveBarcodes { get; set; } = false;

        [JsonProperty("pdfRenderDpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfRenderDpi { get; set; } = "150";

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
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
    public enum SplitDocByBarcodeBodyInputBarcodeTypeType
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
        After,
        [EnumMember(Value = "remove")]
        Remove
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode;

    public partial class WorkflowManagedActions
    {
        public Pdf4mebarcodeActions Pdf4mebarcode(string connectionId) => new Pdf4mebarcodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4mebarcodeTriggers Pdf4mebarcode(string connectionId) => new Pdf4mebarcodeTriggers(connectionId);
    }
}