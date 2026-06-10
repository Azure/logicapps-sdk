//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Hostfile
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HostfileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        public IBodyWorkflowAction<GenerateFileContentsOutput> GenerateFileContents(Expression<Func<string>> hidx, Expression<Func<string>> schema, Expression<Func<JToken[]>> rows)
        {
            var parameters = new JObject();
            parameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            parameters["schema"] = ExpressionConverter.ConvertO(schema);
            parameters["rows"] = ExpressionConverter.ConvertO(rows);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "generateFileContents", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GenerateFileContentsOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        public IBodyWorkflowAction<ParseFileContentsOutput> ParseFileContents(Expression<Func<string>> hidx, Expression<Func<string>> schema, Expression<Func<string>> contents)
        {
            var parameters = new JObject();
            parameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            parameters["schema"] = ExpressionConverter.ConvertO(schema);
            parameters["contents"] = ExpressionConverter.ConvertO(contents);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "parseFileContents", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ParseFileContentsOutput>(input);
        }
    }

    public class HostfileTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateFileContentsOutput
    {
        [JsonProperty("contents")]
        public string Contents { get; set; }
    }

    public class ParseFileContentsOutput
    {
        [JsonProperty("rows")]
        public JToken[] Rows { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Hostfile;

    public partial class WorkflowServiceProviderActions
    {
        public HostfileActions Hostfile(string connectionId) => new HostfileActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public HostfileTriggers Hostfile(string connectionId) => new HostfileTriggers(connectionId);
    }
}