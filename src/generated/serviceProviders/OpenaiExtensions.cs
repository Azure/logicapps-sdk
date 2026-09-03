//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class OpenaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetArrayEmbeddingsOutput> GetArrayEmbeddings(Expression<Func<string>> deploymentId, Expression<Func<string[]>> input)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            serviceProviderParameters["input"] = ExpressionConverter.ConvertO(input);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/openai", "getArrayEmbeddings", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetArrayEmbeddingsOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetSingleEmbeddingOutput> GetSingleEmbedding(Expression<Func<string>> deploymentId, Expression<Func<string>> input)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            serviceProviderParameters["input"] = ExpressionConverter.ConvertO(input);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/openai", "getSingleEmbedding", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetSingleEmbeddingOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsOutput> GetChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetChatCompletionsInputMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            serviceProviderParameters["messages"] = ExpressionConverter.ConvertO(messages);
            if (topP != null)
            {
                serviceProviderParameters["top_p"] = ExpressionConverter.ConvertO(topP);
            }

            if (maxTokens != null)
            {
                serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (presencePenalty != null)
            {
                serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/openai", "getChatCompletions", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetChatCompletionsOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetMultipleChatCompletionsOutput> GetMultipleChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetMultipleChatCompletionsInputMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<int>> n = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            serviceProviderParameters["messages"] = ExpressionConverter.ConvertO(messages);
            if (topP != null)
            {
                serviceProviderParameters["top_p"] = ExpressionConverter.ConvertO(topP);
            }

            if (maxTokens != null)
            {
                serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (n != null)
            {
                serviceProviderParameters["n"] = ExpressionConverter.ConvertO(n);
            }

            if (presencePenalty != null)
            {
                serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/openai", "getMultipleChatCompletions", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetMultipleChatCompletionsOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetCompletionOutput> GetCompletion(Expression<Func<string>> deploymentId, Expression<Func<string[]>> prompts, Expression<Func<double>> temperature = null, Expression<Func<string[]>> stopSequences = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            serviceProviderParameters["prompts"] = ExpressionConverter.ConvertO(prompts);
            if (stopSequences != null)
            {
                serviceProviderParameters["stopSequences"] = ExpressionConverter.ConvertO(stopSequences);
            }

            if (maxTokens != null)
            {
                serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (presencePenalty != null)
            {
                serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/openai", "getCompletion", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetCompletionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsUsingPromptTemplateOutput> GetChatCompletionsUsingPromptTemplate(Expression<Func<string>> deploymentId, Expression<Func<string>> promptTemplateInput, Expression<Func<double>> temperature = null, Expression<Func<object>> promptTemplateInputVariables = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
            if (temperature != null)
            {
                serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
            }

            serviceProviderParameters["promptTemplateInput"] = ExpressionConverter.ConvertO(promptTemplateInput);
            if (promptTemplateInputVariables != null)
            {
                serviceProviderParameters["promptTemplateInputVariables"] = ExpressionConverter.ConvertO(promptTemplateInputVariables);
            }

            if (topP != null)
            {
                serviceProviderParameters["top_p"] = ExpressionConverter.ConvertO(topP);
            }

            if (maxTokens != null)
            {
                serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(maxTokens);
            }

            if (presencePenalty != null)
            {
                serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(presencePenalty);
            }

            if (frequencyPenalty != null)
            {
                serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(frequencyPenalty);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration("/serviceProviders/openai", "getChatCompletionsUsingPromptTemplate", connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetChatCompletionsUsingPromptTemplateOutput>(serviceProviderInput);
        }
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

    public class GetChatCompletionsInputMessagesTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetChatCompletionsInputMessagesTypeItemRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetChatCompletionsInputMessagesTypeItemRoleType
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

    public class GetMultipleChatCompletionsInputMessagesTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetMultipleChatCompletionsInputMessagesTypeItemRoleType Role { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetMultipleChatCompletionsInputMessagesTypeItemRoleType
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
}