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
        public IWorkflowAction SendPushNotification([WorkflowExpression] Func<string[]> payloadrecipients = null, [WorkflowExpression] Func<string> payloadmessage = null, [WorkflowExpression] Func<bool> payloadopenApp = null)
        {
            SourceExpression.Validate(payloadrecipients, nameof(payloadrecipients), required: false);
            SourceExpression.Validate(payloadmessage, nameof(payloadmessage), required: false);
            SourceExpression.Validate(payloadopenApp, nameof(payloadopenApp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/providers/Microsoft.PowerApps/scopes/connector/sendPushNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var payload = new JObject();
                var payloadpropCount = 0;
                if (payloadrecipients != null)
                {
                    payload["recipients"] = SourceExpressionConverter.ConvertToken(payloadrecipients);
                    payloadpropCount++;
                }

                if (payloadmessage != null)
                {
                    payload["message"] = SourceExpressionConverter.ConvertToken(payloadmessage);
                    payloadpropCount++;
                }

                if (payloadopenApp != null)
                {
                    payload["openApp"] = SourceExpressionConverter.ConvertToken(payloadopenApp);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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