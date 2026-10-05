//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Readwiseip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReadwiseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightListGet))]
        public IBodyWorkflowAction<HighlightListGetResponse> HighlightListGet([WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> bookId = null, [WorkflowExpression] Func<string> updatedLt = null, [WorkflowExpression] Func<string> updatedGt = null, [WorkflowExpression] Func<string> hightlightedAtLt = null, [WorkflowExpression] Func<string> highlightedAtGt = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightListGetResponse> __BuildHighlightListGet(WorkflowValue<int> pageSize = null, WorkflowValue<int> page = null, WorkflowValue<int> bookId = null, WorkflowValue<string> updatedLt = null, WorkflowValue<string> updatedGt = null, WorkflowValue<string> hightlightedAtLt = null, WorkflowValue<string> highlightedAtGt = null)
        {
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(bookId, nameof(bookId), required: false);
            WorkflowValue.Validate(updatedLt, nameof(updatedLt), required: false);
            WorkflowValue.Validate(updatedGt, nameof(updatedGt), required: false);
            WorkflowValue.Validate(hightlightedAtLt, nameof(hightlightedAtLt), required: false);
            WorkflowValue.Validate(highlightedAtGt, nameof(highlightedAtGt), required: false);
            return new DeferredBodyAction<HighlightListGetResponse>(() =>
            {
                var apiCallPath = "/highlights/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (bookId != null)
                    callPayload.Queries["book_id"] = ExpressionConverter.Convert(bookId);
                if (updatedLt != null)
                    callPayload.Queries["updated__lt"] = ExpressionConverter.Convert(updatedLt);
                if (updatedGt != null)
                    callPayload.Queries["updated__gt"] = ExpressionConverter.Convert(updatedGt);
                if (hightlightedAtLt != null)
                    callPayload.Queries["hightlighted_at__lt"] = ExpressionConverter.Convert(hightlightedAtLt);
                if (highlightedAtGt != null)
                    callPayload.Queries["highlighted_at__gt"] = ExpressionConverter.Convert(highlightedAtGt);
                return new ApiConnectionAction<HighlightListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightSave))]
        public IBodyWorkflowAction<HighlightSavePostResponseItem[]> HighlightSave([WorkflowExpression] Func<bodyhighlightsInputItem[]> bodyhighlights)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightSavePostResponseItem[]> __BuildHighlightSave(WorkflowValue<bodyhighlightsInputItem[]> bodyhighlights)
        {
            WorkflowValue.Validate(bodyhighlights, nameof(bodyhighlights), required: true);
            return new DeferredBodyAction<HighlightSavePostResponseItem[]>(() =>
            {
                var apiCallPath = "/highlights/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["highlights"] = ExpressionConverter.ConvertO(bodyhighlights);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<HighlightSavePostResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightExportGet))]
        public IBodyWorkflowAction<HighlightExportGetResponse> HighlightExportGet([WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> pageCursor = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightExportGetResponse> __BuildHighlightExportGet(WorkflowValue<string> updatedAfter = null, WorkflowValue<string> ids = null, WorkflowValue<string> pageCursor = null)
        {
            WorkflowValue.Validate(updatedAfter, nameof(updatedAfter), required: false);
            WorkflowValue.Validate(ids, nameof(ids), required: false);
            WorkflowValue.Validate(pageCursor, nameof(pageCursor), required: false);
            return new DeferredBodyAction<HighlightExportGetResponse>(() =>
            {
                var apiCallPath = "/export/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(updatedAfter);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (pageCursor != null)
                    callPayload.Queries["pageCursor"] = ExpressionConverter.Convert(pageCursor);
                return new ApiConnectionAction<HighlightExportGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHightlightDetailGet))]
        public IBodyWorkflowAction<HightlightDetailGetResponse> HightlightDetailGet([WorkflowExpression] Func<string> highlightId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HightlightDetailGetResponse> __BuildHightlightDetailGet(WorkflowValue<string> highlightId)
        {
            WorkflowValue.Validate(highlightId, nameof(highlightId), required: true);
            return new DeferredBodyAction<HightlightDetailGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlights/{0}", ExpressionConverter.ConvertWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HightlightDetailGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightDelete))]
        public IBodyWorkflowAction<string> HighlightDelete([WorkflowExpression] Func<string> highlightId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildHighlightDelete(WorkflowValue<string> highlightId)
        {
            WorkflowValue.Validate(highlightId, nameof(highlightId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlights/{0}", ExpressionConverter.ConvertWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightUpdatePatch))]
        public IBodyWorkflowAction<HighlightUpdatePatchResponse> HighlightUpdatePatch([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<int> bodylocation = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodycolor = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightUpdatePatchResponse> __BuildHighlightUpdatePatch(WorkflowValue<string> highlightId, WorkflowValue<string> bodytext = null, WorkflowValue<string> bodynote = null, WorkflowValue<int> bodylocation = null, WorkflowValue<string> bodyurl = null, WorkflowValue<string> bodycolor = null)
        {
            WorkflowValue.Validate(highlightId, nameof(highlightId), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowValue.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowValue.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowValue.Validate(bodycolor, nameof(bodycolor), required: false);
            return new DeferredBodyAction<HighlightUpdatePatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlights/{0}", ExpressionConverter.ConvertWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                if (bodycolor != null)
                {
                    body["color"] = ExpressionConverter.ConvertO(bodycolor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<HighlightUpdatePatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightTagsGet))]
        public IBodyWorkflowAction<HighlightTagsGetResponse> HighlightTagsGet([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> page = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightTagsGetResponse> __BuildHighlightTagsGet(WorkflowValue<string> highlightId, WorkflowValue<int> pageSize = null, WorkflowValue<string> page = null)
        {
            WorkflowValue.Validate(highlightId, nameof(highlightId), required: true);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<HighlightTagsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<HighlightTagsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightTags))]
        public IBodyWorkflowAction<HighlightTagsPostResponse> HighlightTags([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightTagsPostResponse> __BuildHighlightTags(WorkflowValue<string> highlightId, WorkflowValue<string> bodyname)
        {
            WorkflowValue.Validate(highlightId, nameof(highlightId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<HighlightTagsPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<HighlightTagsPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightTagsDelete))]
        public IBodyWorkflowAction<string> HighlightTagsDelete([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildHighlightTagsDelete(WorkflowValue<string> highlightId, WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(highlightId, nameof(highlightId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(highlightId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildHighlightTagsUpdate))]
        public IBodyWorkflowAction<HighlightTagsUpdateResponse> HighlightTagsUpdate([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HighlightTagsUpdateResponse> __BuildHighlightTagsUpdate(WorkflowValue<string> highlightId, WorkflowValue<string> tagId, WorkflowValue<string> bodyname)
        {
            WorkflowValue.Validate(highlightId, nameof(highlightId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<HighlightTagsUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(highlightId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<HighlightTagsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildBookListGet))]
        public IBodyWorkflowAction<BookListGetResponse> BookListGet([WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<int> numHighlights = null, [WorkflowExpression] Func<int> numHighlightsLt = null, [WorkflowExpression] Func<int> numHighlightsGt = null, [WorkflowExpression] Func<string> updatedLt = null, [WorkflowExpression] Func<string> updatedGt = null, [WorkflowExpression] Func<string> lastHighlightAtLt = null, [WorkflowExpression] Func<string> lastHighlightGt = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookListGetResponse> __BuildBookListGet(WorkflowValue<int> pageSize = null, WorkflowValue<string> page = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<int> numHighlights = null, WorkflowValue<int> numHighlightsLt = null, WorkflowValue<int> numHighlightsGt = null, WorkflowValue<string> updatedLt = null, WorkflowValue<string> updatedGt = null, WorkflowValue<string> lastHighlightAtLt = null, WorkflowValue<string> lastHighlightGt = null)
        {
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(numHighlights, nameof(numHighlights), required: false);
            WorkflowValue.Validate(numHighlightsLt, nameof(numHighlightsLt), required: false);
            WorkflowValue.Validate(numHighlightsGt, nameof(numHighlightsGt), required: false);
            WorkflowValue.Validate(updatedLt, nameof(updatedLt), required: false);
            WorkflowValue.Validate(updatedGt, nameof(updatedGt), required: false);
            WorkflowValue.Validate(lastHighlightAtLt, nameof(lastHighlightAtLt), required: false);
            WorkflowValue.Validate(lastHighlightGt, nameof(lastHighlightGt), required: false);
            return new DeferredBodyAction<BookListGetResponse>(() =>
            {
                var apiCallPath = "/books/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (numHighlights != null)
                    callPayload.Queries["num_highlights"] = ExpressionConverter.Convert(numHighlights);
                if (numHighlightsLt != null)
                    callPayload.Queries["num_highlights__lt"] = ExpressionConverter.Convert(numHighlightsLt);
                if (numHighlightsGt != null)
                    callPayload.Queries["num_highlights__gt"] = ExpressionConverter.Convert(numHighlightsGt);
                if (updatedLt != null)
                    callPayload.Queries["updated__lt"] = ExpressionConverter.Convert(updatedLt);
                if (updatedGt != null)
                    callPayload.Queries["updated__gt"] = ExpressionConverter.Convert(updatedGt);
                if (lastHighlightAtLt != null)
                    callPayload.Queries["last_highlight_at__lt"] = ExpressionConverter.Convert(lastHighlightAtLt);
                if (lastHighlightGt != null)
                    callPayload.Queries["last_highlight_gt"] = ExpressionConverter.Convert(lastHighlightGt);
                return new ApiConnectionAction<BookListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildBookGet))]
        public IBodyWorkflowAction<BookGetResponse> BookGet([WorkflowExpression] Func<string> bookId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookGetResponse> __BuildBookGet(WorkflowValue<string> bookId)
        {
            WorkflowValue.Validate(bookId, nameof(bookId), required: true);
            return new DeferredBodyAction<BookGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/books/{0}", ExpressionConverter.ConvertWithUrlEncoding(bookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BookGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildBookTagsGet))]
        public IBodyWorkflowAction<BookTagsGetResponse> BookTagsGet([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> page = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookTagsGetResponse> __BuildBookTagsGet(WorkflowValue<string> bookId, WorkflowValue<int> pageSize = null, WorkflowValue<string> page = null)
        {
            WorkflowValue.Validate(bookId, nameof(bookId), required: true);
            WorkflowValue.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<BookTagsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/books/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(bookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<BookTagsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildBookTagsCreate))]
        public IBodyWorkflowAction<BookTagsCreateResponse> BookTagsCreate([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookTagsCreateResponse> __BuildBookTagsCreate(WorkflowValue<string> bookId, WorkflowValue<string> bodyname)
        {
            WorkflowValue.Validate(bookId, nameof(bookId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<BookTagsCreateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/books/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(bookId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BookTagsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildBookTagsDelete))]
        public IBodyWorkflowAction<string> BookTagsDelete([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildBookTagsDelete(WorkflowValue<string> bookId, WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(bookId, nameof(bookId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/books/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(bookId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        [WorkflowExpressionFactory(nameof(__BuildBookTagsUpdate))]
        public IBodyWorkflowAction<BookTagsUpdateResponse> BookTagsUpdate([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookTagsUpdateResponse> __BuildBookTagsUpdate(WorkflowValue<string> bookId, WorkflowValue<string> tagId, WorkflowValue<string> bodyname)
        {
            WorkflowValue.Validate(bookId, nameof(bookId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<BookTagsUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/books/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(bookId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BookTagsUpdateResponse>(callPayload);
            });
        }
    }

    public class ReadwiseipTriggers([ConnectionName] string connectionId)
    {
    }

    public class HighlightListGetResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public HighlightListGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class HighlightListGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("location")]
        public int Location { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        [JsonProperty("highlighted_at")]
        public string HighlightedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("book_id")]
        public int BookId { get; set; }

        [JsonProperty("tags")]
        public HighlightListGetResponseResultsTypeItemTagsTypeItem[] Tags { get; set; }
    }

    public class HighlightListGetResponseResultsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class HighlightSavePostResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("num_highlights")]
        public int NumHighlights { get; set; }

        [JsonProperty("last_highlight_at")]
        public string LastHighlightAt { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }

        [JsonProperty("highlights_url")]
        public string HighlightsUrl { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("asin")]
        public string Asin { get; set; }

        [JsonProperty("tags")]
        public HighlightSavePostResponseItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("modified_highlights")]
        public int[] ModifiedHighlights { get; set; }
    }

    public class HighlightSavePostResponseItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyhighlightsInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("category")]
        public bodyhighlightsInputItemCategoryType Category { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("location")]
        public int Location { get; set; }

        [JsonProperty("location_type")]
        public bodyhighlightsInputItemLocationTypeType LocationType { get; set; }

        [JsonProperty("highlighted_at")]
        public string HighlightedAt { get; set; }

        [JsonProperty("highlight_url")]
        public string HighlightUrl { get; set; }
    }

    public enum bodyhighlightsInputItemCategoryType
    {
        [EnumMember(Value = "books")]
        Books,
        [EnumMember(Value = "articles")]
        Articles,
        [EnumMember(Value = "tweets")]
        Tweets,
        [EnumMember(Value = "podcasts")]
        Podcasts
    }

    public enum bodyhighlightsInputItemLocationTypeType
    {
        [EnumMember(Value = "page")]
        Page,
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "time_offset")]
        TimeOffset
    }

    public class HighlightExportGetResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("nextPageCursor")]
        public string NextPageCursor { get; set; }

        [JsonProperty("results")]
        public HighlightExportGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class HighlightExportGetResponseResultsTypeItem
    {
        [JsonProperty("user_book_id")]
        public int UserBookId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("readable_title")]
        public string ReadableTitle { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }

        [JsonProperty("unique_url")]
        public string UniqueUrl { get; set; }

        [JsonProperty("book_tags")]
        public string[] BookTags { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("readwise_url")]
        public string ReadwiseUrl { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("asin")]
        public string Asin { get; set; }

        [JsonProperty("highlights")]
        public HighlightExportGetResponseResultsTypeItemHighlightsTypeItem[] Highlights { get; set; }
    }

    public class HighlightExportGetResponseResultsTypeItemHighlightsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("location")]
        public int Location { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("highlighted_at")]
        public string HighlightedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("end_location")]
        public string EndLocation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("book_id")]
        public int BookId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_discard")]
        public bool IsDiscard { get; set; }

        [JsonProperty("readwise_url")]
        public string ReadwiseUrl { get; set; }
    }

    public class HightlightDetailGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("location")]
        public int Location { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("highlighted_at")]
        public string HighlightedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("end_location")]
        public string EndLocation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("book_id")]
        public int BookId { get; set; }

        [JsonProperty("tags")]
        public HightlightDetailGetResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_discard")]
        public bool IsDiscard { get; set; }

        [JsonProperty("readwise_url")]
        public string ReadwiseUrl { get; set; }
    }

    public class HightlightDetailGetResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class HighlightUpdatePatchResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("location")]
        public int Location { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("highlighted_at")]
        public string HighlightedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("end_location")]
        public string EndLocation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("book_id")]
        public int BookId { get; set; }

        [JsonProperty("tags")]
        public HighlightUpdatePatchResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_discard")]
        public bool IsDiscard { get; set; }

        [JsonProperty("readwise_url")]
        public string ReadwiseUrl { get; set; }
    }

    public class HighlightUpdatePatchResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class HighlightTagsGetResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public HighlightTagsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class HighlightTagsGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class HighlightTagsPostResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class HighlightTagsUpdateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BookListGetResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public BookListGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class BookListGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("num_highlights")]
        public int NumHighlights { get; set; }

        [JsonProperty("last_highlight_at")]
        public string LastHighlightAt { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }

        [JsonProperty("highlights_url")]
        public string HighlightsUrl { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("asin")]
        public string Asin { get; set; }

        [JsonProperty("tags")]
        public BookListGetResponseResultsTypeItemTagsTypeItem[] Tags { get; set; }
    }

    public class BookListGetResponseResultsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BookGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("num_highlights")]
        public int NumHighlights { get; set; }

        [JsonProperty("last_highlight_at")]
        public string LastHighlightAt { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }

        [JsonProperty("highlights_url")]
        public string HighlightsUrl { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("asin")]
        public string Asin { get; set; }

        [JsonProperty("tags")]
        public BookGetResponseTagsTypeItem[] Tags { get; set; }
    }

    public class BookGetResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BookTagsGetResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public BookTagsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class BookTagsGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BookTagsCreateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BookTagsUpdateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Readwiseip;

    public partial class WorkflowManagedActions
    {
        public ReadwiseipActions Readwiseip(string connectionId) => new ReadwiseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReadwiseipTriggers Readwiseip(string connectionId) => new ReadwiseipTriggers(connectionId);
    }
}
