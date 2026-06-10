//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.LiquidOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LiquidOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "liquidOperations")]
        public IBodyWorkflowAction<JToken> LiquidJsonToJson(Expression<Func<object>> content, Expression<Func<LiquidJsonToJsonMapType>> map, Expression<Func<object>> transformedContentSchema = null)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["map"] = ExpressionConverter.ConvertO(map);
            if (transformedContentSchema != null)
            {
                parameters["transformedContentSchema"] = ExpressionConverter.ConvertO(transformedContentSchema);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/liquidOperations", operationId: "liquidJsonToJson", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "liquidOperations")]
        public IBodyWorkflowAction<JToken> LiquidJsonToText(Expression<Func<object>> content, Expression<Func<LiquidJsonToTextMapType>> map, Expression<Func<object>> transformedContentSchema = null)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["map"] = ExpressionConverter.ConvertO(map);
            if (transformedContentSchema != null)
            {
                parameters["transformedContentSchema"] = ExpressionConverter.ConvertO(transformedContentSchema);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/liquidOperations", operationId: "liquidJsonToText", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "liquidOperations")]
        public IBodyWorkflowAction<JToken> LiquidXmlToJson(Expression<Func<object>> content, Expression<Func<LiquidXmlToJsonMapType>> map, Expression<Func<object>> transformedContentSchema = null)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["map"] = ExpressionConverter.ConvertO(map);
            if (transformedContentSchema != null)
            {
                parameters["transformedContentSchema"] = ExpressionConverter.ConvertO(transformedContentSchema);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/liquidOperations", operationId: "liquidXmlToJson", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "liquidOperations")]
        public IBodyWorkflowAction<JToken> LiquidXmlToText(Expression<Func<object>> content, Expression<Func<LiquidXmlToTextMapType>> map, Expression<Func<object>> transformedContentSchema = null)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["map"] = ExpressionConverter.ConvertO(map);
            if (transformedContentSchema != null)
            {
                parameters["transformedContentSchema"] = ExpressionConverter.ConvertO(transformedContentSchema);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/liquidOperations", operationId: "liquidXmlToText", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }
    }

    public class LiquidOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class LiquidJsonToJsonMapType
    {
        [JsonProperty("source")]
        public LiquidJsonToJsonMapTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum LiquidJsonToJsonMapTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class LiquidJsonToTextMapType
    {
        [JsonProperty("source")]
        public LiquidJsonToTextMapTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum LiquidJsonToTextMapTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class LiquidXmlToJsonMapType
    {
        [JsonProperty("source")]
        public LiquidXmlToJsonMapTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum LiquidXmlToJsonMapTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }

    public class LiquidXmlToTextMapType
    {
        [JsonProperty("source")]
        public LiquidXmlToTextMapTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum LiquidXmlToTextMapTypeSourceType
    {
        IntegrationAccount,
        LogicApp
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.LiquidOperations;

    public partial class WorkflowServiceProviderActions
    {
        public LiquidOperationsActions LiquidOperations(string connectionId) => new LiquidOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public LiquidOperationsTriggers LiquidOperations(string connectionId) => new LiquidOperationsTriggers(connectionId);
    }
}