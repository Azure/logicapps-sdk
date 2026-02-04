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
        public IBodyWorkflowAction<string> CreateDocument(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var apiCallPath = String.Format("/api/document/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateDocumentV2(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<object>> bodymetadatafields, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null)
        {
            var apiCallPath = String.Format("/api/v2/document/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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

            metadataObjectpropCount++;
            metadataObject["fields"] = ExpressionConverter.ConvertO(bodymetadatafields);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var apiCallPath = String.Format("/api/document/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentV2(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<object>> bodymetadatafields, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null)
        {
            var apiCallPath = String.Format("/api/v2/document/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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

            metadataObjectpropCount++;
            metadataObject["fields"] = ExpressionConverter.ConvertO(bodymetadatafields);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = String.Format("/api/document/update-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentPropertiesV2(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodydisplayName, Expression<Func<object>> bodyfields, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/api/v2/document/update-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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

            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodyfields);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent)
        {
            var apiCallPath = String.Format("/api/document/update-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UnreserveDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/document/check-in/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction ReserveDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/document/check-out/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var apiCallPath = String.Format("/api/document/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse> GetDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var apiCallPath = String.Format("/api/document/get-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentContentResponse> GetDocumentContent(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/document/get-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse> GetDocumentVersionContent(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var apiCallPath = String.Format("/api/document/get-content/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentVersionContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/document/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteDocumentVersion(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var apiCallPath = String.Format("/api/document/delete/{0}/version/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<Version[]> GetDocumentVersions(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/document/get-versions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Version[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction MoveDocument(Expression<Func<string>> id, Expression<Func<string>> parentId)
        {
            var apiCallPath = String.Format("/api/document/move/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(parentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CopyDocument(Expression<Func<string>> id, Expression<Func<string>> parentId)
        {
            var apiCallPath = String.Format("/api/document/copy/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(parentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateFolder(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = String.Format("/api/folder/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateFolderV2(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentID, Expression<Func<object>> bodyfields, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/api/v2/folder/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodyfields);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = String.Format("/api/folder/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateFolderV2(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<object>> bodyfields, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/api/v2/folder/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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

            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodyfields);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetFolderResponse> GetFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var apiCallPath = String.Format("/api/folder/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction DeleteFolder(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/folder/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> GetFolderChildren(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/folder/get-children/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> SimpleSearch(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname)
        {
            var apiCallPath = String.Format("/api/search/simple/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> AdvancedSearch(Expression<Func<string>> bodyquery, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodylimit = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> ExecuteWebReport(Expression<Func<string>> id, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = String.Format("/api/command/execute/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateBusinessWorkspace(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodytemplateID, Expression<Func<string>> bodyname = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = String.Format("/api/workspace/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string> CreateBusinessWorkspaceV2(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyparentID, Expression<Func<string>> bodytemplateID, Expression<Func<object>> bodyfields, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = String.Format("/api/v2/workspace/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodyfields);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[]> GetItemTrustees(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/security/get/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TrusteeRead[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction AddTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var apiCallPath = String.Format("/api/security/add/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var apiCallPath = String.Format("/api/security/update/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction RemoveTrustees(Expression<Func<string>> id, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = String.Format("/api/security/remove/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetBusinessWorkspaceResponse> GetBusinessWorkspace(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var apiCallPath = String.Format("/api/workspace/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBusinessWorkspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateBusinessWorkspace(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = String.Format("/api/workspace/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction UpdateBusinessWorkspaceV2(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<object>> bodyfields)
        {
            var apiCallPath = String.Format("/api/v2/workspace/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodyfields);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class OpentextcsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DocumentCreated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger DocumentUpdated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger DocumentDeleted(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger FolderCreated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger FolderUpdated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger FolderDeleted(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger BusinessWorkspaceCreated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger BusinessWorkspaceUpdated(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger BusinessWorkspaceDeleted(Expression<Func<string>> bodyfilterparentID = null, Expression<Func<string>> bodyfilterancestorID = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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