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

    public class OpenaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        [WorkflowExpressionFactory(nameof(__BuildGetArrayEmbeddings))]
        public IBodyWorkflowAction<GetArrayEmbeddingsOutput> GetArrayEmbeddings([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<JToken[]> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetArrayEmbeddingsOutput> __BuildGetArrayEmbeddings(WorkflowValue<string> deploymentId, WorkflowValue<JToken[]> input)
        {
            WorkflowValue.Validate(deploymentId, nameof(deploymentId), required: true);
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<GetArrayEmbeddingsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
                serviceProviderParameters["input"] = ExpressionConverter.ConvertO(input);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getArrayEmbeddings", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetArrayEmbeddingsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        [WorkflowExpressionFactory(nameof(__BuildGetSingleEmbedding))]
        public IBodyWorkflowAction<GetSingleEmbeddingOutput> GetSingleEmbedding([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<string> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSingleEmbeddingOutput> __BuildGetSingleEmbedding(WorkflowValue<string> deploymentId, WorkflowValue<string> input)
        {
            WorkflowValue.Validate(deploymentId, nameof(deploymentId), required: true);
            WorkflowValue.Validate(input, nameof(input), required: true);
            return new DeferredBodyAction<GetSingleEmbeddingOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
                serviceProviderParameters["input"] = ExpressionConverter.ConvertO(input);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getSingleEmbedding", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetSingleEmbeddingOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        [WorkflowExpressionFactory(nameof(__BuildGetChatCompletions))]
        public IBodyWorkflowAction<GetChatCompletionsOutput> GetChatCompletions([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<GetChatCompletionsInputMessagesTypeItem[]> messages, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<double> topP = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChatCompletionsOutput> __BuildGetChatCompletions(WorkflowValue<string> deploymentId, WorkflowValue<GetChatCompletionsInputMessagesTypeItem[]> messages, WorkflowValue<double> temperature = null, WorkflowValue<double> topP = null, WorkflowValue<int> maxTokens = null, WorkflowValue<double> presencePenalty = null, WorkflowValue<double> frequencyPenalty = null)
        {
            WorkflowValue.Validate(deploymentId, nameof(deploymentId), required: true);
            WorkflowValue.Validate(messages, nameof(messages), required: true);
            WorkflowValue.Validate(temperature, nameof(temperature), required: false);
            WorkflowValue.Validate(topP, nameof(topP), required: false);
            WorkflowValue.Validate(maxTokens, nameof(maxTokens), required: false);
            WorkflowValue.Validate(presencePenalty, nameof(presencePenalty), required: false);
            WorkflowValue.Validate(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetChatCompletionsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getChatCompletions", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetChatCompletionsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        [WorkflowExpressionFactory(nameof(__BuildGetMultipleChatCompletions))]
        public IBodyWorkflowAction<GetMultipleChatCompletionsOutput> GetMultipleChatCompletions([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<GetMultipleChatCompletionsInputMessagesTypeItem[]> messages, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<double> topP = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<int> n = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMultipleChatCompletionsOutput> __BuildGetMultipleChatCompletions(WorkflowValue<string> deploymentId, WorkflowValue<GetMultipleChatCompletionsInputMessagesTypeItem[]> messages, WorkflowValue<double> temperature = null, WorkflowValue<double> topP = null, WorkflowValue<int> maxTokens = null, WorkflowValue<int> n = null, WorkflowValue<double> presencePenalty = null, WorkflowValue<double> frequencyPenalty = null)
        {
            WorkflowValue.Validate(deploymentId, nameof(deploymentId), required: true);
            WorkflowValue.Validate(messages, nameof(messages), required: true);
            WorkflowValue.Validate(temperature, nameof(temperature), required: false);
            WorkflowValue.Validate(topP, nameof(topP), required: false);
            WorkflowValue.Validate(maxTokens, nameof(maxTokens), required: false);
            WorkflowValue.Validate(n, nameof(n), required: false);
            WorkflowValue.Validate(presencePenalty, nameof(presencePenalty), required: false);
            WorkflowValue.Validate(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetMultipleChatCompletionsOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
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
                else
                {
                    serviceProviderParameters["n"] = 1;
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getMultipleChatCompletions", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetMultipleChatCompletionsOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompletion))]
        public IBodyWorkflowAction<GetCompletionOutput> GetCompletion([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<string[]> prompts, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<string[]> stopSequences = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompletionOutput> __BuildGetCompletion(WorkflowValue<string> deploymentId, WorkflowValue<string[]> prompts, WorkflowValue<double> temperature = null, WorkflowValue<string[]> stopSequences = null, WorkflowValue<int> maxTokens = null, WorkflowValue<double> presencePenalty = null, WorkflowValue<double> frequencyPenalty = null)
        {
            WorkflowValue.Validate(deploymentId, nameof(deploymentId), required: true);
            WorkflowValue.Validate(prompts, nameof(prompts), required: true);
            WorkflowValue.Validate(temperature, nameof(temperature), required: false);
            WorkflowValue.Validate(stopSequences, nameof(stopSequences), required: false);
            WorkflowValue.Validate(maxTokens, nameof(maxTokens), required: false);
            WorkflowValue.Validate(presencePenalty, nameof(presencePenalty), required: false);
            WorkflowValue.Validate(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetCompletionOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
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
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getCompletion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetCompletionOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        [WorkflowExpressionFactory(nameof(__BuildGetChatCompletionsUsingPromptTemplate))]
        public IBodyWorkflowAction<GetChatCompletionsUsingPromptTemplateOutput> GetChatCompletionsUsingPromptTemplate([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<string> promptTemplateInput, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<object> promptTemplateInputVariables = null, [WorkflowExpression] Func<double> topP = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetChatCompletionsUsingPromptTemplateOutput> __BuildGetChatCompletionsUsingPromptTemplate(WorkflowValue<string> deploymentId, WorkflowValue<string> promptTemplateInput, WorkflowValue<double> temperature = null, WorkflowValue<object> promptTemplateInputVariables = null, WorkflowValue<double> topP = null, WorkflowValue<int> maxTokens = null, WorkflowValue<double> presencePenalty = null, WorkflowValue<double> frequencyPenalty = null)
        {
            WorkflowValue.Validate(deploymentId, nameof(deploymentId), required: true);
            WorkflowValue.Validate(promptTemplateInput, nameof(promptTemplateInput), required: true);
            WorkflowValue.Validate(temperature, nameof(temperature), required: false);
            WorkflowValue.Validate(promptTemplateInputVariables, nameof(promptTemplateInputVariables), required: false);
            WorkflowValue.Validate(topP, nameof(topP), required: false);
            WorkflowValue.Validate(maxTokens, nameof(maxTokens), required: false);
            WorkflowValue.Validate(presencePenalty, nameof(presencePenalty), required: false);
            WorkflowValue.Validate(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetChatCompletionsUsingPromptTemplateOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = ExpressionConverter.ConvertO(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = ExpressionConverter.ConvertO(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
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
        [System.ComponentModel.DefaultValue(GetMultipleChatCompletionsInputMessagesTypeItemRoleType.User)]
        public GetMultipleChatCompletionsInputMessagesTypeItemRoleType Role { get; set; } = GetMultipleChatCompletionsInputMessagesTypeItemRoleType.User;

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
