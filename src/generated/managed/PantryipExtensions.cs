//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pantryip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PantryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<GetDetailsResponse, ApiConnectionActionConfiguration> GetDetails(Expression<Func<string>> pantryId)
        {
            var __workflow_pantryId = WorkflowExpression.Compile(pantryId, nameof(pantryId), required: true);
            return new DeferredBodyAction<GetDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pantry/{0}", __workflow_pantryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<GetContentsResponse, ApiConnectionActionConfiguration> GetContents(Expression<Func<string>> pantryId, Expression<Func<string>> basketName)
        {
            var __workflow_pantryId = WorkflowExpression.Compile(pantryId, nameof(pantryId), required: true);
            var __workflow_basketName = WorkflowExpression.Compile(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<GetContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pantry/{0}/basket/{1}", __workflow_pantryId.WithUrlEncoding(1), __workflow_basketName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Delete(Expression<Func<string>> pantryId, Expression<Func<string>> basketName)
        {
            var __workflow_pantryId = WorkflowExpression.Compile(pantryId, nameof(pantryId), required: true);
            var __workflow_basketName = WorkflowExpression.Compile(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pantry/{0}/basket/{1}", __workflow_pantryId.WithUrlEncoding(1), __workflow_basketName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateAndOrReplace(Expression<Func<string>> pantryId, Expression<Func<string>> basketName)
        {
            var __workflow_pantryId = WorkflowExpression.Compile(pantryId, nameof(pantryId), required: true);
            var __workflow_basketName = WorkflowExpression.Compile(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pantry/{0}/basket/{1}", __workflow_pantryId.WithUrlEncoding(1), __workflow_basketName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        public IBodyWorkflowAction<UpdateContentsResponse, ApiConnectionActionConfiguration> UpdateContents(Expression<Func<string>> pantryId, Expression<Func<string>> basketName)
        {
            var __workflow_pantryId = WorkflowExpression.Compile(pantryId, nameof(pantryId), required: true);
            var __workflow_basketName = WorkflowExpression.Compile(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<UpdateContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pantry/{0}/basket/{1}", __workflow_pantryId.WithUrlEncoding(1), __workflow_basketName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UpdateContentsResponse>(callPayload);
            });
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