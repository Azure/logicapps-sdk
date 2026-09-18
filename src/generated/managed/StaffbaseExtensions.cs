//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Staffbase
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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/channels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ChannelsGetListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<ChannelsGetPostsResponse> ChannelsGetPosts([WorkflowExpression] Func<string> channelID, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(channelID, nameof(channelID), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/channels/{0}/posts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ChannelsGetPostsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction ChannelsPost([WorkflowExpression] Func<string> channelID, [WorkflowExpression] Func<string> bodyexternalID = null, [WorkflowExpression] Func<bodycontentsInputItem[]> bodycontents = null, [WorkflowExpression] Func<string> bodypublished = null)
        {
            SourceExpression.Validate(channelID, nameof(channelID), required: true);
            SourceExpression.Validate(bodyexternalID, nameof(bodyexternalID), required: false);
            SourceExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            SourceExpression.Validate(bodypublished, nameof(bodypublished), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/channels/{0}/posts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(channelID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexternalID != null)
                {
                    body["externalID"] = SourceExpressionConverter.ConvertToken(bodyexternalID);
                    bodypropCount++;
                }

                if (bodycontents != null)
                {
                    body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
                    bodypropCount++;
                }

                if (bodypublished != null)
                {
                    body["published"] = SourceExpressionConverter.ConvertToken(bodypublished);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<CommentsGetResponse> CommentsGet([WorkflowExpression] Func<bool> manage = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> filter = null)
        {
            SourceExpression.Validate(manage, nameof(manage), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/comments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (manage != null)
                    callPayload.Queries["manage"] = SourceExpressionConverter.ConvertO(manage);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<CommentsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaGetResponse> MediaGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/media";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<MediaGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<MediaData> MediaGetByID([WorkflowExpression] Func<string> mediumID)
        {
            SourceExpression.Validate(mediumID, nameof(mediumID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/media/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mediumID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MediaData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction MediaDelete([WorkflowExpression] Func<string> mediumID)
        {
            SourceExpression.Validate(mediumID, nameof(mediumID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/media/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mediumID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<NotificationPostResponse> Notification([WorkflowExpression] Func<string[]> bodyrecipientsaccessorIds = null, [WorkflowExpression] Func<bodycontentInputItem[]> bodycontent = null, [WorkflowExpression] Func<string> bodylink = null)
        {
            SourceExpression.Validate(bodyrecipientsaccessorIds, nameof(bodyrecipientsaccessorIds), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    recipientsObject["accessorIds"] = SourceExpressionConverter.ConvertToken(bodyrecipientsaccessorIds);
                    recipientsObjectpropCount++;
                }

                if (recipientsObjectpropCount > 0)
                {
                    body["recipients"] = recipientsObject;
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NotificationPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsGetAllResponse> PostsGetAll([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> manageable = null, [WorkflowExpression] Func<contentTypeInput> contentType = null)
        {
            SourceExpression.Validate(query, nameof(query), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(manageable, nameof(manageable), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/posts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                callPayload.Queries["manageable"] = Convert.ToString(false);
                if (manageable != null)
                    callPayload.Queries["manageable"] = SourceExpressionConverter.ConvertO(manageable);
                if (contentType != null)
                    callPayload.Queries["contentType"] = SourceExpressionConverter.Convert(contentType);
                return callPayload;
            }

            return new ApiConnectionAction<PostsGetAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostData> PostsGetByID([WorkflowExpression] Func<string> pageID)
        {
            SourceExpression.Validate(pageID, nameof(pageID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/posts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PostData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<PostsDeleteResponse> PostsDelete([WorkflowExpression] Func<string> pageID)
        {
            SourceExpression.Validate(pageID, nameof(pageID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/posts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PostsDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction PostsPut([WorkflowExpression] Func<string> pageID, [WorkflowExpression] Func<string> bodyexternalID = null, [WorkflowExpression] Func<bodycontentsInputItem2[]> bodycontents = null)
        {
            SourceExpression.Validate(pageID, nameof(pageID), required: true);
            SourceExpression.Validate(bodyexternalID, nameof(bodyexternalID), required: false);
            SourceExpression.Validate(bodycontents, nameof(bodycontents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/posts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexternalID != null)
                {
                    body["externalID"] = SourceExpressionConverter.ConvertToken(bodyexternalID);
                    bodypropCount++;
                }

                if (bodycontents != null)
                {
                    body["contents"] = SourceExpressionConverter.ConvertToken(bodycontents);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserGetAll([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction User([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData> UserGetByID([WorkflowExpression] Func<string> userID)
        {
            SourceExpression.Validate(userID, nameof(userID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserDelete([WorkflowExpression] Func<string> userID)
        {
            SourceExpression.Validate(userID, nameof(userID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IBodyWorkflowAction<UserData> UserPut([WorkflowExpression] Func<string> userID, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyexternalID = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodypublicEmailAddress = null, [WorkflowExpression] Func<string> bodyconfiglocale = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null, [WorkflowExpression] Func<string[]> bodygroupIDs = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodyupdated = null, [WorkflowExpression] Func<string> bodyactivated = null)
        {
            SourceExpression.Validate(userID, nameof(userID), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyexternalID, nameof(bodyexternalID), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodypublicEmailAddress, nameof(bodypublicEmailAddress), required: false);
            SourceExpression.Validate(bodyconfiglocale, nameof(bodyconfiglocale), required: false);
            SourceExpression.Validate(bodyemails, nameof(bodyemails), required: false);
            SourceExpression.Validate(bodygroupIDs, nameof(bodygroupIDs), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            SourceExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            SourceExpression.Validate(bodyupdated, nameof(bodyupdated), required: false);
            SourceExpression.Validate(bodyactivated, nameof(bodyactivated), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyexternalID != null)
                {
                    body["externalID"] = SourceExpressionConverter.ConvertToken(bodyexternalID);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodypublicEmailAddress != null)
                {
                    body["publicEmailAddress"] = SourceExpressionConverter.ConvertToken(bodypublicEmailAddress);
                    bodypropCount++;
                }

                var configObject = new JObject();
                var configObjectpropCount = 0;
                if (bodyconfiglocale != null)
                {
                    configObject["locale"] = SourceExpressionConverter.ConvertToken(bodyconfiglocale);
                    configObjectpropCount++;
                }

                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["emails"] = SourceExpressionConverter.ConvertToken(bodyemails);
                    bodypropCount++;
                }

                if (bodygroupIDs != null)
                {
                    body["groupIDs"] = SourceExpressionConverter.ConvertToken(bodygroupIDs);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                    bodypropCount++;
                }

                if (bodyupdated != null)
                {
                    body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdated);
                    bodypropCount++;
                }

                if (bodyactivated != null)
                {
                    body["activated"] = SourceExpressionConverter.ConvertToken(bodyactivated);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction UserPostRecovery([WorkflowExpression] Func<string> userID)
        {
            SourceExpression.Validate(userID, nameof(userID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/recovery", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staffbase")]
        public IWorkflowAction ProxyVersionGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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