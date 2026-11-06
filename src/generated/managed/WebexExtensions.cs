//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webex
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebexActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateSpaceMemberResponse, ApiConnectionActionConfiguration> CreateSpaceMember(Expression<Func<CreateSpaceMemberBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateSpaceMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/memberships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSpaceMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessagesResponse, ApiConnectionActionConfiguration> GetMessages(Expression<Func<string>> roomId, Expression<Func<string>> mentionedPeople = null, Expression<Func<string>> beforeMessage = null, Expression<Func<string>> before = null, Expression<Func<int>> max = null)
        {
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            var __workflow_mentionedPeople = WorkflowExpression.Compile(mentionedPeople, nameof(mentionedPeople), required: false);
            var __workflow_beforeMessage = WorkflowExpression.Compile(beforeMessage, nameof(beforeMessage), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            return new DeferredBodyAction<GetMessagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["roomId"] = ExpressionConverter.Convert(__workflow_roomId);
                if (__workflow_mentionedPeople != null)
                    callPayload.Queries["mentionedPeople"] = ExpressionConverter.Convert(__workflow_mentionedPeople);
                if (__workflow_beforeMessage != null)
                    callPayload.Queries["beforeMessage"] = ExpressionConverter.Convert(__workflow_beforeMessage);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                return new ApiConnectionAction<GetMessagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<SendMessageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessageDetailsResponse, ApiConnectionActionConfiguration> GetMessageDetails(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<GetMessageDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/messages/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMessageDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetPeopleResponse, ApiConnectionActionConfiguration> GetPeople(Expression<Func<string>> id = null, Expression<Func<string>> email = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            return new DeferredBodyAction<GetPeopleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<GetPeopleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMyOwnDetailsResponse, ApiConnectionActionConfiguration> GetMyOwnDetails()
        {
            return new DeferredBodyAction<GetMyOwnDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/people/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMyOwnDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetSpacesResponse, ApiConnectionActionConfiguration> GetSpaces(Expression<Func<int>> max = null, Expression<Func<TypeInput>> type = null, Expression<Func<SortByInput>> sortBy = null)
        {
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            return new DeferredBodyAction<GetSpacesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/rooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["sortBy"] = Convert.ToString("lastactivity");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                return new ApiConnectionAction<GetSpacesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateSpaceResponse, ApiConnectionActionConfiguration> CreateSpace(Expression<Func<CreateSpaceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateSpaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/rooms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetSpaceDetailResponse, ApiConnectionActionConfiguration> GetSpaceDetail(Expression<Func<string>> roomId)
        {
            var __workflow_roomId = WorkflowExpression.Compile(roomId, nameof(roomId), required: true);
            return new DeferredBodyAction<GetSpaceDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/rooms/{0}", __workflow_roomId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpaceDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateTeamMemberResponse, ApiConnectionActionConfiguration> CreateTeamMember(Expression<Func<CreateTeamMemberBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateTeamMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/team/memberships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTeamMemberResponse>(callPayload);
            });
        }
    }

    public class WebexTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MembershipsUpdatedResponse, ApiConnectionPollingTriggerConfiguration> MembershipsUpdated()
        {
            return new DeferredBodyTrigger<MembershipsUpdatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new MembershipsUpdatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<MembershipsUpdatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<MembershipsDeletedResponse, ApiConnectionPollingTriggerConfiguration> MembershipsDeleted()
        {
            return new DeferredBodyTrigger<MembershipsDeletedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new MembershipsDeletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<MembershipsDeletedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<MembershipsCreatedResponse, ApiConnectionPollingTriggerConfiguration> MembershipsCreated()
        {
            return new DeferredBodyTrigger<MembershipsCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new MembershipsCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<MembershipsCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<MessagesCreatedResponse, ApiConnectionPollingTriggerConfiguration> MessagesCreated()
        {
            return new DeferredBodyTrigger<MessagesCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/4";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new MessagesCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<MessagesCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<MessagesDeletedResponse, ApiConnectionPollingTriggerConfiguration> MessagesDeleted()
        {
            return new DeferredBodyTrigger<MessagesDeletedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/5";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new MessagesDeletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<MessagesDeletedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<SpaceCreatedResponse, ApiConnectionPollingTriggerConfiguration> SpaceCreated()
        {
            return new DeferredBodyTrigger<SpaceCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/6";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new SpaceCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<SpaceCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<SpaceUpdatedResponse, ApiConnectionPollingTriggerConfiguration> SpaceUpdated()
        {
            return new DeferredBodyTrigger<SpaceUpdatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/webhooks/7";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new SpaceUpdatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<SpaceUpdatedResponse>(callPayload);
            });
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

    public class CreateSpaceMemberBodyInput
    {
        [JsonProperty("isModerator", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsModerator { get; set; } = false;

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("roomId", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class SendMessageBodyInput
    {
        [JsonProperty("files")]
        public string[] Files { get; set; }

        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("toPersonEmail")]
        public string ToPersonEmail { get; set; }

        [JsonProperty("toPersonId")]
        public string ToPersonId { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TypeInput
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "direct")]
        Direct
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SortByInput
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

    public class CreateSpaceBodyInput
    {
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
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

    public class CreateTeamMemberBodyInput
    {
        [JsonProperty("isModerator", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsModerator { get; set; } = false;

        [JsonProperty("personEmail")]
        public string PersonEmail { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("teamId", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class MembershipsUpdatedBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "updated";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "MembershipUpdated";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "memberships";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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

    public class MembershipsDeletedBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "deleted";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "MembershipDeleted";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "memberships";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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

    public class MembershipsCreatedBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "created";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "MembershipCreated";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "memberships";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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

    public class MessagesCreatedBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "created";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "MessageCreated";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "messages";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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

    public class MessagesDeletedBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "deleted";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "MessageDeleted";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "messages";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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

    public class SpaceCreatedBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "created";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "SpaceCreated";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "rooms";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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

    public class SpaceUpdatedBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "updated";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "SpaceUpdated";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "rooms";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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