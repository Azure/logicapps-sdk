//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Factset
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FactsetActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [WorkflowExpressionFactory(nameof(__BuildGetHeadlines))]
        public IBodyWorkflowAction<GetHeadlinesResponse> GetHeadlines([WorkflowExpression] Func<string> createdGt = null, [WorkflowExpression] Func<string> createdLt = null, [WorkflowExpression] Func<string> signalIds = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<double> userRelevanceScoreGt = null, [WorkflowExpression] Func<double> userRelevanceScoreLt = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<double> userRelevanceScoreGte = null, [WorkflowExpression] Func<double> userRelevanceScoreLte = null, [WorkflowExpression] Func<string> updatedGt = null, [WorkflowExpression] Func<string> updatedLt = null, [WorkflowExpression] Func<string> createdGte = null, [WorkflowExpression] Func<string> updatedGte = null, [WorkflowExpression] Func<string> createdLte = null, [WorkflowExpression] Func<string> updatedLte = null, [WorkflowExpression] Func<string> portfolios = null, [WorkflowExpression] Func<string> themes = null, [WorkflowExpression] Func<string> categories = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetHeadlinesResponse> __BuildGetHeadlines(WorkflowExpression<string> createdGt = null, WorkflowExpression<string> createdLt = null, WorkflowExpression<string> signalIds = null, WorkflowExpression<string> ids = null, WorkflowExpression<double> userRelevanceScoreGt = null, WorkflowExpression<double> userRelevanceScoreLt = null, WorkflowExpression<string> sort = null, WorkflowExpression<double> userRelevanceScoreGte = null, WorkflowExpression<double> userRelevanceScoreLte = null, WorkflowExpression<string> updatedGt = null, WorkflowExpression<string> updatedLt = null, WorkflowExpression<string> createdGte = null, WorkflowExpression<string> updatedGte = null, WorkflowExpression<string> createdLte = null, WorkflowExpression<string> updatedLte = null, WorkflowExpression<string> portfolios = null, WorkflowExpression<string> themes = null, WorkflowExpression<string> categories = null)
        {
            WorkflowExpression.Validate(createdGt, nameof(createdGt), required: false);
            WorkflowExpression.Validate(createdLt, nameof(createdLt), required: false);
            WorkflowExpression.Validate(signalIds, nameof(signalIds), required: false);
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(userRelevanceScoreGt, nameof(userRelevanceScoreGt), required: false);
            WorkflowExpression.Validate(userRelevanceScoreLt, nameof(userRelevanceScoreLt), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(userRelevanceScoreGte, nameof(userRelevanceScoreGte), required: false);
            WorkflowExpression.Validate(userRelevanceScoreLte, nameof(userRelevanceScoreLte), required: false);
            WorkflowExpression.Validate(updatedGt, nameof(updatedGt), required: false);
            WorkflowExpression.Validate(updatedLt, nameof(updatedLt), required: false);
            WorkflowExpression.Validate(createdGte, nameof(createdGte), required: false);
            WorkflowExpression.Validate(updatedGte, nameof(updatedGte), required: false);
            WorkflowExpression.Validate(createdLte, nameof(createdLte), required: false);
            WorkflowExpression.Validate(updatedLte, nameof(updatedLte), required: false);
            WorkflowExpression.Validate(portfolios, nameof(portfolios), required: false);
            WorkflowExpression.Validate(themes, nameof(themes), required: false);
            WorkflowExpression.Validate(categories, nameof(categories), required: false);
            return new DeferredBodyAction<GetHeadlinesResponse>(() =>
            {
                var apiCallPath = "/signals/v2/events/headlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdGt != null)
                    callPayload.Queries["created[gt]"] = ExpressionConverter.Convert(createdGt);
                if (createdLt != null)
                    callPayload.Queries["created[lt]"] = ExpressionConverter.Convert(createdLt);
                if (signalIds != null)
                    callPayload.Queries["signalIds"] = ExpressionConverter.Convert(signalIds);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (userRelevanceScoreGt != null)
                    callPayload.Queries["userRelevanceScore[gt]"] = ExpressionConverter.Convert(userRelevanceScoreGt);
                if (userRelevanceScoreLt != null)
                    callPayload.Queries["userRelevanceScore[lt]"] = ExpressionConverter.Convert(userRelevanceScoreLt);
                callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (userRelevanceScoreGte != null)
                    callPayload.Queries["userRelevanceScore[gte]"] = ExpressionConverter.Convert(userRelevanceScoreGte);
                if (userRelevanceScoreLte != null)
                    callPayload.Queries["userRelevanceScore[lte]"] = ExpressionConverter.Convert(userRelevanceScoreLte);
                if (updatedGt != null)
                    callPayload.Queries["updated[gt]"] = ExpressionConverter.Convert(updatedGt);
                if (updatedLt != null)
                    callPayload.Queries["updated[lt]"] = ExpressionConverter.Convert(updatedLt);
                if (createdGte != null)
                    callPayload.Queries["created[gte]"] = ExpressionConverter.Convert(createdGte);
                if (updatedGte != null)
                    callPayload.Queries["updated[gte]"] = ExpressionConverter.Convert(updatedGte);
                if (createdLte != null)
                    callPayload.Queries["created[lte]"] = ExpressionConverter.Convert(createdLte);
                if (updatedLte != null)
                    callPayload.Queries["updated[lte]"] = ExpressionConverter.Convert(updatedLte);
                if (portfolios != null)
                    callPayload.Queries["portfolios"] = ExpressionConverter.Convert(portfolios);
                if (themes != null)
                    callPayload.Queries["themes"] = ExpressionConverter.Convert(themes);
                if (categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
                return new ApiConnectionAction<GetHeadlinesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [WorkflowExpressionFactory(nameof(__BuildGetDetails))]
        public IBodyWorkflowAction<GetDetailsResponse> GetDetails([WorkflowExpression] Func<string> signalIds = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<double> userRelevanceScoreGt = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<double> userRelevanceScoreLt = null, [WorkflowExpression] Func<double> userRelevanceScoreLte = null, [WorkflowExpression] Func<double> userRelevanceScoreGte = null, [WorkflowExpression] Func<string> updatedGt = null, [WorkflowExpression] Func<string> updatedLt = null, [WorkflowExpression] Func<string> createdGte = null, [WorkflowExpression] Func<string> updatedGte = null, [WorkflowExpression] Func<string> createdLte = null, [WorkflowExpression] Func<string> updatedLte = null, [WorkflowExpression] Func<string> portfolios = null, [WorkflowExpression] Func<string> themes = null, [WorkflowExpression] Func<string> categories = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDetailsResponse> __BuildGetDetails(WorkflowExpression<string> signalIds = null, WorkflowExpression<string> ids = null, WorkflowExpression<double> userRelevanceScoreGt = null, WorkflowExpression<string> sort = null, WorkflowExpression<double> userRelevanceScoreLt = null, WorkflowExpression<double> userRelevanceScoreLte = null, WorkflowExpression<double> userRelevanceScoreGte = null, WorkflowExpression<string> updatedGt = null, WorkflowExpression<string> updatedLt = null, WorkflowExpression<string> createdGte = null, WorkflowExpression<string> updatedGte = null, WorkflowExpression<string> createdLte = null, WorkflowExpression<string> updatedLte = null, WorkflowExpression<string> portfolios = null, WorkflowExpression<string> themes = null, WorkflowExpression<string> categories = null)
        {
            WorkflowExpression.Validate(signalIds, nameof(signalIds), required: false);
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(userRelevanceScoreGt, nameof(userRelevanceScoreGt), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(userRelevanceScoreLt, nameof(userRelevanceScoreLt), required: false);
            WorkflowExpression.Validate(userRelevanceScoreLte, nameof(userRelevanceScoreLte), required: false);
            WorkflowExpression.Validate(userRelevanceScoreGte, nameof(userRelevanceScoreGte), required: false);
            WorkflowExpression.Validate(updatedGt, nameof(updatedGt), required: false);
            WorkflowExpression.Validate(updatedLt, nameof(updatedLt), required: false);
            WorkflowExpression.Validate(createdGte, nameof(createdGte), required: false);
            WorkflowExpression.Validate(updatedGte, nameof(updatedGte), required: false);
            WorkflowExpression.Validate(createdLte, nameof(createdLte), required: false);
            WorkflowExpression.Validate(updatedLte, nameof(updatedLte), required: false);
            WorkflowExpression.Validate(portfolios, nameof(portfolios), required: false);
            WorkflowExpression.Validate(themes, nameof(themes), required: false);
            WorkflowExpression.Validate(categories, nameof(categories), required: false);
            return new DeferredBodyAction<GetDetailsResponse>(() =>
            {
                var apiCallPath = "/signals/v2/events/details";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (signalIds != null)
                    callPayload.Queries["signalIds"] = ExpressionConverter.Convert(signalIds);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (userRelevanceScoreGt != null)
                    callPayload.Queries["userRelevanceScore[gt]"] = ExpressionConverter.Convert(userRelevanceScoreGt);
                callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (userRelevanceScoreLt != null)
                    callPayload.Queries["userRelevanceScore[lt]"] = ExpressionConverter.Convert(userRelevanceScoreLt);
                if (userRelevanceScoreLte != null)
                    callPayload.Queries["userRelevanceScore[lte]"] = ExpressionConverter.Convert(userRelevanceScoreLte);
                if (userRelevanceScoreGte != null)
                    callPayload.Queries["userRelevanceScore[gte]"] = ExpressionConverter.Convert(userRelevanceScoreGte);
                if (updatedGt != null)
                    callPayload.Queries["updated[gt]"] = ExpressionConverter.Convert(updatedGt);
                if (updatedLt != null)
                    callPayload.Queries["updated[lt]"] = ExpressionConverter.Convert(updatedLt);
                if (createdGte != null)
                    callPayload.Queries["created[gte]"] = ExpressionConverter.Convert(createdGte);
                if (updatedGte != null)
                    callPayload.Queries["updated[gte]"] = ExpressionConverter.Convert(updatedGte);
                if (createdLte != null)
                    callPayload.Queries["created[lte]"] = ExpressionConverter.Convert(createdLte);
                if (updatedLte != null)
                    callPayload.Queries["updated[lte]"] = ExpressionConverter.Convert(updatedLte);
                if (portfolios != null)
                    callPayload.Queries["portfolios"] = ExpressionConverter.Convert(portfolios);
                if (themes != null)
                    callPayload.Queries["themes"] = ExpressionConverter.Convert(themes);
                if (categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
                return new ApiConnectionAction<GetDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [WorkflowExpressionFactory(nameof(__BuildGetAdaptiveCard))]
        public IBodyWorkflowAction<GetAdaptiveCardResponse> GetAdaptiveCard([WorkflowExpression] Func<string> signalIds = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<double> userRelevanceScoreGt = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<double> userRelevanceScoreLt = null, [WorkflowExpression] Func<double> userRelevanceScoreLte = null, [WorkflowExpression] Func<double> userRelevanceScoreGte = null, [WorkflowExpression] Func<string> updatedGt = null, [WorkflowExpression] Func<string> updatedLt = null, [WorkflowExpression] Func<string> createdGte = null, [WorkflowExpression] Func<string> updatedGte = null, [WorkflowExpression] Func<string> createdLte = null, [WorkflowExpression] Func<string> updatedLte = null, [WorkflowExpression] Func<string> portfolios = null, [WorkflowExpression] Func<string> themes = null, [WorkflowExpression] Func<string> categories = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAdaptiveCardResponse> __BuildGetAdaptiveCard(WorkflowExpression<string> signalIds = null, WorkflowExpression<string> ids = null, WorkflowExpression<double> userRelevanceScoreGt = null, WorkflowExpression<string> sort = null, WorkflowExpression<double> userRelevanceScoreLt = null, WorkflowExpression<double> userRelevanceScoreLte = null, WorkflowExpression<double> userRelevanceScoreGte = null, WorkflowExpression<string> updatedGt = null, WorkflowExpression<string> updatedLt = null, WorkflowExpression<string> createdGte = null, WorkflowExpression<string> updatedGte = null, WorkflowExpression<string> createdLte = null, WorkflowExpression<string> updatedLte = null, WorkflowExpression<string> portfolios = null, WorkflowExpression<string> themes = null, WorkflowExpression<string> categories = null)
        {
            WorkflowExpression.Validate(signalIds, nameof(signalIds), required: false);
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(userRelevanceScoreGt, nameof(userRelevanceScoreGt), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(userRelevanceScoreLt, nameof(userRelevanceScoreLt), required: false);
            WorkflowExpression.Validate(userRelevanceScoreLte, nameof(userRelevanceScoreLte), required: false);
            WorkflowExpression.Validate(userRelevanceScoreGte, nameof(userRelevanceScoreGte), required: false);
            WorkflowExpression.Validate(updatedGt, nameof(updatedGt), required: false);
            WorkflowExpression.Validate(updatedLt, nameof(updatedLt), required: false);
            WorkflowExpression.Validate(createdGte, nameof(createdGte), required: false);
            WorkflowExpression.Validate(updatedGte, nameof(updatedGte), required: false);
            WorkflowExpression.Validate(createdLte, nameof(createdLte), required: false);
            WorkflowExpression.Validate(updatedLte, nameof(updatedLte), required: false);
            WorkflowExpression.Validate(portfolios, nameof(portfolios), required: false);
            WorkflowExpression.Validate(themes, nameof(themes), required: false);
            WorkflowExpression.Validate(categories, nameof(categories), required: false);
            return new DeferredBodyAction<GetAdaptiveCardResponse>(() =>
            {
                var apiCallPath = "/signals/v2/events/adaptive-cards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (signalIds != null)
                    callPayload.Queries["signalIds"] = ExpressionConverter.Convert(signalIds);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (userRelevanceScoreGt != null)
                    callPayload.Queries["userRelevanceScore[gt]"] = ExpressionConverter.Convert(userRelevanceScoreGt);
                callPayload.Queries["sort"] = Convert.ToString("-userRelevanceScore,-eventDate");
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (userRelevanceScoreLt != null)
                    callPayload.Queries["userRelevanceScore[lt]"] = ExpressionConverter.Convert(userRelevanceScoreLt);
                if (userRelevanceScoreLte != null)
                    callPayload.Queries["userRelevanceScore[lte]"] = ExpressionConverter.Convert(userRelevanceScoreLte);
                if (userRelevanceScoreGte != null)
                    callPayload.Queries["userRelevanceScore[gte]"] = ExpressionConverter.Convert(userRelevanceScoreGte);
                if (updatedGt != null)
                    callPayload.Queries["updated[gt]"] = ExpressionConverter.Convert(updatedGt);
                if (updatedLt != null)
                    callPayload.Queries["updated[lt]"] = ExpressionConverter.Convert(updatedLt);
                if (createdGte != null)
                    callPayload.Queries["created[gte]"] = ExpressionConverter.Convert(createdGte);
                if (updatedGte != null)
                    callPayload.Queries["updated[gte]"] = ExpressionConverter.Convert(updatedGte);
                if (createdLte != null)
                    callPayload.Queries["created[lte]"] = ExpressionConverter.Convert(createdLte);
                if (updatedLte != null)
                    callPayload.Queries["updated[lte]"] = ExpressionConverter.Convert(updatedLte);
                if (portfolios != null)
                    callPayload.Queries["portfolios"] = ExpressionConverter.Convert(portfolios);
                if (themes != null)
                    callPayload.Queries["themes"] = ExpressionConverter.Convert(themes);
                if (categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
                return new ApiConnectionAction<GetAdaptiveCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [WorkflowExpressionFactory(nameof(__BuildNEREntities))]
        public IBodyWorkflowAction<NEREntitiesResponse> NEREntities([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodyfilterEntities = null, [WorkflowExpression] Func<bool> bodyenableIdLookup = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NEREntitiesResponse> __BuildNEREntities(WorkflowExpression<string> bodytext, WorkflowExpression<bool> bodyfilterEntities = null, WorkflowExpression<bool> bodyenableIdLookup = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyfilterEntities, nameof(bodyfilterEntities), required: false);
            WorkflowExpression.Validate(bodyenableIdLookup, nameof(bodyenableIdLookup), required: false);
            return new DeferredBodyAction<NEREntitiesResponse>(() =>
            {
                var apiCallPath = "/cognitive/ner/v2/entities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodyfilterEntities != null)
                {
                    if (bodyfilterEntities != null)
                    {
                        body["filterEntities"] = ExpressionConverter.ConvertO(bodyfilterEntities);
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
                        body["enableIdLookup"] = ExpressionConverter.ConvertO(bodyenableIdLookup);
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildCreateBookFromTemplate))]
        public IBodyWorkflowAction<CreateBookFromTemplateResponse> CreateBookFromTemplate([WorkflowExpression] Func<string> bodyticker = null, [WorkflowExpression] Func<string> bodytemplateId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateBookFromTemplateResponse> __BuildCreateBookFromTemplate(WorkflowExpression<string> bodyticker = null, WorkflowExpression<string> bodytemplateId = null)
        {
            WorkflowExpression.Validate(bodyticker, nameof(bodyticker), required: false);
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            return new DeferredBodyAction<CreateBookFromTemplateResponse>(() =>
            {
                var apiCallPath = "/book-builder-api/v1/create-book-from-template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyticker != null)
                {
                    body["ticker"] = ExpressionConverter.ConvertO(bodyticker);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBookFromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [WorkflowExpressionFactory(nameof(__BuildGetPDF))]
        public IBodyWorkflowAction<JToken> GetPDF([WorkflowExpression] Func<string> bookId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "factset")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetPDF(WorkflowExpression<string> bookId)
        {
            WorkflowExpression.Validate(bookId, nameof(bookId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/book-builder-api/v1/download-api-book/{0}", ExpressionConverter.ConvertWithUrlEncoding(bookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
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