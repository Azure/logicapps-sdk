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
        public IBodyWorkflowAction<CampaignWrapped> CampaignsGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/resources/campaigns.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<CampaignWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<CampaignWrapped> CampaignGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/campaigns/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CampaignWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> CampaignMediaGet(Expression<Func<int>> id, Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/resources/campaigns/{0}/media.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SyndicateMarshallerWrapped> CampaignSyndicateGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var apiCallPath = String.Format("/resources/campaigns/{0}/syndicate.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (displayMethod != null)
                callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(displayMethod);
            return new ApiConnectionAction<SyndicateMarshallerWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<LanguageWrapped> LanguagesGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/resources/languages.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<LanguageWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<LanguageWrapped> LanguageGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/languages/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LanguageWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null, Expression<Func<string>> order = null, Expression<Func<string>> mediaTypes = null, Expression<Func<string>> name = null, Expression<Func<int>> collectionId = null, Expression<Func<string>> nameContains = null, Expression<Func<string>> descriptionContains = null, Expression<Func<string>> sourceUrl = null, Expression<Func<string>> sourceUrlContains = null, Expression<Func<string>> customThumbnailUrl = null, Expression<Func<string>> customThumbnailUrlContains = null, Expression<Func<string>> dateContentAuthored = null, Expression<Func<string>> dateContentUpdated = null, Expression<Func<string>> dateContentPublished = null, Expression<Func<string>> dateContentReviewed = null, Expression<Func<string>> dateSyndicationCaptured = null, Expression<Func<string>> dateSyndicationUpdated = null, Expression<Func<string>> contentAuthoredSinceDate = null, Expression<Func<string>> contentAuthoredBeforeDate = null, Expression<Func<string>> contentAuthoredInRange = null, Expression<Func<string>> contentUpdatedSinceDate = null, Expression<Func<string>> contentUpdatedBeforeDate = null, Expression<Func<string>> contentUpdatedInRange = null, Expression<Func<string>> contentPublishedSinceDate = null, Expression<Func<string>> contentPublishedBeforeDate = null, Expression<Func<string>> contentPublishedInRange = null, Expression<Func<string>> contentReviewedSinceDate = null, Expression<Func<string>> contentReviewedBeforeDate = null, Expression<Func<string>> contentReviewedInRange = null, Expression<Func<string>> syndicationCapturedSinceDate = null, Expression<Func<string>> syndicationCapturedBeforeDate = null, Expression<Func<string>> syndicationCapturedInRange = null, Expression<Func<string>> syndicationUpdatedSinceDate = null, Expression<Func<string>> syndicationUpdatedBeforeDate = null, Expression<Func<string>> syndicationUpdatedInRange = null, Expression<Func<string>> syndicationVisibleSinceDate = null, Expression<Func<string>> syndicationVisibleBeforeDate = null, Expression<Func<string>> syndicationVisibleInRange = null, Expression<Func<int>> languageId = null, Expression<Func<string>> languageName = null, Expression<Func<string>> languageIsoCode = null, Expression<Func<string>> hash = null, Expression<Func<string>> hashContains = null, Expression<Func<int>> sourceId = null, Expression<Func<string>> sourceName = null, Expression<Func<string>> sourceNameContains = null, Expression<Func<string>> sourceAcronym = null, Expression<Func<string>> sourceAcronymContains = null, Expression<Func<string>> tagIds = null, Expression<Func<string>> restrictToSet = null, Expression<Func<string>> createdBy = null)
        {
            var apiCallPath = "/resources/media.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (order != null)
                callPayload.Queries["order"] = ExpressionConverter.Convert(order);
            if (mediaTypes != null)
                callPayload.Queries["mediaTypes"] = ExpressionConverter.Convert(mediaTypes);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (collectionId != null)
                callPayload.Queries["collectionId"] = ExpressionConverter.Convert(collectionId);
            if (nameContains != null)
                callPayload.Queries["nameContains"] = ExpressionConverter.Convert(nameContains);
            if (descriptionContains != null)
                callPayload.Queries["descriptionContains"] = ExpressionConverter.Convert(descriptionContains);
            if (sourceUrl != null)
                callPayload.Queries["sourceUrl"] = ExpressionConverter.Convert(sourceUrl);
            if (sourceUrlContains != null)
                callPayload.Queries["sourceUrlContains"] = ExpressionConverter.Convert(sourceUrlContains);
            if (customThumbnailUrl != null)
                callPayload.Queries["customThumbnailUrl"] = ExpressionConverter.Convert(customThumbnailUrl);
            if (customThumbnailUrlContains != null)
                callPayload.Queries["customThumbnailUrlContains"] = ExpressionConverter.Convert(customThumbnailUrlContains);
            if (dateContentAuthored != null)
                callPayload.Queries["dateContentAuthored"] = ExpressionConverter.Convert(dateContentAuthored);
            if (dateContentUpdated != null)
                callPayload.Queries["dateContentUpdated"] = ExpressionConverter.Convert(dateContentUpdated);
            if (dateContentPublished != null)
                callPayload.Queries["dateContentPublished"] = ExpressionConverter.Convert(dateContentPublished);
            if (dateContentReviewed != null)
                callPayload.Queries["dateContentReviewed"] = ExpressionConverter.Convert(dateContentReviewed);
            if (dateSyndicationCaptured != null)
                callPayload.Queries["dateSyndicationCaptured"] = ExpressionConverter.Convert(dateSyndicationCaptured);
            if (dateSyndicationUpdated != null)
                callPayload.Queries["dateSyndicationUpdated"] = ExpressionConverter.Convert(dateSyndicationUpdated);
            if (contentAuthoredSinceDate != null)
                callPayload.Queries["contentAuthoredSinceDate"] = ExpressionConverter.Convert(contentAuthoredSinceDate);
            if (contentAuthoredBeforeDate != null)
                callPayload.Queries["contentAuthoredBeforeDate"] = ExpressionConverter.Convert(contentAuthoredBeforeDate);
            if (contentAuthoredInRange != null)
                callPayload.Queries["contentAuthoredInRange"] = ExpressionConverter.Convert(contentAuthoredInRange);
            if (contentUpdatedSinceDate != null)
                callPayload.Queries["contentUpdatedSinceDate"] = ExpressionConverter.Convert(contentUpdatedSinceDate);
            if (contentUpdatedBeforeDate != null)
                callPayload.Queries["contentUpdatedBeforeDate"] = ExpressionConverter.Convert(contentUpdatedBeforeDate);
            if (contentUpdatedInRange != null)
                callPayload.Queries["contentUpdatedInRange"] = ExpressionConverter.Convert(contentUpdatedInRange);
            if (contentPublishedSinceDate != null)
                callPayload.Queries["contentPublishedSinceDate"] = ExpressionConverter.Convert(contentPublishedSinceDate);
            if (contentPublishedBeforeDate != null)
                callPayload.Queries["contentPublishedBeforeDate"] = ExpressionConverter.Convert(contentPublishedBeforeDate);
            if (contentPublishedInRange != null)
                callPayload.Queries["contentPublishedInRange"] = ExpressionConverter.Convert(contentPublishedInRange);
            if (contentReviewedSinceDate != null)
                callPayload.Queries["contentReviewedSinceDate"] = ExpressionConverter.Convert(contentReviewedSinceDate);
            if (contentReviewedBeforeDate != null)
                callPayload.Queries["contentReviewedBeforeDate"] = ExpressionConverter.Convert(contentReviewedBeforeDate);
            if (contentReviewedInRange != null)
                callPayload.Queries["contentReviewedInRange"] = ExpressionConverter.Convert(contentReviewedInRange);
            if (syndicationCapturedSinceDate != null)
                callPayload.Queries["syndicationCapturedSinceDate"] = ExpressionConverter.Convert(syndicationCapturedSinceDate);
            if (syndicationCapturedBeforeDate != null)
                callPayload.Queries["syndicationCapturedBeforeDate"] = ExpressionConverter.Convert(syndicationCapturedBeforeDate);
            if (syndicationCapturedInRange != null)
                callPayload.Queries["syndicationCapturedInRange"] = ExpressionConverter.Convert(syndicationCapturedInRange);
            if (syndicationUpdatedSinceDate != null)
                callPayload.Queries["syndicationUpdatedSinceDate"] = ExpressionConverter.Convert(syndicationUpdatedSinceDate);
            if (syndicationUpdatedBeforeDate != null)
                callPayload.Queries["syndicationUpdatedBeforeDate"] = ExpressionConverter.Convert(syndicationUpdatedBeforeDate);
            if (syndicationUpdatedInRange != null)
                callPayload.Queries["syndicationUpdatedInRange"] = ExpressionConverter.Convert(syndicationUpdatedInRange);
            if (syndicationVisibleSinceDate != null)
                callPayload.Queries["syndicationVisibleSinceDate"] = ExpressionConverter.Convert(syndicationVisibleSinceDate);
            if (syndicationVisibleBeforeDate != null)
                callPayload.Queries["syndicationVisibleBeforeDate"] = ExpressionConverter.Convert(syndicationVisibleBeforeDate);
            if (syndicationVisibleInRange != null)
                callPayload.Queries["syndicationVisibleInRange"] = ExpressionConverter.Convert(syndicationVisibleInRange);
            if (languageId != null)
                callPayload.Queries["languageId"] = ExpressionConverter.Convert(languageId);
            if (languageName != null)
                callPayload.Queries["languageName"] = ExpressionConverter.Convert(languageName);
            if (languageIsoCode != null)
                callPayload.Queries["languageIsoCode"] = ExpressionConverter.Convert(languageIsoCode);
            if (hash != null)
                callPayload.Queries["hash"] = ExpressionConverter.Convert(hash);
            if (hashContains != null)
                callPayload.Queries["hashContains"] = ExpressionConverter.Convert(hashContains);
            if (sourceId != null)
                callPayload.Queries["sourceId"] = ExpressionConverter.Convert(sourceId);
            if (sourceName != null)
                callPayload.Queries["sourceName"] = ExpressionConverter.Convert(sourceName);
            if (sourceNameContains != null)
                callPayload.Queries["sourceNameContains"] = ExpressionConverter.Convert(sourceNameContains);
            if (sourceAcronym != null)
                callPayload.Queries["sourceAcronym"] = ExpressionConverter.Convert(sourceAcronym);
            if (sourceAcronymContains != null)
                callPayload.Queries["sourceAcronymContains"] = ExpressionConverter.Convert(sourceAcronymContains);
            if (tagIds != null)
                callPayload.Queries["tagIds"] = ExpressionConverter.Convert(tagIds);
            if (restrictToSet != null)
                callPayload.Queries["restrictToSet"] = ExpressionConverter.Convert(restrictToSet);
            if (createdBy != null)
                callPayload.Queries["createdBy"] = ExpressionConverter.Convert(createdBy);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItem> MediaFeaturedGet(Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/resources/media/featured.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<MediaItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaPopularGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/resources/media/mostPopularMedia.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaSearchGet(Expression<Func<string>> q, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/resources/media/searchResults.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaItemGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/media/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string> MediaContentGet(Expression<Func<int>> id, Expression<Func<bool>> calledByBuild = null)
        {
            var apiCallPath = String.Format("/resources/media/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (calledByBuild != null)
                callPayload.Queries["calledByBuild"] = ExpressionConverter.Convert(calledByBuild);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string> MediaEmbedGet(Expression<Func<int>> id, Expression<Func<string>> flavor = null, Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<string>> iframeName = null, Expression<Func<bool>> excludeJquery = null, Expression<Func<bool>> excludeDiv = null, Expression<Func<string>> divId = null, Expression<Func<string>> displayMethod = null)
        {
            var apiCallPath = String.Format("/resources/media/{0}/embed.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (flavor != null)
                callPayload.Queries["flavor"] = ExpressionConverter.Convert(flavor);
            if (width != null)
                callPayload.Queries["width"] = ExpressionConverter.Convert(width);
            if (height != null)
                callPayload.Queries["height"] = ExpressionConverter.Convert(height);
            if (iframeName != null)
                callPayload.Queries["iframeName"] = ExpressionConverter.Convert(iframeName);
            callPayload.Queries["excludeJquery"] = Convert.ToString(false);
            if (excludeJquery != null)
                callPayload.Queries["excludeJquery"] = ExpressionConverter.Convert(excludeJquery);
            callPayload.Queries["excludeDiv"] = Convert.ToString(false);
            if (excludeDiv != null)
                callPayload.Queries["excludeDiv"] = ExpressionConverter.Convert(excludeDiv);
            if (divId != null)
                callPayload.Queries["divId"] = ExpressionConverter.Convert(divId);
            if (displayMethod != null)
                callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(displayMethod);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<JToken> TagPreviewGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/media/{0}/preview.jpg", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaRelatedGet(Expression<Func<int>> id, Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = String.Format("/resources/media/{0}/relatedMedia.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SyndicateMarshallerWrapped> MediaSyndicatedGet(Expression<Func<int>> id, Expression<Func<string>> cssClass = null, Expression<Func<bool>> stripStyles = null, Expression<Func<bool>> stripScripts = null, Expression<Func<bool>> stripImages = null, Expression<Func<bool>> stripBreaks = null, Expression<Func<bool>> stripClasses = null, Expression<Func<int>> fontSize = null, Expression<Func<string>> imageFloat = null, Expression<Func<string>> imageMargin = null, Expression<Func<bool>> autoplay = null, Expression<Func<bool>> rel = null)
        {
            var apiCallPath = String.Format("/resources/media/{0}/syndicate.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cssClass"] = Convert.ToString("syndicate");
            if (cssClass != null)
                callPayload.Queries["cssClass"] = ExpressionConverter.Convert(cssClass);
            callPayload.Queries["stripStyles"] = Convert.ToString(false);
            if (stripStyles != null)
                callPayload.Queries["stripStyles"] = ExpressionConverter.Convert(stripStyles);
            callPayload.Queries["stripScripts"] = Convert.ToString(false);
            if (stripScripts != null)
                callPayload.Queries["stripScripts"] = ExpressionConverter.Convert(stripScripts);
            callPayload.Queries["stripImages"] = Convert.ToString(false);
            if (stripImages != null)
                callPayload.Queries["stripImages"] = ExpressionConverter.Convert(stripImages);
            callPayload.Queries["stripBreaks"] = Convert.ToString(false);
            if (stripBreaks != null)
                callPayload.Queries["stripBreaks"] = ExpressionConverter.Convert(stripBreaks);
            callPayload.Queries["stripClasses"] = Convert.ToString(false);
            if (stripClasses != null)
                callPayload.Queries["stripClasses"] = ExpressionConverter.Convert(stripClasses);
            if (fontSize != null)
                callPayload.Queries["font-size"] = ExpressionConverter.Convert(fontSize);
            if (imageFloat != null)
                callPayload.Queries["imageFloat"] = ExpressionConverter.Convert(imageFloat);
            if (imageMargin != null)
                callPayload.Queries["imageMargin"] = ExpressionConverter.Convert(imageMargin);
            callPayload.Queries["autoplay"] = Convert.ToString(true);
            if (autoplay != null)
                callPayload.Queries["autoplay"] = ExpressionConverter.Convert(autoplay);
            callPayload.Queries["rel"] = Convert.ToString(false);
            if (rel != null)
                callPayload.Queries["rel"] = ExpressionConverter.Convert(rel);
            return new ApiConnectionAction<SyndicateMarshallerWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<JToken> MediaThumbnailGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/media/{0}/thumbnail.jpg", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaYouTubeGetResponse> MediaYouTubeGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/media/{0}/youtubeMetaData.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MediaYouTubeGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaTypeHolderWrapped> MediaTypesGet()
        {
            var apiCallPath = "/resources/mediaTypes.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MediaTypeHolderWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SourceWrapped> SourcesGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/resources/sources.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<SourceWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SourceWrapped> SourceGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/sources/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SourceWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> SourceMediaGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var apiCallPath = String.Format("/resources/sources/{0}/syndicate.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (displayMethod != null)
                callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(displayMethod);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped> TagsGet(Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> name = null, Expression<Func<string>> nameContains = null, Expression<Func<int>> mediaId = null, Expression<Func<int>> typeId = null, Expression<Func<string>> typeName = null)
        {
            var apiCallPath = "/resources/tags.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (nameContains != null)
                callPayload.Queries["nameContains"] = ExpressionConverter.Convert(nameContains);
            if (mediaId != null)
                callPayload.Queries["mediaId"] = ExpressionConverter.Convert(mediaId);
            if (typeId != null)
                callPayload.Queries["typeId"] = ExpressionConverter.Convert(typeId);
            if (typeName != null)
                callPayload.Queries["typeName"] = ExpressionConverter.Convert(typeName);
            return new ApiConnectionAction<TagMarshallerWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagLanguageMarshallerWrapped> TagLanguagesGet()
        {
            var apiCallPath = "/resources/tags/tagLanguages.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagLanguageMarshallerWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagTypeMarshallerWrapped> TagMediaTypesGet()
        {
            var apiCallPath = "/resources/tags/tagTypes.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagTypeMarshallerWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped> TagGet(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/tags/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagMarshallerWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> TagMediaGet(Expression<Func<int>> id, Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/resources/tags/{0}/media.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped> TagRelatedGet(Expression<Func<int>> id, Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/resources/tags/{0}/related.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<TagMarshallerWrapped>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string> TagSyndicateGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var apiCallPath = String.Format("/resources/tags/{0}/syndicate.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (displayMethod != null)
                callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(displayMethod);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped> MediaListGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var apiCallPath = String.Format("/resources/userMediaLists/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (displayMethod != null)
                callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(displayMethod);
            return new ApiConnectionAction<MediaItemWrapped>(callPayload);
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