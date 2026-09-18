//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextedocsbyonefox
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextedocsbyonefoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> configurationKey, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<string> bodyfilefileName, [WorkflowExpression] Func<string> bodyfilefileContent, [WorkflowExpression] Func<string> bodyparentID = null, [WorkflowExpression] Func<string> bodymetadatadescription = null, [WorkflowExpression] Func<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
        {
            var apiCallPath = String.Format("/api/document/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyparentID != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentID);
                bodypropCount++;
            }

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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodymetadatadisplayName, [WorkflowExpression] Func<string> bodyfilefileName, [WorkflowExpression] Func<string> bodyfilefileContent, [WorkflowExpression] Func<string> bodymetadatadescription = null, [WorkflowExpression] Func<bodymetadatafieldsInputItem[]> bodymetadatafields = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateDocumentProperties([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateDocumentContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction CheckInDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/document/check-in/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction CheckOutDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/document/check-out/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            var apiCallPath = String.Format("/api/document/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse> GetDocumentProperties([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            var apiCallPath = String.Format("/api/document/get-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentContentResponse> GetDocumentContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/document/get-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse> GetDocumentVersionContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> versionId)
        {
            var apiCallPath = String.Format("/api/document/get-content/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentVersionContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction DeleteDocument([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/document/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction DeleteDocumentVersion([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> versionId)
        {
            var apiCallPath = String.Format("/api/document/delete/{0}/version/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<Version[]> GetDocumentVersions([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/document/get-versions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Version[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyparentID = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
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

            if (bodyparentID != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentID);
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

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetFolderResponse> GetFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> configurationKey)
        {
            var apiCallPath = String.Format("/api/folder/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction DeleteFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/folder/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> GetFolderChildren([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/folder/get-children/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction AddReferenceToFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sourceId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/folder/add-reference/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(sourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction RemoveReferenceFromFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sourceId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/folder/remove-reference/{0}/from/{1}", ExpressionConverter.ConvertWithUrlEncoding(sourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> SimpleSearch([WorkflowExpression] Func<string> bodysearchValue)
        {
            var apiCallPath = "/api/search/simple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodysearchValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> AdvancedSearch([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodylimit = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[]> GetTrustees([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/security/get/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TrusteeRead[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction AddTrustees([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            var apiCallPath = String.Format("/api/security/add/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateTrustees([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            var apiCallPath = String.Format("/api/security/update/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction RemoveTrustees([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string[]> body = null)
        {
            var apiCallPath = String.Format("/api/security/remove/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction OverrideTrustees([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<TrusteeWrite[]> body = null)
        {
            var apiCallPath = String.Format("/api/security/override/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateLookupEntry([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> configurationKey, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            var apiCallPath = String.Format("/api/lookup-entry/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateLookupEntry([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> configurationKey, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields = null)
        {
            var apiCallPath = String.Format("/api/lookup-entry/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetLookupEntriesResponseItem[]> GetLookupEntries([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> configurationKey, [WorkflowExpression] Func<string> filter = null)
        {
            var apiCallPath = String.Format("/api/lookup-entry/get-all/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetLookupEntriesResponseItem[]>(callPayload);
        }
    }

    public class OpentextedocsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DocumentCreated([WorkflowExpression] Func<int> bodyfilterparentparentID = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyfilterparentparentID != null)
            {
                parentObject["id"] = ExpressionConverter.ConvertO(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = ExpressionConverter.ConvertO(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger DocumentContentUpdated([WorkflowExpression] Func<int> bodyfilterparentparentID = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/web-hook/create/DocumentContentUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "@listCallbackUrl()";
            bodypropCount++;
            var filterObject = new JObject();
            var filterObjectpropCount = 0;
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyfilterparentparentID != null)
            {
                parentObject["id"] = ExpressionConverter.ConvertO(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = ExpressionConverter.ConvertO(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger DocumentPropertiesUpdated([WorkflowExpression] Func<int> bodyfilterparentparentID = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/web-hook/create/DocumentPropertiesUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "@listCallbackUrl()";
            bodypropCount++;
            var filterObject = new JObject();
            var filterObjectpropCount = 0;
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyfilterparentparentID != null)
            {
                parentObject["id"] = ExpressionConverter.ConvertO(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = ExpressionConverter.ConvertO(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger DocumentDeleted([WorkflowExpression] Func<int> bodyfilterparentparentID = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyfilterparentparentID != null)
            {
                parentObject["id"] = ExpressionConverter.ConvertO(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = ExpressionConverter.ConvertO(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger FolderCreated([WorkflowExpression] Func<int> bodyfilterparentparentID = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyfilterparentparentID != null)
            {
                parentObject["id"] = ExpressionConverter.ConvertO(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = ExpressionConverter.ConvertO(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger FolderUpdated([WorkflowExpression] Func<int> bodyfilterparentparentID = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyfilterparentparentID != null)
            {
                parentObject["id"] = ExpressionConverter.ConvertO(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = ExpressionConverter.ConvertO(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger FolderDeleted([WorkflowExpression] Func<int> bodyfilterparentparentID = null, [WorkflowExpression] Func<int> bodyfilterparentparentDepth = null, [WorkflowExpression] Func<bodyfiltermetadataInputItem[]> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            if (bodyfilterparentparentID != null)
            {
                parentObject["id"] = ExpressionConverter.ConvertO(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = ExpressionConverter.ConvertO(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
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

        public IWorkflowTrigger ItemDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/web-hook/create/ItemDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "@listCallbackUrl()";
            bodypropCount++;
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