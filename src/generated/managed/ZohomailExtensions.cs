//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohomail
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_bodyfromAddress = bodyfromAddress == null ? null : WorkflowExpression.Compile(bodyfromAddress);
            WorkflowExpression.Validate(__workflow_bodyfromAddress, nameof(bodyfromAddress), required: true);
            var __workflow_bodytoAddress = bodytoAddress == null ? null : WorkflowExpression.Compile(bodytoAddress);
            WorkflowExpression.Validate(__workflow_bodytoAddress, nameof(bodytoAddress), required: true);
            var __workflow_bodyccAddress = bodyccAddress == null ? null : WorkflowExpression.Compile(bodyccAddress);
            WorkflowExpression.Validate(__workflow_bodyccAddress, nameof(bodyccAddress), required: false);
            var __workflow_bodybccAddress = bodybccAddress == null ? null : WorkflowExpression.Compile(bodybccAddress);
            WorkflowExpression.Validate(__workflow_bodybccAddress, nameof(bodybccAddress), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodycontent = bodycontent == null ? null : WorkflowExpression.Compile(bodycontent);
            WorkflowExpression.Validate(__workflow_bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyaskReceipt = bodyaskReceipt == null ? null : WorkflowExpression.Compile(bodyaskReceipt);
            WorkflowExpression.Validate(__workflow_bodyaskReceipt, nameof(bodyaskReceipt), required: false);
            var __workflow_bodymailFormat = bodymailFormat == null ? null : WorkflowExpression.Compile(bodymailFormat);
            WorkflowExpression.Validate(__workflow_bodymailFormat, nameof(bodymailFormat), required: false);
            var __workflow_bodyattachment = bodyattachment == null ? null : WorkflowExpression.Compile(bodyattachment);
            WorkflowExpression.Validate(__workflow_bodyattachment, nameof(bodyattachment), required: false);
            return new DeferredBodyAction<SendMailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fromAddress"] = ExpressionConverter.ConvertO(__workflow_bodyfromAddress);
                bodypropCount++;
                body["toAddress"] = ExpressionConverter.ConvertO(__workflow_bodytoAddress);
                if (__workflow_bodyccAddress != null)
                {
                    body["ccAddress"] = ExpressionConverter.ConvertO(__workflow_bodyccAddress);
                    bodypropCount++;
                }

                if (__workflow_bodybccAddress != null)
                {
                    body["bccAddress"] = ExpressionConverter.ConvertO(__workflow_bodybccAddress);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyaskReceipt != null)
                {
                    body["askReceipt"] = ExpressionConverter.ConvertO(__workflow_bodyaskReceipt);
                    bodypropCount++;
                }

                if (__workflow_bodymailFormat != null)
                {
                    body["mailFormat"] = ExpressionConverter.ConvertO(__workflow_bodymailFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyattachment != null)
                {
                    body["attachmentDetails"] = ExpressionConverter.ConvertO(__workflow_bodyattachment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SaveDraftResponse> SaveDraft(Expression<Func<string>> accountId, Expression<Func<bodymodeInput>> bodymode, Expression<Func<string>> bodyfromAddress, Expression<Func<string>> bodytoAddress, Expression<Func<string>> bodyccAddress = null, Expression<Func<string>> bodybccAddress = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodycontent = null, Expression<Func<bodyaskReceiptInput>> bodyaskReceipt = null, Expression<Func<bodymailFormatInput>> bodymailFormat = null, Expression<Func<bodyattachmentInputItem[]>> bodyattachment = null)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_bodymode = bodymode == null ? null : WorkflowExpression.Compile(bodymode);
            WorkflowExpression.Validate(__workflow_bodymode, nameof(bodymode), required: true);
            var __workflow_bodyfromAddress = bodyfromAddress == null ? null : WorkflowExpression.Compile(bodyfromAddress);
            WorkflowExpression.Validate(__workflow_bodyfromAddress, nameof(bodyfromAddress), required: true);
            var __workflow_bodytoAddress = bodytoAddress == null ? null : WorkflowExpression.Compile(bodytoAddress);
            WorkflowExpression.Validate(__workflow_bodytoAddress, nameof(bodytoAddress), required: true);
            var __workflow_bodyccAddress = bodyccAddress == null ? null : WorkflowExpression.Compile(bodyccAddress);
            WorkflowExpression.Validate(__workflow_bodyccAddress, nameof(bodyccAddress), required: false);
            var __workflow_bodybccAddress = bodybccAddress == null ? null : WorkflowExpression.Compile(bodybccAddress);
            WorkflowExpression.Validate(__workflow_bodybccAddress, nameof(bodybccAddress), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodycontent = bodycontent == null ? null : WorkflowExpression.Compile(bodycontent);
            WorkflowExpression.Validate(__workflow_bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyaskReceipt = bodyaskReceipt == null ? null : WorkflowExpression.Compile(bodyaskReceipt);
            WorkflowExpression.Validate(__workflow_bodyaskReceipt, nameof(bodyaskReceipt), required: false);
            var __workflow_bodymailFormat = bodymailFormat == null ? null : WorkflowExpression.Compile(bodymailFormat);
            WorkflowExpression.Validate(__workflow_bodymailFormat, nameof(bodymailFormat), required: false);
            var __workflow_bodyattachment = bodyattachment == null ? null : WorkflowExpression.Compile(bodyattachment);
            WorkflowExpression.Validate(__workflow_bodyattachment, nameof(bodyattachment), required: false);
            return new DeferredBodyAction<SaveDraftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages/draft", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                bodypropCount++;
                body["fromAddress"] = ExpressionConverter.ConvertO(__workflow_bodyfromAddress);
                bodypropCount++;
                body["toAddress"] = ExpressionConverter.ConvertO(__workflow_bodytoAddress);
                if (__workflow_bodyccAddress != null)
                {
                    body["ccAddress"] = ExpressionConverter.ConvertO(__workflow_bodyccAddress);
                    bodypropCount++;
                }

                if (__workflow_bodybccAddress != null)
                {
                    body["bccAddress"] = ExpressionConverter.ConvertO(__workflow_bodybccAddress);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyaskReceipt != null)
                {
                    body["askReceipt"] = ExpressionConverter.ConvertO(__workflow_bodyaskReceipt);
                    bodypropCount++;
                }

                if (__workflow_bodymailFormat != null)
                {
                    body["mailFormat"] = ExpressionConverter.ConvertO(__workflow_bodymailFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyattachment != null)
                {
                    body["attachmentDetails"] = ExpressionConverter.ConvertO(__workflow_bodyattachment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SaveDraftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetSenderDetailsResponse> GetSenderDetails(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<GetSenderDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSenderDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<SearchMailResponse> SearchMail(Expression<Func<string>> accountId, Expression<Func<int>> start, Expression<Func<int>> limit, Expression<Func<string>> bodyentire = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodysender = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycc = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileContent = null, Expression<Func<string>> bodyfromDate = null, Expression<Func<string>> bodytoDate = null, Expression<Func<bool>> bodygroupResult = null, Expression<Func<string>> bodyin = null, Expression<Func<string>> bodylabel = null)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: true);
            var __workflow_bodyentire = bodyentire == null ? null : WorkflowExpression.Compile(bodyentire);
            WorkflowExpression.Validate(__workflow_bodyentire, nameof(bodyentire), required: false);
            var __workflow_bodycontent = bodycontent == null ? null : WorkflowExpression.Compile(bodycontent);
            WorkflowExpression.Validate(__workflow_bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodysender = bodysender == null ? null : WorkflowExpression.Compile(bodysender);
            WorkflowExpression.Validate(__workflow_bodysender, nameof(bodysender), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycc = bodycc == null ? null : WorkflowExpression.Compile(bodycc);
            WorkflowExpression.Validate(__workflow_bodycc, nameof(bodycc), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileContent = bodyfileContent == null ? null : WorkflowExpression.Compile(bodyfileContent);
            WorkflowExpression.Validate(__workflow_bodyfileContent, nameof(bodyfileContent), required: false);
            var __workflow_bodyfromDate = bodyfromDate == null ? null : WorkflowExpression.Compile(bodyfromDate);
            WorkflowExpression.Validate(__workflow_bodyfromDate, nameof(bodyfromDate), required: false);
            var __workflow_bodytoDate = bodytoDate == null ? null : WorkflowExpression.Compile(bodytoDate);
            WorkflowExpression.Validate(__workflow_bodytoDate, nameof(bodytoDate), required: false);
            var __workflow_bodygroupResult = bodygroupResult == null ? null : WorkflowExpression.Compile(bodygroupResult);
            WorkflowExpression.Validate(__workflow_bodygroupResult, nameof(bodygroupResult), required: false);
            var __workflow_bodyin = bodyin == null ? null : WorkflowExpression.Compile(bodyin);
            WorkflowExpression.Validate(__workflow_bodyin, nameof(bodyin), required: false);
            var __workflow_bodylabel = bodylabel == null ? null : WorkflowExpression.Compile(bodylabel);
            WorkflowExpression.Validate(__workflow_bodylabel, nameof(bodylabel), required: false);
            return new DeferredBodyAction<SearchMailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/messages/search", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyentire != null)
                {
                    body["entire"] = ExpressionConverter.ConvertO(__workflow_bodyentire);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodysender != null)
                {
                    body["sender"] = ExpressionConverter.ConvertO(__workflow_bodysender);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodycc != null)
                {
                    body["cc"] = ExpressionConverter.ConvertO(__workflow_bodycc);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["fileName"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileContent != null)
                {
                    body["fileContent"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                    bodypropCount++;
                }

                if (__workflow_bodyfromDate != null)
                {
                    body["fromDate"] = ExpressionConverter.ConvertO(__workflow_bodyfromDate);
                    bodypropCount++;
                }

                if (__workflow_bodytoDate != null)
                {
                    body["toDate"] = ExpressionConverter.ConvertO(__workflow_bodytoDate);
                    bodypropCount++;
                }

                if (__workflow_bodygroupResult != null)
                {
                    body["groupResult"] = ExpressionConverter.ConvertO(__workflow_bodygroupResult);
                    bodypropCount++;
                }

                if (__workflow_bodyin != null)
                {
                    body["in"] = ExpressionConverter.ConvertO(__workflow_bodyin);
                    bodypropCount++;
                }

                if (__workflow_bodylabel != null)
                {
                    body["label"] = ExpressionConverter.ConvertO(__workflow_bodylabel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllFolderResponse> GetAllFolder(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<GetAllFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetAllLabelResponse> GetAllLabel(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<GetAllLabelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/labels", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailContentResponse> GetEmailContent(Expression<Func<string>> accountId, Expression<Func<string>> messageId)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<GetEmailContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeBlockContent"] = Convert.ToString(true);
                return new ApiConnectionAction<GetEmailContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<GetEmailAttachmentInfoResponse> GetEmailAttachmentInfo(Expression<Func<string>> accountId, Expression<Func<string>> messageId)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<GetEmailAttachmentInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachmentinfo", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEmailAttachmentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohomail")]
        public IBodyWorkflowAction<string> GetEmailAttachmentContent(Expression<Func<string>> accountId, Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var __workflow_accountId = accountId == null ? null : WorkflowExpression.Compile(accountId);
            WorkflowExpression.Validate(__workflow_accountId, nameof(accountId), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            var __workflow_attachmentId = attachmentId == null ? null : WorkflowExpression.Compile(attachmentId);
            WorkflowExpression.Validate(__workflow_attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/accounts/{0}/folders/1/messages/{1}/attachments/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ZohomailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMailTriggerResponse> NewMailTrigger(Expression<Func<string>> accId, Expression<Func<string>> criterias, FlowRecurrence recurrence = null)
        {
            var __workflow_accId = accId == null ? null : WorkflowExpression.Compile(accId);
            WorkflowExpression.Validate(__workflow_accId, nameof(accId), required: true);
            var __workflow_criterias = criterias == null ? null : WorkflowExpression.Compile(criterias);
            WorkflowExpression.Validate(__workflow_criterias, nameof(criterias), required: true);
            return new DeferredBodyTrigger<NewMailTriggerResponse>(() =>
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
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<NewMailTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NEWCONDITIONALMAILResponse> NEWCONDITIONALMAIL(Expression<Func<string>> accId, Expression<Func<bodycriteriasInputItem[]>> bodycriterias, FlowRecurrence recurrence = null)
        {
            var __workflow_accId = accId == null ? null : WorkflowExpression.Compile(accId);
            WorkflowExpression.Validate(__workflow_accId, nameof(accId), required: true);
            var __workflow_bodycriterias = bodycriterias == null ? null : WorkflowExpression.Compile(bodycriterias);
            WorkflowExpression.Validate(__workflow_bodycriterias, nameof(bodycriterias), required: true);
            return new DeferredBodyTrigger<NEWCONDITIONALMAILResponse>(() =>
            {
                var apiCallPath = "/integPlatform/api/outgoingconditionWebhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accId"] = ExpressionConverter.Convert(__workflow_accId);
                callPayload.Queries["category"] = Convert.ToString(3);
                callPayload.Queries["action"] = Convert.ToString("CREATE_OWH");
                callPayload.Queries["metaOnly"] = Convert.ToString(false);
                callPayload.Queries["matchingCondition"] = Convert.ToString("and");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["criterias"] = ExpressionConverter.ConvertO(__workflow_bodycriterias);
                body["webhookURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaskReceiptInput
    {
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
