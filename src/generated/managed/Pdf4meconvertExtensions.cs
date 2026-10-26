//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertHtmlToPdf(Expression<Func<ConvertHtmlToPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertJsonToExcel(Expression<Func<ConvertJsonToExcelV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertMdToPdf(Expression<Func<ConvertMdToPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertMdToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertToPdf(Expression<Func<ConvertToPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertUrlToPdf(Expression<Func<ConvertUrlToPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertUrlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertVisio(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertVisio";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWordToPdfForm(Expression<Func<ConvertWordToPdfFormV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertWordToPdfForm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreatePdfA(Expression<Func<CreatePdfAV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/PdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = WorkflowExpression.Compile(featurePath, nameof(featurePath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/FlowV2/{0}", __workflow_featurePath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToExcel(Expression<Func<PdfToExcelV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToPowerPoint(Expression<Func<PdfToPowerPointV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToWord(Expression<Func<PdfToWordV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class Pdf4meconvertTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConvertHtmlToPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("indexFilePath")]
        public string IndexFilePath { get; set; }

        [JsonProperty("layout", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertHtmlToPdfV1InputLayoutType? Layout { get; set; } = ConvertHtmlToPdfV1InputLayoutType.Portrait;

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertHtmlToPdfV1InputFormatType? Format { get; set; } = ConvertHtmlToPdfV1InputFormatType.A4;

        [JsonProperty("scale", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Scale { get; set; } = 0.8;

        [JsonProperty("topMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TopMargin { get; set; } = "40px";

        [JsonProperty("bottomMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BottomMargin { get; set; } = "40px";

        [JsonProperty("leftMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LeftMargin { get; set; } = "40px";

        [JsonProperty("rightMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RightMargin { get; set; } = "40px";

        [JsonProperty("printBackground", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintBackground { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertHtmlToPdfV1InputLayoutType
    {
        [EnumMember(Value = "")]
        None,
        Portrait,
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertHtmlToPdfV1InputFormatType
    {
        [EnumMember(Value = "")]
        None,
        Letter,
        Legal,
        Tabloid,
        Ledger,
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6
    }

    public class ConvertJsonToExcelV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertJsonToExcelV1InputDocumentType Document { get; set; }

        [JsonProperty("firstRow", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstRow { get; set; } = 0;

        [JsonProperty("firstColumn", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstColumn { get; set; } = 0;

        [JsonProperty("worksheetName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorksheetName { get; set; } = "Sheet1";

        [JsonProperty("convertNumberAndDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConvertNumberAndDate { get; set; } = false;

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("numberFormat")]
        public string NumberFormat { get; set; }

        [JsonProperty("ignoreNullValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreNullValues { get; set; } = false;

        [JsonProperty("isTitleBold", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsTitleBold { get; set; } = true;

        [JsonProperty("isTitleWrapText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsTitleWrapText { get; set; } = true;
    }

    public class ConvertJsonToExcelV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ConvertMdToPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("mdFilePath")]
        public string MdFilePath { get; set; }
    }

    public class ConvertToPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertToPdfV1InputDocumentType Document { get; set; }
    }

    public class ConvertToPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ConvertUrlToPdfV1Input
    {
        [JsonProperty("webUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebUrl { get; set; }

        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertUrlToPdfV1InputAuthTypeType? AuthType { get; set; } = ConvertUrlToPdfV1InputAuthTypeType.NoAuth;

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertUrlToPdfV1InputAuthTypeType
    {
        NoAuth,
        SharePointLogin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum schemaValInput
    {
        PDF,
        BMP,
        GIF,
        PNG,
        JPG,
        SVG,
        TIFF,
        HTML,
        VSDX
    }

    public class ConvertWordToPdfFormV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertWordToPdfFormV1InputDocumentType Document { get; set; }
    }

    public class ConvertWordToPdfFormV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class CreatePdfAV1Input
    {
        [JsonProperty("compliance", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePdfAV1InputComplianceType Compliance { get; set; } = CreatePdfAV1InputComplianceType.PdfA1b;

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePdfAV1InputDocumentType Document { get; set; }

        [JsonProperty("allowUpgrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowUpgrade { get; set; } = true;

        [JsonProperty("allowDowngrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowDowngrade { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePdfAV1InputComplianceType
    {
        PdfA1b,
        PdfA1a,
        PdfA2b,
        PdfA2u,
        PdfA2a,
        PdfA3b,
        PdfA3u,
        PdfA3a
    }

    public class CreatePdfAV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class PdfToExcelV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfToExcelV1InputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfToExcelV1InputQualityTypeType QualityType { get; set; } = PdfToExcelV1InputQualityTypeType.Draft;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mergeAllSheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MergeAllSheets { get; set; } = false;

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfToExcelV1InputOutputFormatType? OutputFormat { get; set; } = PdfToExcelV1InputOutputFormatType.None;

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    public class PdfToExcelV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfToExcelV1InputQualityTypeType
    {
        Draft,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfToExcelV1InputOutputFormatType
    {
        [EnumMember(Value = "")]
        None,
        Excel,
        CSV
    }

    public class PdfToPowerPointV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfToPowerPointV1InputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfToPowerPointV1InputQualityTypeType? QualityType { get; set; } = PdfToPowerPointV1InputQualityTypeType.High;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    public class PdfToPowerPointV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfToPowerPointV1InputQualityTypeType
    {
        Draft,
        High
    }

    public class PdfToWordV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfToWordV1InputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfToWordV1InputQualityTypeType QualityType { get; set; } = PdfToWordV1InputQualityTypeType.Draft;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    public class PdfToWordV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfToWordV1InputQualityTypeType
    {
        Draft,
        High
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert;

    public partial class WorkflowManagedActions
    {
        public Pdf4meconvertActions Pdf4meconvert(string connectionId) => new Pdf4meconvertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meconvertTriggers Pdf4meconvert(string connectionId) => new Pdf4meconvertTriggers(connectionId);
    }
}