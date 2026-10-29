//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voicemonkey
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoicemonkeyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        public IBodyWorkflowAction<MakeAnnouncementResponse, ApiConnectionActionConfiguration> MakeAnnouncement(Expression<Func<MakeAnnouncementInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MakeAnnouncementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/announcement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MakeAnnouncementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        public IBodyWorkflowAction<TriggerRoutineResponse, ApiConnectionActionConfiguration> TriggerRoutine(Expression<Func<TriggerRoutineInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TriggerRoutineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TriggerRoutineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        public IBodyWorkflowAction<TriggerFlowResponse, ApiConnectionActionConfiguration> TriggerFlow(Expression<Func<TriggerFlowInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TriggerFlowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TriggerFlowResponse>(callPayload);
            });
        }
    }

    public class VoicemonkeyTriggers([ConnectionName] string connectionId)
    {
    }

    public class MakeAnnouncementResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class MakeAnnouncementInput
    {
        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("voice")]
        public MakeAnnouncementInputVoiceType? Voice { get; set; }

        [JsonProperty("language")]
        public MakeAnnouncementInputLanguageType? Language { get; set; }

        [JsonProperty("chime")]
        public MakeAnnouncementInputChimeType? Chime { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("background_audio")]
        public string BackgroundAudio { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("no_bg")]
        public bool? NoBackground { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("media_width")]
        public int? MediaWidth { get; set; }

        [JsonProperty("media_height")]
        public int? MediaHeight { get; set; }

        [JsonProperty("media_scaling")]
        public MakeAnnouncementInputMediaScalingType? MediaScaling { get; set; }

        [JsonProperty("media_align")]
        public MakeAnnouncementInputMediaAlignmentType? MediaAlignment { get; set; }

        [JsonProperty("media_radius")]
        public int? MediaRadius { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("video_repeat")]
        public int? VideoRepeat { get; set; }

        [JsonProperty("character_display")]
        public string EchoDotWithClockDisplay { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MakeAnnouncementInputVoiceType
    {
        Nicole,
        Russell,
        Amy,
        Emma,
        Brian,
        Raveena,
        Aditi,
        Ivy,
        Joanna,
        Kendra,
        Kimberly,
        Salli,
        Joey,
        Justin,
        Matthew,
        Geraint,
        Celine,
        Lea,
        Mathieu,
        Chantal,
        Marlene,
        Vicki,
        Hans,
        Bianca,
        Carla,
        Giorgio,
        Takumi,
        Mizuki,
        Camila,
        Vitoria,
        Ricardo,
        Conchita,
        Lucia,
        Enrique,
        Mia,
        Penelope,
        Lupe,
        Miguel
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MakeAnnouncementInputLanguageType
    {
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "en-AU")]
        EnAU,
        [EnumMember(Value = "en-CA")]
        EnCA,
        [EnumMember(Value = "en-GB")]
        EnGB,
        [EnumMember(Value = "en-IN")]
        EnIN,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "es-MX")]
        EsMX,
        [EnumMember(Value = "es-US")]
        EsUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "hi-IN")]
        HiIN,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "pt-BR")]
        PtBR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MakeAnnouncementInputChimeType
    {
        [EnumMember(Value = "soundbank://soundlibrary/alarms/air_horns/air_horn_01")]
        SoundbankSoundlibraryAlarmsAirHornsAirHorn01,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/boing_01")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsBoing01,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/bell_01")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsBell01,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/bell_02")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsBell02,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/chimes_and_bells/chimes_bells_05")]
        SoundbankSoundlibraryAlarmsChimesAndBellsChimesBells05,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/buzzers/buzzers_01")]
        SoundbankSoundlibraryAlarmsBuzzersBuzzers01,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/buzzers/buzzers_04")]
        SoundbankSoundlibraryAlarmsBuzzersBuzzers04,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/chimes_and_bells/chimes_bells_04")]
        SoundbankSoundlibraryAlarmsChimesAndBellsChimesBells04,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/bell_03")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsBell03,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/bell_04")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsBell04,
        [EnumMember(Value = "soundbank://soundlibrary/home/amzn_sfx_doorbell_01")]
        SoundbankSoundlibraryHomeAmznSfxDoorbell01,
        [EnumMember(Value = "soundbank://soundlibrary/home/amzn_sfx_doorbell_chime_02")]
        SoundbankSoundlibraryHomeAmznSfxDoorbellChime02,
        [EnumMember(Value = "soundbank://soundlibrary/musical/amzn_sfx_electronic_beep_01")]
        SoundbankSoundlibraryMusicalAmznSfxElectronicBeep01,
        [EnumMember(Value = "soundbank://soundlibrary/musical/amzn_sfx_electronic_beep_02")]
        SoundbankSoundlibraryMusicalAmznSfxElectronicBeep02,
        [EnumMember(Value = "soundbank://soundlibrary/scifi/amzn_sfx_scifi_timer_beep_01")]
        SoundbankSoundlibraryScifiAmznSfxScifiTimerBeep01,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/intro_02")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsIntro02,
        [EnumMember(Value = "soundbank://soundlibrary/scifi/amzn_sfx_scifi_alarm_01")]
        SoundbankSoundlibraryScifiAmznSfxScifiAlarm01,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/buzz_03")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsBuzz03,
        [EnumMember(Value = "soundbank://soundlibrary/musical/amzn_sfx_test_tone_01")]
        SoundbankSoundlibraryMusicalAmznSfxTestTone01,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/tone_02")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsTone02,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/tone_05")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsTone05,
        [EnumMember(Value = "soundbank://soundlibrary/alarms/beeps_and_bloops/woosh_02")]
        SoundbankSoundlibraryAlarmsBeepsAndBloopsWoosh02
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MakeAnnouncementInputMediaScalingType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "fill")]
        Fill,
        [EnumMember(Value = "best-fill")]
        BestFill,
        [EnumMember(Value = "best-fit")]
        BestFit,
        [EnumMember(Value = "best-fit-down")]
        BestFitDown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MakeAnnouncementInputMediaAlignmentType
    {
        [EnumMember(Value = "bottom")]
        Bottom,
        [EnumMember(Value = "bottom-left")]
        BottomLeft,
        [EnumMember(Value = "bottom-right")]
        BottomRight,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "right")]
        Right,
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "top-left")]
        TopLeft,
        [EnumMember(Value = "top-right")]
        TopRight
    }

    public class TriggerRoutineResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TriggerRoutineInput
    {
        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceId { get; set; }
    }

    public class TriggerFlowResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TriggerFlowInput
    {
        [JsonProperty("flow", DefaultValueHandling = DefaultValueHandling.Include)]
        public int FlowId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Voicemonkey;

    public partial class WorkflowManagedActions
    {
        public VoicemonkeyActions Voicemonkey(string connectionId) => new VoicemonkeyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VoicemonkeyTriggers Voicemonkey(string connectionId) => new VoicemonkeyTriggers(connectionId);
    }
}