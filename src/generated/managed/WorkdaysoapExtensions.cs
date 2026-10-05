//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdaysoap
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkdaysoapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        [WorkflowExpressionFactory(nameof(__BuildSOAPOperation))]
        public IBodyWorkflowAction<string> SOAPOperation([WorkflowExpression] Func<serviceInput> service, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> requestBody = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSOAPOperation(WorkflowValue<serviceInput> service, WorkflowValue<string> version, WorkflowValue<string> requestBody = null)
        {
            WorkflowValue.Validate(service, nameof(service), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            WorkflowValue.Validate(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/SOAPOperation/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(service, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        [WorkflowExpressionFactory(nameof(__BuildRaaSOperation))]
        public IBodyWorkflowAction<string> RaaSOperation([WorkflowExpression] Func<string> accountName, [WorkflowExpression] Func<string> reportName, [WorkflowExpression] Func<string> reportInstanceName, [WorkflowExpression] Func<string> requestBody = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRaaSOperation(WorkflowValue<string> accountName, WorkflowValue<string> reportName, WorkflowValue<string> reportInstanceName, WorkflowValue<string> requestBody = null)
        {
            WorkflowValue.Validate(accountName, nameof(accountName), required: true);
            WorkflowValue.Validate(reportName, nameof(reportName), required: true);
            WorkflowValue.Validate(reportInstanceName, nameof(reportInstanceName), required: true);
            WorkflowValue.Validate(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/RaaSOperation/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(reportInstanceName, 1), ExpressionConverter.ConvertWithUrlEncoding(accountName, 1), ExpressionConverter.ConvertWithUrlEncoding(reportName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WorkdaysoapTriggers([ConnectionName] string connectionId)
    {
    }

    public enum serviceInput
    {
        [EnumMember(Value = "Human_Resources")]
        HumanResources,
        [EnumMember(Value = "Financial_Management")]
        FinancialManagement,
        Talent,
        [EnumMember(Value = "Absence_Management")]
        AbsenceManagement,
        [EnumMember(Value = "Academic_Advising")]
        AcademicAdvising,
        Admissions,
        Adoption,
        [EnumMember(Value = "Benefits_Administration")]
        BenefitsAdministration,
        [EnumMember(Value = "Benefits_Partner_Program_Integrations")]
        BenefitsPartnerProgramIntegrations,
        [EnumMember(Value = "Campus_Engagement")]
        CampusEngagement,
        [EnumMember(Value = "Cash_Management")]
        CashManagement,
        Compensation,
        [EnumMember(Value = "Compensation_Review")]
        CompensationReview,
        Drive,
        [EnumMember(Value = "Dynamic_Document_Generation")]
        DynamicDocumentGeneration,
        [EnumMember(Value = "External_Integrations")]
        ExternalIntegrations,
        [EnumMember(Value = "Financial_Aid")]
        FinancialAid,
        [EnumMember(Value = "Identity_Management")]
        IdentityManagement,
        Integrations,
        Inventory,
        Learning,
        [EnumMember(Value = "Metadata_Translations")]
        MetadataTranslations,
        Moments,
        Notification,
        [EnumMember(Value = "Org_Studio")]
        OrgStudio,
        Payroll,
        [EnumMember(Value = "Payroll_AUS")]
        PayrollAUS,
        [EnumMember(Value = "Payroll_CAN")]
        PayrollCAN,
        [EnumMember(Value = "Payroll_FRA")]
        PayrollFRA,
        [EnumMember(Value = "Payroll_GBR")]
        PayrollGBR,
        [EnumMember(Value = "Payroll_Interface")]
        PayrollInterface,
        [EnumMember(Value = "Performance_Management")]
        PerformanceManagement,
        [EnumMember(Value = "Professional_Services_Automation")]
        ProfessionalServicesAutomation,
        Recruiting,
        [EnumMember(Value = "Resource_Management")]
        ResourceManagement,
        [EnumMember(Value = "Revenue_Management")]
        RevenueManagement,
        Scheduling,
        [EnumMember(Value = "Settlement_Services")]
        SettlementServices,
        Staffing,
        [EnumMember(Value = "Student_Core")]
        StudentCore,
        [EnumMember(Value = "Student_Finance")]
        StudentFinance,
        [EnumMember(Value = "Student_Records")]
        StudentRecords,
        [EnumMember(Value = "Student_Recruiting")]
        StudentRecruiting,
        [EnumMember(Value = "Student_Transfer_Credit")]
        StudentTransferCredit,
        [EnumMember(Value = "Tenant_Data_Translation")]
        TenantDataTranslation,
        [EnumMember(Value = "Time_Tracking")]
        TimeTracking,
        [EnumMember(Value = "Workday_Connect")]
        WorkdayConnect,
        [EnumMember(Value = "Workday_Extensibility")]
        WorkdayExtensibility,
        [EnumMember(Value = "Workforce_Planning")]
        WorkforcePlanning
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workdaysoap;

    public partial class WorkflowManagedActions
    {
        public WorkdaysoapActions Workdaysoap(string connectionId) => new WorkdaysoapActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkdaysoapTriggers Workdaysoap(string connectionId) => new WorkdaysoapTriggers(connectionId);
    }
}
