//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webex
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebexActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateSpaceMemberResponse> CreateSpaceMember([WorkflowExpression] Func<bool> bodyisModerator, [WorkflowExpression] Func<string> bodyroomId, [WorkflowExpression] Func<string> bodypersonEmail = null, [WorkflowExpression] Func<string> bodypersonId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/memberships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isModerator"] = SourceExpressionConverter.ConvertToken(bodyisModerator);
                if (bodypersonEmail != null)
                {
                    body["personEmail"] = SourceExpressionConverter.ConvertToken(bodypersonEmail);
                    bodypropCount++;
                }

                if (bodypersonId != null)
                {
                    body["personId"] = SourceExpressionConverter.ConvertToken(bodypersonId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["roomId"] = SourceExpressionConverter.ConvertToken(bodyroomId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSpaceMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessagesResponse> GetMessages([WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> mentionedPeople = null, [WorkflowExpression] Func<string> beforeMessage = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<int> max = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["roomId"] = SourceExpressionConverter.ConvertO(roomId);
                if (mentionedPeople != null)
                    callPayload.Queries["mentionedPeople"] = SourceExpressionConverter.ConvertO(mentionedPeople);
                if (beforeMessage != null)
                    callPayload.Queries["beforeMessage"] = SourceExpressionConverter.ConvertO(beforeMessage);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string[]> bodyfiles = null, [WorkflowExpression] Func<string> bodymarkdown = null, [WorkflowExpression] Func<string> bodyroomId = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodytoPersonEmail = null, [WorkflowExpression] Func<string> bodytoPersonId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfiles != null)
                {
                    body["files"] = SourceExpressionConverter.ConvertToken(bodyfiles);
                    bodypropCount++;
                }

                if (bodymarkdown != null)
                {
                    body["markdown"] = SourceExpressionConverter.ConvertToken(bodymarkdown);
                    bodypropCount++;
                }

                if (bodyroomId != null)
                {
                    body["roomId"] = SourceExpressionConverter.ConvertToken(bodyroomId);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodytoPersonEmail != null)
                {
                    body["toPersonEmail"] = SourceExpressionConverter.ConvertToken(bodytoPersonEmail);
                    bodypropCount++;
                }

                if (bodytoPersonId != null)
                {
                    body["toPersonId"] = SourceExpressionConverter.ConvertToken(bodytoPersonId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessageDetailsResponse> GetMessageDetails([WorkflowExpression] Func<string> messageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/messages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessageDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetPeopleResponse> GetPeople([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> email = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<GetPeopleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMyOwnDetailsResponse> GetMyOwnDetails()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/people/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyOwnDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetSpacesResponse> GetSpaces([WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<sortByInput> sortBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/rooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                callPayload.Queries["sortBy"] = Convert.ToString("lastactivity");
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.Convert(sortBy);
                return callPayload;
            }

            return new ApiConnectionAction<GetSpacesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateSpaceResponse> CreateSpace([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyteamId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/rooms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyteamId != null)
                {
                    body["teamId"] = SourceExpressionConverter.ConvertToken(bodyteamId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSpaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetSpaceDetailResponse> GetSpaceDetail([WorkflowExpression] Func<string> roomId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/rooms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSpaceDetailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateTeamMemberResponse> CreateTeamMember([WorkflowExpression] Func<bool> bodyisModerator, [WorkflowExpression] Func<string> bodyteamId, [WorkflowExpression] Func<string> bodypersonEmail = null, [WorkflowExpression] Func<string> bodypersonId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/team/memberships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isModerator"] = SourceExpressionConverter.ConvertToken(bodyisModerator);
                if (bodypersonEmail != null)
                {
                    body["personEmail"] = SourceExpressionConverter.ConvertToken(bodypersonEmail);
                    bodypropCount++;
                }

                if (bodypersonId != null)
                {
                    body["personId"] = SourceExpressionConverter.ConvertToken(bodypersonId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["teamId"] = SourceExpressionConverter.ConvertToken(bodyteamId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTeamMemberResponse>(BuildSourceInput);
        }
    }

    public class WebexTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MembershipsUpdatedResponse> MembershipsUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "updated";
                bodypropCount++;
                body["name"] = "MembershipUpdated";
                bodypropCount++;
                body["resource"] = "memberships";
                bodypropCount++;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<MembershipsUpdatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MembershipsDeletedResponse> MembershipsDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "deleted";
                bodypropCount++;
                body["name"] = "MembershipDeleted";
                bodypropCount++;
                body["resource"] = "memberships";
                bodypropCount++;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<MembershipsDeletedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MembershipsCreatedResponse> MembershipsCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "created";
                bodypropCount++;
                body["name"] = "MembershipCreated";
                bodypropCount++;
                body["resource"] = "memberships";
                bodypropCount++;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<MembershipsCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MessagesCreatedResponse> MessagesCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/4";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "created";
                bodypropCount++;
                body["name"] = "MessageCreated";
                bodypropCount++;
                body["resource"] = "messages";
                bodypropCount++;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<MessagesCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MessagesDeletedResponse> MessagesDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/5";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "deleted";
                bodypropCount++;
                body["name"] = "MessageDeleted";
                bodypropCount++;
                body["resource"] = "messages";
                bodypropCount++;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<MessagesDeletedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SpaceCreatedResponse> SpaceCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/6";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "created";
                bodypropCount++;
                body["name"] = "SpaceCreated";
                bodypropCount++;
                body["resource"] = "rooms";
                bodypropCount++;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<SpaceCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SpaceUpdatedResponse> SpaceUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/webhooks/7";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "updated";
                bodypropCount++;
                body["name"] = "SpaceUpdated";
                bodypropCount++;
                body["resource"] = "rooms";
                bodypropCount++;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<SpaceUpdatedResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class CreateSpaceMemberResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isModerator")]
        public bool IsModerator { get; set; }

        [JsonProperty("isMonitor")]
        public bool IsMonitor { get; set; }

        [JsonProperty("personDisplayName")]
        public string PersonDisplayName { get; set; }

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("personOrgId")]
        public string PersonOrgId { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public class GetMessagesResponse
    {
        [JsonProperty("items")]
        public GetMessagesResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetMessagesResponseItemsTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("roomType")]
        public string RoomType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendMessageResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("roomType")]
        public string RoomType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("toPersonEmail")]
        public string ToPersonEmail { get; set; }
    }

    public class GetMessageDetailsResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("files")]
        public string[] Files { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("mentionedGroups")]
        public string[] MentionedGroups { get; set; }

        [JsonProperty("mentionedPeople")]
        public string[] MentionedPeople { get; set; }

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("roomType")]
        public string RoomType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("toPersonEmail")]
        public string ToPersonEmail { get; set; }

        [JsonProperty("toPersonId")]
        public string ToPersonId { get; set; }
    }

    public class GetPeopleResponse
    {
        [JsonProperty("items")]
        public GetPeopleResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("notFoundIds")]
        public string[] NotFoundIds { get; set; }
    }

    public class GetPeopleResponseItemsTypeItem
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("phoneNumbers")]
        public GetPeopleResponseItemsTypeItemPhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetPeopleResponseItemsTypeItemPhoneNumbersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMyOwnDetailsResponse
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("phoneNumbers")]
        public GetMyOwnDetailsResponsePhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetMyOwnDetailsResponsePhoneNumbersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetSpacesResponse
    {
        [JsonProperty("items")]
        public GetSpacesResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetSpacesResponseItemsTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum typeInput
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "direct")]
        Direct
    }

    public enum sortByInput
    {
        [EnumMember(Value = "lastactivity")]
        Lastactivity,
        [EnumMember(Value = "created")]
        Created
    }

    public class CreateSpaceResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetSpaceDetailResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateTeamMemberResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isModerator")]
        public bool IsModerator { get; set; }

        [JsonProperty("personDisplayName")]
        public string PersonDisplayName { get; set; }

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("personOrgId")]
        public string PersonOrgId { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }
    }

    public class MembershipsUpdatedResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MembershipsDeletedResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MembershipsCreatedResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MessagesCreatedResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MessagesDeletedResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SpaceCreatedResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SpaceUpdatedResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webex;

    public partial class WorkflowManagedActions
    {
        public WebexActions Webex(string connectionId) => new WebexActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebexTriggers Webex(string connectionId) => new WebexTriggers(connectionId);
    }
}