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
        public IBodyWorkflowAction<string> CreateDocument(Expression<Func<string>> configurationKey, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodyparentID = null, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/create/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyparentID != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentID);
                bodypropCount++;
            }

            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            metadataObjectpropCount++;
            metadataObject["displayName"] = CSharpExpressionConverter.ConvertToken(bodymetadatadisplayName);
            if (bodymetadatadescription != null)
            {
                metadataObject["description"] = CSharpExpressionConverter.ConvertToken(bodymetadatadescription);
                metadataObjectpropCount++;
            }

            if (bodymetadatafields != null)
            {
                metadataObject["fieldValues"] = CSharpExpressionConverter.ConvertToken(bodymetadatafields);
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
            fileObject["name"] = CSharpExpressionConverter.ConvertToken(bodyfilefileName);
            fileObjectpropCount++;
            fileObject["content"] = CSharpExpressionConverter.ConvertToken(bodyfilefileContent);
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
        public IWorkflowAction UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodymetadatadisplayName, Expression<Func<string>> bodyfilefileName, Expression<Func<string>> bodyfilefileContent, Expression<Func<string>> bodymetadatadescription = null, Expression<Func<bodymetadatafieldsInputItem[]>> bodymetadatafields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/update/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            metadataObjectpropCount++;
            metadataObject["displayName"] = CSharpExpressionConverter.ConvertToken(bodymetadatadisplayName);
            if (bodymetadatadescription != null)
            {
                metadataObject["description"] = CSharpExpressionConverter.ConvertToken(bodymetadatadescription);
                metadataObjectpropCount++;
            }

            if (bodymetadatafields != null)
            {
                metadataObject["fieldValues"] = CSharpExpressionConverter.ConvertToken(bodymetadatafields);
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
            fileObject["name"] = CSharpExpressionConverter.ConvertToken(bodyfilefileName);
            fileObjectpropCount++;
            fileObject["content"] = CSharpExpressionConverter.ConvertToken(bodyfilefileContent);
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
        public IWorkflowAction UpdateDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/update-properties/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["displayName"] = CSharpExpressionConverter.ConvertToken(bodydisplayName);
            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyfields != null)
            {
                body["fieldValues"] = CSharpExpressionConverter.ConvertToken(bodyfields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/update-content/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
            bodypropCount++;
            body["content"] = CSharpExpressionConverter.ConvertToken(bodyfileContent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction CheckInDocument(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/check-in/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction CheckOutDocument(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/check-out/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/get/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponse> GetDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/get-properties/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentContentResponse> GetDocumentContent(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/get-content/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetDocumentVersionContentResponse> GetDocumentVersionContent(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/get-content/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentVersionContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/delete/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction DeleteDocumentVersion(Expression<Func<string>> id, Expression<Func<string>> versionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/delete/{0}/version/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<Version[]> GetDocumentVersions(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/document/get-versions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Version[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateFolder(Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyparentID = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/folder/create/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyparentID != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentID);
                bodypropCount++;
            }

            if (bodyfields != null)
            {
                body["fieldValues"] = CSharpExpressionConverter.ConvertToken(bodyfields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription = null, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/folder/update/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyfields != null)
            {
                body["fieldValues"] = CSharpExpressionConverter.ConvertToken(bodyfields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetFolderResponse> GetFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/folder/get/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction DeleteFolder(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/folder/delete/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> GetFolderChildren(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/folder/get-children/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction AddReferenceToFolder(Expression<Func<string>> sourceId, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/folder/add-reference/{0}/to/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sourceId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction RemoveReferenceFromFolder(Expression<Func<string>> sourceId, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/folder/remove-reference/{0}/from/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sourceId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> SimpleSearch(Expression<Func<string>> bodysearchValue)
        {
            var apiCallPath = "/api/search/simple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodysearchValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[]> AdvancedSearch(Expression<Func<string>> bodyquery, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodylimit = null)
        {
            var apiCallPath = "/api/search/advanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
            if (bodystart != null)
            {
                body["start"] = CSharpExpressionConverter.ConvertToken(bodystart);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = CSharpExpressionConverter.ConvertToken(bodylimit);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[]> GetTrustees(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/security/get/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TrusteeRead[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction AddTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/security/add/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/security/update/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction RemoveTrustees(Expression<Func<string>> id, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/security/remove/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction OverrideTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/security/override/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string> CreateLookupEntry(Expression<Func<string>> configurationKey, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/lookup-entry/create/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfields != null)
            {
                body["fieldValues"] = CSharpExpressionConverter.ConvertToken(bodyfields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction UpdateLookupEntry(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<bodyfieldsInputItem[]>> bodyfields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/lookup-entry/update/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfields != null)
            {
                body["fieldValues"] = CSharpExpressionConverter.ConvertToken(bodyfields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<GetLookupEntriesResponseItem[]> GetLookupEntries(Expression<Func<string>> configurationKey, Expression<Func<string>> filter = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/lookup-entry/get-all/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            return new ApiConnectionAction<GetLookupEntriesResponseItem[]>(callPayload);
        }
    }

    public class OpentextedocsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DocumentCreated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
                parentObject["id"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
                filterObjectpropCount++;
            }

            if (bodyfiltermetadata != null)
            {
                filterObject["metadata"] = CSharpExpressionConverter.ConvertToken(bodyfiltermetadata);
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

        public IWorkflowTrigger DocumentContentUpdated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
                parentObject["id"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
                filterObjectpropCount++;
            }

            if (bodyfiltermetadata != null)
            {
                filterObject["metadata"] = CSharpExpressionConverter.ConvertToken(bodyfiltermetadata);
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

        public IWorkflowTrigger DocumentPropertiesUpdated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
                parentObject["id"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
                filterObjectpropCount++;
            }

            if (bodyfiltermetadata != null)
            {
                filterObject["metadata"] = CSharpExpressionConverter.ConvertToken(bodyfiltermetadata);
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

        public IWorkflowTrigger DocumentDeleted(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
                parentObject["id"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
                filterObjectpropCount++;
            }

            if (bodyfiltermetadata != null)
            {
                filterObject["metadata"] = CSharpExpressionConverter.ConvertToken(bodyfiltermetadata);
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

        public IWorkflowTrigger FolderCreated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
                parentObject["id"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
                filterObjectpropCount++;
            }

            if (bodyfiltermetadata != null)
            {
                filterObject["metadata"] = CSharpExpressionConverter.ConvertToken(bodyfiltermetadata);
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

        public IWorkflowTrigger FolderUpdated(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
                parentObject["id"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
                filterObjectpropCount++;
            }

            if (bodyfiltermetadata != null)
            {
                filterObject["metadata"] = CSharpExpressionConverter.ConvertToken(bodyfiltermetadata);
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

        public IWorkflowTrigger FolderDeleted(Expression<Func<int>> bodyfilterparentparentID = null, Expression<Func<int>> bodyfilterparentparentDepth = null, Expression<Func<bodyfiltermetadataInputItem[]>> bodyfiltermetadata = null, string triggerName = null, FlowRecurrence recurrence = null)
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
                parentObject["id"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentID);
                parentObjectpropCount++;
            }

            if (bodyfilterparentparentDepth != null)
            {
                parentObject["depth"] = CSharpExpressionConverter.ConvertToken(bodyfilterparentparentDepth);
                parentObjectpropCount++;
            }

            if (parentObjectpropCount > 0)
            {
                filterObject["parent"] = parentObject;
                filterObjectpropCount++;
            }

            if (bodyfiltermetadata != null)
            {
                filterObject["metadata"] = CSharpExpressionConverter.ConvertToken(bodyfiltermetadata);
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