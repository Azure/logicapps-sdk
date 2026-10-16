//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ImsProgramCall
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ImsProgramCallActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "imsProgramCall")]
        public IBodyWorkflowAction<JToken> ExecuteMethod(Expression<Func<string>> hidx, Expression<Func<string>> method, Expression<Func<object>> inputParameters)
        {
            var __workflow_hidx = WorkflowExpression.Compile(hidx, nameof(hidx), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_inputParameters = WorkflowExpression.Compile(inputParameters, nameof(inputParameters), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = ExpressionConverter.ConvertO(__workflow_hidx);
                serviceProviderParameters["method"] = ExpressionConverter.ConvertO(__workflow_method);
                serviceProviderParameters["inputParameters"] = ExpressionConverter.ConvertO(__workflow_inputParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "executeMethod", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ImsProgramCall;

    public partial class WorkflowServiceProviderActions
    {
        public ImsProgramCallActions ImsProgramCall(string connectionId) => new ImsProgramCallActions(connectionId);
    }
}
