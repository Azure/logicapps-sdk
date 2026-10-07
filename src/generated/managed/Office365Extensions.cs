//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365
{
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
        [WorkflowExpressionFactory(nameof(__BuildDraftEmail))]
        public IBodyWorkflowAction<OutlookReceiveMessage> DraftEmail([WorkflowExpression] Func<string> draftMessageto, [WorkflowExpression] Func<string> draftMessagesubject, [WorkflowExpression] Func<string> draftMessagebody, [WorkflowExpression] Func<string> draftMessagefromSendAs = null, [WorkflowExpression] Func<string> draftMessagecC = null, [WorkflowExpression] Func<string> draftMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> draftMessageattachments = null, [WorkflowExpression] Func<string> draftMessagesensitivity = null, [WorkflowExpression] Func<string> draftMessagereplyTo = null, [WorkflowExpression] Func<draftMessageimportanceInput> draftMessageimportance = null, [WorkflowExpression] Func<string> messageId = null, [WorkflowExpression] Func<string> draftType = null, [WorkflowExpression] Func<string> comment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OutlookReceiveMessage> __BuildDraftEmail(WorkflowExpression<string> draftMessageto, WorkflowExpression<string> draftMessagesubject, WorkflowExpression<string> draftMessagebody, WorkflowExpression<string> draftMessagefromSendAs = null, WorkflowExpression<string> draftMessagecC = null, WorkflowExpression<string> draftMessagebCC = null, WorkflowExpression<ClientSendAttachment[]> draftMessageattachments = null, WorkflowExpression<string> draftMessagesensitivity = null, WorkflowExpression<string> draftMessagereplyTo = null, WorkflowExpression<draftMessageimportanceInput> draftMessageimportance = null, WorkflowExpression<string> messageId = null, WorkflowExpression<string> draftType = null, WorkflowExpression<string> comment = null)
        {
            WorkflowExpression.Validate(draftMessageto, nameof(draftMessageto), required: true);
            WorkflowExpression.Validate(draftMessagesubject, nameof(draftMessagesubject), required: true);
            WorkflowExpression.Validate(draftMessagebody, nameof(draftMessagebody), required: true);
            WorkflowExpression.Validate(draftMessagefromSendAs, nameof(draftMessagefromSendAs), required: false);
            WorkflowExpression.Validate(draftMessagecC, nameof(draftMessagecC), required: false);
            WorkflowExpression.Validate(draftMessagebCC, nameof(draftMessagebCC), required: false);
            WorkflowExpression.Validate(draftMessageattachments, nameof(draftMessageattachments), required: false);
            WorkflowExpression.Validate(draftMessagesensitivity, nameof(draftMessagesensitivity), required: false);
            WorkflowExpression.Validate(draftMessagereplyTo, nameof(draftMessagereplyTo), required: false);
            WorkflowExpression.Validate(draftMessageimportance, nameof(draftMessageimportance), required: false);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: false);
            WorkflowExpression.Validate(draftType, nameof(draftType), required: false);
            WorkflowExpression.Validate(comment, nameof(comment), required: false);
            return new DeferredBodyAction<OutlookReceiveMessage>(() =>
            {
                var apiCallPath = "/Draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (messageId != null)
                    callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
                if (draftType != null)
                    callPayload.Queries["draftType"] = ExpressionConverter.Convert(draftType);
                if (comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
                var draftMessage = new JObject();
                var draftMessagepropCount = 0;
                draftMessagepropCount++;
                draftMessage["To"] = ExpressionConverter.ConvertO(draftMessageto);
                draftMessagepropCount++;
                draftMessage["Subject"] = ExpressionConverter.ConvertO(draftMessagesubject);
                draftMessagepropCount++;
                draftMessage["Body"] = ExpressionConverter.ConvertO(draftMessagebody);
                if (draftMessagefromSendAs != null)
                {
                    draftMessage["From"] = ExpressionConverter.ConvertO(draftMessagefromSendAs);
                    draftMessagepropCount++;
                }

                if (draftMessagecC != null)
                {
                    draftMessage["Cc"] = ExpressionConverter.ConvertO(draftMessagecC);
                    draftMessagepropCount++;
                }

                if (draftMessagebCC != null)
                {
                    draftMessage["Bcc"] = ExpressionConverter.ConvertO(draftMessagebCC);
                    draftMessagepropCount++;
                }

                if (draftMessageattachments != null)
                {
                    draftMessage["Attachments"] = ExpressionConverter.ConvertO(draftMessageattachments);
                    draftMessagepropCount++;
                }

                if (draftMessagesensitivity != null)
                {
                    draftMessage["Sensitivity"] = ExpressionConverter.ConvertO(draftMessagesensitivity);
                    draftMessagepropCount++;
                }

                if (draftMessagereplyTo != null)
                {
                    draftMessage["ReplyTo"] = ExpressionConverter.ConvertO(draftMessagereplyTo);
                    draftMessagepropCount++;
                }

                if (draftMessageimportance != null)
                {
                    if (draftMessageimportance != null)
                    {
                        draftMessage["Importance"] = ExpressionConverter.ConvertO(draftMessageimportance);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDraftEmail))]
        public IWorkflowAction UpdateDraftEmail([WorkflowExpression] Func<string> draftMessageto, [WorkflowExpression] Func<string> draftMessagesubject, [WorkflowExpression] Func<string> draftMessagebody, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> draftMessagefromSendAs = null, [WorkflowExpression] Func<string> draftMessagecC = null, [WorkflowExpression] Func<string> draftMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> draftMessageattachments = null, [WorkflowExpression] Func<string> draftMessagesensitivity = null, [WorkflowExpression] Func<string> draftMessagereplyTo = null, [WorkflowExpression] Func<draftMessageimportanceInput> draftMessageimportance = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDraftEmail(WorkflowExpression<string> draftMessageto, WorkflowExpression<string> draftMessagesubject, WorkflowExpression<string> draftMessagebody, WorkflowExpression<string> messageId, WorkflowExpression<string> draftMessagefromSendAs = null, WorkflowExpression<string> draftMessagecC = null, WorkflowExpression<string> draftMessagebCC = null, WorkflowExpression<ClientSendAttachment[]> draftMessageattachments = null, WorkflowExpression<string> draftMessagesensitivity = null, WorkflowExpression<string> draftMessagereplyTo = null, WorkflowExpression<draftMessageimportanceInput> draftMessageimportance = null)
        {
            WorkflowExpression.Validate(draftMessageto, nameof(draftMessageto), required: true);
            WorkflowExpression.Validate(draftMessagesubject, nameof(draftMessagesubject), required: true);
            WorkflowExpression.Validate(draftMessagebody, nameof(draftMessagebody), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(draftMessagefromSendAs, nameof(draftMessagefromSendAs), required: false);
            WorkflowExpression.Validate(draftMessagecC, nameof(draftMessagecC), required: false);
            WorkflowExpression.Validate(draftMessagebCC, nameof(draftMessagebCC), required: false);
            WorkflowExpression.Validate(draftMessageattachments, nameof(draftMessageattachments), required: false);
            WorkflowExpression.Validate(draftMessagesensitivity, nameof(draftMessagesensitivity), required: false);
            WorkflowExpression.Validate(draftMessagereplyTo, nameof(draftMessagereplyTo), required: false);
            WorkflowExpression.Validate(draftMessageimportance, nameof(draftMessageimportance), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Draft";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
                var draftMessage = new JObject();
                var draftMessagepropCount = 0;
                draftMessagepropCount++;
                draftMessage["To"] = ExpressionConverter.ConvertO(draftMessageto);
                draftMessagepropCount++;
                draftMessage["Subject"] = ExpressionConverter.ConvertO(draftMessagesubject);
                draftMessagepropCount++;
                draftMessage["Body"] = ExpressionConverter.ConvertO(draftMessagebody);
                if (draftMessagefromSendAs != null)
                {
                    draftMessage["From"] = ExpressionConverter.ConvertO(draftMessagefromSendAs);
                    draftMessagepropCount++;
                }

                if (draftMessagecC != null)
                {
                    draftMessage["Cc"] = ExpressionConverter.ConvertO(draftMessagecC);
                    draftMessagepropCount++;
                }

                if (draftMessagebCC != null)
                {
                    draftMessage["Bcc"] = ExpressionConverter.ConvertO(draftMessagebCC);
                    draftMessagepropCount++;
                }

                if (draftMessageattachments != null)
                {
                    draftMessage["Attachments"] = ExpressionConverter.ConvertO(draftMessageattachments);
                    draftMessagepropCount++;
                }

                if (draftMessagesensitivity != null)
                {
                    draftMessage["Sensitivity"] = ExpressionConverter.ConvertO(draftMessagesensitivity);
                    draftMessagepropCount++;
                }

                if (draftMessagereplyTo != null)
                {
                    draftMessage["ReplyTo"] = ExpressionConverter.ConvertO(draftMessagereplyTo);
                    draftMessagepropCount++;
                }

                if (draftMessageimportance != null)
                {
                    if (draftMessageimportance != null)
                    {
                        draftMessage["Importance"] = ExpressionConverter.ConvertO(draftMessageimportance);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildSendDraftEmail))]
        public IWorkflowAction SendDraftEmail([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendDraftEmail(WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Draft/Send/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildAssignCategory))]
        public IWorkflowAction AssignCategory([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> category)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAssignCategory(WorkflowExpression<string> messageId, WorkflowExpression<string> category)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(category, nameof(category), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Mail/Category";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildAssignCategoryBulk))]
        public IBodyWorkflowAction<BatchOperationResult> AssignCategoryBulk([WorkflowExpression] Func<string> categoryName, [WorkflowExpression] Func<string[]> messageIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BatchOperationResult> __BuildAssignCategoryBulk(WorkflowExpression<string> categoryName, WorkflowExpression<string[]> messageIds = null)
        {
            WorkflowExpression.Validate(categoryName, nameof(categoryName), required: true);
            WorkflowExpression.Validate(messageIds, nameof(messageIds), required: false);
            return new DeferredBodyAction<BatchOperationResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/Category/Bulk/{0}", ExpressionConverter.ConvertWithUrlEncoding(categoryName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(messageIds);
                return new ApiConnectionAction<BatchOperationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildSendMailWithOptions))]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions([WorkflowExpression] Func<string> optionsEmailSubscriptionmessageto, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<optionsEmailSubscriptionmessageimportanceInput> optionsEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> optionsEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessagehideMicrosoftFooter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriptionResponse> __BuildSendMailWithOptions(WorkflowExpression<string> optionsEmailSubscriptionmessageto, WorkflowExpression<string> optionsEmailSubscriptionmessagesubject = null, WorkflowExpression<string> optionsEmailSubscriptionmessageuserOptions = null, WorkflowExpression<string> optionsEmailSubscriptionmessageheaderText = null, WorkflowExpression<string> optionsEmailSubscriptionmessageselectionText = null, WorkflowExpression<string> optionsEmailSubscriptionmessagebody = null, WorkflowExpression<optionsEmailSubscriptionmessageimportanceInput> optionsEmailSubscriptionmessageimportance = null, WorkflowExpression<ClientSendAttachment[]> optionsEmailSubscriptionmessageattachments = null, WorkflowExpression<bool> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, WorkflowExpression<bool> optionsEmailSubscriptionmessagehideHTMLMessage = null, WorkflowExpression<bool> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null, WorkflowExpression<bool> optionsEmailSubscriptionmessagehideMicrosoftFooter = null)
        {
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageto, nameof(optionsEmailSubscriptionmessageto), required: true);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessagesubject, nameof(optionsEmailSubscriptionmessagesubject), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageuserOptions, nameof(optionsEmailSubscriptionmessageuserOptions), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageheaderText, nameof(optionsEmailSubscriptionmessageheaderText), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageselectionText, nameof(optionsEmailSubscriptionmessageselectionText), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessagebody, nameof(optionsEmailSubscriptionmessagebody), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageimportance, nameof(optionsEmailSubscriptionmessageimportance), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageattachments, nameof(optionsEmailSubscriptionmessageattachments), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(optionsEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessagehideHTMLMessage, nameof(optionsEmailSubscriptionmessagehideHTMLMessage), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
            WorkflowExpression.Validate(optionsEmailSubscriptionmessagehideMicrosoftFooter, nameof(optionsEmailSubscriptionmessagehideMicrosoftFooter), required: false);
            return new DeferredBodyAction<SubscriptionResponse>(() =>
            {
                var apiCallPath = "/mailwithoptions/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var optionsEmailSubscription = new JObject();
                var optionsEmailSubscriptionpropCount = 0;
                optionsEmailSubscription["NotificationUrl"] = "#{listCallbackUrl()}";
                optionsEmailSubscriptionpropCount++;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                messageObjectpropCount++;
                messageObject["To"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageto);
                if (optionsEmailSubscriptionmessagesubject != null)
                {
                    if (optionsEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessagesubject);
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
                        messageObject["Options"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageuserOptions);
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
                    messageObject["HeaderText"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageimportance != null)
                {
                    if (optionsEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageimportance);
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
                    messageObject["Attachments"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessagehideHTMLMessage);
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
                        messageObject["ShowHTMLConfirmationDialog"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog);
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
                        messageObject["HideMicrosoftFooter"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionmessagehideMicrosoftFooter);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildSendApprovalMail))]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail([WorkflowExpression] Func<string> approvalEmailSubscriptionmessageto, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<approvalEmailSubscriptionmessageimportanceInput> approvalEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> approvalEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriptionResponse> __BuildSendApprovalMail(WorkflowExpression<string> approvalEmailSubscriptionmessageto, WorkflowExpression<string> approvalEmailSubscriptionmessagesubject = null, WorkflowExpression<string> approvalEmailSubscriptionmessageuserOptions = null, WorkflowExpression<string> approvalEmailSubscriptionmessageheaderText = null, WorkflowExpression<string> approvalEmailSubscriptionmessageselectionText = null, WorkflowExpression<string> approvalEmailSubscriptionmessagebody = null, WorkflowExpression<approvalEmailSubscriptionmessageimportanceInput> approvalEmailSubscriptionmessageimportance = null, WorkflowExpression<ClientSendAttachment[]> approvalEmailSubscriptionmessageattachments = null, WorkflowExpression<bool> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, WorkflowExpression<bool> approvalEmailSubscriptionmessagehideHTMLMessage = null, WorkflowExpression<bool> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageto, nameof(approvalEmailSubscriptionmessageto), required: true);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessagesubject, nameof(approvalEmailSubscriptionmessagesubject), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageuserOptions, nameof(approvalEmailSubscriptionmessageuserOptions), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageheaderText, nameof(approvalEmailSubscriptionmessageheaderText), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageselectionText, nameof(approvalEmailSubscriptionmessageselectionText), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessagebody, nameof(approvalEmailSubscriptionmessagebody), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageimportance, nameof(approvalEmailSubscriptionmessageimportance), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageattachments, nameof(approvalEmailSubscriptionmessageattachments), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(approvalEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessagehideHTMLMessage, nameof(approvalEmailSubscriptionmessagehideHTMLMessage), required: false);
            WorkflowExpression.Validate(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
            return new DeferredBodyAction<SubscriptionResponse>(() =>
            {
                var apiCallPath = "/approvalmail/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var approvalEmailSubscription = new JObject();
                var approvalEmailSubscriptionpropCount = 0;
                approvalEmailSubscription["NotificationUrl"] = "#{listCallbackUrl()}";
                approvalEmailSubscriptionpropCount++;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                messageObjectpropCount++;
                messageObject["To"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageto);
                if (approvalEmailSubscriptionmessagesubject != null)
                {
                    if (approvalEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessagesubject);
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
                        messageObject["Options"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageuserOptions);
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
                    messageObject["HeaderText"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageimportance != null)
                {
                    if (approvalEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageimportance);
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
                    messageObject["Attachments"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessagehideHTMLMessage);
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
                        messageObject["ShowHTMLConfirmationDialog"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMyContactPhoto))]
        public IWorkflowAction UpdateMyContactPhoto([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateMyContactPhoto(WorkflowExpression<string> folder, WorkflowExpression<string> id, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(folder, nameof(folder), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}/photo/$value", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("image/jpeg");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> customHeader1 = null, [WorkflowExpression] Func<string> customHeader2 = null, [WorkflowExpression] Func<string> customHeader3 = null, [WorkflowExpression] Func<string> customHeader4 = null, [WorkflowExpression] Func<string> customHeader5 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpRequest(WorkflowExpression<string> uri, WorkflowExpression<methodInput> method, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null, WorkflowExpression<string> customHeader1 = null, WorkflowExpression<string> customHeader2 = null, WorkflowExpression<string> customHeader3 = null, WorkflowExpression<string> customHeader4 = null, WorkflowExpression<string> customHeader5 = null)
        {
            WorkflowExpression.Validate(uri, nameof(uri), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(customHeader1, nameof(customHeader1), required: false);
            WorkflowExpression.Validate(customHeader2, nameof(customHeader2), required: false);
            WorkflowExpression.Validate(customHeader3, nameof(customHeader3), required: false);
            WorkflowExpression.Validate(customHeader4, nameof(customHeader4), required: false);
            WorkflowExpression.Validate(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
                if (customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
                if (customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
                if (customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
                if (customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
                if (customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildMcpEmailsManagement))]
        public IBodyWorkflowAction<MCPQueryResponse> McpEmailsManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MCPQueryResponse> __BuildMcpEmailsManagement(WorkflowExpression<string> queryRequestjsonrpc = null, WorkflowExpression<string> queryRequestid = null, WorkflowExpression<string> queryRequestmethod = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/EmailsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildMcpMeetingManagement))]
        public IBodyWorkflowAction<MCPQueryResponse> McpMeetingManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MCPQueryResponse> __BuildMcpMeetingManagement(WorkflowExpression<string> queryRequestjsonrpc = null, WorkflowExpression<string> queryRequestid = null, WorkflowExpression<string> queryRequestmethod = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/MeetingManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildMcpContactsManagement))]
        public IBodyWorkflowAction<MCPQueryResponse> McpContactsManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MCPQueryResponse> __BuildMcpContactsManagement(WorkflowExpression<string> queryRequestjsonrpc = null, WorkflowExpression<string> queryRequestid = null, WorkflowExpression<string> queryRequestmethod = null, WorkflowExpression<string> sessionId = null)
        {
            WorkflowExpression.Validate(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            WorkflowExpression.Validate(queryRequestid, nameof(queryRequestid), required: false);
            WorkflowExpression.Validate(queryRequestmethod, nameof(queryRequestmethod), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/ContactsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarDeleteItem))]
        public IWorkflowAction CalendarDeleteItem([WorkflowExpression] Func<string> calendar, [WorkflowExpression] Func<string> @event)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCalendarDeleteItem(WorkflowExpression<string> calendar, WorkflowExpression<string> @event)
        {
            WorkflowExpression.Validate(calendar, nameof(calendar), required: true);
            WorkflowExpression.Validate(@event, nameof(@event), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(calendar, 2), ExpressionConverter.ConvertWithUrlEncoding(@event, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarGetItem))]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarGetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> __BuildCalendarGetItem(WorkflowExpression<string> table, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarGetItems))]
        public IBodyWorkflowAction<GraphCalendarEventListClientReceive> CalendarGetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphCalendarEventListClientReceive> __BuildCalendarGetItems(WorkflowExpression<string> table, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyAction<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionAction<GraphCalendarEventListClientReceive>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildCalendarPatchItem))]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarPatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<itemselectedDaysOfWeekInputItem[]> itemselectedDaysOfWeek = null, [WorkflowExpression] Func<string> itemrecurrenceEndDate = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<bool> itemisReminderOn = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null, [WorkflowExpression] Func<itemsensitivityInput> itemsensitivity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> __BuildCalendarPatchItem(WorkflowExpression<string> table, WorkflowExpression<string> id, WorkflowExpression<string> itemsubject, WorkflowExpression<string> itemstartTime, WorkflowExpression<string> itemendTime, WorkflowExpression<itemtimeZoneInput> itemtimeZone, WorkflowExpression<string> itemrequiredAttendees = null, WorkflowExpression<string> itemoptionalAttendees = null, WorkflowExpression<string> itemresourceAttendees = null, WorkflowExpression<string> itembody = null, WorkflowExpression<string[]> itemcategories = null, WorkflowExpression<string> itemlocation = null, WorkflowExpression<itemimportanceInput> itemimportance = null, WorkflowExpression<bool> itemisAllDayEvent = null, WorkflowExpression<itemrecurrenceInput> itemrecurrence = null, WorkflowExpression<itemselectedDaysOfWeekInputItem[]> itemselectedDaysOfWeek = null, WorkflowExpression<string> itemrecurrenceEndDate = null, WorkflowExpression<int> itemnumberOfOccurrences = null, WorkflowExpression<int> itemreminder = null, WorkflowExpression<bool> itemisReminderOn = null, WorkflowExpression<itemshowAsInput> itemshowAs = null, WorkflowExpression<bool> itemresponseRequested = null, WorkflowExpression<itemsensitivityInput> itemsensitivity = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(itemsubject, nameof(itemsubject), required: true);
            WorkflowExpression.Validate(itemstartTime, nameof(itemstartTime), required: true);
            WorkflowExpression.Validate(itemendTime, nameof(itemendTime), required: true);
            WorkflowExpression.Validate(itemtimeZone, nameof(itemtimeZone), required: true);
            WorkflowExpression.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            WorkflowExpression.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            WorkflowExpression.Validate(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            WorkflowExpression.Validate(itembody, nameof(itembody), required: false);
            WorkflowExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            WorkflowExpression.Validate(itemlocation, nameof(itemlocation), required: false);
            WorkflowExpression.Validate(itemimportance, nameof(itemimportance), required: false);
            WorkflowExpression.Validate(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            WorkflowExpression.Validate(itemrecurrence, nameof(itemrecurrence), required: false);
            WorkflowExpression.Validate(itemselectedDaysOfWeek, nameof(itemselectedDaysOfWeek), required: false);
            WorkflowExpression.Validate(itemrecurrenceEndDate, nameof(itemrecurrenceEndDate), required: false);
            WorkflowExpression.Validate(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            WorkflowExpression.Validate(itemreminder, nameof(itemreminder), required: false);
            WorkflowExpression.Validate(itemisReminderOn, nameof(itemisReminderOn), required: false);
            WorkflowExpression.Validate(itemshowAs, nameof(itemshowAs), required: false);
            WorkflowExpression.Validate(itemresponseRequested, nameof(itemresponseRequested), required: false);
            WorkflowExpression.Validate(itemsensitivity, nameof(itemsensitivity), required: false);
            return new DeferredBodyAction<GraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = ExpressionConverter.ConvertO(itemsubject);
                itempropCount++;
                item["start"] = ExpressionConverter.ConvertO(itemstartTime);
                itempropCount++;
                item["end"] = ExpressionConverter.ConvertO(itemendTime);
                itempropCount++;
                item["timeZone"] = ExpressionConverter.ConvertO(itemtimeZone);
                if (itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = ExpressionConverter.ConvertO(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = ExpressionConverter.ConvertO(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["resourceAttendees"] = ExpressionConverter.ConvertO(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["body"] = ExpressionConverter.ConvertO(itembody);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(itemcategories);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["location"] = ExpressionConverter.ConvertO(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["importance"] = ExpressionConverter.ConvertO(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["isAllDay"] = ExpressionConverter.ConvertO(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["recurrence"] = ExpressionConverter.ConvertO(itemrecurrence);
                    itempropCount++;
                }

                if (itemselectedDaysOfWeek != null)
                {
                    item["selectedDaysOfWeek"] = ExpressionConverter.ConvertO(itemselectedDaysOfWeek);
                    itempropCount++;
                }

                if (itemrecurrenceEndDate != null)
                {
                    item["recurrenceEnd"] = ExpressionConverter.ConvertO(itemrecurrenceEndDate);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["numberOfOccurences"] = ExpressionConverter.ConvertO(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(itemreminder);
                    itempropCount++;
                }

                if (itemisReminderOn != null)
                {
                    item["isReminderOn"] = ExpressionConverter.ConvertO(itemisReminderOn);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["showAs"] = ExpressionConverter.ConvertO(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["responseRequested"] = ExpressionConverter.ConvertO(itemresponseRequested);
                    itempropCount++;
                }

                if (itemsensitivity != null)
                {
                    item["sensitivity"] = ExpressionConverter.ConvertO(itemsensitivity);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarPostItem))]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarPostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<itemselectedDaysOfWeekInputItem[]> itemselectedDaysOfWeek = null, [WorkflowExpression] Func<string> itemrecurrenceEndDate = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<bool> itemisReminderOn = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null, [WorkflowExpression] Func<itemsensitivityInput> itemsensitivity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> __BuildCalendarPostItem(WorkflowExpression<string> table, WorkflowExpression<string> itemsubject, WorkflowExpression<string> itemstartTime, WorkflowExpression<string> itemendTime, WorkflowExpression<itemtimeZoneInput> itemtimeZone, WorkflowExpression<string> itemrequiredAttendees = null, WorkflowExpression<string> itemoptionalAttendees = null, WorkflowExpression<string> itemresourceAttendees = null, WorkflowExpression<string> itembody = null, WorkflowExpression<string[]> itemcategories = null, WorkflowExpression<string> itemlocation = null, WorkflowExpression<itemimportanceInput> itemimportance = null, WorkflowExpression<bool> itemisAllDayEvent = null, WorkflowExpression<itemrecurrenceInput> itemrecurrence = null, WorkflowExpression<itemselectedDaysOfWeekInputItem[]> itemselectedDaysOfWeek = null, WorkflowExpression<string> itemrecurrenceEndDate = null, WorkflowExpression<int> itemnumberOfOccurrences = null, WorkflowExpression<int> itemreminder = null, WorkflowExpression<bool> itemisReminderOn = null, WorkflowExpression<itemshowAsInput> itemshowAs = null, WorkflowExpression<bool> itemresponseRequested = null, WorkflowExpression<itemsensitivityInput> itemsensitivity = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(itemsubject, nameof(itemsubject), required: true);
            WorkflowExpression.Validate(itemstartTime, nameof(itemstartTime), required: true);
            WorkflowExpression.Validate(itemendTime, nameof(itemendTime), required: true);
            WorkflowExpression.Validate(itemtimeZone, nameof(itemtimeZone), required: true);
            WorkflowExpression.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            WorkflowExpression.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            WorkflowExpression.Validate(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            WorkflowExpression.Validate(itembody, nameof(itembody), required: false);
            WorkflowExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            WorkflowExpression.Validate(itemlocation, nameof(itemlocation), required: false);
            WorkflowExpression.Validate(itemimportance, nameof(itemimportance), required: false);
            WorkflowExpression.Validate(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            WorkflowExpression.Validate(itemrecurrence, nameof(itemrecurrence), required: false);
            WorkflowExpression.Validate(itemselectedDaysOfWeek, nameof(itemselectedDaysOfWeek), required: false);
            WorkflowExpression.Validate(itemrecurrenceEndDate, nameof(itemrecurrenceEndDate), required: false);
            WorkflowExpression.Validate(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            WorkflowExpression.Validate(itemreminder, nameof(itemreminder), required: false);
            WorkflowExpression.Validate(itemisReminderOn, nameof(itemisReminderOn), required: false);
            WorkflowExpression.Validate(itemshowAs, nameof(itemshowAs), required: false);
            WorkflowExpression.Validate(itemresponseRequested, nameof(itemresponseRequested), required: false);
            WorkflowExpression.Validate(itemsensitivity, nameof(itemsensitivity), required: false);
            return new DeferredBodyAction<GraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v4/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = ExpressionConverter.ConvertO(itemsubject);
                itempropCount++;
                item["start"] = ExpressionConverter.ConvertO(itemstartTime);
                itempropCount++;
                item["end"] = ExpressionConverter.ConvertO(itemendTime);
                itempropCount++;
                item["timeZone"] = ExpressionConverter.ConvertO(itemtimeZone);
                if (itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = ExpressionConverter.ConvertO(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = ExpressionConverter.ConvertO(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["resourceAttendees"] = ExpressionConverter.ConvertO(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["body"] = ExpressionConverter.ConvertO(itembody);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(itemcategories);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["location"] = ExpressionConverter.ConvertO(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["importance"] = ExpressionConverter.ConvertO(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["isAllDay"] = ExpressionConverter.ConvertO(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["recurrence"] = ExpressionConverter.ConvertO(itemrecurrence);
                    itempropCount++;
                }

                if (itemselectedDaysOfWeek != null)
                {
                    item["selectedDaysOfWeek"] = ExpressionConverter.ConvertO(itemselectedDaysOfWeek);
                    itempropCount++;
                }

                if (itemrecurrenceEndDate != null)
                {
                    item["recurrenceEnd"] = ExpressionConverter.ConvertO(itemrecurrenceEndDate);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["numberOfOccurences"] = ExpressionConverter.ConvertO(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(itemreminder);
                    itempropCount++;
                }

                if (itemisReminderOn != null)
                {
                    item["isReminderOn"] = ExpressionConverter.ConvertO(itemisReminderOn);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["showAs"] = ExpressionConverter.ConvertO(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["responseRequested"] = ExpressionConverter.ConvertO(itemresponseRequested);
                    itempropCount++;
                }

                if (itemsensitivity != null)
                {
                    item["sensitivity"] = ExpressionConverter.ConvertO(itemsensitivity);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildContactDeleteItem))]
        public IWorkflowAction ContactDeleteItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactDeleteItem(WorkflowExpression<string> folder, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(folder, nameof(folder), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildContactGetItem))]
        public IBodyWorkflowAction<ContactResponseV2> ContactGetItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponseV2> __BuildContactGetItem(WorkflowExpression<string> folder, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(folder, nameof(folder), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildContactGetItems))]
        public IBodyWorkflowAction<EntityListResponseContactResponseV2> ContactGetItems([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityListResponseContactResponseV2> __BuildContactGetItems(WorkflowExpression<string> folder, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null)
        {
            WorkflowExpression.Validate(folder, nameof(folder), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EntityListResponseContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(folder, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionAction<EntityListResponseContactResponseV2>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildContactPatchItem))]
        public IBodyWorkflowAction<ContactResponseV2> ContactPatchItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddressV2[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponseV2> __BuildContactPatchItem(WorkflowExpression<string> folder, WorkflowExpression<string> id, WorkflowExpression<string> itemgivenName, WorkflowExpression<string[]> itemhomePhones, WorkflowExpression<string> itemid = null, WorkflowExpression<string> itemparentFolderId = null, WorkflowExpression<string> itembirthday = null, WorkflowExpression<string> itemfileAs = null, WorkflowExpression<string> itemdisplayName = null, WorkflowExpression<string> iteminitials = null, WorkflowExpression<string> itemmiddleName = null, WorkflowExpression<string> itemnickname = null, WorkflowExpression<string> itemsurname = null, WorkflowExpression<string> itemtitle = null, WorkflowExpression<string> itemgeneration = null, WorkflowExpression<EmailAddressV2[]> itememailAddresses = null, WorkflowExpression<string[]> itemiMAddresses = null, WorkflowExpression<string> itemjobTitle = null, WorkflowExpression<string> itemcompanyName = null, WorkflowExpression<string> itemdepartment = null, WorkflowExpression<string> itemofficeLocation = null, WorkflowExpression<string> itemprofession = null, WorkflowExpression<string> itembusinessHomePage = null, WorkflowExpression<string> itemassistantName = null, WorkflowExpression<string> itemmanager = null, WorkflowExpression<string[]> itembusinessPhones = null, WorkflowExpression<string> itemmobilePhone = null, WorkflowExpression<string> itemhomeAddressstreet = null, WorkflowExpression<string> itemhomeAddresscity = null, WorkflowExpression<string> itemhomeAddressstate = null, WorkflowExpression<string> itemhomeAddresscountryOrRegion = null, WorkflowExpression<string> itemhomeAddresspostalCode = null, WorkflowExpression<string> itembusinessAddressstreet = null, WorkflowExpression<string> itembusinessAddresscity = null, WorkflowExpression<string> itembusinessAddressstate = null, WorkflowExpression<string> itembusinessAddresscountryOrRegion = null, WorkflowExpression<string> itembusinessAddresspostalCode = null, WorkflowExpression<string> itemotherAddressstreet = null, WorkflowExpression<string> itemotherAddresscity = null, WorkflowExpression<string> itemotherAddressstate = null, WorkflowExpression<string> itemotherAddresscountryOrRegion = null, WorkflowExpression<string> itemotherAddresspostalCode = null, WorkflowExpression<string> itemyomiCompanyName = null, WorkflowExpression<string> itemyomiGivenName = null, WorkflowExpression<string> itemyomiSurname = null, WorkflowExpression<string[]> itemcategories = null, WorkflowExpression<string> itemchangeKey = null, WorkflowExpression<string> itemcreatedTime = null, WorkflowExpression<string> itemlastModifiedTime = null)
        {
            WorkflowExpression.Validate(folder, nameof(folder), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(itemgivenName, nameof(itemgivenName), required: true);
            WorkflowExpression.Validate(itemhomePhones, nameof(itemhomePhones), required: true);
            WorkflowExpression.Validate(itemid, nameof(itemid), required: false);
            WorkflowExpression.Validate(itemparentFolderId, nameof(itemparentFolderId), required: false);
            WorkflowExpression.Validate(itembirthday, nameof(itembirthday), required: false);
            WorkflowExpression.Validate(itemfileAs, nameof(itemfileAs), required: false);
            WorkflowExpression.Validate(itemdisplayName, nameof(itemdisplayName), required: false);
            WorkflowExpression.Validate(iteminitials, nameof(iteminitials), required: false);
            WorkflowExpression.Validate(itemmiddleName, nameof(itemmiddleName), required: false);
            WorkflowExpression.Validate(itemnickname, nameof(itemnickname), required: false);
            WorkflowExpression.Validate(itemsurname, nameof(itemsurname), required: false);
            WorkflowExpression.Validate(itemtitle, nameof(itemtitle), required: false);
            WorkflowExpression.Validate(itemgeneration, nameof(itemgeneration), required: false);
            WorkflowExpression.Validate(itememailAddresses, nameof(itememailAddresses), required: false);
            WorkflowExpression.Validate(itemiMAddresses, nameof(itemiMAddresses), required: false);
            WorkflowExpression.Validate(itemjobTitle, nameof(itemjobTitle), required: false);
            WorkflowExpression.Validate(itemcompanyName, nameof(itemcompanyName), required: false);
            WorkflowExpression.Validate(itemdepartment, nameof(itemdepartment), required: false);
            WorkflowExpression.Validate(itemofficeLocation, nameof(itemofficeLocation), required: false);
            WorkflowExpression.Validate(itemprofession, nameof(itemprofession), required: false);
            WorkflowExpression.Validate(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            WorkflowExpression.Validate(itemassistantName, nameof(itemassistantName), required: false);
            WorkflowExpression.Validate(itemmanager, nameof(itemmanager), required: false);
            WorkflowExpression.Validate(itembusinessPhones, nameof(itembusinessPhones), required: false);
            WorkflowExpression.Validate(itemmobilePhone, nameof(itemmobilePhone), required: false);
            WorkflowExpression.Validate(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            WorkflowExpression.Validate(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            WorkflowExpression.Validate(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            WorkflowExpression.Validate(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            WorkflowExpression.Validate(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            WorkflowExpression.Validate(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            WorkflowExpression.Validate(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            WorkflowExpression.Validate(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            WorkflowExpression.Validate(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            WorkflowExpression.Validate(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            WorkflowExpression.Validate(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            WorkflowExpression.Validate(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            WorkflowExpression.Validate(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            WorkflowExpression.Validate(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            WorkflowExpression.Validate(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            WorkflowExpression.Validate(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            WorkflowExpression.Validate(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            WorkflowExpression.Validate(itemyomiSurname, nameof(itemyomiSurname), required: false);
            WorkflowExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            WorkflowExpression.Validate(itemchangeKey, nameof(itemchangeKey), required: false);
            WorkflowExpression.Validate(itemcreatedTime, nameof(itemcreatedTime), required: false);
            WorkflowExpression.Validate(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            return new DeferredBodyAction<ContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["id"] = ExpressionConverter.ConvertO(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["parentFolderId"] = ExpressionConverter.ConvertO(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["birthday"] = ExpressionConverter.ConvertO(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["fileAs"] = ExpressionConverter.ConvertO(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["displayName"] = ExpressionConverter.ConvertO(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["givenName"] = ExpressionConverter.ConvertO(itemgivenName);
                if (iteminitials != null)
                {
                    item["initials"] = ExpressionConverter.ConvertO(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["middleName"] = ExpressionConverter.ConvertO(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["nickName"] = ExpressionConverter.ConvertO(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["surname"] = ExpressionConverter.ConvertO(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["title"] = ExpressionConverter.ConvertO(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["generation"] = ExpressionConverter.ConvertO(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["emailAddresses"] = ExpressionConverter.ConvertO(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["imAddresses"] = ExpressionConverter.ConvertO(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["jobTitle"] = ExpressionConverter.ConvertO(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["companyName"] = ExpressionConverter.ConvertO(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["department"] = ExpressionConverter.ConvertO(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["officeLocation"] = ExpressionConverter.ConvertO(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["profession"] = ExpressionConverter.ConvertO(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["businessHomePage"] = ExpressionConverter.ConvertO(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["assistantName"] = ExpressionConverter.ConvertO(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["manager"] = ExpressionConverter.ConvertO(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["homePhones"] = ExpressionConverter.ConvertO(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["businessPhones"] = ExpressionConverter.ConvertO(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["mobilePhone"] = ExpressionConverter.ConvertO(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["city"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["state"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["postalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
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
                    businessAddressObject["street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["city"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["state"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["postalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
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
                    otherAddressObject["street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["city"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["state"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["postalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["otherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["yomiCompanyName"] = ExpressionConverter.ConvertO(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["yomiGivenName"] = ExpressionConverter.ConvertO(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["yomiSurname"] = ExpressionConverter.ConvertO(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["changeKey"] = ExpressionConverter.ConvertO(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["createdDateTime"] = ExpressionConverter.ConvertO(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["lastModifiedDateTime"] = ExpressionConverter.ConvertO(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildContactPostItem))]
        public IBodyWorkflowAction<ContactResponseV2> ContactPostItem([WorkflowExpression] Func<string> folder, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddressV2[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponseV2> __BuildContactPostItem(WorkflowExpression<string> folder, WorkflowExpression<string> itemgivenName, WorkflowExpression<string[]> itemhomePhones, WorkflowExpression<string> itemid = null, WorkflowExpression<string> itemparentFolderId = null, WorkflowExpression<string> itembirthday = null, WorkflowExpression<string> itemfileAs = null, WorkflowExpression<string> itemdisplayName = null, WorkflowExpression<string> iteminitials = null, WorkflowExpression<string> itemmiddleName = null, WorkflowExpression<string> itemnickname = null, WorkflowExpression<string> itemsurname = null, WorkflowExpression<string> itemtitle = null, WorkflowExpression<string> itemgeneration = null, WorkflowExpression<EmailAddressV2[]> itememailAddresses = null, WorkflowExpression<string[]> itemiMAddresses = null, WorkflowExpression<string> itemjobTitle = null, WorkflowExpression<string> itemcompanyName = null, WorkflowExpression<string> itemdepartment = null, WorkflowExpression<string> itemofficeLocation = null, WorkflowExpression<string> itemprofession = null, WorkflowExpression<string> itembusinessHomePage = null, WorkflowExpression<string> itemassistantName = null, WorkflowExpression<string> itemmanager = null, WorkflowExpression<string[]> itembusinessPhones = null, WorkflowExpression<string> itemmobilePhone = null, WorkflowExpression<string> itemhomeAddressstreet = null, WorkflowExpression<string> itemhomeAddresscity = null, WorkflowExpression<string> itemhomeAddressstate = null, WorkflowExpression<string> itemhomeAddresscountryOrRegion = null, WorkflowExpression<string> itemhomeAddresspostalCode = null, WorkflowExpression<string> itembusinessAddressstreet = null, WorkflowExpression<string> itembusinessAddresscity = null, WorkflowExpression<string> itembusinessAddressstate = null, WorkflowExpression<string> itembusinessAddresscountryOrRegion = null, WorkflowExpression<string> itembusinessAddresspostalCode = null, WorkflowExpression<string> itemotherAddressstreet = null, WorkflowExpression<string> itemotherAddresscity = null, WorkflowExpression<string> itemotherAddressstate = null, WorkflowExpression<string> itemotherAddresscountryOrRegion = null, WorkflowExpression<string> itemotherAddresspostalCode = null, WorkflowExpression<string> itemyomiCompanyName = null, WorkflowExpression<string> itemyomiGivenName = null, WorkflowExpression<string> itemyomiSurname = null, WorkflowExpression<string[]> itemcategories = null, WorkflowExpression<string> itemchangeKey = null, WorkflowExpression<string> itemcreatedTime = null, WorkflowExpression<string> itemlastModifiedTime = null)
        {
            WorkflowExpression.Validate(folder, nameof(folder), required: true);
            WorkflowExpression.Validate(itemgivenName, nameof(itemgivenName), required: true);
            WorkflowExpression.Validate(itemhomePhones, nameof(itemhomePhones), required: true);
            WorkflowExpression.Validate(itemid, nameof(itemid), required: false);
            WorkflowExpression.Validate(itemparentFolderId, nameof(itemparentFolderId), required: false);
            WorkflowExpression.Validate(itembirthday, nameof(itembirthday), required: false);
            WorkflowExpression.Validate(itemfileAs, nameof(itemfileAs), required: false);
            WorkflowExpression.Validate(itemdisplayName, nameof(itemdisplayName), required: false);
            WorkflowExpression.Validate(iteminitials, nameof(iteminitials), required: false);
            WorkflowExpression.Validate(itemmiddleName, nameof(itemmiddleName), required: false);
            WorkflowExpression.Validate(itemnickname, nameof(itemnickname), required: false);
            WorkflowExpression.Validate(itemsurname, nameof(itemsurname), required: false);
            WorkflowExpression.Validate(itemtitle, nameof(itemtitle), required: false);
            WorkflowExpression.Validate(itemgeneration, nameof(itemgeneration), required: false);
            WorkflowExpression.Validate(itememailAddresses, nameof(itememailAddresses), required: false);
            WorkflowExpression.Validate(itemiMAddresses, nameof(itemiMAddresses), required: false);
            WorkflowExpression.Validate(itemjobTitle, nameof(itemjobTitle), required: false);
            WorkflowExpression.Validate(itemcompanyName, nameof(itemcompanyName), required: false);
            WorkflowExpression.Validate(itemdepartment, nameof(itemdepartment), required: false);
            WorkflowExpression.Validate(itemofficeLocation, nameof(itemofficeLocation), required: false);
            WorkflowExpression.Validate(itemprofession, nameof(itemprofession), required: false);
            WorkflowExpression.Validate(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            WorkflowExpression.Validate(itemassistantName, nameof(itemassistantName), required: false);
            WorkflowExpression.Validate(itemmanager, nameof(itemmanager), required: false);
            WorkflowExpression.Validate(itembusinessPhones, nameof(itembusinessPhones), required: false);
            WorkflowExpression.Validate(itemmobilePhone, nameof(itemmobilePhone), required: false);
            WorkflowExpression.Validate(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            WorkflowExpression.Validate(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            WorkflowExpression.Validate(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            WorkflowExpression.Validate(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            WorkflowExpression.Validate(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            WorkflowExpression.Validate(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            WorkflowExpression.Validate(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            WorkflowExpression.Validate(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            WorkflowExpression.Validate(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            WorkflowExpression.Validate(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            WorkflowExpression.Validate(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            WorkflowExpression.Validate(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            WorkflowExpression.Validate(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            WorkflowExpression.Validate(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            WorkflowExpression.Validate(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            WorkflowExpression.Validate(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            WorkflowExpression.Validate(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            WorkflowExpression.Validate(itemyomiSurname, nameof(itemyomiSurname), required: false);
            WorkflowExpression.Validate(itemcategories, nameof(itemcategories), required: false);
            WorkflowExpression.Validate(itemchangeKey, nameof(itemchangeKey), required: false);
            WorkflowExpression.Validate(itemcreatedTime, nameof(itemcreatedTime), required: false);
            WorkflowExpression.Validate(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            return new DeferredBodyAction<ContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(folder, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["id"] = ExpressionConverter.ConvertO(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["parentFolderId"] = ExpressionConverter.ConvertO(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["birthday"] = ExpressionConverter.ConvertO(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["fileAs"] = ExpressionConverter.ConvertO(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["displayName"] = ExpressionConverter.ConvertO(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["givenName"] = ExpressionConverter.ConvertO(itemgivenName);
                if (iteminitials != null)
                {
                    item["initials"] = ExpressionConverter.ConvertO(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["middleName"] = ExpressionConverter.ConvertO(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["nickName"] = ExpressionConverter.ConvertO(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["surname"] = ExpressionConverter.ConvertO(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["title"] = ExpressionConverter.ConvertO(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["generation"] = ExpressionConverter.ConvertO(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["emailAddresses"] = ExpressionConverter.ConvertO(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["imAddresses"] = ExpressionConverter.ConvertO(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["jobTitle"] = ExpressionConverter.ConvertO(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["companyName"] = ExpressionConverter.ConvertO(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["department"] = ExpressionConverter.ConvertO(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["officeLocation"] = ExpressionConverter.ConvertO(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["profession"] = ExpressionConverter.ConvertO(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["businessHomePage"] = ExpressionConverter.ConvertO(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["assistantName"] = ExpressionConverter.ConvertO(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["manager"] = ExpressionConverter.ConvertO(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["homePhones"] = ExpressionConverter.ConvertO(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["businessPhones"] = ExpressionConverter.ConvertO(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["mobilePhone"] = ExpressionConverter.ConvertO(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["city"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["state"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["postalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
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
                    businessAddressObject["street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["city"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["state"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["postalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
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
                    otherAddressObject["street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["city"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["state"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["postalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["otherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["yomiCompanyName"] = ExpressionConverter.ConvertO(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["yomiGivenName"] = ExpressionConverter.ConvertO(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["yomiSurname"] = ExpressionConverter.ConvertO(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["changeKey"] = ExpressionConverter.ConvertO(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["createdDateTime"] = ExpressionConverter.ConvertO(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["lastModifiedDateTime"] = ExpressionConverter.ConvertO(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEmail))]
        public IWorkflowAction DeleteEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEmail(WorkflowExpression<string> messageId, WorkflowExpression<string> mailboxAddress = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildExportEmail))]
        public IBodyWorkflowAction<string> ExportEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExportEmail(WorkflowExpression<string> messageId, WorkflowExpression<string> mailboxAddress = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/beta/me/messages/{0}/$value", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildFindMeetingTimes))]
        public IBodyWorkflowAction<FindMeetingTimesV2Response> FindMeetingTimes([WorkflowExpression] Func<string> bodyrequiredAttendees = null, [WorkflowExpression] Func<string> bodyoptionalAttendees = null, [WorkflowExpression] Func<string> bodyresourceAttendees = null, [WorkflowExpression] Func<int> bodymeetingDuration = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<int> bodymaxCandidates = null, [WorkflowExpression] Func<string> bodyminimumAttendeePercentage = null, [WorkflowExpression] Func<bool> bodyisOrganizerOptional = null, [WorkflowExpression] Func<bodyactivityDomainInput> bodyactivityDomain = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindMeetingTimesV2Response> __BuildFindMeetingTimes(WorkflowExpression<string> bodyrequiredAttendees = null, WorkflowExpression<string> bodyoptionalAttendees = null, WorkflowExpression<string> bodyresourceAttendees = null, WorkflowExpression<int> bodymeetingDuration = null, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<int> bodymaxCandidates = null, WorkflowExpression<string> bodyminimumAttendeePercentage = null, WorkflowExpression<bool> bodyisOrganizerOptional = null, WorkflowExpression<bodyactivityDomainInput> bodyactivityDomain = null)
        {
            WorkflowExpression.Validate(bodyrequiredAttendees, nameof(bodyrequiredAttendees), required: false);
            WorkflowExpression.Validate(bodyoptionalAttendees, nameof(bodyoptionalAttendees), required: false);
            WorkflowExpression.Validate(bodyresourceAttendees, nameof(bodyresourceAttendees), required: false);
            WorkflowExpression.Validate(bodymeetingDuration, nameof(bodymeetingDuration), required: false);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodymaxCandidates, nameof(bodymaxCandidates), required: false);
            WorkflowExpression.Validate(bodyminimumAttendeePercentage, nameof(bodyminimumAttendeePercentage), required: false);
            WorkflowExpression.Validate(bodyisOrganizerOptional, nameof(bodyisOrganizerOptional), required: false);
            WorkflowExpression.Validate(bodyactivityDomain, nameof(bodyactivityDomain), required: false);
            return new DeferredBodyAction<FindMeetingTimesV2Response>(() =>
            {
                var apiCallPath = "/codeless/beta/me/findMeetingTimes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequiredAttendees != null)
                {
                    body["RequiredAttendees"] = ExpressionConverter.ConvertO(bodyrequiredAttendees);
                    bodypropCount++;
                }

                if (bodyoptionalAttendees != null)
                {
                    body["OptionalAttendees"] = ExpressionConverter.ConvertO(bodyoptionalAttendees);
                    bodypropCount++;
                }

                if (bodyresourceAttendees != null)
                {
                    body["ResourceAttendees"] = ExpressionConverter.ConvertO(bodyresourceAttendees);
                    bodypropCount++;
                }

                if (bodymeetingDuration != null)
                {
                    body["MeetingDuration"] = ExpressionConverter.ConvertO(bodymeetingDuration);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["Start"] = ExpressionConverter.ConvertO(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["End"] = ExpressionConverter.ConvertO(bodyendTime);
                    bodypropCount++;
                }

                if (bodymaxCandidates != null)
                {
                    body["MaxCandidates"] = ExpressionConverter.ConvertO(bodymaxCandidates);
                    bodypropCount++;
                }

                if (bodyminimumAttendeePercentage != null)
                {
                    body["MinimumAttendeePercentage"] = ExpressionConverter.ConvertO(bodyminimumAttendeePercentage);
                    bodypropCount++;
                }

                if (bodyisOrganizerOptional != null)
                {
                    body["IsOrganizerOptional"] = ExpressionConverter.ConvertO(bodyisOrganizerOptional);
                    bodypropCount++;
                }

                if (bodyactivityDomain != null)
                {
                    if (bodyactivityDomain != null)
                    {
                        body["ActivityDomain"] = ExpressionConverter.ConvertO(bodyactivityDomain);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildFlag))]
        public IWorkflowAction Flag([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bodyflagflagStatusInput> bodyflagflagStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlag(WorkflowExpression<string> messageId, WorkflowExpression<string> mailboxAddress = null, WorkflowExpression<bodyflagflagStatusInput> bodyflagflagStatus = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            WorkflowExpression.Validate(bodyflagflagStatus, nameof(bodyflagflagStatus), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/flag", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                var flagObject = new JObject();
                var flagObjectpropCount = 0;
                if (bodyflagflagStatus != null)
                {
                    if (bodyflagflagStatus != null)
                    {
                        flagObject["flagStatus"] = ExpressionConverter.ConvertO(bodyflagflagStatus);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildForwardEmail))]
        public IWorkflowAction ForwardEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildForwardEmail(WorkflowExpression<string> messageId, WorkflowExpression<string> bodyto, WorkflowExpression<string> mailboxAddress = null, WorkflowExpression<string> bodycomment = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/forward", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToRecipients"] = ExpressionConverter.ConvertO(bodyto);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttachment))]
        public IBodyWorkflowAction<GetAttachmentV2Response> GetAttachment([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAttachmentV2Response> __BuildGetAttachment(WorkflowExpression<string> messageId, WorkflowExpression<string> attachmentId, WorkflowExpression<string> mailboxAddress = null, WorkflowExpression<bool> extractSensitivityLabel = null, WorkflowExpression<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            WorkflowExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetAttachmentV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/messages/{0}/attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetAttachmentV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmail))]
        public IBodyWorkflowAction<GraphClientReceiveMessage> GetEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> internetMessageId = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphClientReceiveMessage> __BuildGetEmail(WorkflowExpression<string> messageId, WorkflowExpression<string> mailboxAddress = null, WorkflowExpression<bool> includeAttachments = null, WorkflowExpression<string> internetMessageId = null, WorkflowExpression<bool> extractSensitivityLabel = null, WorkflowExpression<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowExpression.Validate(internetMessageId, nameof(internetMessageId), required: false);
            WorkflowExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GraphClientReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (internetMessageId != null)
                    callPayload.Queries["internetMessageId"] = ExpressionConverter.Convert(internetMessageId);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmails))]
        public IBodyWorkflowAction<BatchResponseGraphClientReceiveMessage> GetEmails([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<string> subjectFilter = null, [WorkflowExpression] Func<bool> fetchOnlyUnread = null, [WorkflowExpression] Func<string> mailboxAddress = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> searchQuery = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BatchResponseGraphClientReceiveMessage> __BuildGetEmails(WorkflowExpression<string> folderPath = null, WorkflowExpression<string> to = null, WorkflowExpression<string> cc = null, WorkflowExpression<string> toOrCc = null, WorkflowExpression<string> from = null, WorkflowExpression<importanceInput> importance = null, WorkflowExpression<bool> fetchOnlyWithAttachment = null, WorkflowExpression<string> subjectFilter = null, WorkflowExpression<bool> fetchOnlyUnread = null, WorkflowExpression<string> mailboxAddress = null, WorkflowExpression<bool> includeAttachments = null, WorkflowExpression<string> searchQuery = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(cc, nameof(cc), required: false);
            WorkflowExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(importance, nameof(importance), required: false);
            WorkflowExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            WorkflowExpression.Validate(fetchOnlyUnread, nameof(fetchOnlyUnread), required: false);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowExpression.Validate(searchQuery, nameof(searchQuery), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<BatchResponseGraphClientReceiveMessage>(() =>
            {
                var apiCallPath = "/v3/Mail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = Convert.ToString("Inbox");
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                if (cc != null)
                    callPayload.Queries["cc"] = ExpressionConverter.Convert(cc);
                if (toOrCc != null)
                    callPayload.Queries["toOrCc"] = ExpressionConverter.Convert(toOrCc);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                callPayload.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    callPayload.Queries["importance"] = ExpressionConverter.Convert(importance);
                callPayload.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    callPayload.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
                if (subjectFilter != null)
                    callPayload.Queries["subjectFilter"] = ExpressionConverter.Convert(subjectFilter);
                callPayload.Queries["fetchOnlyUnread"] = Convert.ToString(true);
                if (fetchOnlyUnread != null)
                    callPayload.Queries["fetchOnlyUnread"] = ExpressionConverter.Convert(fetchOnlyUnread);
                callPayload.Queries["fetchOnlyFlagged"] = Convert.ToString(false);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (searchQuery != null)
                    callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(searchQuery);
                callPayload.Queries["top"] = Convert.ToString(10);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<BatchResponseGraphClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildGetEventsCalendarView))]
        public IBodyWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> GetEventsCalendarView([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> startDateTimeUtc, [WorkflowExpression] Func<string> endDateTimeUtc, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> search = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> __BuildGetEventsCalendarView(WorkflowExpression<string> calendarId, WorkflowExpression<string> startDateTimeUtc, WorkflowExpression<string> endDateTimeUtc, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> search = null)
        {
            WorkflowExpression.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowExpression.Validate(startDateTimeUtc, nameof(startDateTimeUtc), required: true);
            WorkflowExpression.Validate(endDateTimeUtc, nameof(endDateTimeUtc), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            return new DeferredBodyAction<EntityListResponseGraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = "/datasets/calendars/v3/tables/items/calendarview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["calendarId"] = ExpressionConverter.Convert(calendarId);
                callPayload.Queries["startDateTimeUtc"] = ExpressionConverter.Convert(startDateTimeUtc);
                callPayload.Queries["endDateTimeUtc"] = ExpressionConverter.Convert(endDateTimeUtc);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                return new ApiConnectionAction<EntityListResponseGraphCalendarEventClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildGetMailTips))]
        public IBodyWorkflowAction<GetMailTipsV2Response> GetMailTips([WorkflowExpression] Func<string[]> bodyemailAddresses)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMailTipsV2Response> __BuildGetMailTips(WorkflowExpression<string[]> bodyemailAddresses)
        {
            WorkflowExpression.Validate(bodyemailAddresses, nameof(bodyemailAddresses), required: true);
            return new DeferredBodyAction<GetMailTipsV2Response>(() =>
            {
                var apiCallPath = "/codeless/v1.0/me/getMailTips";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["MailTipsOptions"] = "automaticReplies, deliveryRestriction, externalMemberCount, mailboxFullStatus, maxMessageSize, moderationStatus, totalMemberCount";
                bodypropCount++;
                bodypropCount++;
                body["EmailAddresses"] = ExpressionConverter.ConvertO(bodyemailAddresses);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetMailTipsV2Response>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildGetRoomsInRoomList))]
        public IBodyWorkflowAction<GetRoomsInRoomListV2Response> GetRoomsInRoomList([WorkflowExpression] Func<string> roomList)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRoomsInRoomListV2Response> __BuildGetRoomsInRoomList(WorkflowExpression<string> roomList)
        {
            WorkflowExpression.Validate(roomList, nameof(roomList), required: true);
            return new DeferredBodyAction<GetRoomsInRoomListV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/beta/me/findRooms(RoomList='{0}')", ExpressionConverter.ConvertWithUrlEncoding(roomList, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRoomsInRoomListV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildMarkAsRead))]
        public IWorkflowAction MarkAsRead([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<bool> bodymarkAs, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarkAsRead(WorkflowExpression<string> messageId, WorkflowExpression<bool> bodymarkAs, WorkflowExpression<string> mailboxAddress = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(bodymarkAs, nameof(bodymarkAs), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v3/v1.0/me/messages/{0}/markAsRead", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isRead"] = ExpressionConverter.ConvertO(bodymarkAs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildMove))]
        public IBodyWorkflowAction<GraphClientReceiveMessage> Move([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphClientReceiveMessage> __BuildMove(WorkflowExpression<string> messageId, WorkflowExpression<string> folderPath, WorkflowExpression<string> mailboxAddress = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: true);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredBodyAction<GraphClientReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/Mail/Move/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildReplyTo))]
        public IWorkflowAction ReplyTo([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> replyParametersto = null, [WorkflowExpression] Func<string> replyParameterscC = null, [WorkflowExpression] Func<string> replyParametersbCC = null, [WorkflowExpression] Func<string> replyParameterssubject = null, [WorkflowExpression] Func<string> replyParametersbody = null, [WorkflowExpression] Func<bool> replyParametersreplyAll = null, [WorkflowExpression] Func<replyParametersimportanceInput> replyParametersimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> replyParametersattachments = null, [WorkflowExpression] Func<string> mailboxAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReplyTo(WorkflowExpression<string> messageId, WorkflowExpression<string> replyParametersto = null, WorkflowExpression<string> replyParameterscC = null, WorkflowExpression<string> replyParametersbCC = null, WorkflowExpression<string> replyParameterssubject = null, WorkflowExpression<string> replyParametersbody = null, WorkflowExpression<bool> replyParametersreplyAll = null, WorkflowExpression<replyParametersimportanceInput> replyParametersimportance = null, WorkflowExpression<ClientSendAttachment[]> replyParametersattachments = null, WorkflowExpression<string> mailboxAddress = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(replyParametersto, nameof(replyParametersto), required: false);
            WorkflowExpression.Validate(replyParameterscC, nameof(replyParameterscC), required: false);
            WorkflowExpression.Validate(replyParametersbCC, nameof(replyParametersbCC), required: false);
            WorkflowExpression.Validate(replyParameterssubject, nameof(replyParameterssubject), required: false);
            WorkflowExpression.Validate(replyParametersbody, nameof(replyParametersbody), required: false);
            WorkflowExpression.Validate(replyParametersreplyAll, nameof(replyParametersreplyAll), required: false);
            WorkflowExpression.Validate(replyParametersimportance, nameof(replyParametersimportance), required: false);
            WorkflowExpression.Validate(replyParametersattachments, nameof(replyParametersattachments), required: false);
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                var replyParameters = new JObject();
                var replyParameterspropCount = 0;
                if (replyParametersto != null)
                {
                    replyParameters["To"] = ExpressionConverter.ConvertO(replyParametersto);
                    replyParameterspropCount++;
                }

                if (replyParameterscC != null)
                {
                    replyParameters["Cc"] = ExpressionConverter.ConvertO(replyParameterscC);
                    replyParameterspropCount++;
                }

                if (replyParametersbCC != null)
                {
                    replyParameters["Bcc"] = ExpressionConverter.ConvertO(replyParametersbCC);
                    replyParameterspropCount++;
                }

                if (replyParameterssubject != null)
                {
                    replyParameters["Subject"] = ExpressionConverter.ConvertO(replyParameterssubject);
                    replyParameterspropCount++;
                }

                if (replyParametersbody != null)
                {
                    replyParameters["Body"] = ExpressionConverter.ConvertO(replyParametersbody);
                    replyParameterspropCount++;
                }

                if (replyParametersreplyAll != null)
                {
                    replyParameters["ReplyAll"] = ExpressionConverter.ConvertO(replyParametersreplyAll);
                    replyParameterspropCount++;
                }

                if (replyParametersimportance != null)
                {
                    replyParameters["Importance"] = ExpressionConverter.ConvertO(replyParametersimportance);
                    replyParameterspropCount++;
                }

                if (replyParametersattachments != null)
                {
                    replyParameters["Attachments"] = ExpressionConverter.ConvertO(replyParametersattachments);
                    replyParameterspropCount++;
                }

                if (replyParameterspropCount > 0)
                {
                    callPayload.Body = replyParameters;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildRespondToEvent))]
        public IWorkflowAction RespondToEvent([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<responseInput> response, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<bool> bodysendResponse = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRespondToEvent(WorkflowExpression<string> eventId, WorkflowExpression<responseInput> response, WorkflowExpression<string> bodycomment = null, WorkflowExpression<bool> bodysendResponse = null)
        {
            WorkflowExpression.Validate(eventId, nameof(eventId), required: true);
            WorkflowExpression.Validate(response, nameof(response), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodysendResponse, nameof(bodysendResponse), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/me/events/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(response, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                    bodypropCount++;
                }

                if (bodysendResponse != null)
                {
                    if (bodysendResponse != null)
                    {
                        body["SendResponse"] = ExpressionConverter.ConvertO(bodysendResponse);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildSendEmail))]
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagesubject, [WorkflowExpression] Func<string> emailMessagebody, [WorkflowExpression] Func<string> emailMessagefromSendAs = null, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> emailMessageattachments = null, [WorkflowExpression] Func<string> emailMessagesensitivity = null, [WorkflowExpression] Func<string> emailMessagereplyTo = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEmail(WorkflowExpression<string> emailMessageto, WorkflowExpression<string> emailMessagesubject, WorkflowExpression<string> emailMessagebody, WorkflowExpression<string> emailMessagefromSendAs = null, WorkflowExpression<string> emailMessagecC = null, WorkflowExpression<string> emailMessagebCC = null, WorkflowExpression<ClientSendAttachment[]> emailMessageattachments = null, WorkflowExpression<string> emailMessagesensitivity = null, WorkflowExpression<string> emailMessagereplyTo = null, WorkflowExpression<emailMessageimportanceInput> emailMessageimportance = null)
        {
            WorkflowExpression.Validate(emailMessageto, nameof(emailMessageto), required: true);
            WorkflowExpression.Validate(emailMessagesubject, nameof(emailMessagesubject), required: true);
            WorkflowExpression.Validate(emailMessagebody, nameof(emailMessagebody), required: true);
            WorkflowExpression.Validate(emailMessagefromSendAs, nameof(emailMessagefromSendAs), required: false);
            WorkflowExpression.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            WorkflowExpression.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            WorkflowExpression.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            WorkflowExpression.Validate(emailMessagesensitivity, nameof(emailMessagesensitivity), required: false);
            WorkflowExpression.Validate(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            WorkflowExpression.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["To"] = ExpressionConverter.ConvertO(emailMessageto);
                emailMessagepropCount++;
                emailMessage["Subject"] = ExpressionConverter.ConvertO(emailMessagesubject);
                emailMessagepropCount++;
                emailMessage["Body"] = ExpressionConverter.ConvertO(emailMessagebody);
                if (emailMessagefromSendAs != null)
                {
                    emailMessage["From"] = ExpressionConverter.ConvertO(emailMessagefromSendAs);
                    emailMessagepropCount++;
                }

                if (emailMessagecC != null)
                {
                    emailMessage["Cc"] = ExpressionConverter.ConvertO(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = ExpressionConverter.ConvertO(emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = ExpressionConverter.ConvertO(emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagesensitivity != null)
                {
                    emailMessage["Sensitivity"] = ExpressionConverter.ConvertO(emailMessagesensitivity);
                    emailMessagepropCount++;
                }

                if (emailMessagereplyTo != null)
                {
                    emailMessage["ReplyTo"] = ExpressionConverter.ConvertO(emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    if (emailMessageimportance != null)
                    {
                        emailMessage["Importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildSetAutomaticRepliesSetting))]
        public IBodyWorkflowAction<SetAutomaticRepliesSettingV2Response> SetAutomaticRepliesSetting([WorkflowExpression] Func<bodyautomaticRepliesSettingstatusInput> bodyautomaticRepliesSettingstatus, [WorkflowExpression] Func<bodyautomaticRepliesSettingexternalAudienceInput> bodyautomaticRepliesSettingexternalAudience, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingstartTimedateTime = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingstartTimetimeZone = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingendTimedateTime = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingendTimetimeZone = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettinginternalReplyMessage = null, [WorkflowExpression] Func<string> bodyautomaticRepliesSettingexternalReplyMessage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetAutomaticRepliesSettingV2Response> __BuildSetAutomaticRepliesSetting(WorkflowExpression<bodyautomaticRepliesSettingstatusInput> bodyautomaticRepliesSettingstatus, WorkflowExpression<bodyautomaticRepliesSettingexternalAudienceInput> bodyautomaticRepliesSettingexternalAudience, WorkflowExpression<string> bodyautomaticRepliesSettingstartTimedateTime = null, WorkflowExpression<string> bodyautomaticRepliesSettingstartTimetimeZone = null, WorkflowExpression<string> bodyautomaticRepliesSettingendTimedateTime = null, WorkflowExpression<string> bodyautomaticRepliesSettingendTimetimeZone = null, WorkflowExpression<string> bodyautomaticRepliesSettinginternalReplyMessage = null, WorkflowExpression<string> bodyautomaticRepliesSettingexternalReplyMessage = null)
        {
            WorkflowExpression.Validate(bodyautomaticRepliesSettingstatus, nameof(bodyautomaticRepliesSettingstatus), required: true);
            WorkflowExpression.Validate(bodyautomaticRepliesSettingexternalAudience, nameof(bodyautomaticRepliesSettingexternalAudience), required: true);
            WorkflowExpression.Validate(bodyautomaticRepliesSettingstartTimedateTime, nameof(bodyautomaticRepliesSettingstartTimedateTime), required: false);
            WorkflowExpression.Validate(bodyautomaticRepliesSettingstartTimetimeZone, nameof(bodyautomaticRepliesSettingstartTimetimeZone), required: false);
            WorkflowExpression.Validate(bodyautomaticRepliesSettingendTimedateTime, nameof(bodyautomaticRepliesSettingendTimedateTime), required: false);
            WorkflowExpression.Validate(bodyautomaticRepliesSettingendTimetimeZone, nameof(bodyautomaticRepliesSettingendTimetimeZone), required: false);
            WorkflowExpression.Validate(bodyautomaticRepliesSettinginternalReplyMessage, nameof(bodyautomaticRepliesSettinginternalReplyMessage), required: false);
            WorkflowExpression.Validate(bodyautomaticRepliesSettingexternalReplyMessage, nameof(bodyautomaticRepliesSettingexternalReplyMessage), required: false);
            return new DeferredBodyAction<SetAutomaticRepliesSettingV2Response>(() =>
            {
                var apiCallPath = "/codeless/v1.0/me/mailboxSettings";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var automaticRepliesSettingObject = new JObject();
                var automaticRepliesSettingObjectpropCount = 0;
                automaticRepliesSettingObjectpropCount++;
                automaticRepliesSettingObject["status"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettingstatus);
                automaticRepliesSettingObjectpropCount++;
                automaticRepliesSettingObject["externalAudience"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettingexternalAudience);
                var scheduledStartDateTimeObject = new JObject();
                var scheduledStartDateTimeObjectpropCount = 0;
                if (bodyautomaticRepliesSettingstartTimedateTime != null)
                {
                    scheduledStartDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettingstartTimedateTime);
                    scheduledStartDateTimeObjectpropCount++;
                }

                if (bodyautomaticRepliesSettingstartTimetimeZone != null)
                {
                    scheduledStartDateTimeObject["timeZone"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettingstartTimetimeZone);
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
                    scheduledEndDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettingendTimedateTime);
                    scheduledEndDateTimeObjectpropCount++;
                }

                if (bodyautomaticRepliesSettingendTimetimeZone != null)
                {
                    scheduledEndDateTimeObject["timeZone"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettingendTimetimeZone);
                    scheduledEndDateTimeObjectpropCount++;
                }

                if (scheduledEndDateTimeObjectpropCount > 0)
                {
                    automaticRepliesSettingObject["scheduledEndDateTime"] = scheduledEndDateTimeObject;
                    automaticRepliesSettingObjectpropCount++;
                }

                if (bodyautomaticRepliesSettinginternalReplyMessage != null)
                {
                    automaticRepliesSettingObject["internalReplyMessage"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettinginternalReplyMessage);
                    automaticRepliesSettingObjectpropCount++;
                }

                if (bodyautomaticRepliesSettingexternalReplyMessage != null)
                {
                    automaticRepliesSettingObject["externalReplyMessage"] = ExpressionConverter.ConvertO(bodyautomaticRepliesSettingexternalReplyMessage);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [WorkflowExpressionFactory(nameof(__BuildSharedMailboxSendEmail))]
        public IWorkflowAction SharedMailboxSendEmail([WorkflowExpression] Func<string> emailMessageoriginalMailboxAddress, [WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagesubject, [WorkflowExpression] Func<string> emailMessagebody, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> emailMessageattachments = null, [WorkflowExpression] Func<string> emailMessagesensitivity = null, [WorkflowExpression] Func<string> emailMessagereplyTo = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSharedMailboxSendEmail(WorkflowExpression<string> emailMessageoriginalMailboxAddress, WorkflowExpression<string> emailMessageto, WorkflowExpression<string> emailMessagesubject, WorkflowExpression<string> emailMessagebody, WorkflowExpression<string> emailMessagecC = null, WorkflowExpression<string> emailMessagebCC = null, WorkflowExpression<ClientSendAttachment[]> emailMessageattachments = null, WorkflowExpression<string> emailMessagesensitivity = null, WorkflowExpression<string> emailMessagereplyTo = null, WorkflowExpression<emailMessageimportanceInput> emailMessageimportance = null)
        {
            WorkflowExpression.Validate(emailMessageoriginalMailboxAddress, nameof(emailMessageoriginalMailboxAddress), required: true);
            WorkflowExpression.Validate(emailMessageto, nameof(emailMessageto), required: true);
            WorkflowExpression.Validate(emailMessagesubject, nameof(emailMessagesubject), required: true);
            WorkflowExpression.Validate(emailMessagebody, nameof(emailMessagebody), required: true);
            WorkflowExpression.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            WorkflowExpression.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            WorkflowExpression.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            WorkflowExpression.Validate(emailMessagesensitivity, nameof(emailMessagesensitivity), required: false);
            WorkflowExpression.Validate(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            WorkflowExpression.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/SharedMailbox/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["MailboxAddress"] = ExpressionConverter.ConvertO(emailMessageoriginalMailboxAddress);
                emailMessagepropCount++;
                emailMessage["To"] = ExpressionConverter.ConvertO(emailMessageto);
                emailMessagepropCount++;
                emailMessage["Subject"] = ExpressionConverter.ConvertO(emailMessagesubject);
                emailMessagepropCount++;
                emailMessage["Body"] = ExpressionConverter.ConvertO(emailMessagebody);
                if (emailMessagecC != null)
                {
                    emailMessage["Cc"] = ExpressionConverter.ConvertO(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = ExpressionConverter.ConvertO(emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = ExpressionConverter.ConvertO(emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagesensitivity != null)
                {
                    emailMessage["Sensitivity"] = ExpressionConverter.ConvertO(emailMessagesensitivity);
                    emailMessagepropCount++;
                }

                if (emailMessagereplyTo != null)
                {
                    emailMessage["ReplyTo"] = ExpressionConverter.ConvertO(emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    if (emailMessageimportance != null)
                    {
                        emailMessage["Importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
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
            });
        }
    }

    public class Office365Triggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnCalendarChangedItems))]
        public IBodyWorkflowTrigger<GraphCalendarEventListWithActionType> OnCalendarChangedItems([WorkflowExpression] Func<string> table,[WorkflowExpression] Func<int> incomingDays = null,[WorkflowExpression] Func<int> pastDays = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GraphCalendarEventListWithActionType> __BuildOnCalendarChangedItems(WorkflowExpression<string> table,WorkflowExpression<int> incomingDays = null,WorkflowExpression<int> pastDays = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(incomingDays, nameof(incomingDays), required: false);
            WorkflowExpression.Validate(pastDays, nameof(pastDays), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListWithActionType>(() =>
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
                    input.Fetch.Queries["incomingDays"] = ExpressionConverter.Convert(incomingDays);
                input.Fetch.Queries["pastDays"] = Convert.ToString(50);
                if (pastDays != null)
                    input.Fetch.Queries["pastDays"] = ExpressionConverter.Convert(pastDays);
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
                    input.Subscribe.Queries["incomingDays"] = ExpressionConverter.Convert(incomingDays);
                input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
                if (pastDays != null)
                    input.Subscribe.Queries["pastDays"] = ExpressionConverter.Convert(pastDays);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<GraphCalendarEventListWithActionType>(input);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnCalendarNewItems))]
        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarNewItems([WorkflowExpression] Func<string> table,[WorkflowExpression] Func<string> orderby = null,[WorkflowExpression] Func<int> top = null,[WorkflowExpression] Func<int> skip = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> __BuildOnCalendarNewItems(WorkflowExpression<string> table,WorkflowExpression<string> orderby = null,WorkflowExpression<int> top = null,WorkflowExpression<int> skip = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnCalendarUpdatedItems))]
        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarUpdatedItems([WorkflowExpression] Func<string> table,[WorkflowExpression] Func<string> orderby = null,[WorkflowExpression] Func<int> top = null,[WorkflowExpression] Func<int> skip = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> __BuildOnCalendarUpdatedItems(WorkflowExpression<string> table,WorkflowExpression<string> orderby = null,WorkflowExpression<int> top = null,WorkflowExpression<int> skip = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnFlaggedEmail))]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnFlaggedEmail([WorkflowExpression] Func<string> folderPath = null,[WorkflowExpression] Func<string> to = null,[WorkflowExpression] Func<string> cc = null,[WorkflowExpression] Func<string> toOrCc = null,[WorkflowExpression] Func<string> from = null,[WorkflowExpression] Func<importanceInput> importance = null,[WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null,[WorkflowExpression] Func<bool> includeAttachments = null,[WorkflowExpression] Func<string> subjectFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> __BuildOnFlaggedEmail(WorkflowExpression<string> folderPath = null,WorkflowExpression<string> to = null,WorkflowExpression<string> cc = null,WorkflowExpression<string> toOrCc = null,WorkflowExpression<string> from = null,WorkflowExpression<importanceInput> importance = null,WorkflowExpression<bool> fetchOnlyWithAttachment = null,WorkflowExpression<bool> includeAttachments = null,WorkflowExpression<string> subjectFilter = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(cc, nameof(cc), required: false);
            WorkflowExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(importance, nameof(importance), required: false);
            WorkflowExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage>(() =>
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
                    input.Fetch.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = ExpressionConverter.Convert(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = ExpressionConverter.Convert(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = ExpressionConverter.Convert(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = ExpressionConverter.Convert(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = ExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = ExpressionConverter.Convert(subjectFilter);
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
                    input.Subscribe.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = ExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewEmail))]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmail([WorkflowExpression] Func<string> folderPath = null,[WorkflowExpression] Func<string> to = null,[WorkflowExpression] Func<string> cc = null,[WorkflowExpression] Func<string> toOrCc = null,[WorkflowExpression] Func<string> from = null,[WorkflowExpression] Func<importanceInput> importance = null,[WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null,[WorkflowExpression] Func<bool> includeAttachments = null,[WorkflowExpression] Func<string> subjectFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> __BuildOnNewEmail(WorkflowExpression<string> folderPath = null,WorkflowExpression<string> to = null,WorkflowExpression<string> cc = null,WorkflowExpression<string> toOrCc = null,WorkflowExpression<string> from = null,WorkflowExpression<importanceInput> importance = null,WorkflowExpression<bool> fetchOnlyWithAttachment = null,WorkflowExpression<bool> includeAttachments = null,WorkflowExpression<string> subjectFilter = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(cc, nameof(cc), required: false);
            WorkflowExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(importance, nameof(importance), required: false);
            WorkflowExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage>(() =>
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
                    input.Fetch.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = ExpressionConverter.Convert(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = ExpressionConverter.Convert(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = ExpressionConverter.Convert(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = ExpressionConverter.Convert(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = ExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = ExpressionConverter.Convert(subjectFilter);
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
                    input.Subscribe.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = ExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewEmailMentioningMe))]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmailMentioningMe([WorkflowExpression] Func<string> folderPath = null,[WorkflowExpression] Func<string> to = null,[WorkflowExpression] Func<string> cc = null,[WorkflowExpression] Func<string> toOrCc = null,[WorkflowExpression] Func<string> from = null,[WorkflowExpression] Func<importanceInput> importance = null,[WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null,[WorkflowExpression] Func<bool> includeAttachments = null,[WorkflowExpression] Func<string> subjectFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> __BuildOnNewEmailMentioningMe(WorkflowExpression<string> folderPath = null,WorkflowExpression<string> to = null,WorkflowExpression<string> cc = null,WorkflowExpression<string> toOrCc = null,WorkflowExpression<string> from = null,WorkflowExpression<importanceInput> importance = null,WorkflowExpression<bool> fetchOnlyWithAttachment = null,WorkflowExpression<bool> includeAttachments = null,WorkflowExpression<string> subjectFilter = null)
        {
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(cc, nameof(cc), required: false);
            WorkflowExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(importance, nameof(importance), required: false);
            WorkflowExpression.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage>(() =>
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
                    input.Fetch.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = ExpressionConverter.Convert(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = ExpressionConverter.Convert(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = ExpressionConverter.Convert(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = ExpressionConverter.Convert(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = ExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = ExpressionConverter.Convert(subjectFilter);
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
                    input.Subscribe.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = ExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpcomingEvents))]
        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnUpcomingEvents([WorkflowExpression] Func<string> table,[WorkflowExpression] Func<int> lookAheadTimeInMinutes = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> __BuildOnUpcomingEvents(WorkflowExpression<string> table,WorkflowExpression<int> lookAheadTimeInMinutes = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(table, nameof(table), required: true);
            WorkflowExpression.Validate(lookAheadTimeInMinutes, nameof(lookAheadTimeInMinutes), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = "/v3/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = ExpressionConverter.Convert(table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(lookAheadTimeInMinutes);
                return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnSharedMailboxNewEmail))]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnSharedMailboxNewEmail([WorkflowExpression] Func<string> mailboxAddress,[WorkflowExpression] Func<string> folderId = null,[WorkflowExpression] Func<string> to = null,[WorkflowExpression] Func<string> cc = null,[WorkflowExpression] Func<string> toOrCc = null,[WorkflowExpression] Func<string> from = null,[WorkflowExpression] Func<importanceInput> importance = null,[WorkflowExpression] Func<bool> hasAttachments = null,[WorkflowExpression] Func<bool> includeAttachments = null,[WorkflowExpression] Func<string> subjectFilter = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> __BuildOnSharedMailboxNewEmail(WorkflowExpression<string> mailboxAddress,WorkflowExpression<string> folderId = null,WorkflowExpression<string> to = null,WorkflowExpression<string> cc = null,WorkflowExpression<string> toOrCc = null,WorkflowExpression<string> from = null,WorkflowExpression<importanceInput> importance = null,WorkflowExpression<bool> hasAttachments = null,WorkflowExpression<bool> includeAttachments = null,WorkflowExpression<string> subjectFilter = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(mailboxAddress, nameof(mailboxAddress), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(cc, nameof(cc), required: false);
            WorkflowExpression.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(importance, nameof(importance), required: false);
            WorkflowExpression.Validate(hasAttachments, nameof(hasAttachments), required: false);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowExpression.Validate(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage>(() =>
            {
                var apiCallPath = "/v2/SharedMailbox/Mail/OnNewEmail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
                callPayload.Queries["folderId"] = Convert.ToString("Inbox");
                if (folderId != null)
                    callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                if (cc != null)
                    callPayload.Queries["cc"] = ExpressionConverter.Convert(cc);
                if (toOrCc != null)
                    callPayload.Queries["toOrCc"] = ExpressionConverter.Convert(toOrCc);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                callPayload.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    callPayload.Queries["importance"] = ExpressionConverter.Convert(importance);
                callPayload.Queries["hasAttachments"] = Convert.ToString(false);
                if (hasAttachments != null)
                    callPayload.Queries["hasAttachments"] = ExpressionConverter.Convert(hasAttachments);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (subjectFilter != null)
                    callPayload.Queries["subjectFilter"] = ExpressionConverter.Convert(subjectFilter);
                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemBodyContentTypeType
    {
        Text,
        HTML
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum optionsEmailSubscriptionmessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum approvalEmailSubscriptionmessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GraphCalendarEventClientReceiveImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum itemimportanceInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactivityDomainInput
    {
        Work,
        Personal,
        Unrestricted,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum replyParametersimportanceInput
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum responseInput
    {
        [EnumMember(Value = "accept")]
        Accept,
        [EnumMember(Value = "tentativelyAccept")]
        TentativelyAccept,
        [EnumMember(Value = "decline")]
        Decline
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AutomaticRepliesSettingClientV2StatusType
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyautomaticRepliesSettingstatusInput
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GraphCalendarEventClientWithActionTypeActionTypeType
    {
        [EnumMember(Value = "added")]
        Added,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "deleted")]
        Deleted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GraphCalendarEventClientWithActionTypeImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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