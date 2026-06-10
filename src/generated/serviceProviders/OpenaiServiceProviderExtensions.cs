//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetArrayEmbeddingsOutput> GetArrayEmbeddings(Expression<Func<string>> deploymentId, Expression<Func<string[]>> input)
        {
            var parameters = new JObject();
            parameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            parameters["input"] = ExpressionConverter.ConvertO(input);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getArrayEmbeddings", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetArrayEmbeddingsOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetSingleEmbeddingOutput> GetSingleEmbedding(Expression<Func<string>> deploymentId, Expression<Func<string>> input)
        {
            var parameters = new JObject();
            parameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            parameters["input"] = ExpressionConverter.ConvertO(input);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getSingleEmbedding", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetSingleEmbeddingOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsOutput> GetChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetChatCompletionsMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var parameters = new JObject();
            parameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                parameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            parameters["messages"] = ExpressionConverter.ConvertO(messages);
            if (topP != null)
            {
                parameters["top_p"] = ExpressionConverter.ConvertO(topP);
            }

            if (maxTokens != null)
            {
                parameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (presencePenalty != null)
            {
                parameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                parameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getChatCompletions", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetChatCompletionsOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetMultipleChatCompletionsOutput> GetMultipleChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetMultipleChatCompletionsMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<int>> n = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var parameters = new JObject();
            parameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                parameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            parameters["messages"] = ExpressionConverter.ConvertO(messages);
            if (topP != null)
            {
                parameters["top_p"] = ExpressionConverter.ConvertO(topP);
            }

            if (maxTokens != null)
            {
                parameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (n != null)
            {
                parameters["n"] = ExpressionConverter.ConvertO(n);
            }

            if (presencePenalty != null)
            {
                parameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                parameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getMultipleChatCompletions", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetMultipleChatCompletionsOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetCompletionOutput> GetCompletion(Expression<Func<string>> deploymentId, Expression<Func<string[]>> prompts, Expression<Func<double>> temperature = null, Expression<Func<string[]>> stopSequences = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var parameters = new JObject();
            parameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                parameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            parameters["prompts"] = ExpressionConverter.ConvertO(prompts);
            if (stopSequences != null)
            {
                parameters["stopSequences"] = ExpressionConverter.ConvertO(stopSequences);
            }

            if (maxTokens != null)
            {
                parameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (presencePenalty != null)
            {
                parameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                parameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getCompletion", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetCompletionOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsUsingPromptTemplateOutput> GetChatCompletionsUsingPromptTemplate(Expression<Func<string>> deploymentId, Expression<Func<string>> promptTemplateInput, Expression<Func<double>> temperature = null, Expression<Func<object>> promptTemplateInputVariables = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var parameters = new JObject();
            parameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                parameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            parameters["promptTemplateInput"] = ExpressionConverter.ConvertO(promptTemplateInput);
            if (promptTemplateInputVariables != null)
            {
                parameters["promptTemplateInputVariables"] = ExpressionConverter.ConvertO(promptTemplateInputVariables);
            }

            if (topP != null)
            {
                parameters["top_p"] = ExpressionConverter.ConvertO(topP);
            }

            if (maxTokens != null)
            {
                parameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (presencePenalty != null)
            {
                parameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                parameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getChatCompletionsUsingPromptTemplate", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<GetChatCompletionsUsingPromptTemplateOutput>(input);
        }
    }

    public class OpenaiTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetArrayEmbeddingsOutput
    {
        [JsonProperty("embeddings")]
        public double[][] Embeddings { get; set; }

        [JsonProperty("usage")]
        public GetArrayEmbeddingsOutputUsageType Usage { get; set; }
    }

    public class GetArrayEmbeddingsOutputUsageType
    {
        [JsonProperty("promptTokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }
    }

    public class GetSingleEmbeddingOutput
    {
        [JsonProperty("embedding")]
        public double[] Embedding { get; set; }

        [JsonProperty("usage")]
        public GetSingleEmbeddingOutputUsageType Usage { get; set; }
    }

    public class GetSingleEmbeddingOutputUsageType
    {
        [JsonProperty("promptTokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }
    }

    public class GetChatCompletionsOutput
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("usage")]
        public GetChatCompletionsOutputUsageType Usage { get; set; }
    }

    public class GetChatCompletionsOutputUsageType
    {
        [JsonProperty("promptTokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }

        [JsonProperty("completionTokens")]
        public int CompletionTokens { get; set; }
    }

    public class GetChatCompletionsMessagesTypeItem
    {
        [JsonProperty("role")]
        public GetChatCompletionsMessagesTypeItemRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public enum GetChatCompletionsMessagesTypeItemRoleType
    {
        User,
        System,
        Assistant
    }

    public class GetMultipleChatCompletionsOutput
    {
        [JsonProperty("choices")]
        public GetMultipleChatCompletionsOutputChoicesTypeItem[] Choices { get; set; }

        [JsonProperty("usage")]
        public GetMultipleChatCompletionsOutputUsageType Usage { get; set; }
    }

    public class GetMultipleChatCompletionsOutputChoicesTypeItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetMultipleChatCompletionsOutputUsageType
    {
        [JsonProperty("promptTokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }

        [JsonProperty("completionTokens")]
        public int CompletionTokens { get; set; }
    }

    public class GetMultipleChatCompletionsMessagesTypeItem
    {
        [JsonProperty("role")]
        public GetMultipleChatCompletionsMessagesTypeItemRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public enum GetMultipleChatCompletionsMessagesTypeItemRoleType
    {
        User,
        System,
        Assistant
    }

    public class GetCompletionOutput
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("usage")]
        public GetCompletionOutputUsageType Usage { get; set; }
    }

    public class GetCompletionOutputUsageType
    {
        [JsonProperty("promptTokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }

        [JsonProperty("completionTokens")]
        public int CompletionTokens { get; set; }
    }

    public class GetChatCompletionsUsingPromptTemplateOutput
    {
        [JsonProperty("request")]
        public GetChatCompletionsUsingPromptTemplateOutputRequestTypeItem[] Request { get; set; }

        [JsonProperty("response")]
        public GetChatCompletionsUsingPromptTemplateOutputResponseType Response { get; set; }

        [JsonProperty("usage")]
        public GetChatCompletionsUsingPromptTemplateOutputUsageType Usage { get; set; }
    }

    public class GetChatCompletionsUsingPromptTemplateOutputRequestTypeItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GetChatCompletionsUsingPromptTemplateOutputResponseType
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GetChatCompletionsUsingPromptTemplateOutputUsageType
    {
        [JsonProperty("promptTokens")]
        public int PromptTokens { get; set; }

        [JsonProperty("totalTokens")]
        public int TotalTokens { get; set; }

        [JsonProperty("completionTokens")]
        public int CompletionTokens { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai;

    public partial class WorkflowServiceProviderActions
    {
        public OpenaiActions Openai(string connectionId) => new OpenaiActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public OpenaiTriggers Openai(string connectionId) => new OpenaiTriggers(connectionId);
    }
}