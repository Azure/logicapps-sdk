//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Lawlift
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LawliftActions([ConnectionName] string connectionId)
    {
    }

    public class LawliftTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<LawliftExportTriggerResponse> LawliftExportTrigger(Expression<Func<string>> bodyflowName = null)
        {
            var apiCallPath = "/webhooks/export";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger<LawliftExportTriggerResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<LawliftNotificationTriggerResponse> LawliftNotificationTrigger(Expression<Func<string>> bodyflowName = null)
        {
            var apiCallPath = "/webhooks/notifications";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger<LawliftNotificationTriggerResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Lawlift;

    public partial class WorkflowManagedActions
    {
        public LawliftActions Lawlift(string connectionId) => new LawliftActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LawliftTriggers Lawlift(string connectionId) => new LawliftTriggers(connectionId);
    }
}