//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kintone
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KintoneActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction AddRecord([WorkflowExpression] Func<string> requestBodyOfRecordappID, [WorkflowExpression] Func<object> requestBodyOfRecordrecord = null)
        {
            var apiCallPath = "/k/v1/record.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfRecord = new JObject();
            var requestBodyOfRecordpropCount = 0;
            requestBodyOfRecordpropCount++;
            requestBodyOfRecord["app"] = ExpressionConverter.ConvertO(requestBodyOfRecordappID);
            requestBodyOfRecord["schemaType"] = "ACTION_POST_RECORD";
            requestBodyOfRecordpropCount++;
            if (requestBodyOfRecordrecord != null)
            {
                requestBodyOfRecord["record"] = ExpressionConverter.ConvertO(requestBodyOfRecordrecord);
                requestBodyOfRecordpropCount++;
            }

            if (requestBodyOfRecordpropCount > 0)
            {
                callPayload.Body = requestBodyOfRecord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction UpdateRecord([WorkflowExpression] Func<string> requestBodyOfRecordappID, [WorkflowExpression] Func<string> requestBodyOfRecordrecordNumber, [WorkflowExpression] Func<object> requestBodyOfRecordrecord = null)
        {
            var apiCallPath = "/k/v1/record.json";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfRecord = new JObject();
            var requestBodyOfRecordpropCount = 0;
            requestBodyOfRecordpropCount++;
            requestBodyOfRecord["app"] = ExpressionConverter.ConvertO(requestBodyOfRecordappID);
            requestBodyOfRecordpropCount++;
            requestBodyOfRecord["id"] = ExpressionConverter.ConvertO(requestBodyOfRecordrecordNumber);
            requestBodyOfRecord["schemaType"] = "ACTION_PUT_RECORD";
            requestBodyOfRecordpropCount++;
            if (requestBodyOfRecordrecord != null)
            {
                requestBodyOfRecord["record"] = ExpressionConverter.ConvertO(requestBodyOfRecordrecord);
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
        public IWorkflowTrigger WebhookTrigger([WorkflowExpression] Func<string> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(requestBodyOfWebhookappID);
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

        public IWorkflowTrigger AddWebhookForUpdatingRecord([WorkflowExpression] Func<string> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/update_record.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(requestBodyOfWebhookappID);
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

        public IWorkflowTrigger AddWebhookForDeletingRecord([WorkflowExpression] Func<string> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/delete_record.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(requestBodyOfWebhookappID);
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

        public IWorkflowTrigger AddWebhookForAddingRecordComment([WorkflowExpression] Func<string> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/add_record_comment.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(requestBodyOfWebhookappID);
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

        public IWorkflowTrigger AddWebhookForUpdatingStatus([WorkflowExpression] Func<string> requestBodyOfWebhookappID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/k/integration/v1/preview/app/webhook/update_status.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["app"] = ExpressionConverter.ConvertO(requestBodyOfWebhookappID);
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