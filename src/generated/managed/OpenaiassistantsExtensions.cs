//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openaiassistants
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenaiassistantsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ModelsGetResponse> ModelsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantsGetResponse> AssistantsGet([WorkflowExpression] Func<string> openAIBeta)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<AssistantsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantPostResponse> Assistant([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null, [WorkflowExpression] Func<string[]> bodyfileIds = null)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(bodymodel, nameof(bodymodel), required: true);
            SourceExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodytools, nameof(bodytools), required: false);
            SourceExpression.Validate(bodyfileIds, nameof(bodyfileIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = SourceExpressionConverter.ConvertToken(bodytools);
                    bodypropCount++;
                }

                if (bodyfileIds != null)
                {
                    body["file_ids"] = SourceExpressionConverter.ConvertToken(bodyfileIds);
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
                return callPayload;
            }

            return new ApiConnectionAction<AssistantPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantGetResponse> AssistantGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(assistantId, nameof(assistantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/assistants/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<AssistantGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<AssistantDeleteResponse> AssistantDelete([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(assistantId, nameof(assistantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/assistants/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<AssistantDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FilesGetResponse> FilesGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(assistantId, nameof(assistantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<FilesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FilePostResponse> File([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId, [WorkflowExpression] Func<string> bodyfileId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(assistantId, nameof(assistantId), required: true);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assistantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FilePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FileGetResponse> FileGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(assistantId, nameof(assistantId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assistantId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<FileGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<FileDeleteResponse> FileDelete([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> assistantId, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(assistantId, nameof(assistantId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/assistants/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assistantId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<FileDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadPostResponse> Thread([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(bodymessages, nameof(bodymessages), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["messages"] = SourceExpressionConverter.ConvertToken(bodymessages);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ThreadPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadGetResponse> ThreadGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<ThreadGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadDeleteResponse> ThreadDelete([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<ThreadDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadModifyPostResponse> ThreadModify([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
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
                return callPayload;
            }

            return new ApiConnectionAction<ThreadModifyPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessagesGetResponse> MessagesGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<MessagesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessagePostResponse> Message([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<MessagePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageModifyPostResponse> MessageModify([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
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
                return callPayload;
            }

            return new ApiConnectionAction<MessageModifyPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageFileGetResponse> MessageFileGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}/files/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<MessageFileGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<MessageFilesGetResponse> MessageFilesGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/messages/{1}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<MessageFilesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunsGetResponse> RunsGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<RunsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunPostResponse> Run([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> bodymodel, [WorkflowExpression] Func<string> bodyassistantId = null, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(bodymodel, nameof(bodymodel), required: true);
            SourceExpression.Validate(bodyassistantId, nameof(bodyassistantId), required: false);
            SourceExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            SourceExpression.Validate(bodytools, nameof(bodytools), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassistantId != null)
                {
                    body["assistant_id"] = SourceExpressionConverter.ConvertToken(bodyassistantId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = SourceExpressionConverter.ConvertToken(bodytools);
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
                return callPayload;
            }

            return new ApiConnectionAction<RunPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunGetResponse> RunGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(runId, nameof(runId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<RunGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunModifyPostResponse> RunModify([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(runId, nameof(runId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
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
                return callPayload;
            }

            return new ApiConnectionAction<RunModifyPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunToolOutputsPostResponse> RunToolOutputs([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<bodytoolOutputsInputItem[]> bodytoolOutputs = null)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(runId, nameof(runId), required: true);
            SourceExpression.Validate(bodytoolOutputs, nameof(bodytoolOutputs), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/submit_tool_outputs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytoolOutputs != null)
                {
                    body["tool_outputs"] = SourceExpressionConverter.ConvertToken(bodytoolOutputs);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunToolOutputsPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunCancelPostResponse> RunCancel([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(runId, nameof(runId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<RunCancelPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<ThreadRunPostResponse> ThreadRun([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> bodyassistantId = null, [WorkflowExpression] Func<bodythreadmessagesInputItem[]> bodythreadmessages = null, [WorkflowExpression] Func<string> bodymodel = null, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<bodytoolsInputItem[]> bodytools = null)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(bodyassistantId, nameof(bodyassistantId), required: false);
            SourceExpression.Validate(bodythreadmessages, nameof(bodythreadmessages), required: false);
            SourceExpression.Validate(bodymodel, nameof(bodymodel), required: false);
            SourceExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            SourceExpression.Validate(bodytools, nameof(bodytools), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threads/runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassistantId != null)
                {
                    body["assistant_id"] = SourceExpressionConverter.ConvertToken(bodyassistantId);
                    bodypropCount++;
                }

                var threadObject = new JObject();
                var threadObjectpropCount = 0;
                if (bodythreadmessages != null)
                {
                    threadObject["messages"] = SourceExpressionConverter.ConvertToken(bodythreadmessages);
                    threadObjectpropCount++;
                }

                if (threadObjectpropCount > 0)
                {
                    body["thread"] = threadObject;
                    bodypropCount++;
                }

                if (bodymodel != null)
                {
                    body["model"] = SourceExpressionConverter.ConvertToken(bodymodel);
                    bodypropCount++;
                }

                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                if (bodytools != null)
                {
                    body["tools"] = SourceExpressionConverter.ConvertToken(bodytools);
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
                return callPayload;
            }

            return new ApiConnectionAction<ThreadRunPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunStepGetResponse> RunStepGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<string> stepId)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(runId, nameof(runId), required: true);
            SourceExpression.Validate(stepId, nameof(stepId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/steps/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<RunStepGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openaiassistants")]
        public IBodyWorkflowAction<RunStepsGetResponse> RunStepsGet([WorkflowExpression] Func<string> openAIBeta, [WorkflowExpression] Func<string> threadId, [WorkflowExpression] Func<string> runId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<string> before = null)
        {
            SourceExpression.Validate(openAIBeta, nameof(openAIBeta), required: true);
            SourceExpression.Validate(threadId, nameof(threadId), required: true);
            SourceExpression.Validate(runId, nameof(runId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(after, nameof(after), required: false);
            SourceExpression.Validate(before, nameof(before), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/threads/{0}/runs/{1}/steps", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(threadId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(runId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                callPayload.Headers["OpenAI-Beta"] = SourceExpressionConverter.ConvertO(openAIBeta);
                return callPayload;
            }

            return new ApiConnectionAction<RunStepsGetResponse>(BuildSourceInput);
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