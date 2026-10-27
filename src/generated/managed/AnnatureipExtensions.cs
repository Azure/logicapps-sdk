//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Annatureip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnnatureipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetDocumentsResponseItem[], ApiConnectionActionConfiguration> GetDocuments(Expression<Func<string>> envelopeId, Expression<Func<int>> endpointDuration = null)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_endpointDuration = WorkflowExpression.Compile(endpointDuration, nameof(endpointDuration), required: false);
            return new DeferredBodyAction<GetDocumentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["envelope_id"] = ExpressionConverter.Convert(__workflow_envelopeId);
                if (__workflow_endpointDuration != null)
                    callPayload.Queries["endpoint_duration"] = ExpressionConverter.Convert(__workflow_endpointDuration);
                return new ApiConnectionAction<GetDocumentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetEnvelopeResponse, ApiConnectionActionConfiguration> GetEnvelope(Expression<Func<string>> id, Expression<Func<int>> endpointDuration = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_endpointDuration = WorkflowExpression.Compile(endpointDuration, nameof(endpointDuration), required: false);
            return new DeferredBodyAction<GetEnvelopeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_endpointDuration != null)
                    callPayload.Queries["endpoint_duration"] = ExpressionConverter.Convert(__workflow_endpointDuration);
                return new ApiConnectionAction<GetEnvelopeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnvelope(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "head";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetEnvelopesResponseItem[], ApiConnectionActionConfiguration> GetEnvelopes(Expression<Func<string>> name = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> recipient = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> completedBefore = null, Expression<Func<string>> completedAfter = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_completedBefore = WorkflowExpression.Compile(completedBefore, nameof(completedBefore), required: false);
            var __workflow_completedAfter = WorkflowExpression.Compile(completedAfter, nameof(completedAfter), required: false);
            return new DeferredBodyAction<GetEnvelopesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["created_before"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["created_after"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_completedBefore != null)
                    callPayload.Queries["completed_before"] = ExpressionConverter.Convert(__workflow_completedBefore);
                if (__workflow_completedAfter != null)
                    callPayload.Queries["completed_after"] = ExpressionConverter.Convert(__workflow_completedAfter);
                return new ApiConnectionAction<GetEnvelopesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration> CreateEnvelope(Expression<Func<CreateEnvelopeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEnvelope(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/send", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> VoidEnvelope(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/void", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetFieldAttachmentsResponseItem[], ApiConnectionActionConfiguration> GetFieldAttachments(Expression<Func<string>> envelopeId, Expression<Func<string>> id)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFieldAttachmentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fields/{0}/attachments", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["envelope_id"] = ExpressionConverter.Convert(__workflow_envelopeId);
                return new ApiConnectionAction<GetFieldAttachmentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetFieldResponse, ApiConnectionActionConfiguration> GetField(Expression<Func<string>> envelopeId, Expression<Func<string>> id)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fields/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["envelope_id"] = ExpressionConverter.Convert(__workflow_envelopeId);
                return new ApiConnectionAction<GetFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetFieldsResponseItem[], ApiConnectionActionConfiguration> GetFields(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<GetFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["envelope_id"] = ExpressionConverter.Convert(__workflow_envelopeId);
                return new ApiConnectionAction<GetFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetTemplateResponse, ApiConnectionActionConfiguration> GetTemplate(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetTemplatesResponseItem[], ApiConnectionActionConfiguration> GetTemplates(Expression<Func<string>> name = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdAfter = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            return new DeferredBodyAction<GetTemplatesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["created_before"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["created_after"] = ExpressionConverter.Convert(__workflow_createdAfter);
                return new ApiConnectionAction<GetTemplatesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetAccountsResponseItem[], ApiConnectionActionConfiguration> GetAccounts()
        {
            return new DeferredBodyAction<GetAccountsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAccountsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetOrganisationResponse, ApiConnectionActionConfiguration> GetOrganisation()
        {
            return new DeferredBodyAction<GetOrganisationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/organisations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOrganisationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<UseTemplateResponse, ApiConnectionActionConfiguration> UseTemplate(Expression<Func<string>> id, Expression<Func<UseTemplateInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UseTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}/use", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UseTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "annatureip")]
        public IBodyWorkflowAction<GetRecipientResponse, ApiConnectionActionConfiguration> GetRecipient(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetRecipientResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/recipients/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRecipientResponse>(callPayload);
            });
        }
    }

    public class AnnatureipTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnDocumentEventResponse, ApiConnectionTriggerConfiguration> OnDocumentEvent(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OnDocumentEventResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/endpoints";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new OnDocumentEventInput().ToJToken();
                return new ApiConnectionTrigger<OnDocumentEventResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetDocumentsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("master")]
        public string Master { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetEnvelopeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("sent")]
        public string Sent { get; set; }

        [JsonProperty("voided")]
        public string Voided { get; set; }

        [JsonProperty("declined")]
        public string Declined { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("master")]
        public string Master { get; set; }

        [JsonProperty("combined")]
        public string Combined { get; set; }

        [JsonProperty("certificate")]
        public string Certificate { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("recipients")]
        public GetEnvelopeResponseRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetEnvelopeResponseRecipientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EmailId { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("type")]
        public GetEnvelopeResponseRecipientsTypeItemRecipientTypeType RecipientType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("password")]
        public JToken Password { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("order")]
        public int SigningOrder { get; set; }

        [JsonProperty("redirects")]
        public GetEnvelopeResponseRecipientsTypeItemRedirectsType Redirects { get; set; }

        [JsonProperty("fields")]
        public GetEnvelopeResponseRecipientsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEnvelopeResponseRecipientsTypeItemRecipientTypeType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "carbon-copy")]
        CarbonCopy
    }

    public class GetEnvelopeResponseRecipientsTypeItemRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class GetEnvelopeResponseRecipientsTypeItemFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("x_coordinate")]
        public int XCoordinate { get; set; }

        [JsonProperty("y_coordinate")]
        public int YCoordinate { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("font_size")]
        public int FontSize { get; set; }

        [JsonProperty("font_type")]
        public string FontType { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetEnvelopesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("sent")]
        public string Sent { get; set; }

        [JsonProperty("voided")]
        public string Voided { get; set; }

        [JsonProperty("declined")]
        public string Declined { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("combined")]
        public string Combined { get; set; }

        [JsonProperty("master")]
        public string Master { get; set; }

        [JsonProperty("certificate")]
        public string Certificate { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("recipients")]
        public GetEnvelopesResponseItemRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetEnvelopesResponseItemRecipientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EmailId { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("type")]
        public GetEnvelopesResponseItemRecipientsTypeItemRecipientTypeType RecipientType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("password")]
        public JToken Password { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("order")]
        public int SigningOrder { get; set; }

        [JsonProperty("redirects")]
        public GetEnvelopesResponseItemRecipientsTypeItemRedirectsType Redirects { get; set; }

        [JsonProperty("fields")]
        public GetEnvelopesResponseItemRecipientsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEnvelopesResponseItemRecipientsTypeItemRecipientTypeType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "carbon-copy")]
        CarbonCopy
    }

    public class GetEnvelopesResponseItemRecipientsTypeItemRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class GetEnvelopesResponseItemRecipientsTypeItemFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("x_coordinate")]
        public int XCoordinate { get; set; }

        [JsonProperty("y_coordinate")]
        public int YCoordinate { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("font_size")]
        public int FontSize { get; set; }

        [JsonProperty("font_type")]
        public string FontType { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "voided")]
        Voided
    }

    public class CreateEnvelopeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("created")]
        public string CreatedOn { get; set; }

        [JsonProperty("sent")]
        public string SentOn { get; set; }

        [JsonProperty("voided")]
        public JToken Voided { get; set; }

        [JsonProperty("declined")]
        public JToken Declined { get; set; }

        [JsonProperty("completed")]
        public JToken Completed { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("recipients")]
        public CreateEnvelopeResponseRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateEnvelopeResponseRecipientsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("password")]
        public JToken Password { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("declined_reason")]
        public JToken DeclinedReason { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("sent")]
        public string Sent { get; set; }

        [JsonProperty("declined")]
        public JToken Declined { get; set; }

        [JsonProperty("completed")]
        public JToken Completed { get; set; }

        [JsonProperty("redirects")]
        public CreateEnvelopeResponseRecipientsTypeItemRedirectsType Redirects { get; set; }
    }

    public class CreateEnvelopeResponseRecipientsTypeItemRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class CreateEnvelopeInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("shared")]
        public bool? Shared { get; set; }

        [JsonProperty("draft")]
        public bool? IsDraft { get; set; }

        [JsonProperty("account_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEnvelopeInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEnvelopeInputRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateEnvelopeInputDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public CreateEnvelopeInputDocumentsTypeItemTypeType? Type { get; set; }

        [JsonProperty("base")]
        public string FileContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeInputDocumentsTypeItemTypeType
    {
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf
    }

    public class CreateEnvelopeInputRecipientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EmailId { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("type")]
        public CreateEnvelopeInputRecipientsTypeItemRecipientTypeType? RecipientType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("muted")]
        public bool? Muted { get; set; }

        [JsonProperty("order")]
        public int? SigningOrder { get; set; }

        [JsonProperty("redirects")]
        public CreateEnvelopeInputRecipientsTypeItemRedirectsType Redirects { get; set; }

        [JsonProperty("fields")]
        public CreateEnvelopeInputRecipientsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeInputRecipientsTypeItemRecipientTypeType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "carbon-copy")]
        CarbonCopy
    }

    public class CreateEnvelopeInputRecipientsTypeItemRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class CreateEnvelopeInputRecipientsTypeItemFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        [JsonProperty("type")]
        public CreateEnvelopeInputRecipientsTypeItemFieldsTypeItemTypeType? Type { get; set; }

        [JsonProperty("page")]
        public int? Page { get; set; }

        [JsonProperty("x_coordinate")]
        public int? XCoordinate { get; set; }

        [JsonProperty("y_coordinate")]
        public int? YCoordinate { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        [JsonProperty("collaborative")]
        public bool? Collaborative { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("font_size")]
        public int? FontSize { get; set; }

        [JsonProperty("font_type")]
        public string FontType { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeInputRecipientsTypeItemFieldsTypeItemTypeType
    {
        [EnumMember(Value = "signature")]
        Signature,
        [EnumMember(Value = "initials")]
        Initials,
        [EnumMember(Value = "witness")]
        Witness,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "input")]
        Input,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "dropdown")]
        Dropdown
    }

    public class GetFieldAttachmentsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetFieldResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("anchor")]
        public string Anchor { get; set; }

        [JsonProperty("x_coordinate")]
        public int XCoordinate { get; set; }

        [JsonProperty("y_coordinate")]
        public int YCoordinate { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("checked")]
        public bool Checked { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }

        [JsonProperty("font_size")]
        public int FontSize { get; set; }

        [JsonProperty("font_type")]
        public string FontType { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetFieldsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("anchor")]
        public string Anchor { get; set; }

        [JsonProperty("x_coordinate")]
        public int XCoordinate { get; set; }

        [JsonProperty("y_coordinate")]
        public int YCoordinate { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("checked")]
        public bool Checked { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }

        [JsonProperty("font_size")]
        public int FontSize { get; set; }

        [JsonProperty("font_type")]
        public string FontType { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetTemplateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("envelope_name")]
        public string EnvelopeName { get; set; }

        [JsonProperty("envelope_message")]
        public string EnvelopeMessage { get; set; }

        [JsonProperty("envelope_shared")]
        public bool EnvelopeShared { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("documents")]
        public GetTemplateResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("roles")]
        public GetTemplateResponseRolesTypeItem[] Roles { get; set; }
    }

    public class GetTemplateResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("master")]
        public string Master { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetTemplateResponseRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        [JsonProperty("recipient_email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipient_mobile")]
        public string RecipientMobile { get; set; }

        [JsonProperty("recipient_type")]
        public GetTemplateResponseRolesTypeItemRecipientTypeType RecipientType { get; set; }

        [JsonProperty("recipient_password")]
        public string Password { get; set; }

        [JsonProperty("order")]
        public int SigningOrder { get; set; }

        [JsonProperty("recipient_redirects")]
        public GetTemplateResponseRolesTypeItemRecipientRedirectsType RecipientRedirects { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTemplateResponseRolesTypeItemRecipientTypeType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "carbon-copy")]
        CarbonCopy
    }

    public class GetTemplateResponseRolesTypeItemRecipientRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class GetTemplatesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("envelope_name")]
        public string EnvelopeName { get; set; }

        [JsonProperty("envelope_message")]
        public string EnvelopeMessage { get; set; }

        [JsonProperty("envelope_shared")]
        public bool EnvelopeShared { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("documents")]
        public GetTemplatesResponseItemDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("roles")]
        public GetTemplatesResponseItemRolesTypeItem[] Roles { get; set; }
    }

    public class GetTemplatesResponseItemDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("master")]
        public string Master { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetTemplatesResponseItemRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        [JsonProperty("recipient_email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipient_mobile")]
        public string RecipientMobile { get; set; }

        [JsonProperty("recipient_type")]
        public GetTemplatesResponseItemRolesTypeItemRecipientTypeType RecipientType { get; set; }

        [JsonProperty("recipient_password")]
        public string Password { get; set; }

        [JsonProperty("order")]
        public int SigningOrder { get; set; }

        [JsonProperty("recipient_redirects")]
        public GetTemplatesResponseItemRolesTypeItemRecipientRedirectsType RecipientRedirects { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTemplatesResponseItemRolesTypeItemRecipientTypeType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "carbon-copy")]
        CarbonCopy
    }

    public class GetTemplatesResponseItemRolesTypeItemRecipientRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class GetAccountsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("verified")]
        public string Verified { get; set; }
    }

    public class GetOrganisationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("business")]
        public string Business { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("colour")]
        public string Colour { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class UseTemplateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("draft")]
        public bool Draft { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("documents")]
        public UseTemplateResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("recipients")]
        public UseTemplateResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class UseTemplateResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("master")]
        public string Master { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class UseTemplateResponseRecipientsTypeItem
    {
        [JsonProperty("role_id")]
        public string RoleId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("password")]
        public bool Password { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("redirects")]
        public UseTemplateResponseRecipientsTypeItemRedirectsType Redirects { get; set; }
    }

    public class UseTemplateResponseRecipientsTypeItemRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class UseTemplateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("draft", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsDraft { get; set; } = false;

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("shared")]
        public bool? Shared { get; set; }

        [JsonProperty("account_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccountId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("documents")]
        public UseTemplateInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public UseTemplateInputRecipientsTypeItem[] Recipients { get; set; }
    }

    public class UseTemplateInputDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string GroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public UseTemplateInputDocumentsTypeItemGroupId2Type? GroupId2 { get; set; }

        [JsonProperty("base")]
        public string FileContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UseTemplateInputDocumentsTypeItemGroupId2Type
    {
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf
    }

    public class UseTemplateInputRecipientsTypeItem
    {
        [JsonProperty("role_id")]
        public string RoleId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EmailId { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("sms_auth")]
        public string SMSAuth { get; set; }

        [JsonProperty("type")]
        public UseTemplateInputRecipientsTypeItemRecipientTypeType? RecipientType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("muted")]
        public bool? Muted { get; set; }

        [JsonProperty("order")]
        public int? SigningOrder { get; set; }

        [JsonProperty("fields")]
        public UseTemplateInputRecipientsTypeItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("redirects")]
        public UseTemplateInputRecipientsTypeItemRedirectsType Redirects { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UseTemplateInputRecipientsTypeItemRecipientTypeType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "carbon-copy")]
        CarbonCopy
    }

    public class UseTemplateInputRecipientsTypeItemFieldsTypeItem
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldIdFromTemplate { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class UseTemplateInputRecipientsTypeItemRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class GetRecipientResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("password")]
        public JToken Password { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("declined_reason")]
        public string DeclinedReason { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("sent")]
        public string Sent { get; set; }

        [JsonProperty("declined")]
        public string Declined { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("redirects")]
        public GetRecipientResponseRedirectsType Redirects { get; set; }
    }

    public class GetRecipientResponseRedirectsType
    {
        [JsonProperty("session_completed")]
        public string SessionCompleted { get; set; }

        [JsonProperty("session_declined")]
        public string SessionDeclined { get; set; }
    }

    public class OnDocumentEventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class OnDocumentEventInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Annatureip;

    public partial class WorkflowManagedActions
    {
        public AnnatureipActions Annatureip(string connectionId) => new AnnatureipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnnatureipTriggers Annatureip(string connectionId) => new AnnatureipTriggers(connectionId);
    }
}