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
        public IBodyWorkflowAction<AiCompareResponse, ApiConnectionActionConfiguration> AiCompare(Expression<Func<AiCompareRequestInput>> request)
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
        public IBodyWorkflowAction<AiSummaryResponse, ApiConnectionActionConfiguration> AiSummary(Expression<Func<AiSummaryRequestInput>> request)
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
        public IBodyWorkflowAction<AiTemplateBuilderResponse, ApiConnectionActionConfiguration> AiTemplateBuilder(Expression<Func<AiTemplateBuilderRequestInput>> request)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConversionConvert(Expression<Func<ConversionConvertRequestInput>> request)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentJsonTemplate(Expression<Func<DocumentJsonTemplateRequestInput>> request)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentTemplate(Expression<Func<DocumentTemplateRequestInput>> request)
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
        public IBodyWorkflowAction<InstancesResponse, ApiConnectionActionConfiguration> EnvelopesInstances(Expression<Func<EnvelopesInstancesRequestInput>> request)
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

    public class AiCompareRequestInput
    {
        public AiCompareRequestInput(RequestInputSourceDocumentType sourceDocument, RequestInputComparisonDocumentType comparisonDocument, AiCompareRequestInputConfigurationType configuration)
        {
            this.SourceDocument = sourceDocument;
            this.ComparisonDocument = comparisonDocument;
            this.Configuration = configuration;
        }

        [JsonProperty("sourceDocument", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestInputSourceDocumentType SourceDocument { get; set; }

        [JsonProperty("comparisonDocument", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestInputComparisonDocumentType ComparisonDocument { get; set; }

        [JsonProperty("configuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public AiCompareRequestInputConfigurationType Configuration { get; set; }
    }

    public class RequestInputSourceDocumentType
    {
        public RequestInputSourceDocumentType(string firstFile)
        {
            this.FirstFile = firstFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstFile { get; set; }
    }

    public class RequestInputComparisonDocumentType
    {
        public RequestInputComparisonDocumentType(string secondFile)
        {
            this.SecondFile = secondFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecondFile { get; set; }
    }

    public class AiCompareRequestInputConfigurationType
    {
        public AiCompareRequestInputConfigurationType(RequestInputConfigurationTypeProfessionType profession)
        {
            this.Profession = profession;
        }

        [JsonProperty("profession", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestInputConfigurationTypeProfessionType Profession { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestInputConfigurationTypeProfessionType
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

    public class AiSummaryRequestInput
    {
        public AiSummaryRequestInput(AiSummaryRequestInputDocumentType document, AiSummaryRequestInputConfigurationType configuration)
        {
            this.Document = document;
            this.Configuration = configuration;
        }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AiSummaryRequestInputDocumentType Document { get; set; }

        [JsonProperty("configuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public AiSummaryRequestInputConfigurationType Configuration { get; set; }
    }

    public class AiSummaryRequestInputDocumentType
    {
        public AiSummaryRequestInputDocumentType(string @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }
    }

    public class AiSummaryRequestInputConfigurationType
    {
        public AiSummaryRequestInputConfigurationType(int targetWordCount)
        {
            this.TargetWordCount = targetWordCount;
        }

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

    public class AiTemplateBuilderRequestInput
    {
        public AiTemplateBuilderRequestInput(string describeTheDocument1000Chars)
        {
            this.DescribeTheDocument1000Chars = describeTheDocument1000Chars;
        }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DescribeTheDocument1000Chars { get; set; }

        [JsonProperty("configuration")]
        public AiTemplateBuilderRequestInputConfigurationType Configuration { get; set; }
    }

    public class AiTemplateBuilderRequestInputConfigurationType
    {
        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    public class ConversionConvertRequestInput
    {
        public ConversionConvertRequestInput(AiSummaryRequestInputDocumentType document, ConversionConvertRequestInputConfigurationType configuration)
        {
            this.Document = document;
            this.Configuration = configuration;
        }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AiSummaryRequestInputDocumentType Document { get; set; }

        [JsonProperty("configuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConversionConvertRequestInputConfigurationType Configuration { get; set; }
    }

    public class ConversionConvertRequestInputConfigurationType
    {
        public ConversionConvertRequestInputConfigurationType(ConversionConvertRequestInputConfigurationTypeDocumentFormatType documentFormat)
        {
            this.DocumentFormat = documentFormat;
        }

        [JsonProperty("documentResponseFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConversionConvertRequestInputConfigurationTypeDocumentFormatType DocumentFormat { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConversionConvertRequestInputConfigurationTypeDocumentFormatType
    {
        PDF,
        HTML
    }

    public class DocumentJsonTemplateRequestInput
    {
        public DocumentJsonTemplateRequestInput(RequestInputTemplateType template, JToken jSONObject)
        {
            this.Template = template;
            this.JSONObject = jSONObject;
        }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestInputTemplateType Template { get; set; }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken JSONObject { get; set; }

        [JsonProperty("configuration")]
        public DocumentJsonTemplateRequestInputConfigurationType Configuration { get; set; }
    }

    public class RequestInputTemplateType
    {
        public RequestInputTemplateType(string templateFile)
        {
            this.TemplateFile = templateFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFile { get; set; }
    }

    public class DocumentJsonTemplateRequestInputConfigurationType
    {
        [JsonProperty("documentResponseFormat")]
        public DocumentJsonTemplateRequestInputConfigurationTypeDocumentFormatType? DocumentFormat { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentJsonTemplateRequestInputConfigurationTypeDocumentFormatType
    {
        Original,
        PDF,
        HTML
    }

    public class DocumentTemplateRequestInput
    {
        public DocumentTemplateRequestInput(RequestInputTemplateType template)
        {
            this.Template = template;
        }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestInputTemplateType Template { get; set; }

        [JsonProperty("images")]
        public RequestInputImageTypeItem[] Image { get; set; }

        [JsonProperty("text")]
        public JToken Text { get; set; }

        [JsonProperty("substituteDocuments")]
        public RequestInputDocumentTypeItem[] Document { get; set; }

        [JsonProperty("tables")]
        public RequestInputTableTypeItem[] Table { get; set; }

        [JsonProperty("configuration")]
        public DocumentTemplateRequestInputConfigurationType Configuration { get; set; }
    }

    public class RequestInputImageTypeItem
    {
        public RequestInputImageTypeItem(string token, string fileContent)
        {
            this.Token = token;
            this.FileContent = fileContent;
        }

        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Token { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileContent { get; set; }
    }

    public class RequestInputDocumentTypeItem
    {
        public RequestInputDocumentTypeItem(string token, string fileContent)
        {
            this.Token = token;
            this.FileContent = fileContent;
        }

        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Token { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileContent { get; set; }
    }

    public class RequestInputTableTypeItem
    {
        public RequestInputTableTypeItem(string token, JToken rows)
        {
            this.Token = token;
            this.Rows = rows;
        }

        [JsonProperty("token", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Token { get; set; }

        [JsonProperty("rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Rows { get; set; }
    }

    public class DocumentTemplateRequestInputConfigurationType
    {
        [JsonProperty("documentresponseformat")]
        public DocumentJsonTemplateRequestInputConfigurationTypeDocumentFormatType? DocumentFormat { get; set; }

        [JsonProperty("keys")]
        public JToken ConfigurationKeys { get; set; }
    }

    public class InstancesResponse
    {
        [JsonProperty("url")]
        public string DocumentUrl { get; set; }
    }

    public class EnvelopesInstancesRequestInput
    {
        public EnvelopesInstancesRequestInput(EnvelopesInstancesRequestInputDocumentType document, string documentTitle, string documentIntroduction, string recipientEmail, string recipientFirstName, string recipientLastName, string expiryDate, bool signatureRequired, string organsiationTitle, string organisationEmail, string organisationOwner)
        {
            this.Document = document;
            this.DocumentTitle = documentTitle;
            this.DocumentIntroduction = documentIntroduction;
            this.RecipientEmail = recipientEmail;
            this.RecipientFirstName = recipientFirstName;
            this.RecipientLastName = recipientLastName;
            this.ExpiryDate = expiryDate;
            this.SignatureRequired = signatureRequired;
            this.OrgansiationTitle = organsiationTitle;
            this.OrganisationEmail = organisationEmail;
            this.OrganisationOwner = organisationOwner;
        }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public EnvelopesInstancesRequestInputDocumentType Document { get; set; }

        [JsonProperty("configuration")]
        public AiTemplateBuilderRequestInputConfigurationType Configuration { get; set; }

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

    public class EnvelopesInstancesRequestInputDocumentType
    {
        public EnvelopesInstancesRequestInputDocumentType(string pDFDocument)
        {
            this.PDFDocument = pDFDocument;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PDFDocument { get; set; }
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