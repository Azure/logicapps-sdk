//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Office365
{
    using System.Net;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class Office365Extensions
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<GraphCalendarEventListClientReceive> WhenOnUpcomingEventsV3([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null)
        {
            var apiCallPath = "/v3/Events/OnUpcomingEvents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["table"] = ExpressionConverter.Convert(table);
            if (lookAheadTimeInMinutes != null)
            {
                callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(lookAheadTimeInMinutes);
            }

            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GraphOutlookCategory[]> GetOutlookCategoryNames([ConnectionName] string connectionId)
        {
            var apiCallPath = "/Categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphOutlookCategory[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<OutlookReceiveMessage> DraftEmail([ConnectionName] string connectionId, Expression<Func<ClientDraftHtmlMessage>> draftMessage, Expression<Func<string>> messageId = null, Expression<Func<string>> draftType = null, Expression<Func<string>> comment = null)
        {
            var apiCallPath = "/Draft";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (messageId != null)
            {
                callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
            }

            if (draftType != null)
            {
                callPayload.Queries["draftType"] = ExpressionConverter.Convert(draftType);
            }

            if (comment != null)
            {
                callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
            }

            callPayload.Body = ExpressionConverter.ConvertObject(draftMessage);
            return new ApiConnectionAction<OutlookReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction UpdateDraftEmail([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<ClientDraftHtmlMessage>> draftMessage)
        {
            var apiCallPath = "/Draft";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
            callPayload.Body = ExpressionConverter.ConvertObject(draftMessage);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction SendDraftEmail([ConnectionName] string connectionId, Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/Draft/Send/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction AssignCategory([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> category)
        {
            var apiCallPath = "/Mail/Category";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
            callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<BatchOperationResult> AssignCategoryBulk([ConnectionName] string connectionId, Expression<Func<string>> categoryName, Expression<Func<string[]>> messageIds)
        {
            var apiCallPath = String.Format("/Mail/Category/Bulk/{0}", ExpressionConverter.ConvertWithUrlEncoding(categoryName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(messageIds);
            return new ApiConnectionAction<BatchOperationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction SendEmailV2([ConnectionName] string connectionId, Expression<Func<ClientSendHtmlMessage>> emailMessage)
        {
            var apiCallPath = "/v2/Mail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(emailMessage);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GraphClientReceiveMessage> GetEmailV2([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null, Expression<Func<GetEmailV2extractSensitivityLabelInput>> extractSensitivityLabel = null, Expression<Func<GetEmailV2fetchSensitivityLabelMetadataInput>> fetchSensitivityLabelMetadata = null)
        {
            var apiCallPath = String.Format("/v2/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            if (includeAttachments != null)
            {
                callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
            }

            if (internetMessageId != null)
            {
                callPayload.Queries["internetMessageId"] = ExpressionConverter.Convert(internetMessageId);
            }

            if (extractSensitivityLabel != null)
            {
                callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
            }

            if (fetchSensitivityLabelMetadata != null)
            {
                callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
            }

            return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<BatchResponseGraphClientReceiveMessage> GetEmailsV3([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<GetEmailsV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/v3/Mail";
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

            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
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
            return new ApiConnectionAction<BatchResponseGraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GraphClientReceiveMessage> MoveV2([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> folderPath, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/v2/Mail/Move/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction ReplyToV3([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<ReplyHtmlMessage>> replyParameters, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/v3/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            callPayload.Body = ExpressionConverter.ConvertObject(replyParameters);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnNewEmailV3([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewEmailV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/v3/Mail/OnNewEmail";
            input.Fetch.Method = "get";
            input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Fetch.Queries["importance"] = Convert.ToString(0);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            input.Subscribe.PathTemplate.Template = "/GraphMailSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Subscribe.Queries["importance"] = Convert.ToString(0);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnFlaggedEmailV3([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnFlaggedEmailV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/v3/Mail/OnFlaggedEmail";
            input.Fetch.Method = "get";
            input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Fetch.Queries["importance"] = Convert.ToString(0);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            input.Subscribe.PathTemplate.Template = "/GraphFlaggedMailSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Subscribe.Queries["importance"] = Convert.ToString(0);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnFlaggedEmailV4([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnFlaggedEmailV4importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/v4/Mail/OnFlaggedEmail";
            input.Fetch.Method = "get";
            input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Fetch.Queries["importance"] = Convert.ToString(0);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            input.Subscribe.PathTemplate.Template = "/GraphFlaggedMailSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
            input.Subscribe.Queries["importance"] = Convert.ToString(0);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnNewMentionMeEmailV3([ConnectionName] string connectionId, Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewMentionMeEmailV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/v3/Mail/OnNewMentionMeEmail";
            input.Fetch.Method = "get";
            input.Fetch.Queries["importance"] = Convert.ToString(0);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            input.Subscribe.PathTemplate.Template = "/GraphMentionMeMailSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["importance"] = Convert.ToString(0);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<SubscriptionResponse> SendMailWithOptions([ConnectionName] string connectionId, Expression<Func<OptionsEmailSubscription>> optionsEmailSubscription)
        {
            var apiCallPath = "/mailwithoptions/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(optionsEmailSubscription);
            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<SubscriptionResponse> SendApprovalMail([ConnectionName] string connectionId, Expression<Func<ApprovalEmailSubscription>> approvalEmailSubscription)
        {
            var apiCallPath = "/approvalmail/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(approvalEmailSubscription);
            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction SharedMailboxSendEmailV2([ConnectionName] string connectionId, Expression<Func<SharedMailboxClientSendHtmlMessage>> emailMessage)
        {
            var apiCallPath = "/v2/SharedMailbox/Mail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(emailMessage);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenSharedMailboxOnNewEmailV2([ConnectionName] string connectionId, Expression<Func<string>> mailboxAddress, Expression<Func<string>> folderId = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<SharedMailboxOnNewEmailV2importanceInput>> importance = null, Expression<Func<bool>> hasAttachments = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
        {
            var apiCallPath = "/v2/SharedMailbox/Mail/OnNewEmail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            if (folderId != null)
            {
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
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

            if (hasAttachments != null)
            {
                callPayload.Queries["hasAttachments"] = ExpressionConverter.Convert(hasAttachments);
            }

            if (includeAttachments != null)
            {
                callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
            }

            if (subjectFilter != null)
            {
                callPayload.Queries["subjectFilter"] = ExpressionConverter.Convert(subjectFilter);
            }

            return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GraphCalendarEventListClientReceive> V4CalendarGetItems([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v4/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            return new ApiConnectionAction<GraphCalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GraphCalendarEventClientReceive> V4CalendarPostItem([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<GraphCalendarEventClient>> item)
        {
            var apiCallPath = String.Format("/datasets/calendars/v4/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> GetEventsCalendarViewV3([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeUtc, Expression<Func<string>> endDateTimeUtc, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/datasets/calendars/v3/tables/items/calendarview";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["calendarId"] = ExpressionConverter.Convert(calendarId);
            callPayload.Queries["startDateTimeUtc"] = ExpressionConverter.Convert(startDateTimeUtc);
            callPayload.Queries["endDateTimeUtc"] = ExpressionConverter.Convert(endDateTimeUtc);
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

            return new ApiConnectionAction<EntityListResponseGraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GraphCalendarEventClientReceive> V3CalendarGetItem([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GraphCalendarEventClientReceive> V4CalendarPatchItem([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<GraphCalendarEventClient>> item)
        {
            var apiCallPath = String.Format("/datasets/calendars/v4/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<GraphCalendarEventListClientReceive> WhenCalendarGetOnNewItemsV3([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<GraphCalendarEventListClientReceive> WhenCalendarGetOnUpdatedItemsV3([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/datasets/calendars/v3/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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

            return new ApiConnectionTrigger<GraphCalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowTrigger<GraphCalendarEventListWithActionType> WhenCalendarGetOnChangedItemsV3([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.PathTemplate.Template = "/datasets/calendars/v3/tables/{0}/onchangeditems";
            input.Fetch.Method = "get";
            input.Fetch.Queries["incomingDays"] = Convert.ToString(300);
            input.Fetch.Queries["pastDays"] = Convert.ToString(50);
            input.Subscribe.PathTemplate.Template = "/{0}/GraphEventSubscriptionPoke/$subscriptions";
            input.Subscribe.Method = "post";
            input.Subscribe.Queries["incomingDays"] = Convert.ToString(300);
            input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
            return new ApiConnectionTrigger<GraphCalendarEventListWithActionType>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<EntityListResponseGraphContactFolder> ContactGetTablesV2([ConnectionName] string connectionId)
        {
            var apiCallPath = "/v2/datasets/contacts/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseGraphContactFolder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<string> ExportEmailV2([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/codeless/beta/me/messages/{0}/$value", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction FlagV2([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<UpdateEmailFlag>> body, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}/flag", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction DeleteEmailV2([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GetAttachmentV2Response> GetAttachmentV2([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<string>> attachmentId, Expression<Func<string>> mailboxAddress = null, Expression<Func<GetAttachmentV2extractSensitivityLabelInput>> extractSensitivityLabel = null, Expression<Func<GetAttachmentV2fetchSensitivityLabelMetadataInput>> fetchSensitivityLabelMetadata = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}/attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            if (extractSensitivityLabel != null)
            {
                callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
            }

            if (fetchSensitivityLabelMetadata != null)
            {
                callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
            }

            return new ApiConnectionAction<GetAttachmentV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction RespondToEventV2([ConnectionName] string connectionId, Expression<Func<string>> eventId, Expression<Func<RespondToEventV2responseInput>> response, Expression<Func<ResponseToEventInvite>> body)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/events/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventId, 1), ExpressionConverter.ConvertWithUrlEncoding(response, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction ForwardEmailV2([ConnectionName] string connectionId, Expression<Func<string>> messageId, Expression<Func<DirectForwardMessage>> body, Expression<Func<string>> mailboxAddress = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/messages/{0}/forward", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mailboxAddress != null)
            {
                callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(mailboxAddress);
            }

            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GetRoomListsV2Response> GetRoomListsV2([ConnectionName] string connectionId)
        {
            var apiCallPath = "/codeless/beta/me/findRoomLists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomListsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GetRoomsV2Response> GetRoomsV2([ConnectionName] string connectionId)
        {
            var apiCallPath = "/codeless/beta/me/findRooms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GetRoomsInRoomListV2Response> GetRoomsInRoomListV2([ConnectionName] string connectionId, [DynamicValues("GetRoomLists_V2")] Expression<Func<string>> roomList)
        {
            var apiCallPath = String.Format("/codeless/beta/me/findRooms(RoomList='{0}')", ExpressionConverter.ConvertWithUrlEncoding(roomList, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoomsInRoomListV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<FindMeetingTimesV2Response> FindMeetingTimesV2([ConnectionName] string connectionId, Expression<Func<FindMeetingTimesV2bodyInput>> body)
        {
            var apiCallPath = "/codeless/beta/me/findMeetingTimes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<FindMeetingTimesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<SetAutomaticRepliesSettingV2Response> SetAutomaticRepliesSettingV2([ConnectionName] string connectionId, Expression<Func<SetAutomaticRepliesSettingV2bodyInput>> body)
        {
            var apiCallPath = "/codeless/v1.0/me/mailboxSettings";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<SetAutomaticRepliesSettingV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<GetMailTipsV2Response> GetMailTipsV2([ConnectionName] string connectionId, Expression<Func<GetMailTipsV2bodyInput>> body)
        {
            var apiCallPath = "/codeless/v1.0/me/getMailTips";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<GetMailTipsV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<CalendarGetTablesV2Response> CalendarGetTablesV2([ConnectionName] string connectionId)
        {
            var apiCallPath = "/codeless/v1.0/me/calendars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["skip"] = "0";
            callPayload.Queries["top"] = "256";
            callPayload.Queries["orderBy"] = "name";
            return new ApiConnectionAction<CalendarGetTablesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction CalendarDeleteItemV2([ConnectionName] string connectionId, [DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> calendar, Expression<Func<string>> @event)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/calendars/{0}/events/{1}", ExpressionConverter.ConvertWithUrlEncoding(calendar, 2), ExpressionConverter.ConvertWithUrlEncoding(@event, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<ContactResponseV2> ContactGetItemV2([ConnectionName] string connectionId, [DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction ContactDeleteItemV2([ConnectionName] string connectionId, [DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<ContactResponseV2> ContactPatchItemV2([ConnectionName] string connectionId, [DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<ContactV2>> item)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<ContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<EntityListResponseContactResponseV2> ContactGetItemsV2([ConnectionName] string connectionId, [DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(folder, 2));
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

            return new ApiConnectionAction<EntityListResponseContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<ContactResponseV2> ContactPostItemV2([ConnectionName] string connectionId, [DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<ContactV2>> item)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(folder, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<ContactResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IWorkflowAction UpdateMyContactPhoto([ConnectionName] string connectionId, [DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> body)
        {
            var apiCallPath = String.Format("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}/photo/$value", ExpressionConverter.ConvertWithUrlEncoding(folder, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertObject(body);
            callPayload.Headers["Content-Type"] = "image/jpeg";
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public static IOutputWorkflowAction<JToken> HttpRequest([ConnectionName] string connectionId, Expression<Func<string>> uri, Expression<Func<HttpRequestMethodInput>> method, Expression<Func<string>> body, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
        {
            var apiCallPath = "/codeless/httprequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Uri"] = ExpressionConverter.Convert(uri);
            callPayload.Headers["Method"] = ExpressionConverter.Convert(method);
            if (contentType != null)
            {
                callPayload.Headers["ContentType"] = ExpressionConverter.Convert(contentType);
            }

            if (customHeader1 != null)
            {
                callPayload.Headers["CustomHeader1"] = ExpressionConverter.Convert(customHeader1);
            }

            if (customHeader2 != null)
            {
                callPayload.Headers["CustomHeader2"] = ExpressionConverter.Convert(customHeader2);
            }

            if (customHeader3 != null)
            {
                callPayload.Headers["CustomHeader3"] = ExpressionConverter.Convert(customHeader3);
            }

            if (customHeader4 != null)
            {
                callPayload.Headers["CustomHeader4"] = ExpressionConverter.Convert(customHeader4);
            }

            if (customHeader5 != null)
            {
                callPayload.Headers["CustomHeader5"] = ExpressionConverter.Convert(customHeader5);
            }

            callPayload.Body = ExpressionConverter.ConvertObject(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class Office365Instance(string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GraphOutlookCategory[]> GetOutlookCategoryNames() => Office365Extensions.GetOutlookCategoryNames(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<OutlookReceiveMessage> DraftEmail(Expression<Func<ClientDraftHtmlMessage>> draftMessage, Expression<Func<string>> messageId = null, Expression<Func<string>> draftType = null, Expression<Func<string>> comment = null) => Office365Extensions.DraftEmail(connectionId, draftMessage, messageId, draftType, comment);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateDraftEmail(Expression<Func<string>> messageId, Expression<Func<ClientDraftHtmlMessage>> draftMessage) => Office365Extensions.UpdateDraftEmail(connectionId, messageId, draftMessage);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendDraftEmail(Expression<Func<string>> messageId) => Office365Extensions.SendDraftEmail(connectionId, messageId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction AssignCategory(Expression<Func<string>> messageId, Expression<Func<string>> category) => Office365Extensions.AssignCategory(connectionId, messageId, category);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<BatchOperationResult> AssignCategoryBulk(Expression<Func<string>> categoryName, Expression<Func<string[]>> messageIds) => Office365Extensions.AssignCategoryBulk(connectionId, categoryName, messageIds);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SendEmailV2(Expression<Func<ClientSendHtmlMessage>> emailMessage) => Office365Extensions.SendEmailV2(connectionId, emailMessage);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GraphClientReceiveMessage> GetEmailV2(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null, Expression<Func<GetEmailV2extractSensitivityLabelInput>> extractSensitivityLabel = null, Expression<Func<GetEmailV2fetchSensitivityLabelMetadataInput>> fetchSensitivityLabelMetadata = null) => Office365Extensions.GetEmailV2(connectionId, messageId, mailboxAddress, includeAttachments, internetMessageId, extractSensitivityLabel, fetchSensitivityLabelMetadata);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<BatchResponseGraphClientReceiveMessage> GetEmailsV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<GetEmailsV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null) => Office365Extensions.GetEmailsV3(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, subjectFilter, fetchOnlyUnread, mailboxAddress, includeAttachments, searchQuery, top);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GraphClientReceiveMessage> MoveV2(Expression<Func<string>> messageId, Expression<Func<string>> folderPath, Expression<Func<string>> mailboxAddress = null) => Office365Extensions.MoveV2(connectionId, messageId, folderPath, mailboxAddress);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ReplyToV3(Expression<Func<string>> messageId, Expression<Func<ReplyHtmlMessage>> replyParameters, Expression<Func<string>> mailboxAddress = null) => Office365Extensions.ReplyToV3(connectionId, messageId, replyParameters, mailboxAddress);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<OptionsEmailSubscription>> optionsEmailSubscription) => Office365Extensions.SendMailWithOptions(connectionId, optionsEmailSubscription);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<SubscriptionResponse> SendApprovalMail(Expression<Func<ApprovalEmailSubscription>> approvalEmailSubscription) => Office365Extensions.SendApprovalMail(connectionId, approvalEmailSubscription);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction SharedMailboxSendEmailV2(Expression<Func<SharedMailboxClientSendHtmlMessage>> emailMessage) => Office365Extensions.SharedMailboxSendEmailV2(connectionId, emailMessage);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GraphCalendarEventListClientReceive> V4CalendarGetItems([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => Office365Extensions.V4CalendarGetItems(connectionId, table, filter, orderby, top, skip);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GraphCalendarEventClientReceive> V4CalendarPostItem([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<GraphCalendarEventClient>> item) => Office365Extensions.V4CalendarPostItem(connectionId, table, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<EntityListResponseGraphCalendarEventClientReceive> GetEventsCalendarViewV3([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeUtc, Expression<Func<string>> endDateTimeUtc, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null) => Office365Extensions.GetEventsCalendarViewV3(connectionId, calendarId, startDateTimeUtc, endDateTimeUtc, filter, orderby, top, skip, search);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GraphCalendarEventClientReceive> V3CalendarGetItem([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> id) => Office365Extensions.V3CalendarGetItem(connectionId, table, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GraphCalendarEventClientReceive> V4CalendarPatchItem([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<GraphCalendarEventClient>> item) => Office365Extensions.V4CalendarPatchItem(connectionId, table, id, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<EntityListResponseGraphContactFolder> ContactGetTablesV2() => Office365Extensions.ContactGetTablesV2(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<string> ExportEmailV2(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null) => Office365Extensions.ExportEmailV2(connectionId, messageId, mailboxAddress);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction FlagV2(Expression<Func<string>> messageId, Expression<Func<UpdateEmailFlag>> body, Expression<Func<string>> mailboxAddress = null) => Office365Extensions.FlagV2(connectionId, messageId, body, mailboxAddress);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction DeleteEmailV2(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null) => Office365Extensions.DeleteEmailV2(connectionId, messageId, mailboxAddress);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GetAttachmentV2Response> GetAttachmentV2(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId, Expression<Func<string>> mailboxAddress = null, Expression<Func<GetAttachmentV2extractSensitivityLabelInput>> extractSensitivityLabel = null, Expression<Func<GetAttachmentV2fetchSensitivityLabelMetadataInput>> fetchSensitivityLabelMetadata = null) => Office365Extensions.GetAttachmentV2(connectionId, messageId, attachmentId, mailboxAddress, extractSensitivityLabel, fetchSensitivityLabelMetadata);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction RespondToEventV2(Expression<Func<string>> eventId, Expression<Func<RespondToEventV2responseInput>> response, Expression<Func<ResponseToEventInvite>> body) => Office365Extensions.RespondToEventV2(connectionId, eventId, response, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ForwardEmailV2(Expression<Func<string>> messageId, Expression<Func<DirectForwardMessage>> body, Expression<Func<string>> mailboxAddress = null) => Office365Extensions.ForwardEmailV2(connectionId, messageId, body, mailboxAddress);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GetRoomListsV2Response> GetRoomListsV2() => Office365Extensions.GetRoomListsV2(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GetRoomsV2Response> GetRoomsV2() => Office365Extensions.GetRoomsV2(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GetRoomsInRoomListV2Response> GetRoomsInRoomListV2([DynamicValues("GetRoomLists_V2")] Expression<Func<string>> roomList) => Office365Extensions.GetRoomsInRoomListV2(connectionId, roomList);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<FindMeetingTimesV2Response> FindMeetingTimesV2(Expression<Func<FindMeetingTimesV2bodyInput>> body) => Office365Extensions.FindMeetingTimesV2(connectionId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<SetAutomaticRepliesSettingV2Response> SetAutomaticRepliesSettingV2(Expression<Func<SetAutomaticRepliesSettingV2bodyInput>> body) => Office365Extensions.SetAutomaticRepliesSettingV2(connectionId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<GetMailTipsV2Response> GetMailTipsV2(Expression<Func<GetMailTipsV2bodyInput>> body) => Office365Extensions.GetMailTipsV2(connectionId, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<CalendarGetTablesV2Response> CalendarGetTablesV2() => Office365Extensions.CalendarGetTablesV2(connectionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction CalendarDeleteItemV2([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> calendar, Expression<Func<string>> @event) => Office365Extensions.CalendarDeleteItemV2(connectionId, calendar, @event);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<ContactResponseV2> ContactGetItemV2([DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id) => Office365Extensions.ContactGetItemV2(connectionId, folder, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction ContactDeleteItemV2([DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id) => Office365Extensions.ContactDeleteItemV2(connectionId, folder, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<ContactResponseV2> ContactPatchItemV2([DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<ContactV2>> item) => Office365Extensions.ContactPatchItemV2(connectionId, folder, id, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<EntityListResponseContactResponseV2> ContactGetItemsV2([DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => Office365Extensions.ContactGetItemsV2(connectionId, folder, filter, orderby, top, skip);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<ContactResponseV2> ContactPostItemV2([DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<ContactV2>> item) => Office365Extensions.ContactPostItemV2(connectionId, folder, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction UpdateMyContactPhoto([DynamicValues("ContactGetTablesV2")] Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> body) => Office365Extensions.UpdateMyContactPhoto(connectionId, folder, id, body);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IOutputWorkflowAction<JToken> HttpRequest(Expression<Func<string>> uri, Expression<Func<HttpRequestMethodInput>> method, Expression<Func<string>> body, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null) => Office365Extensions.HttpRequest(connectionId, uri, method, body, contentType, customHeader1, customHeader2, customHeader3, customHeader4, customHeader5);
    }

    public class Office365InstanceTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<GraphCalendarEventListClientReceive> WhenOnUpcomingEventsV3([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null) => Office365Extensions.WhenOnUpcomingEventsV3(connectionId, table, lookAheadTimeInMinutes);
        public IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnNewEmailV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewEmailV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => Office365Extensions.WhenOnNewEmailV3(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnFlaggedEmailV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnFlaggedEmailV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => Office365Extensions.WhenOnFlaggedEmailV3(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnFlaggedEmailV4(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnFlaggedEmailV4importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => Office365Extensions.WhenOnFlaggedEmailV4(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenOnNewMentionMeEmailV3(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewMentionMeEmailV3importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => Office365Extensions.WhenOnNewMentionMeEmailV3(connectionId, folderPath, to, cc, toOrCc, from, importance, fetchOnlyWithAttachment, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage> WhenSharedMailboxOnNewEmailV2(Expression<Func<string>> mailboxAddress, Expression<Func<string>> folderId = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<SharedMailboxOnNewEmailV2importanceInput>> importance = null, Expression<Func<bool>> hasAttachments = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null) => Office365Extensions.WhenSharedMailboxOnNewEmailV2(connectionId, mailboxAddress, folderId, to, cc, toOrCc, from, importance, hasAttachments, includeAttachments, subjectFilter);
        public IOutputWorkflowTrigger<GraphCalendarEventListClientReceive> WhenCalendarGetOnNewItemsV3([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => Office365Extensions.WhenCalendarGetOnNewItemsV3(connectionId, table, orderby, top, skip);
        public IOutputWorkflowTrigger<GraphCalendarEventListClientReceive> WhenCalendarGetOnUpdatedItemsV3([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null) => Office365Extensions.WhenCalendarGetOnUpdatedItemsV3(connectionId, table, orderby, top, skip);
        public IOutputWorkflowTrigger<GraphCalendarEventListWithActionType> WhenCalendarGetOnChangedItemsV3([DynamicValues("CalendarGetTables_V2")] Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null) => Office365Extensions.WhenCalendarGetOnChangedItemsV3(connectionId, table, incomingDays, pastDays);
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

    public class GraphCalendarEventClientReceive
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("startWithTimeZone")]
        public string StartWithTimeZone { get; set; }

        [JsonProperty("endWithTimeZone")]
        public string EndWithTimeZone { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHtml { get; set; }

        [JsonProperty("responseType")]
        public GraphCalendarEventClientReceiveResponseTypeType ResponseType { get; set; }

        [JsonProperty("responseTime")]
        public string ResponseTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

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
        public bool IsAllDay { get; set; }

        [JsonProperty("recurrence")]
        public GraphCalendarEventClientReceiveRecurrenceType Recurrence { get; set; }

        [JsonProperty("recurrenceEnd")]
        public string RecurrenceEnd { get; set; }

        [JsonProperty("numberOfOccurences")]
        public int NumberOfOccurences { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderMinutesBeforeStart { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("showAs")]
        public GraphCalendarEventClientReceiveShowAsType ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("sensitivity")]
        public GraphCalendarEventClientReceiveSensitivityType Sensitivity { get; set; }
    }

    public class GraphCalendarEventListClientReceive
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientReceive[] Value { get; set; }
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

    public class GraphOutlookCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ClientSendAttachment
    {
        public string Name { get; set; }
        public string ContentBytes { get; set; }
    }

    public class ClientDraftHtmlMessage
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
        public string Sensitivity { get; set; }
        public string ReplyTo { get; set; }
        public ClientDraftHtmlMessageImportanceType Importance { get; set; }
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

    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Recipient
    {
        public EmailAddress EmailAddress { get; set; }
    }

    public class ItemBody
    {
        public ItemBodyContentTypeType ContentType { get; set; }
        public string Content { get; set; }
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

    public class BatchItemFailureResult
    {
        public string MessageId { get; set; }
        public string Error { get; set; }
    }

    public class BatchOperationResult
    {
        [JsonProperty("successCount")]
        public int SuccessCount { get; set; }

        [JsonProperty("failures")]
        public BatchItemFailureResult[] Failures { get; set; }
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
        public string Sensitivity { get; set; }
        public string ReplyTo { get; set; }
        public ClientSendHtmlMessageImportanceType Importance { get; set; }
    }

    public class GraphClientReceiveFileAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contentBytes")]
        public string ContentBytes { get; set; }

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

    public class GraphClientReceiveMessage
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("toRecipients")]
        public string ToRecipients { get; set; }

        [JsonProperty("ccRecipients")]
        public string CcRecipients { get; set; }

        [JsonProperty("bccRecipients")]
        public string BccRecipients { get; set; }

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
        public bool HasAttachments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("internetMessageId")]
        public string InternetMessageId { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }

        [JsonProperty("receivedDateTime")]
        public string ReceivedDateTime { get; set; }

        [JsonProperty("isRead")]
        public bool IsRead { get; set; }

        [JsonProperty("attachments")]
        public GraphClientReceiveFileAttachment[] Attachments { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHtml { get; set; }
    }

    public class BatchResponseGraphClientReceiveMessage
    {
        [JsonProperty("value")]
        public GraphClientReceiveMessage[] Value { get; set; }
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

    public class TriggerBatchResponseGraphClientReceiveMessage
    {
        [JsonProperty("value")]
        public GraphClientReceiveMessage[] Value { get; set; }
    }

    public class SensitivityLabel
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string ApplicableTo { get; set; }
        public SensitivityLabel[] SubLabels { get; set; }
    }

    public class BatchResponseSensitivityLabel
    {
        [JsonProperty("value")]
        public SensitivityLabel[] Value { get; set; }
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
        public bool HideMicrosoftFooter { get; set; }
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

    public class SharedMailboxClientSendHtmlMessage
    {
        public string MailboxAddress { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
        public string Sensitivity { get; set; }
        public string ReplyTo { get; set; }
        public SharedMailboxClientSendHtmlMessageImportanceType Importance { get; set; }
    }

    public class GraphCalendarEventClient
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("timeZone")]
        public GraphCalendarEventClientTimeZoneType TimeZone { get; set; }

        [JsonProperty("requiredAttendees")]
        public string RequiredAttendees { get; set; }

        [JsonProperty("optionalAttendees")]
        public string OptionalAttendees { get; set; }

        [JsonProperty("resourceAttendees")]
        public string ResourceAttendees { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("importance")]
        public GraphCalendarEventClientImportanceType Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool IsAllDay { get; set; }

        [JsonProperty("recurrence")]
        public GraphCalendarEventClientRecurrenceType Recurrence { get; set; }

        [JsonProperty("selectedDaysOfWeek")]
        public GraphCalendarEventClientSelectedDaysOfWeekTypeItem[] SelectedDaysOfWeek { get; set; }

        [JsonProperty("recurrenceEnd")]
        public string RecurrenceEnd { get; set; }

        [JsonProperty("numberOfOccurences")]
        public int NumberOfOccurences { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderMinutesBeforeStart { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("showAs")]
        public GraphCalendarEventClientShowAsType ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("sensitivity")]
        public GraphCalendarEventClientSensitivityType Sensitivity { get; set; }
    }

    public class EntityListResponseGraphCalendarEventClientReceive
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientReceive[] Value { get; set; }
    }

    public class ResponseStatus
    {
        public ResponseStatusResponseType Response { get; set; }
        public string Time { get; set; }
    }

    public class Attendee
    {
        public ResponseStatus Status { get; set; }
        public AttendeeTypeType Type { get; set; }
        public EmailAddress EmailAddress { get; set; }
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

    public class GraphCalendarEventClientWithActionType
    {
        public GraphCalendarEventClientWithActionTypeActionTypeType ActionType { get; set; }
        public bool IsAdded { get; set; }
        public bool IsUpdated { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("startWithTimeZone")]
        public string StartWithTimeZone { get; set; }

        [JsonProperty("endWithTimeZone")]
        public string EndWithTimeZone { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHtml { get; set; }

        [JsonProperty("responseType")]
        public GraphCalendarEventClientWithActionTypeResponseTypeType ResponseType { get; set; }

        [JsonProperty("responseTime")]
        public string ResponseTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

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
        public bool IsAllDay { get; set; }

        [JsonProperty("recurrence")]
        public GraphCalendarEventClientWithActionTypeRecurrenceType Recurrence { get; set; }

        [JsonProperty("recurrenceEnd")]
        public string RecurrenceEnd { get; set; }

        [JsonProperty("numberOfOccurences")]
        public int NumberOfOccurences { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int ReminderMinutesBeforeStart { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("showAs")]
        public GraphCalendarEventClientWithActionTypeShowAsType ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool ResponseRequested { get; set; }

        [JsonProperty("sensitivity")]
        public GraphCalendarEventClientWithActionTypeSensitivityType Sensitivity { get; set; }
    }

    public class GraphCalendarEventListWithActionType
    {
        [JsonProperty("value")]
        public GraphCalendarEventClientWithActionType[] Value { get; set; }
    }

    public class GraphContactFolder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class EntityListResponseGraphContactFolder
    {
        [JsonProperty("value")]
        public GraphContactFolder[] Value { get; set; }
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

    public class UpdateEmailFlagFlagType
    {
        [JsonProperty("flagStatus")]
        public UpdateEmailFlagFlagTypeFlagStatusType FlagStatus { get; set; }
    }

    public class UpdateEmailFlag
    {
        [JsonProperty("flag")]
        public UpdateEmailFlagFlagType Flag { get; set; }
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

    public class GetRoomListsV2ResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class GetRoomListsV2Response
    {
        [JsonProperty("value")]
        public GetRoomListsV2ResponseValueTypeItem[] Value { get; set; }
    }

    public class GetRoomsV2ResponseValueTypeItem
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

    public class GetRoomsInRoomListV2ResponseValueTypeItem
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

    public class FindMeetingTimesV2bodyInput
    {
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public int MeetingDuration { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public int MaxCandidates { get; set; }
        public string MinimumAttendeePercentage { get; set; }
        public bool IsOrganizerOptional { get; set; }
        public FindMeetingTimesV2bodyInputActivityDomainType ActivityDomain { get; set; }
    }

    public class DateTimeTimeZoneV2
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemMeetingTimeSlotType
    {
        [JsonProperty("start")]
        public DateTimeTimeZoneV2 Start { get; set; }

        [JsonProperty("end")]
        public DateTimeTimeZoneV2 End { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeTypeEmailAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("emailAddress")]
        public MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeTypeEmailAddressType EmailAddress { get; set; }
    }

    public class MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItem
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("attendee")]
        public MeetingTimeSuggestionsV2ItemAttendeeAvailabilityTypeItemAttendeeType Attendee { get; set; }
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

    public class MeetingTimeSuggestionsV2ItemLocationsTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("locationEmailAddress")]
        public string LocationEmailAddress { get; set; }

        [JsonProperty("address")]
        public MeetingTimeSuggestionsV2ItemLocationsTypeItemAddressType Address { get; set; }
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

    public class FindMeetingTimesV2Response
    {
        [JsonProperty("emptySuggestionsReason")]
        public string EmptySuggestionsReason { get; set; }

        [JsonProperty("meetingTimeSuggestions")]
        public MeetingTimeSuggestionsV2Item[] MeetingTimeSuggestions { get; set; }
    }

    public class AutomaticRepliesSettingClientV2ScheduledStartDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class AutomaticRepliesSettingClientV2ScheduledEndDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class AutomaticRepliesSettingClientV2
    {
        [JsonProperty("status")]
        public AutomaticRepliesSettingClientV2StatusType Status { get; set; }

        [JsonProperty("externalAudience")]
        public AutomaticRepliesSettingClientV2ExternalAudienceType ExternalAudience { get; set; }

        [JsonProperty("scheduledStartDateTime")]
        public AutomaticRepliesSettingClientV2ScheduledStartDateTimeType ScheduledStartDateTime { get; set; }

        [JsonProperty("scheduledEndDateTime")]
        public AutomaticRepliesSettingClientV2ScheduledEndDateTimeType ScheduledEndDateTime { get; set; }

        [JsonProperty("internalReplyMessage")]
        public string InternalReplyMessage { get; set; }

        [JsonProperty("externalReplyMessage")]
        public string ExternalReplyMessage { get; set; }
    }

    public class SetAutomaticRepliesSettingV2bodyInput
    {
        [JsonProperty("automaticRepliesSetting")]
        public AutomaticRepliesSettingClientV2 AutomaticRepliesSetting { get; set; }
    }

    public class SetAutomaticRepliesSettingV2Response
    {
        [JsonProperty("automaticRepliesSetting")]
        public AutomaticRepliesSettingClientV2 AutomaticRepliesSetting { get; set; }
    }

    public class GetMailTipsV2bodyInput
    {
        public string MailTipsOptions { get; set; }
        public string[] EmailAddresses { get; set; }
    }

    public class MailTipsAutomaticRepliesV2
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class MailTipsClientReceiveV2
    {
        [JsonProperty("automaticReplies")]
        public MailTipsAutomaticRepliesV2 AutomaticReplies { get; set; }

        [JsonProperty("deliveryRestricted")]
        public bool DeliveryRestricted { get; set; }

        [JsonProperty("externalMemberCount")]
        public int ExternalMemberCount { get; set; }

        [JsonProperty("isModerated")]
        public bool IsModerated { get; set; }

        [JsonProperty("mailboxFull")]
        public bool MailboxFull { get; set; }

        [JsonProperty("maxMessageSize")]
        public int MaxMessageSize { get; set; }

        [JsonProperty("totalMemberCount")]
        public int TotalMemberCount { get; set; }
    }

    public class GetMailTipsV2Response
    {
        [JsonProperty("value")]
        public MailTipsClientReceiveV2[] Value { get; set; }
    }

    public class EmailAddressV2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class CalendarGetTablesV2ResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public EmailAddressV2 Owner { get; set; }
    }

    public class CalendarGetTablesV2Response
    {
        [JsonProperty("value")]
        public CalendarGetTablesV2ResponseValueTypeItem[] Value { get; set; }
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
        public string NickName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("generation")]
        public string Generation { get; set; }

        [JsonProperty("emailAddresses")]
        public EmailAddressV2[] EmailAddresses { get; set; }

        [JsonProperty("imAddresses")]
        public string[] ImAddresses { get; set; }

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
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }
    }

    public class ContactV2
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
        public string NickName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("generation")]
        public string Generation { get; set; }

        [JsonProperty("emailAddresses")]
        public EmailAddressV2[] EmailAddresses { get; set; }

        [JsonProperty("imAddresses")]
        public string[] ImAddresses { get; set; }

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
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }
    }

    public class EntityListResponseContactResponseV2
    {
        [JsonProperty("value")]
        public ContactResponseV2[] Value { get; set; }
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

    public enum ClientDraftHtmlMessageImportanceType
    {
        Low,
        Normal,
        High
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

    public enum ClientSendHtmlMessageImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum GetEmailV2extractSensitivityLabelInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public enum GetEmailV2fetchSensitivityLabelMetadataInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
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

    public enum GetEmailsV3importanceInput
    {
        Any,
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

    public enum OnNewEmailV3importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum OnFlaggedEmailV3importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum OnFlaggedEmailV4importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum OnNewMentionMeEmailV3importanceInput
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

    public enum CreateGraphOnNewEmailPokeSubscriptionimportanceInput
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

    public enum CreateGraphOnNewMentionMeEmailPokeSubscriptionimportanceInput
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

    public enum CreateGraphOnFlaggedEmailPokeSubscriptionimportanceInput
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

    public enum SharedMailboxClientSendHtmlMessageImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum SharedMailboxOnNewEmailV2importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public enum GraphCalendarEventClientTimeZoneType
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

    public enum GraphCalendarEventClientImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public enum GraphCalendarEventClientRecurrenceType
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

    public enum GraphCalendarEventClientSelectedDaysOfWeekTypeItem
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum GraphCalendarEventClientShowAsType
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

    public enum GraphCalendarEventClientSensitivityType
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

    public enum UpdateEmailFlagFlagTypeFlagStatusType
    {
        [EnumMember(Value = "flagged")]
        Flagged,
        [EnumMember(Value = "notFlagged")]
        NotFlagged,
        [EnumMember(Value = "complete")]
        Complete
    }

    public enum GetAttachmentV2extractSensitivityLabelInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public enum GetAttachmentV2fetchSensitivityLabelMetadataInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public enum RespondToEventV2responseInput
    {
        [EnumMember(Value = "accept")]
        Accept,
        [EnumMember(Value = "tentativelyAccept")]
        TentativelyAccept,
        [EnumMember(Value = "decline")]
        Decline
    }

    public enum FindMeetingTimesV2bodyInputActivityDomainType
    {
        Work,
        Personal,
        Unrestricted,
        Unknown
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

    public enum HttpRequestMethodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365;

    public static class Office365TriggerInstanceExtensions
    {
        public static Office365InstanceTriggers Office365(this WorkflowManagedTriggers t, string connectionId) => new Office365InstanceTriggers(connectionId);
        public static Office365Instance Office365(this WorkflowManagedActions t, string connectionId) => new Office365Instance(connectionId);
    }
}