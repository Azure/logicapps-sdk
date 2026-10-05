//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushcut
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PushcutActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushcut")]
        [WorkflowExpressionFactory(nameof(__BuildSendNotification))]
        public IWorkflowAction SendNotification([WorkflowExpression] Func<string> notificationName, [WorkflowExpression] Func<string> bodydynamicText = null, [WorkflowExpression] Func<string> bodydynamicTitle = null, [WorkflowExpression] Func<string> bodyinputParameter = null, [WorkflowExpression] Func<string[]> bodydevices = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendNotification(WorkflowValue<string> notificationName, WorkflowValue<string> bodydynamicText = null, WorkflowValue<string> bodydynamicTitle = null, WorkflowValue<string> bodyinputParameter = null, WorkflowValue<string[]> bodydevices = null)
        {
            WorkflowValue.Validate(notificationName, nameof(notificationName), required: true);
            WorkflowValue.Validate(bodydynamicText, nameof(bodydynamicText), required: false);
            WorkflowValue.Validate(bodydynamicTitle, nameof(bodydynamicTitle), required: false);
            WorkflowValue.Validate(bodyinputParameter, nameof(bodyinputParameter), required: false);
            WorkflowValue.Validate(bodydevices, nameof(bodydevices), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notifications/{0}", ExpressionConverter.ConvertWithUrlEncoding(notificationName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydynamicText != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodydynamicText);
                    bodypropCount++;
                }

                if (bodydynamicTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodydynamicTitle);
                    bodypropCount++;
                }

                if (bodyinputParameter != null)
                {
                    body["input"] = ExpressionConverter.ConvertO(bodyinputParameter);
                    bodypropCount++;
                }

                if (bodydevices != null)
                {
                    body["devices"] = ExpressionConverter.ConvertO(bodydevices);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PushcutTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildActionExecuted))]
        public IWorkflowTrigger ActionExecuted([WorkflowExpression] Func<string> bodyactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildActionExecuted(WorkflowValue<string> bodyactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyactionName, nameof(bodyactionName), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["actionName"] = ExpressionConverter.ConvertO(bodyactionName);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pushcut;

    public partial class WorkflowManagedActions
    {
        public PushcutActions Pushcut(string connectionId) => new PushcutActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PushcutTriggers Pushcut(string connectionId) => new PushcutTriggers(connectionId);
    }
}
