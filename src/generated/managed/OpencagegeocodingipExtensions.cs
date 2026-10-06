//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opencagegeocodingip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpencagegeocodingipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opencagegeocodingip")]
        [WorkflowExpressionFactory(nameof(__BuildReverseGeocoding))]
        public IBodyWorkflowAction<ReverseGeocodingResponse> ReverseGeocoding([WorkflowExpression] Func<string> lat, [WorkflowExpression] Func<string> @long)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opencagegeocodingip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReverseGeocodingResponse> __BuildReverseGeocoding(WorkflowExpression<string> lat, WorkflowExpression<string> @long)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(@long, nameof(@long), required: true);
            return new DeferredBodyAction<ReverseGeocodingResponse>(() =>
            {
                var apiCallPath = "/v1/json/reverse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Headers["long"] = ExpressionConverter.Convert(@long);
                return new ApiConnectionAction<ReverseGeocodingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opencagegeocodingip")]
        [WorkflowExpressionFactory(nameof(__BuildForwardGeocoding))]
        public IBodyWorkflowAction<ForwardGeocodingResponse> ForwardGeocoding([WorkflowExpression] Func<string> placename)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opencagegeocodingip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ForwardGeocodingResponse> __BuildForwardGeocoding(WorkflowExpression<string> placename)
        {
            WorkflowExpression.Validate(placename, nameof(placename), required: true);
            return new DeferredBodyAction<ForwardGeocodingResponse>(() =>
            {
                var apiCallPath = "/v1/json/forward";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["placename"] = ExpressionConverter.Convert(placename);
                return new ApiConnectionAction<ForwardGeocodingResponse>(callPayload);
            });
        }
    }

    public class OpencagegeocodingipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReverseGeocodingResponse
    {
        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("licenses")]
        public ReverseGeocodingResponseLicensesTypeItem[] Licenses { get; set; }

        [JsonProperty("rate")]
        public ReverseGeocodingResponseRateType Rate { get; set; }

        [JsonProperty("results")]
        public ReverseGeocodingResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("status")]
        public ReverseGeocodingResponseStatusType Status { get; set; }

        [JsonProperty("stay_informed")]
        public ReverseGeocodingResponseStayInformedType StayInformed { get; set; }

        [JsonProperty("thanks")]
        public string Thanks { get; set; }

        [JsonProperty("timestamp")]
        public ReverseGeocodingResponseTimestampType Timestamp { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class ReverseGeocodingResponseLicensesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ReverseGeocodingResponseRateType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset")]
        public int Reset { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItem
    {
        [JsonProperty("annotations")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsType Annotations { get; set; }

        [JsonProperty("bounds")]
        public ReverseGeocodingResponseResultsTypeItemBoundsType Bounds { get; set; }

        [JsonProperty("components")]
        public ReverseGeocodingResponseResultsTypeItemComponentsType Components { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("geometry")]
        public ReverseGeocodingResponseResultsTypeItemGeometryType Geometry { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsType
    {
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeDMSType DMS { get; set; }
        public string MGRS { get; set; }
        public string Maidenhead { get; set; }
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeMercatorType Mercator { get; set; }
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeOSMType OSM { get; set; }

        [JsonProperty("UN_M49")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeUNM49Type UNM49 { get; set; }

        [JsonProperty("callingcode")]
        public int Callingcode { get; set; }

        [JsonProperty("currency")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeCurrencyType Currency { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("geohash")]
        public string Geohash { get; set; }

        [JsonProperty("qibla")]
        public double Qibla { get; set; }

        [JsonProperty("roadinfo")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeRoadinfoType Roadinfo { get; set; }

        [JsonProperty("sun")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeSunType Sun { get; set; }

        [JsonProperty("timezone")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeTimezoneType Timezone { get; set; }

        [JsonProperty("what3words")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeWhat3wordsType What3words { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeDMSType
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeMercatorType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeOSMType
    {
        [JsonProperty("edit_url")]
        public string EditUrl { get; set; }

        [JsonProperty("note_url")]
        public string NoteUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeUNM49Type
    {
        [JsonProperty("regions")]
        public JToken Regions { get; set; }

        [JsonProperty("statistical_groupings")]
        public string[] StatisticalGroupings { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeCurrencyType
    {
        [JsonProperty("alternate_symbols")]
        public JToken[] AlternateSymbols { get; set; }

        [JsonProperty("decimal_mark")]
        public string DecimalMark { get; set; }

        [JsonProperty("html_entity")]
        public string HtmlEntity { get; set; }

        [JsonProperty("iso_code")]
        public string IsoCode { get; set; }

        [JsonProperty("iso_numeric")]
        public string IsoNumeric { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("smallest_denomination")]
        public int SmallestDenomination { get; set; }

        [JsonProperty("subunit")]
        public string Subunit { get; set; }

        [JsonProperty("subunit_to_unit")]
        public int SubunitToUnit { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("symbol_first")]
        public int SymbolFirst { get; set; }

        [JsonProperty("thousands_separator")]
        public string ThousandsSeparator { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeRoadinfoType
    {
        [JsonProperty("drive_on")]
        public string DriveOn { get; set; }

        [JsonProperty("road")]
        public string Road { get; set; }

        [JsonProperty("speed_in")]
        public string SpeedIn { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeSunType
    {
        [JsonProperty("rise")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeRiseType Rise { get; set; }

        [JsonProperty("set")]
        public ReverseGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeSetType Set { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeRiseType
    {
        [JsonProperty("apparent")]
        public int Apparent { get; set; }

        [JsonProperty("astronomical")]
        public int Astronomical { get; set; }

        [JsonProperty("civil")]
        public int Civil { get; set; }

        [JsonProperty("nautical")]
        public int Nautical { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeSetType
    {
        [JsonProperty("apparent")]
        public int Apparent { get; set; }

        [JsonProperty("astronomical")]
        public int Astronomical { get; set; }

        [JsonProperty("civil")]
        public int Civil { get; set; }

        [JsonProperty("nautical")]
        public int Nautical { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeTimezoneType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("now_in_dst")]
        public int NowInDst { get; set; }

        [JsonProperty("offset_sec")]
        public int OffsetSec { get; set; }

        [JsonProperty("offset_string")]
        public string OffsetString { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemAnnotationsTypeWhat3wordsType
    {
        [JsonProperty("words")]
        public string Words { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemBoundsType
    {
        [JsonProperty("northeast")]
        public ReverseGeocodingResponseResultsTypeItemBoundsTypeNortheastType Northeast { get; set; }

        [JsonProperty("southwest")]
        public ReverseGeocodingResponseResultsTypeItemBoundsTypeSouthwestType Southwest { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemBoundsTypeNortheastType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemBoundsTypeSouthwestType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemComponentsType
    {
        [JsonProperty("ISO_3166-1_alpha-2")]
        public string ISO31661Alpha2 { get; set; }

        [JsonProperty("ISO_3166-1_alpha-3")]
        public string ISO31661Alpha3 { get; set; }

        [JsonProperty("_category")]
        public string Category { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_district")]
        public string CityDistrict { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }

        [JsonProperty("neighbourhood")]
        public string Neighbourhood { get; set; }

        [JsonProperty("political_union")]
        public string PoliticalUnion { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("road")]
        public string Road { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }
    }

    public class ReverseGeocodingResponseResultsTypeItemGeometryType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class ReverseGeocodingResponseStatusType
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ReverseGeocodingResponseStayInformedType
    {
        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public class ReverseGeocodingResponseTimestampType
    {
        [JsonProperty("created_http")]
        public string CreatedHttp { get; set; }

        [JsonProperty("created_unix")]
        public int CreatedUnix { get; set; }
    }

    public class ForwardGeocodingResponse
    {
        [JsonProperty("documentation")]
        public string Documentation { get; set; }

        [JsonProperty("licenses")]
        public ForwardGeocodingResponseLicensesTypeItem[] Licenses { get; set; }

        [JsonProperty("rate")]
        public ForwardGeocodingResponseRateType Rate { get; set; }

        [JsonProperty("results")]
        public ForwardGeocodingResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("status")]
        public ForwardGeocodingResponseStatusType Status { get; set; }

        [JsonProperty("stay_informed")]
        public ForwardGeocodingResponseStayInformedType StayInformed { get; set; }

        [JsonProperty("thanks")]
        public string Thanks { get; set; }

        [JsonProperty("timestamp")]
        public ForwardGeocodingResponseTimestampType Timestamp { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }

    public class ForwardGeocodingResponseLicensesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ForwardGeocodingResponseRateType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset")]
        public int Reset { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItem
    {
        [JsonProperty("annotations")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsType Annotations { get; set; }

        [JsonProperty("bounds")]
        public ForwardGeocodingResponseResultsTypeItemBoundsType Bounds { get; set; }

        [JsonProperty("components")]
        public ForwardGeocodingResponseResultsTypeItemComponentsType Components { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("geometry")]
        public ForwardGeocodingResponseResultsTypeItemGeometryType Geometry { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsType
    {
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeDMSType DMS { get; set; }
        public string MGRS { get; set; }
        public string Maidenhead { get; set; }
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeMercatorType Mercator { get; set; }
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeOSMType OSM { get; set; }

        [JsonProperty("UN_M49")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeUNM49Type UNM49 { get; set; }

        [JsonProperty("callingcode")]
        public int Callingcode { get; set; }

        [JsonProperty("currency")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeCurrencyType Currency { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("geohash")]
        public string Geohash { get; set; }

        [JsonProperty("qibla")]
        public double Qibla { get; set; }

        [JsonProperty("roadinfo")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeRoadinfoType Roadinfo { get; set; }

        [JsonProperty("sun")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeSunType Sun { get; set; }

        [JsonProperty("timezone")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeTimezoneType Timezone { get; set; }

        [JsonProperty("what3words")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeWhat3wordsType What3words { get; set; }

        [JsonProperty("wikidata")]
        public string Wikidata { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeDMSType
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeMercatorType
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeOSMType
    {
        [JsonProperty("edit_url")]
        public string EditUrl { get; set; }

        [JsonProperty("note_url")]
        public string NoteUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeUNM49Type
    {
        [JsonProperty("regions")]
        public JToken Regions { get; set; }

        [JsonProperty("statistical_groupings")]
        public string[] StatisticalGroupings { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeCurrencyType
    {
        [JsonProperty("alternate_symbols")]
        public JToken[] AlternateSymbols { get; set; }

        [JsonProperty("decimal_mark")]
        public string DecimalMark { get; set; }

        [JsonProperty("html_entity")]
        public string HtmlEntity { get; set; }

        [JsonProperty("iso_code")]
        public string IsoCode { get; set; }

        [JsonProperty("iso_numeric")]
        public string IsoNumeric { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("smallest_denomination")]
        public int SmallestDenomination { get; set; }

        [JsonProperty("subunit")]
        public string Subunit { get; set; }

        [JsonProperty("subunit_to_unit")]
        public int SubunitToUnit { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("symbol_first")]
        public int SymbolFirst { get; set; }

        [JsonProperty("thousands_separator")]
        public string ThousandsSeparator { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeRoadinfoType
    {
        [JsonProperty("drive_on")]
        public string DriveOn { get; set; }

        [JsonProperty("road")]
        public string Road { get; set; }

        [JsonProperty("speed_in")]
        public string SpeedIn { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeSunType
    {
        [JsonProperty("rise")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeRiseType Rise { get; set; }

        [JsonProperty("set")]
        public ForwardGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeSetType Set { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeRiseType
    {
        [JsonProperty("apparent")]
        public int Apparent { get; set; }

        [JsonProperty("astronomical")]
        public int Astronomical { get; set; }

        [JsonProperty("civil")]
        public int Civil { get; set; }

        [JsonProperty("nautical")]
        public int Nautical { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeSunTypeSetType
    {
        [JsonProperty("apparent")]
        public int Apparent { get; set; }

        [JsonProperty("astronomical")]
        public int Astronomical { get; set; }

        [JsonProperty("civil")]
        public int Civil { get; set; }

        [JsonProperty("nautical")]
        public int Nautical { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeTimezoneType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("now_in_dst")]
        public int NowInDst { get; set; }

        [JsonProperty("offset_sec")]
        public int OffsetSec { get; set; }

        [JsonProperty("offset_string")]
        public string OffsetString { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemAnnotationsTypeWhat3wordsType
    {
        [JsonProperty("words")]
        public string Words { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemBoundsType
    {
        [JsonProperty("northeast")]
        public ForwardGeocodingResponseResultsTypeItemBoundsTypeNortheastType Northeast { get; set; }

        [JsonProperty("southwest")]
        public ForwardGeocodingResponseResultsTypeItemBoundsTypeSouthwestType Southwest { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemBoundsTypeNortheastType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemBoundsTypeSouthwestType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemComponentsType
    {
        [JsonProperty("ISO_3166-1_alpha-2")]
        public string ISO31661Alpha2 { get; set; }

        [JsonProperty("ISO_3166-1_alpha-3")]
        public string ISO31661Alpha3 { get; set; }

        [JsonProperty("_category")]
        public string Category { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("house_number")]
        public string HouseNumber { get; set; }

        [JsonProperty("museum")]
        public string Museum { get; set; }

        [JsonProperty("political_union")]
        public string PoliticalUnion { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("road")]
        public string Road { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }
    }

    public class ForwardGeocodingResponseResultsTypeItemGeometryType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class ForwardGeocodingResponseStatusType
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ForwardGeocodingResponseStayInformedType
    {
        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }
    }

    public class ForwardGeocodingResponseTimestampType
    {
        [JsonProperty("created_http")]
        public string CreatedHttp { get; set; }

        [JsonProperty("created_unix")]
        public int CreatedUnix { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opencagegeocodingip;

    public partial class WorkflowManagedActions
    {
        public OpencagegeocodingipActions Opencagegeocodingip(string connectionId) => new OpencagegeocodingipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpencagegeocodingipTriggers Opencagegeocodingip(string connectionId) => new OpencagegeocodingipTriggers(connectionId);
    }
}