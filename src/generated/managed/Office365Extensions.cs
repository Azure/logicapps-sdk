//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Office365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphOutlookCategory[]> GetOutlookCategoryNames()
        {
            var apiCallPath = "/Categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphOutlookCategory[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<OutlookReceiveMessage> DraftEmail(Expression<Func<string>> draftMessageto, Expression<Func<string>> draftMessagesubject, Expression<Func<string>> draftMessagebody, Expression<Func<string>> draftMessagefromSendAs = null, Expression<Func<string>> draftMessagecC = null, Expression<Func<string>> draftMessagebCC = null, Expression<Func<ClientSendAttachment[]>> draftMessageattachments = null, Expression<Func<string>> draftMessagesensitivity = null, Expression<Func<string>> draftMessagereplyTo = null, Expression<Func<draftMessageimportanceInput>> draftMessageimportance = null, Expression<Func<string>> messageId = null, Expression<Func<string>> draftType = null, Expression<Func<string>> comment = null)
        {
            var apiCallPath = "/Draft";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (messageId != null)
                callPayload.Queries["messageId"] = CSharpExpressionConverter.ConvertO(messageId);
            if (draftType != null)
                callPayload.Queries["draftType"] = CSharpExpressionConverter.ConvertO(draftType);
            if (comment != null)
                callPayload.Queries["comment"] = CSharpExpressionConverter.ConvertO(comment);
            var draftMessage = new JObject();
            var draftMessagepropCount = 0;
            draftMessagepropCount++;
            draftMessage["To"] = CSharpExpressionConverter.ConvertToken(draftMessageto);
            draftMessagepropCount++;
            draftMessage["Subject"] = CSharpExpressionConverter.ConvertToken(draftMessagesubject);
            draftMessagepropCount++;
            draftMessage["Body"] = CSharpExpressionConverter.ConvertToken(draftMessagebody);
            if (draftMessagefromSendAs != null)
            {
                draftMessage["From"] = CSharpExpressionConverter.ConvertToken(draftMessagefromSendAs);
                draftMessagepropCount++;
            }

            if (draftMessagecC != null)
            {
                draftMessage["Cc"] = CSharpExpressionConverter.ConvertToken(draftMessagecC);
                draftMessagepropCount++;
            }

            if (draftMessagebCC != null)
            {
                draftMessage["Bcc"] = CSharpExpressionConverter.ConvertToken(draftMessagebCC);
                draftMessagepropCount++;
            }

            if (draftMessageattachments != null)
            {
                draftMessage["Attachments"] = CSharpExpressionConverter.ConvertToken(draftMessageattachments);
                draftMessagepropCount++;
            }

            if (draftMessagesensitivity != null)
            {
                draftMessage["Sensitivity"] = CSharpExpressionConverter.ConvertToken(draftMessagesensitivity);
                draftMessagepropCount++;
            }

            if (draftMessagereplyTo != null)
            {
                draftMessage["ReplyTo"] = CSharpExpressionConverter.ConvertToken(draftMessagereplyTo);
                draftMessagepropCount++;
            }

            if (draftMessageimportance != null)
            {
                if (draftMessageimportance != null)
                {
                    draftMessage["Importance"] = CSharpExpressionConverter.Convert(draftMessageimportance);
                    draftMessagepropCount++;
                }

                draftMessagepropCount++;
            }
            else
            {
                draftMessage["Importance"] = "Normal";
                draftMessagepropCount++;
            }

            if (draftMessagepropCount > 0)
            {
                callPayload.Body = draftMessage;
            }

            return new ApiConnectionAction<OutlookReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateDraftEmail(Expression<Func<string>> draftMessageto, Expression<Func<string>> draftMessagesubject, Expression<Func<string>> draftMessagebody, Expression<Func<string>> messageId, Expression<Func<string>> draftMessagefromSendAs = null, Expression<Func<string>> draftMessagecC = null, Expression<Func<string>> draftMessagebCC = null, Expression<Func<ClientSendAttachment[]>> draftMessageattachments = null, Expression<Func<string>> draftMessagesensitivity = null, Expression<Func<string>> draftMessagereplyTo = null, Expression<Func<draftMessageimportanceInput>> draftMessageimportance = null)
        {
            var apiCallPath = "/Draft";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["messageId"] = CSharpExpressionConverter.ConvertO(messageId);
            var draftMessage = new JObject();
            var draftMessagepropCount = 0;
            draftMessagepropCount++;
            draftMessage["To"] = CSharpExpressionConverter.ConvertToken(draftMessageto);
            draftMessagepropCount++;
            draftMessage["Subject"] = CSharpExpressionConverter.ConvertToken(draftMessagesubject);
            draftMessagepropCount++;
            draftMessage["Body"] = CSharpExpressionConverter.ConvertToken(draftMessagebody);
            if (draftMessagefromSendAs != null)
            {
                draftMessage["From"] = CSharpExpressionConverter.ConvertToken(draftMessagefromSendAs);
                draftMessagepropCount++;
            }

            if (draftMessagecC != null)
            {
                draftMessage["Cc"] = CSharpExpressionConverter.ConvertToken(draftMessagecC);
                draftMessagepropCount++;
            }

            if (draftMessagebCC != null)
            {
                draftMessage["Bcc"] = CSharpExpressionConverter.ConvertToken(draftMessagebCC);
                draftMessagepropCount++;
            }

            if (draftMessageattachments != null)
            {
                draftMessage["Attachments"] = CSharpExpressionConverter.ConvertToken(draftMessageattachments);
                draftMessagepropCount++;
            }

            if (draftMessagesensitivity != null)
            {
                draftMessage["Sensitivity"] = CSharpExpressionConverter.ConvertToken(draftMessagesensitivity);
                draftMessagepropCount++;
            }

            if (draftMessagereplyTo != null)
            {
                draftMessage["ReplyTo"] = CSharpExpressionConverter.ConvertToken(draftMessagereplyTo);
                draftMessagepropCount++;
            }

            if (draftMessageimportance != null)
            {
                if (draftMessageimportance != null)
                {
                    draftMessage["Importance"] = CSharpExpressionConverter.Convert(draftMessageimportance);
                    draftMessagepropCount++;
                }

                draftMessagepropCount++;
            }
            else
            {
                draftMessage["Importance"] = "Normal";
                draftMessagepropCount++;
            }

            if (draftMessagepropCount > 0)
            {
                callPayload.Body = draftMessage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendDraftEmail(Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Draft/Send/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction AssignCategory(Expression<Func<string>> messageId, Expression<Func<string>> category)
        {
            var apiCallPath = "/Mail/Category";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["messageId"] = CSharpExpressionConverter.ConvertO(messageId);
            callPayload.Queries["category"] = CSharpExpressionConverter.ConvertO(category);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchOperationResult> AssignCategoryBulk(Expression<Func<string>> categoryName, Expression<Func<string[]>> messageIds = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/Category/Bulk/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(messageIds);
            return new ApiConnectionAction<BatchOperationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<string>> optionsEmailSubscriptionmessageto, Expression<Func<string>> optionsEmailSubscriptionmessagesubject = null, Expression<Func<string>> optionsEmailSubscriptionmessageuserOptions = null, Expression<Func<string>> optionsEmailSubscriptionmessageheaderText = null, Expression<Func<string>> optionsEmailSubscriptionmessageselectionText = null, Expression<Func<string>> optionsEmailSubscriptionmessagebody = null, Expression<Func<optionsEmailSubscriptionmessageimportanceInput>> optionsEmailSubscriptionmessageimportance = null, Expression<Func<ClientSendAttachment[]>> optionsEmailSubscriptionmessageattachments = null, Expression<Func<bool>> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessagehideHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null, Expression<Func<bool>> optionsEmailSubscriptionmessagehideMicrosoftFooter = null)
        {
            var apiCallPath = "/mailwithoptions/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var optionsEmailSubscription = new JObject();
            var optionsEmailSubscriptionpropCount = 0;
            optionsEmailSubscription["NotificationUrl"] = "@listCallbackUrl()";
            optionsEmailSubscriptionpropCount++;
            var messageObject = new JObject();
            var messageObjectpropCount = 0;
            messageObjectpropCount++;
            messageObject["To"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageto);
            if (optionsEmailSubscriptionmessagesubject != null)
            {
                if (optionsEmailSubscriptionmessagesubject != null)
                {
                    messageObject["Subject"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagesubject);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["Subject"] = "Your input is required";
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageuserOptions != null)
            {
                if (optionsEmailSubscriptionmessageuserOptions != null)
                {
                    messageObject["Options"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuserOptions);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["Options"] = "Choice1, Choice2, Choice3";
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageheaderText != null)
            {
                messageObject["HeaderText"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageheaderText);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageselectionText != null)
            {
                messageObject["SelectionText"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageselectionText);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessagebody != null)
            {
                messageObject["Body"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagebody);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageimportance != null)
            {
                if (optionsEmailSubscriptionmessageimportance != null)
                {
                    messageObject["Importance"] = CSharpExpressionConverter.Convert(optionsEmailSubscriptionmessageimportance);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["Importance"] = "Normal";
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageattachments != null)
            {
                messageObject["Attachments"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageattachments);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageuseOnlyHTMLMessage != null)
            {
                messageObject["UseOnlyHTMLMessage"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuseOnlyHTMLMessage);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
            {
                if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    messageObject["HideHTMLMessage"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagehideHTMLMessage);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["HideHTMLMessage"] = false;
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
            {
                if (optionsEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                {
                    messageObject["ShowHTMLConfirmationDialog"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["ShowHTMLConfirmationDialog"] = false;
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessagehideMicrosoftFooter != null)
            {
                if (optionsEmailSubscriptionmessagehideMicrosoftFooter != null)
                {
                    messageObject["HideMicrosoftFooter"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagehideMicrosoftFooter);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["HideMicrosoftFooter"] = false;
                messageObjectpropCount++;
            }

            if (messageObjectpropCount > 0)
            {
                optionsEmailSubscription["Message"] = messageObject;
                optionsEmailSubscriptionpropCount++;
            }

            if (optionsEmailSubscriptionpropCount > 0)
            {
                callPayload.Body = optionsEmailSubscription;
            }

            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail(Expression<Func<string>> approvalEmailSubscriptionmessageto, Expression<Func<string>> approvalEmailSubscriptionmessagesubject = null, Expression<Func<string>> approvalEmailSubscriptionmessageuserOptions = null, Expression<Func<string>> approvalEmailSubscriptionmessageheaderText = null, Expression<Func<string>> approvalEmailSubscriptionmessageselectionText = null, Expression<Func<string>> approvalEmailSubscriptionmessagebody = null, Expression<Func<approvalEmailSubscriptionmessageimportanceInput>> approvalEmailSubscriptionmessageimportance = null, Expression<Func<ClientSendAttachment[]>> approvalEmailSubscriptionmessageattachments = null, Expression<Func<bool>> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionmessagehideHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            var apiCallPath = "/approvalmail/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var approvalEmailSubscription = new JObject();
            var approvalEmailSubscriptionpropCount = 0;
            approvalEmailSubscription["NotificationUrl"] = "@listCallbackUrl()";
            approvalEmailSubscriptionpropCount++;
            var messageObject = new JObject();
            var messageObjectpropCount = 0;
            messageObjectpropCount++;
            messageObject["To"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageto);
            if (approvalEmailSubscriptionmessagesubject != null)
            {
                if (approvalEmailSubscriptionmessagesubject != null)
                {
                    messageObject["Subject"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagesubject);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["Subject"] = "Approval Request";
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageuserOptions != null)
            {
                if (approvalEmailSubscriptionmessageuserOptions != null)
                {
                    messageObject["Options"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuserOptions);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["Options"] = "Approve, Reject";
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageheaderText != null)
            {
                messageObject["HeaderText"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageheaderText);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageselectionText != null)
            {
                messageObject["SelectionText"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageselectionText);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessagebody != null)
            {
                messageObject["Body"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagebody);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageimportance != null)
            {
                if (approvalEmailSubscriptionmessageimportance != null)
                {
                    messageObject["Importance"] = CSharpExpressionConverter.Convert(approvalEmailSubscriptionmessageimportance);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["Importance"] = "Normal";
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageattachments != null)
            {
                messageObject["Attachments"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageattachments);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageuseOnlyHTMLMessage != null)
            {
                messageObject["UseOnlyHTMLMessage"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuseOnlyHTMLMessage);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
            {
                if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    messageObject["HideHTMLMessage"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagehideHTMLMessage);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["HideHTMLMessage"] = false;
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
            {
                if (approvalEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                {
                    messageObject["ShowHTMLConfirmationDialog"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog);
                    messageObjectpropCount++;
                }

                messageObjectpropCount++;
            }
            else
            {
                messageObject["ShowHTMLConfirmationDialog"] = false;
                messageObjectpropCount++;
            }

            if (messageObjectpropCount > 0)
            {
                approvalEmailSubscription["Message"] = messageObject;
                approvalEmailSubscriptionpropCount++;
            }

            if (approvalEmailSubscriptionpropCount > 0)
            {
                callPayload.Body = approvalEmailSubscription;
            }

            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateMyContactPhoto(Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}/photo/$value", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("image/jpeg");
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var apiCallPath = "/codeless/httprequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Uri"] = CSharpExpressionConverter.ConvertO(uri);
            callPayload.Headers["Method"] = CSharpExpressionConverter.Convert(method);
            callPayload.Headers["ContentType"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["ContentType"] = CSharpExpressionConverter.ConvertO(contentType);
            if (customHeader1 != null)
                callPayload.Headers["CustomHeader1"] = CSharpExpressionConverter.ConvertO(customHeader1);
            if (customHeader2 != null)
                callPayload.Headers["CustomHeader2"] = CSharpExpressionConverter.ConvertO(customHeader2);
            if (customHeader3 != null)
                callPayload.Headers["CustomHeader3"] = CSharpExpressionConverter.ConvertO(customHeader3);
            if (customHeader4 != null)
                callPayload.Headers["CustomHeader4"] = CSharpExpressionConverter.ConvertO(customHeader4);
            if (customHeader5 != null)
                callPayload.Headers["CustomHeader5"] = CSharpExpressionConverter.ConvertO(customHeader5);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpEmailsManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = "/mcp/EmailsManagement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = CSharpExpressionConverter.ConvertToken(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = CSharpExpressionConverter.ConvertToken(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = CSharpExpressionConverter.ConvertToken(queryRequestmethod);
                queryRequestpropCount++;
            }

            var @paramsObject = new JObject();
            var @paramsObjectpropCount = 0;
            if (@paramsObjectpropCount > 0)
            {
                queryRequest["params"] = @paramsObject;
                queryRequestpropCount++;
            }

            var resultObject = new JObject();
            var resultObjectpropCount = 0;
            if (resultObjectpropCount > 0)
            {
                queryRequest["result"] = resultObject;
                queryRequestpropCount++;
            }

            var errorObject = new JObject();
            var errorObjectpropCount = 0;
            if (errorObjectpropCount > 0)
            {
                queryRequest["error"] = errorObject;
                queryRequestpropCount++;
            }

            if (queryRequestpropCount > 0)
            {
                callPayload.Body = queryRequest;
            }

            return new ApiConnectionAction<MCPQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpMeetingManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = "/mcp/MeetingManagement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = CSharpExpressionConverter.ConvertToken(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = CSharpExpressionConverter.ConvertToken(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = CSharpExpressionConverter.ConvertToken(queryRequestmethod);
                queryRequestpropCount++;
            }

            var @paramsObject = new JObject();
            var @paramsObjectpropCount = 0;
            if (@paramsObjectpropCount > 0)
            {
                queryRequest["params"] = @paramsObject;
                queryRequestpropCount++;
            }

            var resultObject = new JObject();
            var resultObjectpropCount = 0;
            if (resultObjectpropCount > 0)
            {
                queryRequest["result"] = resultObject;
                queryRequestpropCount++;
            }

            var errorObject = new JObject();
            var errorObjectpropCount = 0;
            if (errorObjectpropCount > 0)
            {
                queryRequest["error"] = errorObject;
                queryRequestpropCount++;
            }

            if (queryRequestpropCount > 0)
            {
                callPayload.Body = queryRequest;
            }

            return new ApiConnectionAction<MCPQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpContactsManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = "/mcp/ContactsManagement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sessionId != null)
                callPayload.Queries["sessionId"] = CSharpExpressionConverter.ConvertO(sessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = CSharpExpressionConverter.ConvertToken(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = CSharpExpressionConverter.ConvertToken(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = CSharpExpressionConverter.ConvertToken(queryRequestmethod);
                queryRequestpropCount++;
            }

            var @paramsObject = new JObject();
            var @paramsObjectpropCount = 0;
            if (@paramsObjectpropCount > 0)
            {
                queryRequest["params"] = @paramsObject;
                queryRequestpropCount++;
            }

            var resultObject = new JObject();
            var resultObjectpropCount = 0;
            if (resultObjectpropCount > 0)
            {
                queryRequest["result"] = resultObject;
                queryRequestpropCount++;
            }

            var errorObject = new JObject();
            var errorObjectpropCount = 0;
            if (errorObjectpropCount > 0)
            {
                queryRequest["error"] = errorObject;
                queryRequestpropCount++;
            }

            if (queryRequestpropCount > 0)
            {
                callPayload.Body = queryRequest;
            }

            return new ApiConnectionAction<MCPQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction CalendarDeleteItem(Expression<Func<string>> calendar, Expression<Func<string>> @event)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/calendars/{0}/events/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendar, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(@event, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventListClientReceive> CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<GraphCalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<CalendarGetTablesV2Response> CalendarGetTables()
        {
            var apiCallPath = "/codeless/v1.0/me/calendars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["skip"] = Convert.ToString(0);
            callPayload.Queries["top"] = Convert.ToString(256);
            callPayload.Queries["orderBy"] = Convert.ToString("name");
            return new ApiConnectionAction<CalendarGetTablesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<itemselectedDaysOfWeekInputItem[]>> itemselectedDaysOfWeek = null, Expression<Func<string>> itemrecurrenceEndDate = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<bool>> itemisReminderOn = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null, Expression<Func<itemsensitivityInput>> itemsensitivity = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            itempropCount++;
            item["subject"] = CSharpExpressionConverter.ConvertToken(itemsubject);
            itempropCount++;
            item["start"] = CSharpExpressionConverter.ConvertToken(itemstartTime);
            itempropCount++;
            item["end"] = CSharpExpressionConverter.ConvertToken(itemendTime);
            itempropCount++;
            item["timeZone"] = CSharpExpressionConverter.Convert(itemtimeZone);
            if (itemrequiredAttendees != null)
            {
                item["requiredAttendees"] = CSharpExpressionConverter.ConvertToken(itemrequiredAttendees);
                itempropCount++;
            }

            if (itemoptionalAttendees != null)
            {
                item["optionalAttendees"] = CSharpExpressionConverter.ConvertToken(itemoptionalAttendees);
                itempropCount++;
            }

            if (itemresourceAttendees != null)
            {
                item["resourceAttendees"] = CSharpExpressionConverter.ConvertToken(itemresourceAttendees);
                itempropCount++;
            }

            if (itembody != null)
            {
                item["body"] = CSharpExpressionConverter.ConvertToken(itembody);
                itempropCount++;
            }

            if (itemcategories != null)
            {
                item["categories"] = CSharpExpressionConverter.ConvertToken(itemcategories);
                itempropCount++;
            }

            if (itemlocation != null)
            {
                item["location"] = CSharpExpressionConverter.ConvertToken(itemlocation);
                itempropCount++;
            }

            if (itemimportance != null)
            {
                item["importance"] = CSharpExpressionConverter.Convert(itemimportance);
                itempropCount++;
            }

            if (itemisAllDayEvent != null)
            {
                item["isAllDay"] = CSharpExpressionConverter.ConvertToken(itemisAllDayEvent);
                itempropCount++;
            }

            if (itemrecurrence != null)
            {
                item["recurrence"] = CSharpExpressionConverter.Convert(itemrecurrence);
                itempropCount++;
            }

            if (itemselectedDaysOfWeek != null)
            {
                item["selectedDaysOfWeek"] = CSharpExpressionConverter.ConvertToken(itemselectedDaysOfWeek);
                itempropCount++;
            }

            if (itemrecurrenceEndDate != null)
            {
                item["recurrenceEnd"] = CSharpExpressionConverter.ConvertToken(itemrecurrenceEndDate);
                itempropCount++;
            }

            if (itemnumberOfOccurrences != null)
            {
                item["numberOfOccurences"] = CSharpExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                itempropCount++;
            }

            if (itemreminder != null)
            {
                item["reminderMinutesBeforeStart"] = CSharpExpressionConverter.ConvertToken(itemreminder);
                itempropCount++;
            }

            if (itemisReminderOn != null)
            {
                item["isReminderOn"] = CSharpExpressionConverter.ConvertToken(itemisReminderOn);
                itempropCount++;
            }

            if (itemshowAs != null)
            {
                item["showAs"] = CSharpExpressionConverter.Convert(itemshowAs);
                itempropCount++;
            }

            if (itemresponseRequested != null)
            {
                item["responseRequested"] = CSharpExpressionConverter.ConvertToken(itemresponseRequested);
                itempropCount++;
            }

            if (itemsensitivity != null)
            {
                item["sensitivity"] = CSharpExpressionConverter.Convert(itemsensitivity);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarPostItem(Expression<Func<string>> table, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<itemselectedDaysOfWeekInputItem[]>> itemselectedDaysOfWeek = null, Expression<Func<string>> itemrecurrenceEndDate = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<bool>> itemisReminderOn = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null, Expression<Func<itemsensitivityInput>> itemsensitivity = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            itempropCount++;
            item["subject"] = CSharpExpressionConverter.ConvertToken(itemsubject);
            itempropCount++;
            item["start"] = CSharpExpressionConverter.ConvertToken(itemstartTime);
            itempropCount++;
            item["end"] = CSharpExpressionConverter.ConvertToken(itemendTime);
            itempropCount++;
            item["timeZone"] = CSharpExpressionConverter.Convert(itemtimeZone);
            if (itemrequiredAttendees != null)
            {
                item["requiredAttendees"] = CSharpExpressionConverter.ConvertToken(itemrequiredAttendees);
                itempropCount++;
            }

            if (itemoptionalAttendees != null)
            {
                item["optionalAttendees"] = CSharpExpressionConverter.ConvertToken(itemoptionalAttendees);
                itempropCount++;
            }

            if (itemresourceAttendees != null)
            {
                item["resourceAttendees"] = CSharpExpressionConverter.ConvertToken(itemresourceAttendees);
                itempropCount++;
            }

            if (itembody != null)
            {
                item["body"] = CSharpExpressionConverter.ConvertToken(itembody);
                itempropCount++;
            }

            if (itemcategories != null)
            {
                item["categories"] = CSharpExpressionConverter.ConvertToken(itemcategories);
                itempropCount++;
            }

            if (itemlocation != null)
            {
                item["location"] = CSharpExpressionConverter.ConvertToken(itemlocation);
                itempropCount++;
            }

            if (itemimportance != null)
            {
                item["importance"] = CSharpExpressionConverter.Convert(itemimportance);
                itempropCount++;
            }

            if (itemisAllDayEvent != null)
            {
                item["isAllDay"] = CSharpExpressionConverter.ConvertToken(itemisAllDayEvent);
                itempropCount++;
            }

            if (itemrecurrence != null)
            {
                item["recurrence"] = CSharpExpressionConverter.Convert(itemrecurrence);
                itempropCount++;
            }

            if (itemselectedDaysOfWeek != null)
            {
                item["selectedDaysOfWeek"] = CSharpExpressionConverter.ConvertToken(itemselectedDaysOfWeek);
                itempropCount++;
            }

            if (itemrecurrenceEndDate != null)
            {
                item["recurrenceEnd"] = CSharpExpressionConverter.ConvertToken(itemrecurrenceEndDate);
                itempropCount++;
            }

            if (itemnumberOfOccurrences != null)
            {
                item["numberOfOccurences"] = CSharpExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                itempropCount++;
            }

            if (itemreminder != null)
            {
                item["reminderMinutesBeforeStart"] = CSharpExpressionConverter.ConvertToken(itemreminder);
                itempropCount++;
            }

            if (itemisReminderOn != null)
            {
                item["isReminderOn"] = CSharpExpressionConverter.ConvertToken(itemisReminderOn);
                itempropCount++;
            }

            if (itemshowAs != null)
            {
                item["showAs"] = CSharpExpressionConverter.Convert(itemshowAs);
                itempropCount++;
            }

            if (itemresponseRequested != null)
            {
                item["responseRequested"] = CSharpExpressionConverter.ConvertToken(itemresponseRequested);
                itempropCount++;
            }

            if (itemsensitivity != null)
            {
                item["sensitivity"] = CSharpExpressionConverter.Convert(itemsensitivity);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ContactDeleteItem(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactGetItem(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseContactResponseV2> ContactGetItems(Expression<Func<string>> folder, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<EntityListResponseContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphContactFolder> ContactGetTables()
        {
            var apiCallPath = "/v2/datasets/contacts/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseGraphContactFolder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactPatchItem(Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddressV2[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            if (itemid != null)
            {
                item["id"] = CSharpExpressionConverter.ConvertToken(itemid);
                itempropCount++;
            }

            if (itemparentFolderId != null)
            {
                item["parentFolderId"] = CSharpExpressionConverter.ConvertToken(itemparentFolderId);
                itempropCount++;
            }

            if (itembirthday != null)
            {
                item["birthday"] = CSharpExpressionConverter.ConvertToken(itembirthday);
                itempropCount++;
            }

            if (itemfileAs != null)
            {
                item["fileAs"] = CSharpExpressionConverter.ConvertToken(itemfileAs);
                itempropCount++;
            }

            if (itemdisplayName != null)
            {
                item["displayName"] = CSharpExpressionConverter.ConvertToken(itemdisplayName);
                itempropCount++;
            }

            itempropCount++;
            item["givenName"] = CSharpExpressionConverter.ConvertToken(itemgivenName);
            if (iteminitials != null)
            {
                item["initials"] = CSharpExpressionConverter.ConvertToken(iteminitials);
                itempropCount++;
            }

            if (itemmiddleName != null)
            {
                item["middleName"] = CSharpExpressionConverter.ConvertToken(itemmiddleName);
                itempropCount++;
            }

            if (itemnickname != null)
            {
                item["nickName"] = CSharpExpressionConverter.ConvertToken(itemnickname);
                itempropCount++;
            }

            if (itemsurname != null)
            {
                item["surname"] = CSharpExpressionConverter.ConvertToken(itemsurname);
                itempropCount++;
            }

            if (itemtitle != null)
            {
                item["title"] = CSharpExpressionConverter.ConvertToken(itemtitle);
                itempropCount++;
            }

            if (itemgeneration != null)
            {
                item["generation"] = CSharpExpressionConverter.ConvertToken(itemgeneration);
                itempropCount++;
            }

            if (itememailAddresses != null)
            {
                item["emailAddresses"] = CSharpExpressionConverter.ConvertToken(itememailAddresses);
                itempropCount++;
            }

            if (itemiMAddresses != null)
            {
                item["imAddresses"] = CSharpExpressionConverter.ConvertToken(itemiMAddresses);
                itempropCount++;
            }

            if (itemjobTitle != null)
            {
                item["jobTitle"] = CSharpExpressionConverter.ConvertToken(itemjobTitle);
                itempropCount++;
            }

            if (itemcompanyName != null)
            {
                item["companyName"] = CSharpExpressionConverter.ConvertToken(itemcompanyName);
                itempropCount++;
            }

            if (itemdepartment != null)
            {
                item["department"] = CSharpExpressionConverter.ConvertToken(itemdepartment);
                itempropCount++;
            }

            if (itemofficeLocation != null)
            {
                item["officeLocation"] = CSharpExpressionConverter.ConvertToken(itemofficeLocation);
                itempropCount++;
            }

            if (itemprofession != null)
            {
                item["profession"] = CSharpExpressionConverter.ConvertToken(itemprofession);
                itempropCount++;
            }

            if (itembusinessHomePage != null)
            {
                item["businessHomePage"] = CSharpExpressionConverter.ConvertToken(itembusinessHomePage);
                itempropCount++;
            }

            if (itemassistantName != null)
            {
                item["assistantName"] = CSharpExpressionConverter.ConvertToken(itemassistantName);
                itempropCount++;
            }

            if (itemmanager != null)
            {
                item["manager"] = CSharpExpressionConverter.ConvertToken(itemmanager);
                itempropCount++;
            }

            itempropCount++;
            item["homePhones"] = CSharpExpressionConverter.ConvertToken(itemhomePhones);
            if (itembusinessPhones != null)
            {
                item["businessPhones"] = CSharpExpressionConverter.ConvertToken(itembusinessPhones);
                itempropCount++;
            }

            if (itemmobilePhone != null)
            {
                item["mobilePhone"] = CSharpExpressionConverter.ConvertToken(itemmobilePhone);
                itempropCount++;
            }

            var homeAddressObject = new JObject();
            var homeAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                homeAddressObject["street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                homeAddressObject["city"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                homeAddressObject["state"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                homeAddressObject["countryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                homeAddressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                homeAddressObjectpropCount++;
            }

            if (homeAddressObjectpropCount > 0)
            {
                item["homeAddress"] = homeAddressObject;
                itempropCount++;
            }

            var businessAddressObject = new JObject();
            var businessAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                businessAddressObject["street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                businessAddressObject["city"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                businessAddressObject["state"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                businessAddressObject["countryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                businessAddressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                businessAddressObjectpropCount++;
            }

            if (businessAddressObjectpropCount > 0)
            {
                item["businessAddress"] = businessAddressObject;
                itempropCount++;
            }

            var otherAddressObject = new JObject();
            var otherAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                otherAddressObject["street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                otherAddressObject["city"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                otherAddressObject["state"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                otherAddressObject["countryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                otherAddressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                otherAddressObjectpropCount++;
            }

            if (otherAddressObjectpropCount > 0)
            {
                item["otherAddress"] = otherAddressObject;
                itempropCount++;
            }

            if (itemyomiCompanyName != null)
            {
                item["yomiCompanyName"] = CSharpExpressionConverter.ConvertToken(itemyomiCompanyName);
                itempropCount++;
            }

            if (itemyomiGivenName != null)
            {
                item["yomiGivenName"] = CSharpExpressionConverter.ConvertToken(itemyomiGivenName);
                itempropCount++;
            }

            if (itemyomiSurname != null)
            {
                item["yomiSurname"] = CSharpExpressionConverter.ConvertToken(itemyomiSurname);
                itempropCount++;
            }

            if (itemcategories != null)
            {
                item["categories"] = CSharpExpressionConverter.ConvertToken(itemcategories);
                itempropCount++;
            }

            if (itemchangeKey != null)
            {
                item["changeKey"] = CSharpExpressionConverter.ConvertToken(itemchangeKey);
                itempropCount++;
            }

            if (itemcreatedTime != null)
            {
                item["createdDateTime"] = CSharpExpressionConverter.ConvertToken(itemcreatedTime);
                itempropCount++;
            }

            if (itemlastModifiedTime != null)
            {
                item["lastModifiedDateTime"] = CSharpExpressionConverter.ConvertToken(itemlastModifiedTime);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<ContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactPostItem(Expression<Func<string>> folder, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddressV2[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            if (itemid != null)
            {
                item["id"] = CSharpExpressionConverter.ConvertToken(itemid);
                itempropCount++;
            }

            if (itemparentFolderId != null)
            {
                item["parentFolderId"] = CSharpExpressionConverter.ConvertToken(itemparentFolderId);
                itempropCount++;
            }

            if (itembirthday != null)
            {
                item["birthday"] = CSharpExpressionConverter.ConvertToken(itembirthday);
                itempropCount++;
            }

            if (itemfileAs != null)
            {
                item["fileAs"] = CSharpExpressionConverter.ConvertToken(itemfileAs);
                itempropCount++;
            }

            if (itemdisplayName != null)
            {
                item["displayName"] = CSharpExpressionConverter.ConvertToken(itemdisplayName);
                itempropCount++;
            }

            itempropCount++;
            item["givenName"] = CSharpExpressionConverter.ConvertToken(itemgivenName);
            if (iteminitials != null)
            {
                item["initials"] = CSharpExpressionConverter.ConvertToken(iteminitials);
                itempropCount++;
            }

            if (itemmiddleName != null)
            {
                item["middleName"] = CSharpExpressionConverter.ConvertToken(itemmiddleName);
                itempropCount++;
            }

            if (itemnickname != null)
            {
                item["nickName"] = CSharpExpressionConverter.ConvertToken(itemnickname);
                itempropCount++;
            }

            if (itemsurname != null)
            {
                item["surname"] = CSharpExpressionConverter.ConvertToken(itemsurname);
                itempropCount++;
            }

            if (itemtitle != null)
            {
                item["title"] = CSharpExpressionConverter.ConvertToken(itemtitle);
                itempropCount++;
            }

            if (itemgeneration != null)
            {
                item["generation"] = CSharpExpressionConverter.ConvertToken(itemgeneration);
                itempropCount++;
            }

            if (itememailAddresses != null)
            {
                item["emailAddresses"] = CSharpExpressionConverter.ConvertToken(itememailAddresses);
                itempropCount++;
            }

            if (itemiMAddresses != null)
            {
                item["imAddresses"] = CSharpExpressionConverter.ConvertToken(itemiMAddresses);
                itempropCount++;
            }

            if (itemjobTitle != null)
            {
                item["jobTitle"] = CSharpExpressionConverter.ConvertToken(itemjobTitle);
                itempropCount++;
            }

            if (itemcompanyName != null)
            {
                item["companyName"] = CSharpExpressionConverter.ConvertToken(itemcompanyName);
                itempropCount++;
            }

            if (itemdepartment != null)
            {
                item["department"] = CSharpExpressionConverter.ConvertToken(itemdepartment);
                itempropCount++;
            }

            if (itemofficeLocation != null)
            {
                item["officeLocation"] = CSharpExpressionConverter.ConvertToken(itemofficeLocation);
                itempropCount++;
            }

            if (itemprofession != null)
            {
                item["profession"] = CSharpExpressionConverter.ConvertToken(itemprofession);
                itempropCount++;
            }

            if (itembusinessHomePage != null)
            {
                item["businessHomePage"] = CSharpExpressionConverter.ConvertToken(itembusinessHomePage);
                itempropCount++;
            }

            if (itemassistantName != null)
            {
                item["assistantName"] = CSharpExpressionConverter.ConvertToken(itemassistantName);
                itempropCount++;
            }

            if (itemmanager != null)
            {
                item["manager"] = CSharpExpressionConverter.ConvertToken(itemmanager);
                itempropCount++;
            }

            itempropCount++;
            item["homePhones"] = CSharpExpressionConverter.ConvertToken(itemhomePhones);
            if (itembusinessPhones != null)
            {
                item["businessPhones"] = CSharpExpressionConverter.ConvertToken(itembusinessPhones);
                itempropCount++;
            }

            if (itemmobilePhone != null)
            {
                item["mobilePhone"] = CSharpExpressionConverter.ConvertToken(itemmobilePhone);
                itempropCount++;
            }

            var homeAddressObject = new JObject();
            var homeAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                homeAddressObject["street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                homeAddressObject["city"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                homeAddressObject["state"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                homeAddressObject["countryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                homeAddressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                homeAddressObjectpropCount++;
            }

            if (homeAddressObjectpropCount > 0)
            {
                item["homeAddress"] = homeAddressObject;
                itempropCount++;
            }

            var businessAddressObject = new JObject();
            var businessAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                businessAddressObject["street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                businessAddressObject["city"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                businessAddressObject["state"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                businessAddressObject["countryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                businessAddressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                businessAddressObjectpropCount++;
            }

            if (businessAddressObjectpropCount > 0)
            {
                item["businessAddress"] = businessAddressObject;
                itempropCount++;
            }

            var otherAddressObject = new JObject();
            var otherAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                otherAddressObject["street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                otherAddressObject["city"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                otherAddressObject["state"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                otherAddressObject["countryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                otherAddressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                otherAddressObjectpropCount++;
            }

            if (otherAddressObjectpropCount > 0)
            {
                item["otherAddress"] = otherAddressObject;
                itempropCount++;
            }

            if (itemyomiCompanyName != null)
            {
                item["yomiCompanyName"] = CSharpExpressionConverter.ConvertToken(itemyomiCompanyName);
                itempropCount++;
            }

            if (itemyomiGivenName != null)
            {
                item["yomiGivenName"] = CSharpExpressionConverter.ConvertToken(itemyomiGivenName);
                itempropCount++;
            }

            if (itemyomiSurname != null)
            {
                item["yomiSurname"] = CSharpExpressionConverter.ConvertToken(itemyomiSurname);
                itempropCount++;
            }

            if (itemcategories != null)
            {
                item["categories"] = CSharpExpressionConverter.ConvertToken(itemcategories);
                itempropCount++;
            }

            if (itemchangeKey != null)
            {
                item["changeKey"] = CSharpExpressionConverter.ConvertToken(itemchangeKey);
                itempropCount++;
            }

            if (itemcreatedTime != null)
            {
                item["createdDateTime"] = CSharpExpressionConverter.ConvertToken(itemcreatedTime);
                itempropCount++;
            }

            if (itemlastModifiedTime != null)
            {
                item["lastModifiedDateTime"] = CSharpExpressionConverter.ConvertToken(itemlastModifiedTime);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<ContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<string> ExportEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/beta/me/messages/{0}/$value", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<FindMeetingTimesV2Response> FindMeetingTimes(Expression<Func<string>> bodyrequiredAttendees = null, Expression<Func<string>> bodyoptionalAttendees = null, Expression<Func<string>> bodyresourceAttendees = null, Expression<Func<int>> bodymeetingDuration = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<int>> bodymaxCandidates = null, Expression<Func<string>> bodyminimumAttendeePercentage = null, Expression<Func<bool>> bodyisOrganizerOptional = null, Expression<Func<bodyactivityDomainInput>> bodyactivityDomain = null)
        {
            var apiCallPath = "/codeless/beta/me/findMeetingTimes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequiredAttendees != null)
            {
                body["RequiredAttendees"] = CSharpExpressionConverter.ConvertToken(bodyrequiredAttendees);
                bodypropCount++;
            }

            if (bodyoptionalAttendees != null)
            {
                body["OptionalAttendees"] = CSharpExpressionConverter.ConvertToken(bodyoptionalAttendees);
                bodypropCount++;
            }

            if (bodyresourceAttendees != null)
            {
                body["ResourceAttendees"] = CSharpExpressionConverter.ConvertToken(bodyresourceAttendees);
                bodypropCount++;
            }

            if (bodymeetingDuration != null)
            {
                body["MeetingDuration"] = CSharpExpressionConverter.ConvertToken(bodymeetingDuration);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["Start"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["End"] = CSharpExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
            }

            if (bodymaxCandidates != null)
            {
                body["MaxCandidates"] = CSharpExpressionConverter.ConvertToken(bodymaxCandidates);
                bodypropCount++;
            }

            if (bodyminimumAttendeePercentage != null)
            {
                body["MinimumAttendeePercentage"] = CSharpExpressionConverter.ConvertToken(bodyminimumAttendeePercentage);
                bodypropCount++;
            }

            if (bodyisOrganizerOptional != null)
            {
                body["IsOrganizerOptional"] = CSharpExpressionConverter.ConvertToken(bodyisOrganizerOptional);
                bodypropCount++;
            }

            if (bodyactivityDomain != null)
            {
                if (bodyactivityDomain != null)
                {
                    body["ActivityDomain"] = CSharpExpressionConverter.Convert(bodyactivityDomain);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["ActivityDomain"] = "Work";
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FindMeetingTimesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction Flag(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bodyflagflagStatusInput>> bodyflagflagStatus = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/flag", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            var body = new JObject();
            var bodypropCount = 0;
            var flagObject = new JObject();
            var flagObjectpropCount = 0;
            if (bodyflagflagStatus != null)
            {
                if (bodyflagflagStatus != null)
                {
                    flagObject["flagStatus"] = CSharpExpressionConverter.Convert(bodyflagflagStatus);
                    flagObjectpropCount++;
                }

                flagObjectpropCount++;
            }
            else
            {
                flagObject["flagStatus"] = "flagged";
                flagObjectpropCount++;
            }

            if (flagObjectpropCount > 0)
            {
                body["flag"] = flagObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ForwardEmail(Expression<Func<string>> messageId, Expression<Func<string>> bodyto, Expression<Func<string>> mailboxAddress = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/forward", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            bodypropCount++;
            body["ToRecipients"] = CSharpExpressionConverter.ConvertToken(bodyto);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetAttachmentV2Response> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/attachments/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (fetchSensitivityLabelMetadata != null)
                callPayload.Queries["fetchSensitivityLabelMetadata"] = CSharpExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
            return new ApiConnectionAction<GetAttachmentV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> GetEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/Mail/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (internetMessageId != null)
                callPayload.Queries["internetMessageId"] = CSharpExpressionConverter.ConvertO(internetMessageId);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = CSharpExpressionConverter.ConvertO(extractSensitivityLabel);
            if (fetchSensitivityLabelMetadata != null)
                callPayload.Queries["fetchSensitivityLabelMetadata"] = CSharpExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
            return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchResponseGraphClientReceiveMessage> GetEmails(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/v3/Mail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = Convert.ToString("Inbox");
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                callPayload.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                callPayload.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            callPayload.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                callPayload.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            callPayload.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                callPayload.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            if (subjectFilter != null)
                callPayload.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
            callPayload.Queries["fetchOnlyUnread"] = Convert.ToString(true);
            if (fetchOnlyUnread != null)
                callPayload.Queries["fetchOnlyUnread"] = CSharpExpressionConverter.ConvertO(fetchOnlyUnread);
            callPayload.Queries["fetchOnlyFlagged"] = Convert.ToString(false);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (searchQuery != null)
                callPayload.Queries["searchQuery"] = CSharpExpressionConverter.ConvertO(searchQuery);
            callPayload.Queries["top"] = Convert.ToString(10);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<BatchResponseGraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> GetEventsCalendarView(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeUtc, Expression<Func<string>> endDateTimeUtc, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/datasets/calendars/v3/tables/items/calendarview";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["calendarId"] = CSharpExpressionConverter.ConvertO(calendarId);
            callPayload.Queries["startDateTimeUtc"] = CSharpExpressionConverter.ConvertO(startDateTimeUtc);
            callPayload.Queries["endDateTimeUtc"] = CSharpExpressionConverter.ConvertO(endDateTimeUtc);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            return new ApiConnectionAction<EntityListResponseGraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetMailTipsV2Response> GetMailTips(Expression<Func<string[]>> bodyemailAddresses)
        {
            var apiCallPath = "/codeless/v1.0/me/getMailTips";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["MailTipsOptions"] = "automaticReplies, deliveryRestriction, externalMemberCount, mailboxFullStatus, maxMessageSize, moderationStatus, totalMemberCount";
            bodypropCount++;
            bodypropCount++;
            body["EmailAddresses"] = CSharpExpressionConverter.ConvertToken(bodyemailAddresses);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetMailTipsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomListsV2Response> GetRoomLists()
        {
            var apiCallPath = "/codeless/beta/me/findRoomLists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomListsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsV2Response> GetRooms()
        {
            var apiCallPath = "/codeless/beta/me/findRooms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsInRoomListV2Response> GetRoomsInRoomList(Expression<Func<string>> roomList)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/beta/me/findRooms(RoomList='{0}')", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomList, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomsInRoomListV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction MarkAsRead(Expression<Func<string>> messageId, Expression<Func<bool>> bodymarkAs, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v3/v1.0/me/messages/{0}/markAsRead", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["isRead"] = CSharpExpressionConverter.ConvertToken(bodymarkAs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/Mail/Move/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ReplyTo(Expression<Func<string>> messageId, Expression<Func<string>> replyParametersto = null, Expression<Func<string>> replyParameterscC = null, Expression<Func<string>> replyParametersbCC = null, Expression<Func<string>> replyParameterssubject = null, Expression<Func<string>> replyParametersbody = null, Expression<Func<bool>> replyParametersreplyAll = null, Expression<Func<replyParametersimportanceInput>> replyParametersimportance = null, Expression<Func<ClientSendAttachment[]>> replyParametersattachments = null, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/Mail/ReplyTo/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            var replyParameters = new JObject();
            var replyParameterspropCount = 0;
            if (replyParametersto != null)
            {
                replyParameters["To"] = CSharpExpressionConverter.ConvertToken(replyParametersto);
                replyParameterspropCount++;
            }

            if (replyParameterscC != null)
            {
                replyParameters["Cc"] = CSharpExpressionConverter.ConvertToken(replyParameterscC);
                replyParameterspropCount++;
            }

            if (replyParametersbCC != null)
            {
                replyParameters["Bcc"] = CSharpExpressionConverter.ConvertToken(replyParametersbCC);
                replyParameterspropCount++;
            }

            if (replyParameterssubject != null)
            {
                replyParameters["Subject"] = CSharpExpressionConverter.ConvertToken(replyParameterssubject);
                replyParameterspropCount++;
            }

            if (replyParametersbody != null)
            {
                replyParameters["Body"] = CSharpExpressionConverter.ConvertToken(replyParametersbody);
                replyParameterspropCount++;
            }

            if (replyParametersreplyAll != null)
            {
                replyParameters["ReplyAll"] = CSharpExpressionConverter.ConvertToken(replyParametersreplyAll);
                replyParameterspropCount++;
            }

            if (replyParametersimportance != null)
            {
                replyParameters["Importance"] = CSharpExpressionConverter.Convert(replyParametersimportance);
                replyParameterspropCount++;
            }

            if (replyParametersattachments != null)
            {
                replyParameters["Attachments"] = CSharpExpressionConverter.ConvertToken(replyParametersattachments);
                replyParameterspropCount++;
            }

            if (replyParameterspropCount > 0)
            {
                callPayload.Body = replyParameters;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction RespondToEvent(Expression<Func<string>> eventId, Expression<Func<responseInput>> response, Expression<Func<string>> bodycomment = null, Expression<Func<bool>> bodysendResponse = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/events/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(response, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodysendResponse != null)
            {
                if (bodysendResponse != null)
                {
                    body["SendResponse"] = CSharpExpressionConverter.ConvertToken(bodysendResponse);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["SendResponse"] = true;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendEmail(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagefromSendAs = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagesensitivity = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
        {
            var apiCallPath = "/v2/Mail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var emailMessage = new JObject();
            var emailMessagepropCount = 0;
            emailMessagepropCount++;
            emailMessage["To"] = CSharpExpressionConverter.ConvertToken(emailMessageto);
            emailMessagepropCount++;
            emailMessage["Subject"] = CSharpExpressionConverter.ConvertToken(emailMessagesubject);
            emailMessagepropCount++;
            emailMessage["Body"] = CSharpExpressionConverter.ConvertToken(emailMessagebody);
            if (emailMessagefromSendAs != null)
            {
                emailMessage["From"] = CSharpExpressionConverter.ConvertToken(emailMessagefromSendAs);
                emailMessagepropCount++;
            }

            if (emailMessagecC != null)
            {
                emailMessage["Cc"] = CSharpExpressionConverter.ConvertToken(emailMessagecC);
                emailMessagepropCount++;
            }

            if (emailMessagebCC != null)
            {
                emailMessage["Bcc"] = CSharpExpressionConverter.ConvertToken(emailMessagebCC);
                emailMessagepropCount++;
            }

            if (emailMessageattachments != null)
            {
                emailMessage["Attachments"] = CSharpExpressionConverter.ConvertToken(emailMessageattachments);
                emailMessagepropCount++;
            }

            if (emailMessagesensitivity != null)
            {
                emailMessage["Sensitivity"] = CSharpExpressionConverter.ConvertToken(emailMessagesensitivity);
                emailMessagepropCount++;
            }

            if (emailMessagereplyTo != null)
            {
                emailMessage["ReplyTo"] = CSharpExpressionConverter.ConvertToken(emailMessagereplyTo);
                emailMessagepropCount++;
            }

            if (emailMessageimportance != null)
            {
                if (emailMessageimportance != null)
                {
                    emailMessage["Importance"] = CSharpExpressionConverter.Convert(emailMessageimportance);
                    emailMessagepropCount++;
                }

                emailMessagepropCount++;
            }
            else
            {
                emailMessage["Importance"] = "Normal";
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SetAutomaticRepliesSettingV2Response> SetAutomaticRepliesSetting(Expression<Func<bodyautomaticRepliesSettingstatusInput>> bodyautomaticRepliesSettingstatus, Expression<Func<bodyautomaticRepliesSettingexternalAudienceInput>> bodyautomaticRepliesSettingexternalAudience, Expression<Func<string>> bodyautomaticRepliesSettingstartTimedateTime = null, Expression<Func<string>> bodyautomaticRepliesSettingstartTimetimeZone = null, Expression<Func<string>> bodyautomaticRepliesSettingendTimedateTime = null, Expression<Func<string>> bodyautomaticRepliesSettingendTimetimeZone = null, Expression<Func<string>> bodyautomaticRepliesSettinginternalReplyMessage = null, Expression<Func<string>> bodyautomaticRepliesSettingexternalReplyMessage = null)
        {
            var apiCallPath = "/codeless/v1.0/me/mailboxSettings";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var automaticRepliesSettingObject = new JObject();
            var automaticRepliesSettingObjectpropCount = 0;
            automaticRepliesSettingObjectpropCount++;
            automaticRepliesSettingObject["status"] = CSharpExpressionConverter.Convert(bodyautomaticRepliesSettingstatus);
            automaticRepliesSettingObjectpropCount++;
            automaticRepliesSettingObject["externalAudience"] = CSharpExpressionConverter.Convert(bodyautomaticRepliesSettingexternalAudience);
            var scheduledStartDateTimeObject = new JObject();
            var scheduledStartDateTimeObjectpropCount = 0;
            if (bodyautomaticRepliesSettingstartTimedateTime != null)
            {
                scheduledStartDateTimeObject["dateTime"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRepliesSettingstartTimedateTime);
                scheduledStartDateTimeObjectpropCount++;
            }

            if (bodyautomaticRepliesSettingstartTimetimeZone != null)
            {
                scheduledStartDateTimeObject["timeZone"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRepliesSettingstartTimetimeZone);
                scheduledStartDateTimeObjectpropCount++;
            }

            if (scheduledStartDateTimeObjectpropCount > 0)
            {
                automaticRepliesSettingObject["scheduledStartDateTime"] = scheduledStartDateTimeObject;
                automaticRepliesSettingObjectpropCount++;
            }

            var scheduledEndDateTimeObject = new JObject();
            var scheduledEndDateTimeObjectpropCount = 0;
            if (bodyautomaticRepliesSettingendTimedateTime != null)
            {
                scheduledEndDateTimeObject["dateTime"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRepliesSettingendTimedateTime);
                scheduledEndDateTimeObjectpropCount++;
            }

            if (bodyautomaticRepliesSettingendTimetimeZone != null)
            {
                scheduledEndDateTimeObject["timeZone"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRepliesSettingendTimetimeZone);
                scheduledEndDateTimeObjectpropCount++;
            }

            if (scheduledEndDateTimeObjectpropCount > 0)
            {
                automaticRepliesSettingObject["scheduledEndDateTime"] = scheduledEndDateTimeObject;
                automaticRepliesSettingObjectpropCount++;
            }

            if (bodyautomaticRepliesSettinginternalReplyMessage != null)
            {
                automaticRepliesSettingObject["internalReplyMessage"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRepliesSettinginternalReplyMessage);
                automaticRepliesSettingObjectpropCount++;
            }

            if (bodyautomaticRepliesSettingexternalReplyMessage != null)
            {
                automaticRepliesSettingObject["externalReplyMessage"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRepliesSettingexternalReplyMessage);
                automaticRepliesSettingObjectpropCount++;
            }

            if (automaticRepliesSettingObjectpropCount > 0)
            {
                body["automaticRepliesSetting"] = automaticRepliesSettingObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetAutomaticRepliesSettingV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SharedMailboxSendEmail(Expression<Func<string>> emailMessageoriginalMailboxAddress, Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagesensitivity = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
        {
            var apiCallPath = "/v2/SharedMailbox/Mail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var emailMessage = new JObject();
            var emailMessagepropCount = 0;
            emailMessagepropCount++;
            emailMessage["MailboxAddress"] = CSharpExpressionConverter.ConvertToken(emailMessageoriginalMailboxAddress);
            emailMessagepropCount++;
            emailMessage["To"] = CSharpExpressionConverter.ConvertToken(emailMessageto);
            emailMessagepropCount++;
            emailMessage["Subject"] = CSharpExpressionConverter.ConvertToken(emailMessagesubject);
            emailMessagepropCount++;
            emailMessage["Body"] = CSharpExpressionConverter.ConvertToken(emailMessagebody);
            if (emailMessagecC != null)
            {
                emailMessage["Cc"] = CSharpExpressionConverter.ConvertToken(emailMessagecC);
                emailMessagepropCount++;
            }

            if (emailMessagebCC != null)
            {
                emailMessage["Bcc"] = CSharpExpressionConverter.ConvertToken(emailMessagebCC);
                emailMessagepropCount++;
            }

            if (emailMessageattachments != null)
            {
                emailMessage["Attachments"] = CSharpExpressionConverter.ConvertToken(emailMessageattachments);
                emailMessagepropCount++;
            }

            if (emailMessagesensitivity != null)
            {
                emailMessage["Sensitivity"] = CSharpExpressionConverter.ConvertToken(emailMessagesensitivity);
                emailMessagepropCount++;
            }

            if (emailMessagereplyTo != null)
            {
                emailMessage["ReplyTo"] = CSharpExpressionConverter.ConvertToken(emailMessagereplyTo);
                emailMessagepropCount++;
            }

            if (emailMessageimportance != null)
            {
                if (emailMessageimportance != null)
                {
                    emailMessage["Importance"] = CSharpExpressionConverter.Convert(emailMessageimportance);
                    emailMessagepropCount++;
                }

                emailMessagepropCount++;
            }
            else
            {
                emailMessage["Importance"] = "Normal";
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class Office365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GraphCalendarEventListWithActionType> OnCalendarChangedItems(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/datasets/calendars/v3/tables/{0}/onchangeditems"
                },
                Method = "get",
            };
            input.Fetch.Queries["incomingDays"] = Convert.ToString(300);
            if (incomingDays != null)
                input.Fetch.Queries["incomingDays"] = CSharpExpressionConverter.ConvertO(incomingDays);
            input.Fetch.Queries["pastDays"] = Convert.ToString(50);
            if (pastDays != null)
                input.Fetch.Queries["pastDays"] = CSharpExpressionConverter.ConvertO(pastDays);
            input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/{0}/GraphEventSubscriptionPoke/$subscriptions"
                },
                Method = "post",
            };
            input.Subscribe.Queries["incomingDays"] = Convert.ToString(300);
            if (incomingDays != null)
                input.Subscribe.Queries["incomingDays"] = CSharpExpressionConverter.ConvertO(incomingDays);
            input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
            if (pastDays != null)
                input.Subscribe.Queries["pastDays"] = CSharpExpressionConverter.ConvertO(pastDays);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<GraphCalendarEventListWithActionType>(input);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarNewItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/onnewitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/onupdateditems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnFlaggedEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/v4/Mail/OnFlaggedEmail"
                },
                Method = "get",
            };
            input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
            if (folderPath != null)
                input.Fetch.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                input.Fetch.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                input.Fetch.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                input.Fetch.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                input.Fetch.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            input.Fetch.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Fetch.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Fetch.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                input.Fetch.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (subjectFilter != null)
                input.Fetch.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
            input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/GraphFlaggedMailSubscriptionPoke/$subscriptions"
                },
                Method = "post",
            };
            input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
            if (folderPath != null)
                input.Subscribe.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            input.Subscribe.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Subscribe.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/v3/Mail/OnNewEmail"
                },
                Method = "get",
            };
            input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
            if (folderPath != null)
                input.Fetch.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                input.Fetch.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                input.Fetch.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                input.Fetch.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                input.Fetch.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            input.Fetch.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Fetch.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Fetch.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                input.Fetch.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (subjectFilter != null)
                input.Fetch.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
            input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/GraphMailSubscriptionPoke/$subscriptions"
                },
                Method = "post",
            };
            input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
            if (folderPath != null)
                input.Subscribe.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            input.Subscribe.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Subscribe.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmailMentioningMe(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/v3/Mail/OnNewMentionMeEmail"
                },
                Method = "get",
            };
            if (folderPath != null)
                input.Fetch.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                input.Fetch.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                input.Fetch.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                input.Fetch.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                input.Fetch.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            input.Fetch.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Fetch.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Fetch.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                input.Fetch.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (subjectFilter != null)
                input.Fetch.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
            input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/GraphMentionMeMailSubscriptionPoke/$subscriptions"
                },
                Method = "post",
            };
            if (folderPath != null)
                input.Subscribe.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            input.Subscribe.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Subscribe.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnUpcomingEvents(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v3/Events/OnUpcomingEvents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["table"] = CSharpExpressionConverter.ConvertO(table);
            callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
            if (lookAheadTimeInMinutes != null)
                callPayload.Queries["lookAheadTimeInMinutes"] = CSharpExpressionConverter.ConvertO(lookAheadTimeInMinutes);
            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnSharedMailboxNewEmail(Expression<Func<string>> mailboxAddress, Expression<Func<string>> folderId = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> hasAttachments = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/SharedMailbox/Mail/OnNewEmail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mailboxAddress"] = CSharpExpressionConverter.ConvertO(mailboxAddress);
            callPayload.Queries["folderId"] = Convert.ToString("Inbox");
            if (folderId != null)
                callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                callPayload.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                callPayload.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            callPayload.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                callPayload.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            callPayload.Queries["hasAttachments"] = Convert.ToString(false);
            if (hasAttachments != null)
                callPayload.Queries["hasAttachments"] = CSharpExpressionConverter.ConvertO(hasAttachments);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (subjectFilter != null)
                callPayload.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(callPayload, triggerName, recurrence);
        }
    }

    public class GraphOutlookCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class OutlookReceiveMessage
    {
        public string InternetMessageId { get; set; }
        public string BodyPreview { get; set; }
        public string Id { get; set; }
        public string ConversationId { get; set; }
        public bool HasAttachments { get; set; }
        public bool IsRead { get; set; }
        public string CreatedDateTime { get; set; }
        public string ReceivedDateTime { get; set; }
        public string LastModifiedDateTime { get; set; }
        public OutlookReceiveAttachment[] Attachments { get; set; }
        public Recipient[] ToRecipients { get; set; }
        public Recipient[] CcRecipients { get; set; }
        public Recipient[] BccRecipients { get; set; }
        public Recipient[] ReplyTo { get; set; }
        public string Subject { get; set; }
        public ItemBody Body { get; set; }
        public Recipient From { get; set; }
        public OutlookReceiveMessageImportanceType Importance { get; set; }
        public InternetMessageHeader[] InternetMessageHeaders { get; set; }
    }

    public class OutlookReceiveAttachment
    {
        [JsonProperty("@odata.type")]
        public string Type { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ContentBytes { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public string Permission { get; set; }
        public string ProviderType { get; set; }
        public string SourceUrl { get; set; }
        public bool IsInline { get; set; }
        public string LastModifiedDateTime { get; set; }
        public string ContentId { get; set; }
    }

    public class Recipient
    {
        public EmailAddress EmailAddress { get; set; }
    }

    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class ItemBody
    {
        public ItemBodyContentTypeType ContentType { get; set; }
        public string Content { get; set; }
    }

    public enum ItemBodyContentTypeType
    {
        Text,
        HTML
    }

    public enum OutlookReceiveMessageImportanceType
    {
        Low,
        Normal,
        High
    }

    public class InternetMessageHeader
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class ClientSendAttachment
    {
        public string Name { get; set; }

        [JsonProperty("ContentBytes")]
        public string Content { get; set; }
    }

    public enum draftMessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class BatchOperationResult
    {
        [JsonProperty("successCount")]
        public int SuccessCount { get; set; }

        [JsonProperty("failures")]
        public BatchItemFailureResult[] Failures { get; set; }
    }

    public class BatchItemFailureResult
    {
        public string MessageId { get; set; }
        public string Error { get; set; }
    }

    public class SubscriptionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }
    }

    public enum optionsEmailSubscriptionmessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum approvalEmailSubscriptionmessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class MCPQueryResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }

    public class GraphCalendarEventClientReceive
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }

        [JsonProperty("end")]
        public string EndTime { get; set; }

        [JsonProperty("startWithTimeZone")]
        public string StartTimeWithTimeZone { get; set; }

        [JsonProperty("endWithTimeZone")]
        public string EndTimeWithTimeZone { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHTML { get; set; }

        [JsonProperty("responseType")]
        public GraphCalendarEventClientReceiveResponseTypeType ResponseType { get; set; }

        [JsonProperty("responseTime")]
        public string ResponseTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("seriesMasterId")]
        public string SeriesMasterId { get; set; }

        [JsonProperty("iCalUId")]
        public string ICalUId { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        [JsonProperty("requiredAttendees")]
        public string RequiredAttendees { get; set; }

        [JsonProperty("optionalAttendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("resourceAttendees")]
        public string ResourceAttendees { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("importance")]
        public GraphCalendarEventClientReceiveImportanceType Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("recurrence")]
        public GraphCalendarEventClientReceiveRecurrenceType Recurrence { get; set; }

        [JsonProperty("recurrenceEnd")]
        public string RecurrenceEndDate { get; set; }

        [JsonProperty("numberOfOccurences")]
        public int NumberOfOccurrences { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int Reminder { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("showAs")]
        public GraphCalendarEventClientReceiveShowAsType ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("sensitivity")]
        public GraphCalendarEventClientReceiveSensitivityType Sensitivity { get; set; }
    }

    public enum GraphCalendarEventClientReceiveResponseTypeType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "organizer")]
        Organizer,
        [EnumMember(Value = "tentativelyAccepted")]
        TentativelyAccepted,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "notResponded")]
        NotResponded
    }

    public enum GraphCalendarEventClientReceiveImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public enum GraphCalendarEventClientReceiveRecurrenceType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "monthly")]
        Monthly,
        [EnumMember(Value = "yearly")]
        Yearly
    }

    public enum GraphCalendarEventClientReceiveShowAsType
    {
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "oof")]
        Oof,
        [EnumMember(Value = "workingElsewhere")]
        WorkingElsewhere,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    public enum GraphCalendarEventClientReceiveSensitivityType
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "confidential")]
        Confidential
    }

    public class GraphCalendarEventListClientReceive
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientReceive[] Value { get; set; }
    }

    public class CalendarGetTablesV2Response
    {
        [JsonProperty("value")]
        public CalendarGetTablesV2ResponseValueTypeItem[] Value { get; set; }
    }

    public class CalendarGetTablesV2ResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public EmailAddressV2 Owner { get; set; }
    }

    public class EmailAddressV2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public enum itemtimeZoneInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "(UTC-12:00) International Date Line West")]
        UTC1200InternationalDateLineWest,
        [EnumMember(Value = "(UTC-11:00) Coordinated Universal Time-11")]
        UTC1100CoordinatedUniversalTime11,
        [EnumMember(Value = "(UTC-10:00) Aleutian Islands")]
        UTC1000AleutianIslands,
        [EnumMember(Value = "(UTC-10:00) Hawaii")]
        UTC1000Hawaii,
        [EnumMember(Value = "(UTC-09:30) Marquesas Islands")]
        UTC0930MarquesasIslands,
        [EnumMember(Value = "(UTC-09:00) Alaska")]
        UTC0900Alaska,
        [EnumMember(Value = "(UTC-09:00) Coordinated Universal Time-09")]
        UTC0900CoordinatedUniversalTime09,
        [EnumMember(Value = "(UTC-08:00) Baja California")]
        UTC0800BajaCalifornia,
        [EnumMember(Value = "(UTC-08:00) Coordinated Universal Time-08")]
        UTC0800CoordinatedUniversalTime08,
        [EnumMember(Value = "(UTC-08:00) Pacific Time (US & Canada)")]
        UTC0800PacificTimeUSCanada,
        [EnumMember(Value = "(UTC-07:00) Arizona")]
        UTC0700Arizona,
        [EnumMember(Value = "(UTC-07:00) Chihuahua, La Paz, Mazatlan")]
        UTC0700ChihuahuaLaPazMazatlan,
        [EnumMember(Value = "(UTC-07:00) Mountain Time (US & Canada)")]
        UTC0700MountainTimeUSCanada,
        [EnumMember(Value = "(UTC-06:00) Central America")]
        UTC0600CentralAmerica,
        [EnumMember(Value = "(UTC-06:00) Central Time (US & Canada)")]
        UTC0600CentralTimeUSCanada,
        [EnumMember(Value = "(UTC-06:00) Easter Island")]
        UTC0600EasterIsland,
        [EnumMember(Value = "(UTC-06:00) Guadalajara, Mexico City, Monterrey")]
        UTC0600GuadalajaraMexicoCityMonterrey,
        [EnumMember(Value = "(UTC-06:00) Saskatchewan")]
        UTC0600Saskatchewan,
        [EnumMember(Value = "(UTC-05:00) Bogota, Lima, Quito, Rio Branco")]
        UTC0500BogotaLimaQuitoRioBranco,
        [EnumMember(Value = "(UTC-05:00) Chetumal")]
        UTC0500Chetumal,
        [EnumMember(Value = "(UTC-05:00) Eastern Time (US & Canada)")]
        UTC0500EasternTimeUSCanada,
        [EnumMember(Value = "(UTC-05:00) Haiti")]
        UTC0500Haiti,
        [EnumMember(Value = "(UTC-05:00) Havana")]
        UTC0500Havana,
        [EnumMember(Value = "(UTC-05:00) Indiana (East)")]
        UTC0500IndianaEast,
        [EnumMember(Value = "(UTC-04:00) Asuncion")]
        UTC0400Asuncion,
        [EnumMember(Value = "(UTC-04:00) Atlantic Time (Canada)")]
        UTC0400AtlanticTimeCanada,
        [EnumMember(Value = "(UTC-04:00) Caracas")]
        UTC0400Caracas,
        [EnumMember(Value = "(UTC-04:00) Cuiaba")]
        UTC0400Cuiaba,
        [EnumMember(Value = "(UTC-04:00) Georgetown, La Paz, Manaus, San Juan")]
        UTC0400GeorgetownLaPazManausSanJuan,
        [EnumMember(Value = "(UTC-04:00) Santiago")]
        UTC0400Santiago,
        [EnumMember(Value = "(UTC-04:00) Turks and Caicos")]
        UTC0400TurksAndCaicos,
        [EnumMember(Value = "(UTC-03:30) Newfoundland")]
        UTC0330Newfoundland,
        [EnumMember(Value = "(UTC-03:00) Araguaina")]
        UTC0300Araguaina,
        [EnumMember(Value = "(UTC-03:00) Brasilia")]
        UTC0300Brasilia,
        [EnumMember(Value = "(UTC-03:00) Cayenne, Fortaleza")]
        UTC0300CayenneFortaleza,
        [EnumMember(Value = "(UTC-03:00) City of Buenos Aires")]
        UTC0300CityOfBuenosAires,
        [EnumMember(Value = "(UTC-03:00) Greenland")]
        UTC0300Greenland,
        [EnumMember(Value = "(UTC-03:00) Montevideo")]
        UTC0300Montevideo,
        [EnumMember(Value = "(UTC-03:00) Punta Arenas")]
        UTC0300PuntaArenas,
        [EnumMember(Value = "(UTC-03:00) Saint Pierre and Miquelon")]
        UTC0300SaintPierreAndMiquelon,
        [EnumMember(Value = "(UTC-03:00) Salvador")]
        UTC0300Salvador,
        [EnumMember(Value = "(UTC-02:00) Coordinated Universal Time-02")]
        UTC0200CoordinatedUniversalTime02,
        [EnumMember(Value = "(UTC-02:00) Mid-Atlantic - Old")]
        UTC0200MidAtlanticOld,
        [EnumMember(Value = "(UTC-01:00) Azores")]
        UTC0100Azores,
        [EnumMember(Value = "(UTC-01:00) Cabo Verde Is.")]
        UTC0100CaboVerdeIs,
        [EnumMember(Value = "(UTC) Coordinated Universal Time")]
        UTCCoordinatedUniversalTime,
        [EnumMember(Value = "(UTC+00:00) Casablanca")]
        UTC0000Casablanca,
        [EnumMember(Value = "(UTC+00:00) Dublin, Edinburgh, Lisbon, London")]
        UTC0000DublinEdinburghLisbonLondon,
        [EnumMember(Value = "(UTC+00:00) Monrovia, Reykjavik")]
        UTC0000MonroviaReykjavik,
        [EnumMember(Value = "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna")]
        UTC0100AmsterdamBerlinBernRomeStockholmVienna,
        [EnumMember(Value = "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague")]
        UTC0100BelgradeBratislavaBudapestLjubljanaPrague,
        [EnumMember(Value = "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris")]
        UTC0100BrusselsCopenhagenMadridParis,
        [EnumMember(Value = "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb")]
        UTC0100SarajevoSkopjeWarsawZagreb,
        [EnumMember(Value = "(UTC+01:00) West Central Africa")]
        UTC0100WestCentralAfrica,
        [EnumMember(Value = "(UTC+01:00) Windhoek")]
        UTC0100Windhoek,
        [EnumMember(Value = "(UTC+02:00) Amman")]
        UTC0200Amman,
        [EnumMember(Value = "(UTC+02:00) Athens, Bucharest")]
        UTC0200AthensBucharest,
        [EnumMember(Value = "(UTC+02:00) Beirut")]
        UTC0200Beirut,
        [EnumMember(Value = "(UTC+02:00) Cairo")]
        UTC0200Cairo,
        [EnumMember(Value = "(UTC+02:00) Chisinau")]
        UTC0200Chisinau,
        [EnumMember(Value = "(UTC+02:00) Damascus")]
        UTC0200Damascus,
        [EnumMember(Value = "(UTC+02:00) Gaza, Hebron")]
        UTC0200GazaHebron,
        [EnumMember(Value = "(UTC+02:00) Harare, Pretoria")]
        UTC0200HararePretoria,
        [EnumMember(Value = "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius")]
        UTC0200HelsinkiKyivRigaSofiaTallinnVilnius,
        [EnumMember(Value = "(UTC+02:00) Jerusalem")]
        UTC0200Jerusalem,
        [EnumMember(Value = "(UTC+02:00) Kaliningrad")]
        UTC0200Kaliningrad,
        [EnumMember(Value = "(UTC+02:00) Tripoli")]
        UTC0200Tripoli,
        [EnumMember(Value = "(UTC+03:00) Baghdad")]
        UTC0300Baghdad,
        [EnumMember(Value = "(UTC+03:00) Istanbul")]
        UTC0300Istanbul,
        [EnumMember(Value = "(UTC+03:00) Kuwait, Riyadh")]
        UTC0300KuwaitRiyadh,
        [EnumMember(Value = "(UTC+03:00) Minsk")]
        UTC0300Minsk,
        [EnumMember(Value = "(UTC+03:00) Moscow, St. Petersburg")]
        UTC0300MoscowStPetersburg,
        [EnumMember(Value = "(UTC+03:00) Nairobi")]
        UTC0300Nairobi,
        [EnumMember(Value = "(UTC+03:30) Tehran")]
        UTC0330Tehran,
        [EnumMember(Value = "(UTC+04:00) Abu Dhabi, Muscat")]
        UTC0400AbuDhabiMuscat,
        [EnumMember(Value = "(UTC+04:00) Astrakhan, Ulyanovsk")]
        UTC0400AstrakhanUlyanovsk,
        [EnumMember(Value = "(UTC+04:00) Baku")]
        UTC0400Baku,
        [EnumMember(Value = "(UTC+04:00) Izhevsk, Samara")]
        UTC0400IzhevskSamara,
        [EnumMember(Value = "(UTC+04:00) Port Louis")]
        UTC0400PortLouis,
        [EnumMember(Value = "(UTC+04:00) Saratov")]
        UTC0400Saratov,
        [EnumMember(Value = "(UTC+04:00) Tbilisi")]
        UTC0400Tbilisi,
        [EnumMember(Value = "(UTC+04:00) Volgograd")]
        UTC0400Volgograd,
        [EnumMember(Value = "(UTC+04:00) Yerevan")]
        UTC0400Yerevan,
        [EnumMember(Value = "(UTC+04:30) Kabul")]
        UTC0430Kabul,
        [EnumMember(Value = "(UTC+05:00) Ashgabat, Tashkent")]
        UTC0500AshgabatTashkent,
        [EnumMember(Value = "(UTC+05:00) Ekaterinburg")]
        UTC0500Ekaterinburg,
        [EnumMember(Value = "(UTC+05:00) Islamabad, Karachi")]
        UTC0500IslamabadKarachi,
        [EnumMember(Value = "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi")]
        UTC0530ChennaiKolkataMumbaiNewDelhi,
        [EnumMember(Value = "(UTC+05:30) Sri Jayawardenepura")]
        UTC0530SriJayawardenepura,
        [EnumMember(Value = "(UTC+05:45) Kathmandu")]
        UTC0545Kathmandu,
        [EnumMember(Value = "(UTC+06:00) Astana")]
        UTC0600Astana,
        [EnumMember(Value = "(UTC+06:00) Dhaka")]
        UTC0600Dhaka,
        [EnumMember(Value = "(UTC+06:00) Omsk")]
        UTC0600Omsk,
        [EnumMember(Value = "(UTC+06:30) Yangon (Rangoon)")]
        UTC0630YangonRangoon,
        [EnumMember(Value = "(UTC+07:00) Bangkok, Hanoi, Jakarta")]
        UTC0700BangkokHanoiJakarta,
        [EnumMember(Value = "(UTC+07:00) Barnaul, Gorno-Altaysk")]
        UTC0700BarnaulGornoAltaysk,
        [EnumMember(Value = "(UTC+07:00) Hovd")]
        UTC0700Hovd,
        [EnumMember(Value = "(UTC+07:00) Krasnoyarsk")]
        UTC0700Krasnoyarsk,
        [EnumMember(Value = "(UTC+07:00) Novosibirsk")]
        UTC0700Novosibirsk,
        [EnumMember(Value = "(UTC+07:00) Tomsk")]
        UTC0700Tomsk,
        [EnumMember(Value = "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi")]
        UTC0800BeijingChongqingHongKongUrumqi,
        [EnumMember(Value = "(UTC+08:00) Irkutsk")]
        UTC0800Irkutsk,
        [EnumMember(Value = "(UTC+08:00) Kuala Lumpur, Singapore")]
        UTC0800KualaLumpurSingapore,
        [EnumMember(Value = "(UTC+08:00) Perth")]
        UTC0800Perth,
        [EnumMember(Value = "(UTC+08:00) Taipei")]
        UTC0800Taipei,
        [EnumMember(Value = "(UTC+08:00) Ulaanbaatar")]
        UTC0800Ulaanbaatar,
        [EnumMember(Value = "(UTC+08:30) Pyongyang")]
        UTC0830Pyongyang,
        [EnumMember(Value = "(UTC+08:45) Eucla")]
        UTC0845Eucla,
        [EnumMember(Value = "(UTC+09:00) Chita")]
        UTC0900Chita,
        [EnumMember(Value = "(UTC+09:00) Osaka, Sapporo, Tokyo")]
        UTC0900OsakaSapporoTokyo,
        [EnumMember(Value = "(UTC+09:00) Seoul")]
        UTC0900Seoul,
        [EnumMember(Value = "(UTC+09:00) Yakutsk")]
        UTC0900Yakutsk,
        [EnumMember(Value = "(UTC+09:30) Adelaide")]
        UTC0930Adelaide,
        [EnumMember(Value = "(UTC+09:30) Darwin")]
        UTC0930Darwin,
        [EnumMember(Value = "(UTC+10:00) Brisbane")]
        UTC1000Brisbane,
        [EnumMember(Value = "(UTC+10:00) Canberra, Melbourne, Sydney")]
        UTC1000CanberraMelbourneSydney,
        [EnumMember(Value = "(UTC+10:00) Guam, Port Moresby")]
        UTC1000GuamPortMoresby,
        [EnumMember(Value = "(UTC+10:00) Hobart")]
        UTC1000Hobart,
        [EnumMember(Value = "(UTC+10:00) Vladivostok")]
        UTC1000Vladivostok,
        [EnumMember(Value = "(UTC+10:30) Lord Howe Island")]
        UTC1030LordHoweIsland,
        [EnumMember(Value = "(UTC+11:00) Bougainville Island")]
        UTC1100BougainvilleIsland,
        [EnumMember(Value = "(UTC+11:00) Chokurdakh")]
        UTC1100Chokurdakh,
        [EnumMember(Value = "(UTC+11:00) Magadan")]
        UTC1100Magadan,
        [EnumMember(Value = "(UTC+11:00) Norfolk Island")]
        UTC1100NorfolkIsland,
        [EnumMember(Value = "(UTC+11:00) Sakhalin")]
        UTC1100Sakhalin,
        [EnumMember(Value = "(UTC+11:00) Solomon Is., New Caledonia")]
        UTC1100SolomonIsNewCaledonia,
        [EnumMember(Value = "(UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky")]
        UTC1200AnadyrPetropavlovskKamchatsky,
        [EnumMember(Value = "(UTC+12:00) Auckland, Wellington")]
        UTC1200AucklandWellington,
        [EnumMember(Value = "(UTC+12:00) Coordinated Universal Time+12")]
        UTC1200CoordinatedUniversalTime12,
        [EnumMember(Value = "(UTC+12:00) Fiji")]
        UTC1200Fiji,
        [EnumMember(Value = "(UTC+12:00) Petropavlovsk-Kamchatsky - Old")]
        UTC1200PetropavlovskKamchatskyOld,
        [EnumMember(Value = "(UTC+12:45) Chatham Islands")]
        UTC1245ChathamIslands,
        [EnumMember(Value = "(UTC+13:00) Coordinated Universal Time+13")]
        UTC1300CoordinatedUniversalTime13,
        [EnumMember(Value = "(UTC+13:00) Nuku'alofa")]
        UTC1300NukuAlofa,
        [EnumMember(Value = "(UTC+13:00) Samoa")]
        UTC1300Samoa,
        [EnumMember(Value = "(UTC+14:00) Kiritimati Island")]
        UTC1400KiritimatiIsland
    }

    public enum itemimportanceInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public enum itemrecurrenceInput
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "monthly")]
        Monthly,
        [EnumMember(Value = "yearly")]
        Yearly
    }

    public enum itemselectedDaysOfWeekInputItem
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum itemshowAsInput
    {
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "oof")]
        Oof,
        [EnumMember(Value = "workingElsewhere")]
        WorkingElsewhere,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    public enum itemsensitivityInput
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "confidential")]
        Confidential
    }

    public class ContactResponseV2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("fileAs")]
        public string FileAs { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("nickName")]
        public string Nickname { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("generation")]
        public string Generation { get; set; }

        [JsonProperty("emailAddresses")]
        public EmailAddressV2[] EmailAddresses { get; set; }

        [JsonProperty("imAddresses")]
        public string[] IMAddresses { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("businessHomePage")]
        public string BusinessHomePage { get; set; }

        [JsonProperty("assistantName")]
        public string AssistantName { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("homePhones")]
        public string[] HomePhones { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("homeAddress")]
        public PhysicalAddressV2 HomeAddress { get; set; }

        [JsonProperty("businessAddress")]
        public PhysicalAddressV2 BusinessAddress { get; set; }

        [JsonProperty("otherAddress")]
        public PhysicalAddressV2 OtherAddress { get; set; }

        [JsonProperty("yomiCompanyName")]
        public string YomiCompanyName { get; set; }

        [JsonProperty("yomiGivenName")]
        public string YomiGivenName { get; set; }

        [JsonProperty("yomiSurname")]
        public string YomiSurname { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("changeKey")]
        public string ChangeKey { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedTime { get; set; }
    }

    public class PhysicalAddressV2
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("countryOrRegion")]
        public string CountryOrRegion { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class EntityListResponseContactResponseV2
    {
        [JsonProperty("value")]
        public ContactResponseV2[] Value { get; set; }
    }

    public class EntityListResponseGraphContactFolder
    {
        [JsonProperty("value")]
        public GraphContactFolder[] Value { get; set; }
    }

    public class GraphContactFolder
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderID { get; set; }
    }

    public class FindMeetingTimesV2Response
    {
        [JsonProperty("emptySuggestionsReason")]
        public string EmptySuggestionsReason { get; set; }

        [JsonProperty("meetingTimeSuggestions")]
        public MeetingTimeSuggestionsV2Item[] MeetingTimeSuggestions { get; set; }
    }

    public class MeetingTimeSuggestionsV2Item
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("organizerAvailability")]
        public string OrganizerAvailability { get; set; }

        [JsonProperty("suggestionReason")]
        public string SuggestionReason { get; set; }

        [JsonProperty("meetingTimeSlot")]
        public MeetingTimeSuggestionsV2ItemMeetingTimeSlotType MeetingTimeSlot { get; set; }

        [JsonProperty("attendeeAvailability")]
        public MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItem[] AttendeeAvailability { get; set; }

        [JsonProperty("locations")]
        public MeetingTimeSuggestionsV2ItemLocationsTypeItem[] Locations { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemMeetingTimeSlotType
    {
        [JsonProperty("start")]
        public DateTimeTimeZoneV2 Start { get; set; }

        [JsonProperty("end")]
        public DateTimeTimeZoneV2 End { get; set; }
    }

    public class DateTimeTimeZoneV2
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItem
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("attendee")]
        public MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeType Attendee { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("emailAddress")]
        public MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeTypeEmailAddressType EmailAddress { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeTypeEmailAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemLocationsTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("locationEmailAddress")]
        public string LocationEmailAddress { get; set; }

        [JsonProperty("address")]
        public MeetingTimeSuggestionsV2ItemLocationsTypeItemAddressType Address { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemLocationsTypeItemAddressType
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("countryOrRegion")]
        public string CountryOrRegion { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public enum bodyactivityDomainInput
    {
        Work,
        Personal,
        Unrestricted,
        Unknown
    }

    public enum bodyflagflagStatusInput
    {
        [EnumMember(Value = "flagged")]
        Flagged,
        [EnumMember(Value = "notFlagged")]
        NotFlagged,
        [EnumMember(Value = "complete")]
        Complete
    }

    public class GetAttachmentV2Response
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("contentBytes")]
        public string ContentBytes { get; set; }

        [JsonProperty("isInline")]
        public bool IsInline { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class SensitivityLabelMetadata
    {
        [JsonProperty("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string SensitivityLabelDisplayNameInfo { get; set; }

        [JsonProperty("tooltip")]
        public string TooltipInfo { get; set; }

        [JsonProperty("priority")]
        public int PriorityOfSensitivityLabel { get; set; }

        [JsonProperty("color")]
        public string ColorToBeDisplayedForSensitivityLabel { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncryptedStatusOfSensitivityLabel { get; set; }

        [JsonProperty("isEnabled")]
        public bool WhetherSensitivityLabelIsEnabled { get; set; }

        [JsonProperty("isParent")]
        public bool WhetherSensitivityLabelIsParent { get; set; }

        [JsonProperty("parentSensitivityLabelId")]
        public string ParentSensitivityLabelId { get; set; }
    }

    public class GraphClientReceiveMessage
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("toRecipients")]
        public string To { get; set; }

        [JsonProperty("ccRecipients")]
        public string CC { get; set; }

        [JsonProperty("bccRecipients")]
        public string BCC { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("importance")]
        public GraphClientReceiveMessageImportanceType Importance { get; set; }

        [JsonProperty("bodyPreview")]
        public string BodyPreview { get; set; }

        [JsonProperty("hasAttachments")]
        public bool HasAttachment { get; set; }

        [JsonProperty("id")]
        public string MessageId { get; set; }

        [JsonProperty("internetMessageId")]
        public string InternetMessageId { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }

        [JsonProperty("receivedDateTime")]
        public string ReceivedTime { get; set; }

        [JsonProperty("isRead")]
        public bool IsRead { get; set; }

        [JsonProperty("attachments")]
        public GraphClientReceiveFileAttachment[] Attachments { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHTML { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public enum GraphClientReceiveMessageImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public class GraphClientReceiveFileAttachment
    {
        [JsonProperty("id")]
        public string AttachmentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contentBytes")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("isInline")]
        public bool IsInline { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }
    }

    public class BatchResponseGraphClientReceiveMessage
    {
        [JsonProperty("value")]
        public GraphClientReceiveMessage[] Value { get; set; }
    }

    public enum importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public class EntityListResponseGraphCalendarEventClientReceive
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientReceive[] Value { get; set; }
    }

    public class GetMailTipsV2Response
    {
        [JsonProperty("value")]
        public MailTipsClientReceiveV2[] Value { get; set; }
    }

    public class MailTipsClientReceiveV2
    {
        [JsonProperty("automaticReplies")]
        public MailTipsAutomaticRepliesV2 AutomaticReplies { get; set; }

        [JsonProperty("deliveryRestricted")]
        public bool IsDeliveryRestricted { get; set; }

        [JsonProperty("isModerated")]
        public bool IsModerated { get; set; }

        [JsonProperty("mailboxFull")]
        public bool IsMailboxFull { get; set; }

        [JsonProperty("maxMessageSize")]
        public int MaximumMessageSize { get; set; }

        [JsonProperty("totalMemberCount")]
        public int TotalMemberCount { get; set; }
    }

    public class MailTipsAutomaticRepliesV2
    {
        [JsonProperty("message")]
        public string AutomaticRepliesMessage { get; set; }
    }

    public class GetRoomListsV2Response
    {
        [JsonProperty("value")]
        public GetRoomListsV2ResponseValueTypeItem[] Value { get; set; }
    }

    public class GetRoomListsV2ResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class GetRoomsV2Response
    {
        [JsonProperty("value")]
        public GetRoomsV2ResponseValueTypeItem[] Value { get; set; }
    }

    public class GetRoomsV2ResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class GetRoomsInRoomListV2Response
    {
        [JsonProperty("value")]
        public GetRoomsInRoomListV2ResponseValueTypeItem[] Value { get; set; }
    }

    public class GetRoomsInRoomListV2ResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public enum replyParametersimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum responseInput
    {
        [EnumMember(Value = "accept")]
        Accept,
        [EnumMember(Value = "tentativelyAccept")]
        TentativelyAccept,
        [EnumMember(Value = "decline")]
        Decline
    }

    public enum emailMessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class SetAutomaticRepliesSettingV2Response
    {
        [JsonProperty("automaticRepliesSetting")]
        public AutomaticRepliesSettingClientV2 AutomaticRepliesSetting { get; set; }
    }

    public class AutomaticRepliesSettingClientV2
    {
        [JsonProperty("status")]
        public AutomaticRepliesSettingClientV2StatusType Status { get; set; }

        [JsonProperty("externalAudience")]
        public AutomaticRepliesSettingClientV2ExternalAudienceType ExternalAudience { get; set; }

        [JsonProperty("scheduledStartDateTime")]
        public AutomaticRepliesSettingClientV2StartTimeType StartTime { get; set; }

        [JsonProperty("scheduledEndDateTime")]
        public AutomaticRepliesSettingClientV2EndTimeType EndTime { get; set; }

        [JsonProperty("internalReplyMessage")]
        public string InternalReplyMessage { get; set; }

        [JsonProperty("externalReplyMessage")]
        public string ExternalReplyMessage { get; set; }
    }

    public enum AutomaticRepliesSettingClientV2StatusType
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled
    }

    public enum AutomaticRepliesSettingClientV2ExternalAudienceType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "contactsOnly")]
        ContactsOnly,
        [EnumMember(Value = "all")]
        All
    }

    public class AutomaticRepliesSettingClientV2StartTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class AutomaticRepliesSettingClientV2EndTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public enum bodyautomaticRepliesSettingstatusInput
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled
    }

    public enum bodyautomaticRepliesSettingexternalAudienceInput
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "contactsOnly")]
        ContactsOnly,
        [EnumMember(Value = "all")]
        All
    }

    public class GraphCalendarEventListWithActionType
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientWithActionType[] Value { get; set; }
    }

    public class GraphCalendarEventClientWithActionType
    {
        public GraphCalendarEventClientWithActionTypeActionTypeType ActionType { get; set; }
        public bool IsAdded { get; set; }
        public bool IsUpdated { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }

        [JsonProperty("end")]
        public string EndTime { get; set; }

        [JsonProperty("startWithTimeZone")]
        public string StartTimeWithTimeZone { get; set; }

        [JsonProperty("endWithTimeZone")]
        public string EndTimeWithTimeZone { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHTML { get; set; }

        [JsonProperty("responseType")]
        public GraphCalendarEventClientWithActionTypeResponseTypeType ResponseType { get; set; }

        [JsonProperty("responseTime")]
        public string ResponseTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("seriesMasterId")]
        public string SeriesMasterId { get; set; }

        [JsonProperty("iCalUId")]
        public string ICalUId { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        [JsonProperty("requiredAttendees")]
        public string RequiredAttendees { get; set; }

        [JsonProperty("optionalAttendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("resourceAttendees")]
        public string ResourceAttendees { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("importance")]
        public GraphCalendarEventClientWithActionTypeImportanceType Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("recurrence")]
        public GraphCalendarEventClientWithActionTypeRecurrenceType Recurrence { get; set; }

        [JsonProperty("recurrenceEnd")]
        public string RecurrenceEndDate { get; set; }

        [JsonProperty("numberOfOccurences")]
        public int NumberOfOccurrences { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int Reminder { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("showAs")]
        public GraphCalendarEventClientWithActionTypeShowAsType ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("sensitivity")]
        public GraphCalendarEventClientWithActionTypeSensitivityType Sensitivity { get; set; }
    }

    public enum GraphCalendarEventClientWithActionTypeActionTypeType
    {
        [EnumMember(Value = "added")]
        Added,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "deleted")]
        Deleted
    }

    public enum GraphCalendarEventClientWithActionTypeResponseTypeType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "organizer")]
        Organizer,
        [EnumMember(Value = "tentativelyAccepted")]
        TentativelyAccepted,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "notResponded")]
        NotResponded
    }

    public enum GraphCalendarEventClientWithActionTypeImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public enum GraphCalendarEventClientWithActionTypeRecurrenceType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "monthly")]
        Monthly,
        [EnumMember(Value = "yearly")]
        Yearly
    }

    public enum GraphCalendarEventClientWithActionTypeShowAsType
    {
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "oof")]
        Oof,
        [EnumMember(Value = "workingElsewhere")]
        WorkingElsewhere,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    public enum GraphCalendarEventClientWithActionTypeSensitivityType
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "confidential")]
        Confidential
    }

    public class TriggerBatchResponseGraphClientReceiveMessage
    {
        [JsonProperty("value")]
        public GraphClientReceiveMessage[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365;

    public partial class WorkflowManagedActions
    {
        public Office365Actions Office365(string connectionId) => new Office365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Office365Triggers Office365(string connectionId) => new Office365Triggers(connectionId);
    }
}