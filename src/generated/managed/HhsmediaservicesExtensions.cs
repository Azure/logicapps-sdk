//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hhsmediaservices
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HhsmediaservicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<CampaignWrapped> CampaignsGet([WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/campaigns.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<CampaignWrapped> CampaignGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/campaigns/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> CampaignMediaGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/campaigns/{0}/media.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SyndicateMarshallerWrapped> CampaignSyndicateGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> displayMethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/campaigns/{0}/syndicate.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (displayMethod != null)
                    callPayload.Queries["displayMethod"] = SourceExpressionConverter.ConvertO(displayMethod);
                return callPayload;
            }

            return new ApiConnectionAction<SyndicateMarshallerWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<LanguageWrapped> LanguagesGet([WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/languages.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<LanguageWrapped> LanguageGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/languages/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LanguageWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaGet([WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> mediaTypes = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> collectionId = null, [WorkflowExpression] Func<string> nameContains = null, [WorkflowExpression] Func<string> descriptionContains = null, [WorkflowExpression] Func<string> sourceUrl = null, [WorkflowExpression] Func<string> sourceUrlContains = null, [WorkflowExpression] Func<string> customThumbnailUrl = null, [WorkflowExpression] Func<string> customThumbnailUrlContains = null, [WorkflowExpression] Func<string> dateContentAuthored = null, [WorkflowExpression] Func<string> dateContentUpdated = null, [WorkflowExpression] Func<string> dateContentPublished = null, [WorkflowExpression] Func<string> dateContentReviewed = null, [WorkflowExpression] Func<string> dateSyndicationCaptured = null, [WorkflowExpression] Func<string> dateSyndicationUpdated = null, [WorkflowExpression] Func<string> contentAuthoredSinceDate = null, [WorkflowExpression] Func<string> contentAuthoredBeforeDate = null, [WorkflowExpression] Func<string> contentAuthoredInRange = null, [WorkflowExpression] Func<string> contentUpdatedSinceDate = null, [WorkflowExpression] Func<string> contentUpdatedBeforeDate = null, [WorkflowExpression] Func<string> contentUpdatedInRange = null, [WorkflowExpression] Func<string> contentPublishedSinceDate = null, [WorkflowExpression] Func<string> contentPublishedBeforeDate = null, [WorkflowExpression] Func<string> contentPublishedInRange = null, [WorkflowExpression] Func<string> contentReviewedSinceDate = null, [WorkflowExpression] Func<string> contentReviewedBeforeDate = null, [WorkflowExpression] Func<string> contentReviewedInRange = null, [WorkflowExpression] Func<string> syndicationCapturedSinceDate = null, [WorkflowExpression] Func<string> syndicationCapturedBeforeDate = null, [WorkflowExpression] Func<string> syndicationCapturedInRange = null, [WorkflowExpression] Func<string> syndicationUpdatedSinceDate = null, [WorkflowExpression] Func<string> syndicationUpdatedBeforeDate = null, [WorkflowExpression] Func<string> syndicationUpdatedInRange = null, [WorkflowExpression] Func<string> syndicationVisibleSinceDate = null, [WorkflowExpression] Func<string> syndicationVisibleBeforeDate = null, [WorkflowExpression] Func<string> syndicationVisibleInRange = null, [WorkflowExpression] Func<int> languageId = null, [WorkflowExpression] Func<string> languageName = null, [WorkflowExpression] Func<string> languageIsoCode = null, [WorkflowExpression] Func<string> hash = null, [WorkflowExpression] Func<string> hashContains = null, [WorkflowExpression] Func<int> sourceId = null, [WorkflowExpression] Func<string> sourceName = null, [WorkflowExpression] Func<string> sourceNameContains = null, [WorkflowExpression] Func<string> sourceAcronym = null, [WorkflowExpression] Func<string> sourceAcronymContains = null, [WorkflowExpression] Func<string> tagIds = null, [WorkflowExpression] Func<string> restrictToSet = null, [WorkflowExpression] Func<string> createdBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/media.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                if (mediaTypes != null)
                    callPayload.Queries["mediaTypes"] = SourceExpressionConverter.ConvertO(mediaTypes);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (collectionId != null)
                    callPayload.Queries["collectionId"] = SourceExpressionConverter.ConvertO(collectionId);
                if (nameContains != null)
                    callPayload.Queries["nameContains"] = SourceExpressionConverter.ConvertO(nameContains);
                if (descriptionContains != null)
                    callPayload.Queries["descriptionContains"] = SourceExpressionConverter.ConvertO(descriptionContains);
                if (sourceUrl != null)
                    callPayload.Queries["sourceUrl"] = SourceExpressionConverter.ConvertO(sourceUrl);
                if (sourceUrlContains != null)
                    callPayload.Queries["sourceUrlContains"] = SourceExpressionConverter.ConvertO(sourceUrlContains);
                if (customThumbnailUrl != null)
                    callPayload.Queries["customThumbnailUrl"] = SourceExpressionConverter.ConvertO(customThumbnailUrl);
                if (customThumbnailUrlContains != null)
                    callPayload.Queries["customThumbnailUrlContains"] = SourceExpressionConverter.ConvertO(customThumbnailUrlContains);
                if (dateContentAuthored != null)
                    callPayload.Queries["dateContentAuthored"] = SourceExpressionConverter.ConvertO(dateContentAuthored);
                if (dateContentUpdated != null)
                    callPayload.Queries["dateContentUpdated"] = SourceExpressionConverter.ConvertO(dateContentUpdated);
                if (dateContentPublished != null)
                    callPayload.Queries["dateContentPublished"] = SourceExpressionConverter.ConvertO(dateContentPublished);
                if (dateContentReviewed != null)
                    callPayload.Queries["dateContentReviewed"] = SourceExpressionConverter.ConvertO(dateContentReviewed);
                if (dateSyndicationCaptured != null)
                    callPayload.Queries["dateSyndicationCaptured"] = SourceExpressionConverter.ConvertO(dateSyndicationCaptured);
                if (dateSyndicationUpdated != null)
                    callPayload.Queries["dateSyndicationUpdated"] = SourceExpressionConverter.ConvertO(dateSyndicationUpdated);
                if (contentAuthoredSinceDate != null)
                    callPayload.Queries["contentAuthoredSinceDate"] = SourceExpressionConverter.ConvertO(contentAuthoredSinceDate);
                if (contentAuthoredBeforeDate != null)
                    callPayload.Queries["contentAuthoredBeforeDate"] = SourceExpressionConverter.ConvertO(contentAuthoredBeforeDate);
                if (contentAuthoredInRange != null)
                    callPayload.Queries["contentAuthoredInRange"] = SourceExpressionConverter.ConvertO(contentAuthoredInRange);
                if (contentUpdatedSinceDate != null)
                    callPayload.Queries["contentUpdatedSinceDate"] = SourceExpressionConverter.ConvertO(contentUpdatedSinceDate);
                if (contentUpdatedBeforeDate != null)
                    callPayload.Queries["contentUpdatedBeforeDate"] = SourceExpressionConverter.ConvertO(contentUpdatedBeforeDate);
                if (contentUpdatedInRange != null)
                    callPayload.Queries["contentUpdatedInRange"] = SourceExpressionConverter.ConvertO(contentUpdatedInRange);
                if (contentPublishedSinceDate != null)
                    callPayload.Queries["contentPublishedSinceDate"] = SourceExpressionConverter.ConvertO(contentPublishedSinceDate);
                if (contentPublishedBeforeDate != null)
                    callPayload.Queries["contentPublishedBeforeDate"] = SourceExpressionConverter.ConvertO(contentPublishedBeforeDate);
                if (contentPublishedInRange != null)
                    callPayload.Queries["contentPublishedInRange"] = SourceExpressionConverter.ConvertO(contentPublishedInRange);
                if (contentReviewedSinceDate != null)
                    callPayload.Queries["contentReviewedSinceDate"] = SourceExpressionConverter.ConvertO(contentReviewedSinceDate);
                if (contentReviewedBeforeDate != null)
                    callPayload.Queries["contentReviewedBeforeDate"] = SourceExpressionConverter.ConvertO(contentReviewedBeforeDate);
                if (contentReviewedInRange != null)
                    callPayload.Queries["contentReviewedInRange"] = SourceExpressionConverter.ConvertO(contentReviewedInRange);
                if (syndicationCapturedSinceDate != null)
                    callPayload.Queries["syndicationCapturedSinceDate"] = SourceExpressionConverter.ConvertO(syndicationCapturedSinceDate);
                if (syndicationCapturedBeforeDate != null)
                    callPayload.Queries["syndicationCapturedBeforeDate"] = SourceExpressionConverter.ConvertO(syndicationCapturedBeforeDate);
                if (syndicationCapturedInRange != null)
                    callPayload.Queries["syndicationCapturedInRange"] = SourceExpressionConverter.ConvertO(syndicationCapturedInRange);
                if (syndicationUpdatedSinceDate != null)
                    callPayload.Queries["syndicationUpdatedSinceDate"] = SourceExpressionConverter.ConvertO(syndicationUpdatedSinceDate);
                if (syndicationUpdatedBeforeDate != null)
                    callPayload.Queries["syndicationUpdatedBeforeDate"] = SourceExpressionConverter.ConvertO(syndicationUpdatedBeforeDate);
                if (syndicationUpdatedInRange != null)
                    callPayload.Queries["syndicationUpdatedInRange"] = SourceExpressionConverter.ConvertO(syndicationUpdatedInRange);
                if (syndicationVisibleSinceDate != null)
                    callPayload.Queries["syndicationVisibleSinceDate"] = SourceExpressionConverter.ConvertO(syndicationVisibleSinceDate);
                if (syndicationVisibleBeforeDate != null)
                    callPayload.Queries["syndicationVisibleBeforeDate"] = SourceExpressionConverter.ConvertO(syndicationVisibleBeforeDate);
                if (syndicationVisibleInRange != null)
                    callPayload.Queries["syndicationVisibleInRange"] = SourceExpressionConverter.ConvertO(syndicationVisibleInRange);
                if (languageId != null)
                    callPayload.Queries["languageId"] = SourceExpressionConverter.ConvertO(languageId);
                if (languageName != null)
                    callPayload.Queries["languageName"] = SourceExpressionConverter.ConvertO(languageName);
                if (languageIsoCode != null)
                    callPayload.Queries["languageIsoCode"] = SourceExpressionConverter.ConvertO(languageIsoCode);
                if (hash != null)
                    callPayload.Queries["hash"] = SourceExpressionConverter.ConvertO(hash);
                if (hashContains != null)
                    callPayload.Queries["hashContains"] = SourceExpressionConverter.ConvertO(hashContains);
                if (sourceId != null)
                    callPayload.Queries["sourceId"] = SourceExpressionConverter.ConvertO(sourceId);
                if (sourceName != null)
                    callPayload.Queries["sourceName"] = SourceExpressionConverter.ConvertO(sourceName);
                if (sourceNameContains != null)
                    callPayload.Queries["sourceNameContains"] = SourceExpressionConverter.ConvertO(sourceNameContains);
                if (sourceAcronym != null)
                    callPayload.Queries["sourceAcronym"] = SourceExpressionConverter.ConvertO(sourceAcronym);
                if (sourceAcronymContains != null)
                    callPayload.Queries["sourceAcronymContains"] = SourceExpressionConverter.ConvertO(sourceAcronymContains);
                if (tagIds != null)
                    callPayload.Queries["tagIds"] = SourceExpressionConverter.ConvertO(tagIds);
                if (restrictToSet != null)
                    callPayload.Queries["restrictToSet"] = SourceExpressionConverter.ConvertO(restrictToSet);
                if (createdBy != null)
                    callPayload.Queries["createdBy"] = SourceExpressionConverter.ConvertO(createdBy);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItem> MediaFeaturedGet([WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/media/featured.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaPopularGet([WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/media/mostPopularMedia.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/media/searchResults.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaItemGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string> MediaContentGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<bool> calledByBuild = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (calledByBuild != null)
                    callPayload.Queries["calledByBuild"] = SourceExpressionConverter.ConvertO(calledByBuild);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string> MediaEmbedGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> flavor = null, [WorkflowExpression] Func<int> width = null, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<string> iframeName = null, [WorkflowExpression] Func<bool> excludeJquery = null, [WorkflowExpression] Func<bool> excludeDiv = null, [WorkflowExpression] Func<string> divId = null, [WorkflowExpression] Func<string> displayMethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}/embed.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (flavor != null)
                    callPayload.Queries["flavor"] = SourceExpressionConverter.ConvertO(flavor);
                if (width != null)
                    callPayload.Queries["width"] = SourceExpressionConverter.ConvertO(width);
                if (height != null)
                    callPayload.Queries["height"] = SourceExpressionConverter.ConvertO(height);
                if (iframeName != null)
                    callPayload.Queries["iframeName"] = SourceExpressionConverter.ConvertO(iframeName);
                callPayload.Queries["excludeJquery"] = Convert.ToString(false);
                if (excludeJquery != null)
                    callPayload.Queries["excludeJquery"] = SourceExpressionConverter.ConvertO(excludeJquery);
                callPayload.Queries["excludeDiv"] = Convert.ToString(false);
                if (excludeDiv != null)
                    callPayload.Queries["excludeDiv"] = SourceExpressionConverter.ConvertO(excludeDiv);
                if (divId != null)
                    callPayload.Queries["divId"] = SourceExpressionConverter.ConvertO(divId);
                if (displayMethod != null)
                    callPayload.Queries["displayMethod"] = SourceExpressionConverter.ConvertO(displayMethod);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<JToken> TagPreviewGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}/preview.jpg", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaRelatedGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}/relatedMedia.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SyndicateMarshallerWrapped> MediaSyndicatedGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> cssClass = null, [WorkflowExpression] Func<bool> stripStyles = null, [WorkflowExpression] Func<bool> stripScripts = null, [WorkflowExpression] Func<bool> stripImages = null, [WorkflowExpression] Func<bool> stripBreaks = null, [WorkflowExpression] Func<bool> stripClasses = null, [WorkflowExpression] Func<int> fontSize = null, [WorkflowExpression] Func<string> imageFloat = null, [WorkflowExpression] Func<string> imageMargin = null, [WorkflowExpression] Func<bool> autoplay = null, [WorkflowExpression] Func<bool> rel = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}/syndicate.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cssClass"] = Convert.ToString("syndicate");
                if (cssClass != null)
                    callPayload.Queries["cssClass"] = SourceExpressionConverter.ConvertO(cssClass);
                callPayload.Queries["stripStyles"] = Convert.ToString(false);
                if (stripStyles != null)
                    callPayload.Queries["stripStyles"] = SourceExpressionConverter.ConvertO(stripStyles);
                callPayload.Queries["stripScripts"] = Convert.ToString(false);
                if (stripScripts != null)
                    callPayload.Queries["stripScripts"] = SourceExpressionConverter.ConvertO(stripScripts);
                callPayload.Queries["stripImages"] = Convert.ToString(false);
                if (stripImages != null)
                    callPayload.Queries["stripImages"] = SourceExpressionConverter.ConvertO(stripImages);
                callPayload.Queries["stripBreaks"] = Convert.ToString(false);
                if (stripBreaks != null)
                    callPayload.Queries["stripBreaks"] = SourceExpressionConverter.ConvertO(stripBreaks);
                callPayload.Queries["stripClasses"] = Convert.ToString(false);
                if (stripClasses != null)
                    callPayload.Queries["stripClasses"] = SourceExpressionConverter.ConvertO(stripClasses);
                if (fontSize != null)
                    callPayload.Queries["font-size"] = SourceExpressionConverter.ConvertO(fontSize);
                if (imageFloat != null)
                    callPayload.Queries["imageFloat"] = SourceExpressionConverter.ConvertO(imageFloat);
                if (imageMargin != null)
                    callPayload.Queries["imageMargin"] = SourceExpressionConverter.ConvertO(imageMargin);
                callPayload.Queries["autoplay"] = Convert.ToString(true);
                if (autoplay != null)
                    callPayload.Queries["autoplay"] = SourceExpressionConverter.ConvertO(autoplay);
                callPayload.Queries["rel"] = Convert.ToString(false);
                if (rel != null)
                    callPayload.Queries["rel"] = SourceExpressionConverter.ConvertO(rel);
                return callPayload;
            }

            return new ApiConnectionAction<SyndicateMarshallerWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<JToken> MediaThumbnailGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}/thumbnail.jpg", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaYouTubeGetResponse> MediaYouTubeGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/media/{0}/youtubeMetaData.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MediaYouTubeGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaTypeHolderWrapped> MediaTypesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/mediaTypes.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MediaTypeHolderWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SourceWrapped> SourcesGet([WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/sources.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<SourceWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SourceWrapped> SourceGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/sources/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SourceWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> SourceMediaGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> displayMethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/sources/{0}/syndicate.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (displayMethod != null)
                    callPayload.Queries["displayMethod"] = SourceExpressionConverter.ConvertO(displayMethod);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped> TagsGet([WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> nameContains = null, [WorkflowExpression] Func<int> mediaId = null, [WorkflowExpression] Func<int> typeId = null, [WorkflowExpression] Func<string> typeName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/tags.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (nameContains != null)
                    callPayload.Queries["nameContains"] = SourceExpressionConverter.ConvertO(nameContains);
                if (mediaId != null)
                    callPayload.Queries["mediaId"] = SourceExpressionConverter.ConvertO(mediaId);
                if (typeId != null)
                    callPayload.Queries["typeId"] = SourceExpressionConverter.ConvertO(typeId);
                if (typeName != null)
                    callPayload.Queries["typeName"] = SourceExpressionConverter.ConvertO(typeName);
                return callPayload;
            }

            return new ApiConnectionAction<TagMarshallerWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagLanguageMarshallerWrapped> TagLanguagesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/tags/tagLanguages.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TagLanguageMarshallerWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagTypeMarshallerWrapped> TagMediaTypesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/tags/tagTypes.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TagTypeMarshallerWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped> TagGet([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/tags/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TagMarshallerWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> TagMediaGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/tags/{0}/media.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped> TagRelatedGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/tags/{0}/related.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<TagMarshallerWrapped>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string> TagSyndicateGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> displayMethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/tags/{0}/syndicate.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (displayMethod != null)
                    callPayload.Queries["displayMethod"] = SourceExpressionConverter.ConvertO(displayMethod);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaListGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> displayMethod = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/userMediaLists/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (displayMethod != null)
                    callPayload.Queries["displayMethod"] = SourceExpressionConverter.ConvertO(displayMethod);
                return callPayload;
            }

            return new ApiConnectionAction<MediaItemWrapped>(BuildSourceInput);
        }
    }

    public class HhsmediaservicesTriggers([ConnectionName] string connectionId)
    {
    }

    public class CampaignWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public Campaign[] Results { get; set; }
    }

    public class Meta
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("messages")]
        public Message[] Messages { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Message
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorDetail")]
        public string ErrorDetail { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("userMessage")]
        public string UserMessage { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("pageNum")]
        public int PageNum { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("currentUrl")]
        public string CurrentUrl { get; set; }

        [JsonProperty("nextUrl")]
        public string NextUrl { get; set; }

        [JsonProperty("previousUrl")]
        public string PreviousUrl { get; set; }
    }

    public class Campaign
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }
    }

    public class Source
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("largeLogoUrl")]
        public string LargeLogoUrl { get; set; }

        [JsonProperty("smallLogoUrl")]
        public string SmallLogoUrl { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }
    }

    public class MediaItemWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public MediaItem[] Results { get; set; }
    }

    public class MediaItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonProperty("customAttributionUrl")]
        public string CustomAttributionUrl { get; set; }

        [JsonProperty("campaigns")]
        public Campaign[] Campaigns { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("customThumbnailUrl")]
        public string CustomThumbnailUrl { get; set; }

        [JsonProperty("customPreviewUrl")]
        public string CustomPreviewUrl { get; set; }

        [JsonProperty("dateContentAuthored")]
        public string DateContentAuthored { get; set; }

        [JsonProperty("dateContentUpdated")]
        public string DateContentUpdated { get; set; }

        [JsonProperty("dateContentPublished")]
        public string DateContentPublished { get; set; }

        [JsonProperty("dateContentReviewed")]
        public string DateContentReviewed { get; set; }

        [JsonProperty("dateSyndicationCaptured")]
        public string DateSyndicationCaptured { get; set; }

        [JsonProperty("dateSyndicationUpdated")]
        public string DateSyndicationUpdated { get; set; }

        [JsonProperty("dateSyndicationVisible")]
        public string DateSyndicationVisible { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("externalGuid")]
        public string ExternalGuid { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("foreignSyndicationAPIUrl")]
        public string ForeignSyndicationAPIUrl { get; set; }

        [JsonProperty("extendedAttributes")]
        public ExtendedAttribute ExtendedAttributes { get; set; }
    }

    public class Language
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }

    public class ExtendedAttribute
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SyndicateMarshallerWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public SyndicateMarshaller[] Results { get; set; }
    }

    public class SyndicateMarshaller
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }
    }

    public class LanguageWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public Language[] Results { get; set; }
    }

    public class MediaYouTubeGetResponse
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public JToken[] Results { get; set; }
    }

    public class MediaTypeHolderWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public MediaTypeHolder[] Results { get; set; }
    }

    public class MediaTypeHolder
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SourceWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public Source[] Results { get; set; }
    }

    public class TagMarshallerWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public TagMarshaller[] Results { get; set; }
    }

    public class TagMarshaller
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public TagLanguageMarshaller Language { get; set; }

        [JsonProperty("type")]
        public TagTypeMarshaller Type { get; set; }
    }

    public class TagLanguageMarshaller
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }

    public class TagTypeMarshaller
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TagLanguageMarshallerWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public TagLanguageMarshaller[] Results { get; set; }
    }

    public class TagTypeMarshallerWrapped
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("results")]
        public TagTypeMarshaller[] Results { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hhsmediaservices;

    public partial class WorkflowManagedActions
    {
        public HhsmediaservicesActions Hhsmediaservices(string connectionId) => new HhsmediaservicesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HhsmediaservicesTriggers Hhsmediaservices(string connectionId) => new HhsmediaservicesTriggers(connectionId);
    }
}