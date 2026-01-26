//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sasdecisioning
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SasdecisioningActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sasdecisioning")]
        public IBodyWorkflowAction<StepOutput> ExecuteStep(Expression<Func<string>> moduleId, Expression<Func<string>> stepId, Expression<Func<Variable[]>> inputinputs)
        {
            var apiCallPath = String.Format("/microanalyticScore/modules/{0}/steps/{1}", ExpressionConverter.ConvertWithUrlEncoding(moduleId, 1), ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            inputpropCount++;
            input["inputs"] = ExpressionConverter.ConvertO(inputinputs);
            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<StepOutput>(callPayload);
        }
    }

    public class SasdecisioningTriggers([ConnectionName] string connectionId)
    {
    }

    public class StepOutput
    {
        [JsonProperty("moduleId")]
        public string ModuleId { get; set; }

        [JsonProperty("stepId")]
        public string StepId { get; set; }

        [JsonProperty("outputs")]
        public Variable[] Outputs { get; set; }
    }

    public class Variable
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sasdecisioning;

    public partial class WorkflowManagedActions
    {
        public SasdecisioningActions Sasdecisioning(string connectionId) => new SasdecisioningActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SasdecisioningTriggers Sasdecisioning(string connectionId) => new SasdecisioningTriggers(connectionId);
    }
}