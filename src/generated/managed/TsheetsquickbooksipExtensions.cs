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
        public IBodyWorkflowAction<GetJobcodesResponse> GetJobcodes([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> parentIds = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<bool> customfields = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<supplementalDataInput> supplementalData = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<activeInput> active = null)
        {
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(parentIds, nameof(parentIds), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(customfields, nameof(customfields), required: false);
            SourceExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(supplementalData, nameof(supplementalData), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(active, nameof(active), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/jobcodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (parentIds != null)
                    callPayload.Queries["parent_ids"] = SourceExpressionConverter.ConvertO(parentIds);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["type"] = Convert.ToString("regular");
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (customfields != null)
                    callPayload.Queries["customfields"] = SourceExpressionConverter.ConvertO(customfields);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = SourceExpressionConverter.ConvertO(modifiedBefore);
                if (modifiedSince != null)
                    callPayload.Queries["modified_since"] = SourceExpressionConverter.ConvertO(modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (supplementalData != null)
                    callPayload.Queries["supplemental_data"] = SourceExpressionConverter.Convert(supplementalData);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.Convert(active);
                return callPayload;
            }

            return new ApiConnectionAction<GetJobcodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetProjectsResponse> GetProjects([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> jobcodeIds = null, [WorkflowExpression] Func<int> parentJobcodeId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<activeInput> active = null, [WorkflowExpression] Func<bool> byJobcodeAssignment = null)
        {
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(jobcodeIds, nameof(jobcodeIds), required: false);
            SourceExpression.Validate(parentJobcodeId, nameof(parentJobcodeId), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(active, nameof(active), required: false);
            SourceExpression.Validate(byJobcodeAssignment, nameof(byJobcodeAssignment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (jobcodeIds != null)
                    callPayload.Queries["jobcode_ids"] = SourceExpressionConverter.ConvertO(jobcodeIds);
                if (parentJobcodeId != null)
                    callPayload.Queries["parent_jobcode_id"] = SourceExpressionConverter.ConvertO(parentJobcodeId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.Convert(active);
                if (byJobcodeAssignment != null)
                    callPayload.Queries["by_jobcode_assignment"] = SourceExpressionConverter.ConvertO(byJobcodeAssignment);
                return callPayload;
            }

            return new ApiConnectionAction<GetProjectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> notIds = null, [WorkflowExpression] Func<string> employeeNumbers = null, [WorkflowExpression] Func<string> usernames = null, [WorkflowExpression] Func<string> groupIds = null, [WorkflowExpression] Func<string> notGroupIds = null, [WorkflowExpression] Func<string> payrollIds = null, [WorkflowExpression] Func<activeInput> active = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<supplementalDataInput> supplementalData = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(notIds, nameof(notIds), required: false);
            SourceExpression.Validate(employeeNumbers, nameof(employeeNumbers), required: false);
            SourceExpression.Validate(usernames, nameof(usernames), required: false);
            SourceExpression.Validate(groupIds, nameof(groupIds), required: false);
            SourceExpression.Validate(notGroupIds, nameof(notGroupIds), required: false);
            SourceExpression.Validate(payrollIds, nameof(payrollIds), required: false);
            SourceExpression.Validate(active, nameof(active), required: false);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(lastName, nameof(lastName), required: false);
            SourceExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(supplementalData, nameof(supplementalData), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (notIds != null)
                    callPayload.Queries["not_ids"] = SourceExpressionConverter.ConvertO(notIds);
                if (employeeNumbers != null)
                    callPayload.Queries["employee_numbers"] = SourceExpressionConverter.ConvertO(employeeNumbers);
                if (usernames != null)
                    callPayload.Queries["usernames"] = SourceExpressionConverter.ConvertO(usernames);
                if (groupIds != null)
                    callPayload.Queries["group_ids"] = SourceExpressionConverter.ConvertO(groupIds);
                if (notGroupIds != null)
                    callPayload.Queries["not_group_ids"] = SourceExpressionConverter.ConvertO(notGroupIds);
                if (payrollIds != null)
                    callPayload.Queries["payroll_ids"] = SourceExpressionConverter.ConvertO(payrollIds);
                callPayload.Queries["active"] = Convert.ToString("yes");
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.Convert(active);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["last_name"] = SourceExpressionConverter.ConvertO(lastName);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = SourceExpressionConverter.ConvertO(modifiedBefore);
                if (modifiedSince != null)
                    callPayload.Queries["modified_since"] = SourceExpressionConverter.ConvertO(modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (supplementalData != null)
                    callPayload.Queries["supplemental_data"] = SourceExpressionConverter.Convert(supplementalData);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GetUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetTimesheetsResponse> GetTimesheets([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> jobcodeIds = null, [WorkflowExpression] Func<string> payrollIds = null, [WorkflowExpression] Func<string> userIds = null, [WorkflowExpression] Func<string> groupIds = null, [WorkflowExpression] Func<onTheClockInput> onTheClock = null, [WorkflowExpression] Func<jobcodeTypeInput> jobcodeType = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<supplementalDataInput> supplementalData = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(jobcodeIds, nameof(jobcodeIds), required: false);
            SourceExpression.Validate(payrollIds, nameof(payrollIds), required: false);
            SourceExpression.Validate(userIds, nameof(userIds), required: false);
            SourceExpression.Validate(groupIds, nameof(groupIds), required: false);
            SourceExpression.Validate(onTheClock, nameof(onTheClock), required: false);
            SourceExpression.Validate(jobcodeType, nameof(jobcodeType), required: false);
            SourceExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(supplementalData, nameof(supplementalData), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/timesheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (jobcodeIds != null)
                    callPayload.Queries["jobcode_ids"] = SourceExpressionConverter.ConvertO(jobcodeIds);
                if (payrollIds != null)
                    callPayload.Queries["payroll_ids"] = SourceExpressionConverter.ConvertO(payrollIds);
                if (userIds != null)
                    callPayload.Queries["user_ids"] = SourceExpressionConverter.ConvertO(userIds);
                if (groupIds != null)
                    callPayload.Queries["group_ids"] = SourceExpressionConverter.ConvertO(groupIds);
                callPayload.Queries["on_the_clock"] = Convert.ToString("no");
                if (onTheClock != null)
                    callPayload.Queries["on_the_clock"] = SourceExpressionConverter.Convert(onTheClock);
                callPayload.Queries["jobcode_type"] = Convert.ToString("all");
                if (jobcodeType != null)
                    callPayload.Queries["jobcode_type"] = SourceExpressionConverter.Convert(jobcodeType);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = SourceExpressionConverter.ConvertO(modifiedBefore);
                if (modifiedSince != null)
                    callPayload.Queries["modified_since"] = SourceExpressionConverter.ConvertO(modifiedSince);
                callPayload.Queries["supplemental_data"] = Convert.ToString("yes");
                if (supplementalData != null)
                    callPayload.Queries["supplemental_data"] = SourceExpressionConverter.Convert(supplementalData);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GetTimesheetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tsheetsquickbooksip")]
        public IBodyWorkflowAction<GetNotificationsResponse> GetNotifications([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> deliveryBefore = null, [WorkflowExpression] Func<string> deliveryAfter = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<string> msgTrackingId = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(deliveryBefore, nameof(deliveryBefore), required: false);
            SourceExpression.Validate(deliveryAfter, nameof(deliveryAfter), required: false);
            SourceExpression.Validate(userId, nameof(userId), required: false);
            SourceExpression.Validate(msgTrackingId, nameof(msgTrackingId), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (deliveryBefore != null)
                    callPayload.Queries["delivery_before"] = SourceExpressionConverter.ConvertO(deliveryBefore);
                if (deliveryAfter != null)
                    callPayload.Queries["delivery_after"] = SourceExpressionConverter.ConvertO(deliveryAfter);
                if (userId != null)
                    callPayload.Queries["user_id"] = SourceExpressionConverter.ConvertO(userId);
                if (msgTrackingId != null)
                    callPayload.Queries["msg_tracking_id"] = SourceExpressionConverter.ConvertO(msgTrackingId);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GetNotificationsResponse>(BuildSourceInput);
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