//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instagrambasicdispip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstagrambasicdispipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        [WorkflowExpressionFactory(nameof(__BuildGetMyMedia))]
        public IBodyWorkflowAction<GetMyMediaResponse> GetMyMedia([WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMyMediaResponse> __BuildGetMyMedia(WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<GetMyMediaResponse>(() =>
            {
                var apiCallPath = "/me/media";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("caption,media_type,media_url,permalink,timestamp,username,thumbnail_url");
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<GetMyMediaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        [WorkflowExpressionFactory(nameof(__BuildGetMyDetails))]
        public IBodyWorkflowAction<GetMyDetailsResponse> GetMyDetails([WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMyDetailsResponse> __BuildGetMyDetails(WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<GetMyDetailsResponse>(() =>
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("id,media_count,username,account_type");
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<GetMyDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        [WorkflowExpressionFactory(nameof(__BuildGetMediaDetails))]
        public IBodyWorkflowAction<GetMediaDetailsResponse> GetMediaDetails([WorkflowExpression] Func<string> mediaId, [WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMediaDetailsResponse> __BuildGetMediaDetails(WorkflowExpression<string> mediaId, WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(mediaId, nameof(mediaId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<GetMediaDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(mediaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("caption,media_type,media_url,permalink,timestamp,username,thumbnail_url");
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<GetMediaDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        [WorkflowExpressionFactory(nameof(__BuildRefreshToken))]
        public IBodyWorkflowAction<RefreshTokenResponse> RefreshToken([WorkflowExpression] Func<string> grantType, [WorkflowExpression] Func<string> accessToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefreshTokenResponse> __BuildRefreshToken(WorkflowExpression<string> grantType, WorkflowExpression<string> accessToken)
        {
            WorkflowExpression.Validate(grantType, nameof(grantType), required: true);
            WorkflowExpression.Validate(accessToken, nameof(accessToken), required: true);
            return new DeferredBodyAction<RefreshTokenResponse>(() =>
            {
                var apiCallPath = "/refresh_access_token";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["grant_type"] = ExpressionConverter.Convert(grantType);
                callPayload.Queries["access_token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction<RefreshTokenResponse>(callPayload);
            });
        }
    }

    public class InstagrambasicdispipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetMyMediaResponse
    {
        [JsonProperty("data")]
        public GetMyMediaResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("paging")]
        public GetMyMediaResponsePagingType Paging { get; set; }
    }

    public class GetMyMediaResponseDataTypeItem
    {
        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }

    public class GetMyMediaResponsePagingType
    {
        [JsonProperty("cursors")]
        public GetMyMediaResponsePagingTypeCursorsType Cursors { get; set; }
    }

    public class GetMyMediaResponsePagingTypeCursorsType
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }
    }

    public class GetMyDetailsResponse
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("media_count")]
        public int MediaCount { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetMediaDetailsResponse
    {
        [JsonProperty("data")]
        public GetMediaDetailsResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("paging")]
        public GetMediaDetailsResponsePagingType Paging { get; set; }
    }

    public class GetMediaDetailsResponseDataTypeItem
    {
        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }

    public class GetMediaDetailsResponsePagingType
    {
        [JsonProperty("cursors")]
        public GetMediaDetailsResponsePagingTypeCursorsType Cursors { get; set; }
    }

    public class GetMediaDetailsResponsePagingTypeCursorsType
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }
    }

    public class RefreshTokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Instagrambasicdispip;

    public partial class WorkflowManagedActions
    {
        public InstagrambasicdispipActions Instagrambasicdispip(string connectionId) => new InstagrambasicdispipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InstagrambasicdispipTriggers Instagrambasicdispip(string connectionId) => new InstagrambasicdispipTriggers(connectionId);
    }
}