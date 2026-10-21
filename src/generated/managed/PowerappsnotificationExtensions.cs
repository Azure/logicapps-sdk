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
        public IWorkflowAction SendPushNotification(Expression<Func<string[]>> payloadrecipients = null, Expression<Func<string>> payloadmessage = null, Expression<Func<bool>> payloadopenApp = null)
        {
            var __workflow_payloadrecipients = WorkflowExpression.Compile(payloadrecipients, nameof(payloadrecipients), required: false);
            var __workflow_payloadmessage = WorkflowExpression.Compile(payloadmessage, nameof(payloadmessage), required: false);
            var __workflow_payloadopenApp = WorkflowExpression.Compile(payloadopenApp, nameof(payloadopenApp), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/providers/Microsoft.PowerApps/scopes/connector/sendPushNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var payload = new JObject();
                var payloadpropCount = 0;
                if (__workflow_payloadrecipients != null)
                {
                    payload["recipients"] = ExpressionConverter.ConvertO(__workflow_payloadrecipients);
                    payloadpropCount++;
                }

                if (__workflow_payloadmessage != null)
                {
                    payload["message"] = ExpressionConverter.ConvertO(__workflow_payloadmessage);
                    payloadpropCount++;
                }

                if (__workflow_payloadopenApp != null)
                {
                    payload["openApp"] = ExpressionConverter.ConvertO(__workflow_payloadopenApp);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
