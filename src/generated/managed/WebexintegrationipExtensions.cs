//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webexintegrationip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebexintegrationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<ReadMeetingResponse, ApiConnectionActionConfiguration> ReadMeetings(Expression<Func<string>> contentType = null, Expression<Func<string>> password = null, Expression<Func<string>> timezone = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: false);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            return new DeferredBodyAction<ReadMeetingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_password != null)
                    callPayload.Headers["password"] = ExpressionConverter.Convert(__workflow_password);
                if (__workflow_timezone != null)
                    callPayload.Headers["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                return new ApiConnectionAction<ReadMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<CreateAMeetingResponse, ApiConnectionActionConfiguration> CreateAMeeting(Expression<Func<string>> contentType, Expression<Func<CreateAMeetingInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAMeetingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateAInvitee(Expression<Func<string>> contentType = null, Expression<Func<CreateAInviteeInput>> body = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meetingInvitees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAMeeting(Expression<Func<string>> meetingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meetings/{0}", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAMeeting(Expression<Func<string>> meetingId, Expression<Func<string>> contentType = null, Expression<Func<UpdateAMeetingInput>> body = null)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meetings/{0}", __workflow_meetingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class WebexintegrationipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReadMeetingResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meetingNumber")]
        public string MeetingNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("agenda")]
        public string Agenda { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phoneAndVideoSystemPassword")]
        public string PhoneAndVideoSystemPassword { get; set; }

        [JsonProperty("meetingType")]
        public string MeetingType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }

        [JsonProperty("hostUserId")]
        public string HostUserId { get; set; }

        [JsonProperty("hostDisplayName")]
        public string HostDisplayName { get; set; }

        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        [JsonProperty("hostKey")]
        public string HostKey { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }

        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        [JsonProperty("sipAddress")]
        public string SipAddress { get; set; }

        [JsonProperty("dialInIpAddress")]
        public string DialInIpAddress { get; set; }

        [JsonProperty("enabledAutoRecordMeeting")]
        public bool EnabledAutoRecordMeeting { get; set; }

        [JsonProperty("allowAnyUserToBeCoHost")]
        public bool AllowAnyUserToBeCoHost { get; set; }

        [JsonProperty("enabledJoinBeforeHost")]
        public bool EnabledJoinBeforeHost { get; set; }

        [JsonProperty("enableConnectAudioBeforeHost")]
        public bool EnableConnectAudioBeforeHost { get; set; }

        [JsonProperty("joinBeforeHostMinutes")]
        public int JoinBeforeHostMinutes { get; set; }

        [JsonProperty("excludePassword")]
        public bool ExcludePassword { get; set; }

        [JsonProperty("publicMeeting")]
        public bool PublicMeeting { get; set; }

        [JsonProperty("reminderTime")]
        public int ReminderTime { get; set; }

        [JsonProperty("unlockedMeetingJoinSecurity")]
        public string UnlockedMeetingJoinSecurity { get; set; }

        [JsonProperty("sessionTypeId")]
        public int SessionTypeId { get; set; }

        [JsonProperty("enableAutomaticLock")]
        public bool EnableAutomaticLock { get; set; }

        [JsonProperty("automaticLockMinutes")]
        public int AutomaticLockMinutes { get; set; }

        [JsonProperty("allowFirstUserToBeCoHost")]
        public bool AllowFirstUserToBeCoHost { get; set; }

        [JsonProperty("allowAuthenticatedDevices")]
        public bool AllowAuthenticatedDevices { get; set; }

        [JsonProperty("telephony")]
        public ReadMeetingResponseTelephonyType Telephony { get; set; }

        [JsonProperty("meetingOptions")]
        public ReadMeetingResponseMeetingOptionsType MeetingOptions { get; set; }

        [JsonProperty("attendeePrivileges")]
        public ReadMeetingResponseAttendeePrivilegesType AttendeePrivileges { get; set; }

        [JsonProperty("registration")]
        public ReadMeetingResponseRegistrationType Registration { get; set; }

        [JsonProperty("integrationTags")]
        public string[] IntegrationTags { get; set; }

        [JsonProperty("scheduledType")]
        public string ScheduledType { get; set; }

        [JsonProperty("simultaneousInterpretation")]
        public ReadMeetingResponseSimultaneousInterpretationType SimultaneousInterpretation { get; set; }

        [JsonProperty("enabledBreakoutSessions")]
        public bool EnabledBreakoutSessions { get; set; }

        [JsonProperty("links")]
        public ReadMeetingResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("trackingCodes")]
        public ReadMeetingResponseTrackingCodesTypeItem[] TrackingCodes { get; set; }

        [JsonProperty("audioConnectionOptions")]
        public ReadMeetingResponseAudioConnectionOptionsType AudioConnectionOptions { get; set; }
    }

    public class ReadMeetingResponseTelephonyType
    {
        [JsonProperty("accessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("callInNumbers")]
        public ReadMeetingResponseTelephonyTypeCallInNumbersTypeItem[] CallInNumbers { get; set; }

        [JsonProperty("links")]
        public ReadMeetingResponseTelephonyTypeLinksTypeItem[] Links { get; set; }
    }

    public class ReadMeetingResponseTelephonyTypeCallInNumbersTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("callInNumber")]
        public string CallInNumber { get; set; }

        [JsonProperty("tollType")]
        public string TollType { get; set; }
    }

    public class ReadMeetingResponseTelephonyTypeLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class ReadMeetingResponseMeetingOptionsType
    {
        [JsonProperty("enabledChat")]
        public bool EnabledChat { get; set; }

        [JsonProperty("enabledVideo")]
        public bool EnabledVideo { get; set; }

        [JsonProperty("enabledPolling")]
        public bool EnabledPolling { get; set; }

        [JsonProperty("enabledNote")]
        public bool EnabledNote { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("enabledClosedCaptions")]
        public bool EnabledClosedCaptions { get; set; }

        [JsonProperty("enabledFileTransfer")]
        public bool EnabledFileTransfer { get; set; }

        [JsonProperty("enabledUCFRichMedia")]
        public bool EnabledUCFRichMedia { get; set; }
    }

    public class ReadMeetingResponseAttendeePrivilegesType
    {
        [JsonProperty("enabledShareContent")]
        public bool EnabledShareContent { get; set; }

        [JsonProperty("enabledSaveDocument")]
        public bool EnabledSaveDocument { get; set; }

        [JsonProperty("enabledPrintDocument")]
        public bool EnabledPrintDocument { get; set; }

        [JsonProperty("enabledAnnotate")]
        public bool EnabledAnnotate { get; set; }

        [JsonProperty("enabledViewParticipantList")]
        public bool EnabledViewParticipantList { get; set; }

        [JsonProperty("enabledViewThumbnails")]
        public bool EnabledViewThumbnails { get; set; }

        [JsonProperty("enabledRemoteControl")]
        public bool EnabledRemoteControl { get; set; }

        [JsonProperty("enabledViewAnyDocument")]
        public bool EnabledViewAnyDocument { get; set; }

        [JsonProperty("enabledViewAnyPage")]
        public bool EnabledViewAnyPage { get; set; }

        [JsonProperty("enabledContactOperatorPrivately")]
        public bool EnabledContactOperatorPrivately { get; set; }

        [JsonProperty("enabledChatHost")]
        public bool EnabledChatHost { get; set; }

        [JsonProperty("enabledChatPresenter")]
        public bool EnabledChatPresenter { get; set; }

        [JsonProperty("enabledChatOtherParticipants")]
        public bool EnabledChatOtherParticipants { get; set; }
    }

    public class ReadMeetingResponseRegistrationType
    {
        [JsonProperty("autoAcceptRequest")]
        public bool AutoAcceptRequest { get; set; }

        [JsonProperty("requireFirstName")]
        public bool RequireFirstName { get; set; }

        [JsonProperty("requireLastName")]
        public bool RequireLastName { get; set; }

        [JsonProperty("requireEmail")]
        public bool RequireEmail { get; set; }

        [JsonProperty("requireCompanyName")]
        public bool RequireCompanyName { get; set; }

        [JsonProperty("requireCountryRegion")]
        public bool RequireCountryRegion { get; set; }

        [JsonProperty("requireWorkPhone")]
        public bool RequireWorkPhone { get; set; }

        [JsonProperty("customizedQuestions")]
        public ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem[] CustomizedQuestions { get; set; }

        [JsonProperty("rules")]
        public ReadMeetingResponseRegistrationTypeRulesTypeItem[] Rules { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("rules")]
        public ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem[] Rules { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeRulesTypeItem
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class ReadMeetingResponseSimultaneousInterpretationType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("interpreters")]
        public ReadMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem[] Interpreters { get; set; }
    }

    public class ReadMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageCode1")]
        public string LanguageCode1 { get; set; }

        [JsonProperty("languageCode2")]
        public string LanguageCode2 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ReadMeetingResponseLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class ReadMeetingResponseTrackingCodesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReadMeetingResponseAudioConnectionOptionsType
    {
        [JsonProperty("audioConnectionType")]
        public string AudioConnectionType { get; set; }

        [JsonProperty("enabledTollFreeCallIn")]
        public bool EnabledTollFreeCallIn { get; set; }

        [JsonProperty("enabledGlobalCallIn")]
        public bool EnabledGlobalCallIn { get; set; }

        [JsonProperty("enabledAudienceCallBack")]
        public bool EnabledAudienceCallBack { get; set; }

        [JsonProperty("entryAndExitTone")]
        public string EntryAndExitTone { get; set; }

        [JsonProperty("allowHostToUnmuteParticipants")]
        public bool AllowHostToUnmuteParticipants { get; set; }

        [JsonProperty("allowAttendeeToUnmuteSelf")]
        public bool AllowAttendeeToUnmuteSelf { get; set; }

        [JsonProperty("muteAttendeeUponEntry")]
        public bool MuteAttendeeUponEntry { get; set; }
    }

    public class CreateAMeetingResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meetingNumber")]
        public string MeetingNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("agenda")]
        public string Agenda { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phoneAndVideoSystemPassword")]
        public string PhoneAndVideoSystemPassword { get; set; }

        [JsonProperty("meetingType")]
        public string MeetingType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }

        [JsonProperty("hostUserId")]
        public string HostUserId { get; set; }

        [JsonProperty("hostDisplayName")]
        public string HostDisplayName { get; set; }

        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        [JsonProperty("hostKey")]
        public string HostKey { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }

        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        [JsonProperty("sipAddress")]
        public string SipAddress { get; set; }

        [JsonProperty("dialInIpAddress")]
        public string DialInIpAddress { get; set; }

        [JsonProperty("enabledAutoRecordMeeting")]
        public bool EnabledAutoRecordMeeting { get; set; }

        [JsonProperty("allowAnyUserToBeCoHost")]
        public bool AllowAnyUserToBeCoHost { get; set; }

        [JsonProperty("enabledJoinBeforeHost")]
        public bool EnabledJoinBeforeHost { get; set; }

        [JsonProperty("enableConnectAudioBeforeHost")]
        public bool EnableConnectAudioBeforeHost { get; set; }

        [JsonProperty("joinBeforeHostMinutes")]
        public int JoinBeforeHostMinutes { get; set; }

        [JsonProperty("excludePassword")]
        public bool ExcludePassword { get; set; }

        [JsonProperty("publicMeeting")]
        public bool PublicMeeting { get; set; }

        [JsonProperty("reminderTime")]
        public int ReminderTime { get; set; }

        [JsonProperty("unlockedMeetingJoinSecurity")]
        public string UnlockedMeetingJoinSecurity { get; set; }

        [JsonProperty("sessionTypeId")]
        public int SessionTypeId { get; set; }

        [JsonProperty("enableAutomaticLock")]
        public bool EnableAutomaticLock { get; set; }

        [JsonProperty("automaticLockMinutes")]
        public int AutomaticLockMinutes { get; set; }

        [JsonProperty("allowFirstUserToBeCoHost")]
        public bool AllowFirstUserToBeCoHost { get; set; }

        [JsonProperty("allowAuthenticatedDevices")]
        public bool AllowAuthenticatedDevices { get; set; }

        [JsonProperty("telephony")]
        public CreateAMeetingResponseTelephonyType Telephony { get; set; }

        [JsonProperty("meetingOptions")]
        public CreateAMeetingResponseMeetingOptionsType MeetingOptions { get; set; }

        [JsonProperty("attendeePrivileges")]
        public CreateAMeetingResponseAttendeePrivilegesType AttendeePrivileges { get; set; }

        [JsonProperty("registration")]
        public CreateAMeetingResponseRegistrationType Registration { get; set; }

        [JsonProperty("integrationTags")]
        public string[] IntegrationTags { get; set; }

        [JsonProperty("scheduledType")]
        public string ScheduledType { get; set; }

        [JsonProperty("simultaneousInterpretation")]
        public CreateAMeetingResponseSimultaneousInterpretationType SimultaneousInterpretation { get; set; }

        [JsonProperty("enabledBreakoutSessions")]
        public bool EnabledBreakoutSessions { get; set; }

        [JsonProperty("links")]
        public CreateAMeetingResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("trackingCodes")]
        public CreateAMeetingResponseTrackingCodesTypeItem[] TrackingCodes { get; set; }

        [JsonProperty("audioConnectionOptions")]
        public CreateAMeetingResponseAudioConnectionOptionsType AudioConnectionOptions { get; set; }
    }

    public class CreateAMeetingResponseTelephonyType
    {
        [JsonProperty("accessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("callInNumbers")]
        public CreateAMeetingResponseTelephonyTypeCallInNumbersTypeItem[] CallInNumbers { get; set; }

        [JsonProperty("links")]
        public CreateAMeetingResponseTelephonyTypeLinksTypeItem[] Links { get; set; }
    }

    public class CreateAMeetingResponseTelephonyTypeCallInNumbersTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("callInNumber")]
        public string CallInNumber { get; set; }

        [JsonProperty("tollType")]
        public string TollType { get; set; }
    }

    public class CreateAMeetingResponseTelephonyTypeLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class CreateAMeetingResponseMeetingOptionsType
    {
        [JsonProperty("enabledChat")]
        public bool EnabledChat { get; set; }

        [JsonProperty("enabledVideo")]
        public bool EnabledVideo { get; set; }

        [JsonProperty("enabledPolling")]
        public bool EnabledPolling { get; set; }

        [JsonProperty("enabledNote")]
        public bool EnabledNote { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("enabledClosedCaptions")]
        public bool EnabledClosedCaptions { get; set; }

        [JsonProperty("enabledFileTransfer")]
        public bool EnabledFileTransfer { get; set; }

        [JsonProperty("enabledUCFRichMedia")]
        public bool EnabledUCFRichMedia { get; set; }
    }

    public class CreateAMeetingResponseAttendeePrivilegesType
    {
        [JsonProperty("enabledShareContent")]
        public bool EnabledShareContent { get; set; }

        [JsonProperty("enabledSaveDocument")]
        public bool EnabledSaveDocument { get; set; }

        [JsonProperty("enabledPrintDocument")]
        public bool EnabledPrintDocument { get; set; }

        [JsonProperty("enabledAnnotate")]
        public bool EnabledAnnotate { get; set; }

        [JsonProperty("enabledViewParticipantList")]
        public bool EnabledViewParticipantList { get; set; }

        [JsonProperty("enabledViewThumbnails")]
        public bool EnabledViewThumbnails { get; set; }

        [JsonProperty("enabledRemoteControl")]
        public bool EnabledRemoteControl { get; set; }

        [JsonProperty("enabledViewAnyDocument")]
        public bool EnabledViewAnyDocument { get; set; }

        [JsonProperty("enabledViewAnyPage")]
        public bool EnabledViewAnyPage { get; set; }

        [JsonProperty("enabledContactOperatorPrivately")]
        public bool EnabledContactOperatorPrivately { get; set; }

        [JsonProperty("enabledChatHost")]
        public bool EnabledChatHost { get; set; }

        [JsonProperty("enabledChatPresenter")]
        public bool EnabledChatPresenter { get; set; }

        [JsonProperty("enabledChatOtherParticipants")]
        public bool EnabledChatOtherParticipants { get; set; }
    }

    public class CreateAMeetingResponseRegistrationType
    {
        [JsonProperty("autoAcceptRequest")]
        public bool AutoAcceptRequest { get; set; }

        [JsonProperty("requireFirstName")]
        public bool RequireFirstName { get; set; }

        [JsonProperty("requireLastName")]
        public bool RequireLastName { get; set; }

        [JsonProperty("requireEmail")]
        public bool RequireEmail { get; set; }

        [JsonProperty("requireCompanyName")]
        public bool RequireCompanyName { get; set; }

        [JsonProperty("requireCountryRegion")]
        public bool RequireCountryRegion { get; set; }

        [JsonProperty("requireWorkPhone")]
        public bool RequireWorkPhone { get; set; }

        [JsonProperty("customizedQuestions")]
        public CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem[] CustomizedQuestions { get; set; }

        [JsonProperty("rules")]
        public CreateAMeetingResponseRegistrationTypeRulesTypeItem[] Rules { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("rules")]
        public CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem[] Rules { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeRulesTypeItem
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class CreateAMeetingResponseSimultaneousInterpretationType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("interpreters")]
        public CreateAMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem[] Interpreters { get; set; }
    }

    public class CreateAMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageCode1")]
        public string LanguageCode1 { get; set; }

        [JsonProperty("languageCode2")]
        public string LanguageCode2 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class CreateAMeetingResponseLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class CreateAMeetingResponseTrackingCodesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateAMeetingResponseAudioConnectionOptionsType
    {
        [JsonProperty("audioConnectionType")]
        public string AudioConnectionType { get; set; }

        [JsonProperty("enabledTollFreeCallIn")]
        public bool EnabledTollFreeCallIn { get; set; }

        [JsonProperty("enabledGlobalCallIn")]
        public bool EnabledGlobalCallIn { get; set; }

        [JsonProperty("enabledAudienceCallBack")]
        public bool EnabledAudienceCallBack { get; set; }

        [JsonProperty("entryAndExitTone")]
        public string EntryAndExitTone { get; set; }

        [JsonProperty("allowHostToUnmuteParticipants")]
        public bool AllowHostToUnmuteParticipants { get; set; }

        [JsonProperty("allowAttendeeToUnmuteSelf")]
        public bool AllowAttendeeToUnmuteSelf { get; set; }

        [JsonProperty("muteAttendeeUponEntry")]
        public bool MuteAttendeeUponEntry { get; set; }
    }

    public class CreateAMeetingInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("agenda")]
        public string Agenda { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Start { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public string End { get; set; }

        [JsonProperty("timezone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Timezone { get; set; } = "Europe/London";

        [JsonProperty("enabledAutoRecordMeeting", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnabledAutoRecordMeeting { get; set; } = false;

        [JsonProperty("allowAnyUserToBeCoHost", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowAnyUserToBeCoHost { get; set; } = false;
    }

    public class CreateAInviteeInput
    {
        [JsonProperty("meetingId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MeetingId { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("coHost")]
        public string CoHost { get; set; }

        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        [JsonProperty("sendEmail")]
        public string SendEmail { get; set; }

        [JsonProperty("panelist")]
        public string Panelist { get; set; }
    }

    public class UpdateAMeetingInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("agenda")]
        public string Agenda { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("enabledAutoRecordMeeting")]
        public bool? EnabledAutoRecordMeeting { get; set; }

        [JsonProperty("allowAnyUserToBeCoHost")]
        public bool? AllowAnyUserToBeCoHost { get; set; }

        [JsonProperty("enabledJoinBeforeHost")]
        public bool? EnabledJoinBeforeHost { get; set; }

        [JsonProperty("enableConnectAudioBeforeHost")]
        public bool? EnableConnectAudioBeforeHost { get; set; }

        [JsonProperty("joinBeforeHostMinutes")]
        public int? JoinBeforeHostMinutes { get; set; }

        [JsonProperty("excludePassword")]
        public bool? ExcludePassword { get; set; }

        [JsonProperty("publicMeeting")]
        public bool? PublicMeeting { get; set; }

        [JsonProperty("reminderTime")]
        public int? ReminderTime { get; set; }

        [JsonProperty("unlockedMeetingJoinSecurity")]
        public string UnlockedMeetingJoinSecurity { get; set; }

        [JsonProperty("enableAutomaticLock")]
        public bool? EnableAutomaticLock { get; set; }

        [JsonProperty("automaticLockMinutes")]
        public int? AutomaticLockMinutes { get; set; }

        [JsonProperty("allowFirstUserToBeCoHost")]
        public bool? AllowFirstUserToBeCoHost { get; set; }

        [JsonProperty("allowAuthenticatedDevices")]
        public bool? AllowAuthenticatedDevices { get; set; }

        [JsonProperty("sendEmail")]
        public bool? SendEmail { get; set; }

        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }

        [JsonProperty("meetingOptions")]
        public UpdateAMeetingInputMeetingOptionsType MeetingOptions { get; set; }

        [JsonProperty("attendeePrivileges")]
        public UpdateAMeetingInputAttendeePrivilegesType AttendeePrivileges { get; set; }

        [JsonProperty("integrationTags")]
        public string[] IntegrationTags { get; set; }

        [JsonProperty("enabledBreakoutSessions")]
        public bool? EnabledBreakoutSessions { get; set; }

        [JsonProperty("trackingCodes")]
        public UpdateAMeetingInputTrackingCodesTypeItem[] TrackingCodes { get; set; }

        [JsonProperty("audioConnectionOptions")]
        public UpdateAMeetingInputAudioConnectionOptionsType AudioConnectionOptions { get; set; }
    }

    public class UpdateAMeetingInputMeetingOptionsType
    {
        [JsonProperty("enabledChat")]
        public bool? EnabledChat { get; set; }

        [JsonProperty("enabledVideo")]
        public bool? EnabledVideo { get; set; }

        [JsonProperty("enabledPolling")]
        public bool? EnabledPolling { get; set; }

        [JsonProperty("enabledNote")]
        public bool? EnabledNote { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("enabledClosedCaptions")]
        public bool? EnabledClosedCaptions { get; set; }

        [JsonProperty("enabledFileTransfer")]
        public bool? EnabledFileTransfer { get; set; }

        [JsonProperty("enabledUCFRichMedia")]
        public bool? EnabledUCFRichMedia { get; set; }
    }

    public class UpdateAMeetingInputAttendeePrivilegesType
    {
        [JsonProperty("enabledShareContent")]
        public bool? EnabledShareContent { get; set; }

        [JsonProperty("enabledSaveDocument")]
        public bool? EnabledSaveDocument { get; set; }

        [JsonProperty("enabledPrintDocument")]
        public bool? EnabledPrintDocument { get; set; }

        [JsonProperty("enabledAnnotate")]
        public bool? EnabledAnnotate { get; set; }

        [JsonProperty("enabledViewParticipantList")]
        public bool? EnabledViewParticipantList { get; set; }

        [JsonProperty("enabledViewThumbnails")]
        public bool? EnabledViewThumbnails { get; set; }

        [JsonProperty("enabledRemoteControl")]
        public bool? EnabledRemoteControl { get; set; }

        [JsonProperty("enabledViewAnyDocument")]
        public bool? EnabledViewAnyDocument { get; set; }

        [JsonProperty("enabledViewAnyPage")]
        public bool? EnabledViewAnyPage { get; set; }

        [JsonProperty("enabledContactOperatorPrivately")]
        public bool? EnabledContactOperatorPrivately { get; set; }

        [JsonProperty("enabledChatHost")]
        public bool? EnabledChatHost { get; set; }

        [JsonProperty("enabledChatPresenter")]
        public bool? EnabledChatPresenter { get; set; }

        [JsonProperty("enabledChatOtherParticipants")]
        public bool? EnabledChatOtherParticipants { get; set; }
    }

    public class UpdateAMeetingInputTrackingCodesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateAMeetingInputAudioConnectionOptionsType
    {
        [JsonProperty("audioConnectionType")]
        public string AudioConnectionType { get; set; }

        [JsonProperty("enabledTollFreeCallIn")]
        public bool? EnabledTollFreeCallIn { get; set; }

        [JsonProperty("enabledGlobalCallIn")]
        public bool? EnabledGlobalCallIn { get; set; }

        [JsonProperty("enabledAudienceCallBack")]
        public bool? EnabledAudienceCallBack { get; set; }

        [JsonProperty("entryAndExitTone")]
        public string EntryAndExitTone { get; set; }

        [JsonProperty("allowHostToUnmuteParticipants")]
        public bool? AllowHostToUnmuteParticipants { get; set; }

        [JsonProperty("allowAttendeeToUnmuteSelf")]
        public bool? AllowAttendeeToUnmuteSelf { get; set; }

        [JsonProperty("muteAttendeeUponEntry")]
        public bool? MuteAttendeeUponEntry { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webexintegrationip;

    public partial class WorkflowManagedActions
    {
        public WebexintegrationipActions Webexintegrationip(string connectionId) => new WebexintegrationipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebexintegrationipTriggers Webexintegrationip(string connectionId) => new WebexintegrationipTriggers(connectionId);
    }
}