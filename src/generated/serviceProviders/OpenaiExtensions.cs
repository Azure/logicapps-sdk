//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Openai
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class OpenaiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "openai")]
        public IBodyWorkflowAction<GetArrayEmbeddingsOutput, GetArrayEmbeddingsActionConfiguration> GetArrayEmbeddings(Expression<Func<string>> deploymentId, Expression<Func<JToken[]>> input)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetArrayEmbeddingsOutput, GetArrayEmbeddingsActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetSingleEmbeddingOutput, GetSingleEmbeddingActionConfiguration> GetSingleEmbedding(Expression<Func<string>> deploymentId, Expression<Func<string>> input)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetSingleEmbeddingOutput, GetSingleEmbeddingActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetChatCompletionsOutput, GetChatCompletionsActionConfiguration> GetChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetChatCompletionsInputMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_messages = WorkflowExpression.Compile(messages, nameof(messages), required: true);
            var __workflow_temperature = WorkflowExpression.Compile(temperature, nameof(temperature), required: false);
            var __workflow_topP = WorkflowExpression.Compile(topP, nameof(topP), required: false);
            var __workflow_maxTokens = WorkflowExpression.Compile(maxTokens, nameof(maxTokens), required: false);
            var __workflow_presencePenalty = WorkflowExpression.Compile(presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = WorkflowExpression.Compile(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetChatCompletionsOutput, GetChatCompletionsActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetMultipleChatCompletionsOutput, GetMultipleChatCompletionsActionConfiguration> GetMultipleChatCompletions(Expression<Func<string>> deploymentId, Expression<Func<GetMultipleChatCompletionsInputMessagesTypeItem[]>> messages, Expression<Func<double>> temperature = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<int>> n = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_messages = WorkflowExpression.Compile(messages, nameof(messages), required: true);
            var __workflow_temperature = WorkflowExpression.Compile(temperature, nameof(temperature), required: false);
            var __workflow_topP = WorkflowExpression.Compile(topP, nameof(topP), required: false);
            var __workflow_maxTokens = WorkflowExpression.Compile(maxTokens, nameof(maxTokens), required: false);
            var __workflow_n = WorkflowExpression.Compile(n, nameof(n), required: false);
            var __workflow_presencePenalty = WorkflowExpression.Compile(presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = WorkflowExpression.Compile(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetMultipleChatCompletionsOutput, GetMultipleChatCompletionsActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetCompletionOutput, GetCompletionActionConfiguration> GetCompletion(Expression<Func<string>> deploymentId, Expression<Func<string[]>> prompts, Expression<Func<double>> temperature = null, Expression<Func<string[]>> stopSequences = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_prompts = WorkflowExpression.Compile(prompts, nameof(prompts), required: true);
            var __workflow_temperature = WorkflowExpression.Compile(temperature, nameof(temperature), required: false);
            var __workflow_stopSequences = WorkflowExpression.Compile(stopSequences, nameof(stopSequences), required: false);
            var __workflow_maxTokens = WorkflowExpression.Compile(maxTokens, nameof(maxTokens), required: false);
            var __workflow_presencePenalty = WorkflowExpression.Compile(presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = WorkflowExpression.Compile(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetCompletionOutput, GetCompletionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetChatCompletionsUsingPromptTemplateOutput, GetChatCompletionsUsingPromptTemplateActionConfiguration> GetChatCompletionsUsingPromptTemplate(Expression<Func<string>> deploymentId, Expression<Func<string>> promptTemplateInput, Expression<Func<double>> temperature = null, Expression<Func<object>> promptTemplateInputVariables = null, Expression<Func<double>> topP = null, Expression<Func<int>> maxTokens = null, Expression<Func<double>> presencePenalty = null, Expression<Func<double>> frequencyPenalty = null)
        {
            var __workflow_deploymentId = WorkflowExpression.Compile(deploymentId, nameof(deploymentId), required: true);
            var __workflow_promptTemplateInput = WorkflowExpression.Compile(promptTemplateInput, nameof(promptTemplateInput), required: true);
            var __workflow_temperature = WorkflowExpression.Compile(temperature, nameof(temperature), required: false);
            var __workflow_promptTemplateInputVariables = WorkflowExpression.Compile(promptTemplateInputVariables, nameof(promptTemplateInputVariables), required: false);
            var __workflow_topP = WorkflowExpression.Compile(topP, nameof(topP), required: false);
            var __workflow_maxTokens = WorkflowExpression.Compile(maxTokens, nameof(maxTokens), required: false);
            var __workflow_presencePenalty = WorkflowExpression.Compile(presencePenalty, nameof(presencePenalty), required: false);
            var __workflow_frequencyPenalty = WorkflowExpression.Compile(frequencyPenalty, nameof(frequencyPenalty), required: false);
            return new DeferredBodyAction<GetChatCompletionsUsingPromptTemplateOutput, GetChatCompletionsUsingPromptTemplateActionConfiguration>(() =>
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

    public sealed class GetArrayEmbeddingsActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetSingleEmbeddingActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetChatCompletionsActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetMultipleChatCompletionsActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetCompletionActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetChatCompletionsUsingPromptTemplateActionConfiguration : IWorkflowOperationConfiguration, IRetryPolicyConfigurationHolder, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
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