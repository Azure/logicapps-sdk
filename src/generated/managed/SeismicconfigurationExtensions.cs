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
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> GetContentPropertyValues([WorkflowExpression] Func<string> contentPropertyId)
        {
            SourceExpression.Validate(contentPropertyId, nameof(contentPropertyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/contentProperties/{0}/values", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contentPropertyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerDomainOfValues[]> AddContentPropertyValues([WorkflowExpression] Func<string> contentPropertyId, [WorkflowExpression] Func<string[]> body = null)
        {
            SourceExpression.Validate(contentPropertyId, nameof(contentPropertyId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/contentProperties/{0}/values", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contentPropertyId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicContentManagerDomainOfValues[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentPropertiesContentProperty[]> GetContentProperties([WorkflowExpression] Func<string> teamsiteId = null, [WorkflowExpression] Func<bool> includeValues = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: false);
            SourceExpression.Validate(includeValues, nameof(includeValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/contentProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (teamsiteId != null)
                    callPayload.Queries["teamsiteId"] = SourceExpressionConverter.ConvertO(teamsiteId);
                callPayload.Queries["includeValues"] = Convert.ToString(true);
                if (includeValues != null)
                    callPayload.Queries["includeValues"] = SourceExpressionConverter.ConvertO(includeValues);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicContentPropertiesContentProperty[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicContentManagerAddContentPropertyResponse> AddContentProperty([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string[]> bodycontentPropertyValues, [WorkflowExpression] Func<SeismicContentManagerContentPropertyTeamSiteInfo[]> bodyteamsiteIds)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodycontentPropertyValues, nameof(bodycontentPropertyValues), required: true);
            SourceExpression.Validate(bodyteamsiteIds, nameof(bodyteamsiteIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/contentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["domainOfValues"] = SourceExpressionConverter.ConvertToken(bodycontentPropertyValues);
                bodypropCount++;
                body["teamSites"] = SourceExpressionConverter.ConvertToken(bodyteamsiteIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicContentManagerAddContentPropertyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicPrivacyManagementGdprEmailSettingResponse> GetGdprEmails([WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/system/optouts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicPrivacyManagementGdprEmailSettingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IWorkflowAction DeleteGdprEmail([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/system/optouts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse[]> GetTeamsites()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/teamsites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse> GetTeamsiteDetails([WorkflowExpression] Func<string> teamsiteId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/integration/v2/teamsites/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicTeamsitesTeamsiteResponse[]> GetUserTeamsites()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/users/teamsites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicTeamsitesTeamsiteResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicconfiguration")]
        public IBodyWorkflowAction<SeismicDocCenterContentProfileResponse[]> GetUserProfiles([WorkflowExpression] Func<string> application = null, [WorkflowExpression] Func<bool> isPredictiveOnly = null)
        {
            SourceExpression.Validate(application, nameof(application), required: false);
            SourceExpression.Validate(isPredictiveOnly, nameof(isPredictiveOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/v2/users/profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (application != null)
                    callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                if (isPredictiveOnly != null)
                    callPayload.Queries["isPredictiveOnly"] = SourceExpressionConverter.ConvertO(isPredictiveOnly);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicDocCenterContentProfileResponse[]>(BuildSourceInput);
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