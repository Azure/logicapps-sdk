//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicworkspace
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicworkspaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicPagingWorkspaceCommentWorkspaceComment> GetWorkspaceItemComments(Expression<Func<string>> workspaceContentId, Expression<Func<string>> spaceId, Expression<Func<string>> versionId = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/spaces/{0}/items/{1}/comments", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (versionId != null)
                callPayload.Queries["versionId"] = ExpressionConverter.Convert(versionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<SeismicPagingWorkspaceCommentWorkspaceComment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse> AddWorkspaceItemComments(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> bodytext = null, Expression<Func<bodyannotationtypeInput>> bodyannotationtype = null, Expression<Func<int>> bodyannotationpage = null, Expression<Func<string>> bodyannotationcolor = null, Expression<Func<SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel[]>> bodyannotationpoints = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse> AddReplyToComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId, Expression<Func<string>> bodytext = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItemComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItemCommentsReply(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId, Expression<Func<string>> replyId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply/{4}", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1), ExpressionConverter.ConvertWithUrlEncoding(replyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction ResolveWorkspaceItemComment(Expression<Func<string>> spaceId, Expression<Func<string>> workspaceContentId, Expression<Func<string>> workspaceVersionId, Expression<Func<string>> commentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/resolve", ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceVersionId, 1), ExpressionConverter.ConvertWithUrlEncoding(commentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceFolder(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> GetWorkspaceFolderDetails(Expression<Func<string>> workspaceFolderId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceFolder(Expression<Func<string>> workspaceFolderId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> UpdateWorkspaceFolder(Expression<Func<string>> workspaceFolderId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicCommonWorkSpaceContentManagerWsItemResp> GetWorkspaceFolderItems(Expression<Func<string>> workspaceFolderId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/folders/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicCommonWorkSpaceContentManagerWsItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CopyWorkspaceFolder(Expression<Func<string>> workspaceFolderId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/folders/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceFolderId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceContextualFolder(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysystemType = null, Expression<Func<string>> bodycontextType = null, Expression<Func<string>> bodycontextTypePlural = null, Expression<Func<string>> bodycontextId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CreateWorkSpaceFile(Expression<Func<string>> metadata = null, Expression<Func<object>> content = null)
        {
            var apiCallPath = "/integration/v2/workspace/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> GetWorkspaceFileDetails(Expression<Func<string>> workspaceContentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceFile(Expression<Func<string>> workspaceContentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> UpdateWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CopyWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/files/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadWorkspaceFile(Expression<Func<string>> workspaceContentId, Expression<Func<bool>> redirect = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["redirect"] = Convert.ToString(true);
            if (redirect != null)
                callPayload.Queries["redirect"] = ExpressionConverter.Convert(redirect);
            return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CreateWorkspaceFileVersion(Expression<Func<string>> workspaceContentId, Expression<Func<object>> content = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CreateWorkspaceUrl(Expression<Func<bool>> openInNewWindow = null, Expression<Func<string>> bodyurlurl = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI> GetWorkspaceUrlDetails(Expression<Func<string>> workspaceContentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceUrl(Expression<Func<string>> workspaceContentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> UpdateWorkspaceUrl(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyurlurl = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/urls/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CopyWorkspaceUrl(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/urls/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> GetWorkspaceItemDetails(Expression<Func<string>> workspaceContentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItem(Expression<Func<string>> workspaceContentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> UpdateWorkspaceItem(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> CopyWorkspaceItem(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyparentFolderId = null)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/items/{0}/copy", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]> GetWorkspaceItenMembers(Expression<Func<string>> workspaceContentId)
        {
            var apiCallPath = String.Format("/integration/v2/workspace/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<CollaboratorResponse> AddCollaboratorAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyrole = null)
        {
            var apiCallPath = String.Format("/v1/items/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteCollaboratorAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> memberId)
        {
            var apiCallPath = String.Format("/v1/items/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction TransferOwnerAsync(Expression<Func<string>> workspaceContentId, Expression<Func<string>> bodyownerId = null)
        {
            var apiCallPath = String.Format("/v1/items/{0}/owner", ExpressionConverter.ConvertWithUrlEncoding(workspaceContentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction GetCustomPropertiesByFileId(Expression<Func<string>> fileId, Expression<Func<bool>> includeInvisibledInDC = null)
        {
            var apiCallPath = String.Format("/v1/files/{0}/customProperties", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeInvisibledInDC"] = Convert.ToString(false);
            if (includeInvisibledInDC != null)
                callPayload.Queries["includeInvisibledInDC"] = ExpressionConverter.Convert(includeInvisibledInDC);
            return new ApiConnectionAction(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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