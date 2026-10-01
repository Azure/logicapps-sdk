//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unsplaship
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UnsplashipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Users> UserGet([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> w = null, [WorkflowExpression] Func<int> h = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (w != null)
                    callPayload.Queries["w"] = SourceExpressionConverter.ConvertO(w);
                if (h != null)
                    callPayload.Queries["h"] = SourceExpressionConverter.ConvertO(h);
                return callPayload;
            }

            return new ApiConnectionAction<Users>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> UserGetPhotos([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/photos", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (orderBy != null)
                    callPayload.Queries["order_by"] = SourceExpressionConverter.ConvertO(orderBy);
                return callPayload;
            }

            return new ApiConnectionAction<Photos[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> UserGetLiked([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/likes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (orderBy != null)
                    callPayload.Queries["order_by"] = SourceExpressionConverter.ConvertO(orderBy);
                return callPayload;
            }

            return new ApiConnectionAction<Photos[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Collections[]> UserGetCollections([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}/collections", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(username, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<Collections[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> PhotoGetPage([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/photos";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (orderBy != null)
                    callPayload.Queries["order_by"] = SourceExpressionConverter.ConvertO(orderBy);
                return callPayload;
            }

            return new ApiConnectionAction<Photos[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photos[]> PhotoSearch([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> category)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/photos/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                return callPayload;
            }

            return new ApiConnectionAction<Photos[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photo> PhotoGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/photos/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Photo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unsplaship")]
        public IBodyWorkflowAction<Photo> PhotoGetRandom([WorkflowExpression] Func<string> collections = null, [WorkflowExpression] Func<string> topics = null, [WorkflowExpression] Func<string> username = null, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<orientationInput> orientation = null, [WorkflowExpression] Func<contentFilterInput> contentFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/photos/random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (collections != null)
                    callPayload.Queries["collections"] = SourceExpressionConverter.ConvertO(collections);
                if (topics != null)
                    callPayload.Queries["topics"] = SourceExpressionConverter.ConvertO(topics);
                if (username != null)
                    callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (orientation != null)
                    callPayload.Queries["orientation"] = SourceExpressionConverter.Convert(orientation);
                callPayload.Queries["content_filter"] = Convert.ToString("low");
                if (contentFilter != null)
                    callPayload.Queries["content_filter"] = SourceExpressionConverter.Convert(contentFilter);
                return callPayload;
            }

            return new ApiConnectionAction<Photo>(BuildSourceInput);
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

    public enum orientationInput
    {
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "squarish")]
        Squarish
    }

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