//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zoommeetingsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZoommeetingsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zoommeetingsip")]
        public IBodyWorkflowAction<GetMeetingsResponse> GetMeetings()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/users/me/meetings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMeetingsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zoommeetingsip")]
        public IBodyWorkflowAction<CreateMeetingResponse> CreateMeeting([WorkflowExpression] Func<string> bodytopic = null, [WorkflowExpression] Func<int> bodytype = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyduration = null, [WorkflowExpression] Func<bool> bodysettingshostVideo = null, [WorkflowExpression] Func<bool> bodysettingsparticipantVideo = null, [WorkflowExpression] Func<bool> bodysettingsjoinBeforeHost = null, [WorkflowExpression] Func<string> bodysettingsmuteUponEntry = null, [WorkflowExpression] Func<string> bodysettingswatermark = null, [WorkflowExpression] Func<string> bodysettingsaudio = null, [WorkflowExpression] Func<string> bodysettingsautoRecording = null)
        {
            SourceExpression.Validate(bodytopic, nameof(bodytopic), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            SourceExpression.Validate(bodysettingshostVideo, nameof(bodysettingshostVideo), required: false);
            SourceExpression.Validate(bodysettingsparticipantVideo, nameof(bodysettingsparticipantVideo), required: false);
            SourceExpression.Validate(bodysettingsjoinBeforeHost, nameof(bodysettingsjoinBeforeHost), required: false);
            SourceExpression.Validate(bodysettingsmuteUponEntry, nameof(bodysettingsmuteUponEntry), required: false);
            SourceExpression.Validate(bodysettingswatermark, nameof(bodysettingswatermark), required: false);
            SourceExpression.Validate(bodysettingsaudio, nameof(bodysettingsaudio), required: false);
            SourceExpression.Validate(bodysettingsautoRecording, nameof(bodysettingsautoRecording), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/users/me/meetings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytopic != null)
                {
                    body["topic"] = SourceExpressionConverter.ConvertToken(bodytopic);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (bodysettingshostVideo != null)
                {
                    settingsObject["host_video"] = SourceExpressionConverter.ConvertToken(bodysettingshostVideo);
                    settingsObjectpropCount++;
                }

                if (bodysettingsparticipantVideo != null)
                {
                    settingsObject["participant_video"] = SourceExpressionConverter.ConvertToken(bodysettingsparticipantVideo);
                    settingsObjectpropCount++;
                }

                if (bodysettingsjoinBeforeHost != null)
                {
                    settingsObject["join_before_host"] = SourceExpressionConverter.ConvertToken(bodysettingsjoinBeforeHost);
                    settingsObjectpropCount++;
                }

                if (bodysettingsmuteUponEntry != null)
                {
                    settingsObject["mute_upon_entry"] = SourceExpressionConverter.ConvertToken(bodysettingsmuteUponEntry);
                    settingsObjectpropCount++;
                }

                if (bodysettingswatermark != null)
                {
                    settingsObject["watermark"] = SourceExpressionConverter.ConvertToken(bodysettingswatermark);
                    settingsObjectpropCount++;
                }

                if (bodysettingsaudio != null)
                {
                    settingsObject["audio"] = SourceExpressionConverter.ConvertToken(bodysettingsaudio);
                    settingsObjectpropCount++;
                }

                if (bodysettingsautoRecording != null)
                {
                    settingsObject["auto_recording"] = SourceExpressionConverter.ConvertToken(bodysettingsautoRecording);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateMeetingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zoommeetingsip")]
        public IBodyWorkflowAction<MeetingDetailsResponse> MeetingDetails([WorkflowExpression] Func<string> meetingid)
        {
            SourceExpression.Validate(meetingid, nameof(meetingid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/meetings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MeetingDetailsResponse>(BuildSourceInput);
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