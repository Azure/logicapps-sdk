//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclivedoc
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismiclivedocActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        [WorkflowExpressionFactory(nameof(__BuildGetLiveDocInputs))]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocVersionResp> GetLiveDocInputs([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentVersionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocVersionResp> __BuildGetLiveDocInputs(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentVersionId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentVersionId, nameof(libraryContentVersionId), required: true);
            return new DeferredBodyAction<SeismicLiveDocsLiveDocVersionResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/livedocVersions/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentVersionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLiveDocsLiveDocVersionResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        [WorkflowExpressionFactory(nameof(__BuildSubmitLiveDocGeneration))]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenSuccinctResultResp> SubmitLiveDocGeneration([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentVersionId, [WorkflowExpression] Func<bodyoutputsInputItem[]> bodyoutputs, [WorkflowExpression] Func<JToken[]> bodyadHocInputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenSuccinctResultResp> __BuildSubmitLiveDocGeneration(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentVersionId, WorkflowExpression<bodyoutputsInputItem[]> bodyoutputs, WorkflowExpression<JToken[]> bodyadHocInputs = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentVersionId, nameof(libraryContentVersionId), required: true);
            WorkflowExpression.Validate(bodyoutputs, nameof(bodyoutputs), required: true);
            WorkflowExpression.Validate(bodyadHocInputs, nameof(bodyadHocInputs), required: false);
            return new DeferredBodyAction<SeismicLiveDocsLiveDocGenSuccinctResultResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/livedocVersions/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentVersionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyadHocInputs != null)
                {
                    body["adHocInputs"] = ExpressionConverter.ConvertO(bodyadHocInputs);
                    bodypropCount++;
                }

                bodypropCount++;
                body["outputs"] = ExpressionConverter.ConvertO(bodyoutputs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLiveDocsLiveDocGenSuccinctResultResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        [WorkflowExpressionFactory(nameof(__BuildGetLiveDocGenerationStatus))]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenResultResp> GetLiveDocGenerationStatus([WorkflowExpression] Func<string> generatedLivedocId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenResultResp> __BuildGetLiveDocGenerationStatus(WorkflowExpression<string> generatedLivedocId)
        {
            WorkflowExpression.Validate(generatedLivedocId, nameof(generatedLivedocId), required: true);
            return new DeferredBodyAction<SeismicLiveDocsLiveDocGenResultResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/generatedLivedocs/{0}", ExpressionConverter.ConvertWithUrlEncoding(generatedLivedocId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLiveDocsLiveDocGenResultResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadGeneratedLiveDoc))]
        public IBodyWorkflowAction<SeismicLiveDocsDownloadLocationResp> DownloadGeneratedLiveDoc([WorkflowExpression] Func<string> generatedLivedocId, [WorkflowExpression] Func<string> outputId, [WorkflowExpression] Func<bool> redirect = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLiveDocsDownloadLocationResp> __BuildDownloadGeneratedLiveDoc(WorkflowExpression<string> generatedLivedocId, WorkflowExpression<string> outputId, WorkflowExpression<bool> redirect = null)
        {
            WorkflowExpression.Validate(generatedLivedocId, nameof(generatedLivedocId), required: true);
            WorkflowExpression.Validate(outputId, nameof(outputId), required: true);
            WorkflowExpression.Validate(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicLiveDocsDownloadLocationResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/generatedLivedocs/{0}/outputs/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(generatedLivedocId, 1), ExpressionConverter.ConvertWithUrlEncoding(outputId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(false);
                if (redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(redirect);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputsInputItemPptxOptionsTypeImageDpiType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "120")]
        _120,
        [EnumMember(Value = "144")]
        _144,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "300")]
        _300,
        [EnumMember(Value = "400")]
        _400
    }

    public class bodyoutputsInputItemDocxOptionsType
    {
        [JsonProperty("imageDpi")]
        public bodyoutputsInputItemDocxOptionsTypeImageDpiType ImageDpi { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputsInputItemDocxOptionsTypeImageDpiType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "120")]
        _120,
        [EnumMember(Value = "144")]
        _144,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "300")]
        _300,
        [EnumMember(Value = "400")]
        _400
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