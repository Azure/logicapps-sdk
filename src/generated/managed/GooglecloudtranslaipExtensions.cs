//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Googlecloudtranslaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglecloudtranslaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        public IBodyWorkflowAction<TextTranslateResponse> TextTranslate(Expression<Func<string>> q, Expression<Func<string>> target, Expression<Func<formatInput>> format = null, Expression<Func<string>> source = null, Expression<Func<string>> model = null)
        {
            var apiCallPath = "/language/translate/v2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["target"] = ExpressionConverter.Convert(target);
            callPayload.Queries["format"] = Convert.ToString("text");
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (source != null)
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            callPayload.Queries["model"] = Convert.ToString("base");
            if (model != null)
                callPayload.Queries["model"] = ExpressionConverter.Convert(model);
            return new ApiConnectionAction<TextTranslateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        public IBodyWorkflowAction<LanguageDetectResponse> LanguageDetect(Expression<Func<string>> q)
        {
            var apiCallPath = "/language/translate/v2/detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<LanguageDetectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        public IBodyWorkflowAction<LanguageGetResponse> LanguageGet(Expression<Func<string>> target = null, Expression<Func<string>> model = null)
        {
            var apiCallPath = "/language/translate/v2/languages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (target != null)
                callPayload.Queries["target"] = ExpressionConverter.Convert(target);
            callPayload.Queries["model"] = Convert.ToString("nmt");
            if (model != null)
                callPayload.Queries["model"] = ExpressionConverter.Convert(model);
            return new ApiConnectionAction<LanguageGetResponse>(callPayload);
        }
    }

    public class GooglecloudtranslaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TextTranslateResponse
    {
        [JsonProperty("data")]
        public TextTranslateResponseDataType Data { get; set; }
    }

    public class TextTranslateResponseDataType
    {
        [JsonProperty("translations")]
        public TextTranslateResponseDataTypeTranslationsTypeItem[] Translations { get; set; }
    }

    public class TextTranslateResponseDataTypeTranslationsTypeItem
    {
        [JsonProperty("translatedText")]
        public string TranslatedText { get; set; }

        [JsonProperty("detectedSourceLanguage")]
        public string DetectedSourceLanguage { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }
    }

    public enum formatInput
    {
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    public class LanguageDetectResponse
    {
        [JsonProperty("data")]
        public LanguageDetectResponseDataType Data { get; set; }
    }

    public class LanguageDetectResponseDataType
    {
        [JsonProperty("detections")]
        public LanguageDetectResponseDataTypeDetectionsTypeItemItem[][] Detections { get; set; }
    }

    public class LanguageDetectResponseDataTypeDetectionsTypeItemItem
    {
        [JsonProperty("isReliable")]
        public bool IsReliable { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class LanguageGetResponse
    {
        [JsonProperty("data")]
        public LanguageGetResponseDataType Data { get; set; }
    }

    public class LanguageGetResponseDataType
    {
        [JsonProperty("languages")]
        public LanguageGetResponseDataTypeLanguagesTypeItem[] Languages { get; set; }
    }

    public class LanguageGetResponseDataTypeLanguagesTypeItem
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Googlecloudtranslaip;

    public partial class WorkflowManagedActions
    {
        public GooglecloudtranslaipActions Googlecloudtranslaip(string connectionId) => new GooglecloudtranslaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglecloudtranslaipTriggers Googlecloudtranslaip(string connectionId) => new GooglecloudtranslaipTriggers(connectionId);
    }
}