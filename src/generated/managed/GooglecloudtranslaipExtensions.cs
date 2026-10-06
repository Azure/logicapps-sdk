//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlecloudtranslaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglecloudtranslaipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        [WorkflowExpressionFactory(nameof(__BuildTextTranslate))]
        public IBodyWorkflowAction<TextTranslateResponse> TextTranslate([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> target, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> model = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TextTranslateResponse> __BuildTextTranslate(WorkflowExpression<string> q, WorkflowExpression<string> target, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> source = null, WorkflowExpression<string> model = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(target, nameof(target), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(model, nameof(model), required: false);
            return new DeferredBodyAction<TextTranslateResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageDetect))]
        public IBodyWorkflowAction<LanguageDetectResponse> LanguageDetect([WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageDetectResponse> __BuildLanguageDetect(WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<LanguageDetectResponse>(() =>
            {
                var apiCallPath = "/language/translate/v2/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<LanguageDetectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        [WorkflowExpressionFactory(nameof(__BuildLanguageGet))]
        public IBodyWorkflowAction<LanguageGetResponse> LanguageGet([WorkflowExpression] Func<string> target = null, [WorkflowExpression] Func<string> model = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecloudtranslaip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LanguageGetResponse> __BuildLanguageGet(WorkflowExpression<string> target = null, WorkflowExpression<string> model = null)
        {
            WorkflowExpression.Validate(target, nameof(target), required: false);
            WorkflowExpression.Validate(model, nameof(model), required: false);
            return new DeferredBodyAction<LanguageGetResponse>(() =>
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
            });
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