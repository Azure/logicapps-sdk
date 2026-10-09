//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Spotifyip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpotifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spotifyip")]
        public IBodyWorkflowAction<GetSavedAlbumsResponse> GetSavedAlbums()
        {
            var apiCallPath = "/v1/me/albums";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSavedAlbumsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spotifyip")]
        public IBodyWorkflowAction<PrivateUser> GetUserProfile()
        {
            var apiCallPath = "/v1/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrivateUser>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spotifyip")]
        public IBodyWorkflowAction<GetTopArtistsResponse> GetTopArtists()
        {
            var apiCallPath = "/v1/me/top/artists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTopArtistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spotifyip")]
        [WorkflowExpressionFactory(nameof(__BuildGetNewReleases))]
        public IBodyWorkflowAction<GetNewReleasesResponse> GetNewReleases([WorkflowExpression] Func<string> country = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetNewReleasesResponse> __BuildGetNewReleases(WorkflowExpression<string> country = null)
        {
            WorkflowExpression.Validate(country, nameof(country), required: false);
            return new DeferredBodyAction<GetNewReleasesResponse>(() =>
            {
                var apiCallPath = "/v1/browse/new-releases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                return new ApiConnectionAction<GetNewReleasesResponse>(callPayload);
            });
        }
    }

    public class SpotifyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSavedAlbumsResponse
    {
        [JsonProperty("items")]
        public Album[] Albums { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Album
    {
        [JsonProperty("album_type")]
        public string AlbumType { get; set; }

        [JsonProperty("artists")]
        public Artist[] Artists { get; set; }

        [JsonProperty("available_markets")]
        public string[] AvailableMarkets { get; set; }

        [JsonProperty("copyrights")]
        public Copyright[] Copyrights { get; set; }

        [JsonProperty("external_ids")]
        public ExternalId ExternalIds { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        [JsonProperty("genres")]
        public JToken[] Genres { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        [JsonProperty("restrictions")]
        public JToken Restrictions { get; set; }

        [JsonProperty("total_tracks")]
        public int TotalTracks { get; set; }

        [JsonProperty("tracks")]
        public SimplifiedTrack[] Tracks { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }

    public class Artist
    {
        [JsonProperty("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }

    public class ExternalUrl
    {
        [JsonProperty("spotify")]
        public string Spotify { get; set; }
    }

    public class Copyright
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ExternalId
    {
        [JsonProperty("ean")]
        public string EAN { get; set; }

        [JsonProperty("isrc")]
        public string ISRC { get; set; }

        [JsonProperty("upc")]
        public string UPC { get; set; }
    }

    public class Image
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class SimplifiedTrack
    {
        [JsonProperty("artists")]
        public SimplifiedArtist[] Artists { get; set; }

        [JsonProperty("available_markets")]
        public string[] AvailableMarkets { get; set; }

        [JsonProperty("disc_number")]
        public int DiscNumber { get; set; }

        [JsonProperty("duration_ms")]
        public int DurationMs { get; set; }

        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("is_local")]
        public bool IsLocal { get; set; }

        [JsonProperty("is_playable")]
        public bool IsPlayable { get; set; }

        [JsonProperty("linked_from")]
        public JToken LinkedFrom { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewURL { get; set; }

        [JsonProperty("restrictions")]
        public TrackRestriction Restrictions { get; set; }

        [JsonProperty("track_number")]
        public int TrackNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }

    public class SimplifiedArtist
    {
        [JsonProperty("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TrackRestriction
    {
        [EnumMember(Value = "market")]
        Market,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "explicit")]
        Explicit
    }

    public class PrivateUser
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("explicit_content")]
        public ExplicitContentSettings ExplicitContent { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        [JsonProperty("followers")]
        public Followers Followers { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public Image Images { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }

    public class ExplicitContentSettings
    {
        [JsonProperty("filter_enabled")]
        public bool FilterEnabled { get; set; }

        [JsonProperty("filter_locked")]
        public bool FilterLocked { get; set; }
    }

    public class Followers
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetTopArtistsResponse
    {
        [JsonProperty("items")]
        public Artist[] Items { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetNewReleasesResponse
    {
        [JsonProperty("albums")]
        public GetNewReleasesResponseAlbumsType Albums { get; set; }
    }

    public class GetNewReleasesResponseAlbumsType
    {
        [JsonProperty("items")]
        public SimplifiedAlbum[] Albums { get; set; }
    }

    public class SimplifiedAlbum
    {
        [JsonProperty("album_group")]
        public string AlbumGroup { get; set; }

        [JsonProperty("album_type")]
        public string AlbumType { get; set; }

        [JsonProperty("artists")]
        public SimplifiedArtist[] Artists { get; set; }

        [JsonProperty("available_markets")]
        public string[] AvailableMarkets { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Spotifyip;

    public partial class WorkflowManagedActions
    {
        public SpotifyipActions Spotifyip(string connectionId) => new SpotifyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SpotifyipTriggers Spotifyip(string connectionId) => new SpotifyipTriggers(connectionId);
    }
}