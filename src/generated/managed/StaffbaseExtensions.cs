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
        public IBodyWorkflowAction<ChannelsGetListResponse, ApiConnectionActionConfiguration> ChannelsGetList()
        {
            return new DeferredBodyAction<ChannelsGetListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/channels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChannelsGetListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<ChannelsGetPostsResponse, ApiConnectionActionConfiguration> ChannelsGetPosts(Expression<Func<string>> channelId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ChannelsGetPostsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/channels/{0}/posts", __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ChannelsGetPostsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ChannelsPost(Expression<Func<string>> channelId, Expression<Func<ChannelsPostBodyInput>> body = null)
        {
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/channels/{0}/posts", __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<CommentsGetResponse, ApiConnectionActionConfiguration> CommentsGet(Expression<Func<bool>> manage = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> filter = null)
        {
            var __workflow_manage = WorkflowExpression.Compile(manage, nameof(manage), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CommentsGetResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaGetResponse, ApiConnectionActionConfiguration> MediaGet(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaGetResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaData, ApiConnectionActionConfiguration> MediaGetById(Expression<Func<string>> mediumId)
        {
            var __workflow_mediumId = WorkflowExpression.Compile(mediumId, nameof(mediumId), required: true);
            return new DeferredBodyAction<MediaData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/media/{0}", __workflow_mediumId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MediaData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MediaDelete(Expression<Func<string>> mediumId)
        {
            var __workflow_mediumId = WorkflowExpression.Compile(mediumId, nameof(mediumId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/media/{0}", __workflow_mediumId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<NotificationResponse, ApiConnectionActionConfiguration> Notification(Expression<Func<NotificationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<NotificationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsGetAllResponse, ApiConnectionActionConfiguration> PostsGetAll(Expression<Func<string>> query = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> manageable = null, Expression<Func<ContentTypeInput>> contentType = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_manageable = WorkflowExpression.Compile(manageable, nameof(manageable), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<PostsGetAllResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostData, ApiConnectionActionConfiguration> PostsGetById(Expression<Func<string>> pageId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<PostData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/posts/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsDeleteResponse, ApiConnectionActionConfiguration> PostsDelete(Expression<Func<string>> pageId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<PostsDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/posts/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostsPut(Expression<Func<string>> pageId, Expression<Func<PostsPutBodyInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/posts/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UserGetAll(Expression<Func<string>> filter = null, Expression<Func<string>> query = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> User(Expression<Func<UserBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData, ApiConnectionActionConfiguration> UserGetById(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UserDelete(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData, ApiConnectionActionConfiguration> UserPut(Expression<Func<string>> userId, Expression<Func<UserPutBodyInput>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UserPostRecovery(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/recovery", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProxyVersionGet()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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
        public string SpaceId { get; set; }

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
        public string PublicId { get; set; }
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

    public class ChannelsPostBodyInput
    {
        [JsonProperty("externalID")]
        public string ExternalId { get; set; }

        [JsonProperty("contents")]
        public ChannelsPostBodyInputContentsTypeItem[] Contents { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }
    }

    public class ChannelsPostBodyInputContentsTypeItem
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
        public string ParentId { get; set; }

        [JsonProperty("parentType")]
        public string ParentType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("rootID")]
        public string RootId { get; set; }

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
        public string OwnerId { get; set; }

        [JsonProperty("parentID")]
        public string ParentId { get; set; }

        [JsonProperty("publicID")]
        public string PublicId { get; set; }

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

    public class NotificationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipients")]
        public NotificationResponseRecipientsType Recipients { get; set; }

        [JsonProperty("content")]
        public NotificationResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class NotificationResponseRecipientsType
    {
        [JsonProperty("accessorIds")]
        public string[] AccessorIds { get; set; }
    }

    public class NotificationResponseContentTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class NotificationBodyInput
    {
        [JsonProperty("recipients")]
        public BodyInputRecipientsType Recipients { get; set; }

        [JsonProperty("content")]
        public BodyInputContentTypeItem[] Content { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class BodyInputRecipientsType
    {
        [JsonProperty("accessorIds")]
        public string[] AccessorIds { get; set; }
    }

    public class BodyInputContentTypeItem
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
    public enum ContentTypeInput
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

    public class PostsPutBodyInput
    {
        [JsonProperty("externalID")]
        public string ExternalId { get; set; }

        [JsonProperty("contents")]
        public PostsPutBodyInputContentsTypeItem[] Contents { get; set; }
    }

    public class PostsPutBodyInputContentsTypeItem
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

    public class UserBodyInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class UserData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("externalID")]
        public string ExternalId { get; set; }

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

    public class UserPutBodyInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("externalID")]
        public string ExternalId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("publicEmailAddress")]
        public string PublicEmailAddress { get; set; }

        [JsonProperty("config")]
        public BodyInputConfigType Config { get; set; }

        [JsonProperty("emails")]
        public BodyInputEmailsTypeItem[] Emails { get; set; }

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

    public class BodyInputConfigType
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class BodyInputEmailsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }
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