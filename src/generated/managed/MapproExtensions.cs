//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mappro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MapproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> GetPlaceById([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> placeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/places/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(placeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Place>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IWorkflowAction DeletePlace([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> placeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/places/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(placeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> UpdatePlace([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> placeId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<double> bodylatitude, [WorkflowExpression] Func<double> bodylongitude, [WorkflowExpression] Func<string> bodydescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/places/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(placeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
                body["lat"] = SourceExpressionConverter.ConvertToken(bodylatitude);
                bodypropCount++;
                body["lng"] = SourceExpressionConverter.ConvertToken(bodylongitude);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Place>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place[]> GetMapPlacesById([WorkflowExpression] Func<string> mapId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/places", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Place[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        public IBodyWorkflowAction<Place> CreateNewPlace([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<double> bodylatitude, [WorkflowExpression] Func<double> bodylongitude, [WorkflowExpression] Func<string> bodydescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/places", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mapId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
                body["lat"] = SourceExpressionConverter.ConvertToken(bodylatitude);
                bodypropCount++;
                body["lng"] = SourceExpressionConverter.ConvertToken(bodylongitude);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Place>(BuildSourceInput);
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