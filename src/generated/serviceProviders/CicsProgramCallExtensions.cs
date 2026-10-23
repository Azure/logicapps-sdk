//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.CicsProgramCall
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class CicsProgramCallActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "cicsProgramCall")]
        public IBodyWorkflowAction<JToken, ExecuteMethodActionConfiguration> ExecuteMethod(Expression<Func<string>> hidx, Expression<Func<string>> method, Expression<Func<object>> inputParameters)
        {
            var __workflow_hidx = WorkflowExpression.Compile(hidx, nameof(hidx), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_inputParameters = WorkflowExpression.Compile(inputParameters, nameof(inputParameters), required: true);
            return new DeferredBodyAction<JToken, ExecuteMethodActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(__workflow_hidx);
                serviceProviderParameters["method"] = ExpressionConverter.ConvertO(__workflow_method);
                serviceProviderParameters["inputParameters"] = ExpressionConverter.ConvertO(__workflow_inputParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/cicsProgramCall", operationId: "executeMethod", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken, ExecuteMethodActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class ExecuteMethodActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.CicsProgramCall;

    public partial class WorkflowServiceProviderActions
    {
        public CicsProgramCallActions CicsProgramCall(string connectionId) => new CicsProgramCallActions(connectionId);
    }
}