//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kintone
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KintoneActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction AddRecord(Expression<Func<string>> requestBodyOfRecordappID, Expression<Func<object>> requestBodyOfRecordrecord = null)
        {
            var apiCallPath = "/k/v1/record.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfRecord = new JObject();
            var requestBodyOfRecordpropCount = 0;
            requestBodyOfRecordpropCount++;
            requestBodyOfRecord["app"] = CSharpExpressionConverter.ConvertToken(requestBodyOfRecordappID);
            requestBodyOfRecord["schemaType"] = "ACTION_POST_RECORD";
            requestBodyOfRecordpropCount++;
            if (requestBodyOfRecordrecord != null)
            {
                requestBodyOfRecord["record"] = CSharpExpressionConverter.ConvertToken(requestBodyOfRecordrecord);
                requestBodyOfRecordpropCount++;
            }

            if (requestBodyOfRecordpropCount > 0)
            {
                callPayload.Body = requestBodyOfRecord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction UpdateRecord(Expression<Func<string>> requestBodyOfRecordappID, Expression<Func<string>> requestBodyOfRecordrecordNumber, Expression<Func<object>> requestBodyOfRecordrecord = null)
        {
            var apiCallPath = "/k/v1/record.json";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfRecord = new JObject();
            var requestBodyOfRecordpropCount = 0;
            requestBodyOfRecordpropCount++;
            requestBodyOfRecord["app"] = CSharpExpressionConverter.ConvertToken(requestBodyOfRecordappID);
            requestBodyOfRecordpropCount++;
            requestBodyOfRecord["id"] = CSharpExpressionConverter.ConvertToken(requestBodyOfRecordrecordNumber);
            requestBodyOfRecord["schemaType"] = "ACTION_PUT_RECORD";
            requestBodyOfRecordpropCount++;
            if (requestBodyOfRecordrecord != null)
            {
                requestBodyOfRecord["record"] = CSharpExpressionConverter.ConvertToken(requestBodyOfRecordrecord);
                requestBodyOfRecordpropCount++;
            }

            if (requestBodyOfRecordpropCount > 0)
            {
                callPayload.Body = requestBodyOfRecord;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class KintoneTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger(Expression<Func<string>> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = CSharpExpressionConverter.ConvertToken(requestBodyOfWebhookappID);
            requestBodyOfWebhook["url"] = "@listCallbackUrl()";
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForUpdatingRecord(Expression<Func<string>> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/update_record.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = CSharpExpressionConverter.ConvertToken(requestBodyOfWebhookappID);
            requestBodyOfWebhook["url"] = "@listCallbackUrl()";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
            requestBodyOfWebhookpropCount++;
            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForDeletingRecord(Expression<Func<string>> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/delete_record.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = CSharpExpressionConverter.ConvertToken(requestBodyOfWebhookappID);
            requestBodyOfWebhook["url"] = "@listCallbackUrl()";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
            requestBodyOfWebhookpropCount++;
            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForAddingRecordComment(Expression<Func<string>> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/add_record_comment.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = CSharpExpressionConverter.ConvertToken(requestBodyOfWebhookappID);
            requestBodyOfWebhook["url"] = "@listCallbackUrl()";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
            requestBodyOfWebhookpropCount++;
            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForUpdatingStatus(Expression<Func<string>> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/update_status.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = CSharpExpressionConverter.ConvertToken(requestBodyOfWebhookappID);
            requestBodyOfWebhook["url"] = "@listCallbackUrl()";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["description"] = "Added by Microsoft Flow. Settings should not be changed.";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["schemaType"] = "TRIGGER_WEBHOOK_RECORD";
            requestBodyOfWebhookpropCount++;
            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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