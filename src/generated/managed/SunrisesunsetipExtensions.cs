//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sunrisesunsetip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SunrisesunsetipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sunrisesunsetip")]
        public IBodyWorkflowAction<GetDataResponse> GetData(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<string>> date = null, Expression<Func<formattedInput>> formatted = null)
        {
            var apiCallPath = "/json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["lat"] = CSharpExpressionConverter.ConvertO(lat);
            callPayload.Queries["lng"] = CSharpExpressionConverter.ConvertO(lng);
            callPayload.Queries["date"] = Convert.ToString("");
            if (date != null)
                callPayload.Queries["date"] = CSharpExpressionConverter.ConvertO(date);
            if (formatted != null)
                callPayload.Queries["formatted"] = CSharpExpressionConverter.Convert(formatted);
            return new ApiConnectionAction<GetDataResponse>(callPayload);
        }
    }

    public class SunrisesunsetipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDataResponse
    {
        [JsonProperty("results")]
        public GetDataResponseResultsType Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetDataResponseResultsType
    {
        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("solar_noon")]
        public string SolarNoon { get; set; }

        [JsonProperty("day_length")]
        public string DayLength { get; set; }

        [JsonProperty("civil_twilight_begin")]
        public string CivilTwilightBegin { get; set; }

        [JsonProperty("civil_twilight_end")]
        public string CivilTwilightEnd { get; set; }

        [JsonProperty("nautical_twilight_begin")]
        public string NauticalTwilightBegin { get; set; }

        [JsonProperty("nautical_twilight_end")]
        public string NauticalTwilightEnd { get; set; }

        [JsonProperty("astronomical_twilight_begin")]
        public string AstronomicalTwilightBegin { get; set; }

        [JsonProperty("astronomical_twilight_end")]
        public string AstronomicalTwilightEnd { get; set; }
    }

    public enum formattedInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sunrisesunsetip;

    public partial class WorkflowManagedActions
    {
        public SunrisesunsetipActions Sunrisesunsetip(string connectionId) => new SunrisesunsetipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SunrisesunsetipTriggers Sunrisesunsetip(string connectionId) => new SunrisesunsetipTriggers(connectionId);
    }
}