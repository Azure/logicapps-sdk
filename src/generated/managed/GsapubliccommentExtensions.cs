//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gsapubliccomment
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GsapubliccommentActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsapubliccomment")]
        public IBodyWorkflowAction<GetCommentsResponse> GetComments()
        {
            var apiCallPath = "/comments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCommentsResponse>(callPayload);
        }
    }

    public class GsapubliccommentTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCommentsResponse
    {
        [JsonProperty("data")]
        public Comment[] Data { get; set; }

        [JsonProperty("meta")]
        public GetCommentsResponseMetaType Meta { get; set; }
    }

    public class Comment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public CommentAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public CommentLinksType Links { get; set; }
    }

    public class CommentAttributesType
    {
        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("highlightedContent")]
        public string HighlightedContent { get; set; }

        [JsonProperty("withdrawn")]
        public bool Withdrawn { get; set; }

        [JsonProperty("agencyId")]
        public string AgencyId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("postedDate")]
        public string PostedDate { get; set; }
    }

    public class CommentLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class GetCommentsResponseMetaType
    {
        [JsonProperty("aggregations")]
        public JToken Aggregations { get; set; }

        [JsonProperty("filters")]
        public JToken Filters { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("firstPage")]
        public bool FirstPage { get; set; }

        [JsonProperty("lastPage")]
        public bool LastPage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gsapubliccomment;

    public partial class WorkflowManagedActions
    {
        public GsapubliccommentActions Gsapubliccomment(string connectionId) => new GsapubliccommentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GsapubliccommentTriggers Gsapubliccomment(string connectionId) => new GsapubliccommentTriggers(connectionId);
    }
}