//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Decentralandip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_x = x == null ? null : WorkflowExpression.Compile(x);
            WorkflowExpression.Validate(__workflow_x, nameof(x), required: true);
            var __workflow_y = y == null ? null : WorkflowExpression.Compile(y);
            WorkflowExpression.Validate(__workflow_y, nameof(y), required: true);
            return new DeferredBodyAction<GetParcelDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parcels/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_x, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_y, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetParcelDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetParcelMapResponse> GetParcelMap(Expression<Func<string>> x, Expression<Func<string>> y, Expression<Func<int>> width, Expression<Func<int>> height, Expression<Func<int>> size, Expression<Func<bool>> publication)
        {
            var __workflow_x = x == null ? null : WorkflowExpression.Compile(x);
            WorkflowExpression.Validate(__workflow_x, nameof(x), required: true);
            var __workflow_y = y == null ? null : WorkflowExpression.Compile(y);
            WorkflowExpression.Validate(__workflow_y, nameof(y), required: true);
            var __workflow_width = width == null ? null : WorkflowExpression.Compile(width);
            WorkflowExpression.Validate(__workflow_width, nameof(width), required: true);
            var __workflow_height = height == null ? null : WorkflowExpression.Compile(height);
            WorkflowExpression.Validate(__workflow_height, nameof(height), required: true);
            var __workflow_size = size == null ? null : WorkflowExpression.Compile(size);
            WorkflowExpression.Validate(__workflow_size, nameof(size), required: true);
            var __workflow_publication = publication == null ? null : WorkflowExpression.Compile(publication);
            WorkflowExpression.Validate(__workflow_publication, nameof(publication), required: true);
            return new DeferredBodyAction<GetParcelMapResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parcels/{0}/{1}/map.png", ExpressionConverter.ConvertWithUrlEncoding(__workflow_x, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_y, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["publication"] = ExpressionConverter.Convert(__workflow_publication);
                return new ApiConnectionAction<GetParcelMapResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "decentralandip")]
        public IBodyWorkflowAction<GetTilesResponse> GetId(Expression<Func<string>> x1, Expression<Func<string>> x2, Expression<Func<string>> y1, Expression<Func<string>> y2, Expression<Func<string>> include)
        {
            var __workflow_x1 = x1 == null ? null : WorkflowExpression.Compile(x1);
            WorkflowExpression.Validate(__workflow_x1, nameof(x1), required: true);
            var __workflow_x2 = x2 == null ? null : WorkflowExpression.Compile(x2);
            WorkflowExpression.Validate(__workflow_x2, nameof(x2), required: true);
            var __workflow_y1 = y1 == null ? null : WorkflowExpression.Compile(y1);
            WorkflowExpression.Validate(__workflow_y1, nameof(y1), required: true);
            var __workflow_y2 = y2 == null ? null : WorkflowExpression.Compile(y2);
            WorkflowExpression.Validate(__workflow_y2, nameof(y2), required: true);
            var __workflow_include = include == null ? null : WorkflowExpression.Compile(include);
            WorkflowExpression.Validate(__workflow_include, nameof(include), required: true);
            return new DeferredBodyAction<GetTilesResponse>(() =>
            {
                var apiCallPath = "/tiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x1"] = ExpressionConverter.Convert(__workflow_x1);
                callPayload.Queries["x2"] = ExpressionConverter.Convert(__workflow_x2);
                callPayload.Queries["y1"] = ExpressionConverter.Convert(__workflow_y1);
                callPayload.Queries["y2"] = ExpressionConverter.Convert(__workflow_y2);
                callPayload.Queries["include"] = ExpressionConverter.Convert(__workflow_include);
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
