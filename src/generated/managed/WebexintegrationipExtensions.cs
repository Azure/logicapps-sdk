//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webexintegrationip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebexintegrationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<ReadMeetingResponse> ReadMeetings(Expression<Func<string>> contentType = null, Expression<Func<string>> password = null, Expression<Func<string>> timezone = null)
        {
            var apiCallPath = "/meetings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            if (password != null)
                callPayload.Headers["password"] = CSharpExpressionConverter.ConvertO(password);
            if (timezone != null)
                callPayload.Headers["timezone"] = CSharpExpressionConverter.ConvertO(timezone);
            return new ApiConnectionAction<ReadMeetingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<CreateAMeetingResponse> CreateAMeeting(Expression<Func<string>> contentType, Expression<Func<string>> bodytitle, Expression<Func<string>> bodystart, Expression<Func<string>> bodyend, Expression<Func<string>> bodyagenda = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodytimezone = null, Expression<Func<bool>> bodyenabledAutoRecordMeeting = null, Expression<Func<bool>> bodyallowAnyUserToBeCoHost = null)
        {
            var apiCallPath = "/meetings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            if (bodyagenda != null)
            {
                body["agenda"] = CSharpExpressionConverter.ConvertToken(bodyagenda);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
            }

            bodypropCount++;
            body["start"] = CSharpExpressionConverter.ConvertToken(bodystart);
            bodypropCount++;
            body["end"] = CSharpExpressionConverter.ConvertToken(bodyend);
            if (bodytimezone != null)
            {
                if (bodytimezone != null)
                {
                    body["timezone"] = CSharpExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["timezone"] = "Europe/London";
                bodypropCount++;
            }

            if (bodyenabledAutoRecordMeeting != null)
            {
                if (bodyenabledAutoRecordMeeting != null)
                {
                    body["enabledAutoRecordMeeting"] = CSharpExpressionConverter.ConvertToken(bodyenabledAutoRecordMeeting);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["enabledAutoRecordMeeting"] = false;
                bodypropCount++;
            }

            if (bodyallowAnyUserToBeCoHost != null)
            {
                if (bodyallowAnyUserToBeCoHost != null)
                {
                    body["allowAnyUserToBeCoHost"] = CSharpExpressionConverter.ConvertToken(bodyallowAnyUserToBeCoHost);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["allowAnyUserToBeCoHost"] = false;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAMeetingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction CreateAInvitee(Expression<Func<string>> bodymeetingId, Expression<Func<string>> bodyemail, Expression<Func<string>> contentType = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodycoHost = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodysendEmail = null, Expression<Func<string>> bodypanelist = null)
        {
            var apiCallPath = "/meetingInvitees";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["meetingId"] = CSharpExpressionConverter.ConvertToken(bodymeetingId);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodydisplayName != null)
            {
                body["displayName"] = CSharpExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
            }

            if (bodycoHost != null)
            {
                body["coHost"] = CSharpExpressionConverter.ConvertToken(bodycoHost);
                bodypropCount++;
            }

            if (bodyhostEmail != null)
            {
                body["hostEmail"] = CSharpExpressionConverter.ConvertToken(bodyhostEmail);
                bodypropCount++;
            }

            if (bodysendEmail != null)
            {
                body["sendEmail"] = CSharpExpressionConverter.ConvertToken(bodysendEmail);
                bodypropCount++;
            }

            if (bodypanelist != null)
            {
                body["panelist"] = CSharpExpressionConverter.ConvertToken(bodypanelist);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction DeleteAMeeting(Expression<Func<string>> meetingId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/meetings/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction UpdateAMeeting(Expression<Func<string>> meetingId, Expression<Func<string>> contentType = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyagenda = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<bool>> bodyenabledAutoRecordMeeting = null, Expression<Func<bool>> bodyallowAnyUserToBeCoHost = null, Expression<Func<bool>> bodyenabledJoinBeforeHost = null, Expression<Func<bool>> bodyenableConnectAudioBeforeHost = null, Expression<Func<int>> bodyjoinBeforeHostMinutes = null, Expression<Func<bool>> bodyexcludePassword = null, Expression<Func<bool>> bodypublicMeeting = null, Expression<Func<int>> bodyreminderTime = null, Expression<Func<string>> bodyunlockedMeetingJoinSecurity = null, Expression<Func<bool>> bodyenableAutomaticLock = null, Expression<Func<int>> bodyautomaticLockMinutes = null, Expression<Func<bool>> bodyallowFirstUserToBeCoHost = null, Expression<Func<bool>> bodyallowAuthenticatedDevices = null, Expression<Func<bool>> bodysendEmail = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodysiteUrl = null, Expression<Func<bool>> bodymeetingOptionsenabledChat = null, Expression<Func<bool>> bodymeetingOptionsenabledVideo = null, Expression<Func<bool>> bodymeetingOptionsenabledPolling = null, Expression<Func<bool>> bodymeetingOptionsenabledNote = null, Expression<Func<string>> bodymeetingOptionsnoteType = null, Expression<Func<bool>> bodymeetingOptionsenabledClosedCaptions = null, Expression<Func<bool>> bodymeetingOptionsenabledFileTransfer = null, Expression<Func<bool>> bodymeetingOptionsenabledUCFRichMedia = null, Expression<Func<bool>> bodyattendeePrivilegesenabledShareContent = null, Expression<Func<bool>> bodyattendeePrivilegesenabledSaveDocument = null, Expression<Func<bool>> bodyattendeePrivilegesenabledPrintDocument = null, Expression<Func<bool>> bodyattendeePrivilegesenabledAnnotate = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewParticipantList = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewThumbnails = null, Expression<Func<bool>> bodyattendeePrivilegesenabledRemoteControl = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewAnyDocument = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewAnyPage = null, Expression<Func<bool>> bodyattendeePrivilegesenabledContactOperatorPrivately = null, Expression<Func<bool>> bodyattendeePrivilegesenabledChatHost = null, Expression<Func<bool>> bodyattendeePrivilegesenabledChatPresenter = null, Expression<Func<bool>> bodyattendeePrivilegesenabledChatOtherParticipants = null, Expression<Func<string[]>> bodyintegrationTags = null, Expression<Func<bool>> bodyenabledBreakoutSessions = null, Expression<Func<bodytrackingCodesInputItem[]>> bodytrackingCodes = null, Expression<Func<string>> bodyaudioConnectionOptionsaudioConnectionType = null, Expression<Func<bool>> bodyaudioConnectionOptionsenabledTollFreeCallIn = null, Expression<Func<bool>> bodyaudioConnectionOptionsenabledGlobalCallIn = null, Expression<Func<bool>> bodyaudioConnectionOptionsenabledAudienceCallBack = null, Expression<Func<string>> bodyaudioConnectionOptionsentryAndExitTone = null, Expression<Func<bool>> bodyaudioConnectionOptionsallowHostToUnmuteParticipants = null, Expression<Func<bool>> bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf = null, Expression<Func<bool>> bodyaudioConnectionOptionsmuteAttendeeUponEntry = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/meetings/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyagenda != null)
            {
                body["agenda"] = CSharpExpressionConverter.ConvertToken(bodyagenda);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = CSharpExpressionConverter.ConvertToken(bodytimezone);
                bodypropCount++;
            }

            if (bodystart != null)
            {
                body["start"] = CSharpExpressionConverter.ConvertToken(bodystart);
                bodypropCount++;
            }

            if (bodyend != null)
            {
                body["end"] = CSharpExpressionConverter.ConvertToken(bodyend);
                bodypropCount++;
            }

            if (bodyenabledAutoRecordMeeting != null)
            {
                body["enabledAutoRecordMeeting"] = CSharpExpressionConverter.ConvertToken(bodyenabledAutoRecordMeeting);
                bodypropCount++;
            }

            if (bodyallowAnyUserToBeCoHost != null)
            {
                body["allowAnyUserToBeCoHost"] = CSharpExpressionConverter.ConvertToken(bodyallowAnyUserToBeCoHost);
                bodypropCount++;
            }

            if (bodyenabledJoinBeforeHost != null)
            {
                body["enabledJoinBeforeHost"] = CSharpExpressionConverter.ConvertToken(bodyenabledJoinBeforeHost);
                bodypropCount++;
            }

            if (bodyenableConnectAudioBeforeHost != null)
            {
                body["enableConnectAudioBeforeHost"] = CSharpExpressionConverter.ConvertToken(bodyenableConnectAudioBeforeHost);
                bodypropCount++;
            }

            if (bodyjoinBeforeHostMinutes != null)
            {
                body["joinBeforeHostMinutes"] = CSharpExpressionConverter.ConvertToken(bodyjoinBeforeHostMinutes);
                bodypropCount++;
            }

            if (bodyexcludePassword != null)
            {
                body["excludePassword"] = CSharpExpressionConverter.ConvertToken(bodyexcludePassword);
                bodypropCount++;
            }

            if (bodypublicMeeting != null)
            {
                body["publicMeeting"] = CSharpExpressionConverter.ConvertToken(bodypublicMeeting);
                bodypropCount++;
            }

            if (bodyreminderTime != null)
            {
                body["reminderTime"] = CSharpExpressionConverter.ConvertToken(bodyreminderTime);
                bodypropCount++;
            }

            if (bodyunlockedMeetingJoinSecurity != null)
            {
                body["unlockedMeetingJoinSecurity"] = CSharpExpressionConverter.ConvertToken(bodyunlockedMeetingJoinSecurity);
                bodypropCount++;
            }

            if (bodyenableAutomaticLock != null)
            {
                body["enableAutomaticLock"] = CSharpExpressionConverter.ConvertToken(bodyenableAutomaticLock);
                bodypropCount++;
            }

            if (bodyautomaticLockMinutes != null)
            {
                body["automaticLockMinutes"] = CSharpExpressionConverter.ConvertToken(bodyautomaticLockMinutes);
                bodypropCount++;
            }

            if (bodyallowFirstUserToBeCoHost != null)
            {
                body["allowFirstUserToBeCoHost"] = CSharpExpressionConverter.ConvertToken(bodyallowFirstUserToBeCoHost);
                bodypropCount++;
            }

            if (bodyallowAuthenticatedDevices != null)
            {
                body["allowAuthenticatedDevices"] = CSharpExpressionConverter.ConvertToken(bodyallowAuthenticatedDevices);
                bodypropCount++;
            }

            if (bodysendEmail != null)
            {
                body["sendEmail"] = CSharpExpressionConverter.ConvertToken(bodysendEmail);
                bodypropCount++;
            }

            if (bodyhostEmail != null)
            {
                body["hostEmail"] = CSharpExpressionConverter.ConvertToken(bodyhostEmail);
                bodypropCount++;
            }

            if (bodysiteUrl != null)
            {
                body["siteUrl"] = CSharpExpressionConverter.ConvertToken(bodysiteUrl);
                bodypropCount++;
            }

            var meetingOptionsObject = new JObject();
            var meetingOptionsObjectpropCount = 0;
            if (bodymeetingOptionsenabledChat != null)
            {
                meetingOptionsObject["enabledChat"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsenabledChat);
                meetingOptionsObjectpropCount++;
            }

            if (bodymeetingOptionsenabledVideo != null)
            {
                meetingOptionsObject["enabledVideo"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsenabledVideo);
                meetingOptionsObjectpropCount++;
            }

            if (bodymeetingOptionsenabledPolling != null)
            {
                meetingOptionsObject["enabledPolling"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsenabledPolling);
                meetingOptionsObjectpropCount++;
            }

            if (bodymeetingOptionsenabledNote != null)
            {
                meetingOptionsObject["enabledNote"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsenabledNote);
                meetingOptionsObjectpropCount++;
            }

            if (bodymeetingOptionsnoteType != null)
            {
                meetingOptionsObject["noteType"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsnoteType);
                meetingOptionsObjectpropCount++;
            }

            if (bodymeetingOptionsenabledClosedCaptions != null)
            {
                meetingOptionsObject["enabledClosedCaptions"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsenabledClosedCaptions);
                meetingOptionsObjectpropCount++;
            }

            if (bodymeetingOptionsenabledFileTransfer != null)
            {
                meetingOptionsObject["enabledFileTransfer"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsenabledFileTransfer);
                meetingOptionsObjectpropCount++;
            }

            if (bodymeetingOptionsenabledUCFRichMedia != null)
            {
                meetingOptionsObject["enabledUCFRichMedia"] = CSharpExpressionConverter.ConvertToken(bodymeetingOptionsenabledUCFRichMedia);
                meetingOptionsObjectpropCount++;
            }

            if (meetingOptionsObjectpropCount > 0)
            {
                body["meetingOptions"] = meetingOptionsObject;
                bodypropCount++;
            }

            var attendeePrivilegesObject = new JObject();
            var attendeePrivilegesObjectpropCount = 0;
            if (bodyattendeePrivilegesenabledShareContent != null)
            {
                attendeePrivilegesObject["enabledShareContent"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledShareContent);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledSaveDocument != null)
            {
                attendeePrivilegesObject["enabledSaveDocument"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledSaveDocument);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledPrintDocument != null)
            {
                attendeePrivilegesObject["enabledPrintDocument"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledPrintDocument);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledAnnotate != null)
            {
                attendeePrivilegesObject["enabledAnnotate"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledAnnotate);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledViewParticipantList != null)
            {
                attendeePrivilegesObject["enabledViewParticipantList"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewParticipantList);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledViewThumbnails != null)
            {
                attendeePrivilegesObject["enabledViewThumbnails"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewThumbnails);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledRemoteControl != null)
            {
                attendeePrivilegesObject["enabledRemoteControl"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledRemoteControl);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledViewAnyDocument != null)
            {
                attendeePrivilegesObject["enabledViewAnyDocument"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewAnyDocument);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledViewAnyPage != null)
            {
                attendeePrivilegesObject["enabledViewAnyPage"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewAnyPage);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledContactOperatorPrivately != null)
            {
                attendeePrivilegesObject["enabledContactOperatorPrivately"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledContactOperatorPrivately);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledChatHost != null)
            {
                attendeePrivilegesObject["enabledChatHost"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledChatHost);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledChatPresenter != null)
            {
                attendeePrivilegesObject["enabledChatPresenter"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledChatPresenter);
                attendeePrivilegesObjectpropCount++;
            }

            if (bodyattendeePrivilegesenabledChatOtherParticipants != null)
            {
                attendeePrivilegesObject["enabledChatOtherParticipants"] = CSharpExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledChatOtherParticipants);
                attendeePrivilegesObjectpropCount++;
            }

            if (attendeePrivilegesObjectpropCount > 0)
            {
                body["attendeePrivileges"] = attendeePrivilegesObject;
                bodypropCount++;
            }

            if (bodyintegrationTags != null)
            {
                body["integrationTags"] = CSharpExpressionConverter.ConvertToken(bodyintegrationTags);
                bodypropCount++;
            }

            if (bodyenabledBreakoutSessions != null)
            {
                body["enabledBreakoutSessions"] = CSharpExpressionConverter.ConvertToken(bodyenabledBreakoutSessions);
                bodypropCount++;
            }

            if (bodytrackingCodes != null)
            {
                body["trackingCodes"] = CSharpExpressionConverter.ConvertToken(bodytrackingCodes);
                bodypropCount++;
            }

            var audioConnectionOptionsObject = new JObject();
            var audioConnectionOptionsObjectpropCount = 0;
            if (bodyaudioConnectionOptionsaudioConnectionType != null)
            {
                audioConnectionOptionsObject["audioConnectionType"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsaudioConnectionType);
                audioConnectionOptionsObjectpropCount++;
            }

            if (bodyaudioConnectionOptionsenabledTollFreeCallIn != null)
            {
                audioConnectionOptionsObject["enabledTollFreeCallIn"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsenabledTollFreeCallIn);
                audioConnectionOptionsObjectpropCount++;
            }

            if (bodyaudioConnectionOptionsenabledGlobalCallIn != null)
            {
                audioConnectionOptionsObject["enabledGlobalCallIn"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsenabledGlobalCallIn);
                audioConnectionOptionsObjectpropCount++;
            }

            if (bodyaudioConnectionOptionsenabledAudienceCallBack != null)
            {
                audioConnectionOptionsObject["enabledAudienceCallBack"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsenabledAudienceCallBack);
                audioConnectionOptionsObjectpropCount++;
            }

            if (bodyaudioConnectionOptionsentryAndExitTone != null)
            {
                audioConnectionOptionsObject["entryAndExitTone"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsentryAndExitTone);
                audioConnectionOptionsObjectpropCount++;
            }

            if (bodyaudioConnectionOptionsallowHostToUnmuteParticipants != null)
            {
                audioConnectionOptionsObject["allowHostToUnmuteParticipants"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsallowHostToUnmuteParticipants);
                audioConnectionOptionsObjectpropCount++;
            }

            if (bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf != null)
            {
                audioConnectionOptionsObject["allowAttendeeToUnmuteSelf"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf);
                audioConnectionOptionsObjectpropCount++;
            }

            if (bodyaudioConnectionOptionsmuteAttendeeUponEntry != null)
            {
                audioConnectionOptionsObject["muteAttendeeUponEntry"] = CSharpExpressionConverter.ConvertToken(bodyaudioConnectionOptionsmuteAttendeeUponEntry);
                audioConnectionOptionsObjectpropCount++;
            }

            if (audioConnectionOptionsObjectpropCount > 0)
            {
                body["audioConnectionOptions"] = audioConnectionOptionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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

    public class bodytrackingCodesInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
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