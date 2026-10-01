//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdaysoap
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkdaysoapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string> SOAPOperation([WorkflowExpression] Func<serviceInput> service, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> requestBody = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/SOAPOperation/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(requestBody);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string> RaaSOperation([WorkflowExpression] Func<string> accountName, [WorkflowExpression] Func<string> reportName, [WorkflowExpression] Func<string> reportInstanceName, [WorkflowExpression] Func<string> requestBody = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/RaaSOperation/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportInstanceName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(requestBody);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string> RESTOperation([WorkflowExpression] Func<string> relativePath, [WorkflowExpression] Func<methodInput> method = null, [WorkflowExpression] Func<contentTypeInput> contentType = null, [WorkflowExpression] Func<string> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RESTOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                callPayload.Queries["method"] = Convert.ToString("GET");
                if (method != null)
                    callPayload.Queries["method"] = SourceExpressionConverter.Convert(method);
                callPayload.Queries["contentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Queries["contentType"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<InboxTasksResponse> GetWorkerInboxTasks([WorkflowExpression] Func<string> workerId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/RESTOperation/workers/{0}/inboxTasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<InboxTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<JobChangeResponse> TransferEmployee([WorkflowExpression] Func<string> workerId, [WorkflowExpression] Func<string> bodyeffectiveDate, [WorkflowExpression] Func<string> bodysupervisoryOrganizationid = null, [WorkflowExpression] Func<string> bodyjobChangeReasonid = null, [WorkflowExpression] Func<bool> bodymoveManagerSTeam = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/RESTOperation/workers/{0}/jobChanges", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var supervisoryOrganizationObject = new JObject();
                var supervisoryOrganizationObjectpropCount = 0;
                if (bodysupervisoryOrganizationid != null)
                {
                    supervisoryOrganizationObject["id"] = SourceExpressionConverter.ConvertToken(bodysupervisoryOrganizationid);
                    supervisoryOrganizationObjectpropCount++;
                }

                if (supervisoryOrganizationObjectpropCount > 0)
                {
                    body["supervisoryOrganization"] = supervisoryOrganizationObject;
                    bodypropCount++;
                }

                var jobChangeReasonObject = new JObject();
                var jobChangeReasonObjectpropCount = 0;
                if (bodysupervisoryOrganizationid != null)
                {
                    jobChangeReasonObject["id"] = SourceExpressionConverter.ConvertToken(bodysupervisoryOrganizationid);
                    jobChangeReasonObjectpropCount++;
                }

                if (jobChangeReasonObjectpropCount > 0)
                {
                    body["jobChangeReason"] = jobChangeReasonObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["effective"] = SourceExpressionConverter.ConvertToken(bodyeffectiveDate);
                if (bodymoveManagerSTeam != null)
                {
                    body["moveManagersTeam"] = SourceExpressionConverter.ConvertToken(bodymoveManagerSTeam);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JobChangeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<RequestFeedbackResponse> RequestFeedback([WorkflowExpression] Func<string> workerId, [WorkflowExpression] Func<WorkdayObjectReference[]> bodyfeedbackResponders, [WorkflowExpression] Func<string> bodyfeedbackTemplateid = null, [WorkflowExpression] Func<bool> bodyconfidential = null, [WorkflowExpression] Func<bool> bodyshowProviderName = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/RESTOperation/workers/{0}/requestedFeedbackOnWorkerEvents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackResponders"] = SourceExpressionConverter.ConvertToken(bodyfeedbackResponders);
                var feedbackTemplateObject = new JObject();
                var feedbackTemplateObjectpropCount = 0;
                if (bodyfeedbackTemplateid != null)
                {
                    feedbackTemplateObject["id"] = SourceExpressionConverter.ConvertToken(bodyfeedbackTemplateid);
                    feedbackTemplateObjectpropCount++;
                }

                if (feedbackTemplateObjectpropCount > 0)
                {
                    body["feedbackTemplate"] = feedbackTemplateObject;
                    bodypropCount++;
                }

                if (bodyconfidential != null)
                {
                    body["feedbackConfidential"] = SourceExpressionConverter.ConvertToken(bodyconfidential);
                    bodypropCount++;
                }

                if (bodyshowProviderName != null)
                {
                    body["showFeedbackProviderName"] = SourceExpressionConverter.ConvertToken(bodyshowProviderName);
                    bodypropCount++;
                }

                if (bodyexpirationDate != null)
                {
                    body["expirationDate"] = SourceExpressionConverter.ConvertToken(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RequestFeedbackResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<FeedbackTemplatesResponse> GetFeedbackTemplates([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> templateType = null, [WorkflowExpression] Func<string> worker = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RESTOperation/feedbackTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (templateType != null)
                    callPayload.Queries["templateType"] = SourceExpressionConverter.ConvertO(templateType);
                if (worker != null)
                    callPayload.Queries["worker"] = SourceExpressionConverter.ConvertO(worker);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<FeedbackTemplatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<WorkerSummaryResponse> SearchWorkers([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RESTOperation/workers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<WorkerSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<WorkerSummary> GetWorkerMe()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RESTOperation/workers/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WorkerSummary>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<SupervisoryOrganizationsResponse> GetSupervisoryOrganizationsManaged([WorkflowExpression] Func<string> workerId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/RESTOperation/workers/{0}/supervisoryOrganizationsManaged", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<SupervisoryOrganizationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<DirectReportsResponse> GetWorkerDirectReports([WorkflowExpression] Func<string> workerId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/RESTOperation/workers/{0}/directReports", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<DirectReportsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<PaySlipsResponse> GetWorkerPaySlips([WorkflowExpression] Func<string> workerId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/RESTOperation/workers/{0}/paySlips", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<PaySlipsResponse>(BuildSourceInput);
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

    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "application/json")]
        ApplicationJson,
        [EnumMember(Value = "application/xml")]
        ApplicationXml,
        [EnumMember(Value = "text/xml")]
        TextXml,
        [EnumMember(Value = "text/plain")]
        TextPlain
    }

    public class InboxTasksResponse
    {
        [JsonProperty("data")]
        public InboxTask[] Tasks { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class InboxTask
    {
        [JsonProperty("id")]
        public string TaskID { get; set; }

        [JsonProperty("descriptor")]
        public string TaskTitle { get; set; }

        [JsonProperty("href")]
        public string WorkdayLink { get; set; }

        [JsonProperty("assigned")]
        public string AssignedDate { get; set; }

        [JsonProperty("due")]
        public string DueDate { get; set; }

        [JsonProperty("status")]
        public WorkdayObjectReference Status { get; set; }

        [JsonProperty("stepType")]
        public WorkdayObjectReference StepType { get; set; }

        [JsonProperty("initiator")]
        public WorkdayObjectReference Initiator { get; set; }

        [JsonProperty("subject")]
        public WorkdayObjectReference Subject { get; set; }

        [JsonProperty("overallProcess")]
        public WorkdayObjectReference OverallProcess { get; set; }
    }

    public class WorkdayObjectReference
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class JobChangeResponse
    {
        [JsonProperty("id")]
        public string ProcessID { get; set; }

        [JsonProperty("descriptor")]
        public string TaskTitle { get; set; }

        [JsonProperty("href")]
        public string WorkdayLink { get; set; }

        [JsonProperty("effective")]
        public string EffectiveDate { get; set; }

        [JsonProperty("supervisoryOrganization")]
        public WorkdayObjectReference SupervisoryOrganization { get; set; }
    }

    public class RequestFeedbackResponse
    {
        [JsonProperty("id")]
        public string EventID { get; set; }

        [JsonProperty("descriptor")]
        public string Description { get; set; }

        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        [JsonProperty("feedbackOverallStatus")]
        public string Status { get; set; }

        [JsonProperty("feedbackAbout")]
        public WorkdayObjectReference FeedbackAbout { get; set; }
    }

    public class FeedbackTemplatesResponse
    {
        [JsonProperty("data")]
        public FeedbackTemplate[] Templates { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class FeedbackTemplate
    {
        [JsonProperty("id")]
        public string TemplateID { get; set; }

        [JsonProperty("descriptor")]
        public string TemplateName { get; set; }
    }

    public class WorkerSummaryResponse
    {
        [JsonProperty("data")]
        public WorkerSummary[] Workers { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class WorkerSummary
    {
        [JsonProperty("id")]
        public string WorkerID { get; set; }

        [JsonProperty("descriptor")]
        public string WorkerName { get; set; }

        [JsonProperty("href")]
        public string WorkerURL { get; set; }

        [JsonProperty("isManager")]
        public bool IsManager { get; set; }

        [JsonProperty("businessTitle")]
        public string BusinessTitle { get; set; }

        [JsonProperty("primaryWorkEmail")]
        public string WorkEmail { get; set; }

        [JsonProperty("primaryWorkPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("primarySupervisoryOrganization")]
        public WorkdayObjectReference PrimarySupervisoryOrganization { get; set; }
    }

    public class SupervisoryOrganizationsResponse
    {
        [JsonProperty("data")]
        public SupervisoryOrganization[] Organizations { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class SupervisoryOrganization
    {
        [JsonProperty("id")]
        public string OrganizationID { get; set; }

        [JsonProperty("descriptor")]
        public string OrganizationName { get; set; }

        [JsonProperty("href")]
        public string OrganizationURL { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DirectReportsResponse
    {
        [JsonProperty("data")]
        public DirectReport[] DirectReports { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DirectReport
    {
        [JsonProperty("id")]
        public string WorkerID { get; set; }

        [JsonProperty("descriptor")]
        public string WorkerName { get; set; }

        [JsonProperty("href")]
        public string WorkerURL { get; set; }

        [JsonProperty("isManager")]
        public bool IsManager { get; set; }

        [JsonProperty("businessTitle")]
        public string BusinessTitle { get; set; }

        [JsonProperty("primaryWorkEmail")]
        public string WorkEmail { get; set; }

        [JsonProperty("primaryWorkPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("primarySupervisoryOrganization")]
        public WorkdayObjectReference PrimarySupervisoryOrganization { get; set; }
    }

    public class PaySlipsResponse
    {
        [JsonProperty("data")]
        public PaySlip[] PaySlips { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class PaySlip
    {
        [JsonProperty("id")]
        public string PaySlipID { get; set; }

        [JsonProperty("descriptor")]
        public string PayPeriod { get; set; }

        [JsonProperty("href")]
        public string WorkdayLink { get; set; }

        [JsonProperty("date")]
        public string PaymentDate { get; set; }

        [JsonProperty("gross")]
        public double GrossPay { get; set; }

        [JsonProperty("net")]
        public double NetPay { get; set; }

        [JsonProperty("status")]
        public WorkdayObjectReference Status { get; set; }
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