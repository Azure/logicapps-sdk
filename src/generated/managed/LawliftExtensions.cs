//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lawlift
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LawliftActions([ConnectionName] string connectionId)
    {
    }

    public class LawliftTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildLawliftExportTrigger))]
        public IBodyWorkflowTrigger<LawliftExportTriggerResponse> LawliftExportTrigger([WorkflowExpression] Func<string> bodyflowName = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<LawliftExportTriggerResponse> __BuildLawliftExportTrigger(WorkflowExpression<string> bodyflowName = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyflowName, nameof(bodyflowName), required: false);
            return new DeferredBodyTrigger<LawliftExportTriggerResponse>(() =>
            {
                var apiCallPath = "/webhooks/export";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyflowName != null)
                {
                    body["flowName"] = ExpressionConverter.ConvertO(bodyflowName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<LawliftExportTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildLawliftNotificationTrigger))]
        public IBodyWorkflowTrigger<LawliftNotificationTriggerResponse> LawliftNotificationTrigger([WorkflowExpression] Func<string> bodyflowName = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<LawliftNotificationTriggerResponse> __BuildLawliftNotificationTrigger(WorkflowExpression<string> bodyflowName = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyflowName, nameof(bodyflowName), required: false);
            return new DeferredBodyTrigger<LawliftNotificationTriggerResponse>(() =>
            {
                var apiCallPath = "/webhooks/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyflowName != null)
                {
                    body["flowName"] = ExpressionConverter.ConvertO(bodyflowName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<LawliftNotificationTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class LawliftExportTriggerResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class LawliftNotificationTriggerResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lawlift;

    public partial class WorkflowManagedActions
    {
        public LawliftActions Lawlift(string connectionId) => new LawliftActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LawliftTriggers Lawlift(string connectionId) => new LawliftTriggers(connectionId);
    }
}