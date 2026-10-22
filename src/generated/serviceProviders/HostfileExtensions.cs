//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Hostfile
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class HostfileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        public IBodyWorkflowAction<GenerateFileContentsOutput, GenerateFileContentsActionConfiguration> GenerateFileContents(Expression<Func<string>> hidx, Expression<Func<string>> schema, Expression<Func<JToken[]>> rows)
        {
            var __workflow_hidx = WorkflowExpression.Compile(hidx, nameof(hidx), required: true);
            var __workflow_schema = WorkflowExpression.Compile(schema, nameof(schema), required: true);
            var __workflow_rows = WorkflowExpression.Compile(rows, nameof(rows), required: true);
            return new DeferredBodyAction<GenerateFileContentsOutput, GenerateFileContentsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(__workflow_hidx);
                serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(__workflow_schema);
                serviceProviderParameters["rows"] = ExpressionConverter.ConvertO(__workflow_rows);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "generateFileContents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GenerateFileContentsOutput, GenerateFileContentsActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "hostfile")]
        public IBodyWorkflowAction<ParseFileContentsOutput, ParseFileContentsActionConfiguration> ParseFileContents(Expression<Func<string>> hidx, Expression<Func<string>> schema, Expression<Func<string>> contents)
        {
            var __workflow_hidx = WorkflowExpression.Compile(hidx, nameof(hidx), required: true);
            var __workflow_schema = WorkflowExpression.Compile(schema, nameof(schema), required: true);
            var __workflow_contents = WorkflowExpression.Compile(contents, nameof(contents), required: true);
            return new DeferredBodyAction<ParseFileContentsOutput, ParseFileContentsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(__workflow_hidx);
                serviceProviderParameters["schema"] = ExpressionConverter.ConvertO(__workflow_schema);
                serviceProviderParameters["contents"] = ExpressionConverter.ConvertO(__workflow_contents);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/hostfile", operationId: "parseFileContents", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<ParseFileContentsOutput, ParseFileContentsActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class GenerateFileContentsActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ParseFileContentsActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
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