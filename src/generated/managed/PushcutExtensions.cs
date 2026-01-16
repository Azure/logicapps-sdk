//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushcut
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PushcutActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushcut")]
        public IWorkflowAction SendNotification(Expression<Func<string>> notificationName, Expression<Func<string>> bodydynamicText = null, Expression<Func<string>> bodydynamicTitle = null, Expression<Func<string>> bodyinputParameter = null, Expression<Func<string[]>> bodydevices = null)
        {
            var apiCallPath = String.Format("/notifications/{0}", ExpressionConverter.ConvertWithUrlEncoding(notificationName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydynamicText != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodydynamicText);
                bodypropCount++;
            }

            if (bodydynamicTitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodydynamicTitle);
                bodypropCount++;
            }

            if (bodyinputParameter != null)
            {
                body["input"] = ExpressionConverter.ConvertO(bodyinputParameter);
                bodypropCount++;
            }

            if (bodydevices != null)
            {
                body["devices"] = ExpressionConverter.ConvertO(bodydevices);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class PushcutTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ActionExecuted(Expression<Func<string>> bodyactionName)
        {
            var apiCallPath = "/subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["actionName"] = ExpressionConverter.ConvertO(bodyactionName);
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pushcut;

    public partial class WorkflowManagedActions
    {
        public PushcutActions Pushcut(string connectionId) => new PushcutActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PushcutTriggers Pushcut(string connectionId) => new PushcutTriggers(connectionId);
    }
}