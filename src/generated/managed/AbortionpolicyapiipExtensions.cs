//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abortionpolicyapiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbortionpolicyapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetGestationalLimitsbyStateResponse> GetGestationalLimitsbyState([WorkflowExpression] Func<stateInput> state)
        {
            SourceExpression.Validate(state, nameof(state), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/gestational_limits/states/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(state, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetGestationalLimitsbyStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetGestationalLimitsbyStatebyZipResponse> GetGestationalLimitsbyStatebyZip([WorkflowExpression] Func<string> zipCode)
        {
            SourceExpression.Validate(zipCode, nameof(zipCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/gestational_limits/zips/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(zipCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetGestationalLimitsbyStatebyZipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetInsuranceCoveragebyStateResponse> GetInsuranceCoveragebyState([WorkflowExpression] Func<stateInput> state)
        {
            SourceExpression.Validate(state, nameof(state), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/insurance_coverage/states/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(state, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInsuranceCoveragebyStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetInsuranceCoveragebyZipResponse> GetInsuranceCoveragebyZip([WorkflowExpression] Func<string> zipCode)
        {
            SourceExpression.Validate(zipCode, nameof(zipCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/insurance_coverage/zips/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(zipCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInsuranceCoveragebyZipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetMinorsInfobyStateResponse> GetMinorsInfobyState([WorkflowExpression] Func<stateInput> state)
        {
            SourceExpression.Validate(state, nameof(state), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/minors/states/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(state, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMinorsInfobyStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetMinorsInfobyZipResponse> GetMinorsInfobyZip([WorkflowExpression] Func<string> zipCode)
        {
            SourceExpression.Validate(zipCode, nameof(zipCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/minors/zips/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(zipCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMinorsInfobyZipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetWaitingPeriodsInfobyStateResponse> GetWaitingPeriodsInfobyState([WorkflowExpression] Func<stateInput> state)
        {
            SourceExpression.Validate(state, nameof(state), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/waiting_periods/states/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(state, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWaitingPeriodsInfobyStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abortionpolicyapiip")]
        public IBodyWorkflowAction<GetWaitingPeriodsInfobyZipResponse> GetWaitingPeriodsInfobyZip([WorkflowExpression] Func<string> zipCode)
        {
            SourceExpression.Validate(zipCode, nameof(zipCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/waiting_periods/zips/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(zipCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWaitingPeriodsInfobyZipResponse>(BuildSourceInput);
        }
    }

    public class AbortionpolicyapiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetGestationalLimitsbyStateResponse
    {
        public GetGestationalLimitsbyStateResponseStateType State { get; set; }
    }

    public class GetGestationalLimitsbyStateResponseStateType
    {
        [JsonProperty("banned_after_weeks_since_LMP")]
        public int BannedAfterWeeksSinceLMP { get; set; }

        [JsonProperty("exception_life")]
        public bool ExceptionLife { get; set; }

        [JsonProperty("exception_health")]
        public string ExceptionHealth { get; set; }

        [JsonProperty("exception_fetal")]
        public string ExceptionFetal { get; set; }

        [JsonProperty("exception_rape_or_incest")]
        public bool ExceptionRapeOrIncest { get; set; }

        [JsonProperty("Last Updated")]
        public string LastUpdated { get; set; }
    }

    public enum stateInput
    {
        Alabama,
        Alaska,
        Arizona,
        Arkansas,
        California,
        Colorado,
        Connecticut,
        Delaware,
        Florida,
        Georgia,
        Hawaii,
        Idaho,
        Illinois,
        Indiana,
        Iowa,
        Kansas,
        Kentucky,
        Louisiana,
        Maine,
        Maryland,
        Massachusetts,
        Michigan,
        Minnesota,
        Mississippi,
        Missouri,
        Montana,
        Nebraska,
        Nevada,
        [EnumMember(Value = "New Hampshire")]
        NewHampshire,
        [EnumMember(Value = "New Jersey")]
        NewJersey,
        [EnumMember(Value = "New Mexico")]
        NewMexico,
        [EnumMember(Value = "New York")]
        NewYork,
        [EnumMember(Value = "North Carolina")]
        NorthCarolina,
        [EnumMember(Value = "North Dakota")]
        NorthDakota,
        Ohio,
        Oklahoma,
        Oregon,
        Pennsylvania,
        [EnumMember(Value = "Rhode Island")]
        RhodeIsland,
        [EnumMember(Value = "South Carolina")]
        SouthCarolina,
        [EnumMember(Value = "South Dakota")]
        SouthDakota,
        Tennessee,
        Texas,
        Utah,
        Vermont,
        Virginia,
        Washington,
        [EnumMember(Value = "West Virginia")]
        WestVirginia,
        Wisconsin,
        Wyoming
    }

    public class GetGestationalLimitsbyStatebyZipResponse
    {
        public GetGestationalLimitsbyStatebyZipResponseStateType State { get; set; }
    }

    public class GetGestationalLimitsbyStatebyZipResponseStateType
    {
        [JsonProperty("banned_after_weeks_since_LMP")]
        public int BannedAfterWeeksSinceLMP { get; set; }

        [JsonProperty("exception_life")]
        public bool ExceptionLife { get; set; }

        [JsonProperty("exception_health")]
        public string ExceptionHealth { get; set; }

        [JsonProperty("exception_fetal")]
        public string ExceptionFetal { get; set; }

        [JsonProperty("exception_rape_or_incest")]
        public bool ExceptionRapeOrIncest { get; set; }

        [JsonProperty("Last Updated")]
        public string LastUpdated { get; set; }
    }

    public class GetInsuranceCoveragebyStateResponse
    {
        public GetInsuranceCoveragebyStateResponseStateType State { get; set; }
    }

    public class GetInsuranceCoveragebyStateResponseStateType
    {
        [JsonProperty("requires coverage")]
        public bool RequiresCoverage { get; set; }

        [JsonProperty("private_coverage_no_restrictions")]
        public bool PrivateCoverageNoRestrictions { get; set; }

        [JsonProperty("private_exception_life")]
        public bool PrivateExceptionLife { get; set; }

        [JsonProperty("private_exception_fetal")]
        public string PrivateExceptionFetal { get; set; }

        [JsonProperty("private_exception_rape_or_incest")]
        public bool PrivateExceptionRapeOrIncest { get; set; }

        [JsonProperty("private_exception_health")]
        public string PrivateExceptionHealth { get; set; }

        [JsonProperty("exchange_exception_life")]
        public bool ExchangeExceptionLife { get; set; }

        [JsonProperty("exchange_exception_health")]
        public string ExchangeExceptionHealth { get; set; }

        [JsonProperty("exchange_coverage_no_restrictions")]
        public bool ExchangeCoverageNoRestrictions { get; set; }

        [JsonProperty("exchange_exception_fetal")]
        public string ExchangeExceptionFetal { get; set; }

        [JsonProperty("exchange_exception_rape_or_incest")]
        public bool ExchangeExceptionRapeOrIncest { get; set; }

        [JsonProperty("exchange_forbids_coverage")]
        public bool ExchangeForbidsCoverage { get; set; }

        [JsonProperty("medicaid_coverage_provider_patient_decision")]
        public bool MedicaidCoverageProviderPatientDecision { get; set; }

        [JsonProperty("medicaid_exception_life")]
        public bool MedicaidExceptionLife { get; set; }

        [JsonProperty("medicaid_exception_health")]
        public string MedicaidExceptionHealth { get; set; }

        [JsonProperty("medicaid_exception_fetal")]
        public string MedicaidExceptionFetal { get; set; }

        [JsonProperty("medicaid_exception_rape_or_incest")]
        public bool MedicaidExceptionRapeOrIncest { get; set; }

        [JsonProperty("Last Updated")]
        public string LastUpdated { get; set; }
    }

    public class GetInsuranceCoveragebyZipResponse
    {
        public GetInsuranceCoveragebyZipResponseStateType State { get; set; }
    }

    public class GetInsuranceCoveragebyZipResponseStateType
    {
        [JsonProperty("requires coverage")]
        public bool RequiresCoverage { get; set; }

        [JsonProperty("private_coverage_no_restrictions")]
        public bool PrivateCoverageNoRestrictions { get; set; }

        [JsonProperty("private_exception_life")]
        public bool PrivateExceptionLife { get; set; }

        [JsonProperty("private_exception_fetal")]
        public string PrivateExceptionFetal { get; set; }

        [JsonProperty("private_exception_rape_or_incest")]
        public bool PrivateExceptionRapeOrIncest { get; set; }

        [JsonProperty("private_exception_health")]
        public string PrivateExceptionHealth { get; set; }

        [JsonProperty("exchange_exception_life")]
        public bool ExchangeExceptionLife { get; set; }

        [JsonProperty("exchange_exception_health")]
        public string ExchangeExceptionHealth { get; set; }

        [JsonProperty("exchange_coverage_no_restrictions")]
        public bool ExchangeCoverageNoRestrictions { get; set; }

        [JsonProperty("exchange_exception_fetal")]
        public string ExchangeExceptionFetal { get; set; }

        [JsonProperty("exchange_exception_rape_or_incest")]
        public bool ExchangeExceptionRapeOrIncest { get; set; }

        [JsonProperty("exchange_forbids_coverage")]
        public bool ExchangeForbidsCoverage { get; set; }

        [JsonProperty("medicaid_coverage_provider_patient_decision")]
        public bool MedicaidCoverageProviderPatientDecision { get; set; }

        [JsonProperty("medicaid_exception_life")]
        public bool MedicaidExceptionLife { get; set; }

        [JsonProperty("medicaid_exception_health")]
        public string MedicaidExceptionHealth { get; set; }

        [JsonProperty("medicaid_exception_fetal")]
        public string MedicaidExceptionFetal { get; set; }

        [JsonProperty("medicaid_exception_rape_or_incest")]
        public bool MedicaidExceptionRapeOrIncest { get; set; }

        [JsonProperty("Last Updated")]
        public string LastUpdated { get; set; }
    }

    public class GetMinorsInfobyStateResponse
    {
        public GetMinorsInfobyStateResponseStateType State { get; set; }
    }

    public class GetMinorsInfobyStateResponseStateType
    {
        [JsonProperty("parents_required")]
        public int ParentsRequired { get; set; }

        [JsonProperty("below_age")]
        public int BelowAge { get; set; }

        [JsonProperty("parental_consent_required")]
        public bool ParentalConsentRequired { get; set; }

        [JsonProperty("parental_notification_required")]
        public bool ParentalNotificationRequired { get; set; }

        [JsonProperty("judicial_bypass_available")]
        public bool JudicialBypassAvailable { get; set; }

        [JsonProperty("allows_minor_to_consent")]
        public bool AllowsMinorToConsent { get; set; }
    }

    public class GetMinorsInfobyZipResponse
    {
        public GetMinorsInfobyZipResponseStateType State { get; set; }
    }

    public class GetMinorsInfobyZipResponseStateType
    {
        [JsonProperty("parents_required")]
        public int ParentsRequired { get; set; }

        [JsonProperty("below_age")]
        public int BelowAge { get; set; }

        [JsonProperty("parental_consent_required")]
        public bool ParentalConsentRequired { get; set; }

        [JsonProperty("parental_notification_required")]
        public bool ParentalNotificationRequired { get; set; }

        [JsonProperty("judicial_bypass_available")]
        public bool JudicialBypassAvailable { get; set; }

        [JsonProperty("allows_minor_to_consent")]
        public bool AllowsMinorToConsent { get; set; }
    }

    public class GetWaitingPeriodsInfobyStateResponse
    {
        public GetWaitingPeriodsInfobyStateResponseStateType State { get; set; }
    }

    public class GetWaitingPeriodsInfobyStateResponseStateType
    {
        [JsonProperty("waiting_period_hours")]
        public int WaitingPeriodHours { get; set; }

        [JsonProperty("counseling_visits")]
        public int CounselingVisits { get; set; }

        [JsonProperty("exception_health")]
        public string ExceptionHealth { get; set; }

        [JsonProperty("waiting_period_notes")]
        public string WaitingPeriodNotes { get; set; }

        [JsonProperty("counseling_waived_condition")]
        public string CounselingWaivedCondition { get; set; }

        [JsonProperty("Last Updated")]
        public string LastUpdated { get; set; }
    }

    public class GetWaitingPeriodsInfobyZipResponse
    {
        public GetWaitingPeriodsInfobyZipResponseStateType State { get; set; }
    }

    public class GetWaitingPeriodsInfobyZipResponseStateType
    {
        [JsonProperty("waiting_period_hours")]
        public int WaitingPeriodHours { get; set; }

        [JsonProperty("counseling_visits")]
        public int CounselingVisits { get; set; }

        [JsonProperty("exception_health")]
        public string ExceptionHealth { get; set; }

        [JsonProperty("waiting_period_notes")]
        public string WaitingPeriodNotes { get; set; }

        [JsonProperty("counseling_waived_condition")]
        public string CounselingWaivedCondition { get; set; }

        [JsonProperty("Last Updated")]
        public string LastUpdated { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abortionpolicyapiip;

    public partial class WorkflowManagedActions
    {
        public AbortionpolicyapiipActions Abortionpolicyapiip(string connectionId) => new AbortionpolicyapiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbortionpolicyapiipTriggers Abortionpolicyapiip(string connectionId) => new AbortionpolicyapiipTriggers(connectionId);
    }
}