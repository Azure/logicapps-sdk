//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureagentserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListAgentsResponse> ListAgents([WorkflowExpression] Func<apiVersionInput> apiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.Convert(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ListAgentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListAgentsServiceResponse> ListAgentsFromService()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/agents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListAgentsServiceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateThreadResponse> CreateThread([WorkflowExpression] Func<apiVersionInput> apiVersion, [WorkflowExpression] Func<Messages[]> requestBodymessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.Convert(apiVersion);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodymessages != null)
                {
                    requestBody["messages"] = SourceExpressionConverter.ConvertToken(requestBodymessages);
                    requestBodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    requestBody["metadata"] = metadataObject;
                    requestBodypropCount++;
                }

                var toolResourcesObject = new JObject();
                var toolResourcesObjectpropCount = 0;
                if (toolResourcesObjectpropCount > 0)
                {
                    requestBody["tool_resources"] = toolResourcesObject;
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateThreadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateRunResponse> CreateRun([WorkflowExpression] Func<apiVersionInput> apiVersion, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> requestBodyassistantId, [WorkflowExpression] Func<string> requestBodymodel = null, [WorkflowExpression] Func<string> requestBodyinstructions = null, [WorkflowExpression] Func<string> requestBodyadditionalInstructions = null, [WorkflowExpression] Func<Messages[]> requestBodyadditionalMessages = null, [WorkflowExpression] Func<Tools[]> requestBodytools = null, [WorkflowExpression] Func<double> requestBodytemperature = null, [WorkflowExpression] Func<double> requestBodytopP = null, [WorkflowExpression] Func<bool> requestBodystream = null, [WorkflowExpression] Func<int> requestBodymaxPromptTokens = null, [WorkflowExpression] Func<int> requestBodymaxCompletionTokens = null, [WorkflowExpression] Func<object> requestBodytoolChoice = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.Convert(apiVersion);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["assistant_id"] = SourceExpressionConverter.ConvertToken(requestBodyassistantId);
                if (requestBodymodel != null)
                {
                    requestBody["model"] = SourceExpressionConverter.ConvertToken(requestBodymodel);
                    requestBodypropCount++;
                }

                if (requestBodyinstructions != null)
                {
                    requestBody["instructions"] = SourceExpressionConverter.ConvertToken(requestBodyinstructions);
                    requestBodypropCount++;
                }

                if (requestBodyadditionalInstructions != null)
                {
                    requestBody["additional_instructions"] = SourceExpressionConverter.ConvertToken(requestBodyadditionalInstructions);
                    requestBodypropCount++;
                }

                if (requestBodyadditionalMessages != null)
                {
                    requestBody["additional_messages"] = SourceExpressionConverter.ConvertToken(requestBodyadditionalMessages);
                    requestBodypropCount++;
                }

                if (requestBodytools != null)
                {
                    requestBody["tools"] = SourceExpressionConverter.ConvertToken(requestBodytools);
                    requestBodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    requestBody["metadata"] = metadataObject;
                    requestBodypropCount++;
                }

                if (requestBodytemperature != null)
                {
                    if (requestBodytemperature != null)
                    {
                        requestBody["temperature"] = SourceExpressionConverter.ConvertToken(requestBodytemperature);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["temperature"] = 1;
                    requestBodypropCount++;
                }

                if (requestBodytopP != null)
                {
                    if (requestBodytopP != null)
                    {
                        requestBody["top_p"] = SourceExpressionConverter.ConvertToken(requestBodytopP);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["top_p"] = 1;
                    requestBodypropCount++;
                }

                if (requestBodystream != null)
                {
                    requestBody["stream"] = SourceExpressionConverter.ConvertToken(requestBodystream);
                    requestBodypropCount++;
                }

                if (requestBodymaxPromptTokens != null)
                {
                    requestBody["max_prompt_tokens"] = SourceExpressionConverter.ConvertToken(requestBodymaxPromptTokens);
                    requestBodypropCount++;
                }

                if (requestBodymaxCompletionTokens != null)
                {
                    requestBody["max_completion_tokens"] = SourceExpressionConverter.ConvertToken(requestBodymaxCompletionTokens);
                    requestBodypropCount++;
                }

                var truncationStrategyObject = new JObject();
                var truncationStrategyObjectpropCount = 0;
                if (truncationStrategyObjectpropCount > 0)
                {
                    requestBody["truncation_strategy"] = truncationStrategyObject;
                    requestBodypropCount++;
                }

                if (requestBodytoolChoice != null)
                {
                    requestBody["tool_choice"] = SourceExpressionConverter.ConvertToken(requestBodytoolChoice);
                    requestBodypropCount++;
                }

                var responseFormatObject = new JObject();
                var responseFormatObjectpropCount = 0;
                if (responseFormatObjectpropCount > 0)
                {
                    requestBody["response_format"] = responseFormatObject;
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateRunResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<GetRunResponse> GetRun([WorkflowExpression] Func<apiVersionInput> apiVersion, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.Convert(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<GetRunResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListMessageResponse> ListMessages([WorkflowExpression] Func<apiVersionInput> apiVersion, [WorkflowExpression] Func<string> threadId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.Convert(apiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<ListMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<OpenAIResponse> InvokeAgent([WorkflowExpression] Func<apiVersionInput> apiVersion, [WorkflowExpression] Func<string> bodypromptid, [WorkflowExpression] Func<bodyconversationconversationIdInput> bodyconversationconversationId, [WorkflowExpression] Func<bodyagenttypeInput> bodyagenttype, [WorkflowExpression] Func<string> bodyagentname, [WorkflowExpression] Func<string> bodyagentversion, [WorkflowExpression] Func<string> bodyuser = null, [WorkflowExpression] Func<int> bodytopLogprobs = null, [WorkflowExpression] Func<string> bodypreviousResponseId = null, [WorkflowExpression] Func<bool> bodybackground = null, [WorkflowExpression] Func<int> bodymaxOutputTokens = null, [WorkflowExpression] Func<int> bodymaxToolCalls = null, [WorkflowExpression] Func<bodytextformattypeInput> bodytextformattype = null, [WorkflowExpression] Func<OpenAITool[]> bodytools = null, [WorkflowExpression] Func<object> bodytoolChoice = null, [WorkflowExpression] Func<string> bodypromptversion = null, [WorkflowExpression] Func<bodytruncationInput> bodytruncation = null, [WorkflowExpression] Func<object> bodyinput = null, [WorkflowExpression] Func<OpenAIIncludable[]> bodyinclude = null, [WorkflowExpression] Func<bool> bodyparallelToolCalls = null, [WorkflowExpression] Func<bool> bodystore = null, [WorkflowExpression] Func<string> bodyinstructions = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/openai/responses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = SourceExpressionConverter.Convert(apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodytopLogprobs != null)
                {
                    body["top_logprobs"] = SourceExpressionConverter.ConvertToken(bodytopLogprobs);
                    bodypropCount++;
                }

                if (bodypreviousResponseId != null)
                {
                    body["previous_response_id"] = SourceExpressionConverter.ConvertToken(bodypreviousResponseId);
                    bodypropCount++;
                }

                if (bodybackground != null)
                {
                    if (bodybackground != null)
                    {
                        body["background"] = SourceExpressionConverter.ConvertToken(bodybackground);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["background"] = false;
                    bodypropCount++;
                }

                if (bodymaxOutputTokens != null)
                {
                    body["max_output_tokens"] = SourceExpressionConverter.ConvertToken(bodymaxOutputTokens);
                    bodypropCount++;
                }

                if (bodymaxToolCalls != null)
                {
                    body["max_tool_calls"] = SourceExpressionConverter.ConvertToken(bodymaxToolCalls);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                var formatObject = new JObject();
                var formatObjectpropCount = 0;
                if (bodytextformattype != null)
                {
                    formatObject["type"] = SourceExpressionConverter.Convert(bodytextformattype);
                    formatObjectpropCount++;
                }

                if (formatObjectpropCount > 0)
                {
                    textObject["format"] = formatObject;
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = SourceExpressionConverter.ConvertToken(bodytools);
                    bodypropCount++;
                }

                if (bodytoolChoice != null)
                {
                    body["tool_choice"] = SourceExpressionConverter.ConvertToken(bodytoolChoice);
                    bodypropCount++;
                }

                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                promptObjectpropCount++;
                promptObject["id"] = SourceExpressionConverter.ConvertToken(bodypromptid);
                if (bodypromptversion != null)
                {
                    promptObject["version"] = SourceExpressionConverter.ConvertToken(bodypromptversion);
                    promptObjectpropCount++;
                }

                var variablesObject = new JObject();
                var variablesObjectpropCount = 0;
                if (variablesObjectpropCount > 0)
                {
                    promptObject["variables"] = variablesObject;
                    promptObjectpropCount++;
                }

                if (promptObjectpropCount > 0)
                {
                    body["prompt"] = promptObject;
                    bodypropCount++;
                }

                if (bodytruncation != null)
                {
                    if (bodytruncation != null)
                    {
                        body["truncation"] = SourceExpressionConverter.Convert(bodytruncation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["truncation"] = "disabled";
                    bodypropCount++;
                }

                if (bodyinput != null)
                {
                    body["input"] = SourceExpressionConverter.ConvertToken(bodyinput);
                    bodypropCount++;
                }

                if (bodyinclude != null)
                {
                    body["include"] = SourceExpressionConverter.ConvertToken(bodyinclude);
                    bodypropCount++;
                }

                if (bodyparallelToolCalls != null)
                {
                    if (bodyparallelToolCalls != null)
                    {
                        body["parallel_tool_calls"] = SourceExpressionConverter.ConvertToken(bodyparallelToolCalls);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["parallel_tool_calls"] = true;
                    bodypropCount++;
                }

                if (bodystore != null)
                {
                    if (bodystore != null)
                    {
                        body["store"] = SourceExpressionConverter.ConvertToken(bodystore);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["store"] = true;
                    bodypropCount++;
                }

                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                var conversationObject = new JObject();
                var conversationObjectpropCount = 0;
                conversationObjectpropCount++;
                conversationObject["id"] = SourceExpressionConverter.Convert(bodyconversationconversationId);
                if (conversationObjectpropCount > 0)
                {
                    body["conversation"] = conversationObject;
                    bodypropCount++;
                }

                var agentObject = new JObject();
                var agentObjectpropCount = 0;
                agentObjectpropCount++;
                agentObject["type"] = SourceExpressionConverter.Convert(bodyagenttype);
                agentObjectpropCount++;
                agentObject["name"] = SourceExpressionConverter.ConvertToken(bodyagentname);
                agentObjectpropCount++;
                agentObject["version"] = SourceExpressionConverter.ConvertToken(bodyagentversion);
                if (agentObjectpropCount > 0)
                {
                    body["agent"] = agentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenAIResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken> SendActivityApplication([WorkflowExpression] Func<string> myApplication)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/applications/{0}/protocols/activityprotocol", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(myApplication, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                var activity = new JObject();
                var activitypropCount = 0;
                if (activitypropCount > 0)
                {
                    callPayload.Body = activity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken> SendActivity([WorkflowExpression] Func<string> agentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/agents/{0}/endpoint/protocols/activityprotocol", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(agentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                var activity = new JObject();
                var activitypropCount = 0;
                if (activitypropCount > 0)
                {
                    callPayload.Body = activity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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

    public enum OpenAIReasoningEffortType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High
    }

    public enum OpenAIReasoningSummaryType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "concise")]
        Concise,
        [EnumMember(Value = "detailed")]
        Detailed
    }

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

    public enum OpenAIResponseTruncationType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    public enum OpenAIResponseObjectEntityType
    {
        [EnumMember(Value = "response")]
        Response
    }

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

    public enum AgentIdTypeType
    {
        [EnumMember(Value = "agent_id")]
        AgentId
    }

    public enum bodyconversationconversationIdInput
    {
        [EnumMember(Value = "Create new Conversation")]
        CreateNewConversation
    }

    public enum bodyagenttypeInput
    {
        [EnumMember(Value = "agent_reference")]
        AgentReference
    }

    public enum bodytextformattypeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "json_schema")]
        JsonSchema,
        [EnumMember(Value = "json_object")]
        JsonObject
    }

    public enum bodytruncationInput
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "disabled")]
        Disabled
    }

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