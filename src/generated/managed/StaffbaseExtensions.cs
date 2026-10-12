//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Staffbase
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StaffbaseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<ChannelsGetListResponse> ChannelsGetList()
        {
            var apiCallPath = "/channels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ChannelsGetListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildChannelsGetPosts))]
        public IBodyWorkflowAction<ChannelsGetPostsResponse> ChannelsGetPosts([WorkflowExpression] Func<string> channelID, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChannelsGetPostsResponse> __BuildChannelsGetPosts(WorkflowExpression<string> channelID, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(channelID, nameof(channelID), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ChannelsGetPostsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/channels/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(channelID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<ChannelsGetPostsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildChannelsPost))]
        public IWorkflowAction ChannelsPost([WorkflowExpression] Func<string> channelID, [WorkflowExpression] Func<string> bodyexternalID = null, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents = null, [WorkflowExpression] Func<string> bodypublished = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildChannelsPost(WorkflowExpression<string> channelID, WorkflowExpression<string> bodyexternalID = null, WorkflowExpression<bodycontentsInputItem[]> bodycontents = null, WorkflowExpression<string> bodypublished = null)
        {
            WorkflowExpression.Validate(channelID, nameof(channelID), required: true);
            WorkflowExpression.Validate(bodyexternalID, nameof(bodyexternalID), required: false);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            WorkflowExpression.Validate(bodypublished, nameof(bodypublished), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/channels/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(channelID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexternalID != null)
                {
                    body["externalID"] = ExpressionConverter.ConvertO(bodyexternalID);
                    bodypropCount++;
                }

                if (bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                    bodypropCount++;
                }

                if (bodypublished != null)
                {
                    body["published"] = ExpressionConverter.ConvertO(bodypublished);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildCommentsGet))]
        public IBodyWorkflowAction<CommentsGetResponse> CommentsGet([WorkflowExpression] Func<bool> manage = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommentsGetResponse> __BuildCommentsGet(WorkflowExpression<bool> manage = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(manage, nameof(manage), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CommentsGetResponse>(() =>
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (manage != null)
                    callPayload.Queries["manage"] = ExpressionConverter.Convert(manage);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<CommentsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildMediaGet))]
        public IBodyWorkflowAction<MediaGetResponse> MediaGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MediaGetResponse> __BuildMediaGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaGetResponse>(() =>
            {
                var apiCallPath = "/media";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<MediaGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildMediaGetByID))]
        public IBodyWorkflowAction<MediaData> MediaGetByID([WorkflowExpression] Func<string> mediumID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MediaData> __BuildMediaGetByID(WorkflowExpression<string> mediumID)
        {
            WorkflowExpression.Validate(mediumID, nameof(mediumID), required: true);
            return new DeferredBodyAction<MediaData>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/media/{0}", ExpressionConverter.ConvertWithUrlEncoding(mediumID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MediaData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildMediaDelete))]
        public IWorkflowAction MediaDelete([WorkflowExpression] Func<string> mediumID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMediaDelete(WorkflowExpression<string> mediumID)
        {
            WorkflowExpression.Validate(mediumID, nameof(mediumID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/media/{0}", ExpressionConverter.ConvertWithUrlEncoding(mediumID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildNotification))]
        public IBodyWorkflowAction<NotificationPostResponse> Notification([WorkflowExpression] Func<string[]> bodyrecipientsaccessorIds = null, [WorkflowExpression] Func<bodycontentInputItem[]> bodycontent = null, [WorkflowExpression] Func<string> bodylink = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NotificationPostResponse> __BuildNotification(WorkflowExpression<string[]> bodyrecipientsaccessorIds = null, WorkflowExpression<bodycontentInputItem[]> bodycontent = null, WorkflowExpression<string> bodylink = null)
        {
            WorkflowExpression.Validate(bodyrecipientsaccessorIds, nameof(bodyrecipientsaccessorIds), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodylink, nameof(bodylink), required: false);
            return new DeferredBodyAction<NotificationPostResponse>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var recipientsObject = new JObject();
                var recipientsObjectpropCount = 0;
                if (bodyrecipientsaccessorIds != null)
                {
                    recipientsObject["accessorIds"] = ExpressionConverter.ConvertO(bodyrecipientsaccessorIds);
                    recipientsObjectpropCount++;
                }

                if (recipientsObjectpropCount > 0)
                {
                    body["recipients"] = recipientsObject;
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(bodylink);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NotificationPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildPostsGetAll))]
        public IBodyWorkflowAction<PostsGetAllResponse> PostsGetAll([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> manageable = null, [WorkflowExpression] Func<contentTypeInput> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostsGetAllResponse> __BuildPostsGetAll(WorkflowExpression<string> query = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<bool> manageable = null, WorkflowExpression<contentTypeInput> contentType = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(manageable, nameof(manageable), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<PostsGetAllResponse>(() =>
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                callPayload.Queries["manageable"] = Convert.ToString(false);
                if (manageable != null)
                    callPayload.Queries["manageable"] = ExpressionConverter.Convert(manageable);
                if (contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction<PostsGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildPostsGetByID))]
        public IBodyWorkflowAction<PostData> PostsGetByID([WorkflowExpression] Func<string> pageID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostData> __BuildPostsGetByID(WorkflowExpression<string> pageID)
        {
            WorkflowExpression.Validate(pageID, nameof(pageID), required: true);
            return new DeferredBodyAction<PostData>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildPostsDelete))]
        public IBodyWorkflowAction<PostsDeleteResponse> PostsDelete([WorkflowExpression] Func<string> pageID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostsDeleteResponse> __BuildPostsDelete(WorkflowExpression<string> pageID)
        {
            WorkflowExpression.Validate(pageID, nameof(pageID), required: true);
            return new DeferredBodyAction<PostsDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildPostsPut))]
        public IWorkflowAction PostsPut([WorkflowExpression] Func<string> pageID, [WorkflowExpression] Func<string> bodyexternalID = null, [WorkflowExpression] Func<bodycontentsInputItem2[]> bodycontents = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostsPut(WorkflowExpression<string> pageID, WorkflowExpression<string> bodyexternalID = null, WorkflowExpression<bodycontentsInputItem2[]> bodycontents = null)
        {
            WorkflowExpression.Validate(pageID, nameof(pageID), required: true);
            WorkflowExpression.Validate(bodyexternalID, nameof(bodyexternalID), required: false);
            WorkflowExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexternalID != null)
                {
                    body["externalID"] = ExpressionConverter.ConvertO(bodyexternalID);
                    bodypropCount++;
                }

                if (bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(bodycontents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildUserGetAll))]
        public IWorkflowAction UserGetAll([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> query = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUserGetAll(WorkflowExpression<string> filter = null, WorkflowExpression<string> query = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(query, nameof(query), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildUser))]
        public IWorkflowAction User([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUser(WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildUserGetByID))]
        public IBodyWorkflowAction<UserData> UserGetByID([WorkflowExpression] Func<string> userID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserData> __BuildUserGetByID(WorkflowExpression<string> userID)
        {
            WorkflowExpression.Validate(userID, nameof(userID), required: true);
            return new DeferredBodyAction<UserData>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildUserDelete))]
        public IWorkflowAction UserDelete([WorkflowExpression] Func<string> userID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUserDelete(WorkflowExpression<string> userID)
        {
            WorkflowExpression.Validate(userID, nameof(userID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildUserPut))]
        public IBodyWorkflowAction<UserData> UserPut([WorkflowExpression] Func<string> userID, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyexternalID = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodypublicEmailAddress = null, [WorkflowExpression] Func<string> bodyconfiglocale = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null, [WorkflowExpression] Func<string[]> bodygroupIDs = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodyupdated = null, [WorkflowExpression] Func<string> bodyactivated = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserData> __BuildUserPut(WorkflowExpression<string> userID, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodyexternalID = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodypublicEmailAddress = null, WorkflowExpression<string> bodyconfiglocale = null, WorkflowExpression<bodyemailsInputItem[]> bodyemails = null, WorkflowExpression<string[]> bodygroupIDs = null, WorkflowExpression<string> bodyposition = null, WorkflowExpression<string> bodydepartment = null, WorkflowExpression<string> bodylocation = null, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<string> bodycreated = null, WorkflowExpression<string> bodyupdated = null, WorkflowExpression<string> bodyactivated = null)
        {
            WorkflowExpression.Validate(userID, nameof(userID), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodyexternalID, nameof(bodyexternalID), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodypublicEmailAddress, nameof(bodypublicEmailAddress), required: false);
            WorkflowExpression.Validate(bodyconfiglocale, nameof(bodyconfiglocale), required: false);
            WorkflowExpression.Validate(bodyemails, nameof(bodyemails), required: false);
            WorkflowExpression.Validate(bodygroupIDs, nameof(bodygroupIDs), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            WorkflowExpression.Validate(bodyupdated, nameof(bodyupdated), required: false);
            WorkflowExpression.Validate(bodyactivated, nameof(bodyactivated), required: false);
            return new DeferredBodyAction<UserData>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyexternalID != null)
                {
                    body["externalID"] = ExpressionConverter.ConvertO(bodyexternalID);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodypublicEmailAddress != null)
                {
                    body["publicEmailAddress"] = ExpressionConverter.ConvertO(bodypublicEmailAddress);
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                if (bodyconfiglocale != null)
                {
                    configObject["locale"] = ExpressionConverter.ConvertO(bodyconfiglocale);
                    configObjectpropCount++;
                }

                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(bodyemails);
                    bodypropCount++;
                }

                if (bodygroupIDs != null)
                {
                    body["groupIDs"] = ExpressionConverter.ConvertO(bodygroupIDs);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(bodycreated);
                    bodypropCount++;
                }

                if (bodyupdated != null)
                {
                    body["updated"] = ExpressionConverter.ConvertO(bodyupdated);
                    bodypropCount++;
                }

                if (bodyactivated != null)
                {
                    body["activated"] = ExpressionConverter.ConvertO(bodyactivated);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        [WorkflowExpressionFactory(nameof(__BuildUserPostRecovery))]
        public IWorkflowAction UserPostRecovery([WorkflowExpression] Func<string> userID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUserPostRecovery(WorkflowExpression<string> userID)
        {
            WorkflowExpression.Validate(userID, nameof(userID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/recovery", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction ProxyVersionGet()
        {
            var apiCallPath = "/version";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class StaffbaseTriggers([ConnectionName] string connectionId)
    {
    }

    public class ChannelsGetListResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("data")]
        public ChannelsGetListResponseDataTypeItem[] Data { get; set; }
    }

    public class ChannelsGetListResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("config")]
        public ChannelsGetListResponseDataTypeItemConfigType Config { get; set; }

        [JsonProperty("spaceID")]
        public string SpaceID { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class ChannelsGetListResponseDataTypeItemConfigType
    {
        [JsonProperty("localization")]
        public ChannelsGetListResponseDataTypeItemConfigTypeLocalizationTypeItem[] Localization { get; set; }
    }

    public class ChannelsGetListResponseDataTypeItemConfigTypeLocalizationTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class ChannelsGetPostsResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("data")]
        public PostData[] Data { get; set; }
    }

    public class PostData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public AuthorObject Author { get; set; }

        [JsonProperty("contents")]
        public PostDataContentsTypeItem[] Contents { get; set; }

        [JsonProperty("channel")]
        public PostDataChannelType Channel { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class AuthorObject
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public AuthorObjectAvatarType Avatar { get; set; }
    }

    public class AuthorObjectAvatarType
    {
        [JsonProperty("original")]
        public AuthorObjectAvatarTypeOriginalType Original { get; set; }

        [JsonProperty("icon")]
        public AuthorObjectAvatarTypeIconType Icon { get; set; }

        [JsonProperty("thumb")]
        public AuthorObjectAvatarTypeThumbType Thumb { get; set; }

        [JsonProperty("publicID")]
        public string PublicID { get; set; }
    }

    public class AuthorObjectAvatarTypeOriginalType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class AuthorObjectAvatarTypeIconType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class AuthorObjectAvatarTypeThumbType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class PostDataContentsTypeItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public ImageObject Image { get; set; }

        [JsonProperty("teaser")]
        public string Teaser { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class ImageObject
    {
        [JsonProperty("original")]
        public ImageObjectOriginalType Original { get; set; }

        [JsonProperty("original_scaled")]
        public ImageObjectOriginalScaledType OriginalScaled { get; set; }

        [JsonProperty("compact")]
        public ImageObjectCompactType Compact { get; set; }
    }

    public class ImageObjectOriginalType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class ImageObjectOriginalScaledType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class ImageObjectCompactType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class PostDataChannelType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("config")]
        public PostDataChannelTypeConfigType Config { get; set; }
    }

    public class PostDataChannelTypeConfigType
    {
        [JsonProperty("localization")]
        public PostDataChannelTypeConfigTypeLocalizationTypeItem[] Localization { get; set; }
    }

    public class PostDataChannelTypeConfigTypeLocalizationTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class bodycontentsInputItem
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("teaser")]
        public string Teaser { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CommentsGetResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("data")]
        public CommentsGetResponseDataTypeItem[] Data { get; set; }
    }

    public class CommentsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentID")]
        public string ParentID { get; set; }

        [JsonProperty("parentType")]
        public string ParentType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("rootID")]
        public string RootID { get; set; }

        [JsonProperty("author")]
        public AuthorObject Author { get; set; }

        [JsonProperty("likes")]
        public CommentsGetResponseDataTypeItemLikesType Likes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("image")]
        public ImageObject Image { get; set; }
    }

    public class CommentsGetResponseDataTypeItemLikesType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("isLiked")]
        public CommentsGetResponseDataTypeItemLikesTypeIsLikedType IsLiked { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommentsGetResponseDataTypeItemLikesTypeIsLikedType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class MediaGetResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("data")]
        public MediaData[] Data { get; set; }
    }

    public class MediaData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ownerID")]
        public string OwnerID { get; set; }

        [JsonProperty("parentID")]
        public string ParentID { get; set; }

        [JsonProperty("publicID")]
        public string PublicID { get; set; }

        [JsonProperty("resourceInfo")]
        public MediaDataResourceInfoType ResourceInfo { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class MediaDataResourceInfoType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bytes")]
        public int Bytes { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class NotificationPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipients")]
        public NotificationPostResponseRecipientsType Recipients { get; set; }

        [JsonProperty("content")]
        public NotificationPostResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class NotificationPostResponseRecipientsType
    {
        [JsonProperty("accessorIds")]
        public string[] AccessorIds { get; set; }
    }

    public class NotificationPostResponseContentTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class bodycontentInputItem
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class PostsGetAllResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("data")]
        public PostData[] Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum contentTypeInput
    {
        [EnumMember(Value = "articles")]
        Articles,
        [EnumMember(Value = "pictures")]
        Pictures,
        [EnumMember(Value = "updates")]
        Updates
    }

    public class PostsDeleteResponse
    {
        [JsonProperty("identifier")]
        public int Identifier { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodycontentsInputItem2
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("teaser")]
        public string Teaser { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }
    }

    public class UserData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("externalID")]
        public string ExternalID { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("publicEmailAddress")]
        public string PublicEmailAddress { get; set; }

        [JsonProperty("config")]
        public UserDataConfigType Config { get; set; }

        [JsonProperty("emails")]
        public UserDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("groupIDs")]
        public string[] GroupIDs { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("activated")]
        public string Activated { get; set; }
    }

    public class UserDataConfigType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class UserDataEmailsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }

    public class bodyemailsInputItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Staffbase;

    public partial class WorkflowManagedActions
    {
        public StaffbaseActions Staffbase(string connectionId) => new StaffbaseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StaffbaseTriggers Staffbase(string connectionId) => new StaffbaseTriggers(connectionId);
    }
}