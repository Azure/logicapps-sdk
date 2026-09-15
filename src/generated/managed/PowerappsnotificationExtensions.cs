//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerappsnotification
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowerappsnotificationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerappsnotification")]
        public IWorkflowAction SendPushNotification(Expression<Func<string[]>> payloadrecipients = null, Expression<Func<string>> payloadmessage = null, Expression<Func<bool>> payloadopenApp = null)
        {
            var apiCallPath = "/providers/Microsoft.PowerApps/scopes/connector/sendPushNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var payload = new JObject();
            var payloadpropCount = 0;
            if (payloadrecipients != null)
            {
                payload["recipients"] = CSharpExpressionConverter.ConvertToken(payloadrecipients);
                payloadpropCount++;
            }

            if (payloadmessage != null)
            {
                payload["message"] = CSharpExpressionConverter.ConvertToken(payloadmessage);
                payloadpropCount++;
            }

            if (payloadopenApp != null)
            {
                payload["openApp"] = CSharpExpressionConverter.ConvertToken(payloadopenApp);
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