//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
            var __workflow_draftMessageto = WorkflowExpression.Compile(draftMessageto, nameof(draftMessageto), required: true);
            var __workflow_draftMessagesubject = WorkflowExpression.Compile(draftMessagesubject, nameof(draftMessagesubject), required: true);
            var __workflow_draftMessagebody = WorkflowExpression.Compile(draftMessagebody, nameof(draftMessagebody), required: true);
            var __workflow_draftMessagefromSendAs = WorkflowExpression.Compile(draftMessagefromSendAs, nameof(draftMessagefromSendAs), required: false);
            var __workflow_draftMessagecC = WorkflowExpression.Compile(draftMessagecC, nameof(draftMessagecC), required: false);
            var __workflow_draftMessagebCC = WorkflowExpression.Compile(draftMessagebCC, nameof(draftMessagebCC), required: false);
            var __workflow_draftMessageattachments = WorkflowExpression.Compile(draftMessageattachments, nameof(draftMessageattachments), required: false);
            var __workflow_draftMessagesensitivity = WorkflowExpression.Compile(draftMessagesensitivity, nameof(draftMessagesensitivity), required: false);
            var __workflow_draftMessagereplyTo = WorkflowExpression.Compile(draftMessagereplyTo, nameof(draftMessagereplyTo), required: false);
            var __workflow_draftMessageimportance = WorkflowExpression.Compile(draftMessageimportance, nameof(draftMessageimportance), required: false);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: false);
            var __workflow_draftType = WorkflowExpression.Compile(draftType, nameof(draftType), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<OutlookReceiveMessage>(() =>
            {
                var apiCallPath = "/Draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_messageId != null)
                    callPayload.Queries["messageId"] = ExpressionConverter.Convert(__workflow_messageId);
                if (__workflow_draftType != null)
                    callPayload.Queries["draftType"] = ExpressionConverter.Convert(__workflow_draftType);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                var draftMessage = new JObject();
                var draftMessagepropCount = 0;
                draftMessagepropCount++;
                draftMessage["To"] = ExpressionConverter.ConvertO(__workflow_draftMessageto);
                draftMessagepropCount++;
                draftMessage["Subject"] = ExpressionConverter.ConvertO(__workflow_draftMessagesubject);
                draftMessagepropCount++;
                draftMessage["Body"] = ExpressionConverter.ConvertO(__workflow_draftMessagebody);
                if (__workflow_draftMessagefromSendAs != null)
                {
                    draftMessage["From"] = ExpressionConverter.ConvertO(__workflow_draftMessagefromSendAs);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagecC != null)
                {
                    draftMessage["Cc"] = ExpressionConverter.ConvertO(__workflow_draftMessagecC);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagebCC != null)
                {
                    draftMessage["Bcc"] = ExpressionConverter.ConvertO(__workflow_draftMessagebCC);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessageattachments != null)
                {
                    draftMessage["Attachments"] = ExpressionConverter.ConvertO(__workflow_draftMessageattachments);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagesensitivity != null)
                {
                    draftMessage["Sensitivity"] = ExpressionConverter.ConvertO(__workflow_draftMessagesensitivity);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagereplyTo != null)
                {
                    draftMessage["ReplyTo"] = ExpressionConverter.ConvertO(__workflow_draftMessagereplyTo);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessageimportance != null)
                {
                    if (__workflow_draftMessageimportance != null)
                    {
                        draftMessage["Importance"] = ExpressionConverter.ConvertO(__workflow_draftMessageimportance);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateDraftEmail(Expression<Func<string>> draftMessageto, Expression<Func<string>> draftMessagesubject, Expression<Func<string>> draftMessagebody, Expression<Func<string>> messageId, Expression<Func<string>> draftMessagefromSendAs = null, Expression<Func<string>> draftMessagecC = null, Expression<Func<string>> draftMessagebCC = null, Expression<Func<ClientSendAttachment[]>> draftMessageattachments = null, Expression<Func<string>> draftMessagesensitivity = null, Expression<Func<string>> draftMessagereplyTo = null, Expression<Func<draftMessageimportanceInput>> draftMessageimportance = null)
        {
            var __workflow_draftMessageto = WorkflowExpression.Compile(draftMessageto, nameof(draftMessageto), required: true);
            var __workflow_draftMessagesubject = WorkflowExpression.Compile(draftMessagesubject, nameof(draftMessagesubject), required: true);
            var __workflow_draftMessagebody = WorkflowExpression.Compile(draftMessagebody, nameof(draftMessagebody), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_draftMessagefromSendAs = WorkflowExpression.Compile(draftMessagefromSendAs, nameof(draftMessagefromSendAs), required: false);
            var __workflow_draftMessagecC = WorkflowExpression.Compile(draftMessagecC, nameof(draftMessagecC), required: false);
            var __workflow_draftMessagebCC = WorkflowExpression.Compile(draftMessagebCC, nameof(draftMessagebCC), required: false);
            var __workflow_draftMessageattachments = WorkflowExpression.Compile(draftMessageattachments, nameof(draftMessageattachments), required: false);
            var __workflow_draftMessagesensitivity = WorkflowExpression.Compile(draftMessagesensitivity, nameof(draftMessagesensitivity), required: false);
            var __workflow_draftMessagereplyTo = WorkflowExpression.Compile(draftMessagereplyTo, nameof(draftMessagereplyTo), required: false);
            var __workflow_draftMessageimportance = WorkflowExpression.Compile(draftMessageimportance, nameof(draftMessageimportance), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Draft";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = ExpressionConverter.Convert(__workflow_messageId);
                var draftMessage = new JObject();
                var draftMessagepropCount = 0;
                draftMessagepropCount++;
                draftMessage["To"] = ExpressionConverter.ConvertO(__workflow_draftMessageto);
                draftMessagepropCount++;
                draftMessage["Subject"] = ExpressionConverter.ConvertO(__workflow_draftMessagesubject);
                draftMessagepropCount++;
                draftMessage["Body"] = ExpressionConverter.ConvertO(__workflow_draftMessagebody);
                if (__workflow_draftMessagefromSendAs != null)
                {
                    draftMessage["From"] = ExpressionConverter.ConvertO(__workflow_draftMessagefromSendAs);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagecC != null)
                {
                    draftMessage["Cc"] = ExpressionConverter.ConvertO(__workflow_draftMessagecC);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagebCC != null)
                {
                    draftMessage["Bcc"] = ExpressionConverter.ConvertO(__workflow_draftMessagebCC);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessageattachments != null)
                {
                    draftMessage["Attachments"] = ExpressionConverter.ConvertO(__workflow_draftMessageattachments);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagesensitivity != null)
                {
                    draftMessage["Sensitivity"] = ExpressionConverter.ConvertO(__workflow_draftMessagesensitivity);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessagereplyTo != null)
                {
                    draftMessage["ReplyTo"] = ExpressionConverter.ConvertO(__workflow_draftMessagereplyTo);
                    draftMessagepropCount++;
                }

                if (__workflow_draftMessageimportance != null)
                {
                    if (__workflow_draftMessageimportance != null)
                    {
                        draftMessage["Importance"] = ExpressionConverter.ConvertO(__workflow_draftMessageimportance);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendDraftEmail(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Draft/Send/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction AssignCategory(Expression<Func<string>> messageId, Expression<Func<string>> category)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Mail/Category";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = ExpressionConverter.Convert(__workflow_messageId);
                callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchOperationResult> AssignCategoryBulk(Expression<Func<string>> categoryName, Expression<Func<string[]>> messageIds = null)
        {
            var __workflow_categoryName = WorkflowExpression.Compile(categoryName, nameof(categoryName), required: true);
            var __workflow_messageIds = WorkflowExpression.Compile(messageIds, nameof(messageIds), required: false);
            return new DeferredBodyAction<BatchOperationResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/Category/Bulk/{0}", __workflow_categoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_messageIds);
                return new ApiConnectionAction<BatchOperationResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<string>> optionsEmailSubscriptionmessageto, Expression<Func<string>> optionsEmailSubscriptionmessagesubject = null, Expression<Func<string>> optionsEmailSubscriptionmessageuserOptions = null, Expression<Func<string>> optionsEmailSubscriptionmessageheaderText = null, Expression<Func<string>> optionsEmailSubscriptionmessageselectionText = null, Expression<Func<string>> optionsEmailSubscriptionmessagebody = null, Expression<Func<optionsEmailSubscriptionmessageimportanceInput>> optionsEmailSubscriptionmessageimportance = null, Expression<Func<ClientSendAttachment[]>> optionsEmailSubscriptionmessageattachments = null, Expression<Func<bool>> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessagehideHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null, Expression<Func<bool>> optionsEmailSubscriptionmessagehideMicrosoftFooter = null)
        {
            var __workflow_optionsEmailSubscriptionmessageto = WorkflowExpression.Compile(optionsEmailSubscriptionmessageto, nameof(optionsEmailSubscriptionmessageto), required: true);
            var __workflow_optionsEmailSubscriptionmessagesubject = WorkflowExpression.Compile(optionsEmailSubscriptionmessagesubject, nameof(optionsEmailSubscriptionmessagesubject), required: false);
            var __workflow_optionsEmailSubscriptionmessageuserOptions = WorkflowExpression.Compile(optionsEmailSubscriptionmessageuserOptions, nameof(optionsEmailSubscriptionmessageuserOptions), required: false);
            var __workflow_optionsEmailSubscriptionmessageheaderText = WorkflowExpression.Compile(optionsEmailSubscriptionmessageheaderText, nameof(optionsEmailSubscriptionmessageheaderText), required: false);
            var __workflow_optionsEmailSubscriptionmessageselectionText = WorkflowExpression.Compile(optionsEmailSubscriptionmessageselectionText, nameof(optionsEmailSubscriptionmessageselectionText), required: false);
            var __workflow_optionsEmailSubscriptionmessagebody = WorkflowExpression.Compile(optionsEmailSubscriptionmessagebody, nameof(optionsEmailSubscriptionmessagebody), required: false);
            var __workflow_optionsEmailSubscriptionmessageimportance = WorkflowExpression.Compile(optionsEmailSubscriptionmessageimportance, nameof(optionsEmailSubscriptionmessageimportance), required: false);
            var __workflow_optionsEmailSubscriptionmessageattachments = WorkflowExpression.Compile(optionsEmailSubscriptionmessageattachments, nameof(optionsEmailSubscriptionmessageattachments), required: false);
            var __workflow_optionsEmailSubscriptionmessageuseOnlyHTMLMessage = WorkflowExpression.Compile(optionsEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(optionsEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            var __workflow_optionsEmailSubscriptionmessagehideHTMLMessage = WorkflowExpression.Compile(optionsEmailSubscriptionmessagehideHTMLMessage, nameof(optionsEmailSubscriptionmessagehideHTMLMessage), required: false);
            var __workflow_optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = WorkflowExpression.Compile(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
            var __workflow_optionsEmailSubscriptionmessagehideMicrosoftFooter = WorkflowExpression.Compile(optionsEmailSubscriptionmessagehideMicrosoftFooter, nameof(optionsEmailSubscriptionmessagehideMicrosoftFooter), required: false);
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
                messageObject["To"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageto);
                if (__workflow_optionsEmailSubscriptionmessagesubject != null)
                {
                    if (__workflow_optionsEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessagesubject);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Subject"] = "Your input is required";
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessageuserOptions != null)
                {
                    if (__workflow_optionsEmailSubscriptionmessageuserOptions != null)
                    {
                        messageObject["Options"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageuserOptions);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Options"] = "Choice1, Choice2, Choice3";
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessageheaderText != null)
                {
                    messageObject["HeaderText"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessageimportance != null)
                {
                    if (__workflow_optionsEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageimportance);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Importance"] = "Normal";
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessageattachments != null)
                {
                    messageObject["Attachments"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (__workflow_optionsEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessagehideHTMLMessage);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["HideHTMLMessage"] = false;
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                {
                    if (__workflow_optionsEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                    {
                        messageObject["ShowHTMLConfirmationDialog"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessageshowHTMLConfirmationDialog);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["ShowHTMLConfirmationDialog"] = false;
                    messageObjectpropCount++;
                }

                if (__workflow_optionsEmailSubscriptionmessagehideMicrosoftFooter != null)
                {
                    if (__workflow_optionsEmailSubscriptionmessagehideMicrosoftFooter != null)
                    {
                        messageObject["HideMicrosoftFooter"] = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscriptionmessagehideMicrosoftFooter);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail(Expression<Func<string>> approvalEmailSubscriptionmessageto, Expression<Func<string>> approvalEmailSubscriptionmessagesubject = null, Expression<Func<string>> approvalEmailSubscriptionmessageuserOptions = null, Expression<Func<string>> approvalEmailSubscriptionmessageheaderText = null, Expression<Func<string>> approvalEmailSubscriptionmessageselectionText = null, Expression<Func<string>> approvalEmailSubscriptionmessagebody = null, Expression<Func<approvalEmailSubscriptionmessageimportanceInput>> approvalEmailSubscriptionmessageimportance = null, Expression<Func<ClientSendAttachment[]>> approvalEmailSubscriptionmessageattachments = null, Expression<Func<bool>> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionmessagehideHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            var __workflow_approvalEmailSubscriptionmessageto = WorkflowExpression.Compile(approvalEmailSubscriptionmessageto, nameof(approvalEmailSubscriptionmessageto), required: true);
            var __workflow_approvalEmailSubscriptionmessagesubject = WorkflowExpression.Compile(approvalEmailSubscriptionmessagesubject, nameof(approvalEmailSubscriptionmessagesubject), required: false);
            var __workflow_approvalEmailSubscriptionmessageuserOptions = WorkflowExpression.Compile(approvalEmailSubscriptionmessageuserOptions, nameof(approvalEmailSubscriptionmessageuserOptions), required: false);
            var __workflow_approvalEmailSubscriptionmessageheaderText = WorkflowExpression.Compile(approvalEmailSubscriptionmessageheaderText, nameof(approvalEmailSubscriptionmessageheaderText), required: false);
            var __workflow_approvalEmailSubscriptionmessageselectionText = WorkflowExpression.Compile(approvalEmailSubscriptionmessageselectionText, nameof(approvalEmailSubscriptionmessageselectionText), required: false);
            var __workflow_approvalEmailSubscriptionmessagebody = WorkflowExpression.Compile(approvalEmailSubscriptionmessagebody, nameof(approvalEmailSubscriptionmessagebody), required: false);
            var __workflow_approvalEmailSubscriptionmessageimportance = WorkflowExpression.Compile(approvalEmailSubscriptionmessageimportance, nameof(approvalEmailSubscriptionmessageimportance), required: false);
            var __workflow_approvalEmailSubscriptionmessageattachments = WorkflowExpression.Compile(approvalEmailSubscriptionmessageattachments, nameof(approvalEmailSubscriptionmessageattachments), required: false);
            var __workflow_approvalEmailSubscriptionmessageuseOnlyHTMLMessage = WorkflowExpression.Compile(approvalEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(approvalEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            var __workflow_approvalEmailSubscriptionmessagehideHTMLMessage = WorkflowExpression.Compile(approvalEmailSubscriptionmessagehideHTMLMessage, nameof(approvalEmailSubscriptionmessagehideHTMLMessage), required: false);
            var __workflow_approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = WorkflowExpression.Compile(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
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
                messageObject["To"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageto);
                if (__workflow_approvalEmailSubscriptionmessagesubject != null)
                {
                    if (__workflow_approvalEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessagesubject);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Subject"] = "Approval Request";
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessageuserOptions != null)
                {
                    if (__workflow_approvalEmailSubscriptionmessageuserOptions != null)
                    {
                        messageObject["Options"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageuserOptions);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Options"] = "Approve, Reject";
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessageheaderText != null)
                {
                    messageObject["HeaderText"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessageimportance != null)
                {
                    if (__workflow_approvalEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageimportance);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Importance"] = "Normal";
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessageattachments != null)
                {
                    messageObject["Attachments"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (__workflow_approvalEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessagehideHTMLMessage);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["HideHTMLMessage"] = false;
                    messageObjectpropCount++;
                }

                if (__workflow_approvalEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                {
                    if (__workflow_approvalEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                    {
                        messageObject["ShowHTMLConfirmationDialog"] = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscriptionmessageshowHTMLConfirmationDialog);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateMyContactPhoto(Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}/photo/$value", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("image/jpeg");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_customHeader1 = WorkflowExpression.Compile(customHeader1, nameof(customHeader1), required: false);
            var __workflow_customHeader2 = WorkflowExpression.Compile(customHeader2, nameof(customHeader2), required: false);
            var __workflow_customHeader3 = WorkflowExpression.Compile(customHeader3, nameof(customHeader3), required: false);
            var __workflow_customHeader4 = WorkflowExpression.Compile(customHeader4, nameof(customHeader4), required: false);
            var __workflow_customHeader5 = WorkflowExpression.Compile(customHeader5, nameof(customHeader5), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/codeless/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(__workflow_uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_customHeader1 != null)
                    callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(__workflow_customHeader1);
                if (__workflow_customHeader2 != null)
                    callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(__workflow_customHeader2);
                if (__workflow_customHeader3 != null)
                    callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(__workflow_customHeader3);
                if (__workflow_customHeader4 != null)
                    callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(__workflow_customHeader4);
                if (__workflow_customHeader5 != null)
                    callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(__workflow_customHeader5);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpEmailsManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/EmailsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpMeetingManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/MeetingManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpContactsManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse>(() =>
            {
                var apiCallPath = "/mcp/ContactsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction CalendarDeleteItem(Expression<Func<string>> calendar, Expression<Func<string>> @event)
        {
            var __workflow_calendar = WorkflowExpression.Compile(calendar, nameof(calendar), required: true);
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/calendars/{0}/events/{1}", __workflow_calendar.WithUrlEncoding(2), __workflow_event.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventListClientReceive> CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v4/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<GraphCalendarEventListClientReceive>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_itemsubject = WorkflowExpression.Compile(itemsubject, nameof(itemsubject), required: true);
            var __workflow_itemstartTime = WorkflowExpression.Compile(itemstartTime, nameof(itemstartTime), required: true);
            var __workflow_itemendTime = WorkflowExpression.Compile(itemendTime, nameof(itemendTime), required: true);
            var __workflow_itemtimeZone = WorkflowExpression.Compile(itemtimeZone, nameof(itemtimeZone), required: true);
            var __workflow_itemrequiredAttendees = WorkflowExpression.Compile(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            var __workflow_itemoptionalAttendees = WorkflowExpression.Compile(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            var __workflow_itemresourceAttendees = WorkflowExpression.Compile(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            var __workflow_itembody = WorkflowExpression.Compile(itembody, nameof(itembody), required: false);
            var __workflow_itemcategories = WorkflowExpression.Compile(itemcategories, nameof(itemcategories), required: false);
            var __workflow_itemlocation = WorkflowExpression.Compile(itemlocation, nameof(itemlocation), required: false);
            var __workflow_itemimportance = WorkflowExpression.Compile(itemimportance, nameof(itemimportance), required: false);
            var __workflow_itemisAllDayEvent = WorkflowExpression.Compile(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            var __workflow_itemrecurrence = WorkflowExpression.Compile(itemrecurrence, nameof(itemrecurrence), required: false);
            var __workflow_itemselectedDaysOfWeek = WorkflowExpression.Compile(itemselectedDaysOfWeek, nameof(itemselectedDaysOfWeek), required: false);
            var __workflow_itemrecurrenceEndDate = WorkflowExpression.Compile(itemrecurrenceEndDate, nameof(itemrecurrenceEndDate), required: false);
            var __workflow_itemnumberOfOccurrences = WorkflowExpression.Compile(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            var __workflow_itemreminder = WorkflowExpression.Compile(itemreminder, nameof(itemreminder), required: false);
            var __workflow_itemisReminderOn = WorkflowExpression.Compile(itemisReminderOn, nameof(itemisReminderOn), required: false);
            var __workflow_itemshowAs = WorkflowExpression.Compile(itemshowAs, nameof(itemshowAs), required: false);
            var __workflow_itemresponseRequested = WorkflowExpression.Compile(itemresponseRequested, nameof(itemresponseRequested), required: false);
            var __workflow_itemsensitivity = WorkflowExpression.Compile(itemsensitivity, nameof(itemsensitivity), required: false);
            return new DeferredBodyAction<GraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v4/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = ExpressionConverter.ConvertO(__workflow_itemsubject);
                itempropCount++;
                item["start"] = ExpressionConverter.ConvertO(__workflow_itemstartTime);
                itempropCount++;
                item["end"] = ExpressionConverter.ConvertO(__workflow_itemendTime);
                itempropCount++;
                item["timeZone"] = ExpressionConverter.ConvertO(__workflow_itemtimeZone);
                if (__workflow_itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = ExpressionConverter.ConvertO(__workflow_itemrequiredAttendees);
                    itempropCount++;
                }

                if (__workflow_itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = ExpressionConverter.ConvertO(__workflow_itemoptionalAttendees);
                    itempropCount++;
                }

                if (__workflow_itemresourceAttendees != null)
                {
                    item["resourceAttendees"] = ExpressionConverter.ConvertO(__workflow_itemresourceAttendees);
                    itempropCount++;
                }

                if (__workflow_itembody != null)
                {
                    item["body"] = ExpressionConverter.ConvertO(__workflow_itembody);
                    itempropCount++;
                }

                if (__workflow_itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(__workflow_itemcategories);
                    itempropCount++;
                }

                if (__workflow_itemlocation != null)
                {
                    item["location"] = ExpressionConverter.ConvertO(__workflow_itemlocation);
                    itempropCount++;
                }

                if (__workflow_itemimportance != null)
                {
                    item["importance"] = ExpressionConverter.ConvertO(__workflow_itemimportance);
                    itempropCount++;
                }

                if (__workflow_itemisAllDayEvent != null)
                {
                    item["isAllDay"] = ExpressionConverter.ConvertO(__workflow_itemisAllDayEvent);
                    itempropCount++;
                }

                if (__workflow_itemrecurrence != null)
                {
                    item["recurrence"] = ExpressionConverter.ConvertO(__workflow_itemrecurrence);
                    itempropCount++;
                }

                if (__workflow_itemselectedDaysOfWeek != null)
                {
                    item["selectedDaysOfWeek"] = ExpressionConverter.ConvertO(__workflow_itemselectedDaysOfWeek);
                    itempropCount++;
                }

                if (__workflow_itemrecurrenceEndDate != null)
                {
                    item["recurrenceEnd"] = ExpressionConverter.ConvertO(__workflow_itemrecurrenceEndDate);
                    itempropCount++;
                }

                if (__workflow_itemnumberOfOccurrences != null)
                {
                    item["numberOfOccurences"] = ExpressionConverter.ConvertO(__workflow_itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (__workflow_itemreminder != null)
                {
                    item["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(__workflow_itemreminder);
                    itempropCount++;
                }

                if (__workflow_itemisReminderOn != null)
                {
                    item["isReminderOn"] = ExpressionConverter.ConvertO(__workflow_itemisReminderOn);
                    itempropCount++;
                }

                if (__workflow_itemshowAs != null)
                {
                    item["showAs"] = ExpressionConverter.ConvertO(__workflow_itemshowAs);
                    itempropCount++;
                }

                if (__workflow_itemresponseRequested != null)
                {
                    item["responseRequested"] = ExpressionConverter.ConvertO(__workflow_itemresponseRequested);
                    itempropCount++;
                }

                if (__workflow_itemsensitivity != null)
                {
                    item["sensitivity"] = ExpressionConverter.ConvertO(__workflow_itemsensitivity);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> CalendarPostItem(Expression<Func<string>> table, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<itemselectedDaysOfWeekInputItem[]>> itemselectedDaysOfWeek = null, Expression<Func<string>> itemrecurrenceEndDate = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<bool>> itemisReminderOn = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null, Expression<Func<itemsensitivityInput>> itemsensitivity = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_itemsubject = WorkflowExpression.Compile(itemsubject, nameof(itemsubject), required: true);
            var __workflow_itemstartTime = WorkflowExpression.Compile(itemstartTime, nameof(itemstartTime), required: true);
            var __workflow_itemendTime = WorkflowExpression.Compile(itemendTime, nameof(itemendTime), required: true);
            var __workflow_itemtimeZone = WorkflowExpression.Compile(itemtimeZone, nameof(itemtimeZone), required: true);
            var __workflow_itemrequiredAttendees = WorkflowExpression.Compile(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            var __workflow_itemoptionalAttendees = WorkflowExpression.Compile(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            var __workflow_itemresourceAttendees = WorkflowExpression.Compile(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            var __workflow_itembody = WorkflowExpression.Compile(itembody, nameof(itembody), required: false);
            var __workflow_itemcategories = WorkflowExpression.Compile(itemcategories, nameof(itemcategories), required: false);
            var __workflow_itemlocation = WorkflowExpression.Compile(itemlocation, nameof(itemlocation), required: false);
            var __workflow_itemimportance = WorkflowExpression.Compile(itemimportance, nameof(itemimportance), required: false);
            var __workflow_itemisAllDayEvent = WorkflowExpression.Compile(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            var __workflow_itemrecurrence = WorkflowExpression.Compile(itemrecurrence, nameof(itemrecurrence), required: false);
            var __workflow_itemselectedDaysOfWeek = WorkflowExpression.Compile(itemselectedDaysOfWeek, nameof(itemselectedDaysOfWeek), required: false);
            var __workflow_itemrecurrenceEndDate = WorkflowExpression.Compile(itemrecurrenceEndDate, nameof(itemrecurrenceEndDate), required: false);
            var __workflow_itemnumberOfOccurrences = WorkflowExpression.Compile(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            var __workflow_itemreminder = WorkflowExpression.Compile(itemreminder, nameof(itemreminder), required: false);
            var __workflow_itemisReminderOn = WorkflowExpression.Compile(itemisReminderOn, nameof(itemisReminderOn), required: false);
            var __workflow_itemshowAs = WorkflowExpression.Compile(itemshowAs, nameof(itemshowAs), required: false);
            var __workflow_itemresponseRequested = WorkflowExpression.Compile(itemresponseRequested, nameof(itemresponseRequested), required: false);
            var __workflow_itemsensitivity = WorkflowExpression.Compile(itemsensitivity, nameof(itemsensitivity), required: false);
            return new DeferredBodyAction<GraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v4/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["subject"] = ExpressionConverter.ConvertO(__workflow_itemsubject);
                itempropCount++;
                item["start"] = ExpressionConverter.ConvertO(__workflow_itemstartTime);
                itempropCount++;
                item["end"] = ExpressionConverter.ConvertO(__workflow_itemendTime);
                itempropCount++;
                item["timeZone"] = ExpressionConverter.ConvertO(__workflow_itemtimeZone);
                if (__workflow_itemrequiredAttendees != null)
                {
                    item["requiredAttendees"] = ExpressionConverter.ConvertO(__workflow_itemrequiredAttendees);
                    itempropCount++;
                }

                if (__workflow_itemoptionalAttendees != null)
                {
                    item["optionalAttendees"] = ExpressionConverter.ConvertO(__workflow_itemoptionalAttendees);
                    itempropCount++;
                }

                if (__workflow_itemresourceAttendees != null)
                {
                    item["resourceAttendees"] = ExpressionConverter.ConvertO(__workflow_itemresourceAttendees);
                    itempropCount++;
                }

                if (__workflow_itembody != null)
                {
                    item["body"] = ExpressionConverter.ConvertO(__workflow_itembody);
                    itempropCount++;
                }

                if (__workflow_itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(__workflow_itemcategories);
                    itempropCount++;
                }

                if (__workflow_itemlocation != null)
                {
                    item["location"] = ExpressionConverter.ConvertO(__workflow_itemlocation);
                    itempropCount++;
                }

                if (__workflow_itemimportance != null)
                {
                    item["importance"] = ExpressionConverter.ConvertO(__workflow_itemimportance);
                    itempropCount++;
                }

                if (__workflow_itemisAllDayEvent != null)
                {
                    item["isAllDay"] = ExpressionConverter.ConvertO(__workflow_itemisAllDayEvent);
                    itempropCount++;
                }

                if (__workflow_itemrecurrence != null)
                {
                    item["recurrence"] = ExpressionConverter.ConvertO(__workflow_itemrecurrence);
                    itempropCount++;
                }

                if (__workflow_itemselectedDaysOfWeek != null)
                {
                    item["selectedDaysOfWeek"] = ExpressionConverter.ConvertO(__workflow_itemselectedDaysOfWeek);
                    itempropCount++;
                }

                if (__workflow_itemrecurrenceEndDate != null)
                {
                    item["recurrenceEnd"] = ExpressionConverter.ConvertO(__workflow_itemrecurrenceEndDate);
                    itempropCount++;
                }

                if (__workflow_itemnumberOfOccurrences != null)
                {
                    item["numberOfOccurences"] = ExpressionConverter.ConvertO(__workflow_itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (__workflow_itemreminder != null)
                {
                    item["reminderMinutesBeforeStart"] = ExpressionConverter.ConvertO(__workflow_itemreminder);
                    itempropCount++;
                }

                if (__workflow_itemisReminderOn != null)
                {
                    item["isReminderOn"] = ExpressionConverter.ConvertO(__workflow_itemisReminderOn);
                    itempropCount++;
                }

                if (__workflow_itemshowAs != null)
                {
                    item["showAs"] = ExpressionConverter.ConvertO(__workflow_itemshowAs);
                    itempropCount++;
                }

                if (__workflow_itemresponseRequested != null)
                {
                    item["responseRequested"] = ExpressionConverter.ConvertO(__workflow_itemresponseRequested);
                    itempropCount++;
                }

                if (__workflow_itemsensitivity != null)
                {
                    item["sensitivity"] = ExpressionConverter.ConvertO(__workflow_itemsensitivity);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ContactDeleteItem(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactGetItem(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseContactResponseV2> ContactGetItems(Expression<Func<string>> folder, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EntityListResponseContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", __workflow_folder.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<EntityListResponseContactResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_itemgivenName = WorkflowExpression.Compile(itemgivenName, nameof(itemgivenName), required: true);
            var __workflow_itemhomePhones = WorkflowExpression.Compile(itemhomePhones, nameof(itemhomePhones), required: true);
            var __workflow_itemid = WorkflowExpression.Compile(itemid, nameof(itemid), required: false);
            var __workflow_itemparentFolderId = WorkflowExpression.Compile(itemparentFolderId, nameof(itemparentFolderId), required: false);
            var __workflow_itembirthday = WorkflowExpression.Compile(itembirthday, nameof(itembirthday), required: false);
            var __workflow_itemfileAs = WorkflowExpression.Compile(itemfileAs, nameof(itemfileAs), required: false);
            var __workflow_itemdisplayName = WorkflowExpression.Compile(itemdisplayName, nameof(itemdisplayName), required: false);
            var __workflow_iteminitials = WorkflowExpression.Compile(iteminitials, nameof(iteminitials), required: false);
            var __workflow_itemmiddleName = WorkflowExpression.Compile(itemmiddleName, nameof(itemmiddleName), required: false);
            var __workflow_itemnickname = WorkflowExpression.Compile(itemnickname, nameof(itemnickname), required: false);
            var __workflow_itemsurname = WorkflowExpression.Compile(itemsurname, nameof(itemsurname), required: false);
            var __workflow_itemtitle = WorkflowExpression.Compile(itemtitle, nameof(itemtitle), required: false);
            var __workflow_itemgeneration = WorkflowExpression.Compile(itemgeneration, nameof(itemgeneration), required: false);
            var __workflow_itememailAddresses = WorkflowExpression.Compile(itememailAddresses, nameof(itememailAddresses), required: false);
            var __workflow_itemiMAddresses = WorkflowExpression.Compile(itemiMAddresses, nameof(itemiMAddresses), required: false);
            var __workflow_itemjobTitle = WorkflowExpression.Compile(itemjobTitle, nameof(itemjobTitle), required: false);
            var __workflow_itemcompanyName = WorkflowExpression.Compile(itemcompanyName, nameof(itemcompanyName), required: false);
            var __workflow_itemdepartment = WorkflowExpression.Compile(itemdepartment, nameof(itemdepartment), required: false);
            var __workflow_itemofficeLocation = WorkflowExpression.Compile(itemofficeLocation, nameof(itemofficeLocation), required: false);
            var __workflow_itemprofession = WorkflowExpression.Compile(itemprofession, nameof(itemprofession), required: false);
            var __workflow_itembusinessHomePage = WorkflowExpression.Compile(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            var __workflow_itemassistantName = WorkflowExpression.Compile(itemassistantName, nameof(itemassistantName), required: false);
            var __workflow_itemmanager = WorkflowExpression.Compile(itemmanager, nameof(itemmanager), required: false);
            var __workflow_itembusinessPhones = WorkflowExpression.Compile(itembusinessPhones, nameof(itembusinessPhones), required: false);
            var __workflow_itemmobilePhone = WorkflowExpression.Compile(itemmobilePhone, nameof(itemmobilePhone), required: false);
            var __workflow_itemhomeAddressstreet = WorkflowExpression.Compile(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            var __workflow_itemhomeAddresscity = WorkflowExpression.Compile(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            var __workflow_itemhomeAddressstate = WorkflowExpression.Compile(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            var __workflow_itemhomeAddresscountryOrRegion = WorkflowExpression.Compile(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            var __workflow_itemhomeAddresspostalCode = WorkflowExpression.Compile(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            var __workflow_itembusinessAddressstreet = WorkflowExpression.Compile(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            var __workflow_itembusinessAddresscity = WorkflowExpression.Compile(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            var __workflow_itembusinessAddressstate = WorkflowExpression.Compile(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            var __workflow_itembusinessAddresscountryOrRegion = WorkflowExpression.Compile(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            var __workflow_itembusinessAddresspostalCode = WorkflowExpression.Compile(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            var __workflow_itemotherAddressstreet = WorkflowExpression.Compile(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            var __workflow_itemotherAddresscity = WorkflowExpression.Compile(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            var __workflow_itemotherAddressstate = WorkflowExpression.Compile(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            var __workflow_itemotherAddresscountryOrRegion = WorkflowExpression.Compile(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            var __workflow_itemotherAddresspostalCode = WorkflowExpression.Compile(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            var __workflow_itemyomiCompanyName = WorkflowExpression.Compile(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            var __workflow_itemyomiGivenName = WorkflowExpression.Compile(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            var __workflow_itemyomiSurname = WorkflowExpression.Compile(itemyomiSurname, nameof(itemyomiSurname), required: false);
            var __workflow_itemcategories = WorkflowExpression.Compile(itemcategories, nameof(itemcategories), required: false);
            var __workflow_itemchangeKey = WorkflowExpression.Compile(itemchangeKey, nameof(itemchangeKey), required: false);
            var __workflow_itemcreatedTime = WorkflowExpression.Compile(itemcreatedTime, nameof(itemcreatedTime), required: false);
            var __workflow_itemlastModifiedTime = WorkflowExpression.Compile(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            return new DeferredBodyAction<ContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (__workflow_itemid != null)
                {
                    item["id"] = ExpressionConverter.ConvertO(__workflow_itemid);
                    itempropCount++;
                }

                if (__workflow_itemparentFolderId != null)
                {
                    item["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_itemparentFolderId);
                    itempropCount++;
                }

                if (__workflow_itembirthday != null)
                {
                    item["birthday"] = ExpressionConverter.ConvertO(__workflow_itembirthday);
                    itempropCount++;
                }

                if (__workflow_itemfileAs != null)
                {
                    item["fileAs"] = ExpressionConverter.ConvertO(__workflow_itemfileAs);
                    itempropCount++;
                }

                if (__workflow_itemdisplayName != null)
                {
                    item["displayName"] = ExpressionConverter.ConvertO(__workflow_itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["givenName"] = ExpressionConverter.ConvertO(__workflow_itemgivenName);
                if (__workflow_iteminitials != null)
                {
                    item["initials"] = ExpressionConverter.ConvertO(__workflow_iteminitials);
                    itempropCount++;
                }

                if (__workflow_itemmiddleName != null)
                {
                    item["middleName"] = ExpressionConverter.ConvertO(__workflow_itemmiddleName);
                    itempropCount++;
                }

                if (__workflow_itemnickname != null)
                {
                    item["nickName"] = ExpressionConverter.ConvertO(__workflow_itemnickname);
                    itempropCount++;
                }

                if (__workflow_itemsurname != null)
                {
                    item["surname"] = ExpressionConverter.ConvertO(__workflow_itemsurname);
                    itempropCount++;
                }

                if (__workflow_itemtitle != null)
                {
                    item["title"] = ExpressionConverter.ConvertO(__workflow_itemtitle);
                    itempropCount++;
                }

                if (__workflow_itemgeneration != null)
                {
                    item["generation"] = ExpressionConverter.ConvertO(__workflow_itemgeneration);
                    itempropCount++;
                }

                if (__workflow_itememailAddresses != null)
                {
                    item["emailAddresses"] = ExpressionConverter.ConvertO(__workflow_itememailAddresses);
                    itempropCount++;
                }

                if (__workflow_itemiMAddresses != null)
                {
                    item["imAddresses"] = ExpressionConverter.ConvertO(__workflow_itemiMAddresses);
                    itempropCount++;
                }

                if (__workflow_itemjobTitle != null)
                {
                    item["jobTitle"] = ExpressionConverter.ConvertO(__workflow_itemjobTitle);
                    itempropCount++;
                }

                if (__workflow_itemcompanyName != null)
                {
                    item["companyName"] = ExpressionConverter.ConvertO(__workflow_itemcompanyName);
                    itempropCount++;
                }

                if (__workflow_itemdepartment != null)
                {
                    item["department"] = ExpressionConverter.ConvertO(__workflow_itemdepartment);
                    itempropCount++;
                }

                if (__workflow_itemofficeLocation != null)
                {
                    item["officeLocation"] = ExpressionConverter.ConvertO(__workflow_itemofficeLocation);
                    itempropCount++;
                }

                if (__workflow_itemprofession != null)
                {
                    item["profession"] = ExpressionConverter.ConvertO(__workflow_itemprofession);
                    itempropCount++;
                }

                if (__workflow_itembusinessHomePage != null)
                {
                    item["businessHomePage"] = ExpressionConverter.ConvertO(__workflow_itembusinessHomePage);
                    itempropCount++;
                }

                if (__workflow_itemassistantName != null)
                {
                    item["assistantName"] = ExpressionConverter.ConvertO(__workflow_itemassistantName);
                    itempropCount++;
                }

                if (__workflow_itemmanager != null)
                {
                    item["manager"] = ExpressionConverter.ConvertO(__workflow_itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["homePhones"] = ExpressionConverter.ConvertO(__workflow_itemhomePhones);
                if (__workflow_itembusinessPhones != null)
                {
                    item["businessPhones"] = ExpressionConverter.ConvertO(__workflow_itembusinessPhones);
                    itempropCount++;
                }

                if (__workflow_itemmobilePhone != null)
                {
                    item["mobilePhone"] = ExpressionConverter.ConvertO(__workflow_itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    homeAddressObject["street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    homeAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    homeAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["homeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    businessAddressObject["street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    businessAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    businessAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["businessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    otherAddressObject["street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    otherAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    otherAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["otherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (__workflow_itemyomiCompanyName != null)
                {
                    item["yomiCompanyName"] = ExpressionConverter.ConvertO(__workflow_itemyomiCompanyName);
                    itempropCount++;
                }

                if (__workflow_itemyomiGivenName != null)
                {
                    item["yomiGivenName"] = ExpressionConverter.ConvertO(__workflow_itemyomiGivenName);
                    itempropCount++;
                }

                if (__workflow_itemyomiSurname != null)
                {
                    item["yomiSurname"] = ExpressionConverter.ConvertO(__workflow_itemyomiSurname);
                    itempropCount++;
                }

                if (__workflow_itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(__workflow_itemcategories);
                    itempropCount++;
                }

                if (__workflow_itemchangeKey != null)
                {
                    item["changeKey"] = ExpressionConverter.ConvertO(__workflow_itemchangeKey);
                    itempropCount++;
                }

                if (__workflow_itemcreatedTime != null)
                {
                    item["createdDateTime"] = ExpressionConverter.ConvertO(__workflow_itemcreatedTime);
                    itempropCount++;
                }

                if (__workflow_itemlastModifiedTime != null)
                {
                    item["lastModifiedDateTime"] = ExpressionConverter.ConvertO(__workflow_itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactPostItem(Expression<Func<string>> folder, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddressV2[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_itemgivenName = WorkflowExpression.Compile(itemgivenName, nameof(itemgivenName), required: true);
            var __workflow_itemhomePhones = WorkflowExpression.Compile(itemhomePhones, nameof(itemhomePhones), required: true);
            var __workflow_itemid = WorkflowExpression.Compile(itemid, nameof(itemid), required: false);
            var __workflow_itemparentFolderId = WorkflowExpression.Compile(itemparentFolderId, nameof(itemparentFolderId), required: false);
            var __workflow_itembirthday = WorkflowExpression.Compile(itembirthday, nameof(itembirthday), required: false);
            var __workflow_itemfileAs = WorkflowExpression.Compile(itemfileAs, nameof(itemfileAs), required: false);
            var __workflow_itemdisplayName = WorkflowExpression.Compile(itemdisplayName, nameof(itemdisplayName), required: false);
            var __workflow_iteminitials = WorkflowExpression.Compile(iteminitials, nameof(iteminitials), required: false);
            var __workflow_itemmiddleName = WorkflowExpression.Compile(itemmiddleName, nameof(itemmiddleName), required: false);
            var __workflow_itemnickname = WorkflowExpression.Compile(itemnickname, nameof(itemnickname), required: false);
            var __workflow_itemsurname = WorkflowExpression.Compile(itemsurname, nameof(itemsurname), required: false);
            var __workflow_itemtitle = WorkflowExpression.Compile(itemtitle, nameof(itemtitle), required: false);
            var __workflow_itemgeneration = WorkflowExpression.Compile(itemgeneration, nameof(itemgeneration), required: false);
            var __workflow_itememailAddresses = WorkflowExpression.Compile(itememailAddresses, nameof(itememailAddresses), required: false);
            var __workflow_itemiMAddresses = WorkflowExpression.Compile(itemiMAddresses, nameof(itemiMAddresses), required: false);
            var __workflow_itemjobTitle = WorkflowExpression.Compile(itemjobTitle, nameof(itemjobTitle), required: false);
            var __workflow_itemcompanyName = WorkflowExpression.Compile(itemcompanyName, nameof(itemcompanyName), required: false);
            var __workflow_itemdepartment = WorkflowExpression.Compile(itemdepartment, nameof(itemdepartment), required: false);
            var __workflow_itemofficeLocation = WorkflowExpression.Compile(itemofficeLocation, nameof(itemofficeLocation), required: false);
            var __workflow_itemprofession = WorkflowExpression.Compile(itemprofession, nameof(itemprofession), required: false);
            var __workflow_itembusinessHomePage = WorkflowExpression.Compile(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            var __workflow_itemassistantName = WorkflowExpression.Compile(itemassistantName, nameof(itemassistantName), required: false);
            var __workflow_itemmanager = WorkflowExpression.Compile(itemmanager, nameof(itemmanager), required: false);
            var __workflow_itembusinessPhones = WorkflowExpression.Compile(itembusinessPhones, nameof(itembusinessPhones), required: false);
            var __workflow_itemmobilePhone = WorkflowExpression.Compile(itemmobilePhone, nameof(itemmobilePhone), required: false);
            var __workflow_itemhomeAddressstreet = WorkflowExpression.Compile(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            var __workflow_itemhomeAddresscity = WorkflowExpression.Compile(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            var __workflow_itemhomeAddressstate = WorkflowExpression.Compile(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            var __workflow_itemhomeAddresscountryOrRegion = WorkflowExpression.Compile(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            var __workflow_itemhomeAddresspostalCode = WorkflowExpression.Compile(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            var __workflow_itembusinessAddressstreet = WorkflowExpression.Compile(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            var __workflow_itembusinessAddresscity = WorkflowExpression.Compile(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            var __workflow_itembusinessAddressstate = WorkflowExpression.Compile(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            var __workflow_itembusinessAddresscountryOrRegion = WorkflowExpression.Compile(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            var __workflow_itembusinessAddresspostalCode = WorkflowExpression.Compile(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            var __workflow_itemotherAddressstreet = WorkflowExpression.Compile(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            var __workflow_itemotherAddresscity = WorkflowExpression.Compile(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            var __workflow_itemotherAddressstate = WorkflowExpression.Compile(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            var __workflow_itemotherAddresscountryOrRegion = WorkflowExpression.Compile(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            var __workflow_itemotherAddresspostalCode = WorkflowExpression.Compile(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            var __workflow_itemyomiCompanyName = WorkflowExpression.Compile(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            var __workflow_itemyomiGivenName = WorkflowExpression.Compile(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            var __workflow_itemyomiSurname = WorkflowExpression.Compile(itemyomiSurname, nameof(itemyomiSurname), required: false);
            var __workflow_itemcategories = WorkflowExpression.Compile(itemcategories, nameof(itemcategories), required: false);
            var __workflow_itemchangeKey = WorkflowExpression.Compile(itemchangeKey, nameof(itemchangeKey), required: false);
            var __workflow_itemcreatedTime = WorkflowExpression.Compile(itemcreatedTime, nameof(itemcreatedTime), required: false);
            var __workflow_itemlastModifiedTime = WorkflowExpression.Compile(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            return new DeferredBodyAction<ContactResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", __workflow_folder.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (__workflow_itemid != null)
                {
                    item["id"] = ExpressionConverter.ConvertO(__workflow_itemid);
                    itempropCount++;
                }

                if (__workflow_itemparentFolderId != null)
                {
                    item["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_itemparentFolderId);
                    itempropCount++;
                }

                if (__workflow_itembirthday != null)
                {
                    item["birthday"] = ExpressionConverter.ConvertO(__workflow_itembirthday);
                    itempropCount++;
                }

                if (__workflow_itemfileAs != null)
                {
                    item["fileAs"] = ExpressionConverter.ConvertO(__workflow_itemfileAs);
                    itempropCount++;
                }

                if (__workflow_itemdisplayName != null)
                {
                    item["displayName"] = ExpressionConverter.ConvertO(__workflow_itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["givenName"] = ExpressionConverter.ConvertO(__workflow_itemgivenName);
                if (__workflow_iteminitials != null)
                {
                    item["initials"] = ExpressionConverter.ConvertO(__workflow_iteminitials);
                    itempropCount++;
                }

                if (__workflow_itemmiddleName != null)
                {
                    item["middleName"] = ExpressionConverter.ConvertO(__workflow_itemmiddleName);
                    itempropCount++;
                }

                if (__workflow_itemnickname != null)
                {
                    item["nickName"] = ExpressionConverter.ConvertO(__workflow_itemnickname);
                    itempropCount++;
                }

                if (__workflow_itemsurname != null)
                {
                    item["surname"] = ExpressionConverter.ConvertO(__workflow_itemsurname);
                    itempropCount++;
                }

                if (__workflow_itemtitle != null)
                {
                    item["title"] = ExpressionConverter.ConvertO(__workflow_itemtitle);
                    itempropCount++;
                }

                if (__workflow_itemgeneration != null)
                {
                    item["generation"] = ExpressionConverter.ConvertO(__workflow_itemgeneration);
                    itempropCount++;
                }

                if (__workflow_itememailAddresses != null)
                {
                    item["emailAddresses"] = ExpressionConverter.ConvertO(__workflow_itememailAddresses);
                    itempropCount++;
                }

                if (__workflow_itemiMAddresses != null)
                {
                    item["imAddresses"] = ExpressionConverter.ConvertO(__workflow_itemiMAddresses);
                    itempropCount++;
                }

                if (__workflow_itemjobTitle != null)
                {
                    item["jobTitle"] = ExpressionConverter.ConvertO(__workflow_itemjobTitle);
                    itempropCount++;
                }

                if (__workflow_itemcompanyName != null)
                {
                    item["companyName"] = ExpressionConverter.ConvertO(__workflow_itemcompanyName);
                    itempropCount++;
                }

                if (__workflow_itemdepartment != null)
                {
                    item["department"] = ExpressionConverter.ConvertO(__workflow_itemdepartment);
                    itempropCount++;
                }

                if (__workflow_itemofficeLocation != null)
                {
                    item["officeLocation"] = ExpressionConverter.ConvertO(__workflow_itemofficeLocation);
                    itempropCount++;
                }

                if (__workflow_itemprofession != null)
                {
                    item["profession"] = ExpressionConverter.ConvertO(__workflow_itemprofession);
                    itempropCount++;
                }

                if (__workflow_itembusinessHomePage != null)
                {
                    item["businessHomePage"] = ExpressionConverter.ConvertO(__workflow_itembusinessHomePage);
                    itempropCount++;
                }

                if (__workflow_itemassistantName != null)
                {
                    item["assistantName"] = ExpressionConverter.ConvertO(__workflow_itemassistantName);
                    itempropCount++;
                }

                if (__workflow_itemmanager != null)
                {
                    item["manager"] = ExpressionConverter.ConvertO(__workflow_itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["homePhones"] = ExpressionConverter.ConvertO(__workflow_itemhomePhones);
                if (__workflow_itembusinessPhones != null)
                {
                    item["businessPhones"] = ExpressionConverter.ConvertO(__workflow_itembusinessPhones);
                    itempropCount++;
                }

                if (__workflow_itemmobilePhone != null)
                {
                    item["mobilePhone"] = ExpressionConverter.ConvertO(__workflow_itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    homeAddressObject["street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    homeAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    homeAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["homeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    businessAddressObject["street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    businessAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    businessAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["businessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    otherAddressObject["street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    otherAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    otherAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["countryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["otherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (__workflow_itemyomiCompanyName != null)
                {
                    item["yomiCompanyName"] = ExpressionConverter.ConvertO(__workflow_itemyomiCompanyName);
                    itempropCount++;
                }

                if (__workflow_itemyomiGivenName != null)
                {
                    item["yomiGivenName"] = ExpressionConverter.ConvertO(__workflow_itemyomiGivenName);
                    itempropCount++;
                }

                if (__workflow_itemyomiSurname != null)
                {
                    item["yomiSurname"] = ExpressionConverter.ConvertO(__workflow_itemyomiSurname);
                    itempropCount++;
                }

                if (__workflow_itemcategories != null)
                {
                    item["categories"] = ExpressionConverter.ConvertO(__workflow_itemcategories);
                    itempropCount++;
                }

                if (__workflow_itemchangeKey != null)
                {
                    item["changeKey"] = ExpressionConverter.ConvertO(__workflow_itemchangeKey);
                    itempropCount++;
                }

                if (__workflow_itemcreatedTime != null)
                {
                    item["createdDateTime"] = ExpressionConverter.ConvertO(__workflow_itemcreatedTime);
                    itempropCount++;
                }

                if (__workflow_itemlastModifiedTime != null)
                {
                    item["lastModifiedDateTime"] = ExpressionConverter.ConvertO(__workflow_itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/messages/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<string> ExportEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/beta/me/messages/{0}/$value", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<FindMeetingTimesV2Response> FindMeetingTimes(Expression<Func<string>> bodyrequiredAttendees = null, Expression<Func<string>> bodyoptionalAttendees = null, Expression<Func<string>> bodyresourceAttendees = null, Expression<Func<int>> bodymeetingDuration = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<int>> bodymaxCandidates = null, Expression<Func<string>> bodyminimumAttendeePercentage = null, Expression<Func<bool>> bodyisOrganizerOptional = null, Expression<Func<bodyactivityDomainInput>> bodyactivityDomain = null)
        {
            var __workflow_bodyrequiredAttendees = WorkflowExpression.Compile(bodyrequiredAttendees, nameof(bodyrequiredAttendees), required: false);
            var __workflow_bodyoptionalAttendees = WorkflowExpression.Compile(bodyoptionalAttendees, nameof(bodyoptionalAttendees), required: false);
            var __workflow_bodyresourceAttendees = WorkflowExpression.Compile(bodyresourceAttendees, nameof(bodyresourceAttendees), required: false);
            var __workflow_bodymeetingDuration = WorkflowExpression.Compile(bodymeetingDuration, nameof(bodymeetingDuration), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodymaxCandidates = WorkflowExpression.Compile(bodymaxCandidates, nameof(bodymaxCandidates), required: false);
            var __workflow_bodyminimumAttendeePercentage = WorkflowExpression.Compile(bodyminimumAttendeePercentage, nameof(bodyminimumAttendeePercentage), required: false);
            var __workflow_bodyisOrganizerOptional = WorkflowExpression.Compile(bodyisOrganizerOptional, nameof(bodyisOrganizerOptional), required: false);
            var __workflow_bodyactivityDomain = WorkflowExpression.Compile(bodyactivityDomain, nameof(bodyactivityDomain), required: false);
            return new DeferredBodyAction<FindMeetingTimesV2Response>(() =>
            {
                var apiCallPath = "/codeless/beta/me/findMeetingTimes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequiredAttendees != null)
                {
                    body["RequiredAttendees"] = ExpressionConverter.ConvertO(__workflow_bodyrequiredAttendees);
                    bodypropCount++;
                }

                if (__workflow_bodyoptionalAttendees != null)
                {
                    body["OptionalAttendees"] = ExpressionConverter.ConvertO(__workflow_bodyoptionalAttendees);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceAttendees != null)
                {
                    body["ResourceAttendees"] = ExpressionConverter.ConvertO(__workflow_bodyresourceAttendees);
                    bodypropCount++;
                }

                if (__workflow_bodymeetingDuration != null)
                {
                    body["MeetingDuration"] = ExpressionConverter.ConvertO(__workflow_bodymeetingDuration);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["Start"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["End"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodymaxCandidates != null)
                {
                    body["MaxCandidates"] = ExpressionConverter.ConvertO(__workflow_bodymaxCandidates);
                    bodypropCount++;
                }

                if (__workflow_bodyminimumAttendeePercentage != null)
                {
                    body["MinimumAttendeePercentage"] = ExpressionConverter.ConvertO(__workflow_bodyminimumAttendeePercentage);
                    bodypropCount++;
                }

                if (__workflow_bodyisOrganizerOptional != null)
                {
                    body["IsOrganizerOptional"] = ExpressionConverter.ConvertO(__workflow_bodyisOrganizerOptional);
                    bodypropCount++;
                }

                if (__workflow_bodyactivityDomain != null)
                {
                    if (__workflow_bodyactivityDomain != null)
                    {
                        body["ActivityDomain"] = ExpressionConverter.ConvertO(__workflow_bodyactivityDomain);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction Flag(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bodyflagflagStatusInput>> bodyflagflagStatus = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_bodyflagflagStatus = WorkflowExpression.Compile(bodyflagflagStatus, nameof(bodyflagflagStatus), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/messages/{0}/flag", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                var flagObject = new JObject();
                var flagObjectpropCount = 0;
                if (__workflow_bodyflagflagStatus != null)
                {
                    if (__workflow_bodyflagflagStatus != null)
                    {
                        flagObject["flagStatus"] = ExpressionConverter.ConvertO(__workflow_bodyflagflagStatus);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ForwardEmail(Expression<Func<string>> messageId, Expression<Func<string>> bodyto, Expression<Func<string>> mailboxAddress = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/messages/{0}/forward", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToRecipients"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetAttachmentV2Response> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetAttachmentV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/messages/{0}/attachments/{1}", __workflow_messageId.WithUrlEncoding(1), __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetAttachmentV2Response>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> GetEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_internetMessageId = WorkflowExpression.Compile(internetMessageId, nameof(internetMessageId), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GraphClientReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/Mail/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_internetMessageId != null)
                    callPayload.Queries["internetMessageId"] = ExpressionConverter.Convert(__workflow_internetMessageId);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchResponseGraphClientReceiveMessage> GetEmails(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_cc = WorkflowExpression.Compile(cc, nameof(cc), required: false);
            var __workflow_toOrCc = WorkflowExpression.Compile(toOrCc, nameof(toOrCc), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_importance = WorkflowExpression.Compile(importance, nameof(importance), required: false);
            var __workflow_fetchOnlyWithAttachment = WorkflowExpression.Compile(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            var __workflow_subjectFilter = WorkflowExpression.Compile(subjectFilter, nameof(subjectFilter), required: false);
            var __workflow_fetchOnlyUnread = WorkflowExpression.Compile(fetchOnlyUnread, nameof(fetchOnlyUnread), required: false);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_searchQuery = WorkflowExpression.Compile(searchQuery, nameof(searchQuery), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<BatchResponseGraphClientReceiveMessage>(() =>
            {
                var apiCallPath = "/v3/Mail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = Convert.ToString("Inbox");
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_cc != null)
                    callPayload.Queries["cc"] = ExpressionConverter.Convert(__workflow_cc);
                if (__workflow_toOrCc != null)
                    callPayload.Queries["toOrCc"] = ExpressionConverter.Convert(__workflow_toOrCc);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                callPayload.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    callPayload.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                callPayload.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachment != null)
                    callPayload.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachment);
                if (__workflow_subjectFilter != null)
                    callPayload.Queries["subjectFilter"] = ExpressionConverter.Convert(__workflow_subjectFilter);
                callPayload.Queries["fetchOnlyUnread"] = Convert.ToString(true);
                if (__workflow_fetchOnlyUnread != null)
                    callPayload.Queries["fetchOnlyUnread"] = ExpressionConverter.Convert(__workflow_fetchOnlyUnread);
                callPayload.Queries["fetchOnlyFlagged"] = Convert.ToString(false);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_searchQuery != null)
                    callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(__workflow_searchQuery);
                callPayload.Queries["top"] = Convert.ToString(10);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<BatchResponseGraphClientReceiveMessage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> GetEventsCalendarView(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeUtc, Expression<Func<string>> endDateTimeUtc, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_startDateTimeUtc = WorkflowExpression.Compile(startDateTimeUtc, nameof(startDateTimeUtc), required: true);
            var __workflow_endDateTimeUtc = WorkflowExpression.Compile(endDateTimeUtc, nameof(endDateTimeUtc), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<EntityListResponseGraphCalendarEventClientReceive>(() =>
            {
                var apiCallPath = "/datasets/calendars/v3/tables/items/calendarview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["calendarId"] = ExpressionConverter.Convert(__workflow_calendarId);
                callPayload.Queries["startDateTimeUtc"] = ExpressionConverter.Convert(__workflow_startDateTimeUtc);
                callPayload.Queries["endDateTimeUtc"] = ExpressionConverter.Convert(__workflow_endDateTimeUtc);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<EntityListResponseGraphCalendarEventClientReceive>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetMailTipsV2Response> GetMailTips(Expression<Func<string[]>> bodyemailAddresses)
        {
            var __workflow_bodyemailAddresses = WorkflowExpression.Compile(bodyemailAddresses, nameof(bodyemailAddresses), required: true);
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
                body["EmailAddresses"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddresses);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetMailTipsV2Response>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
            var __workflow_roomList = WorkflowExpression.Compile(roomList, nameof(roomList), required: true);
            return new DeferredBodyAction<GetRoomsInRoomListV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/beta/me/findRooms(RoomList='{0}')", __workflow_roomList.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRoomsInRoomListV2Response>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction MarkAsRead(Expression<Func<string>> messageId, Expression<Func<bool>> bodymarkAs, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_bodymarkAs = WorkflowExpression.Compile(bodymarkAs, nameof(bodymarkAs), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v3/v1.0/me/messages/{0}/markAsRead", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isRead"] = ExpressionConverter.ConvertO(__workflow_bodymarkAs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredBodyAction<GraphClientReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/Mail/Move/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ReplyTo(Expression<Func<string>> messageId, Expression<Func<string>> replyParametersto = null, Expression<Func<string>> replyParameterscC = null, Expression<Func<string>> replyParametersbCC = null, Expression<Func<string>> replyParameterssubject = null, Expression<Func<string>> replyParametersbody = null, Expression<Func<bool>> replyParametersreplyAll = null, Expression<Func<replyParametersimportanceInput>> replyParametersimportance = null, Expression<Func<ClientSendAttachment[]>> replyParametersattachments = null, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_replyParametersto = WorkflowExpression.Compile(replyParametersto, nameof(replyParametersto), required: false);
            var __workflow_replyParameterscC = WorkflowExpression.Compile(replyParameterscC, nameof(replyParameterscC), required: false);
            var __workflow_replyParametersbCC = WorkflowExpression.Compile(replyParametersbCC, nameof(replyParametersbCC), required: false);
            var __workflow_replyParameterssubject = WorkflowExpression.Compile(replyParameterssubject, nameof(replyParameterssubject), required: false);
            var __workflow_replyParametersbody = WorkflowExpression.Compile(replyParametersbody, nameof(replyParametersbody), required: false);
            var __workflow_replyParametersreplyAll = WorkflowExpression.Compile(replyParametersreplyAll, nameof(replyParametersreplyAll), required: false);
            var __workflow_replyParametersimportance = WorkflowExpression.Compile(replyParametersimportance, nameof(replyParametersimportance), required: false);
            var __workflow_replyParametersattachments = WorkflowExpression.Compile(replyParametersattachments, nameof(replyParametersattachments), required: false);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/Mail/ReplyTo/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                var replyParameters = new JObject();
                var replyParameterspropCount = 0;
                if (__workflow_replyParametersto != null)
                {
                    replyParameters["To"] = ExpressionConverter.ConvertO(__workflow_replyParametersto);
                    replyParameterspropCount++;
                }

                if (__workflow_replyParameterscC != null)
                {
                    replyParameters["Cc"] = ExpressionConverter.ConvertO(__workflow_replyParameterscC);
                    replyParameterspropCount++;
                }

                if (__workflow_replyParametersbCC != null)
                {
                    replyParameters["Bcc"] = ExpressionConverter.ConvertO(__workflow_replyParametersbCC);
                    replyParameterspropCount++;
                }

                if (__workflow_replyParameterssubject != null)
                {
                    replyParameters["Subject"] = ExpressionConverter.ConvertO(__workflow_replyParameterssubject);
                    replyParameterspropCount++;
                }

                if (__workflow_replyParametersbody != null)
                {
                    replyParameters["Body"] = ExpressionConverter.ConvertO(__workflow_replyParametersbody);
                    replyParameterspropCount++;
                }

                if (__workflow_replyParametersreplyAll != null)
                {
                    replyParameters["ReplyAll"] = ExpressionConverter.ConvertO(__workflow_replyParametersreplyAll);
                    replyParameterspropCount++;
                }

                if (__workflow_replyParametersimportance != null)
                {
                    replyParameters["Importance"] = ExpressionConverter.ConvertO(__workflow_replyParametersimportance);
                    replyParameterspropCount++;
                }

                if (__workflow_replyParametersattachments != null)
                {
                    replyParameters["Attachments"] = ExpressionConverter.ConvertO(__workflow_replyParametersattachments);
                    replyParameterspropCount++;
                }

                if (replyParameterspropCount > 0)
                {
                    callPayload.Body = replyParameters;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction RespondToEvent(Expression<Func<string>> eventId, Expression<Func<responseInput>> response, Expression<Func<string>> bodycomment = null, Expression<Func<bool>> bodysendResponse = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_response = WorkflowExpression.Compile(response, nameof(response), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodysendResponse = WorkflowExpression.Compile(bodysendResponse, nameof(bodysendResponse), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/events/{0}/{1}", __workflow_eventId.WithUrlEncoding(1), __workflow_response.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodysendResponse != null)
                {
                    if (__workflow_bodysendResponse != null)
                    {
                        body["SendResponse"] = ExpressionConverter.ConvertO(__workflow_bodysendResponse);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendEmail(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagefromSendAs = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagesensitivity = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
        {
            var __workflow_emailMessageto = WorkflowExpression.Compile(emailMessageto, nameof(emailMessageto), required: true);
            var __workflow_emailMessagesubject = WorkflowExpression.Compile(emailMessagesubject, nameof(emailMessagesubject), required: true);
            var __workflow_emailMessagebody = WorkflowExpression.Compile(emailMessagebody, nameof(emailMessagebody), required: true);
            var __workflow_emailMessagefromSendAs = WorkflowExpression.Compile(emailMessagefromSendAs, nameof(emailMessagefromSendAs), required: false);
            var __workflow_emailMessagecC = WorkflowExpression.Compile(emailMessagecC, nameof(emailMessagecC), required: false);
            var __workflow_emailMessagebCC = WorkflowExpression.Compile(emailMessagebCC, nameof(emailMessagebCC), required: false);
            var __workflow_emailMessageattachments = WorkflowExpression.Compile(emailMessageattachments, nameof(emailMessageattachments), required: false);
            var __workflow_emailMessagesensitivity = WorkflowExpression.Compile(emailMessagesensitivity, nameof(emailMessagesensitivity), required: false);
            var __workflow_emailMessagereplyTo = WorkflowExpression.Compile(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            var __workflow_emailMessageimportance = WorkflowExpression.Compile(emailMessageimportance, nameof(emailMessageimportance), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["To"] = ExpressionConverter.ConvertO(__workflow_emailMessageto);
                emailMessagepropCount++;
                emailMessage["Subject"] = ExpressionConverter.ConvertO(__workflow_emailMessagesubject);
                emailMessagepropCount++;
                emailMessage["Body"] = ExpressionConverter.ConvertO(__workflow_emailMessagebody);
                if (__workflow_emailMessagefromSendAs != null)
                {
                    emailMessage["From"] = ExpressionConverter.ConvertO(__workflow_emailMessagefromSendAs);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagecC != null)
                {
                    emailMessage["Cc"] = ExpressionConverter.ConvertO(__workflow_emailMessagecC);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = ExpressionConverter.ConvertO(__workflow_emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = ExpressionConverter.ConvertO(__workflow_emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagesensitivity != null)
                {
                    emailMessage["Sensitivity"] = ExpressionConverter.ConvertO(__workflow_emailMessagesensitivity);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagereplyTo != null)
                {
                    emailMessage["ReplyTo"] = ExpressionConverter.ConvertO(__workflow_emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageimportance != null)
                {
                    if (__workflow_emailMessageimportance != null)
                    {
                        emailMessage["Importance"] = ExpressionConverter.ConvertO(__workflow_emailMessageimportance);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SetAutomaticRepliesSettingV2Response> SetAutomaticRepliesSetting(Expression<Func<bodyautomaticRepliesSettingstatusInput>> bodyautomaticRepliesSettingstatus, Expression<Func<bodyautomaticRepliesSettingexternalAudienceInput>> bodyautomaticRepliesSettingexternalAudience, Expression<Func<string>> bodyautomaticRepliesSettingstartTimedateTime = null, Expression<Func<string>> bodyautomaticRepliesSettingstartTimetimeZone = null, Expression<Func<string>> bodyautomaticRepliesSettingendTimedateTime = null, Expression<Func<string>> bodyautomaticRepliesSettingendTimetimeZone = null, Expression<Func<string>> bodyautomaticRepliesSettinginternalReplyMessage = null, Expression<Func<string>> bodyautomaticRepliesSettingexternalReplyMessage = null)
        {
            var __workflow_bodyautomaticRepliesSettingstatus = WorkflowExpression.Compile(bodyautomaticRepliesSettingstatus, nameof(bodyautomaticRepliesSettingstatus), required: true);
            var __workflow_bodyautomaticRepliesSettingexternalAudience = WorkflowExpression.Compile(bodyautomaticRepliesSettingexternalAudience, nameof(bodyautomaticRepliesSettingexternalAudience), required: true);
            var __workflow_bodyautomaticRepliesSettingstartTimedateTime = WorkflowExpression.Compile(bodyautomaticRepliesSettingstartTimedateTime, nameof(bodyautomaticRepliesSettingstartTimedateTime), required: false);
            var __workflow_bodyautomaticRepliesSettingstartTimetimeZone = WorkflowExpression.Compile(bodyautomaticRepliesSettingstartTimetimeZone, nameof(bodyautomaticRepliesSettingstartTimetimeZone), required: false);
            var __workflow_bodyautomaticRepliesSettingendTimedateTime = WorkflowExpression.Compile(bodyautomaticRepliesSettingendTimedateTime, nameof(bodyautomaticRepliesSettingendTimedateTime), required: false);
            var __workflow_bodyautomaticRepliesSettingendTimetimeZone = WorkflowExpression.Compile(bodyautomaticRepliesSettingendTimetimeZone, nameof(bodyautomaticRepliesSettingendTimetimeZone), required: false);
            var __workflow_bodyautomaticRepliesSettinginternalReplyMessage = WorkflowExpression.Compile(bodyautomaticRepliesSettinginternalReplyMessage, nameof(bodyautomaticRepliesSettinginternalReplyMessage), required: false);
            var __workflow_bodyautomaticRepliesSettingexternalReplyMessage = WorkflowExpression.Compile(bodyautomaticRepliesSettingexternalReplyMessage, nameof(bodyautomaticRepliesSettingexternalReplyMessage), required: false);
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
                automaticRepliesSettingObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettingstatus);
                automaticRepliesSettingObjectpropCount++;
                automaticRepliesSettingObject["externalAudience"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettingexternalAudience);
                var scheduledStartDateTimeObject = new JObject();
                var scheduledStartDateTimeObjectpropCount = 0;
                if (__workflow_bodyautomaticRepliesSettingstartTimedateTime != null)
                {
                    scheduledStartDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettingstartTimedateTime);
                    scheduledStartDateTimeObjectpropCount++;
                }

                if (__workflow_bodyautomaticRepliesSettingstartTimetimeZone != null)
                {
                    scheduledStartDateTimeObject["timeZone"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettingstartTimetimeZone);
                    scheduledStartDateTimeObjectpropCount++;
                }

                if (scheduledStartDateTimeObjectpropCount > 0)
                {
                    automaticRepliesSettingObject["scheduledStartDateTime"] = scheduledStartDateTimeObject;
                    automaticRepliesSettingObjectpropCount++;
                }

                var scheduledEndDateTimeObject = new JObject();
                var scheduledEndDateTimeObjectpropCount = 0;
                if (__workflow_bodyautomaticRepliesSettingendTimedateTime != null)
                {
                    scheduledEndDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettingendTimedateTime);
                    scheduledEndDateTimeObjectpropCount++;
                }

                if (__workflow_bodyautomaticRepliesSettingendTimetimeZone != null)
                {
                    scheduledEndDateTimeObject["timeZone"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettingendTimetimeZone);
                    scheduledEndDateTimeObjectpropCount++;
                }

                if (scheduledEndDateTimeObjectpropCount > 0)
                {
                    automaticRepliesSettingObject["scheduledEndDateTime"] = scheduledEndDateTimeObject;
                    automaticRepliesSettingObjectpropCount++;
                }

                if (__workflow_bodyautomaticRepliesSettinginternalReplyMessage != null)
                {
                    automaticRepliesSettingObject["internalReplyMessage"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettinginternalReplyMessage);
                    automaticRepliesSettingObjectpropCount++;
                }

                if (__workflow_bodyautomaticRepliesSettingexternalReplyMessage != null)
                {
                    automaticRepliesSettingObject["externalReplyMessage"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRepliesSettingexternalReplyMessage);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SharedMailboxSendEmail(Expression<Func<string>> emailMessageoriginalMailboxAddress, Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagesensitivity = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
        {
            var __workflow_emailMessageoriginalMailboxAddress = WorkflowExpression.Compile(emailMessageoriginalMailboxAddress, nameof(emailMessageoriginalMailboxAddress), required: true);
            var __workflow_emailMessageto = WorkflowExpression.Compile(emailMessageto, nameof(emailMessageto), required: true);
            var __workflow_emailMessagesubject = WorkflowExpression.Compile(emailMessagesubject, nameof(emailMessagesubject), required: true);
            var __workflow_emailMessagebody = WorkflowExpression.Compile(emailMessagebody, nameof(emailMessagebody), required: true);
            var __workflow_emailMessagecC = WorkflowExpression.Compile(emailMessagecC, nameof(emailMessagecC), required: false);
            var __workflow_emailMessagebCC = WorkflowExpression.Compile(emailMessagebCC, nameof(emailMessagebCC), required: false);
            var __workflow_emailMessageattachments = WorkflowExpression.Compile(emailMessageattachments, nameof(emailMessageattachments), required: false);
            var __workflow_emailMessagesensitivity = WorkflowExpression.Compile(emailMessagesensitivity, nameof(emailMessagesensitivity), required: false);
            var __workflow_emailMessagereplyTo = WorkflowExpression.Compile(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            var __workflow_emailMessageimportance = WorkflowExpression.Compile(emailMessageimportance, nameof(emailMessageimportance), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/SharedMailbox/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["MailboxAddress"] = ExpressionConverter.ConvertO(__workflow_emailMessageoriginalMailboxAddress);
                emailMessagepropCount++;
                emailMessage["To"] = ExpressionConverter.ConvertO(__workflow_emailMessageto);
                emailMessagepropCount++;
                emailMessage["Subject"] = ExpressionConverter.ConvertO(__workflow_emailMessagesubject);
                emailMessagepropCount++;
                emailMessage["Body"] = ExpressionConverter.ConvertO(__workflow_emailMessagebody);
                if (__workflow_emailMessagecC != null)
                {
                    emailMessage["Cc"] = ExpressionConverter.ConvertO(__workflow_emailMessagecC);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = ExpressionConverter.ConvertO(__workflow_emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = ExpressionConverter.ConvertO(__workflow_emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagesensitivity != null)
                {
                    emailMessage["Sensitivity"] = ExpressionConverter.ConvertO(__workflow_emailMessagesensitivity);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagereplyTo != null)
                {
                    emailMessage["ReplyTo"] = ExpressionConverter.ConvertO(__workflow_emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageimportance != null)
                {
                    if (__workflow_emailMessageimportance != null)
                    {
                        emailMessage["Importance"] = ExpressionConverter.ConvertO(__workflow_emailMessageimportance);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class Office365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GraphCalendarEventListWithActionType> OnCalendarChangedItems(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_incomingDays = WorkflowExpression.Compile(incomingDays, nameof(incomingDays), required: false);
            var __workflow_pastDays = WorkflowExpression.Compile(pastDays, nameof(pastDays), required: false);
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
                if (__workflow_incomingDays != null)
                    input.Fetch.Queries["incomingDays"] = ExpressionConverter.Convert(__workflow_incomingDays);
                input.Fetch.Queries["pastDays"] = Convert.ToString(50);
                if (__workflow_pastDays != null)
                    input.Fetch.Queries["pastDays"] = ExpressionConverter.Convert(__workflow_pastDays);
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
                if (__workflow_incomingDays != null)
                    input.Subscribe.Queries["incomingDays"] = ExpressionConverter.Convert(__workflow_incomingDays);
                input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
                if (__workflow_pastDays != null)
                    input.Subscribe.Queries["pastDays"] = ExpressionConverter.Convert(__workflow_pastDays);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<GraphCalendarEventListWithActionType>(input);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarNewItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v3/tables/{0}/onnewitems", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnCalendarUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v3/tables/{0}/onupdateditems", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnFlaggedEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_cc = WorkflowExpression.Compile(cc, nameof(cc), required: false);
            var __workflow_toOrCc = WorkflowExpression.Compile(toOrCc, nameof(toOrCc), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_importance = WorkflowExpression.Compile(importance, nameof(importance), required: false);
            var __workflow_fetchOnlyWithAttachment = WorkflowExpression.Compile(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_subjectFilter = WorkflowExpression.Compile(subjectFilter, nameof(subjectFilter), required: false);
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
                if (__workflow_folderPath != null)
                    input.Fetch.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_to != null)
                    input.Fetch.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_cc != null)
                    input.Fetch.Queries["cc"] = ExpressionConverter.Convert(__workflow_cc);
                if (__workflow_toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = ExpressionConverter.Convert(__workflow_toOrCc);
                if (__workflow_from != null)
                    input.Fetch.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    input.Fetch.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = ExpressionConverter.Convert(__workflow_subjectFilter);
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
                if (__workflow_folderPath != null)
                    input.Subscribe.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    input.Subscribe.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_cc = WorkflowExpression.Compile(cc, nameof(cc), required: false);
            var __workflow_toOrCc = WorkflowExpression.Compile(toOrCc, nameof(toOrCc), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_importance = WorkflowExpression.Compile(importance, nameof(importance), required: false);
            var __workflow_fetchOnlyWithAttachment = WorkflowExpression.Compile(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_subjectFilter = WorkflowExpression.Compile(subjectFilter, nameof(subjectFilter), required: false);
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
                if (__workflow_folderPath != null)
                    input.Fetch.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_to != null)
                    input.Fetch.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_cc != null)
                    input.Fetch.Queries["cc"] = ExpressionConverter.Convert(__workflow_cc);
                if (__workflow_toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = ExpressionConverter.Convert(__workflow_toOrCc);
                if (__workflow_from != null)
                    input.Fetch.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    input.Fetch.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = ExpressionConverter.Convert(__workflow_subjectFilter);
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
                if (__workflow_folderPath != null)
                    input.Subscribe.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    input.Subscribe.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmailMentioningMe(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_cc = WorkflowExpression.Compile(cc, nameof(cc), required: false);
            var __workflow_toOrCc = WorkflowExpression.Compile(toOrCc, nameof(toOrCc), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_importance = WorkflowExpression.Compile(importance, nameof(importance), required: false);
            var __workflow_fetchOnlyWithAttachment = WorkflowExpression.Compile(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_subjectFilter = WorkflowExpression.Compile(subjectFilter, nameof(subjectFilter), required: false);
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
                if (__workflow_folderPath != null)
                    input.Fetch.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_to != null)
                    input.Fetch.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_cc != null)
                    input.Fetch.Queries["cc"] = ExpressionConverter.Convert(__workflow_cc);
                if (__workflow_toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = ExpressionConverter.Convert(__workflow_toOrCc);
                if (__workflow_from != null)
                    input.Fetch.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    input.Fetch.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = ExpressionConverter.Convert(__workflow_subjectFilter);
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
                if (__workflow_folderPath != null)
                    input.Subscribe.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    input.Subscribe.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnUpcomingEvents(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_lookAheadTimeInMinutes = WorkflowExpression.Compile(lookAheadTimeInMinutes, nameof(lookAheadTimeInMinutes), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive>(() =>
            {
                var apiCallPath = "/v3/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = ExpressionConverter.Convert(__workflow_table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (__workflow_lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(__workflow_lookAheadTimeInMinutes);
                return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnSharedMailboxNewEmail(Expression<Func<string>> mailboxAddress, Expression<Func<string>> folderId = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> hasAttachments = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, FlowRecurrence recurrence = null)
        {
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_cc = WorkflowExpression.Compile(cc, nameof(cc), required: false);
            var __workflow_toOrCc = WorkflowExpression.Compile(toOrCc, nameof(toOrCc), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_importance = WorkflowExpression.Compile(importance, nameof(importance), required: false);
            var __workflow_hasAttachments = WorkflowExpression.Compile(hasAttachments, nameof(hasAttachments), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_subjectFilter = WorkflowExpression.Compile(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage>(() =>
            {
                var apiCallPath = "/v2/SharedMailbox/Mail/OnNewEmail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                callPayload.Queries["folderId"] = Convert.ToString("Inbox");
                if (__workflow_folderId != null)
                    callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_cc != null)
                    callPayload.Queries["cc"] = ExpressionConverter.Convert(__workflow_cc);
                if (__workflow_toOrCc != null)
                    callPayload.Queries["toOrCc"] = ExpressionConverter.Convert(__workflow_toOrCc);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                callPayload.Queries["importance"] = Convert.ToString("Any");
                if (__workflow_importance != null)
                    callPayload.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                callPayload.Queries["hasAttachments"] = Convert.ToString(false);
                if (__workflow_hasAttachments != null)
                    callPayload.Queries["hasAttachments"] = ExpressionConverter.Convert(__workflow_hasAttachments);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_subjectFilter != null)
                    callPayload.Queries["subjectFilter"] = ExpressionConverter.Convert(__workflow_subjectFilter);
                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
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
