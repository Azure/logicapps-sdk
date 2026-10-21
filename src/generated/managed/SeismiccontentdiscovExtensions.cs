//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismiccontentdiscov
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismiccontentdiscovActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiccontentdiscov")]
        public IBodyWorkflowAction<SeismicPredictiveContentPredictiveContentResponse[]> GetPredictiveContentResultSet(Expression<Func<string>> predictiveContentId, Expression<Func<string>> contextId)
        {
            var __workflow_predictiveContentId = WorkflowExpression.Compile(predictiveContentId, nameof(predictiveContentId), required: true);
            var __workflow_contextId = WorkflowExpression.Compile(contextId, nameof(contextId), required: true);
            return new DeferredBodyAction<SeismicPredictiveContentPredictiveContentResponse[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/predictiveContent/{0}/{1}", __workflow_predictiveContentId.WithUrlEncoding(1), __workflow_contextId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicPredictiveContentPredictiveContentResponse[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiccontentdiscov")]
        public IBodyWorkflowAction<SeismicPredictiveContentEmbeddedAppTab[]> GetPredictiveSettings(Expression<Func<string>> systemType = null, Expression<Func<string>> contextType = null)
        {
            var __workflow_systemType = WorkflowExpression.Compile(systemType, nameof(systemType), required: false);
            var __workflow_contextType = WorkflowExpression.Compile(contextType, nameof(contextType), required: false);
            return new DeferredBodyAction<SeismicPredictiveContentEmbeddedAppTab[]>(() =>
            {
                var apiCallPath = "/integration/v2/predictiveContent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_systemType != null)
                    callPayload.Queries["systemType"] = ExpressionConverter.Convert(__workflow_systemType);
                if (__workflow_contextType != null)
                    callPayload.Queries["contextType"] = ExpressionConverter.Convert(__workflow_contextType);
                return new ApiConnectionAction<SeismicPredictiveContentEmbeddedAppTab[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiccontentdiscov")]
        public IBodyWorkflowAction<SeismicDocCenterContentItem[]> GetUserFavorites()
        {
            var apiCallPath = "/integration/v2/users/favorites";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicDocCenterContentItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiccontentdiscov")]
        public IBodyWorkflowAction<SeismicDocCenterContentItem[]> GetUserRecentContents()
        {
            var apiCallPath = "/integration/v2/users/recents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicDocCenterContentItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiccontentdiscov")]
        public IBodyWorkflowAction<SeismicSearchSearchResponse> QueryContent(Expression<Func<string>> continuationToken = null, Expression<Func<string>> searchRequestBodyterm = null, Expression<Func<int>> searchRequestBodyoptionspageSize = null, Expression<Func<searchRequestBodyoptionssearchFieldsInputItem[]>> searchRequestBodyoptionssearchFields = null, Expression<Func<searchRequestBodyoptionsreturnFieldsInputItem[]>> searchRequestBodyoptionsreturnFields = null, Expression<Func<SeismicSearchSortConstraint[]>> searchRequestBodysort = null, Expression<Func<SeismicSearchConditionExpressionInfo[]>> searchRequestBodyfiltercondition = null, Expression<Func<SeismicSearchFilterExpressionInfo[]>> searchRequestBodyfilterfilter = null, Expression<Func<string>> searchRequestBodyfilterOperator = null)
        {
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_searchRequestBodyterm = WorkflowExpression.Compile(searchRequestBodyterm, nameof(searchRequestBodyterm), required: false);
            var __workflow_searchRequestBodyoptionspageSize = WorkflowExpression.Compile(searchRequestBodyoptionspageSize, nameof(searchRequestBodyoptionspageSize), required: false);
            var __workflow_searchRequestBodyoptionssearchFields = WorkflowExpression.Compile(searchRequestBodyoptionssearchFields, nameof(searchRequestBodyoptionssearchFields), required: false);
            var __workflow_searchRequestBodyoptionsreturnFields = WorkflowExpression.Compile(searchRequestBodyoptionsreturnFields, nameof(searchRequestBodyoptionsreturnFields), required: false);
            var __workflow_searchRequestBodysort = WorkflowExpression.Compile(searchRequestBodysort, nameof(searchRequestBodysort), required: false);
            var __workflow_searchRequestBodyfiltercondition = WorkflowExpression.Compile(searchRequestBodyfiltercondition, nameof(searchRequestBodyfiltercondition), required: false);
            var __workflow_searchRequestBodyfilterfilter = WorkflowExpression.Compile(searchRequestBodyfilterfilter, nameof(searchRequestBodyfilterfilter), required: false);
            var __workflow_searchRequestBodyfilterOperator = WorkflowExpression.Compile(searchRequestBodyfilterOperator, nameof(searchRequestBodyfilterOperator), required: false);
            return new DeferredBodyAction<SeismicSearchSearchResponse>(() =>
            {
                var apiCallPath = "/search/v1/content/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                var searchRequestBody = new JObject();
                var searchRequestBodypropCount = 0;
                if (__workflow_searchRequestBodyterm != null)
                {
                    searchRequestBody["term"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodyterm);
                    searchRequestBodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_searchRequestBodyoptionspageSize != null)
                {
                    optionsObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodyoptionspageSize);
                    optionsObjectpropCount++;
                }

                if (__workflow_searchRequestBodyoptionssearchFields != null)
                {
                    optionsObject["searchFields"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodyoptionssearchFields);
                    optionsObjectpropCount++;
                }

                if (__workflow_searchRequestBodyoptionsreturnFields != null)
                {
                    optionsObject["returnFields"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodyoptionsreturnFields);
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    searchRequestBody["options"] = optionsObject;
                    searchRequestBodypropCount++;
                }

                if (__workflow_searchRequestBodysort != null)
                {
                    searchRequestBody["sort"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodysort);
                    searchRequestBodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_searchRequestBodyfiltercondition != null)
                {
                    filterObject["conditions"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodyfiltercondition);
                    filterObjectpropCount++;
                }

                if (__workflow_searchRequestBodyfilterfilter != null)
                {
                    filterObject["filters"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodyfilterfilter);
                    filterObjectpropCount++;
                }

                if (__workflow_searchRequestBodyfilterOperator != null)
                {
                    filterObject["operator"] = ExpressionConverter.ConvertO(__workflow_searchRequestBodyfilterOperator);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    searchRequestBody["filter"] = filterObject;
                    searchRequestBodypropCount++;
                }

                if (searchRequestBodypropCount > 0)
                {
                    callPayload.Body = searchRequestBody;
                }

                return new ApiConnectionAction<SeismicSearchSearchResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class SeismiccontentdiscovTriggers([ConnectionName] string connectionId)
    {
    }

    public class SeismicPredictiveContentPredictiveContentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("score")]
        public SeismicPredictiveContentPredictiveContentScore Score { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("contentProfileId")]
        public string ContentProfileId { get; set; }

        [JsonProperty("url")]
        public SeismicLibraryContentManagementUrlInfo Url { get; set; }

        [JsonProperty("properties")]
        public SeismicContentManagerContentCustomProperties[] Properties { get; set; }

        [JsonProperty("hierarchy")]
        public SeismicPredictiveContentPredictiveContentHierarchy[] Hierarchy { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicWorkSpaceContentManagerApplicationUrl[] ApplicationUrls { get; set; }

        [JsonProperty("libraryContent")]
        public SeismicLibraryWorkflowLibraryContent LibraryContent { get; set; }

        [JsonProperty("deliveryOptions")]
        public SeismicWorkSpaceContentManagerWsDeliveryOption[] DeliveryOptions { get; set; }
    }

    public class SeismicPredictiveContentPredictiveContentScore
    {
        [JsonProperty("points")]
        public double Points { get; set; }

        [JsonProperty("rank")]
        public double Rank { get; set; }
    }

    public class SeismicLibraryContentManagementUrlInfo
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("openInNewWindow")]
        public bool OpenInNewWindow { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SeismicContentManagerContentCustomProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class SeismicPredictiveContentPredictiveContentHierarchy
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SeismicWorkSpaceContentManagerApplicationUrl
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SeismicLibraryWorkflowLibraryContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("teamsiteId")]
        public string TeamsiteId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsDeliveryOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SeismicPredictiveContentEmbeddedAppTab
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("systemType")]
        public string SystemType { get; set; }

        [JsonProperty("contextType")]
        public string ContextType { get; set; }
    }

    public class SeismicDocCenterContentItem
    {
        [JsonProperty("content")]
        public SeismicDocCenterContentInfo Content { get; set; }

        [JsonProperty("publishedAt")]
        public string ContentPublishedDate { get; set; }

        [JsonProperty("modifiedAt")]
        public string ContentModifiedDate { get; set; }

        [JsonProperty("addedAt")]
        public string ContentAddedDate { get; set; }

        [JsonProperty("universalLink")]
        public string ContentUniversalLink { get; set; }

        [JsonProperty("urlObjectUrl")]
        public string ContentOriginURL { get; set; }

        [JsonProperty("thumbnailId")]
        public string ContentThumbnailId { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ContentThumbnailUrl { get; set; }

        [JsonProperty("sourceBlobId")]
        public string SourceBlobId { get; set; }

        [JsonProperty("sourceBlobDownloadUrl")]
        public string SourceBlobDownloadUrl { get; set; }

        [JsonProperty("sourceContainerName")]
        public string SourceContainerName { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("deliveryOptions")]
        public string[] DeliveryOptions { get; set; }

        [JsonProperty("blockedDeliveryOptions")]
        public string[] BlockedDeliveryOptions { get; set; }

        [JsonProperty("allowedDeliveryOptions")]
        public string[] AllowedDeliveryOptions { get; set; }

        [JsonProperty("profileVersionId")]
        public string ProfileVersionId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class SeismicDocCenterContentInfo
    {
        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("name")]
        public string ContentName { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("format")]
        public string ContentFormat { get; set; }

        [JsonProperty("majorVersion")]
        public string MajorVersion { get; set; }

        [JsonProperty("minorVersion")]
        public string MinorVersion { get; set; }

        [JsonProperty("libraryContent")]
        public SeismicLiveSendLiveSendLinkContentBasicInfo LibraryContent { get; set; }

        [JsonProperty("contentProfileId")]
        public string ContentProfileId { get; set; }

        [JsonProperty("contentProfileName")]
        public string ContentProfileName { get; set; }

        [JsonProperty("contentProfilePath")]
        public string[] ContentProfilePath { get; set; }

        [JsonProperty("contentProfilePathIds")]
        public string[] ContentProfilePathIds { get; set; }

        [JsonProperty("id")]
        public string ContentId { get; set; }

        [JsonProperty("contentTypes")]
        public string[] ContentTypes { get; set; }

        [JsonProperty("versionId")]
        public string ContentVersionId { get; set; }

        [JsonProperty("workspaceVersionType")]
        public string WorkspaceVersionType { get; set; }
    }

    public class SeismicLiveSendLiveSendLinkContentBasicInfo
    {
        [JsonProperty("id")]
        public string LibraryContentId { get; set; }

        [JsonProperty("versionId")]
        public string LibraryContentVersionId { get; set; }

        [JsonProperty("teamsiteId")]
        public string LibraryTeamSiteId { get; set; }
    }

    public class SeismicSearchSearchResponse
    {
        [JsonProperty("totalCount")]
        public int TotalResultCount { get; set; }

        [JsonProperty("queryTimeInMs")]
        public int QueryTimeInMillisecond { get; set; }

        [JsonProperty("serviceTimeInMs")]
        public int ServiceTimeInMillisecond { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("documents")]
        public SeismicSearchDocuments[] Documents { get; set; }
    }

    public class SeismicSearchDocuments
    {
        [JsonProperty("repository")]
        public string ContentRepository { get; set; }

        [JsonProperty("name")]
        public string ContentName { get; set; }

        [JsonProperty("teamsiteId")]
        public string ContentTeamsiteId { get; set; }

        [JsonProperty("id")]
        public string ContentId { get; set; }

        [JsonProperty("versionId")]
        public string ContentVersionId { get; set; }

        [JsonProperty("type")]
        public string ContentType { get; set; }

        [JsonProperty("format")]
        public string ContentFormat { get; set; }

        [JsonProperty("description")]
        public string ContentDescription { get; set; }

        [JsonProperty("customProperties")]
        public SeismicSearchCustomPropertyDefinition[] ContentCustomProperties { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicSearchApplicationUrls[] ContentApplicationUrls { get; set; }

        [JsonProperty("contentThumbnailUrl")]
        public string ContentThumbnailUrl { get; set; }

        [JsonProperty("contentDownloadUrl")]
        public string ContentDownloadUrl { get; set; }

        [JsonProperty("createdDate")]
        public string ContentCreatedDate { get; set; }

        [JsonProperty("publishDate")]
        public string ContentPublishDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ContentModifiedDate { get; set; }

        [JsonProperty("majorVersion")]
        public string ContentMajorVersion { get; set; }

        [JsonProperty("minorVersion")]
        public string ContentMinorVersion { get; set; }
    }

    public class SeismicSearchCustomPropertyDefinition
    {
        [JsonProperty("name")]
        public string CustomPropertyName { get; set; }

        [JsonProperty("id")]
        public string CustomPropertyId { get; set; }

        [JsonProperty("type")]
        public string CustomPropertyType { get; set; }

        [JsonProperty("teamSiteId")]
        public string CustomPropertyTeamsiteId { get; set; }

        [JsonProperty("values")]
        public SeismicSearchCustomPropertyValueDefinition[] Values { get; set; }
    }

    public class SeismicSearchCustomPropertyValueDefinition
    {
        [JsonProperty("id")]
        public string CustomPropertyValueId { get; set; }

        [JsonProperty("value")]
        public string CustomPropertyValue { get; set; }
    }

    public class SeismicSearchApplicationUrls
    {
        [JsonProperty("name")]
        public string ApplicationUrlName { get; set; }

        [JsonProperty("url")]
        public string ApplicationUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchRequestBodyoptionssearchFieldsInputItem
    {
        Name,
        Description,
        Body,
        Properties
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchRequestBodyoptionsreturnFieldsInputItem
    {
        Repository,
        Name,
        TeamsiteId,
        Id,
        VersionId,
        Type,
        ApplicationUrls,
        Format,
        Description,
        Properties,
        ThumbnailUrl,
        DownloadUrl,
        CreatedDate,
        PublishDate,
        ModifiedDate,
        MajorVersion,
        MinorVersion
    }

    public class SeismicSearchSortConstraint
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("order")]
        public SeismicSearchSortConstraintOrderType Order { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeismicSearchSortConstraintOrderType
    {
        Asc,
        Desc
    }

    public class SeismicSearchConditionExpressionInfo
    {
        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SeismicSearchFilterExpressionInfo
    {
        [JsonProperty("conditions")]
        public SeismicSearchConditionExpressionInfo[] Condition { get; set; }

        [JsonProperty("filters")]
        public SeismicSearchFilterExpressionInfo[] Filter { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismiccontentdiscov;

    public partial class WorkflowManagedActions
    {
        public SeismiccontentdiscovActions Seismiccontentdiscov(string connectionId) => new SeismiccontentdiscovActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismiccontentdiscovTriggers Seismiccontentdiscov(string connectionId) => new SeismiccontentdiscovTriggers(connectionId);
    }
}
