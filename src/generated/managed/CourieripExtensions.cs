//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Courierip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CourieripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageSendPostResponse, ApiConnectionActionConfiguration> MessageSend(Expression<Func<string>> idempotency, Expression<Func<MessageSendPostInput>> body = null)
        {
            var __workflow_idempotency = WorkflowExpression.Compile(idempotency, nameof(idempotency), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MessageSendPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idempotency"] = ExpressionConverter.Convert(__workflow_idempotency);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessageSendPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceGetResponse, ApiConnectionActionConfiguration> AudienceGet(Expression<Func<string>> audienceId)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<AudienceGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AudienceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AudienceDelete(Expression<Func<string>> audienceId)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencePutResponse, ApiConnectionActionConfiguration> AudiencePut(Expression<Func<string>> audienceId, Expression<Func<AudiencePutInput>> body = null)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AudiencePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AudiencePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceMembersGetResponse, ApiConnectionActionConfiguration> AudienceMembersGet(Expression<Func<string>> audienceId, Expression<Func<string>> cursor = null)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudienceMembersGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}/members", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<AudienceMembersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencesGetResponse, ApiConnectionActionConfiguration> AudiencesGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudiencesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/audiences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<AudiencesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventsGetResponse, ApiConnectionActionConfiguration> AuditEventsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AuditEventsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/audit-events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<AuditEventsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventGetResponse, ApiConnectionActionConfiguration> AuditEventGet(Expression<Func<string>> auditEventId)
        {
            var __workflow_auditEventId = WorkflowExpression.Compile(auditEventId, nameof(auditEventId), required: true);
            return new DeferredBodyAction<AuditEventGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audit-events/{0}", __workflow_auditEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AuditEventGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationTemplatedPostResponse, ApiConnectionActionConfiguration> AutomationTemplated(Expression<Func<string>> templateId, Expression<Func<AutomationTemplatedPostInput>> body = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AutomationTemplatedPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/automations/{0}/invoke", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AutomationTemplatedPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationAdHocPostResponse, ApiConnectionActionConfiguration> AutomationAdHoc(Expression<Func<AutomationAdHocPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AutomationAdHocPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/automations/invoke";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AutomationAdHocPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandsGetResponse, ApiConnectionActionConfiguration> BrandsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<BrandsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<BrandsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Brand(Expression<Func<BrandPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandGetResponse, ApiConnectionActionConfiguration> BrandGet(Expression<Func<string>> brandId)
        {
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: true);
            return new DeferredBodyAction<BrandGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/brands/{0}", __workflow_brandId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BrandGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobPostResponse, ApiConnectionActionConfiguration> BulkJob(Expression<Func<BulkJobPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BulkJobPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BulkJobPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobGetResponse, ApiConnectionActionConfiguration> BulkJobGet(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BulkJobGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> BulkJobUsers(Expression<Func<string>> jobId, Expression<Func<BulkJobUsersPostInput>> body = null)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BulkJobRun(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}/run", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobUsersGetResponse, ApiConnectionActionConfiguration> BulkJobUsersGet(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobUsersGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}/users", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BulkJobUsersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListsGetResponse, ApiConnectionActionConfiguration> ListsGet()
        {
            return new DeferredBodyAction<ListsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListGetResponse, ApiConnectionActionConfiguration> ListGet(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<ListGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListDelete(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListPut(Expression<Func<string>> listId, Expression<Func<ListPutInput>> body = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListRestorePut(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/restore", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListSubscriptionsGetResponse, ApiConnectionActionConfiguration> ListSubscriptionsGet(Expression<Func<string>> listId, Expression<Func<string>> cursor = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<ListSubscriptionsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/subscriptions", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<ListSubscriptionsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListSubscribers(Expression<Func<string>> listId, Expression<Func<ListSubscribersPostInput>> body = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/subscriptions", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListSubscribeDelete(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/subscriptions/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessagesGetResponse, ApiConnectionActionConfiguration> MessagesGet(Expression<Func<bool>> archived = null, Expression<Func<string>> cursor = null, Expression<Func<string>> @event = null, Expression<Func<string>> list = null, Expression<Func<string>> messageId = null, Expression<Func<string>> notification = null, Expression<Func<string>> recipient = null, Expression<Func<string>> status = null, Expression<Func<string>> tags = null)
        {
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: false);
            var __workflow_list = WorkflowExpression.Compile(list, nameof(list), required: false);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: false);
            var __workflow_notification = WorkflowExpression.Compile(notification, nameof(notification), required: false);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            return new DeferredBodyAction<MessagesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_event != null)
                    callPayload.Queries["event"] = ExpressionConverter.Convert(__workflow_event);
                if (__workflow_list != null)
                    callPayload.Queries["list"] = ExpressionConverter.Convert(__workflow_list);
                if (__workflow_messageId != null)
                    callPayload.Queries["messageId"] = ExpressionConverter.Convert(__workflow_messageId);
                if (__workflow_notification != null)
                    callPayload.Queries["notification"] = ExpressionConverter.Convert(__workflow_notification);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                return new ApiConnectionAction<MessagesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageGetResponse, ApiConnectionActionConfiguration> MessageGet(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageHistoryGetResponse, ApiConnectionActionConfiguration> MessageHistoryGet(Expression<Func<string>> messageId, Expression<Func<string>> type = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<MessageHistoryGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/{0}/history", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<MessageHistoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageContentGetResponse, ApiConnectionActionConfiguration> MessageContentGet(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageContentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/{0}/output", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageContentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MessagePut(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/archive", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<NotificationsGetResponse, ApiConnectionActionConfiguration> NotificationsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<NotificationsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<NotificationsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileGetResponse, ApiConnectionActionConfiguration> ProfileGet(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileDeleteResponse, ApiConnectionActionConfiguration> ProfileDelete(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Profile(Expression<Func<string>> recipientId, Expression<Func<ProfilePostInput>> body = null)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfilePatchResponse, ApiConnectionActionConfiguration> ProfilePatch(Expression<Func<string>> recipientId, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ProfilePatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProfilePatchResponse>(callPayload);
            });
        }
    }

    public class CourieripTriggers([ConnectionName] string connectionId)
    {
    }

    public class MessageSendPostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public class MessageSendPostInput
    {
        [JsonProperty("message")]
        public MessageSendPostInputMessageType Message { get; set; }
    }

    public class MessageSendPostInputMessageType
    {
        [JsonProperty("content")]
        public MessageSendPostInputMessageTypeContentType Content { get; set; }

        [JsonProperty("to")]
        public MessageSendPostInputMessageTypeToType To { get; set; }
    }

    public class MessageSendPostInputMessageTypeContentType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class MessageSendPostInputMessageTypeToType
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("audience_id")]
        public string AudienceId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class AudienceGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filter")]
        public AudienceGetResponseFilterType Filter { get; set; }
    }

    public class AudienceGetResponseFilterType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class AudiencePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filter")]
        public AudiencePutResponseFilterType Filter { get; set; }
    }

    public class AudiencePutResponseFilterType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("filters")]
        public AudiencePutResponseFilterTypeFiltersTypeItem[] Filters { get; set; }
    }

    public class AudiencePutResponseFilterTypeFiltersTypeItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AudiencePutInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("filter")]
        public AudiencePutInputFilterType Filter { get; set; }
    }

    public class AudiencePutInputFilterType
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("filters")]
        public AudiencePutInputFilterTypeFiltersTypeItem[] Filters { get; set; }
    }

    public class AudiencePutInputFilterTypeFiltersTypeItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AudienceMembersGetResponse
    {
        [JsonProperty("items")]
        public AudienceMembersGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("paging")]
        public AudienceMembersGetResponsePagingType Paging { get; set; }
    }

    public class AudienceMembersGetResponseItemsTypeItem
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("added_at")]
        public string AddedAt { get; set; }

        [JsonProperty("audience_id")]
        public string AudienceId { get; set; }

        [JsonProperty("audience_version")]
        public int AudienceVersion { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class AudienceMembersGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class AudiencesGetResponse
    {
        [JsonProperty("items")]
        public AudiencesGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("paging")]
        public AudiencesGetResponsePagingType Paging { get; set; }
    }

    public class AudiencesGetResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filter")]
        public AudiencesGetResponseItemsTypeItemFilterType Filter { get; set; }
    }

    public class AudiencesGetResponseItemsTypeItemFilterType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class AudiencesGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class AuditEventsGetResponse
    {
        [JsonProperty("paging")]
        public AuditEventsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public AuditEventsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class AuditEventsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class AuditEventsGetResponseResultsTypeItem
    {
        [JsonProperty("auditEventId")]
        public string AuditEventId { get; set; }

        [JsonProperty("actor")]
        public AuditEventsGetResponseResultsTypeItemActorType Actor { get; set; }

        [JsonProperty("target")]
        public AuditEventsGetResponseResultsTypeItemTargetType Target { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AuditEventsGetResponseResultsTypeItemActorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AuditEventsGetResponseResultsTypeItemTargetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AuditEventGetResponse
    {
        [JsonProperty("auditEventId")]
        public string AuditEventId { get; set; }

        [JsonProperty("actor")]
        public AuditEventGetResponseActorType Actor { get; set; }

        [JsonProperty("target")]
        public AuditEventGetResponseTargetType Target { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AuditEventGetResponseActorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AuditEventGetResponseTargetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AutomationTemplatedPostResponse
    {
        [JsonProperty("runId")]
        public string RunId { get; set; }
    }

    public class AutomationTemplatedPostInput
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("profile")]
        public JToken Profile { get; set; }
    }

    public class AutomationAdHocPostResponse
    {
        [JsonProperty("runId")]
        public string RunId { get; set; }
    }

    public class AutomationAdHocPostInput
    {
        [JsonProperty("automation")]
        public AutomationAdHocPostInputAutomationType Automation { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("profile")]
        public JToken Profile { get; set; }
    }

    public class AutomationAdHocPostInputAutomationType
    {
        [JsonProperty("steps")]
        public JToken[] Steps { get; set; }

        [JsonProperty("cancelation_token")]
        public string CancelationToken { get; set; }
    }

    public class BrandsGetResponse
    {
        [JsonProperty("paging")]
        public BrandsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public BrandsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class BrandsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class BrandsGetResponseResultsTypeItem
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published")]
        public int Published { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("settings")]
        public BrandsGetResponseResultsTypeItemSettingsType Settings { get; set; }

        [JsonProperty("snippets")]
        public BrandsGetResponseResultsTypeItemSnippetsType Snippets { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsType
    {
        [JsonProperty("colors")]
        public BrandsGetResponseResultsTypeItemSettingsTypeColorsType Colors { get; set; }

        [JsonProperty("email")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailType Email { get; set; }

        [JsonProperty("inapp")]
        public BrandsGetResponseResultsTypeItemSettingsTypeInappType Inapp { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeColorsType
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("secondary")]
        public string Secondary { get; set; }

        [JsonProperty("tertiary")]
        public string Tertiary { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailType
    {
        [JsonProperty("header")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderType Header { get; set; }

        [JsonProperty("footer")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterType Footer { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderType
    {
        [JsonProperty("barColor")]
        public string BarColor { get; set; }

        [JsonProperty("logo")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderTypeLogoType Logo { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderTypeLogoType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterType
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("social")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialType Social { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialType
    {
        [JsonProperty("facebook")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType Facebook { get; set; }

        [JsonProperty("instagram")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType Instagram { get; set; }

        [JsonProperty("linkedin")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType Linkedin { get; set; }

        [JsonProperty("medium")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeMediumType Medium { get; set; }

        [JsonProperty("twitter")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType Twitter { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeMediumType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeInappType
    {
        [JsonProperty("disableMessageIcon")]
        public bool DisableMessageIcon { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSnippetsType
    {
        [JsonProperty("items")]
        public string[] Items { get; set; }
    }

    public class BrandPostInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("settings")]
        public BrandPostInputSettingsType Settings { get; set; }

        [JsonProperty("snippets")]
        public BrandPostInputSnippetsType Snippets { get; set; }
    }

    public class BrandPostInputSettingsType
    {
        [JsonProperty("colors")]
        public BrandPostInputSettingsTypeColorsType Colors { get; set; }

        [JsonProperty("email")]
        public BrandPostInputSettingsTypeEmailType Email { get; set; }

        [JsonProperty("inapp")]
        public BrandPostInputSettingsTypeInappType Inapp { get; set; }
    }

    public class BrandPostInputSettingsTypeColorsType
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("secondary")]
        public string Secondary { get; set; }

        [JsonProperty("tertiary")]
        public string Tertiary { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailType
    {
        [JsonProperty("header")]
        public BrandPostInputSettingsTypeEmailTypeHeaderType Header { get; set; }

        [JsonProperty("footer")]
        public BrandPostInputSettingsTypeEmailTypeFooterType Footer { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeHeaderType
    {
        [JsonProperty("barColor")]
        public string BarColor { get; set; }

        [JsonProperty("logo")]
        public BrandPostInputSettingsTypeEmailTypeHeaderTypeLogoType Logo { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeHeaderTypeLogoType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeFooterType
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("social")]
        public BrandPostInputSettingsTypeEmailTypeFooterTypeSocialType Social { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeFooterTypeSocialType
    {
        [JsonProperty("facebook")]
        public BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType Facebook { get; set; }

        [JsonProperty("instagram")]
        public BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType Instagram { get; set; }

        [JsonProperty("linkedin")]
        public BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType Linkedin { get; set; }

        [JsonProperty("medium")]
        public BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeMediumType Medium { get; set; }

        [JsonProperty("twitter")]
        public BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType Twitter { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeMediumType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandPostInputSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandPostInputSettingsTypeInappType
    {
        [JsonProperty("disableMessageIcon")]
        public bool? DisableMessageIcon { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }
    }

    public class BrandPostInputSnippetsType
    {
        [JsonProperty("items")]
        public string[] Items { get; set; }
    }

    public class BrandGetResponse
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published")]
        public int Published { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("settings")]
        public BrandGetResponseSettingsType Settings { get; set; }

        [JsonProperty("snippets")]
        public BrandGetResponseSnippetsType Snippets { get; set; }
    }

    public class BrandGetResponseSettingsType
    {
        [JsonProperty("colors")]
        public BrandGetResponseSettingsTypeColorsType Colors { get; set; }

        [JsonProperty("email")]
        public BrandGetResponseSettingsTypeEmailType Email { get; set; }

        [JsonProperty("inapp")]
        public BrandGetResponseSettingsTypeInappType Inapp { get; set; }
    }

    public class BrandGetResponseSettingsTypeColorsType
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("secondary")]
        public string Secondary { get; set; }

        [JsonProperty("tertiary")]
        public string Tertiary { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailType
    {
        [JsonProperty("header")]
        public BrandGetResponseSettingsTypeEmailTypeHeaderType Header { get; set; }

        [JsonProperty("footer")]
        public BrandGetResponseSettingsTypeEmailTypeFooterType Footer { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeHeaderType
    {
        [JsonProperty("barColor")]
        public string BarColor { get; set; }

        [JsonProperty("logo")]
        public BrandGetResponseSettingsTypeEmailTypeHeaderTypeLogoType Logo { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeHeaderTypeLogoType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterType
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("social")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialType Social { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialType
    {
        [JsonProperty("facebook")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType Facebook { get; set; }

        [JsonProperty("instagram")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType Instagram { get; set; }

        [JsonProperty("linkedin")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType Linkedin { get; set; }

        [JsonProperty("medium")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeMediumType Medium { get; set; }

        [JsonProperty("twitter")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType Twitter { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeMediumType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeInappType
    {
        [JsonProperty("disableMessageIcon")]
        public bool DisableMessageIcon { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }
    }

    public class BrandGetResponseSnippetsType
    {
        [JsonProperty("items")]
        public string[] Items { get; set; }
    }

    public class BulkJobPostResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }

    public class BulkJobPostInput
    {
        [JsonProperty("message")]
        public BulkJobPostInputMessageType Message { get; set; }
    }

    public class BulkJobPostInputMessageType
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("override")]
        public JToken Override { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("brand_id")]
        public string BrandId { get; set; }

        [JsonProperty("routing")]
        public BulkJobPostInputMessageTypeRoutingType Routing { get; set; }

        [JsonProperty("channels")]
        public JToken Channels { get; set; }

        [JsonProperty("providers")]
        public JToken Providers { get; set; }

        [JsonProperty("metadata")]
        public BulkJobPostInputMessageTypeMetadataType Metadata { get; set; }
    }

    public class BulkJobPostInputMessageTypeRoutingType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("channels")]
        public string[] Channels { get; set; }
    }

    public class BulkJobPostInputMessageTypeMetadataType
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("trace_id")]
        public string TraceId { get; set; }

        [JsonProperty("utm")]
        public BulkJobPostInputMessageTypeMetadataTypeUtmType Utm { get; set; }
    }

    public class BulkJobPostInputMessageTypeMetadataTypeUtmType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class BulkJobGetResponse
    {
        [JsonProperty("job")]
        public BulkJobGetResponseJobType Job { get; set; }
    }

    public class BulkJobGetResponseJobType
    {
        [JsonProperty("definition")]
        public BulkJobGetResponseJobTypeDefinitionType Definition { get; set; }

        [JsonProperty("enqueued")]
        public int Enqueued { get; set; }

        [JsonProperty("failures")]
        public int Failures { get; set; }

        [JsonProperty("received")]
        public int Received { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class BulkJobGetResponseJobTypeDefinitionType
    {
        [JsonProperty("event")]
        public string Event { get; set; }
    }

    public class BulkJobUsersPostInput
    {
        [JsonProperty("users")]
        public BulkJobUsersPostInputUsersTypeItem[] Users { get; set; }
    }

    public class BulkJobUsersPostInputUsersTypeItem
    {
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }

        [JsonProperty("profile")]
        public JToken Profile { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("to")]
        public JToken To { get; set; }
    }

    public class BulkJobUsersGetResponse
    {
        [JsonProperty("items")]
        public BulkJobUsersGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("paging")]
        public BulkJobUsersGetResponsePagingType Paging { get; set; }
    }

    public class BulkJobUsersGetResponseItemsTypeItem
    {
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class BulkJobUsersGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class ListsGetResponse
    {
        [JsonProperty("paging")]
        public ListsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public ListsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class ListsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class ListsGetResponseResultsTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("preferences")]
        public ListsGetResponseResultsTypeItemPreferencesType Preferences { get; set; }
    }

    public class ListsGetResponseResultsTypeItemPreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ListGetResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("preferences")]
        public ListGetResponsePreferencesType Preferences { get; set; }
    }

    public class ListGetResponsePreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ListPutInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferences")]
        public ListPutInputPreferencesType Preferences { get; set; }
    }

    public class ListPutInputPreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ListSubscriptionsGetResponse
    {
        [JsonProperty("paging")]
        public ListSubscriptionsGetResponsePagingType Paging { get; set; }

        [JsonProperty("items")]
        public ListSubscriptionsGetResponseItemsTypeItem[] Items { get; set; }
    }

    public class ListSubscriptionsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class ListSubscriptionsGetResponseItemsTypeItem
    {
        [JsonProperty("recipientId")]
        public string RecipientId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("preferences")]
        public ListSubscriptionsGetResponseItemsTypeItemPreferencesType Preferences { get; set; }
    }

    public class ListSubscriptionsGetResponseItemsTypeItemPreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ListSubscribersPostInput
    {
        [JsonProperty("recipients")]
        public ListSubscribersPostInputRecipientsTypeItem[] Recipients { get; set; }
    }

    public class ListSubscribersPostInputRecipientsTypeItem
    {
        [JsonProperty("recipientId")]
        public string RecipientId { get; set; }

        [JsonProperty("preferences")]
        public ListSubscribersPostInputRecipientsTypeItemPreferencesType Preferences { get; set; }
    }

    public class ListSubscribersPostInputRecipientsTypeItemPreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class MessagesGetResponse
    {
        [JsonProperty("paging")]
        public MessagesGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public MessagesGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class MessagesGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class MessagesGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("enqueued")]
        public int Enqueued { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("opened")]
        public int Opened { get; set; }

        [JsonProperty("clicked")]
        public int Clicked { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("notification")]
        public string Notification { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class MessageGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("enqueued")]
        public int Enqueued { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("opened")]
        public int Opened { get; set; }

        [JsonProperty("clicked")]
        public int Clicked { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("notification")]
        public string Notification { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("providers")]
        public MessageGetResponseProvidersTypeItem[] Providers { get; set; }
    }

    public class MessageGetResponseProvidersTypeItem
    {
        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("clicked")]
        public int Clicked { get; set; }

        [JsonProperty("opened")]
        public int Opened { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MessageHistoryGetResponse
    {
        [JsonProperty("results")]
        public MessageHistoryGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItem
    {
        [JsonProperty("data")]
        public MessageHistoryGetResponseResultsTypeItemDataType Data { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("notification_id")]
        public string NotificationId { get; set; }

        [JsonProperty("channel")]
        public MessageHistoryGetResponseResultsTypeItemChannelType Channel { get; set; }

        [JsonProperty("integration")]
        public MessageHistoryGetResponseResultsTypeItemIntegrationType Integration { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItemChannelType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItemIntegrationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }
    }

    public class MessageContentGetResponse
    {
        [JsonProperty("results")]
        public MessageContentGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class MessageContentGetResponseResultsTypeItem
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("content")]
        public MessageContentGetResponseResultsTypeItemContentType Content { get; set; }
    }

    public class MessageContentGetResponseResultsTypeItemContentType
    {
        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("blocks")]
        public MessageContentGetResponseResultsTypeItemContentTypeBlocksTypeItem[] Blocks { get; set; }
    }

    public class MessageContentGetResponseResultsTypeItemContentTypeBlocksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class NotificationsGetResponse
    {
        [JsonProperty("paging")]
        public NotificationsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public NotificationsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class NotificationsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class NotificationsGetResponseResultsTypeItem
    {
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tags")]
        public NotificationsGetResponseResultsTypeItemTagsType Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }
    }

    public class NotificationsGetResponseResultsTypeItemTagsType
    {
        [JsonProperty("data")]
        public NotificationsGetResponseResultsTypeItemTagsTypeDataTypeItem[] Data { get; set; }
    }

    public class NotificationsGetResponseResultsTypeItemTagsTypeDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProfileGetResponse
    {
        [JsonProperty("profile")]
        public ProfileGetResponseProfileType Profile { get; set; }

        [JsonProperty("preferences")]
        public ProfileGetResponsePreferencesType Preferences { get; set; }
    }

    public class ProfileGetResponseProfileType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class ProfileGetResponsePreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ProfileDeleteResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ProfilePostInput
    {
        [JsonProperty("profile")]
        public ProfilePostInputProfileType Profile { get; set; }
    }

    public class ProfilePostInputProfileType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("address")]
        public ProfilePostInputProfileTypeAddressType Address { get; set; }

        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty("email_verified")]
        public bool? EmailVerified { get; set; }

        [JsonProperty("phone_number_verified")]
        public bool? PhoneNumberVerified { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("zoneinfo")]
        public string Zoneinfo { get; set; }

        [JsonProperty("custom")]
        public JToken Custom { get; set; }

        [JsonProperty("airship")]
        public ProfilePostInputProfileTypeAirshipType Airship { get; set; }
    }

    public class ProfilePostInputProfileTypeAddressType
    {
        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipType
    {
        [JsonProperty("audience")]
        public ProfilePostInputProfileTypeAirshipTypeAudienceType Audience { get; set; }

        [JsonProperty("device_types")]
        public string[] DeviceTypes { get; set; }

        [JsonProperty("apn")]
        public string Apn { get; set; }

        [JsonProperty("target_arn")]
        public string TargetArn { get; set; }

        [JsonProperty("discord")]
        public ProfilePostInputProfileTypeAirshipTypeDiscordType Discord { get; set; }

        [JsonProperty("expo")]
        public ProfilePostInputProfileTypeAirshipTypeExpoType Expo { get; set; }

        [JsonProperty("facebookPSID")]
        public string FacebookPSId { get; set; }

        [JsonProperty("firebaseToken")]
        public string FirebaseToken { get; set; }

        [JsonProperty("intercom")]
        public ProfilePostInputProfileTypeAirshipTypeIntercomType Intercom { get; set; }

        [JsonProperty("ms_teams")]
        public ProfilePostInputProfileTypeAirshipTypeMsTeamsType MsTeams { get; set; }

        [JsonProperty("oneSignalPlayerID")]
        public string OneSignalPlayerId { get; set; }

        [JsonProperty("slack")]
        public ProfilePostInputProfileTypeAirshipTypeSlackType Slack { get; set; }

        [JsonProperty("webhook")]
        public ProfilePostInputProfileTypeAirshipTypeWebhookType Webhook { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeAudienceType
    {
        [JsonProperty("named_user")]
        public string NamedUser { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeDiscordType
    {
        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeExpoType
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("tokens")]
        public string[] Tokens { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeIntercomType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public ProfilePostInputProfileTypeAirshipTypeIntercomTypeToType To { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeIntercomTypeToType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeMsTeamsType
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }

        [JsonProperty("service_url")]
        public string ServiceUrl { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeSlackType
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("incoming_webhook")]
        public ProfilePostInputProfileTypeAirshipTypeSlackTypeIncomingWebhookType IncomingWebhook { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeSlackTypeIncomingWebhookType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeWebhookType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public JToken Headers { get; set; }

        [JsonProperty("authentication")]
        public ProfilePostInputProfileTypeAirshipTypeWebhookTypeAuthenticationType Authentication { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }
    }

    public class ProfilePostInputProfileTypeAirshipTypeWebhookTypeAuthenticationType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class ProfilePatchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("op")]
        public bodyInputItemOpType Op { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyInputItemOpType
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "remove")]
        Remove,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "move")]
        Move,
        [EnumMember(Value = "copy")]
        Copy,
        [EnumMember(Value = "test")]
        Test
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Courierip;

    public partial class WorkflowManagedActions
    {
        public CourieripActions Courierip(string connectionId) => new CourieripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CourieripTriggers Courierip(string connectionId) => new CourieripTriggers(connectionId);
    }
}