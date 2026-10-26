//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerappsnotification
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerappsnotificationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerappsnotification")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendPushNotification(Expression<Func<SendPushNotificationInput>> payload)
        {
            var __workflow_payload = WorkflowExpression.Compile(payload, nameof(payload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/providers/Microsoft.PowerApps/scopes/connector/sendPushNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_payload);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PowerappsnotificationTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendPushNotificationInput
    {
        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("openApp")]
        public bool? OpenApp { get; set; }

        [JsonProperty("params")]
        public JToken Parameters { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powerappsnotification;

    public partial class WorkflowManagedActions
    {
        public PowerappsnotificationActions Powerappsnotification(string connectionId) => new PowerappsnotificationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowerappsnotificationTriggers Powerappsnotification(string connectionId) => new PowerappsnotificationTriggers(connectionId);
    }
}