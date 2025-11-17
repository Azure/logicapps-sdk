//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Outlook
{
    using System.Net;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class OutlookExtensions
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowTrigger<CalendarEventListClientReceive> WhenOnUpcomingEventsV2([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null)
        {
            var apiCallPath = "/v2/Events/OnUpcomingEvents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["table"] = ExpressionConverter.Convert(table);
            if (lookAheadTimeInMinutes != null)
            {
                callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(lookAheadTimeInMinutes);
            }

            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<BatchResponseClientReceiveMessage> GetEmailsV2([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<GetEmailsV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/v2/Mail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folderPath != null)
            {
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            }

            if (to != null)
            {
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            }

            if (cc != null)
            {
                callPayload.Queries["cc"] = ExpressionConverter.Convert(cc);
            }

            if (toOrCc != null)
            {
                callPayload.Queries["toOrCc"] = ExpressionConverter.Convert(toOrCc);
            }

            if (from != null)
            {
                callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            }

            if (importance != null)
            {
                callPayload.Queries["importance"] = ExpressionConverter.Convert(importance);
            }

            if (fetchOnlyWithAttachment != null)
            {
                callPayload.Queries["fetchOnlyWithAttachment"] = ExpressionConverter.Convert(fetchOnlyWithAttachment);
            }

            if (subjectFilter != null)
            {
                callPayload.Queries["subjectFilter"] = ExpressionConverter.Convert(subjectFilter);
            }

            if (fetchOnlyUnread != null)
            {
                callPayload.Queries["fetchOnlyUnread"] = ExpressionConverter.Convert(fetchOnlyUnread);
            }

            if (includeAttachments != null)
            {
                callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
            }

            if (searchQuery != null)
            {
                callPayload.Queries["searchQuery"] = ExpressionConverter.Convert(searchQuery);
            }

            if (top != null)
            {
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            }

            callPayload.Queries["fetchOnlyFlagged"] = "false";
            return new ApiConnectionAction<BatchResponseClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction SendEmailV2([ConnectionName] string connectionId, Expression<Func<ClientSendHtmlMessage>> emailMessage)
        {
            var apiCallPath = "/v2/Mail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(emailMessage);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<ClientReceiveMessage> GetEmail([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null)
        {
            var apiCallPath = String.Format("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeAttachments != null)
            {
                callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
            }

            if (internetMessageId != null)
            {
                callPayload.Queries["internetMessageId"] = ExpressionConverter.Convert(internetMessageId);
            }

            return new ApiConnectionAction<ClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction DeleteEmail([ConnectionName] string connectionId, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<ClientReceiveMessageStringEnums> Move([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> folderPath)
        {
            var apiCallPath = String.Format("/Mail/Move/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionAction<ClientReceiveMessageStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction Flag([ConnectionName] string connectionId, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Mail/Flag/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction MarkAsRead([ConnectionName] string connectionId, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Mail/MarkAsRead/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction ReplyToV3([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<ReplyHtmlMessage>> replyParameters)
        {
            var apiCallPath = String.Format("/v3/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(replyParameters);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<string> GetAttachment([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = String.Format("/Mail/{0}/Attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> WhenOnNewEmailV2([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewEmailV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/v2/Mail/OnNewEmail";
            input.Fetch.Method = "get";
            input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Fetch.Queries["importance"] = Convert.ToString(0);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            input.Subscribe.PathTemplate.Template = "/MailSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Subscribe.Queries["importance"] = Convert.ToString(0);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> WhenOnFlaggedEmailV2([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnFlaggedEmailV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/v2/Mail/OnFlaggedEmail";
            input.Fetch.Method = "get";
            input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Fetch.Queries["importance"] = Convert.ToString(0);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            input.Subscribe.PathTemplate.Template = "/FlaggedMailSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Subscribe.Queries["importance"] = Convert.ToString(0);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> WhenOnNewMentionMeEmailV2([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewMentionMeEmailV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/v2/Mail/OnNewMentionMeEmail";
            input.Fetch.Method = "get";
            input.Fetch.Queries["importance"] = Convert.ToString(0);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            input.Subscribe.PathTemplate.Template = "/MentionMeMailSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["importance"] = Convert.ToString(0);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<SubscriptionResponse> SendMailWithOptions([ConnectionName] string connectionId, Expression<Func<OptionsEmailSubscription>> optionsEmailSubscription)
        {
            var apiCallPath = "/mailwithoptions/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(optionsEmailSubscription);
            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<SubscriptionResponse> SendApprovalMail([ConnectionName] string connectionId, Expression<Func<ApprovalEmailSubscription>> approvalEmailSubscription)
        {
            var apiCallPath = "/approvalmail/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(approvalEmailSubscription);
            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<EntityListResponseTable> CalendarGetTables([ConnectionName] string connectionId)
        {
            var apiCallPath = "/datasets/calendars/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseTable>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction CalendarDeleteItem([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/calendars/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<CalendarEventListClientReceive> V3CalendarGetItems([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
            {
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            }

            if (orderby != null)
            {
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            }

            if (top != null)
            {
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            }

            if (skip != null)
            {
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            }

            return new ApiConnectionAction<CalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<CalendarEventClientReceiveStringEnums> V3CalendarPostItem([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<CalendarEventHtmlClient>> item)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> GetEventsCalendarViewV2([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeOffset, Expression<Func<string>> endDateTimeOffset, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/datasets/calendars/v2/tables/items/calendarview";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["calendarId"] = ExpressionConverter.Convert(calendarId);
            callPayload.Queries["startDateTimeOffset"] = ExpressionConverter.Convert(startDateTimeOffset);
            callPayload.Queries["endDateTimeOffset"] = ExpressionConverter.Convert(endDateTimeOffset);
            if (filter != null)
            {
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            }

            if (orderby != null)
            {
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            }

            if (top != null)
            {
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            }

            if (skip != null)
            {
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            }

            if (search != null)
            {
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            }

            return new ApiConnectionAction<EntityListResponseCalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<CalendarEventClientReceiveStringEnums> V2CalendarGetItem([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/calendars/v2/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<CalendarEventClientReceiveStringEnums> V3CalendarPatchItem([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<CalendarEventHtmlClient>> item)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowTrigger<CalendarEventListClientReceive> WhenCalendarGetOnNewItemsV2([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v2/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
            {
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            }

            if (top != null)
            {
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            }

            if (skip != null)
            {
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            }

            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowTrigger<CalendarEventListClientReceive> WhenCalendarGetOnUpdatedItemsV2([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v2/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
            {
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            }

            if (top != null)
            {
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            }

            if (skip != null)
            {
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            }

            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowTrigger<CalendarEventListWithActionType> WhenCalendarGetOnChangedItemsV2([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/datasets/calendars/v2/tables/{0}/onchangeditems";
            input.Fetch.Method = "get";
            input.Fetch.Queries["incomingDays"] = Convert.ToString(300);
            input.Fetch.Queries["pastDays"] = Convert.ToString(50);
            input.Subscribe.PathTemplate.Template = "/{0}/EventSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["incomingDays"] = Convert.ToString(300);
            input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
            return new ApiConnectionTrigger<CalendarEventListWithActionType>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<EntityListResponseTable> ContactGetTables([ConnectionName] string connectionId)
        {
            var apiCallPath = "/datasets/contacts/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseTable>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<EntityListResponseContactResponse> ContactGetItems([ConnectionName] string connectionId, [DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
            {
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            }

            if (orderby != null)
            {
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            }

            if (top != null)
            {
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            }

            if (skip != null)
            {
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            }

            return new ApiConnectionAction<EntityListResponseContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<ContactResponse> ContactPostItem([ConnectionName] string connectionId, [DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<Contact>> item)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<ContactResponse> ContactGetItem([ConnectionName] string connectionId, [DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction ContactDeleteItem([ConnectionName] string connectionId, [DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IOutputWorkflowAction<ContactResponse> ContactPatchItem([ConnectionName] string connectionId, [DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<Contact>> item)
        {
            var apiCallPath = String.Format("/datasets/contacts/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction RespondToEvent([ConnectionName] string connectionId, Expression<Func<string>> eventId, Expression<Func<RespondToEventresponseInput>> response, Expression<Func<ResponseToEventInvite>> body)
        {
            var apiCallPath = String.Format("/codeless/api/v2.0/me/events/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(response, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public static IWorkflowAction ForwardEmail([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<DirectForwardMessage>> body)
        {
            var apiCallPath = String.Format("/codeless/api/v2.0/me/messages/{0}/forward", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class OutlookInstance(string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<BatchResponseClientReceiveMessage> GetEmailsV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<GetEmailsV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null) => OutlookExtensions.GetEmailsV2(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, subjectFilter, fetchOnlyUnread, includeAttachments, searchQuery, top);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction SendEmailV2(Expression<Func<ClientSendHtmlMessage>> emailMessage) => OutlookExtensions.SendEmailV2(connectionId, emailMessage);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<ClientReceiveMessage> GetEmail(Expression<Func<string>> messageId, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null) => OutlookExtensions.GetEmail(connectionId, messageId, includeAttachments, internetMessageId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> messageId) => OutlookExtensions.DeleteEmail(connectionId, messageId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<ClientReceiveMessageStringEnums> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath) => OutlookExtensions.Move(connectionId, messageId, folderPath);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction Flag(Expression<Func<string>> messageId) => OutlookExtensions.Flag(connectionId, messageId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction MarkAsRead(Expression<Func<string>> messageId) => OutlookExtensions.MarkAsRead(connectionId, messageId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ReplyToV3(Expression<Func<string>> messageId, Expression<Func<ReplyHtmlMessage>> replyParameters) => OutlookExtensions.ReplyToV3(connectionId, messageId, replyParameters);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<string> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId) => OutlookExtensions.GetAttachment(connectionId, messageId, attachmentId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<OptionsEmailSubscription>> optionsEmailSubscription) => OutlookExtensions.SendMailWithOptions(connectionId, optionsEmailSubscription);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<SubscriptionResponse> SendApprovalMail(Expression<Func<ApprovalEmailSubscription>> approvalEmailSubscription) => OutlookExtensions.SendApprovalMail(connectionId, approvalEmailSubscription);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<EntityListResponseTable> CalendarGetTables() => OutlookExtensions.CalendarGetTables(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction CalendarDeleteItem([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> id) => OutlookExtensions.CalendarDeleteItem(connectionId, table, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<CalendarEventListClientReceive> V3CalendarGetItems([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => OutlookExtensions.V3CalendarGetItems(connectionId, table, filter, orderby, top, skip);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<CalendarEventClientReceiveStringEnums> V3CalendarPostItem([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<CalendarEventHtmlClient>> item) => OutlookExtensions.V3CalendarPostItem(connectionId, table, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> GetEventsCalendarViewV2([DynamicValues("CalendarGetTables")] Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeOffset, Expression<Func<string>> endDateTimeOffset, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null) => OutlookExtensions.GetEventsCalendarViewV2(connectionId, calendarId, startDateTimeOffset, endDateTimeOffset, filter, orderby, top, skip, search);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<CalendarEventClientReceiveStringEnums> V2CalendarGetItem([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> id) => OutlookExtensions.V2CalendarGetItem(connectionId, table, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<CalendarEventClientReceiveStringEnums> V3CalendarPatchItem([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<CalendarEventHtmlClient>> item) => OutlookExtensions.V3CalendarPatchItem(connectionId, table, id, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<EntityListResponseTable> ContactGetTables() => OutlookExtensions.ContactGetTables(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<EntityListResponseContactResponse> ContactGetItems([DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => OutlookExtensions.ContactGetItems(connectionId, table, filter, orderby, top, skip);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<ContactResponse> ContactPostItem([DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<Contact>> item) => OutlookExtensions.ContactPostItem(connectionId, table, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<ContactResponse> ContactGetItem([DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> id) => OutlookExtensions.ContactGetItem(connectionId, table, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ContactDeleteItem([DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> id) => OutlookExtensions.ContactDeleteItem(connectionId, table, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IOutputWorkflowAction<ContactResponse> ContactPatchItem([DynamicValues("ContactGetTables")] Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<Contact>> item) => OutlookExtensions.ContactPatchItem(connectionId, table, id, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction RespondToEvent(Expression<Func<string>> eventId, Expression<Func<RespondToEventresponseInput>> response, Expression<Func<ResponseToEventInvite>> body) => OutlookExtensions.RespondToEvent(connectionId, eventId, response, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ForwardEmail(Expression<Func<string>> messageId, Expression<Func<DirectForwardMessage>> body) => OutlookExtensions.ForwardEmail(connectionId, messageId, body);
    }

    public class OutlookInstanceTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CalendarEventListClientReceive> WhenOnUpcomingEventsV2([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null) => OutlookExtensions.WhenOnUpcomingEventsV2(connectionId, table, lookAheadTimeInMinutes);
        public IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> WhenOnNewEmailV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewEmailV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => OutlookExtensions.WhenOnNewEmailV2(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> WhenOnFlaggedEmailV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnFlaggedEmailV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => OutlookExtensions.WhenOnFlaggedEmailV2(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> WhenOnNewMentionMeEmailV2(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewMentionMeEmailV2importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => OutlookExtensions.WhenOnNewMentionMeEmailV2(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<CalendarEventListClientReceive> WhenCalendarGetOnNewItemsV2([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => OutlookExtensions.WhenCalendarGetOnNewItemsV2(connectionId, table, orderby, top, skip);
        public IOutputWorkflowTrigger<CalendarEventListClientReceive> WhenCalendarGetOnUpdatedItemsV2([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => OutlookExtensions.WhenCalendarGetOnUpdatedItemsV2(connectionId, table, orderby, top, skip);
        public IOutputWorkflowTrigger<CalendarEventListWithActionType> WhenCalendarGetOnChangedItemsV2([DynamicValues("CalendarGetTables")] Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null) => OutlookExtensions.WhenCalendarGetOnChangedItemsV2(connectionId, table, incomingDays, pastDays);
    }

    public class TableSortRestrictionsMetadata
    {
        [JsonProperty("sortable")]
        public bool Sortable { get; set; }

        [JsonProperty("unsortableProperties")]
        public string[] UnsortableProperties { get; set; }

        [JsonProperty("ascendingOnlyProperties")]
        public string[] AscendingOnlyProperties { get; set; }
    }

    public class TableFilterRestrictionsMetadata
    {
        [JsonProperty("filterable")]
        public bool Filterable { get; set; }

        [JsonProperty("nonFilterableProperties")]
        public string[] NonFilterableProperties { get; set; }

        [JsonProperty("requiredProperties")]
        public string[] RequiredProperties { get; set; }
    }

    public class TableSelectRestrictionsMetadata
    {
        [JsonProperty("selectable")]
        public bool Selectable { get; set; }
    }

    public class TableCapabilitiesMetadata
    {
        [JsonProperty("sortRestrictions")]
        public TableSortRestrictionsMetadata SortRestrictions { get; set; }

        [JsonProperty("filterRestrictions")]
        public TableFilterRestrictionsMetadata FilterRestrictions { get; set; }

        [JsonProperty("selectRestrictions")]
        public TableSelectRestrictionsMetadata SelectRestrictions { get; set; }

        [JsonProperty("isOnlyServerPagable")]
        public bool IsOnlyServerPagable { get; set; }

        [JsonProperty("filterFunctionSupport")]
        public TableCapabilitiesMetadataFilterFunctionSupportTypeItem[] FilterFunctionSupport { get; set; }

        [JsonProperty("serverPagingOptions")]
        public TableCapabilitiesMetadataServerPagingOptionsTypeItem[] ServerPagingOptions { get; set; }
    }

    public class TableMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("x-ms-permission")]
        public string XMsPermission { get; set; }

        [JsonProperty("x-ms-capabilities")]
        public TableCapabilitiesMetadata XMsCapabilities { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("referencedEntities")]
        public JToken ReferencedEntities { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }
    }

    public class CalendarEventClientReceive
    {
        public string Subject { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int ShowAs { get; set; }
        public int Recurrence { get; set; }
        public int ResponseType { get; set; }
        public string ResponseTime { get; set; }
        public string ICalUId { get; set; }
        public int Importance { get; set; }
        public string Id { get; set; }
        public string DateTimeCreated { get; set; }
        public string DateTimeLastModified { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
        public string Location { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceEnd { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public class CalendarEventListClientReceive
    {
        [JsonProperty("value")]
        public CalendarEventClientReceive[] Value { get; set; }
    }

    public class ClientSubscription
    {
        public string NotificationUrl { get; set; }
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

    public class FilePickerFile
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public bool IsFolder { get; set; }
        public string Path { get; set; }
    }

    public class EntityListResponseFilePickerFile
    {
        [JsonProperty("value")]
        public FilePickerFile[] Value { get; set; }
    }

    public class ClientReceiveFileAttachment
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ContentBytes { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public bool IsInline { get; set; }
        public string LastModifiedDateTime { get; set; }
        public string ContentId { get; set; }
    }

    public class ClientReceiveMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Importance { get; set; }
        public string BodyPreview { get; set; }
        public bool HasAttachment { get; set; }
        public string Id { get; set; }
        public string InternetMessageId { get; set; }
        public string ConversationId { get; set; }
        public string DateTimeReceived { get; set; }
        public bool IsRead { get; set; }
        public ClientReceiveFileAttachment[] Attachments { get; set; }
        public bool IsHtml { get; set; }
    }

    public class BatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
    }

    public class ClientSendAttachment
    {
        public string Name { get; set; }
        public string ContentBytes { get; set; }
    }

    public class ClientSendHtmlMessage
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
        public string ReplyTo { get; set; }
        public ClientSendHtmlMessageImportanceType Importance { get; set; }
    }

    public class ClientReceiveMessageStringEnums
    {
        public ClientReceiveMessageStringEnumsImportanceType Importance { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string BodyPreview { get; set; }
        public bool HasAttachment { get; set; }
        public string Id { get; set; }
        public string InternetMessageId { get; set; }
        public string ConversationId { get; set; }
        public string DateTimeReceived { get; set; }
        public bool IsRead { get; set; }
        public ClientReceiveFileAttachment[] Attachments { get; set; }
        public bool IsHtml { get; set; }
    }

    public class ReplyHtmlMessage
    {
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool ReplyAll { get; set; }
        public ReplyHtmlMessageImportanceType Importance { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
    }

    public class TriggerBatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
    }

    public class TabularDataSetsMetadata
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("urlEncoding")]
        public string UrlEncoding { get; set; }

        [JsonProperty("tableDisplayName")]
        public string TableDisplayName { get; set; }

        [JsonProperty("tablePluralName")]
        public string TablePluralName { get; set; }
    }

    public class BlobDataSetsMetadata
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("urlEncoding")]
        public string UrlEncoding { get; set; }
    }

    public class DataSetsMetadata
    {
        [JsonProperty("tabular")]
        public TabularDataSetsMetadata Tabular { get; set; }

        [JsonProperty("blob")]
        public BlobDataSetsMetadata Blob { get; set; }
    }

    public class MessageWithOptions
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Options { get; set; }
        public string HeaderText { get; set; }
        public string SelectionText { get; set; }
        public string Body { get; set; }
        public MessageWithOptionsImportanceType Importance { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
        public bool UseOnlyHTMLMessage { get; set; }
        public bool HideHTMLMessage { get; set; }
        public bool ShowHTMLConfirmationDialog { get; set; }
    }

    public class OptionsEmailSubscription
    {
        public string NotificationUrl { get; set; }
        public MessageWithOptions Message { get; set; }
    }

    public class ApprovalMessage
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Options { get; set; }
        public string HeaderText { get; set; }
        public string SelectionText { get; set; }
        public string Body { get; set; }
        public ApprovalMessageImportanceType Importance { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
        public bool UseOnlyHTMLMessage { get; set; }
        public bool HideHTMLMessage { get; set; }
        public bool ShowHTMLConfirmationDialog { get; set; }
    }

    public class ApprovalEmailSubscription
    {
        public string NotificationUrl { get; set; }
        public ApprovalMessage Message { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class EntityListResponseTable
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class CalendarEventHtmlClient
    {
        public string Subject { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public CalendarEventHtmlClientTimeZoneType TimeZone { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }
        public string Location { get; set; }
        public CalendarEventHtmlClientImportanceType Importance { get; set; }
        public bool IsAllDay { get; set; }
        public CalendarEventHtmlClientRecurrenceType Recurrence { get; set; }
        public string RecurrenceEnd { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public CalendarEventHtmlClientShowAsType ShowAs { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public class CalendarEventClientReceiveStringEnums
    {
        public CalendarEventClientReceiveStringEnumsImportanceType Importance { get; set; }
        public CalendarEventClientReceiveStringEnumsResponseTypeType ResponseType { get; set; }
        public CalendarEventClientReceiveStringEnumsRecurrenceType Recurrence { get; set; }
        public CalendarEventClientReceiveStringEnumsShowAsType ShowAs { get; set; }
        public string Subject { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string ResponseTime { get; set; }
        public string ICalUId { get; set; }
        public string Id { get; set; }
        public string DateTimeCreated { get; set; }
        public string DateTimeLastModified { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
        public string Location { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceEnd { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public class EntityListResponseCalendarEventClientReceiveStringEnums
    {
        [JsonProperty("value")]
        public CalendarEventClientReceiveStringEnums[] Value { get; set; }
    }

    public class ResponseStatus
    {
        public ResponseStatusResponseType Response { get; set; }
        public string Time { get; set; }
    }

    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Attendee
    {
        public ResponseStatus Status { get; set; }
        public AttendeeTypeType Type { get; set; }
        public EmailAddress EmailAddress { get; set; }
    }

    public class ItemBody
    {
        public ItemBodyContentTypeType ContentType { get; set; }
        public string Content { get; set; }
    }

    public class PhysicalAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryOrRegion { get; set; }
        public string PostalCode { get; set; }
    }

    public class GeoCoordinates
    {
        public double Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Accuracy { get; set; }
        public double AltitudeAccuracy { get; set; }
    }

    public class Location
    {
        public string DisplayName { get; set; }
        public PhysicalAddress Address { get; set; }
        public GeoCoordinates Coordinates { get; set; }
    }

    public class Recipient
    {
        public EmailAddress EmailAddress { get; set; }
    }

    public class RecurrencePattern
    {
        public RecurrencePatternTypeType Type { get; set; }
        public int Interval { get; set; }
        public int Month { get; set; }
        public int DayOfMonth { get; set; }
        public RecurrencePatternDaysOfWeekTypeItem[] DaysOfWeek { get; set; }
        public RecurrencePatternFirstDayOfWeekType FirstDayOfWeek { get; set; }
        public RecurrencePatternIndexType Index { get; set; }
    }

    public class RecurrenceRange
    {
        public RecurrenceRangeTypeType Type { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NumberOfOccurrences { get; set; }
    }

    public class PatternedRecurrence
    {
        public RecurrencePattern Pattern { get; set; }
        public RecurrenceRange Range { get; set; }
    }

    public class CalendarEventBackend
    {
        public string Id { get; set; }
        public Attendee[] Attendees { get; set; }
        public ItemBody Body { get; set; }
        public string BodyPreview { get; set; }
        public string[] Categories { get; set; }
        public string ChangeKey { get; set; }
        public string DateTimeCreated { get; set; }
        public string DateTimeLastModified { get; set; }
        public string End { get; set; }
        public string EndTimeZone { get; set; }
        public bool HasAttachments { get; set; }
        public string ICalUId { get; set; }
        public CalendarEventBackendImportanceType Importance { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsOrganizer { get; set; }
        public Location Location { get; set; }
        public Recipient Organizer { get; set; }
        public PatternedRecurrence Recurrence { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public string SeriesMasterId { get; set; }
        public CalendarEventBackendShowAsType ShowAs { get; set; }
        public string Start { get; set; }
        public string StartTimeZone { get; set; }
        public string Subject { get; set; }
        public CalendarEventBackendTypeType Type { get; set; }
        public string WebLink { get; set; }
        public string Reason { get; set; }
    }

    public class CalendarEventList
    {
        [JsonProperty("value")]
        public CalendarEventBackend[] Value { get; set; }
    }

    public class CalendarEventClientWithActionType
    {
        public CalendarEventClientWithActionTypeActionTypeType ActionType { get; set; }
        public bool IsAdded { get; set; }
        public bool IsUpdated { get; set; }
        public string Subject { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int ShowAs { get; set; }
        public int Recurrence { get; set; }
        public int ResponseType { get; set; }
        public string ResponseTime { get; set; }
        public string ICalUId { get; set; }
        public int Importance { get; set; }
        public string Id { get; set; }
        public string DateTimeCreated { get; set; }
        public string DateTimeLastModified { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
        public string Location { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceEnd { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public class CalendarEventListWithActionType
    {
        [JsonProperty("value")]
        public CalendarEventClientWithActionType[] Value { get; set; }
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
        public string NickName { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Generation { get; set; }
        public EmailAddress[] EmailAddresses { get; set; }
        public string[] ImAddresses { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string OfficeLocation { get; set; }
        public string Profession { get; set; }
        public string BusinessHomePage { get; set; }
        public string AssistantName { get; set; }
        public string Manager { get; set; }
        public string[] BusinessPhones { get; set; }
        public string MobilePhone1 { get; set; }
        public PhysicalAddress HomeAddress { get; set; }
        public PhysicalAddress BusinessAddress { get; set; }
        public PhysicalAddress OtherAddress { get; set; }
        public string YomiCompanyName { get; set; }
        public string YomiGivenName { get; set; }
        public string YomiSurname { get; set; }
        public string[] Categories { get; set; }
        public string ChangeKey { get; set; }
        public string DateTimeCreated { get; set; }
        public string DateTimeLastModified { get; set; }
    }

    public class EntityListResponseContactResponse
    {
        [JsonProperty("value")]
        public ContactResponse[] Value { get; set; }
    }

    public class Contact
    {
        public string Id { get; set; }
        public string ParentFolderId { get; set; }
        public string Birthday { get; set; }
        public string FileAs { get; set; }
        public string DisplayName { get; set; }
        public string GivenName { get; set; }
        public string Initials { get; set; }
        public string MiddleName { get; set; }
        public string NickName { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Generation { get; set; }
        public EmailAddress[] EmailAddresses { get; set; }
        public string[] ImAddresses { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string OfficeLocation { get; set; }
        public string Profession { get; set; }
        public string BusinessHomePage { get; set; }
        public string AssistantName { get; set; }
        public string Manager { get; set; }
        public string[] HomePhones { get; set; }
        public string[] BusinessPhones { get; set; }
        public string MobilePhone1 { get; set; }
        public PhysicalAddress HomeAddress { get; set; }
        public PhysicalAddress BusinessAddress { get; set; }
        public PhysicalAddress OtherAddress { get; set; }
        public string YomiCompanyName { get; set; }
        public string YomiGivenName { get; set; }
        public string YomiSurname { get; set; }
        public string[] Categories { get; set; }
        public string ChangeKey { get; set; }
        public string DateTimeCreated { get; set; }
        public string DateTimeLastModified { get; set; }
    }

    public class PassThroughNativeQuery
    {
        public string Language { get; set; }
    }

    public class DataSet
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }

        [JsonProperty("query")]
        public PassThroughNativeQuery[] Query { get; set; }
    }

    public class DataSetsList
    {
        [JsonProperty("value")]
        public DataSet[] Value { get; set; }
    }

    public class ResponseToEventInvite
    {
        public string Comment { get; set; }
        public bool SendResponse { get; set; }
    }

    public class DirectForwardMessage
    {
        public string Comment { get; set; }
        public string ToRecipients { get; set; }
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

    public class InternetMessageHeader
    {
        public string Name { get; set; }
        public string Value { get; set; }
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

    public class SubscriptionPayloadEntityOutlookReceiveMessage
    {
        public int SequenceNumber { get; set; }
        public string ChangeType { get; set; }
        public string ClientState { get; set; }
        public string Resource { get; set; }
        public OutlookReceiveMessage ResourceData { get; set; }
    }

    public class SubscriptionPayloadOutlookReceiveMessage
    {
        [JsonProperty("value")]
        public SubscriptionPayloadEntityOutlookReceiveMessage[] Value { get; set; }
    }

    public class SubscriptionEvent
    {
        public string Id { get; set; }
    }

    public class SubscriptionPayloadEntitySubscriptionEvent
    {
        public int SequenceNumber { get; set; }
        public string ChangeType { get; set; }
        public string ClientState { get; set; }
        public string Resource { get; set; }
        public SubscriptionEvent ResourceData { get; set; }
    }

    public class SubscriptionPayloadSubscriptionEvent
    {
        [JsonProperty("value")]
        public SubscriptionPayloadEntitySubscriptionEvent[] Value { get; set; }
    }

    public enum TableCapabilitiesMetadataFilterFunctionSupportTypeItem
    {
        [EnumMember(Value = "eq")]
        Eq,
        [EnumMember(Value = "ne")]
        Ne,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "ge")]
        Ge,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "le")]
        Le,
        [EnumMember(Value = "and")]
        And,
        [EnumMember(Value = "or")]
        Or,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "startswith")]
        Startswith,
        [EnumMember(Value = "endswith")]
        Endswith,
        [EnumMember(Value = "length")]
        Length,
        [EnumMember(Value = "indexof")]
        Indexof,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "substring")]
        Substring,
        [EnumMember(Value = "substringof")]
        Substringof,
        [EnumMember(Value = "tolower")]
        Tolower,
        [EnumMember(Value = "toupper")]
        Toupper,
        [EnumMember(Value = "trim")]
        Trim,
        [EnumMember(Value = "concat")]
        Concat,
        [EnumMember(Value = "year")]
        Year,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "day")]
        Day,
        [EnumMember(Value = "hour")]
        Hour,
        [EnumMember(Value = "minute")]
        Minute,
        [EnumMember(Value = "second")]
        Second,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "time")]
        Time,
        [EnumMember(Value = "now")]
        Now,
        [EnumMember(Value = "totaloffsetminutes")]
        Totaloffsetminutes,
        [EnumMember(Value = "totalseconds")]
        Totalseconds,
        [EnumMember(Value = "floor")]
        Floor,
        [EnumMember(Value = "ceiling")]
        Ceiling,
        [EnumMember(Value = "round")]
        Round,
        [EnumMember(Value = "not")]
        Not,
        [EnumMember(Value = "negate")]
        Negate,
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "sub")]
        Sub,
        [EnumMember(Value = "mul")]
        Mul,
        [EnumMember(Value = "div")]
        Div,
        [EnumMember(Value = "mod")]
        Mod,
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "average")]
        Average,
        [EnumMember(Value = "countdistinct")]
        Countdistinct,
        [EnumMember(Value = "null")]
        Null
    }

    public enum TableCapabilitiesMetadataServerPagingOptionsTypeItem
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "skiptoken")]
        Skiptoken
    }

    public enum GetEmailsV2importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum ClientSendHtmlMessageImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum ClientReceiveMessageStringEnumsImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum ReplyHtmlMessageImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum OnNewEmailV2importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum OnFlaggedEmailV2importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum OnNewMentionMeEmailV2importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum CreateOnNewEmailPokeSubscriptionimportanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum CreateOnNewMentionMeEmailPokeSubscriptionimportanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum CreateOnFlaggedEmailPokeSubscriptionimportanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum MessageWithOptionsImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum ApprovalMessageImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum CalendarEventHtmlClientTimeZoneType
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

    public enum CalendarEventHtmlClientImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum CalendarEventHtmlClientRecurrenceType
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum CalendarEventHtmlClientShowAsType
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
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

    public enum ResponseStatusResponseType
    {
        None,
        Organizer,
        TentativelyAccepted,
        Accepted,
        Declined,
        NotResponded
    }

    public enum AttendeeTypeType
    {
        Required,
        Optional,
        Resource
    }

    public enum ItemBodyContentTypeType
    {
        Text,
        HTML
    }

    public enum CalendarEventBackendImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum RecurrencePatternTypeType
    {
        Daily,
        Weekly,
        AbsoluteMonthly,
        RelativeMonthly,
        AbsoluteYearly,
        RelativeYearly
    }

    public enum RecurrencePatternDaysOfWeekTypeItem
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum RecurrencePatternFirstDayOfWeekType
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum RecurrencePatternIndexType
    {
        First,
        Second,
        Third,
        Fourth,
        Last
    }

    public enum RecurrenceRangeTypeType
    {
        EndDate,
        NoEnd,
        Numbered
    }

    public enum CalendarEventBackendShowAsType
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
    }

    public enum CalendarEventBackendTypeType
    {
        SingleInstance,
        Occurrence,
        Exception,
        SeriesMaster
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

    public enum RespondToEventresponseInput
    {
        Accept,
        [EnumMember(Value = "Tentatively Accept")]
        TentativelyAccept,
        Decline
    }

    public enum OutlookReceiveMessageImportanceType
    {
        Low,
        Normal,
        High
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Outlook;

    public static class OutlookTriggerInstanceExtensions
    {
        public static OutlookInstanceTriggers Outlook(this WorkflowManagedTriggers t, string connectionId) => new OutlookInstanceTriggers(connectionId);
        public static OutlookInstance Outlook(this WorkflowManagedActions t, string connectionId) => new OutlookInstance(connectionId);
    }
}