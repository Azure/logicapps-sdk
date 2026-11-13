//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaiassistants
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenaiassistantsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ModelsGetResponse, ApiConnectionActionConfiguration> ModelsGet()
        {
            return new DeferredBodyAction<ModelsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantsGetResponse, ApiConnectionActionConfiguration> AssistantsGet(Expression<Func<string>> openAIBeta)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            return new DeferredBodyAction<AssistantsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<AssistantsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantResponse, ApiConnectionActionConfiguration> Assistant(Expression<Func<string>> openAIBeta, Expression<Func<AssistantBodyInput>> body = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AssistantResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new AssistantBodyInput().ToJToken();
                return new ApiConnectionAction<AssistantResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantGetResponse, ApiConnectionActionConfiguration> AssistantGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = WorkflowExpression.Compile(assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<AssistantGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assistants/{0}", __workflow_assistantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<AssistantGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantDeleteResponse, ApiConnectionActionConfiguration> AssistantDelete(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = WorkflowExpression.Compile(assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<AssistantDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assistants/{0}", __workflow_assistantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<AssistantDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FilesGetResponse, ApiConnectionActionConfiguration> FilesGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = WorkflowExpression.Compile(assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<FilesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assistants/{0}/files", __workflow_assistantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<FilesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FileResponse, ApiConnectionActionConfiguration> File(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId, Expression<Func<FileBodyInput>> body)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = WorkflowExpression.Compile(assistantId, nameof(assistantId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assistants/{0}/files", __workflow_assistantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FileGetResponse, ApiConnectionActionConfiguration> FileGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId, Expression<Func<string>> fileId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = WorkflowExpression.Compile(assistantId, nameof(assistantId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<FileGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assistants/{0}/files/{1}", __workflow_assistantId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<FileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FileDeleteResponse, ApiConnectionActionConfiguration> FileDelete(Expression<Func<string>> openAIBeta, Expression<Func<string>> assistantId, Expression<Func<string>> fileId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_assistantId = WorkflowExpression.Compile(assistantId, nameof(assistantId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<FileDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/assistants/{0}/files/{1}", __workflow_assistantId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<FileDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadResponse, ApiConnectionActionConfiguration> Thread(Expression<Func<string>> openAIBeta, Expression<Func<ThreadBodyInput>> body)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadGetResponse, ApiConnectionActionConfiguration> ThreadGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<ThreadGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadDeleteResponse, ApiConnectionActionConfiguration> ThreadDelete(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<ThreadDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadModifyResponse, ApiConnectionActionConfiguration> ThreadModify(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<MessageModifyBodyInput>> body = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ThreadModifyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ThreadModifyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessagesGetResponse, ApiConnectionActionConfiguration> MessagesGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<int>> limit = null, Expression<Func<string>> order = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<MessagesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/messages", __workflow_threadId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<MessageResponse, ApiConnectionActionConfiguration> Message(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<MessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/messages", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<MessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageModifyResponse, ApiConnectionActionConfiguration> MessageModify(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> messageId, Expression<Func<MessageModifyBodyInput>> body = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MessageModifyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/messages/{1}", __workflow_threadId.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MessageModifyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageFileGetResponse, ApiConnectionActionConfiguration> MessageFileGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> messageId, Expression<Func<string>> fileId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<MessageFileGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/messages/{1}/files/{2}", __workflow_threadId.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<MessageFileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageFilesGetResponse, ApiConnectionActionConfiguration> MessageFilesGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> messageId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageFilesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/messages/{1}/files", __workflow_threadId.WithUrlEncoding(1), __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<MessageFilesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunsGetResponse, ApiConnectionActionConfiguration> RunsGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<int>> limit = null, Expression<Func<string>> order = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<RunsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs", __workflow_threadId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<RunResponse, ApiConnectionActionConfiguration> Run(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<RunBodyInput>> body)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunGetResponse, ApiConnectionActionConfiguration> RunGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunModifyResponse, ApiConnectionActionConfiguration> RunModify(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId, Expression<Func<MessageModifyBodyInput>> body = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RunModifyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunModifyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunToolOutputsResponse, ApiConnectionActionConfiguration> RunToolOutputs(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId, Expression<Func<RunToolOutputsBodyInput>> body = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RunToolOutputsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}/submit_tool_outputs", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunToolOutputsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunCancelResponse, ApiConnectionActionConfiguration> RunCancel(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunCancelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}/cancel", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunCancelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadRunResponse, ApiConnectionActionConfiguration> ThreadRun(Expression<Func<string>> openAIBeta, Expression<Func<ThreadRunBodyInput>> body = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ThreadRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threads/runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ThreadRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunStepGetResponse, ApiConnectionActionConfiguration> RunStepGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId, Expression<Func<string>> stepId)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            return new DeferredBodyAction<RunStepGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}/steps/{2}", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1), __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(__workflow_openAIBeta);
                return new ApiConnectionAction<RunStepGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunStepsGetResponse, ApiConnectionActionConfiguration> RunStepsGet(Expression<Func<string>> openAIBeta, Expression<Func<string>> threadId, Expression<Func<string>> runId, Expression<Func<int>> limit = null, Expression<Func<string>> order = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_openAIBeta = WorkflowExpression.Compile(openAIBeta, nameof(openAIBeta), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<RunStepsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}/steps", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
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

    public class AssistantResponse
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
        public AssistantResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class AssistantResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public AssistantResponseToolsTypeItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssistantResponseToolsTypeItemTypeType
    {
        [EnumMember(Value = "code_interpreter")]
        CodeInterpreter,
        [EnumMember(Value = "retrieval")]
        Retrieval,
        [EnumMember(Value = "function")]
        Function
    }

    public class AssistantBodyInput
    {
        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; } = "gpt-4-1106-preview";

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tools")]
        public BodyInputToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class BodyInputToolsTypeItem
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

    public class FileResponse
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

    public class FileBodyInput
    {
        public FileBodyInput(string fileId)
        {
            this.FileId = fileId;
        }

        [JsonProperty("file_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileId { get; set; }
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

    public class ThreadResponse
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

    public class ThreadBodyInput
    {
        public ThreadBodyInput(BodyInputMessagesTypeItem[] messages)
        {
            this.Messages = messages;
        }

        [JsonProperty("messages", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputMessagesTypeItem[] Messages { get; set; }
    }

    public class BodyInputMessagesTypeItem
    {
        public BodyInputMessagesTypeItem(string role, string content)
        {
            this.Role = role;
            this.Content = content;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class ThreadModifyResponse
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

    public class MessageModifyBodyInput
    {
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

    public class MessageResponse
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
        public MessageResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MessageResponseContentTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public MessageResponseContentTypeItemTextType Text { get; set; }
    }

    public class MessageResponseContentTypeItemTextType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("annotations")]
        public string[] Annotations { get; set; }
    }

    public class MessageModifyResponse
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
        public MessageModifyResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("run_id")]
        public string RunId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MessageModifyResponseContentTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public MessageModifyResponseContentTypeItemTextType Text { get; set; }
    }

    public class MessageModifyResponseContentTypeItemTextType
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

    public class RunResponse
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
        public RunResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RunBodyInput
    {
        public RunBodyInput(string model)
        {
            this.Model = model;
        }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public BodyInputToolsTypeItem[] Tools { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
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

    public class RunModifyResponse
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
        public RunModifyResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunModifyResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RunToolOutputsResponse
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
        public RunToolOutputsResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunToolOutputsResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("function")]
        public RunToolOutputsResponseToolsTypeItemFunctionType Function { get; set; }
    }

    public class RunToolOutputsResponseToolsTypeItemFunctionType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parameters")]
        public RunToolOutputsResponseToolsTypeItemFunctionTypeParametersType Parameters { get; set; }
    }

    public class RunToolOutputsResponseToolsTypeItemFunctionTypeParametersType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class RunToolOutputsBodyInput
    {
        [JsonProperty("tool_outputs")]
        public BodyInputToolOutputsTypeItem[] ToolOutputs { get; set; }
    }

    public class BodyInputToolOutputsTypeItem
    {
        [JsonProperty("tool_call_id")]
        public string ToolCallId { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }
    }

    public class RunCancelResponse
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
        public RunCancelResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class RunCancelResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ThreadRunResponse
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
        public ThreadRunResponseToolsTypeItem[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public string[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ThreadRunResponseToolsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ThreadRunBodyInput
    {
        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("thread")]
        public BodyInputThreadType Thread { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public BodyInputToolsTypeItem[] Tools { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class BodyInputThreadType
    {
        [JsonProperty("messages")]
        public BodyInputThreadTypeMessagesTypeItem[] Messages { get; set; }
    }

    public class BodyInputThreadTypeMessagesTypeItem
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