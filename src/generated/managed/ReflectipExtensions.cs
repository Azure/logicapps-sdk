//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reflectip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReflectipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<GraphsGetResponseItem[], ApiConnectionActionConfiguration> GraphsGet()
        {
            return new DeferredBodyAction<GraphsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/graphs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<BooksGetResponseItem[], ApiConnectionActionConfiguration> BooksGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<BooksGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graphs/{0}/books", __workflow_graphId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BooksGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinksGetResponseItem[], ApiConnectionActionConfiguration> LinksGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<LinksGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graphs/{0}/links", __workflow_graphId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinksGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinkResponseItem[], ApiConnectionActionConfiguration> Link(Expression<Func<string>> graphId, Expression<Func<LinkBodyInput>> body = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LinkResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graphs/{0}/links", __workflow_graphId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LinkResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<DailyNotePutResponse, ApiConnectionActionConfiguration> DailyNotePut(Expression<Func<string>> graphId, Expression<Func<DailyNotePutBodyInput>> body = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DailyNotePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graphs/{0}/daily-notes", __workflow_graphId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DailyNotePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<NoteResponse, ApiConnectionActionConfiguration> Note(Expression<Func<string>> graphId, Expression<Func<NoteBodyInput>> body = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<NoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graphs/{0}/notes", __workflow_graphId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NoteResponse>(callPayload);
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

    public class LinkResponseItem
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

    public class LinkBodyInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class DailyNotePutBodyInput
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("transform_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TransformType { get; set; } = "list-append";

        [JsonProperty("list_name")]
        public string ListName { get; set; }
    }

    public class NoteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class NoteBodyInput
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("content_markdown", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentMarkdown { get; set; }

        [JsonProperty("pinned")]
        public bool? Pinned { get; set; }
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