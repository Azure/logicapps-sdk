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
        public IBodyWorkflowAction<RestroomsByDateResponseItem[]> RestroomsByDate([WorkflowExpression] Func<int> day, [WorkflowExpression] Func<int> month, [WorkflowExpression] Func<int> year, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null, [WorkflowExpression] Func<bool> updated = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/restrooms/by_date";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = SourceExpressionConverter.ConvertO(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = SourceExpressionConverter.ConvertO(unisex);
                if (updated != null)
                    callPayload.Queries["updated"] = SourceExpressionConverter.ConvertO(updated);
                callPayload.Queries["day"] = SourceExpressionConverter.ConvertO(day);
                callPayload.Queries["month"] = SourceExpressionConverter.ConvertO(month);
                callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                return callPayload;
            }

            return new ApiConnectionAction<RestroomsByDateResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsByLocationResponseItem[]> RestroomsByLocation([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> lng, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/restrooms/by_location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = SourceExpressionConverter.ConvertO(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = SourceExpressionConverter.ConvertO(unisex);
                callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                callPayload.Queries["lng"] = SourceExpressionConverter.ConvertO(lng);
                return callPayload;
            }

            return new ApiConnectionAction<RestroomsByLocationResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsSearchResponseItem[]> RestroomsSearch([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/restrooms/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = SourceExpressionConverter.ConvertO(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = SourceExpressionConverter.ConvertO(unisex);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<RestroomsSearchResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "refugerestroomsip")]
        public IBodyWorkflowAction<RestroomsResponseItem[]> Restrooms([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> ada = null, [WorkflowExpression] Func<bool> unisex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/restrooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (ada != null)
                    callPayload.Queries["ada"] = SourceExpressionConverter.ConvertO(ada);
                if (unisex != null)
                    callPayload.Queries["unisex"] = SourceExpressionConverter.ConvertO(unisex);
                return callPayload;
            }

            return new ApiConnectionAction<RestroomsResponseItem[]>(BuildSourceInput);
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