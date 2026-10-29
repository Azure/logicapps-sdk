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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddBarcode(Expression<Func<AddBarcodeV1Input>> body = null)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Createbarcode(Expression<Func<CreatebarcodeV1Input>> body = null)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateEpcQrCode(Expression<Func<CreateEpcQrCodeV1Input>> body = null)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateSwissQrBill(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
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
        public IBodyWorkflowAction<ReadBarcodesV1Response, ApiConnectionActionConfiguration> ReadBarcodes(Expression<Func<ReadBarcodesV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadBarcodesV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadBarcodesV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesFromImageV1Response, ApiConnectionActionConfiguration> ReadBarcodesFromImage(Expression<Func<ReadBarcodesFromImageV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadBarcodesFromImageV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodesFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadBarcodesFromImageV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<SplitDocByBarcodeV1Response, ApiConnectionActionConfiguration> SplitDocByBarcode(Expression<Func<SplitDocByBarcodeV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SplitDocByBarcodeV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitDocByBarcodeV1Response>(callPayload);
            });
        }
    }

    public class Pdf4mebarcodeTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddBarcodeV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeV1InputBarcodeTypeType BarcodeType { get; set; } = AddBarcodeV1InputBarcodeTypeType.QrCode;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "1";

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeV1InputAlignXType AlignX { get; set; } = AddBarcodeV1InputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeV1InputAlignYType AlignY { get; set; } = AddBarcodeV1InputAlignYType.Top;

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
    public enum AddBarcodeV1InputBarcodeTypeType
    {
        QrCode,
        Datamatrix,
        Code128,
        Aztec,
        Pdf417,
        Hanxin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddBarcodeV1InputAlignXType
    {
        Left,
        Center,
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddBarcodeV1InputAlignYType
    {
        Top,
        Middle,
        Bottom
    }

    public class CreatebarcodeV1Input
    {
        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatebarcodeV1InputBarcodeTypeType BarcodeType { get; set; } = CreatebarcodeV1InputBarcodeTypeType.QrCode;

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("hideText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideText { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatebarcodeV1InputBarcodeTypeType
    {
        QrCode,
        Datamatrix,
        Code128,
        Aztec,
        Pdf417,
        Hanxin
    }

    public class CreateEpcQrCodeV1Input
    {
        [JsonProperty("epcQrCodeAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEpcQrCodeV1InputEpcQrCodeActionType EpcQrCodeAction { get; set; }
    }

    public class CreateEpcQrCodeV1InputEpcQrCodeActionType
    {
        [JsonProperty("serviceTag", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateEpcQrCodeV1InputEpcQrCodeActionTypeServiceTagType ServiceTag { get; set; } = CreateEpcQrCodeV1InputEpcQrCodeActionTypeServiceTagType.BCD;

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEpcQrCodeV1InputEpcQrCodeActionTypeVersionType Version { get; set; } = CreateEpcQrCodeV1InputEpcQrCodeActionTypeVersionType.V2;

        [JsonProperty("characterSet", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEpcQrCodeV1InputEpcQrCodeActionTypeCharacterSetType? CharacterSet { get; set; } = CreateEpcQrCodeV1InputEpcQrCodeActionTypeCharacterSetType.UTF8;

        [JsonProperty("identificationCode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateEpcQrCodeV1InputEpcQrCodeActionTypeIdentificationCodeType IdentificationCode { get; set; } = CreateEpcQrCodeV1InputEpcQrCodeActionTypeIdentificationCodeType.SCT;

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("receiverName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReceiverName { get; set; }

        [JsonProperty("iban", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Iban { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CreateEpcQrCodeV1InputEpcQrCodeActionTypeCurrencyType Currency { get; set; } = CreateEpcQrCodeV1InputEpcQrCodeActionTypeCurrencyType.EUR;

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
    public enum CreateEpcQrCodeV1InputEpcQrCodeActionTypeServiceTagType
    {
        BCD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEpcQrCodeV1InputEpcQrCodeActionTypeVersionType
    {
        V1,
        V2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEpcQrCodeV1InputEpcQrCodeActionTypeCharacterSetType
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
    public enum CreateEpcQrCodeV1InputEpcQrCodeActionTypeIdentificationCodeType
    {
        SCT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEpcQrCodeV1InputEpcQrCodeActionTypeCurrencyType
    {
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum schemaValInput
    {
        PDF,
        PNG,
        JPEG,
        Tiff
    }

    public class ReadBarcodesV1Response
    {
        [JsonProperty("barcodes")]
        public ReadBarcodesV1ResponseBarcodesTypeItem[] Barcodes { get; set; }
    }

    public class ReadBarcodesV1ResponseBarcodesTypeItem
    {
        [JsonProperty("barcodeType")]
        public string BarcodeType { get; set; }
        public string Value { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    public class ReadBarcodesV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadBarcodesV1InputDocumentType Document { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadBarcodesV1InputBarcodeTypeTypeItem[] BarcodeType { get; set; }

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "all";
    }

    public class ReadBarcodesV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadBarcodesV1InputBarcodeTypeTypeItem
    {
        All,
        QrCode,
        Datamatrix,
        Code128,
        Code39,
        Pdf417,
        Code93
    }

    public class ReadBarcodesFromImageV1Response
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }

    public class ReadBarcodesFromImageV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReadBarcodesFromImageV1InputDocumentType Document { get; set; }
    }

    public class ReadBarcodesFromImageV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
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

    public class SplitDocByBarcodeV1Response
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocByBarcodeV1ResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocByBarcodeV1ResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("barcodeText")]
        public string BarcodeText { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitDocByBarcodeV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocByBarcodeV1InputDocumentType Document { get; set; }

        [JsonProperty("barcodeFilter", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocByBarcodeV1InputBarcodeFilterType BarcodeFilter { get; set; } = SplitDocByBarcodeV1InputBarcodeFilterType.StartsWith;

        [JsonProperty("barcodeString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BarcodeString { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocByBarcodeV1InputBarcodeTypeType BarcodeType { get; set; } = SplitDocByBarcodeV1InputBarcodeTypeType.Any;

        [JsonProperty("splitBarcodePage", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocByBarcodeV1InputSplitBarcodePageType SplitBarcodePage { get; set; } = SplitDocByBarcodeV1InputSplitBarcodePageType.Before;

        [JsonProperty("combinePagesWithSameConsecutiveBarcodes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CombinePagesWithSameConsecutiveBarcodes { get; set; } = false;

        [JsonProperty("pdfRenderDpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfRenderDpi { get; set; } = "150";

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    public class SplitDocByBarcodeV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocByBarcodeV1InputBarcodeFilterType
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
    public enum SplitDocByBarcodeV1InputBarcodeTypeType
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "datamatrix")]
        Datamatrix,
        [EnumMember(Value = "qrcode")]
        Qrcode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocByBarcodeV1InputSplitBarcodePageType
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