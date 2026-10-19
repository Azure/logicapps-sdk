//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextcsbyonefox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextcsbyonefoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateDocument(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyparentID = WorkflowExpression.Compile(bodyparentID, nameof(bodyparentID), required: true);
            var __workflow_bodymetadatadisplayName = WorkflowExpression.Compile(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            var __workflow_bodyfilefileName = WorkflowExpression.Compile(bodyfilefileName, nameof(bodyfilefileName), required: true);
            var __workflow_bodyfilefileContent = WorkflowExpression.Compile(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            var __workflow_bodymetadatadescription = WorkflowExpression.Compile(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            var __workflow_bodymetadatafields = WorkflowExpression.Compile(bodymetadatafields, nameof(bodymetadatafields), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentID);
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodymetadatadisplayName);
                if (__workflow_bodymetadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(__workflow_bodymetadatadescription);
                    metadataObjectpropCount++;
                }

                if (__workflow_bodymetadatafields != null)
                {
                    metadataObject["fieldValues"] = ExpressionConverter.ConvertO(__workflow_bodymetadatafields);
                    metadataObjectpropCount++;
                }

                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(__workflow_bodyfilefileContent);
                if (fileObjectpropCount > 0)
                {
                    body["file"] = fileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodymetadatadisplayName = WorkflowExpression.Compile(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            var __workflow_bodyfilefileName = WorkflowExpression.Compile(bodyfilefileName, nameof(bodyfilefileName), required: true);
            var __workflow_bodyfilefileContent = WorkflowExpression.Compile(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            var __workflow_bodymetadatadescription = WorkflowExpression.Compile(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            var __workflow_bodymetadatafields = WorkflowExpression.Compile(bodymetadatafields, nameof(bodymetadatafields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodymetadatadisplayName);
                if (__workflow_bodymetadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(__workflow_bodymetadatadescription);
                    metadataObjectpropCount++;
                }

                if (__workflow_bodymetadatafields != null)
                {
                    metadataObject["fieldValues"] = ExpressionConverter.ConvertO(__workflow_bodymetadatafields);
                    metadataObjectpropCount++;
                }

                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(__workflow_bodyfilefileContent);
                if (fileObjectpropCount > 0)
                {
                    body["file"] = fileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/update-properties/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/update-content/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UnreserveDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/check-in/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction ReserveDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/check-out/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse> GetDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetDocumentPropertiesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-properties/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentContentResponse> GetDocumentContent(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-content/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse> GetDocumentVersionContent(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_versionId = WorkflowExpression.Compile(versionId, nameof(versionId), required: true);
            return new DeferredBodyAction<GetDocumentVersionContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-content/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_versionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentVersionContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/delete/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteDocumentVersion(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_versionId = WorkflowExpression.Compile(versionId, nameof(versionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/delete/{0}/version/{1}", __workflow_id.WithUrlEncoding(1), __workflow_versionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<Version[]> GetDocumentVersions(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Version[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-versions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Version[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction MoveDocument(Expression<Func<string>> id, Expression<Func<string>> parentId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/move/{0}/to/{1}", __workflow_id.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CopyDocument(Expression<Func<string>> id, Expression<Func<string>> parentId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/copy/{0}/to/{1}", __workflow_id.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateFolder(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyparentID = WorkflowExpression.Compile(bodyparentID, nameof(bodyparentID), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentID);
                if (__workflow_bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetFolderResponse> GetFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/get/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteFolder(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/delete/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> GetFolderChildren(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/get-children/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> SimpleSearch(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<ResultItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/search/simple/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> AdvancedSearch(Expression<Func<string>> bodyquery, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodylimit = null)
        {
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<ResultItem[]>(() =>
            {
                var apiCallPath = "/api/search/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                if (__workflow_bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> ExecuteWebReport(Expression<Func<string>> id, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/command/execute/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateBusinessWorkspace(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodytemplateID, Expression<Func<string>> bodyname = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyparentID = WorkflowExpression.Compile(bodyparentID, nameof(bodyparentID), required: true);
            var __workflow_bodytemplateID = WorkflowExpression.Compile(bodytemplateID, nameof(bodytemplateID), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workspace/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentID);
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateID);
                if (__workflow_bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[]> GetItemTrustees(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TrusteeRead[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/get/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TrusteeRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction AddTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/add/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/update/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction RemoveTrustees(Expression<Func<string>> id, Expression<Func<string[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/remove/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetBusinessWorkspaceResponse> GetBusinessWorkspace(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetBusinessWorkspaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workspace/get/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBusinessWorkspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateBusinessWorkspace(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workspace/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class OpentextcsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DocumentCreated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger DocumentUpdated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger DocumentDeleted(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger FolderCreated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/FolderCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger FolderUpdated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/FolderUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger FolderDeleted(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/FolderDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger BusinessWorkspaceCreated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger BusinessWorkspaceUpdated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger BusinessWorkspaceDeleted(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentID = WorkflowExpression.Compile(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            var __workflow_bodyfilterancestorID = WorkflowExpression.Compile(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(__workflow_bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermetadata);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["Filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class bodymetadatafieldsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyfieldsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetDocumentResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

        [JsonProperty("metadata")]
        public GetDocumentResponseMetadataType Metadata { get; set; }

        [JsonProperty("file")]
        public GetDocumentResponseFileType File { get; set; }
    }

    public class GetDocumentResponseMetadataType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class GetDocumentResponseFileType
    {
        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string FileContent { get; set; }
    }

    public class GetDocumentPropertiesResponse
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class GetDocumentContentResponse
    {
        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string FileContent { get; set; }
    }

    public class GetDocumentVersionContentResponse
    {
        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string FileContent { get; set; }
    }

    public class Version
    {
        [JsonProperty("versionId")]
        public string VersionID { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class GetFolderResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class ResultItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("key")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class TrusteeRead
    {
        [JsonProperty("trusteeId")]
        public string ID { get; set; }

        [JsonProperty("trusteeType")]
        public string Type { get; set; }

        [JsonProperty("accessRights")]
        public string[] AccessRights { get; set; }
    }

    public class TrusteeWrite
    {
        [JsonProperty("trusteeId")]
        public string ID { get; set; }

        [JsonProperty("trusteeType")]
        public string Type { get; set; }

        [JsonProperty("accessRights")]
        public TrusteeWriteAccessRightsTypeItem[] AccessRights { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TrusteeWriteAccessRightsTypeItem
    {
        [EnumMember(Value = "see")]
        See,
        [EnumMember(Value = "see_contents")]
        SeeContents,
        [EnumMember(Value = "modify")]
        Modify,
        [EnumMember(Value = "edit_attributes")]
        EditAttributes,
        [EnumMember(Value = "add_items")]
        AddItems,
        [EnumMember(Value = "reserve")]
        Reserve,
        [EnumMember(Value = "add_major_version")]
        AddMajorVersion,
        [EnumMember(Value = "delete_versions")]
        DeleteVersions,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "edit_permissions")]
        EditPermissions
    }

    public class GetBusinessWorkspaceResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class bodyfiltermetadataInputItem
    {
        [JsonProperty("column")]
        public string Column { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opentextcsbyonefox;

    public partial class WorkflowManagedActions
    {
        public OpentextcsbyonefoxActions Opentextcsbyonefox(string connectionId) => new OpentextcsbyonefoxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpentextcsbyonefoxTriggers Opentextcsbyonefox(string connectionId) => new OpentextcsbyonefoxTriggers(connectionId);
    }
}
