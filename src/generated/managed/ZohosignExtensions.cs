//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohosign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohosignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeAPI(Expression<Func<string>> url, Expression<Func<methodInput>> method)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_url.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadCompletionCertificate(Expression<Func<int>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/completioncertificate", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<int>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/pdf", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadFile(Expression<Func<int>> requestId, Expression<Func<int>> documentId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}/pdf", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<GetFormDataResponse, ApiConnectionActionConfiguration> GetFormData(Expression<Func<int>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetFormDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/fielddata", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFormDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RecallDocument(Expression<Func<int>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/recall", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemindDocumentRecipients(Expression<Func<int>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/remind", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<int>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/delete", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<GetDocumentResponse, ApiConnectionActionConfiguration> GetDocument(Expression<Func<int>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<GetDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<UpdateDocumentResponse, ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<string>> requestId, Expression<Func<string>> bodyrequestsrequestTypeId = null, Expression<Func<string>> bodyrequestsrequestName = null, Expression<Func<bodyrequestsactionsInputItem[]>> bodyrequestsactions = null, Expression<Func<int>> bodyrequestsexpirationDays = null, Expression<Func<bool>> bodyrequestsisSequential = null, Expression<Func<bool>> bodyrequestsemailReminders = null, Expression<Func<int>> bodyrequestsreminderPeriod = null, Expression<Func<string>> bodyrequestsfolderId = null, Expression<Func<string>> bodyrequestsnotes = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_bodyrequestsrequestTypeId = WorkflowExpression.Compile(bodyrequestsrequestTypeId, nameof(bodyrequestsrequestTypeId), required: false);
            var __workflow_bodyrequestsrequestName = WorkflowExpression.Compile(bodyrequestsrequestName, nameof(bodyrequestsrequestName), required: false);
            var __workflow_bodyrequestsactions = WorkflowExpression.Compile(bodyrequestsactions, nameof(bodyrequestsactions), required: false);
            var __workflow_bodyrequestsexpirationDays = WorkflowExpression.Compile(bodyrequestsexpirationDays, nameof(bodyrequestsexpirationDays), required: false);
            var __workflow_bodyrequestsisSequential = WorkflowExpression.Compile(bodyrequestsisSequential, nameof(bodyrequestsisSequential), required: false);
            var __workflow_bodyrequestsemailReminders = WorkflowExpression.Compile(bodyrequestsemailReminders, nameof(bodyrequestsemailReminders), required: false);
            var __workflow_bodyrequestsreminderPeriod = WorkflowExpression.Compile(bodyrequestsreminderPeriod, nameof(bodyrequestsreminderPeriod), required: false);
            var __workflow_bodyrequestsfolderId = WorkflowExpression.Compile(bodyrequestsfolderId, nameof(bodyrequestsfolderId), required: false);
            var __workflow_bodyrequestsnotes = WorkflowExpression.Compile(bodyrequestsnotes, nameof(bodyrequestsnotes), required: false);
            return new DeferredBodyAction<UpdateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var requestsObject = new JObject();
                var requestsObjectpropCount = 0;
                if (__workflow_bodyrequestsrequestTypeId != null)
                {
                    requestsObject["request_type_id"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsrequestTypeId);
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsrequestName != null)
                {
                    requestsObject["request_name"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsrequestName);
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsactions != null)
                {
                    requestsObject["actions"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsactions);
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsexpirationDays != null)
                {
                    if (__workflow_bodyrequestsexpirationDays != null)
                    {
                        requestsObject["expiration_days"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsexpirationDays);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["expiration_days"] = 15;
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsisSequential != null)
                {
                    if (__workflow_bodyrequestsisSequential != null)
                    {
                        requestsObject["is_sequential"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsisSequential);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["is_sequential"] = true;
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsemailReminders != null)
                {
                    if (__workflow_bodyrequestsemailReminders != null)
                    {
                        requestsObject["email_reminders"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsemailReminders);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["email_reminders"] = true;
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsreminderPeriod != null)
                {
                    if (__workflow_bodyrequestsreminderPeriod != null)
                    {
                        requestsObject["reminder_period"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsreminderPeriod);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["reminder_period"] = 5;
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsfolderId != null)
                {
                    requestsObject["folder_id"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsfolderId);
                    requestsObjectpropCount++;
                }

                if (__workflow_bodyrequestsnotes != null)
                {
                    requestsObject["notes"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsnotes);
                    requestsObjectpropCount++;
                }

                if (requestsObjectpropCount > 0)
                {
                    body["requests"] = requestsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<SendSignRequestResponse, ApiConnectionActionConfiguration> SendSignRequest(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<SendSignRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/submit", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SendSignRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTemplateDetails(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<GetTemplatesResponse, ApiConnectionActionConfiguration> GetTemplates()
        {
            return new DeferredBodyAction<GetTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplatesResponse>(callPayload);
            });
        }
    }

    public class ZohosignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ZohoSignTriggers(Expression<Func<bodywebhookActionsInput>> bodywebhookActions, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebhookActions = WorkflowExpression.Compile(bodywebhookActions, nameof(bodywebhookActions), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/internal/accounts/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhook_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["webhook_actions"] = ExpressionConverter.ConvertO(__workflow_bodywebhookActions);
                body["purpose"] = "Microsoft PowerAutomate";
                bodypropCount++;
                body["appname"] = "Microsoft PowerAutomate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        POST,
        PUT
    }

    public class GetFormDataResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("document_form_data")]
        public GetFormDataResponseDocumentFormDataType DocumentFormData { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetFormDataResponseDocumentFormDataType
    {
        [JsonProperty("request_name")]
        public string RequestName { get; set; }

        [JsonProperty("zsdocumentid")]
        public string Zsdocumentid { get; set; }

        [JsonProperty("actions")]
        public GetFormDataResponseDocumentFormDataTypeActionsTypeItem[] Actions { get; set; }
    }

    public class GetFormDataResponseDocumentFormDataTypeActionsTypeItem
    {
        [JsonProperty("signed_time")]
        public string SignedTime { get; set; }

        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        [JsonProperty("recipient_email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        [JsonProperty("fields")]
        public GetFormDataResponseDocumentFormDataTypeActionsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    public class GetFormDataResponseDocumentFormDataTypeActionsTypeItemFieldsTypeItem
    {
        [JsonProperty("field_label")]
        public string FieldLabel { get; set; }

        [JsonProperty("field_value")]
        public string FieldValue { get; set; }

        [JsonProperty("field_name")]
        public string FieldName { get; set; }
    }

    public class GetDocumentResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("requests")]
        public GetDocumentResponseRequestsType Requests { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetDocumentResponseRequestsType
    {
        [JsonProperty("request_status")]
        public string RequestStatus { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("reminder_period")]
        public int ReminderPeriod { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("request_name")]
        public string RequestName { get; set; }

        [JsonProperty("modified_time")]
        public int ModifiedTime { get; set; }

        [JsonProperty("action_time")]
        public int ActionTime { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("expiration_days")]
        public int ExpirationDays { get; set; }

        [JsonProperty("is_sequential")]
        public bool IsSequential { get; set; }

        [JsonProperty("sign_submitted_time")]
        public int SignSubmittedTime { get; set; }

        [JsonProperty("owner_first_name")]
        public string OwnerFirstName { get; set; }

        [JsonProperty("sign_percentage")]
        public double SignPercentage { get; set; }

        [JsonProperty("expire_by")]
        public int ExpireBy { get; set; }

        [JsonProperty("is_expiring")]
        public bool IsExpiring { get; set; }

        [JsonProperty("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonProperty("created_time")]
        public int CreatedTime { get; set; }

        [JsonProperty("email_reminders")]
        public bool EmailReminders { get; set; }

        [JsonProperty("document_ids")]
        public GetDocumentResponseRequestsTypeDocumentIdsTypeItem[] DocumentIds { get; set; }

        [JsonProperty("self_sign")]
        public bool SelfSign { get; set; }

        [JsonProperty("sign_id")]
        public string SignId { get; set; }

        [JsonProperty("folder_name")]
        public string FolderName { get; set; }

        [JsonProperty("in_process")]
        public bool InProcess { get; set; }

        [JsonProperty("validity")]
        public int Validity { get; set; }

        [JsonProperty("request_type_name")]
        public string RequestTypeName { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("request_type_id")]
        public string RequestTypeId { get; set; }

        [JsonProperty("owner_last_name")]
        public string OwnerLastName { get; set; }

        [JsonProperty("actions")]
        public GetDocumentResponseRequestsTypeActionsTypeItem[] Actions { get; set; }

        [JsonProperty("attachment_size")]
        public int AttachmentSize { get; set; }
    }

    public class GetDocumentResponseRequestsTypeDocumentIdsTypeItem
    {
        [JsonProperty("image_string")]
        public string ImageString { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("pages")]
        public GetDocumentResponseRequestsTypeDocumentIdsTypeItemPagesTypeItem[] Pages { get; set; }

        [JsonProperty("document_size")]
        public int DocumentSize { get; set; }

        [JsonProperty("document_order")]
        public string DocumentOrder { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("document_id")]
        public string DocumentId { get; set; }
    }

    public class GetDocumentResponseRequestsTypeDocumentIdsTypeItemPagesTypeItem
    {
        [JsonProperty("image_string")]
        public string ImageString { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("is_thumbnail")]
        public bool IsThumbnail { get; set; }
    }

    public class GetDocumentResponseRequestsTypeActionsTypeItem
    {
        [JsonProperty("verify_recipient")]
        public bool VerifyRecipient { get; set; }

        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        [JsonProperty("private_notes")]
        public string PrivateNotes { get; set; }

        [JsonProperty("recipient_email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("send_completed_document")]
        public bool SendCompletedDocument { get; set; }

        [JsonProperty("verification_type")]
        public string VerificationType { get; set; }

        [JsonProperty("allow_signing")]
        public bool AllowSigning { get; set; }

        [JsonProperty("recipient_phonenumber")]
        public string RecipientPhonenumber { get; set; }

        [JsonProperty("is_bulk")]
        public bool IsBulk { get; set; }

        [JsonProperty("action_id")]
        public string ActionId { get; set; }

        [JsonProperty("is_revoked")]
        public bool IsRevoked { get; set; }

        [JsonProperty("is_embedded")]
        public bool IsEmbedded { get; set; }

        [JsonProperty("signing_order")]
        public int SigningOrder { get; set; }

        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        [JsonProperty("action_status")]
        public string ActionStatus { get; set; }

        [JsonProperty("recipient_countrycode")]
        public string RecipientCountrycode { get; set; }

        [JsonProperty("ishost")]
        public bool Ishost { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("in_person_name")]
        public string InPersonName { get; set; }

        [JsonProperty("in_person_email")]
        public string InPersonEmail { get; set; }

        [JsonProperty("verification_code")]
        public string VerificationCode { get; set; }
    }

    public class UpdateDocumentResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class bodyrequestsactionsInputItem
    {
        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        [JsonProperty("recipient_email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipient_phonenumber")]
        public string RecipientPhonenumber { get; set; }

        [JsonProperty("recipient_countrycode")]
        public string RecipientCountrycode { get; set; }

        [JsonProperty("action_type")]
        public bodyrequestsactionsInputItemActionTypeType ActionType { get; set; }

        [JsonProperty("private_notes")]
        public string PrivateNotes { get; set; }

        [JsonProperty("signing_order")]
        public int SigningOrder { get; set; }

        [JsonProperty("verify_recipient")]
        public bool VerifyRecipient { get; set; }

        [JsonProperty("verification_type")]
        public bodyrequestsactionsInputItemVerificationTypeType VerificationType { get; set; }

        [JsonProperty("verification_code")]
        public string VerificationCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrequestsactionsInputItemActionTypeType
    {
        SIGN,
        VIEW,
        INPERSONSIGN,
        APPROVER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrequestsactionsInputItemVerificationTypeType
    {
        NONE,
        OFFLINE,
        EMAIL,
        SMS
    }

    public class SendSignRequestResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetTemplatesResponse
    {
        [JsonProperty("templates")]
        public GetTemplatesResponseTemplatesTypeItem[] Templates { get; set; }
    }

    public class GetTemplatesResponseTemplatesTypeItem
    {
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodywebhookActionsInput
    {
        Sign,
        Decline,
        Forward,
        Completed,
        Recalled,
        Expired,
        Viewed
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zohosign;

    public partial class WorkflowManagedActions
    {
        public ZohosignActions Zohosign(string connectionId) => new ZohosignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZohosignTriggers Zohosign(string connectionId) => new ZohosignTriggers(connectionId);
    }
}