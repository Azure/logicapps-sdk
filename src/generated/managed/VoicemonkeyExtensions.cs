//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voicemonkey
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoicemonkeyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        public IBodyWorkflowAction<MakeAnnouncementResponse> MakeAnnouncement(Expression<Func<string>> bodydeviceID, Expression<Func<string>> bodytext = null, Expression<Func<bodyvoiceInput>> bodyvoice = null, Expression<Func<bodylanguageInput>> bodylanguage = null, Expression<Func<bodychimeInput>> bodychime = null, Expression<Func<string>> bodyaudio = null, Expression<Func<string>> bodybackgroundAudio = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bool>> bodynoBackground = null, Expression<Func<string>> bodyimage = null, Expression<Func<int>> bodymediaWidth = null, Expression<Func<int>> bodymediaHeight = null, Expression<Func<bodymediaScalingInput>> bodymediaScaling = null, Expression<Func<bodymediaAlignmentInput>> bodymediaAlignment = null, Expression<Func<int>> bodymediaRadius = null, Expression<Func<string>> bodyvideo = null, Expression<Func<int>> bodyvideoRepeat = null, Expression<Func<string>> bodyechoDotWithClockDisplay = null)
        {
            var apiCallPath = "/announcement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["device"] = CSharpExpressionConverter.ConvertToken(bodydeviceID);
            if (bodytext != null)
            {
                body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
            }

            if (bodyvoice != null)
            {
                body["voice"] = CSharpExpressionConverter.Convert(bodyvoice);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = CSharpExpressionConverter.Convert(bodylanguage);
                bodypropCount++;
            }

            if (bodychime != null)
            {
                body["chime"] = CSharpExpressionConverter.Convert(bodychime);
                bodypropCount++;
            }

            if (bodyaudio != null)
            {
                body["audio"] = CSharpExpressionConverter.ConvertToken(bodyaudio);
                bodypropCount++;
            }

            if (bodybackgroundAudio != null)
            {
                body["background_audio"] = CSharpExpressionConverter.ConvertToken(bodybackgroundAudio);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = CSharpExpressionConverter.ConvertToken(bodywebsite);
                bodypropCount++;
            }

            if (bodynoBackground != null)
            {
                body["no_bg"] = CSharpExpressionConverter.ConvertToken(bodynoBackground);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = CSharpExpressionConverter.ConvertToken(bodyimage);
                bodypropCount++;
            }

            if (bodymediaWidth != null)
            {
                body["media_width"] = CSharpExpressionConverter.ConvertToken(bodymediaWidth);
                bodypropCount++;
            }

            if (bodymediaHeight != null)
            {
                body["media_height"] = CSharpExpressionConverter.ConvertToken(bodymediaHeight);
                bodypropCount++;
            }

            if (bodymediaScaling != null)
            {
                body["media_scaling"] = CSharpExpressionConverter.Convert(bodymediaScaling);
                bodypropCount++;
            }

            if (bodymediaAlignment != null)
            {
                body["media_align"] = CSharpExpressionConverter.Convert(bodymediaAlignment);
                bodypropCount++;
            }

            if (bodymediaRadius != null)
            {
                body["media_radius"] = CSharpExpressionConverter.ConvertToken(bodymediaRadius);
                bodypropCount++;
            }

            if (bodyvideo != null)
            {
                body["video"] = CSharpExpressionConverter.ConvertToken(bodyvideo);
                bodypropCount++;
            }

            if (bodyvideoRepeat != null)
            {
                body["video_repeat"] = CSharpExpressionConverter.ConvertToken(bodyvideoRepeat);
                bodypropCount++;
            }

            if (bodyechoDotWithClockDisplay != null)
            {
                body["character_display"] = CSharpExpressionConverter.ConvertToken(bodyechoDotWithClockDisplay);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MakeAnnouncementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        public IBodyWorkflowAction<TriggerRoutineResponse> TriggerRoutine(Expression<Func<string>> bodydeviceID)
        {
            var apiCallPath = "/trigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["device"] = CSharpExpressionConverter.ConvertToken(bodydeviceID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TriggerRoutineResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voicemonkey")]
        public IBodyWorkflowAction<TriggerFlowResponse> TriggerFlow(Expression<Func<int>> bodyflowID)
        {
            var apiCallPath = "/flows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["flow"] = CSharpExpressionConverter.ConvertToken(bodyflowID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TriggerFlowResponse>(callPayload);
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