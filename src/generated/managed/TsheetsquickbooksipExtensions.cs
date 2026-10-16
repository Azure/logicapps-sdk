//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tsheetsquickbooksip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TsheetsquickbooksipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetJobcodesResponse> GetJobcodes(Expression<Func<string>> ids = null, Expression<Func<string>> parentIds = null, Expression<Func<string>> name = null, Expression<Func<typeInput>> type = null, Expression<Func<bool>> customfields = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> modifiedSince = null, Expression<Func<supplementalDataInput>> supplementalData = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null, Expression<Func<activeInput>> active = null)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_parentIds = WorkflowExpression.Compile(parentIds, nameof(parentIds), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_customfields = WorkflowExpression.Compile(customfields, nameof(customfields), required: false);
            var __workflow_modifiedBefore = WorkflowExpression.Compile(modifiedBefore, nameof(modifiedBefore), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_supplementalData = WorkflowExpression.Compile(supplementalData, nameof(supplementalData), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            return new DeferredBodyAction<GetJobcodesResponse>(() =>
            {
                var apiCallPath = "/jobcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_parentIds != null)
                    callPayload.Queries["parent_ids"] = ExpressionConverter.Convert(__workflow_parentIds);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["type"] = Convert.ToString("regular");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_customfields != null)
                    callPayload.Queries["customfields"] = ExpressionConverter.Convert(__workflow_customfields);
                if (__workflow_modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(__workflow_modifiedBefore);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modified_since"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (__workflow_supplementalData != null)
                    callPayload.Queries["supplemental_data"] = ExpressionConverter.Convert(__workflow_supplementalData);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                return new ApiConnectionAction<GetJobcodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects(Expression<Func<string>> ids = null, Expression<Func<string>> jobcodeIds = null, Expression<Func<int>> parentJobcodeId = null, Expression<Func<string>> name = null, Expression<Func<activeInput>> active = null, Expression<Func<bool>> byJobcodeAssignment = null)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_jobcodeIds = WorkflowExpression.Compile(jobcodeIds, nameof(jobcodeIds), required: false);
            var __workflow_parentJobcodeId = WorkflowExpression.Compile(parentJobcodeId, nameof(parentJobcodeId), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_byJobcodeAssignment = WorkflowExpression.Compile(byJobcodeAssignment, nameof(byJobcodeAssignment), required: false);
            return new DeferredBodyAction<GetProjectsResponse>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_jobcodeIds != null)
                    callPayload.Queries["jobcode_ids"] = ExpressionConverter.Convert(__workflow_jobcodeIds);
                if (__workflow_parentJobcodeId != null)
                    callPayload.Queries["parent_jobcode_id"] = ExpressionConverter.Convert(__workflow_parentJobcodeId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_byJobcodeAssignment != null)
                    callPayload.Queries["by_jobcode_assignment"] = ExpressionConverter.Convert(__workflow_byJobcodeAssignment);
                return new ApiConnectionAction<GetProjectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers(Expression<Func<string>> ids = null, Expression<Func<string>> notIds = null, Expression<Func<string>> employeeNumbers = null, Expression<Func<string>> usernames = null, Expression<Func<string>> groupIds = null, Expression<Func<string>> notGroupIds = null, Expression<Func<string>> payrollIds = null, Expression<Func<activeInput>> active = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> modifiedSince = null, Expression<Func<supplementalDataInput>> supplementalData = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_notIds = WorkflowExpression.Compile(notIds, nameof(notIds), required: false);
            var __workflow_employeeNumbers = WorkflowExpression.Compile(employeeNumbers, nameof(employeeNumbers), required: false);
            var __workflow_usernames = WorkflowExpression.Compile(usernames, nameof(usernames), required: false);
            var __workflow_groupIds = WorkflowExpression.Compile(groupIds, nameof(groupIds), required: false);
            var __workflow_notGroupIds = WorkflowExpression.Compile(notGroupIds, nameof(notGroupIds), required: false);
            var __workflow_payrollIds = WorkflowExpression.Compile(payrollIds, nameof(payrollIds), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_modifiedBefore = WorkflowExpression.Compile(modifiedBefore, nameof(modifiedBefore), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_supplementalData = WorkflowExpression.Compile(supplementalData, nameof(supplementalData), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetUsersResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_notIds != null)
                    callPayload.Queries["not_ids"] = ExpressionConverter.Convert(__workflow_notIds);
                if (__workflow_employeeNumbers != null)
                    callPayload.Queries["employee_numbers"] = ExpressionConverter.Convert(__workflow_employeeNumbers);
                if (__workflow_usernames != null)
                    callPayload.Queries["usernames"] = ExpressionConverter.Convert(__workflow_usernames);
                if (__workflow_groupIds != null)
                    callPayload.Queries["group_ids"] = ExpressionConverter.Convert(__workflow_groupIds);
                if (__workflow_notGroupIds != null)
                    callPayload.Queries["not_group_ids"] = ExpressionConverter.Convert(__workflow_notGroupIds);
                if (__workflow_payrollIds != null)
                    callPayload.Queries["payroll_ids"] = ExpressionConverter.Convert(__workflow_payrollIds);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["last_name"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(__workflow_modifiedBefore);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modified_since"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (__workflow_supplementalData != null)
                    callPayload.Queries["supplemental_data"] = ExpressionConverter.Convert(__workflow_supplementalData);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetTimesheetsResponse> GetTimesheets(Expression<Func<string>> ids = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> jobcodeIds = null, Expression<Func<string>> payrollIds = null, Expression<Func<string>> userIds = null, Expression<Func<string>> groupIds = null, Expression<Func<onTheClockInput>> onTheClock = null, Expression<Func<jobcodeTypeInput>> jobcodeType = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> modifiedSince = null, Expression<Func<supplementalDataInput>> supplementalData = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_jobcodeIds = WorkflowExpression.Compile(jobcodeIds, nameof(jobcodeIds), required: false);
            var __workflow_payrollIds = WorkflowExpression.Compile(payrollIds, nameof(payrollIds), required: false);
            var __workflow_userIds = WorkflowExpression.Compile(userIds, nameof(userIds), required: false);
            var __workflow_groupIds = WorkflowExpression.Compile(groupIds, nameof(groupIds), required: false);
            var __workflow_onTheClock = WorkflowExpression.Compile(onTheClock, nameof(onTheClock), required: false);
            var __workflow_jobcodeType = WorkflowExpression.Compile(jobcodeType, nameof(jobcodeType), required: false);
            var __workflow_modifiedBefore = WorkflowExpression.Compile(modifiedBefore, nameof(modifiedBefore), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_supplementalData = WorkflowExpression.Compile(supplementalData, nameof(supplementalData), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetTimesheetsResponse>(() =>
            {
                var apiCallPath = "/timesheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_jobcodeIds != null)
                    callPayload.Queries["jobcode_ids"] = ExpressionConverter.Convert(__workflow_jobcodeIds);
                if (__workflow_payrollIds != null)
                    callPayload.Queries["payroll_ids"] = ExpressionConverter.Convert(__workflow_payrollIds);
                if (__workflow_userIds != null)
                    callPayload.Queries["user_ids"] = ExpressionConverter.Convert(__workflow_userIds);
                if (__workflow_groupIds != null)
                    callPayload.Queries["group_ids"] = ExpressionConverter.Convert(__workflow_groupIds);
                callPayload.Queries["on_the_clock"] = Convert.ToString("no");
                if (__workflow_onTheClock != null)
                    callPayload.Queries["on_the_clock"] = ExpressionConverter.Convert(__workflow_onTheClock);
                callPayload.Queries["jobcode_type"] = Convert.ToString("all");
                if (__workflow_jobcodeType != null)
                    callPayload.Queries["jobcode_type"] = ExpressionConverter.Convert(__workflow_jobcodeType);
                if (__workflow_modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(__workflow_modifiedBefore);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modified_since"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (__workflow_supplementalData != null)
                    callPayload.Queries["supplemental_data"] = ExpressionConverter.Convert(__workflow_supplementalData);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetTimesheetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetNotificationsResponse> GetNotifications(Expression<Func<string>> ids = null, Expression<Func<string>> deliveryBefore = null, Expression<Func<string>> deliveryAfter = null, Expression<Func<int>> userId = null, Expression<Func<string>> msgTrackingId = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_deliveryBefore = WorkflowExpression.Compile(deliveryBefore, nameof(deliveryBefore), required: false);
            var __workflow_deliveryAfter = WorkflowExpression.Compile(deliveryAfter, nameof(deliveryAfter), required: false);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_msgTrackingId = WorkflowExpression.Compile(msgTrackingId, nameof(msgTrackingId), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetNotificationsResponse>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_deliveryBefore != null)
                    callPayload.Queries["delivery_before"] = ExpressionConverter.Convert(__workflow_deliveryBefore);
                if (__workflow_deliveryAfter != null)
                    callPayload.Queries["delivery_after"] = ExpressionConverter.Convert(__workflow_deliveryAfter);
                if (__workflow_userId != null)
                    callPayload.Queries["user_id"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_msgTrackingId != null)
                    callPayload.Queries["msg_tracking_id"] = ExpressionConverter.Convert(__workflow_msgTrackingId);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum supplementalDataInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum onTheClockInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "both")]
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
