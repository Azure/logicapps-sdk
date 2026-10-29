//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclivedoc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismiclivedocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocVersionResp, ApiConnectionActionConfiguration> GetLiveDocInputs(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentVersionId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentVersionId = WorkflowExpression.Compile(libraryContentVersionId, nameof(libraryContentVersionId), required: true);
            return new DeferredBodyAction<SeismicLiveDocsLiveDocVersionResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/livedocVersions/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentVersionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLiveDocsLiveDocVersionResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenSuccinctResultResp, ApiConnectionActionConfiguration> SubmitLiveDocGeneration(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentVersionId, Expression<Func<bodyoutputsInputItem[]>> bodyoutputs, Expression<Func<JToken[]>> bodyadHocInputs = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentVersionId = WorkflowExpression.Compile(libraryContentVersionId, nameof(libraryContentVersionId), required: true);
            var __workflow_bodyoutputs = WorkflowExpression.Compile(bodyoutputs, nameof(bodyoutputs), required: true);
            var __workflow_bodyadHocInputs = WorkflowExpression.Compile(bodyadHocInputs, nameof(bodyadHocInputs), required: false);
            return new DeferredBodyAction<SeismicLiveDocsLiveDocGenSuccinctResultResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/livedocVersions/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentVersionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyadHocInputs != null)
                {
                    body["adHocInputs"] = ExpressionConverter.ConvertO(__workflow_bodyadHocInputs);
                    bodypropCount++;
                }

                bodypropCount++;
                body["outputs"] = ExpressionConverter.ConvertO(__workflow_bodyoutputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLiveDocsLiveDocGenSuccinctResultResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenResultResp, ApiConnectionActionConfiguration> GetLiveDocGenerationStatus(Expression<Func<string>> generatedLivedocId)
        {
            var __workflow_generatedLivedocId = WorkflowExpression.Compile(generatedLivedocId, nameof(generatedLivedocId), required: true);
            return new DeferredBodyAction<SeismicLiveDocsLiveDocGenResultResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/generatedLivedocs/{0}", __workflow_generatedLivedocId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLiveDocsLiveDocGenResultResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsDownloadLocationResp, ApiConnectionActionConfiguration> DownloadGeneratedLiveDoc(Expression<Func<string>> generatedLivedocId, Expression<Func<string>> outputId, Expression<Func<bool>> redirect = null)
        {
            var __workflow_generatedLivedocId = WorkflowExpression.Compile(generatedLivedocId, nameof(generatedLivedocId), required: true);
            var __workflow_outputId = WorkflowExpression.Compile(outputId, nameof(outputId), required: true);
            var __workflow_redirect = WorkflowExpression.Compile(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicLiveDocsDownloadLocationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/generatedLivedocs/{0}/outputs/{1}/content", __workflow_generatedLivedocId.WithUrlEncoding(1), __workflow_outputId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(false);
                if (__workflow_redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(__workflow_redirect);
                return new ApiConnectionAction<SeismicLiveDocsDownloadLocationResp>(callPayload);
            });
        }
    }

    public class SeismiclivedocTriggers([ConnectionName] string connectionId)
    {
    }

    public class SeismicLiveDocsLiveDocVersionResp
    {
        [JsonProperty("forms")]
        public SeismicLiveDocsFormOutputResp[] Forms { get; set; }

        [JsonProperty("adhocInputs")]
        public SeismicLiveDocsAdhocInputResp[] AdhocInputs { get; set; }
    }

    public class SeismicLiveDocsFormOutputResp
    {
        [JsonProperty("id")]
        public string FormId { get; set; }

        [JsonProperty("isDefault")]
        public bool FormIsDefault { get; set; }

        [JsonProperty("name")]
        public string FormName { get; set; }

        [JsonProperty("outputs")]
        public SeismicLiveDocsResponseModelsFormOutput[] FormOutputs { get; set; }
    }

    public class SeismicLiveDocsResponseModelsFormOutput
    {
        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("name")]
        public string OutputName { get; set; }

        [JsonProperty("pptxOptions")]
        public JToken PptxOptions { get; set; }

        [JsonProperty("docxOptions")]
        public JToken DocxOptions { get; set; }

        [JsonProperty("pdfOptions")]
        public JToken PdfOptions { get; set; }

        [JsonProperty("xlsxOptions")]
        public JToken XlsxOptions { get; set; }
    }

    public class SeismicLiveDocsAdhocInputResp
    {
        [JsonProperty("id")]
        public string AdhocInputId { get; set; }

        [JsonProperty("name")]
        public string AdhocInputName { get; set; }

        [JsonProperty("format")]
        public string AdhocInputFormat { get; set; }

        [JsonProperty("type")]
        public string AdhocInputType { get; set; }

        [JsonProperty("columns")]
        public SeismicLiveDocsAdhocInputResp[] AdhocInputColumns { get; set; }
    }

    public class SeismicLiveDocsLiveDocGenSuccinctResultResp
    {
        [JsonProperty("generatedLivedocId")]
        public string GeneratedLivedocId { get; set; }
    }

    public class bodyoutputsInputItem
    {
        [JsonProperty("format")]
        public bodyoutputsInputItemFormatType Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("pptxOptions")]
        public bodyoutputsInputItemPptxOptionsType PptxOptions { get; set; }

        [JsonProperty("docxOptions")]
        public bodyoutputsInputItemDocxOptionsType DocxOptions { get; set; }

        [JsonProperty("pdfOptions")]
        public bodyoutputsInputItemPdfOptionsType PdfOptions { get; set; }

        [JsonProperty("xlsxOptions")]
        public bodyoutputsInputItemXlsxOptionsType XlsxOptions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputsInputItemFormatType
    {
        PPTX,
        DOCX,
        PDF,
        XLSX
    }

    public class bodyoutputsInputItemPptxOptionsType
    {
        [JsonProperty("imageDpi")]
        public bodyoutputsInputItemPptxOptionsTypeImageDpiType ImageDpi { get; set; }

        [JsonProperty("clearNotes")]
        public bool ClearNotes { get; set; }
    }

    public enum bodyoutputsInputItemPptxOptionsTypeImageDpiType
    {
        _0 = 0,
        _96 = 96,
        _120 = 120,
        _144 = 144,
        _200 = 200,
        _300 = 300,
        _400 = 400
    }

    public class bodyoutputsInputItemDocxOptionsType
    {
        [JsonProperty("imageDpi")]
        public bodyoutputsInputItemDocxOptionsTypeImageDpiType ImageDpi { get; set; }
    }

    public enum bodyoutputsInputItemDocxOptionsTypeImageDpiType
    {
        _0 = 0,
        _96 = 96,
        _120 = 120,
        _144 = 144,
        _200 = 200,
        _300 = 300,
        _400 = 400
    }

    public class bodyoutputsInputItemPdfOptionsType
    {
        [JsonProperty("layout")]
        public bodyoutputsInputItemPdfOptionsTypeLayoutType Layout { get; set; }

        [JsonProperty("compatibility")]
        public bodyoutputsInputItemPdfOptionsTypeCompatibilityType Compatibility { get; set; }

        [JsonProperty("openPassword")]
        public string OpenPassword { get; set; }

        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; set; }

        [JsonProperty("ownerOptions")]
        public string OwnerOptions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputsInputItemPdfOptionsTypeLayoutType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "Full Page Slides")]
        FullPageSlides,
        [EnumMember(Value = "Note Pages")]
        NotePages
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputsInputItemPdfOptionsTypeCompatibilityType
    {
        [EnumMember(Value = "Acrobat 5.0")]
        Acrobat50,
        [EnumMember(Value = "Acrobat 7.0")]
        Acrobat70,
        [EnumMember(Value = "Acrobat 9.0")]
        Acrobat90
    }

    public class bodyoutputsInputItemXlsxOptionsType
    {
        [JsonProperty("datasource")]
        public string Datasource { get; set; }
    }

    public class SeismicLiveDocsLiveDocGenResultResp
    {
        [JsonProperty("id")]
        public string LivedocId { get; set; }

        [JsonProperty("outputs")]
        public SeismicLiveDocsLiveDocGenOutputResultResp[] Outputs { get; set; }
    }

    public class SeismicLiveDocsLiveDocGenOutputResultResp
    {
        [JsonProperty("id")]
        public string OutputId { get; set; }

        [JsonProperty("status")]
        public SeismicLiveDocsLiveDocGenStatusResp Status { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("name")]
        public string OutputName { get; set; }

        [JsonProperty("fileName")]
        public string OutputFileName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeismicLiveDocsLiveDocGenStatusResp
    {
        Queued,
        Generating,
        Completed,
        Failed
    }

    public class SeismicLiveDocsDownloadLocationResp
    {
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclivedoc;

    public partial class WorkflowManagedActions
    {
        public SeismiclivedocActions Seismiclivedoc(string connectionId) => new SeismiclivedocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismiclivedocTriggers Seismiclivedoc(string connectionId) => new SeismiclivedocTriggers(connectionId);
    }
}