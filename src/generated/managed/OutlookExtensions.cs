//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Outlook
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OutlookActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<BatchResponseClientReceiveMessage> GetEmailsV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction SendEmailV2(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagefromSendAs = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
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
                emailMessage["Importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessage> GetEmail(Expression<Func<string>> messageId, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null)
        {
            var apiCallPath = String.Format("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
            if (internetMessageId != null)
                callPayload.Queries["internetMessageId"] = ExpressionConverter.Convert(internetMessageId);
            return new ApiConnectionAction<ClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessageStringEnums> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath)
        {
            var apiCallPath = String.Format("/Mail/Move/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionAction<ClientReceiveMessageStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction Flag(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Mail/Flag/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction MarkAsRead(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Mail/MarkAsRead/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ReplyToV3(Expression<Func<string>> messageId, Expression<Func<string>> replyParametersto = null, Expression<Func<string>> replyParameterscC = null, Expression<Func<string>> replyParametersbCC = null, Expression<Func<string>> replyParameterssubject = null, Expression<Func<string>> replyParametersbody = null, Expression<Func<bool>> replyParametersreplyAll = null, Expression<Func<replyParametersimportanceInput>> replyParametersimportance = null, Expression<Func<ClientSendAttachment[]>> replyParametersattachments = null)
        {
            var apiCallPath = String.Format("/v3/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<string> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = String.Format("/Mail/{0}/Attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<string>> optionsEmailSubscriptionMessageto, Expression<Func<string>> optionsEmailSubscriptionMessagesubject = null, Expression<Func<string>> optionsEmailSubscriptionMessageuserOptions = null, Expression<Func<string>> optionsEmailSubscriptionMessageheaderText = null, Expression<Func<string>> optionsEmailSubscriptionMessageselectionText = null, Expression<Func<string>> optionsEmailSubscriptionMessagebody = null, Expression<Func<optionsEmailSubscriptionMessageimportanceInput>> optionsEmailSubscriptionMessageimportance = null, Expression<Func<ClientSendAttachment[]>> optionsEmailSubscriptionMessageattachments = null, Expression<Func<bool>> optionsEmailSubscriptionMessageuseOnlyHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionMessagehideHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionMessageshowHTMLConfirmationDialog = null)
        {
            var apiCallPath = "/mailwithoptions/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var optionsEmailSubscription = new JObject();
            var optionsEmailSubscriptionpropCount = 0;
            optionsEmailSubscription["NotificationUrl"] = "@listcallbackurl()";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail(Expression<Func<string>> approvalEmailSubscriptionMessageto, Expression<Func<string>> approvalEmailSubscriptionMessagesubject = null, Expression<Func<string>> approvalEmailSubscriptionMessageuserOptions = null, Expression<Func<string>> approvalEmailSubscriptionMessageheaderText = null, Expression<Func<string>> approvalEmailSubscriptionMessageselectionText = null, Expression<Func<string>> approvalEmailSubscriptionMessagebody = null, Expression<Func<approvalEmailSubscriptionMessageimportanceInput>> approvalEmailSubscriptionMessageimportance = null, Expression<Func<ClientSendAttachment[]>> approvalEmailSubscriptionMessageattachments = null, Expression<Func<bool>> approvalEmailSubscriptionMessageuseOnlyHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionMessagehideHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionMessageshowHTMLConfirmationDialog = null)
        {
            var apiCallPath = "/approvalmail/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var approvalEmailSubscription = new JObject();
            var approvalEmailSubscriptionpropCount = 0;
            approvalEmailSubscription["NotificationUrl"] = "@listcallbackurl()";
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
            var apiCallPath = String.Format("/datasets/calendars/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventListClientReceive> V3CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> V3CalendarPostItem(Expression<Func<string>> table, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone = null, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<string>> itemrecurrenceEndTime = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> GetEventsCalendarViewV2(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeOffset, Expression<Func<string>> endDateTimeOffset, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> V2CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/calendars/v2/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> V3CalendarPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone = null, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<string>> itemrecurrenceEndTime = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
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
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPostItem(Expression<Func<string>> table, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddress[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemHomeAddressStreet = null, Expression<Func<string>> itemHomeAddressCity = null, Expression<Func<string>> itemHomeAddressState = null, Expression<Func<string>> itemHomeAddressCountryOrRegion = null, Expression<Func<string>> itemHomeAddressPostalCode = null, Expression<Func<string>> itemBusinessAddressStreet = null, Expression<Func<string>> itemBusinessAddressCity = null, Expression<Func<string>> itemBusinessAddressState = null, Expression<Func<string>> itemBusinessAddressCountryOrRegion = null, Expression<Func<string>> itemBusinessAddressPostalCode = null, Expression<Func<string>> itemOtherAddressStreet = null, Expression<Func<string>> itemOtherAddressCity = null, Expression<Func<string>> itemOtherAddressState = null, Expression<Func<string>> itemOtherAddressCountryOrRegion = null, Expression<Func<string>> itemOtherAddressPostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            var HomeAddressObject = new JObject();
            var HomeAddressObjectpropCount = 0;
            if (itemHomeAddressStreet != null)
            {
                HomeAddressObject["Street"] = ExpressionConverter.ConvertO(itemHomeAddressStreet);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressCity != null)
            {
                HomeAddressObject["City"] = ExpressionConverter.ConvertO(itemHomeAddressCity);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressState != null)
            {
                HomeAddressObject["State"] = ExpressionConverter.ConvertO(itemHomeAddressState);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressCountryOrRegion != null)
            {
                HomeAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemHomeAddressCountryOrRegion);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressPostalCode != null)
            {
                HomeAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemHomeAddressPostalCode);
                HomeAddressObjectpropCount++;
            }

            if (HomeAddressObjectpropCount > 0)
            {
                item["HomeAddress"] = HomeAddressObject;
                itempropCount++;
            }

            var BusinessAddressObject = new JObject();
            var BusinessAddressObjectpropCount = 0;
            if (itemBusinessAddressStreet != null)
            {
                BusinessAddressObject["Street"] = ExpressionConverter.ConvertO(itemBusinessAddressStreet);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressCity != null)
            {
                BusinessAddressObject["City"] = ExpressionConverter.ConvertO(itemBusinessAddressCity);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressState != null)
            {
                BusinessAddressObject["State"] = ExpressionConverter.ConvertO(itemBusinessAddressState);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressCountryOrRegion != null)
            {
                BusinessAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemBusinessAddressCountryOrRegion);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressPostalCode != null)
            {
                BusinessAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemBusinessAddressPostalCode);
                BusinessAddressObjectpropCount++;
            }

            if (BusinessAddressObjectpropCount > 0)
            {
                item["BusinessAddress"] = BusinessAddressObject;
                itempropCount++;
            }

            var OtherAddressObject = new JObject();
            var OtherAddressObjectpropCount = 0;
            if (itemOtherAddressStreet != null)
            {
                OtherAddressObject["Street"] = ExpressionConverter.ConvertO(itemOtherAddressStreet);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressCity != null)
            {
                OtherAddressObject["City"] = ExpressionConverter.ConvertO(itemOtherAddressCity);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressState != null)
            {
                OtherAddressObject["State"] = ExpressionConverter.ConvertO(itemOtherAddressState);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressCountryOrRegion != null)
            {
                OtherAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemOtherAddressCountryOrRegion);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressPostalCode != null)
            {
                OtherAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemOtherAddressPostalCode);
                OtherAddressObjectpropCount++;
            }

            if (OtherAddressObjectpropCount > 0)
            {
                item["OtherAddress"] = OtherAddressObject;
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ContactDeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddress[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemHomeAddressStreet = null, Expression<Func<string>> itemHomeAddressCity = null, Expression<Func<string>> itemHomeAddressState = null, Expression<Func<string>> itemHomeAddressCountryOrRegion = null, Expression<Func<string>> itemHomeAddressPostalCode = null, Expression<Func<string>> itemBusinessAddressStreet = null, Expression<Func<string>> itemBusinessAddressCity = null, Expression<Func<string>> itemBusinessAddressState = null, Expression<Func<string>> itemBusinessAddressCountryOrRegion = null, Expression<Func<string>> itemBusinessAddressPostalCode = null, Expression<Func<string>> itemOtherAddressStreet = null, Expression<Func<string>> itemOtherAddressCity = null, Expression<Func<string>> itemOtherAddressState = null, Expression<Func<string>> itemOtherAddressCountryOrRegion = null, Expression<Func<string>> itemOtherAddressPostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
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

            var HomeAddressObject = new JObject();
            var HomeAddressObjectpropCount = 0;
            if (itemHomeAddressStreet != null)
            {
                HomeAddressObject["Street"] = ExpressionConverter.ConvertO(itemHomeAddressStreet);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressCity != null)
            {
                HomeAddressObject["City"] = ExpressionConverter.ConvertO(itemHomeAddressCity);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressState != null)
            {
                HomeAddressObject["State"] = ExpressionConverter.ConvertO(itemHomeAddressState);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressCountryOrRegion != null)
            {
                HomeAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemHomeAddressCountryOrRegion);
                HomeAddressObjectpropCount++;
            }

            if (itemHomeAddressPostalCode != null)
            {
                HomeAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemHomeAddressPostalCode);
                HomeAddressObjectpropCount++;
            }

            if (HomeAddressObjectpropCount > 0)
            {
                item["HomeAddress"] = HomeAddressObject;
                itempropCount++;
            }

            var BusinessAddressObject = new JObject();
            var BusinessAddressObjectpropCount = 0;
            if (itemBusinessAddressStreet != null)
            {
                BusinessAddressObject["Street"] = ExpressionConverter.ConvertO(itemBusinessAddressStreet);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressCity != null)
            {
                BusinessAddressObject["City"] = ExpressionConverter.ConvertO(itemBusinessAddressCity);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressState != null)
            {
                BusinessAddressObject["State"] = ExpressionConverter.ConvertO(itemBusinessAddressState);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressCountryOrRegion != null)
            {
                BusinessAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemBusinessAddressCountryOrRegion);
                BusinessAddressObjectpropCount++;
            }

            if (itemBusinessAddressPostalCode != null)
            {
                BusinessAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemBusinessAddressPostalCode);
                BusinessAddressObjectpropCount++;
            }

            if (BusinessAddressObjectpropCount > 0)
            {
                item["BusinessAddress"] = BusinessAddressObject;
                itempropCount++;
            }

            var OtherAddressObject = new JObject();
            var OtherAddressObjectpropCount = 0;
            if (itemOtherAddressStreet != null)
            {
                OtherAddressObject["Street"] = ExpressionConverter.ConvertO(itemOtherAddressStreet);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressCity != null)
            {
                OtherAddressObject["City"] = ExpressionConverter.ConvertO(itemOtherAddressCity);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressState != null)
            {
                OtherAddressObject["State"] = ExpressionConverter.ConvertO(itemOtherAddressState);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressCountryOrRegion != null)
            {
                OtherAddressObject["CountryOrRegion"] = ExpressionConverter.ConvertO(itemOtherAddressCountryOrRegion);
                OtherAddressObjectpropCount++;
            }

            if (itemOtherAddressPostalCode != null)
            {
                OtherAddressObject["PostalCode"] = ExpressionConverter.ConvertO(itemOtherAddressPostalCode);
                OtherAddressObjectpropCount++;
            }

            if (OtherAddressObjectpropCount > 0)
            {
                item["OtherAddress"] = OtherAddressObject;
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction RespondToEvent(Expression<Func<string>> eventId, Expression<Func<responseInput>> response, Expression<Func<string>> bodycomment = null, Expression<Func<bool>> bodysendResponse = null)
        {
            var apiCallPath = String.Format("/codeless/api/v2.0/me/events/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(response, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ForwardEmail(Expression<Func<string>> messageId, Expression<Func<string>> bodyto, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/codeless/api/v2.0/me/messages/{0}/forward", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
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
        }
    }

    public class OutlookTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CalendarEventListClientReceive> OnUpcomingEventsV2(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null)
        {
            var apiCallPath = "/v2/Events/OnUpcomingEvents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["table"] = ExpressionConverter.Convert(table);
            callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
            if (lookAheadTimeInMinutes != null)
                callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(lookAheadTimeInMinutes);
            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload);
        }

        public IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewEmailV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
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
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        public IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnFlaggedEmailV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
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
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        public IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewMentionMeEmailV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
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
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        public IOutputWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnNewItemsV2(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v2/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload);
        }

        public IOutputWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnUpdatedItemsV2(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v2/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload);
        }

        public IOutputWorkflowTrigger<CalendarEventListWithActionType> CalendarGetOnChangedItemsV2(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.Queries["incomingDays"] = Convert.ToString(300);
            if (incomingDays != null)
                input.Fetch.Queries["incomingDays"] = ExpressionConverter.Convert(incomingDays);
            input.Fetch.Queries["pastDays"] = Convert.ToString(50);
            if (pastDays != null)
                input.Fetch.Queries["pastDays"] = ExpressionConverter.Convert(pastDays);
            input.Subscribe.Queries["incomingDays"] = Convert.ToString(300);
            if (incomingDays != null)
                input.Subscribe.Queries["incomingDays"] = ExpressionConverter.Convert(incomingDays);
            input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
            if (pastDays != null)
                input.Subscribe.Queries["pastDays"] = ExpressionConverter.Convert(pastDays);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<CalendarEventListWithActionType>(input);
        }
    }

    public class BatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
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

    public enum importanceInput
    {
        Any,
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

    public enum emailMessageimportanceInput
    {
        Low,
        Normal,
        High
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

    public class EntityListResponseCalendarEventClientReceiveStringEnums
    {
        [JsonProperty("value")]
        public CalendarEventClientReceiveStringEnums[] Value { get; set; }
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

    public class TriggerBatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
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