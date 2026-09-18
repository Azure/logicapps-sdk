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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GraphOutlookCategory[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<OutlookReceiveMessage> DraftEmail([WorkflowExpression] Func<string> draftMessageto, [WorkflowExpression] Func<string> draftMessagesubject, [WorkflowExpression] Func<string> draftMessagebody, [WorkflowExpression] Func<string> draftMessagefromSendAs = null, [WorkflowExpression] Func<string> draftMessagecC = null, [WorkflowExpression] Func<string> draftMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> draftMessageattachments = null, [WorkflowExpression] Func<string> draftMessagesensitivity = null, [WorkflowExpression] Func<string> draftMessagereplyTo = null, [WorkflowExpression] Func<draftMessageimportanceInput> draftMessageimportance = null, [WorkflowExpression] Func<string> messageId = null, [WorkflowExpression] Func<string> draftType = null, [WorkflowExpression] Func<string> comment = null)
        {
            SourceExpression.Validate(draftMessageto, nameof(draftMessageto), required: true);
            SourceExpression.Validate(draftMessagesubject, nameof(draftMessagesubject), required: true);
            SourceExpression.Validate(draftMessagebody, nameof(draftMessagebody), required: true);
            SourceExpression.Validate(draftMessagefromSendAs, nameof(draftMessagefromSendAs), required: false);
            SourceExpression.Validate(draftMessagecC, nameof(draftMessagecC), required: false);
            SourceExpression.Validate(draftMessagebCC, nameof(draftMessagebCC), required: false);
            SourceExpression.Validate(draftMessageattachments, nameof(draftMessageattachments), required: false);
            SourceExpression.Validate(draftMessagesensitivity, nameof(draftMessagesensitivity), required: false);
            SourceExpression.Validate(draftMessagereplyTo, nameof(draftMessagereplyTo), required: false);
            SourceExpression.Validate(draftMessageimportance, nameof(draftMessageimportance), required: false);
            SourceExpression.Validate(messageId, nameof(messageId), required: false);
            SourceExpression.Validate(draftType, nameof(draftType), required: false);
            SourceExpression.Validate(comment, nameof(comment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (messageId != null)
                    callPayload.Queries["messageId"] = SourceExpressionConverter.ConvertO(messageId);
                if (draftType != null)
                    callPayload.Queries["draftType"] = SourceExpressionConverter.ConvertO(draftType);
                if (comment != null)
                    callPayload.Queries["comment"] = SourceExpressionConverter.ConvertO(comment);
                var draftMessage = new JObject();
                var draftMessagepropCount = 0;
                draftMessagepropCount++;
                draftMessage["To"] = SourceExpressionConverter.ConvertToken(draftMessageto);
                draftMessagepropCount++;
                draftMessage["Subject"] = SourceExpressionConverter.ConvertToken(draftMessagesubject);
                draftMessagepropCount++;
                draftMessage["Body"] = SourceExpressionConverter.ConvertToken(draftMessagebody);
                if (draftMessagefromSendAs != null)
                {
                    draftMessage["From"] = SourceExpressionConverter.ConvertToken(draftMessagefromSendAs);
                    draftMessagepropCount++;
                }

                if (draftMessagecC != null)
                {
                    draftMessage["Cc"] = SourceExpressionConverter.ConvertToken(draftMessagecC);
                    draftMessagepropCount++;
                }

                if (draftMessagebCC != null)
                {
                    draftMessage["Bcc"] = SourceExpressionConverter.ConvertToken(draftMessagebCC);
                    draftMessagepropCount++;
                }

                if (draftMessageattachments != null)
                {
                    draftMessage["Attachments"] = SourceExpressionConverter.ConvertToken(draftMessageattachments);
                    draftMessagepropCount++;
                }

                if (draftMessagesensitivity != null)
                {
                    draftMessage["Sensitivity"] = SourceExpressionConverter.ConvertToken(draftMessagesensitivity);
                    draftMessagepropCount++;
                }

                if (draftMessagereplyTo != null)
                {
                    draftMessage["ReplyTo"] = SourceExpressionConverter.ConvertToken(draftMessagereplyTo);
                    draftMessagepropCount++;
                }

                if (draftMessageimportance != null)
                {
                    if (draftMessageimportance != null)
                    {
                        draftMessage["Importance"] = SourceExpressionConverter.Convert(draftMessageimportance);
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
                return callPayload;
            }

            return new ApiConnectionAction<OutlookReceiveMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateDraftEmail([WorkflowExpression] Func<string> draftMessageto, [WorkflowExpression] Func<string> draftMessagesubject, [WorkflowExpression] Func<string> draftMessagebody, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> draftMessagefromSendAs = null, [WorkflowExpression] Func<string> draftMessagecC = null, [WorkflowExpression] Func<string> draftMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> draftMessageattachments = null, [WorkflowExpression] Func<string> draftMessagesensitivity = null, [WorkflowExpression] Func<string> draftMessagereplyTo = null, [WorkflowExpression] Func<draftMessageimportanceInput> draftMessageimportance = null)
        {
            SourceExpression.Validate(draftMessageto, nameof(draftMessageto), required: true);
            SourceExpression.Validate(draftMessagesubject, nameof(draftMessagesubject), required: true);
            SourceExpression.Validate(draftMessagebody, nameof(draftMessagebody), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(draftMessagefromSendAs, nameof(draftMessagefromSendAs), required: false);
            SourceExpression.Validate(draftMessagecC, nameof(draftMessagecC), required: false);
            SourceExpression.Validate(draftMessagebCC, nameof(draftMessagebCC), required: false);
            SourceExpression.Validate(draftMessageattachments, nameof(draftMessageattachments), required: false);
            SourceExpression.Validate(draftMessagesensitivity, nameof(draftMessagesensitivity), required: false);
            SourceExpression.Validate(draftMessagereplyTo, nameof(draftMessagereplyTo), required: false);
            SourceExpression.Validate(draftMessageimportance, nameof(draftMessageimportance), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Draft";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = SourceExpressionConverter.ConvertO(messageId);
                var draftMessage = new JObject();
                var draftMessagepropCount = 0;
                draftMessagepropCount++;
                draftMessage["To"] = SourceExpressionConverter.ConvertToken(draftMessageto);
                draftMessagepropCount++;
                draftMessage["Subject"] = SourceExpressionConverter.ConvertToken(draftMessagesubject);
                draftMessagepropCount++;
                draftMessage["Body"] = SourceExpressionConverter.ConvertToken(draftMessagebody);
                if (draftMessagefromSendAs != null)
                {
                    draftMessage["From"] = SourceExpressionConverter.ConvertToken(draftMessagefromSendAs);
                    draftMessagepropCount++;
                }

                if (draftMessagecC != null)
                {
                    draftMessage["Cc"] = SourceExpressionConverter.ConvertToken(draftMessagecC);
                    draftMessagepropCount++;
                }

                if (draftMessagebCC != null)
                {
                    draftMessage["Bcc"] = SourceExpressionConverter.ConvertToken(draftMessagebCC);
                    draftMessagepropCount++;
                }

                if (draftMessageattachments != null)
                {
                    draftMessage["Attachments"] = SourceExpressionConverter.ConvertToken(draftMessageattachments);
                    draftMessagepropCount++;
                }

                if (draftMessagesensitivity != null)
                {
                    draftMessage["Sensitivity"] = SourceExpressionConverter.ConvertToken(draftMessagesensitivity);
                    draftMessagepropCount++;
                }

                if (draftMessagereplyTo != null)
                {
                    draftMessage["ReplyTo"] = SourceExpressionConverter.ConvertToken(draftMessagereplyTo);
                    draftMessagepropCount++;
                }

                if (draftMessageimportance != null)
                {
                    if (draftMessageimportance != null)
                    {
                        draftMessage["Importance"] = SourceExpressionConverter.Convert(draftMessageimportance);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendDraftEmail([WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Draft/Send/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction AssignCategory([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> category)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(category, nameof(category), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Mail/Category";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = SourceExpressionConverter.ConvertO(messageId);
                callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchOperationResult> AssignCategoryBulk([WorkflowExpression] Func<string> categoryName, [WorkflowExpression] Func<string[]> messageIds = null)
        {
            SourceExpression.Validate(categoryName, nameof(categoryName), required: true);
            SourceExpression.Validate(messageIds, nameof(messageIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/Category/Bulk/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(messageIds);
                return callPayload;
            }

            return new ApiConnectionAction<BatchOperationResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions([WorkflowExpression] Func<string> optionsEmailSubscriptionmessageto, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<optionsEmailSubscriptionmessageimportanceInput> optionsEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> optionsEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessagehideMicrosoftFooter = null)
        {
            SourceExpression.Validate(optionsEmailSubscriptionmessageto, nameof(optionsEmailSubscriptionmessageto), required: true);
            SourceExpression.Validate(optionsEmailSubscriptionmessagesubject, nameof(optionsEmailSubscriptionmessagesubject), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessageuserOptions, nameof(optionsEmailSubscriptionmessageuserOptions), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessageheaderText, nameof(optionsEmailSubscriptionmessageheaderText), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessageselectionText, nameof(optionsEmailSubscriptionmessageselectionText), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessagebody, nameof(optionsEmailSubscriptionmessagebody), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessageimportance, nameof(optionsEmailSubscriptionmessageimportance), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessageattachments, nameof(optionsEmailSubscriptionmessageattachments), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(optionsEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessagehideHTMLMessage, nameof(optionsEmailSubscriptionmessagehideHTMLMessage), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
            SourceExpression.Validate(optionsEmailSubscriptionmessagehideMicrosoftFooter, nameof(optionsEmailSubscriptionmessagehideMicrosoftFooter), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                messageObject["To"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageto);
                if (optionsEmailSubscriptionmessagesubject != null)
                {
                    if (optionsEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagesubject);
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
                        messageObject["Options"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuserOptions);
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
                    messageObject["HeaderText"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageimportance != null)
                {
                    if (optionsEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = SourceExpressionConverter.Convert(optionsEmailSubscriptionmessageimportance);
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
                    messageObject["Attachments"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagehideHTMLMessage);
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
                        messageObject["ShowHTMLConfirmationDialog"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog);
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
                        messageObject["HideMicrosoftFooter"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagehideMicrosoftFooter);
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
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail([WorkflowExpression] Func<string> approvalEmailSubscriptionmessageto, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<approvalEmailSubscriptionmessageimportanceInput> approvalEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> approvalEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            SourceExpression.Validate(approvalEmailSubscriptionmessageto, nameof(approvalEmailSubscriptionmessageto), required: true);
            SourceExpression.Validate(approvalEmailSubscriptionmessagesubject, nameof(approvalEmailSubscriptionmessagesubject), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessageuserOptions, nameof(approvalEmailSubscriptionmessageuserOptions), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessageheaderText, nameof(approvalEmailSubscriptionmessageheaderText), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessageselectionText, nameof(approvalEmailSubscriptionmessageselectionText), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessagebody, nameof(approvalEmailSubscriptionmessagebody), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessageimportance, nameof(approvalEmailSubscriptionmessageimportance), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessageattachments, nameof(approvalEmailSubscriptionmessageattachments), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(approvalEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessagehideHTMLMessage, nameof(approvalEmailSubscriptionmessagehideHTMLMessage), required: false);
            SourceExpression.Validate(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                messageObject["To"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageto);
                if (approvalEmailSubscriptionmessagesubject != null)
                {
                    if (approvalEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagesubject);
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
                        messageObject["Options"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuserOptions);
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
                    messageObject["HeaderText"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageimportance != null)
                {
                    if (approvalEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = SourceExpressionConverter.Convert(approvalEmailSubscriptionmessageimportance);
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
                    messageObject["Attachments"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagehideHTMLMessage);
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
                        messageObject["ShowHTMLConfirmationDialog"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog);
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
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateMyContactPhoto([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(folder, nameof(folder), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}/photo/$value", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("image/jpeg");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            SourceExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            SourceExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            SourceExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            SourceExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = SourceExpressionConverter.ConvertO(uri);
                callPayload.Headers["Method"] = SourceExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = SourceExpressionConverter.ConvertO(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = SourceExpressionConverter.ConvertO(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = SourceExpressionConverter.ConvertO(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = SourceExpressionConverter.ConvertO(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = SourceExpressionConverter.ConvertO(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = SourceExpressionConverter.ConvertO(customHeader5);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpEmailsManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            SourceExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            SourceExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            SourceExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp/EmailsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
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
                return callPayload;
            }

            return new ApiConnectionAction<MCPQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpMeetingManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            SourceExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            SourceExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            SourceExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp/MeetingManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
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
                return callPayload;
            }

            return new ApiConnectionAction<MCPQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpContactsManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            SourceExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            SourceExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            SourceExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp/ContactsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
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
                return callPayload;
            }

            return new ApiConnectionAction<MCPQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction CalendarDeleteItem([WorkflowExpression] Func<string> calendar, [WorkflowExpression] Func<string> @event)
        {
            SourceExpression.Validate(calendar, nameof(calendar), required: true);
            SourceExpression.Validate(@event, nameof(@event), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/calendars/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendar, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@event, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarGetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GraphCalendarEventClientReceive>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventListClientReceive> CalendarGetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<GraphCalendarEventListClientReceive>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<CalendarGetTablesV2Response> CalendarGetTables()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/v1.0/me/calendars";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["skip"] = Convert.ToString(0);
                callPayload.Queries["top"] = Convert.ToString(256);
                callPayload.Queries["orderBy"] = Convert.ToString("name");
                return callPayload;
            }

            return new ApiConnectionAction<CalendarGetTablesV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarPatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<itemselectedDaysOfWeekInputItem[]> itemselectedDaysOfWeek = null, [WorkflowExpression] Func<string> itemrecurrenceEndDate = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<bool> itemisReminderOn = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null, [WorkflowExpression] Func<itemsensitivityInput> itemsensitivity = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(itemsubject, nameof(itemsubject), required: true);
            SourceExpression.Validate(itemstartTime, nameof(itemstartTime), required: true);
            SourceExpression.Validate(itemendTime, nameof(itemendTime), required: true);
            SourceExpression.Validate(itemtimeZone, nameof(itemtimeZone), required: true);
            SourceExpression.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            SourceExpression.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            SourceExpression.Validate(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            SourceExpression.Validate(itembody, nameof(itembody), required: false);
            SourceExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            SourceExpression.Validate(itemlocation, nameof(itemlocation), required: false);
            SourceExpression.Validate(itemimportance, nameof(itemimportance), required: false);
            SourceExpression.Validate(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            SourceExpression.Validate(itemrecurrence, nameof(itemrecurrence), required: false);
            SourceExpression.Validate(itemselectedDaysOfWeek, nameof(itemselectedDaysOfWeek), required: false);
            SourceExpression.Validate(itemrecurrenceEndDate, nameof(itemrecurrenceEndDate), required: false);
            SourceExpression.Validate(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            SourceExpression.Validate(itemreminder, nameof(itemreminder), required: false);
            SourceExpression.Validate(itemisReminderOn, nameof(itemisReminderOn), required: false);
            SourceExpression.Validate(itemshowAs, nameof(itemshowAs), required: false);
            SourceExpression.Validate(itemresponseRequested, nameof(itemresponseRequested), required: false);
            SourceExpression.Validate(itemsensitivity, nameof(itemsensitivity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = SourceExpressionConverter.ConvertToken(itemsubject);
                itempropCount++;
                item["start"] = SourceExpressionConverter.ConvertToken(itemstartTime);
                itempropCount++;
                item["end"] = SourceExpressionConverter.ConvertToken(itemendTime);
                itempropCount++;
                item["timeZone"] = SourceExpressionConverter.Convert(itemtimeZone);
                if (itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = SourceExpressionConverter.ConvertToken(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = SourceExpressionConverter.ConvertToken(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["resourceAttendees"] = SourceExpressionConverter.ConvertToken(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["body"] = SourceExpressionConverter.ConvertToken(itembody);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = SourceExpressionConverter.ConvertToken(itemcategories);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["location"] = SourceExpressionConverter.ConvertToken(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["importance"] = SourceExpressionConverter.Convert(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["isAllDay"] = SourceExpressionConverter.ConvertToken(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["recurrence"] = SourceExpressionConverter.Convert(itemrecurrence);
                    itempropCount++;
                }

                if (itemselectedDaysOfWeek != null)
                {
                    item["selectedDaysOfWeek"] = SourceExpressionConverter.ConvertToken(itemselectedDaysOfWeek);
                    itempropCount++;
                }

                if (itemrecurrenceEndDate != null)
                {
                    item["recurrenceEnd"] = SourceExpressionConverter.ConvertToken(itemrecurrenceEndDate);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["numberOfOccurences"] = SourceExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["reminderMinutesBeforeStart"] = SourceExpressionConverter.ConvertToken(itemreminder);
                    itempropCount++;
                }

                if (itemisReminderOn != null)
                {
                    item["isReminderOn"] = SourceExpressionConverter.ConvertToken(itemisReminderOn);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["showAs"] = SourceExpressionConverter.Convert(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["responseRequested"] = SourceExpressionConverter.ConvertToken(itemresponseRequested);
                    itempropCount++;
                }

                if (itemsensitivity != null)
                {
                    item["sensitivity"] = SourceExpressionConverter.Convert(itemsensitivity);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GraphCalendarEventClientReceive>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarPostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<itemselectedDaysOfWeekInputItem[]> itemselectedDaysOfWeek = null, [WorkflowExpression] Func<string> itemrecurrenceEndDate = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<bool> itemisReminderOn = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null, [WorkflowExpression] Func<itemsensitivityInput> itemsensitivity = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(itemsubject, nameof(itemsubject), required: true);
            SourceExpression.Validate(itemstartTime, nameof(itemstartTime), required: true);
            SourceExpression.Validate(itemendTime, nameof(itemendTime), required: true);
            SourceExpression.Validate(itemtimeZone, nameof(itemtimeZone), required: true);
            SourceExpression.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            SourceExpression.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            SourceExpression.Validate(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            SourceExpression.Validate(itembody, nameof(itembody), required: false);
            SourceExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            SourceExpression.Validate(itemlocation, nameof(itemlocation), required: false);
            SourceExpression.Validate(itemimportance, nameof(itemimportance), required: false);
            SourceExpression.Validate(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            SourceExpression.Validate(itemrecurrence, nameof(itemrecurrence), required: false);
            SourceExpression.Validate(itemselectedDaysOfWeek, nameof(itemselectedDaysOfWeek), required: false);
            SourceExpression.Validate(itemrecurrenceEndDate, nameof(itemrecurrenceEndDate), required: false);
            SourceExpression.Validate(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            SourceExpression.Validate(itemreminder, nameof(itemreminder), required: false);
            SourceExpression.Validate(itemisReminderOn, nameof(itemisReminderOn), required: false);
            SourceExpression.Validate(itemshowAs, nameof(itemshowAs), required: false);
            SourceExpression.Validate(itemresponseRequested, nameof(itemresponseRequested), required: false);
            SourceExpression.Validate(itemsensitivity, nameof(itemsensitivity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = SourceExpressionConverter.ConvertToken(itemsubject);
                itempropCount++;
                item["start"] = SourceExpressionConverter.ConvertToken(itemstartTime);
                itempropCount++;
                item["end"] = SourceExpressionConverter.ConvertToken(itemendTime);
                itempropCount++;
                item["timeZone"] = SourceExpressionConverter.Convert(itemtimeZone);
                if (itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = SourceExpressionConverter.ConvertToken(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = SourceExpressionConverter.ConvertToken(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["resourceAttendees"] = SourceExpressionConverter.ConvertToken(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["body"] = SourceExpressionConverter.ConvertToken(itembody);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = SourceExpressionConverter.ConvertToken(itemcategories);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["location"] = SourceExpressionConverter.ConvertToken(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["importance"] = SourceExpressionConverter.Convert(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["isAllDay"] = SourceExpressionConverter.ConvertToken(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["recurrence"] = SourceExpressionConverter.Convert(itemrecurrence);
                    itempropCount++;
                }

                if (itemselectedDaysOfWeek != null)
                {
                    item["selectedDaysOfWeek"] = SourceExpressionConverter.ConvertToken(itemselectedDaysOfWeek);
                    itempropCount++;
                }

                if (itemrecurrenceEndDate != null)
                {
                    item["recurrenceEnd"] = SourceExpressionConverter.ConvertToken(itemrecurrenceEndDate);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["numberOfOccurences"] = SourceExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["reminderMinutesBeforeStart"] = SourceExpressionConverter.ConvertToken(itemreminder);
                    itempropCount++;
                }

                if (itemisReminderOn != null)
                {
                    item["isReminderOn"] = SourceExpressionConverter.ConvertToken(itemisReminderOn);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["showAs"] = SourceExpressionConverter.Convert(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["responseRequested"] = SourceExpressionConverter.ConvertToken(itemresponseRequested);
                    itempropCount++;
                }

                if (itemsensitivity != null)
                {
                    item["sensitivity"] = SourceExpressionConverter.Convert(itemsensitivity);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GraphCalendarEventClientReceive>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ContactDeleteItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(folder, nameof(folder), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactGetItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(folder, nameof(folder), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseContactResponseV2> ContactGetItems([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(folder, nameof(folder), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<EntityListResponseContactResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphContactFolder> ContactGetTables()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/datasets/contacts/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EntityListResponseGraphContactFolder>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactPatchItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddressV2[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            SourceExpression.Validate(folder, nameof(folder), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(itemgivenName, nameof(itemgivenName), required: true);
            SourceExpression.Validate(itemhomePhones, nameof(itemhomePhones), required: true);
            SourceExpression.Validate(itemid, nameof(itemid), required: false);
            SourceExpression.Validate(itemparentFolderId, nameof(itemparentFolderId), required: false);
            SourceExpression.Validate(itembirthday, nameof(itembirthday), required: false);
            SourceExpression.Validate(itemfileAs, nameof(itemfileAs), required: false);
            SourceExpression.Validate(itemdisplayName, nameof(itemdisplayName), required: false);
            SourceExpression.Validate(iteminitials, nameof(iteminitials), required: false);
            SourceExpression.Validate(itemmiddleName, nameof(itemmiddleName), required: false);
            SourceExpression.Validate(itemnickname, nameof(itemnickname), required: false);
            SourceExpression.Validate(itemsurname, nameof(itemsurname), required: false);
            SourceExpression.Validate(itemtitle, nameof(itemtitle), required: false);
            SourceExpression.Validate(itemgeneration, nameof(itemgeneration), required: false);
            SourceExpression.Validate(itememailAddresses, nameof(itememailAddresses), required: false);
            SourceExpression.Validate(itemiMAddresses, nameof(itemiMAddresses), required: false);
            SourceExpression.Validate(itemjobTitle, nameof(itemjobTitle), required: false);
            SourceExpression.Validate(itemcompanyName, nameof(itemcompanyName), required: false);
            SourceExpression.Validate(itemdepartment, nameof(itemdepartment), required: false);
            SourceExpression.Validate(itemofficeLocation, nameof(itemofficeLocation), required: false);
            SourceExpression.Validate(itemprofession, nameof(itemprofession), required: false);
            SourceExpression.Validate(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            SourceExpression.Validate(itemassistantName, nameof(itemassistantName), required: false);
            SourceExpression.Validate(itemmanager, nameof(itemmanager), required: false);
            SourceExpression.Validate(itembusinessPhones, nameof(itembusinessPhones), required: false);
            SourceExpression.Validate(itemmobilePhone, nameof(itemmobilePhone), required: false);
            SourceExpression.Validate(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            SourceExpression.Validate(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            SourceExpression.Validate(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            SourceExpression.Validate(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            SourceExpression.Validate(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            SourceExpression.Validate(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            SourceExpression.Validate(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            SourceExpression.Validate(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            SourceExpression.Validate(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            SourceExpression.Validate(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            SourceExpression.Validate(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            SourceExpression.Validate(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            SourceExpression.Validate(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            SourceExpression.Validate(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            SourceExpression.Validate(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            SourceExpression.Validate(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            SourceExpression.Validate(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            SourceExpression.Validate(itemyomiSurname, nameof(itemyomiSurname), required: false);
            SourceExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            SourceExpression.Validate(itemchangeKey, nameof(itemchangeKey), required: false);
            SourceExpression.Validate(itemcreatedTime, nameof(itemcreatedTime), required: false);
            SourceExpression.Validate(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["id"] = SourceExpressionConverter.ConvertToken(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["parentFolderId"] = SourceExpressionConverter.ConvertToken(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["birthday"] = SourceExpressionConverter.ConvertToken(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["fileAs"] = SourceExpressionConverter.ConvertToken(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["displayName"] = SourceExpressionConverter.ConvertToken(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["givenName"] = SourceExpressionConverter.ConvertToken(itemgivenName);
                if (iteminitials != null)
                {
                    item["initials"] = SourceExpressionConverter.ConvertToken(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["middleName"] = SourceExpressionConverter.ConvertToken(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["nickName"] = SourceExpressionConverter.ConvertToken(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["surname"] = SourceExpressionConverter.ConvertToken(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["title"] = SourceExpressionConverter.ConvertToken(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["generation"] = SourceExpressionConverter.ConvertToken(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["emailAddresses"] = SourceExpressionConverter.ConvertToken(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["imAddresses"] = SourceExpressionConverter.ConvertToken(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["jobTitle"] = SourceExpressionConverter.ConvertToken(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["companyName"] = SourceExpressionConverter.ConvertToken(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["department"] = SourceExpressionConverter.ConvertToken(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["officeLocation"] = SourceExpressionConverter.ConvertToken(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["profession"] = SourceExpressionConverter.ConvertToken(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["businessHomePage"] = SourceExpressionConverter.ConvertToken(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["assistantName"] = SourceExpressionConverter.ConvertToken(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["manager"] = SourceExpressionConverter.ConvertToken(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["homePhones"] = SourceExpressionConverter.ConvertToken(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["businessPhones"] = SourceExpressionConverter.ConvertToken(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["mobilePhone"] = SourceExpressionConverter.ConvertToken(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["city"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["state"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["countryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["postalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                    businessAddressObject["street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["city"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["state"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["countryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["postalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                    otherAddressObject["street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["city"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["state"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["countryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["postalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["otherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["yomiCompanyName"] = SourceExpressionConverter.ConvertToken(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["yomiGivenName"] = SourceExpressionConverter.ConvertToken(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["yomiSurname"] = SourceExpressionConverter.ConvertToken(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = SourceExpressionConverter.ConvertToken(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["changeKey"] = SourceExpressionConverter.ConvertToken(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["createdDateTime"] = SourceExpressionConverter.ConvertToken(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["lastModifiedDateTime"] = SourceExpressionConverter.ConvertToken(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactPostItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddressV2[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            SourceExpression.Validate(folder, nameof(folder), required: true);
            SourceExpression.Validate(itemgivenName, nameof(itemgivenName), required: true);
            SourceExpression.Validate(itemhomePhones, nameof(itemhomePhones), required: true);
            SourceExpression.Validate(itemid, nameof(itemid), required: false);
            SourceExpression.Validate(itemparentFolderId, nameof(itemparentFolderId), required: false);
            SourceExpression.Validate(itembirthday, nameof(itembirthday), required: false);
            SourceExpression.Validate(itemfileAs, nameof(itemfileAs), required: false);
            SourceExpression.Validate(itemdisplayName, nameof(itemdisplayName), required: false);
            SourceExpression.Validate(iteminitials, nameof(iteminitials), required: false);
            SourceExpression.Validate(itemmiddleName, nameof(itemmiddleName), required: false);
            SourceExpression.Validate(itemnickname, nameof(itemnickname), required: false);
            SourceExpression.Validate(itemsurname, nameof(itemsurname), required: false);
            SourceExpression.Validate(itemtitle, nameof(itemtitle), required: false);
            SourceExpression.Validate(itemgeneration, nameof(itemgeneration), required: false);
            SourceExpression.Validate(itememailAddresses, nameof(itememailAddresses), required: false);
            SourceExpression.Validate(itemiMAddresses, nameof(itemiMAddresses), required: false);
            SourceExpression.Validate(itemjobTitle, nameof(itemjobTitle), required: false);
            SourceExpression.Validate(itemcompanyName, nameof(itemcompanyName), required: false);
            SourceExpression.Validate(itemdepartment, nameof(itemdepartment), required: false);
            SourceExpression.Validate(itemofficeLocation, nameof(itemofficeLocation), required: false);
            SourceExpression.Validate(itemprofession, nameof(itemprofession), required: false);
            SourceExpression.Validate(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            SourceExpression.Validate(itemassistantName, nameof(itemassistantName), required: false);
            SourceExpression.Validate(itemmanager, nameof(itemmanager), required: false);
            SourceExpression.Validate(itembusinessPhones, nameof(itembusinessPhones), required: false);
            SourceExpression.Validate(itemmobilePhone, nameof(itemmobilePhone), required: false);
            SourceExpression.Validate(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            SourceExpression.Validate(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            SourceExpression.Validate(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            SourceExpression.Validate(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            SourceExpression.Validate(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            SourceExpression.Validate(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            SourceExpression.Validate(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            SourceExpression.Validate(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            SourceExpression.Validate(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            SourceExpression.Validate(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            SourceExpression.Validate(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            SourceExpression.Validate(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            SourceExpression.Validate(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            SourceExpression.Validate(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            SourceExpression.Validate(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            SourceExpression.Validate(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            SourceExpression.Validate(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            SourceExpression.Validate(itemyomiSurname, nameof(itemyomiSurname), required: false);
            SourceExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            SourceExpression.Validate(itemchangeKey, nameof(itemchangeKey), required: false);
            SourceExpression.Validate(itemcreatedTime, nameof(itemcreatedTime), required: false);
            SourceExpression.Validate(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folder, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["id"] = SourceExpressionConverter.ConvertToken(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["parentFolderId"] = SourceExpressionConverter.ConvertToken(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["birthday"] = SourceExpressionConverter.ConvertToken(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["fileAs"] = SourceExpressionConverter.ConvertToken(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["displayName"] = SourceExpressionConverter.ConvertToken(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["givenName"] = SourceExpressionConverter.ConvertToken(itemgivenName);
                if (iteminitials != null)
                {
                    item["initials"] = SourceExpressionConverter.ConvertToken(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["middleName"] = SourceExpressionConverter.ConvertToken(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["nickName"] = SourceExpressionConverter.ConvertToken(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["surname"] = SourceExpressionConverter.ConvertToken(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["title"] = SourceExpressionConverter.ConvertToken(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["generation"] = SourceExpressionConverter.ConvertToken(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["emailAddresses"] = SourceExpressionConverter.ConvertToken(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["imAddresses"] = SourceExpressionConverter.ConvertToken(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["jobTitle"] = SourceExpressionConverter.ConvertToken(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["companyName"] = SourceExpressionConverter.ConvertToken(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["department"] = SourceExpressionConverter.ConvertToken(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["officeLocation"] = SourceExpressionConverter.ConvertToken(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["profession"] = SourceExpressionConverter.ConvertToken(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["businessHomePage"] = SourceExpressionConverter.ConvertToken(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["assistantName"] = SourceExpressionConverter.ConvertToken(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["manager"] = SourceExpressionConverter.ConvertToken(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["homePhones"] = SourceExpressionConverter.ConvertToken(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["businessPhones"] = SourceExpressionConverter.ConvertToken(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["mobilePhone"] = SourceExpressionConverter.ConvertToken(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["city"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["state"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["countryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["postalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                    businessAddressObject["street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["city"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["state"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["countryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["postalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                    otherAddressObject["street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["city"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["state"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["countryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["postalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["otherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["yomiCompanyName"] = SourceExpressionConverter.ConvertToken(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["yomiGivenName"] = SourceExpressionConverter.ConvertToken(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["yomiSurname"] = SourceExpressionConverter.ConvertToken(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = SourceExpressionConverter.ConvertToken(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["changeKey"] = SourceExpressionConverter.ConvertToken(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["createdDateTime"] = SourceExpressionConverter.ConvertToken(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["lastModifiedDateTime"] = SourceExpressionConverter.ConvertToken(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction DeleteEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<string> ExportEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/beta/me/messages/{0}/$value", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<FindMeetingTimesV2Response> FindMeetingTimes([WorkflowExpression] Func<string> bodyrequiredAttendees = null, [WorkflowExpression] Func<string> bodyoptionalAttendees = null, [WorkflowExpression] Func<string> bodyresourceAttendees = null, [WorkflowExpression] Func<int> bodymeetingDuration = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<int> bodymaxCandidates = null, [WorkflowExpression] Func<string> bodyminimumAttendeePercentage = null, [WorkflowExpression] Func<bool> bodyisOrganizerOptional = null, [WorkflowExpression] Func<bodyactivityDomainInput> bodyactivityDomain = null)
        {
            SourceExpression.Validate(bodyrequiredAttendees, nameof(bodyrequiredAttendees), required: false);
            SourceExpression.Validate(bodyoptionalAttendees, nameof(bodyoptionalAttendees), required: false);
            SourceExpression.Validate(bodyresourceAttendees, nameof(bodyresourceAttendees), required: false);
            SourceExpression.Validate(bodymeetingDuration, nameof(bodymeetingDuration), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodymaxCandidates, nameof(bodymaxCandidates), required: false);
            SourceExpression.Validate(bodyminimumAttendeePercentage, nameof(bodyminimumAttendeePercentage), required: false);
            SourceExpression.Validate(bodyisOrganizerOptional, nameof(bodyisOrganizerOptional), required: false);
            SourceExpression.Validate(bodyactivityDomain, nameof(bodyactivityDomain), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/beta/me/findMeetingTimes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequiredAttendees != null)
                {
                    body["RequiredAttendees"] = SourceExpressionConverter.ConvertToken(bodyrequiredAttendees);
                    bodypropCount++;
                }

                if (bodyoptionalAttendees != null)
                {
                    body["OptionalAttendees"] = SourceExpressionConverter.ConvertToken(bodyoptionalAttendees);
                    bodypropCount++;
                }

                if (bodyresourceAttendees != null)
                {
                    body["ResourceAttendees"] = SourceExpressionConverter.ConvertToken(bodyresourceAttendees);
                    bodypropCount++;
                }

                if (bodymeetingDuration != null)
                {
                    body["MeetingDuration"] = SourceExpressionConverter.ConvertToken(bodymeetingDuration);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["Start"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["End"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodymaxCandidates != null)
                {
                    body["MaxCandidates"] = SourceExpressionConverter.ConvertToken(bodymaxCandidates);
                    bodypropCount++;
                }

                if (bodyminimumAttendeePercentage != null)
                {
                    body["MinimumAttendeePercentage"] = SourceExpressionConverter.ConvertToken(bodyminimumAttendeePercentage);
                    bodypropCount++;
                }

                if (bodyisOrganizerOptional != null)
                {
                    body["IsOrganizerOptional"] = SourceExpressionConverter.ConvertToken(bodyisOrganizerOptional);
                    bodypropCount++;
                }

                if (bodyactivityDomain != null)
                {
                    if (bodyactivityDomain != null)
                    {
                        body["ActivityDomain"] = SourceExpressionConverter.Convert(bodyactivityDomain);
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
                return callPayload;
            }

            return new ApiConnectionAction<FindMeetingTimesV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction Flag([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bodyflagflagStatusInput> bodyflagflagStatus = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            SourceExpression.Validate(bodyflagflagStatus, nameof(bodyflagflagStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/flag", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                var flagObject = new JObject();
                var flagObjectpropCount = 0;
                if (bodyflagflagStatus != null)
                {
                    if (bodyflagflagStatus != null)
                    {
                        flagObject["flagStatus"] = SourceExpressionConverter.Convert(bodyflagflagStatus);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ForwardEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/forward", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToRecipients"] = SourceExpressionConverter.ConvertToken(bodyto);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetAttachmentV2Response> GetAttachment([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/attachments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                return callPayload;
            }

            return new ApiConnectionAction<GetAttachmentV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> GetEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> internetMessageId = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            SourceExpression.Validate(internetMessageId, nameof(internetMessageId), required: false);
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/Mail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (internetMessageId != null)
                    callPayload.Queries["internetMessageId"] = SourceExpressionConverter.ConvertO(internetMessageId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                return callPayload;
            }

            return new ApiConnectionAction<GraphClientReceiveMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchResponseGraphClientReceiveMessage> GetEmails([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<string> subjectFilter = null, [WorkflowExpression] Func<bool> fetchOnlyUnread = null, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> searchQuery = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            SourceExpression.Validate(cc, nameof(cc), required: false);
            SourceExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(importance, nameof(importance), required: false);
            SourceExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            SourceExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            SourceExpression.Validate(fetchOnlyUnread, nameof(fetchOnlyUnread), required: false);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            SourceExpression.Validate(searchQuery, nameof(searchQuery), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/Mail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = Convert.ToString("Inbox");
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    callPayload.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    callPayload.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                callPayload.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    callPayload.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                callPayload.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    callPayload.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                if (subjectFilter != null)
                    callPayload.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
                callPayload.Queries["fetchOnlyUnread"] = Convert.ToString(true);
                if (fetchOnlyUnread != null)
                    callPayload.Queries["fetchOnlyUnread"] = SourceExpressionConverter.ConvertO(fetchOnlyUnread);
                callPayload.Queries["fetchOnlyFlagged"] = Convert.ToString(false);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (searchQuery != null)
                    callPayload.Queries["searchQuery"] = SourceExpressionConverter.ConvertO(searchQuery);
                callPayload.Queries["top"] = Convert.ToString(10);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<BatchResponseGraphClientReceiveMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> GetEventsCalendarView([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> startDateTimeUtc, [WorkflowExpression] Func<string> endDateTimeUtc, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(calendarId, nameof(calendarId), required: true);
            SourceExpression.Validate(startDateTimeUtc, nameof(startDateTimeUtc), required: true);
            SourceExpression.Validate(endDateTimeUtc, nameof(endDateTimeUtc), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/calendars/v3/tables/items/calendarview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["calendarId"] = SourceExpressionConverter.ConvertO(calendarId);
                callPayload.Queries["startDateTimeUtc"] = SourceExpressionConverter.ConvertO(startDateTimeUtc);
                callPayload.Queries["endDateTimeUtc"] = SourceExpressionConverter.ConvertO(endDateTimeUtc);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<EntityListResponseGraphCalendarEventClientReceive>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetMailTipsV2Response> GetMailTips([WorkflowExpression] Func<string[]> bodyemailAddresses)
        {
            SourceExpression.Validate(bodyemailAddresses, nameof(bodyemailAddresses), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/v1.0/me/getMailTips";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["MailTipsOptions"] = "automaticReplies, deliveryRestriction, externalMemberCount, mailboxFullStatus, maxMessageSize, moderationStatus, totalMemberCount";
                bodypropCount++;
                bodypropCount++;
                body["EmailAddresses"] = SourceExpressionConverter.ConvertToken(bodyemailAddresses);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetMailTipsV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomListsV2Response> GetRoomLists()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/beta/me/findRoomLists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRoomListsV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsV2Response> GetRooms()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/beta/me/findRooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRoomsV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsInRoomListV2Response> GetRoomsInRoomList([WorkflowExpression] Func<string> roomList)
        {
            SourceExpression.Validate(roomList, nameof(roomList), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/beta/me/findRooms(RoomList='{0}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomList, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRoomsInRoomListV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction MarkAsRead([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<bool> bodymarkAs, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(bodymarkAs, nameof(bodymarkAs), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v3/v1.0/me/messages/{0}/markAsRead", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isRead"] = SourceExpressionConverter.ConvertToken(bodymarkAs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> Move([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/Mail/Move/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                return callPayload;
            }

            return new ApiConnectionAction<GraphClientReceiveMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ReplyTo([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> replyParametersto = null, [WorkflowExpression] Func<string> replyParameterscC = null, [WorkflowExpression] Func<string> replyParametersbCC = null, [WorkflowExpression] Func<string> replyParameterssubject = null, [WorkflowExpression] Func<string> replyParametersbody = null, [WorkflowExpression] Func<bool> replyParametersreplyAll = null, [WorkflowExpression] Func<replyParametersimportanceInput> replyParametersimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> replyParametersattachments = null, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(replyParametersto, nameof(replyParametersto), required: false);
            SourceExpression.Validate(replyParameterscC, nameof(replyParameterscC), required: false);
            SourceExpression.Validate(replyParametersbCC, nameof(replyParametersbCC), required: false);
            SourceExpression.Validate(replyParameterssubject, nameof(replyParameterssubject), required: false);
            SourceExpression.Validate(replyParametersbody, nameof(replyParametersbody), required: false);
            SourceExpression.Validate(replyParametersreplyAll, nameof(replyParametersreplyAll), required: false);
            SourceExpression.Validate(replyParametersimportance, nameof(replyParametersimportance), required: false);
            SourceExpression.Validate(replyParametersattachments, nameof(replyParametersattachments), required: false);
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/Mail/ReplyTo/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                var replyParameters = new JObject();
                var replyParameterspropCount = 0;
                if (replyParametersto != null)
                {
                    replyParameters["To"] = SourceExpressionConverter.ConvertToken(replyParametersto);
                    replyParameterspropCount++;
                }

                if (replyParameterscC != null)
                {
                    replyParameters["Cc"] = SourceExpressionConverter.ConvertToken(replyParameterscC);
                    replyParameterspropCount++;
                }

                if (replyParametersbCC != null)
                {
                    replyParameters["Bcc"] = SourceExpressionConverter.ConvertToken(replyParametersbCC);
                    replyParameterspropCount++;
                }

                if (replyParameterssubject != null)
                {
                    replyParameters["Subject"] = SourceExpressionConverter.ConvertToken(replyParameterssubject);
                    replyParameterspropCount++;
                }

                if (replyParametersbody != null)
                {
                    replyParameters["Body"] = SourceExpressionConverter.ConvertToken(replyParametersbody);
                    replyParameterspropCount++;
                }

                if (replyParametersreplyAll != null)
                {
                    replyParameters["ReplyAll"] = SourceExpressionConverter.ConvertToken(replyParametersreplyAll);
                    replyParameterspropCount++;
                }

                if (replyParametersimportance != null)
                {
                    replyParameters["Importance"] = SourceExpressionConverter.Convert(replyParametersimportance);
                    replyParameterspropCount++;
                }

                if (replyParametersattachments != null)
                {
                    replyParameters["Attachments"] = SourceExpressionConverter.ConvertToken(replyParametersattachments);
                    replyParameterspropCount++;
                }

                if (replyParameterspropCount > 0)
                {
                    callPayload.Body = replyParameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction RespondToEvent([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<responseInput> response, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<bool> bodysendResponse = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(response, nameof(response), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodysendResponse, nameof(bodysendResponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/events/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(response, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodysendResponse != null)
                {
                    if (bodysendResponse != null)
                    {
                        body["SendResponse"] = SourceExpressionConverter.ConvertToken(bodysendResponse);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagesubject, [WorkflowExpression] Func<string> emailMessagebody, [WorkflowExpression] Func<string> emailMessagefromSendAs = null, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> emailMessageattachments = null, [WorkflowExpression] Func<string> emailMessagesensitivity = null, [WorkflowExpression] Func<string> emailMessagereplyTo = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null)
        {
            SourceExpression.Validate(emailMessageto, nameof(emailMessageto), required: true);
            SourceExpression.Validate(emailMessagesubject, nameof(emailMessagesubject), required: true);
            SourceExpression.Validate(emailMessagebody, nameof(emailMessagebody), required: true);
            SourceExpression.Validate(emailMessagefromSendAs, nameof(emailMessagefromSendAs), required: false);
            SourceExpression.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            SourceExpression.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            SourceExpression.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            SourceExpression.Validate(emailMessagesensitivity, nameof(emailMessagesensitivity), required: false);
            SourceExpression.Validate(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            SourceExpression.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["To"] = SourceExpressionConverter.ConvertToken(emailMessageto);
                emailMessagepropCount++;
                emailMessage["Subject"] = SourceExpressionConverter.ConvertToken(emailMessagesubject);
                emailMessagepropCount++;
                emailMessage["Body"] = SourceExpressionConverter.ConvertToken(emailMessagebody);
                if (emailMessagefromSendAs != null)
                {
                    emailMessage["From"] = SourceExpressionConverter.ConvertToken(emailMessagefromSendAs);
                    emailMessagepropCount++;
                }

                if (emailMessagecC != null)
                {
                    emailMessage["Cc"] = SourceExpressionConverter.ConvertToken(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = SourceExpressionConverter.ConvertToken(emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = SourceExpressionConverter.ConvertToken(emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagesensitivity != null)
                {
                    emailMessage["Sensitivity"] = SourceExpressionConverter.ConvertToken(emailMessagesensitivity);
                    emailMessagepropCount++;
                }

                if (emailMessagereplyTo != null)
                {
                    emailMessage["ReplyTo"] = SourceExpressionConverter.ConvertToken(emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    if (emailMessageimportance != null)
                    {
                        emailMessage["Importance"] = SourceExpressionConverter.Convert(emailMessageimportance);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SetAutomaticRepliesSettingV2Response> SetAutomaticRepliesSetting([WorkflowExpression] Func<bodyautomaticRepliesSettingstatusInput> bodyautomaticRepliesSettingstatus, [WorkflowExpression] Func<bodyautomaticRepliesSettingexternalAudienceInput> bodyautomaticRepliesSettingexternalAudience, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingstartTimedateTime = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingstartTimetimeZone = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingendTimedateTime = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingendTimetimeZone = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettinginternalReplyMessage = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingexternalReplyMessage = null)
        {
            SourceExpression.Validate(bodyautomaticRepliesSettingstatus, nameof(bodyautomaticRepliesSettingstatus), required: true);
            SourceExpression.Validate(bodyautomaticRepliesSettingexternalAudience, nameof(bodyautomaticRepliesSettingexternalAudience), required: true);
            SourceExpression.Validate(bodyautomaticRepliesSettingstartTimedateTime, nameof(bodyautomaticRepliesSettingstartTimedateTime), required: false);
            SourceExpression.Validate(bodyautomaticRepliesSettingstartTimetimeZone, nameof(bodyautomaticRepliesSettingstartTimetimeZone), required: false);
            SourceExpression.Validate(bodyautomaticRepliesSettingendTimedateTime, nameof(bodyautomaticRepliesSettingendTimedateTime), required: false);
            SourceExpression.Validate(bodyautomaticRepliesSettingendTimetimeZone, nameof(bodyautomaticRepliesSettingendTimetimeZone), required: false);
            SourceExpression.Validate(bodyautomaticRepliesSettinginternalReplyMessage, nameof(bodyautomaticRepliesSettinginternalReplyMessage), required: false);
            SourceExpression.Validate(bodyautomaticRepliesSettingexternalReplyMessage, nameof(bodyautomaticRepliesSettingexternalReplyMessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/v1.0/me/mailboxSettings";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var automaticRepliesSettingObject = new JObject();
                var automaticRepliesSettingObjectpropCount = 0;
                automaticRepliesSettingObjectpropCount++;
                automaticRepliesSettingObject["status"] = SourceExpressionConverter.Convert(bodyautomaticRepliesSettingstatus);
                automaticRepliesSettingObjectpropCount++;
                automaticRepliesSettingObject["externalAudience"] = SourceExpressionConverter.Convert(bodyautomaticRepliesSettingexternalAudience);
                var scheduledStartDateTimeObject = new JObject();
                var scheduledStartDateTimeObjectpropCount = 0;
                if (bodyautomaticRepliesSettingstartTimedateTime != null)
                {
                    scheduledStartDateTimeObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodyautomaticRepliesSettingstartTimedateTime);
                    scheduledStartDateTimeObjectpropCount++;
                }

                if (bodyautomaticRepliesSettingstartTimetimeZone != null)
                {
                    scheduledStartDateTimeObject["timeZone"] = SourceExpressionConverter.ConvertToken(bodyautomaticRepliesSettingstartTimetimeZone);
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
                    scheduledEndDateTimeObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodyautomaticRepliesSettingendTimedateTime);
                    scheduledEndDateTimeObjectpropCount++;
                }

                if (bodyautomaticRepliesSettingendTimetimeZone != null)
                {
                    scheduledEndDateTimeObject["timeZone"] = SourceExpressionConverter.ConvertToken(bodyautomaticRepliesSettingendTimetimeZone);
                    scheduledEndDateTimeObjectpropCount++;
                }

                if (scheduledEndDateTimeObjectpropCount > 0)
                {
                    automaticRepliesSettingObject["scheduledEndDateTime"] = scheduledEndDateTimeObject;
                    automaticRepliesSettingObjectpropCount++;
                }

                if (bodyautomaticRepliesSettinginternalReplyMessage != null)
                {
                    automaticRepliesSettingObject["internalReplyMessage"] = SourceExpressionConverter.ConvertToken(bodyautomaticRepliesSettinginternalReplyMessage);
                    automaticRepliesSettingObjectpropCount++;
                }

                if (bodyautomaticRepliesSettingexternalReplyMessage != null)
                {
                    automaticRepliesSettingObject["externalReplyMessage"] = SourceExpressionConverter.ConvertToken(bodyautomaticRepliesSettingexternalReplyMessage);
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
                return callPayload;
            }

            return new ApiConnectionAction<SetAutomaticRepliesSettingV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SharedMailboxSendEmail([WorkflowExpression] Func<string> emailMessageoriginalMailboxAddress, [WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagesubject, [WorkflowExpression] Func<string> emailMessagebody, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> emailMessageattachments = null, [WorkflowExpression] Func<string> emailMessagesensitivity = null, [WorkflowExpression] Func<string> emailMessagereplyTo = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null)
        {
            SourceExpression.Validate(emailMessageoriginalMailboxAddress, nameof(emailMessageoriginalMailboxAddress), required: true);
            SourceExpression.Validate(emailMessageto, nameof(emailMessageto), required: true);
            SourceExpression.Validate(emailMessagesubject, nameof(emailMessagesubject), required: true);
            SourceExpression.Validate(emailMessagebody, nameof(emailMessagebody), required: true);
            SourceExpression.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            SourceExpression.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            SourceExpression.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            SourceExpression.Validate(emailMessagesensitivity, nameof(emailMessagesensitivity), required: false);
            SourceExpression.Validate(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            SourceExpression.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/SharedMailbox/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["MailboxAddress"] = SourceExpressionConverter.ConvertToken(emailMessageoriginalMailboxAddress);
                emailMessagepropCount++;
                emailMessage["To"] = SourceExpressionConverter.ConvertToken(emailMessageto);
                emailMessagepropCount++;
                emailMessage["Subject"] = SourceExpressionConverter.ConvertToken(emailMessagesubject);
                emailMessagepropCount++;
                emailMessage["Body"] = SourceExpressionConverter.ConvertToken(emailMessagebody);
                if (emailMessagecC != null)
                {
                    emailMessage["Cc"] = SourceExpressionConverter.ConvertToken(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = SourceExpressionConverter.ConvertToken(emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = SourceExpressionConverter.ConvertToken(emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagesensitivity != null)
                {
                    emailMessage["Sensitivity"] = SourceExpressionConverter.ConvertToken(emailMessagesensitivity);
                    emailMessagepropCount++;
                }

                if (emailMessagereplyTo != null)
                {
                    emailMessage["ReplyTo"] = SourceExpressionConverter.ConvertToken(emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    if (emailMessageimportance != null)
                    {
                        emailMessage["Importance"] = SourceExpressionConverter.Convert(emailMessageimportance);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class Office365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GraphCalendarEventListWithActionType> OnCalendarChangedItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> incomingDays = null, [WorkflowExpression] Func<int> pastDays = null, string triggerName = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(incomingDays, nameof(incomingDays), required: false);
            SourceExpression.Validate(pastDays, nameof(pastDays), required: false);
            ApiConnectionNotificationActionInput BuildSourceInput()
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
                    input.Fetch.Queries["incomingDays"] = SourceExpressionConverter.ConvertO(incomingDays);
                input.Fetch.Queries["pastDays"] = Convert.ToString(50);
                if (pastDays != null)
                    input.Fetch.Queries["pastDays"] = SourceExpressionConverter.ConvertO(pastDays);
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
                    input.Subscribe.Queries["incomingDays"] = SourceExpressionConverter.ConvertO(incomingDays);
                input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
                if (pastDays != null)
                    input.Subscribe.Queries["pastDays"] = SourceExpressionConverter.ConvertO(pastDays);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "@listCallbackUrl()";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<GraphCalendarEventListWithActionType>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarNewItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/onnewitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarUpdatedItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/onupdateditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnFlaggedEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            SourceExpression.Validate(cc, nameof(cc), required: false);
            SourceExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(importance, nameof(importance), required: false);
            SourceExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            SourceExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            ApiConnectionNotificationActionInput BuildSourceInput()
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
                    input.Fetch.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
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
                    input.Subscribe.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "@listCallbackUrl()";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            SourceExpression.Validate(cc, nameof(cc), required: false);
            SourceExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(importance, nameof(importance), required: false);
            SourceExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            SourceExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            ApiConnectionNotificationActionInput BuildSourceInput()
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
                    input.Fetch.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
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
                    input.Subscribe.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "@listCallbackUrl()";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmailMentioningMe([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            SourceExpression.Validate(cc, nameof(cc), required: false);
            SourceExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(importance, nameof(importance), required: false);
            SourceExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            SourceExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            ApiConnectionNotificationActionInput BuildSourceInput()
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
                    input.Fetch.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
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
                    input.Subscribe.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "@listCallbackUrl()";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnUpcomingEvents([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> lookAheadTimeInMinutes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(lookAheadTimeInMinutes, nameof(lookAheadTimeInMinutes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = SourceExpressionConverter.ConvertO(table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = SourceExpressionConverter.ConvertO(lookAheadTimeInMinutes);
                return callPayload;
            }

            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnSharedMailboxNewEmail([WorkflowExpression] Func<string> mailboxAddress, [WorkflowExpression] Func<string> folderId = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> hasAttachments = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            SourceExpression.Validate(cc, nameof(cc), required: false);
            SourceExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(importance, nameof(importance), required: false);
            SourceExpression.Validate(hasAttachments, nameof(hasAttachments), required: false);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            SourceExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/SharedMailbox/Mail/OnNewEmail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mailboxAddress"] = SourceExpressionConverter.ConvertO(mailboxAddress);
                callPayload.Queries["folderId"] = Convert.ToString("Inbox");
                if (folderId != null)
                    callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    callPayload.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    callPayload.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                callPayload.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    callPayload.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                callPayload.Queries["hasAttachments"] = Convert.ToString(false);
                if (hasAttachments != null)
                    callPayload.Queries["hasAttachments"] = SourceExpressionConverter.ConvertO(hasAttachments);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (subjectFilter != null)
                    callPayload.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(BuildSourceInput, triggerName, recurrence);
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