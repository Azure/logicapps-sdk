//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tsheetsquickbooksip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TsheetsquickbooksipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [WorkflowExpressionFactory(nameof(__BuildGetJobcodes))]
        public IBodyWorkflowAction<GetJobcodesResponse> GetJobcodes([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> parentIds = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<bool> customfields = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<supplementalDataInput> supplementalData = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<activeInput> active = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetJobcodesResponse> __BuildGetJobcodes(WorkflowExpression<string> ids = null, WorkflowExpression<string> parentIds = null, WorkflowExpression<string> name = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<bool> customfields = null, WorkflowExpression<string> modifiedBefore = null, WorkflowExpression<string> modifiedSince = null, WorkflowExpression<supplementalDataInput> supplementalData = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> page = null, WorkflowExpression<activeInput> active = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(parentIds, nameof(parentIds), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(customfields, nameof(customfields), required: false);
            WorkflowExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            WorkflowExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            WorkflowExpression.Validate(supplementalData, nameof(supplementalData), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(active, nameof(active), required: false);
            return new DeferredBodyAction<GetJobcodesResponse>(() =>
            {
                var apiCallPath = "/jobcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (parentIds != null)
                    callPayload.Queries["parent_ids"] = ExpressionConverter.Convert(parentIds);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Queries["type"] = Convert.ToString("regular");
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (customfields != null)
                    callPayload.Queries["customfields"] = ExpressionConverter.Convert(customfields);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(modifiedBefore);
                if (modifiedSince != null)
                    callPayload.Queries["modified_since"] = ExpressionConverter.Convert(modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (supplementalData != null)
                    callPayload.Queries["supplemental_data"] = ExpressionConverter.Convert(supplementalData);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(active);
                return new ApiConnectionAction<GetJobcodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [WorkflowExpressionFactory(nameof(__BuildGetProjects))]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> jobcodeIds = null, [WorkflowExpression] Func<int> parentJobcodeId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<activeInput> active = null, [WorkflowExpression] Func<bool> byJobcodeAssignment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProjectsResponse> __BuildGetProjects(WorkflowExpression<string> ids = null, WorkflowExpression<string> jobcodeIds = null, WorkflowExpression<int> parentJobcodeId = null, WorkflowExpression<string> name = null, WorkflowExpression<activeInput> active = null, WorkflowExpression<bool> byJobcodeAssignment = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(jobcodeIds, nameof(jobcodeIds), required: false);
            WorkflowExpression.Validate(parentJobcodeId, nameof(parentJobcodeId), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(active, nameof(active), required: false);
            WorkflowExpression.Validate(byJobcodeAssignment, nameof(byJobcodeAssignment), required: false);
            return new DeferredBodyAction<GetProjectsResponse>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (jobcodeIds != null)
                    callPayload.Queries["jobcode_ids"] = ExpressionConverter.Convert(jobcodeIds);
                if (parentJobcodeId != null)
                    callPayload.Queries["parent_jobcode_id"] = ExpressionConverter.Convert(parentJobcodeId);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(active);
                if (byJobcodeAssignment != null)
                    callPayload.Queries["by_jobcode_assignment"] = ExpressionConverter.Convert(byJobcodeAssignment);
                return new ApiConnectionAction<GetProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [WorkflowExpressionFactory(nameof(__BuildGetUsers))]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> notIds = null, [WorkflowExpression] Func<string> employeeNumbers = null, [WorkflowExpression] Func<string> usernames = null, [WorkflowExpression] Func<string> groupIds = null, [WorkflowExpression] Func<string> notGroupIds = null, [WorkflowExpression] Func<string> payrollIds = null, [WorkflowExpression] Func<activeInput> active = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<supplementalDataInput> supplementalData = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUsersResponse> __BuildGetUsers(WorkflowExpression<string> ids = null, WorkflowExpression<string> notIds = null, WorkflowExpression<string> employeeNumbers = null, WorkflowExpression<string> usernames = null, WorkflowExpression<string> groupIds = null, WorkflowExpression<string> notGroupIds = null, WorkflowExpression<string> payrollIds = null, WorkflowExpression<activeInput> active = null, WorkflowExpression<string> firstName = null, WorkflowExpression<string> lastName = null, WorkflowExpression<string> modifiedBefore = null, WorkflowExpression<string> modifiedSince = null, WorkflowExpression<supplementalDataInput> supplementalData = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(notIds, nameof(notIds), required: false);
            WorkflowExpression.Validate(employeeNumbers, nameof(employeeNumbers), required: false);
            WorkflowExpression.Validate(usernames, nameof(usernames), required: false);
            WorkflowExpression.Validate(groupIds, nameof(groupIds), required: false);
            WorkflowExpression.Validate(notGroupIds, nameof(notGroupIds), required: false);
            WorkflowExpression.Validate(payrollIds, nameof(payrollIds), required: false);
            WorkflowExpression.Validate(active, nameof(active), required: false);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(lastName, nameof(lastName), required: false);
            WorkflowExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            WorkflowExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            WorkflowExpression.Validate(supplementalData, nameof(supplementalData), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<GetUsersResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (notIds != null)
                    callPayload.Queries["not_ids"] = ExpressionConverter.Convert(notIds);
                if (employeeNumbers != null)
                    callPayload.Queries["employee_numbers"] = ExpressionConverter.Convert(employeeNumbers);
                if (usernames != null)
                    callPayload.Queries["usernames"] = ExpressionConverter.Convert(usernames);
                if (groupIds != null)
                    callPayload.Queries["group_ids"] = ExpressionConverter.Convert(groupIds);
                if (notGroupIds != null)
                    callPayload.Queries["not_group_ids"] = ExpressionConverter.Convert(notGroupIds);
                if (payrollIds != null)
                    callPayload.Queries["payroll_ids"] = ExpressionConverter.Convert(payrollIds);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(active);
                if (firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["last_name"] = ExpressionConverter.Convert(lastName);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(modifiedBefore);
                if (modifiedSince != null)
                    callPayload.Queries["modified_since"] = ExpressionConverter.Convert(modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (supplementalData != null)
                    callPayload.Queries["supplemental_data"] = ExpressionConverter.Convert(supplementalData);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<GetUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimesheets))]
        public IBodyWorkflowAction<GetTimesheetsResponse> GetTimesheets([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> jobcodeIds = null, [WorkflowExpression] Func<string> payrollIds = null, [WorkflowExpression] Func<string> userIds = null, [WorkflowExpression] Func<string> groupIds = null, [WorkflowExpression] Func<onTheClockInput> onTheClock = null, [WorkflowExpression] Func<jobcodeTypeInput> jobcodeType = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<supplementalDataInput> supplementalData = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTimesheetsResponse> __BuildGetTimesheets(WorkflowExpression<string> ids = null, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> jobcodeIds = null, WorkflowExpression<string> payrollIds = null, WorkflowExpression<string> userIds = null, WorkflowExpression<string> groupIds = null, WorkflowExpression<onTheClockInput> onTheClock = null, WorkflowExpression<jobcodeTypeInput> jobcodeType = null, WorkflowExpression<string> modifiedBefore = null, WorkflowExpression<string> modifiedSince = null, WorkflowExpression<supplementalDataInput> supplementalData = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(jobcodeIds, nameof(jobcodeIds), required: false);
            WorkflowExpression.Validate(payrollIds, nameof(payrollIds), required: false);
            WorkflowExpression.Validate(userIds, nameof(userIds), required: false);
            WorkflowExpression.Validate(groupIds, nameof(groupIds), required: false);
            WorkflowExpression.Validate(onTheClock, nameof(onTheClock), required: false);
            WorkflowExpression.Validate(jobcodeType, nameof(jobcodeType), required: false);
            WorkflowExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            WorkflowExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            WorkflowExpression.Validate(supplementalData, nameof(supplementalData), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<GetTimesheetsResponse>(() =>
            {
                var apiCallPath = "/timesheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (jobcodeIds != null)
                    callPayload.Queries["jobcode_ids"] = ExpressionConverter.Convert(jobcodeIds);
                if (payrollIds != null)
                    callPayload.Queries["payroll_ids"] = ExpressionConverter.Convert(payrollIds);
                if (userIds != null)
                    callPayload.Queries["user_ids"] = ExpressionConverter.Convert(userIds);
                if (groupIds != null)
                    callPayload.Queries["group_ids"] = ExpressionConverter.Convert(groupIds);
                callPayload.Queries["on_the_clock"] = Convert.ToString("no");
                if (onTheClock != null)
                    callPayload.Queries["on_the_clock"] = ExpressionConverter.Convert(onTheClock);
                callPayload.Queries["jobcode_type"] = Convert.ToString("all");
                if (jobcodeType != null)
                    callPayload.Queries["jobcode_type"] = ExpressionConverter.Convert(jobcodeType);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(modifiedBefore);
                if (modifiedSince != null)
                    callPayload.Queries["modified_since"] = ExpressionConverter.Convert(modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (supplementalData != null)
                    callPayload.Queries["supplemental_data"] = ExpressionConverter.Convert(supplementalData);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<GetTimesheetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [WorkflowExpressionFactory(nameof(__BuildGetNotifications))]
        public IBodyWorkflowAction<GetNotificationsResponse> GetNotifications([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> deliveryBefore = null, [WorkflowExpression] Func<string> deliveryAfter = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<string> msgTrackingId = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetNotificationsResponse> __BuildGetNotifications(WorkflowExpression<string> ids = null, WorkflowExpression<string> deliveryBefore = null, WorkflowExpression<string> deliveryAfter = null, WorkflowExpression<int> userId = null, WorkflowExpression<string> msgTrackingId = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(deliveryBefore, nameof(deliveryBefore), required: false);
            WorkflowExpression.Validate(deliveryAfter, nameof(deliveryAfter), required: false);
            WorkflowExpression.Validate(userId, nameof(userId), required: false);
            WorkflowExpression.Validate(msgTrackingId, nameof(msgTrackingId), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<GetNotificationsResponse>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                if (deliveryBefore != null)
                    callPayload.Queries["delivery_before"] = ExpressionConverter.Convert(deliveryBefore);
                if (deliveryAfter != null)
                    callPayload.Queries["delivery_after"] = ExpressionConverter.Convert(deliveryAfter);
                if (userId != null)
                    callPayload.Queries["user_id"] = ExpressionConverter.Convert(userId);
                if (msgTrackingId != null)
                    callPayload.Queries["msg_tracking_id"] = ExpressionConverter.Convert(msgTrackingId);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<GetNotificationsResponse>(callPayload);
            });
        }
    }

    public class TsheetsquickbooksipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetJobcodesResponse
    {
        [JsonProperty("results")]
        public GetJobcodesResponseResultsType Results { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class GetJobcodesResponseResultsType
    {
        [JsonProperty("jobcodes")]
        public JToken Jobcodes { get; set; }
    }

    public enum typeInput
    {
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "pto")]
        Pto,
        [EnumMember(Value = "paid_break")]
        PaidBreak,
        [EnumMember(Value = "unpaid_break")]
        UnpaidBreak,
        [EnumMember(Value = "all")]
        All
    }

    public enum supplementalDataInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public enum activeInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "both")]
        Both
    }

    public class GetProjectsResponse
    {
        [JsonProperty("results")]
        public GetProjectsResponseResultsType Results { get; set; }

        [JsonProperty("supplemental_data")]
        public GetProjectsResponseSupplementalDataType SupplementalData { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class GetProjectsResponseResultsType
    {
        [JsonProperty("projects")]
        public JToken Projects { get; set; }
    }

    public class GetProjectsResponseSupplementalDataType
    {
        [JsonProperty("jobcodes")]
        public JToken Jobcodes { get; set; }
    }

    public class GetUsersResponse
    {
        [JsonProperty("results")]
        public GetUsersResponseResultsType Results { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("supplemental_data")]
        public GetUsersResponseSupplementalDataType SupplementalData { get; set; }
    }

    public class GetUsersResponseResultsType
    {
        [JsonProperty("users")]
        public JToken Users { get; set; }
    }

    public class GetUsersResponseSupplementalDataType
    {
        [JsonProperty("jobcodes")]
        public JToken Jobcodes { get; set; }

        [JsonProperty("groups")]
        public JToken Groups { get; set; }
    }

    public class GetTimesheetsResponse
    {
        [JsonProperty("results")]
        public GetTimesheetsResponseResultsType Results { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("supplemental_data")]
        public GetTimesheetsResponseSupplementalDataType SupplementalData { get; set; }
    }

    public class GetTimesheetsResponseResultsType
    {
        [JsonProperty("timesheets")]
        public JToken Timesheets { get; set; }
    }

    public class GetTimesheetsResponseSupplementalDataType
    {
        [JsonProperty("jobcodes")]
        public JToken Jobcodes { get; set; }

        [JsonProperty("users")]
        public JToken Users { get; set; }

        [JsonProperty("customfields")]
        public JToken Customfields { get; set; }

        [JsonProperty("files")]
        public JToken Files { get; set; }
    }

    public enum onTheClockInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "both")]
        Both
    }

    public enum jobcodeTypeInput
    {
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "pto")]
        Pto,
        [EnumMember(Value = "paid_break")]
        PaidBreak,
        [EnumMember(Value = "unpaid_break")]
        UnpaidBreak,
        [EnumMember(Value = "all")]
        All
    }

    public class GetNotificationsResponse
    {
        [JsonProperty("results")]
        public GetNotificationsResponseResultsType Results { get; set; }
    }

    public class GetNotificationsResponseResultsType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tsheetsquickbooksip;

    public partial class WorkflowManagedActions
    {
        public TsheetsquickbooksipActions Tsheetsquickbooksip(string connectionId) => new TsheetsquickbooksipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TsheetsquickbooksipTriggers Tsheetsquickbooksip(string connectionId) => new TsheetsquickbooksipTriggers(connectionId);
    }
}