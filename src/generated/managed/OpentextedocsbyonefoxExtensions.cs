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
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<UpdateDocumentContentBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/update-content/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<ResultItem[], ApiConnectionActionConfiguration> SimpleSearch(Expression<Func<SimpleSearchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/search/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<ResultItem[], ApiConnectionActionConfiguration> AdvancedSearch(Expression<Func<AdvancedSearchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/search/advanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveTrustees(Expression<Func<string>> id, Expression<Func<string[]>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> OverrideTrustees(Expression<Func<string>> id, Expression<Func<TrusteeWrite[]>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<string>> configurationKey, Expression<Func<CreateDocumentBodyInput>> body)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/document/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateFolder(Expression<Func<string>> configurationKey, Expression<Func<CreateFolderBodyInput>> body)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/folder/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateLookupEntry(Expression<Func<string>> configurationKey, Expression<Func<CreateLookupEntryBodyInput>> body)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/lookup-entry/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<UpdateDocumentBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/document/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<UpdateDocumentPropertiesBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/document/update-properties/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateFolder(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<UpdateFolderBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/folder/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextedocsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateLookupEntry(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<CreateLookupEntryBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/lookup-entry/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class OpentextedocsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DocumentCreated(Expression<Func<DocumentContentUpdatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DocumentContentUpdated(Expression<Func<DocumentContentUpdatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentContentUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DocumentPropertiesUpdated(Expression<Func<DocumentContentUpdatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentPropertiesUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DocumentDeleted(Expression<Func<DocumentContentUpdatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FolderCreated(Expression<Func<DocumentContentUpdatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/FolderCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FolderUpdated(Expression<Func<DocumentContentUpdatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/FolderUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FolderDeleted(Expression<Func<DocumentContentUpdatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/FolderDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> ItemDeleted()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/ItemDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new ItemDeletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class UpdateDocumentContentBodyInput
    {
        public UpdateDocumentContentBodyInput(string fileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent)
        {
            this.FileName = fileName;
            this.FileContent = fileContent;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }
    }

    public class GetDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

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
        public string VersionId { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SimpleSearchBodyInput
    {
        public SimpleSearchBodyInput(string searchValue)
        {
            this.SearchValue = searchValue;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchValue { get; set; }
    }

    public class AdvancedSearchBodyInput
    {
        public AdvancedSearchBodyInput(string query)
        {
            this.Query = query;
        }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }
    }

    public class TrusteeRead
    {
        [JsonProperty("trusteeId")]
        public string Id { get; set; }

        [JsonProperty("trusteeType")]
        public string Type { get; set; }

        [JsonProperty("accessRights")]
        public string[] AccessRights { get; set; }
    }

    public class TrusteeWrite
    {
        public TrusteeWrite(string id, string[] accessRights)
        {
            this.Id = id;
            this.AccessRights = accessRights;
        }

        [JsonProperty("trusteeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("trusteeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public TrusteeWriteTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Opentextedocsbyonefox.TrusteeWriteTypeType.User;

        [JsonProperty("accessRights", DefaultValueHandling = DefaultValueHandling.Include)]
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
        public string Id { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class CreateDocumentBodyInput
    {
        public CreateDocumentBodyInput(DocumentMetadataV2 metadata, File @file)
        {
            this.Metadata = metadata;
            this.File = @file;
        }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentMetadataV2 Metadata { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public File File { get; set; }
    }

    public class DocumentMetadataV2
    {
        public DocumentMetadataV2(string displayName, JToken fields)
        {
            this.DisplayName = displayName;
            this.Fields = fields;
        }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class File
    {
        public File(string fileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent)
        {
            this.FileName = fileName;
            this.FileContent = fileContent;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }
    }

    public class CreateFolderBodyInput
    {
        public CreateFolderBodyInput(string name, JToken fields)
        {
            this.Name = name;
            this.Fields = fields;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class CreateLookupEntryBodyInput
    {
        public CreateLookupEntryBodyInput(JToken fields)
        {
            this.Fields = fields;
        }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class UpdateDocumentBodyInput
    {
        public UpdateDocumentBodyInput(DocumentMetadataV2 metadata, File @file)
        {
            this.Metadata = metadata;
            this.File = @file;
        }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentMetadataV2 Metadata { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public File File { get; set; }
    }

    public class UpdateDocumentPropertiesBodyInput
    {
        public UpdateDocumentPropertiesBodyInput(string displayName, JToken fields)
        {
            this.DisplayName = displayName;
            this.Fields = fields;
        }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class UpdateFolderBodyInput
    {
        public UpdateFolderBodyInput(string name, JToken fields)
        {
            this.Name = name;
            this.Fields = fields;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class DocumentContentUpdatedBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
        public BodyInputFilterType Filter { get; set; }
    }

    public class BodyInputFilterType
    {
        [JsonProperty("parent")]
        public BodyInputFilterTypeParentType Parent { get; set; }

        [JsonProperty("metadata")]
        public BodyInputFilterTypeMetadataTypeItem[] Metadata { get; set; }
    }

    public class BodyInputFilterTypeParentType
    {
        [JsonProperty("id")]
        public int? ParentId { get; set; }

        [JsonProperty("depth")]
        public int? ParentDepth { get; set; }
    }

    public class BodyInputFilterTypeMetadataTypeItem
    {
        [JsonProperty("column")]
        public string Column { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ItemDeletedBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
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