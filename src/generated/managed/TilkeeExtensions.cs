//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tilkee
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TilkeeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectListResponse> ProjectList(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> order, Expression<Func<bool>> isTemplate, Expression<Func<bool>> isOwner, Expression<Func<string>> tags = null, Expression<Func<string>> tagOperator = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            callPayload.Queries["order"] = ExpressionConverter.Convert(order);
            callPayload.Queries["is_template"] = ExpressionConverter.Convert(isTemplate);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (tagOperator != null)
                callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(tagOperator);
            callPayload.Queries["is_owner"] = ExpressionConverter.Convert(isOwner);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<ProjectListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectGetResponse> ProjectGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["iframe_url"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<ProjectGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ProjectUpdateResponse> ProjectUpdate(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodycanBeDownloaded = null, Expression<Func<bool>> bodyconsultable = null, Expression<Func<string>> bodyconsultableUntil = null, Expression<Func<string>> bodyduration = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<bool>> bodystarred = null, Expression<Func<string[]>> bodytags = null, Expression<Func<bodyverdictInput>> bodyverdict = null, Expression<Func<JToken[]>> bodycollaborators = null, Expression<Func<bool>> bodyisTemplate = null, Expression<Func<int>> bodyvcardId = null, Expression<Func<bool>> bodyalertOn = null, Expression<Func<string[]>> bodyemailCible = null, Expression<Func<int>> bodythemeid = null)
        {
            var apiCallPath = String.Format("/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycanBeDownloaded != null)
            {
                body["can_be_downloaded"] = ExpressionConverter.ConvertO(bodycanBeDownloaded);
                bodypropCount++;
            }

            if (bodyconsultable != null)
            {
                body["consultable"] = ExpressionConverter.ConvertO(bodyconsultable);
                bodypropCount++;
            }

            if (bodyconsultableUntil != null)
            {
                body["consultable_until"] = ExpressionConverter.ConvertO(bodyconsultableUntil);
                bodypropCount++;
            }

            if (bodyduration != null)
            {
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                bodypropCount++;
            }

            if (bodyexternalId != null)
            {
                body["external_id"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            if (bodystarred != null)
            {
                body["starred"] = ExpressionConverter.ConvertO(bodystarred);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodyverdict != null)
            {
                body["verdict"] = ExpressionConverter.ConvertO(bodyverdict);
                bodypropCount++;
            }

            if (bodycollaborators != null)
            {
                body["collaborators"] = ExpressionConverter.ConvertO(bodycollaborators);
                bodypropCount++;
            }

            if (bodyisTemplate != null)
            {
                body["is_template"] = ExpressionConverter.ConvertO(bodyisTemplate);
                bodypropCount++;
            }

            if (bodyvcardId != null)
            {
                body["vcard_id"] = ExpressionConverter.ConvertO(bodyvcardId);
                bodypropCount++;
            }

            if (bodyalertOn != null)
            {
                body["alert_on"] = ExpressionConverter.ConvertO(bodyalertOn);
                bodypropCount++;
            }

            if (bodyemailCible != null)
            {
                body["email_cible"] = ExpressionConverter.ConvertO(bodyemailCible);
                bodypropCount++;
            }

            var themeObject = new JObject();
            var themeObjectpropCount = 0;
            if (bodythemeid != null)
            {
                themeObject["id"] = ExpressionConverter.ConvertO(bodythemeid);
                themeObjectpropCount++;
            }

            if (themeObjectpropCount > 0)
            {
                body["theme"] = themeObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProjectUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<AccessLinkCreateResponse> AccessLinkCreate(Expression<Func<string>> projectId, Expression<Func<bodyaccessLinkInputItem[]>> bodyaccessLink = null)
        {
            var apiCallPath = String.Format("/projects/{0}/tokens", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaccessLink != null)
            {
                body["persons"] = ExpressionConverter.ConvertO(bodyaccessLink);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AccessLinkCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<AddItemToProjectResponseItem[]> AddItemToProject(Expression<Func<string>> projectId, Expression<Func<bodyitemsInputItem[]>> bodyitems = null)
        {
            var apiCallPath = String.Format("/projects/{0}/add_items", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyitems != null)
            {
                body["items"] = ExpressionConverter.ConvertO(bodyitems);
                bodypropCount++;
            }

            body["type"] = "ProjectItem";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddItemToProjectResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ItemListResponse> ItemList(Expression<Func<int>> limit, Expression<Func<int>> offset, Expression<Func<string>> tags = null, Expression<Func<string>> tagOperator = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/items";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (tagOperator != null)
                callPayload.Queries["tagOperator"] = ExpressionConverter.Convert(tagOperator);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<ItemListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<ItemCreateResponseItem[]> ItemCreate(Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = "/items";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<ItemCreateResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tilkee")]
        public IBodyWorkflowAction<DirectUploadInformationResponse> DirectUploadInformation(Expression<Func<string>> filename, Expression<Func<string>> originalFilename, Expression<Func<bool>> checkExisting = null)
        {
            var apiCallPath = "/direct_upload_data";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["original_filename"] = ExpressionConverter.Convert(originalFilename);
            if (checkExisting != null)
                callPayload.Queries["check_existing"] = ExpressionConverter.Convert(checkExisting);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            return new ApiConnectionAction<DirectUploadInformationResponse>(callPayload);
        }
    }

    public class TilkeeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> OnTilkeeEvent(Expression<Func<bodyruleInput>> bodyrule, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyprojectId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/notifications";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["rule"] = ExpressionConverter.ConvertO(bodyrule);
            if (bodyuserId != null)
            {
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["target"] = "Webhook";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnTilkeeEventEnded(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyprojectId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/notifications/connexion_ended";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["rule"] = "connexion_ended";
            bodypropCount++;
            if (bodyuserId != null)
            {
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["target"] = "Webhook";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnTilkeeEventSigned(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyprojectId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/notifications/token_signed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["x_tilk_ref"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["rule"] = "token_signed";
            bodypropCount++;
            if (bodyuserId != null)
            {
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["target"] = "Webhook";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }
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

    public enum bodyverdictInput
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

    public class bodyaccessLinkInputItem
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

    public class bodyitemsInputItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }

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

    public enum bodyruleInput
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