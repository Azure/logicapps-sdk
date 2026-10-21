//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unsplaship
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UnsplashipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Users> UserGet(Expression<Func<string>> username, Expression<Func<int>> w = null, Expression<Func<int>> h = null)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_w = WorkflowExpression.Compile(w, nameof(w), required: false);
            var __workflow_h = WorkflowExpression.Compile(h, nameof(h), required: false);
            return new DeferredBodyAction<Users>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_w != null)
                    callPayload.Queries["w"] = ExpressionConverter.Convert(__workflow_w);
                if (__workflow_h != null)
                    callPayload.Queries["h"] = ExpressionConverter.Convert(__workflow_h);
                return new ApiConnectionAction<Users>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> UserGetPhotos(Expression<Func<string>> username, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/photos", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                return new ApiConnectionAction<Photos[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> UserGetLiked(Expression<Func<string>> username, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/likes", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                return new ApiConnectionAction<Photos[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Collections[]> UserGetCollections(Expression<Func<string>> username, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Collections[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/collections", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<Collections[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> PhotoGetPage(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = "/photos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                return new ApiConnectionAction<Photos[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> PhotoSearch(Expression<Func<string>> query, Expression<Func<string>> category)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = "/photos/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                return new ApiConnectionAction<Photos[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photo> PhotoGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Photo>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/photos/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Photo>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photo> PhotoGetRandom(Expression<Func<string>> collections = null, Expression<Func<string>> topics = null, Expression<Func<string>> username = null, Expression<Func<string>> query = null, Expression<Func<orientationInput>> orientation = null, Expression<Func<contentFilterInput>> contentFilter = null)
        {
            var __workflow_collections = WorkflowExpression.Compile(collections, nameof(collections), required: false);
            var __workflow_topics = WorkflowExpression.Compile(topics, nameof(topics), required: false);
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_orientation = WorkflowExpression.Compile(orientation, nameof(orientation), required: false);
            var __workflow_contentFilter = WorkflowExpression.Compile(contentFilter, nameof(contentFilter), required: false);
            return new DeferredBodyAction<Photo>(() =>
            {
                var apiCallPath = "/photos/random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_collections != null)
                    callPayload.Queries["collections"] = ExpressionConverter.Convert(__workflow_collections);
                if (__workflow_topics != null)
                    callPayload.Queries["topics"] = ExpressionConverter.Convert(__workflow_topics);
                if (__workflow_username != null)
                    callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_orientation != null)
                    callPayload.Queries["orientation"] = ExpressionConverter.Convert(__workflow_orientation);
                callPayload.Queries["content_filter"] = Convert.ToString("low");
                if (__workflow_contentFilter != null)
                    callPayload.Queries["content_filter"] = ExpressionConverter.Convert(__workflow_contentFilter);
                return new ApiConnectionAction<Photo>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class UnsplashipTriggers([ConnectionName] string connectionId)
    {
    }

    public class Users
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("portfolio_url")]
        public string PortfolioUrl { get; set; }

        [JsonProperty("downloads")]
        public int Downloads { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage ProfileImage { get; set; }

        [JsonProperty("links")]
        public UserLinks Links { get; set; }
    }

    public class ProfileImage
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }
    }

    public class UserLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }

        [JsonProperty("likes")]
        public string Likes { get; set; }
    }

    public class Photos
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("liked_by_user")]
        public bool LikedByUser { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("urls")]
        public PhotoURLs Urls { get; set; }

        [JsonProperty("links")]
        public PhotoLinks Links { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_image")]
        public ProfileImage ProfileImage { get; set; }

        [JsonProperty("links")]
        public UserLinks Links { get; set; }
    }

    public class PhotoURLs
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("regular")]
        public string Regular { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }

    public class PhotoLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("photo_count")]
        public int PhotoCount { get; set; }

        [JsonProperty("links")]
        public CategoryLinks Links { get; set; }
    }

    public class CategoryLinks
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("photos")]
        public string Photos { get; set; }
    }

    public class Collections
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("curated")]
        public bool Curated { get; set; }

        [JsonProperty("cover_photo")]
        public Photo CoverPhoto { get; set; }

        [JsonProperty("user")]
        public Users User { get; set; }

        [JsonProperty("links")]
        public UserLinks Links { get; set; }
    }

    public class Photo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("liked_by_user")]
        public bool LikedByUser { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("urls")]
        public PhotoURLs Urls { get; set; }

        [JsonProperty("links")]
        public PhotoLinks Links { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("exif")]
        public Exif Exif { get; set; }
    }

    public class Location
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class Exif
    {
        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("exposure_time")]
        public double ExposureTime { get; set; }

        [JsonProperty("aperture")]
        public double Aperture { get; set; }

        [JsonProperty("focal_length")]
        public int FocalLength { get; set; }

        [JsonProperty("iso")]
        public int Iso { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orientationInput
    {
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "squarish")]
        Squarish
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum contentFilterInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "high")]
        High
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Unsplaship;

    public partial class WorkflowManagedActions
    {
        public UnsplashipActions Unsplaship(string connectionId) => new UnsplashipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UnsplashipTriggers Unsplaship(string connectionId) => new UnsplashipTriggers(connectionId);
    }
}
