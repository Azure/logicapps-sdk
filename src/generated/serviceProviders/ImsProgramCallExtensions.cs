//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.ImsProgramCall
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class ImsProgramCallActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "imsProgramCall")]
        public IBodyWorkflowAction<JToken> ExecuteMethod([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> inputParameters)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["method"] = SourceExpressionConverter.ConvertToken(method);
                serviceProviderParameters["inputParameters"] = SourceExpressionConverter.ConvertToken(inputParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "executeMethod", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "imsProgramCall")]
        public IOutputWorkflowAction<JToken[]> GetHidxs()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "getHidxs", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "imsProgramCall")]
        public IOutputWorkflowAction<JToken[]> GetMethods([WorkflowExpression] Func<string> hidx)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "getMethods", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "imsProgramCall")]
        public IOutputWorkflowAction<JToken> GetInputSwagger([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> method)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["method"] = SourceExpressionConverter.ConvertToken(method);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "getInputSwagger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "imsProgramCall")]
        public IOutputWorkflowAction<JToken> GetOutputSwagger([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> method)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["method"] = SourceExpressionConverter.ConvertToken(method);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/imsProgramCall", operationId: "getOutputSwagger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
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