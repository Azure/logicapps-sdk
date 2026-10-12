//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flic
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlicActions([ConnectionName] string connectionId)
    {
    }

    public class FlicTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildFlicButtonTrigger))]
        public IWorkflowTrigger FlicButtonTrigger([WorkflowExpression] Func<string> buttonUuid,[WorkflowExpression] Func<requestBodyOfWebhookeventsInput> requestBodyOfWebhookevents = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFlicButtonTrigger(WorkflowExpression<string> buttonUuid,WorkflowExpression<requestBodyOfWebhookeventsInput> requestBodyOfWebhookevents = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(buttonUuid, nameof(buttonUuid), required: true);
            WorkflowExpression.Validate(requestBodyOfWebhookevents, nameof(requestBodyOfWebhookevents), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/msflow/subscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(buttonUuid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookevents != null)
                {
                    if (requestBodyOfWebhookevents != null)
                    {
                        requestBodyOfWebhook["events"] = ExpressionConverter.ConvertO(requestBodyOfWebhookevents);
                        requestBodyOfWebhookpropCount++;
                    }

                    requestBodyOfWebhookpropCount++;
                }
                else
                {
                    requestBodyOfWebhook["events"] = "any";
                    requestBodyOfWebhookpropCount++;
                }

                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildFlicTaskTrigger))]
        public IWorkflowTrigger FlicTaskTrigger([WorkflowExpression] Func<string> taskUuid,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFlicTaskTrigger(WorkflowExpression<string> taskUuid,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(taskUuid, nameof(taskUuid), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/msflow/subscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskUuid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["url"] = "#{listCallbackUrl()}";
                requestBodyOfWebhookpropCount++;
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestBodyOfWebhookeventsInput
    {
        [EnumMember(Value = "click")]
        Click,
        [EnumMember(Value = "double click")]
        DoubleClick,
        [EnumMember(Value = "hold")]
        Hold,
        [EnumMember(Value = "any")]
        Any
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flic;

    public partial class WorkflowManagedActions
    {
        public FlicActions Flic(string connectionId) => new FlicActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlicTriggers Flic(string connectionId) => new FlicTriggers(connectionId);
    }
}