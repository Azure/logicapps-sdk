//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextcsbyonefox
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextcsbyonefoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocument))]
        public IBodyWorkflowAction<string> CreateDocument([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyparentID, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<string> bodyfilefileName, [WorkflowExpression] Func<string> bodyfilefileContent, [WorkflowExpression] Func<string> bodymetadatadescription = null, [WorkflowExpression] Func<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateDocument(WorkflowValue<string> configurationKey, WorkflowValue<string> bodyparentID, WorkflowValue<string> bodymetadatadisplayName, WorkflowValue<string> bodyfilefileName, WorkflowValue<string> bodyfilefileContent, WorkflowValue<string> bodymetadatadescription = null, WorkflowValue<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
        {
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodyparentID, nameof(bodyparentID), required: true);
            WorkflowValue.Validate(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            WorkflowValue.Validate(bodyfilefileName, nameof(bodyfilefileName), required: true);
            WorkflowValue.Validate(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            WorkflowValue.Validate(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            WorkflowValue.Validate(bodymetadatafields, nameof(bodymetadatafields), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentID);
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(bodymetadatadisplayName);
                if (bodymetadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(bodymetadatadescription);
                    metadataObjectpropCount++;
                }

                if (bodymetadatafields != null)
                {
                    metadataObject["fieldValues"] = ExpressionConverter.ConvertO(bodymetadatafields);
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
                fileObject["name"] = ExpressionConverter.ConvertO(bodyfilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(bodyfilefileContent);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocument))]
        public IWorkflowAction UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<string> bodyfilefileName, [WorkflowExpression] Func<string> bodyfilefileContent, [WorkflowExpression] Func<string> bodymetadatadescription = null, [WorkflowExpression] Func<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocument(WorkflowValue<string> id, WorkflowValue<string> configurationKey, WorkflowValue<string> bodymetadatadisplayName, WorkflowValue<string> bodyfilefileName, WorkflowValue<string> bodyfilefileContent, WorkflowValue<string> bodymetadatadescription = null, WorkflowValue<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            WorkflowValue.Validate(bodyfilefileName, nameof(bodyfilefileName), required: true);
            WorkflowValue.Validate(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            WorkflowValue.Validate(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            WorkflowValue.Validate(bodymetadatafields, nameof(bodymetadatafields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(bodymetadatadisplayName);
                if (bodymetadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(bodymetadatadescription);
                    metadataObjectpropCount++;
                }

                if (bodymetadatafields != null)
                {
                    metadataObject["fieldValues"] = ExpressionConverter.ConvertO(bodymetadatafields);
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
                fileObject["name"] = ExpressionConverter.ConvertO(bodyfilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(bodyfilefileContent);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocumentProperties))]
        public IWorkflowAction UpdateDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocumentProperties(WorkflowValue<string> id, WorkflowValue<string> configurationKey, WorkflowValue<string> bodydisplayName, WorkflowValue<string> bodydescription = null, WorkflowValue<bodyfieldsInputItem[]> bodyfields = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/update-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(bodyfields);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocumentContent))]
        public IWorkflowAction UpdateDocumentContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocumentContent(WorkflowValue<string> id, WorkflowValue<string> bodyfileName, WorkflowValue<string> bodyfileContent)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowValue.Validate(bodyfileContent, nameof(bodyfileContent), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/update-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(bodyfileContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildUnreserveDocument))]
        public IWorkflowAction UnreserveDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnreserveDocument(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/check-in/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildReserveDocument))]
        public IWorkflowAction ReserveDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReserveDocument(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/check-out/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocument))]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentResponse> __BuildGetDocument(WorkflowValue<string> id, WorkflowValue<string> configurationKey)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentProperties))]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse> GetDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse> __BuildGetDocumentProperties(WorkflowValue<string> id, WorkflowValue<string> configurationKey)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetDocumentPropertiesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/get-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentContent))]
        public IBodyWorkflowAction<GetDocumentContentResponse> GetDocumentContent([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentContentResponse> __BuildGetDocumentContent(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/get-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentVersionContent))]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse> GetDocumentVersionContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> versionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse> __BuildGetDocumentVersionContent(WorkflowValue<string> id, WorkflowValue<string> versionId)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(versionId, nameof(versionId), required: true);
            return new DeferredBodyAction<GetDocumentVersionContentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/get-content/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentVersionContentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocument(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocumentVersion))]
        public IWorkflowAction DeleteDocumentVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> versionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocumentVersion(WorkflowValue<string> id, WorkflowValue<string> versionId)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(versionId, nameof(versionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/delete/{0}/version/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentVersions))]
        public IBodyWorkflowAction<Version[]> GetDocumentVersions([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Version[]> __BuildGetDocumentVersions(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<Version[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/get-versions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Version[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildMoveDocument))]
        public IWorkflowAction MoveDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> parentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveDocument(WorkflowValue<string> id, WorkflowValue<string> parentId)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(parentId, nameof(parentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/move/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(parentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildCopyDocument))]
        public IBodyWorkflowAction<string> CopyDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> parentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCopyDocument(WorkflowValue<string> id, WorkflowValue<string> parentId)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(parentId, nameof(parentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/document/copy/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(parentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<string> CreateFolder([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentID, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateFolder(WorkflowValue<string> configurationKey, WorkflowValue<string> bodyname, WorkflowValue<string> bodyparentID, WorkflowValue<string> bodydescription = null, WorkflowValue<bodyfieldsInputItem[]> bodyfields = null)
        {
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyparentID, nameof(bodyparentID), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/folder/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentID);
                if (bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(bodyfields);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateFolder))]
        public IWorkflowAction UpdateFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateFolder(WorkflowValue<string> id, WorkflowValue<string> configurationKey, WorkflowValue<string> bodyname, WorkflowValue<string> bodydescription = null, WorkflowValue<bodyfieldsInputItem[]> bodyfields = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/folder/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(bodyfields);
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
        [WorkflowExpressionFactory(nameof(__BuildGetFolder))]
        public IBodyWorkflowAction<GetFolderResponse> GetFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFolderResponse> __BuildGetFolder(WorkflowValue<string> id, WorkflowValue<string> configurationKey)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/folder/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFolder))]
        public IWorkflowAction DeleteFolder([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFolder(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/folder/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildGetFolderChildren))]
        public IBodyWorkflowAction<ResultItem[]> GetFolderChildren([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultItem[]> __BuildGetFolderChildren(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/folder/get-children/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildSimpleSearch))]
        public IBodyWorkflowAction<ResultItem[]> SimpleSearch([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultItem[]> __BuildSimpleSearch(WorkflowValue<string> configurationKey, WorkflowValue<string> bodyname)
        {
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<ResultItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/search/simple/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildAdvancedSearch))]
        public IBodyWorkflowAction<ResultItem[]> AdvancedSearch([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodylimit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultItem[]> __BuildAdvancedSearch(WorkflowValue<string> bodyquery, WorkflowValue<string> bodystart = null, WorkflowValue<string> bodylimit = null)
        {
            WorkflowValue.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowValue.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowValue.Validate(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<ResultItem[]>(() =>
            {
                var apiCallPath = "/api/search/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                if (bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(bodystart);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(bodylimit);
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
        [WorkflowExpressionFactory(nameof(__BuildExecuteWebReport))]
        public IBodyWorkflowAction<string> ExecuteWebReport([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExecuteWebReport(WorkflowValue<string> id, WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/command/execute/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBusinessWorkspace))]
        public IBodyWorkflowAction<string> CreateBusinessWorkspace([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyparentID, [WorkflowExpression] Func<string> bodytemplateID, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateBusinessWorkspace(WorkflowValue<string> configurationKey, WorkflowValue<string> bodyparentID, WorkflowValue<string> bodytemplateID, WorkflowValue<string> bodyname = null, WorkflowValue<bodyfieldsInputItem[]> bodyfields = null)
        {
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodyparentID, nameof(bodyparentID), required: true);
            WorkflowValue.Validate(bodytemplateID, nameof(bodytemplateID), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/workspace/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentID);
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateID);
                if (bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(bodyfields);
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
        [WorkflowExpressionFactory(nameof(__BuildGetItemTrustees))]
        public IBodyWorkflowAction<TrusteeRead[]> GetItemTrustees([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TrusteeRead[]> __BuildGetItemTrustees(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TrusteeRead[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/security/get/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TrusteeRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildAddTrustees))]
        public IWorkflowAction AddTrustees([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddTrustees(WorkflowValue<string> id, WorkflowValue<TrusteeWrite[]> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/security/add/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTrustees))]
        public IWorkflowAction UpdateTrustees([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateTrustees(WorkflowValue<string> id, WorkflowValue<TrusteeWrite[]> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/security/update/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveTrustees))]
        public IWorkflowAction RemoveTrustees([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveTrustees(WorkflowValue<string> id, WorkflowValue<string[]> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/security/remove/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildGetBusinessWorkspace))]
        public IBodyWorkflowAction<GetBusinessWorkspaceResponse> GetBusinessWorkspace([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetBusinessWorkspaceResponse> __BuildGetBusinessWorkspace(WorkflowValue<string> id, WorkflowValue<string> configurationKey)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetBusinessWorkspaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/workspace/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBusinessWorkspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateBusinessWorkspace))]
        public IWorkflowAction UpdateBusinessWorkspace([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateBusinessWorkspace(WorkflowValue<string> id, WorkflowValue<string> configurationKey, WorkflowValue<string> bodyname, WorkflowValue<bodyfieldsInputItem[]> bodyfields = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(configurationKey, nameof(configurationKey), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/workspace/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyfields != null)
                {
                    body["fieldValues"] = ExpressionConverter.ConvertO(bodyfields);
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
        [WorkflowExpressionFactory(nameof(__BuildDocumentCreated))]
        public IWorkflowTrigger DocumentCreated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildDocumentCreated(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildDocumentUpdated))]
        public IWorkflowTrigger DocumentUpdated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildDocumentUpdated(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildDocumentDeleted))]
        public IWorkflowTrigger DocumentDeleted([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildDocumentDeleted(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildFolderCreated))]
        public IWorkflowTrigger FolderCreated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFolderCreated(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildFolderUpdated))]
        public IWorkflowTrigger FolderUpdated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFolderUpdated(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildFolderDeleted))]
        public IWorkflowTrigger FolderDeleted([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFolderDeleted(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildBusinessWorkspaceCreated))]
        public IWorkflowTrigger BusinessWorkspaceCreated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBusinessWorkspaceCreated(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildBusinessWorkspaceUpdated))]
        public IWorkflowTrigger BusinessWorkspaceUpdated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBusinessWorkspaceUpdated(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildBusinessWorkspaceDeleted))]
        public IWorkflowTrigger BusinessWorkspaceDeleted([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBusinessWorkspaceDeleted(WorkflowValue<string> bodyfilterparentID = null, WorkflowValue<string> bodyfilterancestorID = null, WorkflowValue<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            WorkflowValue.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            WorkflowValue.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
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
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = ExpressionConverter.ConvertO(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = ExpressionConverter.ConvertO(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = ExpressionConverter.ConvertO(bodyfiltermetadata);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
