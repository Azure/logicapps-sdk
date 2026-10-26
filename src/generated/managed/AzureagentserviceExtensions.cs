//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureagentserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListAgentsResponse, ApiConnectionActionConfiguration> ListAgents(Expression<Func<apiVersionInput>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListAgentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListAgentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListAgentsServiceResponse, ApiConnectionActionConfiguration> ListAgentsFromService()
        {
            return new DeferredBodyAction<ListAgentsServiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/agents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListAgentsServiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateThreadResponse, ApiConnectionActionConfiguration> CreateThread(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<CreateThreadInput>> requestBody)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<CreateThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<CreateThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateRunResponse, ApiConnectionActionConfiguration> CreateRun(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<string>> threadId, Expression<Func<CreateRunInput>> requestBody)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<CreateRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<CreateRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<GetRunResponse, ApiConnectionActionConfiguration> GetRun(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            return new DeferredBodyAction<GetRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<GetRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListMessageResponse, ApiConnectionActionConfiguration> ListMessages(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<string>> threadId)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ListMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/messages", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<OpenAIResponse, ApiConnectionActionConfiguration> InvokeAgent(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<InvokeAgentInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OpenAIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/openai/responses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OpenAIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendActivityApplication(Expression<Func<string>> myApplication, Expression<Func<object>> activity = null)
        {
            var __workflow_myApplication = WorkflowExpression.Compile(myApplication, nameof(myApplication), required: true);
            var __workflow_activity = WorkflowExpression.Compile(activity, nameof(activity), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/protocols/activityprotocol", __workflow_myApplication.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                if (__workflow_activity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_activity);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendActivity(Expression<Func<string>> agentId, Expression<Func<object>> activity = null)
        {
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_activity = WorkflowExpression.Compile(activity, nameof(activity), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/protocols/activityprotocol", __workflow_agentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                if (__workflow_activity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_activity);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class AzureagentserviceTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListAgentsResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public Data[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public Tools[] Tools { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("top_p")]
        public double TopP { get; set; }

        [JsonProperty("response_format")]
        public JToken ResponseFormat { get; set; }

        [JsonProperty("tool_resources")]
        public JToken ToolResources { get; set; }
    }

    public class Tools
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum apiVersionInput
    {
        [EnumMember(Value = "2025-11-15-preview")]
        _20251115Preview
    }

    public class ListAgentsServiceResponse
    {
        [JsonProperty("data")]
        public AgentServiceData[] Data { get; set; }
    }

    public class AgentServiceData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class CreateThreadResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateThreadInput
    {
        [JsonProperty("messages")]
        public Messages[] Messages { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("tool_resources")]
        public JToken ToolResources { get; set; }
    }

    public class Messages
    {
        [JsonProperty("role")]
        public MessagesRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("attachments")]
        public MessagesAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessagesRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class MessagesAttachmentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRunResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("required_action")]
        public JToken RequiredAction { get; set; }

        [JsonProperty("last_error")]
        public JToken LastError { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("cancelled_at")]
        public int CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public int FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public Tools[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public FileIds[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("max_prompt_tokens")]
        public double MaxPromptTokens { get; set; }

        [JsonProperty("max_completion_tokens")]
        public double MaxCompletionTokens { get; set; }

        [JsonProperty("usage")]
        public JToken Usage { get; set; }

        [JsonProperty("truncation_strategy")]
        public JToken TruncationStrategy { get; set; }

        [JsonProperty("response_format")]
        public string ResponseFormat { get; set; }
    }

    public class FileIds
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRunInput
    {
        [JsonProperty("assistant_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AssistantId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("additional_instructions")]
        public string AdditionalInstructions { get; set; }

        [JsonProperty("additional_messages")]
        public Messages[] AdditionalMessages { get; set; }

        [JsonProperty("tools")]
        public Tools[] Tools { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Temperature { get; set; } = 1;

        [JsonProperty("top_p", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TopP { get; set; } = 1;

        [JsonProperty("stream")]
        public bool? Stream { get; set; }

        [JsonProperty("max_prompt_tokens")]
        public int? MaxPromptTokens { get; set; }

        [JsonProperty("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        [JsonProperty("truncation_strategy")]
        public JToken TruncationStrategy { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("response_format")]
        public JToken ResponseFormat { get; set; }
    }

    public class GetRunResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("required_action")]
        public JToken RequiredAction { get; set; }

        [JsonProperty("last_error")]
        public JToken LastError { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("cancelled_at")]
        public int CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public int FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public Tools[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public FileIds[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("max_prompt_tokens")]
        public double MaxPromptTokens { get; set; }

        [JsonProperty("max_completion_tokens")]
        public double MaxCompletionTokens { get; set; }

        [JsonProperty("usage")]
        public JToken Usage { get; set; }

        [JsonProperty("truncation_strategy")]
        public JToken TruncationStrategy { get; set; }

        [JsonProperty("response_format")]
        public string ResponseFormat { get; set; }
    }

    public class ListMessageResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public Data[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class OpenAIResponse
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("top_p")]
        public double TopP { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("service_tier")]
        public OpenAIServiceTier ServiceTier { get; set; }

        [JsonProperty("top_logprobs")]
        public int TopLogprobs { get; set; }

        [JsonProperty("previous_response_id")]
        public string PreviousResponseId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("reasoning")]
        public OpenAIReasoning Reasoning { get; set; }

        [JsonProperty("background")]
        public bool Background { get; set; }

        [JsonProperty("max_output_tokens")]
        public int MaxOutputTokens { get; set; }

        [JsonProperty("max_tool_calls")]
        public int MaxToolCalls { get; set; }

        [JsonProperty("text")]
        public OpenAIResponseTextType Text { get; set; }

        [JsonProperty("tools")]
        public OpenAITool[] Tools { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("prompt")]
        public OpenAIPrompt Prompt { get; set; }

        [JsonProperty("truncation")]
        public OpenAIResponseTruncationType Truncation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public OpenAIResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("status")]
        public OpenAIResponseStatusType Status { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("error")]
        public OpenAIResponseError Error { get; set; }

        [JsonProperty("incomplete_details")]
        public OpenAIResponseIncompleteDetailsType IncompleteDetails { get; set; }

        [JsonProperty("output")]
        public OpenAIItemResource[] Output { get; set; }

        [JsonProperty("instructions")]
        public JToken Instructions { get; set; }

        [JsonProperty("output_text")]
        public string OutputText { get; set; }

        [JsonProperty("usage")]
        public OpenAIResponseUsage Usage { get; set; }

        [JsonProperty("parallel_tool_calls")]
        public bool ParallelToolCalls { get; set; }

        [JsonProperty("conversation")]
        public OpenAIResponseConversationType Conversation { get; set; }

        [JsonProperty("agent")]
        public AgentId Agent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIServiceTier
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "flex")]
        Flex,
        [EnumMember(Value = "scale")]
        Scale,
        [EnumMember(Value = "priority")]
        Priority
    }

    public class OpenAIReasoning
    {
        [JsonProperty("effort")]
        public OpenAIReasoningEffortType Effort { get; set; }

        [JsonProperty("summary")]
        public OpenAIReasoningSummaryType Summary { get; set; }

        [JsonProperty("generate_summary")]
        public OpenAIReasoningGenerateSummaryType GenerateSummary { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIReasoningEffortType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIReasoningSummaryType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "concise")]
        Concise,
        [EnumMember(Value = "detailed")]
        Detailed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIReasoningGenerateSummaryType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "concise")]
        Concise,
        [EnumMember(Value = "detailed")]
        Detailed
    }

    public class OpenAIResponseTextType
    {
        [JsonProperty("format")]
        public OpenAIResponseTextFormatConfiguration Format { get; set; }
    }

    public class OpenAIResponseTextFormatConfiguration
    {
        [JsonProperty("type")]
        public OpenAIResponseTextFormatConfigurationType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseTextFormatConfigurationType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "json_schema")]
        JsonSchema,
        [EnumMember(Value = "json_object")]
        JsonObject
    }

    public class OpenAITool
    {
        [JsonProperty("type")]
        public OpenAIToolType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIToolType
    {
        [EnumMember(Value = "file_search")]
        FileSearch,
        [EnumMember(Value = "function")]
        Function,
        [EnumMember(Value = "computer_use_preview")]
        ComputerUsePreview,
        [EnumMember(Value = "web_search_preview")]
        WebSearchPreview,
        [EnumMember(Value = "mcp")]
        Mcp,
        [EnumMember(Value = "code_interpreter")]
        CodeInterpreter,
        [EnumMember(Value = "image_generation")]
        ImageGeneration,
        [EnumMember(Value = "local_shell")]
        LocalShell,
        [EnumMember(Value = "bing_grounding")]
        BingGrounding,
        [EnumMember(Value = "browser_automation_preview")]
        BrowserAutomationPreview,
        [EnumMember(Value = "fabric_dataagent_preview")]
        FabricDataagentPreview,
        [EnumMember(Value = "sharepoint_grounding_preview")]
        SharepointGroundingPreview,
        [EnumMember(Value = "azure_ai_search")]
        AzureAiSearch,
        [EnumMember(Value = "openapi")]
        Openapi,
        [EnumMember(Value = "bing_custom_search_preview")]
        BingCustomSearchPreview,
        [EnumMember(Value = "capture_structured_outputs")]
        CaptureStructuredOutputs,
        [EnumMember(Value = "capture_semantic_events")]
        CaptureSemanticEvents,
        [EnumMember(Value = "a2a_preview")]
        A2aPreview,
        [EnumMember(Value = "azure_function")]
        AzureFunction,
        [EnumMember(Value = "memory_search")]
        MemorySearch
    }

    public class OpenAIPrompt
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("variables")]
        public JToken Variables { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseTruncationType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseObjectEntityType
    {
        [EnumMember(Value = "response")]
        Response
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseStatusType
    {
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "in_progress")]
        InProgress,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "incomplete")]
        Incomplete
    }

    public class OpenAIResponseError
    {
        [JsonProperty("code")]
        public OpenAIResponseErrorCode Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseErrorCode
    {
        [EnumMember(Value = "server_error")]
        ServerError,
        [EnumMember(Value = "rate_limit_exceeded")]
        RateLimitExceeded,
        [EnumMember(Value = "invalid_prompt")]
        InvalidPrompt,
        [EnumMember(Value = "vector_store_timeout")]
        VectorStoreTimeout,
        [EnumMember(Value = "invalid_image")]
        InvalidImage,
        [EnumMember(Value = "invalid_image_format")]
        InvalidImageFormat,
        [EnumMember(Value = "invalid_base64_image")]
        InvalidBase64Image,
        [EnumMember(Value = "invalid_image_url")]
        InvalidImageUrl,
        [EnumMember(Value = "image_too_large")]
        ImageTooLarge,
        [EnumMember(Value = "image_too_small")]
        ImageTooSmall,
        [EnumMember(Value = "image_parse_error")]
        ImageParseError,
        [EnumMember(Value = "image_content_policy_violation")]
        ImageContentPolicyViolation,
        [EnumMember(Value = "invalid_image_mode")]
        InvalidImageMode,
        [EnumMember(Value = "image_file_too_large")]
        ImageFileTooLarge,
        [EnumMember(Value = "unsupported_image_media_type")]
        UnsupportedImageMediaType,
        [EnumMember(Value = "empty_image_file")]
        EmptyImageFile,
        [EnumMember(Value = "failed_to_download_image")]
        FailedToDownloadImage,
        [EnumMember(Value = "image_file_not_found")]
        ImageFileNotFound
    }

    public class OpenAIResponseIncompleteDetailsType
    {
        [JsonProperty("reason")]
        public OpenAIResponseIncompleteDetailsTypeReasonType Reason { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseIncompleteDetailsTypeReasonType
    {
        [EnumMember(Value = "max_output_tokens")]
        MaxOutputTokens,
        [EnumMember(Value = "content_filter")]
        ContentFilter
    }

    public class OpenAIItemResource
    {
        [JsonProperty("type")]
        public OpenAIItemType Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIItemType
    {
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "file_search_call")]
        FileSearchCall,
        [EnumMember(Value = "function_call")]
        FunctionCall,
        [EnumMember(Value = "function_call_output")]
        FunctionCallOutput,
        [EnumMember(Value = "computer_call")]
        ComputerCall,
        [EnumMember(Value = "computer_call_output")]
        ComputerCallOutput,
        [EnumMember(Value = "web_search_call")]
        WebSearchCall,
        [EnumMember(Value = "reasoning")]
        Reasoning,
        [EnumMember(Value = "item_reference")]
        ItemReference,
        [EnumMember(Value = "image_generation_call")]
        ImageGenerationCall,
        [EnumMember(Value = "code_interpreter_call")]
        CodeInterpreterCall,
        [EnumMember(Value = "local_shell_call")]
        LocalShellCall,
        [EnumMember(Value = "local_shell_call_output")]
        LocalShellCallOutput,
        [EnumMember(Value = "mcp_list_tools")]
        McpListTools,
        [EnumMember(Value = "mcp_approval_request")]
        McpApprovalRequest,
        [EnumMember(Value = "mcp_approval_response")]
        McpApprovalResponse,
        [EnumMember(Value = "mcp_call")]
        McpCall,
        [EnumMember(Value = "structured_inputs")]
        StructuredInputs,
        [EnumMember(Value = "structured_outputs")]
        StructuredOutputs,
        [EnumMember(Value = "semantic_event")]
        SemanticEvent,
        [EnumMember(Value = "workflow_action")]
        WorkflowAction,
        [EnumMember(Value = "memory_search_call")]
        MemorySearchCall
    }

    public class OpenAIResponseUsage
    {
        [JsonProperty("input_tokens")]
        public int InputTokens { get; set; }

        [JsonProperty("input_tokens_details")]
        public OpenAIResponseUsageInputTokensDetailsType InputTokensDetails { get; set; }

        [JsonProperty("output_tokens")]
        public int OutputTokens { get; set; }

        [JsonProperty("output_tokens_details")]
        public OpenAIResponseUsageOutputTokensDetailsType OutputTokensDetails { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class OpenAIResponseUsageInputTokensDetailsType
    {
        [JsonProperty("cached_tokens")]
        public int CachedTokens { get; set; }
    }

    public class OpenAIResponseUsageOutputTokensDetailsType
    {
        [JsonProperty("reasoning_tokens")]
        public int ReasoningTokens { get; set; }
    }

    public class OpenAIResponseConversationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AgentId
    {
        [JsonProperty("type")]
        public AgentIdTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgentIdTypeType
    {
        [EnumMember(Value = "agent_id")]
        AgentId
    }

    public class InvokeAgentInput
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("top_logprobs")]
        public int? TopLogprobs { get; set; }

        [JsonProperty("previous_response_id")]
        public string PreviousResponseId { get; set; }

        [JsonProperty("background", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Background { get; set; } = false;

        [JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        [JsonProperty("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        [JsonProperty("text")]
        public InvokeAgentInputTextType Text { get; set; }

        [JsonProperty("tools")]
        public OpenAITool[] Tools { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("prompt")]
        public OpenAIPrompt Prompt { get; set; }

        [JsonProperty("truncation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InvokeAgentInputTruncationType? Truncation { get; set; } = InvokeAgentInputTruncationType.Disabled;

        [JsonProperty("input")]
        public JToken Input { get; set; }

        [JsonProperty("include")]
        public OpenAIIncludable[] Include { get; set; }

        [JsonProperty("parallel_tool_calls", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ParallelToolCalls { get; set; } = true;

        [JsonProperty("store", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Store { get; set; } = true;

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("conversation")]
        public InvokeAgentInputConversationType Conversation { get; set; }

        [JsonProperty("agent")]
        public AgentReference Agent { get; set; }
    }

    public class InvokeAgentInputTextType
    {
        [JsonProperty("format")]
        public OpenAIResponseTextFormatConfiguration Format { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeAgentInputTruncationType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIIncludable
    {
        [EnumMember(Value = "code_interpreter_call.outputs")]
        CodeInterpreterCallOutputs,
        [EnumMember(Value = "computer_call_output.output.image_url")]
        ComputerCallOutputOutputImageUrl,
        [EnumMember(Value = "file_search_call.results")]
        FileSearchCallResults,
        [EnumMember(Value = "message.input_image.image_url")]
        MessageInputImageImageUrl,
        [EnumMember(Value = "message.output_text.logprobs")]
        MessageOutputTextLogprobs,
        [EnumMember(Value = "reasoning.encrypted_content")]
        ReasoningEncryptedContent,
        [EnumMember(Value = "memory_search_call.results")]
        MemorySearchCallResults
    }

    public class InvokeAgentInputConversationType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public InvokeAgentInputConversationTypeConversationIdType ConversationId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeAgentInputConversationTypeConversationIdType
    {
        [EnumMember(Value = "Create new Conversation")]
        CreateNewConversation
    }

    public class AgentReference
    {
        [JsonProperty("type")]
        public AgentReferenceTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgentReferenceTypeType
    {
        [EnumMember(Value = "agent_reference")]
        AgentReference
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice;

    public partial class WorkflowManagedActions
    {
        public AzureagentserviceActions Azureagentservice(string connectionId) => new AzureagentserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureagentserviceTriggers Azureagentservice(string connectionId) => new AzureagentserviceTriggers(connectionId);
    }
}