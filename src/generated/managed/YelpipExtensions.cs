//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Yelpip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YelpipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<BusinessSearchResponse> BusinessSearch(Expression<Func<string>> term, Expression<Func<string>> location, Expression<Func<double>> latitude = null, Expression<Func<double>> longtitude = null, Expression<Func<int>> radius = null, Expression<Func<string>> categories = null, Expression<Func<string>> locale = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<sortByInput>> sortBy = null, Expression<Func<bool>> openNow = null)
        {
            var apiCallPath = "/v3/businesses/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["term"] = ExpressionConverter.Convert(term);
            callPayload.Queries["location"] = ExpressionConverter.Convert(location);
            if (latitude != null)
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            if (longtitude != null)
                callPayload.Queries["longtitude"] = ExpressionConverter.Convert(longtitude);
            if (radius != null)
                callPayload.Queries["radius"] = ExpressionConverter.Convert(radius);
            if (categories != null)
                callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (sortBy != null)
                callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
            if (openNow != null)
                callPayload.Queries["open_now"] = ExpressionConverter.Convert(openNow);
            return new ApiConnectionAction<BusinessSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<PhoneSearchResponse> PhoneSearch(Expression<Func<string>> phone, Expression<Func<string>> locale = null)
        {
            var apiCallPath = "/v3/businesses/search/phone";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            return new ApiConnectionAction<PhoneSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<BusinessDetailsResponse> BusinessDetails(Expression<Func<string>> id, Expression<Func<string>> locale = null)
        {
            var apiCallPath = String.Format("/v3/businesses/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            return new ApiConnectionAction<BusinessDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<BusinessMatchResponseItem[]> BusinessMatch(Expression<Func<string>> name, Expression<Func<string>> address1, Expression<Func<string>> city, Expression<Func<string>> state, Expression<Func<string>> country, Expression<Func<string>> address2 = null, Expression<Func<string>> address3 = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<string>> phone = null, Expression<Func<string>> zipCode = null, Expression<Func<string>> yelpBusinessId = null, Expression<Func<int>> limit = null, Expression<Func<matchThresholdInput>> matchThreshold = null)
        {
            var apiCallPath = "/v3/businesses/matches";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["address1"] = ExpressionConverter.Convert(address1);
            if (address2 != null)
                callPayload.Queries["address2"] = ExpressionConverter.Convert(address2);
            if (address3 != null)
                callPayload.Queries["address3"] = ExpressionConverter.Convert(address3);
            callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            if (latitude != null)
                callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            if (phone != null)
                callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            if (zipCode != null)
                callPayload.Queries["zip_code"] = ExpressionConverter.Convert(zipCode);
            if (yelpBusinessId != null)
                callPayload.Queries["yelp_business_id"] = ExpressionConverter.Convert(yelpBusinessId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (matchThreshold != null)
                callPayload.Queries["match_threshold"] = ExpressionConverter.Convert(matchThreshold);
            return new ApiConnectionAction<BusinessMatchResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<ReviewsResponse> Reviews(Expression<Func<string>> id, Expression<Func<string>> locale = null)
        {
            var apiCallPath = String.Format("/v3/businesses/{0}/reviews", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            return new ApiConnectionAction<ReviewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<AutocompleteResponse> Autocomplete(Expression<Func<string>> text, Expression<Func<double>> latitude, Expression<Func<double>> longitude, Expression<Func<string>> locale = null)
        {
            var apiCallPath = "/v3/autocomplete";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
            callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            return new ApiConnectionAction<AutocompleteResponse>(callPayload);
        }
    }

    public class YelpipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BusinessSearchResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("businesses")]
        public BusinessSearchResponseBusinessesTypeItem[] Businesses { get; set; }

        [JsonProperty("region")]
        public BusinessSearchResponseRegionType Region { get; set; }
    }

    public class BusinessSearchResponseBusinessesTypeItem
    {
        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("categories")]
        public BusinessSearchResponseBusinessesTypeItemCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("review_count")]
        public int ReviewCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("coordinates")]
        public BusinessSearchResponseBusinessesTypeItemCoordinatesType Coordinates { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("location")]
        public BusinessSearchResponseBusinessesTypeItemLocationType Location { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("transactions")]
        public string[] Transactions { get; set; }
    }

    public class BusinessSearchResponseBusinessesTypeItemCategoriesTypeItem
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class BusinessSearchResponseBusinessesTypeItemCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class BusinessSearchResponseBusinessesTypeItemLocationType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }

    public class BusinessSearchResponseRegionType
    {
        [JsonProperty("center")]
        public BusinessSearchResponseRegionTypeCenterType Center { get; set; }
    }

    public class BusinessSearchResponseRegionTypeCenterType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public enum sortByInput
    {
        [EnumMember(Value = "best_match")]
        BestMatch,
        [EnumMember(Value = "rating")]
        Rating,
        [EnumMember(Value = "review_count")]
        ReviewCount,
        [EnumMember(Value = "distance")]
        Distance
    }

    public class PhoneSearchResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("businesses")]
        public PhoneSearchResponseBusinessesTypeItem[] Businesses { get; set; }
    }

    public class PhoneSearchResponseBusinessesTypeItem
    {
        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("categories")]
        public PhoneSearchResponseBusinessesTypeItemCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("review_count")]
        public int ReviewCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("coordinates")]
        public PhoneSearchResponseBusinessesTypeItemCoordinatesType Coordinates { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("location")]
        public PhoneSearchResponseBusinessesTypeItemLocationType Location { get; set; }

        [JsonProperty("transactions")]
        public string[] Transactions { get; set; }
    }

    public class PhoneSearchResponseBusinessesTypeItemCategoriesTypeItem
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class PhoneSearchResponseBusinessesTypeItemCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class PhoneSearchResponseBusinessesTypeItemLocationType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }

    public class BusinessDetailsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("is_claimed")]
        public bool IsClaimed { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("display_phone")]
        public string DisplayPhone { get; set; }

        [JsonProperty("review_count")]
        public int ReviewCount { get; set; }

        [JsonProperty("categories")]
        public BusinessDetailsResponseCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("location")]
        public BusinessDetailsResponseLocationType Location { get; set; }

        [JsonProperty("coordinates")]
        public BusinessDetailsResponseCoordinatesType Coordinates { get; set; }

        [JsonProperty("photos")]
        public string[] Photos { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("hours")]
        public BusinessDetailsResponseHoursTypeItem[] Hours { get; set; }

        [JsonProperty("transactions")]
        public JToken[] Transactions { get; set; }

        [JsonProperty("special_hours")]
        public BusinessDetailsResponseSpecialHoursTypeItem[] SpecialHours { get; set; }
    }

    public class BusinessDetailsResponseCategoriesTypeItem
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class BusinessDetailsResponseLocationType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("display_address")]
        public string[] DisplayAddress { get; set; }

        [JsonProperty("cross_streets")]
        public string CrossStreets { get; set; }
    }

    public class BusinessDetailsResponseCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class BusinessDetailsResponseHoursTypeItem
    {
        [JsonProperty("open")]
        public BusinessDetailsResponseHoursTypeItemOpenTypeItem[] Open { get; set; }

        [JsonProperty("hours_type")]
        public string HoursType { get; set; }

        [JsonProperty("is_open_now")]
        public bool IsOpenNow { get; set; }
    }

    public class BusinessDetailsResponseHoursTypeItemOpenTypeItem
    {
        [JsonProperty("is_overnight")]
        public bool IsOvernight { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class BusinessDetailsResponseSpecialHoursTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("is_closed")]
        public string IsClosed { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("is_overnight")]
        public bool IsOvernight { get; set; }
    }

    public class BusinessMatchResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public BusinessMatchResponseItemLocationType Location { get; set; }

        [JsonProperty("coordinates")]
        public BusinessMatchResponseItemCoordinatesType Coordinates { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }
    }

    public class BusinessMatchResponseItemLocationType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class BusinessMatchResponseItemCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public enum matchThresholdInput
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "strict")]
        Strict
    }

    public class ReviewsResponse
    {
        [JsonProperty("reviews")]
        public ReviewsResponseReviewsTypeItem[] Reviews { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("possible_languages")]
        public string[] PossibleLanguages { get; set; }
    }

    public class ReviewsResponseReviewsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("user")]
        public ReviewsResponseReviewsTypeItemUserType User { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("time_created")]
        public string TimeCreated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ReviewsResponseReviewsTypeItemUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AutocompleteResponse
    {
        [JsonProperty("terms")]
        public AutocompleteResponseTermsTypeItem[] Terms { get; set; }

        [JsonProperty("businesses")]
        public AutocompleteResponseBusinessesTypeItem[] Businesses { get; set; }

        [JsonProperty("categories")]
        public AutocompleteResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class AutocompleteResponseTermsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AutocompleteResponseBusinessesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AutocompleteResponseCategoriesTypeItem
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Yelpip;

    public partial class WorkflowManagedActions
    {
        public YelpipActions Yelpip(string connectionId) => new YelpipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YelpipTriggers Yelpip(string connectionId) => new YelpipTriggers(connectionId);
    }
}