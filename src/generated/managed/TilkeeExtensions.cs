//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tilkee
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TilkeeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectCreateResponse, ApiConnectionActionConfiguration> ProjectCreate(Expression<Func<ProjectCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ProjectCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/wrapper/token_from_files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectListResponse, ApiConnectionActionConfiguration> ProjectList(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> order, Expression<Func<bool>> isTemplate, Expression<Func<bool>> isOwner, Expression<Func<string>> tags = null, Expression<Func<string>> tagOperator = null, Expression<Func<string>> search = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: true);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: true);
            var __workflow_isTemplate = WorkflowExpression.Compile(isTemplate, nameof(isTemplate), required: true);
            var __workflow_isOwner = WorkflowExpression.Compile(isOwner, nameof(isOwner), required: true);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_tagOperator = WorkflowExpression.Compile(tagOperator, nameof(tagOperator), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<ProjectListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                callPayload.Queries["is_template"] = ExpressionConverter.Convert(__workflow_isTemplate);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_tagOperator != null)
                    callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(__workflow_tagOperator);
                callPayload.Queries["is_owner"] = ExpressionConverter.Convert(__workflow_isOwner);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ProjectListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectGetResponse, ApiConnectionActionConfiguration> ProjectGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ProjectGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["iframe_url"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ProjectGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectUpdateResponse, ApiConnectionActionConfiguration> ProjectUpdate(Expression<Func<string>> id, Expression<Func<ProjectUpdateInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProjectUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<AccessLinkCreateResponse, ApiConnectionActionConfiguration> AccessLinkCreate(Expression<Func<string>> projectId, Expression<Func<AccessLinkCreateInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AccessLinkCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/tokens", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AccessLinkCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<AddItemToProjectResponseItem[], ApiConnectionActionConfiguration> AddItemToProject(Expression<Func<string>> projectId, Expression<Func<AddItemToProjectInput>> body)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddItemToProjectResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/add_items", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddItemToProjectResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ItemListResponse, ApiConnectionActionConfiguration> ItemList(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> tags = null, Expression<Func<string>> tagOperator = null, Expression<Func<string>> search = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: true);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_tagOperator = WorkflowExpression.Compile(tagOperator, nameof(tagOperator), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<ItemListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_tagOperator != null)
                    callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(__workflow_tagOperator);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<ItemListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ItemCreateResponseItem[], ApiConnectionActionConfiguration> ItemCreate(Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ItemCreateResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ItemCreateResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<DirectUploadInformationResponse, ApiConnectionActionConfiguration> DirectUploadInformation(Expression<Func<string>> filename, Expression<Func<string>> originalFilename, Expression<Func<bool>> checkExisting = null)
        {
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            var __workflow_originalFilename = WorkflowExpression.Compile(originalFilename, nameof(originalFilename), required: true);
            var __workflow_checkExisting = WorkflowExpression.Compile(checkExisting, nameof(checkExisting), required: false);
            return new DeferredBodyAction<DirectUploadInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/direct_upload_data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                callPayload.Queries["original_filename"] = ExpressionConverter.Convert(__workflow_originalFilename);
                if (__workflow_checkExisting != null)
                    callPayload.Queries["check_existing"] = ExpressionConverter.Convert(__workflow_checkExisting);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                return new ApiConnectionAction<DirectUploadInformationResponse>(callPayload);
            });
        }
    }

    public class TilkeeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnTilkeeEvent(Expression<Func<OnTilkeeEventInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnTilkeeEventEnded(Expression<Func<OnTilkeeEventEndedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/notifications/connexion_ended";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnTilkeeEventSigned(Expression<Func<OnTilkeeEventSignedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/notifications/token_signed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ProjectCreateResponse
    {
        [JsonProperty("project")]
        public ProjectCreateResponseProjectType Project { get; set; }

        [JsonProperty("tokens")]
        public ProjectCreateResponseTokensTypeItem[] Tokens { get; set; }
    }

    public class ProjectCreateResponseProjectType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("iframes")]
        public ProjectCreateResponseProjectTypeIframesType Iframes { get; set; }
    }

    public class ProjectCreateResponseProjectTypeIframesType
    {
        [JsonProperty("project_escape")]
        public string ProjectEscape { get; set; }

        [JsonProperty("tokens_escape")]
        public string TokensEscape { get; set; }

        [JsonProperty("stats_escape")]
        public string StatsEscape { get; set; }
    }

    public class ProjectCreateResponseTokensTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    public class ProjectCreateInput
    {
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Include)]
        public ProjectCreateInputProjectType Project { get; set; }

        [JsonProperty("documents")]
        public ProjectCreateInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("person")]
        public ProjectCreateInputPersonTypeItem[] Person { get; set; }
    }

    public class ProjectCreateInputProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool? CanBeDownloaded { get; set; }

        [JsonProperty("consultable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Consultable { get; set; } = true;

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("collaborators")]
        public JToken[] Collaborators { get; set; }

        [JsonProperty("is_template", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsTemplate { get; set; } = false;

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("theme")]
        public ProjectCreateInputProjectTypeThemeType Theme { get; set; }
    }

    public class ProjectCreateInputProjectTypeThemeType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class ProjectCreateInputDocumentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("signable")]
        public bool? Signable { get; set; }

        [JsonProperty("from_url")]
        public bool? FromUrl { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    public class ProjectCreateInputPersonTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("external_data")]
        public JToken ExternalData { get; set; }
    }

    public class ProjectListResponse
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("contents")]
        public ProjectListResponseContentsTypeItem[] Contents { get; set; }
    }

    public class ProjectListResponseContentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool CanBeDownloaded { get; set; }

        [JsonProperty("preview_new")]
        public string PreviewNew { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("consultable")]
        public bool Consultable { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("pt_note")]
        public double PtNote { get; set; }

        [JsonProperty("pt_accuracy")]
        public string PtAccuracy { get; set; }

        [JsonProperty("pt_won")]
        public bool PtWon { get; set; }

        [JsonProperty("vcard_id")]
        public int VcardId { get; set; }

        [JsonProperty("email_cible")]
        public string[] EmailCible { get; set; }

        [JsonProperty("alert_on")]
        public bool AlertOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("last_sign_in_at")]
        public string LastSignInAt { get; set; }

        [JsonProperty("first_access_at")]
        public string FirstAccessAt { get; set; }

        [JsonProperty("collaborators_count")]
        public int CollaboratorsCount { get; set; }

        [JsonProperty("convert_status")]
        public ProjectListResponseContentsTypeItemConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("nb_connections")]
        public int NbConnections { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("leader_first_name")]
        public string LeaderFirstName { get; set; }

        [JsonProperty("leader_last_name")]
        public string LeaderLastName { get; set; }

        [JsonProperty("leader_id")]
        public int LeaderId { get; set; }

        [JsonProperty("leader_email")]
        public string LeaderEmail { get; set; }

        [JsonProperty("leader_avatar")]
        public string LeaderAvatar { get; set; }

        [JsonProperty("tokens_count")]
        public int TokensCount { get; set; }

        [JsonProperty("project_items_count")]
        public int ProjectItemsCount { get; set; }

        [JsonProperty("nb_used_as_template")]
        public int NbUsedAsTemplate { get; set; }

        [JsonProperty("email_templates_count")]
        public int EmailTemplatesCount { get; set; }

        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }
    }

    public class ProjectListResponseContentsTypeItemConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }
    }

    public class ProjectGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("consultable")]
        public bool Consultable { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool CanBeDownloaded { get; set; }

        [JsonProperty("preview_new")]
        public string PreviewNew { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("vcard_id")]
        public int VcardId { get; set; }

        [JsonProperty("email_cible")]
        public string[] EmailCible { get; set; }

        [JsonProperty("alert_on")]
        public bool AlertOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("last_sign_in_at")]
        public string LastSignInAt { get; set; }

        [JsonProperty("first_access_at")]
        public string FirstAccessAt { get; set; }

        [JsonProperty("collaborators_count")]
        public int CollaboratorsCount { get; set; }

        [JsonProperty("convert_status")]
        public ProjectGetResponseConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("nb_connections")]
        public int NbConnections { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("theme")]
        public ProjectGetResponseThemeType Theme { get; set; }

        [JsonProperty("iframes")]
        public ProjectGetResponseIframesType Iframes { get; set; }

        [JsonProperty("tokens_count")]
        public int TokensCount { get; set; }

        [JsonProperty("project_items_count")]
        public int ProjectItemsCount { get; set; }

        [JsonProperty("nb_used_as_template")]
        public int NbUsedAsTemplate { get; set; }

        [JsonProperty("email_templates_count")]
        public int EmailTemplatesCount { get; set; }
    }

    public class ProjectGetResponseConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }
    }

    public class ProjectGetResponseThemeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponseIframesType
    {
        [JsonProperty("project_escape")]
        public string ProjectEscape { get; set; }

        [JsonProperty("tokens_escape")]
        public string TokensEscape { get; set; }

        [JsonProperty("stats_escape")]
        public string StatsEscape { get; set; }
    }

    public class ProjectUpdateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("consultable")]
        public bool Consultable { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool CanBeDownloaded { get; set; }

        [JsonProperty("preview_new")]
        public string PreviewNew { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("vcard_id")]
        public int VcardId { get; set; }

        [JsonProperty("email_cible")]
        public string[] EmailCible { get; set; }

        [JsonProperty("alert_on")]
        public bool AlertOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("last_sign_in_at")]
        public string LastSignInAt { get; set; }

        [JsonProperty("first_access_at")]
        public string FirstAccessAt { get; set; }

        [JsonProperty("collaborators_count")]
        public int CollaboratorsCount { get; set; }

        [JsonProperty("convert_status")]
        public ProjectUpdateResponseConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("nb_connections")]
        public int NbConnections { get; set; }

        [JsonProperty("total_time")]
        public int TotalTime { get; set; }

        [JsonProperty("theme")]
        public ProjectUpdateResponseThemeType Theme { get; set; }

        [JsonProperty("tokens_count")]
        public int TokensCount { get; set; }

        [JsonProperty("project_items_count")]
        public int ProjectItemsCount { get; set; }

        [JsonProperty("nb_used_as_template")]
        public int NbUsedAsTemplate { get; set; }

        [JsonProperty("email_templates_count")]
        public int EmailTemplatesCount { get; set; }
    }

    public class ProjectUpdateResponseConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }
    }

    public class ProjectUpdateResponseThemeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectUpdateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("can_be_downloaded")]
        public bool? CanBeDownloaded { get; set; }

        [JsonProperty("consultable")]
        public bool? Consultable { get; set; }

        [JsonProperty("consultable_until")]
        public string ConsultableUntil { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("starred")]
        public bool? Starred { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("verdict")]
        public ProjectUpdateInputVerdictType? Verdict { get; set; }

        [JsonProperty("collaborators")]
        public JToken[] Collaborators { get; set; }

        [JsonProperty("is_template")]
        public bool? IsTemplate { get; set; }

        [JsonProperty("vcard_id")]
        public int? VcardId { get; set; }

        [JsonProperty("alert_on")]
        public bool? AlertOn { get; set; }

        [JsonProperty("email_cible")]
        public string[] EmailCible { get; set; }

        [JsonProperty("theme")]
        public ProjectUpdateInputThemeType Theme { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProjectUpdateInputVerdictType
    {
        [EnumMember(Value = "won")]
        Won,
        [EnumMember(Value = "lost")]
        Lost,
        [EnumMember(Value = "na")]
        Na,
        [EnumMember(Value = "nc")]
        Nc
    }

    public class ProjectUpdateInputThemeType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class AccessLinkCreateResponse
    {
        [JsonProperty("contents")]
        public AccessLinkCreateResponseContentsTypeItem[] Contents { get; set; }
    }

    public class AccessLinkCreateResponseContentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    public class AccessLinkCreateInput
    {
        [JsonProperty("persons")]
        public AccessLinkCreateInputAccessLinkTypeItem[] AccessLink { get; set; }
    }

    public class AccessLinkCreateInputAccessLinkTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("external_data")]
        public JToken ExternalData { get; set; }
    }

    public class AddItemToProjectResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("element_id")]
        public int ElementId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty("item")]
        public AddItemToProjectResponseItemItemType Item { get; set; }
    }

    public class AddItemToProjectResponseItemItemType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usable")]
        public bool Usable { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("file_version")]
        public int FileVersion { get; set; }

        [JsonProperty("replaced_at")]
        public string ReplacedAt { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("num_pages")]
        public int NumPages { get; set; }

        [JsonProperty("convert_status")]
        public AddItemToProjectResponseItemItemTypeConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class AddItemToProjectResponseItemItemTypeConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }

        [JsonProperty("status")]
        public string[] Status { get; set; }
    }

    public class AddItemToProjectInput
    {
        [JsonProperty("items")]
        public AddItemToProjectInputItemsTypeItem[] Items { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "ProjectItem";
    }

    public class AddItemToProjectInputItemsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("downloadable")]
        public bool? Downloadable { get; set; }

        [JsonProperty("signable")]
        public bool? Signable { get; set; }

        [JsonProperty("watermark")]
        public string Watermark { get; set; }
    }

    public class ItemListResponse
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("contents")]
        public ItemListResponseContentsTypeItem[] Contents { get; set; }
    }

    public class ItemListResponseContentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usable")]
        public bool Usable { get; set; }

        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("file_version")]
        public int FileVersion { get; set; }

        [JsonProperty("num_pages")]
        public int NumPages { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("replaced_at")]
        public string ReplacedAt { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("convert_status")]
        public ItemListResponseContentsTypeItemConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("owner")]
        public ItemListResponseContentsTypeItemOwnerType Owner { get; set; }

        [JsonProperty("projects")]
        public ItemListResponseContentsTypeItemProjectsTypeItem[] Projects { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("thumbnail_page_url")]
        public string ThumbnailPageUrl { get; set; }
    }

    public class ItemListResponseContentsTypeItemConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }

        [JsonProperty("status")]
        public string[] Status { get; set; }
    }

    public class ItemListResponseContentsTypeItemOwnerType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class ItemListResponseContentsTypeItemProjectsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }
    }

    public class ItemCreateResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usable")]
        public bool Usable { get; set; }

        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("file_version")]
        public int FileVersion { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("replaced_at")]
        public string ReplacedAt { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("convert_status")]
        public ItemCreateResponseItemConvertStatusType ConvertStatus { get; set; }

        [JsonProperty("owner")]
        public ItemCreateResponseItemOwnerType Owner { get; set; }
    }

    public class ItemCreateResponseItemConvertStatusType
    {
        [JsonProperty("complete_base")]
        public bool CompleteBase { get; set; }

        [JsonProperty("complete_full")]
        public bool CompleteFull { get; set; }

        [JsonProperty("status")]
        public JToken[] Status { get; set; }
    }

    public class ItemCreateResponseItemOwnerType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("type")]
        public bodyInputItemTypeType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("s3_url")]
        public string S3Url { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyInputItemTypeType
    {
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "link")]
        Link
    }

    public class DirectUploadInformationResponse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("acl")]
        public string Acl { get; set; }

        [JsonProperty("policy")]
        public string Policy { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }
        public string AWSAccessKeyId { get; set; }

        [JsonProperty("success_action_status")]
        public string SuccessActionStatus { get; set; }

        [JsonProperty("s3_endpoint")]
        public string S3Endpoint { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OnTilkeeEventInput
    {
        [JsonProperty("rule", DefaultValueHandling = DefaultValueHandling.Include)]
        public OnTilkeeEventInputRuleType Rule { get; set; } = OnTilkeeEventInputRuleType.ConnexionEnded;

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "Webhook";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnTilkeeEventInputRuleType
    {
        [EnumMember(Value = "connexion_started")]
        ConnexionStarted,
        [EnumMember(Value = "connexion_ended")]
        ConnexionEnded,
        [EnumMember(Value = "token_signed")]
        TokenSigned,
        [EnumMember(Value = "token_created")]
        TokenCreated,
        [EnumMember(Value = "project_archived")]
        ProjectArchived,
        [EnumMember(Value = "unactivated_project_accessed")]
        UnactivatedProjectAccessed,
        [EnumMember(Value = "user_created")]
        UserCreated
    }

    public class OnTilkeeEventEndedInput
    {
        [JsonProperty("rule", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Rule { get; set; } = "connexion_ended";

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "Webhook";
    }

    public class OnTilkeeEventSignedInput
    {
        [JsonProperty("rule", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Rule { get; set; } = "token_signed";

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Target { get; set; } = "Webhook";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tilkee;

    public partial class WorkflowManagedActions
    {
        public TilkeeActions Tilkee(string connectionId) => new TilkeeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TilkeeTriggers Tilkee(string connectionId) => new TilkeeTriggers(connectionId);
    }
}