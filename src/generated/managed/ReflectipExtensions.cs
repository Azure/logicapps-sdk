//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reflectip
{
    using System.Linq.Expressions;
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
        public IBodyWorkflowAction<BooksGetResponseItem[]> BooksGet(Expression<Func<string>> graphId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/graphs/{0}/books", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BooksGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinksGetResponseItem[]> LinksGet(Expression<Func<string>> graphId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LinksGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinkPostResponseItem[]> Link(Expression<Func<string>> graphId, Expression<Func<string>> bodyurl, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string[]>> bodyhighlights = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            bodypropCount++;
            body["url"] = CSharpExpressionConverter.ConvertToken(bodyurl);
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyupdatedAt != null)
            {
                body["updated_at"] = CSharpExpressionConverter.ConvertToken(bodyupdatedAt);
                bodypropCount++;
            }

            if (bodyhighlights != null)
            {
                body["highlights"] = CSharpExpressionConverter.ConvertToken(bodyhighlights);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LinkPostResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<DailyNotePutResponse> DailyNotePut(Expression<Func<string>> graphId, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodylistName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/graphs/{0}/daily-notes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
            }

            body["transform_type"] = "list-append";
            bodypropCount++;
            if (bodylistName != null)
            {
                body["list_name"] = CSharpExpressionConverter.ConvertToken(bodylistName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DailyNotePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<NotePostResponse> Note(Expression<Func<string>> graphId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodycontentMarkdown, Expression<Func<bool>> bodypinned = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/graphs/{0}/notes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
            bodypropCount++;
            body["content_markdown"] = CSharpExpressionConverter.ConvertToken(bodycontentMarkdown);
            if (bodypinned != null)
            {
                body["pinned"] = CSharpExpressionConverter.ConvertToken(bodypinned);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NotePostResponse>(callPayload);
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