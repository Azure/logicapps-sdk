//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextedocsbyonefox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextedocsbyonefoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction CheckInDocument([WorkflowExpression] Func<string> id)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction CheckOutDocument([WorkflowExpression] Func<string> id)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction AddReferenceToFolder([WorkflowExpression] Func<string> sourceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(sourceId, nameof(sourceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/folder/add-reference/{0}/to/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sourceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction RemoveReferenceFromFolder([WorkflowExpression] Func<string> sourceId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(sourceId, nameof(sourceId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/folder/remove-reference/{0}/from/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sourceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> SimpleSearch([WorkflowExpression] Func<string> bodysearchValue)
        {
            SourceExpression.Validate(bodysearchValue, nameof(bodysearchValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/search/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodysearchValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[]> GetTrustees([WorkflowExpression] Func<string> id)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction OverrideTrustees([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/security/override/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetLookupEntriesResponseItem[]> GetLookupEntries([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> filter = null)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/lookup-entry/get-all/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<GetLookupEntriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateDocument([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<object> bodymetadatafields, [WorkflowExpression] Func<string> bodyFilefileName, [WorkflowExpression] Func<string> bodyFilefileContent, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodymetadatadescription = null)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            SourceExpression.Validate(bodymetadatafields, nameof(bodymetadatafields), required: true);
            SourceExpression.Validate(bodyFilefileName, nameof(bodyFilefileName), required: true);
            SourceExpression.Validate(bodyFilefileContent, nameof(bodyFilefileContent), required: true);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/document/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = SourceExpressionConverter.ConvertToken(bodymetadatadisplayName);
                if (bodymetadatadescription != null)
                {
                    metadataObject["description"] = SourceExpressionConverter.ConvertToken(bodymetadatadescription);
                    metadataObjectpropCount++;
                }

                metadataObjectpropCount++;
                metadataObject["fields"] = SourceExpressionConverter.ConvertToken(bodymetadatafields);
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var @fileObject = new JObject();
                var @fileObjectpropCount = 0;
                @fileObjectpropCount++;
                @fileObject["name"] = SourceExpressionConverter.ConvertToken(bodyFilefileName);
                @fileObjectpropCount++;
                @fileObject["content"] = SourceExpressionConverter.ConvertToken(bodyFilefileContent);
                if (@fileObjectpropCount > 0)
                {
                    body["file"] = @fileObject;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateFolder([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<object> bodyfields, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/folder/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
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

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateLookupEntry([WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<object> bodyfields)
        {
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/lookup-entry/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<object> bodymetadatafields, [WorkflowExpression] Func<string> bodyFilefileName, [WorkflowExpression] Func<string> bodyFilefileContent, [WorkflowExpression] Func<string> bodymetadatadescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodymetadatadisplayName, nameof(bodymetadatadisplayName), required: true);
            SourceExpression.Validate(bodymetadatafields, nameof(bodymetadatafields), required: true);
            SourceExpression.Validate(bodyFilefileName, nameof(bodyFilefileName), required: true);
            SourceExpression.Validate(bodyFilefileContent, nameof(bodyFilefileContent), required: true);
            SourceExpression.Validate(bodymetadatadescription, nameof(bodymetadatadescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/document/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
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

                metadataObjectpropCount++;
                metadataObject["fields"] = SourceExpressionConverter.ConvertToken(bodymetadatafields);
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var @fileObject = new JObject();
                var @fileObjectpropCount = 0;
                @fileObjectpropCount++;
                @fileObject["name"] = SourceExpressionConverter.ConvertToken(bodyFilefileName);
                @fileObjectpropCount++;
                @fileObject["content"] = SourceExpressionConverter.ConvertToken(bodyFilefileContent);
                if (@fileObjectpropCount > 0)
                {
                    body["file"] = @fileObject;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<object> bodyfields, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/document/update-properties/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
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

                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<object> bodyfields, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/folder/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
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

                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateLookupEntry([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<object> bodyfields)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationKey, nameof(configurationKey), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/lookup-entry/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class OpentextedocsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DocumentCreated([WorkflowExpression] Func<int> bodyfilterparentparentId = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentparentId, nameof(bodyfilterparentparentId), required: false);
            SourceExpression.Validate(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyfilterparentparentId != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentId);
                    parentObjectpropCount++;
                }

                if (bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger DocumentContentUpdated([WorkflowExpression] Func<int> bodyfilterparentparentId = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentparentId, nameof(bodyfilterparentparentId), required: false);
            SourceExpression.Validate(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyfilterparentparentId != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentId);
                    parentObjectpropCount++;
                }

                if (bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger DocumentPropertiesUpdated([WorkflowExpression] Func<int> bodyfilterparentparentId = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentparentId, nameof(bodyfilterparentparentId), required: false);
            SourceExpression.Validate(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyfilterparentparentId != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentId);
                    parentObjectpropCount++;
                }

                if (bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger DocumentDeleted([WorkflowExpression] Func<int> bodyfilterparentparentId = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentparentId, nameof(bodyfilterparentparentId), required: false);
            SourceExpression.Validate(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyfilterparentparentId != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentId);
                    parentObjectpropCount++;
                }

                if (bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger FolderCreated([WorkflowExpression] Func<int> bodyfilterparentparentId = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentparentId, nameof(bodyfilterparentparentId), required: false);
            SourceExpression.Validate(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyfilterparentparentId != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentId);
                    parentObjectpropCount++;
                }

                if (bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger FolderUpdated([WorkflowExpression] Func<int> bodyfilterparentparentId = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentparentId, nameof(bodyfilterparentparentId), required: false);
            SourceExpression.Validate(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyfilterparentparentId != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentId);
                    parentObjectpropCount++;
                }

                if (bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger FolderDeleted([WorkflowExpression] Func<int> bodyfilterparentparentId = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilterparentparentId, nameof(bodyfilterparentparentId), required: false);
            SourceExpression.Validate(bodyfilterparentparentDepth, nameof(bodyfilterparentparentDepth), required: false);
            SourceExpression.Validate(bodyfiltermetadata, nameof(bodyfiltermetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyfilterparentparentId != null)
                {
                    parentObject["id"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentId);
                    parentObjectpropCount++;
                }

                if (bodyfilterparentparentDepth != null)
                {
                    parentObject["depth"] = SourceExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                    parentObjectpropCount++;
                }

                if (parentObjectpropCount > 0)
                {
                    filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger ItemDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
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