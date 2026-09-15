//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Refugerestroomsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RefugerestroomsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsByDateResponseItem[]> RestroomsByDate(Expression<Func<int>> day, Expression<Func<int>> month, Expression<Func<int>> year, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null, Expression<Func<bool>> updated = null)
        {
            var apiCallPath = "/v1/restrooms/by_date";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (ada != null)
                callPayload.Queries["ada"] = CSharpExpressionConverter.ConvertO(ada);
            if (unisex != null)
                callPayload.Queries["unisex"] = CSharpExpressionConverter.ConvertO(unisex);
            if (updated != null)
                callPayload.Queries["updated"] = CSharpExpressionConverter.ConvertO(updated);
            callPayload.Queries["day"] = CSharpExpressionConverter.ConvertO(day);
            callPayload.Queries["month"] = CSharpExpressionConverter.ConvertO(month);
            callPayload.Queries["year"] = CSharpExpressionConverter.ConvertO(year);
            return new ApiConnectionAction<RestroomsByDateResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsByLocationResponseItem[]> RestroomsByLocation(Expression<Func<double>> lat, Expression<Func<double>> lng, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null)
        {
            var apiCallPath = "/v1/restrooms/by_location";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (ada != null)
                callPayload.Queries["ada"] = CSharpExpressionConverter.ConvertO(ada);
            if (unisex != null)
                callPayload.Queries["unisex"] = CSharpExpressionConverter.ConvertO(unisex);
            callPayload.Queries["lat"] = CSharpExpressionConverter.ConvertO(lat);
            callPayload.Queries["lng"] = CSharpExpressionConverter.ConvertO(lng);
            return new ApiConnectionAction<RestroomsByLocationResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsSearchResponseItem[]> RestroomsSearch(Expression<Func<string>> query, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null)
        {
            var apiCallPath = "/v1/restrooms/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (ada != null)
                callPayload.Queries["ada"] = CSharpExpressionConverter.ConvertO(ada);
            if (unisex != null)
                callPayload.Queries["unisex"] = CSharpExpressionConverter.ConvertO(unisex);
            callPayload.Queries["query"] = CSharpExpressionConverter.ConvertO(query);
            return new ApiConnectionAction<RestroomsSearchResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsResponseItem[]> Restrooms(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<int>> offset = null, Expression<Func<bool>> ada = null, Expression<Func<bool>> unisex = null)
        {
            var apiCallPath = "/v1/restrooms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (ada != null)
                callPayload.Queries["ada"] = CSharpExpressionConverter.ConvertO(ada);
            if (unisex != null)
                callPayload.Queries["unisex"] = CSharpExpressionConverter.ConvertO(unisex);
            return new ApiConnectionAction<RestroomsResponseItem[]>(callPayload);
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