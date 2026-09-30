//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Festivoip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FestivoipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "festivoip")]
        public IBodyWorkflowAction<HolidaysGetResponse> HolidaysGet([WorkflowExpression] Func<string> country, [WorkflowExpression] Func<int> year, [WorkflowExpression] Func<int> month = null, [WorkflowExpression] Func<int> day = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<bool> before = null, [WorkflowExpression] Func<bool> after = null, [WorkflowExpression] Func<bool> @public = null, [WorkflowExpression] Func<string> timezone = null)
        {
            var apiCallPath = "/holidays";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            callPayload.Queries["year"] = ExpressionConverter.Convert(year);
            if (month != null)
                callPayload.Queries["month"] = ExpressionConverter.Convert(month);
            if (day != null)
                callPayload.Queries["day"] = ExpressionConverter.Convert(day);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Queries["before"] = Convert.ToString(false);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            callPayload.Queries["after"] = Convert.ToString(false);
            if (after != null)
                callPayload.Queries["after"] = ExpressionConverter.Convert(after);
            callPayload.Queries["public"] = Convert.ToString(false);
            if (@public != null)
                callPayload.Queries["public"] = ExpressionConverter.Convert(@public);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (timezone != null)
                callPayload.Queries["timezone"] = ExpressionConverter.Convert(timezone);
            return new ApiConnectionAction<HolidaysGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "festivoip")]
        public IBodyWorkflowAction<CountriesGetResponseItem[]> CountriesGet([WorkflowExpression] Func<string> code = null)
        {
            var apiCallPath = "/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (code != null)
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
            return new ApiConnectionAction<CountriesGetResponseItem[]>(callPayload);
        }
    }

    public class FestivoipTriggers([ConnectionName] string connectionId)
    {
    }

    public class HolidaysGetResponse
    {
        [JsonProperty("holidays")]
        public HolidaysGetResponseHolidaysTypeItem[] Holidays { get; set; }
    }

    public class HolidaysGetResponseHolidaysTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("observed")]
        public string Observed { get; set; }

        [JsonProperty("substitute")]
        public bool Substitute { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("subdivisions")]
        public string[] Subdivisions { get; set; }
    }

    public class CountriesGetResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("codeAlpha2")]
        public string CodeAlpha2 { get; set; }

        [JsonProperty("isSupported")]
        public bool IsSupported { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Festivoip;

    public partial class WorkflowManagedActions
    {
        public FestivoipActions Festivoip(string connectionId) => new FestivoipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FestivoipTriggers Festivoip(string connectionId) => new FestivoipTriggers(connectionId);
    }
}