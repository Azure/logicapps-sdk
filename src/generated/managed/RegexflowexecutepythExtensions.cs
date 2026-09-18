//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Regexflowexecutepyth
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RegexflowexecutepythActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "regexflowexecutepyth")]
        public IBodyWorkflowAction<ExecutePythonResponse> ExecutePython([WorkflowExpression] Func<string> pythonCode = null)
        {
            var apiCallPath = "/ExecutePython";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(pythonCode);
            return new ApiConnectionAction<ExecutePythonResponse>(callPayload);
        }
    }

    public class RegexflowexecutepythTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExecutePythonResponse
    {
        [JsonProperty("isSuccess")]
        public string IsSuccess { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("output")]
        public JToken Output { get; set; }

        [JsonProperty("caution")]
        public string Caution { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Regexflowexecutepyth;

    public partial class WorkflowManagedActions
    {
        public RegexflowexecutepythActions Regexflowexecutepyth(string connectionId) => new RegexflowexecutepythActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RegexflowexecutepythTriggers Regexflowexecutepyth(string connectionId) => new RegexflowexecutepythTriggers(connectionId);
    }
}