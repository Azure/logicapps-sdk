//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thelordoftheringsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThelordoftheringsipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildBookList))]
        public IBodyWorkflowAction<BookListResponse> BookList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookListResponse> __BuildBookList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<BookListResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildBookGet))]
        public IBodyWorkflowAction<BookGetResponse> BookGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookGetResponse> __BuildBookGet(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<BookGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/book/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildBookGetChapters))]
        public IBodyWorkflowAction<BookGetChaptersResponse> BookGetChapters([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookGetChaptersResponse> __BuildBookGetChapters(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<BookGetChaptersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/book/{0}/chapter", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildMovieList))]
        public IBodyWorkflowAction<MovieListResponse> MovieList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MovieListResponse> __BuildMovieList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<MovieListResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildMovieGet))]
        public IBodyWorkflowAction<MovieGetResponse> MovieGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MovieGetResponse> __BuildMovieGet(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<MovieGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/movie/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildMovieGetQuote))]
        public IBodyWorkflowAction<MovieGetQuoteResponse> MovieGetQuote([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MovieGetQuoteResponse> __BuildMovieGetQuote(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<MovieGetQuoteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/movie/{0}/quote", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildCharacterList))]
        public IBodyWorkflowAction<CharacterListResponse> CharacterList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CharacterListResponse> __BuildCharacterList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<CharacterListResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildCharacterGet))]
        public IBodyWorkflowAction<CharacterGetResponse> CharacterGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CharacterGetResponse> __BuildCharacterGet(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<CharacterGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/character/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildCharacterGetQuote))]
        public IBodyWorkflowAction<CharacterGetQuoteResponse> CharacterGetQuote([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CharacterGetQuoteResponse> __BuildCharacterGetQuote(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<CharacterGetQuoteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/character/{0}/quote", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildQuoteList))]
        public IBodyWorkflowAction<QuoteListResponse> QuoteList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QuoteListResponse> __BuildQuoteList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<QuoteListResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildQuoteGet))]
        public IBodyWorkflowAction<QuoteGetResponse> QuoteGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QuoteGetResponse> __BuildQuoteGet(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<QuoteGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/quote/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildChapterList))]
        public IBodyWorkflowAction<ChapterListResponse> ChapterList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChapterListResponse> __BuildChapterList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<ChapterListResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [WorkflowExpressionFactory(nameof(__BuildChapterGet))]
        public IBodyWorkflowAction<ChapterGetResponse> ChapterGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> sorting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thelordoftheringsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChapterGetResponse> __BuildChapterGet(WorkflowExpression<string> id, WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> sorting = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(sorting, nameof(sorting), required: false);
            return new DeferredBodyAction<ChapterGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/chapter/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
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