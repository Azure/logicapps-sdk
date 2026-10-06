//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yeeflow
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YeeflowActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildAddItem))]
        public IBodyWorkflowAction<AddItemResponse> AddItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<object> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddItemResponse> __BuildAddItem(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<object> bodydata = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<AddItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["Data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<GetItemResponse> GetItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetItemResponse> __BuildGetItem(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                return new ApiConnectionAction<GetItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IBodyWorkflowAction<DeleteItemResponse> DeleteItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteItemResponse> __BuildDeleteItem(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<DeleteItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                return new ApiConnectionAction<DeleteItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateItem))]
        public IBodyWorkflowAction<UpdateItemResponse> UpdateItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> bodyrowVersion = null, [WorkflowExpression] Func<object> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateItemResponse> __BuildUpdateItem(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<string> id, WorkflowExpression<int> bodyrowVersion = null, WorkflowExpression<object> bodydata = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyrowVersion, nameof(bodyrowVersion), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<UpdateItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrowVersion != null)
                {
                    body["RowVersion"] = ExpressionConverter.ConvertO(bodyrowVersion);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["Data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildGetListFields))]
        public IBodyWorkflowAction<GetListFieldsResponse> GetListFields([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetListFieldsResponse> __BuildGetListFields(WorkflowExpression<string> application, WorkflowExpression<string> listID)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            return new DeferredBodyAction<GetListFieldsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                return new ApiConnectionAction<GetListFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildStartWorkflow))]
        public IBodyWorkflowAction<StartWorkflowResponse> StartWorkflow([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> bodyapplicantID = null, [WorkflowExpression] Func<object> bodyvariables = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartWorkflowResponse> __BuildStartWorkflow(WorkflowExpression<string> application, WorkflowExpression<string> key, WorkflowExpression<string> bodyapplicantID = null, WorkflowExpression<object> bodyvariables = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(bodyapplicantID, nameof(bodyapplicantID), required: false);
            WorkflowExpression.Validate(bodyvariables, nameof(bodyvariables), required: false);
            return new DeferredBodyAction<StartWorkflowResponse>(() =>
            {
                var apiCallPath = "/workflow/forms/start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                callPayload.Queries["key"] = ExpressionConverter.Convert(key);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantID != null)
                {
                    body["ApplicantID"] = ExpressionConverter.ConvertO(bodyapplicantID);
                    bodypropCount++;
                }

                if (bodyvariables != null)
                {
                    body["Variables"] = ExpressionConverter.ConvertO(bodyvariables);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StartWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildGetAgentDefinition))]
        public IBodyWorkflowAction<GetAgentDefinitionResponse> GetAgentDefinition([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> agentID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAgentDefinitionResponse> __BuildGetAgentDefinition(WorkflowExpression<string> application, WorkflowExpression<string> agentID)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(agentID, nameof(agentID), required: true);
            return new DeferredBodyAction<GetAgentDefinitionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/agents/{0}", ExpressionConverter.ConvertWithUrlEncoding(agentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                return new ApiConnectionAction<GetAgentDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildRunAgent))]
        public IBodyWorkflowAction<RunAgentResponse> RunAgent([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> agentID, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RunAgentResponse> __BuildRunAgent(WorkflowExpression<string> application, WorkflowExpression<string> agentID, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(agentID, nameof(agentID), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<RunAgentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/agents/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(agentID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<RunAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildQueryItems))]
        public IBodyWorkflowAction<QueryItemsResponse> QueryItems([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string[]> bodyfields = null, [WorkflowExpression] Func<ListDataWhereRequest[]> bodyfilters = null, [WorkflowExpression] Func<bodysortsInputItem[]> bodysorts = null, [WorkflowExpression] Func<int> bodypageNumber = null, [WorkflowExpression] Func<int> bodypageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryItemsResponse> __BuildQueryItems(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<string[]> bodyfields = null, WorkflowExpression<ListDataWhereRequest[]> bodyfilters = null, WorkflowExpression<bodysortsInputItem[]> bodysorts = null, WorkflowExpression<int> bodypageNumber = null, WorkflowExpression<int> bodypageSize = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            WorkflowExpression.Validate(bodyfilters, nameof(bodyfilters), required: false);
            WorkflowExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            WorkflowExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            WorkflowExpression.Validate(bodypageSize, nameof(bodypageSize), required: false);
            return new DeferredBodyAction<QueryItemsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/query", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfields != null)
                {
                    body["Fields"] = ExpressionConverter.ConvertO(bodyfields);
                    bodypropCount++;
                }

                if (bodyfilters != null)
                {
                    body["Filters"] = ExpressionConverter.ConvertO(bodyfilters);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["Sorts"] = ExpressionConverter.ConvertO(bodysorts);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    if (bodypageNumber != null)
                    {
                        body["PageIndex"] = ExpressionConverter.ConvertO(bodypageNumber);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["PageIndex"] = 1;
                    bodypropCount++;
                }

                if (bodypageSize != null)
                {
                    if (bodypageSize != null)
                    {
                        body["PageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["PageSize"] = 10;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildAddItemFile))]
        public IBodyWorkflowAction<AddItemFileResponse> AddItemFile([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> fieldID = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddItemFileResponse> __BuildAddItemFile(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<string> id, WorkflowExpression<string> fileName, WorkflowExpression<string> fieldID = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(fieldID, nameof(fieldID), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AddItemFileResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                if (fieldID != null)
                    callPayload.Queries["FieldID"] = ExpressionConverter.Convert(fieldID);
                callPayload.Queries["FileName"] = ExpressionConverter.Convert(fileName);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AddItemFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFile))]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFileResponse> __BuildUploadFile(WorkflowExpression<string> fileName, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<UploadFileResponse>(() =>
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileName"] = ExpressionConverter.Convert(fileName);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<UploadFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileProperty))]
        public IBodyWorkflowAction<GetFilePropertyResponse> GetFileProperty([WorkflowExpression] Func<string> fieldValue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFilePropertyResponse> __BuildGetFileProperty(WorkflowExpression<string> fieldValue = null)
        {
            WorkflowExpression.Validate(fieldValue, nameof(fieldValue), required: false);
            return new DeferredBodyAction<GetFilePropertyResponse>(() =>
            {
                var apiCallPath = "/files/properties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(fieldValue);
                return new ApiConnectionAction<GetFilePropertyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileContent))]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileContent(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildAddLibraryFile))]
        public IBodyWorkflowAction<AddLibraryFileResponse> AddLibraryFile([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> path = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddLibraryFileResponse> __BuildAddLibraryFile(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<string> fileName, WorkflowExpression<string> path = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(path, nameof(path), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AddLibraryFileResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/library", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                if (path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                callPayload.Queries["FileName"] = ExpressionConverter.Convert(fileName);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AddLibraryFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryFile))]
        public IBodyWorkflowAction<string> GetLibraryFile([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetLibraryFile(WorkflowExpression<string> application, WorkflowExpression<string> listID, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/library/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class YeeflowTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnItemCreated))]
        public IBodyWorkflowTrigger<JToken> OnItemCreated([WorkflowExpression] Func<string> application,[WorkflowExpression] Func<string> listID,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildOnItemCreated(WorkflowExpression<string> application,WorkflowExpression<string> listID,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/1", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnItemModified))]
        public IBodyWorkflowTrigger<JToken> OnItemModified([WorkflowExpression] Func<string> application,[WorkflowExpression] Func<string> listID,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildOnItemModified(WorkflowExpression<string> application,WorkflowExpression<string> listID,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/2", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnItemCreatedModified))]
        public IBodyWorkflowTrigger<JToken> OnItemCreatedModified([WorkflowExpression] Func<string> application,[WorkflowExpression] Func<string> listID,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildOnItemCreatedModified(WorkflowExpression<string> application,WorkflowExpression<string> listID,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/3", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnItemDeleted))]
        public IBodyWorkflowTrigger<JToken> OnItemDeleted([WorkflowExpression] Func<string> application,[WorkflowExpression] Func<string> listID,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildOnItemDeleted(WorkflowExpression<string> application,WorkflowExpression<string> listID,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: true);
            WorkflowExpression.Validate(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/4", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddItemResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class GetItemResponse
    {
        public JToken Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class DeleteItemResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UpdateItemResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class GetListFieldsResponse
    {
        public GetListFieldsResponseDataTypeItem[] Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
    }

    public class GetListFieldsResponseDataTypeItem
    {
        public string FieldID { get; set; }
        public string FieldName { get; set; }
        public string DisplayName { get; set; }
        public string InternalName { get; set; }
        public string Type { get; set; }
        public string DefaultValue { get; set; }
        public string Rules { get; set; }
        public bool IsSort { get; set; }
        public bool IsIndex { get; set; }
        public bool IsSystem { get; set; }
        public bool IsUnique { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class StartWorkflowResponse
    {
        public StartWorkflowResponseDataType Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class StartWorkflowResponseDataType
    {
        public string ApplicationID { get; set; }
        public string FlowNo { get; set; }
    }

    public class GetAgentDefinitionResponse
    {
        public GetAgentDefinitionResponseDataType Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
    }

    public class GetAgentDefinitionResponseDataType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GetAgentDefinitionResponseDataTypeInputVariablesTypeItem[] InputVariables { get; set; }
        public GetAgentDefinitionResponseDataTypeOutputVariablesTypeItem[] OutputVariables { get; set; }
    }

    public class GetAgentDefinitionResponseDataTypeInputVariablesTypeItem
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    public class GetAgentDefinitionResponseDataTypeOutputVariablesTypeItem
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    public class RunAgentResponse
    {
        public JToken Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class QueryItemsResponse
    {
        [JsonProperty("Data")]
        public JToken[] Items { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
    }

    public class ListDataWhereRequest
    {
        public string Field { get; set; }
        public string Value { get; set; }

        [JsonProperty("Type")]
        public int FilterType { get; set; }
        public ListDataWhereRequestPreType Pre { get; set; }
        public ListDataWhereRequest[] Child { get; set; }
    }

    public enum ListDataWhereRequestPreType
    {
        [EnumMember(Value = "and")]
        And,
        [EnumMember(Value = "or")]
        Or
    }

    public class bodysortsInputItem
    {
        public string Field { get; set; }

        [JsonProperty("Desc")]
        public bool IsDescending { get; set; }
    }

    public class AddItemFileResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UploadFileResponse
    {
        public UploadFileResponseDataType Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UploadFileResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }
    }

    public class GetFilePropertyResponse
    {
        [JsonProperty("Data")]
        public GetFilePropertyResponseFilePropertiesTypeItem[] FileProperties { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class GetFilePropertyResponseFilePropertiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }
    }

    public class AddLibraryFileResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Yeeflow;

    public partial class WorkflowManagedActions
    {
        public YeeflowActions Yeeflow(string connectionId) => new YeeflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YeeflowTriggers Yeeflow(string connectionId) => new YeeflowTriggers(connectionId);
    }
}