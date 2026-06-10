//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DataMapperOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataMapperOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "dataMapperOperations")]
        public IBodyWorkflowAction<JToken> XsltTransform(Expression<Func<object>> content, Expression<Func<XsltTransformMapType>> map, Expression<Func<object>> transformedContentSchema = null)
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
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/dataMapperOperations", operationId: "xsltTransform", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }
    }

    public class DataMapperOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class XsltTransformMapType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("source")]
        public XsltTransformMapTypeSourceType Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum XsltTransformMapTypeSourceType
    {
        LogicApp
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.DataMapperOperations;

    public partial class WorkflowServiceProviderActions
    {
        public DataMapperOperationsActions DataMapperOperations(string connectionId) => new DataMapperOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public DataMapperOperationsTriggers DataMapperOperations(string connectionId) => new DataMapperOperationsTriggers(connectionId);
    }
}