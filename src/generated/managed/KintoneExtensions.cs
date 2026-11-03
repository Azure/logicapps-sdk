//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kintone
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KintoneActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddRecord(Expression<Func<string>> requestBodyOfRecordappId, Expression<Func<object>> requestBodyOfRecordRecord = null)
        {
            var __workflow_requestBodyOfRecordappId = WorkflowExpression.Compile(requestBodyOfRecordappId, nameof(requestBodyOfRecordappId), required: true);
            var __workflow_requestBodyOfRecordRecord = WorkflowExpression.Compile(requestBodyOfRecordRecord, nameof(requestBodyOfRecordRecord), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/k/v1/record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfRecord = new JObject();
                var requestBodyOfRecordpropCount = 0;
                requestBodyOfRecordpropCount++;
                requestBodyOfRecord["app"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfRecordappId);
                requestBodyOfRecord["schemaType"] = "ACTION_POST_RECORD";
                requestBodyOfRecordpropCount++;
                if (__workflow_requestBodyOfRecordRecord != null)
                {
                    requestBodyOfRecord["record"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfRecordRecord);
                    requestBodyOfRecordpropCount++;
                }

                if (requestBodyOfRecordpropCount > 0)
                {
                    callPayload.Body = requestBodyOfRecord;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateRecord(Expression<Func<string>> requestBodyOfRecordappId, Expression<Func<string>> requestBodyOfRecordrecordNumber, Expression<Func<object>> requestBodyOfRecordRecord = null)
        {
            var __workflow_requestBodyOfRecordappId = WorkflowExpression.Compile(requestBodyOfRecordappId, nameof(requestBodyOfRecordappId), required: true);
            var __workflow_requestBodyOfRecordrecordNumber = WorkflowExpression.Compile(requestBodyOfRecordrecordNumber, nameof(requestBodyOfRecordrecordNumber), required: true);
            var __workflow_requestBodyOfRecordRecord = WorkflowExpression.Compile(requestBodyOfRecordRecord, nameof(requestBodyOfRecordRecord), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/k/v1/record.json";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfRecord = new JObject();
                var requestBodyOfRecordpropCount = 0;
                requestBodyOfRecordpropCount++;
                requestBodyOfRecord["app"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfRecordappId);
                requestBodyOfRecordpropCount++;
                requestBodyOfRecord["id"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfRecordrecordNumber);
                requestBodyOfRecord["schemaType"] = "ACTION_PUT_RECORD";
                requestBodyOfRecordpropCount++;
                if (__workflow_requestBodyOfRecordRecord != null)
                {
                    requestBodyOfRecord["record"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfRecordRecord);
                    requestBodyOfRecordpropCount++;
                }

                if (requestBodyOfRecordpropCount > 0)
                {
                    callPayload.Body = requestBodyOfRecord;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class KintoneTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookTrigger(Expression<Func<string>> requestBodyOfWebhookappId, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhookappId = WorkflowExpression.Compile(requestBodyOfWebhookappId, nameof(requestBodyOfWebhookappId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhookappId);
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["type"] = "ADD_RECORD";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForUpdatingRecord(Expression<Func<string>> requestBodyOfWebhookappId, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhookappId = WorkflowExpression.Compile(requestBodyOfWebhookappId, nameof(requestBodyOfWebhookappId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/update_record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhookappId);
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForDeletingRecord(Expression<Func<string>> requestBodyOfWebhookappId, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhookappId = WorkflowExpression.Compile(requestBodyOfWebhookappId, nameof(requestBodyOfWebhookappId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/delete_record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhookappId);
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForAddingRecordComment(Expression<Func<string>> requestBodyOfWebhookappId, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhookappId = WorkflowExpression.Compile(requestBodyOfWebhookappId, nameof(requestBodyOfWebhookappId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/add_record_comment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhookappId);
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> AddWebhookForUpdatingStatus(Expression<Func<string>> requestBodyOfWebhookappId, FlowRecurrence recurrence = null)
        {
            var __workflow_requestBodyOfWebhookappId = WorkflowExpression.Compile(requestBodyOfWebhookappId, nameof(requestBodyOfWebhookappId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/update_status.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(__workflow_requestBodyOfWebhookappId);
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kintone;

    public partial class WorkflowManagedActions
    {
        public KintoneActions Kintone(string connectionId) => new KintoneActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KintoneTriggers Kintone(string connectionId) => new KintoneTriggers(connectionId);
    }
}