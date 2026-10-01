//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Confluence
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConfluenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetSpacesResponse> GetSpaces([WorkflowExpression] Func<string> cloudId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/spaces", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cloudId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSpacesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetPagesResponse> GetPages([WorkflowExpression] Func<string> cloudId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/pages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cloudId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetPagesResponse> GetPagesBySpace([WorkflowExpression] Func<string> cloudId, [WorkflowExpression] Func<string> spaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/spaces/{1}/pages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cloudId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "confluence")]
        public IBodyWorkflowAction<GetPagesResponse> GetPageMetadata([WorkflowExpression] Func<string> cloudId, [WorkflowExpression] Func<string> spaceId, [WorkflowExpression] Func<string> pageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ex/confluence/{0}/wiki/api/v2/pages/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cloudId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(spaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPagesResponse>(BuildSourceInput);
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