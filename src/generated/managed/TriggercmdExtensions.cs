//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Triggercmd
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TriggercmdActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "triggercmd")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RunCommand(Expression<Func<RunCommandInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/oauth/flow/trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class TriggercmdTriggers([ConnectionName] string connectionId)
    {
    }

    public class RunCommandInput
    {
        [JsonProperty("computer", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Computer { get; set; }

        [JsonProperty("trigger", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Trigger { get; set; }

        [JsonProperty("params")]
        public string Params { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Triggercmd;

    public partial class WorkflowManagedActions
    {
        public TriggercmdActions Triggercmd(string connectionId) => new TriggercmdActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TriggercmdTriggers Triggercmd(string connectionId) => new TriggercmdTriggers(connectionId);
    }
}