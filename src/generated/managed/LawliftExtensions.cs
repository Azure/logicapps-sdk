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
        public IBodyWorkflowTrigger<LawliftExportTriggerResponse, ApiConnectionPollingTriggerConfiguration> LawliftExportTrigger(Expression<Func<BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<LawliftExportTriggerResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/export";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<LawliftExportTriggerResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<LawliftNotificationTriggerResponse, ApiConnectionPollingTriggerConfiguration> LawliftNotificationTrigger(Expression<Func<BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<LawliftNotificationTriggerResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<LawliftNotificationTriggerResponse>(callPayload);
            });
        }
    }

    public class LawliftExportTriggerResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("flowName")]
        public string FlowName { get; set; }
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