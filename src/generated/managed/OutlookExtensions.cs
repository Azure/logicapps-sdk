//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Outlook
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OutlookActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessage> GetEmail(Expression<Func<string>> messageId, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_internetMessageId = WorkflowExpression.Compile(internetMessageId, nameof(internetMessageId), required: false);
            return new DeferredBodyAction<ClientReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_internetMessageId != null)
                    callPayload.Queries["internetMessageId"] = ExpressionConverter.Convert(__workflow_internetMessageId);
                return new ApiConnectionAction<ClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessageStringEnums> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<ClientReceiveMessageStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/Move/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionAction<ClientReceiveMessageStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction Flag(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/Flag/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction MarkAsRead(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/MarkAsRead/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<string> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}/Attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<string>> optionsEmailSubscriptionmessageto, Expression<Func<string>> optionsEmailSubscriptionmessagesubject = null, Expression<Func<string>> optionsEmailSubscriptionmessageuserOptions = null, Expression<Func<string>> optionsEmailSubscriptionmessageheaderText = null, Expression<Func<string>> optionsEmailSubscriptionmessageselectionText = null, Expression<Func<string>> optionsEmailSubscriptionmessagebody = null, Expression<Func<optionsEmailSubscriptionmessageimportanceInput>> optionsEmailSubscriptionmessageimportance = null, Expression<Func<ClientSendAttachment[]>> optionsEmailSubscriptionmessageattachments = null, Expression<Func<bool>> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessagehideHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
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
        public IWorkflowAction CalendarDeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
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
        public IBodyWorkflowAction<EntityListResponseContactResponse> ContactGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EntityListResponseContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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
                return new ApiConnectionAction<EntityListResponseContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPostItem(Expression<Func<string>> table, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddress[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
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
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (__workflow_itemid != null)
                {
                    item["Id"] = ExpressionConverter.ConvertO(__workflow_itemid);
                    itempropCount++;
                }

                if (__workflow_itemparentFolderId != null)
                {
                    item["ParentFolderId"] = ExpressionConverter.ConvertO(__workflow_itemparentFolderId);
                    itempropCount++;
                }

                if (__workflow_itembirthday != null)
                {
                    item["Birthday"] = ExpressionConverter.ConvertO(__workflow_itembirthday);
                    itempropCount++;
                }

                if (__workflow_itemfileAs != null)
                {
                    item["FileAs"] = ExpressionConverter.ConvertO(__workflow_itemfileAs);
                    itempropCount++;
                }

                if (__workflow_itemdisplayName != null)
                {
                    item["DisplayName"] = ExpressionConverter.ConvertO(__workflow_itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["GivenName"] = ExpressionConverter.ConvertO(__workflow_itemgivenName);
                if (__workflow_iteminitials != null)
                {
                    item["Initials"] = ExpressionConverter.ConvertO(__workflow_iteminitials);
                    itempropCount++;
                }

                if (__workflow_itemmiddleName != null)
                {
                    item["MiddleName"] = ExpressionConverter.ConvertO(__workflow_itemmiddleName);
                    itempropCount++;
                }

                if (__workflow_itemnickname != null)
                {
                    item["NickName"] = ExpressionConverter.ConvertO(__workflow_itemnickname);
                    itempropCount++;
                }

                if (__workflow_itemsurname != null)
                {
                    item["Surname"] = ExpressionConverter.ConvertO(__workflow_itemsurname);
                    itempropCount++;
                }

                if (__workflow_itemtitle != null)
                {
                    item["Title"] = ExpressionConverter.ConvertO(__workflow_itemtitle);
                    itempropCount++;
                }

                if (__workflow_itemgeneration != null)
                {
                    item["Generation"] = ExpressionConverter.ConvertO(__workflow_itemgeneration);
                    itempropCount++;
                }

                if (__workflow_itememailAddresses != null)
                {
                    item["EmailAddresses"] = ExpressionConverter.ConvertO(__workflow_itememailAddresses);
                    itempropCount++;
                }

                if (__workflow_itemiMAddresses != null)
                {
                    item["ImAddresses"] = ExpressionConverter.ConvertO(__workflow_itemiMAddresses);
                    itempropCount++;
                }

                if (__workflow_itemjobTitle != null)
                {
                    item["JobTitle"] = ExpressionConverter.ConvertO(__workflow_itemjobTitle);
                    itempropCount++;
                }

                if (__workflow_itemcompanyName != null)
                {
                    item["CompanyName"] = ExpressionConverter.ConvertO(__workflow_itemcompanyName);
                    itempropCount++;
                }

                if (__workflow_itemdepartment != null)
                {
                    item["Department"] = ExpressionConverter.ConvertO(__workflow_itemdepartment);
                    itempropCount++;
                }

                if (__workflow_itemofficeLocation != null)
                {
                    item["OfficeLocation"] = ExpressionConverter.ConvertO(__workflow_itemofficeLocation);
                    itempropCount++;
                }

                if (__workflow_itemprofession != null)
                {
                    item["Profession"] = ExpressionConverter.ConvertO(__workflow_itemprofession);
                    itempropCount++;
                }

                if (__workflow_itembusinessHomePage != null)
                {
                    item["BusinessHomePage"] = ExpressionConverter.ConvertO(__workflow_itembusinessHomePage);
                    itempropCount++;
                }

                if (__workflow_itemassistantName != null)
                {
                    item["AssistantName"] = ExpressionConverter.ConvertO(__workflow_itemassistantName);
                    itempropCount++;
                }

                if (__workflow_itemmanager != null)
                {
                    item["Manager"] = ExpressionConverter.ConvertO(__workflow_itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["HomePhones"] = ExpressionConverter.ConvertO(__workflow_itemhomePhones);
                if (__workflow_itembusinessPhones != null)
                {
                    item["BusinessPhones"] = ExpressionConverter.ConvertO(__workflow_itembusinessPhones);
                    itempropCount++;
                }

                if (__workflow_itemmobilePhone != null)
                {
                    item["MobilePhone1"] = ExpressionConverter.ConvertO(__workflow_itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    homeAddressObject["Street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    homeAddressObject["City"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    homeAddressObject["State"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["PostalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["HomeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    businessAddressObject["Street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    businessAddressObject["City"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    businessAddressObject["State"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["PostalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["BusinessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    otherAddressObject["Street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    otherAddressObject["City"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    otherAddressObject["State"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["PostalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["OtherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (__workflow_itemyomiCompanyName != null)
                {
                    item["YomiCompanyName"] = ExpressionConverter.ConvertO(__workflow_itemyomiCompanyName);
                    itempropCount++;
                }

                if (__workflow_itemyomiGivenName != null)
                {
                    item["YomiGivenName"] = ExpressionConverter.ConvertO(__workflow_itemyomiGivenName);
                    itempropCount++;
                }

                if (__workflow_itemyomiSurname != null)
                {
                    item["YomiSurname"] = ExpressionConverter.ConvertO(__workflow_itemyomiSurname);
                    itempropCount++;
                }

                if (__workflow_itemcategories != null)
                {
                    item["Categories"] = ExpressionConverter.ConvertO(__workflow_itemcategories);
                    itempropCount++;
                }

                if (__workflow_itemchangeKey != null)
                {
                    item["ChangeKey"] = ExpressionConverter.ConvertO(__workflow_itemchangeKey);
                    itempropCount++;
                }

                if (__workflow_itemcreatedTime != null)
                {
                    item["DateTimeCreated"] = ExpressionConverter.ConvertO(__workflow_itemcreatedTime);
                    itempropCount++;
                }

                if (__workflow_itemlastModifiedTime != null)
                {
                    item["DateTimeLastModified"] = ExpressionConverter.ConvertO(__workflow_itemlastModifiedTime);
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
        public IBodyWorkflowAction<ContactResponse> ContactGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ContactDeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddress[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
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
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (__workflow_itemid != null)
                {
                    item["Id"] = ExpressionConverter.ConvertO(__workflow_itemid);
                    itempropCount++;
                }

                if (__workflow_itemparentFolderId != null)
                {
                    item["ParentFolderId"] = ExpressionConverter.ConvertO(__workflow_itemparentFolderId);
                    itempropCount++;
                }

                if (__workflow_itembirthday != null)
                {
                    item["Birthday"] = ExpressionConverter.ConvertO(__workflow_itembirthday);
                    itempropCount++;
                }

                if (__workflow_itemfileAs != null)
                {
                    item["FileAs"] = ExpressionConverter.ConvertO(__workflow_itemfileAs);
                    itempropCount++;
                }

                if (__workflow_itemdisplayName != null)
                {
                    item["DisplayName"] = ExpressionConverter.ConvertO(__workflow_itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["GivenName"] = ExpressionConverter.ConvertO(__workflow_itemgivenName);
                if (__workflow_iteminitials != null)
                {
                    item["Initials"] = ExpressionConverter.ConvertO(__workflow_iteminitials);
                    itempropCount++;
                }

                if (__workflow_itemmiddleName != null)
                {
                    item["MiddleName"] = ExpressionConverter.ConvertO(__workflow_itemmiddleName);
                    itempropCount++;
                }

                if (__workflow_itemnickname != null)
                {
                    item["NickName"] = ExpressionConverter.ConvertO(__workflow_itemnickname);
                    itempropCount++;
                }

                if (__workflow_itemsurname != null)
                {
                    item["Surname"] = ExpressionConverter.ConvertO(__workflow_itemsurname);
                    itempropCount++;
                }

                if (__workflow_itemtitle != null)
                {
                    item["Title"] = ExpressionConverter.ConvertO(__workflow_itemtitle);
                    itempropCount++;
                }

                if (__workflow_itemgeneration != null)
                {
                    item["Generation"] = ExpressionConverter.ConvertO(__workflow_itemgeneration);
                    itempropCount++;
                }

                if (__workflow_itememailAddresses != null)
                {
                    item["EmailAddresses"] = ExpressionConverter.ConvertO(__workflow_itememailAddresses);
                    itempropCount++;
                }

                if (__workflow_itemiMAddresses != null)
                {
                    item["ImAddresses"] = ExpressionConverter.ConvertO(__workflow_itemiMAddresses);
                    itempropCount++;
                }

                if (__workflow_itemjobTitle != null)
                {
                    item["JobTitle"] = ExpressionConverter.ConvertO(__workflow_itemjobTitle);
                    itempropCount++;
                }

                if (__workflow_itemcompanyName != null)
                {
                    item["CompanyName"] = ExpressionConverter.ConvertO(__workflow_itemcompanyName);
                    itempropCount++;
                }

                if (__workflow_itemdepartment != null)
                {
                    item["Department"] = ExpressionConverter.ConvertO(__workflow_itemdepartment);
                    itempropCount++;
                }

                if (__workflow_itemofficeLocation != null)
                {
                    item["OfficeLocation"] = ExpressionConverter.ConvertO(__workflow_itemofficeLocation);
                    itempropCount++;
                }

                if (__workflow_itemprofession != null)
                {
                    item["Profession"] = ExpressionConverter.ConvertO(__workflow_itemprofession);
                    itempropCount++;
                }

                if (__workflow_itembusinessHomePage != null)
                {
                    item["BusinessHomePage"] = ExpressionConverter.ConvertO(__workflow_itembusinessHomePage);
                    itempropCount++;
                }

                if (__workflow_itemassistantName != null)
                {
                    item["AssistantName"] = ExpressionConverter.ConvertO(__workflow_itemassistantName);
                    itempropCount++;
                }

                if (__workflow_itemmanager != null)
                {
                    item["Manager"] = ExpressionConverter.ConvertO(__workflow_itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["HomePhones"] = ExpressionConverter.ConvertO(__workflow_itemhomePhones);
                if (__workflow_itembusinessPhones != null)
                {
                    item["BusinessPhones"] = ExpressionConverter.ConvertO(__workflow_itembusinessPhones);
                    itempropCount++;
                }

                if (__workflow_itemmobilePhone != null)
                {
                    item["MobilePhone1"] = ExpressionConverter.ConvertO(__workflow_itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    homeAddressObject["Street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    homeAddressObject["City"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    homeAddressObject["State"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["PostalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["HomeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    businessAddressObject["Street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    businessAddressObject["City"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    businessAddressObject["State"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["PostalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["BusinessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (__workflow_itemhomeAddressstreet != null)
                {
                    otherAddressObject["Street"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscity != null)
                {
                    otherAddressObject["City"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddressstate != null)
                {
                    otherAddressObject["State"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (__workflow_itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["PostalCode"] = ExpressionConverter.ConvertO(__workflow_itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["OtherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (__workflow_itemyomiCompanyName != null)
                {
                    item["YomiCompanyName"] = ExpressionConverter.ConvertO(__workflow_itemyomiCompanyName);
                    itempropCount++;
                }

                if (__workflow_itemyomiGivenName != null)
                {
                    item["YomiGivenName"] = ExpressionConverter.ConvertO(__workflow_itemyomiGivenName);
                    itempropCount++;
                }

                if (__workflow_itemyomiSurname != null)
                {
                    item["YomiSurname"] = ExpressionConverter.ConvertO(__workflow_itemyomiSurname);
                    itempropCount++;
                }

                if (__workflow_itemcategories != null)
                {
                    item["Categories"] = ExpressionConverter.ConvertO(__workflow_itemcategories);
                    itempropCount++;
                }

                if (__workflow_itemchangeKey != null)
                {
                    item["ChangeKey"] = ExpressionConverter.ConvertO(__workflow_itemchangeKey);
                    itempropCount++;
                }

                if (__workflow_itemcreatedTime != null)
                {
                    item["DateTimeCreated"] = ExpressionConverter.ConvertO(__workflow_itemcreatedTime);
                    itempropCount++;
                }

                if (__workflow_itemlastModifiedTime != null)
                {
                    item["DateTimeLastModified"] = ExpressionConverter.ConvertO(__workflow_itemlastModifiedTime);
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
        public IWorkflowAction RespondToEvent(Expression<Func<string>> eventId, Expression<Func<responseInput>> response, Expression<Func<string>> bodycomment = null, Expression<Func<bool>> bodysendResponse = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_response = WorkflowExpression.Compile(response, nameof(response), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodysendResponse = WorkflowExpression.Compile(bodysendResponse, nameof(bodysendResponse), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/events/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_response, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ForwardEmail(Expression<Func<string>> messageId, Expression<Func<string>> bodyto, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/messages/{0}/forward", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventListClientReceive> CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
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
                return new ApiConnectionAction<CalendarEventListClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone = null, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<string>> itemrecurrenceEndTime = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_itemsubject = WorkflowExpression.Compile(itemsubject, nameof(itemsubject), required: true);
            var __workflow_itemstartTime = WorkflowExpression.Compile(itemstartTime, nameof(itemstartTime), required: true);
            var __workflow_itemendTime = WorkflowExpression.Compile(itemendTime, nameof(itemendTime), required: true);
            var __workflow_itemtimeZone = WorkflowExpression.Compile(itemtimeZone, nameof(itemtimeZone), required: false);
            var __workflow_itemrequiredAttendees = WorkflowExpression.Compile(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            var __workflow_itemoptionalAttendees = WorkflowExpression.Compile(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            var __workflow_itemresourceAttendees = WorkflowExpression.Compile(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            var __workflow_itembody = WorkflowExpression.Compile(itembody, nameof(itembody), required: false);
            var __workflow_itemlocation = WorkflowExpression.Compile(itemlocation, nameof(itemlocation), required: false);
            var __workflow_itemimportance = WorkflowExpression.Compile(itemimportance, nameof(itemimportance), required: false);
            var __workflow_itemisAllDayEvent = WorkflowExpression.Compile(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            var __workflow_itemrecurrence = WorkflowExpression.Compile(itemrecurrence, nameof(itemrecurrence), required: false);
            var __workflow_itemrecurrenceEndTime = WorkflowExpression.Compile(itemrecurrenceEndTime, nameof(itemrecurrenceEndTime), required: false);
            var __workflow_itemnumberOfOccurrences = WorkflowExpression.Compile(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            var __workflow_itemreminder = WorkflowExpression.Compile(itemreminder, nameof(itemreminder), required: false);
            var __workflow_itemshowAs = WorkflowExpression.Compile(itemshowAs, nameof(itemshowAs), required: false);
            var __workflow_itemresponseRequested = WorkflowExpression.Compile(itemresponseRequested, nameof(itemresponseRequested), required: false);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["Subject"] = ExpressionConverter.ConvertO(__workflow_itemsubject);
                itempropCount++;
                item["Start"] = ExpressionConverter.ConvertO(__workflow_itemstartTime);
                itempropCount++;
                item["End"] = ExpressionConverter.ConvertO(__workflow_itemendTime);
                if (__workflow_itemtimeZone != null)
                {
                    item["TimeZone"] = ExpressionConverter.ConvertO(__workflow_itemtimeZone);
                    itempropCount++;
                }

                if (__workflow_itemrequiredAttendees != null)
                {
                    item["RequiredAttendees"] = ExpressionConverter.ConvertO(__workflow_itemrequiredAttendees);
                    itempropCount++;
                }

                if (__workflow_itemoptionalAttendees != null)
                {
                    item["OptionalAttendees"] = ExpressionConverter.ConvertO(__workflow_itemoptionalAttendees);
                    itempropCount++;
                }

                if (__workflow_itemresourceAttendees != null)
                {
                    item["ResourceAttendees"] = ExpressionConverter.ConvertO(__workflow_itemresourceAttendees);
                    itempropCount++;
                }

                if (__workflow_itembody != null)
                {
                    item["Body"] = ExpressionConverter.ConvertO(__workflow_itembody);
                    itempropCount++;
                }

                if (__workflow_itemlocation != null)
                {
                    item["Location"] = ExpressionConverter.ConvertO(__workflow_itemlocation);
                    itempropCount++;
                }

                if (__workflow_itemimportance != null)
                {
                    item["Importance"] = ExpressionConverter.ConvertO(__workflow_itemimportance);
                    itempropCount++;
                }

                if (__workflow_itemisAllDayEvent != null)
                {
                    item["IsAllDay"] = ExpressionConverter.ConvertO(__workflow_itemisAllDayEvent);
                    itempropCount++;
                }

                if (__workflow_itemrecurrence != null)
                {
                    item["Recurrence"] = ExpressionConverter.ConvertO(__workflow_itemrecurrence);
                    itempropCount++;
                }

                if (__workflow_itemrecurrenceEndTime != null)
                {
                    item["RecurrenceEnd"] = ExpressionConverter.ConvertO(__workflow_itemrecurrenceEndTime);
                    itempropCount++;
                }

                if (__workflow_itemnumberOfOccurrences != null)
                {
                    item["NumberOfOccurrences"] = ExpressionConverter.ConvertO(__workflow_itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (__workflow_itemreminder != null)
                {
                    item["Reminder"] = ExpressionConverter.ConvertO(__workflow_itemreminder);
                    itempropCount++;
                }

                if (__workflow_itemshowAs != null)
                {
                    item["ShowAs"] = ExpressionConverter.ConvertO(__workflow_itemshowAs);
                    itempropCount++;
                }

                if (__workflow_itemresponseRequested != null)
                {
                    item["ResponseRequested"] = ExpressionConverter.ConvertO(__workflow_itemresponseRequested);
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
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPostItem(Expression<Func<string>> table, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone = null, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<string>> itemrecurrenceEndTime = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_itemsubject = WorkflowExpression.Compile(itemsubject, nameof(itemsubject), required: true);
            var __workflow_itemstartTime = WorkflowExpression.Compile(itemstartTime, nameof(itemstartTime), required: true);
            var __workflow_itemendTime = WorkflowExpression.Compile(itemendTime, nameof(itemendTime), required: true);
            var __workflow_itemtimeZone = WorkflowExpression.Compile(itemtimeZone, nameof(itemtimeZone), required: false);
            var __workflow_itemrequiredAttendees = WorkflowExpression.Compile(itemrequiredAttendees, nameof(itemrequiredAttendees), required: false);
            var __workflow_itemoptionalAttendees = WorkflowExpression.Compile(itemoptionalAttendees, nameof(itemoptionalAttendees), required: false);
            var __workflow_itemresourceAttendees = WorkflowExpression.Compile(itemresourceAttendees, nameof(itemresourceAttendees), required: false);
            var __workflow_itembody = WorkflowExpression.Compile(itembody, nameof(itembody), required: false);
            var __workflow_itemlocation = WorkflowExpression.Compile(itemlocation, nameof(itemlocation), required: false);
            var __workflow_itemimportance = WorkflowExpression.Compile(itemimportance, nameof(itemimportance), required: false);
            var __workflow_itemisAllDayEvent = WorkflowExpression.Compile(itemisAllDayEvent, nameof(itemisAllDayEvent), required: false);
            var __workflow_itemrecurrence = WorkflowExpression.Compile(itemrecurrence, nameof(itemrecurrence), required: false);
            var __workflow_itemrecurrenceEndTime = WorkflowExpression.Compile(itemrecurrenceEndTime, nameof(itemrecurrenceEndTime), required: false);
            var __workflow_itemnumberOfOccurrences = WorkflowExpression.Compile(itemnumberOfOccurrences, nameof(itemnumberOfOccurrences), required: false);
            var __workflow_itemreminder = WorkflowExpression.Compile(itemreminder, nameof(itemreminder), required: false);
            var __workflow_itemshowAs = WorkflowExpression.Compile(itemshowAs, nameof(itemshowAs), required: false);
            var __workflow_itemresponseRequested = WorkflowExpression.Compile(itemresponseRequested, nameof(itemresponseRequested), required: false);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["Subject"] = ExpressionConverter.ConvertO(__workflow_itemsubject);
                itempropCount++;
                item["Start"] = ExpressionConverter.ConvertO(__workflow_itemstartTime);
                itempropCount++;
                item["End"] = ExpressionConverter.ConvertO(__workflow_itemendTime);
                if (__workflow_itemtimeZone != null)
                {
                    item["TimeZone"] = ExpressionConverter.ConvertO(__workflow_itemtimeZone);
                    itempropCount++;
                }

                if (__workflow_itemrequiredAttendees != null)
                {
                    item["RequiredAttendees"] = ExpressionConverter.ConvertO(__workflow_itemrequiredAttendees);
                    itempropCount++;
                }

                if (__workflow_itemoptionalAttendees != null)
                {
                    item["OptionalAttendees"] = ExpressionConverter.ConvertO(__workflow_itemoptionalAttendees);
                    itempropCount++;
                }

                if (__workflow_itemresourceAttendees != null)
                {
                    item["ResourceAttendees"] = ExpressionConverter.ConvertO(__workflow_itemresourceAttendees);
                    itempropCount++;
                }

                if (__workflow_itembody != null)
                {
                    item["Body"] = ExpressionConverter.ConvertO(__workflow_itembody);
                    itempropCount++;
                }

                if (__workflow_itemlocation != null)
                {
                    item["Location"] = ExpressionConverter.ConvertO(__workflow_itemlocation);
                    itempropCount++;
                }

                if (__workflow_itemimportance != null)
                {
                    item["Importance"] = ExpressionConverter.ConvertO(__workflow_itemimportance);
                    itempropCount++;
                }

                if (__workflow_itemisAllDayEvent != null)
                {
                    item["IsAllDay"] = ExpressionConverter.ConvertO(__workflow_itemisAllDayEvent);
                    itempropCount++;
                }

                if (__workflow_itemrecurrence != null)
                {
                    item["Recurrence"] = ExpressionConverter.ConvertO(__workflow_itemrecurrence);
                    itempropCount++;
                }

                if (__workflow_itemrecurrenceEndTime != null)
                {
                    item["RecurrenceEnd"] = ExpressionConverter.ConvertO(__workflow_itemrecurrenceEndTime);
                    itempropCount++;
                }

                if (__workflow_itemnumberOfOccurrences != null)
                {
                    item["NumberOfOccurrences"] = ExpressionConverter.ConvertO(__workflow_itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (__workflow_itemreminder != null)
                {
                    item["Reminder"] = ExpressionConverter.ConvertO(__workflow_itemreminder);
                    itempropCount++;
                }

                if (__workflow_itemshowAs != null)
                {
                    item["ShowAs"] = ExpressionConverter.ConvertO(__workflow_itemshowAs);
                    itempropCount++;
                }

                if (__workflow_itemresponseRequested != null)
                {
                    item["ResponseRequested"] = ExpressionConverter.ConvertO(__workflow_itemresponseRequested);
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
        public IBodyWorkflowAction<BatchResponseClientReceiveMessage> GetEmails(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
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
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_searchQuery = WorkflowExpression.Compile(searchQuery, nameof(searchQuery), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<BatchResponseClientReceiveMessage>(() =>
            {
                var apiCallPath = "/v2/Mail";
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
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                if (__workflow_searchQuery != null)
                    callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(__workflow_searchQuery);
                callPayload.Queries["top"] = Convert.ToString(10);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<BatchResponseClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> GetEventsCalendarView(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeOffset, Expression<Func<string>> endDateTimeOffset, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_startDateTimeOffset = WorkflowExpression.Compile(startDateTimeOffset, nameof(startDateTimeOffset), required: true);
            var __workflow_endDateTimeOffset = WorkflowExpression.Compile(endDateTimeOffset, nameof(endDateTimeOffset), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<EntityListResponseCalendarEventClientReceiveStringEnums>(() =>
            {
                var apiCallPath = "/datasets/calendars/v2/tables/items/calendarview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["calendarId"] = ExpressionConverter.Convert(__workflow_calendarId);
                callPayload.Queries["startDateTimeOffset"] = ExpressionConverter.Convert(__workflow_startDateTimeOffset);
                callPayload.Queries["endDateTimeOffset"] = ExpressionConverter.Convert(__workflow_endDateTimeOffset);
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
                return new ApiConnectionAction<EntityListResponseCalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ReplyTo(Expression<Func<string>> messageId, Expression<Func<string>> replyParametersto = null, Expression<Func<string>> replyParameterscC = null, Expression<Func<string>> replyParametersbCC = null, Expression<Func<string>> replyParameterssubject = null, Expression<Func<string>> replyParametersbody = null, Expression<Func<bool>> replyParametersreplyAll = null, Expression<Func<replyParametersimportanceInput>> replyParametersimportance = null, Expression<Func<ClientSendAttachment[]>> replyParametersattachments = null)
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
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction SendEmail(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagefromSendAs = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
        {
            var __workflow_emailMessageto = WorkflowExpression.Compile(emailMessageto, nameof(emailMessageto), required: true);
            var __workflow_emailMessagesubject = WorkflowExpression.Compile(emailMessagesubject, nameof(emailMessagesubject), required: true);
            var __workflow_emailMessagebody = WorkflowExpression.Compile(emailMessagebody, nameof(emailMessagebody), required: true);
            var __workflow_emailMessagefromSendAs = WorkflowExpression.Compile(emailMessagefromSendAs, nameof(emailMessagefromSendAs), required: false);
            var __workflow_emailMessagecC = WorkflowExpression.Compile(emailMessagecC, nameof(emailMessagecC), required: false);
            var __workflow_emailMessagebCC = WorkflowExpression.Compile(emailMessagebCC, nameof(emailMessagebCC), required: false);
            var __workflow_emailMessageattachments = WorkflowExpression.Compile(emailMessageattachments, nameof(emailMessageattachments), required: false);
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
            });
        }
    }

    public class OutlookTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CalendarEventListWithActionType> CalendarGetOnChangedItems(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_incomingDays = WorkflowExpression.Compile(incomingDays, nameof(incomingDays), required: false);
            var __workflow_pastDays = WorkflowExpression.Compile(pastDays, nameof(pastDays), required: false);
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
                        Template = "/{0}/EventSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<CalendarEventListWithActionType>(input);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnNewItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnFlaggedEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
                        Template = "/FlaggedMailSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
                        Template = "/MailSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewMentionMeEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
                        Template = "/MentionMeMailSubscriptionPoke/$subscriptions"
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

                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> OnUpcomingEvents(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null, FlowRecurrence recurrence = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_lookAheadTimeInMinutes = WorkflowExpression.Compile(lookAheadTimeInMinutes, nameof(lookAheadTimeInMinutes), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive>(() =>
            {
                var apiCallPath = "/v2/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = ExpressionConverter.Convert(__workflow_table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (__workflow_lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(__workflow_lookAheadTimeInMinutes);
                return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalendarEventClientReceiveStringEnumsImportanceType
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalendarEventClientReceiveStringEnumsResponseTypeType
    {
        None,
        Organizer,
        TentativelyAccepted,
        Accepted,
        Declined,
        NotResponded
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalendarEventClientReceiveStringEnumsRecurrenceType
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum itemrecurrenceInput
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum replyParametersimportanceInput
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
