//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerappsnotification
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerappsnotificationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerappsnotification")]
        [WorkflowExpressionFactory(nameof(__BuildSendPushNotification))]
        public IWorkflowAction SendPushNotification([WorkflowExpression] Func<string[]> payloadrecipients = null, [WorkflowExpression] Func<string> payloadmessage = null, [WorkflowExpression] Func<bool> payloadopenApp = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendPushNotification(WorkflowValue<string[]> payloadrecipients = null, WorkflowValue<string> payloadmessage = null, WorkflowValue<bool> payloadopenApp = null)
        {
            WorkflowValue.Validate(payloadrecipients, nameof(payloadrecipients), required: false);
            WorkflowValue.Validate(payloadmessage, nameof(payloadmessage), required: false);
            WorkflowValue.Validate(payloadopenApp, nameof(payloadopenApp), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/providers/Microsoft.PowerApps/scopes/connector/sendPushNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var payload = new JObject();
                var payloadpropCount = 0;
                if (payloadrecipients != null)
                {
                    payload["recipients"] = ExpressionConverter.ConvertO(payloadrecipients);
                    payloadpropCount++;
                }

                if (payloadmessage != null)
                {
                    payload["message"] = ExpressionConverter.ConvertO(payloadmessage);
                    payloadpropCount++;
                }

                if (payloadopenApp != null)
                {
                    payload["openApp"] = ExpressionConverter.ConvertO(payloadopenApp);
                    payloadpropCount++;
                }

                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    payload["params"] = @paramsObject;
                    payloadpropCount++;
                }

                if (payloadpropCount > 0)
                {
                    callPayload.Body = payload;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PowerappsnotificationTriggers([ConnectionName] string connectionId)
    {
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
