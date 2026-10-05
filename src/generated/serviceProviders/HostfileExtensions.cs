//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Hostfile
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class HostfileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateFileContents))]
        public IBodyWorkflowAction<GenerateFileContentsOutput> GenerateFileContents([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> schema, [WorkflowExpression] Func<JToken[]> rows)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateFileContentsOutput> __BuildGenerateFileContents(WorkflowValue<string> hidx, WorkflowValue<string> schema, WorkflowValue<JToken[]> rows)
        {
            WorkflowValue.Validate(hidx, nameof(hidx), required: true);
            WorkflowValue.Validate(schema, nameof(schema), required: true);
            WorkflowValue.Validate(rows, nameof(rows), required: true);
            return new DeferredBodyAction<GenerateFileContentsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(hidx);
                serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
                serviceProviderParameters["rows"] = ExpressionConverter.ConvertO(rows);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "generateFileContents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GenerateFileContentsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        [WorkflowExpressionFactory(nameof(__BuildParseFileContents))]
        public IBodyWorkflowAction<ParseFileContentsOutput> ParseFileContents([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> schema, [WorkflowExpression] Func<string> contents)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseFileContentsOutput> __BuildParseFileContents(WorkflowValue<string> hidx, WorkflowValue<string> schema, WorkflowValue<string> contents)
        {
            WorkflowValue.Validate(hidx, nameof(hidx), required: true);
            WorkflowValue.Validate(schema, nameof(schema), required: true);
            WorkflowValue.Validate(contents, nameof(contents), required: true);
            return new DeferredBodyAction<ParseFileContentsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(hidx);
                serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(schema);
                serviceProviderParameters["contents"] = ExpressionConverter.ConvertO(contents);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "parseFileContents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ParseFileContentsOutput>(serviceProviderInput);
            });
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
