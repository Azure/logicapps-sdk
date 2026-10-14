//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdaysoap
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class WorkdaysoapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string> SOAPOperation(Expression<Func<serviceInput>> service, Expression<Func<string>> version, Expression<Func<string>> requestBody = null)
        {
            var __workflow_service = service == null ? null : WorkflowExpression.Compile(service);
            WorkflowExpression.Validate(__workflow_service, nameof(service), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_requestBody = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            WorkflowExpression.Validate(__workflow_requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/SOAPOperation/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_service, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string> RaaSOperation(Expression<Func<string>> accountName, Expression<Func<string>> reportName, Expression<Func<string>> reportInstanceName, Expression<Func<string>> requestBody = null)
        {
            var __workflow_accountName = accountName == null ? null : WorkflowExpression.Compile(accountName);
            WorkflowExpression.Validate(__workflow_accountName, nameof(accountName), required: true);
            var __workflow_reportName = reportName == null ? null : WorkflowExpression.Compile(reportName);
            WorkflowExpression.Validate(__workflow_reportName, nameof(reportName), required: true);
            var __workflow_reportInstanceName = reportInstanceName == null ? null : WorkflowExpression.Compile(reportInstanceName);
            WorkflowExpression.Validate(__workflow_reportInstanceName, nameof(reportInstanceName), required: true);
            var __workflow_requestBody = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            WorkflowExpression.Validate(__workflow_requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/RaaSOperation/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_reportInstanceName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_reportName, 1));
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
