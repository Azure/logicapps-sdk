//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Survey123
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Survey123Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survey123")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetOwnedSurveyList()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/survey/query";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isPublished"] = Convert.ToString(true);
                callPayload.Queries["isQueryAll"] = Convert.ToString(true);
                callPayload.Queries["portalUrl"] = Convert.ToString("https://www.arcgis.com");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survey123")]
        public IBodyWorkflowAction<FeatureReportSubmitJobResponse, ApiConnectionActionConfiguration> FeatureReportSubmitJob(Expression<Func<CreateFeatureReportBodyInput>> createFeatureReportBody)
        {
            var __workflow_createFeatureReportBody = WorkflowExpression.Compile(createFeatureReportBody, nameof(createFeatureReportBody), required: true);
            return new DeferredBodyAction<FeatureReportSubmitJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/featureReport/createReport/submitJob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["portalUrl"] = Convert.ToString("https://www.arcgis.com");
                callPayload.Headers["X-Survey123-Request-Source"] = Convert.ToString("webhook/PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createFeatureReportBody);
                return new ApiConnectionAction<FeatureReportSubmitJobResponse>(callPayload);
            });
        }
    }

    public class Survey123Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> AddData(Expression<Func<string>> surveyId, Expression<Func<AddWebhookBodyInput>> addWebhookBody)
        {
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_addWebhookBody = WorkflowExpression.Compile(addWebhookBody, nameof(addWebhookBody), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/survey/{0}/webhook/add", __workflow_surveyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["portalUrl"] = Convert.ToString("https://www.arcgis.com");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addWebhookBody);
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }
    }

    public class FeatureReportSubmitJobResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("jobStatus")]
        public string JobStatus { get; set; }

        [JsonProperty("submitted")]
        public int Submitted { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("resultInfo")]
        public FeatureReportSubmitJobResponseResultInfoType ResultInfo { get; set; }

        [JsonProperty("inputInfo")]
        public FeatureReportSubmitJobResponseInputInfoType InputInfo { get; set; }
    }

    public class FeatureReportSubmitJobResponseResultInfoType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("succeededObjectIds")]
        public int[] SucceededObjectIds { get; set; }

        [JsonProperty("failedObjectIds")]
        public JToken[] FailedObjectIds { get; set; }

        [JsonProperty("details")]
        public JToken[] Details { get; set; }

        [JsonProperty("resultFiles")]
        public FeatureReportSubmitJobResponseResultInfoTypeResultFilesTypeItem[] ResultFiles { get; set; }

        [JsonProperty("resultFile")]
        public FeatureReportSubmitJobResponseResultInfoTypeResultFileType ResultFile { get; set; }
    }

    public class FeatureReportSubmitJobResponseResultInfoTypeResultFilesTypeItem
    {
        [JsonProperty("objectIds")]
        public int[] ObjectIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FeatureReportSubmitJobResponseResultInfoTypeResultFileType
    {
        [JsonProperty("objectIds")]
        public int[] ObjectIds { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FeatureReportSubmitJobResponseInputInfoType
    {
        [JsonProperty("jobType")]
        public string JobType { get; set; }

        [JsonProperty("parameters")]
        public FeatureReportSubmitJobResponseInputInfoTypeParametersType Parameters { get; set; }
    }

    public class FeatureReportSubmitJobResponseInputInfoTypeParametersType
    {
        [JsonProperty("featureLayerUrl")]
        public string FeatureLayerUrl { get; set; }

        [JsonProperty("queryParameters")]
        public FeatureReportSubmitJobResponseInputInfoTypeParametersTypeQueryParametersType QueryParameters { get; set; }

        [JsonProperty("templateItemId")]
        public string TemplateItemId { get; set; }

        [JsonProperty("surveyItemId")]
        public string SurveyItemId { get; set; }

        [JsonProperty("portalUrl")]
        public string PortalUrl { get; set; }

        [JsonProperty("outputFormat")]
        public string OutputFormat { get; set; }
    }

    public class FeatureReportSubmitJobResponseInputInfoTypeParametersTypeQueryParametersType
    {
        [JsonProperty("objectIds")]
        public string ObjectIds { get; set; }
    }

    public class CreateFeatureReportBodyInput
    {
        [JsonProperty("surveyItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Survey { get; set; }

        [JsonProperty("featureLayerUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeatureLayer { get; set; }

        [JsonProperty("templateItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReportTemplate { get; set; }

        [JsonProperty("queryParameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateFeatureReportBodyInputValueType Value { get; set; }

        [JsonProperty("utcOffset")]
        public string UTCOffset { get; set; }

        [JsonProperty("outputReportName")]
        public string ReportName { get; set; }

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateFeatureReportBodyInputFormatType? Format { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Survey123.CreateFeatureReportBodyInputFormatType.Docx;

        [JsonProperty("asyncPattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool EnableAsyncPattern { get; set; } = true;
    }

    public class CreateFeatureReportBodyInputValueType
    {
        [JsonProperty("objectIds")]
        public string FeatureObjectId { get; set; }

        [JsonProperty("where")]
        public string FeatureWHEREClause { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateFeatureReportBodyInputFormatType
    {
        [EnumMember(Value = "docx")]
        Docx,
        [EnumMember(Value = "pdf")]
        Pdf
    }

    public class AddWebhookBodyInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddWebhookBodyInputValueType Value { get; set; } = new AddWebhookBodyInputValueType();
    }

    public class AddWebhookBodyInputValueType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "MS-FLOW";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] Events { get; set; } = new string[]
        {
            "addData"
        };

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("includePortalInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludePortalInfo { get; set; } = true;

        [JsonProperty("includeUserInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeUserInfo { get; set; } = true;

        [JsonProperty("includeSurveyInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeSurveyInfo { get; set; } = true;

        [JsonProperty("includeServiceRequest", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeServiceRequest { get; set; } = true;

        [JsonProperty("includeServiceResponse", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeServiceResponse { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Survey123;

    public partial class WorkflowManagedActions
    {
        public Survey123Actions Survey123(string connectionId) => new Survey123Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Survey123Triggers Survey123(string connectionId) => new Survey123Triggers(connectionId);
    }
}