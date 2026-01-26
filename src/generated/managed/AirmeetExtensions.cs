//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airmeet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirmeetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<GetAirmeetsResponse> GetAirmeets()
        {
            var apiCallPath = "/airmeets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["allAirmeets"] = Convert.ToString(true);
            callPayload.Queries["crmName"] = Convert.ToString("MICROSOFT_DYNAMICS");
            return new ApiConnectionAction<GetAirmeetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSpeakerResponse> CreateSpeaker(Expression<Func<string>> airmeetId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyorganisation = null, Expression<Func<string>> bodydesignation = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<string>> bodybio = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycountry = null)
        {
            var apiCallPath = String.Format("/airmeet/{0}/speaker", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodyorganisation != null)
            {
                body["organisation"] = ExpressionConverter.ConvertO(bodyorganisation);
                bodypropCount++;
            }

            if (bodydesignation != null)
            {
                body["designation"] = ExpressionConverter.ConvertO(bodydesignation);
                bodypropCount++;
            }

            if (bodyimageUrl != null)
            {
                body["imageUrl"] = ExpressionConverter.ConvertO(bodyimageUrl);
                bodypropCount++;
            }

            if (bodybio != null)
            {
                body["bio"] = ExpressionConverter.ConvertO(bodybio);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateSpeakerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetSessionsResponse> AirmeetSessions(Expression<Func<string>> airmeetId)
        {
            var apiCallPath = String.Format("/airmeet/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AirmeetSessionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<StartAndEndAirmeetResponse> StartAndEndAirmeet(Expression<Func<string>> airmeetId, Expression<Func<bodystatusInput>> bodystatus)
        {
            var apiCallPath = String.Format("/airmeet/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StartAndEndAirmeetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetRegistrationsResponse> AirmeetRegistrations(Expression<Func<string>> airmeetId, Expression<Func<int>> size, Expression<Func<int>> after = null, Expression<Func<int>> before = null)
        {
            var apiCallPath = String.Format("/airmeet/{0}/registrations", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<AirmeetRegistrationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AirmeetParticipantsResponse> AirmeetParticipants(Expression<Func<string>> airmeetId, Expression<Func<int>> resultSize = null, Expression<Func<int>> pageNumber = null, Expression<Func<sortingKeyInput>> sortingKey = null, Expression<Func<sortingDirectionInput>> sortingDirection = null)
        {
            var apiCallPath = String.Format("/airmeet/{0}/participants", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (resultSize != null)
                callPayload.Queries["resultSize"] = ExpressionConverter.Convert(resultSize);
            if (pageNumber != null)
                callPayload.Queries["pageNumber"] = ExpressionConverter.Convert(pageNumber);
            callPayload.Queries["sortingKey"] = Convert.ToString("registrationDate");
            if (sortingKey != null)
                callPayload.Queries["sortingKey"] = ExpressionConverter.Convert(sortingKey);
            if (sortingDirection != null)
                callPayload.Queries["sortingDirection"] = ExpressionConverter.Convert(sortingDirection);
            return new ApiConnectionAction<AirmeetParticipantsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CustomRegistrationFieldsResponse> CustomRegistrationFields(Expression<Func<string>> airmeetId)
        {
            var apiCallPath = String.Format("/airmeet/{0}/custom-fields", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CustomRegistrationFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<RemoveAttendeeResponse> RemoveAttendee(Expression<Func<string>> airmeetId, Expression<Func<string>> urlEncodedAttendeeEmail)
        {
            var apiCallPath = String.Format("/airmeet/{0}/attendee/{1}", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1), ExpressionConverter.ConvertWithUrlEncoding(urlEncodedAttendeeEmail, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RemoveAttendeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchEventTracksResponse> FetchEventTracks(Expression<Func<string>> airmeetId)
        {
            var apiCallPath = String.Format("/airmeet/{0}/tracks", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FetchEventTracksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<FetchAirmeetBoothsResponse> FetchAirmeetBooths(Expression<Func<string>> airmeetId)
        {
            var apiCallPath = String.Format("/airmeet/{0}/booths", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FetchAirmeetBoothsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<AddAuthorizedAttendeeResponse> AddAuthorizedAttendee(Expression<Func<string>> airmeetId, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<bool>> bodyregisterAttendee, Expression<Func<bool>> bodysendEmailInvite, Expression<Func<bodyattendanceTypeInput>> bodyattendanceType = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodydesignation = null, Expression<Func<string>> bodyorganisation = null, Expression<Func<bodycustomFieldMappingInputItem[]>> bodycustomFieldMapping = null)
        {
            var apiCallPath = String.Format("/airmeet/{0}/attendee", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
            bodypropCount++;
            body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
            if (bodyattendanceType != null)
            {
                body["attendance_type"] = ExpressionConverter.ConvertO(bodyattendanceType);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodydesignation != null)
            {
                body["designation"] = ExpressionConverter.ConvertO(bodydesignation);
                bodypropCount++;
            }

            if (bodyorganisation != null)
            {
                body["organisation"] = ExpressionConverter.ConvertO(bodyorganisation);
                bodypropCount++;
            }

            bodypropCount++;
            body["registerAttendee"] = ExpressionConverter.ConvertO(bodyregisterAttendee);
            bodypropCount++;
            body["sendEmailInvite"] = ExpressionConverter.ConvertO(bodysendEmailInvite);
            if (bodycustomFieldMapping != null)
            {
                body["customFieldMapping"] = ExpressionConverter.ConvertO(bodycustomFieldMapping);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddAuthorizedAttendeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airmeet")]
        public IBodyWorkflowAction<CreateSessionResponse> CreateSession(Expression<Func<string>> airmeetId, Expression<Func<int>> bodysessionStartTime, Expression<Func<string>> bodyhostEmail, Expression<Func<string>> bodysessionTitle = null, Expression<Func<int>> bodysessionDuration = null, Expression<Func<string>> bodysessionSummary = null, Expression<Func<string[]>> bodyspeakerEmails = null, Expression<Func<string[]>> bodycohostEmails = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string[]>> bodytracks = null, Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodyboothId = null, Expression<Func<int>> bodyspeedNetworkingDataconversationTime = null, Expression<Func<int>> bodyspeedNetworkingDataextendNetworkingTime = null, Expression<Func<bool>> bodysessionMetahideHost = null)
        {
            var apiCallPath = String.Format("/airmeet/{0}/session", ExpressionConverter.ConvertWithUrlEncoding(airmeetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysessionTitle != null)
            {
                body["sessionTitle"] = ExpressionConverter.ConvertO(bodysessionTitle);
                bodypropCount++;
            }

            bodypropCount++;
            body["sessionStartTime"] = ExpressionConverter.ConvertO(bodysessionStartTime);
            if (bodysessionDuration != null)
            {
                body["sessionDuration"] = ExpressionConverter.ConvertO(bodysessionDuration);
                bodypropCount++;
            }

            if (bodysessionSummary != null)
            {
                body["sessionSummary"] = ExpressionConverter.ConvertO(bodysessionSummary);
                bodypropCount++;
            }

            bodypropCount++;
            body["hostEmail"] = ExpressionConverter.ConvertO(bodyhostEmail);
            if (bodyspeakerEmails != null)
            {
                body["speakerEmails"] = ExpressionConverter.ConvertO(bodyspeakerEmails);
                bodypropCount++;
            }

            if (bodycohostEmails != null)
            {
                body["cohostEmails"] = ExpressionConverter.ConvertO(bodycohostEmails);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodytracks != null)
            {
                body["tracks"] = ExpressionConverter.ConvertO(bodytracks);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodyboothId != null)
            {
                body["boothId"] = ExpressionConverter.ConvertO(bodyboothId);
                bodypropCount++;
            }

            var speedNetworkingDataObject = new JObject();
            var speedNetworkingDataObjectpropCount = 0;
            if (bodyspeedNetworkingDataconversationTime != null)
            {
                speedNetworkingDataObject["conversationTime"] = ExpressionConverter.ConvertO(bodyspeedNetworkingDataconversationTime);
                speedNetworkingDataObjectpropCount++;
            }

            if (bodyspeedNetworkingDataextendNetworkingTime != null)
            {
                speedNetworkingDataObject["extendNetworkingTime"] = ExpressionConverter.ConvertO(bodyspeedNetworkingDataextendNetworkingTime);
                speedNetworkingDataObjectpropCount++;
            }

            if (speedNetworkingDataObjectpropCount > 0)
            {
                body["speedNetworkingData"] = speedNetworkingDataObject;
                bodypropCount++;
            }

            var sessionMetaObject = new JObject();
            var sessionMetaObjectpropCount = 0;
            if (bodysessionMetahideHost != null)
            {
                sessionMetaObject["hideHost"] = ExpressionConverter.ConvertO(bodysessionMetahideHost);
                sessionMetaObjectpropCount++;
            }

            if (sessionMetaObjectpropCount > 0)
            {
                body["sessionMeta"] = sessionMetaObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateSessionResponse>(callPayload);
        }
    }

    public class AirmeetTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AirmeetTriggersResponse> AirmeetTriggers(Expression<Func<bodytriggerMetaInfoIdInput>> bodytriggerMetaInfoId, Expression<Func<string>> airmeetId = null, Expression<Func<string>> sessionId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/platform-integration/v1/webhook-register";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (airmeetId != null)
                callPayload.Queries["airmeetId"] = ExpressionConverter.Convert(airmeetId);
            if (sessionId != null)
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["triggerMetaInfoId"] = ExpressionConverter.ConvertO(bodytriggerMetaInfoId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<AirmeetTriggersResponse>(callPayload, triggerName, recurrence);
        }
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

    public class CreateSpeakerResponse
    {
        [JsonProperty("speakerEmail")]
        public string SpeakerEmail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
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

    public enum bodystatusInput
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

    public enum sortingKeyInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "registrationDate")]
        RegistrationDate
    }

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

    public class AddAuthorizedAttendeeResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("entryLink")]
        public string EntryLink { get; set; }
    }

    public enum bodyattendanceTypeInput
    {
        VIRTUAL,
        [EnumMember(Value = "IN-PERSON")]
        INPERSON
    }

    public class bodycustomFieldMappingInputItem
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

    public enum bodytypeInput
    {
        HOSTING,
        [EnumMember(Value = "FLUID_LOUNGE")]
        FLUIDLOUNGE,
        BOOTH,
        BREAK,
        [EnumMember(Value = "LARGE_CALL")]
        LARGECALL,
        [EnumMember(Value = "SPEED_NETWORKING")]
        SPEEDNETWORKING,
        STREAMING
    }

    public class AirmeetTriggersResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("triggerMetaInfoId")]
        public string TriggerMetaInfoId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum bodytriggerMetaInfoIdInput
    {
        [EnumMember(Value = "trigger.airmeet.created")]
        TriggerAirmeetCreated,
        [EnumMember(Value = "trigger.airmeet.attendee.added")]
        TriggerAirmeetAttendeeAdded,
        [EnumMember(Value = "trigger.airmeet.started")]
        TriggerAirmeetStarted,
        [EnumMember(Value = "trigger.airmeet.finished")]
        TriggerAirmeetFinished,
        [EnumMember(Value = "trigger.airmeet.reminder")]
        TriggerAirmeetReminder,
        [EnumMember(Value = "trigger.airmeet.recording.available")]
        TriggerAirmeetRecordingAvailable,
        [EnumMember(Value = "trigger.airmeet.registrant.added")]
        TriggerAirmeetRegistrantAdded,
        [EnumMember(Value = "trigger.airmeet.attendee.joined")]
        TriggerAirmeetAttendeeJoined,
        [EnumMember(Value = "trigger.session.attendee.joined")]
        TriggerSessionAttendeeJoined,
        [EnumMember(Value = "trigger.airmeet.polls")]
        TriggerAirmeetPolls,
        [EnumMember(Value = "trigger.airmeet.questions")]
        TriggerAirmeetQuestions,
        [EnumMember(Value = "trigger.attendee.booth.joined")]
        TriggerAttendeeBoothJoined
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