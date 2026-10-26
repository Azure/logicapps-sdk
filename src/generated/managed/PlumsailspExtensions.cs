//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailsp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailspActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCreateSiteFromTemplate(Expression<Func<FlowV1SharePointFlowJobsCreateSiteFromTemplatePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<WebUrlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateSiteFromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<WebUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsChangePermissions(Expression<Func<actionTypeInput>> actionType, Expression<Func<targetInput>> target, Expression<Func<object>> request)
        {
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: true);
            var __workflow_target = WorkflowExpression.Compile(target, nameof(target), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ChangePermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(__workflow_actionType);
                callPayload.Queries["target"] = ExpressionConverter.Convert(__workflow_target);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsActivateFeature(Expression<Func<FlowV1SharePointFlowJobsActivateFeaturePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ActivateFeature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsDeactivateFeature(Expression<Func<FlowV1SharePointFlowJobsDeactivateFeaturePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeactivateFeature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCreateListOrLibrary(Expression<Func<FlowV1SharePointFlowJobsCreateListOrLibraryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateListOrLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsSetDefaultSiteGroup(Expression<Func<FlowV1SharePointFlowJobsSetDefaultSiteGroupPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/SetDefaultSiteGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCopyDocumentFromLibrary(Expression<Func<FlowV1SharePointFlowJobsCopyDocumentFromLibraryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<DocumentInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyDocumentFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsMoveDocumentFromLibrary(Expression<Func<FlowV1SharePointFlowJobsMoveDocumentFromLibraryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<DocumentInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveDocumentFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRemoveDocumentByUrl(Expression<Func<FlowV1SharePointFlowJobsRemoveDocumentByUrlPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveDocumentByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCreateDocumentSet(Expression<Func<FlowV1SharePointFlowJobsCreateDocumentSetPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<DocumentSetInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateDocumentSet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<DocumentSetInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCopyDocumentSet(Expression<Func<FlowV1SharePointFlowJobsCopyDocumentSetPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<DocumentSetInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyDocumentSet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<DocumentSetInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsMoveDocumentSet(Expression<Func<FlowV1SharePointFlowJobsMoveDocumentSetPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<DocumentSetInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveDocumentSet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<DocumentSetInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCreateFolderByUrl(Expression<Func<FlowV1SharePointFlowJobsCreateFolderByUrlPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<FolderInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateFolderByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<FolderInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCreateFolderInList(Expression<Func<FlowV1SharePointFlowJobsCreateFolderInListPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<FolderInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateFolderInList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<FolderInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRemoveFolderByUrl(Expression<Func<FlowV1SharePointFlowJobsRemoveFolderByUrlPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveFolderByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCopyFolderFromLibrary(Expression<Func<FlowV1SharePointFlowJobsCopyFolderFromLibraryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<FolderInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyFolderFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<FolderInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsMoveFolderFromLibrary(Expression<Func<FlowV1SharePointFlowJobsMoveFolderFromLibraryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<FolderInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveFolderFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<FolderInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCheckInDocument(Expression<Func<FlowV1SharePointFlowJobsCheckInDocumentPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<DocumentInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckInDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCheckOutDocument(Expression<Func<FlowV1SharePointFlowJobsCheckOutDocumentPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<DocumentInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckOutDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCreateModernSite(Expression<Func<siteTypeInput>> siteType, Expression<Func<object>> request)
        {
            var __workflow_siteType = WorkflowExpression.Compile(siteType, nameof(siteType), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<WebUrlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateModernSite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteType"] = ExpressionConverter.Convert(__workflow_siteType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<WebUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsApplySiteDesign(Expression<Func<FlowV1SharePointFlowJobsApplySiteDesignPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<WebUrlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ApplySiteDesign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<WebUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCreateSharePointGroup(Expression<Func<FlowV1SharePointFlowJobsCreateSharePointGroupPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRemoveSharePointGroup(Expression<Func<FlowV1SharePointFlowJobsRemoveSharePointGroupPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsUpdateSharePointGroupProperties(Expression<Func<FlowV1SharePointFlowJobsUpdateSharePointGroupPropertiesPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateSharePointGroupProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<GroupExistResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCheckSharePointGroupExists(Expression<Func<FlowV1SharePointFlowJobsCheckSharePointGroupExistsPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<GroupExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckSharePointGroupExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<GroupExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsAddUserToSharePointGroup(Expression<Func<FlowV1SharePointFlowJobsAddUserToSharePointGroupPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddUserToSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRemoveUserFromSharePointGroup(Expression<Func<FlowV1SharePointFlowJobsRemoveUserFromSharePointGroupPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveUserFromSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<GetSPGroupMembersResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsGetSharePointGroupMembers(Expression<Func<FlowV1SharePointFlowJobsGetSharePointGroupMembersPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<GetSPGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetSharePointGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<GetSPGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<UserExistsResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsUserExistInSharePointGroup(Expression<Func<FlowV1SharePointFlowJobsUserExistInSharePointGroupPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<UserExistsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UserExistInSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<UserExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsUpdateSharePointSiteProperties(Expression<Func<FlowV1SharePointFlowJobsUpdateSharePointSitePropertiesPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateSharePointSiteProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsDeleteSharePointSite(Expression<Func<FlowV1SharePointFlowJobsDeleteSharePointSitePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeleteSharePointSite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<SPSiteOptionValueResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsString(Expression<Func<FlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsStringPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<SPSiteOptionValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetSharePointSiteOptionValueAsString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<SPSiteOptionValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsInviteExternalUserToSharePoint(Expression<Func<targetInput>> target, Expression<Func<object>> request)
        {
            var __workflow_target = WorkflowExpression.Compile(target, nameof(target), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/InviteExternalUserToSharePoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["target"] = ExpressionConverter.Convert(__workflow_target);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListFileUrlsResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCopyAttachmentsToUrl(Expression<Func<FlowV1SharePointFlowJobsCopyAttachmentsToUrlPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ListFileUrlsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyAttachmentsToUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ListFileUrlsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListFileUrlsResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsMoveAttachmentsToUrl(Expression<Func<FlowV1SharePointFlowJobsMoveAttachmentsToUrlPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ListFileUrlsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveAttachmentsToUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ListFileUrlsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsAddContentTypeToSharePointList(Expression<Func<FlowV1SharePointFlowJobsAddContentTypeToSharePointListPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddContentTypeToSharePointList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListItemIdResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsCopyListItemToSharePointList(Expression<Func<FlowV1SharePointFlowJobsCopyListItemToSharePointListPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ListItemIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyListItemToSharePointList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ListItemIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListItemIdResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsMoveListItemToSharePointList(Expression<Func<FlowV1SharePointFlowJobsMoveListItemToSharePointListPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ListItemIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveListItemToSharePointList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ListItemIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WorkflowGuidResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsStartListWorkflow(Expression<Func<FlowV1SharePointFlowJobsStartListWorkflowPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<WorkflowGuidResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/StartListWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<WorkflowGuidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WorkflowGuidResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsStartSiteWorkflow(Expression<Func<FlowV1SharePointFlowJobsStartSiteWorkflowPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<WorkflowGuidResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/StartSiteWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<WorkflowGuidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsGetItemsByCamlQuery(Expression<Func<FlowV1SharePointFlowJobsGetItemsByCamlQueryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetItemsByCamlQuery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<VersionsHistoryResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsGetVersionsHistory(Expression<Func<FlowV1SharePointFlowJobsGetVersionsHistoryPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<VersionsHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetVersionsHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<VersionsHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsProvisionPnPTemplate(Expression<Func<FlowV1SharePointFlowJobsProvisionPnPTemplatePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ProvisionPnPTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsProvisionPnPTenantTemplate(Expression<Func<FlowV1SharePointFlowJobsProvisionPnPTenantTemplatePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ProvisionPnPTenantTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsAddSiteNavigation(Expression<Func<FlowV1SharePointFlowJobsAddSiteNavigationPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddSiteNavigation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRemoveSiteNavigation(Expression<Func<FlowV1SharePointFlowJobsRemoveSiteNavigationPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveSiteNavigation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsUpdateListItem(Expression<Func<FlowV1SharePointFlowJobsUpdateListItemPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateListItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsDeclareDocumentAsRecord(Expression<Func<FlowV1SharePointFlowJobsDeclareDocumentAsRecordPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeclareDocumentAsRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsUndeclareDocumentAsRecord(Expression<Func<FlowV1SharePointFlowJobsUndeclareDocumentAsRecordPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UndeclareDocumentAsRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsParseCsv(Expression<Func<FlowV1SharePointFlowJobsParseCsvPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ParseCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRegExpMatch(Expression<Func<FlowV1SharePointFlowJobsRegExpMatchPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpMatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<StringResultResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRegExpReplace(Expression<Func<FlowV1SharePointFlowJobsRegExpReplacePostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<StringResultResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpReplace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<StringResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<BooleanResultResponse, ApiConnectionActionConfiguration> FlowV1SharePointFlowJobsRegExpTest(Expression<Func<FlowV1SharePointFlowJobsRegExpTestPostInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<BooleanResultResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpTest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<BooleanResultResponse>(callPayload);
            });
        }
    }

    public class PlumsailspTriggers([ConnectionName] string connectionId)
    {
    }

    public class WebUrlResponse
    {
        [JsonProperty("url")]
        public string WebURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsCreateSiteFromTemplatePostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Template { get; set; }

        [JsonProperty("leafUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LeafURL { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lcid")]
        public int? Lcid { get; set; }

        [JsonProperty("inheritPermissions")]
        public bool? InheritPermissions { get; set; }

        [JsonProperty("inheritNavigation")]
        public bool? InheritNavigation { get; set; }

        [JsonProperty("onTopNav")]
        public bool? OnTopNavigation { get; set; }

        [JsonProperty("onQuickLaunch")]
        public bool? OnQuickLaunch { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actionTypeInput
    {
        Grant,
        Remove,
        RemoveAll,
        RestoreInheritance
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum targetInput
    {
        Site,
        Item,
        Group
    }

    public class FlowV1SharePointFlowJobsActivateFeaturePostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("featureId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeatureId { get; set; }

        [JsonProperty("force")]
        public bool? Force { get; set; }
    }

    public class FlowV1SharePointFlowJobsDeactivateFeaturePostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("featureId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeatureId { get; set; }

        [JsonProperty("force")]
        public bool? Force { get; set; }
    }

    public class FlowV1SharePointFlowJobsCreateListOrLibraryPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Template { get; set; }

        [JsonProperty("partialUrl")]
        public string PartialURL { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("onQuickLaunch")]
        public bool? OnQuickLaunch { get; set; }
    }

    public class FlowV1SharePointFlowJobsSetDefaultSiteGroupPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupType", DefaultValueHandling = DefaultValueHandling.Include)]
        public FlowV1SharePointFlowJobsSetDefaultSiteGroupPostInputGroupTypeType GroupType { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FlowV1SharePointFlowJobsSetDefaultSiteGroupPostInputGroupTypeType
    {
        Owner,
        Member,
        Visitor
    }

    public class DocumentInfoResponse
    {
        [JsonProperty("id")]
        public int DocumentId { get; set; }

        [JsonProperty("url")]
        public string DocumentURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsCopyDocumentFromLibraryPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURL { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsMoveDocumentFromLibraryPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURL { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsRemoveDocumentByUrlPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentURL { get; set; }
    }

    public class DocumentSetInfoResponse
    {
        [JsonProperty("id")]
        public int DocumentSetId { get; set; }

        [JsonProperty("url")]
        public string DocumentSetURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsCreateDocumentSetPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("documentSetName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentSetName { get; set; }

        [JsonProperty("targetListUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetList { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }

    public class FlowV1SharePointFlowJobsCopyDocumentSetPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURL { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsMoveDocumentSetPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURL { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationURL { get; set; }
    }

    public class FolderInfoResponse
    {
        [JsonProperty("id")]
        public int FolderId { get; set; }

        [JsonProperty("url")]
        public string FolderURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsCreateFolderByUrlPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("folderUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsCreateFolderInListPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("targetListUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetList { get; set; }

        [JsonProperty("folderPath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }
    }

    public class FlowV1SharePointFlowJobsRemoveFolderByUrlPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsCopyFolderFromLibraryPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURL { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsMoveFolderFromLibraryPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("sourceUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURL { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsCheckInDocumentPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("documentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentURL { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class FlowV1SharePointFlowJobsCheckOutDocumentPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("documentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentURL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum siteTypeInput
    {
        TeamSite,
        CommunicationSite,
        TeamSiteWithoutGroup
    }

    public class FlowV1SharePointFlowJobsApplySiteDesignPostInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("siteDesign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteDesign { get; set; }
    }

    public class FlowV1SharePointFlowJobsCreateSharePointGroupPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty("groupDescription")]
        public string GroupDescription { get; set; }

        [JsonProperty("userLogin")]
        public string GroupOwner { get; set; }
    }

    public class FlowV1SharePointFlowJobsRemoveSharePointGroupPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }
    }

    public class FlowV1SharePointFlowJobsUpdateSharePointGroupPropertiesPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public SPGroupProperties Properties { get; set; }
    }

    public class SPGroupProperties
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("allowMembersEditMembership")]
        public bool AllowMembersEditMembership { get; set; }

        [JsonProperty("allowRequestToJoinLeave")]
        public bool AllowRequestToJoinLeave { get; set; }

        [JsonProperty("autoAcceptRequestToJoinLeave")]
        public bool AutoAcceptRequestToJoinLeave { get; set; }

        [JsonProperty("onlyAllowMembersViewMembership")]
        public bool OnlyAllowMembersViewMembership { get; set; }

        [JsonProperty("requestToJoinLeaveEmailSetting")]
        public string RequestToJoinLeaveEmailSetting { get; set; }
    }

    public class GroupExistResponse
    {
        [JsonProperty("groupExists")]
        public bool GroupExists { get; set; }
    }

    public class FlowV1SharePointFlowJobsCheckSharePointGroupExistsPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }
    }

    public class FlowV1SharePointFlowJobsAddUserToSharePointGroupPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty("userLogin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("sendEmail")]
        public bool? SendEmail { get; set; }
    }

    public class FlowV1SharePointFlowJobsRemoveUserFromSharePointGroupPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty("userLogin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }
    }

    public class GetSPGroupMembersResponse
    {
        [JsonProperty("users")]
        public SharePointUserResponse[] Users { get; set; }
    }

    public class SharePointUserResponse
    {
        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("loginName")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string UserEmail { get; set; }

        [JsonProperty("claims")]
        public string UserClaims { get; set; }
    }

    public class FlowV1SharePointFlowJobsGetSharePointGroupMembersPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }
    }

    public class UserExistsResponse
    {
        [JsonProperty("userExists")]
        public bool UserExists { get; set; }
    }

    public class FlowV1SharePointFlowJobsUserExistInSharePointGroupPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("groupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty("userLogin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }
    }

    public class FlowV1SharePointFlowJobsUpdateSharePointSitePropertiesPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public SPWebProperties Properties { get; set; }
    }

    public class SPWebProperties
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quickLaunchEnabled")]
        public bool QuickLaunchEnabled { get; set; }

        [JsonProperty("treeViewEnabled")]
        public bool TreeViewEnabled { get; set; }

        [JsonProperty("siteLogoUrl")]
        public string SiteLogoURL { get; set; }

        [JsonProperty("alternateCssUrl")]
        public string AlternateCssURL { get; set; }

        [JsonProperty("associatedMemberGroup")]
        public string AssociatedMemberGroup { get; set; }

        [JsonProperty("associatedOwnerGroup")]
        public string AssociatedOwnerGroup { get; set; }

        [JsonProperty("associatedVisitorGroup")]
        public string AssociatedVisitorGroup { get; set; }

        [JsonProperty("containsConfidentialInfo")]
        public bool ContainsConfidentialInfo { get; set; }

        [JsonProperty("customMasterUrl")]
        public string CustomMasterURL { get; set; }

        [JsonProperty("enableMinimalDownload")]
        public bool EnableMinimalDownload { get; set; }

        [JsonProperty("isMultilingual")]
        public bool IsMultilingual { get; set; }

        [JsonProperty("masterUrl")]
        public string MasterURL { get; set; }

        [JsonProperty("membersCanShare")]
        public bool MembersCanShare { get; set; }

        [JsonProperty("noCrawl")]
        public bool NoCrawl { get; set; }

        [JsonProperty("overwriteTranslationsOnChange")]
        public bool OverwriteTranslationsOnChange { get; set; }

        [JsonProperty("requestAccessEmail")]
        public string RequestAccessEmail { get; set; }

        [JsonProperty("saveSiteAsTemplateEnabled")]
        public bool SaveSiteAsTemplateEnabled { get; set; }

        [JsonProperty("serverRelativeUrl")]
        public string ServerRelativeURL { get; set; }

        [JsonProperty("syndicationEnabled")]
        public bool SyndicationEnabled { get; set; }

        [JsonProperty("uiVersion")]
        public int UIVersion { get; set; }
    }

    public class FlowV1SharePointFlowJobsDeleteSharePointSitePostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }
    }

    public class SPSiteOptionValueResponse
    {
        [JsonProperty("optionValue")]
        public string OptionValue { get; set; }
    }

    public class FlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsStringPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("optionName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OptionName { get; set; }
    }

    public class ListFileUrlsResponse
    {
        [JsonProperty("fileUrls")]
        public string[] FileURLs { get; set; }
    }

    public class FlowV1SharePointFlowJobsCopyAttachmentsToUrlPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ItemId { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationFolderURL { get; set; }

        [JsonProperty("overwrite")]
        public bool? Overwrite { get; set; }
    }

    public class FlowV1SharePointFlowJobsMoveAttachmentsToUrlPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ItemId { get; set; }

        [JsonProperty("destinationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationFolderURL { get; set; }

        [JsonProperty("overwrite")]
        public bool? Overwrite { get; set; }
    }

    public class FlowV1SharePointFlowJobsAddContentTypeToSharePointListPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("contentTypeName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeName { get; set; }

        [JsonProperty("makeItDefault")]
        public bool? MakeItDefault { get; set; }
    }

    public class ListItemIdResponse
    {
        [JsonProperty("resultItemId")]
        public int ResultItemId { get; set; }
    }

    public class FlowV1SharePointFlowJobsCopyListItemToSharePointListPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemId { get; set; }

        [JsonProperty("destinationListUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationListURL { get; set; }

        [JsonProperty("copyAttachments")]
        public bool? CopyAttachments { get; set; }
    }

    public class FlowV1SharePointFlowJobsMoveListItemToSharePointListPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemId { get; set; }

        [JsonProperty("destinationListUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationListURL { get; set; }

        [JsonProperty("copyAttachments")]
        public bool? MoveAttachments { get; set; }
    }

    public class WorkflowGuidResponse
    {
        [JsonProperty("workflowGuid")]
        public string WorkflowGUID { get; set; }
    }

    public class FlowV1SharePointFlowJobsStartListWorkflowPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("workflowName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkflowName { get; set; }

        [JsonProperty("inputParameters")]
        public JToken InputParameters { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ItemId { get; set; }
    }

    public class FlowV1SharePointFlowJobsStartSiteWorkflowPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("workflowName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkflowName { get; set; }

        [JsonProperty("inputParameters")]
        public JToken InputParameters { get; set; }
    }

    public class FlowV1SharePointFlowJobsGetItemsByCamlQueryPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("folderUrl")]
        public string FolderURL { get; set; }

        [JsonProperty("camlQuery", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CAMLQuery { get; set; }
    }

    public class VersionsHistoryResponse
    {
        [JsonProperty("countVersions")]
        public int CountVersions { get; set; }

        [JsonProperty("versions")]
        public SharePointVersionResponse[] Versions { get; set; }
    }

    public class SharePointVersionResponse
    {
        [JsonProperty("editor")]
        public SharePointUserResponse Editor { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class FlowV1SharePointFlowJobsGetVersionsHistoryPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListURL { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ItemId { get; set; }

        [JsonProperty("fieldName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }
    }

    public class FlowV1SharePointFlowJobsProvisionPnPTemplatePostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("xmlTemplateContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateContent { get; set; }

        [JsonProperty("overwriteSystemPropertyBagValues")]
        public bool? OverwriteSystemPropertyBagValues { get; set; }

        [JsonProperty("ignoreDuplicateDataRowErrors")]
        public bool? IgnoreDuplicateDataRowErrors { get; set; }

        [JsonProperty("clearNavigation")]
        public bool? ClearNavigation { get; set; }

        [JsonProperty("provisionContentTypesToSubWebs")]
        public bool? ProvisionContentTypesToSubWebs { get; set; }

        [JsonProperty("provisionFieldsToSubWebs")]
        public bool? ProvisionFieldsToSubWebs { get; set; }

        [JsonProperty("handlers")]
        public string Handlers { get; set; }

        [JsonProperty("excludeHandlers")]
        public string ExcludeHandlers { get; set; }

        [JsonProperty("parameters")]
        public string Parameters { get; set; }
    }

    public class FlowV1SharePointFlowJobsProvisionPnPTenantTemplatePostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("xmlTemplateContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateContent { get; set; }

        [JsonProperty("overwriteSystemPropertyBagValues")]
        public bool? OverwriteSystemPropertyBagValues { get; set; }

        [JsonProperty("ignoreDuplicateDataRowErrors")]
        public bool? IgnoreDuplicateDataRowErrors { get; set; }

        [JsonProperty("clearNavigation")]
        public bool? ClearNavigation { get; set; }

        [JsonProperty("provisionContentTypesToSubWebs")]
        public bool? ProvisionContentTypesToSubWebs { get; set; }

        [JsonProperty("provisionFieldsToSubWebs")]
        public bool? ProvisionFieldsToSubWebs { get; set; }

        [JsonProperty("handlers")]
        public string Handlers { get; set; }

        [JsonProperty("excludeHandlers")]
        public string ExcludeHandlers { get; set; }

        [JsonProperty("parameters")]
        public string Parameters { get; set; }
    }

    public class FlowV1SharePointFlowJobsAddSiteNavigationPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public FlowV1SharePointFlowJobsAddSiteNavigationPostInputLocationType Location { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("prepend")]
        public bool? Prepend { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FlowV1SharePointFlowJobsAddSiteNavigationPostInputLocationType
    {
        Top,
        QuickLaunch
    }

    public class FlowV1SharePointFlowJobsRemoveSiteNavigationPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public FlowV1SharePointFlowJobsRemoveSiteNavigationPostInputLocationType Location { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FlowV1SharePointFlowJobsRemoveSiteNavigationPostInputLocationType
    {
        Top,
        QuickLaunch
    }

    public class FlowV1SharePointFlowJobsUpdateListItemPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemIdOrURL { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken FieldValues { get; set; }
    }

    public class FlowV1SharePointFlowJobsDeclareDocumentAsRecordPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemIdOrURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsUndeclareDocumentAsRecordPostInput
    {
        [JsonProperty("spUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SharePointSiteURL { get; set; }

        [JsonProperty("listName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListName { get; set; }

        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemIdOrURL { get; set; }
    }

    public class FlowV1SharePointFlowJobsParseCsvPostInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentOfCSVDocument { get; set; }

        [JsonProperty("delimiter")]
        public FlowV1SharePointFlowJobsParseCsvPostInputDelimiterType? Delimiter { get; set; }

        [JsonProperty("locale", DefaultValueHandling = DefaultValueHandling.Include)]
        public FlowV1SharePointFlowJobsParseCsvPostInputLocaleType? Locale { get; set; } = FlowV1SharePointFlowJobsParseCsvPostInputLocaleType.EnUS;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("headers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Headers { get; set; }

        [JsonProperty("skipFirstLine")]
        public bool? SkipFirstLine { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FlowV1SharePointFlowJobsParseCsvPostInputDelimiterType
    {
        Comma,
        Semicolon,
        Tab,
        Pipe
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FlowV1SharePointFlowJobsParseCsvPostInputLocaleType
    {
        [EnumMember(Value = "aa-DJ")]
        AaDJ,
        [EnumMember(Value = "aa-ER")]
        AaER,
        [EnumMember(Value = "aa-ET")]
        AaET,
        [EnumMember(Value = "af-NA")]
        AfNA,
        [EnumMember(Value = "af-ZA")]
        AfZA,
        [EnumMember(Value = "agq-CM")]
        AgqCM,
        [EnumMember(Value = "ak-GH")]
        AkGH,
        [EnumMember(Value = "am-ET")]
        AmET,
        [EnumMember(Value = "ar-001")]
        Ar001,
        [EnumMember(Value = "ar-AE")]
        ArAE,
        [EnumMember(Value = "ar-BH")]
        ArBH,
        [EnumMember(Value = "ar-DJ")]
        ArDJ,
        [EnumMember(Value = "ar-DZ")]
        ArDZ,
        [EnumMember(Value = "ar-EG")]
        ArEG,
        [EnumMember(Value = "ar-ER")]
        ArER,
        [EnumMember(Value = "ar-IL")]
        ArIL,
        [EnumMember(Value = "ar-IQ")]
        ArIQ,
        [EnumMember(Value = "ar-JO")]
        ArJO,
        [EnumMember(Value = "ar-KM")]
        ArKM,
        [EnumMember(Value = "ar-KW")]
        ArKW,
        [EnumMember(Value = "ar-LB")]
        ArLB,
        [EnumMember(Value = "ar-LY")]
        ArLY,
        [EnumMember(Value = "ar-MA")]
        ArMA,
        [EnumMember(Value = "ar-MR")]
        ArMR,
        [EnumMember(Value = "ar-OM")]
        ArOM,
        [EnumMember(Value = "ar-PS")]
        ArPS,
        [EnumMember(Value = "ar-QA")]
        ArQA,
        [EnumMember(Value = "ar-SA")]
        ArSA,
        [EnumMember(Value = "ar-SD")]
        ArSD,
        [EnumMember(Value = "ar-SO")]
        ArSO,
        [EnumMember(Value = "ar-SS")]
        ArSS,
        [EnumMember(Value = "ar-SY")]
        ArSY,
        [EnumMember(Value = "ar-TD")]
        ArTD,
        [EnumMember(Value = "ar-TN")]
        ArTN,
        [EnumMember(Value = "ar-YE")]
        ArYE,
        [EnumMember(Value = "arn-CL")]
        ArnCL,
        [EnumMember(Value = "as-IN")]
        AsIN,
        [EnumMember(Value = "asa-TZ")]
        AsaTZ,
        [EnumMember(Value = "ast-ES")]
        AstES,
        [EnumMember(Value = "az-Cyrl-AZ")]
        AzCyrlAZ,
        [EnumMember(Value = "az-Latn-AZ")]
        AzLatnAZ,
        [EnumMember(Value = "ba-RU")]
        BaRU,
        [EnumMember(Value = "bas-CM")]
        BasCM,
        [EnumMember(Value = "be-BY")]
        BeBY,
        [EnumMember(Value = "bem-ZM")]
        BemZM,
        [EnumMember(Value = "bez-TZ")]
        BezTZ,
        [EnumMember(Value = "bg-BG")]
        BgBG,
        [EnumMember(Value = "bm-ML")]
        BmML,
        [EnumMember(Value = "bn-BD")]
        BnBD,
        [EnumMember(Value = "bn-IN")]
        BnIN,
        [EnumMember(Value = "bo-CN")]
        BoCN,
        [EnumMember(Value = "bo-IN")]
        BoIN,
        [EnumMember(Value = "br-FR")]
        BrFR,
        [EnumMember(Value = "brx-IN")]
        BrxIN,
        [EnumMember(Value = "bs-Cyrl-BA")]
        BsCyrlBA,
        [EnumMember(Value = "bs-Latn-BA")]
        BsLatnBA,
        [EnumMember(Value = "byn-ER")]
        BynER,
        [EnumMember(Value = "ca-AD")]
        CaAD,
        [EnumMember(Value = "ca-ES")]
        CaES,
        [EnumMember(Value = "ca-FR")]
        CaFR,
        [EnumMember(Value = "ca-IT")]
        CaIT,
        [EnumMember(Value = "ccp-BD")]
        CcpBD,
        [EnumMember(Value = "ccp-IN")]
        CcpIN,
        [EnumMember(Value = "ce-RU")]
        CeRU,
        [EnumMember(Value = "ceb-PH")]
        CebPH,
        [EnumMember(Value = "cgg-UG")]
        CggUG,
        [EnumMember(Value = "chr-US")]
        ChrUS,
        [EnumMember(Value = "ckb-IQ")]
        CkbIQ,
        [EnumMember(Value = "ckb-IR")]
        CkbIR,
        [EnumMember(Value = "co-FR")]
        CoFR,
        [EnumMember(Value = "cs-CZ")]
        CsCZ,
        [EnumMember(Value = "cu-RU")]
        CuRU,
        [EnumMember(Value = "cy-GB")]
        CyGB,
        [EnumMember(Value = "da-DK")]
        DaDK,
        [EnumMember(Value = "da-GL")]
        DaGL,
        [EnumMember(Value = "dav-KE")]
        DavKE,
        [EnumMember(Value = "de-AT")]
        DeAT,
        [EnumMember(Value = "de-BE")]
        DeBE,
        [EnumMember(Value = "de-CH")]
        DeCH,
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "de-IT")]
        DeIT,
        [EnumMember(Value = "de-LI")]
        DeLI,
        [EnumMember(Value = "de-LU")]
        DeLU,
        [EnumMember(Value = "dje-NE")]
        DjeNE,
        [EnumMember(Value = "dsb-DE")]
        DsbDE,
        [EnumMember(Value = "dua-CM")]
        DuaCM,
        [EnumMember(Value = "dv-MV")]
        DvMV,
        [EnumMember(Value = "dyo-SN")]
        DyoSN,
        [EnumMember(Value = "dz-BT")]
        DzBT,
        [EnumMember(Value = "ebu-KE")]
        EbuKE,
        [EnumMember(Value = "ee-GH")]
        EeGH,
        [EnumMember(Value = "ee-TG")]
        EeTG,
        [EnumMember(Value = "el-CY")]
        ElCY,
        [EnumMember(Value = "el-GR")]
        ElGR,
        [EnumMember(Value = "en-001")]
        En001,
        [EnumMember(Value = "en-150")]
        En150,
        [EnumMember(Value = "en-AE")]
        EnAE,
        [EnumMember(Value = "en-AG")]
        EnAG,
        [EnumMember(Value = "en-AI")]
        EnAI,
        [EnumMember(Value = "en-AS")]
        EnAS,
        [EnumMember(Value = "en-AT")]
        EnAT,
        [EnumMember(Value = "en-AU")]
        EnAU,
        [EnumMember(Value = "en-BB")]
        EnBB,
        [EnumMember(Value = "en-BE")]
        EnBE,
        [EnumMember(Value = "en-BI")]
        EnBI,
        [EnumMember(Value = "en-BM")]
        EnBM,
        [EnumMember(Value = "en-BS")]
        EnBS,
        [EnumMember(Value = "en-BW")]
        EnBW,
        [EnumMember(Value = "en-BZ")]
        EnBZ,
        [EnumMember(Value = "en-CA")]
        EnCA,
        [EnumMember(Value = "en-CC")]
        EnCC,
        [EnumMember(Value = "en-CH")]
        EnCH,
        [EnumMember(Value = "en-CK")]
        EnCK,
        [EnumMember(Value = "en-CM")]
        EnCM,
        [EnumMember(Value = "en-CX")]
        EnCX,
        [EnumMember(Value = "en-CY")]
        EnCY,
        [EnumMember(Value = "en-DE")]
        EnDE,
        [EnumMember(Value = "en-DK")]
        EnDK,
        [EnumMember(Value = "en-DM")]
        EnDM,
        [EnumMember(Value = "en-ER")]
        EnER,
        [EnumMember(Value = "en-FI")]
        EnFI,
        [EnumMember(Value = "en-FJ")]
        EnFJ,
        [EnumMember(Value = "en-FK")]
        EnFK,
        [EnumMember(Value = "en-FM")]
        EnFM,
        [EnumMember(Value = "en-GB")]
        EnGB,
        [EnumMember(Value = "en-GD")]
        EnGD,
        [EnumMember(Value = "en-GG")]
        EnGG,
        [EnumMember(Value = "en-GH")]
        EnGH,
        [EnumMember(Value = "en-GI")]
        EnGI,
        [EnumMember(Value = "en-GM")]
        EnGM,
        [EnumMember(Value = "en-GU")]
        EnGU,
        [EnumMember(Value = "en-GY")]
        EnGY,
        [EnumMember(Value = "en-HK")]
        EnHK,
        [EnumMember(Value = "en-IE")]
        EnIE,
        [EnumMember(Value = "en-IL")]
        EnIL,
        [EnumMember(Value = "en-IM")]
        EnIM,
        [EnumMember(Value = "en-IN")]
        EnIN,
        [EnumMember(Value = "en-IO")]
        EnIO,
        [EnumMember(Value = "en-JE")]
        EnJE,
        [EnumMember(Value = "en-JM")]
        EnJM,
        [EnumMember(Value = "en-KE")]
        EnKE,
        [EnumMember(Value = "en-KI")]
        EnKI,
        [EnumMember(Value = "en-KN")]
        EnKN,
        [EnumMember(Value = "en-KY")]
        EnKY,
        [EnumMember(Value = "en-LC")]
        EnLC,
        [EnumMember(Value = "en-LR")]
        EnLR,
        [EnumMember(Value = "en-LS")]
        EnLS,
        [EnumMember(Value = "en-MG")]
        EnMG,
        [EnumMember(Value = "en-MH")]
        EnMH,
        [EnumMember(Value = "en-MO")]
        EnMO,
        [EnumMember(Value = "en-MP")]
        EnMP,
        [EnumMember(Value = "en-MS")]
        EnMS,
        [EnumMember(Value = "en-MT")]
        EnMT,
        [EnumMember(Value = "en-MU")]
        EnMU,
        [EnumMember(Value = "en-MW")]
        EnMW,
        [EnumMember(Value = "en-MY")]
        EnMY,
        [EnumMember(Value = "en-NA")]
        EnNA,
        [EnumMember(Value = "en-NF")]
        EnNF,
        [EnumMember(Value = "en-NG")]
        EnNG,
        [EnumMember(Value = "en-NL")]
        EnNL,
        [EnumMember(Value = "en-NR")]
        EnNR,
        [EnumMember(Value = "en-NU")]
        EnNU,
        [EnumMember(Value = "en-NZ")]
        EnNZ,
        [EnumMember(Value = "en-PG")]
        EnPG,
        [EnumMember(Value = "en-PH")]
        EnPH,
        [EnumMember(Value = "en-PK")]
        EnPK,
        [EnumMember(Value = "en-PN")]
        EnPN,
        [EnumMember(Value = "en-PR")]
        EnPR,
        [EnumMember(Value = "en-PW")]
        EnPW,
        [EnumMember(Value = "en-RW")]
        EnRW,
        [EnumMember(Value = "en-SB")]
        EnSB,
        [EnumMember(Value = "en-SC")]
        EnSC,
        [EnumMember(Value = "en-SD")]
        EnSD,
        [EnumMember(Value = "en-SE")]
        EnSE,
        [EnumMember(Value = "en-SG")]
        EnSG,
        [EnumMember(Value = "en-SH")]
        EnSH,
        [EnumMember(Value = "en-SI")]
        EnSI,
        [EnumMember(Value = "en-SL")]
        EnSL,
        [EnumMember(Value = "en-SS")]
        EnSS,
        [EnumMember(Value = "en-SX")]
        EnSX,
        [EnumMember(Value = "en-SZ")]
        EnSZ,
        [EnumMember(Value = "en-TC")]
        EnTC,
        [EnumMember(Value = "en-TK")]
        EnTK,
        [EnumMember(Value = "en-TO")]
        EnTO,
        [EnumMember(Value = "en-TT")]
        EnTT,
        [EnumMember(Value = "en-TV")]
        EnTV,
        [EnumMember(Value = "en-TZ")]
        EnTZ,
        [EnumMember(Value = "en-UG")]
        EnUG,
        [EnumMember(Value = "en-UM")]
        EnUM,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "en-US-POSIX")]
        EnUSPOSIX,
        [EnumMember(Value = "en-VC")]
        EnVC,
        [EnumMember(Value = "en-VG")]
        EnVG,
        [EnumMember(Value = "en-VI")]
        EnVI,
        [EnumMember(Value = "en-VU")]
        EnVU,
        [EnumMember(Value = "en-WS")]
        EnWS,
        [EnumMember(Value = "en-ZA")]
        EnZA,
        [EnumMember(Value = "en-ZM")]
        EnZM,
        [EnumMember(Value = "en-ZW")]
        EnZW,
        [EnumMember(Value = "eo-001")]
        Eo001,
        [EnumMember(Value = "es-419")]
        Es419,
        [EnumMember(Value = "es-AR")]
        EsAR,
        [EnumMember(Value = "es-BO")]
        EsBO,
        [EnumMember(Value = "es-BR")]
        EsBR,
        [EnumMember(Value = "es-BZ")]
        EsBZ,
        [EnumMember(Value = "es-CL")]
        EsCL,
        [EnumMember(Value = "es-CO")]
        EsCO,
        [EnumMember(Value = "es-CR")]
        EsCR,
        [EnumMember(Value = "es-CU")]
        EsCU,
        [EnumMember(Value = "es-DO")]
        EsDO,
        [EnumMember(Value = "es-EC")]
        EsEC,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "es-GQ")]
        EsGQ,
        [EnumMember(Value = "es-GT")]
        EsGT,
        [EnumMember(Value = "es-HN")]
        EsHN,
        [EnumMember(Value = "es-MX")]
        EsMX,
        [EnumMember(Value = "es-NI")]
        EsNI,
        [EnumMember(Value = "es-PA")]
        EsPA,
        [EnumMember(Value = "es-PE")]
        EsPE,
        [EnumMember(Value = "es-PH")]
        EsPH,
        [EnumMember(Value = "es-PR")]
        EsPR,
        [EnumMember(Value = "es-PY")]
        EsPY,
        [EnumMember(Value = "es-SV")]
        EsSV,
        [EnumMember(Value = "es-US")]
        EsUS,
        [EnumMember(Value = "es-UY")]
        EsUY,
        [EnumMember(Value = "es-VE")]
        EsVE,
        [EnumMember(Value = "et-EE")]
        EtEE,
        [EnumMember(Value = "eu-ES")]
        EuES,
        [EnumMember(Value = "ewo-CM")]
        EwoCM,
        [EnumMember(Value = "fa-AF")]
        FaAF,
        [EnumMember(Value = "fa-IR")]
        FaIR,
        [EnumMember(Value = "ff-Latn-BF")]
        FfLatnBF,
        [EnumMember(Value = "ff-Latn-CM")]
        FfLatnCM,
        [EnumMember(Value = "ff-Latn-GH")]
        FfLatnGH,
        [EnumMember(Value = "ff-Latn-GM")]
        FfLatnGM,
        [EnumMember(Value = "ff-Latn-GN")]
        FfLatnGN,
        [EnumMember(Value = "ff-Latn-GW")]
        FfLatnGW,
        [EnumMember(Value = "ff-Latn-LR")]
        FfLatnLR,
        [EnumMember(Value = "ff-Latn-MR")]
        FfLatnMR,
        [EnumMember(Value = "ff-Latn-NE")]
        FfLatnNE,
        [EnumMember(Value = "ff-Latn-NG")]
        FfLatnNG,
        [EnumMember(Value = "ff-Latn-SL")]
        FfLatnSL,
        [EnumMember(Value = "ff-Latn-SN")]
        FfLatnSN,
        [EnumMember(Value = "fi-FI")]
        FiFI,
        [EnumMember(Value = "fil-PH")]
        FilPH,
        [EnumMember(Value = "fo-DK")]
        FoDK,
        [EnumMember(Value = "fo-FO")]
        FoFO,
        [EnumMember(Value = "fr-BE")]
        FrBE,
        [EnumMember(Value = "fr-BF")]
        FrBF,
        [EnumMember(Value = "fr-BI")]
        FrBI,
        [EnumMember(Value = "fr-BJ")]
        FrBJ,
        [EnumMember(Value = "fr-BL")]
        FrBL,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "fr-CD")]
        FrCD,
        [EnumMember(Value = "fr-CF")]
        FrCF,
        [EnumMember(Value = "fr-CG")]
        FrCG,
        [EnumMember(Value = "fr-CH")]
        FrCH,
        [EnumMember(Value = "fr-CI")]
        FrCI,
        [EnumMember(Value = "fr-CM")]
        FrCM,
        [EnumMember(Value = "fr-DJ")]
        FrDJ,
        [EnumMember(Value = "fr-DZ")]
        FrDZ,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "fr-GA")]
        FrGA,
        [EnumMember(Value = "fr-GF")]
        FrGF,
        [EnumMember(Value = "fr-GN")]
        FrGN,
        [EnumMember(Value = "fr-GP")]
        FrGP,
        [EnumMember(Value = "fr-GQ")]
        FrGQ,
        [EnumMember(Value = "fr-HT")]
        FrHT,
        [EnumMember(Value = "fr-KM")]
        FrKM,
        [EnumMember(Value = "fr-LU")]
        FrLU,
        [EnumMember(Value = "fr-MA")]
        FrMA,
        [EnumMember(Value = "fr-MC")]
        FrMC,
        [EnumMember(Value = "fr-MF")]
        FrMF,
        [EnumMember(Value = "fr-MG")]
        FrMG,
        [EnumMember(Value = "fr-ML")]
        FrML,
        [EnumMember(Value = "fr-MQ")]
        FrMQ,
        [EnumMember(Value = "fr-MR")]
        FrMR,
        [EnumMember(Value = "fr-MU")]
        FrMU,
        [EnumMember(Value = "fr-NC")]
        FrNC,
        [EnumMember(Value = "fr-NE")]
        FrNE,
        [EnumMember(Value = "fr-PF")]
        FrPF,
        [EnumMember(Value = "fr-PM")]
        FrPM,
        [EnumMember(Value = "fr-RE")]
        FrRE,
        [EnumMember(Value = "fr-RW")]
        FrRW,
        [EnumMember(Value = "fr-SC")]
        FrSC,
        [EnumMember(Value = "fr-SN")]
        FrSN,
        [EnumMember(Value = "fr-SY")]
        FrSY,
        [EnumMember(Value = "fr-TD")]
        FrTD,
        [EnumMember(Value = "fr-TG")]
        FrTG,
        [EnumMember(Value = "fr-TN")]
        FrTN,
        [EnumMember(Value = "fr-VU")]
        FrVU,
        [EnumMember(Value = "fr-WF")]
        FrWF,
        [EnumMember(Value = "fr-YT")]
        FrYT,
        [EnumMember(Value = "fur-IT")]
        FurIT,
        [EnumMember(Value = "fy-NL")]
        FyNL,
        [EnumMember(Value = "ga-IE")]
        GaIE,
        [EnumMember(Value = "gd-GB")]
        GdGB,
        [EnumMember(Value = "gl-ES")]
        GlES,
        [EnumMember(Value = "gn-PY")]
        GnPY,
        [EnumMember(Value = "gsw-CH")]
        GswCH,
        [EnumMember(Value = "gsw-FR")]
        GswFR,
        [EnumMember(Value = "gsw-LI")]
        GswLI,
        [EnumMember(Value = "gu-IN")]
        GuIN,
        [EnumMember(Value = "guz-KE")]
        GuzKE,
        [EnumMember(Value = "gv-IM")]
        GvIM,
        [EnumMember(Value = "ha-GH")]
        HaGH,
        [EnumMember(Value = "ha-NE")]
        HaNE,
        [EnumMember(Value = "ha-NG")]
        HaNG,
        [EnumMember(Value = "haw-US")]
        HawUS,
        [EnumMember(Value = "he-IL")]
        HeIL,
        [EnumMember(Value = "hi-IN")]
        HiIN,
        [EnumMember(Value = "hr-BA")]
        HrBA,
        [EnumMember(Value = "hr-HR")]
        HrHR,
        [EnumMember(Value = "hsb-DE")]
        HsbDE,
        [EnumMember(Value = "hu-HU")]
        HuHU,
        [EnumMember(Value = "hy-AM")]
        HyAM,
        [EnumMember(Value = "ia-001")]
        Ia001,
        [EnumMember(Value = "id-ID")]
        IdId,
        [EnumMember(Value = "ig-NG")]
        IgNG,
        [EnumMember(Value = "ii-CN")]
        IiCN,
        [EnumMember(Value = "is-IS")]
        IsIS,
        [EnumMember(Value = "it-CH")]
        ItCH,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "it-SM")]
        ItSM,
        [EnumMember(Value = "it-VA")]
        ItVA,
        [EnumMember(Value = "iu-CA")]
        IuCA,
        [EnumMember(Value = "iu-Latn-CA")]
        IuLatnCA,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "jgo-CM")]
        JgoCM,
        [EnumMember(Value = "jmc-TZ")]
        JmcTZ,
        [EnumMember(Value = "jv-ID")]
        JvId,
        [EnumMember(Value = "ka-GE")]
        KaGE,
        [EnumMember(Value = "kab-DZ")]
        KabDZ,
        [EnumMember(Value = "kam-KE")]
        KamKE,
        [EnumMember(Value = "kde-TZ")]
        KdeTZ,
        [EnumMember(Value = "kea-CV")]
        KeaCV,
        [EnumMember(Value = "khq-ML")]
        KhqML,
        [EnumMember(Value = "ki-KE")]
        KiKE,
        [EnumMember(Value = "kk-KZ")]
        KkKZ,
        [EnumMember(Value = "kkj-CM")]
        KkjCM,
        [EnumMember(Value = "kl-GL")]
        KlGL,
        [EnumMember(Value = "kln-KE")]
        KlnKE,
        [EnumMember(Value = "km-KH")]
        KmKH,
        [EnumMember(Value = "kn-IN")]
        KnIN,
        [EnumMember(Value = "ko-KP")]
        KoKP,
        [EnumMember(Value = "ko-KR")]
        KoKR,
        [EnumMember(Value = "kok-IN")]
        KokIN,
        [EnumMember(Value = "ks-IN")]
        KsIN,
        [EnumMember(Value = "ksb-TZ")]
        KsbTZ,
        [EnumMember(Value = "ksf-CM")]
        KsfCM,
        [EnumMember(Value = "ksh-DE")]
        KshDE,
        [EnumMember(Value = "kw-GB")]
        KwGB,
        [EnumMember(Value = "ky-KG")]
        KyKG,
        [EnumMember(Value = "lag-TZ")]
        LagTZ,
        [EnumMember(Value = "lb-LU")]
        LbLU,
        [EnumMember(Value = "lg-UG")]
        LgUG,
        [EnumMember(Value = "lkt-US")]
        LktUS,
        [EnumMember(Value = "ln-AO")]
        LnAO,
        [EnumMember(Value = "ln-CD")]
        LnCD,
        [EnumMember(Value = "ln-CF")]
        LnCF,
        [EnumMember(Value = "ln-CG")]
        LnCG,
        [EnumMember(Value = "lo-LA")]
        LoLA,
        [EnumMember(Value = "lrc-IQ")]
        LrcIQ,
        [EnumMember(Value = "lrc-IR")]
        LrcIR,
        [EnumMember(Value = "lt-LT")]
        LtLT,
        [EnumMember(Value = "lu-CD")]
        LuCD,
        [EnumMember(Value = "luo-KE")]
        LuoKE,
        [EnumMember(Value = "luy-KE")]
        LuyKE,
        [EnumMember(Value = "lv-LV")]
        LvLV,
        [EnumMember(Value = "mas-KE")]
        MasKE,
        [EnumMember(Value = "mas-TZ")]
        MasTZ,
        [EnumMember(Value = "mer-KE")]
        MerKE,
        [EnumMember(Value = "mfe-MU")]
        MfeMU,
        [EnumMember(Value = "mg-MG")]
        MgMG,
        [EnumMember(Value = "mgh-MZ")]
        MghMZ,
        [EnumMember(Value = "mgo-CM")]
        MgoCM,
        [EnumMember(Value = "mi-NZ")]
        MiNZ,
        [EnumMember(Value = "mk-MK")]
        MkMK,
        [EnumMember(Value = "ml-IN")]
        MlIN,
        [EnumMember(Value = "mn-MN")]
        MnMN,
        [EnumMember(Value = "mn-Mong-CN")]
        MnMongCN,
        [EnumMember(Value = "mn-Mong-MN")]
        MnMongMN,
        [EnumMember(Value = "moh-CA")]
        MohCA,
        [EnumMember(Value = "mr-IN")]
        MrIN,
        [EnumMember(Value = "ms-BN")]
        MsBN,
        [EnumMember(Value = "ms-MY")]
        MsMY,
        [EnumMember(Value = "ms-SG")]
        MsSG,
        [EnumMember(Value = "mt-MT")]
        MtMT,
        [EnumMember(Value = "mua-CM")]
        MuaCM,
        [EnumMember(Value = "my-MM")]
        MyMM,
        [EnumMember(Value = "mzn-IR")]
        MznIR,
        [EnumMember(Value = "naq-NA")]
        NaqNA,
        [EnumMember(Value = "nb-NO")]
        NbNO,
        [EnumMember(Value = "nb-SJ")]
        NbSJ,
        [EnumMember(Value = "nd-ZW")]
        NdZW,
        [EnumMember(Value = "nds-DE")]
        NdsDE,
        [EnumMember(Value = "nds-NL")]
        NdsNL,
        [EnumMember(Value = "ne-IN")]
        NeIN,
        [EnumMember(Value = "ne-NP")]
        NeNP,
        [EnumMember(Value = "nl-AW")]
        NlAW,
        [EnumMember(Value = "nl-BE")]
        NlBE,
        [EnumMember(Value = "nl-BQ")]
        NlBQ,
        [EnumMember(Value = "nl-CW")]
        NlCW,
        [EnumMember(Value = "nl-NL")]
        NlNL,
        [EnumMember(Value = "nl-SR")]
        NlSR,
        [EnumMember(Value = "nl-SX")]
        NlSX,
        [EnumMember(Value = "nmg-CM")]
        NmgCM,
        [EnumMember(Value = "nn-NO")]
        NnNO,
        [EnumMember(Value = "nnh-CM")]
        NnhCM,
        [EnumMember(Value = "nqo-GN")]
        NqoGN,
        [EnumMember(Value = "nr-ZA")]
        NrZA,
        [EnumMember(Value = "nso-ZA")]
        NsoZA,
        [EnumMember(Value = "nus-SS")]
        NusSS,
        [EnumMember(Value = "nyn-UG")]
        NynUG,
        [EnumMember(Value = "oc-FR")]
        OcFR,
        [EnumMember(Value = "om-ET")]
        OmET,
        [EnumMember(Value = "om-KE")]
        OmKE,
        [EnumMember(Value = "or-IN")]
        OrIN,
        [EnumMember(Value = "os-GE")]
        OsGE,
        [EnumMember(Value = "os-RU")]
        OsRU,
        [EnumMember(Value = "pa-Arab-PK")]
        PaArabPK,
        [EnumMember(Value = "pa-Guru-IN")]
        PaGuruIN,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "prg-001")]
        Prg001,
        [EnumMember(Value = "ps-AF")]
        PsAF,
        [EnumMember(Value = "ps-PK")]
        PsPK,
        [EnumMember(Value = "pt-AO")]
        PtAO,
        [EnumMember(Value = "pt-BR")]
        PtBR,
        [EnumMember(Value = "pt-CH")]
        PtCH,
        [EnumMember(Value = "pt-CV")]
        PtCV,
        [EnumMember(Value = "pt-GQ")]
        PtGQ,
        [EnumMember(Value = "pt-GW")]
        PtGW,
        [EnumMember(Value = "pt-LU")]
        PtLU,
        [EnumMember(Value = "pt-MO")]
        PtMO,
        [EnumMember(Value = "pt-MZ")]
        PtMZ,
        [EnumMember(Value = "pt-PT")]
        PtPT,
        [EnumMember(Value = "pt-ST")]
        PtST,
        [EnumMember(Value = "pt-TL")]
        PtTL,
        [EnumMember(Value = "qu-BO")]
        QuBO,
        [EnumMember(Value = "qu-EC")]
        QuEC,
        [EnumMember(Value = "qu-PE")]
        QuPE,
        [EnumMember(Value = "quc-GT")]
        QucGT,
        [EnumMember(Value = "rm-CH")]
        RmCH,
        [EnumMember(Value = "rn-BI")]
        RnBI,
        [EnumMember(Value = "ro-MD")]
        RoMD,
        [EnumMember(Value = "ro-RO")]
        RoRO,
        [EnumMember(Value = "rof-TZ")]
        RofTZ,
        [EnumMember(Value = "ru-BY")]
        RuBY,
        [EnumMember(Value = "ru-KG")]
        RuKG,
        [EnumMember(Value = "ru-KZ")]
        RuKZ,
        [EnumMember(Value = "ru-MD")]
        RuMD,
        [EnumMember(Value = "ru-RU")]
        RuRU,
        [EnumMember(Value = "ru-UA")]
        RuUA,
        [EnumMember(Value = "rw-RW")]
        RwRW,
        [EnumMember(Value = "rwk-TZ")]
        RwkTZ,
        [EnumMember(Value = "sa-IN")]
        SaIN,
        [EnumMember(Value = "sah-RU")]
        SahRU,
        [EnumMember(Value = "saq-KE")]
        SaqKE,
        [EnumMember(Value = "sbp-TZ")]
        SbpTZ,
        [EnumMember(Value = "sd-PK")]
        SdPK,
        [EnumMember(Value = "se-FI")]
        SeFI,
        [EnumMember(Value = "se-NO")]
        SeNO,
        [EnumMember(Value = "se-SE")]
        SeSE,
        [EnumMember(Value = "seh-MZ")]
        SehMZ,
        [EnumMember(Value = "ses-ML")]
        SesML,
        [EnumMember(Value = "sg-CF")]
        SgCF,
        [EnumMember(Value = "shi-Latn-MA")]
        ShiLatnMA,
        [EnumMember(Value = "shi-Tfng-MA")]
        ShiTfngMA,
        [EnumMember(Value = "si-LK")]
        SiLK,
        [EnumMember(Value = "sk-SK")]
        SkSK,
        [EnumMember(Value = "sl-SI")]
        SlSI,
        [EnumMember(Value = "sma-NO")]
        SmaNO,
        [EnumMember(Value = "sma-SE")]
        SmaSE,
        [EnumMember(Value = "smj-NO")]
        SmjNO,
        [EnumMember(Value = "smj-SE")]
        SmjSE,
        [EnumMember(Value = "smn-FI")]
        SmnFI,
        [EnumMember(Value = "sms-FI")]
        SmsFI,
        [EnumMember(Value = "sn-ZW")]
        SnZW,
        [EnumMember(Value = "so-DJ")]
        SoDJ,
        [EnumMember(Value = "so-ET")]
        SoET,
        [EnumMember(Value = "so-KE")]
        SoKE,
        [EnumMember(Value = "so-SO")]
        SoSO,
        [EnumMember(Value = "sq-AL")]
        SqAL,
        [EnumMember(Value = "sq-MK")]
        SqMK,
        [EnumMember(Value = "sq-XK")]
        SqXK,
        [EnumMember(Value = "sr-Cyrl-BA")]
        SrCyrlBA,
        [EnumMember(Value = "sr-Cyrl-ME")]
        SrCyrlME,
        [EnumMember(Value = "sr-Cyrl-RS")]
        SrCyrlRS,
        [EnumMember(Value = "sr-Cyrl-XK")]
        SrCyrlXK,
        [EnumMember(Value = "sr-Latn-BA")]
        SrLatnBA,
        [EnumMember(Value = "sr-Latn-ME")]
        SrLatnME,
        [EnumMember(Value = "sr-Latn-RS")]
        SrLatnRS,
        [EnumMember(Value = "sr-Latn-XK")]
        SrLatnXK,
        [EnumMember(Value = "ss-SZ")]
        SsSZ,
        [EnumMember(Value = "ss-ZA")]
        SsZA,
        [EnumMember(Value = "ssy-ER")]
        SsyER,
        [EnumMember(Value = "st-LS")]
        StLS,
        [EnumMember(Value = "st-ZA")]
        StZA,
        [EnumMember(Value = "sv-AX")]
        SvAX,
        [EnumMember(Value = "sv-FI")]
        SvFI,
        [EnumMember(Value = "sv-SE")]
        SvSE,
        [EnumMember(Value = "sw-CD")]
        SwCD,
        [EnumMember(Value = "sw-KE")]
        SwKE,
        [EnumMember(Value = "sw-TZ")]
        SwTZ,
        [EnumMember(Value = "sw-UG")]
        SwUG,
        [EnumMember(Value = "syr-SY")]
        SyrSY,
        [EnumMember(Value = "ta-IN")]
        TaIN,
        [EnumMember(Value = "ta-LK")]
        TaLK,
        [EnumMember(Value = "ta-MY")]
        TaMY,
        [EnumMember(Value = "ta-SG")]
        TaSG,
        [EnumMember(Value = "te-IN")]
        TeIN,
        [EnumMember(Value = "teo-KE")]
        TeoKE,
        [EnumMember(Value = "teo-UG")]
        TeoUG,
        [EnumMember(Value = "tg-TJ")]
        TgTJ,
        [EnumMember(Value = "th-TH")]
        ThTH,
        [EnumMember(Value = "ti-ER")]
        TiER,
        [EnumMember(Value = "ti-ET")]
        TiET,
        [EnumMember(Value = "tig-ER")]
        TigER,
        [EnumMember(Value = "tk-TM")]
        TkTM,
        [EnumMember(Value = "tn-BW")]
        TnBW,
        [EnumMember(Value = "tn-ZA")]
        TnZA,
        [EnumMember(Value = "to-TO")]
        ToTO,
        [EnumMember(Value = "tr-CY")]
        TrCY,
        [EnumMember(Value = "tr-TR")]
        TrTR,
        [EnumMember(Value = "ts-ZA")]
        TsZA,
        [EnumMember(Value = "tt-RU")]
        TtRU,
        [EnumMember(Value = "twq-NE")]
        TwqNE,
        [EnumMember(Value = "tzm-MA")]
        TzmMA,
        [EnumMember(Value = "ug-CN")]
        UgCN,
        [EnumMember(Value = "uk-UA")]
        UkUA,
        [EnumMember(Value = "ur-IN")]
        UrIN,
        [EnumMember(Value = "ur-PK")]
        UrPK,
        [EnumMember(Value = "uz-Arab-AF")]
        UzArabAF,
        [EnumMember(Value = "uz-Cyrl-UZ")]
        UzCyrlUZ,
        [EnumMember(Value = "uz-Latn-UZ")]
        UzLatnUZ,
        [EnumMember(Value = "vai-Latn-LR")]
        VaiLatnLR,
        [EnumMember(Value = "vai-Vaii-LR")]
        VaiVaiiLR,
        [EnumMember(Value = "ve-ZA")]
        VeZA,
        [EnumMember(Value = "vi-VN")]
        ViVN,
        [EnumMember(Value = "vo-001")]
        Vo001,
        [EnumMember(Value = "vun-TZ")]
        VunTZ,
        [EnumMember(Value = "wae-CH")]
        WaeCH,
        [EnumMember(Value = "wal-ET")]
        WalET,
        [EnumMember(Value = "wo-SN")]
        WoSN,
        [EnumMember(Value = "xh-ZA")]
        XhZA,
        [EnumMember(Value = "xog-UG")]
        XogUG,
        [EnumMember(Value = "yav-CM")]
        YavCM,
        [EnumMember(Value = "yi-001")]
        Yi001,
        [EnumMember(Value = "yo-BJ")]
        YoBJ,
        [EnumMember(Value = "yo-NG")]
        YoNG,
        [EnumMember(Value = "zgh-MA")]
        ZghMA,
        [EnumMember(Value = "zh-Hans-CN")]
        ZhHansCN,
        [EnumMember(Value = "zh-Hans-HK")]
        ZhHansHK,
        [EnumMember(Value = "zh-Hans-MO")]
        ZhHansMO,
        [EnumMember(Value = "zh-Hans-SG")]
        ZhHansSG,
        [EnumMember(Value = "zh-Hant-HK")]
        ZhHantHK,
        [EnumMember(Value = "zh-Hant-MO")]
        ZhHantMO,
        [EnumMember(Value = "zh-Hant-TW")]
        ZhHantTW,
        [EnumMember(Value = "zu-ZA")]
        ZuZA
    }

    public class FlowV1SharePointFlowJobsRegExpMatchPostInput
    {
        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class StringResultResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class FlowV1SharePointFlowJobsRegExpReplacePostInput
    {
        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("replacement")]
        public string Replacement { get; set; }
    }

    public class BooleanResultResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class FlowV1SharePointFlowJobsRegExpTestPostInput
    {
        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailsp;

    public partial class WorkflowManagedActions
    {
        public PlumsailspActions Plumsailsp(string connectionId) => new PlumsailspActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlumsailspTriggers Plumsailsp(string connectionId) => new PlumsailspTriggers(connectionId);
    }
}