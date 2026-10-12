//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unsplaship
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UnsplashipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildUserGet))]
        public IBodyWorkflowAction<Users> UserGet([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> w = null, [WorkflowExpression] Func<int> h = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Users> __BuildUserGet(WorkflowExpression<string> username, WorkflowExpression<int> w = null, WorkflowExpression<int> h = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(w, nameof(w), required: false);
            WorkflowExpression.Validate(h, nameof(h), required: false);
            return new DeferredBodyAction<Users>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (w != null)
                    callPayload.Queries["w"] = ExpressionConverter.Convert(w);
                if (h != null)
                    callPayload.Queries["h"] = ExpressionConverter.Convert(h);
                return new ApiConnectionAction<Users>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildUserGetPhotos))]
        public IBodyWorkflowAction<Photos[]> UserGetPhotos([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Photos[]> __BuildUserGetPhotos(WorkflowExpression<string> username, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<string> orderBy = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/photos", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
                return new ApiConnectionAction<Photos[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildUserGetLiked))]
        public IBodyWorkflowAction<Photos[]> UserGetLiked([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Photos[]> __BuildUserGetLiked(WorkflowExpression<string> username, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<string> orderBy = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/likes", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
                return new ApiConnectionAction<Photos[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildUserGetCollections))]
        public IBodyWorkflowAction<Collections[]> UserGetCollections([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Collections[]> __BuildUserGetCollections(WorkflowExpression<string> username, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Collections[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}/collections", ExpressionConverter.ConvertWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<Collections[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildPhotoGetPage))]
        public IBodyWorkflowAction<Photos[]> PhotoGetPage([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Photos[]> __BuildPhotoGetPage(WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<string> orderBy = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = "/photos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
                return new ApiConnectionAction<Photos[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildPhotoSearch))]
        public IBodyWorkflowAction<Photos[]> PhotoSearch([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> category)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Photos[]> __BuildPhotoSearch(WorkflowExpression<string> query, WorkflowExpression<string> category)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(category, nameof(category), required: true);
            return new DeferredBodyAction<Photos[]>(() =>
            {
                var apiCallPath = "/photos/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                return new ApiConnectionAction<Photos[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildPhotoGet))]
        public IBodyWorkflowAction<Photo> PhotoGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Photo> __BuildPhotoGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<Photo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/photos/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Photo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        [WorkflowExpressionFactory(nameof(__BuildPhotoGetRandom))]
        public IBodyWorkflowAction<Photo> PhotoGetRandom([WorkflowExpression] Func<string> collections = null, [WorkflowExpression] Func<string> topics = null, [WorkflowExpression] Func<string> username = null, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<orientationInput> orientation = null, [WorkflowExpression] Func<contentFilterInput> contentFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Photo> __BuildPhotoGetRandom(WorkflowExpression<string> collections = null, WorkflowExpression<string> topics = null, WorkflowExpression<string> username = null, WorkflowExpression<string> query = null, WorkflowExpression<orientationInput> orientation = null, WorkflowExpression<contentFilterInput> contentFilter = null)
        {
            WorkflowExpression.Validate(collections, nameof(collections), required: false);
            WorkflowExpression.Validate(topics, nameof(topics), required: false);
            WorkflowExpression.Validate(username, nameof(username), required: false);
            WorkflowExpression.Validate(query, nameof(query), required: false);
            WorkflowExpression.Validate(orientation, nameof(orientation), required: false);
            WorkflowExpression.Validate(contentFilter, nameof(contentFilter), required: false);
            return new DeferredBodyAction<Photo>(() =>
            {
                var apiCallPath = "/photos/random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (collections != null)
                    callPayload.Queries["collections"] = ExpressionConverter.Convert(collections);
                if (topics != null)
                    callPayload.Queries["topics"] = ExpressionConverter.Convert(topics);
                if (username != null)
                    callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                if (query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (orientation != null)
                    callPayload.Queries["orientation"] = ExpressionConverter.Convert(orientation);
                callPayload.Queries["content_filter"] = Convert.ToString("low");
                if (contentFilter != null)
                    callPayload.Queries["content_filter"] = ExpressionConverter.Convert(contentFilter);
                return new ApiConnectionAction<Photo>(callPayload);
            });
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