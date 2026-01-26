//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thegoodapiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThegoodapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thegoodapiip")]
        public IBodyWorkflowAction<TreesGetResponse> TreesGet()
        {
            var apiCallPath = "/plant/trees";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TreesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thegoodapiip")]
        public IBodyWorkflowAction<PlantPostResponse> PlantPost(Expression<Func<int>> bodycount = null)
        {
            var apiCallPath = "/plant/trees";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycount != null)
            {
                body["count"] = ExpressionConverter.ConvertO(bodycount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PlantPostResponse>(callPayload);
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