//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pushcut
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PushcutActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pushcut")]
        public IWorkflowAction SendNotification(Expression<Func<string>> notificationName, Expression<Func<string>> bodydynamicText = null, Expression<Func<string>> bodydynamicTitle = null, Expression<Func<string>> bodyinputParameter = null, Expression<Func<string[]>> bodydevices = null)
        {
            var __workflow_notificationName = WorkflowExpression.Compile(notificationName, nameof(notificationName), required: true);
            var __workflow_bodydynamicText = WorkflowExpression.Compile(bodydynamicText, nameof(bodydynamicText), required: false);
            var __workflow_bodydynamicTitle = WorkflowExpression.Compile(bodydynamicTitle, nameof(bodydynamicTitle), required: false);
            var __workflow_bodyinputParameter = WorkflowExpression.Compile(bodyinputParameter, nameof(bodyinputParameter), required: false);
            var __workflow_bodydevices = WorkflowExpression.Compile(bodydevices, nameof(bodydevices), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notifications/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_notificationName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydynamicText != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodydynamicText);
                    bodypropCount++;
                }

                if (__workflow_bodydynamicTitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodydynamicTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyinputParameter != null)
                {
                    body["input"] = ExpressionConverter.ConvertO(__workflow_bodyinputParameter);
                    bodypropCount++;
                }

                if (__workflow_bodydevices != null)
                {
                    body["devices"] = ExpressionConverter.ConvertO(__workflow_bodydevices);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PushcutTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ActionExecuted(Expression<Func<string>> bodyactionName, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyactionName = WorkflowExpression.Compile(bodyactionName, nameof(bodyactionName), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["actionName"] = ExpressionConverter.ConvertO(__workflow_bodyactionName);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
