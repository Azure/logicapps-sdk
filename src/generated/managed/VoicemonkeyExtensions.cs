//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voicemonkey
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoicemonkeyActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        [WorkflowExpressionFactory(nameof(__BuildMakeAnnouncement))]
        public IBodyWorkflowAction<MakeAnnouncementResponse> MakeAnnouncement([WorkflowExpression] Func<string> bodydeviceID, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<bodyvoiceInput> bodyvoice = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<bodychimeInput> bodychime = null, [WorkflowExpression] Func<string> bodyaudio = null, [WorkflowExpression] Func<string> bodybackgroundAudio = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<bool> bodynoBackground = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<int> bodymediaWidth = null, [WorkflowExpression] Func<int> bodymediaHeight = null, [WorkflowExpression] Func<bodymediaScalingInput> bodymediaScaling = null, [WorkflowExpression] Func<bodymediaAlignmentInput> bodymediaAlignment = null, [WorkflowExpression] Func<int> bodymediaRadius = null, [WorkflowExpression] Func<string> bodyvideo = null, [WorkflowExpression] Func<int> bodyvideoRepeat = null, [WorkflowExpression] Func<string> bodyechoDotWithClockDisplay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MakeAnnouncementResponse> __BuildMakeAnnouncement(WorkflowExpression<string> bodydeviceID, WorkflowExpression<string> bodytext = null, WorkflowExpression<bodyvoiceInput> bodyvoice = null, WorkflowExpression<bodylanguageInput> bodylanguage = null, WorkflowExpression<bodychimeInput> bodychime = null, WorkflowExpression<string> bodyaudio = null, WorkflowExpression<string> bodybackgroundAudio = null, WorkflowExpression<string> bodywebsite = null, WorkflowExpression<bool> bodynoBackground = null, WorkflowExpression<string> bodyimage = null, WorkflowExpression<int> bodymediaWidth = null, WorkflowExpression<int> bodymediaHeight = null, WorkflowExpression<bodymediaScalingInput> bodymediaScaling = null, WorkflowExpression<bodymediaAlignmentInput> bodymediaAlignment = null, WorkflowExpression<int> bodymediaRadius = null, WorkflowExpression<string> bodyvideo = null, WorkflowExpression<int> bodyvideoRepeat = null, WorkflowExpression<string> bodyechoDotWithClockDisplay = null)
        {
            WorkflowExpression.Validate(bodydeviceID, nameof(bodydeviceID), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodyvoice, nameof(bodyvoice), required: false);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodychime, nameof(bodychime), required: false);
            WorkflowExpression.Validate(bodyaudio, nameof(bodyaudio), required: false);
            WorkflowExpression.Validate(bodybackgroundAudio, nameof(bodybackgroundAudio), required: false);
            WorkflowExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            WorkflowExpression.Validate(bodynoBackground, nameof(bodynoBackground), required: false);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            WorkflowExpression.Validate(bodymediaWidth, nameof(bodymediaWidth), required: false);
            WorkflowExpression.Validate(bodymediaHeight, nameof(bodymediaHeight), required: false);
            WorkflowExpression.Validate(bodymediaScaling, nameof(bodymediaScaling), required: false);
            WorkflowExpression.Validate(bodymediaAlignment, nameof(bodymediaAlignment), required: false);
            WorkflowExpression.Validate(bodymediaRadius, nameof(bodymediaRadius), required: false);
            WorkflowExpression.Validate(bodyvideo, nameof(bodyvideo), required: false);
            WorkflowExpression.Validate(bodyvideoRepeat, nameof(bodyvideoRepeat), required: false);
            WorkflowExpression.Validate(bodyechoDotWithClockDisplay, nameof(bodyechoDotWithClockDisplay), required: false);
            return new DeferredBodyAction<MakeAnnouncementResponse>(() =>
            {
                var apiCallPath = "/announcement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["device"] = ExpressionConverter.ConvertO(bodydeviceID);
                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                if (bodyvoice != null)
                {
                    body["voice"] = ExpressionConverter.ConvertO(bodyvoice);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                    bodypropCount++;
                }

                if (bodychime != null)
                {
                    body["chime"] = ExpressionConverter.ConvertO(bodychime);
                    bodypropCount++;
                }

                if (bodyaudio != null)
                {
                    body["audio"] = ExpressionConverter.ConvertO(bodyaudio);
                    bodypropCount++;
                }

                if (bodybackgroundAudio != null)
                {
                    body["background_audio"] = ExpressionConverter.ConvertO(bodybackgroundAudio);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                    bodypropCount++;
                }

                if (bodynoBackground != null)
                {
                    body["no_bg"] = ExpressionConverter.ConvertO(bodynoBackground);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(bodyimage);
                    bodypropCount++;
                }

                if (bodymediaWidth != null)
                {
                    body["media_width"] = ExpressionConverter.ConvertO(bodymediaWidth);
                    bodypropCount++;
                }

                if (bodymediaHeight != null)
                {
                    body["media_height"] = ExpressionConverter.ConvertO(bodymediaHeight);
                    bodypropCount++;
                }

                if (bodymediaScaling != null)
                {
                    body["media_scaling"] = ExpressionConverter.ConvertO(bodymediaScaling);
                    bodypropCount++;
                }

                if (bodymediaAlignment != null)
                {
                    body["media_align"] = ExpressionConverter.ConvertO(bodymediaAlignment);
                    bodypropCount++;
                }

                if (bodymediaRadius != null)
                {
                    body["media_radius"] = ExpressionConverter.ConvertO(bodymediaRadius);
                    bodypropCount++;
                }

                if (bodyvideo != null)
                {
                    body["video"] = ExpressionConverter.ConvertO(bodyvideo);
                    bodypropCount++;
                }

                if (bodyvideoRepeat != null)
                {
                    body["video_repeat"] = ExpressionConverter.ConvertO(bodyvideoRepeat);
                    bodypropCount++;
                }

                if (bodyechoDotWithClockDisplay != null)
                {
                    body["character_display"] = ExpressionConverter.ConvertO(bodyechoDotWithClockDisplay);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MakeAnnouncementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        [WorkflowExpressionFactory(nameof(__BuildTriggerRoutine))]
        public IBodyWorkflowAction<TriggerRoutineResponse> TriggerRoutine([WorkflowExpression] Func<string> bodydeviceID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TriggerRoutineResponse> __BuildTriggerRoutine(WorkflowExpression<string> bodydeviceID)
        {
            WorkflowExpression.Validate(bodydeviceID, nameof(bodydeviceID), required: true);
            return new DeferredBodyAction<TriggerRoutineResponse>(() =>
            {
                var apiCallPath = "/trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["device"] = ExpressionConverter.ConvertO(bodydeviceID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TriggerRoutineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        [WorkflowExpressionFactory(nameof(__BuildTriggerFlow))]
        public IBodyWorkflowAction<TriggerFlowResponse> TriggerFlow([WorkflowExpression] Func<int> bodyflowID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TriggerFlowResponse> __BuildTriggerFlow(WorkflowExpression<int> bodyflowID)
        {
            WorkflowExpression.Validate(bodyflowID, nameof(bodyflowID), required: true);
            return new DeferredBodyAction<TriggerFlowResponse>(() =>
            {
                var apiCallPath = "/flows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["flow"] = ExpressionConverter.ConvertO(bodyflowID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvoiceInput
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
    public enum bodylanguageInput
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
    public enum bodychimeInput
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
    public enum bodymediaScalingInput
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
    public enum bodymediaAlignmentInput
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

    public class TriggerFlowResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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