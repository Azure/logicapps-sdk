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
        public IBodyWorkflowAction<ClientReceiveMessage, ApiConnectionActionConfiguration> GetEmail(Expression<Func<string>> messageId, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_internetMessageId = WorkflowExpression.Compile(internetMessageId, nameof(internetMessageId), required: false);
            return new DeferredBodyAction<ClientReceiveMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/{0}", __workflow_messageId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEmail(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessageStringEnums, ApiConnectionActionConfiguration> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<ClientReceiveMessageStringEnums, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/Move/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionAction<ClientReceiveMessageStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Flag(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/Flag/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarkAsRead(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/MarkAsRead/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/{0}/Attachments/{1}", __workflow_messageId.WithUrlEncoding(1), __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse, ApiConnectionActionConfiguration> SendMailWithOptions(Expression<Func<OptionsEmailSubscriptionInput>> optionsEmailSubscription)
        {
            var __workflow_optionsEmailSubscription = WorkflowExpression.Compile(optionsEmailSubscription, nameof(optionsEmailSubscription), required: true);
            return new DeferredBodyAction<SubscriptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mailwithoptions/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_optionsEmailSubscription);
                return new ApiConnectionAction<SubscriptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse, ApiConnectionActionConfiguration> SendApprovalMail(Expression<Func<ApprovalEmailSubscriptionInput>> approvalEmailSubscription)
        {
            var __workflow_approvalEmailSubscription = WorkflowExpression.Compile(approvalEmailSubscription, nameof(approvalEmailSubscription), required: true);
            return new DeferredBodyAction<SubscriptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/approvalmail/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_approvalEmailSubscription);
                return new ApiConnectionAction<SubscriptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable, ApiConnectionActionConfiguration> CalendarGetTables()
        {
            return new DeferredBodyAction<EntityListResponseTable, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/calendars/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntityListResponseTable>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CalendarDeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable, ApiConnectionActionConfiguration> ContactGetTables()
        {
            return new DeferredBodyAction<EntityListResponseTable, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets/contacts/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntityListResponseTable>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseContactResponse, ApiConnectionActionConfiguration> ContactGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EntityListResponseContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/contacts/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
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
        public IBodyWorkflowAction<ContactResponse, ApiConnectionActionConfiguration> ContactPostItem(Expression<Func<string>> table, Expression<Func<ContactPatchItemItemInput>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<ContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/contacts/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse, ApiConnectionActionConfiguration> ContactGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/contacts/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactDeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/contacts/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse, ApiConnectionActionConfiguration> ContactPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<ContactPatchItemItemInput>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<ContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/contacts/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RespondToEvent(Expression<Func<string>> eventId, Expression<Func<ResponseInput>> response, Expression<Func<RespondToEventBodyInput>> body = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_response = WorkflowExpression.Compile(response, nameof(response), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/api/v2.0/me/events/{0}/{1}", __workflow_eventId.WithUrlEncoding(1), __workflow_response.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new RespondToEventBodyInput().ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ForwardEmail(Expression<Func<string>> messageId, Expression<Func<ForwardEmailBodyInput>> body)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/api/v2.0/me/messages/{0}/forward", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration> CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v2/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventListClientReceive, ApiConnectionActionConfiguration> CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<CalendarEventListClientReceive, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v3/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
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
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration> CalendarPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<CalendarPatchItemItemInput>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration> CalendarPostItem(Expression<Func<string>> table, Expression<Func<CalendarPatchItemItemInput>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<CalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v3/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<BatchResponseClientReceiveMessage, ApiConnectionActionConfiguration> GetEmails(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<ImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
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
            return new DeferredBodyAction<BatchResponseClientReceiveMessage, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration> GetEventsCalendarView(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeOffset, Expression<Func<string>> endDateTimeOffset, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_startDateTimeOffset = WorkflowExpression.Compile(startDateTimeOffset, nameof(startDateTimeOffset), required: true);
            var __workflow_endDateTimeOffset = WorkflowExpression.Compile(endDateTimeOffset, nameof(endDateTimeOffset), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<EntityListResponseCalendarEventClientReceiveStringEnums, ApiConnectionActionConfiguration>(() =>
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplyTo(Expression<Func<string>> messageId, Expression<Func<ReplyParametersInput>> replyParameters)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_replyParameters = WorkflowExpression.Compile(replyParameters, nameof(replyParameters), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/Mail/ReplyTo/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_replyParameters);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEmail(Expression<Func<EmailMessageInput>> emailMessage)
        {
            var __workflow_emailMessage = WorkflowExpression.Compile(emailMessage, nameof(emailMessage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_emailMessage);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class OutlookTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CalendarEventListWithActionType, ApiConnectionTriggerConfiguration> CalendarGetOnChangedItems(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_incomingDays = WorkflowExpression.Compile(incomingDays, nameof(incomingDays), required: false);
            var __workflow_pastDays = WorkflowExpression.Compile(pastDays, nameof(pastDays), required: false);
            return new DeferredBodyTrigger<CalendarEventListWithActionType, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/datasets/calendars/v2/tables/{table}/onchangeditems",
                        Parameters = new Dictionary<string, string>()
                    },
                    Method = "get",
                };
                input.Fetch.PathTemplate.Parameters["table"] = ExpressionConverter.Convert(__workflow_table.WithUrlEncoding(2));
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
                        Template = "/{table}/EventSubscriptionPoke/$subscriptions",
                        Parameters = new Dictionary<string, string>()
                    },
                    Method = "post",
                };
                input.Subscribe.PathTemplate.Parameters["table"] = ExpressionConverter.Convert(__workflow_table.WithUrlEncoding(2));
                input.Subscribe.Queries["incomingDays"] = Convert.ToString(300);
                if (__workflow_incomingDays != null)
                    input.Subscribe.Queries["incomingDays"] = ExpressionConverter.Convert(__workflow_incomingDays);
                input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
                if (__workflow_pastDays != null)
                    input.Subscribe.Queries["pastDays"] = ExpressionConverter.Convert(__workflow_pastDays);
                input.Subscribe.Body = new SubscriptionInput().ToJToken();
                return new ApiConnectionTrigger<CalendarEventListWithActionType>(input);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration> CalendarGetOnNewItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v2/tables/{0}/onnewitems", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionPollingTrigger<CalendarEventListClientReceive>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration> CalendarGetOnUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v2/tables/{0}/onupdateditems", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionPollingTrigger<CalendarEventListClientReceive>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage, ApiConnectionTriggerConfiguration> OnFlaggedEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<ImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
            return new DeferredBodyTrigger<TriggerBatchResponseClientReceiveMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnFlaggedEmail",
                        Parameters = new Dictionary<string, string>()
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
                        Template = "/FlaggedMailSubscriptionPoke/$subscriptions",
                        Parameters = new Dictionary<string, string>()
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
                input.Subscribe.Body = new SubscriptionInput().ToJToken();
                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage, ApiConnectionTriggerConfiguration> OnNewEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<ImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
            return new DeferredBodyTrigger<TriggerBatchResponseClientReceiveMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnNewEmail",
                        Parameters = new Dictionary<string, string>()
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
                        Template = "/MailSubscriptionPoke/$subscriptions",
                        Parameters = new Dictionary<string, string>()
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
                input.Subscribe.Body = new SubscriptionInput().ToJToken();
                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage, ApiConnectionTriggerConfiguration> OnNewMentionMeEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<ImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
            return new DeferredBodyTrigger<TriggerBatchResponseClientReceiveMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnNewMentionMeEmail",
                        Parameters = new Dictionary<string, string>()
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
                        Template = "/MentionMeMailSubscriptionPoke/$subscriptions",
                        Parameters = new Dictionary<string, string>()
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
                input.Subscribe.Body = new SubscriptionInput().ToJToken();
                return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration> OnUpcomingEvents(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_lookAheadTimeInMinutes = WorkflowExpression.Compile(lookAheadTimeInMinutes, nameof(lookAheadTimeInMinutes), required: false);
            return new DeferredBodyTrigger<CalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = ExpressionConverter.Convert(__workflow_table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (__workflow_lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(__workflow_lookAheadTimeInMinutes);
                return new ApiConnectionPollingTrigger<CalendarEventListClientReceive>(callPayload);
            });
        }
    }

    public class ClientReceiveMessage
    {
        public string From { get; set; }
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }
        public string Bcc { get; set; }
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
        public bool IsHtml { get; set; }
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
        public string Bcc { get; set; }
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
        public bool IsHtml { get; set; }
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

    public class OptionsEmailSubscriptionInput
    {
        public OptionsEmailSubscriptionInput(MessageWithOptions message)
        {
            this.Message = message;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MessageWithOptions Message { get; set; }
    }

    public class MessageWithOptions
    {
        public MessageWithOptions(string to)
        {
            this.To = to;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; } = "Your input is required";

        [JsonProperty("Options", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserOptions { get; set; } = "Choice1, Choice2, Choice3";
        public string HeaderText { get; set; }
        public string SelectionText { get; set; }
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MessageWithOptionsImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Outlook.MessageWithOptionsImportanceType.Normal;
        public ClientSendAttachment[] Attachments { get; set; }

        [JsonProperty("UseOnlyHTMLMessage")]
        public bool? UseOnlyHtmlMessage { get; set; }

        [JsonProperty("HideHTMLMessage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideHtmlMessage { get; set; } = false;

        [JsonProperty("ShowHTMLConfirmationDialog", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHtmlConfirmationDialog { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageWithOptionsImportanceType
    {
        Low,
        Normal,
        High
    }

    public class ClientSendAttachment
    {
        public ClientSendAttachment(string name, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent content)
        {
            this.Name = name;
            this.Content = content;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("ContentBytes", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Content { get; set; }
    }

    public class ApprovalEmailSubscriptionInput
    {
        public ApprovalEmailSubscriptionInput(ApprovalMessage message)
        {
            this.Message = message;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ApprovalMessage Message { get; set; }
    }

    public class ApprovalMessage
    {
        public ApprovalMessage(string to)
        {
            this.To = to;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; } = "Approval Request";

        [JsonProperty("Options", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserOptions { get; set; } = "Approve, Reject";
        public string HeaderText { get; set; }
        public string SelectionText { get; set; }
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ApprovalMessageImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Outlook.ApprovalMessageImportanceType.Normal;
        public ClientSendAttachment[] Attachments { get; set; }

        [JsonProperty("UseOnlyHTMLMessage")]
        public bool? UseOnlyHtmlMessage { get; set; }

        [JsonProperty("HideHTMLMessage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideHtmlMessage { get; set; } = false;

        [JsonProperty("ShowHTMLConfirmationDialog", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHtmlConfirmationDialog { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApprovalMessageImportanceType
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
        public ContactGetItemEmailAddressResponse[] EmailAddresses { get; set; }

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
        public ContactGetItemPhysicalAddressResponse HomeAddress { get; set; }
        public ContactGetItemPhysicalAddressResponse BusinessAddress { get; set; }
        public ContactGetItemPhysicalAddressResponse OtherAddress { get; set; }
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

    public class ContactGetItemEmailAddressResponse
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class ContactGetItemPhysicalAddressResponse
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryOrRegion { get; set; }
        public string PostalCode { get; set; }
    }

    public class ContactPatchItemItemInput
    {
        public ContactPatchItemItemInput(string givenName, string[] homePhones)
        {
            this.GivenName = givenName;
            this.HomePhones = homePhones;
        }

        public string Id { get; set; }
        public string ParentFolderId { get; set; }
        public string Birthday { get; set; }
        public string FileAs { get; set; }
        public string DisplayName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GivenName { get; set; }
        public string Initials { get; set; }
        public string MiddleName { get; set; }

        [JsonProperty("NickName")]
        public string Nickname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Generation { get; set; }
        public ContactPatchItemEmailAddress[] EmailAddresses { get; set; }

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

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] HomePhones { get; set; }
        public string[] BusinessPhones { get; set; }

        [JsonProperty("MobilePhone1")]
        public string MobilePhone { get; set; }
        public ContactPatchItemPhysicalAddress HomeAddress { get; set; }
        public ContactPatchItemPhysicalAddress BusinessAddress { get; set; }
        public ContactPatchItemPhysicalAddress OtherAddress { get; set; }
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

    public class ContactPatchItemEmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class ContactPatchItemPhysicalAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryOrRegion { get; set; }
        public string PostalCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResponseInput
    {
        Accept,
        [EnumMember(Value = "Tentatively Accept")]
        TentativelyAccept,
        Decline
    }

    public class RespondToEventBodyInput
    {
        public string Comment { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendResponse { get; set; } = true;
    }

    public class ForwardEmailBodyInput
    {
        public ForwardEmailBodyInput(string to)
        {
            this.To = to;
        }

        public string Comment { get; set; }

        [JsonProperty("ToRecipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }
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
        public string EventUniqueId { get; set; }
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
        public bool IsHtml { get; set; }
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
        public string EventUniqueId { get; set; }
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
        public bool IsHtml { get; set; }
        public string Location { get; set; }

        [JsonProperty("IsAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public class CalendarPatchItemItemInput
    {
        public CalendarPatchItemItemInput(string subject, string startTime, string endTime)
        {
            this.Subject = subject;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("Start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("End", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }
        public ItemInputTimeZoneType? TimeZone { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }
        public string Location { get; set; }
        public ItemInputImportanceType? Importance { get; set; }

        [JsonProperty("IsAllDay")]
        public bool? IsAllDayEvent { get; set; }
        public ItemInputRecurrenceType? Recurrence { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int? NumberOfOccurrences { get; set; }
        public int? Reminder { get; set; }
        public ItemInputShowAsType? ShowAs { get; set; }
        public bool? ResponseRequested { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemInputTimeZoneType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "(UTC-12:00) International Date Line West")]
        Utc1200InternationalDateLineWest,
        [EnumMember(Value = "(UTC-11:00) Coordinated Universal Time-11")]
        Utc1100CoordinatedUniversalTime11,
        [EnumMember(Value = "(UTC-10:00) Aleutian Islands")]
        Utc1000AleutianIslands,
        [EnumMember(Value = "(UTC-10:00) Hawaii")]
        Utc1000Hawaii,
        [EnumMember(Value = "(UTC-09:30) Marquesas Islands")]
        Utc0930MarquesasIslands,
        [EnumMember(Value = "(UTC-09:00) Alaska")]
        Utc0900Alaska,
        [EnumMember(Value = "(UTC-09:00) Coordinated Universal Time-09")]
        Utc0900CoordinatedUniversalTime09,
        [EnumMember(Value = "(UTC-08:00) Baja California")]
        Utc0800BajaCalifornia,
        [EnumMember(Value = "(UTC-08:00) Coordinated Universal Time-08")]
        Utc0800CoordinatedUniversalTime08,
        [EnumMember(Value = "(UTC-08:00) Pacific Time (US & Canada)")]
        Utc0800PacificTimeUSCanada,
        [EnumMember(Value = "(UTC-07:00) Arizona")]
        Utc0700Arizona,
        [EnumMember(Value = "(UTC-07:00) Chihuahua, La Paz, Mazatlan")]
        Utc0700ChihuahuaLaPazMazatlan,
        [EnumMember(Value = "(UTC-07:00) Mountain Time (US & Canada)")]
        Utc0700MountainTimeUSCanada,
        [EnumMember(Value = "(UTC-06:00) Central America")]
        Utc0600CentralAmerica,
        [EnumMember(Value = "(UTC-06:00) Central Time (US & Canada)")]
        Utc0600CentralTimeUSCanada,
        [EnumMember(Value = "(UTC-06:00) Easter Island")]
        Utc0600EasterIsland,
        [EnumMember(Value = "(UTC-06:00) Guadalajara, Mexico City, Monterrey")]
        Utc0600GuadalajaraMexicoCityMonterrey,
        [EnumMember(Value = "(UTC-06:00) Saskatchewan")]
        Utc0600Saskatchewan,
        [EnumMember(Value = "(UTC-05:00) Bogota, Lima, Quito, Rio Branco")]
        Utc0500BogotaLimaQuitoRioBranco,
        [EnumMember(Value = "(UTC-05:00) Chetumal")]
        Utc0500Chetumal,
        [EnumMember(Value = "(UTC-05:00) Eastern Time (US & Canada)")]
        Utc0500EasternTimeUSCanada,
        [EnumMember(Value = "(UTC-05:00) Haiti")]
        Utc0500Haiti,
        [EnumMember(Value = "(UTC-05:00) Havana")]
        Utc0500Havana,
        [EnumMember(Value = "(UTC-05:00) Indiana (East)")]
        Utc0500IndianaEast,
        [EnumMember(Value = "(UTC-04:00) Asuncion")]
        Utc0400Asuncion,
        [EnumMember(Value = "(UTC-04:00) Atlantic Time (Canada)")]
        Utc0400AtlanticTimeCanada,
        [EnumMember(Value = "(UTC-04:00) Caracas")]
        Utc0400Caracas,
        [EnumMember(Value = "(UTC-04:00) Cuiaba")]
        Utc0400Cuiaba,
        [EnumMember(Value = "(UTC-04:00) Georgetown, La Paz, Manaus, San Juan")]
        Utc0400GeorgetownLaPazManausSanJuan,
        [EnumMember(Value = "(UTC-04:00) Santiago")]
        Utc0400Santiago,
        [EnumMember(Value = "(UTC-04:00) Turks and Caicos")]
        Utc0400TurksAndCaicos,
        [EnumMember(Value = "(UTC-03:30) Newfoundland")]
        Utc0330Newfoundland,
        [EnumMember(Value = "(UTC-03:00) Araguaina")]
        Utc0300Araguaina,
        [EnumMember(Value = "(UTC-03:00) Brasilia")]
        Utc0300Brasilia,
        [EnumMember(Value = "(UTC-03:00) Cayenne, Fortaleza")]
        Utc0300CayenneFortaleza,
        [EnumMember(Value = "(UTC-03:00) City of Buenos Aires")]
        Utc0300CityOfBuenosAires,
        [EnumMember(Value = "(UTC-03:00) Greenland")]
        Utc0300Greenland,
        [EnumMember(Value = "(UTC-03:00) Montevideo")]
        Utc0300Montevideo,
        [EnumMember(Value = "(UTC-03:00) Punta Arenas")]
        Utc0300PuntaArenas,
        [EnumMember(Value = "(UTC-03:00) Saint Pierre and Miquelon")]
        Utc0300SaintPierreAndMiquelon,
        [EnumMember(Value = "(UTC-03:00) Salvador")]
        Utc0300Salvador,
        [EnumMember(Value = "(UTC-02:00) Coordinated Universal Time-02")]
        Utc0200CoordinatedUniversalTime02,
        [EnumMember(Value = "(UTC-02:00) Mid-Atlantic - Old")]
        Utc0200MidAtlanticOld,
        [EnumMember(Value = "(UTC-01:00) Azores")]
        Utc0100Azores,
        [EnumMember(Value = "(UTC-01:00) Cabo Verde Is.")]
        Utc0100CaboVerdeIs,
        [EnumMember(Value = "(UTC) Coordinated Universal Time")]
        UtcCoordinatedUniversalTime,
        [EnumMember(Value = "(UTC+00:00) Casablanca")]
        Utc0000Casablanca,
        [EnumMember(Value = "(UTC+00:00) Dublin, Edinburgh, Lisbon, London")]
        Utc0000DublinEdinburghLisbonLondon,
        [EnumMember(Value = "(UTC+00:00) Monrovia, Reykjavik")]
        Utc0000MonroviaReykjavik,
        [EnumMember(Value = "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna")]
        Utc0100AmsterdamBerlinBernRomeStockholmVienna,
        [EnumMember(Value = "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague")]
        Utc0100BelgradeBratislavaBudapestLjubljanaPrague,
        [EnumMember(Value = "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris")]
        Utc0100BrusselsCopenhagenMadridParis,
        [EnumMember(Value = "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb")]
        Utc0100SarajevoSkopjeWarsawZagreb,
        [EnumMember(Value = "(UTC+01:00) West Central Africa")]
        Utc0100WestCentralAfrica,
        [EnumMember(Value = "(UTC+01:00) Windhoek")]
        Utc0100Windhoek,
        [EnumMember(Value = "(UTC+02:00) Amman")]
        Utc0200Amman,
        [EnumMember(Value = "(UTC+02:00) Athens, Bucharest")]
        Utc0200AthensBucharest,
        [EnumMember(Value = "(UTC+02:00) Beirut")]
        Utc0200Beirut,
        [EnumMember(Value = "(UTC+02:00) Cairo")]
        Utc0200Cairo,
        [EnumMember(Value = "(UTC+02:00) Chisinau")]
        Utc0200Chisinau,
        [EnumMember(Value = "(UTC+02:00) Damascus")]
        Utc0200Damascus,
        [EnumMember(Value = "(UTC+02:00) Gaza, Hebron")]
        Utc0200GazaHebron,
        [EnumMember(Value = "(UTC+02:00) Harare, Pretoria")]
        Utc0200HararePretoria,
        [EnumMember(Value = "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius")]
        Utc0200HelsinkiKyivRigaSofiaTallinnVilnius,
        [EnumMember(Value = "(UTC+02:00) Jerusalem")]
        Utc0200Jerusalem,
        [EnumMember(Value = "(UTC+02:00) Kaliningrad")]
        Utc0200Kaliningrad,
        [EnumMember(Value = "(UTC+02:00) Tripoli")]
        Utc0200Tripoli,
        [EnumMember(Value = "(UTC+03:00) Baghdad")]
        Utc0300Baghdad,
        [EnumMember(Value = "(UTC+03:00) Istanbul")]
        Utc0300Istanbul,
        [EnumMember(Value = "(UTC+03:00) Kuwait, Riyadh")]
        Utc0300KuwaitRiyadh,
        [EnumMember(Value = "(UTC+03:00) Minsk")]
        Utc0300Minsk,
        [EnumMember(Value = "(UTC+03:00) Moscow, St. Petersburg")]
        Utc0300MoscowStPetersburg,
        [EnumMember(Value = "(UTC+03:00) Nairobi")]
        Utc0300Nairobi,
        [EnumMember(Value = "(UTC+03:30) Tehran")]
        Utc0330Tehran,
        [EnumMember(Value = "(UTC+04:00) Abu Dhabi, Muscat")]
        Utc0400AbuDhabiMuscat,
        [EnumMember(Value = "(UTC+04:00) Astrakhan, Ulyanovsk")]
        Utc0400AstrakhanUlyanovsk,
        [EnumMember(Value = "(UTC+04:00) Baku")]
        Utc0400Baku,
        [EnumMember(Value = "(UTC+04:00) Izhevsk, Samara")]
        Utc0400IzhevskSamara,
        [EnumMember(Value = "(UTC+04:00) Port Louis")]
        Utc0400PortLouis,
        [EnumMember(Value = "(UTC+04:00) Saratov")]
        Utc0400Saratov,
        [EnumMember(Value = "(UTC+04:00) Tbilisi")]
        Utc0400Tbilisi,
        [EnumMember(Value = "(UTC+04:00) Volgograd")]
        Utc0400Volgograd,
        [EnumMember(Value = "(UTC+04:00) Yerevan")]
        Utc0400Yerevan,
        [EnumMember(Value = "(UTC+04:30) Kabul")]
        Utc0430Kabul,
        [EnumMember(Value = "(UTC+05:00) Ashgabat, Tashkent")]
        Utc0500AshgabatTashkent,
        [EnumMember(Value = "(UTC+05:00) Ekaterinburg")]
        Utc0500Ekaterinburg,
        [EnumMember(Value = "(UTC+05:00) Islamabad, Karachi")]
        Utc0500IslamabadKarachi,
        [EnumMember(Value = "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi")]
        Utc0530ChennaiKolkataMumbaiNewDelhi,
        [EnumMember(Value = "(UTC+05:30) Sri Jayawardenepura")]
        Utc0530SriJayawardenepura,
        [EnumMember(Value = "(UTC+05:45) Kathmandu")]
        Utc0545Kathmandu,
        [EnumMember(Value = "(UTC+06:00) Astana")]
        Utc0600Astana,
        [EnumMember(Value = "(UTC+06:00) Dhaka")]
        Utc0600Dhaka,
        [EnumMember(Value = "(UTC+06:00) Omsk")]
        Utc0600Omsk,
        [EnumMember(Value = "(UTC+06:30) Yangon (Rangoon)")]
        Utc0630YangonRangoon,
        [EnumMember(Value = "(UTC+07:00) Bangkok, Hanoi, Jakarta")]
        Utc0700BangkokHanoiJakarta,
        [EnumMember(Value = "(UTC+07:00) Barnaul, Gorno-Altaysk")]
        Utc0700BarnaulGornoAltaysk,
        [EnumMember(Value = "(UTC+07:00) Hovd")]
        Utc0700Hovd,
        [EnumMember(Value = "(UTC+07:00) Krasnoyarsk")]
        Utc0700Krasnoyarsk,
        [EnumMember(Value = "(UTC+07:00) Novosibirsk")]
        Utc0700Novosibirsk,
        [EnumMember(Value = "(UTC+07:00) Tomsk")]
        Utc0700Tomsk,
        [EnumMember(Value = "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi")]
        Utc0800BeijingChongqingHongKongUrumqi,
        [EnumMember(Value = "(UTC+08:00) Irkutsk")]
        Utc0800Irkutsk,
        [EnumMember(Value = "(UTC+08:00) Kuala Lumpur, Singapore")]
        Utc0800KualaLumpurSingapore,
        [EnumMember(Value = "(UTC+08:00) Perth")]
        Utc0800Perth,
        [EnumMember(Value = "(UTC+08:00) Taipei")]
        Utc0800Taipei,
        [EnumMember(Value = "(UTC+08:00) Ulaanbaatar")]
        Utc0800Ulaanbaatar,
        [EnumMember(Value = "(UTC+08:30) Pyongyang")]
        Utc0830Pyongyang,
        [EnumMember(Value = "(UTC+08:45) Eucla")]
        Utc0845Eucla,
        [EnumMember(Value = "(UTC+09:00) Chita")]
        Utc0900Chita,
        [EnumMember(Value = "(UTC+09:00) Osaka, Sapporo, Tokyo")]
        Utc0900OsakaSapporoTokyo,
        [EnumMember(Value = "(UTC+09:00) Seoul")]
        Utc0900Seoul,
        [EnumMember(Value = "(UTC+09:00) Yakutsk")]
        Utc0900Yakutsk,
        [EnumMember(Value = "(UTC+09:30) Adelaide")]
        Utc0930Adelaide,
        [EnumMember(Value = "(UTC+09:30) Darwin")]
        Utc0930Darwin,
        [EnumMember(Value = "(UTC+10:00) Brisbane")]
        Utc1000Brisbane,
        [EnumMember(Value = "(UTC+10:00) Canberra, Melbourne, Sydney")]
        Utc1000CanberraMelbourneSydney,
        [EnumMember(Value = "(UTC+10:00) Guam, Port Moresby")]
        Utc1000GuamPortMoresby,
        [EnumMember(Value = "(UTC+10:00) Hobart")]
        Utc1000Hobart,
        [EnumMember(Value = "(UTC+10:00) Vladivostok")]
        Utc1000Vladivostok,
        [EnumMember(Value = "(UTC+10:30) Lord Howe Island")]
        Utc1030LordHoweIsland,
        [EnumMember(Value = "(UTC+11:00) Bougainville Island")]
        Utc1100BougainvilleIsland,
        [EnumMember(Value = "(UTC+11:00) Chokurdakh")]
        Utc1100Chokurdakh,
        [EnumMember(Value = "(UTC+11:00) Magadan")]
        Utc1100Magadan,
        [EnumMember(Value = "(UTC+11:00) Norfolk Island")]
        Utc1100NorfolkIsland,
        [EnumMember(Value = "(UTC+11:00) Sakhalin")]
        Utc1100Sakhalin,
        [EnumMember(Value = "(UTC+11:00) Solomon Is., New Caledonia")]
        Utc1100SolomonIsNewCaledonia,
        [EnumMember(Value = "(UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky")]
        Utc1200AnadyrPetropavlovskKamchatsky,
        [EnumMember(Value = "(UTC+12:00) Auckland, Wellington")]
        Utc1200AucklandWellington,
        [EnumMember(Value = "(UTC+12:00) Coordinated Universal Time+12")]
        Utc1200CoordinatedUniversalTime12,
        [EnumMember(Value = "(UTC+12:00) Fiji")]
        Utc1200Fiji,
        [EnumMember(Value = "(UTC+12:00) Petropavlovsk-Kamchatsky - Old")]
        Utc1200PetropavlovskKamchatskyOld,
        [EnumMember(Value = "(UTC+12:45) Chatham Islands")]
        Utc1245ChathamIslands,
        [EnumMember(Value = "(UTC+13:00) Coordinated Universal Time+13")]
        Utc1300CoordinatedUniversalTime13,
        [EnumMember(Value = "(UTC+13:00) Nuku'alofa")]
        Utc1300NukuAlofa,
        [EnumMember(Value = "(UTC+13:00) Samoa")]
        Utc1300Samoa,
        [EnumMember(Value = "(UTC+14:00) Kiritimati Island")]
        Utc1400KiritimatiIsland
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemInputImportanceType
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemInputRecurrenceType
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemInputShowAsType
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
    public enum ImportanceInput
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

    public class ReplyParametersInput
    {
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? ReplyAll { get; set; }
        public ReplyParametersInputImportanceType? Importance { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReplyParametersInputImportanceType
    {
        Low,
        Normal,
        High
    }

    public class EmailMessageInput
    {
        public EmailMessageInput(string to, string subject, string body)
        {
            this.To = to;
            this.Subject = subject;
            this.Body = body;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("From")]
        public string FromSendAs { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }
        public string Bcc { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
        public string ReplyTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailMessageInputImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Outlook.EmailMessageInputImportanceType.Normal;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmailMessageInputImportanceType
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
        public string EventUniqueId { get; set; }
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
        public bool IsHtml { get; set; }
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

    public class SubscriptionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
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