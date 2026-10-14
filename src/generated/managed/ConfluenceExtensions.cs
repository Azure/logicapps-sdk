//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Confluence
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ConfluenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetSpacesResponse> GetSpaces(Expression<Func<string>> cloudId)
        {
            var __workflow_cloudId = cloudId == null ? null : WorkflowExpression.Compile(cloudId);
            WorkflowExpression.Validate(__workflow_cloudId, nameof(cloudId), required: true);
            return new DeferredBodyAction<GetSpacesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/spaces", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cloudId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpacesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetPagesResponse> GetPages(Expression<Func<string>> cloudId)
        {
            var __workflow_cloudId = cloudId == null ? null : WorkflowExpression.Compile(cloudId);
            WorkflowExpression.Validate(__workflow_cloudId, nameof(cloudId), required: true);
            return new DeferredBodyAction<GetPagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/pages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cloudId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetPagesResponse> GetPagesBySpace(Expression<Func<string>> cloudId, Expression<Func<string>> spaceId)
        {
            var __workflow_cloudId = cloudId == null ? null : WorkflowExpression.Compile(cloudId);
            WorkflowExpression.Validate(__workflow_cloudId, nameof(cloudId), required: true);
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            return new DeferredBodyAction<GetPagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/spaces/{1}/pages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cloudId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetPagesResponse> GetPageMetadata(Expression<Func<string>> cloudId, Expression<Func<string>> spaceId, Expression<Func<string>> pageId)
        {
            var __workflow_cloudId = cloudId == null ? null : WorkflowExpression.Compile(cloudId);
            WorkflowExpression.Validate(__workflow_cloudId, nameof(cloudId), required: true);
            var __workflow_spaceId = spaceId == null ? null : WorkflowExpression.Compile(spaceId);
            WorkflowExpression.Validate(__workflow_spaceId, nameof(spaceId), required: true);
            var __workflow_pageId = pageId == null ? null : WorkflowExpression.Compile(pageId);
            WorkflowExpression.Validate(__workflow_pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<GetPagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/pages/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cloudId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPagesResponse>(callPayload);
            });
        }
    }

    public class ConfluenceTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSpacesResponse
    {
        [JsonProperty("value")]
        public GetSpacesResponseSpacesTypeItem[] Spaces { get; set; }
    }

    public class GetSpacesResponseSpacesTypeItem
    {
        [JsonProperty("id")]
        public string SpaceId { get; set; }

        [JsonProperty("name")]
        public string SpaceName { get; set; }

        [JsonProperty("type")]
        public string SpaceType { get; set; }
    }

    public class GetPagesResponse
    {
        [JsonProperty("value")]
        public GetPagesResponsePagesTypeItem[] Pages { get; set; }
    }

    public class GetPagesResponsePagesTypeItem
    {
        [JsonProperty("id")]
        public string PageId { get; set; }

        [JsonProperty("title")]
        public string PageTitle { get; set; }

        [JsonProperty("spaceId")]
        public string SpaceId { get; set; }

        [JsonProperty("status")]
        public string PageStatus { get; set; }

        [JsonProperty("body")]
        public GetPagesResponsePagesTypeItemBodyType Body { get; set; }
    }

    public class GetPagesResponsePagesTypeItemBodyType
    {
        [JsonProperty("storage")]
        public GetPagesResponsePagesTypeItemBodyTypeStorageType Storage { get; set; }
    }

    public class GetPagesResponsePagesTypeItemBodyTypeStorageType
    {
        [JsonProperty("representation")]
        public string ContentRepresentation { get; set; }

        [JsonProperty("value")]
        public string ContentOfThePage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Confluence;

    public partial class WorkflowManagedActions
    {
        public ConfluenceActions Confluence(string connectionId) => new ConfluenceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConfluenceTriggers Confluence(string connectionId) => new ConfluenceTriggers(connectionId);
    }
}
