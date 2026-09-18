//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextcsbyonefox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextcsbyonefoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateDocument([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyparentID, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<string> bodyfilefileName, [WorkflowExpression] Func<string> bodyfilefileContent, [WorkflowExpression] Func<string> bodymetadatadescription = null, [WorkflowExpression] Func<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyparentID, nameof(bodyparentID), required: true);
            SourceExpression.Validate(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            SourceExpression.Validate(bodyfilefileName, nameof(bodyfilefileName), required: true);
            SourceExpression.Validate(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            SourceExpression.Validate(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            SourceExpression.Validate(bodymetadatafields, nameof(bodymetadatafields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentID);
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = SourceExpressionConverter.ConvertToken(bodymetadatadisplayName);
                if (bodymetadatadescription != null)
                {
                    metadataObject["description"] = SourceExpressionConverter.ConvertToken(bodymetadatadescription);
                    metadataObjectpropCount++;
                }

                if (bodymetadatafields != null)
                {
                    metadataObject["fieldValues"] = SourceExpressionConverter.ConvertToken(bodymetadatafields);
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
                fileObject["name"] = SourceExpressionConverter.ConvertToken(bodyfilefileName);
                fileObjectpropCount++;
                fileObject["content"] = SourceExpressionConverter.ConvertToken(bodyfilefileContent);
                if (fileObjectpropCount > 0)
                {
                    body["file"] = fileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<string> bodyfilefileName, [WorkflowExpression] Func<string> bodyfilefileContent, [WorkflowExpression] Func<string> bodymetadatadescription = null, [WorkflowExpression] Func<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            SourceExpression.Validate(bodyfilefileName, nameof(bodyfilefileName), required: true);
            SourceExpression.Validate(bodyfilefileContent, nameof(bodyfilefileContent), required: true);
            SourceExpression.Validate(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            SourceExpression.Validate(bodymetadatafields, nameof(bodymetadatafields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = SourceExpressionConverter.ConvertToken(bodymetadatadisplayName);
                if (bodymetadatadescription != null)
                {
                    metadataObject["description"] = SourceExpressionConverter.ConvertToken(bodymetadatadescription);
                    metadataObjectpropCount++;
                }

                if (bodymetadatafields != null)
                {
                    metadataObject["fieldValues"] = SourceExpressionConverter.ConvertToken(bodymetadatafields);
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
                fileObject["name"] = SourceExpressionConverter.ConvertToken(bodyfilefileName);
                fileObjectpropCount++;
                fileObject["content"] = SourceExpressionConverter.ConvertToken(bodyfilefileContent);
                if (fileObjectpropCount > 0)
                {
                    body["file"] = fileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/update-properties/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyfields != null)
                {
                    body["fieldValues"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/update-content/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
                body["content"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UnreserveDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/check-in/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction ReserveDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/check-out/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/get/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse> GetDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/get-properties/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentContentResponse> GetDocumentContent([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/get-content/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentContentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse> GetDocumentVersionContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> versionId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(versionId, nameof(versionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/get-content/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(versionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentVersionContentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/delete/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteDocumentVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> versionId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(versionId, nameof(versionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/delete/{0}/version/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(versionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<Version[]> GetDocumentVersions([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/get-versions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Version[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction MoveDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> parentId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/move/{0}/to/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CopyDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> parentId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/document/copy/{0}/to/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateFolder([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentID, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyparentID, nameof(bodyparentID), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/folder/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentID);
                if (bodyfields != null)
                {
                    body["fieldValues"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/folder/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyfields != null)
                {
                    body["fieldValues"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetFolderResponse> GetFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/folder/get/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteFolder([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/folder/delete/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> GetFolderChildren([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/folder/get-children/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> SimpleSearch([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/search/simple/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> AdvancedSearch([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodylimit = null)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/search/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodystart != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> ExecuteWebReport([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/command/execute/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateBusinessWorkspace([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyparentID, [WorkflowExpression] Func<string> bodytemplateID, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyparentID, nameof(bodyparentID), required: true);
            SourceExpression.Validate(bodytemplateID, nameof(bodytemplateID), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/workspace/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentID);
                bodypropCount++;
                body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateID);
                if (bodyfields != null)
                {
                    body["fieldValues"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[]> GetItemTrustees([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/security/get/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TrusteeRead[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction AddTrustees([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/security/add/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateTrustees([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/security/update/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction RemoveTrustees([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string[]> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/security/remove/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetBusinessWorkspaceResponse> GetBusinessWorkspace([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/workspace/get/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBusinessWorkspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateBusinessWorkspace([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/workspace/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyfields != null)
                {
                    body["fieldValues"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class OpentextcsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DocumentCreated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/DocumentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger DocumentUpdated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/DocumentUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger DocumentDeleted([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/DocumentDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderCreated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/FolderCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderUpdated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/FolderUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderDeleted([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/FolderDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger BusinessWorkspaceCreated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger BusinessWorkspaceUpdated([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger BusinessWorkspaceDeleted([WorkflowExpression] Func<string> bodyfilterparentID = null, [WorkflowExpression] Func<string> bodyfilterancestorID = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentID, nameof(bodyfilterparentID), required: false);
            SourceExpression.Validate(bodyfilterancestorID, nameof(bodyfilterancestorID), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterparentID != null)
                {
                    filterObject["parentId"] = SourceExpressionConverter.ConvertToken(bodyfilterparentID);
                    filterObjectpropCount++;
                }

                if (bodyfilterancestorID != null)
                {
                    filterObject["ancestorId"] = SourceExpressionConverter.ConvertToken(bodyfilterancestorID);
                    filterObjectpropCount++;
                }

                if (bodyfiltermetadata != null)
                {
                    filterObject["metadata"] = SourceExpressionConverter.ConvertToken(bodyfiltermetadata);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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