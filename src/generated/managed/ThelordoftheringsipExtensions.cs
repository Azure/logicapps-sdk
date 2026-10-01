//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thelordoftheringsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThelordoftheringsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<BookListResponse> BookList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/book";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<BookListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<BookGetResponse> BookGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/book/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<BookGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<BookGetChaptersResponse> BookGetChapters([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/book/{0}/chapter", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<BookGetChaptersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<MovieListResponse> MovieList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/movie";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<MovieListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<MovieGetResponse> MovieGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/movie/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<MovieGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<MovieGetQuoteResponse> MovieGetQuote([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/movie/{0}/quote", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<MovieGetQuoteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<CharacterListResponse> CharacterList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/character";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<CharacterListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<CharacterGetResponse> CharacterGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/character/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<CharacterGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<CharacterGetQuoteResponse> CharacterGetQuote([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/character/{0}/quote", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<CharacterGetQuoteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<QuoteListResponse> QuoteList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/quote";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<QuoteListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<QuoteGetResponse> QuoteGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/quote/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<QuoteGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<ChapterListResponse> ChapterList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/chapter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<ChapterListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<ChapterGetResponse> ChapterGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/chapter/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sorting != null)
                    callPayload.Queries["sorting"] = SourceExpressionConverter.ConvertO(sorting);
                return callPayload;
            }

            return new ApiConnectionAction<ChapterGetResponse>(BuildSourceInput);
        }
    }

    public class ThelordoftheringsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BookListResponse
    {
        [JsonProperty("docs")]
        public BookListResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class BookListResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BookGetResponse
    {
        [JsonProperty("docs")]
        public BookGetResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class BookGetResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BookGetChaptersResponse
    {
        [JsonProperty("docs")]
        public BookGetChaptersResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class BookGetChaptersResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("chapterName")]
        public string ChapterName { get; set; }
    }

    public class MovieListResponse
    {
        [JsonProperty("docs")]
        public MovieListResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class MovieListResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("runtimeInMinutes")]
        public int RuntimeInMinutes { get; set; }

        [JsonProperty("budgetInMillions")]
        public int BudgetInMillions { get; set; }

        [JsonProperty("boxOfficeRevenueInMillions")]
        public int BoxOfficeRevenueInMillions { get; set; }

        [JsonProperty("academyAwardNominations")]
        public int AcademyAwardNominations { get; set; }

        [JsonProperty("academyAwardWins")]
        public int AcademyAwardWins { get; set; }

        [JsonProperty("rottenTomatoesScore")]
        public double RottenTomatoesScore { get; set; }
    }

    public class MovieGetResponse
    {
        [JsonProperty("docs")]
        public MovieGetResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class MovieGetResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("runtimeInMinutes")]
        public int RuntimeInMinutes { get; set; }

        [JsonProperty("budgetInMillions")]
        public int BudgetInMillions { get; set; }

        [JsonProperty("boxOfficeRevenueInMillions")]
        public int BoxOfficeRevenueInMillions { get; set; }

        [JsonProperty("academyAwardNominations")]
        public int AcademyAwardNominations { get; set; }

        [JsonProperty("academyAwardWins")]
        public int AcademyAwardWins { get; set; }

        [JsonProperty("rottenTomatoesScore")]
        public int RottenTomatoesScore { get; set; }
    }

    public class MovieGetQuoteResponse
    {
        [JsonProperty("docs")]
        public MovieGetQuoteResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class MovieGetQuoteResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("dialog")]
        public string Dialog { get; set; }

        [JsonProperty("movie")]
        public string Movie { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }
    }

    public class CharacterListResponse
    {
        [JsonProperty("docs")]
        public CharacterListResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class CharacterListResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birth")]
        public string Birth { get; set; }

        [JsonProperty("spouse")]
        public string Spouse { get; set; }

        [JsonProperty("death")]
        public string Death { get; set; }

        [JsonProperty("realm")]
        public string Realm { get; set; }

        [JsonProperty("hair")]
        public string Hair { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("wikiUrl")]
        public string WikiUrl { get; set; }
    }

    public class CharacterGetResponse
    {
        [JsonProperty("docs")]
        public CharacterGetResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class CharacterGetResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birth")]
        public string Birth { get; set; }

        [JsonProperty("spouse")]
        public string Spouse { get; set; }

        [JsonProperty("death")]
        public string Death { get; set; }

        [JsonProperty("realm")]
        public string Realm { get; set; }

        [JsonProperty("hair")]
        public string Hair { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("wikiUrl")]
        public string WikiUrl { get; set; }
    }

    public class CharacterGetQuoteResponse
    {
        [JsonProperty("docs")]
        public CharacterGetQuoteResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class CharacterGetQuoteResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("dialog")]
        public string Dialog { get; set; }

        [JsonProperty("movie")]
        public string Movie { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }
    }

    public class QuoteListResponse
    {
        [JsonProperty("docs")]
        public QuoteListResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class QuoteListResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("dialog")]
        public string Dialog { get; set; }

        [JsonProperty("movie")]
        public string Movie { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }
    }

    public class QuoteGetResponse
    {
        [JsonProperty("docs")]
        public QuoteGetResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class QuoteGetResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("dialog")]
        public string Dialog { get; set; }

        [JsonProperty("movie")]
        public string Movie { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }
    }

    public class ChapterListResponse
    {
        [JsonProperty("docs")]
        public ChapterListResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class ChapterListResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("chapterName")]
        public string ChapterName { get; set; }

        [JsonProperty("book")]
        public string Book { get; set; }
    }

    public class ChapterGetResponse
    {
        [JsonProperty("docs")]
        public ChapterGetResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class ChapterGetResponseDocsTypeItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("chapterName")]
        public string ChapterName { get; set; }

        [JsonProperty("book")]
        public string Book { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Thelordoftheringsip;

    public partial class WorkflowManagedActions
    {
        public ThelordoftheringsipActions Thelordoftheringsip(string connectionId) => new ThelordoftheringsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThelordoftheringsipTriggers Thelordoftheringsip(string connectionId) => new ThelordoftheringsipTriggers(connectionId);
    }
}