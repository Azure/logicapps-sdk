//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instagrambasicdispip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstagrambasicdispipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        public IBodyWorkflowAction<GetMyMediaResponse> GetMyMedia([WorkflowExpression] Func<string> fields = null)
        {
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/media";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("caption,media_type,media_url,permalink,timestamp,username,thumbnail_url");
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyMediaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        public IBodyWorkflowAction<GetMyDetailsResponse> GetMyDetails([WorkflowExpression] Func<string> fields = null)
        {
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("id,media_count,username,account_type");
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<GetMyDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        public IBodyWorkflowAction<GetMediaDetailsResponse> GetMediaDetails([WorkflowExpression] Func<string> mediaId, [WorkflowExpression] Func<string> fields = null)
        {
            SourceExpression.Validate(mediaId, nameof(mediaId), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mediaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("caption,media_type,media_url,permalink,timestamp,username,thumbnail_url");
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<GetMediaDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instagrambasicdispip")]
        public IBodyWorkflowAction<RefreshTokenResponse> RefreshToken([WorkflowExpression] Func<string> grantType, [WorkflowExpression] Func<string> accessToken)
        {
            SourceExpression.Validate(grantType, nameof(grantType), required: true);
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/refresh_access_token";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["grant_type"] = SourceExpressionConverter.ConvertO(grantType);
                callPayload.Queries["access_token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction<RefreshTokenResponse>(BuildSourceInput);
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