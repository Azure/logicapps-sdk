//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cardplatform
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CardplatformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IBodyWorkflowAction<string> SendMessage(Expression<Func<string[]>> cardbodyrecipients, Expression<Func<string>> cardbodyheading, Expression<Func<string>> cardbodyadaptiveCard)
        {
            var __workflow_cardbodyrecipients = cardbodyrecipients == null ? null : WorkflowExpression.Compile(cardbodyrecipients);
            WorkflowExpression.Validate(__workflow_cardbodyrecipients, nameof(cardbodyrecipients), required: true);
            var __workflow_cardbodyheading = cardbodyheading == null ? null : WorkflowExpression.Compile(cardbodyheading);
            WorkflowExpression.Validate(__workflow_cardbodyheading, nameof(cardbodyheading), required: true);
            var __workflow_cardbodyadaptiveCard = cardbodyadaptiveCard == null ? null : WorkflowExpression.Compile(cardbodyadaptiveCard);
            WorkflowExpression.Validate(__workflow_cardbodyadaptiveCard, nameof(cardbodyadaptiveCard), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/sendmessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var cardbody = new JObject();
                var cardbodypropCount = 0;
                cardbodypropCount++;
                cardbody["recipients"] = ExpressionConverter.ConvertO(__workflow_cardbodyrecipients);
                cardbodypropCount++;
                cardbody["heading"] = ExpressionConverter.ConvertO(__workflow_cardbodyheading);
                cardbodypropCount++;
                cardbody["card"] = ExpressionConverter.ConvertO(__workflow_cardbodyadaptiveCard);
                if (cardbodypropCount > 0)
                {
                    callPayload.Body = cardbody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction PrivateTemplatesDelete(Expression<Func<string>> name)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction PrivateTemplatesUpdate(Expression<Func<string>> name)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
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
