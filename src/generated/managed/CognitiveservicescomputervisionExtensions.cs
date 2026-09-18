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
        public IBodyWorkflowAction<DetectResponse> DetectObjects([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/vision/v2.0/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<DetectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<AreaOfInterestResponse> GetAreaOfInterest([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/vision/v2.0/areaOfInterest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<AreaOfInterestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<AnalyzeResponse> AnalyzeImage([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/analyze", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                callPayload.Queries["visualFeatures"] = Convert.ToString("Tags,Description,Categories");
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<AnalyzeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImage([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<double> maxCandidates = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(maxCandidates, nameof(maxCandidates), required: false);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/describe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = SourceExpressionConverter.ConvertO(maxCandidates);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<DescribeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageContent([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<double> maxCandidates = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(maxCandidates, nameof(maxCandidates), required: false);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/describeImageContent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = SourceExpressionConverter.ConvertO(maxCandidates);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<DescribeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DescribeResponse> DescribeImageURL([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<double> maxCandidates = null, [WorkflowExpression] Func<languageInput> language = null, [WorkflowExpression] Func<string> imageURLimageURL = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(maxCandidates, nameof(maxCandidates), required: false);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(imageURLimageURL, nameof(imageURLimageURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/describeImageURL", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (maxCandidates != null)
                    callPayload.Queries["maxCandidates"] = SourceExpressionConverter.ConvertO(maxCandidates);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                var imageURL = new JObject();
                var imageURLpropCount = 0;
                if (imageURLimageURL != null)
                {
                    imageURL["url"] = SourceExpressionConverter.ConvertToken(imageURLimageURL);
                    imageURLpropCount++;
                }

                if (imageURLpropCount > 0)
                {
                    callPayload.Body = imageURL;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DescribeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<string> GetThumbnail([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<double> width, [WorkflowExpression] Func<double> height, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> smartCropping = null, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(width, nameof(width), required: true);
            SourceExpression.Validate(height, nameof(height), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(smartCropping, nameof(smartCropping), required: false);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/generateThumbnail", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["width"] = SourceExpressionConverter.ConvertO(width);
                callPayload.Queries["height"] = SourceExpressionConverter.ConvertO(height);
                callPayload.Queries["smartCropping"] = Convert.ToString(true);
                if (smartCropping != null)
                    callPayload.Queries["smartCropping"] = SourceExpressionConverter.ConvertO(smartCropping);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<OCRJsonResponse> OCR([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/ocr", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("unk");
                callPayload.Queries["detectOrientation"] = Convert.ToString(true);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<OCRJsonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<OCRTextResponse> OCRText([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/ocrtext", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("unk");
                callPayload.Queries["detectOrientation"] = Convert.ToString(true);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<OCRTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<DomainModelResponse> RecognizeDomainSpecificContent([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<modelInput> model, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(model, nameof(model), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/models/{1}/analyze", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(model, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<DomainModelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescomputervision")]
        public IBodyWorkflowAction<TagResponse> TagImage([WorkflowExpression] Func<string> subdomainName, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(subdomainName, nameof(subdomainName), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/subdomain/{0}/vision/v2.0/tag", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subdomainName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<TagResponse>(BuildSourceInput);
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