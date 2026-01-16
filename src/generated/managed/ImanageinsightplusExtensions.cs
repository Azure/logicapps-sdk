//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageinsightplus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageinsightplusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetCurationPropertiesForDocumentResponse> GetCurationPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<bool>> bodylatest)
        {
            var apiCallPath = "/getCurationPropertiesForDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["latest"] = ExpressionConverter.ConvertO(bodylatest);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetCurationPropertiesForDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SetCurationPropertiesForDocumentResponseBody> SetCurationPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyapprover = null, Expression<Func<string>> bodydraftingNotes = null, Expression<Func<bool>> bodyisMaintained = null, Expression<Func<string>> bodyknowledgeOwner = null, Expression<Func<string>> bodyknowledgeType = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodylastReviewDate = null, Expression<Func<string>> bodyminiSummary = null, Expression<Func<string>> bodynextReviewDate = null, Expression<Func<string>> bodyotherNoteworthy = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodysubmitDate = null, Expression<Func<string>> bodytaxonomy1 = null, Expression<Func<string>> bodytaxonomy2 = null, Expression<Func<string>> bodytaxonomy3 = null, Expression<Func<string>> bodytaxonomy4 = null, Expression<Func<string>> bodytaxonomy5 = null, Expression<Func<string>> bodysubmitter = null, Expression<Func<string>> bodysubmittedDocId = null)
        {
            var apiCallPath = "/setCurationPropertiesForDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            if (bodyapprover != null)
            {
                body["approver"] = ExpressionConverter.ConvertO(bodyapprover);
                bodypropCount++;
            }

            if (bodydraftingNotes != null)
            {
                body["drafting_notes"] = ExpressionConverter.ConvertO(bodydraftingNotes);
                bodypropCount++;
            }

            if (bodyisMaintained != null)
            {
                body["is_maintained"] = ExpressionConverter.ConvertO(bodyisMaintained);
                bodypropCount++;
            }

            if (bodyknowledgeOwner != null)
            {
                body["knowledge_owner"] = ExpressionConverter.ConvertO(bodyknowledgeOwner);
                bodypropCount++;
            }

            if (bodyknowledgeType != null)
            {
                body["knowledge_type"] = ExpressionConverter.ConvertO(bodyknowledgeType);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodylastReviewDate != null)
            {
                body["last_review_date"] = ExpressionConverter.ConvertO(bodylastReviewDate);
                bodypropCount++;
            }

            if (bodyminiSummary != null)
            {
                body["mini_summary"] = ExpressionConverter.ConvertO(bodyminiSummary);
                bodypropCount++;
            }

            if (bodynextReviewDate != null)
            {
                body["next_review_date"] = ExpressionConverter.ConvertO(bodynextReviewDate);
                bodypropCount++;
            }

            if (bodyotherNoteworthy != null)
            {
                body["other_noteworthy"] = ExpressionConverter.ConvertO(bodyotherNoteworthy);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodysubmitDate != null)
            {
                body["submit_date"] = ExpressionConverter.ConvertO(bodysubmitDate);
                bodypropCount++;
            }

            if (bodytaxonomy1 != null)
            {
                body["taxonomy1"] = ExpressionConverter.ConvertO(bodytaxonomy1);
                bodypropCount++;
            }

            if (bodytaxonomy2 != null)
            {
                body["taxonomy2"] = ExpressionConverter.ConvertO(bodytaxonomy2);
                bodypropCount++;
            }

            if (bodytaxonomy3 != null)
            {
                body["taxonomy3"] = ExpressionConverter.ConvertO(bodytaxonomy3);
                bodypropCount++;
            }

            if (bodytaxonomy4 != null)
            {
                body["taxonomy4"] = ExpressionConverter.ConvertO(bodytaxonomy4);
                bodypropCount++;
            }

            if (bodytaxonomy5 != null)
            {
                body["taxonomy5"] = ExpressionConverter.ConvertO(bodytaxonomy5);
                bodypropCount++;
            }

            if (bodysubmitter != null)
            {
                body["submitter"] = ExpressionConverter.ConvertO(bodysubmitter);
                bodypropCount++;
            }

            if (bodysubmittedDocId != null)
            {
                body["submitted_doc_id"] = ExpressionConverter.ConvertO(bodysubmittedDocId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetCurationPropertiesForDocumentResponseBody>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetKnowledgeTypesResponse> GetKnowledgeTypes(Expression<Func<string>> libraryId)
        {
            var apiCallPath = "/getKnowledgeTypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["libraryId"] = ExpressionConverter.Convert(libraryId);
            return new ApiConnectionAction<GetKnowledgeTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetCurationConfigurationResponse> GetCurationConfiguration(Expression<Func<string>> libraryId)
        {
            var apiCallPath = "/getCurationConfiguration";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["libraryId"] = ExpressionConverter.Convert(libraryId);
            return new ApiConnectionAction<GetCurationConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SearchCurationTaxonomyNodeValuesResponse> SearchCurationTaxonomyNodeValues(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodytaxonomyProperty, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyquery = null, Expression<Func<bodyenabledStateInput>> bodyenabledState = null, Expression<Func<bool>> bodyincludePath = null, Expression<Func<string>> bodychildrenOfSsid = null, Expression<Func<bool>> bodyimmediateChildrenOnly = null)
        {
            var apiCallPath = "/searchCurationTaxonomyNodeValues";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["libraryId"] = ExpressionConverter.ConvertO(bodylibraryId);
            bodypropCount++;
            body["taxonomyProperty"] = ExpressionConverter.ConvertO(bodytaxonomyProperty);
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                bodypropCount++;
            }

            if (bodyenabledState != null)
            {
                body["enabled_state"] = ExpressionConverter.ConvertO(bodyenabledState);
                bodypropCount++;
            }

            if (bodyincludePath != null)
            {
                body["include_path"] = ExpressionConverter.ConvertO(bodyincludePath);
                bodypropCount++;
            }

            if (bodychildrenOfSsid != null)
            {
                body["children_of_ssid"] = ExpressionConverter.ConvertO(bodychildrenOfSsid);
                bodypropCount++;
            }

            if (bodyimmediateChildrenOnly != null)
            {
                body["immediate_children_only"] = ExpressionConverter.ConvertO(bodyimmediateChildrenOnly);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchCurationTaxonomyNodeValuesResponse>(callPayload);
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

    public enum bodyenabledStateInput
    {
        Enabled,
        Disabled,
        [EnumMember(Value = "Both Enabled and Disabled")]
        BothEnabledAndDisabled
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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