//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mondaycomip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MondaycomipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mondaycomip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CallGraphQL(Expression<Func<CallGraphQLInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class MondaycomipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CallGraphQLInput
    {
        [JsonProperty("query")]
        public string Query { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mondaycomip;

    public partial class WorkflowManagedActions
    {
        public MondaycomipActions Mondaycomip(string connectionId) => new MondaycomipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MondaycomipTriggers Mondaycomip(string connectionId) => new MondaycomipTriggers(connectionId);
    }
}