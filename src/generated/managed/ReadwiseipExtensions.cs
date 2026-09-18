//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Readwiseip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReadwiseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HighlightListGetResponse> HighlightListGet([WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> bookId = null, [WorkflowExpression] Func<string> updatedLt = null, [WorkflowExpression] Func<string> updatedGt = null, [WorkflowExpression] Func<string> hightlightedAtLt = null, [WorkflowExpression] Func<string> highlightedAtGt = null)
        {
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(bookId, nameof(bookId), required: false);
            SourceExpression.Validate(updatedLt, nameof(updatedLt), required: false);
            SourceExpression.Validate(updatedGt, nameof(updatedGt), required: false);
            SourceExpression.Validate(hightlightedAtLt, nameof(hightlightedAtLt), required: false);
            SourceExpression.Validate(highlightedAtGt, nameof(highlightedAtGt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/highlights/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (bookId != null)
                    callPayload.Queries["book_id"] = SourceExpressionConverter.ConvertO(bookId);
                if (updatedLt != null)
                    callPayload.Queries["updated__lt"] = SourceExpressionConverter.ConvertO(updatedLt);
                if (updatedGt != null)
                    callPayload.Queries["updated__gt"] = SourceExpressionConverter.ConvertO(updatedGt);
                if (hightlightedAtLt != null)
                    callPayload.Queries["hightlighted_at__lt"] = SourceExpressionConverter.ConvertO(hightlightedAtLt);
                if (highlightedAtGt != null)
                    callPayload.Queries["highlighted_at__gt"] = SourceExpressionConverter.ConvertO(highlightedAtGt);
                return callPayload;
            }

            return new ApiConnectionAction<HighlightListGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HighlightSavePostResponseItem[]> HighlightSave([WorkflowExpression] Func<bodyhighlightsInputItem[]> bodyhighlights)
        {
            SourceExpression.Validate(bodyhighlights, nameof(bodyhighlights), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/highlights/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["highlights"] = SourceExpressionConverter.ConvertToken(bodyhighlights);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HighlightSavePostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HighlightExportGetResponse> HighlightExportGet([WorkflowExpression] Func<string> updatedAfter = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> pageCursor = null)
        {
            SourceExpression.Validate(updatedAfter, nameof(updatedAfter), required: false);
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(pageCursor, nameof(pageCursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/export/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = SourceExpressionConverter.ConvertO(updatedAfter);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (pageCursor != null)
                    callPayload.Queries["pageCursor"] = SourceExpressionConverter.ConvertO(pageCursor);
                return callPayload;
            }

            return new ApiConnectionAction<HighlightExportGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HightlightDetailGetResponse> HightlightDetailGet([WorkflowExpression] Func<string> highlightId)
        {
            SourceExpression.Validate(highlightId, nameof(highlightId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlights/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<HightlightDetailGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<string> HighlightDelete([WorkflowExpression] Func<string> highlightId)
        {
            SourceExpression.Validate(highlightId, nameof(highlightId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlights/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HighlightUpdatePatchResponse> HighlightUpdatePatch([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<int> bodylocation = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodycolor = null)
        {
            SourceExpression.Validate(highlightId, nameof(highlightId), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: false);
            SourceExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodycolor, nameof(bodycolor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlights/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodycolor != null)
                {
                    body["color"] = SourceExpressionConverter.ConvertToken(bodycolor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HighlightUpdatePatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HighlightTagsGetResponse> HighlightTagsGet([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> page = null)
        {
            SourceExpression.Validate(highlightId, nameof(highlightId), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<HighlightTagsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HighlightTagsPostResponse> HighlightTags([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(highlightId, nameof(highlightId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(highlightId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HighlightTagsPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<string> HighlightTagsDelete([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> tagId)
        {
            SourceExpression.Validate(highlightId, nameof(highlightId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(highlightId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<HighlightTagsUpdateResponse> HighlightTagsUpdate([WorkflowExpression] Func<string> highlightId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(highlightId, nameof(highlightId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/highlights/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(highlightId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HighlightTagsUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<BookListGetResponse> BookListGet([WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<int> numHighlights = null, [WorkflowExpression] Func<int> numHighlightsLt = null, [WorkflowExpression] Func<int> numHighlightsGt = null, [WorkflowExpression] Func<string> updatedLt = null, [WorkflowExpression] Func<string> updatedGt = null, [WorkflowExpression] Func<string> lastHighlightAtLt = null, [WorkflowExpression] Func<string> lastHighlightGt = null)
        {
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(numHighlights, nameof(numHighlights), required: false);
            SourceExpression.Validate(numHighlightsLt, nameof(numHighlightsLt), required: false);
            SourceExpression.Validate(numHighlightsGt, nameof(numHighlightsGt), required: false);
            SourceExpression.Validate(updatedLt, nameof(updatedLt), required: false);
            SourceExpression.Validate(updatedGt, nameof(updatedGt), required: false);
            SourceExpression.Validate(lastHighlightAtLt, nameof(lastHighlightAtLt), required: false);
            SourceExpression.Validate(lastHighlightGt, nameof(lastHighlightGt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/books/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (numHighlights != null)
                    callPayload.Queries["num_highlights"] = SourceExpressionConverter.ConvertO(numHighlights);
                if (numHighlightsLt != null)
                    callPayload.Queries["num_highlights__lt"] = SourceExpressionConverter.ConvertO(numHighlightsLt);
                if (numHighlightsGt != null)
                    callPayload.Queries["num_highlights__gt"] = SourceExpressionConverter.ConvertO(numHighlightsGt);
                if (updatedLt != null)
                    callPayload.Queries["updated__lt"] = SourceExpressionConverter.ConvertO(updatedLt);
                if (updatedGt != null)
                    callPayload.Queries["updated__gt"] = SourceExpressionConverter.ConvertO(updatedGt);
                if (lastHighlightAtLt != null)
                    callPayload.Queries["last_highlight_at__lt"] = SourceExpressionConverter.ConvertO(lastHighlightAtLt);
                if (lastHighlightGt != null)
                    callPayload.Queries["last_highlight_gt"] = SourceExpressionConverter.ConvertO(lastHighlightGt);
                return callPayload;
            }

            return new ApiConnectionAction<BookListGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<BookGetResponse> BookGet([WorkflowExpression] Func<string> bookId)
        {
            SourceExpression.Validate(bookId, nameof(bookId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/books/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BookGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<BookTagsGetResponse> BookTagsGet([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> page = null)
        {
            SourceExpression.Validate(bookId, nameof(bookId), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/books/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<BookTagsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<BookTagsCreateResponse> BookTagsCreate([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bookId, nameof(bookId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/books/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BookTagsCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<string> BookTagsDelete([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<string> tagId)
        {
            SourceExpression.Validate(bookId, nameof(bookId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/books/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "readwiseip")]
        public IBodyWorkflowAction<BookTagsUpdateResponse> BookTagsUpdate([WorkflowExpression] Func<string> bookId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bookId, nameof(bookId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/books/{0}/tags/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bookId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BookTagsUpdateResponse>(BuildSourceInput);
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