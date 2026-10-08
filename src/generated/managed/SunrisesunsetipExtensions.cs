//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sunrisesunsetip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SunrisesunsetipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sunrisesunsetip")]
        [WorkflowExpressionFactory(nameof(__BuildGetData))]
        public IBodyWorkflowAction<GetDataResponse> GetData([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<formattedInput> formatted = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDataResponse> __BuildGetData(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<string> date = null, WorkflowExpression<formattedInput> formatted = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(formatted, nameof(formatted), required: false);
            return new DeferredBodyAction<GetDataResponse>(() =>
            {
                var apiCallPath = "/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                callPayload.Queries["date"] = Convert.ToString("");
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (formatted != null)
                    callPayload.Queries["formatted"] = ExpressionConverter.Convert(formatted);
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