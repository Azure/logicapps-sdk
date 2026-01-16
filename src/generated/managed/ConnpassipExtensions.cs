//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connpassip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnpassipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connpassip")]
        public IBodyWorkflowAction<SearchEventResponse> SearchEvent(Expression<Func<string>> keyword = null, Expression<Func<string>> eventId = null, Expression<Func<string>> keywordOr = null, Expression<Func<string>> ym = null, Expression<Func<string>> ymd = null, Expression<Func<string>> nickname = null, Expression<Func<string>> ownerNickname = null, Expression<Func<string>> seriesId = null, Expression<Func<string>> start = null, Expression<Func<string>> order = null, Expression<Func<string>> count = null)
        {
            var apiCallPath = "/api/v1/event/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (keyword != null)
                callPayload.Queries["keyword"] = ExpressionConverter.Convert(keyword);
            if (eventId != null)
                callPayload.Queries["event_id"] = ExpressionConverter.Convert(eventId);
            if (keywordOr != null)
                callPayload.Queries["keyword_or"] = ExpressionConverter.Convert(keywordOr);
            if (ym != null)
                callPayload.Queries["ym"] = ExpressionConverter.Convert(ym);
            if (ymd != null)
                callPayload.Queries["ymd"] = ExpressionConverter.Convert(ymd);
            if (nickname != null)
                callPayload.Queries["nickname"] = ExpressionConverter.Convert(nickname);
            if (ownerNickname != null)
                callPayload.Queries["owner_nickname"] = ExpressionConverter.Convert(ownerNickname);
            if (seriesId != null)
                callPayload.Queries["series_id"] = ExpressionConverter.Convert(seriesId);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (order != null)
                callPayload.Queries["order"] = ExpressionConverter.Convert(order);
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            callPayload.Queries["format"] = Convert.ToString("json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<SearchEventResponse>(callPayload);
        }
    }

    public class ConnpassipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchEventResponse
    {
        [JsonProperty("results_start")]
        public int ResultsStart { get; set; }

        [JsonProperty("results_returned")]
        public int ResultsReturned { get; set; }

        [JsonProperty("results_available")]
        public int ResultsAvailable { get; set; }

        [JsonProperty("events")]
        public SearchEventResponseEventsTypeItem[] Events { get; set; }
    }

    public class SearchEventResponseEventsTypeItem
    {
        [JsonProperty("event_Id")]
        public int EventId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("catch")]
        public string Catch { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("event_url")]
        public string EventUrl { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("hash_tag")]
        public string HashTag { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("accepted")]
        public int Accepted { get; set; }

        [JsonProperty("waiting")]
        public int Waiting { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("owner_Id")]
        public int OwnerId { get; set; }

        [JsonProperty("owner_nickname")]
        public string OwnerNickname { get; set; }

        [JsonProperty("owner_display_name")]
        public string OwnerDisplayName { get; set; }

        [JsonProperty("place")]
        public string Place { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("series")]
        public SearchEventResponseEventsTypeItemSeriesType Series { get; set; }
    }

    public class SearchEventResponseEventsTypeItemSeriesType
    {
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Connpassip;

    public partial class WorkflowManagedActions
    {
        public ConnpassipActions Connpassip(string connectionId) => new ConnpassipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConnpassipTriggers Connpassip(string connectionId) => new ConnpassipTriggers(connectionId);
    }
}