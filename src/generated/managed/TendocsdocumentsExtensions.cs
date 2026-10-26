//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tendocsdocuments
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TendocsdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiCompareResponse, ApiConnectionActionConfiguration> AiCompare(Expression<Func<V1AiComparePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<AiCompareResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ai/v1/tasks/compare";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<AiCompareResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiSummaryResponse, ApiConnectionActionConfiguration> AiSummary(Expression<Func<V1AiSummaryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<AiSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ai/v1/tasks/summary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<AiSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiTemplateBuilderResponse, ApiConnectionActionConfiguration> AiTemplateBuilder(Expression<Func<V1AiTemplateBuilderPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<AiTemplateBuilderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ai/v1/tasks/templateBuilder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<AiTemplateBuilderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConversionConvert(Expression<Func<V1ConversionConvertPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversion/v1/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentJsonTemplate(Expression<Func<V1DocumentJsonTemplatePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documents/v1/jsonTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentTemplate(Expression<Func<V1DocumentTemplatePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documents/v1/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<InstancesResponse, ApiConnectionActionConfiguration> EnvelopesInstances(Expression<Func<V1EnvelopesInstancesPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<InstancesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelopes/v1/instances";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<InstancesResponse>(callPayload);
            });
        }
    }

    public class TendocsdocumentsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AiCompareResponse
    {
        [JsonProperty("differences")]
        public AiCompareResponseDifferencesTypeItem[] Differences { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class AiCompareResponseDifferencesTypeItem
    {
        [JsonProperty("aspect")]
        public string Aspect { get; set; }

        [JsonProperty("detailSummary")]
        public string Summary { get; set; }

        [JsonProperty("detail")]
        public AiCompareResponseDifferencesTypeItemDetailsTypeItem[] Details { get; set; }

        [JsonProperty("importance")]
        public string Importance { get; set; }
    }

    public class AiCompareResponseDifferencesTypeItemDetailsTypeItem
    {
        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("summary")]
        public string DocumentSummary { get; set; }
    }

    public class V1AiComparePostInput
    {
        [JsonProperty("sourceDocument", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1AiComparePostInputSourceDocumentType SourceDocument { get; set; }

        [JsonProperty("comparisonDocument", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1AiComparePostInputComparisonDocumentType ComparisonDocument { get; set; }

        [JsonProperty("configuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1AiComparePostInputConfigurationType Configuration { get; set; }
    }

    public class V1AiComparePostInputSourceDocumentType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstFile { get; set; }
    }

    public class V1AiComparePostInputComparisonDocumentType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecondFile { get; set; }
    }

    public class V1AiComparePostInputConfigurationType
    {
        [JsonProperty("profession", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1AiComparePostInputConfigurationTypeProfessionType Profession { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1AiComparePostInputConfigurationTypeProfessionType
    {
        Doctor,
        Editor,
        Lawyer,
        General
    }

    public class AiSummaryResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Summary { get; set; }

        [JsonProperty("targetWords")]
        public double Target { get; set; }

        [JsonProperty("lengthWords")]
        public double Length { get; set; }
    }

    public class V1AiSummaryPostInput
    {
        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1AiSummaryPostInputDocumentType Document { get; set; }

        [JsonProperty("configuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1AiSummaryPostInputConfigurationType Configuration { get; set; }
    }

    public class V1AiSummaryPostInputDocumentType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }
    }

    public class V1AiSummaryPostInputConfigurationType
    {
        [JsonProperty("targetWords", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TargetWordCount { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    public class AiTemplateBuilderResponse
    {
        [JsonProperty("title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("filename")]
        public string DocumentFilename { get; set; }

        [JsonProperty("outline")]
        public AiTemplateBuilderResponseOutlineTypeItem[] Outline { get; set; }
    }

    public class AiTemplateBuilderResponseOutlineTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("subheadings")]
        public AiTemplateBuilderResponseOutlineTypeItemSubheadingsTypeItem[] Subheadings { get; set; }
    }

    public class AiTemplateBuilderResponseOutlineTypeItemSubheadingsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("subheadings")]
        public JToken[] Subsections { get; set; }
    }

    public class V1AiTemplateBuilderPostInput
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DescribeTheDocument1000Chars { get; set; }

        [JsonProperty("configuration")]
        public V1AiTemplateBuilderPostInputConfigurationType Configuration { get; set; }
    }

    public class V1AiTemplateBuilderPostInputConfigurationType
    {
        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    public class V1ConversionConvertPostInput
    {
        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1ConversionConvertPostInputDocumentType Document { get; set; }

        [JsonProperty("configuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1ConversionConvertPostInputConfigurationType Configuration { get; set; }
    }

    public class V1ConversionConvertPostInputDocumentType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }
    }

    public class V1ConversionConvertPostInputConfigurationType
    {
        [JsonProperty("documentResponseFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1ConversionConvertPostInputConfigurationTypeDocumentFormatType DocumentFormat { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1ConversionConvertPostInputConfigurationTypeDocumentFormatType
    {
        PDF,
        HTML
    }

    public class V1DocumentJsonTemplatePostInput
    {
        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1DocumentJsonTemplatePostInputTemplateType Template { get; set; }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken JSONObject { get; set; }

        [JsonProperty("configuration")]
        public V1DocumentJsonTemplatePostInputConfigurationType Configuration { get; set; }
    }

    public class V1DocumentJsonTemplatePostInputTemplateType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFile { get; set; }
    }

    public class V1DocumentJsonTemplatePostInputConfigurationType
    {
        [JsonProperty("documentResponseFormat")]
        public V1DocumentJsonTemplatePostInputConfigurationTypeDocumentFormatType? DocumentFormat { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1DocumentJsonTemplatePostInputConfigurationTypeDocumentFormatType
    {
        Original,
        PDF,
        HTML
    }

    public class V1DocumentTemplatePostInput
    {
        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1DocumentTemplatePostInputTemplateType Template { get; set; }

        [JsonProperty("images")]
        public V1DocumentTemplatePostInputImageTypeItem[] Image { get; set; }

        [JsonProperty("text")]
        public JToken Text { get; set; }

        [JsonProperty("substituteDocuments")]
        public V1DocumentTemplatePostInputDocumentTypeItem[] Document { get; set; }

        [JsonProperty("tables")]
        public V1DocumentTemplatePostInputTableTypeItem[] Table { get; set; }

        [JsonProperty("configuration")]
        public V1DocumentTemplatePostInputConfigurationType Configuration { get; set; }
    }

    public class V1DocumentTemplatePostInputTemplateType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFile { get; set; }
    }

    public class V1DocumentTemplatePostInputImageTypeItem
    {
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Token { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileContent { get; set; }
    }

    public class V1DocumentTemplatePostInputDocumentTypeItem
    {
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Token { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileContent { get; set; }
    }

    public class V1DocumentTemplatePostInputTableTypeItem
    {
        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Token { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Rows { get; set; }
    }

    public class V1DocumentTemplatePostInputConfigurationType
    {
        [JsonProperty("documentresponseformat")]
        public V1DocumentTemplatePostInputConfigurationTypeDocumentFormatType? DocumentFormat { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1DocumentTemplatePostInputConfigurationTypeDocumentFormatType
    {
        Original,
        PDF,
        HTML
    }

    public class InstancesResponse
    {
        [JsonProperty("url")]
        public string DocumentUrl { get; set; }
    }

    public class V1EnvelopesInstancesPostInput
    {
        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1EnvelopesInstancesPostInputDocumentType Document { get; set; }

        [JsonProperty("configuration")]
        public V1EnvelopesInstancesPostInputConfigurationType Configuration { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentTitle { get; set; }

        [JsonProperty("introduction", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentIntroduction { get; set; }

        [JsonProperty("logoUrl")]
        public string DocumentLogo { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientEmail { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientFirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientLastName { get; set; }

        [JsonProperty("checkboxText")]
        public string Checkbox { get; set; }

        [JsonProperty("expiry", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpiryDate { get; set; }

        [JsonProperty("isSignatureRequired", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SignatureRequired { get; set; }

        [JsonProperty("organisationTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrgansiationTitle { get; set; }

        [JsonProperty("organisationWebsite")]
        public string OrganisationWebsite { get; set; }

        [JsonProperty("organisationContactEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganisationEmail { get; set; }

        [JsonProperty("organisationContactPhone")]
        public string OrganisationPhone { get; set; }

        [JsonProperty("organisationContactName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganisationOwner { get; set; }

        [JsonProperty("organisationContactTitle")]
        public string OragnisationOwnerTitle { get; set; }

        [JsonProperty("commentsEnabled")]
        public bool? Comments { get; set; }

        [JsonProperty("projectIdentifier")]
        public string ProjectId { get; set; }

        [JsonProperty("completeButtonLabel")]
        public string CompleteButtonLabel { get; set; }

        [JsonProperty("completeStatusLabel")]
        public string CompleteDocumentLabel { get; set; }

        [JsonProperty("incompleteStatusLabel")]
        public string IncompleteDocumentLabel { get; set; }
    }

    public class V1EnvelopesInstancesPostInputDocumentType
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PDFDocument { get; set; }
    }

    public class V1EnvelopesInstancesPostInputConfigurationType
    {
        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tendocsdocuments;

    public partial class WorkflowManagedActions
    {
        public TendocsdocumentsActions Tendocsdocuments(string connectionId) => new TendocsdocumentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TendocsdocumentsTriggers Tendocsdocuments(string connectionId) => new TendocsdocumentsTriggers(connectionId);
    }
}