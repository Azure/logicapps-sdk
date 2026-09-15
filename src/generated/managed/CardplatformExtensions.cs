//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cardplatform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CardplatformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IBodyWorkflowAction<string> SendMessage(Expression<Func<string[]>> cardbodyrecipients, Expression<Func<string>> cardbodyheading, Expression<Func<string>> cardbodyadaptiveCard)
        {
            var apiCallPath = "/sendmessage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var cardbody = new JObject();
            var cardbodypropCount = 0;
            cardbodypropCount++;
            cardbody["recipients"] = CSharpExpressionConverter.ConvertToken(cardbodyrecipients);
            cardbodypropCount++;
            cardbody["heading"] = CSharpExpressionConverter.ConvertToken(cardbodyheading);
            cardbodypropCount++;
            cardbody["card"] = CSharpExpressionConverter.ConvertToken(cardbodyadaptiveCard);
            if (cardbodypropCount > 0)
            {
                callPayload.Body = cardbody;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction PrivateTemplatesDelete(Expression<Func<string>> name)
        {
            var apiCallPath = "/PrivateTemplates";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction PrivateTemplatesUpdate(Expression<Func<string>> name)
        {
            var apiCallPath = "/PrivateTemplates";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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