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
        public IBodyWorkflowAction<GetArrayEmbeddingsOutput> GetArrayEmbeddings([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<JToken[]> input)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = SourceExpressionConverter.ConvertToken(deploymentId);
                serviceProviderParameters["input"] = SourceExpressionConverter.ConvertToken(input);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getArrayEmbeddings", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetArrayEmbeddingsOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetSingleEmbeddingOutput> GetSingleEmbedding([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<string> input)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = SourceExpressionConverter.ConvertToken(deploymentId);
                serviceProviderParameters["input"] = SourceExpressionConverter.ConvertToken(input);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getSingleEmbedding", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetSingleEmbeddingOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsOutput> GetChatCompletions([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<GetChatCompletionsInputMessagesTypeItem[]> messages, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<double> topP = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = SourceExpressionConverter.ConvertToken(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = SourceExpressionConverter.ConvertToken(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["messages"] = SourceExpressionConverter.ConvertToken(messages);
                if (topP != null)
                {
                    serviceProviderParameters["top_p"] = SourceExpressionConverter.ConvertToken(topP);
                }

                if (maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = SourceExpressionConverter.ConvertToken(maxTokens);
                }

                if (presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = SourceExpressionConverter.ConvertToken(presencePenalty);
                }

                if (frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = SourceExpressionConverter.ConvertToken(frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getChatCompletions", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetChatCompletionsOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetChatCompletionsUsingPromptTemplateOutput> GetChatCompletionsUsingPromptTemplate([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<string> promptTemplateInput, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<object> promptTemplateInputVariables = null, [WorkflowExpression] Func<double> topP = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = SourceExpressionConverter.ConvertToken(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = SourceExpressionConverter.ConvertToken(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["promptTemplateInput"] = SourceExpressionConverter.ConvertToken(promptTemplateInput);
                if (promptTemplateInputVariables != null)
                {
                    serviceProviderParameters["promptTemplateInputVariables"] = SourceExpressionConverter.ConvertToken(promptTemplateInputVariables);
                }

                if (topP != null)
                {
                    serviceProviderParameters["top_p"] = SourceExpressionConverter.ConvertToken(topP);
                }

                if (maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = SourceExpressionConverter.ConvertToken(maxTokens);
                }

                if (presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = SourceExpressionConverter.ConvertToken(presencePenalty);
                }

                if (frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = SourceExpressionConverter.ConvertToken(frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getChatCompletionsUsingPromptTemplate", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetChatCompletionsUsingPromptTemplateOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetMultipleChatCompletionsOutput> GetMultipleChatCompletions([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<GetMultipleChatCompletionsInputMessagesTypeItem[]> messages, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<double> topP = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<int> n = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = SourceExpressionConverter.ConvertToken(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = SourceExpressionConverter.ConvertToken(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["messages"] = SourceExpressionConverter.ConvertToken(messages);
                if (topP != null)
                {
                    serviceProviderParameters["top_p"] = SourceExpressionConverter.ConvertToken(topP);
                }

                if (maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = SourceExpressionConverter.ConvertToken(maxTokens);
                }

                if (n != null)
                {
                    serviceProviderParameters["n"] = SourceExpressionConverter.ConvertToken(n);
                }
                else
                {
                    serviceProviderParameters["n"] = 1;
                }

                if (presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = SourceExpressionConverter.ConvertToken(presencePenalty);
                }

                if (frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = SourceExpressionConverter.ConvertToken(frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getMultipleChatCompletions", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetMultipleChatCompletionsOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetCompletionOutput> GetCompletion([WorkflowExpression] Func<string> deploymentId, [WorkflowExpression] Func<string[]> prompts, [WorkflowExpression] Func<double> temperature = null, [WorkflowExpression] Func<string[]> stopSequences = null, [WorkflowExpression] Func<int> maxTokens = null, [WorkflowExpression] Func<double> presencePenalty = null, [WorkflowExpression] Func<double> frequencyPenalty = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["deploymentId"] = SourceExpressionConverter.ConvertToken(deploymentId);
                if (temperature != null)
                {
                    serviceProviderParameters["temperature"] = SourceExpressionConverter.ConvertToken(temperature);
                }
                else
                {
                    serviceProviderParameters["temperature"] = 1;
                }

                serviceProviderParameters["prompts"] = SourceExpressionConverter.ConvertToken(prompts);
                if (stopSequences != null)
                {
                    serviceProviderParameters["stopSequences"] = SourceExpressionConverter.ConvertToken(stopSequences);
                }

                if (maxTokens != null)
                {
                    serviceProviderParameters["max_tokens"] = SourceExpressionConverter.ConvertToken(maxTokens);
                }

                if (presencePenalty != null)
                {
                    serviceProviderParameters["presence_penalty"] = SourceExpressionConverter.ConvertToken(presencePenalty);
                }

                if (frequencyPenalty != null)
                {
                    serviceProviderParameters["frequency_penalty"] = SourceExpressionConverter.ConvertToken(frequencyPenalty);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/openai", operationId: "getCompletion", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetCompletionOutput>(BuildSourceInput);
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai;

    public partial class WorkflowServiceProviderActions
    {
        public OpenaiActions Openai(string connectionId) => new OpenaiActions(connectionId);
    }
}