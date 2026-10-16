//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reflectip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<BooksGetResponseItem[]> BooksGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<BooksGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/books", ExpressionConverter.ConvertWithUrlEncoding(__workflow_graphId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BooksGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinksGetResponseItem[]> LinksGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<LinksGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", ExpressionConverter.ConvertWithUrlEncoding(__workflow_graphId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinksGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinkPostResponseItem[]> Link(Expression<Func<string>> graphId, Expression<Func<string>> bodyurl, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string[]>> bodyhighlights = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyupdatedAt = WorkflowExpression.Compile(bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            var __workflow_bodyhighlights = WorkflowExpression.Compile(bodyhighlights, nameof(bodyhighlights), required: false);
            return new DeferredBodyAction<LinkPostResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", ExpressionConverter.ConvertWithUrlEncoding(__workflow_graphId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedAt != null)
                {
                    body["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedAt);
                    bodypropCount++;
                }

                if (__workflow_bodyhighlights != null)
                {
                    body["highlights"] = ExpressionConverter.ConvertO(__workflow_bodyhighlights);
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
        public IBodyWorkflowAction<DailyNotePutResponse> DailyNotePut(Expression<Func<string>> graphId, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodylistName = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodylistName = WorkflowExpression.Compile(bodylistName, nameof(bodylistName), required: false);
            return new DeferredBodyAction<DailyNotePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/daily-notes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_graphId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                body["transform_type"] = "list-append";
                bodypropCount++;
                if (__workflow_bodylistName != null)
                {
                    body["list_name"] = ExpressionConverter.ConvertO(__workflow_bodylistName);
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
        public IBodyWorkflowAction<NotePostResponse> Note(Expression<Func<string>> graphId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodycontentMarkdown, Expression<Func<bool>> bodypinned = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodycontentMarkdown = WorkflowExpression.Compile(bodycontentMarkdown, nameof(bodycontentMarkdown), required: true);
            var __workflow_bodypinned = WorkflowExpression.Compile(bodypinned, nameof(bodypinned), required: false);
            return new DeferredBodyAction<NotePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graphs/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_graphId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                bodypropCount++;
                body["content_markdown"] = ExpressionConverter.ConvertO(__workflow_bodycontentMarkdown);
                if (__workflow_bodypinned != null)
                {
                    body["pinned"] = ExpressionConverter.ConvertO(__workflow_bodypinned);
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
