//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaiassistants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OpenaiassistantsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ModelsGetResponse> ModelsGet()
        {
            var apiCallPath = "/models";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ModelsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantsGetResponse> AssistantsGet(Expression<Func<string>> openAIBeta)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            return new DeferredBodyAction<AssistantsGetResponse>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<AssistantsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantPostResponse> Assistant(Expression<Func<string>> openAIBeta, Expression<Func<string>> bodymodel, Expression<Func<string>> bodyinstructions = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodytoolsInputItem[]>> bodytools = null, Expression<Func<string[]>> bodyfileIds = null)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodyinstructions = bodyinstructions == null ? null : WorkflowExpression.Compile(bodyinstructions);
            WorkflowExpression.Validate(__workflow_bodyinstructions, nameof(bodyinstructions), required: false);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodytools = bodytools == null ? null : WorkflowExpression.Compile(bodytools);
            WorkflowExpression.Validate(__workflow_bodytools, nameof(bodytools), required: false);
            var __workflow_bodyfileIds = bodyfileIds == null ? null : WorkflowExpression.Compile(bodyfileIds);
            WorkflowExpression.Validate(__workflow_bodyfileIds, nameof(bodyfileIds), required: false);
            return new DeferredBodyAction<AssistantPostResponse>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                if (__workflow_bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(__workflow_bodytools);
                    bodypropCount++;
                }

                if (__workflow_bodyfileIds != null)
                {
                    body["file_ids"] = ExpressionConverter.ConvertO(__workflow_bodyfileIds);
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AssistantPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantGetResponse> AssistantGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = assistantId == null ? null : WorkflowExpression.Compile(assistantId);
            WorkflowExpression.Validate(__workflow_assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<AssistantGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_assistantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<AssistantGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantDeleteResponse> AssistantDelete(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = assistantId == null ? null : WorkflowExpression.Compile(assistantId);
            WorkflowExpression.Validate(__workflow_assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<AssistantDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_assistantId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<AssistantDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FilesGetResponse> FilesGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = assistantId == null ? null : WorkflowExpression.Compile(assistantId);
            WorkflowExpression.Validate(__workflow_assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<FilesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_assistantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<FilesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FilePostResponse> File(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId, Expression<Func<string>> bodyfileId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = assistantId == null ? null : WorkflowExpression.Compile(assistantId);
            WorkflowExpression.Validate(__workflow_assistantId, nameof(assistantId), required: true);
            var __workflow_bodyfileId = bodyfileId == null ? null : WorkflowExpression.Compile(bodyfileId);
            WorkflowExpression.Validate(__workflow_bodyfileId, nameof(bodyfileId), required: true);
            return new DeferredBodyAction<FilePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_assistantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FilePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FileGetResponse> FileGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId, Expression<Func<string>> fileId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = assistantId == null ? null : WorkflowExpression.Compile(assistantId);
            WorkflowExpression.Validate(__workflow_assistantId, nameof(assistantId), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<FileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_assistantId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<FileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FileDeleteResponse> FileDelete(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId, Expression<Func<string>> fileId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = assistantId == null ? null : WorkflowExpression.Compile(assistantId);
            WorkflowExpression.Validate(__workflow_assistantId, nameof(assistantId), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<FileDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_assistantId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<FileDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadPostResponse> Thread(Expression<Func<string>> openAIBeta, Expression<Func<bodymessagesInputItem[]>> bodymessages)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_bodymessages = bodymessages == null ? null : WorkflowExpression.Compile(bodymessages);
            WorkflowExpression.Validate(__workflow_bodymessages, nameof(bodymessages), required: true);
            return new DeferredBodyAction<ThreadPostResponse>(() =>
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(__workflow_bodymessages);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ThreadPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadGetResponse> ThreadGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<ThreadGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadDeleteResponse> ThreadDelete(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<ThreadDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadModifyPostResponse> ThreadModify(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadModifyPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ThreadModifyPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessagesGetResponse> MessagesGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<int>> limit = null, Expression<Func<string>> order = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_order = order == null ? null : WorkflowExpression.Compile(order);
            WorkflowExpression.Validate(__workflow_order, nameof(order), required: false);
            var __workflow_after = after == null ? null : WorkflowExpression.Compile(after);
            WorkflowExpression.Validate(__workflow_after, nameof(after), required: false);
            var __workflow_before = before == null ? null : WorkflowExpression.Compile(before);
            WorkflowExpression.Validate(__workflow_before, nameof(before), required: false);
            return new DeferredBodyAction<MessagesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<MessagesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessagePostResponse> Message(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<MessagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<MessagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageModifyPostResponse> MessageModify(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> messageId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageModifyPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MessageModifyPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageFileGetResponse> MessageFileGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> messageId, Expression<Func<string>> fileId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<MessageFileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}/files/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<MessageFileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageFilesGetResponse> MessageFilesGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> messageId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageFilesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<MessageFilesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunsGetResponse> RunsGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<int>> limit = null, Expression<Func<string>> order = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_order = order == null ? null : WorkflowExpression.Compile(order);
            WorkflowExpression.Validate(__workflow_order, nameof(order), required: false);
            var __workflow_after = after == null ? null : WorkflowExpression.Compile(after);
            WorkflowExpression.Validate(__workflow_after, nameof(after), required: false);
            var __workflow_before = before == null ? null : WorkflowExpression.Compile(before);
            WorkflowExpression.Validate(__workflow_before, nameof(before), required: false);
            return new DeferredBodyAction<RunsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunPostResponse> Run(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> bodymodel, Expression<Func<string>> bodyassistantId = null, Expression<Func<string>> bodyinstructions = null, Expression<Func<bodytoolsInputItem[]>> bodytools = null)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: true);
            var __workflow_bodyassistantId = bodyassistantId == null ? null : WorkflowExpression.Compile(bodyassistantId);
            WorkflowExpression.Validate(__workflow_bodyassistantId, nameof(bodyassistantId), required: false);
            var __workflow_bodyinstructions = bodyinstructions == null ? null : WorkflowExpression.Compile(bodyinstructions);
            WorkflowExpression.Validate(__workflow_bodyinstructions, nameof(bodyinstructions), required: false);
            var __workflow_bodytools = bodytools == null ? null : WorkflowExpression.Compile(bodytools);
            WorkflowExpression.Validate(__workflow_bodytools, nameof(bodytools), required: false);
            return new DeferredBodyAction<RunPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassistantId != null)
                {
                    body["assistant_id"] = ExpressionConverter.ConvertO(__workflow_bodyassistantId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                if (__workflow_bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                    bodypropCount++;
                }

                if (__workflow_bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(__workflow_bodytools);
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RunPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunGetResponse> RunGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_runId = runId == null ? null : WorkflowExpression.Compile(runId);
            WorkflowExpression.Validate(__workflow_runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunModifyPostResponse> RunModify(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_runId = runId == null ? null : WorkflowExpression.Compile(runId);
            WorkflowExpression.Validate(__workflow_runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunModifyPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RunModifyPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunToolOutputsPostResponse> RunToolOutputs(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId, Expression<Func<bodytoolOutputsInputItem[]>> bodytoolOutputs = null)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_runId = runId == null ? null : WorkflowExpression.Compile(runId);
            WorkflowExpression.Validate(__workflow_runId, nameof(runId), required: true);
            var __workflow_bodytoolOutputs = bodytoolOutputs == null ? null : WorkflowExpression.Compile(bodytoolOutputs);
            WorkflowExpression.Validate(__workflow_bodytoolOutputs, nameof(bodytoolOutputs), required: false);
            return new DeferredBodyAction<RunToolOutputsPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/submit_tool_outputs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytoolOutputs != null)
                {
                    body["tool_outputs"] = ExpressionConverter.ConvertO(__workflow_bodytoolOutputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RunToolOutputsPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunCancelPostResponse> RunCancel(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_runId = runId == null ? null : WorkflowExpression.Compile(runId);
            WorkflowExpression.Validate(__workflow_runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunCancelPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/cancel", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunCancelPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadRunPostResponse> ThreadRun(Expression<Func<string>> openAIBeta, Expression<Func<string>> bodyassistantId = null, Expression<Func<bodythreadmessagesInputItem[]>> bodythreadmessages = null, Expression<Func<string>> bodymodel = null, Expression<Func<string>> bodyinstructions = null, Expression<Func<bodytoolsInputItem[]>> bodytools = null)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_bodyassistantId = bodyassistantId == null ? null : WorkflowExpression.Compile(bodyassistantId);
            WorkflowExpression.Validate(__workflow_bodyassistantId, nameof(bodyassistantId), required: false);
            var __workflow_bodythreadmessages = bodythreadmessages == null ? null : WorkflowExpression.Compile(bodythreadmessages);
            WorkflowExpression.Validate(__workflow_bodythreadmessages, nameof(bodythreadmessages), required: false);
            var __workflow_bodymodel = bodymodel == null ? null : WorkflowExpression.Compile(bodymodel);
            WorkflowExpression.Validate(__workflow_bodymodel, nameof(bodymodel), required: false);
            var __workflow_bodyinstructions = bodyinstructions == null ? null : WorkflowExpression.Compile(bodyinstructions);
            WorkflowExpression.Validate(__workflow_bodyinstructions, nameof(bodyinstructions), required: false);
            var __workflow_bodytools = bodytools == null ? null : WorkflowExpression.Compile(bodytools);
            WorkflowExpression.Validate(__workflow_bodytools, nameof(bodytools), required: false);
            return new DeferredBodyAction<ThreadRunPostResponse>(() =>
            {
                var apiCallPath = "/threads/runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassistantId != null)
                {
                    body["assistant_id"] = ExpressionConverter.ConvertO(__workflow_bodyassistantId);
                    bodypropCount++;
                }

                var threadObject = new JObject();
                var threadObjectpropCount = 0;
                if (__workflow_bodythreadmessages != null)
                {
                    threadObject["messages"] = ExpressionConverter.ConvertO(__workflow_bodythreadmessages);
                    threadObjectpropCount++;
                }

                if (threadObjectpropCount > 0)
                {
                    body["thread"] = threadObject;
                    bodypropCount++;
                }

                if (__workflow_bodymodel != null)
                {
                    body["model"] = ExpressionConverter.ConvertO(__workflow_bodymodel);
                    bodypropCount++;
                }

                if (__workflow_bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                    bodypropCount++;
                }

                if (__workflow_bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(__workflow_bodytools);
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ThreadRunPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunStepGetResponse> RunStepGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId, Expression<Func<string>> stepId)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_runId = runId == null ? null : WorkflowExpression.Compile(runId);
            WorkflowExpression.Validate(__workflow_runId, nameof(runId), required: true);
            var __workflow_stepId = stepId == null ? null : WorkflowExpression.Compile(stepId);
            WorkflowExpression.Validate(__workflow_stepId, nameof(stepId), required: true);
            return new DeferredBodyAction<RunStepGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/steps/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_runId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_stepId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunStepGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunStepsGetResponse> RunStepsGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId, Expression<Func<int>> limit = null, Expression<Func<string>> order = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_openAIBeta = openAIBeta == null ? null : WorkflowExpression.Compile(openAIBeta);
            WorkflowExpression.Validate(__workflow_openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = threadId == null ? null : WorkflowExpression.Compile(threadId);
            WorkflowExpression.Validate(__workflow_threadId, nameof(threadId), required: true);
            var __workflow_runId = runId == null ? null : WorkflowExpression.Compile(runId);
            WorkflowExpression.Validate(__workflow_runId, nameof(runId), required: true);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_order = order == null ? null : WorkflowExpression.Compile(order);
            WorkflowExpression.Validate(__workflow_order, nameof(order), required: false);
            var __workflow_after = after == null ? null : WorkflowExpression.Compile(after);
            WorkflowExpression.Validate(__workflow_after, nameof(after), required: false);
            var __workflow_before = before == null ? null : WorkflowExpression.Compile(before);
            WorkflowExpression.Validate(__workflow_before, nameof(before), required: false);
            return new DeferredBodyAction<RunStepsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/steps", ExpressionConverter.ConvertWithUrlEncoding(__workflow_threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunStepsGetResponse>(callPayload);
            });
        }
    }

    public class OpenaiassistantsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ModelsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public ModelsGetResponseDataTypeItem[] Data { get; set; }
    }

    public class ModelsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("owned_by")]
        public string OwnedBy { get; set; }
    }

    public class AssistantsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public AssistantsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class AssistantsGetResponseDataTypeItem
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
        public AssistantsGetResponseDataTypeItemToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class AssistantsGetResponseDataTypeItemToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AssistantPostResponse
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
        public AssistantPostResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class AssistantPostResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public AssistantPostResponseToolsTypeItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssistantPostResponseToolsTypeItemTypeType
    {
        [EnumMember(Value = "code_interpreter")]
        CodeInterpreter,
        [EnumMember(Value = "retrieval")]
        Retrieval,
        [EnumMember(Value = "function")]
        Function
    }

    public class bodytoolsInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AssistantGetResponse
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
        public AssistantGetResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class AssistantGetResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AssistantDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class FilesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public FilesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class FilesGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }
    }

    public class FilePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }
    }

    public class FileGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }
    }

    public class FileDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class ThreadPostResponse
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

    public class bodymessagesInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ThreadGetResponse
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

    public class ThreadDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class ThreadModifyPostResponse
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

    public class MessagesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public MessagesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class MessagesGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public MessagesGetResponseDataTypeItemContentTypeItem[] Content { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MessagesGetResponseDataTypeItemContentTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public MessagesGetResponseDataTypeItemContentTypeItemTextType Text { get; set; }
    }

    public class MessagesGetResponseDataTypeItemContentTypeItemTextType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("annotations")]
        public string[] Annotations { get; set; }
    }

    public class MessagePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public MessagePostResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MessagePostResponseContentTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public MessagePostResponseContentTypeItemTextType Text { get; set; }
    }

    public class MessagePostResponseContentTypeItemTextType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("annotations")]
        public string[] Annotations { get; set; }
    }

    public class MessageModifyPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public MessageModifyPostResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MessageModifyPostResponseContentTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public MessageModifyPostResponseContentTypeItemTextType Text { get; set; }
    }

    public class MessageModifyPostResponseContentTypeItemTextType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("annotations")]
        public string[] Annotations { get; set; }
    }

    public class MessageFileGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }
    }

    public class MessageFilesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public MessageFilesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class MessageFilesGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }
    }

    public class RunsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public RunsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class RunsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public RunsGetResponseDataTypeItemToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunsGetResponseDataTypeItemToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RunPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public RunPostResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunPostResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RunGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public RunGetResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunGetResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RunModifyPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public RunModifyPostResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunModifyPostResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RunToolOutputsPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public RunToolOutputsPostResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunToolOutputsPostResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("function")]
        public RunToolOutputsPostResponseToolsTypeItemFunctionType Function { get; set; }
    }

    public class RunToolOutputsPostResponseToolsTypeItemFunctionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parameters")]
        public RunToolOutputsPostResponseToolsTypeItemFunctionTypeParametersType Parameters { get; set; }
    }

    public class RunToolOutputsPostResponseToolsTypeItemFunctionTypeParametersType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class bodytoolOutputsInputItem
    {
        [JsonProperty("tool_call_id")]
        public string ToolCallId { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }
    }

    public class RunCancelPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public RunCancelPostResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunCancelPostResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ThreadRunPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public ThreadRunPostResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ThreadRunPostResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodythreadmessagesInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class RunStepGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("expired_at")]
        public string ExpiredAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("step_details")]
        public RunStepGetResponseStepDetailsType StepDetails { get; set; }
    }

    public class RunStepGetResponseStepDetailsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message_creation")]
        public RunStepGetResponseStepDetailsTypeMessageCreationType MessageCreation { get; set; }
    }

    public class RunStepGetResponseStepDetailsTypeMessageCreationType
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
    }

    public class RunStepsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public RunStepsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class RunStepsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("expired_at")]
        public string ExpiredAt { get; set; }

        [JsonProperty("failed_at")]
        public string FailedAt { get; set; }

        [JsonProperty("last_error")]
        public string LastError { get; set; }

        [JsonProperty("step_details")]
        public RunStepsGetResponseDataTypeItemStepDetailsType StepDetails { get; set; }
    }

    public class RunStepsGetResponseDataTypeItemStepDetailsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("message_creation")]
        public RunStepsGetResponseDataTypeItemStepDetailsTypeMessageCreationType MessageCreation { get; set; }
    }

    public class RunStepsGetResponseDataTypeItemStepDetailsTypeMessageCreationType
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openaiassistants;

    public partial class WorkflowManagedActions
    {
        public OpenaiassistantsActions Openaiassistants(string connectionId) => new OpenaiassistantsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenaiassistantsTriggers Openaiassistants(string connectionId) => new OpenaiassistantsTriggers(connectionId);
    }
}
