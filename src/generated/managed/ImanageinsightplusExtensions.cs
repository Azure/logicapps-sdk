//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageinsightplus
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageinsightplusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        [WorkflowExpressionFactory(nameof(__BuildGetCurationPropertiesForDocument))]
        public IBodyWorkflowAction<GetCurationPropertiesForDocumentResponse> GetCurationPropertiesForDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<bool> bodylatest)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCurationPropertiesForDocumentResponse> __BuildGetCurationPropertiesForDocument(WorkflowValue<string> bodydocumentId, WorkflowValue<bool> bodylatest)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodylatest, nameof(bodylatest), required: true);
            return new DeferredBodyAction<GetCurationPropertiesForDocumentResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        [WorkflowExpressionFactory(nameof(__BuildSetCurationPropertiesForDocument))]
        public IBodyWorkflowAction<SetCurationPropertiesForDocumentResponseBody> SetCurationPropertiesForDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyapprover = null, [WorkflowExpression] Func<string> bodydraftingNotes = null, [WorkflowExpression] Func<bool> bodyisMaintained = null, [WorkflowExpression] Func<string> bodyknowledgeOwner = null, [WorkflowExpression] Func<string> bodyknowledgeType = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodylastReviewDate = null, [WorkflowExpression] Func<string> bodyminiSummary = null, [WorkflowExpression] Func<string> bodynextReviewDate = null, [WorkflowExpression] Func<string> bodyotherNoteworthy = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodysubmitDate = null, [WorkflowExpression] Func<string> bodytaxonomy1 = null, [WorkflowExpression] Func<string> bodytaxonomy2 = null, [WorkflowExpression] Func<string> bodytaxonomy3 = null, [WorkflowExpression] Func<string> bodytaxonomy4 = null, [WorkflowExpression] Func<string> bodytaxonomy5 = null, [WorkflowExpression] Func<string> bodysubmitter = null, [WorkflowExpression] Func<string> bodysubmittedDocId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetCurationPropertiesForDocumentResponseBody> __BuildSetCurationPropertiesForDocument(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodyapprover = null, WorkflowValue<string> bodydraftingNotes = null, WorkflowValue<bool> bodyisMaintained = null, WorkflowValue<string> bodyknowledgeOwner = null, WorkflowValue<string> bodyknowledgeType = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<string> bodylastReviewDate = null, WorkflowValue<string> bodyminiSummary = null, WorkflowValue<string> bodynextReviewDate = null, WorkflowValue<string> bodyotherNoteworthy = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodysubmitDate = null, WorkflowValue<string> bodytaxonomy1 = null, WorkflowValue<string> bodytaxonomy2 = null, WorkflowValue<string> bodytaxonomy3 = null, WorkflowValue<string> bodytaxonomy4 = null, WorkflowValue<string> bodytaxonomy5 = null, WorkflowValue<string> bodysubmitter = null, WorkflowValue<string> bodysubmittedDocId = null)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodyapprover, nameof(bodyapprover), required: false);
            WorkflowValue.Validate(bodydraftingNotes, nameof(bodydraftingNotes), required: false);
            WorkflowValue.Validate(bodyisMaintained, nameof(bodyisMaintained), required: false);
            WorkflowValue.Validate(bodyknowledgeOwner, nameof(bodyknowledgeOwner), required: false);
            WorkflowValue.Validate(bodyknowledgeType, nameof(bodyknowledgeType), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodylastReviewDate, nameof(bodylastReviewDate), required: false);
            WorkflowValue.Validate(bodyminiSummary, nameof(bodyminiSummary), required: false);
            WorkflowValue.Validate(bodynextReviewDate, nameof(bodynextReviewDate), required: false);
            WorkflowValue.Validate(bodyotherNoteworthy, nameof(bodyotherNoteworthy), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodysubmitDate, nameof(bodysubmitDate), required: false);
            WorkflowValue.Validate(bodytaxonomy1, nameof(bodytaxonomy1), required: false);
            WorkflowValue.Validate(bodytaxonomy2, nameof(bodytaxonomy2), required: false);
            WorkflowValue.Validate(bodytaxonomy3, nameof(bodytaxonomy3), required: false);
            WorkflowValue.Validate(bodytaxonomy4, nameof(bodytaxonomy4), required: false);
            WorkflowValue.Validate(bodytaxonomy5, nameof(bodytaxonomy5), required: false);
            WorkflowValue.Validate(bodysubmitter, nameof(bodysubmitter), required: false);
            WorkflowValue.Validate(bodysubmittedDocId, nameof(bodysubmittedDocId), required: false);
            return new DeferredBodyAction<SetCurationPropertiesForDocumentResponseBody>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        [WorkflowExpressionFactory(nameof(__BuildGetKnowledgeTypes))]
        public IBodyWorkflowAction<GetKnowledgeTypesResponse> GetKnowledgeTypes([WorkflowExpression] Func<string> libraryId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetKnowledgeTypesResponse> __BuildGetKnowledgeTypes(WorkflowValue<string> libraryId)
        {
            WorkflowValue.Validate(libraryId, nameof(libraryId), required: true);
            return new DeferredBodyAction<GetKnowledgeTypesResponse>(() =>
            {
                var apiCallPath = "/getKnowledgeTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(libraryId);
                return new ApiConnectionAction<GetKnowledgeTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        [WorkflowExpressionFactory(nameof(__BuildGetCurationConfiguration))]
        public IBodyWorkflowAction<GetCurationConfigurationResponse> GetCurationConfiguration([WorkflowExpression] Func<string> libraryId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCurationConfigurationResponse> __BuildGetCurationConfiguration(WorkflowValue<string> libraryId)
        {
            WorkflowValue.Validate(libraryId, nameof(libraryId), required: true);
            return new DeferredBodyAction<GetCurationConfigurationResponse>(() =>
            {
                var apiCallPath = "/getCurationConfiguration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(libraryId);
                return new ApiConnectionAction<GetCurationConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        [WorkflowExpressionFactory(nameof(__BuildSearchCurationTaxonomyNodeValues))]
        public IBodyWorkflowAction<SearchCurationTaxonomyNodeValuesResponse> SearchCurationTaxonomyNodeValues([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodytaxonomyProperty, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<bodyenabledStateInput> bodyenabledState = null, [WorkflowExpression] Func<bool> bodyincludePath = null, [WorkflowExpression] Func<string> bodychildrenOfSsid = null, [WorkflowExpression] Func<bool> bodyimmediateChildrenOnly = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchCurationTaxonomyNodeValuesResponse> __BuildSearchCurationTaxonomyNodeValues(WorkflowValue<string> bodylibraryId, WorkflowValue<string> bodytaxonomyProperty, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodyquery = null, WorkflowValue<bodyenabledStateInput> bodyenabledState = null, WorkflowValue<bool> bodyincludePath = null, WorkflowValue<string> bodychildrenOfSsid = null, WorkflowValue<bool> bodyimmediateChildrenOnly = null)
        {
            WorkflowValue.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            WorkflowValue.Validate(bodytaxonomyProperty, nameof(bodytaxonomyProperty), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodyquery, nameof(bodyquery), required: false);
            WorkflowValue.Validate(bodyenabledState, nameof(bodyenabledState), required: false);
            WorkflowValue.Validate(bodyincludePath, nameof(bodyincludePath), required: false);
            WorkflowValue.Validate(bodychildrenOfSsid, nameof(bodychildrenOfSsid), required: false);
            WorkflowValue.Validate(bodyimmediateChildrenOnly, nameof(bodyimmediateChildrenOnly), required: false);
            return new DeferredBodyAction<SearchCurationTaxonomyNodeValuesResponse>(() =>
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
                    if (bodyenabledState != null)
                    {
                        body["enabled_state"] = ExpressionConverter.ConvertO(bodyenabledState);
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
                        body["include_path"] = ExpressionConverter.ConvertO(bodyincludePath);
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
                    body["children_of_ssid"] = ExpressionConverter.ConvertO(bodychildrenOfSsid);
                    bodypropCount++;
                }

                if (bodyimmediateChildrenOnly != null)
                {
                    if (bodyimmediateChildrenOnly != null)
                    {
                        body["immediate_children_only"] = ExpressionConverter.ConvertO(bodyimmediateChildrenOnly);
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
