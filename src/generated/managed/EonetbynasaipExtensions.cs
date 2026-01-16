//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eonetbynasaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EonetbynasaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        public IBodyWorkflowAction<EventsResponse> Events(Expression<Func<string>> source = null, Expression<Func<string>> category = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> limit = null, Expression<Func<int>> days = null, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<string>> magID = null, Expression<Func<string>> magMin = null, Expression<Func<string>> magMax = null, Expression<Func<string>> bbox = null)
        {
            var apiCallPath = "/events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (source != null)
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            callPayload.Queries["status"] = Convert.ToString("open");
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (days != null)
                callPayload.Queries["days"] = ExpressionConverter.Convert(days);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            if (magID != null)
                callPayload.Queries["magID"] = ExpressionConverter.Convert(magID);
            if (magMin != null)
                callPayload.Queries["magMin"] = ExpressionConverter.Convert(magMin);
            if (magMax != null)
                callPayload.Queries["magMax"] = ExpressionConverter.Convert(magMax);
            if (bbox != null)
                callPayload.Queries["bbox"] = ExpressionConverter.Convert(bbox);
            return new ApiConnectionAction<EventsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        public IBodyWorkflowAction<EventsGeoJSONResponse> EventsGeoJSON(Expression<Func<string>> source = null, Expression<Func<string>> category = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> limit = null, Expression<Func<int>> days = null, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<string>> magID = null, Expression<Func<string>> magMin = null, Expression<Func<string>> magMax = null, Expression<Func<string>> bbox = null)
        {
            var apiCallPath = "/events/geojson";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (source != null)
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            callPayload.Queries["status"] = Convert.ToString("open");
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (days != null)
                callPayload.Queries["days"] = ExpressionConverter.Convert(days);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            if (magID != null)
                callPayload.Queries["magID"] = ExpressionConverter.Convert(magID);
            if (magMin != null)
                callPayload.Queries["magMin"] = ExpressionConverter.Convert(magMin);
            if (magMax != null)
                callPayload.Queries["magMax"] = ExpressionConverter.Convert(magMax);
            if (bbox != null)
                callPayload.Queries["bbox"] = ExpressionConverter.Convert(bbox);
            return new ApiConnectionAction<EventsGeoJSONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        public IBodyWorkflowAction<EventCategoriesResponse> EventCategories(Expression<Func<string>> category, Expression<Func<string>> source = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> limit = null, Expression<Func<int>> days = null, Expression<Func<string>> start = null, Expression<Func<string>> end = null)
        {
            var apiCallPath = String.Format("/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(category, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (source != null)
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (days != null)
                callPayload.Queries["days"] = ExpressionConverter.Convert(days);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            return new ApiConnectionAction<EventCategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        public IBodyWorkflowAction<CategoriesResponse> Categories()
        {
            var apiCallPath = "/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        public IBodyWorkflowAction<LayersResponse> Layers(Expression<Func<string>> category)
        {
            var apiCallPath = String.Format("/layers/{0}", ExpressionConverter.ConvertWithUrlEncoding(category, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LayersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        public IBodyWorkflowAction<SourcesResponse> Sources()
        {
            var apiCallPath = "/sources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SourcesResponse>(callPayload);
        }
    }

    public class EonetbynasaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EventsResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("events")]
        public EventsResponseEventsTypeItem[] Events { get; set; }
    }

    public class EventsResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("categories")]
        public EventsResponseEventsTypeItemCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("sources")]
        public EventsResponseEventsTypeItemSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("geometry")]
        public EventsResponseEventsTypeItemGeometryTypeItem[] Geometry { get; set; }
    }

    public class EventsResponseEventsTypeItemCategoriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class EventsResponseEventsTypeItemSourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EventsResponseEventsTypeItemGeometryTypeItem
    {
        [JsonProperty("magnitudeValue")]
        public double MagnitudeValue { get; set; }

        [JsonProperty("magnitudeUnit")]
        public string MagnitudeUnit { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public enum statusInput
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed
    }

    public class EventsGeoJSONResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public EventsGeoJSONResponseFeaturesTypeItem[] Features { get; set; }
    }

    public class EventsGeoJSONResponseFeaturesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public EventsGeoJSONResponseFeaturesTypeItemPropertiesType Properties { get; set; }

        [JsonProperty("geometry")]
        public EventsGeoJSONResponseFeaturesTypeItemGeometryType Geometry { get; set; }
    }

    public class EventsGeoJSONResponseFeaturesTypeItemPropertiesType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("magnitudeValue")]
        public double MagnitudeValue { get; set; }

        [JsonProperty("magnitudeUnit")]
        public string MagnitudeUnit { get; set; }

        [JsonProperty("categories")]
        public EventsGeoJSONResponseFeaturesTypeItemPropertiesTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("sources")]
        public EventsGeoJSONResponseFeaturesTypeItemPropertiesTypeSourcesTypeItem[] Sources { get; set; }
    }

    public class EventsGeoJSONResponseFeaturesTypeItemPropertiesTypeCategoriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class EventsGeoJSONResponseFeaturesTypeItemPropertiesTypeSourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EventsGeoJSONResponseFeaturesTypeItemGeometryType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public class EventCategoriesResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("events")]
        public EventCategoriesResponseEventsTypeItem[] Events { get; set; }
    }

    public class EventCategoriesResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("categories")]
        public EventCategoriesResponseEventsTypeItemCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("sources")]
        public EventCategoriesResponseEventsTypeItemSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("geometry")]
        public EventCategoriesResponseEventsTypeItemGeometryTypeItem[] Geometry { get; set; }
    }

    public class EventCategoriesResponseEventsTypeItemCategoriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class EventCategoriesResponseEventsTypeItemSourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EventCategoriesResponseEventsTypeItemGeometryTypeItem
    {
        [JsonProperty("magnitudeValue")]
        public double MagnitudeValue { get; set; }

        [JsonProperty("magnitudeUnit")]
        public string MagnitudeUnit { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public class CategoriesResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("categories")]
        public CategoriesResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class CategoriesResponseCategoriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("layers")]
        public string Layers { get; set; }
    }

    public class LayersResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("categories")]
        public LayersResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class LayersResponseCategoriesTypeItem
    {
        [JsonProperty("layers")]
        public LayersResponseCategoriesTypeItemLayersTypeItem[] Layers { get; set; }
    }

    public class LayersResponseCategoriesTypeItemLayersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serviceUrl")]
        public string ServiceUrl { get; set; }

        [JsonProperty("serviceTypeId")]
        public string ServiceTypeId { get; set; }

        [JsonProperty("parameters")]
        public LayersResponseCategoriesTypeItemLayersTypeItemParametersTypeItem[] Parameters { get; set; }
    }

    public class LayersResponseCategoriesTypeItemLayersTypeItemParametersTypeItem
    {
        public string TILEMATRIXSET { get; set; }
        public string FORMAT { get; set; }
    }

    public class SourcesResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("sources")]
        public SourcesResponseSourcesTypeItem[] Sources { get; set; }
    }

    public class SourcesResponseSourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Eonetbynasaip;

    public partial class WorkflowManagedActions
    {
        public EonetbynasaipActions Eonetbynasaip(string connectionId) => new EonetbynasaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EonetbynasaipTriggers Eonetbynasaip(string connectionId) => new EonetbynasaipTriggers(connectionId);
    }
}