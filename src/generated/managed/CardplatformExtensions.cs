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
        public IBodyWorkflowAction<string> SendMessage([WorkflowExpression] Func<string[]> cardbodyrecipients, [WorkflowExpression] Func<string> cardbodyheading, [WorkflowExpression] Func<string> cardbodyadaptiveCard)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sendmessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var cardbody = new JObject();
                var cardbodypropCount = 0;
                cardbodypropCount++;
                cardbody["recipients"] = SourceExpressionConverter.ConvertToken(cardbodyrecipients);
                cardbodypropCount++;
                cardbody["heading"] = SourceExpressionConverter.ConvertToken(cardbodyheading);
                cardbodypropCount++;
                cardbody["card"] = SourceExpressionConverter.ConvertToken(cardbodyadaptiveCard);
                if (cardbodypropCount > 0)
                {
                    callPayload.Body = cardbody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction PrivateTemplatesDelete([WorkflowExpression] Func<string> name)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction PrivateTemplatesUpdate([WorkflowExpression] Func<string> name)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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