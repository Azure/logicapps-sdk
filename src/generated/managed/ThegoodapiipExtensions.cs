//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thegoodapiip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThegoodapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thegoodapiip")]
        public IBodyWorkflowAction<TreesGetResponse, ApiConnectionActionConfiguration> TreesGet()
        {
            return new DeferredBodyAction<TreesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/plant/trees";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TreesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thegoodapiip")]
        public IBodyWorkflowAction<PlantPostResponse, ApiConnectionActionConfiguration> Plant(Expression<Func<PlantPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PlantPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/plant/trees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PlantPostResponse>(callPayload);
            });
        }
    }

    public class ThegoodapiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TreesGetResponse
    {
        [JsonProperty("total_planted_trees")]
        public int TotalPlantedTrees { get; set; }

        [JsonProperty("tree_details")]
        public TreesGetResponseTreeDetailsTypeItem[] TreeDetails { get; set; }
    }

    public class TreesGetResponseTreeDetailsTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class PlantPostResponse
    {
        [JsonProperty("total_planted_trees")]
        public int TotalPlantedTrees { get; set; }

        [JsonProperty("tree_details")]
        public PlantPostResponseTreeDetailsTypeItem[] TreeDetails { get; set; }
    }

    public class PlantPostResponseTreeDetailsTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class PlantPostInput
    {
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Thegoodapiip;

    public partial class WorkflowManagedActions
    {
        public ThegoodapiipActions Thegoodapiip(string connectionId) => new ThegoodapiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThegoodapiipTriggers Thegoodapiip(string connectionId) => new ThegoodapiipTriggers(connectionId);
    }
}