//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclivedoc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismiclivedocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocVersionResp> GetLiveDocInputs(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentVersionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/livedocVersions/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentVersionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicLiveDocsLiveDocVersionResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenSuccinctResultResp> SubmitLiveDocGeneration(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentVersionId, Expression<Func<bodyoutputsInputItem[]>> bodyoutputs, Expression<Func<JToken[]>> bodyadHocInputs = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/livedocVersions/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentVersionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyadHocInputs != null)
            {
                body["adHocInputs"] = CSharpExpressionConverter.ConvertToken(bodyadHocInputs);
                bodypropCount++;
            }

            bodypropCount++;
            body["outputs"] = CSharpExpressionConverter.ConvertToken(bodyoutputs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SeismicLiveDocsLiveDocGenSuccinctResultResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsLiveDocGenResultResp> GetLiveDocGenerationStatus(Expression<Func<string>> generatedLivedocId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/generatedLivedocs/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(generatedLivedocId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicLiveDocsLiveDocGenResultResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclivedoc")]
        public IBodyWorkflowAction<SeismicLiveDocsDownloadLocationResp> DownloadGeneratedLiveDoc(Expression<Func<string>> generatedLivedocId, Expression<Func<string>> outputId, Expression<Func<bool>> redirect = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/generatedLivedocs/{0}/outputs/{1}/content", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(generatedLivedocId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(outputId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["redirect"] = Convert.ToString(false);
            if (redirect != null)
                callPayload.Queries["redirect"] = CSharpExpressionConverter.ConvertO(redirect);
            return new ApiConnectionAction<SeismicLiveDocsDownloadLocationResp>(callPayload);
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

    public enum bodyoutputsInputItemPdfOptionsTypeLayoutType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "Full Page Slides")]
        FullPageSlides,
        [EnumMember(Value = "Note Pages")]
        NotePages
    }

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