//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicworkspace
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicworkspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicPagingWorkspaceCommentWorkspaceComment, ApiConnectionActionConfiguration> GetWorkspaceItemComments(Expression<Func<string>> workspaceContentId, Expression<Func<string>> spaceId, Expression<Func<string>> versionId = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_versionId = WorkflowExpression.Compile(versionId, nameof(versionId), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPagingWorkspaceCommentWorkspaceComment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/comments", __workflow_spaceId.WithUrlEncoding(1), __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_versionId != null)
                    callPayload.Queries["versionId"] = ExpressionConverter.Convert(__workflow_versionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<SeismicPagingWorkspaceCommentWorkspaceComment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse, ApiConnectionActionConfiguration> AddWorkspaceItemComments(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> bodytext = null, Expression<Func<bodyannotationtypeInput>> bodyannotationtype = null, Expression<Func<int>> bodyannotationpage = null, Expression<Func<string>> bodyannotationcolor = null, Expression<Func<SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel[]>> bodyannotationpoints = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = WorkflowExpression.Compile(workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyannotationtype = WorkflowExpression.Compile(bodyannotationtype, nameof(bodyannotationtype), required: false);
            var __workflow_bodyannotationpage = WorkflowExpression.Compile(bodyannotationpage, nameof(bodyannotationpage), required: false);
            var __workflow_bodyannotationcolor = WorkflowExpression.Compile(bodyannotationcolor, nameof(bodyannotationcolor), required: false);
            var __workflow_bodyannotationpoints = WorkflowExpression.Compile(bodyannotationpoints, nameof(bodyannotationpoints), required: false);
            return new DeferredBodyAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments", __workflow_spaceId.WithUrlEncoding(1), __workflow_workspaceContentId.WithUrlEncoding(1), __workflow_workspaceVersionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                var annotationObject = new JObject();
                var annotationObjectpropCount = 0;
                if (__workflow_bodyannotationtype != null)
                {
                    annotationObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyannotationtype);
                    annotationObjectpropCount++;
                }

                if (__workflow_bodyannotationpage != null)
                {
                    annotationObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyannotationpage);
                    annotationObjectpropCount++;
                }

                if (__workflow_bodyannotationcolor != null)
                {
                    annotationObject["color"] = ExpressionConverter.ConvertO(__workflow_bodyannotationcolor);
                    annotationObjectpropCount++;
                }

                if (__workflow_bodyannotationpoints != null)
                {
                    annotationObject["points"] = ExpressionConverter.ConvertO(__workflow_bodyannotationpoints);
                    annotationObjectpropCount++;
                }

                if (annotationObjectpropCount > 0)
                {
                    body["annotation"] = annotationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse, ApiConnectionActionConfiguration> AddReplyToComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId, Expression<Func<string>> bodytext = null)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = WorkflowExpression.Compile(workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply", __workflow_spaceId.WithUrlEncoding(1), __workflow_workspaceContentId.WithUrlEncoding(1), __workflow_workspaceVersionId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWorkspaceItemComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = WorkflowExpression.Compile(workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}", __workflow_spaceId.WithUrlEncoding(1), __workflow_workspaceContentId.WithUrlEncoding(1), __workflow_workspaceVersionId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWorkspaceItemCommentsReply(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId, Expression<Func<string>> replyId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = WorkflowExpression.Compile(workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            var __workflow_replyId = WorkflowExpression.Compile(replyId, nameof(replyId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply/{4}", __workflow_spaceId.WithUrlEncoding(1), __workflow_workspaceContentId.WithUrlEncoding(1), __workflow_workspaceVersionId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1), __workflow_replyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResolveWorkspaceItemComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId)
        {
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = WorkflowExpression.Compile(workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = WorkflowExpression.Compile(commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/resolve", __workflow_spaceId.WithUrlEncoding(1), __workflow_workspaceContentId.WithUrlEncoding(1), __workflow_workspaceVersionId.WithUrlEncoding(1), __workflow_commentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration> CreateWorkspaceFolder(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration> GetWorkspaceFolderDetails(Expression<Func<string>> workspaceFolderId)
        {
            var __workflow_workspaceFolderId = WorkflowExpression.Compile(workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/folders/{0}", __workflow_workspaceFolderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWorkspaceFolder(Expression<Func<string>> workspaceFolderId)
        {
            var __workflow_workspaceFolderId = WorkflowExpression.Compile(workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/folders/{0}", __workflow_workspaceFolderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration> UpdateWorkspaceFolder(Expression<Func<string>> workspaceFolderId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceFolderId = WorkflowExpression.Compile(workspaceFolderId, nameof(workspaceFolderId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/folders/{0}", __workflow_workspaceFolderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicCommonWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration> GetWorkspaceFolderItems(Expression<Func<string>> workspaceFolderId)
        {
            var __workflow_workspaceFolderId = WorkflowExpression.Compile(workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredBodyAction<SeismicCommonWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/folders/{0}/items", __workflow_workspaceFolderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicCommonWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration> CopyWorkspaceFolder(Expression<Func<string>> workspaceFolderId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceFolderId = WorkflowExpression.Compile(workspaceFolderId, nameof(workspaceFolderId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/folders/{0}/copy", __workflow_workspaceFolderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration> CreateWorkspaceContextualFolder(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysystemType = null, Expression<Func<string>> bodycontextType = null, Expression<Func<string>> bodycontextTypePlural = null, Expression<Func<string>> bodycontextId = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodysystemType = WorkflowExpression.Compile(bodysystemType, nameof(bodysystemType), required: false);
            var __workflow_bodycontextType = WorkflowExpression.Compile(bodycontextType, nameof(bodycontextType), required: false);
            var __workflow_bodycontextTypePlural = WorkflowExpression.Compile(bodycontextTypePlural, nameof(bodycontextTypePlural), required: false);
            var __workflow_bodycontextId = WorkflowExpression.Compile(bodycontextId, nameof(bodycontextId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/folders/createContextualFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodysystemType != null)
                {
                    body["systemType"] = ExpressionConverter.ConvertO(__workflow_bodysystemType);
                    bodypropCount++;
                }

                if (__workflow_bodycontextType != null)
                {
                    body["contextType"] = ExpressionConverter.ConvertO(__workflow_bodycontextType);
                    bodypropCount++;
                }

                if (__workflow_bodycontextTypePlural != null)
                {
                    body["contextTypePlural"] = ExpressionConverter.ConvertO(__workflow_bodycontextTypePlural);
                    bodypropCount++;
                }

                if (__workflow_bodycontextId != null)
                {
                    body["contextId"] = ExpressionConverter.ConvertO(__workflow_bodycontextId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration> CreateWorkSpaceFile(Expression<Func<string>> metadata = null, Expression<Func<object>> content = null)
        {
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration> GetWorkspaceFileDetails(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/files/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWorkspaceFile(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/files/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration> UpdateWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/files/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration> CopyWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/files/{0}/copy", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp, ApiConnectionActionConfiguration> DownloadWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<bool>> redirect = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_redirect = WorkflowExpression.Compile(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/files/{0}/content", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (__workflow_redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(__workflow_redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration> CreateWorkspaceFileVersion(Expression<Func<string>> workspaceContentId, Expression<Func<object>> content = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/files/{0}/content", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp, ApiConnectionActionConfiguration> CreateWorkspaceUrl(Expression<Func<bool>> openInNewWindow = null, Expression<Func<string>> bodyurlurl = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_openInNewWindow = WorkflowExpression.Compile(openInNewWindow, nameof(openInNewWindow), required: false);
            var __workflow_bodyurlurl = WorkflowExpression.Compile(bodyurlurl, nameof(bodyurlurl), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["openInNewWindow"] = Convert.ToString(false);
                if (__workflow_openInNewWindow != null)
                    callPayload.Queries["openInNewWindow"] = ExpressionConverter.Convert(__workflow_openInNewWindow);
                var body = new JObject();
                var bodypropCount = 0;
                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (__workflow_bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyurlurl);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI, ApiConnectionActionConfiguration> GetWorkspaceUrlDetails(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/urls/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWorkspaceUrl(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/urls/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp, ApiConnectionActionConfiguration> UpdateWorkspaceUrl(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyurlurl = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            var __workflow_bodyurlurl = WorkflowExpression.Compile(bodyurlurl, nameof(bodyurlurl), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/urls/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (__workflow_bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyurlurl);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp, ApiConnectionActionConfiguration> CopyWorkspaceUrl(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/urls/{0}/copy", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration> GetWorkspaceItemDetails(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/items/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteWorkspaceItem(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/items/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration> UpdateWorkspaceItem(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/items/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration> CopyWorkspaceItem(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/items/{0}/copy", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[], ApiConnectionActionConfiguration> GetWorkspaceItenMembers(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/workspace/{0}/members", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<CollaboratorResponse, ApiConnectionActionConfiguration> AddCollaboratorAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyrole = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            return new DeferredBodyAction<CollaboratorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/items/{0}/members", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CollaboratorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteCollaboratorAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> memberId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/items/{0}/members/{1}", __workflow_workspaceContentId.WithUrlEncoding(1), __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TransferOwnerAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyownerId = null)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/items/{0}/owner", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCustomPropertiesByFileId(Expression<Func<string>> fileId, Expression<Func<bool>> includeInvisibledInDC = null)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_includeInvisibledInDC = WorkflowExpression.Compile(includeInvisibledInDC, nameof(includeInvisibledInDC), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/files/{0}/customProperties", __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeInvisibledInDC"] = Convert.ToString(false);
                if (__workflow_includeInvisibledInDC != null)
                    callPayload.Queries["includeInvisibledInDC"] = ExpressionConverter.Convert(__workflow_includeInvisibledInDC);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SeismicworkspaceTriggers([ConnectionName] string connectionId)
    {
    }

    public class SeismicPagingWorkspaceCommentWorkspaceComment
    {
        [JsonProperty("entries")]
        public SeismicWorkspaceCommentsWorkspaceComment[] Entries { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageCap")]
        public int PageCap { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextPageLink")]
        public string NextPageLink { get; set; }
    }

    public class SeismicWorkspaceCommentsWorkspaceComment
    {
        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("content")]
        public SeismicWorkSpaceContentManagerContentClass Content { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonUserCreated CreatedBy { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("isResolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("annotation")]
        public SeismicWorkspaceCommentsWorkspaceAnnotation Annotation { get; set; }

        [JsonProperty("replies")]
        public SeismicWorkspaceCommentsWorkspaceCommentReply[] Replies { get; set; }
    }

    public class SeismicWorkSpaceContentManagerContentClass
    {
        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }

    public class SeismicCommonUserCreated
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("photoId")]
        public string PhotoId { get; set; }

        [JsonProperty("photoUrl")]
        public string PhotoUrl { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    public class SeismicWorkspaceCommentsWorkspaceAnnotation
    {
        [JsonProperty("type")]
        public SeismicLibraryCommentingAnnotationType Type { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("points")]
        public SeismicWorkspaceCommentsPointInfo[] Points { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeismicLibraryCommentingAnnotationType
    {
        [EnumMember(Value = "pen")]
        Pen,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "pin")]
        Pin,
        [EnumMember(Value = "line")]
        Line,
        [EnumMember(Value = "rectangle")]
        Rectangle,
        [EnumMember(Value = "oval")]
        Oval,
        [EnumMember(Value = "arrow")]
        Arrow
    }

    public class SeismicWorkspaceCommentsPointInfo
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class SeismicWorkspaceCommentsWorkspaceCommentReply
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonUserCreated CreatedBy { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("isResolved")]
        public bool IsResolved { get; set; }
    }

    public class SeismicWorkspaceCommentsWorkspaceAddCommentResponse
    {
        [JsonProperty("annotation")]
        public SeismicWorkspaceCommentsAnnotation Annotation { get; set; }

        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("isResolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("content")]
        public SeismicWorkspaceCommentsWorkspaceContent Content { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonUserCreated CreatedBy { get; set; }
    }

    public class SeismicWorkspaceCommentsAnnotation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicLibraryCommentingAnnotationType Type { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("points")]
        public SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel[] Points { get; set; }
    }

    public class SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class SeismicWorkspaceCommentsWorkspaceContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public SeismicWorkSpaceContentManagerItemType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeismicWorkSpaceContentManagerItemType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyannotationtypeInput
    {
        [EnumMember(Value = "pen")]
        Pen,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "pin")]
        Pin,
        [EnumMember(Value = "line")]
        Line,
        [EnumMember(Value = "rectangle")]
        Rectangle,
        [EnumMember(Value = "oval")]
        Oval,
        [EnumMember(Value = "arrow")]
        Arrow
    }

    public class SeismicWorkspaceCommentsWorkspaceReplyCommentResponse
    {
        [JsonProperty("id")]
        public string ReplyId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonUserCreated CreatedBy { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("commentId")]
        public string CommentId { get; set; }

        [JsonProperty("content")]
        public SeismicWorkspaceCommentsWorkspaceContent Content { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsFolderRespForAddAPI
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicWorkSpaceContentManagerItemType Type { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicWorkSpaceContentManagerApplicationUrl[] ApplicationUrls { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicWorkSpaceContentManagerUserCreated CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicWorkSpaceContentManagerUserModified ModifiedBy { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerApplicationUrl
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SeismicWorkSpaceContentManagerUserCreated
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SeismicWorkSpaceContentManagerUserModified
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SeismicCommonWorkSpaceContentManagerWsItemResp
    {
        [JsonProperty("itemCount")]
        public int ItemCount { get; set; }

        [JsonProperty("items")]
        public SeismicWorkSpaceContentManagerWsItemResp[] Items { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsItemResp
    {
        [JsonProperty("url")]
        public SeismicWorkSpaceContentManagerWsUrlInfoResp Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicWorkSpaceContentManagerItemType Type { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("deliveryOptions")]
        public SeismicWorkSpaceContentManagerWsDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicWorkSpaceContentManagerApplicationUrl[] ApplicationUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicWorkSpaceContentManagerUserCreated CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicWorkSpaceContentManagerUserModified ModifiedBy { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsUrlInfoResp
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsDeliveryOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsFileResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicWorkSpaceContentManagerItemType Type { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("deliveryOptions")]
        public SeismicWorkSpaceContentManagerWsDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicWorkSpaceContentManagerApplicationUrl[] ApplicationUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicWorkSpaceContentManagerUserCreated CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicWorkSpaceContentManagerUserModified ModifiedBy { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class SeismicCommonDownloadLocationResp
    {
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsUrlResp
    {
        [JsonProperty("url")]
        public SeismicWorkSpaceContentManagerWsUrlInfoResp Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicWorkSpaceContentManagerItemType Type { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("deliveryOptions")]
        public SeismicWorkSpaceContentManagerWsDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicWorkSpaceContentManagerApplicationUrl[] ApplicationUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicWorkSpaceContentManagerUserCreated CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicWorkSpaceContentManagerUserModified ModifiedBy { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsUrlRespForGetAPI
    {
        [JsonProperty("url")]
        public SeismicWorkSpaceContentManagerWsUrlInfoResp Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicWorkSpaceContentManagerItemType Type { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("deliveryOptions")]
        public SeismicWorkSpaceContentManagerWsDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicWorkSpaceContentManagerApplicationUrl[] ApplicationUrl { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicWorkSpaceContentManagerUserCreated CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicWorkSpaceContentManagerUserModified ModifiedBy { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class CollaboratorResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismicworkspace;

    public partial class WorkflowManagedActions
    {
        public SeismicworkspaceActions Seismicworkspace(string connectionId) => new SeismicworkspaceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismicworkspaceTriggers Seismicworkspace(string connectionId) => new SeismicworkspaceTriggers(connectionId);
    }
}
