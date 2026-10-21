//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescomputervision
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicescomputervisionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DetectResponse> DetectObjects(Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<DetectResponse>(() =>
            {
                var apiCallPath = "/vision/v2.0/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<DetectResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<AreaOfInterestResponse> GetAreaOfInterest(Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<AreaOfInterestResponse>(() =>
            {
                var apiCallPath = "/vision/v2.0/areaOfInterest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<AreaOfInterestResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<AnalyzeResponse> AnalyzeImage(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<languageInput>> language = null, Expression<Func<object>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<AnalyzeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/analyze", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Queries["visualFeatures"] = Convert.ToString("Tags,Description,Categories");
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<AnalyzeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImage(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<double>> maxCandidates = null, Expression<Func<languageInput>> language = null, Expression<Func<object>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_maxCandidates = WorkflowExpression.Compile(maxCandidates, nameof(maxCandidates), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<DescribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/describe", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(__workflow_maxCandidates);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<DescribeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageContent(Expression<Func<string>> subdomainName, Expression<Func<double>> maxCandidates = null, Expression<Func<languageInput>> language = null, Expression<Func<string>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_maxCandidates = WorkflowExpression.Compile(maxCandidates, nameof(maxCandidates), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<DescribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/describeImageContent", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(__workflow_maxCandidates);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<DescribeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageURL(Expression<Func<string>> subdomainName, Expression<Func<double>> maxCandidates = null, Expression<Func<languageInput>> language = null, Expression<Func<string>> imageURLimageURL = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_maxCandidates = WorkflowExpression.Compile(maxCandidates, nameof(maxCandidates), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_imageURLimageURL = WorkflowExpression.Compile(imageURLimageURL, nameof(imageURLimageURL), required: false);
            return new DeferredBodyAction<DescribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/describeImageURL", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(__workflow_maxCandidates);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                var imageURL = new JObject();
                var imageURLpropCount = 0;
                if (__workflow_imageURLimageURL != null)
                {
                    imageURL["url"] = ExpressionConverter.ConvertO(__workflow_imageURLimageURL);
                    imageURLpropCount++;
                }

                if (imageURLpropCount > 0)
                {
                    callPayload.Body = imageURL;
                }

                return new ApiConnectionAction<DescribeResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<string> GetThumbnail(Expression<Func<string>> subdomainName, Expression<Func<double>> width, Expression<Func<double>> height, Expression<Func<formatInput>> format, Expression<Func<bool>> smartCropping = null, Expression<Func<object>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: true);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_smartCropping = WorkflowExpression.Compile(smartCropping, nameof(smartCropping), required: false);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/generateThumbnail", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                callPayload.Queries["smartCropping"] = Convert.ToString(true);
                if (__workflow_smartCropping != null)
                    callPayload.Queries["smartCropping"] = ExpressionConverter.Convert(__workflow_smartCropping);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<OCRJsonResponse> OCR(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<OCRJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/ocr", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("unk");
                callPayload.Queries["detectOrientation"] = Convert.ToString(true);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<OCRJsonResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<OCRTextResponse> OCRText(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<OCRTextResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/ocrtext", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("unk");
                callPayload.Queries["detectOrientation"] = Convert.ToString(true);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<OCRTextResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DomainModelResponse> RecognizeDomainSpecificContent(Expression<Func<string>> subdomainName, Expression<Func<modelInput>> model, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<DomainModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/models/{1}/analyze", __workflow_subdomainName.WithUrlEncoding(2), __workflow_model.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<DomainModelResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<TagResponse> TagImage(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var __workflow_subdomainName = WorkflowExpression.Compile(subdomainName, nameof(subdomainName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<TagResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/subdomain/{0}/vision/v2.0/tag", __workflow_subdomainName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<TagResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class CognitiveservicescomputervisionTriggers([ConnectionName] string connectionId)
    {
    }

    public class DetectResponse
    {
        [JsonProperty("objects")]
        public DetectResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class DetectResponseObjectsTypeItem
    {
        [JsonProperty("rectangle")]
        public JToken BoundingBox { get; set; }

        [JsonProperty("confidence")]
        public double ObjectConfidenceScore { get; set; }

        [JsonProperty("object")]
        public string ObjectName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "Image Content")]
        ImageContent,
        [EnumMember(Value = "Image URL")]
        ImageURL
    }

    public class AreaOfInterestResponse
    {
        [JsonProperty("areaOfInterest")]
        public JToken AreaOfInterest { get; set; }
    }

    public class AnalyzeResponse
    {
        [JsonProperty("categories")]
        public AnalyzeResponseCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("description")]
        public AnalyzeResponseDescriptionType Description { get; set; }

        [JsonProperty("tags")]
        public AnalyzeResponseTagsTypeItem[] Tags { get; set; }
    }

    public class AnalyzeResponseCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string CategoryName { get; set; }

        [JsonProperty("score")]
        public double CategoryConfidenceScore { get; set; }
    }

    public class AnalyzeResponseDescriptionType
    {
        [JsonProperty("captions")]
        public AnalyzeResponseDescriptionTypeCaptionsTypeItem[] Captions { get; set; }

        [JsonProperty("tags")]
        public string[] TagNames { get; set; }
    }

    public class AnalyzeResponseDescriptionTypeCaptionsTypeItem
    {
        [JsonProperty("confidence")]
        public double CaptionConfidenceScore { get; set; }

        [JsonProperty("text")]
        public string CaptionText { get; set; }
    }

    public class AnalyzeResponseTagsTypeItem
    {
        [JsonProperty("confidence")]
        public double TagConfidenceScore { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum languageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "zh")]
        Zh
    }

    public class DescribeResponse
    {
        [JsonProperty("description")]
        public DescribeResponseDescriptionType Description { get; set; }
    }

    public class DescribeResponseDescriptionType
    {
        [JsonProperty("captions")]
        public DescribeResponseDescriptionTypeCaptionsTypeItem[] Captions { get; set; }

        [JsonProperty("tags")]
        public string[] TagNames { get; set; }
    }

    public class DescribeResponseDescriptionTypeCaptionsTypeItem
    {
        [JsonProperty("confidence")]
        public double CaptionConfidenceScore { get; set; }

        [JsonProperty("text")]
        public string CaptionText { get; set; }
    }

    public class OCRJsonResponse
    {
        [JsonProperty("language")]
        public string TextLanguage { get; set; }

        [JsonProperty("regions")]
        public JToken[] RegionsArray { get; set; }
    }

    public class OCRTextResponse
    {
        [JsonProperty("text")]
        public string DetectedText { get; set; }
    }

    public class DomainModelResponse
    {
        [JsonProperty("result")]
        public DomainModelResponseResultType Result { get; set; }
    }

    public class DomainModelResponseResultType
    {
        [JsonProperty("celebrities")]
        public DomainModelResponseResultTypeCelebritiesTypeItem[] Celebrities { get; set; }

        [JsonProperty("landmarks")]
        public DomainModelResponseResultTypeLandmarksTypeItem[] Landmarks { get; set; }
    }

    public class DomainModelResponseResultTypeCelebritiesTypeItem
    {
        [JsonProperty("confidence")]
        public double CelebrityConfidence { get; set; }

        [JsonProperty("name")]
        public string CelebrityName { get; set; }
    }

    public class DomainModelResponseResultTypeLandmarksTypeItem
    {
        [JsonProperty("confidence")]
        public double LandmarkConfidence { get; set; }

        [JsonProperty("name")]
        public string LandmarkName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modelInput
    {
        [EnumMember(Value = "celebrities")]
        Celebrities,
        [EnumMember(Value = "landmarks")]
        Landmarks
    }

    public class TagResponse
    {
        [JsonProperty("tags")]
        public TagResponseTagsTypeItem[] Tags { get; set; }
    }

    public class TagResponseTagsTypeItem
    {
        [JsonProperty("confidence")]
        public double TagConfidenceScore { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescomputervision;

    public partial class WorkflowManagedActions
    {
        public CognitiveservicescomputervisionActions Cognitiveservicescomputervision(string connectionId) => new CognitiveservicescomputervisionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitiveservicescomputervisionTriggers Cognitiveservicescomputervision(string connectionId) => new CognitiveservicescomputervisionTriggers(connectionId);
    }
}
