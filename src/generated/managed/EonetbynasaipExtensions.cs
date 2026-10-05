//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eonetbynasaip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EonetbynasaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        [WorkflowExpressionFactory(nameof(__BuildEvents))]
        public IBodyWorkflowAction<EventsResponse> Events([WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> days = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> magID = null, [WorkflowExpression] Func<string> magMin = null, [WorkflowExpression] Func<string> magMax = null, [WorkflowExpression] Func<string> bbox = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventsResponse> __BuildEvents(WorkflowValue<string> source = null, WorkflowValue<string> category = null, WorkflowValue<statusInput> status = null, WorkflowValue<int> limit = null, WorkflowValue<int> days = null, WorkflowValue<string> start = null, WorkflowValue<string> end = null, WorkflowValue<string> magID = null, WorkflowValue<string> magMin = null, WorkflowValue<string> magMax = null, WorkflowValue<string> bbox = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(status, nameof(status), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(days, nameof(days), required: false);
            WorkflowValue.Validate(start, nameof(start), required: false);
            WorkflowValue.Validate(end, nameof(end), required: false);
            WorkflowValue.Validate(magID, nameof(magID), required: false);
            WorkflowValue.Validate(magMin, nameof(magMin), required: false);
            WorkflowValue.Validate(magMax, nameof(magMax), required: false);
            WorkflowValue.Validate(bbox, nameof(bbox), required: false);
            return new DeferredBodyAction<EventsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        [WorkflowExpressionFactory(nameof(__BuildEventsGeoJSON))]
        public IBodyWorkflowAction<EventsGeoJSONResponse> EventsGeoJSON([WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> days = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> magID = null, [WorkflowExpression] Func<string> magMin = null, [WorkflowExpression] Func<string> magMax = null, [WorkflowExpression] Func<string> bbox = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventsGeoJSONResponse> __BuildEventsGeoJSON(WorkflowValue<string> source = null, WorkflowValue<string> category = null, WorkflowValue<statusInput> status = null, WorkflowValue<int> limit = null, WorkflowValue<int> days = null, WorkflowValue<string> start = null, WorkflowValue<string> end = null, WorkflowValue<string> magID = null, WorkflowValue<string> magMin = null, WorkflowValue<string> magMax = null, WorkflowValue<string> bbox = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(status, nameof(status), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(days, nameof(days), required: false);
            WorkflowValue.Validate(start, nameof(start), required: false);
            WorkflowValue.Validate(end, nameof(end), required: false);
            WorkflowValue.Validate(magID, nameof(magID), required: false);
            WorkflowValue.Validate(magMin, nameof(magMin), required: false);
            WorkflowValue.Validate(magMax, nameof(magMax), required: false);
            WorkflowValue.Validate(bbox, nameof(bbox), required: false);
            return new DeferredBodyAction<EventsGeoJSONResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eonetbynasaip")]
        [WorkflowExpressionFactory(nameof(__BuildEventCategories))]
        public IBodyWorkflowAction<EventCategoriesResponse> EventCategories([WorkflowExpression] Func<string> category, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> days = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventCategoriesResponse> __BuildEventCategories(WorkflowValue<string> category, WorkflowValue<string> source = null, WorkflowValue<statusInput> status = null, WorkflowValue<int> limit = null, WorkflowValue<int> days = null, WorkflowValue<string> start = null, WorkflowValue<string> end = null)
        {
            WorkflowValue.Validate(category, nameof(category), required: true);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(status, nameof(status), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(days, nameof(days), required: false);
            WorkflowValue.Validate(start, nameof(start), required: false);
            WorkflowValue.Validate(end, nameof(end), required: false);
            return new DeferredBodyAction<EventCategoriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(category, 1));
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildLayers))]
        public IBodyWorkflowAction<LayersResponse> Layers([WorkflowExpression] Func<string> category)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LayersResponse> __BuildLayers(WorkflowValue<string> category)
        {
            WorkflowValue.Validate(category, nameof(category), required: true);
            return new DeferredBodyAction<LayersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/layers/{0}", ExpressionConverter.ConvertWithUrlEncoding(category, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LayersResponse>(callPayload);
            });
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

namespace Microsoft.Azure.Workflows.Sdk
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
