//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescomputervision
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicescomputervisionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DetectResponse> DetectObjects(Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var apiCallPath = "/vision/v2.0/detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<DetectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<AreaOfInterestResponse> GetAreaOfInterest(Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var apiCallPath = "/vision/v2.0/areaOfInterest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<AreaOfInterestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<AnalyzeResponse> AnalyzeImage(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<languageInput>> language = null, Expression<Func<object>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/analyze", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Queries["visualFeatures"] = Convert.ToString("Tags,Description,Categories");
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<AnalyzeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImage(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<double>> maxCandidates = null, Expression<Func<languageInput>> language = null, Expression<Func<object>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/describe", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (maxCandidates != null)
                callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(maxCandidates);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<DescribeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageContent(Expression<Func<string>> subdomainName, Expression<Func<double>> maxCandidates = null, Expression<Func<languageInput>> language = null, Expression<Func<string>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/describeImageContent", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (maxCandidates != null)
                callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(maxCandidates);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<DescribeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageURL(Expression<Func<string>> subdomainName, Expression<Func<double>> maxCandidates = null, Expression<Func<languageInput>> language = null, Expression<Func<string>> imageURLimageURL = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/describeImageURL", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (maxCandidates != null)
                callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(maxCandidates);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            var imageURL = new JObject();
            var imageURLpropCount = 0;
            if (imageURLimageURL != null)
            {
                imageURL["url"] = ExpressionConverter.ConvertO(imageURLimageURL);
                imageURLpropCount++;
            }

            if (imageURLpropCount > 0)
            {
                callPayload.Body = imageURL;
            }

            return new ApiConnectionAction<DescribeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<string> GetThumbnail(Expression<Func<string>> subdomainName, Expression<Func<double>> width, Expression<Func<double>> height, Expression<Func<formatInput>> format, Expression<Func<bool>> smartCropping = null, Expression<Func<object>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/generateThumbnail", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["width"] = ExpressionConverter.Convert(width);
            callPayload.Queries["height"] = ExpressionConverter.Convert(height);
            callPayload.Queries["smartCropping"] = Convert.ToString(true);
            if (smartCropping != null)
                callPayload.Queries["smartCropping"] = ExpressionConverter.Convert(smartCropping);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<OCRJsonResponse> OCR(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/ocr", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["language"] = Convert.ToString("unk");
            callPayload.Queries["detectOrientation"] = Convert.ToString(true);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<OCRJsonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<OCRTextResponse> OCRText(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/ocrtext", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["language"] = Convert.ToString("unk");
            callPayload.Queries["detectOrientation"] = Convert.ToString(true);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<OCRTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DomainModelResponse> RecognizeDomainSpecificContent(Expression<Func<string>> subdomainName, Expression<Func<modelInput>> model, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/models/{1}/analyze", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<DomainModelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<TagResponse> TagImage(Expression<Func<string>> subdomainName, Expression<Func<formatInput>> format, Expression<Func<object>> image = null)
        {
            var apiCallPath = String.Format("/v3/subdomain/{0}/vision/v2.0/tag", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Body = ExpressionConverter.ConvertO(image);
            return new ApiConnectionAction<TagResponse>(callPayload);
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