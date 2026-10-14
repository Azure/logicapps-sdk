//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageinsightplus
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ImanageinsightplusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetCurationPropertiesForDocumentResponse> GetCurationPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<bool>> bodylatest)
        {
            var __workflow_bodydocumentId = bodydocumentId == null ? null : WorkflowExpression.Compile(bodydocumentId);
            WorkflowExpression.Validate(__workflow_bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodylatest = bodylatest == null ? null : WorkflowExpression.Compile(bodylatest);
            WorkflowExpression.Validate(__workflow_bodylatest, nameof(bodylatest), required: true);
            return new DeferredBodyAction<GetCurationPropertiesForDocumentResponse>(() =>
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
        public IBodyWorkflowAction<SetCurationPropertiesForDocumentResponseBody> SetCurationPropertiesForDocument(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyapprover = null, Expression<Func<string>> bodydraftingNotes = null, Expression<Func<bool>> bodyisMaintained = null, Expression<Func<string>> bodyknowledgeOwner = null, Expression<Func<string>> bodyknowledgeType = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodylastReviewDate = null, Expression<Func<string>> bodyminiSummary = null, Expression<Func<string>> bodynextReviewDate = null, Expression<Func<string>> bodyotherNoteworthy = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodysubmitDate = null, Expression<Func<string>> bodytaxonomy1 = null, Expression<Func<string>> bodytaxonomy2 = null, Expression<Func<string>> bodytaxonomy3 = null, Expression<Func<string>> bodytaxonomy4 = null, Expression<Func<string>> bodytaxonomy5 = null, Expression<Func<string>> bodysubmitter = null, Expression<Func<string>> bodysubmittedDocId = null)
        {
            var __workflow_bodydocumentId = bodydocumentId == null ? null : WorkflowExpression.Compile(bodydocumentId);
            WorkflowExpression.Validate(__workflow_bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyapprover = bodyapprover == null ? null : WorkflowExpression.Compile(bodyapprover);
            WorkflowExpression.Validate(__workflow_bodyapprover, nameof(bodyapprover), required: false);
            var __workflow_bodydraftingNotes = bodydraftingNotes == null ? null : WorkflowExpression.Compile(bodydraftingNotes);
            WorkflowExpression.Validate(__workflow_bodydraftingNotes, nameof(bodydraftingNotes), required: false);
            var __workflow_bodyisMaintained = bodyisMaintained == null ? null : WorkflowExpression.Compile(bodyisMaintained);
            WorkflowExpression.Validate(__workflow_bodyisMaintained, nameof(bodyisMaintained), required: false);
            var __workflow_bodyknowledgeOwner = bodyknowledgeOwner == null ? null : WorkflowExpression.Compile(bodyknowledgeOwner);
            WorkflowExpression.Validate(__workflow_bodyknowledgeOwner, nameof(bodyknowledgeOwner), required: false);
            var __workflow_bodyknowledgeType = bodyknowledgeType == null ? null : WorkflowExpression.Compile(bodyknowledgeType);
            WorkflowExpression.Validate(__workflow_bodyknowledgeType, nameof(bodyknowledgeType), required: false);
            var __workflow_bodylanguage = bodylanguage == null ? null : WorkflowExpression.Compile(bodylanguage);
            WorkflowExpression.Validate(__workflow_bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodylastReviewDate = bodylastReviewDate == null ? null : WorkflowExpression.Compile(bodylastReviewDate);
            WorkflowExpression.Validate(__workflow_bodylastReviewDate, nameof(bodylastReviewDate), required: false);
            var __workflow_bodyminiSummary = bodyminiSummary == null ? null : WorkflowExpression.Compile(bodyminiSummary);
            WorkflowExpression.Validate(__workflow_bodyminiSummary, nameof(bodyminiSummary), required: false);
            var __workflow_bodynextReviewDate = bodynextReviewDate == null ? null : WorkflowExpression.Compile(bodynextReviewDate);
            WorkflowExpression.Validate(__workflow_bodynextReviewDate, nameof(bodynextReviewDate), required: false);
            var __workflow_bodyotherNoteworthy = bodyotherNoteworthy == null ? null : WorkflowExpression.Compile(bodyotherNoteworthy);
            WorkflowExpression.Validate(__workflow_bodyotherNoteworthy, nameof(bodyotherNoteworthy), required: false);
            var __workflow_bodystate = bodystate == null ? null : WorkflowExpression.Compile(bodystate);
            WorkflowExpression.Validate(__workflow_bodystate, nameof(bodystate), required: false);
            var __workflow_bodysubmitDate = bodysubmitDate == null ? null : WorkflowExpression.Compile(bodysubmitDate);
            WorkflowExpression.Validate(__workflow_bodysubmitDate, nameof(bodysubmitDate), required: false);
            var __workflow_bodytaxonomy1 = bodytaxonomy1 == null ? null : WorkflowExpression.Compile(bodytaxonomy1);
            WorkflowExpression.Validate(__workflow_bodytaxonomy1, nameof(bodytaxonomy1), required: false);
            var __workflow_bodytaxonomy2 = bodytaxonomy2 == null ? null : WorkflowExpression.Compile(bodytaxonomy2);
            WorkflowExpression.Validate(__workflow_bodytaxonomy2, nameof(bodytaxonomy2), required: false);
            var __workflow_bodytaxonomy3 = bodytaxonomy3 == null ? null : WorkflowExpression.Compile(bodytaxonomy3);
            WorkflowExpression.Validate(__workflow_bodytaxonomy3, nameof(bodytaxonomy3), required: false);
            var __workflow_bodytaxonomy4 = bodytaxonomy4 == null ? null : WorkflowExpression.Compile(bodytaxonomy4);
            WorkflowExpression.Validate(__workflow_bodytaxonomy4, nameof(bodytaxonomy4), required: false);
            var __workflow_bodytaxonomy5 = bodytaxonomy5 == null ? null : WorkflowExpression.Compile(bodytaxonomy5);
            WorkflowExpression.Validate(__workflow_bodytaxonomy5, nameof(bodytaxonomy5), required: false);
            var __workflow_bodysubmitter = bodysubmitter == null ? null : WorkflowExpression.Compile(bodysubmitter);
            WorkflowExpression.Validate(__workflow_bodysubmitter, nameof(bodysubmitter), required: false);
            var __workflow_bodysubmittedDocId = bodysubmittedDocId == null ? null : WorkflowExpression.Compile(bodysubmittedDocId);
            WorkflowExpression.Validate(__workflow_bodysubmittedDocId, nameof(bodysubmittedDocId), required: false);
            return new DeferredBodyAction<SetCurationPropertiesForDocumentResponseBody>(() =>
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
        public IBodyWorkflowAction<GetKnowledgeTypesResponse> GetKnowledgeTypes(Expression<Func<string>> libraryId)
        {
            var __workflow_libraryId = libraryId == null ? null : WorkflowExpression.Compile(libraryId);
            WorkflowExpression.Validate(__workflow_libraryId, nameof(libraryId), required: true);
            return new DeferredBodyAction<GetKnowledgeTypesResponse>(() =>
            {
                var apiCallPath = "/getKnowledgeTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                return new ApiConnectionAction<GetKnowledgeTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<GetCurationConfigurationResponse> GetCurationConfiguration(Expression<Func<string>> libraryId)
        {
            var __workflow_libraryId = libraryId == null ? null : WorkflowExpression.Compile(libraryId);
            WorkflowExpression.Validate(__workflow_libraryId, nameof(libraryId), required: true);
            return new DeferredBodyAction<GetCurationConfigurationResponse>(() =>
            {
                var apiCallPath = "/getCurationConfiguration";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                return new ApiConnectionAction<GetCurationConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageinsightplus")]
        public IBodyWorkflowAction<SearchCurationTaxonomyNodeValuesResponse> SearchCurationTaxonomyNodeValues(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodytaxonomyProperty, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyquery = null, Expression<Func<bodyenabledStateInput>> bodyenabledState = null, Expression<Func<bool>> bodyincludePath = null, Expression<Func<string>> bodychildrenOfSsid = null, Expression<Func<bool>> bodyimmediateChildrenOnly = null)
        {
            var __workflow_bodylibraryId = bodylibraryId == null ? null : WorkflowExpression.Compile(bodylibraryId);
            WorkflowExpression.Validate(__workflow_bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodytaxonomyProperty = bodytaxonomyProperty == null ? null : WorkflowExpression.Compile(bodytaxonomyProperty);
            WorkflowExpression.Validate(__workflow_bodytaxonomyProperty, nameof(bodytaxonomyProperty), required: true);
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: false);
            var __workflow_bodyquery = bodyquery == null ? null : WorkflowExpression.Compile(bodyquery);
            WorkflowExpression.Validate(__workflow_bodyquery, nameof(bodyquery), required: false);
            var __workflow_bodyenabledState = bodyenabledState == null ? null : WorkflowExpression.Compile(bodyenabledState);
            WorkflowExpression.Validate(__workflow_bodyenabledState, nameof(bodyenabledState), required: false);
            var __workflow_bodyincludePath = bodyincludePath == null ? null : WorkflowExpression.Compile(bodyincludePath);
            WorkflowExpression.Validate(__workflow_bodyincludePath, nameof(bodyincludePath), required: false);
            var __workflow_bodychildrenOfSsid = bodychildrenOfSsid == null ? null : WorkflowExpression.Compile(bodychildrenOfSsid);
            WorkflowExpression.Validate(__workflow_bodychildrenOfSsid, nameof(bodychildrenOfSsid), required: false);
            var __workflow_bodyimmediateChildrenOnly = bodyimmediateChildrenOnly == null ? null : WorkflowExpression.Compile(bodyimmediateChildrenOnly);
            WorkflowExpression.Validate(__workflow_bodyimmediateChildrenOnly, nameof(bodyimmediateChildrenOnly), required: false);
            return new DeferredBodyAction<SearchCurationTaxonomyNodeValuesResponse>(() =>
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
