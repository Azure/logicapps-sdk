//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zoommeetingsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZoommeetingsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zoommeetingsip")]
        public IBodyWorkflowAction<GetMeetingsResponse, ApiConnectionActionConfiguration> GetMeetings()
        {
            return new DeferredBodyAction<GetMeetingsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/users/me/meetings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMeetingsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zoommeetingsip")]
        public IBodyWorkflowAction<CreateMeetingResponse, ApiConnectionActionConfiguration> CreateMeeting(Expression<Func<string>> bodytopic = null, Expression<Func<int>> bodytype = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyduration = null, Expression<Func<bool>> bodysettingshostVideo = null, Expression<Func<bool>> bodysettingsparticipantVideo = null, Expression<Func<bool>> bodysettingsjoinBeforeHost = null, Expression<Func<string>> bodysettingsmuteUponEntry = null, Expression<Func<string>> bodysettingswatermark = null, Expression<Func<string>> bodysettingsaudio = null, Expression<Func<string>> bodysettingsautoRecording = null)
        {
            var __workflow_bodytopic = WorkflowExpression.Compile(bodytopic, nameof(bodytopic), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodysettingshostVideo = WorkflowExpression.Compile(bodysettingshostVideo, nameof(bodysettingshostVideo), required: false);
            var __workflow_bodysettingsparticipantVideo = WorkflowExpression.Compile(bodysettingsparticipantVideo, nameof(bodysettingsparticipantVideo), required: false);
            var __workflow_bodysettingsjoinBeforeHost = WorkflowExpression.Compile(bodysettingsjoinBeforeHost, nameof(bodysettingsjoinBeforeHost), required: false);
            var __workflow_bodysettingsmuteUponEntry = WorkflowExpression.Compile(bodysettingsmuteUponEntry, nameof(bodysettingsmuteUponEntry), required: false);
            var __workflow_bodysettingswatermark = WorkflowExpression.Compile(bodysettingswatermark, nameof(bodysettingswatermark), required: false);
            var __workflow_bodysettingsaudio = WorkflowExpression.Compile(bodysettingsaudio, nameof(bodysettingsaudio), required: false);
            var __workflow_bodysettingsautoRecording = WorkflowExpression.Compile(bodysettingsautoRecording, nameof(bodysettingsautoRecording), required: false);
            return new DeferredBodyAction<CreateMeetingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/users/me/meetings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytopic != null)
                {
                    body["topic"] = ExpressionConverter.ConvertO(__workflow_bodytopic);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingshostVideo != null)
                {
                    settingsObject["host_video"] = ExpressionConverter.ConvertO(__workflow_bodysettingshostVideo);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsparticipantVideo != null)
                {
                    settingsObject["participant_video"] = ExpressionConverter.ConvertO(__workflow_bodysettingsparticipantVideo);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsjoinBeforeHost != null)
                {
                    settingsObject["join_before_host"] = ExpressionConverter.ConvertO(__workflow_bodysettingsjoinBeforeHost);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsmuteUponEntry != null)
                {
                    settingsObject["mute_upon_entry"] = ExpressionConverter.ConvertO(__workflow_bodysettingsmuteUponEntry);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingswatermark != null)
                {
                    settingsObject["watermark"] = ExpressionConverter.ConvertO(__workflow_bodysettingswatermark);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsaudio != null)
                {
                    settingsObject["audio"] = ExpressionConverter.ConvertO(__workflow_bodysettingsaudio);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsautoRecording != null)
                {
                    settingsObject["auto_recording"] = ExpressionConverter.ConvertO(__workflow_bodysettingsautoRecording);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zoommeetingsip")]
        public IBodyWorkflowAction<MeetingDetailsResponse, ApiConnectionActionConfiguration> MeetingDetails(Expression<Func<string>> meetingid)
        {
            var __workflow_meetingid = WorkflowExpression.Compile(meetingid, nameof(meetingid), required: true);
            return new DeferredBodyAction<MeetingDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/meetings/{0}", __workflow_meetingid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MeetingDetailsResponse>(callPayload);
            });
        }
    }

    public class ZoommeetingsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetMeetingsResponse
    {
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonProperty("meetings")]
        public GetMeetingsResponseMeetingsTypeItem[] Meetings { get; set; }
    }

    public class GetMeetingsResponseMeetingsTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("host_id")]
        public string HostId { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("join_url")]
        public string JoinUrl { get; set; }
    }

    public class CreateMeetingResponse
    {
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonProperty("meetings")]
        public CreateMeetingResponseMeetingsTypeItem[] Meetings { get; set; }
    }

    public class CreateMeetingResponseMeetingsTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("host_id")]
        public string HostId { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("join_url")]
        public string JoinUrl { get; set; }
    }

    public class MeetingDetailsResponse
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("host_id")]
        public string HostId { get; set; }

        [JsonProperty("host_email")]
        public string HostEmail { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("agenda")]
        public string Agenda { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("start_url")]
        public string StartUrl { get; set; }

        [JsonProperty("join_url")]
        public string JoinUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("h323_password")]
        public string H323Password { get; set; }

        [JsonProperty("pstn_password")]
        public string PstnPassword { get; set; }

        [JsonProperty("encrypted_password")]
        public string EncryptedPassword { get; set; }

        [JsonProperty("settings")]
        public MeetingDetailsResponseSettingsType Settings { get; set; }

        [JsonProperty("pre_schedule")]
        public bool PreSchedule { get; set; }
    }

    public class MeetingDetailsResponseSettingsType
    {
        [JsonProperty("host_video")]
        public bool HostVideo { get; set; }

        [JsonProperty("participant_video")]
        public bool ParticipantVideo { get; set; }

        [JsonProperty("cn_meeting")]
        public bool CnMeeting { get; set; }

        [JsonProperty("in_meeting")]
        public bool InMeeting { get; set; }

        [JsonProperty("join_before_host")]
        public bool JoinBeforeHost { get; set; }

        [JsonProperty("jbh_time")]
        public int JbhTime { get; set; }

        [JsonProperty("mute_upon_entry")]
        public bool MuteUponEntry { get; set; }

        [JsonProperty("watermark")]
        public bool Watermark { get; set; }

        [JsonProperty("use_pmi")]
        public bool UsePmi { get; set; }

        [JsonProperty("approval_type")]
        public int ApprovalType { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("auto_recording")]
        public string AutoRecording { get; set; }

        [JsonProperty("enforce_login")]
        public bool EnforceLogin { get; set; }

        [JsonProperty("enforce_login_domains")]
        public string EnforceLoginDomains { get; set; }

        [JsonProperty("alternative_hosts")]
        public string AlternativeHosts { get; set; }

        [JsonProperty("close_registration")]
        public bool CloseRegistration { get; set; }

        [JsonProperty("show_share_button")]
        public bool ShowShareButton { get; set; }

        [JsonProperty("allow_multiple_devices")]
        public bool AllowMultipleDevices { get; set; }

        [JsonProperty("registrants_confirmation_email")]
        public bool RegistrantsConfirmationEmail { get; set; }

        [JsonProperty("waiting_room")]
        public bool WaitingRoom { get; set; }

        [JsonProperty("request_permission_to_unmute_participants")]
        public bool RequestPermissionToUnmuteParticipants { get; set; }

        [JsonProperty("registrants_email_notification")]
        public bool RegistrantsEmailNotification { get; set; }

        [JsonProperty("meeting_authentication")]
        public bool MeetingAuthentication { get; set; }

        [JsonProperty("encryption_type")]
        public string EncryptionType { get; set; }

        [JsonProperty("approved_or_denied_countries_or_regions")]
        public MeetingDetailsResponseSettingsTypeApprovedOrDeniedCountriesOrRegionsType ApprovedOrDeniedCountriesOrRegions { get; set; }

        [JsonProperty("breakout_room")]
        public MeetingDetailsResponseSettingsTypeBreakoutRoomType BreakoutRoom { get; set; }

        [JsonProperty("alternative_hosts_email_notification")]
        public bool AlternativeHostsEmailNotification { get; set; }

        [JsonProperty("device_testing")]
        public bool DeviceTesting { get; set; }
    }

    public class MeetingDetailsResponseSettingsTypeApprovedOrDeniedCountriesOrRegionsType
    {
        [JsonProperty("enable")]
        public bool Enable { get; set; }
    }

    public class MeetingDetailsResponseSettingsTypeBreakoutRoomType
    {
        [JsonProperty("enable")]
        public bool Enable { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zoommeetingsip;

    public partial class WorkflowManagedActions
    {
        public ZoommeetingsipActions Zoommeetingsip(string connectionId) => new ZoommeetingsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZoommeetingsipTriggers Zoommeetingsip(string connectionId) => new ZoommeetingsipTriggers(connectionId);
    }
}