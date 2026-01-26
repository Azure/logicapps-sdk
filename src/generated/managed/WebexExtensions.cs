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
        public IBodyWorkflowAction<CreateSpaceMemberResponse> CreateSpaceMember(Expression<Func<bool>> bodyisModerator, Expression<Func<string>> bodyroomId, Expression<Func<string>> bodypersonEmail = null, Expression<Func<string>> bodypersonId = null)
        {
            var apiCallPath = "/v1/memberships";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["isModerator"] = ExpressionConverter.ConvertO(bodyisModerator);
            if (bodypersonEmail != null)
            {
                body["personEmail"] = ExpressionConverter.ConvertO(bodypersonEmail);
                bodypropCount++;
            }

            if (bodypersonId != null)
            {
                body["personId"] = ExpressionConverter.ConvertO(bodypersonId);
                bodypropCount++;
            }

            bodypropCount++;
            body["roomId"] = ExpressionConverter.ConvertO(bodyroomId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateSpaceMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessagesResponse> GetMessages(Expression<Func<string>> roomId, Expression<Func<string>> mentionedPeople = null, Expression<Func<string>> beforeMessage = null, Expression<Func<string>> before = null, Expression<Func<int>> max = null)
        {
            var apiCallPath = "/v1/messages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["roomId"] = ExpressionConverter.Convert(roomId);
            if (mentionedPeople != null)
                callPayload.Queries["mentionedPeople"] = ExpressionConverter.Convert(mentionedPeople);
            if (beforeMessage != null)
                callPayload.Queries["beforeMessage"] = ExpressionConverter.Convert(beforeMessage);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            return new ApiConnectionAction<GetMessagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string[]>> bodyfiles = null, Expression<Func<string>> bodymarkdown = null, Expression<Func<string>> bodyroomId = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodytoPersonEmail = null, Expression<Func<string>> bodytoPersonId = null)
        {
            var apiCallPath = "/v1/messages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfiles != null)
            {
                body["files"] = ExpressionConverter.ConvertO(bodyfiles);
                bodypropCount++;
            }

            if (bodymarkdown != null)
            {
                body["markdown"] = ExpressionConverter.ConvertO(bodymarkdown);
                bodypropCount++;
            }

            if (bodyroomId != null)
            {
                body["roomId"] = ExpressionConverter.ConvertO(bodyroomId);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodytoPersonEmail != null)
            {
                body["toPersonEmail"] = ExpressionConverter.ConvertO(bodytoPersonEmail);
                bodypropCount++;
            }

            if (bodytoPersonId != null)
            {
                body["toPersonId"] = ExpressionConverter.ConvertO(bodytoPersonId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessageDetailsResponse> GetMessageDetails(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/v1/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMessageDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetPeopleResponse> GetPeople(Expression<Func<string>> id = null, Expression<Func<string>> email = null)
        {
            var apiCallPath = "/v1/people";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            return new ApiConnectionAction<GetPeopleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMyOwnDetailsResponse> GetMyOwnDetails()
        {
            var apiCallPath = "/v1/people/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMyOwnDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetSpacesResponse> GetSpaces(Expression<Func<int>> max = null, Expression<Func<typeInput>> type = null, Expression<Func<sortByInput>> sortBy = null)
        {
            var apiCallPath = "/v1/rooms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Queries["sortBy"] = Convert.ToString("lastactivity");
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            return new ApiConnectionAction<GetSpacesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateSpaceResponse> CreateSpace(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyteamId = null)
        {
            var apiCallPath = "/v1/rooms";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyteamId != null)
            {
                body["teamId"] = ExpressionConverter.ConvertO(bodyteamId);
                bodypropCount++;
            }

            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateSpaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetSpaceDetailResponse> GetSpaceDetail(Expression<Func<string>> roomId)
        {
            var apiCallPath = String.Format("/v1/rooms/{0}", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSpaceDetailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateTeamMemberResponse> CreateTeamMember(Expression<Func<bool>> bodyisModerator, Expression<Func<string>> bodyteamId, Expression<Func<string>> bodypersonEmail = null, Expression<Func<string>> bodypersonId = null)
        {
            var apiCallPath = "/v1/team/memberships";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["isModerator"] = ExpressionConverter.ConvertO(bodyisModerator);
            if (bodypersonEmail != null)
            {
                body["personEmail"] = ExpressionConverter.ConvertO(bodypersonEmail);
                bodypropCount++;
            }

            if (bodypersonId != null)
            {
                body["personId"] = ExpressionConverter.ConvertO(bodypersonId);
                bodypropCount++;
            }

            bodypropCount++;
            body["teamId"] = ExpressionConverter.ConvertO(bodyteamId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTeamMemberResponse>(callPayload);
        }
    }

    public class WebexTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MembershipsUpdatedResponse> MembershipsUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<MembershipsUpdatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MembershipsDeletedResponse> MembershipsDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<MembershipsDeletedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MembershipsCreatedResponse> MembershipsCreated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<MembershipsCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MessagesCreatedResponse> MessagesCreated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<MessagesCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MessagesDeletedResponse> MessagesDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<MessagesDeletedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SpaceCreatedResponse> SpaceCreated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<SpaceCreatedResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<SpaceUpdatedResponse> SpaceUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<SpaceUpdatedResponse>(callPayload, triggerName, recurrence);
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