//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Mappro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MapproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> GetPlaceById(Expression<Func<string>> mapId, Expression<Func<string>> placeId)
        {
            var apiCallPath = String.Format("/{0}/places/{1}", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1), ExpressionConverter.ConvertWithUrlEncoding(placeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Place>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IWorkflowAction DeletePlace(Expression<Func<string>> mapId, Expression<Func<string>> placeId)
        {
            var apiCallPath = String.Format("/{0}/places/{1}", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1), ExpressionConverter.ConvertWithUrlEncoding(placeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> UpdatePlace(Expression<Func<string>> mapId, Expression<Func<string>> placeId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyaddress, Expression<Func<double>> bodylatitude, Expression<Func<double>> bodylongitude, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/{0}/places/{1}", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1), ExpressionConverter.ConvertWithUrlEncoding(placeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["address"] = ExpressionConverter.ConvertO(bodyaddress);
            bodypropCount++;
            body["lat"] = ExpressionConverter.ConvertO(bodylatitude);
            bodypropCount++;
            body["lng"] = ExpressionConverter.ConvertO(bodylongitude);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Place>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place[]> GetMapPlacesById(Expression<Func<string>> mapId)
        {
            var apiCallPath = String.Format("/{0}/places", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Place[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> CreateNewPlace(Expression<Func<string>> mapId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyaddress, Expression<Func<double>> bodylatitude, Expression<Func<double>> bodylongitude, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/{0}/places", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["address"] = ExpressionConverter.ConvertO(bodyaddress);
            bodypropCount++;
            body["lat"] = ExpressionConverter.ConvertO(bodylatitude);
            bodypropCount++;
            body["lng"] = ExpressionConverter.ConvertO(bodylongitude);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Place>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Mappro;

    public partial class WorkflowManagedActions
    {
        public MapproActions Mappro(string connectionId) => new MapproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MapproTriggers Mappro(string connectionId) => new MapproTriggers(connectionId);
    }
}