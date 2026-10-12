//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ibmwatsontexttospeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IbmwatsontexttospeipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsontexttospeip")]
        [WorkflowExpressionFactory(nameof(__BuildSynthesize))]
        public IBodyWorkflowAction<SynthesizeResponse> Synthesize([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<voiceInput> voice = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SynthesizeResponse> __BuildSynthesize(WorkflowExpression<string> bodytext, WorkflowExpression<voiceInput> voice = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(voice, nameof(voice), required: false);
            return new DeferredBodyAction<SynthesizeResponse>(() =>
            {
                var apiCallPath = "/v1/synthesize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["voice"] = Convert.ToString("en-US_MichaelV3Voice");
                if (voice != null)
                    callPayload.Queries["voice"] = ExpressionConverter.Convert(voice);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SynthesizeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsontexttospeip")]
        public IBodyWorkflowAction<ListVoicesResponse> ListVoices()
        {
            var apiCallPath = "/v1/voices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListVoicesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsontexttospeip")]
        [WorkflowExpressionFactory(nameof(__BuildPronunciation))]
        public IBodyWorkflowAction<PronunciationResponse> Pronunciation([WorkflowExpression] Func<voiceInput> voice = null, [WorkflowExpression] Func<string> text = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PronunciationResponse> __BuildPronunciation(WorkflowExpression<voiceInput> voice = null, WorkflowExpression<string> text = null)
        {
            WorkflowExpression.Validate(voice, nameof(voice), required: false);
            WorkflowExpression.Validate(text, nameof(text), required: false);
            return new DeferredBodyAction<PronunciationResponse>(() =>
            {
                var apiCallPath = "/v1/pronunciation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["voice"] = Convert.ToString("en-US_MichaelV3Voice");
                if (voice != null)
                    callPayload.Queries["voice"] = ExpressionConverter.Convert(voice);
                if (text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                return new ApiConnectionAction<PronunciationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsontexttospeip")]
        [WorkflowExpressionFactory(nameof(__BuildGetVoice))]
        public IBodyWorkflowAction<GetVoiceResponse> GetVoice([WorkflowExpression] Func<string> voice)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetVoiceResponse> __BuildGetVoice(WorkflowExpression<string> voice)
        {
            WorkflowExpression.Validate(voice, nameof(voice), required: true);
            return new DeferredBodyAction<GetVoiceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/voices/{0}", ExpressionConverter.ConvertWithUrlEncoding(voice, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetVoiceResponse>(callPayload);
            });
        }
    }

    public class IbmwatsontexttospeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SynthesizeResponse
    {
        [JsonProperty("base64")]
        public string Base64 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum voiceInput
    {
        [EnumMember(Value = "ar-MS_OmarVoice")]
        ArMSOmarVoice,
        [EnumMember(Value = "cs-CZ_AlenaVoice")]
        CsCZAlenaVoice,
        [EnumMember(Value = "de-DE_BirgitV3Voice")]
        DeDEBirgitV3Voice,
        [EnumMember(Value = "de-DE_DieterV3Voice")]
        DeDEDieterV3Voice,
        [EnumMember(Value = "de-DE_ErikaV3Voice")]
        DeDEErikaV3Voice,
        [EnumMember(Value = "en-AU_CraigVoice")]
        EnAUCraigVoice,
        [EnumMember(Value = "en-AU_MadisonVoice")]
        EnAUMadisonVoice,
        [EnumMember(Value = "en-AU_SteveVoice")]
        EnAUSteveVoice,
        [EnumMember(Value = "en-GB_CharlotteV3Voice")]
        EnGBCharlotteV3Voice,
        [EnumMember(Value = "en-GB_JamesV3Voice")]
        EnGBJamesV3Voice,
        [EnumMember(Value = "en-GB_KateV3Voice")]
        EnGBKateV3Voice,
        [EnumMember(Value = "en-US_AllisonExpressive")]
        EnUSAllisonExpressive,
        [EnumMember(Value = "en-US_AllisonV3Voice")]
        EnUSAllisonV3Voice,
        [EnumMember(Value = "en-US_EmilyV3Voice")]
        EnUSEmilyV3Voice,
        [EnumMember(Value = "en-US_EmmaExpressive")]
        EnUSEmmaExpressive,
        [EnumMember(Value = "en-US_HenryV3Voice")]
        EnUSHenryV3Voice,
        [EnumMember(Value = "en-US_KevinV3Voice")]
        EnUSKevinV3Voice,
        [EnumMember(Value = "en-US_LisaExpressive")]
        EnUSLisaExpressive,
        [EnumMember(Value = "en-US_LisaV3Voice")]
        EnUSLisaV3Voice,
        [EnumMember(Value = "en-US_MichaelExpressive")]
        EnUSMichaelExpressive,
        [EnumMember(Value = "en-US_MichaelV3Voice")]
        EnUSMichaelV3Voice,
        [EnumMember(Value = "en-US_OliviaV3Voice")]
        EnUSOliviaV3Voice,
        [EnumMember(Value = "es-ES_EnriqueV3Voice")]
        EsESEnriqueV3Voice,
        [EnumMember(Value = "es-ES_LauraV3Voice")]
        EsESLauraV3Voice,
        [EnumMember(Value = "es-LA_SofiaV3Voice")]
        EsLASofiaV3Voice,
        [EnumMember(Value = "es-US_SofiaV3Voice")]
        EsUSSofiaV3Voice,
        [EnumMember(Value = "fr-CA_LouiseV3Voice")]
        FrCALouiseV3Voice,
        [EnumMember(Value = "fr-FR_NicolasV3Voice")]
        FrFRNicolasV3Voice,
        [EnumMember(Value = "fr-FR_ReneeV3Voice")]
        FrFRReneeV3Voice,
        [EnumMember(Value = "it-IT_FrancescaV3Voice")]
        ItITFrancescaV3Voice,
        [EnumMember(Value = "ja-JP_EmiV3Voice")]
        JaJPEmiV3Voice,
        [EnumMember(Value = "ko-KR_HyunjunVoice")]
        KoKRHyunjunVoice,
        [EnumMember(Value = "ko-KR_SiWooVoice")]
        KoKRSiWooVoice,
        [EnumMember(Value = "ko-KR_YoungmiVoice")]
        KoKRYoungmiVoice,
        [EnumMember(Value = "ko-KR_YunaVoice")]
        KoKRYunaVoice,
        [EnumMember(Value = "nl-BE_AdeleVoice")]
        NlBEAdeleVoice,
        [EnumMember(Value = "nl-BE_BramVoice")]
        NlBEBramVoice,
        [EnumMember(Value = "nl-NL_EmmaVoice")]
        NlNLEmmaVoice,
        [EnumMember(Value = "nl-NL_LiamVoice")]
        NlNLLiamVoice,
        [EnumMember(Value = "pt-BR_IsabelaV3Voice")]
        PtBRIsabelaV3Voice,
        [EnumMember(Value = "sv-SE_IngridVoice")]
        SvSEIngridVoice,
        [EnumMember(Value = "zh-CN_LiNaVoice")]
        ZhCNLiNaVoice,
        [EnumMember(Value = "zh-CN_WangWeiVoice")]
        ZhCNWangWeiVoice,
        [EnumMember(Value = "zh-CN_ZhangJingVoice")]
        ZhCNZhangJingVoice
    }

    public class ListVoicesResponse
    {
        [JsonProperty("voices")]
        public ListVoicesResponseVoicesTypeItem[] Voices { get; set; }
    }

    public class ListVoicesResponseVoicesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("customizable")]
        public bool Customizable { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("supported_features")]
        public ListVoicesResponseVoicesTypeItemSupportedFeaturesType SupportedFeatures { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ListVoicesResponseVoicesTypeItemSupportedFeaturesType
    {
        [JsonProperty("voice_transformation")]
        public bool VoiceTransformation { get; set; }

        [JsonProperty("custom_pronunciation")]
        public bool CustomPronunciation { get; set; }
    }

    public class PronunciationResponse
    {
        [JsonProperty("pronunciation")]
        public string Pronunciation { get; set; }
    }

    public class GetVoiceResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("customizable")]
        public bool Customizable { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("supported_features")]
        public GetVoiceResponseSupportedFeaturesType SupportedFeatures { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetVoiceResponseSupportedFeaturesType
    {
        [JsonProperty("voice_transformation")]
        public bool VoiceTransformation { get; set; }

        [JsonProperty("custom_pronunciation")]
        public bool CustomPronunciation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ibmwatsontexttospeip;

    public partial class WorkflowManagedActions
    {
        public IbmwatsontexttospeipActions Ibmwatsontexttospeip(string connectionId) => new IbmwatsontexttospeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IbmwatsontexttospeipTriggers Ibmwatsontexttospeip(string connectionId) => new IbmwatsontexttospeipTriggers(connectionId);
    }
}