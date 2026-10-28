//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdaysoap
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkdaysoapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string> SOAPOperation(Expression<Func<serviceInput>> service, Expression<Func<string>> version, Expression<Func<string>> requestBody = null)
        {
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/SOAPOperation/{0}/{1}", __workflow_service.WithUrlEncoding(1), __workflow_version.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string> RaaSOperation(Expression<Func<string>> accountName, Expression<Func<string>> reportName, Expression<Func<string>> reportInstanceName, Expression<Func<string>> requestBody = null)
        {
            var __workflow_accountName = WorkflowExpression.Compile(accountName, nameof(accountName), required: true);
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: true);
            var __workflow_reportInstanceName = WorkflowExpression.Compile(reportInstanceName, nameof(reportInstanceName), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RaaSOperation/{0}/{1}/{2}", __workflow_reportInstanceName.WithUrlEncoding(1), __workflow_accountName.WithUrlEncoding(1), __workflow_reportName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WorkdaysoapTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
