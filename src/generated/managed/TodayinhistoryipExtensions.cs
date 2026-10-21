//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todayinhistoryip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodayinhistoryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todayinhistoryip")]
        public IBodyWorkflowAction<TodayGetResponse> TodayGet()
        {
            var apiCallPath = "/date";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TodayGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todayinhistoryip")]
        public IBodyWorkflowAction<DayGetResponse> DayGet(Expression<Func<string>> month, Expression<Func<string>> day)
        {
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: true);
            var __workflow_day = WorkflowExpression.Compile(day, nameof(day), required: true);
            return new DeferredBodyAction<DayGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/date/{0}/{1}", __workflow_month.WithUrlEncoding(1), __workflow_day.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DayGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class TodayinhistoryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TodayGetResponse
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("data")]
        public TodayGetResponseDataType Data { get; set; }
    }

    public class TodayGetResponseDataType
    {
        public TodayGetResponseDataTypeEventsTypeItem[] Events { get; set; }
        public TodayGetResponseDataTypeBirthsTypeItem[] Births { get; set; }
        public TodayGetResponseDataTypeDeathsTypeItem[] Deaths { get; set; }
    }

    public class TodayGetResponseDataTypeEventsTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("no_year_html")]
        public string NoYearHtml { get; set; }

        [JsonProperty("links")]
        public TodayGetResponseDataTypeEventsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class TodayGetResponseDataTypeEventsTypeItemLinksTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class TodayGetResponseDataTypeBirthsTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("no_year_html")]
        public string NoYearHtml { get; set; }

        [JsonProperty("links")]
        public TodayGetResponseDataTypeBirthsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class TodayGetResponseDataTypeBirthsTypeItemLinksTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class TodayGetResponseDataTypeDeathsTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("no_year_html")]
        public string NoYearHtml { get; set; }

        [JsonProperty("links")]
        public TodayGetResponseDataTypeDeathsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class TodayGetResponseDataTypeDeathsTypeItemLinksTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class DayGetResponse
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("data")]
        public DayGetResponseDataType Data { get; set; }
    }

    public class DayGetResponseDataType
    {
        public DayGetResponseDataTypeEventsTypeItem[] Events { get; set; }
        public DayGetResponseDataTypeBirthsTypeItem[] Births { get; set; }
        public DayGetResponseDataTypeDeathsTypeItem[] Deaths { get; set; }
    }

    public class DayGetResponseDataTypeEventsTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("no_year_html")]
        public string NoYearHtml { get; set; }

        [JsonProperty("links")]
        public DayGetResponseDataTypeEventsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class DayGetResponseDataTypeEventsTypeItemLinksTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class DayGetResponseDataTypeBirthsTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("no_year_html")]
        public string NoYearHtml { get; set; }

        [JsonProperty("links")]
        public DayGetResponseDataTypeBirthsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class DayGetResponseDataTypeBirthsTypeItemLinksTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class DayGetResponseDataTypeDeathsTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("no_year_html")]
        public string NoYearHtml { get; set; }

        [JsonProperty("links")]
        public DayGetResponseDataTypeDeathsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class DayGetResponseDataTypeDeathsTypeItemLinksTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Todayinhistoryip;

    public partial class WorkflowManagedActions
    {
        public TodayinhistoryipActions Todayinhistoryip(string connectionId) => new TodayinhistoryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TodayinhistoryipTriggers Todayinhistoryip(string connectionId) => new TodayinhistoryipTriggers(connectionId);
    }
}
