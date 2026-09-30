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
        public IBodyWorkflowAction<GetCurationPropertiesForDocumentResponse> GetCurationPropertiesForDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<bool> bodylatest)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodylatest, nameof(bodylatest), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getCurationPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["latest"] = SourceExpressionConverter.ConvertToken(bodylatest);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetCurationPropertiesForDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SetCurationPropertiesForDocumentResponseBody> SetCurationPropertiesForDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyapprover = null, [WorkflowExpression] Func<string> bodydraftingNotes = null, [WorkflowExpression] Func<bool> bodyisMaintained = null, [WorkflowExpression] Func<string> bodyknowledgeOwner = null, [WorkflowExpression] Func<string> bodyknowledgeType = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodylastReviewDate = null, [WorkflowExpression] Func<string> bodyminiSummary = null, [WorkflowExpression] Func<string> bodynextReviewDate = null, [WorkflowExpression] Func<string> bodyotherNoteworthy = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodysubmitDate = null, [WorkflowExpression] Func<string> bodytaxonomy1 = null, [WorkflowExpression] Func<string> bodytaxonomy2 = null, [WorkflowExpression] Func<string> bodytaxonomy3 = null, [WorkflowExpression] Func<string> bodytaxonomy4 = null, [WorkflowExpression] Func<string> bodytaxonomy5 = null, [WorkflowExpression] Func<string> bodysubmitter = null, [WorkflowExpression] Func<string> bodysubmittedDocId = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyapprover, nameof(bodyapprover), required: false);
            SourceExpression.Validate(bodydraftingNotes, nameof(bodydraftingNotes), required: false);
            SourceExpression.Validate(bodyisMaintained, nameof(bodyisMaintained), required: false);
            SourceExpression.Validate(bodyknowledgeOwner, nameof(bodyknowledgeOwner), required: false);
            SourceExpression.Validate(bodyknowledgeType, nameof(bodyknowledgeType), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodylastReviewDate, nameof(bodylastReviewDate), required: false);
            SourceExpression.Validate(bodyminiSummary, nameof(bodyminiSummary), required: false);
            SourceExpression.Validate(bodynextReviewDate, nameof(bodynextReviewDate), required: false);
            SourceExpression.Validate(bodyotherNoteworthy, nameof(bodyotherNoteworthy), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodysubmitDate, nameof(bodysubmitDate), required: false);
            SourceExpression.Validate(bodytaxonomy1, nameof(bodytaxonomy1), required: false);
            SourceExpression.Validate(bodytaxonomy2, nameof(bodytaxonomy2), required: false);
            SourceExpression.Validate(bodytaxonomy3, nameof(bodytaxonomy3), required: false);
            SourceExpression.Validate(bodytaxonomy4, nameof(bodytaxonomy4), required: false);
            SourceExpression.Validate(bodytaxonomy5, nameof(bodytaxonomy5), required: false);
            SourceExpression.Validate(bodysubmitter, nameof(bodysubmitter), required: false);
            SourceExpression.Validate(bodysubmittedDocId, nameof(bodysubmittedDocId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setCurationPropertiesForDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodyapprover != null)
                {
                    body["approver"] = SourceExpressionConverter.ConvertToken(bodyapprover);
                    bodypropCount++;
                }

                if (bodydraftingNotes != null)
                {
                    body["drafting_notes"] = SourceExpressionConverter.ConvertToken(bodydraftingNotes);
                    bodypropCount++;
                }

                if (bodyisMaintained != null)
                {
                    body["is_maintained"] = SourceExpressionConverter.ConvertToken(bodyisMaintained);
                    bodypropCount++;
                }

                if (bodyknowledgeOwner != null)
                {
                    body["knowledge_owner"] = SourceExpressionConverter.ConvertToken(bodyknowledgeOwner);
                    bodypropCount++;
                }

                if (bodyknowledgeType != null)
                {
                    body["knowledge_type"] = SourceExpressionConverter.ConvertToken(bodyknowledgeType);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodylastReviewDate != null)
                {
                    body["last_review_date"] = SourceExpressionConverter.ConvertToken(bodylastReviewDate);
                    bodypropCount++;
                }

                if (bodyminiSummary != null)
                {
                    body["mini_summary"] = SourceExpressionConverter.ConvertToken(bodyminiSummary);
                    bodypropCount++;
                }

                if (bodynextReviewDate != null)
                {
                    body["next_review_date"] = SourceExpressionConverter.ConvertToken(bodynextReviewDate);
                    bodypropCount++;
                }

                if (bodyotherNoteworthy != null)
                {
                    body["other_noteworthy"] = SourceExpressionConverter.ConvertToken(bodyotherNoteworthy);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodysubmitDate != null)
                {
                    body["submit_date"] = SourceExpressionConverter.ConvertToken(bodysubmitDate);
                    bodypropCount++;
                }

                if (bodytaxonomy1 != null)
                {
                    body["taxonomy1"] = SourceExpressionConverter.ConvertToken(bodytaxonomy1);
                    bodypropCount++;
                }

                if (bodytaxonomy2 != null)
                {
                    body["taxonomy2"] = SourceExpressionConverter.ConvertToken(bodytaxonomy2);
                    bodypropCount++;
                }

                if (bodytaxonomy3 != null)
                {
                    body["taxonomy3"] = SourceExpressionConverter.ConvertToken(bodytaxonomy3);
                    bodypropCount++;
                }

                if (bodytaxonomy4 != null)
                {
                    body["taxonomy4"] = SourceExpressionConverter.ConvertToken(bodytaxonomy4);
                    bodypropCount++;
                }

                if (bodytaxonomy5 != null)
                {
                    body["taxonomy5"] = SourceExpressionConverter.ConvertToken(bodytaxonomy5);
                    bodypropCount++;
                }

                if (bodysubmitter != null)
                {
                    body["submitter"] = SourceExpressionConverter.ConvertToken(bodysubmitter);
                    bodypropCount++;
                }

                if (bodysubmittedDocId != null)
                {
                    body["submitted_doc_id"] = SourceExpressionConverter.ConvertToken(bodysubmittedDocId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetCurationPropertiesForDocumentResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetKnowledgeTypesResponse> GetKnowledgeTypes([WorkflowExpression] Func<string> libraryId)
        {
            SourceExpression.Validate(libraryId, nameof(libraryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getKnowledgeTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                return callPayload;
            }

            return new ApiConnectionAction<GetKnowledgeTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetCurationConfigurationResponse> GetCurationConfiguration([WorkflowExpression] Func<string> libraryId)
        {
            SourceExpression.Validate(libraryId, nameof(libraryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getCurationConfiguration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCurationConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SearchCurationTaxonomyNodeValuesResponse> SearchCurationTaxonomyNodeValues([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodytaxonomyProperty, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<bodyenabledStateInput> bodyenabledState = null, [WorkflowExpression] Func<bool> bodyincludePath = null, [WorkflowExpression] Func<string> bodychildrenOfSsid = null, [WorkflowExpression] Func<bool> bodyimmediateChildrenOnly = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodytaxonomyProperty, nameof(bodytaxonomyProperty), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            SourceExpression.Validate(bodyenabledState, nameof(bodyenabledState), required: false);
            SourceExpression.Validate(bodyincludePath, nameof(bodyincludePath), required: false);
            SourceExpression.Validate(bodychildrenOfSsid, nameof(bodychildrenOfSsid), required: false);
            SourceExpression.Validate(bodyimmediateChildrenOnly, nameof(bodyimmediateChildrenOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchCurationTaxonomyNodeValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["taxonomyProperty"] = SourceExpressionConverter.ConvertToken(bodytaxonomyProperty);
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                    bodypropCount++;
                }

                if (bodyenabledState != null)
                {
                    if (bodyenabledState != null)
                    {
                        body["enabled_state"] = SourceExpressionConverter.Convert(bodyenabledState);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enabled_state"] = "Enabled";
                    bodypropCount++;
                }

                if (bodyincludePath != null)
                {
                    if (bodyincludePath != null)
                    {
                        body["include_path"] = SourceExpressionConverter.ConvertToken(bodyincludePath);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_path"] = false;
                    bodypropCount++;
                }

                if (bodychildrenOfSsid != null)
                {
                    body["children_of_ssid"] = SourceExpressionConverter.ConvertToken(bodychildrenOfSsid);
                    bodypropCount++;
                }

                if (bodyimmediateChildrenOnly != null)
                {
                    if (bodyimmediateChildrenOnly != null)
                    {
                        body["immediate_children_only"] = SourceExpressionConverter.ConvertToken(bodyimmediateChildrenOnly);
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
                return callPayload;
            }

            return new ApiConnectionAction<SearchCurationTaxonomyNodeValuesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SearchKnowledgeDocumentsResponse> SearchKnowledgeDocuments([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodycontainerId = null, [WorkflowExpression] Func<bool> bodyincludeSubfolders = null, [WorkflowExpression] Func<bodysearchFiltersInputItem[]> bodysearchFilters = null)
        {
            SourceExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            SourceExpression.Validate(bodycontainerId, nameof(bodycontainerId), required: false);
            SourceExpression.Validate(bodyincludeSubfolders, nameof(bodyincludeSubfolders), required: false);
            SourceExpression.Validate(bodysearchFilters, nameof(bodysearchFilters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchKnowledgeDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                if (bodycontainerId != null)
                {
                    body["container_id"] = SourceExpressionConverter.ConvertToken(bodycontainerId);
                    bodypropCount++;
                }

                if (bodyincludeSubfolders != null)
                {
                    if (bodyincludeSubfolders != null)
                    {
                        body["include_subfolders"] = SourceExpressionConverter.ConvertToken(bodyincludeSubfolders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_subfolders"] = false;
                    bodypropCount++;
                }

                if (bodysearchFilters != null)
                {
                    body["searchFilters"] = SourceExpressionConverter.ConvertToken(bodysearchFilters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchKnowledgeDocumentsResponse>(BuildSourceInput);
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