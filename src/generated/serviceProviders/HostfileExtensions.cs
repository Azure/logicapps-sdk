//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Hostfile
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class HostfileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        public IBodyWorkflowAction<GenerateFileContentsOutput> GenerateFileContents(Expression<Func<string>> hidx, Expression<Func<string>> schema, Expression<Func<JToken[]>> rows)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
            serviceProviderParameters["rows"] = ExpressionConverter.ConvertO(rows);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/hostfile", "generateFileContents", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GenerateFileContentsOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        public IBodyWorkflowAction<ParseFileContentsOutput> ParseFileContents(Expression<Func<string>> hidx, Expression<Func<string>> schema, Expression<Func<string>> contents)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(hidx);
            serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
            serviceProviderParameters["contents"] = ExpressionConverter.ConvertO(contents);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/hostfile", "parseFileContents", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ParseFileContentsOutput>(serviceProviderInput);
        }
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
}