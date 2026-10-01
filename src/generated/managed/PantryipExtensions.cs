//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pantryip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PantryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<GetDetailsResponse> GetDetails([WorkflowExpression] Func<string> pantryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pantry/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pantryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<GetContentsResponse> GetContents([WorkflowExpression] Func<string> pantryId, [WorkflowExpression] Func<string> basketName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pantryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(basketName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<string> Delete([WorkflowExpression] Func<string> pantryId, [WorkflowExpression] Func<string> basketName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pantryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(basketName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<string> CreateAndOrReplace([WorkflowExpression] Func<string> pantryId, [WorkflowExpression] Func<string> basketName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pantryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(basketName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<UpdateContentsResponse> UpdateContents([WorkflowExpression] Func<string> pantryId, [WorkflowExpression] Func<string> basketName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pantryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(basketName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateContentsResponse>(BuildSourceInput);
        }
    }

    public class PantryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDetailsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }

        [JsonProperty("notifications")]
        public bool Notifications { get; set; }

        [JsonProperty("percentFull")]
        public int PercentFull { get; set; }

        [JsonProperty("baskets")]
        public GetDetailsResponseBasketsTypeItem[] Baskets { get; set; }
    }

    public class GetDetailsResponseBasketsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }
    }

    public class GetContentsResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("boolean")]
        public bool Boolean { get; set; }

        [JsonProperty("nestedObject")]
        public GetContentsResponseNestedObjectType NestedObject { get; set; }
    }

    public class GetContentsResponseNestedObjectType
    {
        [JsonProperty("nestedKey")]
        public string NestedKey { get; set; }
    }

    public class UpdateContentsResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("boolean")]
        public bool Boolean { get; set; }

        [JsonProperty("nestedObject")]
        public UpdateContentsResponseNestedObjectType NestedObject { get; set; }

        [JsonProperty("newKey")]
        public string NewKey { get; set; }
    }

    public class UpdateContentsResponseNestedObjectType
    {
        [JsonProperty("nestedKey")]
        public string NestedKey { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pantryip;

    public partial class WorkflowManagedActions
    {
        public PantryipActions Pantryip(string connectionId) => new PantryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PantryipTriggers Pantryip(string connectionId) => new PantryipTriggers(connectionId);
    }
}