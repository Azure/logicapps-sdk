//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<Team[]> Teams()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Team[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<FormMeta[]> Forms([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/forms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                return callPayload;
            }

            return new ApiConnectionAction<FormMeta[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<FormSchema> Form([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/form";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["formId"] = SourceExpressionConverter.ConvertO(formId);
                return callPayload;
            }

            return new ApiConnectionAction<FormSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<File[]> Files([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> responseId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(responseId, nameof(responseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["responseId"] = SourceExpressionConverter.ConvertO(responseId);
                return callPayload;
            }

            return new ApiConnectionAction<File[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<File> Pdf([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> responseId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(responseId, nameof(responseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["responseId"] = SourceExpressionConverter.ConvertO(responseId);
                return callPayload;
            }

            return new ApiConnectionAction<File>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<string> PdfContent([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> responseId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(responseId, nameof(responseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf-content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["responseId"] = SourceExpressionConverter.ConvertO(responseId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamforms")]
        public IBodyWorkflowAction<JToken> Response([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> responseId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(responseId, nameof(responseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["formId"] = SourceExpressionConverter.ConvertO(formId);
                callPayload.Queries["responseId"] = SourceExpressionConverter.ConvertO(responseId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class TeamformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SubscribeResponse([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId = null, [WorkflowExpression] Func<environmentInput> environment = null, [WorkflowExpression] Func<triggersInput> triggers = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: false);
            SourceExpression.Validate(environment, nameof(environment), required: false);
            SourceExpression.Validate(triggers, nameof(triggers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response-subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                if (formId != null)
                    callPayload.Queries["formId"] = SourceExpressionConverter.ConvertO(formId);
                if (environment != null)
                    callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                if (triggers != null)
                    callPayload.Queries["triggers"] = SourceExpressionConverter.Convert(triggers);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBody["webHookUrl"] = "@listCallbackUrl()";
                requestBodypropCount++;
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger SubscribeResponseDeletion([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response-deletion-subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                if (formId != null)
                    callPayload.Queries["formId"] = SourceExpressionConverter.ConvertO(formId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBody["webHookUrl"] = "@listCallbackUrl()";
                requestBodypropCount++;
                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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

    public enum environmentInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "published")]
        Published
    }

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