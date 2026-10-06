//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescomputervision
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicescomputervisionActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildDetectObjects))]
        public IBodyWorkflowAction<DetectResponse> DetectObjects([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetectResponse> __BuildDetectObjects(WorkflowExpression<formatInput> format, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<DetectResponse>(() =>
            {
                var apiCallPath = "/vision/v2.0/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<DetectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildGetAreaOfInterest))]
        public IBodyWorkflowAction<AreaOfInterestResponse> GetAreaOfInterest([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AreaOfInterestResponse> __BuildGetAreaOfInterest(WorkflowExpression<formatInput> format, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<AreaOfInterestResponse>(() =>
            {
                var apiCallPath = "/vision/v2.0/areaOfInterest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<AreaOfInterestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyzeImage))]
        public IBodyWorkflowAction<AnalyzeResponse> AnalyzeImage([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AnalyzeResponse> __BuildAnalyzeImage(WorkflowExpression<string> subdomainName, WorkflowExpression<formatInput> format, WorkflowExpression<languageInput> language = null, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<AnalyzeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/analyze", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                callPayload.Queries["visualFeatures"] = Convert.ToString("Tags,Description,Categories");
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<AnalyzeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildDescribeImage))]
        public IBodyWorkflowAction<DescribeResponse> DescribeImage([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<double> maxCandidates = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DescribeResponse> __BuildDescribeImage(WorkflowExpression<string> subdomainName, WorkflowExpression<formatInput> format, WorkflowExpression<double> maxCandidates = null, WorkflowExpression<languageInput> language = null, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(maxCandidates, nameof(maxCandidates), required: false);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<DescribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/describe", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(maxCandidates);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<DescribeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildDescribeImageContent))]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageContent([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<double> maxCandidates = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DescribeResponse> __BuildDescribeImageContent(WorkflowExpression<string> subdomainName, WorkflowExpression<double> maxCandidates = null, WorkflowExpression<languageInput> language = null, WorkflowExpression<string> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(maxCandidates, nameof(maxCandidates), required: false);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<DescribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/describeImageContent", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = ExpressionConverter.Convert(maxCandidates);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<DescribeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildDescribeImageURL))]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageURL([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<double> maxCandidates = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> imageURLimageURL = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DescribeResponse> __BuildDescribeImageURL(WorkflowExpression<string> subdomainName, WorkflowExpression<double> maxCandidates = null, WorkflowExpression<languageInput> language = null, WorkflowExpression<string> imageURLimageURL = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(maxCandidates, nameof(maxCandidates), required: false);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            WorkflowExpression.Validate(imageURLimageURL, nameof(imageURLimageURL), required: false);
            return new DeferredBodyAction<DescribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/describeImageURL", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildGetThumbnail))]
        public IBodyWorkflowAction<string> GetThumbnail([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<double> width, [WorkflowExpression] Func<double> height, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> smartCropping = null, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetThumbnail(WorkflowExpression<string> subdomainName, WorkflowExpression<double> width, WorkflowExpression<double> height, WorkflowExpression<formatInput> format, WorkflowExpression<bool> smartCropping = null, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(width, nameof(width), required: true);
            WorkflowExpression.Validate(height, nameof(height), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(smartCropping, nameof(smartCropping), required: false);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/generateThumbnail", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildOCR))]
        public IBodyWorkflowAction<OCRJsonResponse> OCR([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OCRJsonResponse> __BuildOCR(WorkflowExpression<string> subdomainName, WorkflowExpression<formatInput> format, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<OCRJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/ocr", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("unk");
                callPayload.Queries["detectOrientation"] = Convert.ToString(true);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<OCRJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildOCRText))]
        public IBodyWorkflowAction<OCRTextResponse> OCRText([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OCRTextResponse> __BuildOCRText(WorkflowExpression<string> subdomainName, WorkflowExpression<formatInput> format, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<OCRTextResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/ocrtext", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("unk");
                callPayload.Queries["detectOrientation"] = Convert.ToString(true);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<OCRTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildRecognizeDomainSpecificContent))]
        public IBodyWorkflowAction<DomainModelResponse> RecognizeDomainSpecificContent([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<modelInput> model, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DomainModelResponse> __BuildRecognizeDomainSpecificContent(WorkflowExpression<string> subdomainName, WorkflowExpression<modelInput> model, WorkflowExpression<formatInput> format, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(model, nameof(model), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<DomainModelResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/models/{1}/analyze", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2), ExpressionConverter.ConvertWithUrlEncoding(model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<DomainModelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [WorkflowExpressionFactory(nameof(__BuildTagImage))]
        public IBodyWorkflowAction<TagResponse> TagImage([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagResponse> __BuildTagImage(WorkflowExpression<string> subdomainName, WorkflowExpression<formatInput> format, WorkflowExpression<object> image = null)
        {
            WorkflowExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<TagResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/tag", ExpressionConverter.ConvertWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<TagResponse>(callPayload);
            });
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