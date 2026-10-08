//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openfdadrugip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenfdadrugipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openfdadrugip")]
        [WorkflowExpressionFactory(nameof(__BuildDrugAdverseEvent))]
        public IBodyWorkflowAction<DrugAdverseEventResponse> DrugAdverseEvent([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrugAdverseEventResponse> __BuildDrugAdverseEvent(WorkflowExpression<string> search = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<DrugAdverseEventResponse>(() =>
            {
                var apiCallPath = "/event.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<DrugAdverseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openfdadrugip")]
        [WorkflowExpressionFactory(nameof(__BuildDrugLabeling))]
        public IBodyWorkflowAction<DrugLabelingResponse> DrugLabeling([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrugLabelingResponse> __BuildDrugLabeling(WorkflowExpression<string> search = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<DrugLabelingResponse>(() =>
            {
                var apiCallPath = "/label.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<DrugLabelingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openfdadrugip")]
        [WorkflowExpressionFactory(nameof(__BuildDrugNDC))]
        public IBodyWorkflowAction<DrugNDCResponse> DrugNDC([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrugNDCResponse> __BuildDrugNDC(WorkflowExpression<string> search = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<DrugNDCResponse>(() =>
            {
                var apiCallPath = "/ndc.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<DrugNDCResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openfdadrugip")]
        [WorkflowExpressionFactory(nameof(__BuildDrugEnforcement))]
        public IBodyWorkflowAction<DrugEnforcementResponse> DrugEnforcement([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrugEnforcementResponse> __BuildDrugEnforcement(WorkflowExpression<string> search = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<DrugEnforcementResponse>(() =>
            {
                var apiCallPath = "/enforcement.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<DrugEnforcementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openfdadrugip")]
        [WorkflowExpressionFactory(nameof(__BuildDrugsFDA))]
        public IBodyWorkflowAction<DrugsFDAResponse> DrugsFDA([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrugsFDAResponse> __BuildDrugsFDA(WorkflowExpression<string> search = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<DrugsFDAResponse>(() =>
            {
                var apiCallPath = "/drugsfda.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<DrugsFDAResponse>(callPayload);
            });
        }
    }

    public class OpenfdadrugipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DrugAdverseEventResponse
    {
        [JsonProperty("meta")]
        public DrugAdverseEventResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public DrugAdverseEventResponseResultsTypeItem[] Results { get; set; }
    }

    public class DrugAdverseEventResponseMetaType
    {
        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("results")]
        public DrugAdverseEventResponseMetaTypeResultsType Results { get; set; }
    }

    public class DrugAdverseEventResponseMetaTypeResultsType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DrugAdverseEventResponseResultsTypeItem
    {
        [JsonProperty("receiptdateformat")]
        public string Receiptdateformat { get; set; }

        [JsonProperty("receiver")]
        public string Receiver { get; set; }

        [JsonProperty("seriousnessdeath")]
        public string Seriousnessdeath { get; set; }

        [JsonProperty("companynumb")]
        public string Companynumb { get; set; }

        [JsonProperty("receivedateformat")]
        public string Receivedateformat { get; set; }

        [JsonProperty("primarysource")]
        public DrugAdverseEventResponseResultsTypeItemPrimarysourceType Primarysource { get; set; }

        [JsonProperty("transmissiondateformat")]
        public string Transmissiondateformat { get; set; }

        [JsonProperty("fulfillexpeditecriteria")]
        public string Fulfillexpeditecriteria { get; set; }

        [JsonProperty("safetyreportid")]
        public string Safetyreportid { get; set; }

        [JsonProperty("sender")]
        public DrugAdverseEventResponseResultsTypeItemSenderType Sender { get; set; }

        [JsonProperty("receivedate")]
        public string Receivedate { get; set; }

        [JsonProperty("patient")]
        public DrugAdverseEventResponseResultsTypeItemPatientType Patient { get; set; }

        [JsonProperty("transmissiondate")]
        public string Transmissiondate { get; set; }

        [JsonProperty("serious")]
        public string Serious { get; set; }

        [JsonProperty("receiptdate")]
        public string Receiptdate { get; set; }
    }

    public class DrugAdverseEventResponseResultsTypeItemPrimarysourceType
    {
        [JsonProperty("reportercountry")]
        public string Reportercountry { get; set; }

        [JsonProperty("qualification")]
        public string Qualification { get; set; }
    }

    public class DrugAdverseEventResponseResultsTypeItemSenderType
    {
        [JsonProperty("senderorganization")]
        public string Senderorganization { get; set; }
    }

    public class DrugAdverseEventResponseResultsTypeItemPatientType
    {
        [JsonProperty("patientonsetage")]
        public string Patientonsetage { get; set; }

        [JsonProperty("patientonsetageunit")]
        public string Patientonsetageunit { get; set; }

        [JsonProperty("patientsex")]
        public string Patientsex { get; set; }

        [JsonProperty("patientdeath")]
        public DrugAdverseEventResponseResultsTypeItemPatientTypePatientdeathType Patientdeath { get; set; }

        [JsonProperty("reaction")]
        public DrugAdverseEventResponseResultsTypeItemPatientTypeReactionTypeItem[] Reaction { get; set; }

        [JsonProperty("drug")]
        public DrugAdverseEventResponseResultsTypeItemPatientTypeDrugTypeItem[] Drug { get; set; }
    }

    public class DrugAdverseEventResponseResultsTypeItemPatientTypePatientdeathType
    {
        [JsonProperty("patientdeathdateformat")]
        public string Patientdeathdateformat { get; set; }

        [JsonProperty("patientdeathdate")]
        public string Patientdeathdate { get; set; }
    }

    public class DrugAdverseEventResponseResultsTypeItemPatientTypeReactionTypeItem
    {
        [JsonProperty("reactionmeddrapt")]
        public string Reactionmeddrapt { get; set; }
    }

    public class DrugAdverseEventResponseResultsTypeItemPatientTypeDrugTypeItem
    {
        [JsonProperty("drugcharacterization")]
        public string Drugcharacterization { get; set; }

        [JsonProperty("medicinalproduct")]
        public string Medicinalproduct { get; set; }

        [JsonProperty("drugauthorizationnumb")]
        public string Drugauthorizationnumb { get; set; }

        [JsonProperty("drugadministrationroute")]
        public string Drugadministrationroute { get; set; }

        [JsonProperty("drugindication")]
        public string Drugindication { get; set; }
    }

    public class DrugLabelingResponse
    {
        [JsonProperty("meta")]
        public DrugLabelingResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public DrugLabelingResponseResultsTypeItem[] Results { get; set; }
    }

    public class DrugLabelingResponseMetaType
    {
        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("results")]
        public DrugLabelingResponseMetaTypeResultsType Results { get; set; }
    }

    public class DrugLabelingResponseMetaTypeResultsType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DrugLabelingResponseResultsTypeItem
    {
        [JsonProperty("effective_time")]
        public string EffectiveTime { get; set; }

        [JsonProperty("inactive_ingredient")]
        public string[] InactiveIngredient { get; set; }

        [JsonProperty("references")]
        public string[] References { get; set; }

        [JsonProperty("purpose")]
        public string[] Purpose { get; set; }

        [JsonProperty("keep_out_of_reach_of_children")]
        public string[] KeepOutOfReachOfChildren { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }

        [JsonProperty("spl_product_data_elements")]
        public string[] SplProductDataElements { get; set; }

        [JsonProperty("other_safety_information")]
        public string[] OtherSafetyInformation { get; set; }

        [JsonProperty("openfda")]
        public JToken Openfda { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("dosage_and_administration")]
        public string[] DosageAndAdministration { get; set; }

        [JsonProperty("pregnancy_or_breast_feeding")]
        public string[] PregnancyOrBreastFeeding { get; set; }

        [JsonProperty("stop_use")]
        public string[] StopUse { get; set; }

        [JsonProperty("package_label_principal_display_panel")]
        public string[] PackageLabelPrincipalDisplayPanel { get; set; }

        [JsonProperty("indications_and_usage")]
        public string[] IndicationsAndUsage { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active_ingredient")]
        public string[] ActiveIngredient { get; set; }

        [JsonProperty("dosage_and_administration_table")]
        public string[] DosageAndAdministrationTable { get; set; }
    }

    public class DrugNDCResponse
    {
        [JsonProperty("meta")]
        public DrugNDCResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public DrugNDCResponseResultsTypeItem[] Results { get; set; }
    }

    public class DrugNDCResponseMetaType
    {
        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("results")]
        public DrugNDCResponseMetaTypeResultsType Results { get; set; }
    }

    public class DrugNDCResponseMetaTypeResultsType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DrugNDCResponseResultsTypeItem
    {
        [JsonProperty("product_ndc")]
        public string ProductNdc { get; set; }

        [JsonProperty("generic_name")]
        public string GenericName { get; set; }

        [JsonProperty("labeler_name")]
        public string LabelerName { get; set; }

        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        [JsonProperty("active_ingredients")]
        public DrugNDCResponseResultsTypeItemActiveIngredientsTypeItem[] ActiveIngredients { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("packaging")]
        public DrugNDCResponseResultsTypeItemPackagingTypeItem[] Packaging { get; set; }

        [JsonProperty("listing_expiration_date")]
        public string ListingExpirationDate { get; set; }

        [JsonProperty("openfda")]
        public DrugNDCResponseResultsTypeItemOpenfdaType Openfda { get; set; }

        [JsonProperty("marketing_category")]
        public string MarketingCategory { get; set; }

        [JsonProperty("dosage_form")]
        public string DosageForm { get; set; }

        [JsonProperty("spl_id")]
        public string SplId { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("route")]
        public string[] Route { get; set; }

        [JsonProperty("marketing_start_date")]
        public string MarketingStartDate { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("application_number")]
        public string ApplicationNumber { get; set; }

        [JsonProperty("brand_name_base")]
        public string BrandNameBase { get; set; }

        [JsonProperty("pharm_class")]
        public string[] PharmClass { get; set; }
    }

    public class DrugNDCResponseResultsTypeItemActiveIngredientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }
    }

    public class DrugNDCResponseResultsTypeItemPackagingTypeItem
    {
        [JsonProperty("package_ndc")]
        public string PackageNdc { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("marketing_start_date")]
        public string MarketingStartDate { get; set; }

        [JsonProperty("sample")]
        public bool Sample { get; set; }
    }

    public class DrugNDCResponseResultsTypeItemOpenfdaType
    {
        [JsonProperty("manufacturer_name")]
        public string[] ManufacturerName { get; set; }

        [JsonProperty("rxcui")]
        public string[] Rxcui { get; set; }

        [JsonProperty("spl_set_id")]
        public string[] SplSetId { get; set; }

        [JsonProperty("nui")]
        public string[] Nui { get; set; }

        [JsonProperty("pharm_class_epc")]
        public string[] PharmClassEpc { get; set; }

        [JsonProperty("pharm_class_pe")]
        public string[] PharmClassPe { get; set; }

        [JsonProperty("unii")]
        public string[] Unii { get; set; }
    }

    public class DrugEnforcementResponse
    {
        [JsonProperty("meta")]
        public DrugEnforcementResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public DrugEnforcementResponseResultsTypeItem[] Results { get; set; }
    }

    public class DrugEnforcementResponseMetaType
    {
        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("results")]
        public DrugEnforcementResponseMetaTypeResultsType Results { get; set; }
    }

    public class DrugEnforcementResponseMetaTypeResultsType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DrugEnforcementResponseResultsTypeItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("reason_for_recall")]
        public string ReasonForRecall { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("product_quantity")]
        public string ProductQuantity { get; set; }

        [JsonProperty("code_info")]
        public string CodeInfo { get; set; }

        [JsonProperty("center_classification_date")]
        public string CenterClassificationDate { get; set; }

        [JsonProperty("distribution_pattern")]
        public string DistributionPattern { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("report_date")]
        public string ReportDate { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("openfda")]
        public JToken Openfda { get; set; }

        [JsonProperty("recalling_firm")]
        public string RecallingFirm { get; set; }

        [JsonProperty("recall_number")]
        public string RecallNumber { get; set; }

        [JsonProperty("initial_firm_notification")]
        public string InitialFirmNotification { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("termination_date")]
        public string TerminationDate { get; set; }

        [JsonProperty("more_code_info")]
        public string MoreCodeInfo { get; set; }

        [JsonProperty("recall_initiation_date")]
        public string RecallInitiationDate { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("voluntary_mandated")]
        public string VoluntaryMandated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DrugsFDAResponse
    {
        [JsonProperty("meta")]
        public DrugsFDAResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public DrugsFDAResponseResultsTypeItem[] Results { get; set; }
    }

    public class DrugsFDAResponseMetaType
    {
        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("results")]
        public DrugsFDAResponseMetaTypeResultsType Results { get; set; }
    }

    public class DrugsFDAResponseMetaTypeResultsType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DrugsFDAResponseResultsTypeItem
    {
        [JsonProperty("submissions")]
        public DrugsFDAResponseResultsTypeItemSubmissionsTypeItem[] Submissions { get; set; }

        [JsonProperty("application_number")]
        public string ApplicationNumber { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("products")]
        public DrugsFDAResponseResultsTypeItemProductsTypeItem[] Products { get; set; }
    }

    public class DrugsFDAResponseResultsTypeItemSubmissionsTypeItem
    {
        [JsonProperty("submission_type")]
        public string SubmissionType { get; set; }

        [JsonProperty("submission_number")]
        public string SubmissionNumber { get; set; }

        [JsonProperty("submission_status")]
        public string SubmissionStatus { get; set; }

        [JsonProperty("submission_status_date")]
        public string SubmissionStatusDate { get; set; }

        [JsonProperty("submission_class_code")]
        public string SubmissionClassCode { get; set; }

        [JsonProperty("submission_class_code_description")]
        public string SubmissionClassCodeDescription { get; set; }
    }

    public class DrugsFDAResponseResultsTypeItemProductsTypeItem
    {
        [JsonProperty("product_number")]
        public string ProductNumber { get; set; }

        [JsonProperty("reference_drug")]
        public string ReferenceDrug { get; set; }

        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        [JsonProperty("active_ingredients")]
        public DrugsFDAResponseResultsTypeItemProductsTypeItemActiveIngredientsTypeItem[] ActiveIngredients { get; set; }

        [JsonProperty("reference_standard")]
        public string ReferenceStandard { get; set; }

        [JsonProperty("dosage_form")]
        public string DosageForm { get; set; }

        [JsonProperty("route")]
        public string Route { get; set; }

        [JsonProperty("marketing_status")]
        public string MarketingStatus { get; set; }
    }

    public class DrugsFDAResponseResultsTypeItemProductsTypeItemActiveIngredientsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("strength")]
        public string Strength { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openfdadrugip;

    public partial class WorkflowManagedActions
    {
        public OpenfdadrugipActions Openfdadrugip(string connectionId) => new OpenfdadrugipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenfdadrugipTriggers Openfdadrugip(string connectionId) => new OpenfdadrugipTriggers(connectionId);
    }
}