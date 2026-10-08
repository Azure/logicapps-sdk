//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Refugerestroomsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RefugerestroomsipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        [WorkflowExpressionFactory(nameof(__BuildRestroomsByDate))]
        public IBodyWorkflowAction<RestroomsByDateResponseItem[]> RestroomsByDate([WorkflowExpression] Func<int> day, [WorkflowExpression] Func<int> month, [WorkflowExpression] Func<int> year, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null, [WorkflowExpression] Func<bool> updated = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RestroomsByDateResponseItem[]> __BuildRestroomsByDate(WorkflowExpression<int> day, WorkflowExpression<int> month, WorkflowExpression<int> year, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> offset = null, WorkflowExpression<bool> ada = null, WorkflowExpression<bool> unisex = null, WorkflowExpression<bool> updated = null)
        {
            WorkflowExpression.Validate(day, nameof(day), required: true);
            WorkflowExpression.Validate(month, nameof(month), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(ada, nameof(ada), required: false);
            WorkflowExpression.Validate(unisex, nameof(unisex), required: false);
            WorkflowExpression.Validate(updated, nameof(updated), required: false);
            return new DeferredBodyAction<RestroomsByDateResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms/by_date";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(unisex);
                if (updated != null)
                    callPayload.Queries["updated"] = ExpressionConverter.Convert(updated);
                callPayload.Queries["day"] = ExpressionConverter.Convert(day);
                callPayload.Queries["month"] = ExpressionConverter.Convert(month);
                callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                return new ApiConnectionAction<RestroomsByDateResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        [WorkflowExpressionFactory(nameof(__BuildRestroomsByLocation))]
        public IBodyWorkflowAction<RestroomsByLocationResponseItem[]> RestroomsByLocation([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RestroomsByLocationResponseItem[]> __BuildRestroomsByLocation(WorkflowExpression<double> lat, WorkflowExpression<double> lng, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> offset = null, WorkflowExpression<bool> ada = null, WorkflowExpression<bool> unisex = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(lng, nameof(lng), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(ada, nameof(ada), required: false);
            WorkflowExpression.Validate(unisex, nameof(unisex), required: false);
            return new DeferredBodyAction<RestroomsByLocationResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms/by_location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(unisex);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(lng);
                return new ApiConnectionAction<RestroomsByLocationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        [WorkflowExpressionFactory(nameof(__BuildRestroomsSearch))]
        public IBodyWorkflowAction<RestroomsSearchResponseItem[]> RestroomsSearch([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RestroomsSearchResponseItem[]> __BuildRestroomsSearch(WorkflowExpression<string> query, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> offset = null, WorkflowExpression<bool> ada = null, WorkflowExpression<bool> unisex = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(ada, nameof(ada), required: false);
            WorkflowExpression.Validate(unisex, nameof(unisex), required: false);
            return new DeferredBodyAction<RestroomsSearchResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(unisex);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                return new ApiConnectionAction<RestroomsSearchResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        [WorkflowExpressionFactory(nameof(__BuildRestrooms))]
        public IBodyWorkflowAction<RestroomsResponseItem[]> Restrooms([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RestroomsResponseItem[]> __BuildRestrooms(WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> offset = null, WorkflowExpression<bool> ada = null, WorkflowExpression<bool> unisex = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(ada, nameof(ada), required: false);
            WorkflowExpression.Validate(unisex, nameof(unisex), required: false);
            return new DeferredBodyAction<RestroomsResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(unisex);
                return new ApiConnectionAction<RestroomsResponseItem[]>(callPayload);
            });
        }
    }

    public class RefugerestroomsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class RestroomsByDateResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("accessible")]
        public bool Accessible { get; set; }

        [JsonProperty("unisex")]
        public bool Unisex { get; set; }

        [JsonProperty("directions")]
        public string Directions { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("downvote")]
        public int Downvote { get; set; }

        [JsonProperty("upvote")]
        public int Upvote { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("changing_table")]
        public bool ChangingTable { get; set; }

        [JsonProperty("edit_id")]
        public int EditId { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }
    }

    public class RestroomsByLocationResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("accessible")]
        public bool Accessible { get; set; }

        [JsonProperty("unisex")]
        public bool Unisex { get; set; }

        [JsonProperty("directions")]
        public string Directions { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("downvote")]
        public int Downvote { get; set; }

        [JsonProperty("upvote")]
        public int Upvote { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("changing_table")]
        public bool ChangingTable { get; set; }

        [JsonProperty("edit_id")]
        public int EditId { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("bearing")]
        public string Bearing { get; set; }
    }

    public class RestroomsSearchResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("accessible")]
        public bool Accessible { get; set; }

        [JsonProperty("unisex")]
        public bool Unisex { get; set; }

        [JsonProperty("directions")]
        public string Directions { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("downvote")]
        public int Downvote { get; set; }

        [JsonProperty("upvote")]
        public int Upvote { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("changing_table")]
        public bool ChangingTable { get; set; }

        [JsonProperty("edit_id")]
        public int EditId { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }
    }

    public class RestroomsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("accessible")]
        public bool Accessible { get; set; }

        [JsonProperty("unisex")]
        public bool Unisex { get; set; }

        [JsonProperty("directions")]
        public string Directions { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("downvote")]
        public int Downvote { get; set; }

        [JsonProperty("upvote")]
        public int Upvote { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("changing_table")]
        public bool ChangingTable { get; set; }

        [JsonProperty("edit_id")]
        public int EditId { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Refugerestroomsip;

    public partial class WorkflowManagedActions
    {
        public RefugerestroomsipActions Refugerestroomsip(string connectionId) => new RefugerestroomsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RefugerestroomsipTriggers Refugerestroomsip(string connectionId) => new RefugerestroomsipTriggers(connectionId);
    }
}