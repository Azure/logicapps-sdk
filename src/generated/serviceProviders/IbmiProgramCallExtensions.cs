//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.IbmiProgramCall
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class IbmiProgramCallActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "ibmiProgramCall")]
        public IBodyWorkflowAction<JToken> ExecuteMethod([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> inputParameters)
        {
            SourceExpression.Validate(hidx, nameof(hidx), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(inputParameters, nameof(inputParameters), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["method"] = SourceExpressionConverter.ConvertToken(method);
                serviceProviderParameters["inputParameters"] = SourceExpressionConverter.ConvertToken(inputParameters);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/ibmiProgramCall", operationId: "executeMethod", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "ibmiProgramCall")]
        public IOutputWorkflowAction<JToken[]> GetHidxs()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/ibmiProgramCall", operationId: "getHidxs", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "ibmiProgramCall")]
        public IOutputWorkflowAction<JToken[]> GetMethods([WorkflowExpression] Func<string> hidx)
        {
            SourceExpression.Validate(hidx, nameof(hidx), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/ibmiProgramCall", operationId: "getMethods", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "ibmiProgramCall")]
        public IOutputWorkflowAction<JToken> GetInputSwagger([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> method)
        {
            SourceExpression.Validate(hidx, nameof(hidx), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["method"] = SourceExpressionConverter.ConvertToken(method);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/ibmiProgramCall", operationId: "getInputSwagger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "ibmiProgramCall")]
        public IOutputWorkflowAction<JToken> GetOutputSwagger([WorkflowExpression] Func<string> hidx, [WorkflowExpression] Func<string> method)
        {
            SourceExpression.Validate(hidx, nameof(hidx), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["hidx"] = SourceExpressionConverter.ConvertToken(hidx);
                serviceProviderParameters["method"] = SourceExpressionConverter.ConvertToken(method);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/ibmiProgramCall", operationId: "getOutputSwagger", connectionName: connectionId),
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
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.IbmiProgramCall;

    public partial class WorkflowServiceProviderActions
    {
        public IbmiProgramCallActions IbmiProgramCall(string connectionId) => new IbmiProgramCallActions(connectionId);
    }
}