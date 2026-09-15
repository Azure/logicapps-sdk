//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohomail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohomailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetMailAccountResponse> GetMailAccount()
        {
            var apiCallPath = "/api/accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMailAccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SendMailResponse> SendMail(Expression<Func<string>> accountId, Expression<Func<string>> bodyfromAddress, Expression<Func<string>> bodytoAddress, Expression<Func<string>> bodyccAddress = null, Expression<Func<string>> bodybccAddress = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodycontent = null, Expression<Func<bodyaskReceiptInput>> bodyaskReceipt = null, Expression<Func<bodymailFormatInput>> bodymailFormat = null, Expression<Func<bodyattachmentInputItem[]>> bodyattachment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fromAddress"] = CSharpExpressionConverter.ConvertToken(bodyfromAddress);
            bodypropCount++;
            body["toAddress"] = CSharpExpressionConverter.ConvertToken(bodytoAddress);
            if (bodyccAddress != null)
            {
                body["ccAddress"] = CSharpExpressionConverter.ConvertToken(bodyccAddress);
                bodypropCount++;
            }

            if (bodybccAddress != null)
            {
                body["bccAddress"] = CSharpExpressionConverter.ConvertToken(bodybccAddress);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
            }

            if (bodyaskReceipt != null)
            {
                body["askReceipt"] = CSharpExpressionConverter.Convert(bodyaskReceipt);
                bodypropCount++;
            }

            if (bodymailFormat != null)
            {
                body["mailFormat"] = CSharpExpressionConverter.Convert(bodymailFormat);
                bodypropCount++;
            }

            if (bodyattachment != null)
            {
                body["attachmentDetails"] = CSharpExpressionConverter.ConvertToken(bodyattachment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SaveDraftResponse> SaveDraft(Expression<Func<string>> accountId, Expression<Func<bodymodeInput>> bodymode, Expression<Func<string>> bodyfromAddress, Expression<Func<string>> bodytoAddress, Expression<Func<string>> bodyccAddress = null, Expression<Func<string>> bodybccAddress = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodycontent = null, Expression<Func<bodyaskReceiptInput>> bodyaskReceipt = null, Expression<Func<bodymailFormatInput>> bodymailFormat = null, Expression<Func<bodyattachmentInputItem[]>> bodyattachment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages/draft", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["mode"] = CSharpExpressionConverter.Convert(bodymode);
            bodypropCount++;
            body["fromAddress"] = CSharpExpressionConverter.ConvertToken(bodyfromAddress);
            bodypropCount++;
            body["toAddress"] = CSharpExpressionConverter.ConvertToken(bodytoAddress);
            if (bodyccAddress != null)
            {
                body["ccAddress"] = CSharpExpressionConverter.ConvertToken(bodyccAddress);
                bodypropCount++;
            }

            if (bodybccAddress != null)
            {
                body["bccAddress"] = CSharpExpressionConverter.ConvertToken(bodybccAddress);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
            }

            if (bodyaskReceipt != null)
            {
                body["askReceipt"] = CSharpExpressionConverter.Convert(bodyaskReceipt);
                bodypropCount++;
            }

            if (bodymailFormat != null)
            {
                body["mailFormat"] = CSharpExpressionConverter.Convert(bodymailFormat);
                bodypropCount++;
            }

            if (bodyattachment != null)
            {
                body["attachmentDetails"] = CSharpExpressionConverter.ConvertToken(bodyattachment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SaveDraftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetSenderDetailsResponse> GetSenderDetails(Expression<Func<string>> accountId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSenderDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SearchMailResponse> SearchMail(Expression<Func<string>> accountId, Expression<Func<int>> start, Expression<Func<int>> limit, Expression<Func<string>> bodyentire = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodysender = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycc = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string>> bodyfromDate = null, Expression<Func<string>> bodytoDate = null, Expression<Func<bool>> bodygroupResult = null, Expression<Func<string>> bodyin = null, Expression<Func<string>> bodylabel = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages/search", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["start"] = CSharpExpressionConverter.ConvertO(start);
            callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentire != null)
            {
                body["entire"] = CSharpExpressionConverter.ConvertToken(bodyentire);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
            }

            if (bodysender != null)
            {
                body["sender"] = CSharpExpressionConverter.ConvertToken(bodysender);
                bodypropCount++;
            }

            if (bodyto != null)
            {
                body["to"] = CSharpExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
            }

            if (bodycc != null)
            {
                body["cc"] = CSharpExpressionConverter.ConvertToken(bodycc);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["fileName"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileContent != null)
            {
                body["fileContent"] = CSharpExpressionConverter.ConvertToken(bodyfileContent);
                bodypropCount++;
            }

            if (bodyfromDate != null)
            {
                body["fromDate"] = CSharpExpressionConverter.ConvertToken(bodyfromDate);
                bodypropCount++;
            }

            if (bodytoDate != null)
            {
                body["toDate"] = CSharpExpressionConverter.ConvertToken(bodytoDate);
                bodypropCount++;
            }

            if (bodygroupResult != null)
            {
                body["groupResult"] = CSharpExpressionConverter.ConvertToken(bodygroupResult);
                bodypropCount++;
            }

            if (bodyin != null)
            {
                body["in"] = CSharpExpressionConverter.ConvertToken(bodyin);
                bodypropCount++;
            }

            if (bodylabel != null)
            {
                body["label"] = CSharpExpressionConverter.ConvertToken(bodylabel);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchMailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllFolderResponse> GetAllFolder(Expression<Func<string>> accountId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllLabelResponse> GetAllLabel(Expression<Func<string>> accountId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/labels", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailContentResponse> GetEmailContent(Expression<Func<string>> accountId, Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/content", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeBlockContent"] = Convert.ToString(true);
            return new ApiConnectionAction<GetEmailContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailAttachmentInfoResponse> GetEmailAttachmentInfo(Expression<Func<string>> accountId, Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachmentinfo", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEmailAttachmentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<string> GetEmailAttachmentContent(Expression<Func<string>> accountId, Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachments/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ZohomailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMailTriggerResponse> NewMailTrigger(Expression<Func<string>> accId, Expression<Func<string>> criterias, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integPlatform/api/outgoingWebhooks/newcriteriamail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accId"] = CSharpExpressionConverter.ConvertO(accId);
            callPayload.Queries["category"] = Convert.ToString(3);
            callPayload.Queries["action"] = Convert.ToString("CREATE_OWH");
            callPayload.Queries["metaOnly"] = Convert.ToString(false);
            callPayload.Queries["matchingCondition"] = Convert.ToString("and");
            callPayload.Queries["criterias"] = CSharpExpressionConverter.ConvertO(criterias);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookURL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NewMailTriggerResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NEWCONDITIONALMAILResponse> NEWCONDITIONALMAIL(Expression<Func<string>> accId, Expression<Func<bodycriteriasInputItem[]>> bodycriterias, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/integPlatform/api/outgoingconditionWebhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accId"] = CSharpExpressionConverter.ConvertO(accId);
            callPayload.Queries["category"] = Convert.ToString(3);
            callPayload.Queries["action"] = Convert.ToString("CREATE_OWH");
            callPayload.Queries["metaOnly"] = Convert.ToString(false);
            callPayload.Queries["matchingCondition"] = Convert.ToString("and");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["criterias"] = CSharpExpressionConverter.ConvertToken(bodycriterias);
            body["webhookURL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NEWCONDITIONALMAILResponse>(callPayload, triggerName, recurrence);
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

    public enum bodyaskReceiptInput
    {
        No,
        Yes
    }

    public enum bodymailFormatInput
    {
        [EnumMember(Value = "html")]
        RichText,
        [EnumMember(Value = "plaintext")]
        PlainText
    }

    public class bodyattachmentInputItem
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

    public enum bodymodeInput
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "template")]
        Template
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
        public string MessageID { get; set; }
    }

    public class GetEmailAttachmentInfoResponseDataTypeAttachmentsTypeItem
    {
        [JsonProperty("attachmentSize")]
        public int AttachmentSize { get; set; }

        [JsonProperty("attachmentName")]
        public string AttachmentName { get; set; }

        [JsonProperty("attachmentId")]
        public string AttachmentID { get; set; }
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

    public class bodycriteriasInputItem
    {
        [JsonProperty("lhs")]
        public bodycriteriasInputItemLhsType Lhs { get; set; }

        [JsonProperty("operator")]
        public bodycriteriasInputItemOperatorType Operator { get; set; }

        [JsonProperty("rhs")]
        public string Rhs { get; set; }
    }

    public enum bodycriteriasInputItemLhsType
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

    public enum bodycriteriasInputItemOperatorType
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