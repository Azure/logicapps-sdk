//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Decentralandip
{
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
        [WorkflowExpressionFactory(nameof(__BuildGetParcelDetails))]
        public IBodyWorkflowAction<GetParcelDetailsResponse> GetParcelDetails([WorkflowExpression] Func<string> x, [WorkflowExpression] Func<string> y)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetParcelDetailsResponse> __BuildGetParcelDetails(WorkflowExpression<string> x, WorkflowExpression<string> y)
        {
            WorkflowExpression.Validate(x, nameof(x), required: true);
            WorkflowExpression.Validate(y, nameof(y), required: true);
            return new DeferredBodyAction<GetParcelDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parcels/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(x, 1), ExpressionConverter.ConvertWithUrlEncoding(y, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetParcelDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        [WorkflowExpressionFactory(nameof(__BuildGetParcelMap))]
        public IBodyWorkflowAction<GetParcelMapResponse> GetParcelMap([WorkflowExpression] Func<string> x, [WorkflowExpression] Func<string> y, [WorkflowExpression] Func<int> width, [WorkflowExpression] Func<int> height, [WorkflowExpression] Func<int> size, [WorkflowExpression] Func<bool> publication)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetParcelMapResponse> __BuildGetParcelMap(WorkflowExpression<string> x, WorkflowExpression<string> y, WorkflowExpression<int> width, WorkflowExpression<int> height, WorkflowExpression<int> size, WorkflowExpression<bool> publication)
        {
            WorkflowExpression.Validate(x, nameof(x), required: true);
            WorkflowExpression.Validate(y, nameof(y), required: true);
            WorkflowExpression.Validate(width, nameof(width), required: true);
            WorkflowExpression.Validate(height, nameof(height), required: true);
            WorkflowExpression.Validate(size, nameof(size), required: true);
            WorkflowExpression.Validate(publication, nameof(publication), required: true);
            return new DeferredBodyAction<GetParcelMapResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parcels/{0}/{1}/map.png", ExpressionConverter.ConvertWithUrlEncoding(x, 1), ExpressionConverter.ConvertWithUrlEncoding(y, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["width"] = ExpressionConverter.Convert(width);
                callPayload.Queries["height"] = ExpressionConverter.Convert(height);
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                callPayload.Queries["publication"] = ExpressionConverter.Convert(publication);
                return new ApiConnectionAction<GetParcelMapResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        [WorkflowExpressionFactory(nameof(__BuildGetId))]
        public IBodyWorkflowAction<GetTilesResponse> GetId([WorkflowExpression] Func<string> x1, [WorkflowExpression] Func<string> x2, [WorkflowExpression] Func<string> y1, [WorkflowExpression] Func<string> y2, [WorkflowExpression] Func<string> include)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTilesResponse> __BuildGetId(WorkflowExpression<string> x1, WorkflowExpression<string> x2, WorkflowExpression<string> y1, WorkflowExpression<string> y2, WorkflowExpression<string> include)
        {
            WorkflowExpression.Validate(x1, nameof(x1), required: true);
            WorkflowExpression.Validate(x2, nameof(x2), required: true);
            WorkflowExpression.Validate(y1, nameof(y1), required: true);
            WorkflowExpression.Validate(y2, nameof(y2), required: true);
            WorkflowExpression.Validate(include, nameof(include), required: true);
            return new DeferredBodyAction<GetTilesResponse>(() =>
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
            });
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Decentralandip;

    public partial class WorkflowManagedActions
    {
        public DecentralandipActions Decentralandip(string connectionId) => new DecentralandipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DecentralandipTriggers Decentralandip(string connectionId) => new DecentralandipTriggers(connectionId);
    }
}