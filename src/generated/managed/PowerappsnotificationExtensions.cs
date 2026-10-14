//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powerappsnotification
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PowerappsnotificationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powerappsnotification")]
        public IWorkflowAction SendPushNotification(Expression<Func<string[]>> payloadrecipients = null, Expression<Func<string>> payloadmessage = null, Expression<Func<bool>> payloadopenApp = null)
        {
            var __workflow_payloadrecipients = payloadrecipients == null ? null : WorkflowExpression.Compile(payloadrecipients);
            WorkflowExpression.Validate(__workflow_payloadrecipients, nameof(payloadrecipients), required: false);
            var __workflow_payloadmessage = payloadmessage == null ? null : WorkflowExpression.Compile(payloadmessage);
            WorkflowExpression.Validate(__workflow_payloadmessage, nameof(payloadmessage), required: false);
            var __workflow_payloadopenApp = payloadopenApp == null ? null : WorkflowExpression.Compile(payloadopenApp);
            WorkflowExpression.Validate(__workflow_payloadopenApp, nameof(payloadopenApp), required: false);
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
