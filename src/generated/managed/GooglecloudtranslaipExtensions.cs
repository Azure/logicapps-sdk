//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlecloudtranslaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglecloudtranslaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        public IBodyWorkflowAction<TextTranslateResponse> TextTranslate([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> target, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> model = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/language/translate/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["target"] = SourceExpressionConverter.ConvertO(target);
                callPayload.Queries["format"] = Convert.ToString("text");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["model"] = Convert.ToString("base");
                if (model != null)
                    callPayload.Queries["model"] = SourceExpressionConverter.ConvertO(model);
                return callPayload;
            }

            return new ApiConnectionAction<TextTranslateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        public IBodyWorkflowAction<LanguageDetectResponse> LanguageDetect([WorkflowExpression] Func<string> q)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/language/translate/v2/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageDetectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        public IBodyWorkflowAction<LanguageGetResponse> LanguageGet([WorkflowExpression] Func<string> target = null, [WorkflowExpression] Func<string> model = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/language/translate/v2/languages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (target != null)
                    callPayload.Queries["target"] = SourceExpressionConverter.ConvertO(target);
                callPayload.Queries["model"] = Convert.ToString("nmt");
                if (model != null)
                    callPayload.Queries["model"] = SourceExpressionConverter.ConvertO(model);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageGetResponse>(BuildSourceInput);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlecloudtranslaip;

    public partial class WorkflowManagedActions
    {
        public GooglecloudtranslaipActions Googlecloudtranslaip(string connectionId) => new GooglecloudtranslaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglecloudtranslaipTriggers Googlecloudtranslaip(string connectionId) => new GooglecloudtranslaipTriggers(connectionId);
    }
}