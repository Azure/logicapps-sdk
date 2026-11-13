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
        public IBodyWorkflowAction<GraphOutlookCategory[], ApiConnectionActionConfiguration> GetOutlookCategoryNames()
        {
            return new DeferredBodyAction<GraphOutlookCategory[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphOutlookCategory[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<OutlookReceiveMessage, ApiConnectionActionConfiguration> DraftEmail(Expression<Func<DraftMessageInput>> draftMessage, Expression<Func<string>> messageId = null, Expression<Func<string>> draftType = null, Expression<Func<string>> comment = null)
        {
            var __workflow_draftMessage = WorkflowExpression.Compile(draftMessage, nameof(draftMessage), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: false);
            var __workflow_draftType = WorkflowExpression.Compile(draftType, nameof(draftType), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<OutlookReceiveMessage, ApiConnectionActionConfiguration>(() =>
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
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_draftMessage);
                return new ApiConnectionAction<OutlookReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDraftEmail(Expression<Func<DraftMessageInput>> draftMessage, Expression<Func<string>> messageId)
        {
            var __workflow_draftMessage = WorkflowExpression.Compile(draftMessage, nameof(draftMessage), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Draft";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = ExpressionConverter.Convert(__workflow_messageId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_draftMessage);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendDraftEmail(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Draft/Send/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AssignCategory(Expression<Func<string>> messageId, Expression<Func<string>> category)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Mail/Category";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["messageId"] = ExpressionConverter.Convert(__workflow_messageId);
                callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchOperationResult, ApiConnectionActionConfiguration> AssignCategoryBulk(Expression<Func<string[]>> messageIds, Expression<Func<string>> categoryName)
        {
            var __workflow_messageIds = WorkflowExpression.Compile(messageIds, nameof(messageIds), required: true);
            var __workflow_categoryName = WorkflowExpression.Compile(categoryName, nameof(categoryName), required: true);
            return new DeferredBodyAction<BatchOperationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/Category/Bulk/{0}", __workflow_categoryName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_messageIds);
                return new ApiConnectionAction<BatchOperationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateMyContactPhoto(Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<string>> body)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}/photo/$value", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("image/jpeg");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> uri, Expression<Func<MethodInput>> method, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null, Expression<Func<string>> customHeader1 = null, Expression<Func<string>> customHeader2 = null, Expression<Func<string>> customHeader3 = null, Expression<Func<string>> customHeader4 = null, Expression<Func<string>> customHeader5 = null)
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
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<McpQueryResponse, ApiConnectionActionConfiguration> McpEmailsManagement(Expression<Func<QueryRequestInput>> queryRequest = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<McpQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/EmailsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<McpQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<McpQueryResponse, ApiConnectionActionConfiguration> McpMeetingManagement(Expression<Func<QueryRequestInput>> queryRequest = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<McpQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/MeetingManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<McpQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<McpQueryResponse, ApiConnectionActionConfiguration> McpContactsManagement(Expression<Func<QueryRequestInput>> queryRequest = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequest = WorkflowExpression.Compile(queryRequest, nameof(queryRequest), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<McpQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/ContactsManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_queryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_queryRequest);
                return new ApiConnectionAction<McpQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CalendarDeleteItem(Expression<Func<string>> calendar, Expression<Func<string>> @event)
        {
            var __workflow_calendar = WorkflowExpression.Compile(calendar, nameof(calendar), required: true);
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/calendars/{0}/events/{1}", __workflow_calendar.WithUrlEncoding(2), __workflow_event.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive, ApiConnectionActionConfiguration> CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GraphCalendarEventClientReceive, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventListClientReceive, ApiConnectionActionConfiguration> CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<GraphCalendarEventListClientReceive, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<CalendarGetTablesResponse, ApiConnectionActionConfiguration> CalendarGetTables()
        {
            return new DeferredBodyAction<CalendarGetTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/v1.0/me/calendars";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["skip"] = Convert.ToString(0);
                callPayload.Queries["top"] = Convert.ToString(256);
                callPayload.Queries["orderBy"] = Convert.ToString("name");
                return new ApiConnectionAction<CalendarGetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive, ApiConnectionActionConfiguration> CalendarPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<CalendarPatchItemItemInput>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<GraphCalendarEventClientReceive, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v4/tables/{0}/items/{1}", __workflow_table.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphCalendarEventClientReceive, ApiConnectionActionConfiguration> CalendarPostItem(Expression<Func<string>> table, Expression<Func<CalendarPatchItemItemInput>> item)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<GraphCalendarEventClientReceive, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/calendars/v4/tables/{0}/items", __workflow_table.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<GraphCalendarEventClientReceive>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactDeleteItem(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2, ApiConnectionActionConfiguration> ContactGetItem(Expression<Func<string>> folder, Expression<Func<string>> id)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseContactResponseV2, ApiConnectionActionConfiguration> ContactGetItems(Expression<Func<string>> folder, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EntityListResponseContactResponseV2, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphContactFolder, ApiConnectionActionConfiguration> ContactGetTables()
        {
            return new DeferredBodyAction<EntityListResponseGraphContactFolder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/datasets/contacts/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntityListResponseGraphContactFolder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2, ApiConnectionActionConfiguration> ContactPatchItem(Expression<Func<string>> folder, Expression<Func<string>> id, Expression<Func<ContactPatchItemItemInput>> item)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<ContactResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts/{1}", __workflow_folder.WithUrlEncoding(2), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<ContactResponseV2, ApiConnectionActionConfiguration> ContactPostItem(Expression<Func<string>> folder, Expression<Func<ContactPatchItemItemInput>> item)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            return new DeferredBodyAction<ContactResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/contactFolders/{0}/contacts", __workflow_folder.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<ContactResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/messages/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/beta/me/messages/{0}/$value", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<FindMeetingTimesResponse, ApiConnectionActionConfiguration> FindMeetingTimes(Expression<Func<FindMeetingTimesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindMeetingTimesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/beta/me/findMeetingTimes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindMeetingTimesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Flag(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<FlagBodyInput>> body = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/messages/{0}/flag", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new FlagBodyInput().ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ForwardEmail(Expression<Func<string>> messageId, Expression<Func<ForwardEmailBodyInput>> body, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/messages/{0}/forward", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetAttachmentResponse, ApiConnectionActionConfiguration> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetAttachmentResponse, ApiConnectionActionConfiguration>(() =>
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
                return new ApiConnectionAction<GetAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage, ApiConnectionActionConfiguration> GetEmail(Expression<Func<string>> messageId, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            var __workflow_internetMessageId = WorkflowExpression.Compile(internetMessageId, nameof(internetMessageId), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GraphClientReceiveMessage, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<BatchResponseGraphClientReceiveMessage, ApiConnectionActionConfiguration> GetEmails(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<CreateGraphOnFlaggedEmailPokeSubscriptionImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<string>> mailboxAddress = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
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
            return new DeferredBodyAction<BatchResponseGraphClientReceiveMessage, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<EntityListResponseGraphCalendarEventClientReceive, ApiConnectionActionConfiguration> GetEventsCalendarView(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeUtc, Expression<Func<string>> endDateTimeUtc, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var __workflow_calendarId = WorkflowExpression.Compile(calendarId, nameof(calendarId), required: true);
            var __workflow_startDateTimeUtc = WorkflowExpression.Compile(startDateTimeUtc, nameof(startDateTimeUtc), required: true);
            var __workflow_endDateTimeUtc = WorkflowExpression.Compile(endDateTimeUtc, nameof(endDateTimeUtc), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<EntityListResponseGraphCalendarEventClientReceive, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetMailTipsResponse, ApiConnectionActionConfiguration> GetMailTips(Expression<Func<GetMailTipsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetMailTipsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/v1.0/me/getMailTips";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetMailTipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomListsResponse, ApiConnectionActionConfiguration> GetRoomLists()
        {
            return new DeferredBodyAction<GetRoomListsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/beta/me/findRoomLists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRoomListsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsResponse, ApiConnectionActionConfiguration> GetRooms()
        {
            return new DeferredBodyAction<GetRoomsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/beta/me/findRooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRoomsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GetRoomsInRoomListResponse, ApiConnectionActionConfiguration> GetRoomsInRoomList(Expression<Func<string>> roomList)
        {
            var __workflow_roomList = WorkflowExpression.Compile(roomList, nameof(roomList), required: true);
            return new DeferredBodyAction<GetRoomsInRoomListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/beta/me/findRooms(RoomList='{0}')", __workflow_roomList.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRoomsInRoomListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarkAsRead(Expression<Func<string>> messageId, Expression<Func<MarkAsReadBodyInput>> body, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v3/v1.0/me/messages/{0}/markAsRead", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<GraphClientReceiveMessage, ApiConnectionActionConfiguration> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredBodyAction<GraphClientReceiveMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/Mail/Move/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                return new ApiConnectionAction<GraphClientReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplyTo(Expression<Func<string>> messageId, Expression<Func<ReplyParametersInput>> replyParameters, Expression<Func<string>> mailboxAddress = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_replyParameters = WorkflowExpression.Compile(replyParameters, nameof(replyParameters), required: true);
            var __workflow_mailboxAddress = WorkflowExpression.Compile(mailboxAddress, nameof(mailboxAddress), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/Mail/ReplyTo/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mailboxAddress != null)
                    callPayload.Queries["mailboxAddress"] = ExpressionConverter.Convert(__workflow_mailboxAddress);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_replyParameters);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RespondToEvent(Expression<Func<string>> eventId, Expression<Func<ResponseInput>> response, Expression<Func<RespondToEventBodyInput>> body = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_response = WorkflowExpression.Compile(response, nameof(response), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/me/events/{0}/{1}", __workflow_eventId.WithUrlEncoding(1), __workflow_response.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new RespondToEventBodyInput().ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEmail(Expression<Func<SendEmailEmailMessageInput>> emailMessage)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IBodyWorkflowAction<SetAutomaticRepliesSettingResponse, ApiConnectionActionConfiguration> SetAutomaticRepliesSetting(Expression<Func<SetAutomaticRepliesSettingBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetAutomaticRepliesSettingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codeless/v1.0/me/mailboxSettings";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetAutomaticRepliesSettingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "office365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SharedMailboxSendEmail(Expression<Func<SharedMailboxSendEmailEmailMessageInput>> emailMessage)
        {
            var __workflow_emailMessage = WorkflowExpression.Compile(emailMessage, nameof(emailMessage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/SharedMailbox/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_emailMessage);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Office365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GraphCalendarEventListWithActionType, ApiConnectionTriggerConfiguration> OnCalendarChangedItems(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_incomingDays = WorkflowExpression.Compile(incomingDays, nameof(incomingDays), required: false);
            var __workflow_pastDays = WorkflowExpression.Compile(pastDays, nameof(pastDays), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListWithActionType, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/datasets/calendars/v3/tables/{table}/onchangeditems",
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
                        Template = "/{table}/GraphEventSubscriptionPoke/$subscriptions",
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
                return new ApiConnectionTrigger<GraphCalendarEventListWithActionType>(input);
            });
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration> OnCalendarNewItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GraphCalendarEventListClientReceive>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration> OnCalendarUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GraphCalendarEventListClientReceive>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionTriggerConfiguration> OnFlaggedEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<CreateGraphOnFlaggedEmailPokeSubscriptionImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v4/Mail/OnFlaggedEmail",
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
                        Template = "/GraphFlaggedMailSubscriptionPoke/$subscriptions",
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
                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionTriggerConfiguration> OnNewEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<OnNewEmailImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v3/Mail/OnNewEmail",
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
                        Template = "/GraphMailSubscriptionPoke/$subscriptions",
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
                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionTriggerConfiguration> OnNewEmailMentioningMe(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<CreateGraphOnFlaggedEmailPokeSubscriptionImportanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v3/Mail/OnNewMentionMeEmail",
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
                        Template = "/GraphMentionMeMailSubscriptionPoke/$subscriptions",
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
                return new ApiConnectionTrigger<TriggerBatchResponseGraphClientReceiveMessage>(input);
            });
        }

        public IBodyWorkflowTrigger<GraphCalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration> OnUpcomingEvents(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null)
        {
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_lookAheadTimeInMinutes = WorkflowExpression.Compile(lookAheadTimeInMinutes, nameof(lookAheadTimeInMinutes), required: false);
            return new DeferredBodyTrigger<GraphCalendarEventListClientReceive, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v3/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = ExpressionConverter.Convert(__workflow_table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (__workflow_lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = ExpressionConverter.Convert(__workflow_lookAheadTimeInMinutes);
                return new ApiConnectionPollingTrigger<GraphCalendarEventListClientReceive>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionPollingTriggerConfiguration> OnSharedMailboxNewEmail(Expression<Func<string>> mailboxAddress, Expression<Func<string>> folderId = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<CreateGraphOnFlaggedEmailPokeSubscriptionImportanceInput>> importance = null, Expression<Func<bool>> hasAttachments = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null)
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
            return new DeferredBodyTrigger<TriggerBatchResponseGraphClientReceiveMessage, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<TriggerBatchResponseGraphClientReceiveMessage>(callPayload);
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
        [EnumMember(Value = "HTML")]
        Html
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

    public class DraftMessageInput
    {
        public DraftMessageInput(string to, string subject, string body)
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
        public string Sensitivity { get; set; }
        public string ReplyTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DraftMessageInputImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.DraftMessageInputImportanceType.Normal;
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DraftMessageInputImportanceType
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
        public MessageWithOptionsImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.MessageWithOptionsImportanceType.Normal;
        public ClientSendAttachment[] Attachments { get; set; }

        [JsonProperty("UseOnlyHTMLMessage")]
        public bool? UseOnlyHtmlMessage { get; set; }

        [JsonProperty("HideHTMLMessage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideHtmlMessage { get; set; } = false;

        [JsonProperty("ShowHTMLConfirmationDialog", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHtmlConfirmationDialog { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideMicrosoftFooter { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageWithOptionsImportanceType
    {
        Low,
        Normal,
        High
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
        public ApprovalMessageImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.ApprovalMessageImportanceType.Normal;
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MethodInput
    {
        [EnumMember(Value = "GET")]
        Get,
        [EnumMember(Value = "POST")]
        Post,
        [EnumMember(Value = "PUT")]
        Put,
        [EnumMember(Value = "PATCH")]
        Patch,
        [EnumMember(Value = "DELETE")]
        Delete
    }

    public class McpQueryResponse
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

    public class QueryRequestInput
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
        public bool IsHtml { get; set; }

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

    public class CalendarGetTablesResponse
    {
        [JsonProperty("value")]
        public CalendarGetTablesResponseValueTypeItem[] Value { get; set; }
    }

    public class CalendarGetTablesResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public CalendarGetTablesEmailAddressV2Response Owner { get; set; }
    }

    public class CalendarGetTablesEmailAddressV2Response
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class CalendarPatchItemItemInput
    {
        public CalendarPatchItemItemInput(string subject, string startTime, string endTime, ItemInputTimeZoneType timeZone)
        {
            this.Subject = subject;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TimeZone = timeZone;
        }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        public ItemInputTimeZoneType TimeZone { get; set; }

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
        public ItemInputImportanceType? Importance { get; set; }

        [JsonProperty("isAllDay")]
        public bool? IsAllDayEvent { get; set; }

        [JsonProperty("recurrence")]
        public ItemInputRecurrenceType? Recurrence { get; set; }

        [JsonProperty("selectedDaysOfWeek")]
        public ItemInputSelectedDaysOfWeekTypeItem[] SelectedDaysOfWeek { get; set; }

        [JsonProperty("recurrenceEnd")]
        public string RecurrenceEndDate { get; set; }

        [JsonProperty("numberOfOccurences")]
        public int? NumberOfOccurrences { get; set; }

        [JsonProperty("reminderMinutesBeforeStart")]
        public int? Reminder { get; set; }

        [JsonProperty("isReminderOn")]
        public bool? IsReminderOn { get; set; }

        [JsonProperty("showAs")]
        public ItemInputShowAsType? ShowAs { get; set; }

        [JsonProperty("responseRequested")]
        public bool? ResponseRequested { get; set; }

        [JsonProperty("sensitivity")]
        public ItemInputSensitivityType? Sensitivity { get; set; }
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
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemInputRecurrenceType
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
    public enum ItemInputSelectedDaysOfWeekTypeItem
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
    public enum ItemInputShowAsType
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
    public enum ItemInputSensitivityType
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
        public CalendarGetTablesEmailAddressV2Response[] EmailAddresses { get; set; }

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
        public ContactGetItemPhysicalAddressV2Response HomeAddress { get; set; }

        [JsonProperty("businessAddress")]
        public ContactGetItemPhysicalAddressV2Response BusinessAddress { get; set; }

        [JsonProperty("otherAddress")]
        public ContactGetItemPhysicalAddressV2Response OtherAddress { get; set; }

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

    public class ContactGetItemPhysicalAddressV2Response
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
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class ContactPatchItemItemInput
    {
        public ContactPatchItemItemInput(string givenName, string[] homePhones)
        {
            this.GivenName = givenName;
            this.HomePhones = homePhones;
        }

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

        [JsonProperty("givenName", DefaultValueHandling = DefaultValueHandling.Include)]
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
        public ContactPatchItemEmailAddressV2[] EmailAddresses { get; set; }

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

        [JsonProperty("homePhones", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] HomePhones { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("homeAddress")]
        public ContactPatchItemPhysicalAddressV2 HomeAddress { get; set; }

        [JsonProperty("businessAddress")]
        public ContactPatchItemPhysicalAddressV2 BusinessAddress { get; set; }

        [JsonProperty("otherAddress")]
        public ContactPatchItemPhysicalAddressV2 OtherAddress { get; set; }

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

    public class ContactPatchItemEmailAddressV2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class ContactPatchItemPhysicalAddressV2
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

    public class FindMeetingTimesResponse
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

    public class FindMeetingTimesBodyInput
    {
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public int? MeetingDuration { get; set; }

        [JsonProperty("Start")]
        public string StartTime { get; set; }

        [JsonProperty("End")]
        public string EndTime { get; set; }
        public int? MaxCandidates { get; set; }
        public string MinimumAttendeePercentage { get; set; }
        public bool? IsOrganizerOptional { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputActivityDomainType? ActivityDomain { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.BodyInputActivityDomainType.Work;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActivityDomainType
    {
        Work,
        Personal,
        Unrestricted,
        Unknown
    }

    public class FlagBodyInput
    {
        [JsonProperty("flag", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFlagType Flag { get; set; } = new BodyInputFlagType();
    }

    public class BodyInputFlagType
    {
        [JsonProperty("flagStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFlagTypeFlagStatusType? FlagStatus { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.BodyInputFlagTypeFlagStatusType.Flagged;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFlagTypeFlagStatusType
    {
        [EnumMember(Value = "flagged")]
        Flagged,
        [EnumMember(Value = "notFlagged")]
        NotFlagged,
        [EnumMember(Value = "complete")]
        Complete
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

    public class GetAttachmentResponse
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
        public string Bcc { get; set; }

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
        public bool IsHtml { get; set; }

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
    public enum CreateGraphOnFlaggedEmailPokeSubscriptionImportanceInput
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

    public class GetMailTipsResponse
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

        [JsonProperty("externalMemberCount")]
        public int IsModerated { get; set; }

        [JsonProperty("isModerated")]
        public bool IsModerated2 { get; set; }

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

    public class GetMailTipsBodyInput
    {
        public GetMailTipsBodyInput(string[] emailAddresses)
        {
            this.EmailAddresses = emailAddresses;
        }

        [JsonProperty("MailTipsOptions", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string FlagsThatRepresentsTheMailtips { get; set; } = "automaticReplies, deliveryRestriction, externalMemberCount, mailboxFullStatus, maxMessageSize, moderationStatus, totalMemberCount";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] EmailAddresses { get; set; }
    }

    public class GetRoomListsResponse
    {
        [JsonProperty("value")]
        public GetRoomListsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetRoomListsResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class GetRoomsResponse
    {
        [JsonProperty("value")]
        public GetRoomsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetRoomsResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class GetRoomsInRoomListResponse
    {
        [JsonProperty("value")]
        public GetRoomsInRoomListResponseValueTypeItem[] Value { get; set; }
    }

    public class GetRoomsInRoomListResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class MarkAsReadBodyInput
    {
        public MarkAsReadBodyInput(bool markAs)
        {
            this.MarkAs = markAs;
        }

        [JsonProperty("isRead", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool MarkAs { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResponseInput
    {
        [EnumMember(Value = "accept")]
        Accept,
        [EnumMember(Value = "tentativelyAccept")]
        TentativelyAccept,
        [EnumMember(Value = "decline")]
        Decline
    }

    public class RespondToEventBodyInput
    {
        public string Comment { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendResponse { get; set; } = true;
    }

    public class SendEmailEmailMessageInput
    {
        public SendEmailEmailMessageInput(string to, string subject, string body)
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
        public string Sensitivity { get; set; }
        public string ReplyTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailMessageInputImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.EmailMessageInputImportanceType.Normal;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmailMessageInputImportanceType
    {
        Low,
        Normal,
        High
    }

    public class SetAutomaticRepliesSettingResponse
    {
        [JsonProperty("automaticRepliesSetting")]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2Response AutomaticRepliesSetting { get; set; }
    }

    public class SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2Response
    {
        [JsonProperty("status")]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StatusTypeResponse Status { get; set; }

        [JsonProperty("externalAudience")]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2ExternalAudienceTypeResponse ExternalAudience { get; set; }

        [JsonProperty("scheduledStartDateTime")]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StartTimeTypeResponse StartTime { get; set; }

        [JsonProperty("scheduledEndDateTime")]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2EndTimeTypeResponse EndTime { get; set; }

        [JsonProperty("internalReplyMessage")]
        public string InternalReplyMessage { get; set; }

        [JsonProperty("externalReplyMessage")]
        public string ExternalReplyMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StatusTypeResponse
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled2,
        Scheduled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2ExternalAudienceTypeResponse
    {
        [EnumMember(Value = "none")]
        None2,
        [EnumMember(Value = "contactsOnly")]
        ContactsOnly,
        [EnumMember(Value = "all")]
        All,
        None
    }

    public class SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StartTimeTypeResponse
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2EndTimeTypeResponse
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class SetAutomaticRepliesSettingBodyInput
    {
        [JsonProperty("automaticRepliesSetting", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2 AutomaticRepliesSetting { get; set; } = new SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2();
    }

    public class SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StatusType Status { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StatusType.Scheduled;

        [JsonProperty("externalAudience", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2ExternalAudienceType ExternalAudience { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2ExternalAudienceType.None;

        [JsonProperty("scheduledStartDateTime")]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StartTimeType StartTime { get; set; }

        [JsonProperty("scheduledEndDateTime")]
        public SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2EndTimeType EndTime { get; set; }

        [JsonProperty("internalReplyMessage")]
        public string InternalReplyMessage { get; set; }

        [JsonProperty("externalReplyMessage")]
        public string ExternalReplyMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StatusType
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "alwaysEnabled")]
        AlwaysEnabled,
        [EnumMember(Value = "scheduled")]
        Scheduled2,
        Scheduled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2ExternalAudienceType
    {
        [EnumMember(Value = "none")]
        None2,
        [EnumMember(Value = "contactsOnly")]
        ContactsOnly,
        [EnumMember(Value = "all")]
        All,
        None
    }

    public class SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2StartTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class SetAutomaticRepliesSettingAutomaticRepliesSettingClientV2EndTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class SharedMailboxSendEmailEmailMessageInput
    {
        public SharedMailboxSendEmailEmailMessageInput(string originalMailboxAddress, string to, string subject, string body)
        {
            this.OriginalMailboxAddress = originalMailboxAddress;
            this.To = to;
            this.Subject = subject;
            this.Body = body;
        }

        [JsonProperty("MailboxAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OriginalMailboxAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }
        public string Bcc { get; set; }
        public ClientSendAttachment[] Attachments { get; set; }
        public string Sensitivity { get; set; }
        public string ReplyTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailMessageInputImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Office365.EmailMessageInputImportanceType.Normal;
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
        public bool IsHtml { get; set; }

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

    public class SubscriptionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerBatchResponseGraphClientReceiveMessage
    {
        [JsonProperty("value")]
        public GraphClientReceiveMessage[] Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnNewEmailImportanceInput
    {
        Any,
        Low,
        Normal,
        High
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