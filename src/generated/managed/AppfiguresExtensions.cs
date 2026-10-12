//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appfigures
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppfiguresActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appfigures")]
        public IBodyWorkflowAction<MyProductsResponse> GetMyProducts()
        {
            var apiCallPath = "/products/mine";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MyProductsResponse>(callPayload);
        }
    }

    public class AppfiguresTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Event[]> OnNewEvent(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/event_trigger/events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<Event[]>(callPayload, recurrence: recurrence);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewReview))]
        public IBodyWorkflowTrigger<ReviewInfo[]> OnNewReview([WorkflowExpression] Func<string> products = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ReviewInfo[]> __BuildOnNewReview(WorkflowExpression<string> products = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(products, nameof(products), required: false);
            return new DeferredBodyTrigger<ReviewInfo[]>(() =>
            {
                var apiCallPath = "/reviews_trigger/reviews";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (products != null)
                    callPayload.Queries["products"] = ExpressionConverter.Convert(products);
                return new ApiConnectionTrigger<ReviewInfo[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewRating))]
        public IBodyWorkflowTrigger<Rating[]> OnNewRating([WorkflowExpression] Func<string> products = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<Rating[]> __BuildOnNewRating(WorkflowExpression<string> products = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(products, nameof(products), required: false);
            return new DeferredBodyTrigger<Rating[]>(() =>
            {
                var apiCallPath = "/ratings_trigger/ratings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (products != null)
                    callPayload.Queries["products"] = ExpressionConverter.Convert(products);
                return new ApiConnectionTrigger<Rating[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class MyProductsResponse
    {
        [JsonProperty("products")]
        public MyProduct[] Products { get; set; }
    }

    public class MyProduct
    {
        [JsonProperty("id")]
        public int ProductId { get; set; }

        [JsonProperty("name")]
        public string ProductName { get; set; }

        [JsonProperty("developer")]
        public string Developer { get; set; }

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("updated_date")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class Event
    {
        [JsonProperty("id")]
        public string EventId { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }
    }

    public class ReviewInfo
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("review")]
        public string Review { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("original_review")]
        public string OriginalReview { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("iso")]
        public string CountryCode { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("product")]
        public int ProductId { get; set; }

        [JsonProperty("id")]
        public string ReviewId { get; set; }
    }

    public class Rating
    {
        [JsonProperty("product")]
        public int ProductId { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("oneStar")]
        public int OneStarReviews { get; set; }

        [JsonProperty("twoStar")]
        public int TwoStarReviews { get; set; }

        [JsonProperty("threeStar")]
        public int ThreeStarReviews { get; set; }

        [JsonProperty("fourStar")]
        public int FourStarReviews { get; set; }

        [JsonProperty("fiveStar")]
        public int FiveStarReviews { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Appfigures;

    public partial class WorkflowManagedActions
    {
        public AppfiguresActions Appfigures(string connectionId) => new AppfiguresActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AppfiguresTriggers Appfigures(string connectionId) => new AppfiguresTriggers(connectionId);
    }
}