//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lawlift
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LawliftActions([ConnectionName] string connectionId)
    {
    }

    public class LawliftTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<LawliftExportTriggerResponse> LawliftExportTrigger(Expression<Func<string>> bodyflowName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyflowName = WorkflowExpression.Compile(bodyflowName, nameof(bodyflowName), required: false);
            return new DeferredBodyTrigger<LawliftExportTriggerResponse>(() =>
            {
                var apiCallPath = "/webhooks/export";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyflowName != null)
                {
                    body["flowName"] = ExpressionConverter.ConvertO(__workflow_bodyflowName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<LawliftExportTriggerResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<LawliftNotificationTriggerResponse> LawliftNotificationTrigger(Expression<Func<string>> bodyflowName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyflowName = WorkflowExpression.Compile(bodyflowName, nameof(bodyflowName), required: false);
            return new DeferredBodyTrigger<LawliftNotificationTriggerResponse>(() =>
            {
                var apiCallPath = "/webhooks/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyflowName != null)
                {
                    body["flowName"] = ExpressionConverter.ConvertO(__workflow_bodyflowName);
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
