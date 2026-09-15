//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Factset
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FactsetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetHeadlinesResponse> GetHeadlines(Expression<Func<string>> createdGt = null, Expression<Func<string>> createdLt = null, Expression<Func<string>> signalIds = null, Expression<Func<string>> ids = null, Expression<Func<double>> userRelevanceScoreGt = null, Expression<Func<double>> userRelevanceScoreLt = null, Expression<Func<string>> sort = null, Expression<Func<double>> userRelevanceScoreGte = null, Expression<Func<double>> userRelevanceScoreLte = null, Expression<Func<string>> updatedGt = null, Expression<Func<string>> updatedLt = null, Expression<Func<string>> createdGte = null, Expression<Func<string>> updatedGte = null, Expression<Func<string>> createdLte = null, Expression<Func<string>> updatedLte = null, Expression<Func<string>> portfolios = null, Expression<Func<string>> themes = null, Expression<Func<string>> categories = null)
        {
            var apiCallPath = "/signals/v2/events/headlines";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdGt != null)
                callPayload.Queries["created[gt]"] = CSharpExpressionConverter.ConvertO(createdGt);
            if (createdLt != null)
                callPayload.Queries["created[lt]"] = CSharpExpressionConverter.ConvertO(createdLt);
            if (signalIds != null)
                callPayload.Queries["signalIds"] = CSharpExpressionConverter.ConvertO(signalIds);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (userRelevanceScoreGt != null)
                callPayload.Queries["userRelevanceScore[gt]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreGt);
            if (userRelevanceScoreLt != null)
                callPayload.Queries["userRelevanceScore[lt]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreLt);
            callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (userRelevanceScoreGte != null)
                callPayload.Queries["userRelevanceScore[gte]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreGte);
            if (userRelevanceScoreLte != null)
                callPayload.Queries["userRelevanceScore[lte]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreLte);
            if (updatedGt != null)
                callPayload.Queries["updated[gt]"] = CSharpExpressionConverter.ConvertO(updatedGt);
            if (updatedLt != null)
                callPayload.Queries["updated[lt]"] = CSharpExpressionConverter.ConvertO(updatedLt);
            if (createdGte != null)
                callPayload.Queries["created[gte]"] = CSharpExpressionConverter.ConvertO(createdGte);
            if (updatedGte != null)
                callPayload.Queries["updated[gte]"] = CSharpExpressionConverter.ConvertO(updatedGte);
            if (createdLte != null)
                callPayload.Queries["created[lte]"] = CSharpExpressionConverter.ConvertO(createdLte);
            if (updatedLte != null)
                callPayload.Queries["updated[lte]"] = CSharpExpressionConverter.ConvertO(updatedLte);
            if (portfolios != null)
                callPayload.Queries["portfolios"] = CSharpExpressionConverter.ConvertO(portfolios);
            if (themes != null)
                callPayload.Queries["themes"] = CSharpExpressionConverter.ConvertO(themes);
            if (categories != null)
                callPayload.Queries["categories"] = CSharpExpressionConverter.ConvertO(categories);
            return new ApiConnectionAction<GetHeadlinesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetDetailsResponse> GetDetails(Expression<Func<string>> signalIds = null, Expression<Func<string>> ids = null, Expression<Func<double>> userRelevanceScoreGt = null, Expression<Func<string>> sort = null, Expression<Func<double>> userRelevanceScoreLt = null, Expression<Func<double>> userRelevanceScoreLte = null, Expression<Func<double>> userRelevanceScoreGte = null, Expression<Func<string>> updatedGt = null, Expression<Func<string>> updatedLt = null, Expression<Func<string>> createdGte = null, Expression<Func<string>> updatedGte = null, Expression<Func<string>> createdLte = null, Expression<Func<string>> updatedLte = null, Expression<Func<string>> portfolios = null, Expression<Func<string>> themes = null, Expression<Func<string>> categories = null)
        {
            var apiCallPath = "/signals/v2/events/details";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (signalIds != null)
                callPayload.Queries["signalIds"] = CSharpExpressionConverter.ConvertO(signalIds);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (userRelevanceScoreGt != null)
                callPayload.Queries["userRelevanceScore[gt]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreGt);
            callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (userRelevanceScoreLt != null)
                callPayload.Queries["userRelevanceScore[lt]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreLt);
            if (userRelevanceScoreLte != null)
                callPayload.Queries["userRelevanceScore[lte]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreLte);
            if (userRelevanceScoreGte != null)
                callPayload.Queries["userRelevanceScore[gte]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreGte);
            if (updatedGt != null)
                callPayload.Queries["updated[gt]"] = CSharpExpressionConverter.ConvertO(updatedGt);
            if (updatedLt != null)
                callPayload.Queries["updated[lt]"] = CSharpExpressionConverter.ConvertO(updatedLt);
            if (createdGte != null)
                callPayload.Queries["created[gte]"] = CSharpExpressionConverter.ConvertO(createdGte);
            if (updatedGte != null)
                callPayload.Queries["updated[gte]"] = CSharpExpressionConverter.ConvertO(updatedGte);
            if (createdLte != null)
                callPayload.Queries["created[lte]"] = CSharpExpressionConverter.ConvertO(createdLte);
            if (updatedLte != null)
                callPayload.Queries["updated[lte]"] = CSharpExpressionConverter.ConvertO(updatedLte);
            if (portfolios != null)
                callPayload.Queries["portfolios"] = CSharpExpressionConverter.ConvertO(portfolios);
            if (themes != null)
                callPayload.Queries["themes"] = CSharpExpressionConverter.ConvertO(themes);
            if (categories != null)
                callPayload.Queries["categories"] = CSharpExpressionConverter.ConvertO(categories);
            return new ApiConnectionAction<GetDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<GetAdaptiveCardResponse> GetAdaptiveCard(Expression<Func<string>> signalIds = null, Expression<Func<string>> ids = null, Expression<Func<double>> userRelevanceScoreGt = null, Expression<Func<string>> sort = null, Expression<Func<double>> userRelevanceScoreLt = null, Expression<Func<double>> userRelevanceScoreLte = null, Expression<Func<double>> userRelevanceScoreGte = null, Expression<Func<string>> updatedGt = null, Expression<Func<string>> updatedLt = null, Expression<Func<string>> createdGte = null, Expression<Func<string>> updatedGte = null, Expression<Func<string>> createdLte = null, Expression<Func<string>> updatedLte = null, Expression<Func<string>> portfolios = null, Expression<Func<string>> themes = null, Expression<Func<string>> categories = null)
        {
            var apiCallPath = "/signals/v2/events/adaptive-cards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (signalIds != null)
                callPayload.Queries["signalIds"] = CSharpExpressionConverter.ConvertO(signalIds);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (userRelevanceScoreGt != null)
                callPayload.Queries["userRelevanceScore[gt]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreGt);
            callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (userRelevanceScoreLt != null)
                callPayload.Queries["userRelevanceScore[lt]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreLt);
            if (userRelevanceScoreLte != null)
                callPayload.Queries["userRelevanceScore[lte]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreLte);
            if (userRelevanceScoreGte != null)
                callPayload.Queries["userRelevanceScore[gte]"] = CSharpExpressionConverter.ConvertO(userRelevanceScoreGte);
            if (updatedGt != null)
                callPayload.Queries["updated[gt]"] = CSharpExpressionConverter.ConvertO(updatedGt);
            if (updatedLt != null)
                callPayload.Queries["updated[lt]"] = CSharpExpressionConverter.ConvertO(updatedLt);
            if (createdGte != null)
                callPayload.Queries["created[gte]"] = CSharpExpressionConverter.ConvertO(createdGte);
            if (updatedGte != null)
                callPayload.Queries["updated[gte]"] = CSharpExpressionConverter.ConvertO(updatedGte);
            if (createdLte != null)
                callPayload.Queries["created[lte]"] = CSharpExpressionConverter.ConvertO(createdLte);
            if (updatedLte != null)
                callPayload.Queries["updated[lte]"] = CSharpExpressionConverter.ConvertO(updatedLte);
            if (portfolios != null)
                callPayload.Queries["portfolios"] = CSharpExpressionConverter.ConvertO(portfolios);
            if (themes != null)
                callPayload.Queries["themes"] = CSharpExpressionConverter.ConvertO(themes);
            if (categories != null)
                callPayload.Queries["categories"] = CSharpExpressionConverter.ConvertO(categories);
            return new ApiConnectionAction<GetAdaptiveCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<NEREntitiesResponse> NEREntities(Expression<Func<string>> bodytext, Expression<Func<bool>> bodyfilterEntities = null, Expression<Func<bool>> bodyenableIdLookup = null)
        {
            var apiCallPath = "/cognitive/ner/v2/entities";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            if (bodyfilterEntities != null)
            {
                if (bodyfilterEntities != null)
                {
                    body["filterEntities"] = CSharpExpressionConverter.ConvertToken(bodyfilterEntities);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["filterEntities"] = true;
                bodypropCount++;
            }

            if (bodyenableIdLookup != null)
            {
                if (bodyenableIdLookup != null)
                {
                    body["enableIdLookup"] = CSharpExpressionConverter.ConvertToken(bodyenableIdLookup);
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
            var apiCallPath = "/book-builder-api/v1/create-book-from-template";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyticker != null)
            {
                body["ticker"] = CSharpExpressionConverter.ConvertToken(bodyticker);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["template_id"] = CSharpExpressionConverter.ConvertToken(bodytemplateId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateBookFromTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        public IBodyWorkflowAction<JToken> GetPDF(Expression<Func<string>> bookId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/book-builder-api/v1/download-api-book/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
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