//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Decentralandip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DecentralandipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetDistrictsResponse> GetDistricts()
        {
            var apiCallPath = "/districts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDistrictsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetParcelDetailsResponse> GetParcelDetails(Expression<Func<string>> x, Expression<Func<string>> y)
        {
            var apiCallPath = String.Format("/parcels/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(x, 1), ExpressionConverter.ConvertWithUrlEncoding(y, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetParcelDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetParcelMapResponse> GetParcelMap(Expression<Func<string>> x, Expression<Func<string>> y, Expression<Func<int>> width, Expression<Func<int>> height, Expression<Func<int>> size, Expression<Func<bool>> publication)
        {
            var apiCallPath = String.Format("/parcels/{0}/{1}/map.png", ExpressionConverter.ConvertWithUrlEncoding(x, 1), ExpressionConverter.ConvertWithUrlEncoding(y, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["width"] = ExpressionConverter.Convert(width);
            callPayload.Queries["height"] = ExpressionConverter.Convert(height);
            callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["publication"] = ExpressionConverter.Convert(publication);
            return new ApiConnectionAction<GetParcelMapResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetTilesResponse> GetId(Expression<Func<string>> x1, Expression<Func<string>> x2, Expression<Func<string>> y1, Expression<Func<string>> y2, Expression<Func<string>> include)
        {
            var apiCallPath = "/tiles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x1"] = ExpressionConverter.Convert(x1);
            callPayload.Queries["x2"] = ExpressionConverter.Convert(x2);
            callPayload.Queries["y1"] = ExpressionConverter.Convert(y1);
            callPayload.Queries["y2"] = ExpressionConverter.Convert(y2);
            callPayload.Queries["include"] = ExpressionConverter.Convert(include);
            return new ApiConnectionAction<GetTilesResponse>(callPayload);
        }
    }

    public class DecentralandipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDistrictsResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class StatusDetails
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("messages")]
        public Messages[] Messages { get; set; }
    }

    public class Messages
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetParcelDetailsResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class GetParcelMapResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }

    public class GetTilesResponse
    {
        [JsonProperty("statusDetails")]
        public StatusDetails StatusDetails { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Decentralandip;

    public partial class WorkflowManagedActions
    {
        public DecentralandipActions Decentralandip(string connectionId) => new DecentralandipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DecentralandipTriggers Decentralandip(string connectionId) => new DecentralandipTriggers(connectionId);
    }
}