//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageinsightplus
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageinsightplusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetCurationPropertiesForDocumentResponse, ApiConnectionActionConfiguration> GetCurationPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<bool>> bodylatest)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodylatest = WorkflowExpression.Compile(bodylatest, nameof(bodylatest), required: true);
            return new DeferredBodyAction<GetCurationPropertiesForDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCurationPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["latest"] = ExpressionConverter.ConvertO(__workflow_bodylatest);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetCurationPropertiesForDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SetCurationPropertiesForDocumentResponseBody, ApiConnectionActionConfiguration> SetCurationPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyapprover = null, Expression<Func<string>> bodydraftingNotes = null, Expression<Func<bool>> bodyisMaintained = null, Expression<Func<string>> bodyknowledgeOwner = null, Expression<Func<string>> bodyknowledgeType = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodylastReviewDate = null, Expression<Func<string>> bodyminiSummary = null, Expression<Func<string>> bodynextReviewDate = null, Expression<Func<string>> bodyotherNoteworthy = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodysubmitDate = null, Expression<Func<string>> bodytaxonomy1 = null, Expression<Func<string>> bodytaxonomy2 = null, Expression<Func<string>> bodytaxonomy3 = null, Expression<Func<string>> bodytaxonomy4 = null, Expression<Func<string>> bodytaxonomy5 = null, Expression<Func<string>> bodysubmitter = null, Expression<Func<string>> bodysubmittedDocId = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyapprover = WorkflowExpression.Compile(bodyapprover, nameof(bodyapprover), required: false);
            var __workflow_bodydraftingNotes = WorkflowExpression.Compile(bodydraftingNotes, nameof(bodydraftingNotes), required: false);
            var __workflow_bodyisMaintained = WorkflowExpression.Compile(bodyisMaintained, nameof(bodyisMaintained), required: false);
            var __workflow_bodyknowledgeOwner = WorkflowExpression.Compile(bodyknowledgeOwner, nameof(bodyknowledgeOwner), required: false);
            var __workflow_bodyknowledgeType = WorkflowExpression.Compile(bodyknowledgeType, nameof(bodyknowledgeType), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodylastReviewDate = WorkflowExpression.Compile(bodylastReviewDate, nameof(bodylastReviewDate), required: false);
            var __workflow_bodyminiSummary = WorkflowExpression.Compile(bodyminiSummary, nameof(bodyminiSummary), required: false);
            var __workflow_bodynextReviewDate = WorkflowExpression.Compile(bodynextReviewDate, nameof(bodynextReviewDate), required: false);
            var __workflow_bodyotherNoteworthy = WorkflowExpression.Compile(bodyotherNoteworthy, nameof(bodyotherNoteworthy), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodysubmitDate = WorkflowExpression.Compile(bodysubmitDate, nameof(bodysubmitDate), required: false);
            var __workflow_bodytaxonomy1 = WorkflowExpression.Compile(bodytaxonomy1, nameof(bodytaxonomy1), required: false);
            var __workflow_bodytaxonomy2 = WorkflowExpression.Compile(bodytaxonomy2, nameof(bodytaxonomy2), required: false);
            var __workflow_bodytaxonomy3 = WorkflowExpression.Compile(bodytaxonomy3, nameof(bodytaxonomy3), required: false);
            var __workflow_bodytaxonomy4 = WorkflowExpression.Compile(bodytaxonomy4, nameof(bodytaxonomy4), required: false);
            var __workflow_bodytaxonomy5 = WorkflowExpression.Compile(bodytaxonomy5, nameof(bodytaxonomy5), required: false);
            var __workflow_bodysubmitter = WorkflowExpression.Compile(bodysubmitter, nameof(bodysubmitter), required: false);
            var __workflow_bodysubmittedDocId = WorkflowExpression.Compile(bodysubmittedDocId, nameof(bodysubmittedDocId), required: false);
            return new DeferredBodyAction<SetCurationPropertiesForDocumentResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setCurationPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (__workflow_bodyapprover != null)
                {
                    body["approver"] = ExpressionConverter.ConvertO(__workflow_bodyapprover);
                    bodypropCount++;
                }

                if (__workflow_bodydraftingNotes != null)
                {
                    body["drafting_notes"] = ExpressionConverter.ConvertO(__workflow_bodydraftingNotes);
                    bodypropCount++;
                }

                if (__workflow_bodyisMaintained != null)
                {
                    body["is_maintained"] = ExpressionConverter.ConvertO(__workflow_bodyisMaintained);
                    bodypropCount++;
                }

                if (__workflow_bodyknowledgeOwner != null)
                {
                    body["knowledge_owner"] = ExpressionConverter.ConvertO(__workflow_bodyknowledgeOwner);
                    bodypropCount++;
                }

                if (__workflow_bodyknowledgeType != null)
                {
                    body["knowledge_type"] = ExpressionConverter.ConvertO(__workflow_bodyknowledgeType);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodylastReviewDate != null)
                {
                    body["last_review_date"] = ExpressionConverter.ConvertO(__workflow_bodylastReviewDate);
                    bodypropCount++;
                }

                if (__workflow_bodyminiSummary != null)
                {
                    body["mini_summary"] = ExpressionConverter.ConvertO(__workflow_bodyminiSummary);
                    bodypropCount++;
                }

                if (__workflow_bodynextReviewDate != null)
                {
                    body["next_review_date"] = ExpressionConverter.ConvertO(__workflow_bodynextReviewDate);
                    bodypropCount++;
                }

                if (__workflow_bodyotherNoteworthy != null)
                {
                    body["other_noteworthy"] = ExpressionConverter.ConvertO(__workflow_bodyotherNoteworthy);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodysubmitDate != null)
                {
                    body["submit_date"] = ExpressionConverter.ConvertO(__workflow_bodysubmitDate);
                    bodypropCount++;
                }

                if (__workflow_bodytaxonomy1 != null)
                {
                    body["taxonomy1"] = ExpressionConverter.ConvertO(__workflow_bodytaxonomy1);
                    bodypropCount++;
                }

                if (__workflow_bodytaxonomy2 != null)
                {
                    body["taxonomy2"] = ExpressionConverter.ConvertO(__workflow_bodytaxonomy2);
                    bodypropCount++;
                }

                if (__workflow_bodytaxonomy3 != null)
                {
                    body["taxonomy3"] = ExpressionConverter.ConvertO(__workflow_bodytaxonomy3);
                    bodypropCount++;
                }

                if (__workflow_bodytaxonomy4 != null)
                {
                    body["taxonomy4"] = ExpressionConverter.ConvertO(__workflow_bodytaxonomy4);
                    bodypropCount++;
                }

                if (__workflow_bodytaxonomy5 != null)
                {
                    body["taxonomy5"] = ExpressionConverter.ConvertO(__workflow_bodytaxonomy5);
                    bodypropCount++;
                }

                if (__workflow_bodysubmitter != null)
                {
                    body["submitter"] = ExpressionConverter.ConvertO(__workflow_bodysubmitter);
                    bodypropCount++;
                }

                if (__workflow_bodysubmittedDocId != null)
                {
                    body["submitted_doc_id"] = ExpressionConverter.ConvertO(__workflow_bodysubmittedDocId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetCurationPropertiesForDocumentResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetKnowledgeTypesResponse, ApiConnectionActionConfiguration> GetKnowledgeTypes(Expression<Func<string>> libraryId)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            return new DeferredBodyAction<GetKnowledgeTypesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getKnowledgeTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                return new ApiConnectionAction<GetKnowledgeTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetCurationConfigurationResponse, ApiConnectionActionConfiguration> GetCurationConfiguration(Expression<Func<string>> libraryId)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            return new DeferredBodyAction<GetCurationConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getCurationConfiguration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                return new ApiConnectionAction<GetCurationConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SearchCurationTaxonomyNodeValuesResponse, ApiConnectionActionConfiguration> SearchCurationTaxonomyNodeValues(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodytaxonomyProperty, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyquery = null, Expression<Func<bodyenabledStateInput>> bodyenabledState = null, Expression<Func<bool>> bodyincludePath = null, Expression<Func<string>> bodychildrenOfSsid = null, Expression<Func<bool>> bodyimmediateChildrenOnly = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodytaxonomyProperty = WorkflowExpression.Compile(bodytaxonomyProperty, nameof(bodytaxonomyProperty), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            var __workflow_bodyenabledState = WorkflowExpression.Compile(bodyenabledState, nameof(bodyenabledState), required: false);
            var __workflow_bodyincludePath = WorkflowExpression.Compile(bodyincludePath, nameof(bodyincludePath), required: false);
            var __workflow_bodychildrenOfSsid = WorkflowExpression.Compile(bodychildrenOfSsid, nameof(bodychildrenOfSsid), required: false);
            var __workflow_bodyimmediateChildrenOnly = WorkflowExpression.Compile(bodyimmediateChildrenOnly, nameof(bodyimmediateChildrenOnly), required: false);
            return new DeferredBodyAction<SearchCurationTaxonomyNodeValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchCurationTaxonomyNodeValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["taxonomyProperty"] = ExpressionConverter.ConvertO(__workflow_bodytaxonomyProperty);
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledState != null)
                {
                    if (__workflow_bodyenabledState != null)
                    {
                        body["enabled_state"] = ExpressionConverter.ConvertO(__workflow_bodyenabledState);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enabled_state"] = "Enabled";
                    bodypropCount++;
                }

                if (__workflow_bodyincludePath != null)
                {
                    if (__workflow_bodyincludePath != null)
                    {
                        body["include_path"] = ExpressionConverter.ConvertO(__workflow_bodyincludePath);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_path"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodychildrenOfSsid != null)
                {
                    body["children_of_ssid"] = ExpressionConverter.ConvertO(__workflow_bodychildrenOfSsid);
                    bodypropCount++;
                }

                if (__workflow_bodyimmediateChildrenOnly != null)
                {
                    if (__workflow_bodyimmediateChildrenOnly != null)
                    {
                        body["immediate_children_only"] = ExpressionConverter.ConvertO(__workflow_bodyimmediateChildrenOnly);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["immediate_children_only"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchCurationTaxonomyNodeValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SearchKnowledgeDocumentsResponse, ApiConnectionActionConfiguration> SearchKnowledgeDocuments(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodycontainerId = null, Expression<Func<bool>> bodyincludeSubfolders = null, Expression<Func<bodysearchFiltersInputItem[]>> bodysearchFilters = null)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodycontainerId = WorkflowExpression.Compile(bodycontainerId, nameof(bodycontainerId), required: false);
            var __workflow_bodyincludeSubfolders = WorkflowExpression.Compile(bodyincludeSubfolders, nameof(bodyincludeSubfolders), required: false);
            var __workflow_bodysearchFilters = WorkflowExpression.Compile(bodysearchFilters, nameof(bodysearchFilters), required: false);
            return new DeferredBodyAction<SearchKnowledgeDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchKnowledgeDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                if (__workflow_bodycontainerId != null)
                {
                    body["container_id"] = ExpressionConverter.ConvertO(__workflow_bodycontainerId);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeSubfolders != null)
                {
                    if (__workflow_bodyincludeSubfolders != null)
                    {
                        body["include_subfolders"] = ExpressionConverter.ConvertO(__workflow_bodyincludeSubfolders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_subfolders"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodysearchFilters != null)
                {
                    body["searchFilters"] = ExpressionConverter.ConvertO(__workflow_bodysearchFilters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchKnowledgeDocumentsResponse>(callPayload);
            });
        }
    }

    public class ImanageinsightplusTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCurationPropertiesForDocumentResponse
    {
        [JsonProperty("data")]
        public GetCurationPropertiesForDocumentResponseDataType Data { get; set; }
    }

    public class GetCurationPropertiesForDocumentResponseDataType
    {
        [JsonProperty("curation")]
        public CurationProperties Curation { get; set; }

        [JsonProperty("is_latest")]
        public bool IsLatest { get; set; }

        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }
    }

    public class CurationProperties
    {
        [JsonProperty("submit_date")]
        public string SubmitDate { get; set; }

        [JsonProperty("last_review_date")]
        public string LastReviewDate { get; set; }

        [JsonProperty("next_review_date")]
        public string NextReviewDate { get; set; }

        [JsonProperty("is_maintained")]
        public bool IsMaintained { get; set; }

        [JsonProperty("drafting_notes")]
        public string DraftingNotes { get; set; }

        [JsonProperty("mini_summary")]
        public string MiniSummary { get; set; }

        [JsonProperty("taxonomy1")]
        public CurationPropertiesTaxonomy1TypeItem[] Taxonomy1 { get; set; }

        [JsonProperty("taxonomy2")]
        public CurationPropertiesTaxonomy2TypeItem[] Taxonomy2 { get; set; }

        [JsonProperty("taxonomy3")]
        public CurationPropertiesTaxonomy3TypeItem[] Taxonomy3 { get; set; }

        [JsonProperty("taxonomy4")]
        public CurationPropertiesTaxonomy4TypeItem[] Taxonomy4 { get; set; }

        [JsonProperty("taxonomy5")]
        public CurationPropertiesTaxonomy5TypeItem[] Taxonomy5 { get; set; }

        [JsonProperty("all_taxonomy1_ssids")]
        public string AllTaxonomy1Ssids { get; set; }

        [JsonProperty("all_taxonomy2_ssids")]
        public string AllTaxonomy2Ssids { get; set; }

        [JsonProperty("all_taxonomy3_ssids")]
        public string AllTaxonomy3Ssids { get; set; }

        [JsonProperty("all_taxonomy4_ssids")]
        public string AllTaxonomy4Ssids { get; set; }

        [JsonProperty("all_taxonomy5_ssids")]
        public string AllTaxonomy5Ssids { get; set; }

        [JsonProperty("knowledge_type")]
        public CurationPropertiesKnowledgeTypeTypeItem[] KnowledgeType { get; set; }

        [JsonProperty("all_knowledge_type_ssids")]
        public string AllKnowledgeTypeSsids { get; set; }

        [JsonProperty("approver")]
        public CurationPropertiesApproverTypeItem[] Approver { get; set; }

        [JsonProperty("all_approver_ssids")]
        public string AllApproverSsids { get; set; }

        [JsonProperty("knowledge_owner")]
        public CurationPropertiesKnowledgeOwnerTypeItem[] KnowledgeOwner { get; set; }

        [JsonProperty("all_knowledge_owner_ssids")]
        public string AllKnowledgeOwnerSsids { get; set; }

        [JsonProperty("submitter")]
        public CurationPropertiesSubmitterType Submitter { get; set; }

        [JsonProperty("state")]
        public CurationPropertiesStateType State { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("all_languages")]
        public string AllLanguages { get; set; }

        [JsonProperty("other_noteworthy")]
        public string OtherNoteworthy { get; set; }

        [JsonProperty("submitted_doc_id")]
        public string SubmittedDocId { get; set; }
    }

    public class CurationPropertiesTaxonomy1TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CurationPropertiesTaxonomy2TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CurationPropertiesTaxonomy3TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CurationPropertiesTaxonomy4TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CurationPropertiesTaxonomy5TypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CurationPropertiesKnowledgeTypeTypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CurationPropertiesApproverTypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CurationPropertiesKnowledgeOwnerTypeItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class CurationPropertiesSubmitterType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CurationPropertiesStateType
    {
        [EnumMember(Value = "IN_DRAFT")]
        INDRAFT,
        SUBMITTED,
        REJECTED,
        PUBLISHED,
        RETIRED,
        UNPUBLISHED
    }

    public class SetCurationPropertiesForDocumentResponseBody
    {
        [JsonProperty("data")]
        public CurationProperties Data { get; set; }
    }

    public class GetKnowledgeTypesResponse
    {
        [JsonProperty("data")]
        public GetKnowledgeTypesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetKnowledgeTypesResponseDataTypeItem
    {
        [JsonProperty("created_by")]
        public GetKnowledgeTypesResponseDataTypeItemCreatedByType CreatedBy { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edited_by")]
        public GetKnowledgeTypesResponseDataTypeItemEditedByType EditedBy { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class GetKnowledgeTypesResponseDataTypeItemCreatedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class GetKnowledgeTypesResponseDataTypeItemEditedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class GetCurationConfigurationResponse
    {
        [JsonProperty("data")]
        public GetCurationConfigurationResponseDataType Data { get; set; }
    }

    public class GetCurationConfigurationResponseDataType
    {
        [JsonProperty("folders")]
        public CurationFolders Folders { get; set; }

        [JsonProperty("knowledge_admins")]
        public KnowledgeAdmin[] KnowledgeAdmins { get; set; }

        [JsonProperty("knowledge_library_id")]
        public string KnowledgeLibraryId { get; set; }
    }

    public class CurationFolders
    {
        [JsonProperty("curation_submitted")]
        public string CurationSubmitted { get; set; }

        [JsonProperty("curation_indraft")]
        public string CurationIndraft { get; set; }

        [JsonProperty("curation_new_version_replace")]
        public string CurationNewVersionReplace { get; set; }

        [JsonProperty("curation_published")]
        public string CurationPublished { get; set; }

        [JsonProperty("curation_rejected")]
        public string CurationRejected { get; set; }

        [JsonProperty("curation_retired")]
        public string CurationRetired { get; set; }

        [JsonProperty("curation_unpublished")]
        public string CurationUnpublished { get; set; }
    }

    public class KnowledgeAdmin
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public KnowledgeAdminTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KnowledgeAdminTypeType
    {
        USER,
        GROUP
    }

    public class SearchCurationTaxonomyNodeValuesResponse
    {
        [JsonProperty("data")]
        public SearchCurationTaxonomyNodeValuesResponseDataType Data { get; set; }
    }

    public class SearchCurationTaxonomyNodeValuesResponseDataType
    {
        [JsonProperty("topMatchingResult")]
        public SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultType TopMatchingResult { get; set; }

        [JsonProperty("results")]
        public TaxonomyNodeValue[] Results { get; set; }

        [JsonProperty("all_taxonomy_ssids")]
        public string AllTaxonomySsids { get; set; }
    }

    public class SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultType
    {
        [JsonProperty("created_by")]
        public SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edited_by")]
        public SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeEditedByType EditedBy { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent")]
        public SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeParentType Parent { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("path")]
        public SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypePathTypeItem[] Path { get; set; }
    }

    public class SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeCreatedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeEditedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypeParentType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class SearchCurationTaxonomyNodeValuesResponseDataTypeTopMatchingResultTypePathTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValue
    {
        [JsonProperty("created_by")]
        public TaxonomyNodeValueCreatedByType CreatedBy { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edited_by")]
        public TaxonomyNodeValueEditedByType EditedBy { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent")]
        public TaxonomyNodeValueParentType Parent { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("path")]
        public TaxonomyNodeValuePathTypeItem[] Path { get; set; }
    }

    public class TaxonomyNodeValueCreatedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValueEditedByType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValueParentType
    {
        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    public class TaxonomyNodeValuePathTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenabledStateInput
    {
        Enabled,
        Disabled,
        [EnumMember(Value = "Both Enabled and Disabled")]
        BothEnabledAndDisabled
    }

    public class SearchKnowledgeDocumentsResponse
    {
        [JsonProperty("data")]
        public SearchKnowledgeDocumentsResponseDataType Data { get; set; }
    }

    public class SearchKnowledgeDocumentsResponseDataType
    {
        [JsonProperty("topMatchingId")]
        public string TopMatchingId { get; set; }

        [JsonProperty("topMatchingName")]
        public string TopMatchingName { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("results")]
        public KnowledgeDocumentProfile[] Results { get; set; }
    }

    public class KnowledgeDocumentProfile
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("basic_properties")]
        public string BasicProperties { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("default_security")]
        public KnowledgeDocumentProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("file_create_date")]
        public string FileCreateDate { get; set; }

        [JsonProperty("file_edit_date")]
        public string FileEditDate { get; set; }

        [JsonProperty("full_file_name")]
        public string FullFileName { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("is_hipaa")]
        public bool IsHipaa { get; set; }

        [JsonProperty("iwl")]
        public string Iwl { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("document_number")]
        public int DocumentNumber { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("wstype")]
        public string Wstype { get; set; }

        [JsonProperty("curation")]
        public CurationProperties Curation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum KnowledgeDocumentProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public class bodysearchFiltersInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imanageinsightplus;

    public partial class WorkflowManagedActions
    {
        public ImanageinsightplusActions Imanageinsightplus(string connectionId) => new ImanageinsightplusActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImanageinsightplusTriggers Imanageinsightplus(string connectionId) => new ImanageinsightplusTriggers(connectionId);
    }
}