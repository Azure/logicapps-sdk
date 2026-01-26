//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicengagement
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicengagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicengagement")]
        public IBodyWorkflowAction<SeismicDeliveryDeliveryOption[]> GetListOfDeliveryOptions(Expression<Func<bool>> enabled = null)
        {
            var apiCallPath = "/delivery";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (enabled != null)
                callPayload.Queries["Enabled"] = ExpressionConverter.Convert(enabled);
            return new ApiConnectionAction<SeismicDeliveryDeliveryOption[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicengagement")]
        public IBodyWorkflowAction<SeismicDeliveryDeliveryFormInputs> GetDeliveryOptionFormInputs(Expression<Func<string>> deliveryOptionId)
        {
            var apiCallPath = String.Format("/customDelivery/{0}", ExpressionConverter.ConvertWithUrlEncoding(deliveryOptionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicDeliveryDeliveryFormInputs>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicengagement")]
        public IWorkflowAction DeliverViaCustomDelivery(Expression<Func<string>> bodydeliveryOption = null, Expression<Func<string>> bodydeliveryOptionId = null, Expression<Func<SeismicDeliveryCustomDeliveryAdHocInput[]>> bodyadHocInput = null, Expression<Func<SeismicDeliveryCustomDeliveryContent[]>> bodycontent = null)
        {
            var apiCallPath = "/customDelivery";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeliveryOption != null)
            {
                body["deliveryOption"] = ExpressionConverter.ConvertO(bodydeliveryOption);
                bodypropCount++;
            }

            if (bodydeliveryOptionId != null)
            {
                body["deliveryOptionId"] = ExpressionConverter.ConvertO(bodydeliveryOptionId);
                bodypropCount++;
            }

            if (bodyadHocInput != null)
            {
                body["adHocInputs"] = ExpressionConverter.ConvertO(bodyadHocInput);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicengagement")]
        public IBodyWorkflowAction<SeismicWorkSpaceContentManagerWsItemResp> SaveToWorkspace(Expression<Func<string>> bodyworkspaceOptionsworkspaceFolderId = null, Expression<Func<SeismicDeliveryCustomDelContent[]>> bodycontent = null)
        {
            var apiCallPath = "/saveToWorkspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var workspaceOptionsObject = new JObject();
            var workspaceOptionsObjectpropCount = 0;
            if (bodyworkspaceOptionsworkspaceFolderId != null)
            {
                workspaceOptionsObject["workspaceFolderId"] = ExpressionConverter.ConvertO(bodyworkspaceOptionsworkspaceFolderId);
                workspaceOptionsObjectpropCount++;
            }

            if (workspaceOptionsObjectpropCount > 0)
            {
                body["workspaceOptions"] = workspaceOptionsObject;
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SeismicWorkSpaceContentManagerWsItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicengagement")]
        public IBodyWorkflowAction<SeismicLiveSendLiveSendLinkResponse> CreateLiveSendLink(Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodysettingsexpiresAt = null, Expression<Func<string>> bodysettingspassword = null, Expression<Func<bool>> bodysettingsallowDownload = null, Expression<Func<string>> bodysettingsnotificationType = null, Expression<Func<bool>> bodysettingssingleView = null, Expression<Func<SeismicLiveSendLiveSendLinkContent[]>> bodycontent = null)
        {
            var apiCallPath = "/liveSend/links";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsexpiresAt != null)
            {
                settingsObject["expiresAt"] = ExpressionConverter.ConvertO(bodysettingsexpiresAt);
                settingsObjectpropCount++;
            }

            if (bodysettingspassword != null)
            {
                settingsObject["password"] = ExpressionConverter.ConvertO(bodysettingspassword);
                settingsObjectpropCount++;
            }

            if (bodysettingsallowDownload != null)
            {
                settingsObject["allowDownload"] = ExpressionConverter.ConvertO(bodysettingsallowDownload);
                settingsObjectpropCount++;
            }

            if (bodysettingsnotificationType != null)
            {
                settingsObject["notificationType"] = ExpressionConverter.ConvertO(bodysettingsnotificationType);
                settingsObjectpropCount++;
            }

            if (bodysettingssingleView != null)
            {
                settingsObject["singleView"] = ExpressionConverter.ConvertO(bodysettingssingleView);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                body["settings"] = settingsObject;
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SeismicLiveSendLiveSendLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicengagement")]
        public IBodyWorkflowAction<SeismicLiveSendLiveSendSettingsResponse> GetLiveSendSettings()
        {
            var apiCallPath = "/liveSend/settings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeismicLiveSendLiveSendSettingsResponse>(callPayload);
        }
    }

    public class SeismicengagementTriggers([ConnectionName] string connectionId)
    {
    }

    public class SeismicDeliveryDeliveryOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }

        [JsonProperty("hasForm")]
        public bool HasForm { get; set; }

        [JsonProperty("externalApplication")]
        public SeismicDeliveryExternalApplicationType ExternalApplication { get; set; }
    }

    public enum SeismicDeliveryExternalApplicationType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "ios")]
        Ios,
        [EnumMember(Value = "salesforce")]
        Salesforce,
        [EnumMember(Value = "sharepoint")]
        Sharepoint,
        [EnumMember(Value = "google drive")]
        GoogleDrive,
        [EnumMember(Value = "gmail")]
        Gmail
    }

    public class SeismicDeliveryDeliveryFormInputs
    {
        [JsonProperty("adHocInputs")]
        public SeismicDeliveryDeliveryFormInput[] AdHocInputs { get; set; }
    }

    public class SeismicDeliveryDeliveryFormInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public SeismicDeliveryAdHocInputType Type { get; set; }

        [JsonProperty("columns")]
        public SeismicDeliveryDeliveryFormInput[] Columns { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }

    public enum SeismicDeliveryAdHocInputType
    {
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "float")]
        Float,
        [EnumMember(Value = "table")]
        Table
    }

    public class SeismicDeliveryCustomDeliveryAdHocInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SeismicDeliveryCustomDeliveryContent
    {
        [JsonProperty("repository")]
        public SeismicDeliveryCustomDeliveryContentRepositoryType Repository { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("teamsiteId")]
        public string TeamsiteId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contentProfileId")]
        public string ProfileId { get; set; }

        [JsonProperty("contentProfilePath")]
        public string[] ContentProfilePath { get; set; }

        [JsonProperty("libraryContent")]
        public SeismicDeliveryInternalLibraryContent LibraryContent { get; set; }
    }

    public enum SeismicDeliveryCustomDeliveryContentRepositoryType
    {
        [EnumMember(Value = "generatedlivedocs")]
        Generatedlivedocs,
        [EnumMember(Value = "library")]
        Library,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "doccenter")]
        Doccenter,
        [EnumMember(Value = "newscenter")]
        Newscenter
    }

    public class SeismicDeliveryInternalLibraryContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("teamsiteId")]
        public string TeamsiteId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsItemResp
    {
        [JsonProperty("url")]
        public SeismicWorkSpaceContentManagerWsUrlInfoResp Url { get; set; }

        [JsonProperty("id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("type")]
        public SeismicWorkSpaceContentManagerItemType Type { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("deliveryOptions")]
        public SeismicWorkSpaceContentManagerWsDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("versionId")]
        public string WorkspaceVersionId { get; set; }

        [JsonProperty("applicationUrls")]
        public SeismicWorkSpaceContentManagerApplicationUrl[] ApplicationUrls { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicWorkSpaceContentManagerCreatedUser CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicWorkSpaceContentManagerModifiedUser ModifiedBy { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("name")]
        public string ContentName { get; set; }

        [JsonProperty("parentFolderId")]
        public string ContentParentFolderId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerWsUrlInfoResp
    {
        [JsonProperty("url")]
        public string WorkspaceUrl { get; set; }
    }

    public enum SeismicWorkSpaceContentManagerItemType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File
    }

    public class SeismicWorkSpaceContentManagerWsDeliveryOption
    {
        [JsonProperty("id")]
        public string WorkspaceDeliveryOptionId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerApplicationUrl
    {
        [JsonProperty("name")]
        public string WorkspaceApplicationName { get; set; }

        [JsonProperty("url")]
        public string WorkspaceApplicationUrl { get; set; }
    }

    public class SeismicWorkSpaceContentManagerCreatedUser
    {
        [JsonProperty("id")]
        public string CreatedByUserId { get; set; }
    }

    public class SeismicWorkSpaceContentManagerModifiedUser
    {
        [JsonProperty("id")]
        public string ModifiedByUserId { get; set; }
    }

    public class SeismicDeliveryCustomDelContent
    {
        [JsonProperty("repository")]
        public SeismicDeliveryCustomRepository Repository { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("libraryContent")]
        public SeismicDeliveryInternalLibraryContent LibraryContent { get; set; }

        [JsonProperty("contentProfileId")]
        public string ProfileId { get; set; }

        [JsonProperty("contentProfilePath")]
        public string[] ProfilePath { get; set; }
    }

    public enum SeismicDeliveryCustomRepository
    {
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "doccenter")]
        Doccenter,
        [EnumMember(Value = "newscenter")]
        Newscenter
    }

    public class SeismicLiveSendLiveSendLinkResponse
    {
        [JsonProperty("url")]
        public string LivesendUrl { get; set; }

        [JsonProperty("id")]
        public string LivesendId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("settings")]
        public SeismicLiveSendLiveSendLinkSettings Settings { get; set; }

        [JsonProperty("content")]
        public SeismicLiveSendLiveSendLinkContent[] Content { get; set; }
    }

    public class SeismicLiveSendLiveSendLinkSettings
    {
        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("allowDownload")]
        public bool AllowDownload { get; set; }

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("singleView")]
        public bool SingleView { get; set; }
    }

    public class SeismicLiveSendLiveSendLinkContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("teamsiteId")]
        public string TeamsiteId { get; set; }

        [JsonProperty("repository")]
        public SeismicLiveSendLiveSendContentRepositoryEnum Repository { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("libraryContent")]
        public SeismicLiveSendLiveSendLinkContentBasicInfo LibraryContent { get; set; }

        [JsonProperty("contentProfileId")]
        public string ProfileId { get; set; }

        [JsonProperty("contentProfilePath")]
        public string[] ProfilePath { get; set; }
    }

    public enum SeismicLiveSendLiveSendContentRepositoryEnum
    {
        DocCenter,
        NewsCenter,
        WorkSpace,
        Library,
        GeneratedLivedocs
    }

    public class SeismicLiveSendLiveSendLinkContentBasicInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("teamsiteId")]
        public string TeamSiteId { get; set; }
    }

    public class SeismicLiveSendLiveSendSettingsResponse
    {
        [JsonProperty("defaultExpirationDays")]
        public int DefaultExpirationDays { get; set; }

        [JsonProperty("maxExpirationDays")]
        public int MaxExpirationDays { get; set; }

        [JsonProperty("allowDownload")]
        public bool AllowDownload { get; set; }

        [JsonProperty("singleView")]
        public bool SingleView { get; set; }

        [JsonProperty("passwordSettings")]
        public SeismicLiveSendLiveSendPasswordSettings PasswordSettings { get; set; }
    }

    public class SeismicLiveSendLiveSendPasswordSettings
    {
        [JsonProperty("requiresLowerCase")]
        public bool RequiresLowerCase { get; set; }

        [JsonProperty("requiresNumber")]
        public bool RequiresNumber { get; set; }

        [JsonProperty("requiresSymbols")]
        public bool RequiresSymbols { get; set; }

        [JsonProperty("requiresUpperCase")]
        public bool RequiresUpperCase { get; set; }

        [JsonProperty("minimumLength")]
        public int MinimumLength { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismicengagement;

    public partial class WorkflowManagedActions
    {
        public SeismicengagementActions Seismicengagement(string connectionId) => new SeismicengagementActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismicengagementTriggers Seismicengagement(string connectionId) => new SeismicengagementTriggers(connectionId);
    }
}