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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SOAPOperation(Expression<Func<serviceInput>> service, Expression<Func<string>> version, Expression<Func<string>> requestBody = null)
        {
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/SOAPOperation/{0}/{1}", __workflow_service.WithUrlEncoding(1), __workflow_version.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RaaSOperation(Expression<Func<string>> accountName, Expression<Func<string>> reportName, Expression<Func<string>> reportInstanceName, Expression<Func<string>> requestBody = null)
        {
            var __workflow_accountName = WorkflowExpression.Compile(accountName, nameof(accountName), required: true);
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: true);
            var __workflow_reportInstanceName = WorkflowExpression.Compile(reportInstanceName, nameof(reportInstanceName), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RaaSOperation/{0}/{1}/{2}", __workflow_reportInstanceName.WithUrlEncoding(1), __workflow_accountName.WithUrlEncoding(1), __workflow_reportName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RESTOperation(Expression<Func<string>> relativePath, Expression<Func<methodInput>> method = null, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<string>> body = null)
        {
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RESTOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                callPayload.Queries["method"] = Convert.ToString("GET");
                if (__workflow_method != null)
                    callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Queries["contentType"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<InboxTasksResponse, ApiConnectionActionConfiguration> GetWorkerInboxTasks(Expression<Func<string>> workerId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_workerId = WorkflowExpression.Compile(workerId, nameof(workerId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<InboxTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RESTOperation/workers/{0}/inboxTasks", __workflow_workerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<InboxTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<JobChangeResponse, ApiConnectionActionConfiguration> TransferEmployee(Expression<Func<string>> workerId, Expression<Func<string>> bodyeffectiveDate, Expression<Func<string>> bodysupervisoryOrganizationid = null, Expression<Func<string>> bodyjobChangeReasonid = null, Expression<Func<bool>> bodymoveManagerSTeam = null)
        {
            var __workflow_workerId = WorkflowExpression.Compile(workerId, nameof(workerId), required: true);
            var __workflow_bodyeffectiveDate = WorkflowExpression.Compile(bodyeffectiveDate, nameof(bodyeffectiveDate), required: true);
            var __workflow_bodysupervisoryOrganizationid = WorkflowExpression.Compile(bodysupervisoryOrganizationid, nameof(bodysupervisoryOrganizationid), required: false);
            var __workflow_bodyjobChangeReasonid = WorkflowExpression.Compile(bodyjobChangeReasonid, nameof(bodyjobChangeReasonid), required: false);
            var __workflow_bodymoveManagerSTeam = WorkflowExpression.Compile(bodymoveManagerSTeam, nameof(bodymoveManagerSTeam), required: false);
            return new DeferredBodyAction<JobChangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RESTOperation/workers/{0}/jobChanges", __workflow_workerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var supervisoryOrganizationObject = new JObject();
                var supervisoryOrganizationObjectpropCount = 0;
                if (__workflow_bodysupervisoryOrganizationid != null)
                {
                    supervisoryOrganizationObject["id"] = ExpressionConverter.ConvertO(__workflow_bodysupervisoryOrganizationid);
                    supervisoryOrganizationObjectpropCount++;
                }

                if (supervisoryOrganizationObjectpropCount > 0)
                {
                    body["supervisoryOrganization"] = supervisoryOrganizationObject;
                    bodypropCount++;
                }

                var jobChangeReasonObject = new JObject();
                var jobChangeReasonObjectpropCount = 0;
                if (__workflow_bodysupervisoryOrganizationid != null)
                {
                    jobChangeReasonObject["id"] = ExpressionConverter.ConvertO(__workflow_bodysupervisoryOrganizationid);
                    jobChangeReasonObjectpropCount++;
                }

                if (jobChangeReasonObjectpropCount > 0)
                {
                    body["jobChangeReason"] = jobChangeReasonObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["effective"] = ExpressionConverter.ConvertO(__workflow_bodyeffectiveDate);
                if (__workflow_bodymoveManagerSTeam != null)
                {
                    body["moveManagersTeam"] = ExpressionConverter.ConvertO(__workflow_bodymoveManagerSTeam);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JobChangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<RequestFeedbackResponse, ApiConnectionActionConfiguration> RequestFeedback(Expression<Func<string>> workerId, Expression<Func<WorkdayObjectReference[]>> bodyfeedbackResponders, Expression<Func<string>> bodyfeedbackTemplateid = null, Expression<Func<bool>> bodyconfidential = null, Expression<Func<bool>> bodyshowProviderName = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var __workflow_workerId = WorkflowExpression.Compile(workerId, nameof(workerId), required: true);
            var __workflow_bodyfeedbackResponders = WorkflowExpression.Compile(bodyfeedbackResponders, nameof(bodyfeedbackResponders), required: true);
            var __workflow_bodyfeedbackTemplateid = WorkflowExpression.Compile(bodyfeedbackTemplateid, nameof(bodyfeedbackTemplateid), required: false);
            var __workflow_bodyconfidential = WorkflowExpression.Compile(bodyconfidential, nameof(bodyconfidential), required: false);
            var __workflow_bodyshowProviderName = WorkflowExpression.Compile(bodyshowProviderName, nameof(bodyshowProviderName), required: false);
            var __workflow_bodyexpirationDate = WorkflowExpression.Compile(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<RequestFeedbackResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RESTOperation/workers/{0}/requestedFeedbackOnWorkerEvents", __workflow_workerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackResponders"] = ExpressionConverter.ConvertO(__workflow_bodyfeedbackResponders);
                var feedbackTemplateObject = new JObject();
                var feedbackTemplateObjectpropCount = 0;
                if (__workflow_bodyfeedbackTemplateid != null)
                {
                    feedbackTemplateObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyfeedbackTemplateid);
                    feedbackTemplateObjectpropCount++;
                }

                if (feedbackTemplateObjectpropCount > 0)
                {
                    body["feedbackTemplate"] = feedbackTemplateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyconfidential != null)
                {
                    body["feedbackConfidential"] = ExpressionConverter.ConvertO(__workflow_bodyconfidential);
                    bodypropCount++;
                }

                if (__workflow_bodyshowProviderName != null)
                {
                    body["showFeedbackProviderName"] = ExpressionConverter.ConvertO(__workflow_bodyshowProviderName);
                    bodypropCount++;
                }

                if (__workflow_bodyexpirationDate != null)
                {
                    body["expirationDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RequestFeedbackResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<FeedbackTemplatesResponse, ApiConnectionActionConfiguration> GetFeedbackTemplates(Expression<Func<string>> search = null, Expression<Func<string>> templateType = null, Expression<Func<string>> worker = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_templateType = WorkflowExpression.Compile(templateType, nameof(templateType), required: false);
            var __workflow_worker = WorkflowExpression.Compile(worker, nameof(worker), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FeedbackTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RESTOperation/feedbackTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_templateType != null)
                    callPayload.Queries["templateType"] = ExpressionConverter.Convert(__workflow_templateType);
                if (__workflow_worker != null)
                    callPayload.Queries["worker"] = ExpressionConverter.Convert(__workflow_worker);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<FeedbackTemplatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<WorkerSummaryResponse, ApiConnectionActionConfiguration> SearchWorkers(Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<WorkerSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RESTOperation/workers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<WorkerSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<WorkerSummary, ApiConnectionActionConfiguration> GetWorkerMe()
        {
            return new DeferredBodyAction<WorkerSummary, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RESTOperation/workers/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkerSummary>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<SupervisoryOrganizationsResponse, ApiConnectionActionConfiguration> GetSupervisoryOrganizationsManaged(Expression<Func<string>> workerId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_workerId = WorkflowExpression.Compile(workerId, nameof(workerId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<SupervisoryOrganizationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RESTOperation/workers/{0}/supervisoryOrganizationsManaged", __workflow_workerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<SupervisoryOrganizationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<DirectReportsResponse, ApiConnectionActionConfiguration> GetWorkerDirectReports(Expression<Func<string>> workerId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_workerId = WorkflowExpression.Compile(workerId, nameof(workerId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DirectReportsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RESTOperation/workers/{0}/directReports", __workflow_workerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<DirectReportsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdaysoap")]
        public IBodyWorkflowAction<PaySlipsResponse, ApiConnectionActionConfiguration> GetWorkerPaySlips(Expression<Func<string>> workerId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_workerId = WorkflowExpression.Compile(workerId, nameof(workerId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<PaySlipsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RESTOperation/workers/{0}/paySlips", __workflow_workerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<PaySlipsResponse>(callPayload);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string TaskId { get; set; }

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
        public string Id { get; set; }
    }

    public class JobChangeResponse
    {
        [JsonProperty("id")]
        public string ProcessId { get; set; }

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
        public string EventId { get; set; }

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
        public string TemplateId { get; set; }

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
        public string WorkerId { get; set; }

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
        public string OrganizationId { get; set; }

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
        public string WorkerId { get; set; }

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
        public string PaySlipId { get; set; }

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