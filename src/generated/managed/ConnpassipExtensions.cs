//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connpassip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnpassipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connpassip")]
        public IBodyWorkflowAction<SearchEventResponse, ApiConnectionActionConfiguration> SearchEvent(Expression<Func<string>> keyword = null, Expression<Func<string>> eventId = null, Expression<Func<string>> keywordOr = null, Expression<Func<string>> ym = null, Expression<Func<string>> ymd = null, Expression<Func<string>> nickname = null, Expression<Func<string>> ownerNickname = null, Expression<Func<string>> seriesId = null, Expression<Func<string>> start = null, Expression<Func<string>> order = null, Expression<Func<string>> count = null)
        {
            var __workflow_keyword = WorkflowExpression.Compile(keyword, nameof(keyword), required: false);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: false);
            var __workflow_keywordOr = WorkflowExpression.Compile(keywordOr, nameof(keywordOr), required: false);
            var __workflow_ym = WorkflowExpression.Compile(ym, nameof(ym), required: false);
            var __workflow_ymd = WorkflowExpression.Compile(ymd, nameof(ymd), required: false);
            var __workflow_nickname = WorkflowExpression.Compile(nickname, nameof(nickname), required: false);
            var __workflow_ownerNickname = WorkflowExpression.Compile(ownerNickname, nameof(ownerNickname), required: false);
            var __workflow_seriesId = WorkflowExpression.Compile(seriesId, nameof(seriesId), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<SearchEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/event/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_keyword != null)
                    callPayload.Queries["keyword"] = ExpressionConverter.Convert(__workflow_keyword);
                if (__workflow_eventId != null)
                    callPayload.Queries["event_id"] = ExpressionConverter.Convert(__workflow_eventId);
                if (__workflow_keywordOr != null)
                    callPayload.Queries["keyword_or"] = ExpressionConverter.Convert(__workflow_keywordOr);
                if (__workflow_ym != null)
                    callPayload.Queries["ym"] = ExpressionConverter.Convert(__workflow_ym);
                if (__workflow_ymd != null)
                    callPayload.Queries["ymd"] = ExpressionConverter.Convert(__workflow_ymd);
                if (__workflow_nickname != null)
                    callPayload.Queries["nickname"] = ExpressionConverter.Convert(__workflow_nickname);
                if (__workflow_ownerNickname != null)
                    callPayload.Queries["owner_nickname"] = ExpressionConverter.Convert(__workflow_ownerNickname);
                if (__workflow_seriesId != null)
                    callPayload.Queries["series_id"] = ExpressionConverter.Convert(__workflow_seriesId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SearchEventResponse>(callPayload);
            });
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

namespace Microsoft.Azure.Workflows.Sdk
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
