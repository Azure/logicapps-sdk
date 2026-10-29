//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicconfiguration
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicconfigurationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[], ApiConnectionActionConfiguration> GetContentPropertyValues(Expression<Func<string>> contentPropertyId)
        {
            var __workflow_contentPropertyId = WorkflowExpression.Compile(contentPropertyId, nameof(contentPropertyId), required: true);
            return new DeferredBodyAction<SeismicContentManagerDomainOfValues[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/contentProperties/{0}/values", __workflow_contentPropertyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[], ApiConnectionActionConfiguration> AddContentPropertyValues(Expression<Func<string>> contentPropertyId, Expression<Func<string[]>> body = null)
        {
            var __workflow_contentPropertyId = WorkflowExpression.Compile(contentPropertyId, nameof(contentPropertyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicContentManagerDomainOfValues[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/contentProperties/{0}/values", __workflow_contentPropertyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentPropertiesContentProperty[], ApiConnectionActionConfiguration> GetContentProperties(Expression<Func<string>> teamsiteId = null, Expression<Func<bool>> includeValues = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: false);
            var __workflow_includeValues = WorkflowExpression.Compile(includeValues, nameof(includeValues), required: false);
            return new DeferredBodyAction<SeismicContentPropertiesContentProperty[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/contentProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_teamsiteId != null)
                    callPayload.Queries["teamsiteId"] = ExpressionConverter.Convert(__workflow_teamsiteId);
                callPayload.Queries["includeValues"] = Convert.ToString(true);
                if (__workflow_includeValues != null)
                    callPayload.Queries["includeValues"] = ExpressionConverter.Convert(__workflow_includeValues);
                return new ApiConnectionAction<SeismicContentPropertiesContentProperty[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerAddContentPropertyResponse, ApiConnectionActionConfiguration> AddContentProperty(Expression<Func<string>> bodyname, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string[]>> bodycontentPropertyValues, Expression<Func<SeismicContentManagerContentPropertyTeamSiteInfo[]>> bodyteamsiteIds)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodycontentPropertyValues = WorkflowExpression.Compile(bodycontentPropertyValues, nameof(bodycontentPropertyValues), required: true);
            var __workflow_bodyteamsiteIds = WorkflowExpression.Compile(bodyteamsiteIds, nameof(bodyteamsiteIds), required: true);
            return new DeferredBodyAction<SeismicContentManagerAddContentPropertyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/contentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["domainOfValues"] = ExpressionConverter.ConvertO(__workflow_bodycontentPropertyValues);
                bodypropCount++;
                body["teamSites"] = ExpressionConverter.ConvertO(__workflow_bodyteamsiteIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicContentManagerAddContentPropertyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicPrivacyManagementGdprEmailSettingResponse, ApiConnectionActionConfiguration> GetGdprEmails(Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPrivacyManagementGdprEmailSettingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/system/optouts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<SeismicPrivacyManagementGdprEmailSettingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteGdprEmail(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/system/optouts/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse[], ApiConnectionActionConfiguration> GetTeamsites()
        {
            return new DeferredBodyAction<SeismicTeamsitesTeamsiteResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/teamsites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse, ApiConnectionActionConfiguration> GetTeamsiteDetails(Expression<Func<string>> teamsiteId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            return new DeferredBodyAction<SeismicTeamsitesTeamsiteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/integration/v2/teamsites/{0}", __workflow_teamsiteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse[], ApiConnectionActionConfiguration> GetUserTeamsites()
        {
            return new DeferredBodyAction<SeismicTeamsitesTeamsiteResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/users/teamsites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicDocCenterContentProfileResponse[], ApiConnectionActionConfiguration> GetUserProfiles(Expression<Func<string>> application = null, Expression<Func<bool>> isPredictiveOnly = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: false);
            var __workflow_isPredictiveOnly = WorkflowExpression.Compile(isPredictiveOnly, nameof(isPredictiveOnly), required: false);
            return new DeferredBodyAction<SeismicDocCenterContentProfileResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/v2/users/profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_application != null)
                    callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_isPredictiveOnly != null)
                    callPayload.Queries["isPredictiveOnly"] = ExpressionConverter.Convert(__workflow_isPredictiveOnly);
                return new ApiConnectionAction<SeismicDocCenterContentProfileResponse[]>(callPayload);
            });
        }
    }

    public class SeismicconfigurationTriggers([ConnectionName] string connectionId)
    {
    }

    public class SeismicContentManagerDomainOfValues
    {
        [JsonProperty("id")]
        public string ContentPropertyValueId { get; set; }

        [JsonProperty("value")]
        public string ContentPropertyValue { get; set; }
    }

    public class SeismicContentPropertiesContentProperty
    {
        [JsonProperty("id")]
        public string ContentPropertyId { get; set; }

        [JsonProperty("name")]
        public string ContentPropertyName { get; set; }

        [JsonProperty("type")]
        public string ContentPropertyType { get; set; }

        [JsonProperty("hasDomainOfValues")]
        public bool ContentPropertyHasDomainValues { get; set; }

        [JsonProperty("domainOfValues")]
        public SeismicContentManagerDomainOfValues[] DomainOfValues { get; set; }

        [JsonProperty("teamsites")]
        public SeismicContentPropertiesContentPropertyTeamsite[] Teamsites { get; set; }
    }

    public class SeismicContentPropertiesContentPropertyTeamsite
    {
        [JsonProperty("teamsiteId")]
        public string TeamsiteId { get; set; }

        [JsonProperty("teamsiteName")]
        public string TeamsiteName { get; set; }

        [JsonProperty("isRequired")]
        public bool IsARequiredTeamsite { get; set; }
    }

    public class SeismicContentManagerAddContentPropertyResponse
    {
        [JsonProperty("id")]
        public string ContentPropertyId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "tag")]
        Tag,
        [EnumMember(Value = "multi-value")]
        MultiValue,
        [EnumMember(Value = "boolean")]
        Boolean
    }

    public class SeismicContentManagerContentPropertyTeamSiteInfo
    {
        [JsonProperty("teamSiteId")]
        public string TeamsiteId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsARequiredProperty { get; set; }
    }

    public class SeismicPrivacyManagementGdprEmailSettingResponse
    {
        [JsonProperty("entries")]
        public SeismicPrivacyManagementGdprEmailSettingResponse[] Entries { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageCap")]
        public int PageCap { get; set; }

        [JsonProperty("limit")]
        public int PageLimit { get; set; }

        [JsonProperty("offset")]
        public int PageOffset { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextPageLink")]
        public string NextPageLink { get; set; }
    }

    public class SeismicTeamsitesTeamsiteResponse
    {
        [JsonProperty("id")]
        public string TeamsiteId { get; set; }

        [JsonProperty("name")]
        public string TeamsiteName { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefaultTeamsite { get; set; }
    }

    public class SeismicDocCenterContentProfileResponse
    {
        [JsonProperty("id")]
        public string ContentProfileId { get; set; }

        [JsonProperty("versionId")]
        public string ContentProfileVersionId { get; set; }

        [JsonProperty("name")]
        public string ContentProfileName { get; set; }

        [JsonProperty("type")]
        public string ContentProfileType { get; set; }

        [JsonProperty("modifiedAt")]
        public string ContentProfileLastModifiedDate { get; set; }

        [JsonProperty("coverImageId")]
        public string ContentProfileCoverImageId { get; set; }

        [JsonProperty("coverImageUrl")]
        public string ContentProfileCoverImageUrl { get; set; }

        [JsonProperty("isPredictiveOnly")]
        public bool IsAPredctiveSupportedContentProfile { get; set; }

        [JsonProperty("isPublished")]
        public bool IsAPublishedContentProfile { get; set; }

        [JsonProperty("isDefault")]
        public bool IsADefaultContentProfile { get; set; }

        [JsonProperty("applications")]
        public SeismicDocCenterApplication[] Applications { get; set; }

        [JsonProperty("teamSiteId")]
        public string TeamsiteId { get; set; }
    }

    public class SeismicDocCenterApplication
    {
        [JsonProperty("id")]
        public string ApplicationId { get; set; }

        [JsonProperty("name")]
        public string ApplicationName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismicconfiguration;

    public partial class WorkflowManagedActions
    {
        public SeismicconfigurationActions Seismicconfiguration(string connectionId) => new SeismicconfigurationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismicconfigurationTriggers Seismicconfiguration(string connectionId) => new SeismicconfigurationTriggers(connectionId);
    }
}