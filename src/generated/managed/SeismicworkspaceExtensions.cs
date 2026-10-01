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
        public IBodyWorkflowAction<SeismicPagingWorkspaceCommentWorkspaceComment> GetWorkspaceItemComments([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> versionId = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (versionId != null)
                    callPayload.Queries["versionId"] = SourceExpressionConverter.ConvertO(versionId);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicPagingWorkspaceCommentWorkspaceComment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse> AddWorkspaceItemComments([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<bodyannotationtypeInput> bodyannotationtype = null, [WorkflowExpression] Func<int> bodyannotationpage = null, [WorkflowExpression] Func<string> bodyannotationcolor = null, [WorkflowExpression] Func<SeismicPublicIntegrationApiOriginApiClientModelsContentManagerPointServiceModel[]> bodyannotationpoints = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceVersionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                var annotationObject = new JObject();
                var annotationObjectpropCount = 0;
                if (bodyannotationtype != null)
                {
                    annotationObject["type"] = SourceExpressionConverter.Convert(bodyannotationtype);
                    annotationObjectpropCount++;
                }

                if (bodyannotationpage != null)
                {
                    annotationObject["page"] = SourceExpressionConverter.ConvertToken(bodyannotationpage);
                    annotationObjectpropCount++;
                }

                if (bodyannotationcolor != null)
                {
                    annotationObject["color"] = SourceExpressionConverter.ConvertToken(bodyannotationcolor);
                    annotationObjectpropCount++;
                }

                if (bodyannotationpoints != null)
                {
                    annotationObject["points"] = SourceExpressionConverter.ConvertToken(bodyannotationpoints);
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
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkspaceCommentsWorkspaceAddCommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse> AddReplyToComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId, [WorkflowExpression] Func<string> bodytext = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceVersionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkspaceCommentsWorkspaceReplyCommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItemComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceVersionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItemCommentsReply([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId, [WorkflowExpression] Func<string> replyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/reply/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceVersionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(replyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction ResolveWorkspaceItemComment([WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> workspaceVersionId, [WorkflowExpression] Func<string> commentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/spaces/{0}/items/{1}/versions/{2}/comments/{3}/resolve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceVersionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceFolder([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/workspace/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> GetWorkspaceFolderDetails([WorkflowExpression] Func<string> workspaceFolderId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceFolder([WorkflowExpression] Func<string> workspaceFolderId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> UpdateWorkspaceFolder([WorkflowExpression] Func<string> workspaceFolderId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicCommonWorkSpaceContentManagerWsItemResp> GetWorkspaceFolderItems([WorkflowExpression] Func<string> workspaceFolderId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicCommonWorkSpaceContentManagerWsItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CopyWorkspaceFolder([WorkflowExpression] Func<string> workspaceFolderId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/folders/{0}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI> CreateWorkspaceContextualFolder([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysystemType = null, [WorkflowExpression] Func<string> bodycontextType = null, [WorkflowExpression] Func<string> bodycontextTypePlural = null, [WorkflowExpression] Func<string> bodycontextId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/workspace/folders/createContextualFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodysystemType != null)
                {
                    body["systemType"] = SourceExpressionConverter.ConvertToken(bodysystemType);
                    bodypropCount++;
                }

                if (bodycontextType != null)
                {
                    body["contextType"] = SourceExpressionConverter.ConvertToken(bodycontextType);
                    bodypropCount++;
                }

                if (bodycontextTypePlural != null)
                {
                    body["contextTypePlural"] = SourceExpressionConverter.ConvertToken(bodycontextTypePlural);
                    bodypropCount++;
                }

                if (bodycontextId != null)
                {
                    body["contextId"] = SourceExpressionConverter.ConvertToken(bodycontextId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFolderRespForAddAPI>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> GetWorkspaceFileDetails([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> UpdateWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsFileResp> CopyWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsFileResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadWorkspaceFile([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<bool> redirect = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/files/{0}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (redirect != null)
                    callPayload.Queries["redirect"] = SourceExpressionConverter.ConvertO(redirect);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CreateWorkspaceUrl([WorkflowExpression] Func<bool> openInNewWindow = null, [WorkflowExpression] Func<string> bodyurlurl = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/workspace/urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["openInNewWindow"] = Convert.ToString(false);
                if (openInNewWindow != null)
                    callPayload.Queries["openInNewWindow"] = SourceExpressionConverter.ConvertO(openInNewWindow);
                var body = new JObject();
                var bodypropCount = 0;
                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = SourceExpressionConverter.ConvertToken(bodyurlurl);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI> GetWorkspaceUrlDetails([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlRespForGetAPI>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceUrl([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> UpdateWorkspaceUrl([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyurlurl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = SourceExpressionConverter.ConvertToken(bodyurlurl);
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
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsUrlResp> CopyWorkspaceUrl([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/urls/{0}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsUrlResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> GetWorkspaceItemDetails([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteWorkspaceItem([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> UpdateWorkspaceItem([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> CopyWorkspaceItem([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/items/{0}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]> GetWorkspaceItenMembers([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/workspace/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicWorkspacePermissionsAndSharingWorkspaceMemberResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IBodyWorkflowAction<CollaboratorResponse> AddCollaboratorAsync([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyrole = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CollaboratorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction DeleteCollaboratorAsync([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> memberId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/members/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction TransferOwnerAsync([WorkflowExpression] Func<string> workspaceContentId, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/items/{0}/owner", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicworkspace")]
        public IWorkflowAction GetCustomPropertiesByFileId([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<bool> includeInvisibledInDC = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/files/{0}/customProperties", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeInvisibledInDC"] = Convert.ToString(false);
                if (includeInvisibledInDC != null)
                    callPayload.Queries["includeInvisibledInDC"] = SourceExpressionConverter.ConvertO(includeInvisibledInDC);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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