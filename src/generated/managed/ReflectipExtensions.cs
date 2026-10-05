//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reflectip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReflectipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<GraphsGetResponseItem[]> GraphsGet()
        {
            var apiCallPath = "/graphs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        [WorkflowExpressionFactory(nameof(__BuildBooksGet))]
        public IBodyWorkflowAction<BooksGetResponseItem[]> BooksGet([WorkflowExpression] Func<string> graphId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BooksGetResponseItem[]> __BuildBooksGet(WorkflowValue<string> graphId)
        {
            WorkflowValue.Validate(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<BooksGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/books", ExpressionConverter.ConvertWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BooksGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        [WorkflowExpressionFactory(nameof(__BuildLinksGet))]
        public IBodyWorkflowAction<LinksGetResponseItem[]> LinksGet([WorkflowExpression] Func<string> graphId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinksGetResponseItem[]> __BuildLinksGet(WorkflowValue<string> graphId)
        {
            WorkflowValue.Validate(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<LinksGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", ExpressionConverter.ConvertWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinksGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        [WorkflowExpressionFactory(nameof(__BuildLink))]
        public IBodyWorkflowAction<LinkPostResponseItem[]> Link([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string[]> bodyhighlights = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkPostResponseItem[]> __BuildLink(WorkflowValue<string> graphId, WorkflowValue<string> bodyurl, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodyupdatedAt = null, WorkflowValue<string[]> bodyhighlights = null)
        {
            WorkflowValue.Validate(graphId, nameof(graphId), required: true);
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            WorkflowValue.Validate(bodyhighlights, nameof(bodyhighlights), required: false);
            return new DeferredBodyAction<LinkPostResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", ExpressionConverter.ConvertWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(bodyupdatedAt);
                    bodypropCount++;
                }

                if (bodyhighlights != null)
                {
                    body["highlights"] = ExpressionConverter.ConvertO(bodyhighlights);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LinkPostResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        [WorkflowExpressionFactory(nameof(__BuildDailyNotePut))]
        public IBodyWorkflowAction<DailyNotePutResponse> DailyNotePut([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodylistName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DailyNotePutResponse> __BuildDailyNotePut(WorkflowValue<string> graphId, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodytext = null, WorkflowValue<string> bodylistName = null)
        {
            WorkflowValue.Validate(graphId, nameof(graphId), required: true);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowValue.Validate(bodylistName, nameof(bodylistName), required: false);
            return new DeferredBodyAction<DailyNotePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/daily-notes", ExpressionConverter.ConvertWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                body["transform_type"] = "list-append";
                bodypropCount++;
                if (bodylistName != null)
                {
                    body["list_name"] = ExpressionConverter.ConvertO(bodylistName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DailyNotePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        [WorkflowExpressionFactory(nameof(__BuildNote))]
        public IBodyWorkflowAction<NotePostResponse> Note([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodycontentMarkdown, [WorkflowExpression] Func<bool> bodypinned = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NotePostResponse> __BuildNote(WorkflowValue<string> graphId, WorkflowValue<string> bodysubject, WorkflowValue<string> bodycontentMarkdown, WorkflowValue<bool> bodypinned = null)
        {
            WorkflowValue.Validate(graphId, nameof(graphId), required: true);
            WorkflowValue.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowValue.Validate(bodycontentMarkdown, nameof(bodycontentMarkdown), required: true);
            WorkflowValue.Validate(bodypinned, nameof(bodypinned), required: false);
            return new DeferredBodyAction<NotePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
                body["content_markdown"] = ExpressionConverter.ConvertO(bodycontentMarkdown);
                if (bodypinned != null)
                {
                    body["pinned"] = ExpressionConverter.ConvertO(bodypinned);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NotePostResponse>(callPayload);
            });
        }
    }

    public class ReflectipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GraphsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acl")]
        public string[] Acl { get; set; }
    }

    public class BooksGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("asin")]
        public string Asin { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("authors")]
        public string[] Authors { get; set; }

        [JsonProperty("notes")]
        public BooksGetResponseItemNotesTypeItem[] Notes { get; set; }
    }

    public class BooksGetResponseItemNotesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("location")]
        public int Location { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class LinksGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("highlights")]
        public string[] Highlights { get; set; }
    }

    public class LinkPostResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("highlights")]
        public string[] Highlights { get; set; }
    }

    public class DailyNotePutResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class NotePostResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Reflectip;

    public partial class WorkflowManagedActions
    {
        public ReflectipActions Reflectip(string connectionId) => new ReflectipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReflectipTriggers Reflectip(string connectionId) => new ReflectipTriggers(connectionId);
    }
}
