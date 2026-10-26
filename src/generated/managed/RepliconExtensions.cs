//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Replicon
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RepliconActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<ProjectDetailsResponse, ApiConnectionActionConfiguration> BulkGetProjectDetails3(Expression<Func<string>> hostUrl, Expression<Func<BulkGetProjectDetails3Input>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ProjectDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/ProjectService1.svc/BulkGetProjectDetails3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<CreateProjectOrApplyModificationsResponse, ApiConnectionActionConfiguration> CreateProjectOrApplyModifications(Expression<Func<string>> hostUrl, Expression<Func<CreateProjectOrApplyModificationsInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateProjectOrApplyModificationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/ProjectService1.svc/CreateProjectOrApplyModifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProjectOrApplyModificationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<UserListServiceGetDataResponse, ApiConnectionActionConfiguration> UserListServiceGetData(Expression<Func<string>> hostUrl, Expression<Func<UserListServiceGetDataInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserListServiceGetDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/UserListService1.svc/GetData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserListServiceGetDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDescendantTaskDetails(Expression<Func<string>> hostUrl, Expression<Func<GetDescendantTaskDetailsInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/GetDescendantTaskDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<CreateTaskHierarchyOrApplyModificationsResponse, ApiConnectionActionConfiguration> CreateTaskHierarchyOrApplyModifications(Expression<Func<string>> hostUrl, Expression<Func<CreateTaskHierarchyOrApplyModificationsInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateTaskHierarchyOrApplyModificationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/CreateTaskHierarchyOrApplyModifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskHierarchyOrApplyModificationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTask(Expression<Func<string>> hostUrl, Expression<Func<MoveTaskInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/MoveTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<TaskListServiceGetDataResponse, ApiConnectionActionConfiguration> TaskListServiceGetData(Expression<Func<string>> hostUrl, Expression<Func<TaskListServiceGetDataInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskListServiceGetDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskListService1.svc/GetData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskListServiceGetDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<GetTimesheetSummaryResponse, ApiConnectionActionConfiguration> GetTimesheetSummary(Expression<Func<string>> hostUrl, Expression<Func<GetTimesheetSummaryInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetTimesheetSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TimesheetService1.svc/GetTimesheetSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTimesheetSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<BulkGetTimeEnteredSummaryResponse, ApiConnectionActionConfiguration> BulkGetTimeEnteredSummary(Expression<Func<string>> hostUrl, Expression<Func<BulkGetTimeEnteredSummaryInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BulkGetTimeEnteredSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/BulkGetTimeEnteredSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BulkGetTimeEnteredSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutProjectTeamMemberAssignments(Expression<Func<string>> hostUrl, Expression<Func<PutProjectTeamMemberAssignmentsInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/ProjectService1.svc/PutProjectTeamMemberAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutResourceAssignments(Expression<Func<string>> hostUrl, Expression<Func<PutResourceAssignmentsInput>> body = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/PutResourceAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<TenantEndpointDetails, ApiConnectionActionConfiguration> GetMyTenantEndpointDetails()
        {
            return new DeferredBodyAction<TenantEndpointDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DiscoveryService1.svc/GetMyTenantEndpointDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TenantEndpointDetails>(callPayload);
            });
        }
    }

    public class RepliconTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscriptionResponse, ApiConnectionTriggerConfiguration> WebhookSubscriptionsRestAPI(Expression<Func<string>> hostUrl, Expression<Func<WebhookSubscriptionsRestAPIInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook-api/api/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ProjectDetailsResponse
    {
        [JsonProperty("d")]
        public ProjectDetailsResponseDTypeItem[] D { get; set; }
    }

    public class ProjectDetailsResponseDTypeItem
    {
        [JsonProperty("error")]
        public ProjectDetailsResponseDTypeItemErrorType Error { get; set; }

        [JsonProperty("parameterCorrelationId")]
        public string ParameterCorrelationId { get; set; }

        [JsonProperty("projectDetails")]
        public ProjectDetailsResponseDTypeItemProjectDetailsType ProjectDetails { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemErrorType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsType
    {
        [JsonProperty("billingContract")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeBillingContractType BillingContract { get; set; }

        [JsonProperty("billingType")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeBillingTypeType BillingType { get; set; }

        [JsonProperty("budget")]
        public JToken Budget { get; set; }

        [JsonProperty("budgetedCost")]
        public JToken BudgetedCost { get; set; }

        [JsonProperty("budgetedHours")]
        public JToken BudgetedHours { get; set; }

        [JsonProperty("clientBillingAllocationMethod")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeClientBillingAllocationMethodType ClientBillingAllocationMethod { get; set; }

        [JsonProperty("clientRepresentative")]
        public string ClientRepresentative { get; set; }

        [JsonProperty("clientSchedule")]
        public JToken[] ClientSchedule { get; set; }

        [JsonProperty("clients")]
        public JToken[] Clients { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("costCenter")]
        public JToken CostCenter { get; set; }

        [JsonProperty("costType")]
        public JToken CostType { get; set; }

        [JsonProperty("customFields")]
        public JToken[] CustomFields { get; set; }

        [JsonProperty("defaultBillingCurrency")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeDefaultBillingCurrencyType DefaultBillingCurrency { get; set; }

        [JsonProperty("departmentGroup")]
        public JToken DepartmentGroup { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("division")]
        public JToken Division { get; set; }

        [JsonProperty("employeeTypeGroup")]
        public JToken EmployeeTypeGroup { get; set; }

        [JsonProperty("estimatedCost")]
        public JToken EstimatedCost { get; set; }

        [JsonProperty("estimatedExpenses")]
        public JToken EstimatedExpenses { get; set; }

        [JsonProperty("estimatedHours")]
        public JToken EstimatedHours { get; set; }

        [JsonProperty("estimationMode")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeEstimationModeType EstimationMode { get; set; }

        [JsonProperty("extensionFieldValues")]
        public JToken[] ExtensionFieldValues { get; set; }

        [JsonProperty("isProjectLeaderApprovalRequired")]
        public bool IsProjectLeaderApprovalRequired { get; set; }

        [JsonProperty("isTimeEntryAllowed")]
        public bool IsTimeEntryAllowed { get; set; }

        [JsonProperty("keyValues")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeKeyValuesTypeItem[] KeyValues { get; set; }

        [JsonProperty("location")]
        public JToken Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentCompleted")]
        public int PercentCompleted { get; set; }

        [JsonProperty("program")]
        public JToken Program { get; set; }

        [JsonProperty("projectLeader")]
        public JToken ProjectLeader { get; set; }

        [JsonProperty("serviceCenter")]
        public JToken ServiceCenter { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("status")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeStatusType Status { get; set; }

        [JsonProperty("timeAndExpenseEntryType")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeAndExpenseEntryTypeType TimeAndExpenseEntryType { get; set; }

        [JsonProperty("timeAndMaterials")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeAndMaterialsType TimeAndMaterials { get; set; }

        [JsonProperty("timeEntryDateRange")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeEntryDateRangeType TimeEntryDateRange { get; set; }

        [JsonProperty("totalEstimatedContract")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeTotalEstimatedContractType TotalEstimatedContract { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeBillingContractType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeBillingTypeType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeClientBillingAllocationMethodType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeDefaultBillingCurrencyType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeEstimationModeType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeKeyValuesTypeItem
    {
        [JsonProperty("keyUri")]
        public string KeyUri { get; set; }

        [JsonProperty("value")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeKeyValuesTypeItemValueType Value { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeKeyValuesTypeItemValueType
    {
        [JsonProperty("collection")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeKeyValuesTypeItemValueTypeCollectionTypeItem[] Collection { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeKeyValuesTypeItemValueTypeCollectionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeStatusType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeAndExpenseEntryTypeType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeAndMaterialsType
    {
        [JsonProperty("billingRateFrequency")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeAndMaterialsTypeBillingRateFrequencyType BillingRateFrequency { get; set; }

        [JsonProperty("billingRateFrequencyDuration")]
        public JToken BillingRateFrequencyDuration { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeAndMaterialsTypeBillingRateFrequencyType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeTimeEntryDateRangeType
    {
        [JsonProperty("endDate")]
        public Date EndDate { get; set; }

        [JsonProperty("startDate")]
        public Date StartDate { get; set; }
    }

    public class Date
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeTotalEstimatedContractType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public ProjectDetailsResponseDTypeItemProjectDetailsTypeTotalEstimatedContractTypeCurrencyType Currency { get; set; }
    }

    public class ProjectDetailsResponseDTypeItemProjectDetailsTypeTotalEstimatedContractTypeCurrencyType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class BulkGetProjectDetails3Input
    {
        [JsonProperty("projects")]
        public BulkGetProjectDetails3InputProjectsTypeItem[] Projects { get; set; }
    }

    public class BulkGetProjectDetails3InputProjectsTypeItem
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parameterCorrelationId")]
        public string ParameterCorrelationId { get; set; }
    }

    public class CreateProjectOrApplyModificationsResponse
    {
        [JsonProperty("d")]
        public CreateProjectOrApplyModificationsResponseDType D { get; set; }
    }

    public class CreateProjectOrApplyModificationsResponseDType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CreateProjectOrApplyModificationsInput
    {
        [JsonProperty("target")]
        public JToken Target { get; set; }

        [JsonProperty("modifications")]
        public CreateProjectOrApplyModificationsInputModificationsType Modifications { get; set; }

        [JsonProperty("projectModificationOptionUri")]
        public string ProjectModificationOptionUri { get; set; }

        [JsonProperty("unitOfWorkId")]
        public string UnitOfWorkId { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsType
    {
        [JsonProperty("nameToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeNameToApplyType NameToApply { get; set; }

        [JsonProperty("codeToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeCodeToApplyType CodeToApply { get; set; }

        [JsonProperty("descriptionToApply")]
        public JToken DescriptionToApply { get; set; }

        [JsonProperty("percentCompletedToApply")]
        public string PercentCompletedToApply { get; set; }

        [JsonProperty("startDateToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeStartDateToApplyType StartDateToApply { get; set; }

        [JsonProperty("endDateToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeEndDateToApplyType EndDateToApply { get; set; }

        [JsonProperty("billingTypeToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeBillingTypeToApplyType BillingTypeToApply { get; set; }

        [JsonProperty("projectLeaderToApply")]
        public JToken ProjectLeaderToApply { get; set; }

        [JsonProperty("isProjectLeaderApprovalRequired")]
        public string IsProjectLeaderApprovalRequired { get; set; }

        [JsonProperty("isTimeEntryAllowed")]
        public string IsTimeEntryAllowed { get; set; }

        [JsonProperty("defaultBillingCurrencyToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeDefaultBillingCurrencyToApplyType DefaultBillingCurrencyToApply { get; set; }

        [JsonProperty("billingContractToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeBillingContractToApplyType BillingContractToApply { get; set; }

        [JsonProperty("keyValuesToApply")]
        public CreateProjectOrApplyModificationsInputModificationsTypeKeyValuesToApplyTypeItem[] KeyValuesToApply { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeNameToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeCodeToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeStartDateToApplyType
    {
        [JsonProperty("date")]
        public CreateProjectOrApplyModificationsInputModificationsTypeStartDateToApplyTypeDateType Date { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeStartDateToApplyTypeDateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeEndDateToApplyType
    {
        [JsonProperty("date")]
        public CreateProjectOrApplyModificationsInputModificationsTypeEndDateToApplyTypeDateType Date { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeEndDateToApplyTypeDateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeBillingTypeToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeDefaultBillingCurrencyToApplyType
    {
        [JsonProperty("currency")]
        public CreateProjectOrApplyModificationsInputModificationsTypeDefaultBillingCurrencyToApplyTypeCurrencyType Currency { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeDefaultBillingCurrencyToApplyTypeCurrencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeBillingContractToApplyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeKeyValuesToApplyTypeItem
    {
        [JsonProperty("keyUri")]
        public string KeyUri { get; set; }

        [JsonProperty("value")]
        public CreateProjectOrApplyModificationsInputModificationsTypeKeyValuesToApplyTypeItemValueType Value { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeKeyValuesToApplyTypeItemValueType
    {
        [JsonProperty("collection")]
        public CreateProjectOrApplyModificationsInputModificationsTypeKeyValuesToApplyTypeItemValueTypeCollectionTypeItem[] Collection { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CreateProjectOrApplyModificationsInputModificationsTypeKeyValuesToApplyTypeItemValueTypeCollectionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UserListServiceGetDataResponse
    {
        [JsonProperty("d")]
        public UserListServiceGetDataResponseDType D { get; set; }
    }

    public class UserListServiceGetDataResponseDType
    {
        [JsonProperty("header")]
        public UserListServiceGetDataResponseDTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("rows")]
        public UserListServiceGetDataResponseDTypeRowsTypeItem[] Rows { get; set; }
    }

    public class UserListServiceGetDataResponseDTypeHeaderTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UserListServiceGetDataResponseDTypeRowsTypeItem
    {
        [JsonProperty("cells")]
        public UserListServiceGetDataResponseDTypeRowsTypeItemCellsTypeItem[] Cells { get; set; }
    }

    public class UserListServiceGetDataResponseDTypeRowsTypeItemCellsTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UserListServiceGetDataInput
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("pagesize")]
        public string Pagesize { get; set; }

        [JsonProperty("columnUris")]
        public string[] ColumnUris { get; set; }

        [JsonProperty("sort")]
        public JToken[] Sort { get; set; }

        [JsonProperty("filterExpression")]
        public JToken FilterExpression { get; set; }
    }

    public class GetDescendantTaskDetailsInput
    {
        [JsonProperty("parentUri")]
        public string ParentUri { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsResponse
    {
        [JsonProperty("d")]
        public CreateTaskHierarchyOrApplyModificationsResponseDTypeItem[] D { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsResponseDTypeItem
    {
        [JsonProperty("error")]
        public JToken Error { get; set; }

        [JsonProperty("parameterCorrelationId")]
        public string ParameterCorrelationId { get; set; }

        [JsonProperty("task")]
        public CreateTaskHierarchyOrApplyModificationsResponseDTypeItemTaskObjectType TaskObject { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsResponseDTypeItemTaskObjectType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("parameterCorrelationId")]
        public string ParameterCorrelationId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInput
    {
        [JsonProperty("project")]
        public CreateTaskHierarchyOrApplyModificationsInputProjectType Project { get; set; }

        [JsonProperty("taskHierarchy")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItem[] TaskHierarchy { get; set; }

        [JsonProperty("taskModificationOptionUri")]
        public string TaskModificationOptionUri { get; set; }

        [JsonProperty("unitOfWorkId")]
        public string UnitOfWorkId { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputProjectType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parameterCorrelationId")]
        public string ParameterCorrelationId { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItem
    {
        [JsonProperty("target")]
        public JToken Target { get; set; }

        [JsonProperty("parameterCorrelationId")]
        public string ParameterCorrelationId { get; set; }

        [JsonProperty("taskModificationToApply")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyType TaskModificationToApply { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("codeToApply")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeCodeToApplyType CodeToApply { get; set; }

        [JsonProperty("descriptionToApply")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeDescriptionToApplyType DescriptionToApply { get; set; }

        [JsonProperty("isClosed")]
        public string IsClosed { get; set; }

        [JsonProperty("timeEntryStartDateToApply")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryStartDateToApplyType TimeEntryStartDateToApply { get; set; }

        [JsonProperty("timeEntryEndDateToApply")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryEndDateToApplyType TimeEntryEndDateToApply { get; set; }

        [JsonProperty("timeAndExpenseEntryTypeToApply")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeAndExpenseEntryTypeToApplyType TimeAndExpenseEntryTypeToApply { get; set; }

        [JsonProperty("isTimeEntryAllowed")]
        public string IsTimeEntryAllowed { get; set; }

        [JsonProperty("costTypeToApply")]
        public JToken CostTypeToApply { get; set; }

        [JsonProperty("estimatedHoursToApply")]
        public JToken EstimatedHoursToApply { get; set; }

        [JsonProperty("estimatedCostToApply")]
        public JToken EstimatedCostToApply { get; set; }

        [JsonProperty("resourceAssignmentModifications")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeResourceAssignmentModificationsType ResourceAssignmentModifications { get; set; }

        [JsonProperty("customFieldsToApply")]
        public JToken[] CustomFieldsToApply { get; set; }

        [JsonProperty("keyValuesToApply")]
        public JToken[] KeyValuesToApply { get; set; }

        [JsonProperty("objectExtensionFieldsToApply")]
        public JToken[] ObjectExtensionFieldsToApply { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeCodeToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeDescriptionToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryStartDateToApplyType
    {
        [JsonProperty("date")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryStartDateToApplyTypeDateType Date { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryStartDateToApplyTypeDateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryEndDateToApplyType
    {
        [JsonProperty("date")]
        public CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryEndDateToApplyTypeDateType Date { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeEntryEndDateToApplyTypeDateType
    {
        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeTimeAndExpenseEntryTypeToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateTaskHierarchyOrApplyModificationsInputTaskHierarchyTypeItemTaskModificationToApplyTypeResourceAssignmentModificationsType
    {
        [JsonProperty("resourcesToAdd")]
        public string[] ResourcesToAdd { get; set; }

        [JsonProperty("resourcesToRemove")]
        public string[] ResourcesToRemove { get; set; }
    }

    public class MoveTaskInput
    {
        [JsonProperty("taskUri")]
        public string TaskUri { get; set; }

        [JsonProperty("targetUri")]
        public string TargetUri { get; set; }

        [JsonProperty("moveTaskMethodUri")]
        public string MoveTaskMethodUri { get; set; }
    }

    public class TaskListServiceGetDataResponse
    {
        [JsonProperty("d")]
        public TaskListServiceGetDataResponseDType D { get; set; }
    }

    public class TaskListServiceGetDataResponseDType
    {
        [JsonProperty("header")]
        public TaskListServiceGetDataResponseDTypeHeaderTypeItem[] Header { get; set; }

        [JsonProperty("rows")]
        public TaskListServiceGetDataResponseDTypeRowsTypeItem[] Rows { get; set; }
    }

    public class TaskListServiceGetDataResponseDTypeHeaderTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class TaskListServiceGetDataResponseDTypeRowsTypeItem
    {
        [JsonProperty("cells")]
        public TaskListServiceGetDataResponseDTypeRowsTypeItemCellsTypeItem[] Cells { get; set; }
    }

    public class TaskListServiceGetDataResponseDTypeRowsTypeItemCellsTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("cellCollection")]
        public TaskListServiceGetDataResponseDTypeRowsTypeItemCellsTypeItemCellCollectionTypeItem[] CellCollection { get; set; }
    }

    public class TaskListServiceGetDataResponseDTypeRowsTypeItemCellsTypeItemCellCollectionTypeItem
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class TaskListServiceGetDataInput
    {
        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("pagesize")]
        public string Pagesize { get; set; }

        [JsonProperty("columnUris")]
        public string[] ColumnUris { get; set; }

        [JsonProperty("sort")]
        public JToken[] Sort { get; set; }

        [JsonProperty("filterExpression")]
        public JToken FilterExpression { get; set; }
    }

    public class GetTimesheetSummaryResponse
    {
        [JsonProperty("d")]
        public GetTimesheetSummaryResponseDType D { get; set; }
    }

    public class GetTimesheetSummaryResponseDType
    {
        [JsonProperty("actualPayableTimeCalculationStatus")]
        public string ActualPayableTimeCalculationStatus { get; set; }

        [JsonProperty("actualsByActivity")]
        public GetTimesheetSummaryResponseDTypeActualsByActivityTypeItem[] ActualsByActivity { get; set; }

        [JsonProperty("actualsByBillingRate")]
        public GetTimesheetSummaryResponseDTypeActualsByBillingRateTypeItem[] ActualsByBillingRate { get; set; }

        [JsonProperty("actualsByDate")]
        public GetTimesheetSummaryResponseDTypeActualsByDateTypeItem[] ActualsByDate { get; set; }

        [JsonProperty("actualsByPaycode")]
        public JToken[] ActualsByPaycode { get; set; }

        [JsonProperty("actualsByProject")]
        public GetTimesheetSummaryResponseDTypeActualsByProjectTypeItem[] ActualsByProject { get; set; }

        [JsonProperty("approvalStatus")]
        public GetTimesheetSummaryResponseDTypeApprovalStatusType ApprovalStatus { get; set; }

        [JsonProperty("attestationStatusUri")]
        public string AttestationStatusUri { get; set; }

        [JsonProperty("bankedTimeDuration")]
        public Duration BankedTimeDuration { get; set; }

        [JsonProperty("billableTimeDuration")]
        public Duration BillableTimeDuration { get; set; }

        [JsonProperty("breakDuration")]
        public Duration BreakDuration { get; set; }

        [JsonProperty("dueDate")]
        public Date DueDate { get; set; }

        [JsonProperty("nonBillableTimeDuration")]
        public Duration NonBillableTimeDuration { get; set; }

        [JsonProperty("overtimeDuration")]
        public Duration OvertimeDuration { get; set; }

        [JsonProperty("scriptCalculationStatus")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusType ScriptCalculationStatus { get; set; }

        [JsonProperty("timeOffTimeDuration")]
        public Duration TimeOffTimeDuration { get; set; }

        [JsonProperty("timesheetStatus")]
        public GetTimesheetSummaryResponseDTypeTimesheetStatusType TimesheetStatus { get; set; }

        [JsonProperty("totalTimeDuration")]
        public Duration TotalTimeDuration { get; set; }

        [JsonProperty("workingTimeDuration")]
        public Duration WorkingTimeDuration { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeActualsByActivityTypeItem
    {
        [JsonProperty("activity")]
        public JToken Activity { get; set; }

        [JsonProperty("totalTimeDuration")]
        public Duration TotalTimeDuration { get; set; }
    }

    public class Duration
    {
        [JsonProperty("hours")]
        public int Hours { get; set; }

        [JsonProperty("microseconds")]
        public int Microseconds { get; set; }

        [JsonProperty("milliseconds")]
        public int Milliseconds { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeActualsByBillingRateTypeItem
    {
        [JsonProperty("billingRate")]
        public JToken BillingRate { get; set; }

        [JsonProperty("totalTimeDuration")]
        public Duration TotalTimeDuration { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeActualsByDateTypeItem
    {
        [JsonProperty("breakDuration")]
        public Duration BreakDuration { get; set; }

        [JsonProperty("date")]
        public Date Date { get; set; }

        [JsonProperty("hasComments")]
        public bool HasComments { get; set; }

        [JsonProperty("isHolidayDayOff")]
        public bool IsHolidayDayOff { get; set; }

        [JsonProperty("isWeeklyDayOff")]
        public bool IsWeeklyDayOff { get; set; }

        [JsonProperty("timeOffDuration")]
        public Duration TimeOffDuration { get; set; }

        [JsonProperty("totalTimeDuration")]
        public Duration TotalTimeDuration { get; set; }

        [JsonProperty("workingTimeDuration")]
        public Duration WorkingTimeDuration { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeActualsByProjectTypeItem
    {
        [JsonProperty("project")]
        public GetTimesheetSummaryResponseDTypeActualsByProjectTypeItemProjectType Project { get; set; }

        [JsonProperty("totalTimeDuration")]
        public Duration TotalTimeDuration { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeActualsByProjectTypeItemProjectType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeApprovalStatusType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusType
    {
        [JsonProperty("lastDataModification")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastDataModificationType LastDataModification { get; set; }

        [JsonProperty("lastFailedAttempt")]
        public JToken LastFailedAttempt { get; set; }

        [JsonProperty("lastSuccessfulAttempt")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastSuccessfulAttemptType LastSuccessfulAttempt { get; set; }

        [JsonProperty("timesheet")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeTimesheetType Timesheet { get; set; }

        [JsonProperty("timesheetStatus")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeTimesheetStatusType TimesheetStatus { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastDataModificationType
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("second")]
        public int Second { get; set; }

        [JsonProperty("timeZone")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastDataModificationTypeTimeZoneType TimeZone { get; set; }

        [JsonProperty("valueInUtc")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastDataModificationTypeValueInUtcType ValueInUtc { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastDataModificationTypeTimeZoneType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("ianaName")]
        public string IanaName { get; set; }

        [JsonProperty("offsetDisplayText")]
        public string OffsetDisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastDataModificationTypeValueInUtcType
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("millisecond")]
        public int Millisecond { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("second")]
        public int Second { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastSuccessfulAttemptType
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("second")]
        public int Second { get; set; }

        [JsonProperty("timeZone")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastSuccessfulAttemptTypeTimeZoneType TimeZone { get; set; }

        [JsonProperty("valueInUtc")]
        public GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastSuccessfulAttemptTypeValueInUtcType ValueInUtc { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastSuccessfulAttemptTypeTimeZoneType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("ianaName")]
        public string IanaName { get; set; }

        [JsonProperty("offsetDisplayText")]
        public string OffsetDisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeLastSuccessfulAttemptTypeValueInUtcType
    {
        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("millisecond")]
        public int Millisecond { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("second")]
        public int Second { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeTimesheetType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeScriptCalculationStatusTypeTimesheetStatusType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetTimesheetSummaryResponseDTypeTimesheetStatusType
    {
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetTimesheetSummaryInput
    {
        [JsonProperty("timesheetUri")]
        public string TimesheetUri { get; set; }
    }

    public class BulkGetTimeEnteredSummaryResponse
    {
        [JsonProperty("d")]
        public BulkGetTimeEnteredSummaryResponseDTypeItem[] D { get; set; }
    }

    public class BulkGetTimeEnteredSummaryResponseDTypeItem
    {
        [JsonProperty("taskUri")]
        public string TaskUri { get; set; }

        [JsonProperty("timeEnteredActual")]
        public Duration TimeEnteredActual { get; set; }

        [JsonProperty("timeEnteredTotalEstimated")]
        public Duration TimeEnteredTotalEstimated { get; set; }

        [JsonProperty("timeEnteredTotalEstimatedAtCompletion")]
        public Duration TimeEnteredTotalEstimatedAtCompletion { get; set; }
    }

    public class BulkGetTimeEnteredSummaryInput
    {
        [JsonProperty("taskUris")]
        public string[] TaskUris { get; set; }
    }

    public class PutProjectTeamMemberAssignmentsInput
    {
        [JsonProperty("projectUri")]
        public string ProjectUri { get; set; }

        [JsonProperty("resourceUris")]
        public string[] ResourceUris { get; set; }
    }

    public class PutResourceAssignmentsInput
    {
        [JsonProperty("taskUri")]
        public string TaskUri { get; set; }

        [JsonProperty("resourceUris")]
        public string[] ResourceUris { get; set; }
    }

    public class TenantEndpointDetails
    {
        [JsonProperty("d")]
        public TenantEndpointDetailsDType D { get; set; }
    }

    public class TenantEndpointDetailsDType
    {
        [JsonProperty("applicationRootUrl")]
        public string ApplicationRootUrl { get; set; }

        [JsonProperty("applicationRootUrls")]
        public TenantEndpointDetailsDTypeApplicationRootUrlsTypeItem[] ApplicationRootUrls { get; set; }

        [JsonProperty("isLocal")]
        public bool IsLocal { get; set; }

        [JsonProperty("tenant")]
        public TenantEndpointDetailsDTypeTenantType Tenant { get; set; }
    }

    public class TenantEndpointDetailsDTypeApplicationRootUrlsTypeItem
    {
        [JsonProperty("rootUrl")]
        public string RootUrl { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class TenantEndpointDetailsDTypeTenantType
    {
        [JsonProperty("companyKey")]
        public string CompanyKey { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class WebhookSubscriptionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdTimestamp")]
        public string CreatedTimestamp { get; set; }

        [JsonProperty("updatedTimestamp")]
        public string UpdatedTimestamp { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("sharedSecret")]
        public string SharedSecret { get; set; }

        [JsonProperty("authType")]
        public string AuthType { get; set; }
    }

    public class WebhookSubscriptionsRestAPIInput
    {
        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Replicon;

    public partial class WorkflowManagedActions
    {
        public RepliconActions Replicon(string connectionId) => new RepliconActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RepliconTriggers Replicon(string connectionId) => new RepliconTriggers(connectionId);
    }
}