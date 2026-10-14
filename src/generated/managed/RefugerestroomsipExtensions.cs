//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Refugerestroomsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class RefugerestroomsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsByDateResponseItem[]> RestroomsByDate(Expression<Func<int>> day, Expression<Func<int>> month, Expression<Func<int>> year, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null, Expression<Func<bool>> updated = null)
        {
            var __workflow_day = day == null ? null : WorkflowExpression.Compile(day);
            WorkflowExpression.Validate(__workflow_day, nameof(day), required: true);
            var __workflow_month = month == null ? null : WorkflowExpression.Compile(month);
            WorkflowExpression.Validate(__workflow_month, nameof(month), required: true);
            var __workflow_year = year == null ? null : WorkflowExpression.Compile(year);
            WorkflowExpression.Validate(__workflow_year, nameof(year), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_ada = ada == null ? null : WorkflowExpression.Compile(ada);
            WorkflowExpression.Validate(__workflow_ada, nameof(ada), required: false);
            var __workflow_unisex = unisex == null ? null : WorkflowExpression.Compile(unisex);
            WorkflowExpression.Validate(__workflow_unisex, nameof(unisex), required: false);
            var __workflow_updated = updated == null ? null : WorkflowExpression.Compile(updated);
            WorkflowExpression.Validate(__workflow_updated, nameof(updated), required: false);
            return new DeferredBodyAction<RestroomsByDateResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms/by_date";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(__workflow_ada);
                if (__workflow_unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(__workflow_unisex);
                if (__workflow_updated != null)
                    callPayload.Queries["updated"] = ExpressionConverter.Convert(__workflow_updated);
                callPayload.Queries["day"] = ExpressionConverter.Convert(__workflow_day);
                callPayload.Queries["month"] = ExpressionConverter.Convert(__workflow_month);
                callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                return new ApiConnectionAction<RestroomsByDateResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsByLocationResponseItem[]> RestroomsByLocation(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null)
        {
            var __workflow_lat = lat == null ? null : WorkflowExpression.Compile(lat);
            WorkflowExpression.Validate(__workflow_lat, nameof(lat), required: true);
            var __workflow_lng = lng == null ? null : WorkflowExpression.Compile(lng);
            WorkflowExpression.Validate(__workflow_lng, nameof(lng), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_ada = ada == null ? null : WorkflowExpression.Compile(ada);
            WorkflowExpression.Validate(__workflow_ada, nameof(ada), required: false);
            var __workflow_unisex = unisex == null ? null : WorkflowExpression.Compile(unisex);
            WorkflowExpression.Validate(__workflow_unisex, nameof(unisex), required: false);
            return new DeferredBodyAction<RestroomsByLocationResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms/by_location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(__workflow_ada);
                if (__workflow_unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(__workflow_unisex);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                callPayload.Queries["lng"] = ExpressionConverter.Convert(__workflow_lng);
                return new ApiConnectionAction<RestroomsByLocationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsSearchResponseItem[]> RestroomsSearch(Expression<Func<string>> query, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null)
        {
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_ada = ada == null ? null : WorkflowExpression.Compile(ada);
            WorkflowExpression.Validate(__workflow_ada, nameof(ada), required: false);
            var __workflow_unisex = unisex == null ? null : WorkflowExpression.Compile(unisex);
            WorkflowExpression.Validate(__workflow_unisex, nameof(unisex), required: false);
            return new DeferredBodyAction<RestroomsSearchResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(__workflow_ada);
                if (__workflow_unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(__workflow_unisex);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<RestroomsSearchResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsResponseItem[]> Restrooms(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_ada = ada == null ? null : WorkflowExpression.Compile(ada);
            WorkflowExpression.Validate(__workflow_ada, nameof(ada), required: false);
            var __workflow_unisex = unisex == null ? null : WorkflowExpression.Compile(unisex);
            WorkflowExpression.Validate(__workflow_unisex, nameof(unisex), required: false);
            return new DeferredBodyAction<RestroomsResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/restrooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_ada != null)
                    callPayload.Queries["ada"] = ExpressionConverter.Convert(__workflow_ada);
                if (__workflow_unisex != null)
                    callPayload.Queries["unisex"] = ExpressionConverter.Convert(__workflow_unisex);
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
