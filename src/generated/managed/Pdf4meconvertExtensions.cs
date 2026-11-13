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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertHtmlToPdf(Expression<Func<ConvertHtmlToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertJsonToExcel(Expression<Func<ConvertJsonToExcelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertMdToPdf(Expression<Func<ConvertMdToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertMdToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertToPdf(Expression<Func<ConvertToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertUrlToPdf(Expression<Func<ConvertUrlToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertUrlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertVisio(Expression<Func<SchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWordToPdfForm(Expression<Func<ConvertToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertWordToPdfForm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreatePdfA(Expression<Func<CreatePdfABodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/PdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
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
                else
                    callPayload.Body = ("{\"docContent\":\"\"}").ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToExcel(Expression<Func<PdfToExcelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToPowerPoint(Expression<Func<PdfToPowerPointBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToWord(Expression<Func<PdfToWordBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class Pdf4meconvertTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConvertHtmlToPdfBodyInput
    {
        public ConvertHtmlToPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("indexFilePath")]
        public string IndexFilePath { get; set; }

        [JsonProperty("layout", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLayoutType? Layout { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputLayoutType.Portrait;

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFormatType? Format { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputFormatType.A4;

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
    public enum BodyInputLayoutType
    {
        [EnumMember(Value = "")]
        None,
        Portrait,
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFormatType
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

    public class ConvertJsonToExcelBodyInput
    {
        public ConvertJsonToExcelBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

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

    public class BodyInputDocumentType
    {
        public BodyInputDocumentType(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ConvertMdToPdfBodyInput
    {
        public ConvertMdToPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("mdFilePath")]
        public string MdFilePath { get; set; }
    }

    public class ConvertToPdfBodyInput
    {
        public ConvertToPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }
    }

    public class ConvertUrlToPdfBodyInput
    {
        public ConvertUrlToPdfBodyInput(string webUrl)
        {
            this.WebUrl = webUrl;
        }

        [JsonProperty("webUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebUrl { get; set; }

        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAuthTypeType? AuthType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputAuthTypeType.NoAuth;

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAuthTypeType
    {
        NoAuth,
        SharePointLogin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SchemaValInput
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

    public class CreatePdfABodyInput
    {
        public CreatePdfABodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("compliance", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputComplianceType Compliance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputComplianceType.PdfA1b;

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("allowUpgrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowUpgrade { get; set; } = true;

        [JsonProperty("allowDowngrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowDowngrade { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputComplianceType
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

    public class PdfToExcelBodyInput
    {
        public PdfToExcelBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityTypeType QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputQualityTypeType.Draft;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mergeAllSheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MergeAllSheets { get; set; } = false;

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOutputFormatType? OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputOutputFormatType.None;

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputQualityTypeType
    {
        Draft,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOutputFormatType
    {
        [EnumMember(Value = "")]
        None,
        Excel,
        CSV
    }

    public class PdfToPowerPointBodyInput
    {
        public PdfToPowerPointBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityTypeType? QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputQualityTypeType.High;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    public class PdfToWordBodyInput
    {
        public PdfToWordBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, BodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityTypeType QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert.BodyInputQualityTypeType.Draft;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
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