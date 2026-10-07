//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicconfiguration
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicconfigurationActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildGetContentPropertyValues))]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> GetContentPropertyValues([WorkflowExpression] Func<string> contentPropertyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> __BuildGetContentPropertyValues(WorkflowExpression<string> contentPropertyId)
        {
            WorkflowExpression.Validate(contentPropertyId, nameof(contentPropertyId), required: true);
            return new DeferredBodyAction<SeismicContentManagerDomainOfValues[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/contentProperties/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(contentPropertyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildAddContentPropertyValues))]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> AddContentPropertyValues([WorkflowExpression] Func<string> contentPropertyId, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> __BuildAddContentPropertyValues(WorkflowExpression<string> contentPropertyId, WorkflowExpression<string[]> body = null)
        {
            WorkflowExpression.Validate(contentPropertyId, nameof(contentPropertyId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicContentManagerDomainOfValues[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/contentProperties/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(contentPropertyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildGetContentProperties))]
        public IBodyWorkflowAction<SeismicContentPropertiesContentProperty[]> GetContentProperties([WorkflowExpression] Func<string> teamsiteId = null, [WorkflowExpression] Func<bool> includeValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicContentPropertiesContentProperty[]> __BuildGetContentProperties(WorkflowExpression<string> teamsiteId = null, WorkflowExpression<bool> includeValues = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: false);
            WorkflowExpression.Validate(includeValues, nameof(includeValues), required: false);
            return new DeferredBodyAction<SeismicContentPropertiesContentProperty[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildAddContentProperty))]
        public IBodyWorkflowAction<SeismicContentManagerAddContentPropertyResponse> AddContentProperty([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string[]> bodycontentPropertyValues, [WorkflowExpression] Func<SeismicContentManagerContentPropertyTeamSiteInfo[]> bodyteamsiteIds)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicContentManagerAddContentPropertyResponse> __BuildAddContentProperty(WorkflowExpression<string> bodyname, WorkflowExpression<bodytypeInput> bodytype, WorkflowExpression<string[]> bodycontentPropertyValues, WorkflowExpression<SeismicContentManagerContentPropertyTeamSiteInfo[]> bodyteamsiteIds)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodycontentPropertyValues, nameof(bodycontentPropertyValues), required: true);
            WorkflowExpression.Validate(bodyteamsiteIds, nameof(bodyteamsiteIds), required: true);
            return new DeferredBodyAction<SeismicContentManagerAddContentPropertyResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildGetGdprEmails))]
        public IBodyWorkflowAction<SeismicPrivacyManagementGdprEmailSettingResponse> GetGdprEmails([WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicPrivacyManagementGdprEmailSettingResponse> __BuildGetGdprEmails(WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPrivacyManagementGdprEmailSettingResponse>(() =>
            {
                var apiCallPath = "/integration/v2/system/optouts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<SeismicPrivacyManagementGdprEmailSettingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteGdprEmail))]
        public IWorkflowAction DeleteGdprEmail([WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteGdprEmail(WorkflowExpression<string> email)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/system/optouts/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildGetTeamsiteDetails))]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse> GetTeamsiteDetails([WorkflowExpression] Func<string> teamsiteId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse> __BuildGetTeamsiteDetails(WorkflowExpression<string> teamsiteId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            return new DeferredBodyAction<SeismicTeamsitesTeamsiteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/integration/v2/teamsites/{0}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildGetUserProfiles))]
        public IBodyWorkflowAction<SeismicDocCenterContentProfileResponse[]> GetUserProfiles([WorkflowExpression] Func<string> application = null, [WorkflowExpression] Func<bool> isPredictiveOnly = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicDocCenterContentProfileResponse[]> __BuildGetUserProfiles(WorkflowExpression<string> application = null, WorkflowExpression<bool> isPredictiveOnly = null)
        {
            WorkflowExpression.Validate(application, nameof(application), required: false);
            WorkflowExpression.Validate(isPredictiveOnly, nameof(isPredictiveOnly), required: false);
            return new DeferredBodyAction<SeismicDocCenterContentProfileResponse[]>(() =>
            {
                var apiCallPath = "/integration/v2/users/profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (application != null)
                    callPayload.Queries["application"] = ExpressionConverter.Convert(application);
                if (isPredictiveOnly != null)
                    callPayload.Queries["isPredictiveOnly"] = ExpressionConverter.Convert(isPredictiveOnly);
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