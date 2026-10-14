//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzureagentserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListAgentsResponse> ListAgents(Expression<Func<apiVersionInput>> apiVersion)
        {
            var __workflow_apiVersion = apiVersion == null ? null : WorkflowExpression.Compile(apiVersion);
            WorkflowExpression.Validate(__workflow_apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListAgentsResponse>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListAgentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateThreadResponse> CreateThread(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<Messages[]>> requestBodymessages = null)
        {
            var __workflow_apiVersion = apiVersion == null ? null : WorkflowExpression.Compile(apiVersion);
            WorkflowExpression.Validate(__workflow_apiVersion, nameof(apiVersion), required: true);
            var __workflow_requestBodymessages = requestBodymessages == null ? null : WorkflowExpression.Compile(requestBodymessages);
            WorkflowExpression.Validate(__workflow_requestBodymessages, nameof(requestBodymessages), required: false);
            return new DeferredBodyAction<CreateThreadResponse>(() =>
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodymessages != null)
                {
                    requestBody["messages"] = ExpressionConverter.ConvertO(__workflow_requestBodymessages);
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

                return new ApiConnectionAction<CreateThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateRunResponse> CreateRun(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<string>> threadId, Expression<Func<string>> requestBodyassistantId, Expression<Func<string>> requestBodymodel = null, Expression<Func<string>> requestBodyinstructions = null, Expression<Func<string>> requestBodyadditionalInstructions = null, Expression<Func<Messages[]>> requestBodyadditionalMessages = null, Expression<Func<Tools[]>> requestBodytools = null, Expression<Func<double>> requestBodytemperature = null, Expression<Func<double>> requestBodytopP = null, Expression<Func<bool>> requestBodystream = null, Expression<Func<int>> requestBodymaxPromptTokens = null, Expression<Func<int>> requestBodymaxCompletionTokens = null)
        {
            var __workflow_apiVersion = apiVersion == null ? null : WorkflowExpression.Compile(apiVersion);
            WorkflowExpression.Validate(__workflow_apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_requestBodyassistantId = requestBodyassistantId == null ? null : WorkflowExpression.Compile(requestBodyassistantId);
            WorkflowExpression.Validate(__workflow_requestBodyassistantId, nameof(requestBodyassistantId), required: true);
            var __workflow_requestBodymodel = requestBodymodel == null ? null : WorkflowExpression.Compile(requestBodymodel);
            WorkflowExpression.Validate(__workflow_requestBodymodel, nameof(requestBodymodel), required: false);
            var __workflow_requestBodyinstructions = requestBodyinstructions == null ? null : WorkflowExpression.Compile(requestBodyinstructions);
            WorkflowExpression.Validate(__workflow_requestBodyinstructions, nameof(requestBodyinstructions), required: false);
            var __workflow_requestBodyadditionalInstructions = requestBodyadditionalInstructions == null ? null : WorkflowExpression.Compile(requestBodyadditionalInstructions);
            WorkflowExpression.Validate(__workflow_requestBodyadditionalInstructions, nameof(requestBodyadditionalInstructions), required: false);
            var __workflow_requestBodyadditionalMessages = requestBodyadditionalMessages == null ? null : WorkflowExpression.Compile(requestBodyadditionalMessages);
            WorkflowExpression.Validate(__workflow_requestBodyadditionalMessages, nameof(requestBodyadditionalMessages), required: false);
            var __workflow_requestBodytools = requestBodytools == null ? null : WorkflowExpression.Compile(requestBodytools);
            WorkflowExpression.Validate(__workflow_requestBodytools, nameof(requestBodytools), required: false);
            var __workflow_requestBodytemperature = requestBodytemperature == null ? null : WorkflowExpression.Compile(requestBodytemperature);
            WorkflowExpression.Validate(__workflow_requestBodytemperature, nameof(requestBodytemperature), required: false);
            var __workflow_requestBodytopP = requestBodytopP == null ? null : WorkflowExpression.Compile(requestBodytopP);
            WorkflowExpression.Validate(__workflow_requestBodytopP, nameof(requestBodytopP), required: false);
            var __workflow_requestBodystream = requestBodystream == null ? null : WorkflowExpression.Compile(requestBodystream);
            WorkflowExpression.Validate(__workflow_requestBodystream, nameof(requestBodystream), required: false);
            var __workflow_requestBodymaxPromptTokens = requestBodymaxPromptTokens == null ? null : WorkflowExpression.Compile(requestBodymaxPromptTokens);
            WorkflowExpression.Validate(__workflow_requestBodymaxPromptTokens, nameof(requestBodymaxPromptTokens), required: false);
            var __workflow_requestBodymaxCompletionTokens = requestBodymaxCompletionTokens == null ? null : WorkflowExpression.Compile(requestBodymaxCompletionTokens);
            WorkflowExpression.Validate(__workflow_requestBodymaxCompletionTokens, nameof(requestBodymaxCompletionTokens), required: false);
            return new DeferredBodyAction<CreateRunResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["assistant_id"] = ExpressionConverter.ConvertO(__workflow_requestBodyassistantId);
                if (__workflow_requestBodymodel != null)
                {
                    requestBody["model"] = ExpressionConverter.ConvertO(__workflow_requestBodymodel);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyinstructions != null)
                {
                    requestBody["instructions"] = ExpressionConverter.ConvertO(__workflow_requestBodyinstructions);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyadditionalInstructions != null)
                {
                    requestBody["additional_instructions"] = ExpressionConverter.ConvertO(__workflow_requestBodyadditionalInstructions);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyadditionalMessages != null)
                {
                    requestBody["additional_messages"] = ExpressionConverter.ConvertO(__workflow_requestBodyadditionalMessages);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodytools != null)
                {
                    requestBody["tools"] = ExpressionConverter.ConvertO(__workflow_requestBodytools);
                    requestBodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    requestBody["metadata"] = metadataObject;
                    requestBodypropCount++;
                }

                if (__workflow_requestBodytemperature != null)
                {
                    if (__workflow_requestBodytemperature != null)
                    {
                        requestBody["temperature"] = ExpressionConverter.ConvertO(__workflow_requestBodytemperature);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["temperature"] = 1;
                    requestBodypropCount++;
                }

                if (__workflow_requestBodytopP != null)
                {
                    if (__workflow_requestBodytopP != null)
                    {
                        requestBody["top_p"] = ExpressionConverter.ConvertO(__workflow_requestBodytopP);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["top_p"] = 1;
                    requestBodypropCount++;
                }

                if (__workflow_requestBodystream != null)
                {
                    requestBody["stream"] = ExpressionConverter.ConvertO(__workflow_requestBodystream);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodymaxPromptTokens != null)
                {
                    requestBody["max_prompt_tokens"] = ExpressionConverter.ConvertO(__workflow_requestBodymaxPromptTokens);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodymaxCompletionTokens != null)
                {
                    requestBody["max_completion_tokens"] = ExpressionConverter.ConvertO(__workflow_requestBodymaxCompletionTokens);
                    requestBodypropCount++;
                }

                var truncationStrategyObject = new JObject();
                var truncationStrategyObjectpropCount = 0;
                if (truncationStrategyObjectpropCount > 0)
                {
                    requestBody["truncation_strategy"] = truncationStrategyObject;
                    requestBodypropCount++;
                }

                var toolChoiceObject = new JObject();
                var toolChoiceObjectpropCount = 0;
                if (toolChoiceObjectpropCount > 0)
                {
                    requestBody["tool_choice"] = toolChoiceObject;
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

                return new ApiConnectionAction<CreateRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<GetRunResponse> GetRun(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_apiVersion = apiVersion == null ? null : WorkflowExpression.Compile(apiVersion);
            WorkflowExpression.Validate(__workflow_apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_runId = runId == null ? null : WorkflowExpression.Compile(runId);
            WorkflowExpression.Validate(__workflow_runId, nameof(runId), required: true);
            return new DeferredBodyAction<GetRunResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<GetRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListMessageResponse> ListMessages(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<string>> threadId)
        {
            var __workflow_apiVersion = apiVersion == null ? null : WorkflowExpression.Compile(apiVersion);
            WorkflowExpression.Validate(__workflow_apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ListMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<OpenAIResponse> InvokeAgent(Expression<Func<apiVersionInput>> apiVersion, Expression<Func<string>> bodypromptid, Expression<Func<bodyagenttypeInput>> bodyagenttype, Expression<Func<string>> bodyagentname, Expression<Func<string>> bodyagentversion, Expression<Func<string>> bodyuser = null, Expression<Func<int>> bodytopLogprobs = null, Expression<Func<string>> bodypreviousResponseId = null, Expression<Func<bool>> bodybackground = null, Expression<Func<int>> bodymaxOutputTokens = null, Expression<Func<int>> bodymaxToolCalls = null, Expression<Func<bodytextformattypeInput>> bodytextformattype = null, Expression<Func<OpenAITool[]>> bodytools = null, Expression<Func<object>> bodytoolChoice = null, Expression<Func<string>> bodypromptversion = null, Expression<Func<bodytruncationInput>> bodytruncation = null, Expression<Func<object>> bodyinput = null, Expression<Func<OpenAIIncludable[]>> bodyinclude = null, Expression<Func<bool>> bodyparallelToolCalls = null, Expression<Func<bool>> bodystore = null, Expression<Func<string>> bodyinstructions = null)
        {
            var __workflow_apiVersion = apiVersion == null ? null : WorkflowExpression.Compile(apiVersion);
            WorkflowExpression.Validate(__workflow_apiVersion, nameof(apiVersion), required: true);
            var __workflow_bodypromptid = bodypromptid == null ? null : WorkflowExpression.Compile(bodypromptid);
            WorkflowExpression.Validate(__workflow_bodypromptid, nameof(bodypromptid), required: true);
            var __workflow_bodyagenttype = bodyagenttype == null ? null : WorkflowExpression.Compile(bodyagenttype);
            WorkflowExpression.Validate(__workflow_bodyagenttype, nameof(bodyagenttype), required: true);
            var __workflow_bodyagentname = bodyagentname == null ? null : WorkflowExpression.Compile(bodyagentname);
            WorkflowExpression.Validate(__workflow_bodyagentname, nameof(bodyagentname), required: true);
            var __workflow_bodyagentversion = bodyagentversion == null ? null : WorkflowExpression.Compile(bodyagentversion);
            WorkflowExpression.Validate(__workflow_bodyagentversion, nameof(bodyagentversion), required: true);
            var __workflow_bodyuser = bodyuser == null ? null : WorkflowExpression.Compile(bodyuser);
            WorkflowExpression.Validate(__workflow_bodyuser, nameof(bodyuser), required: false);
            var __workflow_bodytopLogprobs = bodytopLogprobs == null ? null : WorkflowExpression.Compile(bodytopLogprobs);
            WorkflowExpression.Validate(__workflow_bodytopLogprobs, nameof(bodytopLogprobs), required: false);
            var __workflow_bodypreviousResponseId = bodypreviousResponseId == null ? null : WorkflowExpression.Compile(bodypreviousResponseId);
            WorkflowExpression.Validate(__workflow_bodypreviousResponseId, nameof(bodypreviousResponseId), required: false);
            var __workflow_bodybackground = bodybackground == null ? null : WorkflowExpression.Compile(bodybackground);
            WorkflowExpression.Validate(__workflow_bodybackground, nameof(bodybackground), required: false);
            var __workflow_bodymaxOutputTokens = bodymaxOutputTokens == null ? null : WorkflowExpression.Compile(bodymaxOutputTokens);
            WorkflowExpression.Validate(__workflow_bodymaxOutputTokens, nameof(bodymaxOutputTokens), required: false);
            var __workflow_bodymaxToolCalls = bodymaxToolCalls == null ? null : WorkflowExpression.Compile(bodymaxToolCalls);
            WorkflowExpression.Validate(__workflow_bodymaxToolCalls, nameof(bodymaxToolCalls), required: false);
            var __workflow_bodytextformattype = bodytextformattype == null ? null : WorkflowExpression.Compile(bodytextformattype);
            WorkflowExpression.Validate(__workflow_bodytextformattype, nameof(bodytextformattype), required: false);
            var __workflow_bodytools = bodytools == null ? null : WorkflowExpression.Compile(bodytools);
            WorkflowExpression.Validate(__workflow_bodytools, nameof(bodytools), required: false);
            var __workflow_bodytoolChoice = bodytoolChoice == null ? null : WorkflowExpression.Compile(bodytoolChoice);
            WorkflowExpression.Validate(__workflow_bodytoolChoice, nameof(bodytoolChoice), required: false);
            var __workflow_bodypromptversion = bodypromptversion == null ? null : WorkflowExpression.Compile(bodypromptversion);
            WorkflowExpression.Validate(__workflow_bodypromptversion, nameof(bodypromptversion), required: false);
            var __workflow_bodytruncation = bodytruncation == null ? null : WorkflowExpression.Compile(bodytruncation);
            WorkflowExpression.Validate(__workflow_bodytruncation, nameof(bodytruncation), required: false);
            var __workflow_bodyinput = bodyinput == null ? null : WorkflowExpression.Compile(bodyinput);
            WorkflowExpression.Validate(__workflow_bodyinput, nameof(bodyinput), required: false);
            var __workflow_bodyinclude = bodyinclude == null ? null : WorkflowExpression.Compile(bodyinclude);
            WorkflowExpression.Validate(__workflow_bodyinclude, nameof(bodyinclude), required: false);
            var __workflow_bodyparallelToolCalls = bodyparallelToolCalls == null ? null : WorkflowExpression.Compile(bodyparallelToolCalls);
            WorkflowExpression.Validate(__workflow_bodyparallelToolCalls, nameof(bodyparallelToolCalls), required: false);
            var __workflow_bodystore = bodystore == null ? null : WorkflowExpression.Compile(bodystore);
            WorkflowExpression.Validate(__workflow_bodystore, nameof(bodystore), required: false);
            var __workflow_bodyinstructions = bodyinstructions == null ? null : WorkflowExpression.Compile(bodyinstructions);
            WorkflowExpression.Validate(__workflow_bodyinstructions, nameof(bodyinstructions), required: false);
            return new DeferredBodyAction<OpenAIResponse>(() =>
            {
                var apiCallPath = "/openai/responses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (__workflow_bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                    bodypropCount++;
                }

                if (__workflow_bodytopLogprobs != null)
                {
                    body["top_logprobs"] = ExpressionConverter.ConvertO(__workflow_bodytopLogprobs);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousResponseId != null)
                {
                    body["previous_response_id"] = ExpressionConverter.ConvertO(__workflow_bodypreviousResponseId);
                    bodypropCount++;
                }

                if (__workflow_bodybackground != null)
                {
                    if (__workflow_bodybackground != null)
                    {
                        body["background"] = ExpressionConverter.ConvertO(__workflow_bodybackground);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["background"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodymaxOutputTokens != null)
                {
                    body["max_output_tokens"] = ExpressionConverter.ConvertO(__workflow_bodymaxOutputTokens);
                    bodypropCount++;
                }

                if (__workflow_bodymaxToolCalls != null)
                {
                    body["max_tool_calls"] = ExpressionConverter.ConvertO(__workflow_bodymaxToolCalls);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                var formatObject = new JObject();
                var formatObjectpropCount = 0;
                if (__workflow_bodytextformattype != null)
                {
                    formatObject["type"] = ExpressionConverter.ConvertO(__workflow_bodytextformattype);
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

                if (__workflow_bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(__workflow_bodytools);
                    bodypropCount++;
                }

                if (__workflow_bodytoolChoice != null)
                {
                    body["tool_choice"] = ExpressionConverter.ConvertO(__workflow_bodytoolChoice);
                    bodypropCount++;
                }

                var promptObject = new JObject();
                var promptObjectpropCount = 0;
                promptObjectpropCount++;
                promptObject["id"] = ExpressionConverter.ConvertO(__workflow_bodypromptid);
                if (__workflow_bodypromptversion != null)
                {
                    promptObject["version"] = ExpressionConverter.ConvertO(__workflow_bodypromptversion);
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

                if (__workflow_bodytruncation != null)
                {
                    if (__workflow_bodytruncation != null)
                    {
                        body["truncation"] = ExpressionConverter.ConvertO(__workflow_bodytruncation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["truncation"] = "disabled";
                    bodypropCount++;
                }

                if (__workflow_bodyinput != null)
                {
                    body["input"] = ExpressionConverter.ConvertO(__workflow_bodyinput);
                    bodypropCount++;
                }

                if (__workflow_bodyinclude != null)
                {
                    body["include"] = ExpressionConverter.ConvertO(__workflow_bodyinclude);
                    bodypropCount++;
                }

                if (__workflow_bodyparallelToolCalls != null)
                {
                    if (__workflow_bodyparallelToolCalls != null)
                    {
                        body["parallel_tool_calls"] = ExpressionConverter.ConvertO(__workflow_bodyparallelToolCalls);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["parallel_tool_calls"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodystore != null)
                {
                    if (__workflow_bodystore != null)
                    {
                        body["store"] = ExpressionConverter.ConvertO(__workflow_bodystore);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["store"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                    bodypropCount++;
                }

                var agentObject = new JObject();
                var agentObjectpropCount = 0;
                agentObjectpropCount++;
                agentObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyagenttype);
                agentObjectpropCount++;
                agentObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyagentname);
                agentObjectpropCount++;
                agentObject["version"] = ExpressionConverter.ConvertO(__workflow_bodyagentversion);
                if (agentObjectpropCount > 0)
                {
                    body["agent"] = agentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpenAIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken> SendActivity(Expression<Func<string>> agentId)
        {
            var __workflow_agentId = agentId == null ? null : WorkflowExpression.Compile(agentId);
            WorkflowExpression.Validate(__workflow_agentId, nameof(agentId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/agents/{0}/protocols/activityprotocol", ExpressionConverter.ConvertWithUrlEncoding(__workflow_agentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                var activity = new JObject();
                var activitypropCount = 0;
                if (activitypropCount > 0)
                {
                    callPayload.Body = activity;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken> SendActivityApplication(Expression<Func<string>> myApplication)
        {
            var __workflow_myApplication = myApplication == null ? null : WorkflowExpression.Compile(myApplication);
            WorkflowExpression.Validate(__workflow_myApplication, nameof(myApplication), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/applications/{0}/protocols/activityprotocol", ExpressionConverter.ConvertWithUrlEncoding(__workflow_myApplication, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                var activity = new JObject();
                var activitypropCount = 0;
                if (activitypropCount > 0)
                {
                    callPayload.Body = activity;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyagenttypeInput
    {
        [EnumMember(Value = "agent_reference")]
        AgentReference
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytextformattypeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "json_schema")]
        JsonSchema,
        [EnumMember(Value = "json_object")]
        JsonObject
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytruncationInput
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
