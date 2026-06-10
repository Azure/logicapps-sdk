//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.AiOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AiOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "aiOperations")]
        public IBodyWorkflowAction<ParsedocumentOutput> Parsedocument(Expression<Func<object>> content)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "parsedocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ParsedocumentOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "aiOperations")]
        public IBodyWorkflowAction<ChunktextOutput> Chunktext(Expression<Func<ChunktextChunkingStrategyType>> chunkingStrategy, Expression<Func<object>> text)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["chunkingStrategy"] = ExpressionConverter.ConvertO(chunkingStrategy);
            serviceProviderParameters["text"] = ExpressionConverter.ConvertO(text);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "chunktext", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ChunktextOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "aiOperations")]
        public IBodyWorkflowAction<ParsedocumentwithmetadataOutput> Parsedocumentwithmetadata(Expression<Func<object>> content, Expression<Func<ParsedocumentwithmetadataFileTypeType>> fileType)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["content"] = ExpressionConverter.ConvertO(content);
            serviceProviderParameters["fileType"] = ExpressionConverter.ConvertO(fileType);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "parsedocumentwithmetadata", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ParsedocumentwithmetadataOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "aiOperations")]
        public IBodyWorkflowAction<ChunktextwithmetadataOutput> Chunktextwithmetadata(Expression<Func<int>> tokenSize, Expression<Func<int>> chunkOverlapLength, Expression<Func<object>> pageText)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tokenSize"] = ExpressionConverter.ConvertO(tokenSize);
            serviceProviderParameters["chunkOverlapLength"] = ExpressionConverter.ConvertO(chunkOverlapLength);
            serviceProviderParameters["pageText"] = ExpressionConverter.ConvertO(pageText);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "chunktextwithmetadata", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ChunktextwithmetadataOutput>(serviceProviderInput);
        }
    }

    public class AiOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ParsedocumentOutput
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ChunktextOutput
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }
    }

    public enum ChunktextChunkingStrategyType
    {
        TokenSize
    }

    public class ParsedocumentwithmetadataOutput
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }
    }

    public enum ParsedocumentwithmetadataFileTypeType
    {
        PDF,
        DOC,
        DOCX,
        XLS,
        XLSX,
        PPT,
        PPTX,
        TXT,
        MD,
        HTML
    }

    public class ChunktextwithmetadataOutput
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AiOperations;

    public partial class WorkflowServiceProviderActions
    {
        public AiOperationsActions AiOperations(string connectionId) => new AiOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public AiOperationsTriggers AiOperations(string connectionId) => new AiOperationsTriggers(connectionId);
    }
}