//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webex
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class WebexActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateSpaceMemberResponse> CreateSpaceMember(Expression<Func<bool>> bodyisModerator, Expression<Func<string>> bodyroomId, Expression<Func<string>> bodypersonEmail = null, Expression<Func<string>> bodypersonId = null)
        {
            var __workflow_bodyisModerator = bodyisModerator == null ? null : WorkflowExpression.Compile(bodyisModerator);
            WorkflowExpression.Validate(__workflow_bodyisModerator, nameof(bodyisModerator), required: true);
            var __workflow_bodyroomId = bodyroomId == null ? null : WorkflowExpression.Compile(bodyroomId);
            WorkflowExpression.Validate(__workflow_bodyroomId, nameof(bodyroomId), required: true);
            var __workflow_bodypersonEmail = bodypersonEmail == null ? null : WorkflowExpression.Compile(bodypersonEmail);
            WorkflowExpression.Validate(__workflow_bodypersonEmail, nameof(bodypersonEmail), required: false);
            var __workflow_bodypersonId = bodypersonId == null ? null : WorkflowExpression.Compile(bodypersonId);
            WorkflowExpression.Validate(__workflow_bodypersonId, nameof(bodypersonId), required: false);
            return new DeferredBodyAction<CreateSpaceMemberResponse>(() =>
            {
                var apiCallPath = "/v1/memberships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isModerator"] = ExpressionConverter.ConvertO(__workflow_bodyisModerator);
                if (__workflow_bodypersonEmail != null)
                {
                    body["personEmail"] = ExpressionConverter.ConvertO(__workflow_bodypersonEmail);
                    bodypropCount++;
                }

                if (__workflow_bodypersonId != null)
                {
                    body["personId"] = ExpressionConverter.ConvertO(__workflow_bodypersonId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["roomId"] = ExpressionConverter.ConvertO(__workflow_bodyroomId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSpaceMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessagesResponse> GetMessages(Expression<Func<string>> roomId, Expression<Func<string>> mentionedPeople = null, Expression<Func<string>> beforeMessage = null, Expression<Func<string>> before = null, Expression<Func<int>> max = null)
        {
            var __workflow_roomId = roomId == null ? null : WorkflowExpression.Compile(roomId);
            WorkflowExpression.Validate(__workflow_roomId, nameof(roomId), required: true);
            var __workflow_mentionedPeople = mentionedPeople == null ? null : WorkflowExpression.Compile(mentionedPeople);
            WorkflowExpression.Validate(__workflow_mentionedPeople, nameof(mentionedPeople), required: false);
            var __workflow_beforeMessage = beforeMessage == null ? null : WorkflowExpression.Compile(beforeMessage);
            WorkflowExpression.Validate(__workflow_beforeMessage, nameof(beforeMessage), required: false);
            var __workflow_before = before == null ? null : WorkflowExpression.Compile(before);
            WorkflowExpression.Validate(__workflow_before, nameof(before), required: false);
            var __workflow_max = max == null ? null : WorkflowExpression.Compile(max);
            WorkflowExpression.Validate(__workflow_max, nameof(max), required: false);
            return new DeferredBodyAction<GetMessagesResponse>(() =>
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
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string[]>> bodyfiles = null, Expression<Func<string>> bodymarkdown = null, Expression<Func<string>> bodyroomId = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodytoPersonEmail = null, Expression<Func<string>> bodytoPersonId = null)
        {
            var __workflow_bodyfiles = bodyfiles == null ? null : WorkflowExpression.Compile(bodyfiles);
            WorkflowExpression.Validate(__workflow_bodyfiles, nameof(bodyfiles), required: false);
            var __workflow_bodymarkdown = bodymarkdown == null ? null : WorkflowExpression.Compile(bodymarkdown);
            WorkflowExpression.Validate(__workflow_bodymarkdown, nameof(bodymarkdown), required: false);
            var __workflow_bodyroomId = bodyroomId == null ? null : WorkflowExpression.Compile(bodyroomId);
            WorkflowExpression.Validate(__workflow_bodyroomId, nameof(bodyroomId), required: false);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: false);
            var __workflow_bodytoPersonEmail = bodytoPersonEmail == null ? null : WorkflowExpression.Compile(bodytoPersonEmail);
            WorkflowExpression.Validate(__workflow_bodytoPersonEmail, nameof(bodytoPersonEmail), required: false);
            var __workflow_bodytoPersonId = bodytoPersonId == null ? null : WorkflowExpression.Compile(bodytoPersonId);
            WorkflowExpression.Validate(__workflow_bodytoPersonId, nameof(bodytoPersonId), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfiles != null)
                {
                    body["files"] = ExpressionConverter.ConvertO(__workflow_bodyfiles);
                    bodypropCount++;
                }

                if (__workflow_bodymarkdown != null)
                {
                    body["markdown"] = ExpressionConverter.ConvertO(__workflow_bodymarkdown);
                    bodypropCount++;
                }

                if (__workflow_bodyroomId != null)
                {
                    body["roomId"] = ExpressionConverter.ConvertO(__workflow_bodyroomId);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodytoPersonEmail != null)
                {
                    body["toPersonEmail"] = ExpressionConverter.ConvertO(__workflow_bodytoPersonEmail);
                    bodypropCount++;
                }

                if (__workflow_bodytoPersonId != null)
                {
                    body["toPersonId"] = ExpressionConverter.ConvertO(__workflow_bodytoPersonId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetMessageDetailsResponse> GetMessageDetails(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<GetMessageDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMessageDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetPeopleResponse> GetPeople(Expression<Func<string>> id = null, Expression<Func<string>> email = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            return new DeferredBodyAction<GetPeopleResponse>(() =>
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
            var __workflow_max = max == null ? null : WorkflowExpression.Compile(max);
            WorkflowExpression.Validate(__workflow_max, nameof(max), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_sortBy = sortBy == null ? null : WorkflowExpression.Compile(sortBy);
            WorkflowExpression.Validate(__workflow_sortBy, nameof(sortBy), required: false);
            return new DeferredBodyAction<GetSpacesResponse>(() =>
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
        public IBodyWorkflowAction<CreateSpaceResponse> CreateSpace(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyteamId = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyteamId = bodyteamId == null ? null : WorkflowExpression.Compile(bodyteamId);
            WorkflowExpression.Validate(__workflow_bodyteamId, nameof(bodyteamId), required: false);
            return new DeferredBodyAction<CreateSpaceResponse>(() =>
            {
                var apiCallPath = "/v1/rooms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyteamId != null)
                {
                    body["teamId"] = ExpressionConverter.ConvertO(__workflow_bodyteamId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<GetSpaceDetailResponse> GetSpaceDetail(Expression<Func<string>> roomId)
        {
            var __workflow_roomId = roomId == null ? null : WorkflowExpression.Compile(roomId);
            WorkflowExpression.Validate(__workflow_roomId, nameof(roomId), required: true);
            return new DeferredBodyAction<GetSpaceDetailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/rooms/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpaceDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        public IBodyWorkflowAction<CreateTeamMemberResponse> CreateTeamMember(Expression<Func<bool>> bodyisModerator, Expression<Func<string>> bodyteamId, Expression<Func<string>> bodypersonEmail = null, Expression<Func<string>> bodypersonId = null)
        {
            var __workflow_bodyisModerator = bodyisModerator == null ? null : WorkflowExpression.Compile(bodyisModerator);
            WorkflowExpression.Validate(__workflow_bodyisModerator, nameof(bodyisModerator), required: true);
            var __workflow_bodyteamId = bodyteamId == null ? null : WorkflowExpression.Compile(bodyteamId);
            WorkflowExpression.Validate(__workflow_bodyteamId, nameof(bodyteamId), required: true);
            var __workflow_bodypersonEmail = bodypersonEmail == null ? null : WorkflowExpression.Compile(bodypersonEmail);
            WorkflowExpression.Validate(__workflow_bodypersonEmail, nameof(bodypersonEmail), required: false);
            var __workflow_bodypersonId = bodypersonId == null ? null : WorkflowExpression.Compile(bodypersonId);
            WorkflowExpression.Validate(__workflow_bodypersonId, nameof(bodypersonId), required: false);
            return new DeferredBodyAction<CreateTeamMemberResponse>(() =>
            {
                var apiCallPath = "/v1/team/memberships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isModerator"] = ExpressionConverter.ConvertO(__workflow_bodyisModerator);
                if (__workflow_bodypersonEmail != null)
                {
                    body["personEmail"] = ExpressionConverter.ConvertO(__workflow_bodypersonEmail);
                    bodypropCount++;
                }

                if (__workflow_bodypersonId != null)
                {
                    body["personId"] = ExpressionConverter.ConvertO(__workflow_bodypersonId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["teamId"] = ExpressionConverter.ConvertO(__workflow_bodyteamId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTeamMemberResponse>(callPayload);
            });
        }
    }

    public class WebexTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MembershipsUpdatedResponse> MembershipsUpdated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<MembershipsUpdatedResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<MembershipsDeletedResponse> MembershipsDeleted(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<MembershipsDeletedResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<MembershipsCreatedResponse> MembershipsCreated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<MembershipsCreatedResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<MessagesCreatedResponse> MessagesCreated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<MessagesCreatedResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<MessagesDeletedResponse> MessagesDeleted(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<MessagesDeletedResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<SpaceCreatedResponse> SpaceCreated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<SpaceCreatedResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<SpaceUpdatedResponse> SpaceUpdated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<SpaceUpdatedResponse>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "direct")]
        Direct
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
