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
        public IBodyWorkflowAction<ProjectDetailsResponse, ApiConnectionActionConfiguration> BulkGetProjectDetails3(Expression<Func<string>> hostUrl, Expression<Func<bodyprojectsInputItem[]>> bodyprojects = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodyprojects = WorkflowExpression.Compile(bodyprojects, nameof(bodyprojects), required: false);
            return new DeferredBodyAction<ProjectDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/ProjectService1.svc/BulkGetProjectDetails3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprojects != null)
                {
                    body["projects"] = ExpressionConverter.ConvertO(__workflow_bodyprojects);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<CreateProjectOrApplyModificationsResponse, ApiConnectionActionConfiguration> CreateProjectOrApplyModifications(Expression<Func<string>> hostUrl, Expression<Func<string>> bodymodificationsnameToApplyvalue = null, Expression<Func<string>> bodymodificationscodeToApplyvalue = null, Expression<Func<string>> bodymodificationspercentCompletedToApply = null, Expression<Func<int>> bodymodificationsstartDateToApplydateyear = null, Expression<Func<int>> bodymodificationsstartDateToApplydatemonth = null, Expression<Func<int>> bodymodificationsstartDateToApplydateday = null, Expression<Func<int>> bodymodificationsendDateToApplydateyear = null, Expression<Func<int>> bodymodificationsendDateToApplydatemonth = null, Expression<Func<int>> bodymodificationsendDateToApplydateday = null, Expression<Func<string>> bodymodificationsbillingTypeToApplyvalue = null, Expression<Func<string>> bodymodificationsisProjectLeaderApprovalRequired = null, Expression<Func<string>> bodymodificationsisTimeEntryAllowed = null, Expression<Func<string>> bodymodificationsdefaultBillingCurrencyToApplycurrencyname = null, Expression<Func<string>> bodymodificationsbillingContractToApplyname = null, Expression<Func<bodymodificationskeyValuesToApplyInputItem[]>> bodymodificationskeyValuesToApply = null, Expression<Func<string>> bodyprojectModificationOptionUri = null, Expression<Func<string>> bodyunitOfWorkId = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodymodificationsnameToApplyvalue = WorkflowExpression.Compile(bodymodificationsnameToApplyvalue, nameof(bodymodificationsnameToApplyvalue), required: false);
            var __workflow_bodymodificationscodeToApplyvalue = WorkflowExpression.Compile(bodymodificationscodeToApplyvalue, nameof(bodymodificationscodeToApplyvalue), required: false);
            var __workflow_bodymodificationspercentCompletedToApply = WorkflowExpression.Compile(bodymodificationspercentCompletedToApply, nameof(bodymodificationspercentCompletedToApply), required: false);
            var __workflow_bodymodificationsstartDateToApplydateyear = WorkflowExpression.Compile(bodymodificationsstartDateToApplydateyear, nameof(bodymodificationsstartDateToApplydateyear), required: false);
            var __workflow_bodymodificationsstartDateToApplydatemonth = WorkflowExpression.Compile(bodymodificationsstartDateToApplydatemonth, nameof(bodymodificationsstartDateToApplydatemonth), required: false);
            var __workflow_bodymodificationsstartDateToApplydateday = WorkflowExpression.Compile(bodymodificationsstartDateToApplydateday, nameof(bodymodificationsstartDateToApplydateday), required: false);
            var __workflow_bodymodificationsendDateToApplydateyear = WorkflowExpression.Compile(bodymodificationsendDateToApplydateyear, nameof(bodymodificationsendDateToApplydateyear), required: false);
            var __workflow_bodymodificationsendDateToApplydatemonth = WorkflowExpression.Compile(bodymodificationsendDateToApplydatemonth, nameof(bodymodificationsendDateToApplydatemonth), required: false);
            var __workflow_bodymodificationsendDateToApplydateday = WorkflowExpression.Compile(bodymodificationsendDateToApplydateday, nameof(bodymodificationsendDateToApplydateday), required: false);
            var __workflow_bodymodificationsbillingTypeToApplyvalue = WorkflowExpression.Compile(bodymodificationsbillingTypeToApplyvalue, nameof(bodymodificationsbillingTypeToApplyvalue), required: false);
            var __workflow_bodymodificationsisProjectLeaderApprovalRequired = WorkflowExpression.Compile(bodymodificationsisProjectLeaderApprovalRequired, nameof(bodymodificationsisProjectLeaderApprovalRequired), required: false);
            var __workflow_bodymodificationsisTimeEntryAllowed = WorkflowExpression.Compile(bodymodificationsisTimeEntryAllowed, nameof(bodymodificationsisTimeEntryAllowed), required: false);
            var __workflow_bodymodificationsdefaultBillingCurrencyToApplycurrencyname = WorkflowExpression.Compile(bodymodificationsdefaultBillingCurrencyToApplycurrencyname, nameof(bodymodificationsdefaultBillingCurrencyToApplycurrencyname), required: false);
            var __workflow_bodymodificationsbillingContractToApplyname = WorkflowExpression.Compile(bodymodificationsbillingContractToApplyname, nameof(bodymodificationsbillingContractToApplyname), required: false);
            var __workflow_bodymodificationskeyValuesToApply = WorkflowExpression.Compile(bodymodificationskeyValuesToApply, nameof(bodymodificationskeyValuesToApply), required: false);
            var __workflow_bodyprojectModificationOptionUri = WorkflowExpression.Compile(bodyprojectModificationOptionUri, nameof(bodyprojectModificationOptionUri), required: false);
            var __workflow_bodyunitOfWorkId = WorkflowExpression.Compile(bodyunitOfWorkId, nameof(bodyunitOfWorkId), required: false);
            return new DeferredBodyAction<CreateProjectOrApplyModificationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/ProjectService1.svc/CreateProjectOrApplyModifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
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
                if (__workflow_bodymodificationsnameToApplyvalue != null)
                {
                    nameToApplyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsnameToApplyvalue);
                    nameToApplyObjectpropCount++;
                }

                if (nameToApplyObjectpropCount > 0)
                {
                    modificationsObject["nameToApply"] = nameToApplyObject;
                    modificationsObjectpropCount++;
                }

                var codeToApplyObject = new JObject();
                var codeToApplyObjectpropCount = 0;
                if (__workflow_bodymodificationscodeToApplyvalue != null)
                {
                    codeToApplyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymodificationscodeToApplyvalue);
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

                if (__workflow_bodymodificationspercentCompletedToApply != null)
                {
                    modificationsObject["percentCompletedToApply"] = ExpressionConverter.ConvertO(__workflow_bodymodificationspercentCompletedToApply);
                    modificationsObjectpropCount++;
                }

                var startDateToApplyObject = new JObject();
                var startDateToApplyObjectpropCount = 0;
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodymodificationsstartDateToApplydateyear != null)
                {
                    dateObject["year"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsstartDateToApplydateyear);
                    dateObjectpropCount++;
                }

                if (__workflow_bodymodificationsstartDateToApplydatemonth != null)
                {
                    dateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsstartDateToApplydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodymodificationsstartDateToApplydateday != null)
                {
                    dateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsstartDateToApplydateday);
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
                if (__workflow_bodymodificationsendDateToApplydateyear != null)
                {
                    dateObject2["year"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsendDateToApplydateyear);
                    dateObject2propCount++;
                }

                if (__workflow_bodymodificationsendDateToApplydatemonth != null)
                {
                    dateObject2["month"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsendDateToApplydatemonth);
                    dateObject2propCount++;
                }

                if (__workflow_bodymodificationsendDateToApplydateday != null)
                {
                    dateObject2["day"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsendDateToApplydateday);
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
                if (__workflow_bodymodificationsbillingTypeToApplyvalue != null)
                {
                    billingTypeToApplyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsbillingTypeToApplyvalue);
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

                if (__workflow_bodymodificationsisProjectLeaderApprovalRequired != null)
                {
                    modificationsObject["isProjectLeaderApprovalRequired"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsisProjectLeaderApprovalRequired);
                    modificationsObjectpropCount++;
                }

                if (__workflow_bodymodificationsisTimeEntryAllowed != null)
                {
                    modificationsObject["isTimeEntryAllowed"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsisTimeEntryAllowed);
                    modificationsObjectpropCount++;
                }

                var defaultBillingCurrencyToApplyObject = new JObject();
                var defaultBillingCurrencyToApplyObjectpropCount = 0;
                var currencyObject = new JObject();
                var currencyObjectpropCount = 0;
                if (__workflow_bodymodificationsdefaultBillingCurrencyToApplycurrencyname != null)
                {
                    currencyObject["name"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsdefaultBillingCurrencyToApplycurrencyname);
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
                if (__workflow_bodymodificationsbillingContractToApplyname != null)
                {
                    billingContractToApplyObject["name"] = ExpressionConverter.ConvertO(__workflow_bodymodificationsbillingContractToApplyname);
                    billingContractToApplyObjectpropCount++;
                }

                if (billingContractToApplyObjectpropCount > 0)
                {
                    modificationsObject["billingContractToApply"] = billingContractToApplyObject;
                    modificationsObjectpropCount++;
                }

                if (__workflow_bodymodificationskeyValuesToApply != null)
                {
                    modificationsObject["keyValuesToApply"] = ExpressionConverter.ConvertO(__workflow_bodymodificationskeyValuesToApply);
                    modificationsObjectpropCount++;
                }

                if (modificationsObjectpropCount > 0)
                {
                    body["modifications"] = modificationsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyprojectModificationOptionUri != null)
                {
                    body["projectModificationOptionUri"] = ExpressionConverter.ConvertO(__workflow_bodyprojectModificationOptionUri);
                    bodypropCount++;
                }

                if (__workflow_bodyunitOfWorkId != null)
                {
                    body["unitOfWorkId"] = ExpressionConverter.ConvertO(__workflow_bodyunitOfWorkId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateProjectOrApplyModificationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<UserListServiceGetDataResponse, ApiConnectionActionConfiguration> UserListServiceGetData(Expression<Func<string>> hostUrl, Expression<Func<string>> bodypage = null, Expression<Func<string>> bodypagesize = null, Expression<Func<string[]>> bodycolumnUris = null, Expression<Func<JToken[]>> bodysort = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodypage = WorkflowExpression.Compile(bodypage, nameof(bodypage), required: false);
            var __workflow_bodypagesize = WorkflowExpression.Compile(bodypagesize, nameof(bodypagesize), required: false);
            var __workflow_bodycolumnUris = WorkflowExpression.Compile(bodycolumnUris, nameof(bodycolumnUris), required: false);
            var __workflow_bodysort = WorkflowExpression.Compile(bodysort, nameof(bodysort), required: false);
            return new DeferredBodyAction<UserListServiceGetDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/UserListService1.svc/GetData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypage != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypage);
                    bodypropCount++;
                }

                if (__workflow_bodypagesize != null)
                {
                    body["pagesize"] = ExpressionConverter.ConvertO(__workflow_bodypagesize);
                    bodypropCount++;
                }

                if (__workflow_bodycolumnUris != null)
                {
                    body["columnUris"] = ExpressionConverter.ConvertO(__workflow_bodycolumnUris);
                    bodypropCount++;
                }

                if (__workflow_bodysort != null)
                {
                    body["sort"] = ExpressionConverter.ConvertO(__workflow_bodysort);
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

                return new ApiConnectionAction<UserListServiceGetDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDescendantTaskDetails(Expression<Func<string>> hostUrl, Expression<Func<string>> bodyparentUri = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodyparentUri = WorkflowExpression.Compile(bodyparentUri, nameof(bodyparentUri), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/GetDescendantTaskDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyparentUri != null)
                {
                    body["parentUri"] = ExpressionConverter.ConvertO(__workflow_bodyparentUri);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<CreateTaskHierarchyOrApplyModificationsResponse, ApiConnectionActionConfiguration> CreateTaskHierarchyOrApplyModifications(Expression<Func<string>> hostUrl, Expression<Func<string>> bodyprojecturi = null, Expression<Func<string>> bodyprojectname = null, Expression<Func<string>> bodyprojectcode = null, Expression<Func<string>> bodyprojectparameterCorrelationId = null, Expression<Func<bodytaskHierarchyInputItem[]>> bodytaskHierarchy = null, Expression<Func<string>> bodytaskModificationOptionUri = null, Expression<Func<string>> bodyunitOfWorkId = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodyprojecturi = WorkflowExpression.Compile(bodyprojecturi, nameof(bodyprojecturi), required: false);
            var __workflow_bodyprojectname = WorkflowExpression.Compile(bodyprojectname, nameof(bodyprojectname), required: false);
            var __workflow_bodyprojectcode = WorkflowExpression.Compile(bodyprojectcode, nameof(bodyprojectcode), required: false);
            var __workflow_bodyprojectparameterCorrelationId = WorkflowExpression.Compile(bodyprojectparameterCorrelationId, nameof(bodyprojectparameterCorrelationId), required: false);
            var __workflow_bodytaskHierarchy = WorkflowExpression.Compile(bodytaskHierarchy, nameof(bodytaskHierarchy), required: false);
            var __workflow_bodytaskModificationOptionUri = WorkflowExpression.Compile(bodytaskModificationOptionUri, nameof(bodytaskModificationOptionUri), required: false);
            var __workflow_bodyunitOfWorkId = WorkflowExpression.Compile(bodyunitOfWorkId, nameof(bodyunitOfWorkId), required: false);
            return new DeferredBodyAction<CreateTaskHierarchyOrApplyModificationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/CreateTaskHierarchyOrApplyModifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (__workflow_bodyprojecturi != null)
                {
                    projectObject["uri"] = ExpressionConverter.ConvertO(__workflow_bodyprojecturi);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectname != null)
                {
                    projectObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyprojectname);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectcode != null)
                {
                    projectObject["code"] = ExpressionConverter.ConvertO(__workflow_bodyprojectcode);
                    projectObjectpropCount++;
                }

                if (__workflow_bodyprojectparameterCorrelationId != null)
                {
                    projectObject["parameterCorrelationId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectparameterCorrelationId);
                    projectObjectpropCount++;
                }

                if (projectObjectpropCount > 0)
                {
                    body["project"] = projectObject;
                    bodypropCount++;
                }

                if (__workflow_bodytaskHierarchy != null)
                {
                    body["taskHierarchy"] = ExpressionConverter.ConvertO(__workflow_bodytaskHierarchy);
                    bodypropCount++;
                }

                if (__workflow_bodytaskModificationOptionUri != null)
                {
                    body["taskModificationOptionUri"] = ExpressionConverter.ConvertO(__workflow_bodytaskModificationOptionUri);
                    bodypropCount++;
                }

                if (__workflow_bodyunitOfWorkId != null)
                {
                    body["unitOfWorkId"] = ExpressionConverter.ConvertO(__workflow_bodyunitOfWorkId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskHierarchyOrApplyModificationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTask(Expression<Func<string>> hostUrl, Expression<Func<string>> bodytaskUri = null, Expression<Func<string>> bodytargetUri = null, Expression<Func<string>> bodymoveTaskMethodUri = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodytaskUri = WorkflowExpression.Compile(bodytaskUri, nameof(bodytaskUri), required: false);
            var __workflow_bodytargetUri = WorkflowExpression.Compile(bodytargetUri, nameof(bodytargetUri), required: false);
            var __workflow_bodymoveTaskMethodUri = WorkflowExpression.Compile(bodymoveTaskMethodUri, nameof(bodymoveTaskMethodUri), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/MoveTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskUri != null)
                {
                    body["taskUri"] = ExpressionConverter.ConvertO(__workflow_bodytaskUri);
                    bodypropCount++;
                }

                if (__workflow_bodytargetUri != null)
                {
                    body["targetUri"] = ExpressionConverter.ConvertO(__workflow_bodytargetUri);
                    bodypropCount++;
                }

                if (__workflow_bodymoveTaskMethodUri != null)
                {
                    body["moveTaskMethodUri"] = ExpressionConverter.ConvertO(__workflow_bodymoveTaskMethodUri);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<TaskListServiceGetDataResponse, ApiConnectionActionConfiguration> TaskListServiceGetData(Expression<Func<string>> hostUrl, Expression<Func<string>> bodypage = null, Expression<Func<string>> bodypagesize = null, Expression<Func<string[]>> bodycolumnUris = null, Expression<Func<JToken[]>> bodysort = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodypage = WorkflowExpression.Compile(bodypage, nameof(bodypage), required: false);
            var __workflow_bodypagesize = WorkflowExpression.Compile(bodypagesize, nameof(bodypagesize), required: false);
            var __workflow_bodycolumnUris = WorkflowExpression.Compile(bodycolumnUris, nameof(bodycolumnUris), required: false);
            var __workflow_bodysort = WorkflowExpression.Compile(bodysort, nameof(bodysort), required: false);
            return new DeferredBodyAction<TaskListServiceGetDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskListService1.svc/GetData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypage != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypage);
                    bodypropCount++;
                }

                if (__workflow_bodypagesize != null)
                {
                    body["pagesize"] = ExpressionConverter.ConvertO(__workflow_bodypagesize);
                    bodypropCount++;
                }

                if (__workflow_bodycolumnUris != null)
                {
                    body["columnUris"] = ExpressionConverter.ConvertO(__workflow_bodycolumnUris);
                    bodypropCount++;
                }

                if (__workflow_bodysort != null)
                {
                    body["sort"] = ExpressionConverter.ConvertO(__workflow_bodysort);
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

                return new ApiConnectionAction<TaskListServiceGetDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<GetTimesheetSummaryResponse, ApiConnectionActionConfiguration> GetTimesheetSummary(Expression<Func<string>> hostUrl, Expression<Func<string>> bodytimesheetUri = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodytimesheetUri = WorkflowExpression.Compile(bodytimesheetUri, nameof(bodytimesheetUri), required: false);
            return new DeferredBodyAction<GetTimesheetSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TimesheetService1.svc/GetTimesheetSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytimesheetUri != null)
                {
                    body["timesheetUri"] = ExpressionConverter.ConvertO(__workflow_bodytimesheetUri);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTimesheetSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IBodyWorkflowAction<BulkGetTimeEnteredSummaryResponse, ApiConnectionActionConfiguration> BulkGetTimeEnteredSummary(Expression<Func<string>> hostUrl, Expression<Func<string[]>> bodytaskUris = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodytaskUris = WorkflowExpression.Compile(bodytaskUris, nameof(bodytaskUris), required: false);
            return new DeferredBodyAction<BulkGetTimeEnteredSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/BulkGetTimeEnteredSummary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskUris != null)
                {
                    body["taskUris"] = ExpressionConverter.ConvertO(__workflow_bodytaskUris);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BulkGetTimeEnteredSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutProjectTeamMemberAssignments(Expression<Func<string>> hostUrl, Expression<Func<string>> bodyprojectUri = null, Expression<Func<string[]>> bodyresourceUris = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodyprojectUri = WorkflowExpression.Compile(bodyprojectUri, nameof(bodyprojectUri), required: false);
            var __workflow_bodyresourceUris = WorkflowExpression.Compile(bodyresourceUris, nameof(bodyresourceUris), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/ProjectService1.svc/PutProjectTeamMemberAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprojectUri != null)
                {
                    body["projectUri"] = ExpressionConverter.ConvertO(__workflow_bodyprojectUri);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceUris != null)
                {
                    body["resourceUris"] = ExpressionConverter.ConvertO(__workflow_bodyresourceUris);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "replicon")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutResourceAssignments(Expression<Func<string>> hostUrl, Expression<Func<string>> bodytaskUri = null, Expression<Func<string[]>> bodyresourceUris = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodytaskUri = WorkflowExpression.Compile(bodytaskUri, nameof(bodytaskUri), required: false);
            var __workflow_bodyresourceUris = WorkflowExpression.Compile(bodyresourceUris, nameof(bodyresourceUris), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/TaskService1.svc/PutResourceAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskUri != null)
                {
                    body["taskUri"] = ExpressionConverter.ConvertO(__workflow_bodytaskUri);
                    bodypropCount++;
                }

                if (__workflow_bodyresourceUris != null)
                {
                    body["resourceUris"] = ExpressionConverter.ConvertO(__workflow_bodyresourceUris);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowTrigger<WebhookSubscriptionResponse, ApiConnectionTriggerConfiguration> WebhookSubscriptionsRestAPI(Expression<Func<string>> hostUrl, Expression<Func<string>> bodyeventType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_hostUrl = WorkflowExpression.Compile(hostUrl, nameof(hostUrl), required: true);
            var __workflow_bodyeventType = WorkflowExpression.Compile(bodyeventType, nameof(bodyeventType), required: false);
            return new DeferredBodyTrigger<WebhookSubscriptionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook-api/api/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hostUrl"] = ExpressionConverter.Convert(__workflow_hostUrl);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                    bodypropCount++;
                }

                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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