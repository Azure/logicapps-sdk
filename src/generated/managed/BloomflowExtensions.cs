//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bloomflow
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BloomflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIGetItemsReferenceResponse, ApiConnectionActionConfiguration> PublicAPIGetItemsReference(Expression<Func<string>> bloomflowApiUrl)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            return new DeferredBodyAction<PublicAPIGetItemsReferenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/public/items/reference_data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPIGetItemsReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPISearchItemsResponse, ApiConnectionActionConfiguration> PublicAPISearchItems(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> typology, Expression<Func<string>> term = null, Expression<Func<string>> fields = null, Expression<Func<string>> tags = null, Expression<Func<string>> labels = null, Expression<Func<string>> sources = null, Expression<Func<string>> updatedAtGt = null, Expression<Func<string>> updatedAtLt = null, Expression<Func<double>> limit = null, Expression<Func<double>> offset = null, Expression<Func<SortInput>> sort = null)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_typology = WorkflowExpression.Compile(typology, nameof(typology), required: true);
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_labels = WorkflowExpression.Compile(labels, nameof(labels), required: false);
            var __workflow_sources = WorkflowExpression.Compile(sources, nameof(sources), required: false);
            var __workflow_updatedAtGt = WorkflowExpression.Compile(updatedAtGt, nameof(updatedAtGt), required: false);
            var __workflow_updatedAtLt = WorkflowExpression.Compile(updatedAtLt, nameof(updatedAtLt), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<PublicAPISearchItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/public/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["typology"] = ExpressionConverter.Convert(__workflow_typology);
                if (__workflow_term != null)
                    callPayload.Queries["term"] = ExpressionConverter.Convert(__workflow_term);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_labels != null)
                    callPayload.Queries["labels"] = ExpressionConverter.Convert(__workflow_labels);
                if (__workflow_sources != null)
                    callPayload.Queries["sources"] = ExpressionConverter.Convert(__workflow_sources);
                if (__workflow_updatedAtGt != null)
                    callPayload.Queries["updated_at_gt"] = ExpressionConverter.Convert(__workflow_updatedAtGt);
                if (__workflow_updatedAtLt != null)
                    callPayload.Queries["updated_at_lt"] = ExpressionConverter.Convert(__workflow_updatedAtLt);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPISearchItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIAddItemResponse, ApiConnectionActionConfiguration> PublicAPIAddItem(Expression<Func<string>> bloomflowApiUrl, Expression<Func<PublicAPIAddItemBodyInput>> body, Expression<Func<SyncModeInput>> syncMode = null)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_syncMode = WorkflowExpression.Compile(syncMode, nameof(syncMode), required: false);
            return new DeferredBodyAction<PublicAPIAddItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/public/items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_syncMode != null)
                    callPayload.Queries["sync_mode"] = ExpressionConverter.Convert(__workflow_syncMode);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PublicAPIAddItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIGetItemResponse, ApiConnectionActionConfiguration> PublicAPIGetItem(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> id)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PublicAPIGetItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/items/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPIGetItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIUpdateItemResponse, ApiConnectionActionConfiguration> PublicAPIUpdateItem(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> id, Expression<Func<PublicAPIUpdateItemBodyInput>> body)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PublicAPIUpdateItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/items/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PublicAPIUpdateItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIGetItemDocumentsResponseItem[], ApiConnectionActionConfiguration> PublicAPIGetItemDocuments(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> id)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PublicAPIGetItemDocumentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/items/{0}/documents", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPIGetItemDocumentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIGetItemNotesResponseItem[], ApiConnectionActionConfiguration> PublicAPIGetItemNotes(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> id)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PublicAPIGetItemNotesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/items/{0}/notes", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPIGetItemNotesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIAddItemNoteResponse, ApiConnectionActionConfiguration> PublicAPIAddItemNote(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> id, Expression<Func<PublicAPIAddItemNoteBodyInput>> body)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PublicAPIAddItemNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/items/{0}/notes", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PublicAPIAddItemNoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPICreateApplicationResponse, ApiConnectionActionConfiguration> PublicAPICreateApplication(Expression<Func<string>> applicationFormId, Expression<Func<DataInput>> data)
        {
            var __workflow_applicationFormId = WorkflowExpression.Compile(applicationFormId, nameof(applicationFormId), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<PublicAPICreateApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/application-forms/{0}", __workflow_applicationFormId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<PublicAPICreateApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIGetUsersReferenceResponse, ApiConnectionActionConfiguration> PublicAPIGetUsersReference(Expression<Func<string>> bloomflowApiUrl)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            return new DeferredBodyAction<PublicAPIGetUsersReferenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/public/users/reference_data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPIGetUsersReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPISearchUsersResponseItem[], ApiConnectionActionConfiguration> PublicAPISearchUsers(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> provisionningId = null, Expression<Func<string>> id = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> username = null, Expression<Func<string>> linkedin = null, Expression<Func<string>> job = null, Expression<Func<string>> localisation = null, Expression<Func<string>> phone = null, Expression<Func<string>> businessUnit = null, Expression<Func<string>> defaultLanguage = null, Expression<Func<string>> email = null, Expression<Func<string>> role = null, Expression<Func<double>> limit = null, Expression<Func<double>> offset = null)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_provisionningId = WorkflowExpression.Compile(provisionningId, nameof(provisionningId), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: false);
            var __workflow_linkedin = WorkflowExpression.Compile(linkedin, nameof(linkedin), required: false);
            var __workflow_job = WorkflowExpression.Compile(job, nameof(job), required: false);
            var __workflow_localisation = WorkflowExpression.Compile(localisation, nameof(localisation), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_businessUnit = WorkflowExpression.Compile(businessUnit, nameof(businessUnit), required: false);
            var __workflow_defaultLanguage = WorkflowExpression.Compile(defaultLanguage, nameof(defaultLanguage), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_role = WorkflowExpression.Compile(role, nameof(role), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<PublicAPISearchUsersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/public/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_provisionningId != null)
                    callPayload.Queries["provisionning_id"] = ExpressionConverter.Convert(__workflow_provisionningId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_firstName != null)
                    callPayload.Queries["firstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["lastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_username != null)
                    callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                if (__workflow_linkedin != null)
                    callPayload.Queries["linkedin"] = ExpressionConverter.Convert(__workflow_linkedin);
                if (__workflow_job != null)
                    callPayload.Queries["job"] = ExpressionConverter.Convert(__workflow_job);
                if (__workflow_localisation != null)
                    callPayload.Queries["localisation"] = ExpressionConverter.Convert(__workflow_localisation);
                if (__workflow_phone != null)
                    callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_businessUnit != null)
                    callPayload.Queries["business_unit"] = ExpressionConverter.Convert(__workflow_businessUnit);
                if (__workflow_defaultLanguage != null)
                    callPayload.Queries["default_language"] = ExpressionConverter.Convert(__workflow_defaultLanguage);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_role != null)
                    callPayload.Queries["role"] = ExpressionConverter.Convert(__workflow_role);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPISearchUsersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIAddUserResponse, ApiConnectionActionConfiguration> PublicAPIAddUser(Expression<Func<string>> bloomflowApiUrl, Expression<Func<PublicAPIAddUserBodyInput>> body)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PublicAPIAddUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/public/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PublicAPIAddUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIGetUserResponse, ApiConnectionActionConfiguration> PublicAPIGetUser(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> id)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PublicAPIGetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                return new ApiConnectionAction<PublicAPIGetUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bloomflow")]
        public IBodyWorkflowAction<PublicAPIUpdateUserResponse, ApiConnectionActionConfiguration> PublicAPIUpdateUser(Expression<Func<string>> bloomflowApiUrl, Expression<Func<string>> id, Expression<Func<PublicAPIAddUserBodyInput>> body)
        {
            var __workflow_bloomflowApiUrl = WorkflowExpression.Compile(bloomflowApiUrl, nameof(bloomflowApiUrl), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PublicAPIUpdateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/public/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["bloomflow_api_url"] = ExpressionConverter.Convert(__workflow_bloomflowApiUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PublicAPIUpdateUserResponse>(callPayload);
            });
        }
    }

    public class BloomflowTriggers([ConnectionName] string connectionId)
    {
    }

    public class PublicAPIGetItemsReferenceResponse
    {
        [JsonProperty("typologies")]
        public PublicAPIGetItemsReferenceResponseTypologiesTypeItem[] Typologies { get; set; }

        [JsonProperty("custom_fields")]
        public PublicAPIGetItemsReferenceResponseCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("fundraising_stage")]
        public string[] FundraisingStage { get; set; }

        [JsonProperty("nb_employees")]
        public string[] NbEmployees { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("market_ids")]
        public PublicAPIGetItemsReferenceResponseMarketIdsTypeItem[] MarketIds { get; set; }
    }

    public class PublicAPIGetItemsReferenceResponseTypologiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentTypologyId")]
        public string ParentTypologyId { get; set; }

        [JsonProperty("tags")]
        public PublicAPIGetItemsReferenceResponseTypologiesTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("labels")]
        public PublicAPIGetItemsReferenceResponseTypologiesTypeItemLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("sources")]
        public PublicAPIGetItemsReferenceResponseTypologiesTypeItemSourcesTypeItem[] Sources { get; set; }
    }

    public class PublicAPIGetItemsReferenceResponseTypologiesTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIGetItemsReferenceResponseTypologiesTypeItemLabelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIGetItemsReferenceResponseTypologiesTypeItemSourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIGetItemsReferenceResponseCustomFieldsTypeItem
    {
        [JsonProperty("types")]
        public string[] Types { get; set; }

        [JsonProperty("field_id")]
        public string FieldId { get; set; }
    }

    public class PublicAPIGetItemsReferenceResponseMarketIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label_FR")]
        public string LabelFR { get; set; }

        [JsonProperty("label_EN")]
        public string LabelEN { get; set; }
    }

    public class PublicAPISearchItemsResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("results")]
        public PublicAPISearchItemsResponseResultsTypeItem[] Results { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItem
    {
        [JsonProperty("typology_id")]
        public string TypologyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        [JsonProperty("tags")]
        public PublicAPISearchItemsResponseResultsTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("labels")]
        public PublicAPISearchItemsResponseResultsTypeItemLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("sources")]
        public PublicAPISearchItemsResponseResultsTypeItemSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("internal_contacts")]
        public PublicAPISearchItemsResponseResultsTypeItemInternalContactsTypeItem[] InternalContacts { get; set; }

        [JsonProperty("external_contacts")]
        public PublicAPISearchItemsResponseResultsTypeItemExternalContactsTypeItem[] ExternalContacts { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("market_ids")]
        public string[] MarketIds { get; set; }

        [JsonProperty("hq_address")]
        public string HqAddress { get; set; }

        [JsonProperty("links")]
        public PublicAPISearchItemsResponseResultsTypeItemLinksType Links { get; set; }

        [JsonProperty("press_urls")]
        public string[] PressUrls { get; set; }

        [JsonProperty("video_urls")]
        public string[] VideoUrls { get; set; }

        [JsonProperty("nb_employees")]
        public PublicAPISearchItemsResponseResultsTypeItemNbEmployeesType NbEmployees { get; set; }

        [JsonProperty("year_founded")]
        public string YearFounded { get; set; }

        [JsonProperty("total_funding_usd")]
        public string TotalFundingUsd { get; set; }

        [JsonProperty("fundraising_stage")]
        public string FundraisingStage { get; set; }

        [JsonProperty("business_model")]
        public string BusinessModel { get; set; }

        [JsonProperty("painpoints")]
        public string Painpoints { get; set; }

        [JsonProperty("business_opportunity")]
        public string BusinessOpportunity { get; set; }

        [JsonProperty("sustainability")]
        public string Sustainability { get; set; }

        [JsonProperty("success_proofs")]
        public string SuccessProofs { get; set; }

        [JsonProperty("risks")]
        public string Risks { get; set; }

        [JsonProperty("key_differentiators")]
        public string KeyDifferentiators { get; set; }

        [JsonProperty("competitors")]
        public string Competitors { get; set; }

        [JsonProperty("workflows")]
        public PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItem[] Workflows { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemLabelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemSourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemInternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public JToken Type { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemExternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemLinksType
    {
        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PublicAPISearchItemsResponseResultsTypeItemNbEmployeesType
    {
        [EnumMember(Value = "1-10")]
        _110,
        [EnumMember(Value = "11-50")]
        _1150,
        [EnumMember(Value = "50-200")]
        _50200,
        [EnumMember(Value = "200+")]
        _200
    }

    public class PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItem
    {
        [JsonProperty("current_status")]
        public PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemCurrentStatusType CurrentStatus { get; set; }

        [JsonProperty("current_state")]
        public PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemCurrentStateType CurrentState { get; set; }

        [JsonProperty("states")]
        public PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemStatesTypeItem[] States { get; set; }

        [JsonProperty("status")]
        public PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemStatusTypeItem[] Status { get; set; }

        [JsonProperty("groups")]
        public string[] Groups { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemCurrentStatusType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemCurrentStateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemStatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class PublicAPISearchItemsResponseResultsTypeItemWorkflowsTypeItemStatusTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SortInput
    {
        [EnumMember(Value = "created_at_desc")]
        CreatedAtDesc,
        [EnumMember(Value = "created_at_asc")]
        CreatedAtAsc,
        [EnumMember(Value = "updated_at_desc")]
        UpdatedAtDesc,
        [EnumMember(Value = "updated_at_asc")]
        UpdatedAtAsc,
        [EnumMember(Value = "relevance")]
        Relevance
    }

    public class PublicAPIAddItemResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class PublicAPIAddItemBodyInput
    {
        [JsonProperty("typology_id")]
        public string TypologyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        [JsonProperty("tags")]
        public BodyInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("labels")]
        public BodyInputLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("sources")]
        public BodyInputSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonProperty("internal_contacts")]
        public BodyInputInternalContactsTypeItem[] InternalContacts { get; set; }

        [JsonProperty("external_contacts")]
        public BodyInputExternalContactsTypeItem[] ExternalContacts { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("links")]
        public BodyInputLinksTypeItem[] Links { get; set; }

        [JsonProperty("market_ids")]
        public BodyInputMarketIdsTypeItem[] MarketIds { get; set; }

        [JsonProperty("hq_address")]
        public string HqAddress { get; set; }

        [JsonProperty("press_urls")]
        public string[] PressUrls { get; set; }

        [JsonProperty("video_urls")]
        public string[] VideoUrls { get; set; }

        [JsonProperty("year_founded")]
        public string YearFounded { get; set; }

        [JsonProperty("total_funding_usd")]
        public string TotalFundingUsd { get; set; }

        [JsonProperty("fundraising_stage")]
        public string FundraisingStage { get; set; }

        [JsonProperty("nb_employees")]
        public string NbEmployees { get; set; }

        [JsonProperty("business_model")]
        public string BusinessModel { get; set; }

        [JsonProperty("painpoints")]
        public string Painpoints { get; set; }

        [JsonProperty("business_opportunity")]
        public string BusinessOpportunity { get; set; }

        [JsonProperty("sustainability")]
        public string Sustainability { get; set; }

        [JsonProperty("success_proofs")]
        public string SuccessProofs { get; set; }

        [JsonProperty("risks")]
        public string Risks { get; set; }

        [JsonProperty("key_differentiators")]
        public string KeyDifferentiators { get; set; }

        [JsonProperty("competitors")]
        public string Competitors { get; set; }

        [JsonProperty("custom_fields")]
        public BodyInputCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("sync_origin_id")]
        public string SyncOriginId { get; set; }

        [JsonProperty("sync_origin_url")]
        public string SyncOriginUrl { get; set; }

        [JsonProperty("sync_origin_user_id")]
        public string SyncOriginUserId { get; set; }

        [JsonProperty("sync_origin_user_first_name")]
        public string SyncOriginUserFirstName { get; set; }

        [JsonProperty("sync_origin_user_last_name")]
        public string SyncOriginUserLastName { get; set; }

        [JsonProperty("sync_origin_user_email")]
        public string SyncOriginUserEmail { get; set; }
    }

    public class BodyInputTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BodyInputLabelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class BodyInputSourcesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BodyInputInternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public JToken Type { get; set; }
    }

    public class BodyInputExternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class BodyInputLinksTypeItem
    {
        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }
    }

    public class BodyInputMarketIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class BodyInputCustomFieldsTypeItem
    {
        [JsonProperty("field_id")]
        public string FieldId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SyncModeInput
    {
        [EnumMember(Value = "sync_auto")]
        SyncAuto,
        [EnumMember(Value = "sync_manual")]
        SyncManual
    }

    public class PublicAPIGetItemResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("year_founded")]
        public string YearFounded { get; set; }

        [JsonProperty("maturity")]
        public string Maturity { get; set; }

        [JsonProperty("typology_id")]
        public string TypologyId { get; set; }

        [JsonProperty("tags")]
        public PublicAPIGetItemResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("labels")]
        public PublicAPIGetItemResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("business_model")]
        public string BusinessModel { get; set; }

        [JsonProperty("painpoints")]
        public string Painpoints { get; set; }

        [JsonProperty("business_opportunity")]
        public string BusinessOpportunity { get; set; }

        [JsonProperty("sustainability")]
        public string Sustainability { get; set; }

        [JsonProperty("success_proofs")]
        public string SuccessProofs { get; set; }

        [JsonProperty("risks")]
        public string Risks { get; set; }

        [JsonProperty("key_differentiators")]
        public string KeyDifferentiators { get; set; }

        [JsonProperty("competitors")]
        public string Competitors { get; set; }

        [JsonProperty("market_ids")]
        public string[] MarketIds { get; set; }

        [JsonProperty("scoring_value")]
        public int ScoringValue { get; set; }

        [JsonProperty("scoring_summary")]
        public string ScoringSummary { get; set; }

        [JsonProperty("links")]
        public PublicAPIGetItemResponseLinksType Links { get; set; }

        [JsonProperty("press_urls")]
        public string[] PressUrls { get; set; }

        [JsonProperty("video_urls")]
        public string[] VideoUrls { get; set; }

        [JsonProperty("related_items")]
        public PublicAPIGetItemResponseRelatedItemsTypeItem[] RelatedItems { get; set; }

        [JsonProperty("internal_contacts")]
        public PublicAPIGetItemResponseInternalContactsTypeItem[] InternalContacts { get; set; }

        [JsonProperty("external_contacts")]
        public PublicAPIGetItemResponseExternalContactsTypeItem[] ExternalContacts { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("hq_address")]
        public string HqAddress { get; set; }

        [JsonProperty("nb_employees")]
        public PublicAPIGetItemResponseNbEmployeesType NbEmployees { get; set; }

        [JsonProperty("total_funding_usd")]
        public string TotalFundingUsd { get; set; }

        [JsonProperty("fundraising_stage")]
        public string FundraisingStage { get; set; }

        [JsonProperty("custom_fields")]
        public PublicAPIGetItemResponseCustomFieldsType CustomFields { get; set; }

        [JsonProperty("fundings")]
        public PublicAPIGetItemResponseFundingsTypeItem[] Fundings { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class PublicAPIGetItemResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class PublicAPIGetItemResponseLabelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIGetItemResponseLinksType
    {
        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }
    }

    public class PublicAPIGetItemResponseRelatedItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIGetItemResponseInternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public JToken Type { get; set; }
    }

    public class PublicAPIGetItemResponseExternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PublicAPIGetItemResponseNbEmployeesType
    {
        [EnumMember(Value = "1-10")]
        _110,
        [EnumMember(Value = "11-50")]
        _1150,
        [EnumMember(Value = "50-200")]
        _50200,
        [EnumMember(Value = "200+")]
        _200
    }

    public class PublicAPIGetItemResponseCustomFieldsType
    {
        [JsonProperty("sourcing_partner_field")]
        public string SourcingPartnerField { get; set; }
    }

    public class PublicAPIGetItemResponseFundingsTypeItem
    {
        [JsonProperty("investors")]
        public string Investors { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }

    public class PublicAPIUpdateItemResponse
    {
        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        [JsonProperty("tags")]
        public PublicAPIUpdateItemResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("labels")]
        public JToken[] Labels { get; set; }

        [JsonProperty("sources")]
        public PublicAPIUpdateItemResponseSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("internal_contacts")]
        public PublicAPIUpdateItemResponseInternalContactsTypeItem[] InternalContacts { get; set; }

        [JsonProperty("external_contacts")]
        public PublicAPIUpdateItemResponseExternalContactsTypeItem[] ExternalContacts { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("links")]
        public PublicAPIUpdateItemResponseLinksType Links { get; set; }

        [JsonProperty("market_ids")]
        public string[] MarketIds { get; set; }

        [JsonProperty("hq_address")]
        public string HqAddress { get; set; }

        [JsonProperty("press_urls")]
        public string[] PressUrls { get; set; }

        [JsonProperty("video_urls")]
        public string[] VideoUrls { get; set; }

        [JsonProperty("nb_employees")]
        public string NbEmployees { get; set; }

        [JsonProperty("year_founded")]
        public string YearFounded { get; set; }

        [JsonProperty("total_funding_usd")]
        public int TotalFundingUsd { get; set; }

        [JsonProperty("fundraising_stage")]
        public string FundraisingStage { get; set; }

        [JsonProperty("business_model")]
        public string BusinessModel { get; set; }

        [JsonProperty("painpoints")]
        public string Painpoints { get; set; }

        [JsonProperty("business_opportunity")]
        public string BusinessOpportunity { get; set; }

        [JsonProperty("sustainability")]
        public string Sustainability { get; set; }

        [JsonProperty("success_proofs")]
        public string SuccessProofs { get; set; }

        [JsonProperty("risks")]
        public string Risks { get; set; }

        [JsonProperty("key_differentiators")]
        public string KeyDifferentiators { get; set; }

        [JsonProperty("competitors")]
        public string Competitors { get; set; }

        [JsonProperty("related_items")]
        public JToken[] RelatedItems { get; set; }

        [JsonProperty("custom_fields")]
        public PublicAPIUpdateItemResponseCustomFieldsType CustomFields { get; set; }

        [JsonProperty("fundings")]
        public JToken[] Fundings { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class PublicAPIUpdateItemResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class PublicAPIUpdateItemResponseSourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIUpdateItemResponseInternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public JToken Type { get; set; }
    }

    public class PublicAPIUpdateItemResponseExternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class PublicAPIUpdateItemResponseLinksType
    {
        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }
    }

    public class PublicAPIUpdateItemResponseCustomFieldsType
    {
        [JsonProperty("sourcing_partner_field")]
        public string SourcingPartnerField { get; set; }
    }

    public class PublicAPIUpdateItemBodyInput
    {
        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        [JsonProperty("tags")]
        public BodyInputTagsTypeItem[] Tags { get; set; }

        [JsonProperty("labels")]
        public BodyInputLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("sources")]
        public BodyInputSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonProperty("internal_contacts")]
        public BodyInputInternalContactsTypeItem[] InternalContacts { get; set; }

        [JsonProperty("external_contacts")]
        public BodyInputExternalContactsTypeItem[] ExternalContacts { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("links")]
        public BodyInputLinksTypeItem[] Links { get; set; }

        [JsonProperty("market_ids")]
        public BodyInputMarketIdsTypeItem[] MarketIds { get; set; }

        [JsonProperty("hq_address")]
        public string HqAddress { get; set; }

        [JsonProperty("press_urls")]
        public string[] PressUrls { get; set; }

        [JsonProperty("video_urls")]
        public string[] VideoUrls { get; set; }

        [JsonProperty("year_founded")]
        public string YearFounded { get; set; }

        [JsonProperty("total_funding_usd")]
        public int? TotalFundingUsd { get; set; }

        [JsonProperty("fundraising_stage")]
        public string FundraisingStage { get; set; }

        [JsonProperty("nb_employees")]
        public string NbEmployees { get; set; }

        [JsonProperty("business_model")]
        public string BusinessModel { get; set; }

        [JsonProperty("painpoints")]
        public string Painpoints { get; set; }

        [JsonProperty("business_opportunity")]
        public string BusinessOpportunity { get; set; }

        [JsonProperty("sustainability")]
        public string Sustainability { get; set; }

        [JsonProperty("success_proofs")]
        public string SuccessProofs { get; set; }

        [JsonProperty("risks")]
        public string Risks { get; set; }

        [JsonProperty("key_differentiators")]
        public string KeyDifferentiators { get; set; }

        [JsonProperty("competitors")]
        public string Competitors { get; set; }

        [JsonProperty("custom_fields")]
        public BodyInputCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class PublicAPIGetItemDocumentsResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("isExternal")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }

    public class PublicAPIGetItemNotesResponseItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("confidential")]
        public bool Confidential { get; set; }

        [JsonProperty("userMentions")]
        public JToken[] UserMentions { get; set; }

        [JsonProperty("isAutomatic")]
        public bool IsAutomatic { get; set; }

        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("parentTypologyId")]
        public string ParentTypologyId { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIAddItemNoteResponse
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("confidential")]
        public bool Confidential { get; set; }

        [JsonProperty("userMentions")]
        public JToken[] UserMentions { get; set; }

        [JsonProperty("isAutomatic")]
        public bool IsAutomatic { get; set; }

        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("parentTypologyId")]
        public string ParentTypologyId { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIAddItemNoteBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class PublicAPICreateApplicationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DataInput
    {
        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("pitch")]
        public string Pitch { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("year_founded")]
        public string YearFounded { get; set; }

        [JsonProperty("hq_city")]
        public string HqCity { get; set; }

        [JsonProperty("hq_countryId")]
        public string HqCountryId { get; set; }

        [JsonProperty("nb_employees")]
        public string NbEmployees { get; set; }

        [JsonProperty("maturity")]
        public string Maturity { get; set; }

        [JsonProperty("tagIds")]
        public DataInputTagIdsTypeItem[] TagIds { get; set; }

        [JsonProperty("external_contacts")]
        public DataInputExternalContactsTypeItem[] ExternalContacts { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("video_urls")]
        public string[] VideoUrls { get; set; }

        [JsonProperty("press")]
        public string[] Press { get; set; }

        [JsonProperty("business_model")]
        public string BusinessModel { get; set; }

        [JsonProperty("marketIds")]
        public string[] MarketIds { get; set; }

        [JsonProperty("competitors")]
        public string Competitors { get; set; }

        [JsonProperty("note_collaboration")]
        public string NoteCollaboration { get; set; }

        [JsonProperty("internal_contacts")]
        public DataInputInternalContactsTypeItem[] InternalContacts { get; set; }

        [JsonProperty("note_service")]
        public string NoteService { get; set; }

        [JsonProperty("note_department")]
        public string NoteDepartment { get; set; }
    }

    public class DataInputTagIdsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DataInputExternalContactsTypeItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class DataInputInternalContactsTypeItem
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class PublicAPIGetUsersReferenceResponse
    {
        [JsonProperty("roles")]
        public PublicAPIGetUsersReferenceResponseRolesTypeItem[] Roles { get; set; }

        [JsonProperty("user_groups")]
        public PublicAPIGetUsersReferenceResponseUserGroupsTypeItem[] UserGroups { get; set; }
    }

    public class PublicAPIGetUsersReferenceResponseRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("typologyFolderId")]
        public string TypologyFolderId { get; set; }
    }

    public class PublicAPIGetUsersReferenceResponseUserGroupsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public PublicAPIGetUsersReferenceResponseUserGroupsTypeItemRolesTypeItem[] Roles { get; set; }
    }

    public class PublicAPIGetUsersReferenceResponseUserGroupsTypeItemRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("typologyFolderId")]
        public string TypologyFolderId { get; set; }
    }

    public class PublicAPISearchUsersResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("localisation")]
        public string Localisation { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("business_unit")]
        public string BusinessUnit { get; set; }

        [JsonProperty("default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("roles")]
        public PublicAPISearchUsersResponseItemRolesTypeItem[] Roles { get; set; }

        [JsonProperty("groups")]
        public PublicAPISearchUsersResponseItemGroupsTypeItem[] Groups { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }
    }

    public class PublicAPISearchUsersResponseItemRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("typologyFolderId")]
        public string TypologyFolderId { get; set; }
    }

    public class PublicAPISearchUsersResponseItemGroupsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public PublicAPISearchUsersResponseItemGroupsTypeItemRolesTypeItem[] Roles { get; set; }
    }

    public class PublicAPISearchUsersResponseItemGroupsTypeItemRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typologyId")]
        public string TypologyId { get; set; }

        [JsonProperty("typologyFolderId")]
        public string TypologyFolderId { get; set; }
    }

    public class PublicAPIAddUserResponse
    {
        [JsonProperty("provisionning_id")]
        public string ProvisionningId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("localisation")]
        public string Localisation { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("business_unit")]
        public string BusinessUnit { get; set; }

        [JsonProperty("default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("roles")]
        public PublicAPIAddUserResponseRolesTypeItem[] Roles { get; set; }

        [JsonProperty("groups")]
        public JToken[] Groups { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }
    }

    public class PublicAPIAddUserResponseRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIAddUserBodyInput
    {
        [JsonProperty("provisionning_id")]
        public string ProvisionningId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("localisation")]
        public string Localisation { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("business_unit")]
        public string BusinessUnit { get; set; }

        [JsonProperty("default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("suspended")]
        public bool? Suspended { get; set; }
    }

    public class PublicAPIGetUserResponse
    {
        [JsonProperty("provisionning_id")]
        public string ProvisionningId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("localisation")]
        public string Localisation { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("business_unit")]
        public string BusinessUnit { get; set; }

        [JsonProperty("default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("roles")]
        public PublicAPIGetUserResponseRolesTypeItem[] Roles { get; set; }

        [JsonProperty("groups")]
        public JToken[] Groups { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }
    }

    public class PublicAPIGetUserResponseRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PublicAPIUpdateUserResponse
    {
        [JsonProperty("provisionning_id")]
        public string ProvisionningId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("localisation")]
        public string Localisation { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("business_unit")]
        public string BusinessUnit { get; set; }

        [JsonProperty("default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("roles")]
        public PublicAPIUpdateUserResponseRolesTypeItem[] Roles { get; set; }

        [JsonProperty("groups")]
        public JToken[] Groups { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }
    }

    public class PublicAPIUpdateUserResponseRolesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bloomflow;

    public partial class WorkflowManagedActions
    {
        public BloomflowActions Bloomflow(string connectionId) => new BloomflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BloomflowTriggers Bloomflow(string connectionId) => new BloomflowTriggers(connectionId);
    }
}