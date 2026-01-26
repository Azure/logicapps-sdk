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
                draftMessage["Importance"] = ExpressionConverter.ConvertO(draftMessageimportance);
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
                draftMessage["Importance"] = ExpressionConverter.ConvertO(draftMessageimportance);
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
            var apiCallPath = String.Format("/Draft/Send/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
            callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
            callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchOperationResult> AssignCategoryBulk(Expression<Func<string>> categoryName, Expression<Func<string[]>> messageIds = null)
        {
            var apiCallPath = String.Format("/Mail/Category/Bulk/{0}", ExpressionConverter.ConvertWithUrlEncoding(categoryName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(messageIds);
            return new ApiConnectionAction<BatchOperationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendEmailV2(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagefromSendAs = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagesensitivity = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
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
                emailMessage["Importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> GetEmailV2(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var apiCallPath = String.Format("/v2/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchResponseGraphClientReceiveMessage> GetEmailsV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage> MoveV2(Expression<Func<string>> messageId, Expression<Func<string>> folderPath, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/v2/Mail/Move/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ReplyToV3(Expression<Func<string>> messageId, Expression<Func<string>> replyParametersto = null, Expression<Func<string>> replyParameterscC = null, Expression<Func<string>> replyParametersbCC = null, Expression<Func<string>> replyParameterssubject = null, Expression<Func<string>> replyParametersbody = null, Expression<Func<bool>> replyParametersreplyAll = null, Expression<Func<replyParametersimportanceInput>> replyParametersimportance = null, Expression<Func<ClientSendAttachment[]>> replyParametersattachments = null, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/v3/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<string>> optionsEmailSubscriptionMessageto, Expression<Func<string>> optionsEmailSubscriptionMessagesubject = null, Expression<Func<string>> optionsEmailSubscriptionMessageuserOptions = null, Expression<Func<string>> optionsEmailSubscriptionMessageheaderText = null, Expression<Func<string>> optionsEmailSubscriptionMessageselectionText = null, Expression<Func<string>> optionsEmailSubscriptionMessagebody = null, Expression<Func<optionsEmailSubscriptionMessageimportanceInput>> optionsEmailSubscriptionMessageimportance = null, Expression<Func<ClientSendAttachment[]>> optionsEmailSubscriptionMessageattachments = null, Expression<Func<bool>> optionsEmailSubscriptionMessageuseOnlyHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionMessagehideHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionMessageshowHTMLConfirmationDialog = null, Expression<Func<bool>> optionsEmailSubscriptionMessagehideMicrosoftFooter = null)
        {
            var apiCallPath = "/mailwithoptions/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var optionsEmailSubscription = new JObject();
            var optionsEmailSubscriptionpropCount = 0;
            optionsEmailSubscription["NotificationUrl"] = "@listCallbackUrl()";
            optionsEmailSubscriptionpropCount++;
            var MessageObject = new JObject();
            var MessageObjectpropCount = 0;
            MessageObjectpropCount++;
            MessageObject["To"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageto);
            if (optionsEmailSubscriptionMessagesubject != null)
            {
                MessageObject["Subject"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessagesubject);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessageuserOptions != null)
            {
                MessageObject["Options"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageuserOptions);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessageheaderText != null)
            {
                MessageObject["HeaderText"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageheaderText);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessageselectionText != null)
            {
                MessageObject["SelectionText"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageselectionText);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessagebody != null)
            {
                MessageObject["Body"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessagebody);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessageimportance != null)
            {
                MessageObject["Importance"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageimportance);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessageattachments != null)
            {
                MessageObject["Attachments"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageattachments);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessageuseOnlyHTMLMessage != null)
            {
                MessageObject["UseOnlyHTMLMessage"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageuseOnlyHTMLMessage);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessagehideHTMLMessage != null)
            {
                MessageObject["HideHTMLMessage"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessagehideHTMLMessage);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessageshowHTMLConfirmationDialog != null)
            {
                MessageObject["ShowHTMLConfirmationDialog"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessageshowHTMLConfirmationDialog);
                MessageObjectpropCount++;
            }

            if (optionsEmailSubscriptionMessagehideMicrosoftFooter != null)
            {
                MessageObject["HideMicrosoftFooter"] = ExpressionConverter.ConvertO(optionsEmailSubscriptionMessagehideMicrosoftFooter);
                MessageObjectpropCount++;
            }

            if (MessageObjectpropCount > 0)
            {
                optionsEmailSubscription["Message"] = MessageObject;
                optionsEmailSubscriptionpropCount++;
            }

            if (optionsEmailSubscriptionpropCount > 0)
            {
                callPayload.Body = optionsEmailSubscription;
            }

            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail(Expression<Func<string>> approvalEmailSubscriptionMessageto, Expression<Func<string>> approvalEmailSubscriptionMessagesubject = null, Expression<Func<string>> approvalEmailSubscriptionMessageuserOptions = null, Expression<Func<string>> approvalEmailSubscriptionMessageheaderText = null, Expression<Func<string>> approvalEmailSubscriptionMessageselectionText = null, Expression<Func<string>> approvalEmailSubscriptionMessagebody = null, Expression<Func<approvalEmailSubscriptionMessageimportanceInput>> approvalEmailSubscriptionMessageimportance = null, Expression<Func<ClientSendAttachment[]>> approvalEmailSubscriptionMessageattachments = null, Expression<Func<bool>> approvalEmailSubscriptionMessageuseOnlyHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionMessagehideHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionMessageshowHTMLConfirmationDialog = null)
        {
            var apiCallPath = "/approvalmail/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var approvalEmailSubscription = new JObject();
            var approvalEmailSubscriptionpropCount = 0;
            approvalEmailSubscription["NotificationUrl"] = "@listCallbackUrl()";
            approvalEmailSubscriptionpropCount++;
            var MessageObject = new JObject();
            var MessageObjectpropCount = 0;
            MessageObjectpropCount++;
            MessageObject["To"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageto);
            if (approvalEmailSubscriptionMessagesubject != null)
            {
                MessageObject["Subject"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessagesubject);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessageuserOptions != null)
            {
                MessageObject["Options"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageuserOptions);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessageheaderText != null)
            {
                MessageObject["HeaderText"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageheaderText);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessageselectionText != null)
            {
                MessageObject["SelectionText"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageselectionText);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessagebody != null)
            {
                MessageObject["Body"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessagebody);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessageimportance != null)
            {
                MessageObject["Importance"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageimportance);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessageattachments != null)
            {
                MessageObject["Attachments"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageattachments);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessageuseOnlyHTMLMessage != null)
            {
                MessageObject["UseOnlyHTMLMessage"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageuseOnlyHTMLMessage);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessagehideHTMLMessage != null)
            {
                MessageObject["HideHTMLMessage"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessagehideHTMLMessage);
                MessageObjectpropCount++;
            }

            if (approvalEmailSubscriptionMessageshowHTMLConfirmationDialog != null)
            {
                MessageObject["ShowHTMLConfirmationDialog"] = ExpressionConverter.ConvertO(approvalEmailSubscriptionMessageshowHTMLConfirmationDialog);
                MessageObjectpropCount++;
            }

            if (MessageObjectpropCount > 0)
            {
                approvalEmailSubscription["Message"] = MessageObject;
                approvalEmailSubscriptionpropCount++;
            }

            if (approvalEmailSubscriptionpropCount > 0)
            {
                callPayload.Body = approvalEmailSubscription;
            }

            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SharedMailboxSendEmailV2(Expression<Func<string>> emailMessageoriginalMailboxAddress, Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagesensitivity = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
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
                emailMessage["Importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventListClientReceive> V4CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v4/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> V4CalendarPostItem(Expression<Func<string>> table, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<itemselectedDaysOfWeekInputItem[]>> itemselectedDaysOfWeek = null, Expression<Func<string>> itemrecurrenceEndDate = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<bool>> itemisReminderOn = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null, Expression<Func<itemsensitivityInput>> itemsensitivity = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v4/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> GetEventsCalendarViewV3(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeUtc, Expression<Func<string>> endDateTimeUtc, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> V3CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive> V4CalendarPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<itemselectedDaysOfWeekInputItem[]>> itemselectedDaysOfWeek = null, Expression<Func<string>> itemrecurrenceEndDate = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<bool>> itemisReminderOn = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null, Expression<Func<itemsensitivityInput>> itemsensitivity = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v4/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphContactFolder> ContactGetTablesV2()
        {
            var apiCallPath = "/v2/datasets/contacts/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseGraphContactFolder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<string> ExportEmailV2(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/codeless/beta/me/messages/{0}/$value", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction FlagV2(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bodyflagflagStatusInput>> bodyflagflagStatus = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}/flag", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
                flagObject["flagStatus"] = ExpressionConverter.ConvertO(bodyflagflagStatus);
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
        public IWorkflowAction MarkAsReadV3(Expression<Func<string>> messageId, Expression<Func<bool>> bodymarkAs, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/codeless/v3/v1.0/me/messages/{0}/markAsRead", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction DeleteEmailV2(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetAttachmentV2Response> GetAttachmentV2(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}/attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            if (extractSensitivityLabel != null)
                callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
            if (fetchSensitivityLabelMetadata != null)
                callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
            return new ApiConnectionAction<GetAttachmentV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction RespondToEventV2(Expression<Func<string>> eventId, Expression<Func<responseInput>> response, Expression<Func<string>> bodycomment = null, Expression<Func<bool>> bodysendResponse = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/events/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(response, 1));
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
                body["SendResponse"] = ExpressionConverter.ConvertO(bodysendResponse);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ForwardEmailV2(Expression<Func<string>> messageId, Expression<Func<string>> bodyto, Expression<Func<string>> mailboxAddress = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}/forward", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomListsV2Response> GetRoomListsV2()
        {
            var apiCallPath = "/codeless/beta/me/findRoomLists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomListsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsV2Response> GetRoomsV2()
        {
            var apiCallPath = "/codeless/beta/me/findRooms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsInRoomListV2Response> GetRoomsInRoomListV2(Expression<Func<string>> roomList)
        {
            var apiCallPath = String.Format("/codeless/beta/me/findRooms(RoomList='{0}')", ExpressionConverter.ConvertWithUrlEncoding(roomList, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomsInRoomListV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<FindMeetingTimesV2Response> FindMeetingTimesV2(Expression<Func<string>> bodyrequiredAttendees = null, Expression<Func<string>> bodyoptionalAttendees = null, Expression<Func<string>> bodyresourceAttendees = null, Expression<Func<int>> bodymeetingDuration = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<int>> bodymaxCandidates = null, Expression<Func<string>> bodyminimumAttendeePercentage = null, Expression<Func<bool>> bodyisOrganizerOptional = null, Expression<Func<bodyactivityDomainInput>> bodyactivityDomain = null)
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
                body["ActivityDomain"] = ExpressionConverter.ConvertO(bodyactivityDomain);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FindMeetingTimesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SetAutomaticRepliesSettingV2Response> SetAutomaticRepliesSettingV2(Expression<Func<bodyautomaticRepliesSettingstatusInput>> bodyautomaticRepliesSettingstatus, Expression<Func<bodyautomaticRepliesSettingexternalAudienceInput>> bodyautomaticRepliesSettingexternalAudience, Expression<Func<string>> bodyautomaticRepliesSettingstartTimedateTime = null, Expression<Func<string>> bodyautomaticRepliesSettingstartTimetimeZone = null, Expression<Func<string>> bodyautomaticRepliesSettingendTimedateTime = null, Expression<Func<string>> bodyautomaticRepliesSettingendTimetimeZone = null, Expression<Func<string>> bodyautomaticRepliesSettinginternalReplyMessage = null, Expression<Func<string>> bodyautomaticRepliesSettingexternalReplyMessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetMailTipsV2Response> GetMailTipsV2(Expression<Func<string[]>> bodyemailAddresses)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<CalendarGetTablesV2Response> CalendarGetTablesV2()
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
        public IWorkflowAction CalendarDeleteItemV2(Expression<Func<string>> calendar, Expression<Func<string>> @event)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(calendar, 2), ExpressionConverter.ConvertWithUrlEncoding(@event, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactGetItemV2(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ContactDeleteItemV2(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactPatchItemV2(Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddressV2[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseContactResponseV2> ContactGetItemsV2(Expression<Func<string>> folder, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(folder, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2> ContactPostItemV2(Expression<Func<string>> folder, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddressV2[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(folder, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateMyContactPhoto(Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}/photo/$value", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("image/jpeg");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<MCPQueryResponse> McpEmailsManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
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

            var paramsObject = new JObject();
            var paramsObjectpropCount = 0;
            if (paramsObjectpropCount > 0)
            {
                queryRequest["params"] = paramsObject;
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

            var paramsObject = new JObject();
            var paramsObjectpropCount = 0;
            if (paramsObjectpropCount > 0)
            {
                queryRequest["params"] = paramsObject;
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

            var paramsObject = new JObject();
            var paramsObjectpropCount = 0;
            if (paramsObjectpropCount > 0)
            {
                queryRequest["params"] = paramsObject;
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
    }

    public class Office365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> OnUpcomingEventsV3(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v3/Events/OnUpcomingEvents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["table"] = ExpressionConverter.Convert(table);
            callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
            if (lookAheadTimeInMinutes != null)
                callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(lookAheadTimeInMinutes);
            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewEmailV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
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
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnFlaggedEmailV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/v3/Mail/OnFlaggedEmail"
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
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnFlaggedEmailV4(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
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
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> OnNewMentionMeEmailV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
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
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> SharedMailboxOnNewEmailV2(Expression<Func<string>> mailboxAddress, Expression<Func<string>> folderId = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> hasAttachments = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> CalendarGetOnNewItemsV3(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive> CalendarGetOnUpdatedItemsV3(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListWithActionType> CalendarGetOnChangedItemsV3(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null, string triggerName = null)
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
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<GraphCalendarEventListWithActionType>(input);
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

    public enum emailMessageimportanceInput
    {
        Low,
        Normal,
        High
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

    public enum replyParametersimportanceInput
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

    public enum optionsEmailSubscriptionMessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum approvalEmailSubscriptionMessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class GraphCalendarEventListClientReceive
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientReceive[] Value { get; set; }
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

    public class EntityListResponseGraphCalendarEventClientReceive
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientReceive[] Value { get; set; }
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

    public enum responseInput
    {
        [EnumMember(Value = "accept")]
        Accept,
        [EnumMember(Value = "tentativelyAccept")]
        TentativelyAccept,
        [EnumMember(Value = "decline")]
        Decline
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

    public class TriggerBatchResponseGraphClientReceiveMessage
    {
        [JsonProperty("value")]
        public GraphClientReceiveMessage[] Value { get; set; }
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
