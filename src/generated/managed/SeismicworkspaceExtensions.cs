//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicworkspace
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicworkspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceItemComments))]
        public IBodyWorkflowAction<SeismicPagingWorkspaceCommentWorkspaceComment> GetWorkspaceItemComments([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> versionId = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicPagingWorkspaceCommentWorkspaceComment> __BuildGetWorkspaceItemComments(WorkflowValue<string> workspaceContentId, WorkflowValue<string> spaceId, WorkflowValue<string> versionId = null, WorkflowValue<int> offset = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(versionId, nameof(versionId), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPagingWorkspaceCommentWorkspaceComment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/comments", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (versionId != null)
                    callPayload.Queries["versionId"] = ExpressionConverter.Convert(versionId);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<SeismicPagingWorkspaceCommentWorkspaceComment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildAddWorkspaceItemComments))]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse> AddWorkspaceItemComments([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<bodyannotationtypeInput> bodyannotationtype = null, [WorkflowExpression] Func<int> bodyannotationpage = null, [WorkflowExpression] Func<string> bodyannotationcolor = null, [WorkflowExpression] Func<SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel[]> bodyannotationpoints = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse> __BuildAddWorkspaceItemComments(WorkflowValue<string> spaceId, WorkflowValue<string> workspaceContentId, WorkflowValue<string> workspaceVersionId, WorkflowValue<string> bodytext = null, WorkflowValue<bodyannotationtypeInput> bodyannotationtype = null, WorkflowValue<int> bodyannotationpage = null, WorkflowValue<string> bodyannotationcolor = null, WorkflowValue<SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel[]> bodyannotationpoints = null)
        {
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(workspaceVersionId, nameof(workspaceVersionId), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowValue.Validate(bodyannotationtype, nameof(bodyannotationtype), required: false);
            WorkflowValue.Validate(bodyannotationpage, nameof(bodyannotationpage), required: false);
            WorkflowValue.Validate(bodyannotationcolor, nameof(bodyannotationcolor), required: false);
            WorkflowValue.Validate(bodyannotationpoints, nameof(bodyannotationpoints), required: false);
            return new DeferredBodyAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                var annotationObject = new JObject();
                var annotationObjectpropCount = 0;
                if (bodyannotationtype != null)
                {
                    annotationObject["type"] = ExpressionConverter.ConvertO(bodyannotationtype);
                    annotationObjectpropCount++;
                }

                if (bodyannotationpage != null)
                {
                    annotationObject["page"] = ExpressionConverter.ConvertO(bodyannotationpage);
                    annotationObjectpropCount++;
                }

                if (bodyannotationcolor != null)
                {
                    annotationObject["color"] = ExpressionConverter.ConvertO(bodyannotationcolor);
                    annotationObjectpropCount++;
                }

                if (bodyannotationpoints != null)
                {
                    annotationObject["points"] = ExpressionConverter.ConvertO(bodyannotationpoints);
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
        [WorkflowExpressionFactory(nameof(__BuildAddReplyToComment))]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse> AddReplyToComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId, [WorkflowExpression] Func<string> bodytext = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse> __BuildAddReplyToComment(WorkflowValue<string> spaceId, WorkflowValue<string> workspaceContentId, WorkflowValue<string> workspaceVersionId, WorkflowValue<string> commentId, WorkflowValue<string> bodytext = null)
        {
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(workspaceVersionId, nameof(workspaceVersionId), required: true);
            WorkflowValue.Validate(commentId, nameof(commentId), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkspaceItemComment))]
        public IWorkflowAction DeleteWorkspaceItemComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteWorkspaceItemComment(WorkflowValue<string> spaceId, WorkflowValue<string> workspaceContentId, WorkflowValue<string> workspaceVersionId, WorkflowValue<string> commentId)
        {
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(workspaceVersionId, nameof(workspaceVersionId), required: true);
            WorkflowValue.Validate(commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkspaceItemCommentsReply))]
        public IWorkflowAction DeleteWorkspaceItemCommentsReply([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId, [WorkflowExpression] Func<string> replyId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteWorkspaceItemCommentsReply(WorkflowValue<string> spaceId, WorkflowValue<string> workspaceContentId, WorkflowValue<string> workspaceVersionId, WorkflowValue<string> commentId, WorkflowValue<string> replyId)
        {
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(workspaceVersionId, nameof(workspaceVersionId), required: true);
            WorkflowValue.Validate(commentId, nameof(commentId), required: true);
            WorkflowValue.Validate(replyId, nameof(replyId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply/{4}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1), ExpressionConverter.ConvertWithUrlEncoding(replyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildResolveWorkspaceItemComment))]
        public IWorkflowAction ResolveWorkspaceItemComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildResolveWorkspaceItemComment(WorkflowValue<string> spaceId, WorkflowValue<string> workspaceContentId, WorkflowValue<string> workspaceVersionId, WorkflowValue<string> commentId)
        {
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(workspaceVersionId, nameof(workspaceVersionId), required: true);
            WorkflowValue.Validate(commentId, nameof(commentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/resolve", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceFolder))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceFolder([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> __BuildCreateWorkspaceFolder(WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceFolderDetails))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> GetWorkspaceFolderDetails([WorkflowExpression] Func<string> workspaceFolderId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> __BuildGetWorkspaceFolderDetails(WorkflowValue<string> workspaceFolderId)
        {
            WorkflowValue.Validate(workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkspaceFolder))]
        public IWorkflowAction DeleteWorkspaceFolder([WorkflowExpression] Func<string> workspaceFolderId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteWorkspaceFolder(WorkflowValue<string> workspaceFolderId)
        {
            WorkflowValue.Validate(workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkspaceFolder))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> UpdateWorkspaceFolder([WorkflowExpression] Func<string> workspaceFolderId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> __BuildUpdateWorkspaceFolder(WorkflowValue<string> workspaceFolderId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(workspaceFolderId, nameof(workspaceFolderId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceFolderItems))]
        public IBodyWorkflowAction<SeismicCommonWorkSpaceContentManagerWsItemResp> GetWorkspaceFolderItems([WorkflowExpression] Func<string> workspaceFolderId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicCommonWorkSpaceContentManagerWsItemResp> __BuildGetWorkspaceFolderItems(WorkflowValue<string> workspaceFolderId)
        {
            WorkflowValue.Validate(workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredBodyAction<SeismicCommonWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicCommonWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildCopyWorkspaceFolder))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CopyWorkspaceFolder([WorkflowExpression] Func<string> workspaceFolderId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> __BuildCopyWorkspaceFolder(WorkflowValue<string> workspaceFolderId, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(workspaceFolderId, nameof(workspaceFolderId), required: true);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceContextualFolder))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceContextualFolder([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysystemType = null, [WorkflowExpression] Func<string> bodycontextType = null, [WorkflowExpression] Func<string> bodycontextTypePlural = null, [WorkflowExpression] Func<string> bodycontextId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> __BuildCreateWorkspaceContextualFolder(WorkflowValue<string> bodyname = null, WorkflowValue<string> bodysystemType = null, WorkflowValue<string> bodycontextType = null, WorkflowValue<string> bodycontextTypePlural = null, WorkflowValue<string> bodycontextId = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodysystemType, nameof(bodysystemType), required: false);
            WorkflowValue.Validate(bodycontextType, nameof(bodycontextType), required: false);
            WorkflowValue.Validate(bodycontextTypePlural, nameof(bodycontextTypePlural), required: false);
            WorkflowValue.Validate(bodycontextId, nameof(bodycontextId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/folders/createContextualFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodysystemType != null)
                {
                    body["systemType"] = ExpressionConverter.ConvertO(bodysystemType);
                    bodypropCount++;
                }

                if (bodycontextType != null)
                {
                    body["contextType"] = ExpressionConverter.ConvertO(bodycontextType);
                    bodypropCount++;
                }

                if (bodycontextTypePlural != null)
                {
                    body["contextTypePlural"] = ExpressionConverter.ConvertO(bodycontextTypePlural);
                    bodypropCount++;
                }

                if (bodycontextId != null)
                {
                    body["contextId"] = ExpressionConverter.ConvertO(bodycontextId);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkSpaceFile))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CreateWorkSpaceFile([WorkflowExpression] Func<string> metadata = null, [WorkflowExpression] Func<object> content = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> __BuildCreateWorkSpaceFile(WorkflowValue<string> metadata = null, WorkflowValue<object> content = null)
        {
            WorkflowValue.Validate(metadata, nameof(metadata), required: false);
            WorkflowValue.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceFileDetails))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> GetWorkspaceFileDetails([WorkflowExpression] Func<string> workspaceContentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> __BuildGetWorkspaceFileDetails(WorkflowValue<string> workspaceContentId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkspaceFile))]
        public IWorkflowAction DeleteWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteWorkspaceFile(WorkflowValue<string> workspaceContentId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkspaceFile))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> UpdateWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> __BuildUpdateWorkspaceFile(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildCopyWorkspaceFile))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CopyWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> __BuildCopyWorkspaceFile(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildDownloadWorkspaceFile))]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<bool> redirect = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> __BuildDownloadWorkspaceFile(WorkflowValue<string> workspaceContentId, WorkflowValue<bool> redirect = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceFileVersion))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CreateWorkspaceFileVersion([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<object> content = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> __BuildCreateWorkspaceFileVersion(WorkflowValue<string> workspaceContentId, WorkflowValue<object> content = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsFileResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceUrl))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CreateWorkspaceUrl([WorkflowExpression] Func<bool> openInNewWindow = null, [WorkflowExpression] Func<string> bodyurlurl = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> __BuildCreateWorkspaceUrl(WorkflowValue<bool> openInNewWindow = null, WorkflowValue<string> bodyurlurl = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(openInNewWindow, nameof(openInNewWindow), required: false);
            WorkflowValue.Validate(bodyurlurl, nameof(bodyurlurl), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp>(() =>
            {
                var apiCallPath = "/integration/v2/workspace/urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["openInNewWindow"] = Convert.ToString(false);
                if (openInNewWindow != null)
                    callPayload.Queries["openInNewWindow"] = ExpressionConverter.Convert(openInNewWindow);
                var body = new JObject();
                var bodypropCount = 0;
                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(bodyurlurl);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceUrlDetails))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI> GetWorkspaceUrlDetails([WorkflowExpression] Func<string> workspaceContentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI> __BuildGetWorkspaceUrlDetails(WorkflowValue<string> workspaceContentId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkspaceUrl))]
        public IWorkflowAction DeleteWorkspaceUrl([WorkflowExpression] Func<string> workspaceContentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteWorkspaceUrl(WorkflowValue<string> workspaceContentId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkspaceUrl))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> UpdateWorkspaceUrl([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyurlurl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> __BuildUpdateWorkspaceUrl(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyparentFolderId = null, WorkflowValue<string> bodyurlurl = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            WorkflowValue.Validate(bodyurlurl, nameof(bodyurlurl), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                    bodypropCount++;
                }

                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(bodyurlurl);
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
        [WorkflowExpressionFactory(nameof(__BuildCopyWorkspaceUrl))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CopyWorkspaceUrl([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> __BuildCopyWorkspaceUrl(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsUrlResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceItemDetails))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> GetWorkspaceItemDetails([WorkflowExpression] Func<string> workspaceContentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> __BuildGetWorkspaceItemDetails(WorkflowValue<string> workspaceContentId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkspaceItem))]
        public IWorkflowAction DeleteWorkspaceItem([WorkflowExpression] Func<string> workspaceContentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteWorkspaceItem(WorkflowValue<string> workspaceContentId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkspaceItem))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> UpdateWorkspaceItem([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> __BuildUpdateWorkspaceItem(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildCopyWorkspaceItem))]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> CopyWorkspaceItem([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> __BuildCopyWorkspaceItem(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyparentFolderId = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            return new DeferredBodyAction<SeismicWorkSpaceContentManagerWsItemResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceItenMembers))]
        public IBodyWorkflowAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]> GetWorkspaceItenMembers([WorkflowExpression] Func<string> workspaceContentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]> __BuildGetWorkspaceItenMembers(WorkflowValue<string> workspaceContentId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildAddCollaboratorAsync))]
        public IBodyWorkflowAction<CollaboratorResponse> AddCollaboratorAsync([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyrole = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CollaboratorResponse> __BuildAddCollaboratorAsync(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodyrole = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodyrole, nameof(bodyrole), required: false);
            return new DeferredBodyAction<CollaboratorResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(bodyrole);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteCollaboratorAsync))]
        public IWorkflowAction DeleteCollaboratorAsync([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> memberId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteCollaboratorAsync(WorkflowValue<string> workspaceContentId, WorkflowValue<string> memberId)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(memberId, nameof(memberId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        [WorkflowExpressionFactory(nameof(__BuildTransferOwnerAsync))]
        public IWorkflowAction TransferOwnerAsync([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTransferOwnerAsync(WorkflowValue<string> workspaceContentId, WorkflowValue<string> bodyownerId = null)
        {
            WorkflowValue.Validate(workspaceContentId, nameof(workspaceContentId), required: true);
            WorkflowValue.Validate(bodyownerId, nameof(bodyownerId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/owner", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetCustomPropertiesByFileId))]
        public IWorkflowAction GetCustomPropertiesByFileId([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> includeInvisibledInDC = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCustomPropertiesByFileId(WorkflowValue<string> fileId, WorkflowValue<bool> includeInvisibledInDC = null)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            WorkflowValue.Validate(includeInvisibledInDC, nameof(includeInvisibledInDC), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/files/{0}/customProperties", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeInvisibledInDC"] = Convert.ToString(false);
                if (includeInvisibledInDC != null)
                    callPayload.Queries["includeInvisibledInDC"] = ExpressionConverter.Convert(includeInvisibledInDC);
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

    public enum SeismicWorkSpaceContentManagerItemType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File
    }

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
