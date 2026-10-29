//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airmeet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirmeetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<GetAirmeetsResponse, ApiConnectionActionConfiguration> GetAirmeets()
        {
            return new DeferredBodyAction<GetAirmeetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/airmeets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["allAirmeets"] = Convert.ToString(true);
                callPayload.Queries["crmName"] = Convert.ToString("MICROSOFT_DYNAMICS");
                return new ApiConnectionAction<GetAirmeetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateAirmeetResponse, ApiConnectionActionConfiguration> CreateAirmeet(Expression<Func<CreateAirmeetInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateAirmeetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/airmeet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAirmeetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSpeakerResponse, ApiConnectionActionConfiguration> CreateSpeaker(Expression<Func<string>> airmeetId, Expression<Func<CreateSpeakerInput>> body = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateSpeakerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/speaker", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSpeakerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetSessionsResponse, ApiConnectionActionConfiguration> AirmeetSessions(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<AirmeetSessionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/info", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AirmeetSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<StartAndEndAirmeetResponse, ApiConnectionActionConfiguration> StartAndEndAirmeet(Expression<Func<string>> airmeetId, Expression<Func<StartAndEndAirmeetInput>> body)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StartAndEndAirmeetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/status", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartAndEndAirmeetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetRegistrationsResponse, ApiConnectionActionConfiguration> AirmeetRegistrations(Expression<Func<string>> airmeetId, Expression<Func<int>> size, Expression<Func<int>> after = null, Expression<Func<int>> before = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<AirmeetRegistrationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/registrations", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<AirmeetRegistrationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetParticipantsResponse, ApiConnectionActionConfiguration> AirmeetParticipants(Expression<Func<string>> airmeetId, Expression<Func<int>> resultSize = null, Expression<Func<int>> pageNumber = null, Expression<Func<sortingKeyInput>> sortingKey = null, Expression<Func<sortingDirectionInput>> sortingDirection = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_resultSize = WorkflowExpression.Compile(resultSize, nameof(resultSize), required: false);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: false);
            var __workflow_sortingKey = WorkflowExpression.Compile(sortingKey, nameof(sortingKey), required: false);
            var __workflow_sortingDirection = WorkflowExpression.Compile(sortingDirection, nameof(sortingDirection), required: false);
            return new DeferredBodyAction<AirmeetParticipantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/participants", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_resultSize != null)
                    callPayload.Queries["resultSize"] = ExpressionConverter.Convert(__workflow_resultSize);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(__workflow_pageNumber);
                callPayload.Queries["sortingKey"] = Convert.ToString("registrationDate");
                if (__workflow_sortingKey != null)
                    callPayload.Queries["sortingKey"] = ExpressionConverter.Convert(__workflow_sortingKey);
                if (__workflow_sortingDirection != null)
                    callPayload.Queries["sortingDirection"] = ExpressionConverter.Convert(__workflow_sortingDirection);
                return new ApiConnectionAction<AirmeetParticipantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CustomRegistrationFieldsResponse, ApiConnectionActionConfiguration> CustomRegistrationFields(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<CustomRegistrationFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/custom-fields", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomRegistrationFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<RemoveAttendeeResponse, ApiConnectionActionConfiguration> RemoveAttendee(Expression<Func<string>> airmeetId, Expression<Func<string>> urlEncodedAttendeeEmail)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_urlEncodedAttendeeEmail = WorkflowExpression.Compile(urlEncodedAttendeeEmail, nameof(urlEncodedAttendeeEmail), required: true);
            return new DeferredBodyAction<RemoveAttendeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/attendee/{1}", __workflow_airmeetId.WithUrlEncoding(1), __workflow_urlEncodedAttendeeEmail.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RemoveAttendeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchEventTracksResponse, ApiConnectionActionConfiguration> FetchEventTracks(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<FetchEventTracksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/tracks", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FetchEventTracksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchAirmeetBoothsResponse, ApiConnectionActionConfiguration> FetchAirmeetBooths(Expression<Func<string>> airmeetId)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            return new DeferredBodyAction<FetchAirmeetBoothsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/booths", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FetchAirmeetBoothsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateBoothResponse, ApiConnectionActionConfiguration> CreateBooth(Expression<Func<string>> airmeetId, Expression<Func<CreateBoothInput>> body = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateBoothResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/booths", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateBoothResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AddAuthorizedAttendeeResponse, ApiConnectionActionConfiguration> AddAuthorizedAttendee(Expression<Func<string>> airmeetId, Expression<Func<AddAuthorizedAttendeeInput>> body = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddAuthorizedAttendeeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/attendee", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddAuthorizedAttendeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSessionResponse, ApiConnectionActionConfiguration> CreateSession(Expression<Func<string>> airmeetId, Expression<Func<CreateSessionInput>> body = null)
        {
            var __workflow_airmeetId = WorkflowExpression.Compile(airmeetId, nameof(airmeetId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/airmeet/{0}/session", __workflow_airmeetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSessionResponse>(callPayload);
            });
        }
    }

    public class AirmeetTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAirmeetsResponse
    {
        [JsonProperty("data")]
        public GetAirmeetsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("cursors")]
        public GetAirmeetsResponseCursorsType Cursors { get; set; }
    }

    public class GetAirmeetsResponseDataTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }
    }

    public class GetAirmeetsResponseCursorsType
    {
        [JsonProperty("after")]
        public int After { get; set; }

        [JsonProperty("before")]
        public int Before { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }
    }

    public class CreateAirmeetResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateAirmeetInput
    {
        [JsonProperty("hostEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HostEmail { get; set; }

        [JsonProperty("eventName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventName { get; set; }

        [JsonProperty("shortDesc", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShortDesc { get; set; }

        [JsonProperty("eventImage")]
        public string EventImage { get; set; }

        [JsonProperty("longDesc")]
        public string LongDesc { get; set; }

        [JsonProperty("access", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAirmeetInputAccessType? Access { get; set; } = CreateAirmeetInputAccessType.INVITEDONLY;

        [JsonProperty("eventType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EventType { get; set; } = "MEETUP";

        [JsonProperty("timing", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAirmeetInputTimingType Timing { get; set; }

        [JsonProperty("config")]
        public CreateAirmeetInputConfigType Config { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAirmeetInputAccessType
    {
        [EnumMember(Value = "INVITED_ONLY")]
        INVITEDONLY,
        [EnumMember(Value = "WITH_VERIFIED_EMAIL")]
        WITHVERIFIEDEMAIL,
        [EnumMember(Value = "WITHOUT_VERIFIED_EMAIL")]
        WITHOUTVERIFIEDEMAIL
    }

    public class CreateAirmeetInputTimingType
    {
        [JsonProperty("startTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartTime { get; set; }

        [JsonProperty("endTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndTime { get; set; }

        [JsonProperty("timezone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Timezone { get; set; } = "Asia/Kolkata";
    }

    public class CreateAirmeetInputConfigType
    {
        [JsonProperty("networking", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Networking { get; set; } = true;

        [JsonProperty("tableCount", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TableCount { get; set; } = 12;
    }

    public class CreateSpeakerResponse
    {
        [JsonProperty("speakerEmail")]
        public string SpeakerEmail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateSpeakerInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class AirmeetSessionsResponse
    {
        [JsonProperty("sessions")]
        public AirmeetSessionsResponseSessionsTypeItem[] Sessions { get; set; }
    }

    public class AirmeetSessionsResponseSessionsTypeItem
    {
        [JsonProperty("sessionid")]
        public string Sessionid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("host_id")]
        public string[] HostId { get; set; }

        [JsonProperty("cohost_ids")]
        public JToken[] CohostIds { get; set; }

        [JsonProperty("speaker_id")]
        public JToken[] SpeakerId { get; set; }

        [JsonProperty("speakerList")]
        public JToken[] SpeakerList { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class StartAndEndAirmeetResponse
    {
        [JsonProperty("statusUpdated")]
        public bool StatusUpdated { get; set; }
    }

    public class StartAndEndAirmeetInput
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public StartAndEndAirmeetInputStatusType Status { get; set; } = StartAndEndAirmeetInputStatusType.ONGOING;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartAndEndAirmeetInputStatusType
    {
        ONGOING,
        FINISHED
    }

    public class AirmeetRegistrationsResponse
    {
        [JsonProperty("data")]
        public AirmeetRegistrationsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("cursors")]
        public AirmeetRegistrationsResponseCursorsType Cursors { get; set; }
    }

    public class AirmeetRegistrationsResponseDataTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }
        public string Designation { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }
    }

    public class AirmeetRegistrationsResponseCursorsType
    {
        [JsonProperty("before")]
        public int Before { get; set; }

        [JsonProperty("after")]
        public int After { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }
    }

    public class AirmeetParticipantsResponse
    {
        [JsonProperty("paticipants")]
        public AirmeetParticipantsResponsePaticipantsTypeItem[] Paticipants { get; set; }

        [JsonProperty("userCount")]
        public int UserCount { get; set; }

        [JsonProperty("totalUserCount")]
        public int TotalUserCount { get; set; }
    }

    public class AirmeetParticipantsResponsePaticipantsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }
        public string Designation { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("invite_sent")]
        public bool InviteSent { get; set; }

        [JsonProperty("user_profile")]
        public AirmeetParticipantsResponsePaticipantsTypeItemUserProfileTypeItem[] UserProfile { get; set; }
    }

    public class AirmeetParticipantsResponsePaticipantsTypeItemUserProfileTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortingKeyInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "registrationDate")]
        RegistrationDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortingDirectionInput
    {
        ASC,
        DESC
    }

    public class CustomRegistrationFieldsResponse
    {
        [JsonProperty("customFields")]
        public CustomRegistrationFieldsResponseCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class CustomRegistrationFieldsResponseCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("options")]
        public CustomRegistrationFieldsResponseCustomFieldsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("type")]
        public CustomRegistrationFieldsResponseCustomFieldsTypeItemTypeType Type { get; set; }
    }

    public class CustomRegistrationFieldsResponseCustomFieldsTypeItemOptionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }

    public class CustomRegistrationFieldsResponseCustomFieldsTypeItemTypeType
    {
        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("inputType")]
        public string InputType { get; set; }

        [JsonProperty("mappedFrom")]
        public string MappedFrom { get; set; }
    }

    public class RemoveAttendeeResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class FetchEventTracksResponse
    {
        [JsonProperty("tracks")]
        public FetchEventTracksResponseTracksTypeItem[] Tracks { get; set; }
    }

    public class FetchEventTracksResponseTracksTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("track_order")]
        public string TrackOrder { get; set; }

        [JsonProperty("metaData")]
        public FetchEventTracksResponseTracksTypeItemMetaDataType MetaData { get; set; }

        [JsonProperty("sessions")]
        public string[] Sessions { get; set; }
    }

    public class FetchEventTracksResponseTracksTypeItemMetaDataType
    {
        [JsonProperty("colorCode")]
        public string ColorCode { get; set; }
    }

    public class FetchAirmeetBoothsResponse
    {
        [JsonProperty("booths")]
        public FetchAirmeetBoothsResponseBoothsTypeItem[] Booths { get; set; }
    }

    public class FetchAirmeetBoothsResponseBoothsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("exhibitors")]
        public string[] Exhibitors { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("airmeet_id")]
        public string AirmeetId { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("faqs")]
        public string Faqs { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("resources")]
        public string Resources { get; set; }

        [JsonProperty("layoutType")]
        public string LayoutType { get; set; }

        [JsonProperty("layoutData")]
        public string LayoutData { get; set; }

        [JsonProperty("boothExhibitor")]
        public bool BoothExhibitor { get; set; }

        [JsonProperty("social_media_links")]
        public string SocialMediaLinks { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("long_description")]
        public string LongDescription { get; set; }

        [JsonProperty("banner_url")]
        public string BannerUrl { get; set; }

        [JsonProperty("register_interest_details")]
        public string RegisterInterestDetails { get; set; }

        [JsonProperty("offer_details")]
        public string OfferDetails { get; set; }

        [JsonProperty("doc_url")]
        public string DocUrl { get; set; }

        [JsonProperty("doc_name")]
        public string DocName { get; set; }

        [JsonProperty("booth_space_id")]
        public string BoothSpaceId { get; set; }
    }

    public class CreateBoothResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class CreateBoothInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("exhibitorInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateBoothInputExhibitorInfoTypeItem[] ExhibitorInfo { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("metaData", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateBoothInputMetaDataType MetaData { get; set; }
    }

    public class CreateBoothInputExhibitorInfoTypeItem
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("exhibitorAttendanceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateBoothInputExhibitorInfoTypeItemExhibitorAttendanceTypeType? ExhibitorAttendanceType { get; set; } = CreateBoothInputExhibitorInfoTypeItemExhibitorAttendanceTypeType.HYBRId;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateBoothInputExhibitorInfoTypeItemExhibitorAttendanceTypeType
    {
        [EnumMember(Value = "HYBRID")]
        HYBRId,
        ONLINE
    }

    public class CreateBoothInputMetaDataType
    {
        [JsonProperty("chatEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ChatEnabled { get; set; } = false;

        [JsonProperty("loungeEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool LoungeEnabled { get; set; } = false;

        [JsonProperty("broadcastEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool BroadcastEnabled { get; set; } = false;

        [JsonProperty("tableCount", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TableCount { get; set; } = 6;
    }

    public class AddAuthorizedAttendeeResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("entryLink")]
        public string EntryLink { get; set; }
    }

    public class AddAuthorizedAttendeeInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("attendance_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAuthorizedAttendeeInputAttendanceTypeType? AttendanceType { get; set; } = AddAuthorizedAttendeeInputAttendanceTypeType.INPERSON;

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("registerAttendee", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RegisterAttendee { get; set; } = false;

        [JsonProperty("sendEmailInvite", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SendEmailInvite { get; set; } = false;

        [JsonProperty("customFieldMapping")]
        public AddAuthorizedAttendeeInputCustomFieldMappingTypeItem[] CustomFieldMapping { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddAuthorizedAttendeeInputAttendanceTypeType
    {
        VIRTUAL,
        [EnumMember(Value = "IN-PERSON")]
        INPERSON
    }

    public class AddAuthorizedAttendeeInputCustomFieldMappingTypeItem
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("value")]
        public string[] Value { get; set; }
    }

    public class CreateSessionResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class CreateSessionInput
    {
        [JsonProperty("sessionTitle")]
        public string SessionTitle { get; set; }

        [JsonProperty("sessionStartTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SessionStartTime { get; set; }

        [JsonProperty("sessionDuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SessionDuration { get; set; } = 30;

        [JsonProperty("sessionSummary")]
        public string SessionSummary { get; set; }

        [JsonProperty("hostEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HostEmail { get; set; }

        [JsonProperty("speakerEmails")]
        public string[] SpeakerEmails { get; set; }

        [JsonProperty("cohostEmails")]
        public string[] CohostEmails { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSessionInputTypeType? Type { get; set; } = CreateSessionInputTypeType.HOSTING;

        [JsonProperty("tracks")]
        public string[] Tracks { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("boothId")]
        public string BoothId { get; set; }

        [JsonProperty("speedNetworkingData")]
        public CreateSessionInputSpeedNetworkingDataType SpeedNetworkingData { get; set; }

        [JsonProperty("sessionMeta")]
        public CreateSessionInputSessionMetaType SessionMeta { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSessionInputTypeType
    {
        HOSTING,
        [EnumMember(Value = "FLUID_LOUNGE")]
        FLUIdLOUNGE,
        BOOTH,
        BREAK,
        [EnumMember(Value = "LARGE_CALL")]
        LARGECALL,
        [EnumMember(Value = "SPEED_NETWORKING")]
        SPEEDNETWORKING,
        STREAMING
    }

    public class CreateSessionInputSpeedNetworkingDataType
    {
        [JsonProperty("conversationTime")]
        public int? ConversationTime { get; set; }

        [JsonProperty("extendNetworkingTime")]
        public int? ExtendNetworkingTime { get; set; }
    }

    public class CreateSessionInputSessionMetaType
    {
        [JsonProperty("hideHost")]
        public bool? HideHost { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Airmeet;

    public partial class WorkflowManagedActions
    {
        public AirmeetActions Airmeet(string connectionId) => new AirmeetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AirmeetTriggers Airmeet(string connectionId) => new AirmeetTriggers(connectionId);
    }
}