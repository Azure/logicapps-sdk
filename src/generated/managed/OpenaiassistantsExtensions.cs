//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaiassistants
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildAssistantsGet))]
        public IBodyWorkflowAction<AssistantsGetResponse> AssistantsGet([WorkflowExpression] Func<string> openAIBeta)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssistantsGetResponse> __BuildAssistantsGet(WorkflowExpression<string> openAIBeta)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            return new DeferredBodyAction<AssistantsGetResponse>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<AssistantsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildAssistant))]
        public IBodyWorkflowAction<AssistantPostResponse> Assistant([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null, [WorkflowExpression] Func<string[]> bodyfileIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssistantPostResponse> __BuildAssistant(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> bodymodel, WorkflowExpression<string> bodyinstructions = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<bodytoolsInputItem[]> bodytools = null, WorkflowExpression<string[]> bodyfileIds = null)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: true);
            WorkflowExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodytools, nameof(bodytools), required: false);
            WorkflowExpression.Validate(bodyfileIds, nameof(bodyfileIds), required: false);
            return new DeferredBodyAction<AssistantPostResponse>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                if (bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(bodyinstructions);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(bodytools);
                    bodypropCount++;
                }

                if (bodyfileIds != null)
                {
                    body["file_ids"] = ExpressionConverter.ConvertO(bodyfileIds);
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
        [WorkflowExpressionFactory(nameof(__BuildAssistantGet))]
        public IBodyWorkflowAction<AssistantGetResponse> AssistantGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssistantGetResponse> __BuildAssistantGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> assistantId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<AssistantGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}", ExpressionConverter.ConvertWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<AssistantGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildAssistantDelete))]
        public IBodyWorkflowAction<AssistantDeleteResponse> AssistantDelete([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssistantDeleteResponse> __BuildAssistantDelete(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> assistantId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<AssistantDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}", ExpressionConverter.ConvertWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<AssistantDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildFilesGet))]
        public IBodyWorkflowAction<FilesGetResponse> FilesGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilesGetResponse> __BuildFilesGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> assistantId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(assistantId, nameof(assistantId), required: true);
            return new DeferredBodyAction<FilesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<FilesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildFile))]
        public IBodyWorkflowAction<FilePostResponse> File([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId, [WorkflowExpression] Func<string> bodyfileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilePostResponse> __BuildFile(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> assistantId, WorkflowExpression<string> bodyfileId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(assistantId, nameof(assistantId), required: true);
            WorkflowExpression.Validate(bodyfileId, nameof(bodyfileId), required: true);
            return new DeferredBodyAction<FilePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_id"] = ExpressionConverter.ConvertO(bodyfileId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FilePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildFileGet))]
        public IBodyWorkflowAction<FileGetResponse> FileGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId, [WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FileGetResponse> __BuildFileGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> assistantId, WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(assistantId, nameof(assistantId), required: true);
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<FileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(assistantId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<FileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildFileDelete))]
        public IBodyWorkflowAction<FileDeleteResponse> FileDelete([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId, [WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FileDeleteResponse> __BuildFileDelete(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> assistantId, WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(assistantId, nameof(assistantId), required: true);
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<FileDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(assistantId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<FileDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildThread))]
        public IBodyWorkflowAction<ThreadPostResponse> Thread([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThreadPostResponse> __BuildThread(WorkflowExpression<string> openAIBeta, WorkflowExpression<bodymessagesInputItem[]> bodymessages)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            return new DeferredBodyAction<ThreadPostResponse>(() =>
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = ExpressionConverter.ConvertO(bodymessages);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ThreadPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildThreadGet))]
        public IBodyWorkflowAction<ThreadGetResponse> ThreadGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThreadGetResponse> __BuildThreadGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<ThreadGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildThreadDelete))]
        public IBodyWorkflowAction<ThreadDeleteResponse> ThreadDelete([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThreadDeleteResponse> __BuildThreadDelete(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<ThreadDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildThreadModify))]
        public IBodyWorkflowAction<ThreadModifyPostResponse> ThreadModify([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThreadModifyPostResponse> __BuildThreadModify(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ThreadModifyPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
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
        [WorkflowExpressionFactory(nameof(__BuildMessagesGet))]
        public IBodyWorkflowAction<MessagesGetResponse> MessagesGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessagesGetResponse> __BuildMessagesGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<int> limit = null, WorkflowExpression<string> order = null, WorkflowExpression<string> after = null, WorkflowExpression<string> before = null)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(before, nameof(before), required: false);
            return new DeferredBodyAction<MessagesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<MessagesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildMessage))]
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessagePostResponse> __BuildMessage(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<MessagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<MessagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildMessageModify))]
        public IBodyWorkflowAction<MessageModifyPostResponse> MessageModify([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageModifyPostResponse> __BuildMessageModify(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageModifyPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
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
        [WorkflowExpressionFactory(nameof(__BuildMessageFileGet))]
        public IBodyWorkflowAction<MessageFileGetResponse> MessageFileGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageFileGetResponse> __BuildMessageFileGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> messageId, WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<MessageFileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}/files/{2}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<MessageFileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildMessageFilesGet))]
        public IBodyWorkflowAction<MessageFilesGetResponse> MessageFilesGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageFilesGetResponse> __BuildMessageFilesGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageFilesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<MessageFilesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildRunsGet))]
        public IBodyWorkflowAction<RunsGetResponse> RunsGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunsGetResponse> __BuildRunsGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<int> limit = null, WorkflowExpression<string> order = null, WorkflowExpression<string> after = null, WorkflowExpression<string> before = null)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(before, nameof(before), required: false);
            return new DeferredBodyAction<RunsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<RunsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildRun))]
        public IBodyWorkflowAction<RunPostResponse> Run([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<string> bodyassistantId = null, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunPostResponse> __BuildRun(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> bodymodel, WorkflowExpression<string> bodyassistantId = null, WorkflowExpression<string> bodyinstructions = null, WorkflowExpression<bodytoolsInputItem[]> bodytools = null)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: true);
            WorkflowExpression.Validate(bodyassistantId, nameof(bodyassistantId), required: false);
            WorkflowExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            WorkflowExpression.Validate(bodytools, nameof(bodytools), required: false);
            return new DeferredBodyAction<RunPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassistantId != null)
                {
                    body["assistant_id"] = ExpressionConverter.ConvertO(bodyassistantId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["model"] = ExpressionConverter.ConvertO(bodymodel);
                if (bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(bodyinstructions);
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(bodytools);
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
        [WorkflowExpressionFactory(nameof(__BuildRunGet))]
        public IBodyWorkflowAction<RunGetResponse> RunGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunGetResponse> __BuildRunGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> runId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<RunGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildRunModify))]
        public IBodyWorkflowAction<RunModifyPostResponse> RunModify([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunModifyPostResponse> __BuildRunModify(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> runId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunModifyPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
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
        [WorkflowExpressionFactory(nameof(__BuildRunToolOutputs))]
        public IBodyWorkflowAction<RunToolOutputsPostResponse> RunToolOutputs([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<bodytoolOutputsInputItem[]> bodytoolOutputs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunToolOutputsPostResponse> __BuildRunToolOutputs(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> runId, WorkflowExpression<bodytoolOutputsInputItem[]> bodytoolOutputs = null)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(runId, nameof(runId), required: true);
            WorkflowExpression.Validate(bodytoolOutputs, nameof(bodytoolOutputs), required: false);
            return new DeferredBodyAction<RunToolOutputsPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/submit_tool_outputs", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytoolOutputs != null)
                {
                    body["tool_outputs"] = ExpressionConverter.ConvertO(bodytoolOutputs);
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
        [WorkflowExpressionFactory(nameof(__BuildRunCancel))]
        public IBodyWorkflowAction<RunCancelPostResponse> RunCancel([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunCancelPostResponse> __BuildRunCancel(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> runId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(runId, nameof(runId), required: true);
            return new DeferredBodyAction<RunCancelPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/cancel", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<RunCancelPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildThreadRun))]
        public IBodyWorkflowAction<ThreadRunPostResponse> ThreadRun([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> bodyassistantId = null, [WorkflowExpression] Func<bodythreadmessagesInputItem[]> bodythreadmessages = null, [WorkflowExpression] Func<string> bodymodel = null, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThreadRunPostResponse> __BuildThreadRun(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> bodyassistantId = null, WorkflowExpression<bodythreadmessagesInputItem[]> bodythreadmessages = null, WorkflowExpression<string> bodymodel = null, WorkflowExpression<string> bodyinstructions = null, WorkflowExpression<bodytoolsInputItem[]> bodytools = null)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(bodyassistantId, nameof(bodyassistantId), required: false);
            WorkflowExpression.Validate(bodythreadmessages, nameof(bodythreadmessages), required: false);
            WorkflowExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            WorkflowExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            WorkflowExpression.Validate(bodytools, nameof(bodytools), required: false);
            return new DeferredBodyAction<ThreadRunPostResponse>(() =>
            {
                var apiCallPath = "/threads/runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassistantId != null)
                {
                    body["assistant_id"] = ExpressionConverter.ConvertO(bodyassistantId);
                    bodypropCount++;
                }

                var threadObject = new JObject();
                var threadObjectpropCount = 0;
                if (bodythreadmessages != null)
                {
                    threadObject["messages"] = ExpressionConverter.ConvertO(bodythreadmessages);
                    threadObjectpropCount++;
                }

                if (threadObjectpropCount > 0)
                {
                    body["thread"] = threadObject;
                    bodypropCount++;
                }

                if (bodymodel != null)
                {
                    body["model"] = ExpressionConverter.ConvertO(bodymodel);
                    bodypropCount++;
                }

                if (bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(bodyinstructions);
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = ExpressionConverter.ConvertO(bodytools);
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
        [WorkflowExpressionFactory(nameof(__BuildRunStepGet))]
        public IBodyWorkflowAction<RunStepGetResponse> RunStepGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<string> stepId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunStepGetResponse> __BuildRunStepGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> runId, WorkflowExpression<string> stepId)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(runId, nameof(runId), required: true);
            WorkflowExpression.Validate(stepId, nameof(stepId), required: true);
            return new DeferredBodyAction<RunStepGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/steps/{2}", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(runId, 1), ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
                return new ApiConnectionAction<RunStepGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        [WorkflowExpressionFactory(nameof(__BuildRunStepsGet))]
        public IBodyWorkflowAction<RunStepsGetResponse> RunStepsGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunStepsGetResponse> __BuildRunStepsGet(WorkflowExpression<string> openAIBeta, WorkflowExpression<string> threadId, WorkflowExpression<string> runId, WorkflowExpression<int> limit = null, WorkflowExpression<string> order = null, WorkflowExpression<string> after = null, WorkflowExpression<string> before = null)
        {
            WorkflowExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            WorkflowExpression.Validate(threadId, nameof(threadId), required: true);
            WorkflowExpression.Validate(runId, nameof(runId), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(before, nameof(before), required: false);
            return new DeferredBodyAction<RunStepsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/steps", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1), ExpressionConverter.ConvertWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                callPayload.Headers["OpenAI-Beta"] = ExpressionConverter.Convert(openAIBeta);
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