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
        public IWorkflowAction AddRecord([WorkflowExpression] Func<string> requestBodyOfRecordappId, [WorkflowExpression] Func<object> requestBodyOfRecordRecord = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/k/v1/record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfRecord = new JObject();
                var requestBodyOfRecordpropCount = 0;
                requestBodyOfRecordpropCount++;
                requestBodyOfRecord["app"] = SourceExpressionConverter.ConvertToken(requestBodyOfRecordappId);
                requestBodyOfRecord["schemaType"] = "ACTION_POST_RECORD";
                requestBodyOfRecordpropCount++;
                if (requestBodyOfRecordRecord != null)
                {
                    requestBodyOfRecord["record"] = SourceExpressionConverter.ConvertToken(requestBodyOfRecordRecord);
                    requestBodyOfRecordpropCount++;
                }

                if (requestBodyOfRecordpropCount > 0)
                {
                    callPayload.Body = requestBodyOfRecord;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kintone")]
        public IWorkflowAction UpdateRecord([WorkflowExpression] Func<string> requestBodyOfRecordappId, [WorkflowExpression] Func<string> requestBodyOfRecordrecordNumber, [WorkflowExpression] Func<object> requestBodyOfRecordRecord = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/k/v1/record.json";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfRecord = new JObject();
                var requestBodyOfRecordpropCount = 0;
                requestBodyOfRecordpropCount++;
                requestBodyOfRecord["app"] = SourceExpressionConverter.ConvertToken(requestBodyOfRecordappId);
                requestBodyOfRecordpropCount++;
                requestBodyOfRecord["id"] = SourceExpressionConverter.ConvertToken(requestBodyOfRecordrecordNumber);
                requestBodyOfRecord["schemaType"] = "ACTION_PUT_RECORD";
                requestBodyOfRecordpropCount++;
                if (requestBodyOfRecordRecord != null)
                {
                    requestBodyOfRecord["record"] = SourceExpressionConverter.ConvertToken(requestBodyOfRecordRecord);
                    requestBodyOfRecordpropCount++;
                }

                if (requestBodyOfRecordpropCount > 0)
                {
                    callPayload.Body = requestBodyOfRecord;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class KintoneTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WebhookTrigger([WorkflowExpression] Func<string> requestBodyOfWebhookappId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookappId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForUpdatingRecord([WorkflowExpression] Func<string> requestBodyOfWebhookappId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/update_record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookappId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForDeletingRecord([WorkflowExpression] Func<string> requestBodyOfWebhookappId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/delete_record.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookappId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForAddingRecordComment([WorkflowExpression] Func<string> requestBodyOfWebhookappId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/add_record_comment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookappId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AddWebhookForUpdatingStatus([WorkflowExpression] Func<string> requestBodyOfWebhookappId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/k/integration/v1/preview/app/webhook/update_status.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["app"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookappId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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