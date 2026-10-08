//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cardplatform
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CardplatformActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<string> SendMessage([WorkflowExpression] Func<string[]> cardbodyrecipients, [WorkflowExpression] Func<string> cardbodyheading, [WorkflowExpression] Func<string> cardbodyadaptiveCard)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSendMessage(WorkflowExpression<string[]> cardbodyrecipients, WorkflowExpression<string> cardbodyheading, WorkflowExpression<string> cardbodyadaptiveCard)
        {
            WorkflowExpression.Validate(cardbodyrecipients, nameof(cardbodyrecipients), required: true);
            WorkflowExpression.Validate(cardbodyheading, nameof(cardbodyheading), required: true);
            WorkflowExpression.Validate(cardbodyadaptiveCard, nameof(cardbodyadaptiveCard), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/sendmessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var cardbody = new JObject();
                var cardbodypropCount = 0;
                cardbodypropCount++;
                cardbody["recipients"] = ExpressionConverter.ConvertO(cardbodyrecipients);
                cardbodypropCount++;
                cardbody["heading"] = ExpressionConverter.ConvertO(cardbodyheading);
                cardbodypropCount++;
                cardbody["card"] = ExpressionConverter.ConvertO(cardbodyadaptiveCard);
                if (cardbodypropCount > 0)
                {
                    callPayload.Body = cardbody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        [WorkflowExpressionFactory(nameof(__BuildPrivateTemplatesDelete))]
        public IWorkflowAction PrivateTemplatesDelete([WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPrivateTemplatesDelete(WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        [WorkflowExpressionFactory(nameof(__BuildPrivateTemplatesUpdate))]
        public IWorkflowAction PrivateTemplatesUpdate([WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPrivateTemplatesUpdate(WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CardplatformTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cardplatform;

    public partial class WorkflowManagedActions
    {
        public CardplatformActions Cardplatform(string connectionId) => new CardplatformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CardplatformTriggers Cardplatform(string connectionId) => new CardplatformTriggers(connectionId);
    }
}