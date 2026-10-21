//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Festivoip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FestivoipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "festivoip")]
        public IBodyWorkflowAction<HolidaysGetResponse> HolidaysGet(Expression<Func<string>> country, Expression<Func<int>> year, Expression<Func<int>> month = null, Expression<Func<int>> day = null, Expression<Func<string>> language = null, Expression<Func<bool>> before = null, Expression<Func<bool>> after = null, Expression<Func<bool>> @public = null, Expression<Func<string>> timezone = null)
        {
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: true);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: false);
            var __workflow_day = WorkflowExpression.Compile(day, nameof(day), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_public = WorkflowExpression.Compile(@public, nameof(@public), required: false);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            return new DeferredBodyAction<HolidaysGetResponse>(() =>
            {
                var apiCallPath = "/holidays";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(__workflow_month);
                if (__workflow_day != null)
                    callPayload.Queries["day"] = ExpressionConverter.Convert(__workflow_day);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                callPayload.Queries["before"] = Convert.ToString(false);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                callPayload.Queries["after"] = Convert.ToString(false);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                callPayload.Queries["public"] = Convert.ToString(false);
                if (__workflow_public != null)
                    callPayload.Queries["public"] = ExpressionConverter.Convert(__workflow_public);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                return new ApiConnectionAction<HolidaysGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "festivoip")]
        public IBodyWorkflowAction<CountriesGetResponseItem[]> CountriesGet(Expression<Func<string>> code = null)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: false);
            return new DeferredBodyAction<CountriesGetResponseItem[]>(() =>
            {
                var apiCallPath = "/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_code != null)
                    callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                return new ApiConnectionAction<CountriesGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
