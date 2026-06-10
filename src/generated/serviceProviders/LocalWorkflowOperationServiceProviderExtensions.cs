//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.LocalWorkflowOperation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LocalWorkflowOperationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "localWorkflowOperation")]
        public IBodyWorkflowAction<JToken> InvokeWorkflow(Expression<Func<InvokeWorkflowHostType>> host, Expression<Func<object>> body = null, Expression<Func<object>> headers = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["host"] = ExpressionConverter.ConvertO(host);
            if (body != null)
            {
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
            }

            if (headers != null)
            {
                serviceProviderParameters["headers"] = ExpressionConverter.ConvertO(headers);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/localWorkflowOperation", operationId: "invokeWorkflow", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "localWorkflowOperation")]
        public IBodyWorkflowAction<JToken> InvokeNestedAgent(Expression<Func<InvokeNestedAgentHostType>> host, Expression<Func<InvokeNestedAgentBodyType>> body)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["host"] = ExpressionConverter.ConvertO(host);
            serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/localWorkflowOperation", operationId: "invokeNestedAgent", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }
    }

    public class LocalWorkflowOperationTriggers([ConnectionName] string connectionId)
    {
    }

    public class InvokeWorkflowHostType
    {
        [JsonProperty("workflow")]
        public InvokeWorkflowHostTypeWorkflowType Workflow { get; set; }
    }

    public class InvokeWorkflowHostTypeWorkflowType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class InvokeNestedAgentHostType
    {
        [JsonProperty("workflow")]
        public InvokeNestedAgentHostTypeWorkflowType Workflow { get; set; }
    }

    public class InvokeNestedAgentHostTypeWorkflowType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class InvokeNestedAgentBodyType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.LocalWorkflowOperation;

    public partial class WorkflowServiceProviderActions
    {
        public LocalWorkflowOperationActions LocalWorkflowOperation(string connectionId) => new LocalWorkflowOperationActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public LocalWorkflowOperationTriggers LocalWorkflowOperation(string connectionId) => new LocalWorkflowOperationTriggers(connectionId);
    }
}