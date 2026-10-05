//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Outlook
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OutlookActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmail))]
        public IBodyWorkflowAction<ClientReceiveMessage> GetEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> internetMessageId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClientReceiveMessage> __BuildGetEmail(WorkflowValue<string> messageId, WorkflowValue<bool> includeAttachments = null, WorkflowValue<string> internetMessageId = null)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowValue.Validate(internetMessageId, nameof(internetMessageId), required: false);
            return new DeferredBodyAction<ClientReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (internetMessageId != null)
                    callPayload.Queries["internetMessageId"] = ExpressionConverter.Convert(internetMessageId);
                return new ApiConnectionAction<ClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEmail))]
        public IWorkflowAction DeleteEmail([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEmail(WorkflowValue<string> messageId)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildMove))]
        public IBodyWorkflowAction<ClientReceiveMessageStringEnums> Move([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> folderPath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClientReceiveMessageStringEnums> __BuildMove(WorkflowValue<string> messageId, WorkflowValue<string> folderPath)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<ClientReceiveMessageStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/Move/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                return new ApiConnectionAction<ClientReceiveMessageStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildFlag))]
        public IWorkflowAction Flag([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlag(WorkflowValue<string> messageId)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/Flag/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildMarkAsRead))]
        public IWorkflowAction MarkAsRead([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarkAsRead(WorkflowValue<string> messageId)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/MarkAsRead/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttachment))]
        public IBodyWorkflowAction<string> GetAttachment([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> attachmentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetAttachment(WorkflowValue<string> messageId, WorkflowValue<string> attachmentId)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}/Attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildSendMailWithOptions))]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions([WorkflowExpression] Func<string> optionsEmailSubscriptionmessageto, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<optionsEmailSubscriptionmessageimportanceInput> optionsEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> optionsEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriptionResponse> __BuildSendMailWithOptions(WorkflowValue<string> optionsEmailSubscriptionmessageto, WorkflowValue<string> optionsEmailSubscriptionmessagesubject = null, WorkflowValue<string> optionsEmailSubscriptionmessageuserOptions = null, WorkflowValue<string> optionsEmailSubscriptionmessageheaderText = null, WorkflowValue<string> optionsEmailSubscriptionmessageselectionText = null, WorkflowValue<string> optionsEmailSubscriptionmessagebody = null, WorkflowValue<optionsEmailSubscriptionmessageimportanceInput> optionsEmailSubscriptionmessageimportance = null, WorkflowValue<ClientSendAttachment[]> optionsEmailSubscriptionmessageattachments = null, WorkflowValue<bool> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, WorkflowValue<bool> optionsEmailSubscriptionmessagehideHTMLMessage = null, WorkflowValue<bool> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            WorkflowValue.Validate(optionsEmailSubscriptionmessageto, nameof(optionsEmailSubscriptionmessageto), required: true);
            WorkflowValue.Validate(optionsEmailSubscriptionmessagesubject, nameof(optionsEmailSubscriptionmessagesubject), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessageuserOptions, nameof(optionsEmailSubscriptionmessageuserOptions), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessageheaderText, nameof(optionsEmailSubscriptionmessageheaderText), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessageselectionText, nameof(optionsEmailSubscriptionmessageselectionText), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessagebody, nameof(optionsEmailSubscriptionmessagebody), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessageimportance, nameof(optionsEmailSubscriptionmessageimportance), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessageattachments, nameof(optionsEmailSubscriptionmessageattachments), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(optionsEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessagehideHTMLMessage, nameof(optionsEmailSubscriptionmessagehideHTMLMessage), required: false);
            WorkflowValue.Validate(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildSendApprovalMail))]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail([WorkflowExpression] Func<string> approvalEmailSubscriptionmessageto, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<approvalEmailSubscriptionmessageimportanceInput> approvalEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> approvalEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriptionResponse> __BuildSendApprovalMail(WorkflowValue<string> approvalEmailSubscriptionmessageto, WorkflowValue<string> approvalEmailSubscriptionmessagesubject = null, WorkflowValue<string> approvalEmailSubscriptionmessageuserOptions = null, WorkflowValue<string> approvalEmailSubscriptionmessageheaderText = null, WorkflowValue<string> approvalEmailSubscriptionmessageselectionText = null, WorkflowValue<string> approvalEmailSubscriptionmessagebody = null, WorkflowValue<approvalEmailSubscriptionmessageimportanceInput> approvalEmailSubscriptionmessageimportance = null, WorkflowValue<ClientSendAttachment[]> approvalEmailSubscriptionmessageattachments = null, WorkflowValue<bool> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, WorkflowValue<bool> approvalEmailSubscriptionmessagehideHTMLMessage = null, WorkflowValue<bool> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            WorkflowValue.Validate(approvalEmailSubscriptionmessageto, nameof(approvalEmailSubscriptionmessageto), required: true);
            WorkflowValue.Validate(approvalEmailSubscriptionmessagesubject, nameof(approvalEmailSubscriptionmessagesubject), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessageuserOptions, nameof(approvalEmailSubscriptionmessageuserOptions), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessageheaderText, nameof(approvalEmailSubscriptionmessageheaderText), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessageselectionText, nameof(approvalEmailSubscriptionmessageselectionText), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessagebody, nameof(approvalEmailSubscriptionmessagebody), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessageimportance, nameof(approvalEmailSubscriptionmessageimportance), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessageattachments, nameof(approvalEmailSubscriptionmessageattachments), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessageuseOnlyHTMLMessage, nameof(approvalEmailSubscriptionmessageuseOnlyHTMLMessage), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessagehideHTMLMessage, nameof(approvalEmailSubscriptionmessagehideHTMLMessage), required: false);
            WorkflowValue.Validate(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog, nameof(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog), required: false);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable> CalendarGetTables()
        {
            var apiCallPath = "/datasets/calendars/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseTable>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarDeleteItem))]
        public IWorkflowAction CalendarDeleteItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCalendarDeleteItem(WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable> ContactGetTables()
        {
            var apiCallPath = "/datasets/contacts/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseTable>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildContactGetItems))]
        public IBodyWorkflowAction<EntityListResponseContactResponse> ContactGetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityListResponseContactResponse> __BuildContactGetItems(WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EntityListResponseContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
                return new ApiConnectionAction<EntityListResponseContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildContactPostItem))]
        public IBodyWorkflowAction<ContactResponse> ContactPostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddress[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponse> __BuildContactPostItem(WorkflowValue<string> table, WorkflowValue<string> itemgivenName, WorkflowValue<string[]> itemhomePhones, WorkflowValue<string> itemid = null, WorkflowValue<string> itemparentFolderId = null, WorkflowValue<string> itembirthday = null, WorkflowValue<string> itemfileAs = null, WorkflowValue<string> itemdisplayName = null, WorkflowValue<string> iteminitials = null, WorkflowValue<string> itemmiddleName = null, WorkflowValue<string> itemnickname = null, WorkflowValue<string> itemsurname = null, WorkflowValue<string> itemtitle = null, WorkflowValue<string> itemgeneration = null, WorkflowValue<EmailAddress[]> itememailAddresses = null, WorkflowValue<string[]> itemiMAddresses = null, WorkflowValue<string> itemjobTitle = null, WorkflowValue<string> itemcompanyName = null, WorkflowValue<string> itemdepartment = null, WorkflowValue<string> itemofficeLocation = null, WorkflowValue<string> itemprofession = null, WorkflowValue<string> itembusinessHomePage = null, WorkflowValue<string> itemassistantName = null, WorkflowValue<string> itemmanager = null, WorkflowValue<string[]> itembusinessPhones = null, WorkflowValue<string> itemmobilePhone = null, WorkflowValue<string> itemhomeAddressstreet = null, WorkflowValue<string> itemhomeAddresscity = null, WorkflowValue<string> itemhomeAddressstate = null, WorkflowValue<string> itemhomeAddresscountryOrRegion = null, WorkflowValue<string> itemhomeAddresspostalCode = null, WorkflowValue<string> itembusinessAddressstreet = null, WorkflowValue<string> itembusinessAddresscity = null, WorkflowValue<string> itembusinessAddressstate = null, WorkflowValue<string> itembusinessAddresscountryOrRegion = null, WorkflowValue<string> itembusinessAddresspostalCode = null, WorkflowValue<string> itemotherAddressstreet = null, WorkflowValue<string> itemotherAddresscity = null, WorkflowValue<string> itemotherAddressstate = null, WorkflowValue<string> itemotherAddresscountryOrRegion = null, WorkflowValue<string> itemotherAddresspostalCode = null, WorkflowValue<string> itemyomiCompanyName = null, WorkflowValue<string> itemyomiGivenName = null, WorkflowValue<string> itemyomiSurname = null, WorkflowValue<string[]> itemcategories = null, WorkflowValue<string> itemchangeKey = null, WorkflowValue<string> itemcreatedTime = null, WorkflowValue<string> itemlastModifiedTime = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(itemgivenName, nameof(itemgivenName), required: true);
            WorkflowValue.Validate(itemhomePhones, nameof(itemhomePhones), required: true);
            WorkflowValue.Validate(itemid, nameof(itemid), required: false);
            WorkflowValue.Validate(itemparentFolderId, nameof(itemparentFolderId), required: false);
            WorkflowValue.Validate(itembirthday, nameof(itembirthday), required: false);
            WorkflowValue.Validate(itemfileAs, nameof(itemfileAs), required: false);
            WorkflowValue.Validate(itemdisplayName, nameof(itemdisplayName), required: false);
            WorkflowValue.Validate(iteminitials, nameof(iteminitials), required: false);
            WorkflowValue.Validate(itemmiddleName, nameof(itemmiddleName), required: false);
            WorkflowValue.Validate(itemnickname, nameof(itemnickname), required: false);
            WorkflowValue.Validate(itemsurname, nameof(itemsurname), required: false);
            WorkflowValue.Validate(itemtitle, nameof(itemtitle), required: false);
            WorkflowValue.Validate(itemgeneration, nameof(itemgeneration), required: false);
            WorkflowValue.Validate(itememailAddresses, nameof(itememailAddresses), required: false);
            WorkflowValue.Validate(itemiMAddresses, nameof(itemiMAddresses), required: false);
            WorkflowValue.Validate(itemjobTitle, nameof(itemjobTitle), required: false);
            WorkflowValue.Validate(itemcompanyName, nameof(itemcompanyName), required: false);
            WorkflowValue.Validate(itemdepartment, nameof(itemdepartment), required: false);
            WorkflowValue.Validate(itemofficeLocation, nameof(itemofficeLocation), required: false);
            WorkflowValue.Validate(itemprofession, nameof(itemprofession), required: false);
            WorkflowValue.Validate(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            WorkflowValue.Validate(itemassistantName, nameof(itemassistantName), required: false);
            WorkflowValue.Validate(itemmanager, nameof(itemmanager), required: false);
            WorkflowValue.Validate(itembusinessPhones, nameof(itembusinessPhones), required: false);
            WorkflowValue.Validate(itemmobilePhone, nameof(itemmobilePhone), required: false);
            WorkflowValue.Validate(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            WorkflowValue.Validate(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            WorkflowValue.Validate(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            WorkflowValue.Validate(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            WorkflowValue.Validate(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            WorkflowValue.Validate(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            WorkflowValue.Validate(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            WorkflowValue.Validate(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            WorkflowValue.Validate(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            WorkflowValue.Validate(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            WorkflowValue.Validate(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            WorkflowValue.Validate(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            WorkflowValue.Validate(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            WorkflowValue.Validate(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            WorkflowValue.Validate(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            WorkflowValue.Validate(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            WorkflowValue.Validate(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            WorkflowValue.Validate(itemyomiSurname, nameof(itemyomiSurname), required: false);
            WorkflowValue.Validate(itemcategories, nameof(itemcategories), required: false);
            WorkflowValue.Validate(itemchangeKey, nameof(itemchangeKey), required: false);
            WorkflowValue.Validate(itemcreatedTime, nameof(itemcreatedTime), required: false);
            WorkflowValue.Validate(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["Id"] = ExpressionConverter.ConvertO(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["ParentFolderId"] = ExpressionConverter.ConvertO(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["Birthday"] = ExpressionConverter.ConvertO(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["FileAs"] = ExpressionConverter.ConvertO(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["DisplayName"] = ExpressionConverter.ConvertO(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["GivenName"] = ExpressionConverter.ConvertO(itemgivenName);
                if (iteminitials != null)
                {
                    item["Initials"] = ExpressionConverter.ConvertO(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["MiddleName"] = ExpressionConverter.ConvertO(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["NickName"] = ExpressionConverter.ConvertO(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["Surname"] = ExpressionConverter.ConvertO(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["Title"] = ExpressionConverter.ConvertO(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["Generation"] = ExpressionConverter.ConvertO(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["EmailAddresses"] = ExpressionConverter.ConvertO(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["ImAddresses"] = ExpressionConverter.ConvertO(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["JobTitle"] = ExpressionConverter.ConvertO(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["CompanyName"] = ExpressionConverter.ConvertO(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["Department"] = ExpressionConverter.ConvertO(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["OfficeLocation"] = ExpressionConverter.ConvertO(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["Profession"] = ExpressionConverter.ConvertO(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["BusinessHomePage"] = ExpressionConverter.ConvertO(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["AssistantName"] = ExpressionConverter.ConvertO(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["Manager"] = ExpressionConverter.ConvertO(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["HomePhones"] = ExpressionConverter.ConvertO(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["BusinessPhones"] = ExpressionConverter.ConvertO(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["MobilePhone1"] = ExpressionConverter.ConvertO(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["Street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["City"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["State"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["HomeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    businessAddressObject["Street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["City"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["State"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["BusinessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    otherAddressObject["Street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["City"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["State"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["OtherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["YomiCompanyName"] = ExpressionConverter.ConvertO(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["YomiGivenName"] = ExpressionConverter.ConvertO(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["YomiSurname"] = ExpressionConverter.ConvertO(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["Categories"] = ExpressionConverter.ConvertO(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["ChangeKey"] = ExpressionConverter.ConvertO(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["DateTimeCreated"] = ExpressionConverter.ConvertO(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["DateTimeLastModified"] = ExpressionConverter.ConvertO(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildContactGetItem))]
        public IBodyWorkflowAction<ContactResponse> ContactGetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponse> __BuildContactGetItem(WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildContactDeleteItem))]
        public IWorkflowAction ContactDeleteItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactDeleteItem(WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildContactPatchItem))]
        public IBodyWorkflowAction<ContactResponse> ContactPatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddress[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponse> __BuildContactPatchItem(WorkflowValue<string> table, WorkflowValue<string> id, WorkflowValue<string> itemgivenName, WorkflowValue<string[]> itemhomePhones, WorkflowValue<string> itemid = null, WorkflowValue<string> itemparentFolderId = null, WorkflowValue<string> itembirthday = null, WorkflowValue<string> itemfileAs = null, WorkflowValue<string> itemdisplayName = null, WorkflowValue<string> iteminitials = null, WorkflowValue<string> itemmiddleName = null, WorkflowValue<string> itemnickname = null, WorkflowValue<string> itemsurname = null, WorkflowValue<string> itemtitle = null, WorkflowValue<string> itemgeneration = null, WorkflowValue<EmailAddress[]> itememailAddresses = null, WorkflowValue<string[]> itemiMAddresses = null, WorkflowValue<string> itemjobTitle = null, WorkflowValue<string> itemcompanyName = null, WorkflowValue<string> itemdepartment = null, WorkflowValue<string> itemofficeLocation = null, WorkflowValue<string> itemprofession = null, WorkflowValue<string> itembusinessHomePage = null, WorkflowValue<string> itemassistantName = null, WorkflowValue<string> itemmanager = null, WorkflowValue<string[]> itembusinessPhones = null, WorkflowValue<string> itemmobilePhone = null, WorkflowValue<string> itemhomeAddressstreet = null, WorkflowValue<string> itemhomeAddresscity = null, WorkflowValue<string> itemhomeAddressstate = null, WorkflowValue<string> itemhomeAddresscountryOrRegion = null, WorkflowValue<string> itemhomeAddresspostalCode = null, WorkflowValue<string> itembusinessAddressstreet = null, WorkflowValue<string> itembusinessAddresscity = null, WorkflowValue<string> itembusinessAddressstate = null, WorkflowValue<string> itembusinessAddresscountryOrRegion = null, WorkflowValue<string> itembusinessAddresspostalCode = null, WorkflowValue<string> itemotherAddressstreet = null, WorkflowValue<string> itemotherAddresscity = null, WorkflowValue<string> itemotherAddressstate = null, WorkflowValue<string> itemotherAddresscountryOrRegion = null, WorkflowValue<string> itemotherAddresspostalCode = null, WorkflowValue<string> itemyomiCompanyName = null, WorkflowValue<string> itemyomiGivenName = null, WorkflowValue<string> itemyomiSurname = null, WorkflowValue<string[]> itemcategories = null, WorkflowValue<string> itemchangeKey = null, WorkflowValue<string> itemcreatedTime = null, WorkflowValue<string> itemlastModifiedTime = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(itemgivenName, nameof(itemgivenName), required: true);
            WorkflowValue.Validate(itemhomePhones, nameof(itemhomePhones), required: true);
            WorkflowValue.Validate(itemid, nameof(itemid), required: false);
            WorkflowValue.Validate(itemparentFolderId, nameof(itemparentFolderId), required: false);
            WorkflowValue.Validate(itembirthday, nameof(itembirthday), required: false);
            WorkflowValue.Validate(itemfileAs, nameof(itemfileAs), required: false);
            WorkflowValue.Validate(itemdisplayName, nameof(itemdisplayName), required: false);
            WorkflowValue.Validate(iteminitials, nameof(iteminitials), required: false);
            WorkflowValue.Validate(itemmiddleName, nameof(itemmiddleName), required: false);
            WorkflowValue.Validate(itemnickname, nameof(itemnickname), required: false);
            WorkflowValue.Validate(itemsurname, nameof(itemsurname), required: false);
            WorkflowValue.Validate(itemtitle, nameof(itemtitle), required: false);
            WorkflowValue.Validate(itemgeneration, nameof(itemgeneration), required: false);
            WorkflowValue.Validate(itememailAddresses, nameof(itememailAddresses), required: false);
            WorkflowValue.Validate(itemiMAddresses, nameof(itemiMAddresses), required: false);
            WorkflowValue.Validate(itemjobTitle, nameof(itemjobTitle), required: false);
            WorkflowValue.Validate(itemcompanyName, nameof(itemcompanyName), required: false);
            WorkflowValue.Validate(itemdepartment, nameof(itemdepartment), required: false);
            WorkflowValue.Validate(itemofficeLocation, nameof(itemofficeLocation), required: false);
            WorkflowValue.Validate(itemprofession, nameof(itemprofession), required: false);
            WorkflowValue.Validate(itembusinessHomePage, nameof(itembusinessHomePage), required: false);
            WorkflowValue.Validate(itemassistantName, nameof(itemassistantName), required: false);
            WorkflowValue.Validate(itemmanager, nameof(itemmanager), required: false);
            WorkflowValue.Validate(itembusinessPhones, nameof(itembusinessPhones), required: false);
            WorkflowValue.Validate(itemmobilePhone, nameof(itemmobilePhone), required: false);
            WorkflowValue.Validate(itemhomeAddressstreet, nameof(itemhomeAddressstreet), required: false);
            WorkflowValue.Validate(itemhomeAddresscity, nameof(itemhomeAddresscity), required: false);
            WorkflowValue.Validate(itemhomeAddressstate, nameof(itemhomeAddressstate), required: false);
            WorkflowValue.Validate(itemhomeAddresscountryOrRegion, nameof(itemhomeAddresscountryOrRegion), required: false);
            WorkflowValue.Validate(itemhomeAddresspostalCode, nameof(itemhomeAddresspostalCode), required: false);
            WorkflowValue.Validate(itembusinessAddressstreet, nameof(itembusinessAddressstreet), required: false);
            WorkflowValue.Validate(itembusinessAddresscity, nameof(itembusinessAddresscity), required: false);
            WorkflowValue.Validate(itembusinessAddressstate, nameof(itembusinessAddressstate), required: false);
            WorkflowValue.Validate(itembusinessAddresscountryOrRegion, nameof(itembusinessAddresscountryOrRegion), required: false);
            WorkflowValue.Validate(itembusinessAddresspostalCode, nameof(itembusinessAddresspostalCode), required: false);
            WorkflowValue.Validate(itemotherAddressstreet, nameof(itemotherAddressstreet), required: false);
            WorkflowValue.Validate(itemotherAddresscity, nameof(itemotherAddresscity), required: false);
            WorkflowValue.Validate(itemotherAddressstate, nameof(itemotherAddressstate), required: false);
            WorkflowValue.Validate(itemotherAddresscountryOrRegion, nameof(itemotherAddresscountryOrRegion), required: false);
            WorkflowValue.Validate(itemotherAddresspostalCode, nameof(itemotherAddresspostalCode), required: false);
            WorkflowValue.Validate(itemyomiCompanyName, nameof(itemyomiCompanyName), required: false);
            WorkflowValue.Validate(itemyomiGivenName, nameof(itemyomiGivenName), required: false);
            WorkflowValue.Validate(itemyomiSurname, nameof(itemyomiSurname), required: false);
            WorkflowValue.Validate(itemcategories, nameof(itemcategories), required: false);
            WorkflowValue.Validate(itemchangeKey, nameof(itemchangeKey), required: false);
            WorkflowValue.Validate(itemcreatedTime, nameof(itemcreatedTime), required: false);
            WorkflowValue.Validate(itemlastModifiedTime, nameof(itemlastModifiedTime), required: false);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["Id"] = ExpressionConverter.ConvertO(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["ParentFolderId"] = ExpressionConverter.ConvertO(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["Birthday"] = ExpressionConverter.ConvertO(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["FileAs"] = ExpressionConverter.ConvertO(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["DisplayName"] = ExpressionConverter.ConvertO(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["GivenName"] = ExpressionConverter.ConvertO(itemgivenName);
                if (iteminitials != null)
                {
                    item["Initials"] = ExpressionConverter.ConvertO(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["MiddleName"] = ExpressionConverter.ConvertO(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["NickName"] = ExpressionConverter.ConvertO(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["Surname"] = ExpressionConverter.ConvertO(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["Title"] = ExpressionConverter.ConvertO(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["Generation"] = ExpressionConverter.ConvertO(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["EmailAddresses"] = ExpressionConverter.ConvertO(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["ImAddresses"] = ExpressionConverter.ConvertO(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["JobTitle"] = ExpressionConverter.ConvertO(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["CompanyName"] = ExpressionConverter.ConvertO(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["Department"] = ExpressionConverter.ConvertO(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["OfficeLocation"] = ExpressionConverter.ConvertO(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["Profession"] = ExpressionConverter.ConvertO(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["BusinessHomePage"] = ExpressionConverter.ConvertO(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["AssistantName"] = ExpressionConverter.ConvertO(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["Manager"] = ExpressionConverter.ConvertO(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["HomePhones"] = ExpressionConverter.ConvertO(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["BusinessPhones"] = ExpressionConverter.ConvertO(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["MobilePhone1"] = ExpressionConverter.ConvertO(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["Street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["City"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["State"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["HomeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    businessAddressObject["Street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["City"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["State"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["BusinessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    otherAddressObject["Street"] = ExpressionConverter.ConvertO(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["City"] = ExpressionConverter.ConvertO(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["State"] = ExpressionConverter.ConvertO(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["OtherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["YomiCompanyName"] = ExpressionConverter.ConvertO(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["YomiGivenName"] = ExpressionConverter.ConvertO(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["YomiSurname"] = ExpressionConverter.ConvertO(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["Categories"] = ExpressionConverter.ConvertO(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["ChangeKey"] = ExpressionConverter.ConvertO(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["DateTimeCreated"] = ExpressionConverter.ConvertO(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["DateTimeLastModified"] = ExpressionConverter.ConvertO(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildRespondToEvent))]
        public IWorkflowAction RespondToEvent([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<responseInput> response, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<bool> bodysendResponse = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRespondToEvent(WorkflowValue<string> eventId, WorkflowValue<responseInput> response, WorkflowValue<string> bodycomment = null, WorkflowValue<bool> bodysendResponse = null)
        {
            WorkflowValue.Validate(eventId, nameof(eventId), required: true);
            WorkflowValue.Validate(response, nameof(response), required: true);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowValue.Validate(bodysendResponse, nameof(bodysendResponse), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/events/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(response, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildForwardEmail))]
        public IWorkflowAction ForwardEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildForwardEmail(WorkflowValue<string> messageId, WorkflowValue<string> bodyto, WorkflowValue<string> bodycomment = null)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/messages/{0}/forward", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarGetItem))]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarGetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> __BuildCalendarGetItem(WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarGetItems))]
        public IBodyWorkflowAction<CalendarEventListClientReceive> CalendarGetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarEventListClientReceive> __BuildCalendarGetItems(WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyAction<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
                return new ApiConnectionAction<CalendarEventListClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarPatchItem))]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone = null, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<string> itemrecurrenceEndTime = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> __BuildCalendarPatchItem(WorkflowValue<string> table, WorkflowValue<string> id, WorkflowValue<string> itemsubject, WorkflowValue<string> itemstartTime, WorkflowValue<string> itemendTime, WorkflowValue<itemtimeZoneInput> itemtimeZone = null, WorkflowValue<string> itemrequiredAttendees = null, WorkflowValue<string> itemoptionalAttendees = null, WorkflowValue<string> itemresourceAttendees = null, WorkflowValue<string> itembody = null, WorkflowValue<string> itemlocation = null, WorkflowValue<itemimportanceInput> itemimportance = null, WorkflowValue<bool> itemisAllDayEvent = null, WorkflowValue<itemrecurrenceInput> itemrecurrence = null, WorkflowValue<string> itemrecurrenceEndTime = null, WorkflowValue<int> itemnumberOfOccurrences = null, WorkflowValue<int> itemreminder = null, WorkflowValue<itemshowAsInput> itemshowAs = null, WorkflowValue<bool> itemresponseRequested = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(itemsubject, nameof(itemsubject), required: true);
            WorkflowValue.Validate(itemstartTime, nameof(itemstartTime), required: true);
            WorkflowValue.Validate(itemendTime, nameof(itemendTime), required: true);
            WorkflowValue.Validate(itemtimeZone, nameof(itemtimeZone), required: false);
            WorkflowValue.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            WorkflowValue.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            WorkflowValue.Validate(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            WorkflowValue.Validate(itembody, nameof(itembody), required: false);
            WorkflowValue.Validate(itemlocation, nameof(itemlocation), required: false);
            WorkflowValue.Validate(itemimportance, nameof(itemimportance), required: false);
            WorkflowValue.Validate(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            WorkflowValue.Validate(itemrecurrence, nameof(itemrecurrence), required: false);
            WorkflowValue.Validate(itemrecurrenceEndTime, nameof(itemrecurrenceEndTime), required: false);
            WorkflowValue.Validate(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            WorkflowValue.Validate(itemreminder, nameof(itemreminder), required: false);
            WorkflowValue.Validate(itemshowAs, nameof(itemshowAs), required: false);
            WorkflowValue.Validate(itemresponseRequested, nameof(itemresponseRequested), required: false);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["Subject"] = ExpressionConverter.ConvertO(itemsubject);
                itempropCount++;
                item["Start"] = ExpressionConverter.ConvertO(itemstartTime);
                itempropCount++;
                item["End"] = ExpressionConverter.ConvertO(itemendTime);
                if (itemtimeZone != null)
                {
                    item["TimeZone"] = ExpressionConverter.ConvertO(itemtimeZone);
                    itempropCount++;
                }

                if (itemrequiredAttendees != null)
                {
                    item["RequiredAttendees"] = ExpressionConverter.ConvertO(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["OptionalAttendees"] = ExpressionConverter.ConvertO(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["ResourceAttendees"] = ExpressionConverter.ConvertO(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["Body"] = ExpressionConverter.ConvertO(itembody);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["Location"] = ExpressionConverter.ConvertO(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["Importance"] = ExpressionConverter.ConvertO(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["IsAllDay"] = ExpressionConverter.ConvertO(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["Recurrence"] = ExpressionConverter.ConvertO(itemrecurrence);
                    itempropCount++;
                }

                if (itemrecurrenceEndTime != null)
                {
                    item["RecurrenceEnd"] = ExpressionConverter.ConvertO(itemrecurrenceEndTime);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["NumberOfOccurrences"] = ExpressionConverter.ConvertO(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["Reminder"] = ExpressionConverter.ConvertO(itemreminder);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["ShowAs"] = ExpressionConverter.ConvertO(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["ResponseRequested"] = ExpressionConverter.ConvertO(itemresponseRequested);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildCalendarPostItem))]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone = null, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<string> itemrecurrenceEndTime = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> __BuildCalendarPostItem(WorkflowValue<string> table, WorkflowValue<string> itemsubject, WorkflowValue<string> itemstartTime, WorkflowValue<string> itemendTime, WorkflowValue<itemtimeZoneInput> itemtimeZone = null, WorkflowValue<string> itemrequiredAttendees = null, WorkflowValue<string> itemoptionalAttendees = null, WorkflowValue<string> itemresourceAttendees = null, WorkflowValue<string> itembody = null, WorkflowValue<string> itemlocation = null, WorkflowValue<itemimportanceInput> itemimportance = null, WorkflowValue<bool> itemisAllDayEvent = null, WorkflowValue<itemrecurrenceInput> itemrecurrence = null, WorkflowValue<string> itemrecurrenceEndTime = null, WorkflowValue<int> itemnumberOfOccurrences = null, WorkflowValue<int> itemreminder = null, WorkflowValue<itemshowAsInput> itemshowAs = null, WorkflowValue<bool> itemresponseRequested = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(itemsubject, nameof(itemsubject), required: true);
            WorkflowValue.Validate(itemstartTime, nameof(itemstartTime), required: true);
            WorkflowValue.Validate(itemendTime, nameof(itemendTime), required: true);
            WorkflowValue.Validate(itemtimeZone, nameof(itemtimeZone), required: false);
            WorkflowValue.Validate(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            WorkflowValue.Validate(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            WorkflowValue.Validate(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            WorkflowValue.Validate(itembody, nameof(itembody), required: false);
            WorkflowValue.Validate(itemlocation, nameof(itemlocation), required: false);
            WorkflowValue.Validate(itemimportance, nameof(itemimportance), required: false);
            WorkflowValue.Validate(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            WorkflowValue.Validate(itemrecurrence, nameof(itemrecurrence), required: false);
            WorkflowValue.Validate(itemrecurrenceEndTime, nameof(itemrecurrenceEndTime), required: false);
            WorkflowValue.Validate(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            WorkflowValue.Validate(itemreminder, nameof(itemreminder), required: false);
            WorkflowValue.Validate(itemshowAs, nameof(itemshowAs), required: false);
            WorkflowValue.Validate(itemresponseRequested, nameof(itemresponseRequested), required: false);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["Subject"] = ExpressionConverter.ConvertO(itemsubject);
                itempropCount++;
                item["Start"] = ExpressionConverter.ConvertO(itemstartTime);
                itempropCount++;
                item["End"] = ExpressionConverter.ConvertO(itemendTime);
                if (itemtimeZone != null)
                {
                    item["TimeZone"] = ExpressionConverter.ConvertO(itemtimeZone);
                    itempropCount++;
                }

                if (itemrequiredAttendees != null)
                {
                    item["RequiredAttendees"] = ExpressionConverter.ConvertO(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["OptionalAttendees"] = ExpressionConverter.ConvertO(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["ResourceAttendees"] = ExpressionConverter.ConvertO(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["Body"] = ExpressionConverter.ConvertO(itembody);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["Location"] = ExpressionConverter.ConvertO(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["Importance"] = ExpressionConverter.ConvertO(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["IsAllDay"] = ExpressionConverter.ConvertO(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["Recurrence"] = ExpressionConverter.ConvertO(itemrecurrence);
                    itempropCount++;
                }

                if (itemrecurrenceEndTime != null)
                {
                    item["RecurrenceEnd"] = ExpressionConverter.ConvertO(itemrecurrenceEndTime);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["NumberOfOccurrences"] = ExpressionConverter.ConvertO(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["Reminder"] = ExpressionConverter.ConvertO(itemreminder);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["ShowAs"] = ExpressionConverter.ConvertO(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["ResponseRequested"] = ExpressionConverter.ConvertO(itemresponseRequested);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmails))]
        public IBodyWorkflowAction<BatchResponseClientReceiveMessage> GetEmails([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<string> subjectFilter = null, [WorkflowExpression] Func<bool> fetchOnlyUnread = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> searchQuery = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BatchResponseClientReceiveMessage> __BuildGetEmails(WorkflowValue<string> folderPath = null, WorkflowValue<string> to = null, WorkflowValue<string> cc = null, WorkflowValue<string> toOrCc = null, WorkflowValue<string> from = null, WorkflowValue<importanceInput> importance = null, WorkflowValue<bool> fetchOnlyWithAttachment = null, WorkflowValue<string> subjectFilter = null, WorkflowValue<bool> fetchOnlyUnread = null, WorkflowValue<bool> includeAttachments = null, WorkflowValue<string> searchQuery = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            WorkflowValue.Validate(cc, nameof(cc), required: false);
            WorkflowValue.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(importance, nameof(importance), required: false);
            WorkflowValue.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowValue.Validate(subjectFilter, nameof(subjectFilter), required: false);
            WorkflowValue.Validate(fetchOnlyUnread, nameof(fetchOnlyUnread), required: false);
            WorkflowValue.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowValue.Validate(searchQuery, nameof(searchQuery), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<BatchResponseClientReceiveMessage>(() =>
            {
                var apiCallPath = "/v2/Mail";
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
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                if (searchQuery != null)
                    callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(searchQuery);
                callPayload.Queries["top"] = Convert.ToString(10);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<BatchResponseClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildGetEventsCalendarView))]
        public IBodyWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> GetEventsCalendarView([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> startDateTimeOffset, [WorkflowExpression] Func<string> endDateTimeOffset, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> search = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> __BuildGetEventsCalendarView(WorkflowValue<string> calendarId, WorkflowValue<string> startDateTimeOffset, WorkflowValue<string> endDateTimeOffset, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, WorkflowValue<string> search = null)
        {
            WorkflowValue.Validate(calendarId, nameof(calendarId), required: true);
            WorkflowValue.Validate(startDateTimeOffset, nameof(startDateTimeOffset), required: true);
            WorkflowValue.Validate(endDateTimeOffset, nameof(endDateTimeOffset), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(search, nameof(search), required: false);
            return new DeferredBodyAction<EntityListResponseCalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = "/datasets/calendars/v2/tables/items/calendarview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["calendarId"] = ExpressionConverter.Convert(calendarId);
                callPayload.Queries["startDateTimeOffset"] = ExpressionConverter.Convert(startDateTimeOffset);
                callPayload.Queries["endDateTimeOffset"] = ExpressionConverter.Convert(endDateTimeOffset);
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
                return new ApiConnectionAction<EntityListResponseCalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildReplyTo))]
        public IWorkflowAction ReplyTo([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> replyParametersto = null, [WorkflowExpression] Func<string> replyParameterscC = null, [WorkflowExpression] Func<string> replyParametersbCC = null, [WorkflowExpression] Func<string> replyParameterssubject = null, [WorkflowExpression] Func<string> replyParametersbody = null, [WorkflowExpression] Func<bool> replyParametersreplyAll = null, [WorkflowExpression] Func<replyParametersimportanceInput> replyParametersimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> replyParametersattachments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReplyTo(WorkflowValue<string> messageId, WorkflowValue<string> replyParametersto = null, WorkflowValue<string> replyParameterscC = null, WorkflowValue<string> replyParametersbCC = null, WorkflowValue<string> replyParameterssubject = null, WorkflowValue<string> replyParametersbody = null, WorkflowValue<bool> replyParametersreplyAll = null, WorkflowValue<replyParametersimportanceInput> replyParametersimportance = null, WorkflowValue<ClientSendAttachment[]> replyParametersattachments = null)
        {
            WorkflowValue.Validate(messageId, nameof(messageId), required: true);
            WorkflowValue.Validate(replyParametersto, nameof(replyParametersto), required: false);
            WorkflowValue.Validate(replyParameterscC, nameof(replyParameterscC), required: false);
            WorkflowValue.Validate(replyParametersbCC, nameof(replyParametersbCC), required: false);
            WorkflowValue.Validate(replyParameterssubject, nameof(replyParameterssubject), required: false);
            WorkflowValue.Validate(replyParametersbody, nameof(replyParametersbody), required: false);
            WorkflowValue.Validate(replyParametersreplyAll, nameof(replyParametersreplyAll), required: false);
            WorkflowValue.Validate(replyParametersimportance, nameof(replyParametersimportance), required: false);
            WorkflowValue.Validate(replyParametersattachments, nameof(replyParametersattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        [WorkflowExpressionFactory(nameof(__BuildSendEmail))]
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagesubject, [WorkflowExpression] Func<string> emailMessagebody, [WorkflowExpression] Func<string> emailMessagefromSendAs = null, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> emailMessageattachments = null, [WorkflowExpression] Func<string> emailMessagereplyTo = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEmail(WorkflowValue<string> emailMessageto, WorkflowValue<string> emailMessagesubject, WorkflowValue<string> emailMessagebody, WorkflowValue<string> emailMessagefromSendAs = null, WorkflowValue<string> emailMessagecC = null, WorkflowValue<string> emailMessagebCC = null, WorkflowValue<ClientSendAttachment[]> emailMessageattachments = null, WorkflowValue<string> emailMessagereplyTo = null, WorkflowValue<emailMessageimportanceInput> emailMessageimportance = null)
        {
            WorkflowValue.Validate(emailMessageto, nameof(emailMessageto), required: true);
            WorkflowValue.Validate(emailMessagesubject, nameof(emailMessagesubject), required: true);
            WorkflowValue.Validate(emailMessagebody, nameof(emailMessagebody), required: true);
            WorkflowValue.Validate(emailMessagefromSendAs, nameof(emailMessagefromSendAs), required: false);
            WorkflowValue.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            WorkflowValue.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            WorkflowValue.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            WorkflowValue.Validate(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            WorkflowValue.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
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

    public class OutlookTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCalendarGetOnChangedItems))]
        public IBodyWorkflowTrigger<CalendarEventListWithActionType> CalendarGetOnChangedItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> incomingDays = null, [WorkflowExpression] Func<int> pastDays = null, string triggerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventListWithActionType> __BuildCalendarGetOnChangedItems(WorkflowValue<string> table, WorkflowValue<int> incomingDays = null, WorkflowValue<int> pastDays = null, string triggerName = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(incomingDays, nameof(incomingDays), required: false);
            WorkflowValue.Validate(pastDays, nameof(pastDays), required: false);
            return new DeferredBodyTrigger<CalendarEventListWithActionType>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/datasets/calendars/v2/tables/{0}/onchangeditems"
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
                        Template = "/{0}/EventSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<CalendarEventListWithActionType>(input);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCalendarGetOnNewItems))]
        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnNewItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventListClientReceive> __BuildCalendarGetOnNewItems(WorkflowValue<string> table, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCalendarGetOnUpdatedItems))]
        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnUpdatedItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventListClientReceive> __BuildCalendarGetOnUpdatedItems(WorkflowValue<string> table, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnFlaggedEmail))]
        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnFlaggedEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> __BuildOnFlaggedEmail(WorkflowValue<string> folderPath = null, WorkflowValue<string> to = null, WorkflowValue<string> cc = null, WorkflowValue<string> toOrCc = null, WorkflowValue<string> from = null, WorkflowValue<importanceInput> importance = null, WorkflowValue<bool> fetchOnlyWithAttachment = null, WorkflowValue<bool> includeAttachments = null, WorkflowValue<string> subjectFilter = null, string triggerName = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            WorkflowValue.Validate(cc, nameof(cc), required: false);
            WorkflowValue.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(importance, nameof(importance), required: false);
            WorkflowValue.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowValue.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowValue.Validate(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseClientReceiveMessage>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnFlaggedEmail"
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
                        Template = "/FlaggedMailSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewEmail))]
        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> __BuildOnNewEmail(WorkflowValue<string> folderPath = null, WorkflowValue<string> to = null, WorkflowValue<string> cc = null, WorkflowValue<string> toOrCc = null, WorkflowValue<string> from = null, WorkflowValue<importanceInput> importance = null, WorkflowValue<bool> fetchOnlyWithAttachment = null, WorkflowValue<bool> includeAttachments = null, WorkflowValue<string> subjectFilter = null, string triggerName = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            WorkflowValue.Validate(cc, nameof(cc), required: false);
            WorkflowValue.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(importance, nameof(importance), required: false);
            WorkflowValue.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowValue.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowValue.Validate(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseClientReceiveMessage>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnNewEmail"
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
                        Template = "/MailSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewMentionMeEmail))]
        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewMentionMeEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> __BuildOnNewMentionMeEmail(WorkflowValue<string> folderPath = null, WorkflowValue<string> to = null, WorkflowValue<string> cc = null, WorkflowValue<string> toOrCc = null, WorkflowValue<string> from = null, WorkflowValue<importanceInput> importance = null, WorkflowValue<bool> fetchOnlyWithAttachment = null, WorkflowValue<bool> includeAttachments = null, WorkflowValue<string> subjectFilter = null, string triggerName = null)
        {
            WorkflowValue.Validate(folderPath, nameof(folderPath), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            WorkflowValue.Validate(cc, nameof(cc), required: false);
            WorkflowValue.Validate(toOrCc, nameof(toOrCc), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(importance, nameof(importance), required: false);
            WorkflowValue.Validate(fetchOnlyWithAttachment, nameof(fetchOnlyWithAttachment), required: false);
            WorkflowValue.Validate(includeAttachments, nameof(includeAttachments), required: false);
            WorkflowValue.Validate(subjectFilter, nameof(subjectFilter), required: false);
            return new DeferredBodyTrigger<TriggerBatchResponseClientReceiveMessage>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnNewMentionMeEmail"
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
                        Template = "/MentionMeMailSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpcomingEvents))]
        public IBodyWorkflowTrigger<CalendarEventListClientReceive> OnUpcomingEvents([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> lookAheadTimeInMinutes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CalendarEventListClientReceive> __BuildOnUpcomingEvents(WorkflowValue<string> table, WorkflowValue<int> lookAheadTimeInMinutes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(lookAheadTimeInMinutes, nameof(lookAheadTimeInMinutes), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = "/v2/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = ExpressionConverter.Convert(table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(lookAheadTimeInMinutes);
                return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class ClientReceiveMessage
    {
        public string From { get; set; }
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }

        [JsonProperty("Bcc")]
        public string BCC { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Importance { get; set; }
        public string BodyPreview { get; set; }
        public bool HasAttachment { get; set; }

        [JsonProperty("Id")]
        public string MessageId { get; set; }
        public string InternetMessageId { get; set; }
        public string ConversationId { get; set; }

        [JsonProperty("DateTimeReceived")]
        public string ReceivedTime { get; set; }
        public bool IsRead { get; set; }
        public ClientReceiveFileAttachment[] Attachments { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
    }

    public class ClientReceiveFileAttachment
    {
        [JsonProperty("Id")]
        public string AttachmentId { get; set; }
        public string Name { get; set; }

        [JsonProperty("ContentBytes")]
        public string Content { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public bool IsInline { get; set; }
        public string LastModifiedDateTime { get; set; }
        public string ContentId { get; set; }
    }

    public class ClientReceiveMessageStringEnums
    {
        public ClientReceiveMessageStringEnumsImportanceType Importance { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }

        [JsonProperty("Bcc")]
        public string BCC { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string BodyPreview { get; set; }
        public bool HasAttachment { get; set; }

        [JsonProperty("Id")]
        public string MessageId { get; set; }
        public string InternetMessageId { get; set; }
        public string ConversationId { get; set; }

        [JsonProperty("DateTimeReceived")]
        public string ReceivedTime { get; set; }
        public bool IsRead { get; set; }
        public ClientReceiveFileAttachment[] Attachments { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
    }

    public enum ClientReceiveMessageStringEnumsImportanceType
    {
        Low,
        Normal,
        High
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

    public class ClientSendAttachment
    {
        public string Name { get; set; }

        [JsonProperty("ContentBytes")]
        public string Content { get; set; }
    }

    public enum approvalEmailSubscriptionmessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class EntityListResponseTable
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class EntityListResponseContactResponse
    {
        [JsonProperty("value")]
        public ContactResponse[] Value { get; set; }
    }

    public class ContactResponse
    {
        public string GivenName { get; set; }
        public string[] HomePhones { get; set; }
        public string Id { get; set; }
        public string ParentFolderId { get; set; }
        public string Birthday { get; set; }
        public string FileAs { get; set; }
        public string DisplayName { get; set; }
        public string Initials { get; set; }
        public string MiddleName { get; set; }

        [JsonProperty("NickName")]
        public string Nickname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Generation { get; set; }
        public EmailAddress[] EmailAddresses { get; set; }

        [JsonProperty("ImAddresses")]
        public string[] IMAddresses { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string OfficeLocation { get; set; }
        public string Profession { get; set; }
        public string BusinessHomePage { get; set; }
        public string AssistantName { get; set; }
        public string Manager { get; set; }
        public string[] BusinessPhones { get; set; }

        [JsonProperty("MobilePhone1")]
        public string MobilePhone { get; set; }
        public PhysicalAddress HomeAddress { get; set; }
        public PhysicalAddress BusinessAddress { get; set; }
        public PhysicalAddress OtherAddress { get; set; }
        public string YomiCompanyName { get; set; }
        public string YomiGivenName { get; set; }
        public string YomiSurname { get; set; }
        public string[] Categories { get; set; }
        public string ChangeKey { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
    }

    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class PhysicalAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryOrRegion { get; set; }
        public string PostalCode { get; set; }
    }

    public enum responseInput
    {
        Accept,
        [EnumMember(Value = "Tentatively Accept")]
        TentativelyAccept,
        Decline
    }

    public class CalendarEventClientReceiveStringEnums
    {
        public CalendarEventClientReceiveStringEnumsImportanceType Importance { get; set; }
        public CalendarEventClientReceiveStringEnumsResponseTypeType ResponseType { get; set; }
        public CalendarEventClientReceiveStringEnumsRecurrenceType Recurrence { get; set; }
        public CalendarEventClientReceiveStringEnumsShowAsType ShowAs { get; set; }
        public string Subject { get; set; }

        [JsonProperty("Start")]
        public string StartTime { get; set; }

        [JsonProperty("End")]
        public string EndTime { get; set; }
        public string ResponseTime { get; set; }

        [JsonProperty("ICalUId")]
        public string EventUniqueID { get; set; }
        public string Id { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
        public string Location { get; set; }

        [JsonProperty("IsAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public enum CalendarEventClientReceiveStringEnumsImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum CalendarEventClientReceiveStringEnumsResponseTypeType
    {
        None,
        Organizer,
        TentativelyAccepted,
        Accepted,
        Declined,
        NotResponded
    }

    public enum CalendarEventClientReceiveStringEnumsRecurrenceType
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum CalendarEventClientReceiveStringEnumsShowAsType
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
    }

    public class CalendarEventListClientReceive
    {
        [JsonProperty("value")]
        public CalendarEventClientReceive[] Value { get; set; }
    }

    public class CalendarEventClientReceive
    {
        public string Subject { get; set; }

        [JsonProperty("Start")]
        public string StartTime { get; set; }

        [JsonProperty("End")]
        public string EndTime { get; set; }
        public int ShowAs { get; set; }
        public int Recurrence { get; set; }
        public int ResponseType { get; set; }
        public string ResponseTime { get; set; }

        [JsonProperty("ICalUId")]
        public string EventUniqueID { get; set; }
        public int Importance { get; set; }
        public string Id { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
        public string Location { get; set; }

        [JsonProperty("IsAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
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
        Low,
        Normal,
        High
    }

    public enum itemrecurrenceInput
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum itemshowAsInput
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
    }

    public class BatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
    }

    public enum importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public class EntityListResponseCalendarEventClientReceiveStringEnums
    {
        [JsonProperty("value")]
        public CalendarEventClientReceiveStringEnums[] Value { get; set; }
    }

    public enum replyParametersimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum emailMessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class CalendarEventListWithActionType
    {
        [JsonProperty("value")]
        public CalendarEventClientWithActionType[] Value { get; set; }
    }

    public class CalendarEventClientWithActionType
    {
        public CalendarEventClientWithActionTypeActionTypeType ActionType { get; set; }
        public bool IsAdded { get; set; }
        public bool IsUpdated { get; set; }
        public string Subject { get; set; }

        [JsonProperty("Start")]
        public string StartTime { get; set; }

        [JsonProperty("End")]
        public string EndTime { get; set; }
        public int ShowAs { get; set; }
        public int Recurrence { get; set; }
        public int ResponseType { get; set; }
        public string ResponseTime { get; set; }

        [JsonProperty("ICalUId")]
        public string EventUniqueID { get; set; }
        public int Importance { get; set; }
        public string Id { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
        public string Location { get; set; }

        [JsonProperty("IsAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public enum CalendarEventClientWithActionTypeActionTypeType
    {
        [EnumMember(Value = "added")]
        Added,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "deleted")]
        Deleted
    }

    public class TriggerBatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Outlook;

    public partial class WorkflowManagedActions
    {
        public OutlookActions Outlook(string connectionId) => new OutlookActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OutlookTriggers Outlook(string connectionId) => new OutlookTriggers(connectionId);
    }
}
