//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.InlineCode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InlineCodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "inlineCode")]
        public IOutputWorkflowAction<JToken> JavaScriptCode(Expression<Func<object>> code, Expression<Func<JavaScriptCodeExplicitDependenciesType>> explicitDependencies = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["code"] = ExpressionConverter.ConvertO(code);
            if (explicitDependencies != null)
            {
                serviceProviderParameters["explicitDependencies"] = ExpressionConverter.ConvertO(explicitDependencies);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/inlineCode", operationId: "javaScriptCode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "inlineCode")]
        public IOutputWorkflowAction<JToken> CSharpScriptCode(Expression<Func<object>> codeFile)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["CodeFile"] = ExpressionConverter.ConvertO(codeFile);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/inlineCode", operationId: "cSharpScriptCode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "inlineCode")]
        public IOutputWorkflowAction<JToken> PowershellCode(Expression<Func<object>> codeFile)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["CodeFile"] = ExpressionConverter.ConvertO(codeFile);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/inlineCode", operationId: "powershellCode", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<JToken>(serviceProviderInput);
        }
    }

    public class InlineCodeTriggers([ConnectionName] string connectionId)
    {
    }

    public class JavaScriptCodeExplicitDependenciesType
    {
        [JsonProperty("actions")]
        public string[] Actions { get; set; }

        [JsonProperty("includeTrigger")]
        public bool IncludeTrigger { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.InlineCode;

    public partial class WorkflowServiceProviderActions
    {
        public InlineCodeActions InlineCode(string connectionId) => new InlineCodeActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public InlineCodeTriggers InlineCode(string connectionId) => new InlineCodeTriggers(connectionId);
    }
}