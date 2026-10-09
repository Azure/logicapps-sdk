//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connpassip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnpassipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connpassip")]
        [WorkflowExpressionFactory(nameof(__BuildSearchEvent))]
        public IBodyWorkflowAction<SearchEventResponse> SearchEvent([WorkflowExpression] Func<string> keyword = null, [WorkflowExpression] Func<string> eventId = null, [WorkflowExpression] Func<string> keywordOr = null, [WorkflowExpression] Func<string> ym = null, [WorkflowExpression] Func<string> ymd = null, [WorkflowExpression] Func<string> nickname = null, [WorkflowExpression] Func<string> ownerNickname = null, [WorkflowExpression] Func<string> seriesId = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> order = null, [WorkflowExpression] Func<string> count = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchEventResponse> __BuildSearchEvent(WorkflowExpression<string> keyword = null, WorkflowExpression<string> eventId = null, WorkflowExpression<string> keywordOr = null, WorkflowExpression<string> ym = null, WorkflowExpression<string> ymd = null, WorkflowExpression<string> nickname = null, WorkflowExpression<string> ownerNickname = null, WorkflowExpression<string> seriesId = null, WorkflowExpression<string> start = null, WorkflowExpression<string> order = null, WorkflowExpression<string> count = null)
        {
            WorkflowExpression.Validate(keyword, nameof(keyword), required: false);
            WorkflowExpression.Validate(eventId, nameof(eventId), required: false);
            WorkflowExpression.Validate(keywordOr, nameof(keywordOr), required: false);
            WorkflowExpression.Validate(ym, nameof(ym), required: false);
            WorkflowExpression.Validate(ymd, nameof(ymd), required: false);
            WorkflowExpression.Validate(nickname, nameof(nickname), required: false);
            WorkflowExpression.Validate(ownerNickname, nameof(ownerNickname), required: false);
            WorkflowExpression.Validate(seriesId, nameof(seriesId), required: false);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            return new DeferredBodyAction<SearchEventResponse>(() =>
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