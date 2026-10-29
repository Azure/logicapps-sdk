//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohomail
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohomailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetMailAccountResponse, ApiConnectionActionConfiguration> GetMailAccount()
        {
            return new DeferredBodyAction<GetMailAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMailAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SendMailResponse, ApiConnectionActionConfiguration> SendMail(Expression<Func<string>> accountId, Expression<Func<SendMailInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/messages", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SaveDraftResponse, ApiConnectionActionConfiguration> SaveDraft(Expression<Func<string>> accountId, Expression<Func<SaveDraftInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SaveDraftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/messages/draft", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SaveDraftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetSenderDetailsResponse, ApiConnectionActionConfiguration> GetSenderDetails(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<GetSenderDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSenderDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SearchMailResponse, ApiConnectionActionConfiguration> SearchMail(Expression<Func<string>> accountId, Expression<Func<int>> start, Expression<Func<int>> limit, Expression<Func<SearchMailInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchMailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/messages/search", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllFolderResponse, ApiConnectionActionConfiguration> GetAllFolder(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<GetAllFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/folders", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllLabelResponse, ApiConnectionActionConfiguration> GetAllLabel(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<GetAllLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/labels", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailContentResponse, ApiConnectionActionConfiguration> GetEmailContent(Expression<Func<string>> accountId, Expression<Func<string>> messageId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<GetEmailContentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/content", __workflow_accountId.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeBlockContent"] = Convert.ToString(true);
                return new ApiConnectionAction<GetEmailContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailAttachmentInfoResponse, ApiConnectionActionConfiguration> GetEmailAttachmentInfo(Expression<Func<string>> accountId, Expression<Func<string>> messageId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<GetEmailAttachmentInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachmentinfo", __workflow_accountId.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEmailAttachmentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetEmailAttachmentContent(Expression<Func<string>> accountId, Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachments/{2}", __workflow_accountId.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1), __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ZohomailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMailTriggerResponse, ApiConnectionTriggerConfiguration> NewMailTrigger(Expression<Func<string>> accId, Expression<Func<string>> criterias, Expression<Func<NewMailTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_accId = WorkflowExpression.Compile(accId, nameof(accId), required: true);
            var __workflow_criterias = WorkflowExpression.Compile(criterias, nameof(criterias), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NewMailTriggerResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integPlatform/api/outgoingWebhooks/newcriteriamail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accId"] = ExpressionConverter.Convert(__workflow_accId);
                callPayload.Queries["category"] = Convert.ToString(3);
                callPayload.Queries["action"] = Convert.ToString("CREATE_OWH");
                callPayload.Queries["metaOnly"] = Convert.ToString(false);
                callPayload.Queries["matchingCondition"] = Convert.ToString("and");
                callPayload.Queries["criterias"] = ExpressionConverter.Convert(__workflow_criterias);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NewMailTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NEWCONDITIONALMAILResponse, ApiConnectionTriggerConfiguration> NEWCONDITIONALMAIL(Expression<Func<string>> accId, Expression<Func<NEWCONDITIONALMAILInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_accId = WorkflowExpression.Compile(accId, nameof(accId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NEWCONDITIONALMAILResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integPlatform/api/outgoingconditionWebhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accId"] = ExpressionConverter.Convert(__workflow_accId);
                callPayload.Queries["category"] = Convert.ToString(3);
                callPayload.Queries["action"] = Convert.ToString("CREATE_OWH");
                callPayload.Queries["metaOnly"] = Convert.ToString(false);
                callPayload.Queries["matchingCondition"] = Convert.ToString("and");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NEWCONDITIONALMAILResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetMailAccountResponse
    {
        [JsonProperty("data")]
        public GetMailAccountResponseDataTypeItem[] Data { get; set; }
    }

    public class GetMailAccountResponseDataTypeItem
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountDisplayName")]
        public string AccountDisplayName { get; set; }
    }

    public class SendMailResponse
    {
        [JsonProperty("data")]
        public SendMailResponseDataType Data { get; set; }
    }

    public class SendMailResponseDataType
    {
        [JsonProperty("askReceipt")]
        public string AskReceipt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        [JsonProperty("bccAddress")]
        public string BccAddress { get; set; }

        [JsonProperty("mailFormat")]
        public string MailFormat { get; set; }

        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("ccAddress")]
        public string CcAddress { get; set; }
    }

    public class SendMailInput
    {
        [JsonProperty("fromAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromAddress { get; set; }

        [JsonProperty("toAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToAddress { get; set; }

        [JsonProperty("ccAddress")]
        public string CcAddress { get; set; }

        [JsonProperty("bccAddress")]
        public string BccAddress { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("askReceipt")]
        public SendMailInputAskReceiptType? AskReceipt { get; set; }

        [JsonProperty("mailFormat")]
        public SendMailInputMailFormatType? MailFormat { get; set; }

        [JsonProperty("attachmentDetails")]
        public SendMailInputAttachmentTypeItem[] Attachment { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMailInputAskReceiptType
    {
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMailInputMailFormatType
    {
        [EnumMember(Value = "html")]
        RichText,
        [EnumMember(Value = "plaintext")]
        PlainText
    }

    public class SendMailInputAttachmentTypeItem
    {
        [JsonProperty("attachmentContent")]
        public string AttachmentContent { get; set; }

        [JsonProperty("attachmentName")]
        public string AttachmentName { get; set; }
    }

    public class SaveDraftResponse
    {
        [JsonProperty("data")]
        public SaveDraftResponseDataType Data { get; set; }
    }

    public class SaveDraftResponseDataType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        [JsonProperty("bccAddress")]
        public string BccAddress { get; set; }

        [JsonProperty("mailFormat")]
        public string MailFormat { get; set; }

        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("ccAddress")]
        public string CcAddress { get; set; }
    }

    public class SaveDraftInput
    {
        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public SaveDraftInputModeType Mode { get; set; } = SaveDraftInputModeType.Draft;

        [JsonProperty("fromAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromAddress { get; set; }

        [JsonProperty("toAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToAddress { get; set; }

        [JsonProperty("ccAddress")]
        public string CcAddress { get; set; }

        [JsonProperty("bccAddress")]
        public string BccAddress { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("askReceipt")]
        public SaveDraftInputAskReceiptType? AskReceipt { get; set; }

        [JsonProperty("mailFormat")]
        public SaveDraftInputMailFormatType? MailFormat { get; set; }

        [JsonProperty("attachmentDetails")]
        public SaveDraftInputAttachmentTypeItem[] Attachment { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SaveDraftInputModeType
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "template")]
        Template
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SaveDraftInputAskReceiptType
    {
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SaveDraftInputMailFormatType
    {
        [EnumMember(Value = "html")]
        RichText,
        [EnumMember(Value = "plaintext")]
        PlainText
    }

    public class SaveDraftInputAttachmentTypeItem
    {
        [JsonProperty("attachmentContent")]
        public string AttachmentContent { get; set; }

        [JsonProperty("attachmentName")]
        public string AttachmentName { get; set; }
    }

    public class GetSenderDetailsResponse
    {
        [JsonProperty("sendMailDetails")]
        public GetSenderDetailsResponseSendMailDetailsTypeItem[] SendMailDetails { get; set; }
    }

    public class GetSenderDetailsResponseSendMailDetailsTypeItem
    {
        [JsonProperty("sendMailId")]
        public string SendMailId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }
    }

    public class SearchMailResponse
    {
        [JsonProperty("status")]
        public SearchMailResponseStatusType Status { get; set; }

        [JsonProperty("data")]
        public SearchMailResponseDataTypeItem[] Data { get; set; }
    }

    public class SearchMailResponseStatusType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class SearchMailResponseDataTypeItem
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("sentDateInGMT")]
        public string SentDateInGMT { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("hasInline")]
        public string HasInline { get; set; }

        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("ccAddress")]
        public string CcAddress { get; set; }

        [JsonProperty("hasAttachment")]
        public string HasAttachment { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("receivedTime")]
        public string ReceivedTime { get; set; }

        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SearchMailInput
    {
        [JsonProperty("entire")]
        public string Entire { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }

        [JsonProperty("fromDate")]
        public string FromDate { get; set; }

        [JsonProperty("toDate")]
        public string ToDate { get; set; }

        [JsonProperty("groupResult")]
        public bool? GroupResult { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetAllFolderResponse
    {
        [JsonProperty("data")]
        public GetAllFolderResponseDataTypeItem[] Data { get; set; }
    }

    public class GetAllFolderResponseDataTypeItem
    {
        [JsonProperty("folderName")]
        public string FolderName { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }
    }

    public class GetAllLabelResponse
    {
        [JsonProperty("data")]
        public GetAllLabelResponseDataTypeItem[] Data { get; set; }
    }

    public class GetAllLabelResponseDataTypeItem
    {
        [JsonProperty("labelId")]
        public string LabelId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class GetEmailContentResponse
    {
        [JsonProperty("data")]
        public GetEmailContentResponseDataType Data { get; set; }
    }

    public class GetEmailContentResponseDataType
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("sentDateInGMT")]
        public string SentDateInGMT { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("hasInline")]
        public string HasInline { get; set; }

        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("ccAddress")]
        public string CcAddress { get; set; }

        [JsonProperty("hasAttachment")]
        public string HasAttachment { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("receivedTime")]
        public string ReceivedTime { get; set; }

        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GetEmailAttachmentInfoResponse
    {
        [JsonProperty("data")]
        public GetEmailAttachmentInfoResponseDataType Data { get; set; }
    }

    public class GetEmailAttachmentInfoResponseDataType
    {
        [JsonProperty("attachments")]
        public GetEmailAttachmentInfoResponseDataTypeAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }

    public class GetEmailAttachmentInfoResponseDataTypeAttachmentsTypeItem
    {
        [JsonProperty("attachmentSize")]
        public int AttachmentSize { get; set; }

        [JsonProperty("attachmentName")]
        public string AttachmentName { get; set; }

        [JsonProperty("attachmentId")]
        public string AttachmentId { get; set; }
    }

    public class NewMailTriggerResponse
    {
        [JsonProperty("data")]
        public NewMailTriggerResponseDataType Data { get; set; }
    }

    public class NewMailTriggerResponseDataType
    {
        [JsonProperty("data")]
        public NewMailTriggerResponseDataTypeDataType Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class NewMailTriggerResponseDataTypeDataType
    {
        [JsonProperty("functionid")]
        public string Functionid { get; set; }

        [JsonProperty("FILTER_DATA")]
        public NewMailTriggerResponseDataTypeDataTypeFILTERDATAType FILTERDATA { get; set; }

        [JsonProperty("X-Hook-Secret")]
        public string XHookSecret { get; set; }

        [JsonProperty("functionName")]
        public string FunctionName { get; set; }

        [JsonProperty("metaOnly")]
        public bool MetaOnly { get; set; }

        [JsonProperty("integId")]
        public string IntegId { get; set; }

        [JsonProperty("webhookName")]
        public string WebhookName { get; set; }

        [JsonProperty("category")]
        public int Category { get; set; }

        [JsonProperty("webhookURL")]
        public string WebhookURL { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class NewMailTriggerResponseDataTypeDataTypeFILTERDATAType
    {
        [JsonProperty("filterId")]
        public string FilterId { get; set; }

        [JsonProperty("matchingCondition")]
        public string MatchingCondition { get; set; }

        [JsonProperty("fromDate")]
        public string FromDate { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("mailsCount")]
        public string MailsCount { get; set; }

        [JsonProperty("enable")]
        public bool Enable { get; set; }

        [JsonProperty("criterias")]
        public NewMailTriggerResponseDataTypeDataTypeFILTERDATATypeCriteriasTypeItem[] Criterias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("canDelete")]
        public bool CanDelete { get; set; }

        [JsonProperty("filterType")]
        public int FilterType { get; set; }

        [JsonProperty("actions")]
        public NewMailTriggerResponseDataTypeDataTypeFILTERDATATypeActionsType Actions { get; set; }

        [JsonProperty("forImport")]
        public bool ForImport { get; set; }
    }

    public class NewMailTriggerResponseDataTypeDataTypeFILTERDATATypeCriteriasTypeItem
    {
        [JsonProperty("criteriaId")]
        public string CriteriaId { get; set; }

        [JsonProperty("lhs")]
        public string Lhs { get; set; }

        [JsonProperty("rhs")]
        public string Rhs { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }
    }

    public class NewMailTriggerResponseDataTypeDataTypeFILTERDATATypeActionsType
    {
        [JsonProperty("outgoingWebhooks")]
        public NewMailTriggerResponseDataTypeDataTypeFILTERDATATypeActionsTypeOutgoingWebhooksType OutgoingWebhooks { get; set; }

        [JsonProperty("stopEvaluation")]
        public string StopEvaluation { get; set; }
    }

    public class NewMailTriggerResponseDataTypeDataTypeFILTERDATATypeActionsTypeOutgoingWebhooksType
    {
        [JsonProperty("integId")]
        public int IntegId { get; set; }

        [JsonProperty("zuid")]
        public int Zuid { get; set; }
    }

    public class NewMailTriggerInput
    {
        [JsonProperty("webhookURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class NEWCONDITIONALMAILResponse
    {
        [JsonProperty("data")]
        public NEWCONDITIONALMAILResponseDataType Data { get; set; }
    }

    public class NEWCONDITIONALMAILResponseDataType
    {
        [JsonProperty("data")]
        public NEWCONDITIONALMAILResponseDataTypeDataType Data { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class NEWCONDITIONALMAILResponseDataTypeDataType
    {
        [JsonProperty("functionid")]
        public string Functionid { get; set; }

        [JsonProperty("FILTER_DATA")]
        public NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATAType FILTERDATA { get; set; }

        [JsonProperty("X-Hook-Secret")]
        public string XHookSecret { get; set; }

        [JsonProperty("functionName")]
        public string FunctionName { get; set; }

        [JsonProperty("metaOnly")]
        public bool MetaOnly { get; set; }

        [JsonProperty("integId")]
        public string IntegId { get; set; }

        [JsonProperty("webhookName")]
        public string WebhookName { get; set; }

        [JsonProperty("category")]
        public int Category { get; set; }

        [JsonProperty("webhookURL")]
        public string WebhookURL { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATAType
    {
        [JsonProperty("filterId")]
        public string FilterId { get; set; }

        [JsonProperty("matchingCondition")]
        public string MatchingCondition { get; set; }

        [JsonProperty("fromDate")]
        public string FromDate { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("mailsCount")]
        public string MailsCount { get; set; }

        [JsonProperty("enable")]
        public bool Enable { get; set; }

        [JsonProperty("criterias")]
        public NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATATypeCriteriasTypeItem[] Criterias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("canDelete")]
        public bool CanDelete { get; set; }

        [JsonProperty("filterType")]
        public int FilterType { get; set; }

        [JsonProperty("actions")]
        public NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATATypeActionsType Actions { get; set; }

        [JsonProperty("forImport")]
        public bool ForImport { get; set; }
    }

    public class NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATATypeCriteriasTypeItem
    {
        [JsonProperty("criteriaId")]
        public string CriteriaId { get; set; }

        [JsonProperty("lhs")]
        public string Lhs { get; set; }

        [JsonProperty("rhs")]
        public string Rhs { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }
    }

    public class NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATATypeActionsType
    {
        [JsonProperty("outgoingWebhooks")]
        public NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATATypeActionsTypeOutgoingWebhooksType OutgoingWebhooks { get; set; }

        [JsonProperty("stopEvaluation")]
        public string StopEvaluation { get; set; }
    }

    public class NEWCONDITIONALMAILResponseDataTypeDataTypeFILTERDATATypeActionsTypeOutgoingWebhooksType
    {
        [JsonProperty("integId")]
        public int IntegId { get; set; }

        [JsonProperty("zuid")]
        public int Zuid { get; set; }
    }

    public class NEWCONDITIONALMAILInput
    {
        [JsonProperty("criterias", DefaultValueHandling = DefaultValueHandling.Include)]
        public NEWCONDITIONALMAILInputCriteriasTypeItem[] Criterias { get; set; }

        [JsonProperty("webhookURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";
    }

    public class NEWCONDITIONALMAILInputCriteriasTypeItem
    {
        [JsonProperty("lhs", DefaultValueHandling = DefaultValueHandling.Include)]
        public NEWCONDITIONALMAILInputCriteriasTypeItemLhsType Lhs { get; set; }

        [JsonProperty("operator", DefaultValueHandling = DefaultValueHandling.Include)]
        public NEWCONDITIONALMAILInputCriteriasTypeItemOperatorType Operator { get; set; }

        [JsonProperty("rhs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Rhs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NEWCONDITIONALMAILInputCriteriasTypeItemLhsType
    {
        [EnumMember(Value = "sender")]
        From,
        [EnumMember(Value = "deliveredTo")]
        DeliveredTo,
        [EnumMember(Value = "subject")]
        Subject,
        [EnumMember(Value = "cc")]
        Cc,
        [EnumMember(Value = "to/cc")]
        ToCc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NEWCONDITIONALMAILInputCriteriasTypeItemOperatorType
    {
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "doesnot contain")]
        DoesnotContain,
        [EnumMember(Value = "begins with")]
        BeginsWith,
        [EnumMember(Value = "ends with")]
        EndsWith,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "isnot")]
        Isnot
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zohomail;

    public partial class WorkflowManagedActions
    {
        public ZohomailActions Zohomail(string connectionId) => new ZohomailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZohomailTriggers Zohomail(string connectionId) => new ZohomailTriggers(connectionId);
    }
}