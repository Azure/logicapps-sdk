//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Factset
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FactsetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetHeadlinesResponse> GetHeadlines(Expression<Func<string>> createdGt = null, Expression<Func<string>> createdLt = null, Expression<Func<string>> signalIds = null, Expression<Func<string>> ids = null, Expression<Func<double>> userRelevanceScoreGt = null, Expression<Func<double>> userRelevanceScoreLt = null, Expression<Func<string>> sort = null, Expression<Func<double>> userRelevanceScoreGte = null, Expression<Func<double>> userRelevanceScoreLte = null, Expression<Func<string>> updatedGt = null, Expression<Func<string>> updatedLt = null, Expression<Func<string>> createdGte = null, Expression<Func<string>> updatedGte = null, Expression<Func<string>> createdLte = null, Expression<Func<string>> updatedLte = null, Expression<Func<string>> portfolios = null, Expression<Func<string>> themes = null, Expression<Func<string>> categories = null)
        {
            var __workflow_createdGt = WorkflowExpression.Compile(createdGt, nameof(createdGt), required: false);
            var __workflow_createdLt = WorkflowExpression.Compile(createdLt, nameof(createdLt), required: false);
            var __workflow_signalIds = WorkflowExpression.Compile(signalIds, nameof(signalIds), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_userRelevanceScoreGt = WorkflowExpression.Compile(userRelevanceScoreGt, nameof(userRelevanceScoreGt), required: false);
            var __workflow_userRelevanceScoreLt = WorkflowExpression.Compile(userRelevanceScoreLt, nameof(userRelevanceScoreLt), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_userRelevanceScoreGte = WorkflowExpression.Compile(userRelevanceScoreGte, nameof(userRelevanceScoreGte), required: false);
            var __workflow_userRelevanceScoreLte = WorkflowExpression.Compile(userRelevanceScoreLte, nameof(userRelevanceScoreLte), required: false);
            var __workflow_updatedGt = WorkflowExpression.Compile(updatedGt, nameof(updatedGt), required: false);
            var __workflow_updatedLt = WorkflowExpression.Compile(updatedLt, nameof(updatedLt), required: false);
            var __workflow_createdGte = WorkflowExpression.Compile(createdGte, nameof(createdGte), required: false);
            var __workflow_updatedGte = WorkflowExpression.Compile(updatedGte, nameof(updatedGte), required: false);
            var __workflow_createdLte = WorkflowExpression.Compile(createdLte, nameof(createdLte), required: false);
            var __workflow_updatedLte = WorkflowExpression.Compile(updatedLte, nameof(updatedLte), required: false);
            var __workflow_portfolios = WorkflowExpression.Compile(portfolios, nameof(portfolios), required: false);
            var __workflow_themes = WorkflowExpression.Compile(themes, nameof(themes), required: false);
            var __workflow_categories = WorkflowExpression.Compile(categories, nameof(categories), required: false);
            return new DeferredBodyAction<GetHeadlinesResponse>(() =>
            {
                var apiCallPath = "/signals/v2/events/headlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdGt != null)
                    callPayload.Queries["created[gt]"] = ExpressionConverter.Convert(__workflow_createdGt);
                if (__workflow_createdLt != null)
                    callPayload.Queries["created[lt]"] = ExpressionConverter.Convert(__workflow_createdLt);
                if (__workflow_signalIds != null)
                    callPayload.Queries["signalIds"] = ExpressionConverter.Convert(__workflow_signalIds);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_userRelevanceScoreGt != null)
                    callPayload.Queries["userRelevanceScore[gt]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreGt);
                if (__workflow_userRelevanceScoreLt != null)
                    callPayload.Queries["userRelevanceScore[lt]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreLt);
                callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_userRelevanceScoreGte != null)
                    callPayload.Queries["userRelevanceScore[gte]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreGte);
                if (__workflow_userRelevanceScoreLte != null)
                    callPayload.Queries["userRelevanceScore[lte]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreLte);
                if (__workflow_updatedGt != null)
                    callPayload.Queries["updated[gt]"] = ExpressionConverter.Convert(__workflow_updatedGt);
                if (__workflow_updatedLt != null)
                    callPayload.Queries["updated[lt]"] = ExpressionConverter.Convert(__workflow_updatedLt);
                if (__workflow_createdGte != null)
                    callPayload.Queries["created[gte]"] = ExpressionConverter.Convert(__workflow_createdGte);
                if (__workflow_updatedGte != null)
                    callPayload.Queries["updated[gte]"] = ExpressionConverter.Convert(__workflow_updatedGte);
                if (__workflow_createdLte != null)
                    callPayload.Queries["created[lte]"] = ExpressionConverter.Convert(__workflow_createdLte);
                if (__workflow_updatedLte != null)
                    callPayload.Queries["updated[lte]"] = ExpressionConverter.Convert(__workflow_updatedLte);
                if (__workflow_portfolios != null)
                    callPayload.Queries["portfolios"] = ExpressionConverter.Convert(__workflow_portfolios);
                if (__workflow_themes != null)
                    callPayload.Queries["themes"] = ExpressionConverter.Convert(__workflow_themes);
                if (__workflow_categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(__workflow_categories);
                return new ApiConnectionAction<GetHeadlinesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetDetailsResponse> GetDetails(Expression<Func<string>> signalIds = null, Expression<Func<string>> ids = null, Expression<Func<double>> userRelevanceScoreGt = null, Expression<Func<string>> sort = null, Expression<Func<double>> userRelevanceScoreLt = null, Expression<Func<double>> userRelevanceScoreLte = null, Expression<Func<double>> userRelevanceScoreGte = null, Expression<Func<string>> updatedGt = null, Expression<Func<string>> updatedLt = null, Expression<Func<string>> createdGte = null, Expression<Func<string>> updatedGte = null, Expression<Func<string>> createdLte = null, Expression<Func<string>> updatedLte = null, Expression<Func<string>> portfolios = null, Expression<Func<string>> themes = null, Expression<Func<string>> categories = null)
        {
            var __workflow_signalIds = WorkflowExpression.Compile(signalIds, nameof(signalIds), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_userRelevanceScoreGt = WorkflowExpression.Compile(userRelevanceScoreGt, nameof(userRelevanceScoreGt), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_userRelevanceScoreLt = WorkflowExpression.Compile(userRelevanceScoreLt, nameof(userRelevanceScoreLt), required: false);
            var __workflow_userRelevanceScoreLte = WorkflowExpression.Compile(userRelevanceScoreLte, nameof(userRelevanceScoreLte), required: false);
            var __workflow_userRelevanceScoreGte = WorkflowExpression.Compile(userRelevanceScoreGte, nameof(userRelevanceScoreGte), required: false);
            var __workflow_updatedGt = WorkflowExpression.Compile(updatedGt, nameof(updatedGt), required: false);
            var __workflow_updatedLt = WorkflowExpression.Compile(updatedLt, nameof(updatedLt), required: false);
            var __workflow_createdGte = WorkflowExpression.Compile(createdGte, nameof(createdGte), required: false);
            var __workflow_updatedGte = WorkflowExpression.Compile(updatedGte, nameof(updatedGte), required: false);
            var __workflow_createdLte = WorkflowExpression.Compile(createdLte, nameof(createdLte), required: false);
            var __workflow_updatedLte = WorkflowExpression.Compile(updatedLte, nameof(updatedLte), required: false);
            var __workflow_portfolios = WorkflowExpression.Compile(portfolios, nameof(portfolios), required: false);
            var __workflow_themes = WorkflowExpression.Compile(themes, nameof(themes), required: false);
            var __workflow_categories = WorkflowExpression.Compile(categories, nameof(categories), required: false);
            return new DeferredBodyAction<GetDetailsResponse>(() =>
            {
                var apiCallPath = "/signals/v2/events/details";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_signalIds != null)
                    callPayload.Queries["signalIds"] = ExpressionConverter.Convert(__workflow_signalIds);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_userRelevanceScoreGt != null)
                    callPayload.Queries["userRelevanceScore[gt]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreGt);
                callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_userRelevanceScoreLt != null)
                    callPayload.Queries["userRelevanceScore[lt]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreLt);
                if (__workflow_userRelevanceScoreLte != null)
                    callPayload.Queries["userRelevanceScore[lte]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreLte);
                if (__workflow_userRelevanceScoreGte != null)
                    callPayload.Queries["userRelevanceScore[gte]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreGte);
                if (__workflow_updatedGt != null)
                    callPayload.Queries["updated[gt]"] = ExpressionConverter.Convert(__workflow_updatedGt);
                if (__workflow_updatedLt != null)
                    callPayload.Queries["updated[lt]"] = ExpressionConverter.Convert(__workflow_updatedLt);
                if (__workflow_createdGte != null)
                    callPayload.Queries["created[gte]"] = ExpressionConverter.Convert(__workflow_createdGte);
                if (__workflow_updatedGte != null)
                    callPayload.Queries["updated[gte]"] = ExpressionConverter.Convert(__workflow_updatedGte);
                if (__workflow_createdLte != null)
                    callPayload.Queries["created[lte]"] = ExpressionConverter.Convert(__workflow_createdLte);
                if (__workflow_updatedLte != null)
                    callPayload.Queries["updated[lte]"] = ExpressionConverter.Convert(__workflow_updatedLte);
                if (__workflow_portfolios != null)
                    callPayload.Queries["portfolios"] = ExpressionConverter.Convert(__workflow_portfolios);
                if (__workflow_themes != null)
                    callPayload.Queries["themes"] = ExpressionConverter.Convert(__workflow_themes);
                if (__workflow_categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(__workflow_categories);
                return new ApiConnectionAction<GetDetailsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetAdaptiveCardResponse> GetAdaptiveCard(Expression<Func<string>> signalIds = null, Expression<Func<string>> ids = null, Expression<Func<double>> userRelevanceScoreGt = null, Expression<Func<string>> sort = null, Expression<Func<double>> userRelevanceScoreLt = null, Expression<Func<double>> userRelevanceScoreLte = null, Expression<Func<double>> userRelevanceScoreGte = null, Expression<Func<string>> updatedGt = null, Expression<Func<string>> updatedLt = null, Expression<Func<string>> createdGte = null, Expression<Func<string>> updatedGte = null, Expression<Func<string>> createdLte = null, Expression<Func<string>> updatedLte = null, Expression<Func<string>> portfolios = null, Expression<Func<string>> themes = null, Expression<Func<string>> categories = null)
        {
            var __workflow_signalIds = WorkflowExpression.Compile(signalIds, nameof(signalIds), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_userRelevanceScoreGt = WorkflowExpression.Compile(userRelevanceScoreGt, nameof(userRelevanceScoreGt), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_userRelevanceScoreLt = WorkflowExpression.Compile(userRelevanceScoreLt, nameof(userRelevanceScoreLt), required: false);
            var __workflow_userRelevanceScoreLte = WorkflowExpression.Compile(userRelevanceScoreLte, nameof(userRelevanceScoreLte), required: false);
            var __workflow_userRelevanceScoreGte = WorkflowExpression.Compile(userRelevanceScoreGte, nameof(userRelevanceScoreGte), required: false);
            var __workflow_updatedGt = WorkflowExpression.Compile(updatedGt, nameof(updatedGt), required: false);
            var __workflow_updatedLt = WorkflowExpression.Compile(updatedLt, nameof(updatedLt), required: false);
            var __workflow_createdGte = WorkflowExpression.Compile(createdGte, nameof(createdGte), required: false);
            var __workflow_updatedGte = WorkflowExpression.Compile(updatedGte, nameof(updatedGte), required: false);
            var __workflow_createdLte = WorkflowExpression.Compile(createdLte, nameof(createdLte), required: false);
            var __workflow_updatedLte = WorkflowExpression.Compile(updatedLte, nameof(updatedLte), required: false);
            var __workflow_portfolios = WorkflowExpression.Compile(portfolios, nameof(portfolios), required: false);
            var __workflow_themes = WorkflowExpression.Compile(themes, nameof(themes), required: false);
            var __workflow_categories = WorkflowExpression.Compile(categories, nameof(categories), required: false);
            return new DeferredBodyAction<GetAdaptiveCardResponse>(() =>
            {
                var apiCallPath = "/signals/v2/events/adaptive-cards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_signalIds != null)
                    callPayload.Queries["signalIds"] = ExpressionConverter.Convert(__workflow_signalIds);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_userRelevanceScoreGt != null)
                    callPayload.Queries["userRelevanceScore[gt]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreGt);
                callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_userRelevanceScoreLt != null)
                    callPayload.Queries["userRelevanceScore[lt]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreLt);
                if (__workflow_userRelevanceScoreLte != null)
                    callPayload.Queries["userRelevanceScore[lte]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreLte);
                if (__workflow_userRelevanceScoreGte != null)
                    callPayload.Queries["userRelevanceScore[gte]"] = ExpressionConverter.Convert(__workflow_userRelevanceScoreGte);
                if (__workflow_updatedGt != null)
                    callPayload.Queries["updated[gt]"] = ExpressionConverter.Convert(__workflow_updatedGt);
                if (__workflow_updatedLt != null)
                    callPayload.Queries["updated[lt]"] = ExpressionConverter.Convert(__workflow_updatedLt);
                if (__workflow_createdGte != null)
                    callPayload.Queries["created[gte]"] = ExpressionConverter.Convert(__workflow_createdGte);
                if (__workflow_updatedGte != null)
                    callPayload.Queries["updated[gte]"] = ExpressionConverter.Convert(__workflow_updatedGte);
                if (__workflow_createdLte != null)
                    callPayload.Queries["created[lte]"] = ExpressionConverter.Convert(__workflow_createdLte);
                if (__workflow_updatedLte != null)
                    callPayload.Queries["updated[lte]"] = ExpressionConverter.Convert(__workflow_updatedLte);
                if (__workflow_portfolios != null)
                    callPayload.Queries["portfolios"] = ExpressionConverter.Convert(__workflow_portfolios);
                if (__workflow_themes != null)
                    callPayload.Queries["themes"] = ExpressionConverter.Convert(__workflow_themes);
                if (__workflow_categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(__workflow_categories);
                return new ApiConnectionAction<GetAdaptiveCardResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<NEREntitiesResponse> NEREntities(Expression<Func<string>> bodytext, Expression<Func<bool>> bodyfilterEntities = null, Expression<Func<bool>> bodyenableIdLookup = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyfilterEntities = WorkflowExpression.Compile(bodyfilterEntities, nameof(bodyfilterEntities), required: false);
            var __workflow_bodyenableIdLookup = WorkflowExpression.Compile(bodyenableIdLookup, nameof(bodyenableIdLookup), required: false);
            return new DeferredBodyAction<NEREntitiesResponse>(() =>
            {
                var apiCallPath = "/cognitive/ner/v2/entities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyfilterEntities != null)
                {
                    if (__workflow_bodyfilterEntities != null)
                    {
                        body["filterEntities"] = ExpressionConverter.ConvertO(__workflow_bodyfilterEntities);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["filterEntities"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyenableIdLookup != null)
                {
                    if (__workflow_bodyenableIdLookup != null)
                    {
                        body["enableIdLookup"] = ExpressionConverter.ConvertO(__workflow_bodyenableIdLookup);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enableIdLookup"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NEREntitiesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetBookListResponseItem[]> GetBookList()
        {
            var apiCallPath = "/book-builder-api/v1/book-list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBookListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetTemplateListResponseItem[]> GetTemplateList()
        {
            var apiCallPath = "/book-builder-api/v1/template-list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTemplateListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<CreateBookFromTemplateResponse> CreateBookFromTemplate(Expression<Func<string>> bodyticker = null, Expression<Func<string>> bodytemplateId = null)
        {
            var __workflow_bodyticker = WorkflowExpression.Compile(bodyticker, nameof(bodyticker), required: false);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            return new DeferredBodyAction<CreateBookFromTemplateResponse>(() =>
            {
                var apiCallPath = "/book-builder-api/v1/create-book-from-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyticker != null)
                {
                    body["ticker"] = ExpressionConverter.ConvertO(__workflow_bodyticker);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBookFromTemplateResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<JToken> GetPDF(Expression<Func<string>> bookId)
        {
            var __workflow_bookId = WorkflowExpression.Compile(bookId, nameof(bookId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/book-builder-api/v1/download-api-book/{0}", __workflow_bookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class FactsetTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetHeadlinesResponse
    {
        [JsonProperty("data")]
        public GetHeadlinesResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public GetHeadlinesResponseMetaType Meta { get; set; }

        [JsonProperty("errors")]
        public GetHeadlinesResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class GetHeadlinesResponseDataTypeItem
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("signalId")]
        public string SignalId { get; set; }

        [JsonProperty("signalName")]
        public string SignalName { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("eventDate")]
        public string EventDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("userRelevanceScore")]
        public double UserRelevanceScore { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class GetHeadlinesResponseMetaType
    {
        [JsonProperty("signalRequestId")]
        public string SignalRequestId { get; set; }

        [JsonProperty("sort")]
        public string[] Sort { get; set; }

        [JsonProperty("pagination")]
        public GetHeadlinesResponseMetaTypePaginationType Pagination { get; set; }

        [JsonProperty("idResolutions")]
        public GetHeadlinesResponseMetaTypeIdResolutionsType IdResolutions { get; set; }

        [JsonProperty("dateRange")]
        public GetHeadlinesResponseMetaTypeDateRangeType DateRange { get; set; }
    }

    public class GetHeadlinesResponseMetaTypePaginationType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("isEstimatedTotal")]
        public bool IsEstimatedTotal { get; set; }
    }

    public class GetHeadlinesResponseMetaTypeIdResolutionsType
    {
        [JsonProperty("tickerRegion")]
        public GetHeadlinesResponseMetaTypeIdResolutionsTypeTickerRegionType TickerRegion { get; set; }

        [JsonProperty("regionalPermId")]
        public GetHeadlinesResponseMetaTypeIdResolutionsTypeRegionalPermIdType RegionalPermId { get; set; }
    }

    public class GetHeadlinesResponseMetaTypeIdResolutionsTypeTickerRegionType
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class GetHeadlinesResponseMetaTypeIdResolutionsTypeRegionalPermIdType
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class GetHeadlinesResponseMetaTypeDateRangeType
    {
        [JsonProperty("created")]
        public GetHeadlinesResponseMetaTypeDateRangeTypeCreatedType Created { get; set; }

        [JsonProperty("updated")]
        public GetHeadlinesResponseMetaTypeDateRangeTypeUpdatedType Updated { get; set; }
    }

    public class GetHeadlinesResponseMetaTypeDateRangeTypeCreatedType
    {
        [JsonProperty("gt")]
        public string Gt { get; set; }
    }

    public class GetHeadlinesResponseMetaTypeDateRangeTypeUpdatedType
    {
        [JsonProperty("gt")]
        public string Gt { get; set; }
    }

    public class GetHeadlinesResponseErrorsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("source")]
        public GetHeadlinesResponseErrorsTypeItemSourceType Source { get; set; }
    }

    public class GetHeadlinesResponseErrorsTypeItemSourceType
    {
        [JsonProperty("parameter")]
        public string Parameter { get; set; }
    }

    public class GetDetailsResponse
    {
        [JsonProperty("data")]
        public GetDetailsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public GetDetailsResponseMetaType Meta { get; set; }

        [JsonProperty("errors")]
        public GetDetailsResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class GetDetailsResponseDataTypeItem
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("signalId")]
        public string SignalId { get; set; }

        [JsonProperty("signalName")]
        public string SignalName { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("eventDate")]
        public string EventDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("userRelevanceScore")]
        public double UserRelevanceScore { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("details")]
        public GetDetailsResponseDataTypeItemDetailsType Details { get; set; }
    }

    public class GetDetailsResponseDataTypeItemDetailsType
    {
        [JsonProperty("additionalProp1")]
        public JToken AdditionalProp1 { get; set; }
    }

    public class GetDetailsResponseMetaType
    {
        [JsonProperty("signalRequestId")]
        public string SignalRequestId { get; set; }

        [JsonProperty("sort")]
        public string[] Sort { get; set; }

        [JsonProperty("pagination")]
        public GetDetailsResponseMetaTypePaginationType Pagination { get; set; }

        [JsonProperty("idResolutions")]
        public GetDetailsResponseMetaTypeIdResolutionsType IdResolutions { get; set; }

        [JsonProperty("dateRange")]
        public GetDetailsResponseMetaTypeDateRangeType DateRange { get; set; }
    }

    public class GetDetailsResponseMetaTypePaginationType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("isEstimatedTotal")]
        public bool IsEstimatedTotal { get; set; }
    }

    public class GetDetailsResponseMetaTypeIdResolutionsType
    {
        [JsonProperty("tickerRegion")]
        public GetDetailsResponseMetaTypeIdResolutionsTypeTickerRegionType TickerRegion { get; set; }

        [JsonProperty("regionalPermId")]
        public GetDetailsResponseMetaTypeIdResolutionsTypeRegionalPermIdType RegionalPermId { get; set; }
    }

    public class GetDetailsResponseMetaTypeIdResolutionsTypeTickerRegionType
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class GetDetailsResponseMetaTypeIdResolutionsTypeRegionalPermIdType
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class GetDetailsResponseMetaTypeDateRangeType
    {
        [JsonProperty("created")]
        public GetDetailsResponseMetaTypeDateRangeTypeCreatedType Created { get; set; }

        [JsonProperty("updated")]
        public GetDetailsResponseMetaTypeDateRangeTypeUpdatedType Updated { get; set; }
    }

    public class GetDetailsResponseMetaTypeDateRangeTypeCreatedType
    {
        [JsonProperty("gt")]
        public string Gt { get; set; }
    }

    public class GetDetailsResponseMetaTypeDateRangeTypeUpdatedType
    {
        [JsonProperty("gt")]
        public string Gt { get; set; }
    }

    public class GetDetailsResponseErrorsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("source")]
        public GetDetailsResponseErrorsTypeItemSourceType Source { get; set; }
    }

    public class GetDetailsResponseErrorsTypeItemSourceType
    {
        [JsonProperty("parameter")]
        public string Parameter { get; set; }
    }

    public class GetAdaptiveCardResponse
    {
        [JsonProperty("data")]
        public GetAdaptiveCardResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public GetAdaptiveCardResponseMetaType Meta { get; set; }

        [JsonProperty("errors")]
        public GetAdaptiveCardResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class GetAdaptiveCardResponseDataTypeItem
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("signalId")]
        public string SignalId { get; set; }

        [JsonProperty("adaptiveCard")]
        public GetAdaptiveCardResponseDataTypeItemAdaptiveCardType AdaptiveCard { get; set; }
    }

    public class GetAdaptiveCardResponseDataTypeItemAdaptiveCardType
    {
        [JsonProperty("additionalProp1")]
        public JToken AdditionalProp1 { get; set; }
    }

    public class GetAdaptiveCardResponseMetaType
    {
        [JsonProperty("signalRequestId")]
        public string SignalRequestId { get; set; }

        [JsonProperty("sort")]
        public string[] Sort { get; set; }

        [JsonProperty("pagination")]
        public GetAdaptiveCardResponseMetaTypePaginationType Pagination { get; set; }

        [JsonProperty("idResolutions")]
        public GetAdaptiveCardResponseMetaTypeIdResolutionsType IdResolutions { get; set; }

        [JsonProperty("dateRange")]
        public GetAdaptiveCardResponseMetaTypeDateRangeType DateRange { get; set; }
    }

    public class GetAdaptiveCardResponseMetaTypePaginationType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("isEstimatedTotal")]
        public bool IsEstimatedTotal { get; set; }
    }

    public class GetAdaptiveCardResponseMetaTypeIdResolutionsType
    {
        [JsonProperty("tickerRegion")]
        public GetAdaptiveCardResponseMetaTypeIdResolutionsTypeTickerRegionType TickerRegion { get; set; }

        [JsonProperty("regionalPermId")]
        public GetAdaptiveCardResponseMetaTypeIdResolutionsTypeRegionalPermIdType RegionalPermId { get; set; }
    }

    public class GetAdaptiveCardResponseMetaTypeIdResolutionsTypeTickerRegionType
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class GetAdaptiveCardResponseMetaTypeIdResolutionsTypeRegionalPermIdType
    {
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class GetAdaptiveCardResponseMetaTypeDateRangeType
    {
        [JsonProperty("created")]
        public GetAdaptiveCardResponseMetaTypeDateRangeTypeCreatedType Created { get; set; }

        [JsonProperty("updated")]
        public GetAdaptiveCardResponseMetaTypeDateRangeTypeUpdatedType Updated { get; set; }
    }

    public class GetAdaptiveCardResponseMetaTypeDateRangeTypeCreatedType
    {
        [JsonProperty("gt")]
        public string Gt { get; set; }
    }

    public class GetAdaptiveCardResponseMetaTypeDateRangeTypeUpdatedType
    {
        [JsonProperty("gt")]
        public string Gt { get; set; }
    }

    public class GetAdaptiveCardResponseErrorsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("source")]
        public GetAdaptiveCardResponseErrorsTypeItemSourceType Source { get; set; }
    }

    public class GetAdaptiveCardResponseErrorsTypeItemSourceType
    {
        [JsonProperty("parameter")]
        public string Parameter { get; set; }
    }

    public class NEREntitiesResponse
    {
        [JsonProperty("entities")]
        public NEREntitiesResponseEntitiesTypeItem[] Entities { get; set; }
    }

    public class NEREntitiesResponseEntitiesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("startChar")]
        public int StartChar { get; set; }

        [JsonProperty("endChar")]
        public int EndChar { get; set; }

        [JsonProperty("lookupText")]
        public string LookupText { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("lookupUrl")]
        public string LookupUrl { get; set; }

        [JsonProperty("associatedOrgs")]
        public NEREntitiesResponseEntitiesTypeItemAssociatedOrgsTypeItem[] AssociatedOrgs { get; set; }
    }

    public class NEREntitiesResponseEntitiesTypeItemAssociatedOrgsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("lookupUrl")]
        public string LookupUrl { get; set; }
    }

    public class GetBookListResponseItem
    {
        [JsonProperty("bookID")]
        public int BookID { get; set; }

        [JsonProperty("book_name")]
        public string BookName { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
    }

    public class GetTemplateListResponseItem
    {
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("template_source")]
        public string TemplateSource { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateBookFromTemplateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("bookName")]
        public string BookName { get; set; }

        [JsonProperty("bookID")]
        public string BookID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Factset;

    public partial class WorkflowManagedActions
    {
        public FactsetActions Factset(string connectionId) => new FactsetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FactsetTriggers Factset(string connectionId) => new FactsetTriggers(connectionId);
    }
}
