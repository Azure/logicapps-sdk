//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yelpip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YelpipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<BusinessSearchResponse> BusinessSearch([WorkflowExpression] Func<string> term, [WorkflowExpression] Func<string> location, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longtitude = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<sortByInput> sortBy = null, [WorkflowExpression] Func<bool> openNow = null)
        {
            SourceExpression.Validate(term, nameof(term), required: true);
            SourceExpression.Validate(location, nameof(location), required: true);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longtitude, nameof(longtitude), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            SourceExpression.Validate(categories, nameof(categories), required: false);
            SourceExpression.Validate(locale, nameof(locale), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(sortBy, nameof(sortBy), required: false);
            SourceExpression.Validate(openNow, nameof(openNow), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/businesses/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["term"] = SourceExpressionConverter.ConvertO(term);
                callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longtitude != null)
                    callPayload.Queries["longtitude"] = SourceExpressionConverter.ConvertO(longtitude);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                if (categories != null)
                    callPayload.Queries["categories"] = SourceExpressionConverter.ConvertO(categories);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = SourceExpressionConverter.Convert(sortBy);
                if (openNow != null)
                    callPayload.Queries["open_now"] = SourceExpressionConverter.ConvertO(openNow);
                return callPayload;
            }

            return new ApiConnectionAction<BusinessSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<PhoneSearchResponse> PhoneSearch([WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> locale = null)
        {
            SourceExpression.Validate(phone, nameof(phone), required: true);
            SourceExpression.Validate(locale, nameof(locale), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/businesses/search/phone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                return callPayload;
            }

            return new ApiConnectionAction<PhoneSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<BusinessDetailsResponse> BusinessDetails([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(locale, nameof(locale), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/businesses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                return callPayload;
            }

            return new ApiConnectionAction<BusinessDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<BusinessMatchResponseItem[]> BusinessMatch([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> address1, [WorkflowExpression] Func<string> city, [WorkflowExpression] Func<string> state, [WorkflowExpression] Func<string> country, [WorkflowExpression] Func<string> address2 = null, [WorkflowExpression] Func<string> address3 = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> zipCode = null, [WorkflowExpression] Func<string> yelpBusinessId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<matchThresholdInput> matchThreshold = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(address1, nameof(address1), required: true);
            SourceExpression.Validate(city, nameof(city), required: true);
            SourceExpression.Validate(state, nameof(state), required: true);
            SourceExpression.Validate(country, nameof(country), required: true);
            SourceExpression.Validate(address2, nameof(address2), required: false);
            SourceExpression.Validate(address3, nameof(address3), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(phone, nameof(phone), required: false);
            SourceExpression.Validate(zipCode, nameof(zipCode), required: false);
            SourceExpression.Validate(yelpBusinessId, nameof(yelpBusinessId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(matchThreshold, nameof(matchThreshold), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/businesses/matches";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["address1"] = SourceExpressionConverter.ConvertO(address1);
                if (address2 != null)
                    callPayload.Queries["address2"] = SourceExpressionConverter.ConvertO(address2);
                if (address3 != null)
                    callPayload.Queries["address3"] = SourceExpressionConverter.ConvertO(address3);
                callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (phone != null)
                    callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (zipCode != null)
                    callPayload.Queries["zip_code"] = SourceExpressionConverter.ConvertO(zipCode);
                if (yelpBusinessId != null)
                    callPayload.Queries["yelp_business_id"] = SourceExpressionConverter.ConvertO(yelpBusinessId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (matchThreshold != null)
                    callPayload.Queries["match_threshold"] = SourceExpressionConverter.Convert(matchThreshold);
                return callPayload;
            }

            return new ApiConnectionAction<BusinessMatchResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<ReviewsResponse> Reviews([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> locale = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(locale, nameof(locale), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/businesses/{0}/reviews", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                return callPayload;
            }

            return new ApiConnectionAction<ReviewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yelpip")]
        public IBodyWorkflowAction<AutocompleteResponse> Autocomplete([WorkflowExpression] Func<string> text, [WorkflowExpression] Func<double> latitude, [WorkflowExpression] Func<double> longitude, [WorkflowExpression] Func<string> locale = null)
        {
            SourceExpression.Validate(text, nameof(text), required: true);
            SourceExpression.Validate(latitude, nameof(latitude), required: true);
            SourceExpression.Validate(longitude, nameof(longitude), required: true);
            SourceExpression.Validate(locale, nameof(locale), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/autocomplete";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                return callPayload;
            }

            return new ApiConnectionAction<AutocompleteResponse>(BuildSourceInput);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Yelpip;

    public partial class WorkflowManagedActions
    {
        public YelpipActions Yelpip(string connectionId) => new YelpipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YelpipTriggers Yelpip(string connectionId) => new YelpipTriggers(connectionId);
    }
}