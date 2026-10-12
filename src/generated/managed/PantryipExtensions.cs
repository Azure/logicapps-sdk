//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pantryip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PantryipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDetails))]
        public IBodyWorkflowAction<GetDetailsResponse> GetDetails([WorkflowExpression] Func<string> pantryID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDetailsResponse> __BuildGetDetails(WorkflowExpression<string> pantryID)
        {
            WorkflowExpression.Validate(pantryID, nameof(pantryID), required: true);
            return new DeferredBodyAction<GetDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pantry/{0}", ExpressionConverter.ConvertWithUrlEncoding(pantryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        [WorkflowExpressionFactory(nameof(__BuildGetContents))]
        public IBodyWorkflowAction<GetContentsResponse> GetContents([WorkflowExpression] Func<string> pantryID, [WorkflowExpression] Func<string> basketName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContentsResponse> __BuildGetContents(WorkflowExpression<string> pantryID, WorkflowExpression<string> basketName)
        {
            WorkflowExpression.Validate(pantryID, nameof(pantryID), required: true);
            WorkflowExpression.Validate(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<GetContentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", ExpressionConverter.ConvertWithUrlEncoding(pantryID, 1), ExpressionConverter.ConvertWithUrlEncoding(basketName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        [WorkflowExpressionFactory(nameof(__BuildDelete))]
        public IBodyWorkflowAction<string> Delete([WorkflowExpression] Func<string> pantryID, [WorkflowExpression] Func<string> basketName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDelete(WorkflowExpression<string> pantryID, WorkflowExpression<string> basketName)
        {
            WorkflowExpression.Validate(pantryID, nameof(pantryID), required: true);
            WorkflowExpression.Validate(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", ExpressionConverter.ConvertWithUrlEncoding(pantryID, 1), ExpressionConverter.ConvertWithUrlEncoding(basketName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAndOrReplace))]
        public IBodyWorkflowAction<string> CreateAndOrReplace([WorkflowExpression] Func<string> pantryID, [WorkflowExpression] Func<string> basketName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateAndOrReplace(WorkflowExpression<string> pantryID, WorkflowExpression<string> basketName)
        {
            WorkflowExpression.Validate(pantryID, nameof(pantryID), required: true);
            WorkflowExpression.Validate(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", ExpressionConverter.ConvertWithUrlEncoding(pantryID, 1), ExpressionConverter.ConvertWithUrlEncoding(basketName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pantryip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateContents))]
        public IBodyWorkflowAction<UpdateContentsResponse> UpdateContents([WorkflowExpression] Func<string> pantryID, [WorkflowExpression] Func<string> basketName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateContentsResponse> __BuildUpdateContents(WorkflowExpression<string> pantryID, WorkflowExpression<string> basketName)
        {
            WorkflowExpression.Validate(pantryID, nameof(pantryID), required: true);
            WorkflowExpression.Validate(basketName, nameof(basketName), required: true);
            return new DeferredBodyAction<UpdateContentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pantry/{0}/basket/{1}", ExpressionConverter.ConvertWithUrlEncoding(pantryID, 1), ExpressionConverter.ConvertWithUrlEncoding(basketName, 1));
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