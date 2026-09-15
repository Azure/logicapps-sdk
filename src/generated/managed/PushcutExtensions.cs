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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/notifications/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(notificationName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydynamicText != null)
            {
                body["text"] = CSharpExpressionConverter.ConvertToken(bodydynamicText);
                bodypropCount++;
            }

            if (bodydynamicTitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodydynamicTitle);
                bodypropCount++;
            }

            if (bodyinputParameter != null)
            {
                body["input"] = CSharpExpressionConverter.ConvertToken(bodyinputParameter);
                bodypropCount++;
            }

            if (bodydevices != null)
            {
                body["devices"] = CSharpExpressionConverter.ConvertToken(bodydevices);
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
        public IWorkflowTrigger ActionExecuted(Expression<Func<string>> bodyactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["actionName"] = CSharpExpressionConverter.ConvertToken(bodyactionName);
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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