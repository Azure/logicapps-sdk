//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tsheetsquickbooksip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TsheetsquickbooksipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetJobcodesResponse> GetJobcodes(Expression<Func<string>> ids = null, Expression<Func<string>> parentIds = null, Expression<Func<string>> name = null, Expression<Func<typeInput>> type = null, Expression<Func<bool>> customfields = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> modifiedSince = null, Expression<Func<supplementalDataInput>> supplementalData = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null, Expression<Func<activeInput>> active = null)
        {
            var apiCallPath = "/jobcodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (parentIds != null)
                callPayload.Queries["parent_ids"] = CSharpExpressionConverter.ConvertO(parentIds);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            callPayload.Queries["type"] = Convert.ToString("regular");
            if (type != null)
                callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            if (customfields != null)
                callPayload.Queries["customfields"] = CSharpExpressionConverter.ConvertO(customfields);
            if (modifiedBefore != null)
                callPayload.Queries["modified_before"] = CSharpExpressionConverter.ConvertO(modifiedBefore);
            if (modifiedSince != null)
                callPayload.Queries["modified_since"] = CSharpExpressionConverter.ConvertO(modifiedSince);
            callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
            if (supplementalData != null)
                callPayload.Queries["supplemental_data"] = CSharpExpressionConverter.Convert(supplementalData);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            callPayload.Queries["active"] = Convert.ToString("yes");
            if (active != null)
                callPayload.Queries["active"] = CSharpExpressionConverter.Convert(active);
            return new ApiConnectionAction<GetJobcodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects(Expression<Func<string>> ids = null, Expression<Func<string>> jobcodeIds = null, Expression<Func<int>> parentJobcodeId = null, Expression<Func<string>> name = null, Expression<Func<activeInput>> active = null, Expression<Func<bool>> byJobcodeAssignment = null)
        {
            var apiCallPath = "/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (jobcodeIds != null)
                callPayload.Queries["jobcode_ids"] = CSharpExpressionConverter.ConvertO(jobcodeIds);
            if (parentJobcodeId != null)
                callPayload.Queries["parent_jobcode_id"] = CSharpExpressionConverter.ConvertO(parentJobcodeId);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            callPayload.Queries["active"] = Convert.ToString("yes");
            if (active != null)
                callPayload.Queries["active"] = CSharpExpressionConverter.Convert(active);
            if (byJobcodeAssignment != null)
                callPayload.Queries["by_jobcode_assignment"] = CSharpExpressionConverter.ConvertO(byJobcodeAssignment);
            return new ApiConnectionAction<GetProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers(Expression<Func<string>> ids = null, Expression<Func<string>> notIds = null, Expression<Func<string>> employeeNumbers = null, Expression<Func<string>> usernames = null, Expression<Func<string>> groupIds = null, Expression<Func<string>> notGroupIds = null, Expression<Func<string>> payrollIds = null, Expression<Func<activeInput>> active = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> modifiedSince = null, Expression<Func<supplementalDataInput>> supplementalData = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (notIds != null)
                callPayload.Queries["not_ids"] = CSharpExpressionConverter.ConvertO(notIds);
            if (employeeNumbers != null)
                callPayload.Queries["employee_numbers"] = CSharpExpressionConverter.ConvertO(employeeNumbers);
            if (usernames != null)
                callPayload.Queries["usernames"] = CSharpExpressionConverter.ConvertO(usernames);
            if (groupIds != null)
                callPayload.Queries["group_ids"] = CSharpExpressionConverter.ConvertO(groupIds);
            if (notGroupIds != null)
                callPayload.Queries["not_group_ids"] = CSharpExpressionConverter.ConvertO(notGroupIds);
            if (payrollIds != null)
                callPayload.Queries["payroll_ids"] = CSharpExpressionConverter.ConvertO(payrollIds);
            callPayload.Queries["active"] = Convert.ToString("yes");
            if (active != null)
                callPayload.Queries["active"] = CSharpExpressionConverter.Convert(active);
            if (firstName != null)
                callPayload.Queries["first_name"] = CSharpExpressionConverter.ConvertO(firstName);
            if (lastName != null)
                callPayload.Queries["last_name"] = CSharpExpressionConverter.ConvertO(lastName);
            if (modifiedBefore != null)
                callPayload.Queries["modified_before"] = CSharpExpressionConverter.ConvertO(modifiedBefore);
            if (modifiedSince != null)
                callPayload.Queries["modified_since"] = CSharpExpressionConverter.ConvertO(modifiedSince);
            callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
            if (supplementalData != null)
                callPayload.Queries["supplemental_data"] = CSharpExpressionConverter.Convert(supplementalData);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            return new ApiConnectionAction<GetUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetTimesheetsResponse> GetTimesheets(Expression<Func<string>> ids = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> jobcodeIds = null, Expression<Func<string>> payrollIds = null, Expression<Func<string>> userIds = null, Expression<Func<string>> groupIds = null, Expression<Func<onTheClockInput>> onTheClock = null, Expression<Func<jobcodeTypeInput>> jobcodeType = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> modifiedSince = null, Expression<Func<supplementalDataInput>> supplementalData = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/timesheets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (jobcodeIds != null)
                callPayload.Queries["jobcode_ids"] = CSharpExpressionConverter.ConvertO(jobcodeIds);
            if (payrollIds != null)
                callPayload.Queries["payroll_ids"] = CSharpExpressionConverter.ConvertO(payrollIds);
            if (userIds != null)
                callPayload.Queries["user_ids"] = CSharpExpressionConverter.ConvertO(userIds);
            if (groupIds != null)
                callPayload.Queries["group_ids"] = CSharpExpressionConverter.ConvertO(groupIds);
            callPayload.Queries["on_the_clock"] = Convert.ToString("no");
            if (onTheClock != null)
                callPayload.Queries["on_the_clock"] = CSharpExpressionConverter.Convert(onTheClock);
            callPayload.Queries["jobcode_type"] = Convert.ToString("all");
            if (jobcodeType != null)
                callPayload.Queries["jobcode_type"] = CSharpExpressionConverter.Convert(jobcodeType);
            if (modifiedBefore != null)
                callPayload.Queries["modified_before"] = CSharpExpressionConverter.ConvertO(modifiedBefore);
            if (modifiedSince != null)
                callPayload.Queries["modified_since"] = CSharpExpressionConverter.ConvertO(modifiedSince);
            callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
            if (supplementalData != null)
                callPayload.Queries["supplemental_data"] = CSharpExpressionConverter.Convert(supplementalData);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            return new ApiConnectionAction<GetTimesheetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetNotificationsResponse> GetNotifications(Expression<Func<string>> ids = null, Expression<Func<string>> deliveryBefore = null, Expression<Func<string>> deliveryAfter = null, Expression<Func<int>> userId = null, Expression<Func<string>> msgTrackingId = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/notifications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = CSharpExpressionConverter.ConvertO(ids);
            if (deliveryBefore != null)
                callPayload.Queries["delivery_before"] = CSharpExpressionConverter.ConvertO(deliveryBefore);
            if (deliveryAfter != null)
                callPayload.Queries["delivery_after"] = CSharpExpressionConverter.ConvertO(deliveryAfter);
            if (userId != null)
                callPayload.Queries["user_id"] = CSharpExpressionConverter.ConvertO(userId);
            if (msgTrackingId != null)
                callPayload.Queries["msg_tracking_id"] = CSharpExpressionConverter.ConvertO(msgTrackingId);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            return new ApiConnectionAction<GetNotificationsResponse>(callPayload);
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