//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicconfiguration
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicconfigurationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> GetContentPropertyValues(Expression<Func<string>> contentPropertyId)
        {
            var apiCallPath = String.Format("/integration/v2/contentProperties/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(contentPropertyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> AddContentPropertyValues(Expression<Func<string>> contentPropertyId, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = String.Format("/integration/v2/contentProperties/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(contentPropertyId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentPropertiesContentProperty[]> GetContentProperties(Expression<Func<string>> teamsiteId = null, Expression<Func<bool>> includeValues = null)
        {
            var apiCallPath = "/integration/v2/contentProperties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (teamsiteId != null)
                callPayload.Queries["teamsiteId"] = ExpressionConverter.Convert(teamsiteId);
            callPayload.Queries["includeValues"] = Convert.ToString(true);
            if (includeValues != null)
                callPayload.Queries["includeValues"] = ExpressionConverter.Convert(includeValues);
            return new ApiConnectionAction<SeismicContentPropertiesContentProperty[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerAddContentPropertyResponse> AddContentProperty(Expression<Func<string>> bodyname, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string[]>> bodycontentPropertyValues, Expression<Func<SeismicContentManagerContentPropertyTeamSiteInfo[]>> bodyteamsiteIds)
        {
            var apiCallPath = "/integration/v2/contentProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["domainOfValues"] = ExpressionConverter.ConvertO(bodycontentPropertyValues);
            bodypropCount++;
            body["teamSites"] = ExpressionConverter.ConvertO(bodyteamsiteIds);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SeismicContentManagerAddContentPropertyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicPrivacyManagementGdprEmailSettingResponse> GetGdprEmails(Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/integration/v2/system/optouts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<SeismicPrivacyManagementGdprEmailSettingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IWorkflowAction DeleteGdprEmail(Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/integration/v2/system/optouts/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse[]> GetTeamsites()
        {
            var apiCallPath = "/integration/v2/teamsites";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse> GetTeamsiteDetails(Expression<Func<string>> teamsiteId)
        {
            var apiCallPath = String.Format("/integration/v2/teamsites/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse[]> GetUserTeamsites()
        {
            var apiCallPath = "/integration/v2/users/teamsites";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicDocCenterContentProfileResponse[]> GetUserProfiles(Expression<Func<string>> application = null, Expression<Func<bool>> isPredictiveOnly = null)
        {
            var apiCallPath = "/integration/v2/users/profiles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (application != null)
                callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (isPredictiveOnly != null)
                callPayload.Queries["isPredictiveOnly"] = ExpressionConverter.Convert(isPredictiveOnly);
            return new ApiConnectionAction<SeismicDocCenterContentProfileResponse[]>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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