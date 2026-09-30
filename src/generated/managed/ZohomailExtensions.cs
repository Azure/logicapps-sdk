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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMailAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SendMailResponse> SendMail([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyfromAddress, [WorkflowExpression] Func<string> bodytoAddress, [WorkflowExpression] Func<string> bodyccAddress = null, [WorkflowExpression] Func<string> bodybccAddress = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<bodyaskReceiptInput> bodyaskReceipt = null, [WorkflowExpression] Func<bodymailFormatInput> bodymailFormat = null, [WorkflowExpression] Func<bodyattachmentInputItem[]> bodyattachment = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(bodyfromAddress, nameof(bodyfromAddress), required: true);
            SourceExpression.Validate(bodytoAddress, nameof(bodytoAddress), required: true);
            SourceExpression.Validate(bodyccAddress, nameof(bodyccAddress), required: false);
            SourceExpression.Validate(bodybccAddress, nameof(bodybccAddress), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodyaskReceipt, nameof(bodyaskReceipt), required: false);
            SourceExpression.Validate(bodymailFormat, nameof(bodymailFormat), required: false);
            SourceExpression.Validate(bodyattachment, nameof(bodyattachment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fromAddress"] = SourceExpressionConverter.ConvertToken(bodyfromAddress);
                bodypropCount++;
                body["toAddress"] = SourceExpressionConverter.ConvertToken(bodytoAddress);
                if (bodyccAddress != null)
                {
                    body["ccAddress"] = SourceExpressionConverter.ConvertToken(bodyccAddress);
                    bodypropCount++;
                }

                if (bodybccAddress != null)
                {
                    body["bccAddress"] = SourceExpressionConverter.ConvertToken(bodybccAddress);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyaskReceipt != null)
                {
                    body["askReceipt"] = SourceExpressionConverter.Convert(bodyaskReceipt);
                    bodypropCount++;
                }

                if (bodymailFormat != null)
                {
                    body["mailFormat"] = SourceExpressionConverter.Convert(bodymailFormat);
                    bodypropCount++;
                }

                if (bodyattachment != null)
                {
                    body["attachmentDetails"] = SourceExpressionConverter.ConvertToken(bodyattachment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SaveDraftResponse> SaveDraft([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<bodymodeInput> bodymode, [WorkflowExpression] Func<string> bodyfromAddress, [WorkflowExpression] Func<string> bodytoAddress, [WorkflowExpression] Func<string> bodyccAddress = null, [WorkflowExpression] Func<string> bodybccAddress = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<bodyaskReceiptInput> bodyaskReceipt = null, [WorkflowExpression] Func<bodymailFormatInput> bodymailFormat = null, [WorkflowExpression] Func<bodyattachmentInputItem[]> bodyattachment = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(bodymode, nameof(bodymode), required: true);
            SourceExpression.Validate(bodyfromAddress, nameof(bodyfromAddress), required: true);
            SourceExpression.Validate(bodytoAddress, nameof(bodytoAddress), required: true);
            SourceExpression.Validate(bodyccAddress, nameof(bodyccAddress), required: false);
            SourceExpression.Validate(bodybccAddress, nameof(bodybccAddress), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodyaskReceipt, nameof(bodyaskReceipt), required: false);
            SourceExpression.Validate(bodymailFormat, nameof(bodymailFormat), required: false);
            SourceExpression.Validate(bodyattachment, nameof(bodyattachment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages/draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["mode"] = SourceExpressionConverter.Convert(bodymode);
                bodypropCount++;
                body["fromAddress"] = SourceExpressionConverter.ConvertToken(bodyfromAddress);
                bodypropCount++;
                body["toAddress"] = SourceExpressionConverter.ConvertToken(bodytoAddress);
                if (bodyccAddress != null)
                {
                    body["ccAddress"] = SourceExpressionConverter.ConvertToken(bodyccAddress);
                    bodypropCount++;
                }

                if (bodybccAddress != null)
                {
                    body["bccAddress"] = SourceExpressionConverter.ConvertToken(bodybccAddress);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyaskReceipt != null)
                {
                    body["askReceipt"] = SourceExpressionConverter.Convert(bodyaskReceipt);
                    bodypropCount++;
                }

                if (bodymailFormat != null)
                {
                    body["mailFormat"] = SourceExpressionConverter.Convert(bodymailFormat);
                    bodypropCount++;
                }

                if (bodyattachment != null)
                {
                    body["attachmentDetails"] = SourceExpressionConverter.ConvertToken(bodyattachment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SaveDraftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetSenderDetailsResponse> GetSenderDetails([WorkflowExpression] Func<string> accountId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSenderDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SearchMailResponse> SearchMail([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<int> start, [WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<string> bodyentire = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodysender = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycc = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<string> bodyfromDate = null, [WorkflowExpression] Func<string> bodytoDate = null, [WorkflowExpression] Func<bool> bodygroupResult = null, [WorkflowExpression] Func<string> bodyIn = null, [WorkflowExpression] Func<string> bodylabel = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(start, nameof(start), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: true);
            SourceExpression.Validate(bodyentire, nameof(bodyentire), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodysender, nameof(bodysender), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycc, nameof(bodycc), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            SourceExpression.Validate(bodyfromDate, nameof(bodyfromDate), required: false);
            SourceExpression.Validate(bodytoDate, nameof(bodytoDate), required: false);
            SourceExpression.Validate(bodygroupResult, nameof(bodygroupResult), required: false);
            SourceExpression.Validate(bodyIn, nameof(bodyIn), required: false);
            SourceExpression.Validate(bodylabel, nameof(bodylabel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyentire != null)
                {
                    body["entire"] = SourceExpressionConverter.ConvertToken(bodyentire);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodysender != null)
                {
                    body["sender"] = SourceExpressionConverter.ConvertToken(bodysender);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                if (bodycc != null)
                {
                    body["cc"] = SourceExpressionConverter.ConvertToken(bodycc);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["fileName"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["fileContent"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                    bodypropCount++;
                }

                if (bodyfromDate != null)
                {
                    body["fromDate"] = SourceExpressionConverter.ConvertToken(bodyfromDate);
                    bodypropCount++;
                }

                if (bodytoDate != null)
                {
                    body["toDate"] = SourceExpressionConverter.ConvertToken(bodytoDate);
                    bodypropCount++;
                }

                if (bodygroupResult != null)
                {
                    body["groupResult"] = SourceExpressionConverter.ConvertToken(bodygroupResult);
                    bodypropCount++;
                }

                if (bodyIn != null)
                {
                    body["in"] = SourceExpressionConverter.ConvertToken(bodyIn);
                    bodypropCount++;
                }

                if (bodylabel != null)
                {
                    body["label"] = SourceExpressionConverter.ConvertToken(bodylabel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchMailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllFolderResponse> GetAllFolder([WorkflowExpression] Func<string> accountId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllLabelResponse> GetAllLabel([WorkflowExpression] Func<string> accountId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/labels", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllLabelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailContentResponse> GetEmailContent([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeBlockContent"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<GetEmailContentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailAttachmentInfoResponse> GetEmailAttachmentInfo([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachmentinfo", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetEmailAttachmentInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<string> GetEmailAttachmentContent([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> attachmentId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachments/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class ZohomailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMailTriggerResponse> NewMailTrigger([WorkflowExpression] Func<string> accId, [WorkflowExpression] Func<string> criterias, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(accId, nameof(accId), required: true);
            SourceExpression.Validate(criterias, nameof(criterias), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integPlatform/api/outgoingWebhooks/newcriteriamail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accId"] = SourceExpressionConverter.ConvertO(accId);
                callPayload.Queries["category"] = Convert.ToString(3);
                callPayload.Queries["action"] = Convert.ToString("CREATE_OWH");
                callPayload.Queries["metaOnly"] = Convert.ToString(false);
                callPayload.Queries["matchingCondition"] = Convert.ToString("and");
                callPayload.Queries["criterias"] = SourceExpressionConverter.ConvertO(criterias);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<NewMailTriggerResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NEWCONDITIONALMAILResponse> NEWCONDITIONALMAIL([WorkflowExpression] Func<string> accId, [WorkflowExpression] Func<bodycriteriasInputItem[]> bodycriterias, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(accId, nameof(accId), required: true);
            SourceExpression.Validate(bodycriterias, nameof(bodycriterias), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integPlatform/api/outgoingconditionWebhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accId"] = SourceExpressionConverter.ConvertO(accId);
                callPayload.Queries["category"] = Convert.ToString(3);
                callPayload.Queries["action"] = Convert.ToString("CREATE_OWH");
                callPayload.Queries["metaOnly"] = Convert.ToString(false);
                callPayload.Queries["matchingCondition"] = Convert.ToString("and");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["criterias"] = SourceExpressionConverter.ConvertToken(bodycriterias);
                body["webhookURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<NEWCONDITIONALMAILResponse>(BuildSourceInput, triggerName, recurrence);
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