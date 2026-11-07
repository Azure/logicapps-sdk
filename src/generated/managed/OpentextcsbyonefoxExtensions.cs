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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnreserveDocument(Expression<Func<string>> id)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReserveDocument(Expression<Func<string>> id)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveDocument(Expression<Func<string>> id, Expression<Func<string>> parentId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/move/{0}/to/{1}", __workflow_id.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CopyDocument(Expression<Func<string>> id, Expression<Func<string>> parentId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/document/copy/{0}/to/{1}", __workflow_id.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<ResultItem[], ApiConnectionActionConfiguration> SimpleSearch(Expression<Func<string>> configurationKey, Expression<Func<SimpleSearchBodyInput>> body)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/search/simple/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExecuteWebReport(Expression<Func<string>> id, Expression<Func<BodyInputItem[]>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/command/execute/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<TrusteeRead[], ApiConnectionActionConfiguration> GetItemTrustees(Expression<Func<string>> id)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<GetBusinessWorkspaceResponse, ApiConnectionActionConfiguration> GetBusinessWorkspace(Expression<Func<string>> id, Expression<Func<string>> configurationKey)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            return new DeferredBodyAction<GetBusinessWorkspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/workspace/get/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBusinessWorkspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateBusinessWorkspace(Expression<Func<string>> configurationKey, Expression<Func<CreateBusinessWorkspaceBodyInput>> body)
        {
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/workspace/create/{0}", __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateBusinessWorkspace(Expression<Func<string>> id, Expression<Func<string>> configurationKey, Expression<Func<UpdateBusinessWorkspaceBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationKey = WorkflowExpression.Compile(configurationKey, nameof(configurationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/workspace/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextcsbyonefox")]
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
    }

    public class OpentextcsbyonefoxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DocumentCreated(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
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

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DocumentUpdated(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/DocumentUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DocumentDeleted(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
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

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FolderCreated(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
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

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FolderUpdated(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
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

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FolderDeleted(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
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

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> BusinessWorkspaceCreated(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> BusinessWorkspaceUpdated(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> BusinessWorkspaceDeleted(Expression<Func<BusinessWorkspaceCreatedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/web-hook/create/BusinessWorkspaceDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class UpdateDocumentContentBodyInput
    {
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
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class AdvancedSearchBodyInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }
    }

    public class BodyInputItem
    {
        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
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
        [JsonProperty("trusteeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("trusteeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "custom";

        [JsonProperty("accessRights", DefaultValueHandling = DefaultValueHandling.Include)]
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
        public string Id { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class CreateBusinessWorkspaceBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentId { get; set; }

        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class CreateDocumentBodyInput
    {
        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentId { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentMetadataV2 Metadata { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public File File { get; set; }
    }

    public class DocumentMetadataV2
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class File
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }
    }

    public class CreateFolderBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentId { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class UpdateBusinessWorkspaceBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class UpdateDocumentBodyInput
    {
        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentMetadataV2 Metadata { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public File File { get; set; }
    }

    public class UpdateDocumentPropertiesBodyInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class UpdateFolderBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Fields { get; set; }
    }

    public class BusinessWorkspaceCreatedBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
        public BodyInputFilterType Filter { get; set; }
    }

    public class BodyInputFilterType
    {
        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("ancestorId")]
        public string AncestorId { get; set; }

        [JsonProperty("metadata")]
        public BodyInputFilterTypeMetadataTypeItem[] Metadata { get; set; }
    }

    public class BodyInputFilterTypeMetadataTypeItem
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