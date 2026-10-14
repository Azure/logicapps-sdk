//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OpenaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetArrayEmbeddingsOutput> GetArrayEmbeddings(Expression<Func<string>> deploymentId, Expression<Func<JToken[]>> input)
        {
            var __workflow_deploymentId = deploymentId == null ? null : WorkflowExpression.Compile(deploymentId);
            WorkflowExpression.Validate(__workflow_deploymentId, nameof(deploymentId), required: true);
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<GetArrayEmbeddingsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(__workflow_deploymentId);
                serviceProviderParameters["input"] = ExpressionConverter.ConvertO(__workflow_input);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getArrayEmbeddings", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetArrayEmbeddingsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetSingleEmbeddingOutput> GetSingleEmbedding(Expression<Func<string>> deploymentId, Expression<Func<string>> input)
        {
            var __workflow_deploymentId = deploymentId == null ? null : WorkflowExpression.Compile(deploymentId);
            WorkflowExpression.Validate(__workflow_deploymentId, nameof(deploymentId), required: true);
            var __workflow_input = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(__workflow_input, nameof(input), required: true);
            return new DeferredBodyAction<GetSingleEmbeddingOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(__workflow_deploymentId);
                serviceProviderParameters["input"] = ExpressionConverter.ConvertO(__workflow_input);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getSingleEmbedding", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSingleEmbeddingOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsOutput> GetChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetChatCompletionsInputMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = deploymentId == null ? null : WorkflowExpression.Compile(deploymentId);
            WorkflowExpression.Validate(__workflow_deploymentId, nameof(deploymentId), required: true);
            var __workflow_messages = messages == null ? null : WorkflowExpression.Compile(messages);
            WorkflowExpression.Validate(__workflow_messages, nameof(messages), required: true);
            var __workflow_temperature = temperature == null ? null : WorkflowExpression.Compile(temperature);
            WorkflowExpression.Validate(__workflow_temperature, nameof(temperature), required: false);
            var __workflow_topP = topP == null ? null : WorkflowExpression.Compile(topP);
            WorkflowExpression.Validate(__workflow_topP, nameof(topP), required: false);
            var __workflow_maxTokens = maxTokens == null ? null : WorkflowExpression.Compile(maxTokens);
            WorkflowExpression.Validate(__workflow_maxTokens, nameof(maxTokens), required: false);
            var __workflow_presencePenalty = presencePenalty == null ? null : WorkflowExpression.Compile(presencePenalty);
            WorkflowExpression.Validate(__workflow_presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = frequencyPenalty == null ? null : WorkflowExpression.Compile(frequencyPenalty);
            WorkflowExpression.Validate(__workflow_frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetChatCompletionsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(__workflow_deploymentId);
                if (__workflow_temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(__workflow_temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["messages"] = ExpressionConverter.ConvertO(__workflow_messages);
                if (__workflow_topP != null)
                {
                    serviceProviderParameters["top_p"] = ExpressionConverter.ConvertO(__workflow_topP);
                }

                if (__workflow_maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(__workflow_maxTokens);
                }

                if (__workflow_presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(__workflow_presencePenalty);
                }

                if (__workflow_frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(__workflow_frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getChatCompletions", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetChatCompletionsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetMultipleChatCompletionsOutput> GetMultipleChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetMultipleChatCompletionsInputMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<int>> n = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = deploymentId == null ? null : WorkflowExpression.Compile(deploymentId);
            WorkflowExpression.Validate(__workflow_deploymentId, nameof(deploymentId), required: true);
            var __workflow_messages = messages == null ? null : WorkflowExpression.Compile(messages);
            WorkflowExpression.Validate(__workflow_messages, nameof(messages), required: true);
            var __workflow_temperature = temperature == null ? null : WorkflowExpression.Compile(temperature);
            WorkflowExpression.Validate(__workflow_temperature, nameof(temperature), required: false);
            var __workflow_topP = topP == null ? null : WorkflowExpression.Compile(topP);
            WorkflowExpression.Validate(__workflow_topP, nameof(topP), required: false);
            var __workflow_maxTokens = maxTokens == null ? null : WorkflowExpression.Compile(maxTokens);
            WorkflowExpression.Validate(__workflow_maxTokens, nameof(maxTokens), required: false);
            var __workflow_n = n == null ? null : WorkflowExpression.Compile(n);
            WorkflowExpression.Validate(__workflow_n, nameof(n), required: false);
            var __workflow_presencePenalty = presencePenalty == null ? null : WorkflowExpression.Compile(presencePenalty);
            WorkflowExpression.Validate(__workflow_presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = frequencyPenalty == null ? null : WorkflowExpression.Compile(frequencyPenalty);
            WorkflowExpression.Validate(__workflow_frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetMultipleChatCompletionsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(__workflow_deploymentId);
                if (__workflow_temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(__workflow_temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["messages"] = ExpressionConverter.ConvertO(__workflow_messages);
                if (__workflow_topP != null)
                {
                    serviceProviderParameters["top_p"] = ExpressionConverter.ConvertO(__workflow_topP);
                }

                if (__workflow_maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(__workflow_maxTokens);
                }

                if (__workflow_n != null)
                {
                    serviceProviderParameters["n"] = ExpressionConverter.ConvertO(__workflow_n);
                }
                else
                {
                    serviceProviderParameters["n"] = 1;
                }

                if (__workflow_presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(__workflow_presencePenalty);
                }

                if (__workflow_frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(__workflow_frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getMultipleChatCompletions", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetMultipleChatCompletionsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetCompletionOutput> GetCompletion(Expression<Func<string>> deploymentId, Expression<Func<string[]>> prompts, Expression<Func<double>> temperature = null, Expression<Func<string[]>> stopSequences = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = deploymentId == null ? null : WorkflowExpression.Compile(deploymentId);
            WorkflowExpression.Validate(__workflow_deploymentId, nameof(deploymentId), required: true);
            var __workflow_prompts = prompts == null ? null : WorkflowExpression.Compile(prompts);
            WorkflowExpression.Validate(__workflow_prompts, nameof(prompts), required: true);
            var __workflow_temperature = temperature == null ? null : WorkflowExpression.Compile(temperature);
            WorkflowExpression.Validate(__workflow_temperature, nameof(temperature), required: false);
            var __workflow_stopSequences = stopSequences == null ? null : WorkflowExpression.Compile(stopSequences);
            WorkflowExpression.Validate(__workflow_stopSequences, nameof(stopSequences), required: false);
            var __workflow_maxTokens = maxTokens == null ? null : WorkflowExpression.Compile(maxTokens);
            WorkflowExpression.Validate(__workflow_maxTokens, nameof(maxTokens), required: false);
            var __workflow_presencePenalty = presencePenalty == null ? null : WorkflowExpression.Compile(presencePenalty);
            WorkflowExpression.Validate(__workflow_presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = frequencyPenalty == null ? null : WorkflowExpression.Compile(frequencyPenalty);
            WorkflowExpression.Validate(__workflow_frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetCompletionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(__workflow_deploymentId);
                if (__workflow_temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(__workflow_temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["prompts"] = ExpressionConverter.ConvertO(__workflow_prompts);
                if (__workflow_stopSequences != null)
                {
                    serviceProviderParameters["stopSequences"] = ExpressionConverter.ConvertO(__workflow_stopSequences);
                }

                if (__workflow_maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(__workflow_maxTokens);
                }

                if (__workflow_presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(__workflow_presencePenalty);
                }

                if (__workflow_frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(__workflow_frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getCompletion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetCompletionOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsUsingPromptTemplateOutput> GetChatCompletionsUsingPromptTemplate(Expression<Func<string>> deploymentId, Expression<Func<string>> promptTemplateInput, Expression<Func<double>> temperature = null, Expression<Func<object>> promptTemplateInputVariables = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = deploymentId == null ? null : WorkflowExpression.Compile(deploymentId);
            WorkflowExpression.Validate(__workflow_deploymentId, nameof(deploymentId), required: true);
            var __workflow_promptTemplateInput = promptTemplateInput == null ? null : WorkflowExpression.Compile(promptTemplateInput);
            WorkflowExpression.Validate(__workflow_promptTemplateInput, nameof(promptTemplateInput), required: true);
            var __workflow_temperature = temperature == null ? null : WorkflowExpression.Compile(temperature);
            WorkflowExpression.Validate(__workflow_temperature, nameof(temperature), required: false);
            var __workflow_promptTemplateInputVariables = promptTemplateInputVariables == null ? null : WorkflowExpression.Compile(promptTemplateInputVariables);
            WorkflowExpression.Validate(__workflow_promptTemplateInputVariables, nameof(promptTemplateInputVariables), required: false);
            var __workflow_topP = topP == null ? null : WorkflowExpression.Compile(topP);
            WorkflowExpression.Validate(__workflow_topP, nameof(topP), required: false);
            var __workflow_maxTokens = maxTokens == null ? null : WorkflowExpression.Compile(maxTokens);
            WorkflowExpression.Validate(__workflow_maxTokens, nameof(maxTokens), required: false);
            var __workflow_presencePenalty = presencePenalty == null ? null : WorkflowExpression.Compile(presencePenalty);
            WorkflowExpression.Validate(__workflow_presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = frequencyPenalty == null ? null : WorkflowExpression.Compile(frequencyPenalty);
            WorkflowExpression.Validate(__workflow_frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetChatCompletionsUsingPromptTemplateOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(__workflow_deploymentId);
                if (__workflow_temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(__workflow_temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["promptTemplateInput"] = ExpressionConverter.ConvertO(__workflow_promptTemplateInput);
                if (__workflow_promptTemplateInputVariables != null)
                {
                    serviceProviderParameters["promptTemplateInputVariables"] = ExpressionConverter.ConvertO(__workflow_promptTemplateInputVariables);
                }

                if (__workflow_topP != null)
                {
                    serviceProviderParameters["top_p"] = ExpressionConverter.ConvertO(__workflow_topP);
                }

                if (__workflow_maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = ExpressionConverter.ConvertO(__workflow_maxTokens);
                }

                if (__workflow_presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = ExpressionConverter.ConvertO(__workflow_presencePenalty);
                }

                if (__workflow_frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = ExpressionConverter.ConvertO(__workflow_frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getChatCompletionsUsingPromptTemplate", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetChatCompletionsUsingPromptTemplateOutput>(serviceProviderInput);
            });
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
        [System.ComponentModel.DefaultValue(GetChatCompletionsInputMessagesTypeItemRoleType.User)]
        public GetChatCompletionsInputMessagesTypeItemRoleType Role { get; set; } = GetChatCompletionsInputMessagesTypeItemRoleType.User;

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        [System.ComponentModel.DefaultValue(GetMultipleChatCompletionsInputMessagesTypeItemRoleType.User)]
        public GetMultipleChatCompletionsInputMessagesTypeItemRoleType Role { get; set; } = GetMultipleChatCompletionsInputMessagesTypeItemRoleType.User;

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
