//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Staffbase
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
        public IBodyWorkflowAction<ChannelsGetPostsResponse> ChannelsGetPosts(Expression<Func<string>> channelID, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_channelID = WorkflowExpression.Compile(channelID, nameof(channelID), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ChannelsGetPostsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/channels/{0}/posts", __workflow_channelID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ChannelsGetPostsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction ChannelsPost(Expression<Func<string>> channelID, Expression<Func<string>> bodyexternalID = null, Expression<Func<bodycontentsInputItem[]>> bodycontents = null, Expression<Func<string>> bodypublished = null)
        {
            var __workflow_channelID = WorkflowExpression.Compile(channelID, nameof(channelID), required: true);
            var __workflow_bodyexternalID = WorkflowExpression.Compile(bodyexternalID, nameof(bodyexternalID), required: false);
            var __workflow_bodycontents = WorkflowExpression.Compile(bodycontents, nameof(bodycontents), required: false);
            var __workflow_bodypublished = WorkflowExpression.Compile(bodypublished, nameof(bodypublished), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/channels/{0}/posts", __workflow_channelID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexternalID != null)
                {
                    body["externalID"] = ExpressionConverter.ConvertO(__workflow_bodyexternalID);
                    bodypropCount++;
                }

                if (__workflow_bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                    bodypropCount++;
                }

                if (__workflow_bodypublished != null)
                {
                    body["published"] = ExpressionConverter.ConvertO(__workflow_bodypublished);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<CommentsGetResponse> CommentsGet(Expression<Func<bool>> manage = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> filter = null)
        {
            var __workflow_manage = WorkflowExpression.Compile(manage, nameof(manage), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CommentsGetResponse>(() =>
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_manage != null)
                    callPayload.Queries["manage"] = ExpressionConverter.Convert(__workflow_manage);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<CommentsGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaGetResponse> MediaGet(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaGetResponse>(() =>
            {
                var apiCallPath = "/media";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<MediaGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaData> MediaGetByID(Expression<Func<string>> mediumID)
        {
            var __workflow_mediumID = WorkflowExpression.Compile(mediumID, nameof(mediumID), required: true);
            return new DeferredBodyAction<MediaData>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/media/{0}", __workflow_mediumID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MediaData>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction MediaDelete(Expression<Func<string>> mediumID)
        {
            var __workflow_mediumID = WorkflowExpression.Compile(mediumID, nameof(mediumID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/media/{0}", __workflow_mediumID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<NotificationPostResponse> Notification(Expression<Func<string[]>> bodyrecipientsaccessorIds = null, Expression<Func<bodycontentInputItem[]>> bodycontent = null, Expression<Func<string>> bodylink = null)
        {
            var __workflow_bodyrecipientsaccessorIds = WorkflowExpression.Compile(bodyrecipientsaccessorIds, nameof(bodyrecipientsaccessorIds), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: false);
            return new DeferredBodyAction<NotificationPostResponse>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var recipientsObject = new JObject();
                var recipientsObjectpropCount = 0;
                if (__workflow_bodyrecipientsaccessorIds != null)
                {
                    recipientsObject["accessorIds"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientsaccessorIds);
                    recipientsObjectpropCount++;
                }

                if (recipientsObjectpropCount > 0)
                {
                    body["recipients"] = recipientsObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NotificationPostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsGetAllResponse> PostsGetAll(Expression<Func<string>> query = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> manageable = null, Expression<Func<contentTypeInput>> contentType = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_manageable = WorkflowExpression.Compile(manageable, nameof(manageable), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<PostsGetAllResponse>(() =>
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["manageable"] = Convert.ToString(false);
                if (__workflow_manageable != null)
                    callPayload.Queries["manageable"] = ExpressionConverter.Convert(__workflow_manageable);
                if (__workflow_contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<PostsGetAllResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostData> PostsGetByID(Expression<Func<string>> pageID)
        {
            var __workflow_pageID = WorkflowExpression.Compile(pageID, nameof(pageID), required: true);
            return new DeferredBodyAction<PostData>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/posts/{0}", __workflow_pageID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostData>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsDeleteResponse> PostsDelete(Expression<Func<string>> pageID)
        {
            var __workflow_pageID = WorkflowExpression.Compile(pageID, nameof(pageID), required: true);
            return new DeferredBodyAction<PostsDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/posts/{0}", __workflow_pageID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostsDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction PostsPut(Expression<Func<string>> pageID, Expression<Func<string>> bodyexternalID = null, Expression<Func<bodycontentsInputItem2[]>> bodycontents = null)
        {
            var __workflow_pageID = WorkflowExpression.Compile(pageID, nameof(pageID), required: true);
            var __workflow_bodyexternalID = WorkflowExpression.Compile(bodyexternalID, nameof(bodyexternalID), required: false);
            var __workflow_bodycontents = WorkflowExpression.Compile(bodycontents, nameof(bodycontents), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/posts/{0}", __workflow_pageID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexternalID != null)
                {
                    body["externalID"] = ExpressionConverter.ConvertO(__workflow_bodyexternalID);
                    bodypropCount++;
                }

                if (__workflow_bodycontents != null)
                {
                    body["contents"] = ExpressionConverter.ConvertO(__workflow_bodycontents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserGetAll(Expression<Func<string>> filter = null, Expression<Func<string>> query = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction User(Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData> UserGetByID(Expression<Func<string>> userID)
        {
            var __workflow_userID = WorkflowExpression.Compile(userID, nameof(userID), required: true);
            return new DeferredBodyAction<UserData>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserData>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserDelete(Expression<Func<string>> userID)
        {
            var __workflow_userID = WorkflowExpression.Compile(userID, nameof(userID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData> UserPut(Expression<Func<string>> userID, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyexternalID = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodypublicEmailAddress = null, Expression<Func<string>> bodyconfiglocale = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null, Expression<Func<string[]>> bodygroupIDs = null, Expression<Func<string>> bodyposition = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodycreated = null, Expression<Func<string>> bodyupdated = null, Expression<Func<string>> bodyactivated = null)
        {
            var __workflow_userID = WorkflowExpression.Compile(userID, nameof(userID), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyexternalID = WorkflowExpression.Compile(bodyexternalID, nameof(bodyexternalID), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodypublicEmailAddress = WorkflowExpression.Compile(bodypublicEmailAddress, nameof(bodypublicEmailAddress), required: false);
            var __workflow_bodyconfiglocale = WorkflowExpression.Compile(bodyconfiglocale, nameof(bodyconfiglocale), required: false);
            var __workflow_bodyemails = WorkflowExpression.Compile(bodyemails, nameof(bodyemails), required: false);
            var __workflow_bodygroupIDs = WorkflowExpression.Compile(bodygroupIDs, nameof(bodygroupIDs), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: false);
            var __workflow_bodyupdated = WorkflowExpression.Compile(bodyupdated, nameof(bodyupdated), required: false);
            var __workflow_bodyactivated = WorkflowExpression.Compile(bodyactivated, nameof(bodyactivated), required: false);
            return new DeferredBodyAction<UserData>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalID != null)
                {
                    body["externalID"] = ExpressionConverter.ConvertO(__workflow_bodyexternalID);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodypublicEmailAddress != null)
                {
                    body["publicEmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodypublicEmailAddress);
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                if (__workflow_bodyconfiglocale != null)
                {
                    configObject["locale"] = ExpressionConverter.ConvertO(__workflow_bodyconfiglocale);
                    configObjectpropCount++;
                }

                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                if (__workflow_bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                    bodypropCount++;
                }

                if (__workflow_bodygroupIDs != null)
                {
                    body["groupIDs"] = ExpressionConverter.ConvertO(__workflow_bodygroupIDs);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
                    bodypropCount++;
                }

                if (__workflow_bodyupdated != null)
                {
                    body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdated);
                    bodypropCount++;
                }

                if (__workflow_bodyactivated != null)
                {
                    body["activated"] = ExpressionConverter.ConvertO(__workflow_bodyactivated);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserData>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserPostRecovery(Expression<Func<string>> userID)
        {
            var __workflow_userID = WorkflowExpression.Compile(userID, nameof(userID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/recovery", __workflow_userID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
