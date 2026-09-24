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
        public IWorkflowAction SendNotification([WorkflowExpression] Func<string> notificationName, [WorkflowExpression] Func<string> bodydynamicText = null, [WorkflowExpression] Func<string> bodydynamicTitle = null, [WorkflowExpression] Func<string> bodyinputParameter = null, [WorkflowExpression] Func<string[]> bodydevices = null)
        {
            SourceExpression.Validate(notificationName, nameof(notificationName), required: true);
            SourceExpression.Validate(bodydynamicText, nameof(bodydynamicText), required: false);
            SourceExpression.Validate(bodydynamicTitle, nameof(bodydynamicTitle), required: false);
            SourceExpression.Validate(bodyinputParameter, nameof(bodyinputParameter), required: false);
            SourceExpression.Validate(bodydevices, nameof(bodydevices), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/notifications/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(notificationName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydynamicText != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodydynamicText);
                    bodypropCount++;
                }

                if (bodydynamicTitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodydynamicTitle);
                    bodypropCount++;
                }

                if (bodyinputParameter != null)
                {
                    body["input"] = SourceExpressionConverter.ConvertToken(bodyinputParameter);
                    bodypropCount++;
                }

                if (bodydevices != null)
                {
                    body["devices"] = SourceExpressionConverter.ConvertToken(bodydevices);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class PushcutTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ActionExecuted([WorkflowExpression] Func<string> bodyactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyactionName, nameof(bodyactionName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["actionName"] = SourceExpressionConverter.ConvertToken(bodyactionName);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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