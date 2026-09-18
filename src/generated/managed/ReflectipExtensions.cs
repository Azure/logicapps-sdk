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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/graphs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GraphsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<BooksGetResponseItem[]> BooksGet([WorkflowExpression] Func<string> graphId)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graphs/{0}/books", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BooksGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinksGetResponseItem[]> LinksGet([WorkflowExpression] Func<string> graphId)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LinksGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<LinkPostResponseItem[]> Link([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyupdatedAt = null, [WorkflowExpression] Func<string[]> bodyhighlights = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyupdatedAt, nameof(bodyupdatedAt), required: false);
            SourceExpression.Validate(bodyhighlights, nameof(bodyhighlights), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graphs/{0}/links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyupdatedAt != null)
                {
                    body["updated_at"] = SourceExpressionConverter.ConvertToken(bodyupdatedAt);
                    bodypropCount++;
                }

                if (bodyhighlights != null)
                {
                    body["highlights"] = SourceExpressionConverter.ConvertToken(bodyhighlights);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LinkPostResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<DailyNotePutResponse> DailyNotePut([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodylistName = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodylistName, nameof(bodylistName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graphs/{0}/daily-notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                body["transform_type"] = "list-append";
                bodypropCount++;
                if (bodylistName != null)
                {
                    body["list_name"] = SourceExpressionConverter.ConvertToken(bodylistName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DailyNotePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reflectip")]
        public IBodyWorkflowAction<NotePostResponse> Note([WorkflowExpression] Func<string> graphId, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodycontentMarkdown, [WorkflowExpression] Func<bool> bodypinned = null)
        {
            SourceExpression.Validate(graphId, nameof(graphId), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodycontentMarkdown, nameof(bodycontentMarkdown), required: true);
            SourceExpression.Validate(bodypinned, nameof(bodypinned), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graphs/{0}/notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(graphId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
                body["content_markdown"] = SourceExpressionConverter.ConvertToken(bodycontentMarkdown);
                if (bodypinned != null)
                {
                    body["pinned"] = SourceExpressionConverter.ConvertToken(bodypinned);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NotePostResponse>(BuildSourceInput);
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