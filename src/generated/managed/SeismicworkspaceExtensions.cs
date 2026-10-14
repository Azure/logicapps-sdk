//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicworkspace
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SeismicworkspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicPagingWorkspaceCommentWorkspaceComment> GetWorkspaceItemComments(Expression<Func<string>> workspaceContentId, Expression<Func<string>> spaceId, Expression<Func<string>> versionId = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            var __workflow_versionId = versionId == null ? null : WorkflowExpression.Compile(versionId);
            WorkflowExpression.Validate(__workflow_versionId, nameof(versionId), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPagingWorkspaceCommentWorkspaceComment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/comments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse> AddWorkspaceItemComments(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> bodytext = null, Expression<Func<bodyannotationtypeInput>> bodyannotationtype = null, Expression<Func<int>> bodyannotationpage = null, Expression<Func<string>> bodyannotationcolor = null, Expression<Func<SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel[]>> bodyannotationpoints = null)
        {
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = workspaceVersionId == null ? null : WorkflowExpression.Compile(workspaceVersionId);
            WorkflowExpression.Validate(__workflow_workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: false);
            var __workflow_bodyannotationtype = bodyannotationtype == null ? null : WorkflowExpression.Compile(bodyannotationtype);
            WorkflowExpression.Validate(__workflow_bodyannotationtype, nameof(bodyannotationtype), required: false);
            var __workflow_bodyannotationpage = bodyannotationpage == null ? null : WorkflowExpression.Compile(bodyannotationpage);
            WorkflowExpression.Validate(__workflow_bodyannotationpage, nameof(bodyannotationpage), required: false);
            var __workflow_bodyannotationcolor = bodyannotationcolor == null ? null : WorkflowExpression.Compile(bodyannotationcolor);
            WorkflowExpression.Validate(__workflow_bodyannotationcolor, nameof(bodyannotationcolor), required: false);
            var __workflow_bodyannotationpoints = bodyannotationpoints == null ? null : WorkflowExpression.Compile(bodyannotationpoints);
            WorkflowExpression.Validate(__workflow_bodyannotationpoints, nameof(bodyannotationpoints), required: false);
            return new DeferredBodyAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceVersionId, 1));
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
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse> AddReplyToComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId, Expression<Func<string>> bodytext = null)
        {
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = workspaceVersionId == null ? null : WorkflowExpression.Compile(workspaceVersionId);
            WorkflowExpression.Validate(__workflow_workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = commentId == null ? null : WorkflowExpression.Compile(commentId);
            WorkflowExpression.Validate(__workflow_commentId, nameof(commentId), required: true);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply", ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_commentId, 1));
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
        public IWorkflowAction DeleteWorkspaceItemComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId)
        {
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = workspaceVersionId == null ? null : WorkflowExpression.Compile(workspaceVersionId);
            WorkflowExpression.Validate(__workflow_workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = commentId == null ? null : WorkflowExpression.Compile(commentId);
            WorkflowExpression.Validate(__workflow_commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_commentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItemCommentsReply(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId, Expression<Func<string>> replyId)
        {
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = workspaceVersionId == null ? null : WorkflowExpression.Compile(workspaceVersionId);
            WorkflowExpression.Validate(__workflow_workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = commentId == null ? null : WorkflowExpression.Compile(commentId);
            WorkflowExpression.Validate(__workflow_commentId, nameof(commentId), required: true);
            var __workflow_replyId = replyId == null ? null : WorkflowExpression.Compile(replyId);
            WorkflowExpression.Validate(__workflow_replyId, nameof(replyId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_commentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_replyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction ResolveWorkspaceItemComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId)
        {
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_workspaceVersionId = workspaceVersionId == null ? null : WorkflowExpression.Compile(workspaceVersionId);
            WorkflowExpression.Validate(__workflow_workspaceVersionId, nameof(workspaceVersionId), required: true);
            var __workflow_commentId = commentId == null ? null : WorkflowExpression.Compile(commentId);
            WorkflowExpression.Validate(__workflow_commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/resolve", ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_commentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceFolder(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> GetWorkspaceFolderDetails(Expression<Func<string>> workspaceFolderId)
        {
            var __workflow_workspaceFolderId = workspaceFolderId == null ? null : WorkflowExpression.Compile(workspaceFolderId);
            WorkflowExpression.Validate(__workflow_workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceFolderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceFolder(Expression<Func<string>> workspaceFolderId)
        {
            var __workflow_workspaceFolderId = workspaceFolderId == null ? null : WorkflowExpression.Compile(workspaceFolderId);
            WorkflowExpression.Validate(__workflow_workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceFolderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> UpdateWorkspaceFolder(Expression<Func<string>> workspaceFolderId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceFolderId = workspaceFolderId == null ? null : WorkflowExpression.Compile(workspaceFolderId);
            WorkflowExpression.Validate(__workflow_workspaceFolderId, nameof(workspaceFolderId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceFolderId, 1));
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
        public IBodyWorkflowAction<SeismicCommonWorkSpaceContentManagerWsItemResp> GetWorkspaceFolderItems(Expression<Func<string>> workspaceFolderId)
        {
            var __workflow_workspaceFolderId = workspaceFolderId == null ? null : WorkflowExpression.Compile(workspaceFolderId);
            WorkflowExpression.Validate(__workflow_workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredBodyAction<SeismicCommonWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceFolderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicCommonWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CopyWorkspaceFolder(Expression<Func<string>> workspaceFolderId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceFolderId = workspaceFolderId == null ? null : WorkflowExpression.Compile(workspaceFolderId);
            WorkflowExpression.Validate(__workflow_workspaceFolderId, nameof(workspaceFolderId), required: true);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceFolderId, 1));
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceContextualFolder(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysystemType = null, Expression<Func<string>> bodycontextType = null, Expression<Func<string>> bodycontextTypePlural = null, Expression<Func<string>> bodycontextId = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodysystemType = bodysystemType == null ? null : WorkflowExpression.Compile(bodysystemType);
            WorkflowExpression.Validate(__workflow_bodysystemType, nameof(bodysystemType), required: false);
            var __workflow_bodycontextType = bodycontextType == null ? null : WorkflowExpression.Compile(bodycontextType);
            WorkflowExpression.Validate(__workflow_bodycontextType, nameof(bodycontextType), required: false);
            var __workflow_bodycontextTypePlural = bodycontextTypePlural == null ? null : WorkflowExpression.Compile(bodycontextTypePlural);
            WorkflowExpression.Validate(__workflow_bodycontextTypePlural, nameof(bodycontextTypePlural), required: false);
            var __workflow_bodycontextId = bodycontextId == null ? null : WorkflowExpression.Compile(bodycontextId);
            WorkflowExpression.Validate(__workflow_bodycontextId, nameof(bodycontextId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CreateWorkSpaceFile(Expression<Func<string>> metadata = null, Expression<Func<object>> content = null)
        {
            var __workflow_metadata = metadata == null ? null : WorkflowExpression.Compile(metadata);
            WorkflowExpression.Validate(__workflow_metadata, nameof(metadata), required: false);
            var __workflow_content = content == null ? null : WorkflowExpression.Compile(content);
            WorkflowExpression.Validate(__workflow_content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> GetWorkspaceFileDetails(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceFile(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> UpdateWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CopyWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<bool>> redirect = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_redirect = redirect == null ? null : WorkflowExpression.Compile(redirect);
            WorkflowExpression.Validate(__workflow_redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (__workflow_redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(__workflow_redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CreateWorkspaceFileVersion(Expression<Func<string>> workspaceContentId, Expression<Func<object>> content = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_content = content == null ? null : WorkflowExpression.Compile(content);
            WorkflowExpression.Validate(__workflow_content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CreateWorkspaceUrl(Expression<Func<bool>> openInNewWindow = null, Expression<Func<string>> bodyurlurl = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_openInNewWindow = openInNewWindow == null ? null : WorkflowExpression.Compile(openInNewWindow);
            WorkflowExpression.Validate(__workflow_openInNewWindow, nameof(openInNewWindow), required: false);
            var __workflow_bodyurlurl = bodyurlurl == null ? null : WorkflowExpression.Compile(bodyurlurl);
            WorkflowExpression.Validate(__workflow_bodyurlurl, nameof(bodyurlurl), required: false);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp>(() =>
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI> GetWorkspaceUrlDetails(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceUrl(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> UpdateWorkspaceUrl(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyurlurl = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            var __workflow_bodyurlurl = bodyurlurl == null ? null : WorkflowExpression.Compile(bodyurlurl);
            WorkflowExpression.Validate(__workflow_bodyurlurl, nameof(bodyurlurl), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CopyWorkspaceUrl(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> GetWorkspaceItemDetails(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItem(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> UpdateWorkspaceItem(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> CopyWorkspaceItem(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyparentFolderId = bodyparentFolderId == null ? null : WorkflowExpression.Compile(bodyparentFolderId);
            WorkflowExpression.Validate(__workflow_bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IBodyWorkflowAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]> GetWorkspaceItenMembers(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<CollaboratorResponse> AddCollaboratorAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyrole = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: false);
            var __workflow_bodyrole = bodyrole == null ? null : WorkflowExpression.Compile(bodyrole);
            WorkflowExpression.Validate(__workflow_bodyrole, nameof(bodyrole), required: false);
            return new DeferredBodyAction<CollaboratorResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IWorkflowAction DeleteCollaboratorAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> memberId)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_memberId = memberId == null ? null : WorkflowExpression.Compile(memberId);
            WorkflowExpression.Validate(__workflow_memberId, nameof(memberId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction TransferOwnerAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyownerId = null)
        {
            var __workflow_workspaceContentId = workspaceContentId == null ? null : WorkflowExpression.Compile(workspaceContentId);
            WorkflowExpression.Validate(__workflow_workspaceContentId, nameof(workspaceContentId), required: true);
            var __workflow_bodyownerId = bodyownerId == null ? null : WorkflowExpression.Compile(bodyownerId);
            WorkflowExpression.Validate(__workflow_bodyownerId, nameof(bodyownerId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/owner", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceContentId, 1));
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
        public IWorkflowAction GetCustomPropertiesByFileId(Expression<Func<string>> fileId, Expression<Func<bool>> includeInvisibledInDC = null)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            var __workflow_includeInvisibledInDC = includeInvisibledInDC == null ? null : WorkflowExpression.Compile(includeInvisibledInDC);
            WorkflowExpression.Validate(__workflow_includeInvisibledInDC, nameof(includeInvisibledInDC), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/files/{0}/customProperties", ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileId, 1));
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
