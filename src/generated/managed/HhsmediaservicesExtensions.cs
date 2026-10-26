//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hhsmediaservices
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HhsmediaservicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<CampaignWrapped, ApiConnectionActionConfiguration> CampaignsGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CampaignWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/campaigns.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<CampaignWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<CampaignWrapped, ApiConnectionActionConfiguration> CampaignGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CampaignWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/campaigns/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> CampaignMediaGet(Expression<Func<int>> id, Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/campaigns/{0}/media.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SyndicateMarshallerWrapped, ApiConnectionActionConfiguration> CampaignSyndicateGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_displayMethod = WorkflowExpression.Compile(displayMethod, nameof(displayMethod), required: false);
            return new DeferredBodyAction<SyndicateMarshallerWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/campaigns/{0}/syndicate.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_displayMethod != null)
                    callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(__workflow_displayMethod);
                return new ApiConnectionAction<SyndicateMarshallerWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<LanguageWrapped, ApiConnectionActionConfiguration> LanguagesGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<LanguageWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/languages.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<LanguageWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<LanguageWrapped, ApiConnectionActionConfiguration> LanguageGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LanguageWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/languages/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LanguageWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> MediaGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null, Expression<Func<string>> order = null, Expression<Func<string>> mediaTypes = null, Expression<Func<string>> name = null, Expression<Func<int>> collectionId = null, Expression<Func<string>> nameContains = null, Expression<Func<string>> descriptionContains = null, Expression<Func<string>> sourceUrl = null, Expression<Func<string>> sourceUrlContains = null, Expression<Func<string>> customThumbnailUrl = null, Expression<Func<string>> customThumbnailUrlContains = null, Expression<Func<string>> dateContentAuthored = null, Expression<Func<string>> dateContentUpdated = null, Expression<Func<string>> dateContentPublished = null, Expression<Func<string>> dateContentReviewed = null, Expression<Func<string>> dateSyndicationCaptured = null, Expression<Func<string>> dateSyndicationUpdated = null, Expression<Func<string>> contentAuthoredSinceDate = null, Expression<Func<string>> contentAuthoredBeforeDate = null, Expression<Func<string>> contentAuthoredInRange = null, Expression<Func<string>> contentUpdatedSinceDate = null, Expression<Func<string>> contentUpdatedBeforeDate = null, Expression<Func<string>> contentUpdatedInRange = null, Expression<Func<string>> contentPublishedSinceDate = null, Expression<Func<string>> contentPublishedBeforeDate = null, Expression<Func<string>> contentPublishedInRange = null, Expression<Func<string>> contentReviewedSinceDate = null, Expression<Func<string>> contentReviewedBeforeDate = null, Expression<Func<string>> contentReviewedInRange = null, Expression<Func<string>> syndicationCapturedSinceDate = null, Expression<Func<string>> syndicationCapturedBeforeDate = null, Expression<Func<string>> syndicationCapturedInRange = null, Expression<Func<string>> syndicationUpdatedSinceDate = null, Expression<Func<string>> syndicationUpdatedBeforeDate = null, Expression<Func<string>> syndicationUpdatedInRange = null, Expression<Func<string>> syndicationVisibleSinceDate = null, Expression<Func<string>> syndicationVisibleBeforeDate = null, Expression<Func<string>> syndicationVisibleInRange = null, Expression<Func<int>> languageId = null, Expression<Func<string>> languageName = null, Expression<Func<string>> languageIsoCode = null, Expression<Func<string>> hash = null, Expression<Func<string>> hashContains = null, Expression<Func<int>> sourceId = null, Expression<Func<string>> sourceName = null, Expression<Func<string>> sourceNameContains = null, Expression<Func<string>> sourceAcronym = null, Expression<Func<string>> sourceAcronymContains = null, Expression<Func<string>> tagIds = null, Expression<Func<string>> restrictToSet = null, Expression<Func<string>> createdBy = null)
        {
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_mediaTypes = WorkflowExpression.Compile(mediaTypes, nameof(mediaTypes), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: false);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_descriptionContains = WorkflowExpression.Compile(descriptionContains, nameof(descriptionContains), required: false);
            var __workflow_sourceUrl = WorkflowExpression.Compile(sourceUrl, nameof(sourceUrl), required: false);
            var __workflow_sourceUrlContains = WorkflowExpression.Compile(sourceUrlContains, nameof(sourceUrlContains), required: false);
            var __workflow_customThumbnailUrl = WorkflowExpression.Compile(customThumbnailUrl, nameof(customThumbnailUrl), required: false);
            var __workflow_customThumbnailUrlContains = WorkflowExpression.Compile(customThumbnailUrlContains, nameof(customThumbnailUrlContains), required: false);
            var __workflow_dateContentAuthored = WorkflowExpression.Compile(dateContentAuthored, nameof(dateContentAuthored), required: false);
            var __workflow_dateContentUpdated = WorkflowExpression.Compile(dateContentUpdated, nameof(dateContentUpdated), required: false);
            var __workflow_dateContentPublished = WorkflowExpression.Compile(dateContentPublished, nameof(dateContentPublished), required: false);
            var __workflow_dateContentReviewed = WorkflowExpression.Compile(dateContentReviewed, nameof(dateContentReviewed), required: false);
            var __workflow_dateSyndicationCaptured = WorkflowExpression.Compile(dateSyndicationCaptured, nameof(dateSyndicationCaptured), required: false);
            var __workflow_dateSyndicationUpdated = WorkflowExpression.Compile(dateSyndicationUpdated, nameof(dateSyndicationUpdated), required: false);
            var __workflow_contentAuthoredSinceDate = WorkflowExpression.Compile(contentAuthoredSinceDate, nameof(contentAuthoredSinceDate), required: false);
            var __workflow_contentAuthoredBeforeDate = WorkflowExpression.Compile(contentAuthoredBeforeDate, nameof(contentAuthoredBeforeDate), required: false);
            var __workflow_contentAuthoredInRange = WorkflowExpression.Compile(contentAuthoredInRange, nameof(contentAuthoredInRange), required: false);
            var __workflow_contentUpdatedSinceDate = WorkflowExpression.Compile(contentUpdatedSinceDate, nameof(contentUpdatedSinceDate), required: false);
            var __workflow_contentUpdatedBeforeDate = WorkflowExpression.Compile(contentUpdatedBeforeDate, nameof(contentUpdatedBeforeDate), required: false);
            var __workflow_contentUpdatedInRange = WorkflowExpression.Compile(contentUpdatedInRange, nameof(contentUpdatedInRange), required: false);
            var __workflow_contentPublishedSinceDate = WorkflowExpression.Compile(contentPublishedSinceDate, nameof(contentPublishedSinceDate), required: false);
            var __workflow_contentPublishedBeforeDate = WorkflowExpression.Compile(contentPublishedBeforeDate, nameof(contentPublishedBeforeDate), required: false);
            var __workflow_contentPublishedInRange = WorkflowExpression.Compile(contentPublishedInRange, nameof(contentPublishedInRange), required: false);
            var __workflow_contentReviewedSinceDate = WorkflowExpression.Compile(contentReviewedSinceDate, nameof(contentReviewedSinceDate), required: false);
            var __workflow_contentReviewedBeforeDate = WorkflowExpression.Compile(contentReviewedBeforeDate, nameof(contentReviewedBeforeDate), required: false);
            var __workflow_contentReviewedInRange = WorkflowExpression.Compile(contentReviewedInRange, nameof(contentReviewedInRange), required: false);
            var __workflow_syndicationCapturedSinceDate = WorkflowExpression.Compile(syndicationCapturedSinceDate, nameof(syndicationCapturedSinceDate), required: false);
            var __workflow_syndicationCapturedBeforeDate = WorkflowExpression.Compile(syndicationCapturedBeforeDate, nameof(syndicationCapturedBeforeDate), required: false);
            var __workflow_syndicationCapturedInRange = WorkflowExpression.Compile(syndicationCapturedInRange, nameof(syndicationCapturedInRange), required: false);
            var __workflow_syndicationUpdatedSinceDate = WorkflowExpression.Compile(syndicationUpdatedSinceDate, nameof(syndicationUpdatedSinceDate), required: false);
            var __workflow_syndicationUpdatedBeforeDate = WorkflowExpression.Compile(syndicationUpdatedBeforeDate, nameof(syndicationUpdatedBeforeDate), required: false);
            var __workflow_syndicationUpdatedInRange = WorkflowExpression.Compile(syndicationUpdatedInRange, nameof(syndicationUpdatedInRange), required: false);
            var __workflow_syndicationVisibleSinceDate = WorkflowExpression.Compile(syndicationVisibleSinceDate, nameof(syndicationVisibleSinceDate), required: false);
            var __workflow_syndicationVisibleBeforeDate = WorkflowExpression.Compile(syndicationVisibleBeforeDate, nameof(syndicationVisibleBeforeDate), required: false);
            var __workflow_syndicationVisibleInRange = WorkflowExpression.Compile(syndicationVisibleInRange, nameof(syndicationVisibleInRange), required: false);
            var __workflow_languageId = WorkflowExpression.Compile(languageId, nameof(languageId), required: false);
            var __workflow_languageName = WorkflowExpression.Compile(languageName, nameof(languageName), required: false);
            var __workflow_languageIsoCode = WorkflowExpression.Compile(languageIsoCode, nameof(languageIsoCode), required: false);
            var __workflow_hash = WorkflowExpression.Compile(hash, nameof(hash), required: false);
            var __workflow_hashContains = WorkflowExpression.Compile(hashContains, nameof(hashContains), required: false);
            var __workflow_sourceId = WorkflowExpression.Compile(sourceId, nameof(sourceId), required: false);
            var __workflow_sourceName = WorkflowExpression.Compile(sourceName, nameof(sourceName), required: false);
            var __workflow_sourceNameContains = WorkflowExpression.Compile(sourceNameContains, nameof(sourceNameContains), required: false);
            var __workflow_sourceAcronym = WorkflowExpression.Compile(sourceAcronym, nameof(sourceAcronym), required: false);
            var __workflow_sourceAcronymContains = WorkflowExpression.Compile(sourceAcronymContains, nameof(sourceAcronymContains), required: false);
            var __workflow_tagIds = WorkflowExpression.Compile(tagIds, nameof(tagIds), required: false);
            var __workflow_restrictToSet = WorkflowExpression.Compile(restrictToSet, nameof(restrictToSet), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/media.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_mediaTypes != null)
                    callPayload.Queries["mediaTypes"] = ExpressionConverter.Convert(__workflow_mediaTypes);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_collectionId != null)
                    callPayload.Queries["collectionId"] = ExpressionConverter.Convert(__workflow_collectionId);
                if (__workflow_nameContains != null)
                    callPayload.Queries["nameContains"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_descriptionContains != null)
                    callPayload.Queries["descriptionContains"] = ExpressionConverter.Convert(__workflow_descriptionContains);
                if (__workflow_sourceUrl != null)
                    callPayload.Queries["sourceUrl"] = ExpressionConverter.Convert(__workflow_sourceUrl);
                if (__workflow_sourceUrlContains != null)
                    callPayload.Queries["sourceUrlContains"] = ExpressionConverter.Convert(__workflow_sourceUrlContains);
                if (__workflow_customThumbnailUrl != null)
                    callPayload.Queries["customThumbnailUrl"] = ExpressionConverter.Convert(__workflow_customThumbnailUrl);
                if (__workflow_customThumbnailUrlContains != null)
                    callPayload.Queries["customThumbnailUrlContains"] = ExpressionConverter.Convert(__workflow_customThumbnailUrlContains);
                if (__workflow_dateContentAuthored != null)
                    callPayload.Queries["dateContentAuthored"] = ExpressionConverter.Convert(__workflow_dateContentAuthored);
                if (__workflow_dateContentUpdated != null)
                    callPayload.Queries["dateContentUpdated"] = ExpressionConverter.Convert(__workflow_dateContentUpdated);
                if (__workflow_dateContentPublished != null)
                    callPayload.Queries["dateContentPublished"] = ExpressionConverter.Convert(__workflow_dateContentPublished);
                if (__workflow_dateContentReviewed != null)
                    callPayload.Queries["dateContentReviewed"] = ExpressionConverter.Convert(__workflow_dateContentReviewed);
                if (__workflow_dateSyndicationCaptured != null)
                    callPayload.Queries["dateSyndicationCaptured"] = ExpressionConverter.Convert(__workflow_dateSyndicationCaptured);
                if (__workflow_dateSyndicationUpdated != null)
                    callPayload.Queries["dateSyndicationUpdated"] = ExpressionConverter.Convert(__workflow_dateSyndicationUpdated);
                if (__workflow_contentAuthoredSinceDate != null)
                    callPayload.Queries["contentAuthoredSinceDate"] = ExpressionConverter.Convert(__workflow_contentAuthoredSinceDate);
                if (__workflow_contentAuthoredBeforeDate != null)
                    callPayload.Queries["contentAuthoredBeforeDate"] = ExpressionConverter.Convert(__workflow_contentAuthoredBeforeDate);
                if (__workflow_contentAuthoredInRange != null)
                    callPayload.Queries["contentAuthoredInRange"] = ExpressionConverter.Convert(__workflow_contentAuthoredInRange);
                if (__workflow_contentUpdatedSinceDate != null)
                    callPayload.Queries["contentUpdatedSinceDate"] = ExpressionConverter.Convert(__workflow_contentUpdatedSinceDate);
                if (__workflow_contentUpdatedBeforeDate != null)
                    callPayload.Queries["contentUpdatedBeforeDate"] = ExpressionConverter.Convert(__workflow_contentUpdatedBeforeDate);
                if (__workflow_contentUpdatedInRange != null)
                    callPayload.Queries["contentUpdatedInRange"] = ExpressionConverter.Convert(__workflow_contentUpdatedInRange);
                if (__workflow_contentPublishedSinceDate != null)
                    callPayload.Queries["contentPublishedSinceDate"] = ExpressionConverter.Convert(__workflow_contentPublishedSinceDate);
                if (__workflow_contentPublishedBeforeDate != null)
                    callPayload.Queries["contentPublishedBeforeDate"] = ExpressionConverter.Convert(__workflow_contentPublishedBeforeDate);
                if (__workflow_contentPublishedInRange != null)
                    callPayload.Queries["contentPublishedInRange"] = ExpressionConverter.Convert(__workflow_contentPublishedInRange);
                if (__workflow_contentReviewedSinceDate != null)
                    callPayload.Queries["contentReviewedSinceDate"] = ExpressionConverter.Convert(__workflow_contentReviewedSinceDate);
                if (__workflow_contentReviewedBeforeDate != null)
                    callPayload.Queries["contentReviewedBeforeDate"] = ExpressionConverter.Convert(__workflow_contentReviewedBeforeDate);
                if (__workflow_contentReviewedInRange != null)
                    callPayload.Queries["contentReviewedInRange"] = ExpressionConverter.Convert(__workflow_contentReviewedInRange);
                if (__workflow_syndicationCapturedSinceDate != null)
                    callPayload.Queries["syndicationCapturedSinceDate"] = ExpressionConverter.Convert(__workflow_syndicationCapturedSinceDate);
                if (__workflow_syndicationCapturedBeforeDate != null)
                    callPayload.Queries["syndicationCapturedBeforeDate"] = ExpressionConverter.Convert(__workflow_syndicationCapturedBeforeDate);
                if (__workflow_syndicationCapturedInRange != null)
                    callPayload.Queries["syndicationCapturedInRange"] = ExpressionConverter.Convert(__workflow_syndicationCapturedInRange);
                if (__workflow_syndicationUpdatedSinceDate != null)
                    callPayload.Queries["syndicationUpdatedSinceDate"] = ExpressionConverter.Convert(__workflow_syndicationUpdatedSinceDate);
                if (__workflow_syndicationUpdatedBeforeDate != null)
                    callPayload.Queries["syndicationUpdatedBeforeDate"] = ExpressionConverter.Convert(__workflow_syndicationUpdatedBeforeDate);
                if (__workflow_syndicationUpdatedInRange != null)
                    callPayload.Queries["syndicationUpdatedInRange"] = ExpressionConverter.Convert(__workflow_syndicationUpdatedInRange);
                if (__workflow_syndicationVisibleSinceDate != null)
                    callPayload.Queries["syndicationVisibleSinceDate"] = ExpressionConverter.Convert(__workflow_syndicationVisibleSinceDate);
                if (__workflow_syndicationVisibleBeforeDate != null)
                    callPayload.Queries["syndicationVisibleBeforeDate"] = ExpressionConverter.Convert(__workflow_syndicationVisibleBeforeDate);
                if (__workflow_syndicationVisibleInRange != null)
                    callPayload.Queries["syndicationVisibleInRange"] = ExpressionConverter.Convert(__workflow_syndicationVisibleInRange);
                if (__workflow_languageId != null)
                    callPayload.Queries["languageId"] = ExpressionConverter.Convert(__workflow_languageId);
                if (__workflow_languageName != null)
                    callPayload.Queries["languageName"] = ExpressionConverter.Convert(__workflow_languageName);
                if (__workflow_languageIsoCode != null)
                    callPayload.Queries["languageIsoCode"] = ExpressionConverter.Convert(__workflow_languageIsoCode);
                if (__workflow_hash != null)
                    callPayload.Queries["hash"] = ExpressionConverter.Convert(__workflow_hash);
                if (__workflow_hashContains != null)
                    callPayload.Queries["hashContains"] = ExpressionConverter.Convert(__workflow_hashContains);
                if (__workflow_sourceId != null)
                    callPayload.Queries["sourceId"] = ExpressionConverter.Convert(__workflow_sourceId);
                if (__workflow_sourceName != null)
                    callPayload.Queries["sourceName"] = ExpressionConverter.Convert(__workflow_sourceName);
                if (__workflow_sourceNameContains != null)
                    callPayload.Queries["sourceNameContains"] = ExpressionConverter.Convert(__workflow_sourceNameContains);
                if (__workflow_sourceAcronym != null)
                    callPayload.Queries["sourceAcronym"] = ExpressionConverter.Convert(__workflow_sourceAcronym);
                if (__workflow_sourceAcronymContains != null)
                    callPayload.Queries["sourceAcronymContains"] = ExpressionConverter.Convert(__workflow_sourceAcronymContains);
                if (__workflow_tagIds != null)
                    callPayload.Queries["tagIds"] = ExpressionConverter.Convert(__workflow_tagIds);
                if (__workflow_restrictToSet != null)
                    callPayload.Queries["restrictToSet"] = ExpressionConverter.Convert(__workflow_restrictToSet);
                if (__workflow_createdBy != null)
                    callPayload.Queries["createdBy"] = ExpressionConverter.Convert(__workflow_createdBy);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItem, ApiConnectionActionConfiguration> MediaFeaturedGet(Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/media/featured.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<MediaItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> MediaPopularGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/media/mostPopularMedia.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> MediaSearchGet(Expression<Func<string>> q, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/media/searchResults.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> MediaItemGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MediaContentGet(Expression<Func<int>> id, Expression<Func<bool>> calledByBuild = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_calledByBuild = WorkflowExpression.Compile(calledByBuild, nameof(calledByBuild), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}/content", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_calledByBuild != null)
                    callPayload.Queries["calledByBuild"] = ExpressionConverter.Convert(__workflow_calledByBuild);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MediaEmbedGet(Expression<Func<int>> id, Expression<Func<string>> flavor = null, Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<string>> iframeName = null, Expression<Func<bool>> excludeJquery = null, Expression<Func<bool>> excludeDiv = null, Expression<Func<string>> divId = null, Expression<Func<string>> displayMethod = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_flavor = WorkflowExpression.Compile(flavor, nameof(flavor), required: false);
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: false);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: false);
            var __workflow_iframeName = WorkflowExpression.Compile(iframeName, nameof(iframeName), required: false);
            var __workflow_excludeJquery = WorkflowExpression.Compile(excludeJquery, nameof(excludeJquery), required: false);
            var __workflow_excludeDiv = WorkflowExpression.Compile(excludeDiv, nameof(excludeDiv), required: false);
            var __workflow_divId = WorkflowExpression.Compile(divId, nameof(divId), required: false);
            var __workflow_displayMethod = WorkflowExpression.Compile(displayMethod, nameof(displayMethod), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}/embed.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_flavor != null)
                    callPayload.Queries["flavor"] = ExpressionConverter.Convert(__workflow_flavor);
                if (__workflow_width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                if (__workflow_height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                if (__workflow_iframeName != null)
                    callPayload.Queries["iframeName"] = ExpressionConverter.Convert(__workflow_iframeName);
                callPayload.Queries["excludeJquery"] = Convert.ToString(false);
                if (__workflow_excludeJquery != null)
                    callPayload.Queries["excludeJquery"] = ExpressionConverter.Convert(__workflow_excludeJquery);
                callPayload.Queries["excludeDiv"] = Convert.ToString(false);
                if (__workflow_excludeDiv != null)
                    callPayload.Queries["excludeDiv"] = ExpressionConverter.Convert(__workflow_excludeDiv);
                if (__workflow_divId != null)
                    callPayload.Queries["divId"] = ExpressionConverter.Convert(__workflow_divId);
                if (__workflow_displayMethod != null)
                    callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(__workflow_displayMethod);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TagPreviewGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}/preview.jpg", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> MediaRelatedGet(Expression<Func<int>> id, Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}/relatedMedia.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SyndicateMarshallerWrapped, ApiConnectionActionConfiguration> MediaSyndicatedGet(Expression<Func<int>> id, Expression<Func<string>> cssClass = null, Expression<Func<bool>> stripStyles = null, Expression<Func<bool>> stripScripts = null, Expression<Func<bool>> stripImages = null, Expression<Func<bool>> stripBreaks = null, Expression<Func<bool>> stripClasses = null, Expression<Func<int>> fontSize = null, Expression<Func<string>> imageFloat = null, Expression<Func<string>> imageMargin = null, Expression<Func<bool>> autoplay = null, Expression<Func<bool>> rel = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_cssClass = WorkflowExpression.Compile(cssClass, nameof(cssClass), required: false);
            var __workflow_stripStyles = WorkflowExpression.Compile(stripStyles, nameof(stripStyles), required: false);
            var __workflow_stripScripts = WorkflowExpression.Compile(stripScripts, nameof(stripScripts), required: false);
            var __workflow_stripImages = WorkflowExpression.Compile(stripImages, nameof(stripImages), required: false);
            var __workflow_stripBreaks = WorkflowExpression.Compile(stripBreaks, nameof(stripBreaks), required: false);
            var __workflow_stripClasses = WorkflowExpression.Compile(stripClasses, nameof(stripClasses), required: false);
            var __workflow_fontSize = WorkflowExpression.Compile(fontSize, nameof(fontSize), required: false);
            var __workflow_imageFloat = WorkflowExpression.Compile(imageFloat, nameof(imageFloat), required: false);
            var __workflow_imageMargin = WorkflowExpression.Compile(imageMargin, nameof(imageMargin), required: false);
            var __workflow_autoplay = WorkflowExpression.Compile(autoplay, nameof(autoplay), required: false);
            var __workflow_rel = WorkflowExpression.Compile(rel, nameof(rel), required: false);
            return new DeferredBodyAction<SyndicateMarshallerWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}/syndicate.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cssClass"] = Convert.ToString("syndicate");
                if (__workflow_cssClass != null)
                    callPayload.Queries["cssClass"] = ExpressionConverter.Convert(__workflow_cssClass);
                callPayload.Queries["stripStyles"] = Convert.ToString(false);
                if (__workflow_stripStyles != null)
                    callPayload.Queries["stripStyles"] = ExpressionConverter.Convert(__workflow_stripStyles);
                callPayload.Queries["stripScripts"] = Convert.ToString(false);
                if (__workflow_stripScripts != null)
                    callPayload.Queries["stripScripts"] = ExpressionConverter.Convert(__workflow_stripScripts);
                callPayload.Queries["stripImages"] = Convert.ToString(false);
                if (__workflow_stripImages != null)
                    callPayload.Queries["stripImages"] = ExpressionConverter.Convert(__workflow_stripImages);
                callPayload.Queries["stripBreaks"] = Convert.ToString(false);
                if (__workflow_stripBreaks != null)
                    callPayload.Queries["stripBreaks"] = ExpressionConverter.Convert(__workflow_stripBreaks);
                callPayload.Queries["stripClasses"] = Convert.ToString(false);
                if (__workflow_stripClasses != null)
                    callPayload.Queries["stripClasses"] = ExpressionConverter.Convert(__workflow_stripClasses);
                if (__workflow_fontSize != null)
                    callPayload.Queries["font-size"] = ExpressionConverter.Convert(__workflow_fontSize);
                if (__workflow_imageFloat != null)
                    callPayload.Queries["imageFloat"] = ExpressionConverter.Convert(__workflow_imageFloat);
                if (__workflow_imageMargin != null)
                    callPayload.Queries["imageMargin"] = ExpressionConverter.Convert(__workflow_imageMargin);
                callPayload.Queries["autoplay"] = Convert.ToString(true);
                if (__workflow_autoplay != null)
                    callPayload.Queries["autoplay"] = ExpressionConverter.Convert(__workflow_autoplay);
                callPayload.Queries["rel"] = Convert.ToString(false);
                if (__workflow_rel != null)
                    callPayload.Queries["rel"] = ExpressionConverter.Convert(__workflow_rel);
                return new ApiConnectionAction<SyndicateMarshallerWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MediaThumbnailGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}/thumbnail.jpg", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaYouTubeGetResponse, ApiConnectionActionConfiguration> MediaYouTubeGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MediaYouTubeGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/media/{0}/youtubeMetaData.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MediaYouTubeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaTypeHolderWrapped, ApiConnectionActionConfiguration> MediaTypesGet()
        {
            return new DeferredBodyAction<MediaTypeHolderWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/mediaTypes.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MediaTypeHolderWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SourceWrapped, ApiConnectionActionConfiguration> SourcesGet(Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> sort = null)
        {
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<SourceWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/sources.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<SourceWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<SourceWrapped, ApiConnectionActionConfiguration> SourceGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SourceWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/sources/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SourceWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> SourceMediaGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_displayMethod = WorkflowExpression.Compile(displayMethod, nameof(displayMethod), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/sources/{0}/syndicate.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_displayMethod != null)
                    callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(__workflow_displayMethod);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped, ApiConnectionActionConfiguration> TagsGet(Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null, Expression<Func<string>> name = null, Expression<Func<string>> nameContains = null, Expression<Func<int>> mediaId = null, Expression<Func<int>> typeId = null, Expression<Func<string>> typeName = null)
        {
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_nameContains = WorkflowExpression.Compile(nameContains, nameof(nameContains), required: false);
            var __workflow_mediaId = WorkflowExpression.Compile(mediaId, nameof(mediaId), required: false);
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: false);
            var __workflow_typeName = WorkflowExpression.Compile(typeName, nameof(typeName), required: false);
            return new DeferredBodyAction<TagMarshallerWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/tags.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_nameContains != null)
                    callPayload.Queries["nameContains"] = ExpressionConverter.Convert(__workflow_nameContains);
                if (__workflow_mediaId != null)
                    callPayload.Queries["mediaId"] = ExpressionConverter.Convert(__workflow_mediaId);
                if (__workflow_typeId != null)
                    callPayload.Queries["typeId"] = ExpressionConverter.Convert(__workflow_typeId);
                if (__workflow_typeName != null)
                    callPayload.Queries["typeName"] = ExpressionConverter.Convert(__workflow_typeName);
                return new ApiConnectionAction<TagMarshallerWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagLanguageMarshallerWrapped, ApiConnectionActionConfiguration> TagLanguagesGet()
        {
            return new DeferredBodyAction<TagLanguageMarshallerWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/tags/tagLanguages.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagLanguageMarshallerWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagTypeMarshallerWrapped, ApiConnectionActionConfiguration> TagMediaTypesGet()
        {
            return new DeferredBodyAction<TagTypeMarshallerWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/resources/tags/tagTypes.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagTypeMarshallerWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped, ApiConnectionActionConfiguration> TagGet(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TagMarshallerWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/tags/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagMarshallerWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> TagMediaGet(Expression<Func<int>> id, Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/tags/{0}/media.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<TagMarshallerWrapped, ApiConnectionActionConfiguration> TagRelatedGet(Expression<Func<int>> id, Expression<Func<string>> sort = null, Expression<Func<int>> max = null, Expression<Func<int>> offset = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_max = WorkflowExpression.Compile(max, nameof(max), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TagMarshallerWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/tags/{0}/related.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(__workflow_max);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<TagMarshallerWrapped>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> TagSyndicateGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_displayMethod = WorkflowExpression.Compile(displayMethod, nameof(displayMethod), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/tags/{0}/syndicate.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_displayMethod != null)
                    callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(__workflow_displayMethod);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hhsmediaservices")]
        public IBodyWorkflowAction<MediaItemWrapped, ApiConnectionActionConfiguration> MediaListGet(Expression<Func<int>> id, Expression<Func<string>> displayMethod = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_displayMethod = WorkflowExpression.Compile(displayMethod, nameof(displayMethod), required: false);
            return new DeferredBodyAction<MediaItemWrapped, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/userMediaLists/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_displayMethod != null)
                    callPayload.Queries["displayMethod"] = ExpressionConverter.Convert(__workflow_displayMethod);
                return new ApiConnectionAction<MediaItemWrapped>(callPayload);
            });
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