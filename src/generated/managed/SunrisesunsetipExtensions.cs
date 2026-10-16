//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sunrisesunsetip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SunrisesunsetipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sunrisesunsetip")]
        public IBodyWorkflowAction<GetDataResponse> GetData(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<string>> date = null, Expression<Func<formattedInput>> formatted = null)
        {
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: true);
            var __workflow_lng = WorkflowExpression.Compile(lng, nameof(lng), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_formatted = WorkflowExpression.Compile(formatted, nameof(formatted), required: false);
            return new DeferredBodyAction<GetDataResponse>(() =>
            {
                var apiCallPath = "/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(__workflow_lng);
                callPayload.Queries["date"] = Convert.ToString("");
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_formatted != null)
                    callPayload.Queries["formatted"] = ExpressionConverter.Convert(__workflow_formatted);
                return new ApiConnectionAction<GetDataResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
