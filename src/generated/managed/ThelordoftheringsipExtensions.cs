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
        public IBodyWorkflowAction<BookListResponse> BookList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = "/book";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<BookListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<BookGetResponse> BookGet(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/book/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<BookGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<BookGetChaptersResponse> BookGetChapters(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/book/{0}/chapter", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<BookGetChaptersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<MovieListResponse> MovieList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = "/movie";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<MovieListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<MovieGetResponse> MovieGet(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/movie/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<MovieGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<MovieGetQuoteResponse> MovieGetQuote(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/movie/{0}/quote", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<MovieGetQuoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<CharacterListResponse> CharacterList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = "/character";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<CharacterListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<CharacterGetResponse> CharacterGet(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/character/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<CharacterGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<CharacterGetQuoteResponse> CharacterGetQuote(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/character/{0}/quote", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<CharacterGetQuoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<QuoteListResponse> QuoteList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = "/quote";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<QuoteListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<QuoteGetResponse> QuoteGet(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/quote/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<QuoteGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<ChapterListResponse> ChapterList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = "/chapter";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<ChapterListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        public IBodyWorkflowAction<ChapterGetResponse> ChapterGet(Expression<Func<string>> id, Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<int>> offset = null, Expression<Func<string>> sorting = null)
        {
            var apiCallPath = String.Format("/chapter/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sorting != null)
                callPayload.Queries["sorting"] = ExpressionConverter.Convert(sorting);
            return new ApiConnectionAction<ChapterGetResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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