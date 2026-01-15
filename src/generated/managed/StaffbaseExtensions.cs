//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Staffbase
{
    using System.Linq.Expressions;
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
            var apiCallPath = String.Format("/channels/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(channelID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ChannelsGetPostsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction ChannelsPostPost(Expression<Func<string>> channelID, Expression<Func<string>> bodyexternalID = null, Expression<Func<bodycontentsInputItem[]>> bodycontents = null, Expression<Func<string>> bodypublished = null)
        {
            var apiCallPath = String.Format("/channels/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(channelID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<CommentsGetResponse> CommentsGet(Expression<Func<bool>> manage = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> filter = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaGetResponse> MediaGet(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaData> MediaGetByID(Expression<Func<string>> mediumID)
        {
            var apiCallPath = String.Format("/media/{0}", ExpressionConverter.ConvertWithUrlEncoding(mediumID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MediaData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction MediaDelete(Expression<Func<string>> mediumID)
        {
            var apiCallPath = String.Format("/media/{0}", ExpressionConverter.ConvertWithUrlEncoding(mediumID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<NotificationPostResponse> NotificationPost(Expression<Func<string[]>> bodyrecipientsaccessorIds = null, Expression<Func<bodycontentInputItem[]>> bodycontent = null, Expression<Func<string>> bodylink = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsGetAllResponse> PostsGetAll(Expression<Func<string>> query = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> manageable = null, Expression<Func<contentTypeInput>> contentType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostData> PostsGetByID(Expression<Func<string>> pageID)
        {
            var apiCallPath = String.Format("/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PostData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsDeleteResponse> PostsDelete(Expression<Func<string>> pageID)
        {
            var apiCallPath = String.Format("/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PostsDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction PostsPut(Expression<Func<string>> pageID, Expression<Func<string>> bodyexternalID = null, Expression<Func<bodycontentsInputItem2[]>> bodycontents = null)
        {
            var apiCallPath = String.Format("/posts/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserGetAll(Expression<Func<string>> filter = null, Expression<Func<string>> query = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserPost(Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData> UserGetByID(Expression<Func<string>> userID)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserDelete(Expression<Func<string>> userID)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData> UserPut(Expression<Func<string>> userID, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyexternalID = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodypublicEmailAddress = null, Expression<Func<string>> bodyconfiglocale = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null, Expression<Func<string[]>> bodygroupIDs = null, Expression<Func<string>> bodyposition = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodycreated = null, Expression<Func<string>> bodyupdated = null, Expression<Func<string>> bodyactivated = null)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserPostRecovery(Expression<Func<string>> userID)
        {
            var apiCallPath = String.Format("/users/{0}/recovery", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Staffbase;

    public partial class WorkflowManagedActions
    {
        public StaffbaseActions Staffbase(string connectionId) => new StaffbaseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StaffbaseTriggers Staffbase(string connectionId) => new StaffbaseTriggers(connectionId);
    }
}