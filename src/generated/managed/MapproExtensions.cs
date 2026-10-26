//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mappro
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MapproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place, ApiConnectionActionConfiguration> GetPlaceById(Expression<Func<string>> mapId, Expression<Func<string>> placeId)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_placeId = WorkflowExpression.Compile(placeId, nameof(placeId), required: true);
            return new DeferredBodyAction<Place, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places/{1}", __workflow_mapId.WithUrlEncoding(1), __workflow_placeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Place>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletePlace(Expression<Func<string>> mapId, Expression<Func<string>> placeId)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_placeId = WorkflowExpression.Compile(placeId, nameof(placeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places/{1}", __workflow_mapId.WithUrlEncoding(1), __workflow_placeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place, ApiConnectionActionConfiguration> UpdatePlace(Expression<Func<string>> mapId, Expression<Func<string>> placeId, Expression<Func<UpdatePlaceInput>> body)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_placeId = WorkflowExpression.Compile(placeId, nameof(placeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Place, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places/{1}", __workflow_mapId.WithUrlEncoding(1), __workflow_placeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Place>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place[], ApiConnectionActionConfiguration> GetMapPlacesById(Expression<Func<string>> mapId)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            return new DeferredBodyAction<Place[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places", __workflow_mapId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Place[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place, ApiConnectionActionConfiguration> CreateNewPlace(Expression<Func<string>> mapId, Expression<Func<CreateNewPlaceInput>> body)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Place, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places", __workflow_mapId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Place>(callPayload);
            });
        }
    }

    public class MapproTriggers([ConnectionName] string connectionId)
    {
    }

    public class Place
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mapId")]
        public string MapId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }

    public class UpdatePlaceInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("lat", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Latitude { get; set; }

        [JsonProperty("lng", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Longitude { get; set; }
    }

    public class CreateNewPlaceInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("lat", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Latitude { get; set; }

        [JsonProperty("lng", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Longitude { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mappro;

    public partial class WorkflowManagedActions
    {
        public MapproActions Mappro(string connectionId) => new MapproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MapproTriggers Mappro(string connectionId) => new MapproTriggers(connectionId);
    }
}