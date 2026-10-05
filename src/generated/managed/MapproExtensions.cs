//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mappro
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MapproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        [WorkflowExpressionFactory(nameof(__BuildGetPlaceById))]
        public IBodyWorkflowAction<Place> GetPlaceById([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> placeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Place> __BuildGetPlaceById(WorkflowValue<string> mapId, WorkflowValue<string> placeId)
        {
            WorkflowValue.Validate(mapId, nameof(mapId), required: true);
            WorkflowValue.Validate(placeId, nameof(placeId), required: true);
            return new DeferredBodyAction<Place>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/places/{1}", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1), ExpressionConverter.ConvertWithUrlEncoding(placeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Place>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        [WorkflowExpressionFactory(nameof(__BuildDeletePlace))]
        public IWorkflowAction DeletePlace([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> placeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletePlace(WorkflowValue<string> mapId, WorkflowValue<string> placeId)
        {
            WorkflowValue.Validate(mapId, nameof(mapId), required: true);
            WorkflowValue.Validate(placeId, nameof(placeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/places/{1}", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1), ExpressionConverter.ConvertWithUrlEncoding(placeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePlace))]
        public IBodyWorkflowAction<Place> UpdatePlace([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> placeId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<double> bodylatitude, [WorkflowExpression] Func<double> bodylongitude, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Place> __BuildUpdatePlace(WorkflowValue<string> mapId, WorkflowValue<string> placeId, WorkflowValue<string> bodytitle, WorkflowValue<string> bodyaddress, WorkflowValue<double> bodylatitude, WorkflowValue<double> bodylongitude, WorkflowValue<string> bodydescription = null)
        {
            WorkflowValue.Validate(mapId, nameof(mapId), required: true);
            WorkflowValue.Validate(placeId, nameof(placeId), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: true);
            WorkflowValue.Validate(bodylatitude, nameof(bodylatitude), required: true);
            WorkflowValue.Validate(bodylongitude, nameof(bodylongitude), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<Place>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/places/{1}", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1), ExpressionConverter.ConvertWithUrlEncoding(placeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        [WorkflowExpressionFactory(nameof(__BuildGetMapPlacesById))]
        public IBodyWorkflowAction<Place[]> GetMapPlacesById([WorkflowExpression] Func<string> mapId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Place[]> __BuildGetMapPlacesById(WorkflowValue<string> mapId)
        {
            WorkflowValue.Validate(mapId, nameof(mapId), required: true);
            return new DeferredBodyAction<Place[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/places", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Place[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mappro")]
        [WorkflowExpressionFactory(nameof(__BuildCreateNewPlace))]
        public IBodyWorkflowAction<Place> CreateNewPlace([WorkflowExpression] Func<string> mapId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<double> bodylatitude, [WorkflowExpression] Func<double> bodylongitude, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Place> __BuildCreateNewPlace(WorkflowValue<string> mapId, WorkflowValue<string> bodytitle, WorkflowValue<string> bodyaddress, WorkflowValue<double> bodylatitude, WorkflowValue<double> bodylongitude, WorkflowValue<string> bodydescription = null)
        {
            WorkflowValue.Validate(mapId, nameof(mapId), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: true);
            WorkflowValue.Validate(bodylatitude, nameof(bodylatitude), required: true);
            WorkflowValue.Validate(bodylongitude, nameof(bodylongitude), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<Place>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/places", ExpressionConverter.ConvertWithUrlEncoding(mapId, 1));
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
            });
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
