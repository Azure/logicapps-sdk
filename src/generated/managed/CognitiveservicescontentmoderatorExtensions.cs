//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescontentmoderator
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicescontentmoderatorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<EvaluateImageResponse> EvaluateImage([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contentmoderator/moderate/v1.0/ProcessImage/Evaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<EvaluateImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob([WorkflowExpression] Func<string> teamName, [WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> contentId, [WorkflowExpression] Func<string> workflowName, [WorkflowExpression] Func<string> contentcontentValue, [WorkflowExpression] Func<string> callBackEndpoint = null)
        {
            SourceExpression.Validate(teamName, nameof(teamName), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(contentId, nameof(contentId), required: true);
            SourceExpression.Validate(workflowName, nameof(workflowName), required: true);
            SourceExpression.Validate(contentcontentValue, nameof(contentcontentValue), required: true);
            SourceExpression.Validate(callBackEndpoint, nameof(callBackEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contentmoderator/review/v1.0/teams/{0}/jobs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ContentType"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Queries["ContentId"] = SourceExpressionConverter.ConvertO(contentId);
                callPayload.Queries["WorkflowName"] = SourceExpressionConverter.ConvertO(workflowName);
                if (callBackEndpoint != null)
                    callPayload.Queries["CallBackEndpoint"] = SourceExpressionConverter.ConvertO(callBackEndpoint);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["ContentValue"] = SourceExpressionConverter.ConvertToken(contentcontentValue);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateJobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<OCRResponse> OCR([WorkflowExpression] Func<string> language, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(language, nameof(language), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contentmoderator/moderate/v1.0/ProcessImage/OCR";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<OCRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<ScreenTextResponse> ScreenText([WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> autocorrect = null, [WorkflowExpression] Func<bool> pII = null, [WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<bool> classify = null, [WorkflowExpression] Func<string> textContent = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(autocorrect, nameof(autocorrect), required: false);
            SourceExpression.Validate(pII, nameof(pII), required: false);
            SourceExpression.Validate(listId, nameof(listId), required: false);
            SourceExpression.Validate(classify, nameof(classify), required: false);
            SourceExpression.Validate(textContent, nameof(textContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contentmoderator/moderate/v1.0/ProcessText/Screen/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (autocorrect != null)
                    callPayload.Queries["autocorrect"] = SourceExpressionConverter.ConvertO(autocorrect);
                if (pII != null)
                    callPayload.Queries["PII"] = SourceExpressionConverter.ConvertO(pII);
                if (listId != null)
                    callPayload.Queries["listId"] = SourceExpressionConverter.ConvertO(listId);
                if (classify != null)
                    callPayload.Queries["classify"] = SourceExpressionConverter.ConvertO(classify);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(textContent);
                return callPayload;
            }

            return new ApiConnectionAction<ScreenTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<FindFacesResponse> FindFaces([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contentmoderator/moderate/v1.0/ProcessImage/FindFaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<FindFacesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<DetectLanguageResponse> DetectLanguage([WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> textContent = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(textContent, nameof(textContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contentmoderator/moderate/v1.0/ProcessText/DetectLanguage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(textContent);
                return callPayload;
            }

            return new ApiConnectionAction<DetectLanguageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<MatchImageResponse> MatchImage([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<object> image = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(listId, nameof(listId), required: false);
            SourceExpression.Validate(image, nameof(image), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contentmoderator/moderate/v1.0/ProcessImage/Match";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["listId"] = SourceExpressionConverter.ConvertO(listId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<MatchImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescontentmoderator")]
        public IBodyWorkflowAction<string[]> CreateReviews([WorkflowExpression] Func<string> teamName, [WorkflowExpression] Func<string> subTeam = null, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(teamName, nameof(teamName), required: true);
            SourceExpression.Validate(subTeam, nameof(subTeam), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contentmoderator/review/v1.0/teams/{0}/reviews", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (subTeam != null)
                    callPayload.Queries["subTeam"] = SourceExpressionConverter.ConvertO(subTeam);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }
    }

    public class CognitiveservicescontentmoderatorTriggers([ConnectionName] string connectionId)
    {
    }

    public class EvaluateImageResponse
    {
        public double AdultClassificationScore { get; set; }
        public bool IsImageAdultClassified { get; set; }
        public double RacyClassificationScore { get; set; }
        public bool IsImageRacyClassified { get; set; }
        public string TrackingId { get; set; }
    }

    public enum formatInput
    {
        [EnumMember(Value = "Image Content")]
        ImageContent,
        [EnumMember(Value = "Image URL")]
        ImageURL
    }

    public class CreateJobResponse
    {
        public string JobId { get; set; }
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "text/plain")]
        TextPlain,
        [EnumMember(Value = "text/html")]
        TextHtml,
        [EnumMember(Value = "text/xml")]
        TextXml,
        [EnumMember(Value = "text/markdown")]
        TextMarkdown
    }

    public class OCRResponse
    {
        public string TrackingId { get; set; }
        public string CacheId { get; set; }

        [JsonProperty("Language")]
        public string TextLanguage { get; set; }

        [JsonProperty("Text")]
        public string DetectedText { get; set; }

        [JsonProperty("Candidates")]
        public OCRResponseDetectedCandidatesTypeItem[] DetectedCandidates { get; set; }
    }

    public class OCRResponseDetectedCandidatesTypeItem
    {
        [JsonProperty("Text")]
        public string DetectedTextContentCandidates { get; set; }

        [JsonProperty("Confidence")]
        public double ConfidenceScore { get; set; }
    }

    public class ScreenTextResponse
    {
        public string OriginalText { get; set; }
        public string NormalizedText { get; set; }
        public string AutoCorrectedText { get; set; }
        public string[] Misrepresentation { get; set; }

        [JsonProperty("PII")]
        public ScreenTextResponsePersonalIdentifiableInformationType PersonalIdentifiableInformation { get; set; }

        [JsonProperty("Classification")]
        public ScreenTextResponseClassificationDetailsType ClassificationDetails { get; set; }

        [JsonProperty("Language")]
        public string TextLanguage { get; set; }

        [JsonProperty("Terms")]
        public ScreenTextResponseDetectedProfanityTermsTypeItem[] DetectedProfanityTerms { get; set; }
        public string TrackingId { get; set; }
    }

    public class ScreenTextResponsePersonalIdentifiableInformationType
    {
        [JsonProperty("Email")]
        public ScreenTextResponsePersonalIdentifiableInformationTypeDetectedEmailTypeItem[] DetectedEmail { get; set; }

        [JsonProperty("SSN")]
        public ScreenTextResponsePersonalIdentifiableInformationTypeDetectedSSNTypeItem[] DetectedSSN { get; set; }

        [JsonProperty("IPA")]
        public ScreenTextResponsePersonalIdentifiableInformationTypeDetectedIPAddressTypeItem[] DetectedIPAddress { get; set; }

        [JsonProperty("Phone")]
        public ScreenTextResponsePersonalIdentifiableInformationTypeDetectedPhoneNumberTypeItem[] DetectedPhoneNumber { get; set; }

        [JsonProperty("Address")]
        public ScreenTextResponsePersonalIdentifiableInformationTypeDetectedAddressTypeItem[] DetectedAddress { get; set; }
    }

    public class ScreenTextResponsePersonalIdentifiableInformationTypeDetectedEmailTypeItem
    {
        [JsonProperty("Detected")]
        public string DetectedEmail { get; set; }

        [JsonProperty("SubType")]
        public string EmailSubtype { get; set; }

        [JsonProperty("Text")]
        public string EmailAddress { get; set; }

        [JsonProperty("Index")]
        public int EmailIndex { get; set; }
    }

    public class ScreenTextResponsePersonalIdentifiableInformationTypeDetectedSSNTypeItem
    {
        [JsonProperty("Text")]
        public string SSN { get; set; }

        [JsonProperty("Index")]
        public int SSNIndex { get; set; }
    }

    public class ScreenTextResponsePersonalIdentifiableInformationTypeDetectedIPAddressTypeItem
    {
        [JsonProperty("SubType")]
        public string IPAddressSubtype { get; set; }

        [JsonProperty("Text")]
        public string IPAddress { get; set; }

        [JsonProperty("Index")]
        public int IPAddressIndex { get; set; }
    }

    public class ScreenTextResponsePersonalIdentifiableInformationTypeDetectedPhoneNumberTypeItem
    {
        [JsonProperty("CountryCode")]
        public string PhoneCountryCode { get; set; }

        [JsonProperty("Text")]
        public string PhoneNumber { get; set; }

        [JsonProperty("Index")]
        public int PhoneIndex { get; set; }
    }

    public class ScreenTextResponsePersonalIdentifiableInformationTypeDetectedAddressTypeItem
    {
        [JsonProperty("Text")]
        public string Address { get; set; }

        [JsonProperty("Index")]
        public int AddressIndex { get; set; }
    }

    public class ScreenTextResponseClassificationDetailsType
    {
        public ScreenTextResponseClassificationDetailsTypeCategory1Type Category1 { get; set; }
        public ScreenTextResponseClassificationDetailsTypeCategory2Type Category2 { get; set; }
        public ScreenTextResponseClassificationDetailsTypeCategory3Type Category3 { get; set; }
        public bool ReviewRecommended { get; set; }
    }

    public class ScreenTextResponseClassificationDetailsTypeCategory1Type
    {
        [JsonProperty("score")]
        public double Category1Score { get; set; }
    }

    public class ScreenTextResponseClassificationDetailsTypeCategory2Type
    {
        [JsonProperty("score")]
        public double Category2Score { get; set; }
    }

    public class ScreenTextResponseClassificationDetailsTypeCategory3Type
    {
        [JsonProperty("score")]
        public double Category3Score { get; set; }
    }

    public class ScreenTextResponseDetectedProfanityTermsTypeItem
    {
        [JsonProperty("Index")]
        public int TermIndex { get; set; }

        [JsonProperty("OriginalIndex")]
        public int TermOriginalIndex { get; set; }

        [JsonProperty("ListId")]
        public int TermsListId { get; set; }

        [JsonProperty("Term")]
        public string DetectedTerm { get; set; }
    }

    public class FindFacesResponse
    {
        public string TrackingId { get; set; }
        public string CacheId { get; set; }

        [JsonProperty("Count")]
        public double FaceCount { get; set; }

        [JsonProperty("Faces")]
        public FindFacesResponseDetectedFacePositionTypeItem[] DetectedFacePosition { get; set; }
    }

    public class FindFacesResponseDetectedFacePositionTypeItem
    {
        [JsonProperty("Bottom")]
        public double BottomLocation { get; set; }

        [JsonProperty("Left")]
        public double LeftLocation { get; set; }

        [JsonProperty("Right")]
        public double RightLocation { get; set; }

        [JsonProperty("Top")]
        public double TopLocation { get; set; }
    }

    public class DetectLanguageResponse
    {
        public string DetectedLanguage { get; set; }
    }

    public class MatchImageResponse
    {
        public string TrackingId { get; set; }
        public string CacheId { get; set; }
        public bool IsMatch { get; set; }
        public MatchImageResponseMatchDetailsType MatchDetails { get; set; }
    }

    public class MatchImageResponseMatchDetailsType
    {
        [JsonProperty("Score")]
        public double MatchDetailsScore { get; set; }

        [JsonProperty("MatchId")]
        public double MatchDetailsMatchId { get; set; }

        [JsonProperty("Source")]
        public string MatchDetailsSource { get; set; }

        [JsonProperty("Tags")]
        public double[] MatchDetailsTags { get; set; }

        [JsonProperty("Label")]
        public string MatchDetailsLabel { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("Type")]
        public bodyInputItemContentTypeType ContentType { get; set; }

        [JsonProperty("Content")]
        public string ReviewContent { get; set; }
        public string ContentId { get; set; }
        public string CallbackEndpoint { get; set; }

        [JsonProperty("Metadata")]
        public bodyInputItemOptionalMetadataTypeItem[] OptionalMetadata { get; set; }
    }

    public enum bodyInputItemContentTypeType
    {
        Image,
        Text
    }

    public class bodyInputItemOptionalMetadataTypeItem
    {
        [JsonProperty("Key")]
        public string KeyParameter { get; set; }

        [JsonProperty("Value")]
        public string ValueParameter { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescontentmoderator;

    public partial class WorkflowManagedActions
    {
        public CognitiveservicescontentmoderatorActions Cognitiveservicescontentmoderator(string connectionId) => new CognitiveservicescontentmoderatorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitiveservicescontentmoderatorTriggers Cognitiveservicescontentmoderator(string connectionId) => new CognitiveservicescontentmoderatorTriggers(connectionId);
    }
}