//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webex
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebexActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSpaceMember))]
        public IBodyWorkflowAction<CreateSpaceMemberResponse> CreateSpaceMember([WorkflowExpression] Func<bool> bodyisModerator, [WorkflowExpression] Func<string> bodyroomId, [WorkflowExpression] Func<string> bodypersonEmail = null, [WorkflowExpression] Func<string> bodypersonId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSpaceMemberResponse> __BuildCreateSpaceMember(WorkflowExpression<bool> bodyisModerator, WorkflowExpression<string> bodyroomId, WorkflowExpression<string> bodypersonEmail = null, WorkflowExpression<string> bodypersonId = null)
        {
            WorkflowExpression.Validate(bodyisModerator, nameof(bodyisModerator), required: true);
            WorkflowExpression.Validate(bodyroomId, nameof(bodyroomId), required: true);
            WorkflowExpression.Validate(bodypersonEmail, nameof(bodypersonEmail), required: false);
            WorkflowExpression.Validate(bodypersonId, nameof(bodypersonId), required: false);
            return new DeferredBodyAction<CreateSpaceMemberResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessages))]
        public IBodyWorkflowAction<GetMessagesResponse> GetMessages([WorkflowExpression] Func<string> roomId, [WorkflowExpression] Func<string> mentionedPeople = null, [WorkflowExpression] Func<string> beforeMessage = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<int> max = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessagesResponse> __BuildGetMessages(WorkflowExpression<string> roomId, WorkflowExpression<string> mentionedPeople = null, WorkflowExpression<string> beforeMessage = null, WorkflowExpression<string> before = null, WorkflowExpression<int> max = null)
        {
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            WorkflowExpression.Validate(mentionedPeople, nameof(mentionedPeople), required: false);
            WorkflowExpression.Validate(beforeMessage, nameof(beforeMessage), required: false);
            WorkflowExpression.Validate(before, nameof(before), required: false);
            WorkflowExpression.Validate(max, nameof(max), required: false);
            return new DeferredBodyAction<GetMessagesResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string[]> bodyfiles = null, [WorkflowExpression] Func<string> bodymarkdown = null, [WorkflowExpression] Func<string> bodyroomId = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodytoPersonEmail = null, [WorkflowExpression] Func<string> bodytoPersonId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendMessage(WorkflowExpression<string[]> bodyfiles = null, WorkflowExpression<string> bodymarkdown = null, WorkflowExpression<string> bodyroomId = null, WorkflowExpression<string> bodytext = null, WorkflowExpression<string> bodytoPersonEmail = null, WorkflowExpression<string> bodytoPersonId = null)
        {
            WorkflowExpression.Validate(bodyfiles, nameof(bodyfiles), required: false);
            WorkflowExpression.Validate(bodymarkdown, nameof(bodymarkdown), required: false);
            WorkflowExpression.Validate(bodyroomId, nameof(bodyroomId), required: false);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodytoPersonEmail, nameof(bodytoPersonEmail), required: false);
            WorkflowExpression.Validate(bodytoPersonId, nameof(bodytoPersonId), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessageDetails))]
        public IBodyWorkflowAction<GetMessageDetailsResponse> GetMessageDetails([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMessageDetailsResponse> __BuildGetMessageDetails(WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<GetMessageDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMessageDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildGetPeople))]
        public IBodyWorkflowAction<GetPeopleResponse> GetPeople([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> email = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPeopleResponse> __BuildGetPeople(WorkflowExpression<string> id = null, WorkflowExpression<string> email = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            return new DeferredBodyAction<GetPeopleResponse>(() =>
            {
                var apiCallPath = "/v1/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSpaces))]
        public IBodyWorkflowAction<GetSpacesResponse> GetSpaces([WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<sortByInput> sortBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSpacesResponse> __BuildGetSpaces(WorkflowExpression<int> max = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<sortByInput> sortBy = null)
        {
            WorkflowExpression.Validate(max, nameof(max), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            return new DeferredBodyAction<GetSpacesResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSpace))]
        public IBodyWorkflowAction<CreateSpaceResponse> CreateSpace([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyteamId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSpaceResponse> __BuildCreateSpace(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodyteamId = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyteamId, nameof(bodyteamId), required: false);
            return new DeferredBodyAction<CreateSpaceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildGetSpaceDetail))]
        public IBodyWorkflowAction<GetSpaceDetailResponse> GetSpaceDetail([WorkflowExpression] Func<string> roomId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSpaceDetailResponse> __BuildGetSpaceDetail(WorkflowExpression<string> roomId)
        {
            WorkflowExpression.Validate(roomId, nameof(roomId), required: true);
            return new DeferredBodyAction<GetSpaceDetailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/rooms/{0}", ExpressionConverter.ConvertWithUrlEncoding(roomId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpaceDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTeamMember))]
        public IBodyWorkflowAction<CreateTeamMemberResponse> CreateTeamMember([WorkflowExpression] Func<bool> bodyisModerator, [WorkflowExpression] Func<string> bodyteamId, [WorkflowExpression] Func<string> bodypersonEmail = null, [WorkflowExpression] Func<string> bodypersonId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webex")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTeamMemberResponse> __BuildCreateTeamMember(WorkflowExpression<bool> bodyisModerator, WorkflowExpression<string> bodyteamId, WorkflowExpression<string> bodypersonEmail = null, WorkflowExpression<string> bodypersonId = null)
        {
            WorkflowExpression.Validate(bodyisModerator, nameof(bodyisModerator), required: true);
            WorkflowExpression.Validate(bodyteamId, nameof(bodyteamId), required: true);
            WorkflowExpression.Validate(bodypersonEmail, nameof(bodypersonEmail), required: false);
            WorkflowExpression.Validate(bodypersonId, nameof(bodypersonId), required: false);
            return new DeferredBodyAction<CreateTeamMemberResponse>(() =>
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
            });
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
            body["targetUrl"] = "#{listCallbackUrl()}";
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
            body["targetUrl"] = "#{listCallbackUrl()}";
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
            body["targetUrl"] = "#{listCallbackUrl()}";
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
            body["targetUrl"] = "#{listCallbackUrl()}";
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
            body["targetUrl"] = "#{listCallbackUrl()}";
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
            body["targetUrl"] = "#{listCallbackUrl()}";
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
            body["targetUrl"] = "#{listCallbackUrl()}";
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