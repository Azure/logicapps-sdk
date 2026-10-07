//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calendarificip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CalendarificipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarificip")]
        [WorkflowExpressionFactory(nameof(__BuildListHolidays))]
        public IBodyWorkflowAction<ListHolidaysResponse> ListHolidays([WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> day = null, [WorkflowExpression] Func<string> month = null, [WorkflowExpression] Func<string> location = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> language = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarificip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListHolidaysResponse> __BuildListHolidays(WorkflowExpression<string> country, WorkflowExpression<string> year, WorkflowExpression<string> day = null, WorkflowExpression<string> month = null, WorkflowExpression<string> location = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<string> language = null)
        {
            WorkflowExpression.Validate(country, nameof(country), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: true);
            WorkflowExpression.Validate(day, nameof(day), required: false);
            WorkflowExpression.Validate(month, nameof(month), required: false);
            WorkflowExpression.Validate(location, nameof(location), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(language, nameof(language), required: false);
            return new DeferredBodyAction<ListHolidaysResponse>(() =>
            {
                var apiCallPath = "/api/v2/holidays";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (day != null)
                    callPayload.Queries["day"] = ExpressionConverter.Convert(day);
                if (month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(month);
                if (location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(location);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(language);
                return new ApiConnectionAction<ListHolidaysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarificip")]
        public IBodyWorkflowAction<ListLanguagesResponse> ListLanguages()
        {
            var apiCallPath = "/api/v2/languages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListLanguagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarificip")]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries()
        {
            var apiCallPath = "/api/v2/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListCountriesResponse>(callPayload);
        }
    }

    public class CalendarificipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListHolidaysResponse
    {
        [JsonProperty("response")]
        public ListHolidaysResponseResponseType Response { get; set; }
    }

    public class ListHolidaysResponseResponseType
    {
        [JsonProperty("holidays")]
        public ListHolidaysResponseResponseTypeHolidaysTypeItem[] Holidays { get; set; }
    }

    public class ListHolidaysResponseResponseTypeHolidaysTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("country")]
        public ListHolidaysResponseResponseTypeHolidaysTypeItemCountryType Country { get; set; }

        [JsonProperty("date")]
        public ListHolidaysResponseResponseTypeHolidaysTypeItemDateType Date { get; set; }

        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("primary_type")]
        public string PrimaryType { get; set; }

        [JsonProperty("canonical_url")]
        public string CanonicalUrl { get; set; }

        [JsonProperty("locations")]
        public string Locations { get; set; }
    }

    public class ListHolidaysResponseResponseTypeHolidaysTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListHolidaysResponseResponseTypeHolidaysTypeItemDateType
    {
        [JsonProperty("iso")]
        public string Iso { get; set; }

        [JsonProperty("datetime")]
        public ListHolidaysResponseResponseTypeHolidaysTypeItemDateTypeDatetimeType Datetime { get; set; }
    }

    public class ListHolidaysResponseResponseTypeHolidaysTypeItemDateTypeDatetimeType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "local")]
        Local,
        [EnumMember(Value = "national")]
        National,
        [EnumMember(Value = "religious")]
        Religious,
        [EnumMember(Value = "observance")]
        Observance
    }

    public class ListLanguagesResponse
    {
        [JsonProperty("response")]
        public ListLanguagesResponseResponseType Response { get; set; }
    }

    public class ListLanguagesResponseResponseType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("languages")]
        public ListLanguagesResponseResponseTypeLanguagesTypeItem[] Languages { get; set; }
    }

    public class ListLanguagesResponseResponseTypeLanguagesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nativeName")]
        public string NativeName { get; set; }
    }

    public class ListCountriesResponse
    {
        [JsonProperty("response")]
        public ListCountriesResponseResponseType Response { get; set; }
    }

    public class ListCountriesResponseResponseType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("countries")]
        public ListCountriesResponseResponseTypeCountriesTypeItem[] Countries { get; set; }
    }

    public class ListCountriesResponseResponseTypeCountriesTypeItem
    {
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("iso-3166")]
        public string Iso3166 { get; set; }

        [JsonProperty("total_holidays")]
        public int TotalHolidays { get; set; }

        [JsonProperty("supported_languages")]
        public int SupportedLanguages { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Calendarificip;

    public partial class WorkflowManagedActions
    {
        public CalendarificipActions Calendarificip(string connectionId) => new CalendarificipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CalendarificipTriggers Calendarificip(string connectionId) => new CalendarificipTriggers(connectionId);
    }
}