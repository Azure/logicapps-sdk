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
        public IBodyWorkflowAction<GetDataResponse> GetData([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<formattedInput> formatted = null)
        {
            SourceExpression.Validate(lat, nameof(lat), required: true);
            SourceExpression.Validate(lng, nameof(lng), required: true);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(formatted, nameof(formatted), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                callPayload.Queries["lng"] = SourceExpressionConverter.ConvertO(lng);
                callPayload.Queries["date"] = Convert.ToString("");
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (formatted != null)
                    callPayload.Queries["formatted"] = SourceExpressionConverter.Convert(formatted);
                return callPayload;
            }

            return new ApiConnectionAction<GetDataResponse>(BuildSourceInput);
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
        _0 = 0,
        _1 = 1
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