//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Polarispsa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PolarispsaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<ProjectDetailsResponse> BulkGetProjectDetails3([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<bodyprojectsInputItem[]> bodyprojects = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/ProjectService1.svc/BulkGetProjectDetails3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprojects != null)
                {
                    body["projects"] = SourceExpressionConverter.ConvertToken(bodyprojects);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<CreateProjectOrApplyModificationsResponse> CreateProjectOrApplyModifications([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodymodificationsnameToApplyvalue = null, [WorkflowExpression] Func<string> bodymodificationscodeToApplyvalue = null, [WorkflowExpression] Func<string> bodymodificationspercentCompletedToApply = null, [WorkflowExpression] Func<int> bodymodificationsstartDateToApplydateyear = null, [WorkflowExpression] Func<int> bodymodificationsstartDateToApplydatemonth = null, [WorkflowExpression] Func<int> bodymodificationsstartDateToApplydateday = null, [WorkflowExpression] Func<int> bodymodificationsendDateToApplydateyear = null, [WorkflowExpression] Func<int> bodymodificationsendDateToApplydatemonth = null, [WorkflowExpression] Func<int> bodymodificationsendDateToApplydateday = null, [WorkflowExpression] Func<string> bodymodificationsbillingTypeToApplyvalue = null, [WorkflowExpression] Func<string> bodymodificationsisProjectLeaderApprovalRequired = null, [WorkflowExpression] Func<string> bodymodificationsisTimeEntryAllowed = null, [WorkflowExpression] Func<string> bodymodificationsdefaultBillingCurrencyToApplycurrencyname = null, [WorkflowExpression] Func<string> bodymodificationsbillingContractToApplyname = null, [WorkflowExpression] Func<bodymodificationskeyValuesToApplyInputItem[]> bodymodificationskeyValuesToApply = null, [WorkflowExpression] Func<string> bodyprojectModificationOptionUri = null, [WorkflowExpression] Func<string> bodyunitOfWorkId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/ProjectService1.svc/CreateProjectOrApplyModifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                var targetObject = new JObject();
                var targetObjectpropCount = 0;
                if (targetObjectpropCount > 0)
                {
                    body["target"] = targetObject;
                    bodypropCount++;
                }

                var modificationsObject = new JObject();
                var modificationsObjectpropCount = 0;
                var nameToApplyObject = new JObject();
                var nameToApplyObjectpropCount = 0;
                if (bodymodificationsnameToApplyvalue != null)
                {
                    nameToApplyObject["value"] = SourceExpressionConverter.ConvertToken(bodymodificationsnameToApplyvalue);
                    nameToApplyObjectpropCount++;
                }

                if (nameToApplyObjectpropCount > 0)
                {
                    modificationsObject["nameToApply"] = nameToApplyObject;
                    modificationsObjectpropCount++;
                }

                var codeToApplyObject = new JObject();
                var codeToApplyObjectpropCount = 0;
                if (bodymodificationscodeToApplyvalue != null)
                {
                    codeToApplyObject["value"] = SourceExpressionConverter.ConvertToken(bodymodificationscodeToApplyvalue);
                    codeToApplyObjectpropCount++;
                }

                if (codeToApplyObjectpropCount > 0)
                {
                    modificationsObject["codeToApply"] = codeToApplyObject;
                    modificationsObjectpropCount++;
                }

                var descriptionToApplyObject = new JObject();
                var descriptionToApplyObjectpropCount = 0;
                if (descriptionToApplyObjectpropCount > 0)
                {
                    modificationsObject["descriptionToApply"] = descriptionToApplyObject;
                    modificationsObjectpropCount++;
                }

                if (bodymodificationspercentCompletedToApply != null)
                {
                    modificationsObject["percentCompletedToApply"] = SourceExpressionConverter.ConvertToken(bodymodificationspercentCompletedToApply);
                    modificationsObjectpropCount++;
                }

                var startDateToApplyObject = new JObject();
                var startDateToApplyObjectpropCount = 0;
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodymodificationsstartDateToApplydateyear != null)
                {
                    dateObject["year"] = SourceExpressionConverter.ConvertToken(bodymodificationsstartDateToApplydateyear);
                    dateObjectpropCount++;
                }

                if (bodymodificationsstartDateToApplydatemonth != null)
                {
                    dateObject["month"] = SourceExpressionConverter.ConvertToken(bodymodificationsstartDateToApplydatemonth);
                    dateObjectpropCount++;
                }

                if (bodymodificationsstartDateToApplydateday != null)
                {
                    dateObject["day"] = SourceExpressionConverter.ConvertToken(bodymodificationsstartDateToApplydateday);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    startDateToApplyObject["date"] = dateObject;
                    startDateToApplyObjectpropCount++;
                }

                if (startDateToApplyObjectpropCount > 0)
                {
                    modificationsObject["startDateToApply"] = startDateToApplyObject;
                    modificationsObjectpropCount++;
                }

                var endDateToApplyObject = new JObject();
                var endDateToApplyObjectpropCount = 0;
                var dateObject2 = new JObject();
                var dateObject2propCount = 0;
                if (bodymodificationsendDateToApplydateyear != null)
                {
                    dateObject2["year"] = SourceExpressionConverter.ConvertToken(bodymodificationsendDateToApplydateyear);
                    dateObject2propCount++;
                }

                if (bodymodificationsendDateToApplydatemonth != null)
                {
                    dateObject2["month"] = SourceExpressionConverter.ConvertToken(bodymodificationsendDateToApplydatemonth);
                    dateObject2propCount++;
                }

                if (bodymodificationsendDateToApplydateday != null)
                {
                    dateObject2["day"] = SourceExpressionConverter.ConvertToken(bodymodificationsendDateToApplydateday);
                    dateObject2propCount++;
                }

                if (dateObject2propCount > 0)
                {
                    endDateToApplyObject["date"] = dateObject2;
                    endDateToApplyObjectpropCount++;
                }

                if (endDateToApplyObjectpropCount > 0)
                {
                    modificationsObject["endDateToApply"] = endDateToApplyObject;
                    modificationsObjectpropCount++;
                }

                var billingTypeToApplyObject = new JObject();
                var billingTypeToApplyObjectpropCount = 0;
                if (bodymodificationsbillingTypeToApplyvalue != null)
                {
                    billingTypeToApplyObject["value"] = SourceExpressionConverter.ConvertToken(bodymodificationsbillingTypeToApplyvalue);
                    billingTypeToApplyObjectpropCount++;
                }

                if (billingTypeToApplyObjectpropCount > 0)
                {
                    modificationsObject["billingTypeToApply"] = billingTypeToApplyObject;
                    modificationsObjectpropCount++;
                }

                var projectLeaderToApplyObject = new JObject();
                var projectLeaderToApplyObjectpropCount = 0;
                if (projectLeaderToApplyObjectpropCount > 0)
                {
                    modificationsObject["projectLeaderToApply"] = projectLeaderToApplyObject;
                    modificationsObjectpropCount++;
                }

                if (bodymodificationsisProjectLeaderApprovalRequired != null)
                {
                    modificationsObject["isProjectLeaderApprovalRequired"] = SourceExpressionConverter.ConvertToken(bodymodificationsisProjectLeaderApprovalRequired);
                    modificationsObjectpropCount++;
                }

                if (bodymodificationsisTimeEntryAllowed != null)
                {
                    modificationsObject["isTimeEntryAllowed"] = SourceExpressionConverter.ConvertToken(bodymodificationsisTimeEntryAllowed);
                    modificationsObjectpropCount++;
                }

                var defaultBillingCurrencyToApplyObject = new JObject();
                var defaultBillingCurrencyToApplyObjectpropCount = 0;
                var currencyObject = new JObject();
                var currencyObjectpropCount = 0;
                if (bodymodificationsdefaultBillingCurrencyToApplycurrencyname != null)
                {
                    currencyObject["name"] = SourceExpressionConverter.ConvertToken(bodymodificationsdefaultBillingCurrencyToApplycurrencyname);
                    currencyObjectpropCount++;
                }

                if (currencyObjectpropCount > 0)
                {
                    defaultBillingCurrencyToApplyObject["currency"] = currencyObject;
                    defaultBillingCurrencyToApplyObjectpropCount++;
                }

                if (defaultBillingCurrencyToApplyObjectpropCount > 0)
                {
                    modificationsObject["defaultBillingCurrencyToApply"] = defaultBillingCurrencyToApplyObject;
                    modificationsObjectpropCount++;
                }

                var billingContractToApplyObject = new JObject();
                var billingContractToApplyObjectpropCount = 0;
                if (bodymodificationsbillingContractToApplyname != null)
                {
                    billingContractToApplyObject["name"] = SourceExpressionConverter.ConvertToken(bodymodificationsbillingContractToApplyname);
                    billingContractToApplyObjectpropCount++;
                }

                if (billingContractToApplyObjectpropCount > 0)
                {
                    modificationsObject["billingContractToApply"] = billingContractToApplyObject;
                    modificationsObjectpropCount++;
                }

                if (bodymodificationskeyValuesToApply != null)
                {
                    modificationsObject["keyValuesToApply"] = SourceExpressionConverter.ConvertToken(bodymodificationskeyValuesToApply);
                    modificationsObjectpropCount++;
                }

                if (modificationsObjectpropCount > 0)
                {
                    body["modifications"] = modificationsObject;
                    bodypropCount++;
                }

                if (bodyprojectModificationOptionUri != null)
                {
                    body["projectModificationOptionUri"] = SourceExpressionConverter.ConvertToken(bodyprojectModificationOptionUri);
                    bodypropCount++;
                }

                if (bodyunitOfWorkId != null)
                {
                    body["unitOfWorkId"] = SourceExpressionConverter.ConvertToken(bodyunitOfWorkId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectOrApplyModificationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<UserListServiceGetDataResponse> UserListServiceGetData([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodypage = null, [WorkflowExpression] Func<string> bodypagesize = null, [WorkflowExpression] Func<string[]> bodycolumnUris = null, [WorkflowExpression] Func<JToken[]> bodysort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/UserListService1.svc/GetData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypage != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypage);
                    bodypropCount++;
                }

                if (bodypagesize != null)
                {
                    body["pagesize"] = SourceExpressionConverter.ConvertToken(bodypagesize);
                    bodypropCount++;
                }

                if (bodycolumnUris != null)
                {
                    body["columnUris"] = SourceExpressionConverter.ConvertToken(bodycolumnUris);
                    bodypropCount++;
                }

                if (bodysort != null)
                {
                    body["sort"] = SourceExpressionConverter.ConvertToken(bodysort);
                    bodypropCount++;
                }

                var filterExpressionObject = new JObject();
                var filterExpressionObjectpropCount = 0;
                if (filterExpressionObjectpropCount > 0)
                {
                    body["filterExpression"] = filterExpressionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserListServiceGetDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IWorkflowAction GetDescendantTaskDetails([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodyparentUri = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/TaskService1.svc/GetDescendantTaskDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentUri != null)
                {
                    body["parentUri"] = SourceExpressionConverter.ConvertToken(bodyparentUri);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<CreateTaskHierarchyOrApplyModificationsResponse> CreateTaskHierarchyOrApplyModifications([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodyprojecturi = null, [WorkflowExpression] Func<string> bodyprojectname = null, [WorkflowExpression] Func<string> bodyprojectcode = null, [WorkflowExpression] Func<string> bodyprojectparameterCorrelationId = null, [WorkflowExpression] Func<bodytaskHierarchyInputItem[]> bodytaskHierarchy = null, [WorkflowExpression] Func<string> bodytaskModificationOptionUri = null, [WorkflowExpression] Func<string> bodyunitOfWorkId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/TaskService1.svc/CreateTaskHierarchyOrApplyModifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (bodyprojecturi != null)
                {
                    projectObject["uri"] = SourceExpressionConverter.ConvertToken(bodyprojecturi);
                    projectObjectpropCount++;
                }

                if (bodyprojectname != null)
                {
                    projectObject["name"] = SourceExpressionConverter.ConvertToken(bodyprojectname);
                    projectObjectpropCount++;
                }

                if (bodyprojectcode != null)
                {
                    projectObject["code"] = SourceExpressionConverter.ConvertToken(bodyprojectcode);
                    projectObjectpropCount++;
                }

                if (bodyprojectparameterCorrelationId != null)
                {
                    projectObject["parameterCorrelationId"] = SourceExpressionConverter.ConvertToken(bodyprojectparameterCorrelationId);
                    projectObjectpropCount++;
                }

                if (projectObjectpropCount > 0)
                {
                    body["project"] = projectObject;
                    bodypropCount++;
                }

                if (bodytaskHierarchy != null)
                {
                    body["taskHierarchy"] = SourceExpressionConverter.ConvertToken(bodytaskHierarchy);
                    bodypropCount++;
                }

                if (bodytaskModificationOptionUri != null)
                {
                    body["taskModificationOptionUri"] = SourceExpressionConverter.ConvertToken(bodytaskModificationOptionUri);
                    bodypropCount++;
                }

                if (bodyunitOfWorkId != null)
                {
                    body["unitOfWorkId"] = SourceExpressionConverter.ConvertToken(bodyunitOfWorkId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskHierarchyOrApplyModificationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IWorkflowAction MoveTask([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodytaskUri = null, [WorkflowExpression] Func<string> bodytargetUri = null, [WorkflowExpression] Func<string> bodymoveTaskMethodUri = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/TaskService1.svc/MoveTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskUri != null)
                {
                    body["taskUri"] = SourceExpressionConverter.ConvertToken(bodytaskUri);
                    bodypropCount++;
                }

                if (bodytargetUri != null)
                {
                    body["targetUri"] = SourceExpressionConverter.ConvertToken(bodytargetUri);
                    bodypropCount++;
                }

                if (bodymoveTaskMethodUri != null)
                {
                    body["moveTaskMethodUri"] = SourceExpressionConverter.ConvertToken(bodymoveTaskMethodUri);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<TaskListServiceGetDataResponse> TaskListServiceGetData([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodypage = null, [WorkflowExpression] Func<string> bodypagesize = null, [WorkflowExpression] Func<string[]> bodycolumnUris = null, [WorkflowExpression] Func<JToken[]> bodysort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/TaskListService1.svc/GetData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypage != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypage);
                    bodypropCount++;
                }

                if (bodypagesize != null)
                {
                    body["pagesize"] = SourceExpressionConverter.ConvertToken(bodypagesize);
                    bodypropCount++;
                }

                if (bodycolumnUris != null)
                {
                    body["columnUris"] = SourceExpressionConverter.ConvertToken(bodycolumnUris);
                    bodypropCount++;
                }

                if (bodysort != null)
                {
                    body["sort"] = SourceExpressionConverter.ConvertToken(bodysort);
                    bodypropCount++;
                }

                var filterExpressionObject = new JObject();
                var filterExpressionObjectpropCount = 0;
                if (filterExpressionObjectpropCount > 0)
                {
                    body["filterExpression"] = filterExpressionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskListServiceGetDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IWorkflowAction GraphQL([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/graphql";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<GetTimesheetSummaryResponse> GetTimesheetSummary([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodytimesheetUri = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/TimesheetService1.svc/GetTimesheetSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytimesheetUri != null)
                {
                    body["timesheetUri"] = SourceExpressionConverter.ConvertToken(bodytimesheetUri);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTimesheetSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<BulkGetTimeEnteredSummaryResponse> BulkGetTimeEnteredSummary([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string[]> bodytaskUris = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services/TaskService1.svc/BulkGetTimeEnteredSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskUris != null)
                {
                    body["taskUris"] = SourceExpressionConverter.ConvertToken(bodytaskUris);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BulkGetTimeEnteredSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "polarispsa")]
        public IBodyWorkflowAction<TenantEndpointDetails> GetMyTenantEndpointDetails()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DiscoveryService1.svc/GetMyTenantEndpointDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TenantEndpointDetails>(BuildSourceInput);
        }
    }

    public class PolarispsaTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscriptionResponse> WebhookSubscriptionsRestAPI([WorkflowExpression] Func<string> hostUrl, [WorkflowExpression] Func<string> bodyeventType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook-api/api/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = SourceExpressionConverter.ConvertO(hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventType != null)
                {
                    body["eventType"] = SourceExpressionConverter.ConvertToken(bodyeventType);
                    bodypropCount++;
                }

                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSubscriptionResponse>(BuildSourceInput, triggerName, recurrence);
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

    public class bodyprojectsInputItem
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

    public class bodymodificationskeyValuesToApplyInputItem
    {
        [JsonProperty("keyUri")]
        public string KeyUri { get; set; }

        [JsonProperty("value")]
        public bodymodificationskeyValuesToApplyInputItemValueType Value { get; set; }
    }

    public class bodymodificationskeyValuesToApplyInputItemValueType
    {
        [JsonProperty("collection")]
        public bodymodificationskeyValuesToApplyInputItemValueTypeCollectionTypeItem[] Collection { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class bodymodificationskeyValuesToApplyInputItemValueTypeCollectionTypeItem
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

    public class bodytaskHierarchyInputItem
    {
        [JsonProperty("target")]
        public JToken Target { get; set; }

        [JsonProperty("parameterCorrelationId")]
        public string ParameterCorrelationId { get; set; }

        [JsonProperty("taskModificationToApply")]
        public bodytaskHierarchyInputItemTaskModificationToApplyType TaskModificationToApply { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("codeToApply")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeCodeToApplyType CodeToApply { get; set; }

        [JsonProperty("descriptionToApply")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeDescriptionToApplyType DescriptionToApply { get; set; }

        [JsonProperty("isClosed")]
        public string IsClosed { get; set; }

        [JsonProperty("timeEntryStartDateToApply")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryStartDateToApplyType TimeEntryStartDateToApply { get; set; }

        [JsonProperty("timeEntryEndDateToApply")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryEndDateToApplyType TimeEntryEndDateToApply { get; set; }

        [JsonProperty("timeAndExpenseEntryTypeToApply")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeAndExpenseEntryTypeToApplyType TimeAndExpenseEntryTypeToApply { get; set; }

        [JsonProperty("isTimeEntryAllowed")]
        public string IsTimeEntryAllowed { get; set; }

        [JsonProperty("costTypeToApply")]
        public JToken CostTypeToApply { get; set; }

        [JsonProperty("estimatedHoursToApply")]
        public JToken EstimatedHoursToApply { get; set; }

        [JsonProperty("estimatedCostToApply")]
        public JToken EstimatedCostToApply { get; set; }

        [JsonProperty("resourceAssignmentModifications")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeResourceAssignmentModificationsType ResourceAssignmentModifications { get; set; }

        [JsonProperty("customFieldsToApply")]
        public JToken[] CustomFieldsToApply { get; set; }

        [JsonProperty("keyValuesToApply")]
        public JToken[] KeyValuesToApply { get; set; }

        [JsonProperty("objectExtensionFieldsToApply")]
        public JToken[] ObjectExtensionFieldsToApply { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeCodeToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeDescriptionToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryStartDateToApplyType
    {
        [JsonProperty("date")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryStartDateToApplyTypeDateType Date { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryStartDateToApplyTypeDateType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryEndDateToApplyType
    {
        [JsonProperty("date")]
        public bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryEndDateToApplyTypeDateType Date { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeEntryEndDateToApplyTypeDateType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeTimeAndExpenseEntryTypeToApplyType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodytaskHierarchyInputItemTaskModificationToApplyTypeResourceAssignmentModificationsType
    {
        [JsonProperty("resourcesToAdd")]
        public string[] ResourcesToAdd { get; set; }

        [JsonProperty("resourcesToRemove")]
        public string[] ResourcesToRemove { get; set; }
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

    public class bodyInputItem
    {
        [JsonProperty("operationName")]
        public string OperationName { get; set; }

        [JsonProperty("variables")]
        public JToken Variables { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Polarispsa;

    public partial class WorkflowManagedActions
    {
        public PolarispsaActions Polarispsa(string connectionId) => new PolarispsaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PolarispsaTriggers Polarispsa(string connectionId) => new PolarispsaTriggers(connectionId);
    }
}