//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gsaperdiem
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GsaperdiemActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaperdiem")]
        public IBodyWorkflowAction<GetPerDiemRatesByCityStateAndYearResponse> GetPerDiemRatesByCityStateAndYear(Expression<Func<string>> city, Expression<Func<string>> state, Expression<Func<string>> year)
        {
            var apiCallPath = String.Format("/v2/rates/city/{0}/state/{1}/year/{2}", ExpressionConverter.ConvertWithUrlEncoding(city, 1), ExpressionConverter.ConvertWithUrlEncoding(state, 1), ExpressionConverter.ConvertWithUrlEncoding(year, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPerDiemRatesByCityStateAndYearResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaperdiem")]
        public IBodyWorkflowAction<GetPerDiemRatesForAllCountiesResponse> GetPerDiemRatesForAllCounties(Expression<Func<string>> state, Expression<Func<string>> year)
        {
            var apiCallPath = String.Format("/v2/rates/state/{0}/year/{1}", ExpressionConverter.ConvertWithUrlEncoding(state, 1), ExpressionConverter.ConvertWithUrlEncoding(year, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPerDiemRatesForAllCountiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaperdiem")]
        public IBodyWorkflowAction<GetPerDiemRatesByZipCodeAndYearResponse> GetPerDiemRatesByZipCodeAndYear(Expression<Func<int>> zip, Expression<Func<string>> year)
        {
            var apiCallPath = String.Format("/v2/rates/zip/{0}/year/{1}", ExpressionConverter.ConvertWithUrlEncoding(zip, 1), ExpressionConverter.ConvertWithUrlEncoding(year, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPerDiemRatesByZipCodeAndYearResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaperdiem")]
        public IBodyWorkflowAction<LodgingRatesForTheContinentalUsByYearResponseItem[]> LodgingRatesForTheContinentalUsByYear(Expression<Func<string>> year)
        {
            var apiCallPath = String.Format("/v2/rates/conus/lodging/{0}", ExpressionConverter.ConvertWithUrlEncoding(year, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LodgingRatesForTheContinentalUsByYearResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsaperdiem")]
        public IBodyWorkflowAction<MappingOfZIPCodeToLocationsResponseItem[]> MappingOfZIPCodeToLocations(Expression<Func<string>> year)
        {
            var apiCallPath = String.Format("/v2/rates/conus/zipcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(year, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MappingOfZIPCodeToLocationsResponseItem[]>(callPayload);
        }
    }

    public class GsaperdiemTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetPerDiemRatesByCityStateAndYearResponse
    {
        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("errors")]
        public string Errors { get; set; }

        [JsonProperty("rates")]
        public GetPerDiemRatesByCityStateAndYearResponseRatesTypeItem[] Rates { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class GetPerDiemRatesByCityStateAndYearResponseRatesTypeItem
    {
        [JsonProperty("oconusInfo")]
        public string OconusInfo { get; set; }

        [JsonProperty("rate")]
        public GetPerDiemRatesByCityStateAndYearResponseRatesTypeItemRateTypeItem[] Rate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("isOconus")]
        public string IsOconus { get; set; }
    }

    public class GetPerDiemRatesByCityStateAndYearResponseRatesTypeItemRateTypeItem
    {
        [JsonProperty("months")]
        public GetPerDiemRatesByCityStateAndYearResponseRatesTypeItemRateTypeItemMonthsType Months { get; set; }

        [JsonProperty("meals")]
        public int Meals { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("standardRate")]
        public string StandardRate { get; set; }
    }

    public class GetPerDiemRatesByCityStateAndYearResponseRatesTypeItemRateTypeItemMonthsType
    {
        [JsonProperty("month")]
        public GetPerDiemRatesByCityStateAndYearResponseRatesTypeItemRateTypeItemMonthsTypeMonthTypeItem[] Month { get; set; }
    }

    public class GetPerDiemRatesByCityStateAndYearResponseRatesTypeItemRateTypeItemMonthsTypeMonthTypeItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }
    }

    public class GetPerDiemRatesForAllCountiesResponse
    {
        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("errors")]
        public string Errors { get; set; }

        [JsonProperty("rates")]
        public GetPerDiemRatesForAllCountiesResponseRatesTypeItem[] Rates { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class GetPerDiemRatesForAllCountiesResponseRatesTypeItem
    {
        [JsonProperty("oconusInfo")]
        public string OconusInfo { get; set; }

        [JsonProperty("rate")]
        public GetPerDiemRatesForAllCountiesResponseRatesTypeItemRateTypeItem[] Rate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("isOconus")]
        public string IsOconus { get; set; }
    }

    public class GetPerDiemRatesForAllCountiesResponseRatesTypeItemRateTypeItem
    {
        [JsonProperty("months")]
        public GetPerDiemRatesForAllCountiesResponseRatesTypeItemRateTypeItemMonthsType Months { get; set; }

        [JsonProperty("meals")]
        public int Meals { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("standardRate")]
        public string StandardRate { get; set; }
    }

    public class GetPerDiemRatesForAllCountiesResponseRatesTypeItemRateTypeItemMonthsType
    {
        [JsonProperty("month")]
        public GetPerDiemRatesForAllCountiesResponseRatesTypeItemRateTypeItemMonthsTypeMonthTypeItem[] Month { get; set; }
    }

    public class GetPerDiemRatesForAllCountiesResponseRatesTypeItemRateTypeItemMonthsTypeMonthTypeItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }
    }

    public class GetPerDiemRatesByZipCodeAndYearResponse
    {
        [JsonProperty("request")]
        public string Request { get; set; }

        [JsonProperty("errors")]
        public string Errors { get; set; }

        [JsonProperty("rates")]
        public GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItem[] Rates { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItem
    {
        [JsonProperty("oconusInfo")]
        public string OconusInfo { get; set; }

        [JsonProperty("rate")]
        public GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItemRateTypeItem[] Rate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("isOconus")]
        public string IsOconus { get; set; }
    }

    public class GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItemRateTypeItem
    {
        [JsonProperty("months")]
        public GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItemRateTypeItemMonthsType Months { get; set; }

        [JsonProperty("meals")]
        public int Meals { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("standardRate")]
        public string StandardRate { get; set; }
    }

    public class GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItemRateTypeItemMonthsType
    {
        [JsonProperty("month")]
        public GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItemRateTypeItemMonthsTypeMonthTypeItem[] Month { get; set; }
    }

    public class GetPerDiemRatesByZipCodeAndYearResponseRatesTypeItemRateTypeItemMonthsTypeMonthTypeItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }
    }

    public class LodgingRatesForTheContinentalUsByYearResponseItem
    {
        [JsonProperty("Jan")]
        public string January { get; set; }

        [JsonProperty("Feb")]
        public string February { get; set; }

        [JsonProperty("Mar")]
        public string March { get; set; }

        [JsonProperty("Apr")]
        public string April { get; set; }
        public string May { get; set; }

        [JsonProperty("Jun")]
        public string June { get; set; }

        [JsonProperty("Jul")]
        public string July { get; set; }

        [JsonProperty("Aug")]
        public string August { get; set; }

        [JsonProperty("Sep")]
        public string September { get; set; }

        [JsonProperty("Oct")]
        public string October { get; set; }

        [JsonProperty("Nov")]
        public string November { get; set; }

        [JsonProperty("Dec")]
        public string December { get; set; }
        public string Meals { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }

        [JsonProperty("DID")]
        public string DestinationID { get; set; }
    }

    public class MappingOfZIPCodeToLocationsResponseItem
    {
        public string Zip { get; set; }

        [JsonProperty("DID")]
        public string DestinationID { get; set; }

        [JsonProperty("ST")]
        public string State { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gsaperdiem;

    public partial class WorkflowManagedActions
    {
        public GsaperdiemActions Gsaperdiem(string connectionId) => new GsaperdiemActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GsaperdiemTriggers Gsaperdiem(string connectionId) => new GsaperdiemTriggers(connectionId);
    }
}