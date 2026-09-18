//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nederlandsespoorweip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NederlandsespoorweipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nederlandsespoorweip")]
        public IBodyWorkflowAction<GetArrivalsResponse> GetArrivals([WorkflowExpression] Func<string> lang = null, [WorkflowExpression] Func<string> station = null, [WorkflowExpression] Func<string> uicCode = null, [WorkflowExpression] Func<string> dateTime = null, [WorkflowExpression] Func<int> maxJourneys = null)
        {
            var apiCallPath = "/api/v2/arrivals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lang != null)
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
            if (station != null)
                callPayload.Queries["station"] = ExpressionConverter.Convert(station);
            if (uicCode != null)
                callPayload.Queries["uicCode"] = ExpressionConverter.Convert(uicCode);
            if (dateTime != null)
                callPayload.Queries["dateTime"] = ExpressionConverter.Convert(dateTime);
            if (maxJourneys != null)
                callPayload.Queries["maxJourneys"] = ExpressionConverter.Convert(maxJourneys);
            return new ApiConnectionAction<GetArrivalsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nederlandsespoorweip")]
        public IBodyWorkflowAction<GetDeparturesResponse> GetDepartures([WorkflowExpression] Func<string> lang = null, [WorkflowExpression] Func<string> station = null, [WorkflowExpression] Func<string> uicCode = null, [WorkflowExpression] Func<string> dateTime = null, [WorkflowExpression] Func<string> maxJourneys = null)
        {
            var apiCallPath = "/api/v2/departures";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lang != null)
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
            if (station != null)
                callPayload.Queries["station"] = ExpressionConverter.Convert(station);
            if (uicCode != null)
                callPayload.Queries["uicCode"] = ExpressionConverter.Convert(uicCode);
            if (dateTime != null)
                callPayload.Queries["dateTime"] = ExpressionConverter.Convert(dateTime);
            if (maxJourneys != null)
                callPayload.Queries["maxJourneys"] = ExpressionConverter.Convert(maxJourneys);
            return new ApiConnectionAction<GetDeparturesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nederlandsespoorweip")]
        public IBodyWorkflowAction<GetStationDisruptionsResponseItem[]> GetStationDisruptions([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> stationCode)
        {
            var apiCallPath = String.Format("/api/v3/disruptions/station/{0}", ExpressionConverter.ConvertWithUrlEncoding(stationCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStationDisruptionsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nederlandsespoorweip")]
        public IBodyWorkflowAction<GetStationsResponse> GetStations()
        {
            var apiCallPath = "/api/v2/stations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStationsResponse>(callPayload);
        }
    }

    public class NederlandsespoorweipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetArrivalsResponse
    {
        [JsonProperty("payload")]
        public GetArrivalsResponsePayloadType Payload { get; set; }
    }

    public class GetArrivalsResponsePayloadType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("arrivals")]
        public GetArrivalsResponsePayloadTypeArrivalsTypeItem[] Arrivals { get; set; }
    }

    public class GetArrivalsResponsePayloadTypeArrivalsTypeItem
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plannedDateTime")]
        public string PlannedDateTime { get; set; }

        [JsonProperty("plannedTimeZoneOffset")]
        public int PlannedTimeZoneOffset { get; set; }

        [JsonProperty("actualDateTime")]
        public string ActualDateTime { get; set; }

        [JsonProperty("actualTimeZoneOffset")]
        public int ActualTimeZoneOffset { get; set; }

        [JsonProperty("plannedTrack")]
        public string PlannedTrack { get; set; }

        [JsonProperty("product")]
        public GetArrivalsResponsePayloadTypeArrivalsTypeItemProductType Product { get; set; }

        [JsonProperty("trainCategory")]
        public string TrainCategory { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("messages")]
        public GetArrivalsResponsePayloadTypeArrivalsTypeItemMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("arrivalStatus")]
        public string ArrivalStatus { get; set; }

        [JsonProperty("actualTrack")]
        public string ActualTrack { get; set; }
    }

    public class GetArrivalsResponsePayloadTypeArrivalsTypeItemProductType
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("shortCategoryName")]
        public string ShortCategoryName { get; set; }

        [JsonProperty("longCategoryName")]
        public string LongCategoryName { get; set; }

        [JsonProperty("operatorCode")]
        public string OperatorCode { get; set; }

        [JsonProperty("operatorName")]
        public string OperatorName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetArrivalsResponsePayloadTypeArrivalsTypeItemMessagesTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }
    }

    public class GetDeparturesResponse
    {
        [JsonProperty("payload")]
        public GetDeparturesResponsePayloadType Payload { get; set; }
    }

    public class GetDeparturesResponsePayloadType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("departures")]
        public GetDeparturesResponsePayloadTypeDeparturesTypeItem[] Departures { get; set; }
    }

    public class GetDeparturesResponsePayloadTypeDeparturesTypeItem
    {
        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plannedDateTime")]
        public string PlannedDateTime { get; set; }

        [JsonProperty("plannedTimeZoneOffset")]
        public int PlannedTimeZoneOffset { get; set; }

        [JsonProperty("actualDateTime")]
        public string ActualDateTime { get; set; }

        [JsonProperty("actualTimeZoneOffset")]
        public int ActualTimeZoneOffset { get; set; }

        [JsonProperty("plannedTrack")]
        public string PlannedTrack { get; set; }

        [JsonProperty("product")]
        public GetDeparturesResponsePayloadTypeDeparturesTypeItemProductType Product { get; set; }

        [JsonProperty("trainCategory")]
        public string TrainCategory { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("routeStations")]
        public GetDeparturesResponsePayloadTypeDeparturesTypeItemRouteStationsTypeItem[] RouteStations { get; set; }

        [JsonProperty("messages")]
        public JToken[] Messages { get; set; }

        [JsonProperty("departureStatus")]
        public string DepartureStatus { get; set; }
    }

    public class GetDeparturesResponsePayloadTypeDeparturesTypeItemProductType
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("shortCategoryName")]
        public string ShortCategoryName { get; set; }

        [JsonProperty("longCategoryName")]
        public string LongCategoryName { get; set; }

        [JsonProperty("operatorCode")]
        public string OperatorCode { get; set; }

        [JsonProperty("operatorName")]
        public string OperatorName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetDeparturesResponsePayloadTypeDeparturesTypeItemRouteStationsTypeItem
    {
        [JsonProperty("uicCode")]
        public string UicCode { get; set; }

        [JsonProperty("mediumName")]
        public string MediumName { get; set; }
    }

    public class GetStationDisruptionsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("registrationTime")]
        public string RegistrationTime { get; set; }

        [JsonProperty("releaseTime")]
        public string ReleaseTime { get; set; }

        [JsonProperty("local")]
        public bool Local { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("titleSections")]
        public GetStationDisruptionsResponseItemTitleSectionsTypeItemItem[][] TitleSections { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("impact")]
        public GetStationDisruptionsResponseItemImpactType Impact { get; set; }

        [JsonProperty("publicationSections")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItem[] PublicationSections { get; set; }

        [JsonProperty("timespans")]
        public GetStationDisruptionsResponseItemTimespansTypeItem[] Timespans { get; set; }

        [JsonProperty("alternativeTransportTimespans")]
        public JToken[] AlternativeTransportTimespans { get; set; }
    }

    public class GetStationDisruptionsResponseItemTitleSectionsTypeItemItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetStationDisruptionsResponseItemImpactType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItem
    {
        [JsonProperty("section")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItemSectionType Section { get; set; }

        [JsonProperty("consequence")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceType Consequence { get; set; }

        [JsonProperty("sectionType")]
        public string SectionType { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItemSectionType
    {
        [JsonProperty("stations")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItemSectionTypeStationsTypeItem[] Stations { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItemSectionTypeStationsTypeItem
    {
        [JsonProperty("uicCode")]
        public string UicCode { get; set; }

        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coordinate")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItemSectionTypeStationsTypeItemCoordinateType Coordinate { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItemSectionTypeStationsTypeItemCoordinateType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceType
    {
        [JsonProperty("section")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceTypeSectionType Section { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceTypeSectionType
    {
        [JsonProperty("stations")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceTypeSectionTypeStationsTypeItem[] Stations { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceTypeSectionTypeStationsTypeItem
    {
        [JsonProperty("uicCode")]
        public string UicCode { get; set; }

        [JsonProperty("stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coordinate")]
        public GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceTypeSectionTypeStationsTypeItemCoordinateType Coordinate { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class GetStationDisruptionsResponseItemPublicationSectionsTypeItemConsequenceTypeSectionTypeStationsTypeItemCoordinateType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class GetStationDisruptionsResponseItemTimespansTypeItem
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("situation")]
        public GetStationDisruptionsResponseItemTimespansTypeItemSituationType Situation { get; set; }

        [JsonProperty("cause")]
        public GetStationDisruptionsResponseItemTimespansTypeItemCauseType Cause { get; set; }

        [JsonProperty("advices")]
        public string[] Advices { get; set; }
    }

    public class GetStationDisruptionsResponseItemTimespansTypeItemSituationType
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetStationDisruptionsResponseItemTimespansTypeItemCauseType
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetStationsResponse
    {
        [JsonProperty("payload")]
        public GetStationsResponsePayloadTypeItem[] Payload { get; set; }
    }

    public class GetStationsResponsePayloadTypeItem
    {
        public string UICCode { get; set; }

        [JsonProperty("stationType")]
        public string StationType { get; set; }
        public string EVACode { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("sporen")]
        public GetStationsResponsePayloadTypeItemSporenTypeItem[] Sporen { get; set; }

        [JsonProperty("synoniemen")]
        public string[] Synoniemen { get; set; }

        [JsonProperty("heeftFaciliteiten")]
        public bool HeeftFaciliteiten { get; set; }

        [JsonProperty("heeftVertrektijden")]
        public bool HeeftVertrektijden { get; set; }

        [JsonProperty("heeftReisassistentie")]
        public bool HeeftReisassistentie { get; set; }

        [JsonProperty("namen")]
        public GetStationsResponsePayloadTypeItemNamenType Namen { get; set; }

        [JsonProperty("land")]
        public string Land { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("radius")]
        public int Radius { get; set; }

        [JsonProperty("naderenRadius")]
        public int NaderenRadius { get; set; }

        [JsonProperty("ingangsDatum")]
        public string IngangsDatum { get; set; }

        [JsonProperty("nearbyMeLocationId")]
        public GetStationsResponsePayloadTypeItemNearbyMeLocationIdType NearbyMeLocationId { get; set; }
    }

    public class GetStationsResponsePayloadTypeItemSporenTypeItem
    {
        [JsonProperty("spoorNummer")]
        public string SpoorNummer { get; set; }
    }

    public class GetStationsResponsePayloadTypeItemNamenType
    {
        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("middel")]
        public string Middel { get; set; }

        [JsonProperty("kort")]
        public string Kort { get; set; }
    }

    public class GetStationsResponsePayloadTypeItemNearbyMeLocationIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nederlandsespoorweip;

    public partial class WorkflowManagedActions
    {
        public NederlandsespoorweipActions Nederlandsespoorweip(string connectionId) => new NederlandsespoorweipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NederlandsespoorweipTriggers Nederlandsespoorweip(string connectionId) => new NederlandsespoorweipTriggers(connectionId);
    }
}