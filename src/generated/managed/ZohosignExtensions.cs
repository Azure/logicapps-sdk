//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohosign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohosignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<JToken> InvokeAPI([WorkflowExpression] Func<string> url, [WorkflowExpression] Func<methodInput> method)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(url, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = SourceExpressionConverter.Convert(method);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<object> DownloadCompletionCertificate([WorkflowExpression] Func<int> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/completioncertificate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<object> DownloadDocument([WorkflowExpression] Func<int> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/pdf", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<object> DownloadFile([WorkflowExpression] Func<int> requestId, [WorkflowExpression] Func<int> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/pdf", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<GetFormDataResponse> GetFormData([WorkflowExpression] Func<int> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/fielddata", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFormDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction RecallDocument([WorkflowExpression] Func<int> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/recall", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction RemindDocumentRecipients([WorkflowExpression] Func<int> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/remind", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<int> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression] Func<int> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<UpdateDocumentResponse> UpdateDocument([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> bodyrequestsrequestTypeId = null, [WorkflowExpression] Func<string> bodyrequestsrequestName = null, [WorkflowExpression] Func<bodyrequestsactionsInputItem[]> bodyrequestsactions = null, [WorkflowExpression] Func<int> bodyrequestsexpirationDays = null, [WorkflowExpression] Func<bool> bodyrequestsisSequential = null, [WorkflowExpression] Func<bool> bodyrequestsemailReminders = null, [WorkflowExpression] Func<int> bodyrequestsreminderPeriod = null, [WorkflowExpression] Func<string> bodyrequestsfolderId = null, [WorkflowExpression] Func<string> bodyrequestsnotes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var requestsObject = new JObject();
                var requestsObjectpropCount = 0;
                if (bodyrequestsrequestTypeId != null)
                {
                    requestsObject["request_type_id"] = SourceExpressionConverter.ConvertToken(bodyrequestsrequestTypeId);
                    requestsObjectpropCount++;
                }

                if (bodyrequestsrequestName != null)
                {
                    requestsObject["request_name"] = SourceExpressionConverter.ConvertToken(bodyrequestsrequestName);
                    requestsObjectpropCount++;
                }

                if (bodyrequestsactions != null)
                {
                    requestsObject["actions"] = SourceExpressionConverter.ConvertToken(bodyrequestsactions);
                    requestsObjectpropCount++;
                }

                if (bodyrequestsexpirationDays != null)
                {
                    if (bodyrequestsexpirationDays != null)
                    {
                        requestsObject["expiration_days"] = SourceExpressionConverter.ConvertToken(bodyrequestsexpirationDays);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["expiration_days"] = 15;
                    requestsObjectpropCount++;
                }

                if (bodyrequestsisSequential != null)
                {
                    if (bodyrequestsisSequential != null)
                    {
                        requestsObject["is_sequential"] = SourceExpressionConverter.ConvertToken(bodyrequestsisSequential);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["is_sequential"] = true;
                    requestsObjectpropCount++;
                }

                if (bodyrequestsemailReminders != null)
                {
                    if (bodyrequestsemailReminders != null)
                    {
                        requestsObject["email_reminders"] = SourceExpressionConverter.ConvertToken(bodyrequestsemailReminders);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["email_reminders"] = true;
                    requestsObjectpropCount++;
                }

                if (bodyrequestsreminderPeriod != null)
                {
                    if (bodyrequestsreminderPeriod != null)
                    {
                        requestsObject["reminder_period"] = SourceExpressionConverter.ConvertToken(bodyrequestsreminderPeriod);
                        requestsObjectpropCount++;
                    }

                    requestsObjectpropCount++;
                }
                else
                {
                    requestsObject["reminder_period"] = 5;
                    requestsObjectpropCount++;
                }

                if (bodyrequestsfolderId != null)
                {
                    requestsObject["folder_id"] = SourceExpressionConverter.ConvertToken(bodyrequestsfolderId);
                    requestsObjectpropCount++;
                }

                if (bodyrequestsnotes != null)
                {
                    requestsObject["notes"] = SourceExpressionConverter.ConvertToken(bodyrequestsnotes);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<SendSignRequestResponse> SendSignRequest([WorkflowExpression] Func<string> requestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/submit", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SendSignRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IWorkflowAction GetTemplateDetails([WorkflowExpression] Func<string> templateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohosign")]
        public IBodyWorkflowAction<GetTemplatesResponse> GetTemplates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplatesResponse>(BuildSourceInput);
        }
    }

    public class ZohosignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ZohoSignTriggers([WorkflowExpression] Func<bodywebhookActionsInput> bodywebhookActions, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/internal/accounts/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhook_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["webhook_actions"] = SourceExpressionConverter.Convert(bodywebhookActions);
                body["purpose"] = "Microsoft PowerAutomate";
                bodypropCount++;
                body["appname"] = "Microsoft PowerAutomate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

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

    public enum bodyrequestsactionsInputItemActionTypeType
    {
        SIGN,
        VIEW,
        INPERSONSIGN,
        APPROVER
    }

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