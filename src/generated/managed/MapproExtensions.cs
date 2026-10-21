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
        public IBodyWorkflowAction<Place> GetPlaceById(Expression<Func<string>> mapId, Expression<Func<string>> placeId)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_placeId = WorkflowExpression.Compile(placeId, nameof(placeId), required: true);
            return new DeferredBodyAction<Place>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places/{1}", __workflow_mapId.WithUrlEncoding(1), __workflow_placeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Place>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IWorkflowAction DeletePlace(Expression<Func<string>> mapId, Expression<Func<string>> placeId)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_placeId = WorkflowExpression.Compile(placeId, nameof(placeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places/{1}", __workflow_mapId.WithUrlEncoding(1), __workflow_placeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> UpdatePlace(Expression<Func<string>> mapId, Expression<Func<string>> placeId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyaddress, Expression<Func<double>> bodylatitude, Expression<Func<double>> bodylongitude, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_placeId = WorkflowExpression.Compile(placeId, nameof(placeId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: true);
            var __workflow_bodylatitude = WorkflowExpression.Compile(bodylatitude, nameof(bodylatitude), required: true);
            var __workflow_bodylongitude = WorkflowExpression.Compile(bodylongitude, nameof(bodylongitude), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<Place>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places/{1}", __workflow_mapId.WithUrlEncoding(1), __workflow_placeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                bodypropCount++;
                body["lat"] = ExpressionConverter.ConvertO(__workflow_bodylatitude);
                bodypropCount++;
                body["lng"] = ExpressionConverter.ConvertO(__workflow_bodylongitude);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Place>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place[]> GetMapPlacesById(Expression<Func<string>> mapId)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            return new DeferredBodyAction<Place[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places", __workflow_mapId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Place[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> CreateNewPlace(Expression<Func<string>> mapId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyaddress, Expression<Func<double>> bodylatitude, Expression<Func<double>> bodylongitude, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_mapId = WorkflowExpression.Compile(mapId, nameof(mapId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: true);
            var __workflow_bodylatitude = WorkflowExpression.Compile(bodylatitude, nameof(bodylatitude), required: true);
            var __workflow_bodylongitude = WorkflowExpression.Compile(bodylongitude, nameof(bodylongitude), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<Place>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/places", __workflow_mapId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                bodypropCount++;
                body["lat"] = ExpressionConverter.ConvertO(__workflow_bodylatitude);
                bodypropCount++;
                body["lng"] = ExpressionConverter.ConvertO(__workflow_bodylongitude);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Place>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class MapproTriggers([ConnectionName] string connectionId)
    {
    }

    public class Place
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("mapId")]
        public string MapID { get; set; }

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
