//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamforms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<Team[]> Teams()
        {
            var apiCallPath = "/teams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Team[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        [WorkflowExpressionFactory(nameof(__BuildForms))]
        public IBodyWorkflowAction<FormMeta[]> Forms([WorkflowExpression] Func<string> groupId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormMeta[]> __BuildForms(WorkflowExpression<string> groupId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<FormMeta[]>(() =>
            {
                var apiCallPath = "/forms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                return new ApiConnectionAction<FormMeta[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        [WorkflowExpressionFactory(nameof(__BuildForm))]
        public IBodyWorkflowAction<FormSchema> Form([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormSchema> __BuildForm(WorkflowExpression<string> groupId, WorkflowExpression<string> formId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            return new DeferredBodyAction<FormSchema>(() =>
            {
                var apiCallPath = "/form";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["formId"] = ExpressionConverter.Convert(formId);
                return new ApiConnectionAction<FormSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        [WorkflowExpressionFactory(nameof(__BuildFiles))]
        public IBodyWorkflowAction<File[]> Files([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> responseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<File[]> __BuildFiles(WorkflowExpression<string> groupId, WorkflowExpression<string> responseId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(responseId, nameof(responseId), required: true);
            return new DeferredBodyAction<File[]>(() =>
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["responseId"] = ExpressionConverter.Convert(responseId);
                return new ApiConnectionAction<File[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        [WorkflowExpressionFactory(nameof(__BuildPdf))]
        public IBodyWorkflowAction<File> Pdf([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> responseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<File> __BuildPdf(WorkflowExpression<string> groupId, WorkflowExpression<string> responseId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(responseId, nameof(responseId), required: true);
            return new DeferredBodyAction<File>(() =>
            {
                var apiCallPath = "/pdf";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["responseId"] = ExpressionConverter.Convert(responseId);
                return new ApiConnectionAction<File>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        [WorkflowExpressionFactory(nameof(__BuildPdfContent))]
        public IBodyWorkflowAction<string> PdfContent([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> responseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPdfContent(WorkflowExpression<string> groupId, WorkflowExpression<string> responseId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(responseId, nameof(responseId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pdf-content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["responseId"] = ExpressionConverter.Convert(responseId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        [WorkflowExpressionFactory(nameof(__BuildResponse))]
        public IBodyWorkflowAction<JToken> Response([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> responseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildResponse(WorkflowExpression<string> groupId, WorkflowExpression<string> formId, WorkflowExpression<string> responseId)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(responseId, nameof(responseId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/response";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                callPayload.Queries["formId"] = ExpressionConverter.Convert(formId);
                callPayload.Queries["responseId"] = ExpressionConverter.Convert(responseId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class TeamformsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildSubscribeResponse))]
        public IWorkflowTrigger SubscribeResponse([WorkflowExpression] Func<string> groupId,[WorkflowExpression] Func<string> formId = null,[WorkflowExpression] Func<environmentInput> environment = null,[WorkflowExpression] Func<triggersInput> triggers = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSubscribeResponse(WorkflowExpression<string> groupId,WorkflowExpression<string> formId = null,WorkflowExpression<environmentInput> environment = null,WorkflowExpression<triggersInput> triggers = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(formId, nameof(formId), required: false);
            WorkflowExpression.Validate(environment, nameof(environment), required: false);
            WorkflowExpression.Validate(triggers, nameof(triggers), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/response-subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                if (formId != null)
                    callPayload.Queries["formId"] = ExpressionConverter.Convert(formId);
                if (environment != null)
                    callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
                if (triggers != null)
                    callPayload.Queries["triggers"] = ExpressionConverter.Convert(triggers);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBody["webHookUrl"] = "#{listCallbackUrl()}";
                requestBodypropCount++;
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildSubscribeResponseDeletion))]
        public IWorkflowTrigger SubscribeResponseDeletion([WorkflowExpression] Func<string> groupId,[WorkflowExpression] Func<string> formId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSubscribeResponseDeletion(WorkflowExpression<string> groupId,WorkflowExpression<string> formId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(groupId, nameof(groupId), required: true);
            WorkflowExpression.Validate(formId, nameof(formId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/response-deletion-subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                if (formId != null)
                    callPayload.Queries["formId"] = ExpressionConverter.Convert(formId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBody["webHookUrl"] = "#{listCallbackUrl()}";
                requestBodypropCount++;
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Team
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("specialization")]
        public string Specialization { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("isArchived")]
        public bool IsArchived { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("isMembershipLimitedToOwners")]
        public string IsMembershipLimitedToOwners { get; set; }

        [JsonProperty("memberSettings")]
        public string MemberSettings { get; set; }

        [JsonProperty("guestSettings")]
        public string GuestSettings { get; set; }

        [JsonProperty("messagingSettings")]
        public string MessagingSettings { get; set; }

        [JsonProperty("funSettings")]
        public string FunSettings { get; set; }

        [JsonProperty("discoverySettings")]
        public string DiscoverySettings { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class FormMeta
    {
        [JsonProperty("@odata.etag")]
        public string Etag { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("createdBy")]
        public FormMetaCreatedByType CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public FormMetaLastModifiedByType LastModifiedBy { get; set; }

        [JsonProperty("parentReference")]
        public FormMetaParentReferenceType ParentReference { get; set; }

        [JsonProperty("contentType")]
        public FormMetaContentTypeType ContentType { get; set; }

        [JsonProperty("fields@odata.context")]
        public string FieldsOdataContext { get; set; }

        [JsonProperty("fields")]
        public FormMetaFieldsType Fields { get; set; }
    }

    public class FormMetaCreatedByType
    {
        [JsonProperty("user")]
        public FormMetaCreatedByTypeUserType User { get; set; }
    }

    public class FormMetaCreatedByTypeUserType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class FormMetaLastModifiedByType
    {
        [JsonProperty("application")]
        public FormMetaLastModifiedByTypeApplicationType Application { get; set; }

        [JsonProperty("user")]
        public FormMetaLastModifiedByTypeUserType User { get; set; }
    }

    public class FormMetaLastModifiedByTypeApplicationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class FormMetaLastModifiedByTypeUserType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class FormMetaParentReferenceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }
    }

    public class FormMetaContentTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FormMetaFieldsType
    {
        [JsonProperty("@odata.etag")]
        public string Etag { get; set; }

        [JsonProperty("tfItemType")]
        public string TfItemType { get; set; }

        [JsonProperty("tfFormId")]
        public string TfFormId { get; set; }

        [JsonProperty("tfTitle")]
        public string TfTitle { get; set; }
    }

    public class FormSchema
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("version")]
        public double Version { get; set; }
    }

    public class File
    {
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("itemId")]
        public JToken ItemId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum environmentInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "published")]
        Published
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum triggersInput
    {
        Submitted,
        Resubmitted,
        [EnumMember(Value = "Submitted and Resubmitted")]
        SubmittedAndResubmitted
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teamforms;

    public partial class WorkflowManagedActions
    {
        public TeamformsActions Teamforms(string connectionId) => new TeamformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TeamformsTriggers Teamforms(string connectionId) => new TeamformsTriggers(connectionId);
    }
}