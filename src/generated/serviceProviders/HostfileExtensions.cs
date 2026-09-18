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
        public IBodyWorkflowAction<GenerateFileContentsOutput> GenerateFileContents([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> schema, [WorkflowExpression] Func<JToken[]> rows)
        {
            SourceExpression.Validate(hidx, nameof(hidx), required: true);
            SourceExpression.Validate(schema, nameof(schema), required: true);
            SourceExpression.Validate(rows, nameof(rows), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["schema"] = SourceExpressionConverter.ConvertToken(schema);
                serviceProviderParameters["rows"] = SourceExpressionConverter.ConvertToken(rows);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "generateFileContents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GenerateFileContentsOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        public IBodyWorkflowAction<ParseFileContentsOutput> ParseFileContents([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> schema, [WorkflowExpression] Func<string> contents)
        {
            SourceExpression.Validate(hidx, nameof(hidx), required: true);
            SourceExpression.Validate(schema, nameof(schema), required: true);
            SourceExpression.Validate(contents, nameof(contents), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["schema"] = SourceExpressionConverter.ConvertToken(schema);
                serviceProviderParameters["contents"] = SourceExpressionConverter.ConvertToken(contents);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "parseFileContents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ParseFileContentsOutput>(BuildSourceInput);
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