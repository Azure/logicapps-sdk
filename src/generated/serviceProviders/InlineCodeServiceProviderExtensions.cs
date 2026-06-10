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
            var parameters = new JObject();
            parameters["code"] = ExpressionConverter.ConvertO(code);
            if (explicitDependencies != null)
            {
                parameters["explicitDependencies"] = ExpressionConverter.ConvertO(explicitDependencies);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/inlineCode", operationId: "javaScriptCode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "inlineCode")]
        public IOutputWorkflowAction<JToken> CSharpScriptCode(Expression<Func<object>> codeFile)
        {
            var parameters = new JObject();
            parameters["CodeFile"] = ExpressionConverter.ConvertO(codeFile);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/inlineCode", operationId: "cSharpScriptCode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "inlineCode")]
        public IOutputWorkflowAction<JToken> PowershellCode(Expression<Func<object>> codeFile)
        {
            var parameters = new JObject();
            parameters["CodeFile"] = ExpressionConverter.ConvertO(codeFile);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/inlineCode", operationId: "powershellCode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<JToken>(input);
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