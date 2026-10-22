//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextedocsbyonefox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextedocsbyonefoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<string>> configurationKey, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodyparentID = null, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodymetadatadisplayName = WorkflowExpression.Compile(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            var __workflow_bodyfilefileName = WorkflowExpression.Compile(bodyfilefileName, nameof(bodyfilefileName), required: true);
            var __workflow_bodyfilefileContent = WorkflowExpression.Compile(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            var __workflow_bodyparentID = WorkflowExpression.Compile(bodyparentID, nameof(bodyparentID), required: false);
            var __workflow_bodymetadatadescription = WorkflowExpression.Compile(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            var __workflow_bodymetadatafields = WorkflowExpression.Compile(bodymetadatafields, nameof(bodymetadatafields), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyparentID != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentID);
                    bodypropCount++;
                }

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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodymetadatadisplayName = WorkflowExpression.Compile(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            var __workflow_bodyfilefileName = WorkflowExpression.Compile(bodyfilefileName, nameof(bodyfilefileName), required: true);
            var __workflow_bodyfilefileContent = WorkflowExpression.Compile(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            var __workflow_bodymetadatadescription = WorkflowExpression.Compile(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            var __workflow_bodymetadatafields = WorkflowExpression.Compile(bodymetadatafields, nameof(bodymetadatafields), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CheckInDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/check-in/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CheckOutDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/check-out/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentResponse, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse, ApiConnectionActionConfiguration> GetDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetDocumentPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-properties/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentContentResponse, ApiConnectionActionConfiguration> GetDocumentContent(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentContentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-content/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse, ApiConnectionActionConfiguration> GetDocumentVersionContent(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_versionId = WorkflowExpression.Compile(versionId, nameof(versionId), required: true);
            return new DeferredBodyAction<GetDocumentVersionContentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-content/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_versionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentVersionContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/delete/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocumentVersion(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_versionId = WorkflowExpression.Compile(versionId, nameof(versionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/delete/{0}/version/{1}", __workflow_id.WithUrlEncoding(1), __workflow_versionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<Version[], ApiConnectionActionConfiguration> GetDocumentVersions(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Version[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/get-versions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Version[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateFolder(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyparentID = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyparentID = WorkflowExpression.Compile(bodyparentID, nameof(bodyparentID), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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

                if (__workflow_bodyparentID != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentID);
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

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetFolderResponse, ApiConnectionActionConfiguration> GetFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/get/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFolder(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/delete/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[], ApiConnectionActionConfiguration> GetFolderChildren(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/get-children/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddReferenceToFolder(Expression<Func<string>> sourceId, Expression<Func<string>> id)
        {
            var __workflow_sourceId = WorkflowExpression.Compile(sourceId, nameof(sourceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/add-reference/{0}/to/{1}", __workflow_sourceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveReferenceFromFolder(Expression<Func<string>> sourceId, Expression<Func<string>> id)
        {
            var __workflow_sourceId = WorkflowExpression.Compile(sourceId, nameof(sourceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/folder/remove-reference/{0}/from/{1}", __workflow_sourceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[], ApiConnectionActionConfiguration> SimpleSearch(Expression<Func<string>> bodysearchValue)
        {
            var __workflow_bodysearchValue = WorkflowExpression.Compile(bodysearchValue, nameof(bodysearchValue), required: true);
            return new DeferredBodyAction<ResultItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/search/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodysearchValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[], ApiConnectionActionConfiguration> AdvancedSearch(Expression<Func<string>> bodyquery, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodylimit = null)
        {
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<ResultItem[], ApiConnectionActionConfiguration>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[], ApiConnectionActionConfiguration> GetTrustees(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TrusteeRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/get/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TrusteeRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/add/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/update/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveTrustees(Expression<Func<string>> id, Expression<Func<string[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/remove/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OverrideTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/security/override/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateLookupEntry(Expression<Func<string>> configurationKey, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/lookup-entry/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateLookupEntry(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/lookup-entry/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetLookupEntriesResponseItem[], ApiConnectionActionConfiguration> GetLookupEntries(Expression<Func<string>> configurationKey, Expression<Func<string>> filter = null)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetLookupEntriesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/lookup-entry/get-all/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetLookupEntriesResponseItem[]>(callPayload);
            });
        }
    }

    public class OpentextedocsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DocumentCreated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentparentID = WorkflowExpression.Compile(bodyfilterparentparentID, nameof(bodyfilterparentparentID), required: false);
            var __workflow_bodyfilterparentparentDepth = WorkflowExpression.Compile(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (__workflow_bodyfilterparentparentID != null)
                {
                    parentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentID);
                    parentObjectpropCount++;
                }

                if (__workflow_bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DocumentContentUpdated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentparentID = WorkflowExpression.Compile(bodyfilterparentparentID, nameof(bodyfilterparentparentID), required: false);
            var __workflow_bodyfilterparentparentDepth = WorkflowExpression.Compile(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentContentUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (__workflow_bodyfilterparentparentID != null)
                {
                    parentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentID);
                    parentObjectpropCount++;
                }

                if (__workflow_bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DocumentPropertiesUpdated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentparentID = WorkflowExpression.Compile(bodyfilterparentparentID, nameof(bodyfilterparentparentID), required: false);
            var __workflow_bodyfilterparentparentDepth = WorkflowExpression.Compile(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentPropertiesUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (__workflow_bodyfilterparentparentID != null)
                {
                    parentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentID);
                    parentObjectpropCount++;
                }

                if (__workflow_bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DocumentDeleted(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentparentID = WorkflowExpression.Compile(bodyfilterparentparentID, nameof(bodyfilterparentparentID), required: false);
            var __workflow_bodyfilterparentparentDepth = WorkflowExpression.Compile(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (__workflow_bodyfilterparentparentID != null)
                {
                    parentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentID);
                    parentObjectpropCount++;
                }

                if (__workflow_bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FolderCreated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentparentID = WorkflowExpression.Compile(bodyfilterparentparentID, nameof(bodyfilterparentparentID), required: false);
            var __workflow_bodyfilterparentparentDepth = WorkflowExpression.Compile(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (__workflow_bodyfilterparentparentID != null)
                {
                    parentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentID);
                    parentObjectpropCount++;
                }

                if (__workflow_bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FolderUpdated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentparentID = WorkflowExpression.Compile(bodyfilterparentparentID, nameof(bodyfilterparentparentID), required: false);
            var __workflow_bodyfilterparentparentDepth = WorkflowExpression.Compile(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (__workflow_bodyfilterparentparentID != null)
                {
                    parentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentID);
                    parentObjectpropCount++;
                }

                if (__workflow_bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FolderDeleted(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilterparentparentID = WorkflowExpression.Compile(bodyfilterparentparentID, nameof(bodyfilterparentparentID), required: false);
            var __workflow_bodyfilterparentparentDepth = WorkflowExpression.Compile(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            var __workflow_bodyfiltermetadata = WorkflowExpression.Compile(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                var parentObject = new JObject();
                var parentObjectpropCount = 0;
                if (__workflow_bodyfilterparentparentID != null)
                {
                    parentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentID);
                    parentObjectpropCount++;
                }

                if (__workflow_bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = ExpressionConverter.ConvertO(__workflow_bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ItemDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/web-hook/create/ItemDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

        [JsonProperty("versionLabel")]
        public string VersionLabel { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

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
        public TrusteeWriteTypeType Type { get; set; }

        [JsonProperty("accessRights")]
        public string[] AccessRights { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TrusteeWriteTypeType
    {
        User,
        Group
    }

    public class GetLookupEntriesResponseItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opentextedocsbyonefox;

    public partial class WorkflowManagedActions
    {
        public OpentextedocsbyonefoxActions Opentextedocsbyonefox(string connectionId) => new OpentextedocsbyonefoxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpentextedocsbyonefoxTriggers Opentextedocsbyonefox(string connectionId) => new OpentextedocsbyonefoxTriggers(connectionId);
    }
}
