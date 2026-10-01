//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyvistaselfhelp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyvistaselfhelpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaselfhelp")]
        public IWorkflowAction Execute([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> scenarioId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AtanorPortalAPI/atanor/execute/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["scenarioId"] = SourceExpressionConverter.ConvertO(scenarioId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaselfhelp")]
        public IWorkflowAction GetPausedProcedureList([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> locale, [WorkflowExpression] Func<string> versionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AtanorPortalAPI/atanor/paused/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["versionId"] = SourceExpressionConverter.ConvertO(versionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaselfhelp")]
        public IBodyWorkflowAction<GetProcedureListResponse> GetProcedureList([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> locale, [WorkflowExpression] Func<string> versionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AtanorPortalAPI/atanor/project/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["versionId"] = SourceExpressionConverter.ConvertO(versionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProcedureListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaselfhelp")]
        public IBodyWorkflowAction<GetProjectListResponse> GetProjectList([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> locale, [WorkflowExpression] Func<string> mode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AtanorPortalAPI/atanor/projects/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (mode != null)
                    callPayload.Queries["mode"] = SourceExpressionConverter.ConvertO(mode);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaselfhelp")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> locale, [WorkflowExpression] Func<string> pattern, [WorkflowExpression] Func<string> versionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AtanorPortalAPI/atanor/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["pattern"] = SourceExpressionConverter.ConvertO(pattern);
                if (versionId != null)
                    callPayload.Queries["versionId"] = SourceExpressionConverter.ConvertO(versionId);
                return callPayload;
            }

            return new ApiConnectionAction<SearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaselfhelp")]
        public IBodyWorkflowAction<GetUserResponse> GetUser([WorkflowExpression] Func<string> sessionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AtanorPortalAPI/atanor/user/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaselfhelp")]
        public IWorkflowAction Login([WorkflowExpression] Func<string> login, [WorkflowExpression] Func<string> password, [WorkflowExpression] Func<string> locale = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/livedesk/CHECK";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["locale"] = Convert.ToString("en_US");
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                callPayload.Queries["login"] = SourceExpressionConverter.ConvertO(login);
                callPayload.Queries["password"] = SourceExpressionConverter.ConvertO(password);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class EasyvistaselfhelpTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetProcedureListResponse
    {
        [JsonProperty("folders")]
        public GetProcedureListResponseFoldersTypeItem[] Folders { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("iconId")]
        public string IconId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scenarios")]
        public JToken[] Scenarios { get; set; }
    }

    public class GetProcedureListResponseFoldersTypeItem
    {
        [JsonProperty("folders")]
        public GetProcedureListResponseFoldersTypeItemFoldersTypeItem[] Folders { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("iconId")]
        public string IconId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scenarios")]
        public GetProcedureListResponseFoldersTypeItemScenariosTypeItem[] Scenarios { get; set; }
    }

    public class GetProcedureListResponseFoldersTypeItemFoldersTypeItem
    {
        [JsonProperty("folders")]
        public JToken[] Folders { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("iconId")]
        public string IconId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scenarios")]
        public GetProcedureListResponseFoldersTypeItemFoldersTypeItemScenariosTypeItem[] Scenarios { get; set; }
    }

    public class GetProcedureListResponseFoldersTypeItemFoldersTypeItemScenariosTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domainId")]
        public string DomainId { get; set; }

        [JsonProperty("iconId")]
        public string IconId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadataProperties")]
        public GetProcedureListResponseFoldersTypeItemFoldersTypeItemScenariosTypeItemMetadataPropertiesType MetadataProperties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class GetProcedureListResponseFoldersTypeItemFoldersTypeItemScenariosTypeItemMetadataPropertiesType
    {
        public string ProcedureViewable { get; set; }
    }

    public class GetProcedureListResponseFoldersTypeItemScenariosTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domainId")]
        public string DomainId { get; set; }

        [JsonProperty("iconId")]
        public string IconId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadataProperties")]
        public GetProcedureListResponseFoldersTypeItemScenariosTypeItemMetadataPropertiesType MetadataProperties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class GetProcedureListResponseFoldersTypeItemScenariosTypeItemMetadataPropertiesType
    {
        public string ProcedureViewable { get; set; }
    }

    public class GetProjectListResponse
    {
        [JsonProperty("domainList")]
        public GetProjectListResponseDomainListTypeItem[] DomainList { get; set; }
    }

    public class GetProjectListResponseDomainListTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projects")]
        public GetProjectListResponseDomainListTypeItemProjectsTypeItem[] Projects { get; set; }
    }

    public class GetProjectListResponseDomainListTypeItemProjectsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadataProperties")]
        public string MetadataProperties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("publicationDate")]
        public string PublicationDate { get; set; }

        [JsonProperty("versionNumber")]
        public string VersionNumber { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("availableScenarios")]
        public SearchResponseAvailableScenariosTypeItem[] AvailableScenarios { get; set; }

        [JsonProperty("bestRank")]
        public string BestRank { get; set; }

        [JsonProperty("domainId")]
        public string DomainId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("scenarios")]
        public SearchResponseScenariosTypeItem[] Scenarios { get; set; }

        [JsonProperty("searchTimeMs")]
        public string SearchTimeMs { get; set; }

        [JsonProperty("searchUid")]
        public string SearchUid { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userLogin")]
        public string UserLogin { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("worstRank")]
        public string WorstRank { get; set; }
    }

    public class SearchResponseAvailableScenariosTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domainId")]
        public string DomainId { get; set; }

        [JsonProperty("iconId")]
        public string IconId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadataProperties")]
        public JToken MetadataProperties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public class SearchResponseScenariosTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domainId")]
        public string DomainId { get; set; }

        [JsonProperty("iconId")]
        public string IconId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadataProperties")]
        public JToken MetadataProperties { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public class GetUserResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("expert")]
        public bool Expert { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("grps")]
        public GetUserResponseGrpsType Grps { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("properties")]
        public string Properties { get; set; }

        [JsonProperty("sessionLess")]
        public bool SessionLess { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetUserResponseGrpsType
    {
        [JsonProperty("tempAdminGroup-8739-7439")]
        public string TempAdminGroup87397439 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Easyvistaselfhelp;

    public partial class WorkflowManagedActions
    {
        public EasyvistaselfhelpActions Easyvistaselfhelp(string connectionId) => new EasyvistaselfhelpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EasyvistaselfhelpTriggers Easyvistaselfhelp(string connectionId) => new EasyvistaselfhelpTriggers(connectionId);
    }
}