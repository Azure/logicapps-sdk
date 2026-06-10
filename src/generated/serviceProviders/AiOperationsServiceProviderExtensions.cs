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
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "parsedocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ParsedocumentOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "aiOperations")]
        public IBodyWorkflowAction<ChunktextOutput> Chunktext(Expression<Func<ChunktextChunkingStrategyType>> chunkingStrategy, Expression<Func<object>> text)
        {
            var parameters = new JObject();
            parameters["chunkingStrategy"] = ExpressionConverter.ConvertO(chunkingStrategy);
            parameters["text"] = ExpressionConverter.ConvertO(text);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "chunktext", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ChunktextOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "aiOperations")]
        public IBodyWorkflowAction<ParsedocumentwithmetadataOutput> Parsedocumentwithmetadata(Expression<Func<object>> content, Expression<Func<ParsedocumentwithmetadataFileTypeType>> fileType)
        {
            var parameters = new JObject();
            parameters["content"] = ExpressionConverter.ConvertO(content);
            parameters["fileType"] = ExpressionConverter.ConvertO(fileType);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "parsedocumentwithmetadata", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ParsedocumentwithmetadataOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "aiOperations")]
        public IBodyWorkflowAction<ChunktextwithmetadataOutput> Chunktextwithmetadata(Expression<Func<int>> tokenSize, Expression<Func<int>> chunkOverlapLength, Expression<Func<object>> pageText)
        {
            var parameters = new JObject();
            parameters["tokenSize"] = ExpressionConverter.ConvertO(tokenSize);
            parameters["chunkOverlapLength"] = ExpressionConverter.ConvertO(chunkOverlapLength);
            parameters["pageText"] = ExpressionConverter.ConvertO(pageText);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/aiOperations", operationId: "chunktextwithmetadata", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ChunktextwithmetadataOutput>(input);
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