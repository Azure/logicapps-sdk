//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cardplatform
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CardplatformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageInput>> cardbody)
        {
            var __workflow_cardbody = WorkflowExpression.Compile(cardbody, nameof(cardbody), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sendmessage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_cardbody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PrivateTemplatesDelete(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardplatform")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PrivateTemplatesUpdate(Expression<Func<string>> name, Expression<Func<object>> body = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PrivateTemplates";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CardplatformTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendMessageInput
    {
        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Recipients { get; set; }

        [JsonProperty("heading", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Heading { get; set; }

        [JsonProperty("card", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AdaptiveCard { get; set; }
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