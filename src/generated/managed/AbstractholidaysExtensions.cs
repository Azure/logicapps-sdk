//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractholidays
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractholidaysActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractholidays")]
        public IBodyWorkflowAction<ListHolidaysResponseItem[]> ListHolidays(Expression<Func<string>> country, Expression<Func<string>> year = null, Expression<Func<string>> month = null, Expression<Func<string>> day = null)
        {
            var apiCallPath = "/v1/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (year != null)
                callPayload.Queries["year"] = CSharpExpressionConverter.ConvertO(year);
            if (month != null)
                callPayload.Queries["month"] = CSharpExpressionConverter.ConvertO(month);
            if (day != null)
                callPayload.Queries["day"] = CSharpExpressionConverter.ConvertO(day);
            return new ApiConnectionAction<ListHolidaysResponseItem[]>(callPayload);
        }
    }

    public class AbstractholidaysTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListHolidaysResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_local")]
        public string NameLocal { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("date_year")]
        public string DateYear { get; set; }

        [JsonProperty("date_month")]
        public string DateMonth { get; set; }

        [JsonProperty("date_day")]
        public string DateDay { get; set; }

        [JsonProperty("week_day")]
        public string WeekDay { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractholidays;

    public partial class WorkflowManagedActions
    {
        public AbstractholidaysActions Abstractholidays(string connectionId) => new AbstractholidaysActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractholidaysTriggers Abstractholidays(string connectionId) => new AbstractholidaysTriggers(connectionId);
    }
}