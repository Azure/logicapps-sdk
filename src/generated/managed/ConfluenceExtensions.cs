//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Confluence
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConfluenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        [WorkflowExpressionFactory(nameof(__BuildGetSpaces))]
        public IBodyWorkflowAction<GetSpacesResponse> GetSpaces([WorkflowExpression] Func<string> cloudId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSpacesResponse> __BuildGetSpaces(WorkflowValue<string> cloudId)
        {
            WorkflowValue.Validate(cloudId, nameof(cloudId), required: true);
            return new DeferredBodyAction<GetSpacesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/spaces", ExpressionConverter.ConvertWithUrlEncoding(cloudId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpacesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        [WorkflowExpressionFactory(nameof(__BuildGetPages))]
        public IBodyWorkflowAction<GetPagesResponse> GetPages([WorkflowExpression] Func<string> cloudId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPagesResponse> __BuildGetPages(WorkflowValue<string> cloudId)
        {
            WorkflowValue.Validate(cloudId, nameof(cloudId), required: true);
            return new DeferredBodyAction<GetPagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/pages", ExpressionConverter.ConvertWithUrlEncoding(cloudId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        [WorkflowExpressionFactory(nameof(__BuildGetPagesBySpace))]
        public IBodyWorkflowAction<GetPagesResponse> GetPagesBySpace([WorkflowExpression] Func<string> cloudId, [WorkflowExpression] Func<string> spaceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPagesResponse> __BuildGetPagesBySpace(WorkflowValue<string> cloudId, WorkflowValue<string> spaceId)
        {
            WorkflowValue.Validate(cloudId, nameof(cloudId), required: true);
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            return new DeferredBodyAction<GetPagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/spaces/{1}/pages", ExpressionConverter.ConvertWithUrlEncoding(cloudId, 1), ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        [WorkflowExpressionFactory(nameof(__BuildGetPageMetadata))]
        public IBodyWorkflowAction<GetPagesResponse> GetPageMetadata([WorkflowExpression] Func<string> cloudId, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> pageId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPagesResponse> __BuildGetPageMetadata(WorkflowValue<string> cloudId, WorkflowValue<string> spaceId, WorkflowValue<string> pageId)
        {
            WorkflowValue.Validate(cloudId, nameof(cloudId), required: true);
            WorkflowValue.Validate(spaceId, nameof(spaceId), required: true);
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<GetPagesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/pages/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(cloudId, 1), ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(spaceId, 1));
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
