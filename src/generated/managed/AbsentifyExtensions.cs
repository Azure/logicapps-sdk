//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Absentify
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbsentifyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<Member[]> GetMembers(Expression<Func<string[]>> departmentIds = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> employmentStartDateFrom = null, Expression<Func<string>> employmentStartDateTo = null, Expression<Func<string>> employmentEndDateFrom = null, Expression<Func<string>> employmentEndDateTo = null, Expression<Func<bool>> isAdmin = null, Expression<Func<approvalProcessInput>> approvalProcess = null, Expression<Func<bool>> hasApprovers = null, Expression<Func<string>> allowanceTypeId = null, Expression<Func<string>> name = null, Expression<Func<int>> birthdayMonth = null, Expression<Func<managerTypeInput>> managerType = null)
        {
            var apiCallPath = "/v1/members";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (departmentIds != null)
                callPayload.Queries["department_ids"] = ExpressionConverter.Convert(departmentIds);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (employmentStartDateFrom != null)
                callPayload.Queries["employment_start_date_from"] = ExpressionConverter.Convert(employmentStartDateFrom);
            if (employmentStartDateTo != null)
                callPayload.Queries["employment_start_date_to"] = ExpressionConverter.Convert(employmentStartDateTo);
            if (employmentEndDateFrom != null)
                callPayload.Queries["employment_end_date_from"] = ExpressionConverter.Convert(employmentEndDateFrom);
            if (employmentEndDateTo != null)
                callPayload.Queries["employment_end_date_to"] = ExpressionConverter.Convert(employmentEndDateTo);
            if (isAdmin != null)
                callPayload.Queries["is_admin"] = ExpressionConverter.Convert(isAdmin);
            if (approvalProcess != null)
                callPayload.Queries["approval_process"] = ExpressionConverter.Convert(approvalProcess);
            if (hasApprovers != null)
                callPayload.Queries["has_approvers"] = ExpressionConverter.Convert(hasApprovers);
            if (allowanceTypeId != null)
                callPayload.Queries["allowance_type_id"] = ExpressionConverter.Convert(allowanceTypeId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (birthdayMonth != null)
                callPayload.Queries["birthday_month"] = ExpressionConverter.Convert(birthdayMonth);
            if (managerType != null)
                callPayload.Queries["manager_type"] = ExpressionConverter.Convert(managerType);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> InviteMember(Expression<Func<string>> bodyname, Expression<Func<bodydepartmentIDsInputItem[]>> bodydepartmentIDs, Expression<Func<string>> bodypublicHolidayCalendarID, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyemploymentStartDate = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodycustomID = null)
        {
            var apiCallPath = "/v1/members";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            bodypropCount++;
            body["department_ids"] = ExpressionConverter.ConvertO(bodydepartmentIDs);
            if (bodyemploymentStartDate != null)
            {
                body["employment_start_date"] = ExpressionConverter.ConvertO(bodyemploymentStartDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["public_holiday_id"] = ExpressionConverter.ConvertO(bodypublicHolidayCalendarID);
            if (bodybirthday != null)
            {
                body["birthday"] = ExpressionConverter.ConvertO(bodybirthday);
                bodypropCount++;
            }

            if (bodycustomID != null)
            {
                body["custom_id"] = ExpressionConverter.ConvertO(bodycustomID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<MemberDetail> GetMemberById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/members/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> DeleteMember(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/members/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> UpdateMember(Expression<Func<string>> id, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<bodydepartmentIDsInputItem[]>> bodydepartmentIDs = null, Expression<Func<string>> bodyemploymentStartDate = null, Expression<Func<string>> bodyemploymentEndDate = null, Expression<Func<string>> bodypublicHolidayCalendarID = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodycustomID = null, Expression<Func<bodystatusInput>> bodystatus = null)
        {
            var apiCallPath = String.Format("/v1/members/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyisAdmin != null)
            {
                body["is_admin"] = ExpressionConverter.ConvertO(bodyisAdmin);
                bodypropCount++;
            }

            if (bodydepartmentIDs != null)
            {
                body["department_ids"] = ExpressionConverter.ConvertO(bodydepartmentIDs);
                bodypropCount++;
            }

            if (bodyemploymentStartDate != null)
            {
                body["employment_start_date"] = ExpressionConverter.ConvertO(bodyemploymentStartDate);
                bodypropCount++;
            }

            if (bodyemploymentEndDate != null)
            {
                body["employment_end_date"] = ExpressionConverter.ConvertO(bodyemploymentEndDate);
                bodypropCount++;
            }

            if (bodypublicHolidayCalendarID != null)
            {
                body["public_holiday_id"] = ExpressionConverter.ConvertO(bodypublicHolidayCalendarID);
                bodypropCount++;
            }

            if (bodybirthday != null)
            {
                body["birthday"] = ExpressionConverter.ConvertO(bodybirthday);
                bodypropCount++;
            }

            if (bodycustomID != null)
            {
                body["custom_id"] = ExpressionConverter.ConvertO(bodycustomID);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<MemberDetail> GetMemberByMicrosoftId(Expression<Func<string>> microsoftUserId)
        {
            var apiCallPath = String.Format("/v1/members/microsoft/{0}", ExpressionConverter.ConvertWithUrlEncoding(microsoftUserId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<MemberDetail> GetMemberByEmail(Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/v1/members/email/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<MemberDetail> GetMemberByCustomId(Expression<Func<string>> customId)
        {
            var apiCallPath = String.Format("/v1/members/custom_id/{0}", ExpressionConverter.ConvertWithUrlEncoding(customId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> UpdateMemberApprovers(Expression<Func<string>> id, Expression<Func<bodyapprovalProcessInput>> bodyapprovalProcess, Expression<Func<bodyapproversInputItem[]>> bodyapprovers = null)
        {
            var apiCallPath = String.Format("/v1/members/{0}/approvers", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["approval_process"] = ExpressionConverter.ConvertO(bodyapprovalProcess);
            if (bodyapprovers != null)
            {
                body["approvers"] = ExpressionConverter.ConvertO(bodyapprovers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> UpdateMemberAllowance(Expression<Func<string>> id, Expression<Func<string>> allowanceTypeId, Expression<Func<int>> year, Expression<Func<double>> bodyallowance, Expression<Func<double>> bodycompensatoryTimeOff, Expression<Func<double>> bodybroughtForward = null, Expression<Func<string>> bodyreason = null, Expression<Func<bool>> bodyoverwriteBroughtForward = null, Expression<Func<bool>> bodysetAsDefault = null, Expression<Func<bool>> bodydisabled = null)
        {
            var apiCallPath = String.Format("/v1/members/{0}/allowance/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(allowanceTypeId, 1), ExpressionConverter.ConvertWithUrlEncoding(year, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["allowance"] = ExpressionConverter.ConvertO(bodyallowance);
            bodypropCount++;
            body["compensatory_time_off"] = ExpressionConverter.ConvertO(bodycompensatoryTimeOff);
            if (bodybroughtForward != null)
            {
                body["brought_forward"] = ExpressionConverter.ConvertO(bodybroughtForward);
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodyoverwriteBroughtForward != null)
            {
                body["overwrite_brought_forward"] = ExpressionConverter.ConvertO(bodyoverwriteBroughtForward);
                bodypropCount++;
            }

            if (bodysetAsDefault != null)
            {
                body["set_as_default"] = ExpressionConverter.ConvertO(bodysetAsDefault);
                bodypropCount++;
            }

            if (bodydisabled != null)
            {
                body["disabled"] = ExpressionConverter.ConvertO(bodydisabled);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> AddMemberSchedule(Expression<Func<string>> id, Expression<Func<string>> bodyfromDate = null, Expression<Func<bool>> bodymondayAMEnabled = null, Expression<Func<bool>> bodymondayPMEnabled = null, Expression<Func<bool>> bodytuesdayAMEnabled = null, Expression<Func<bool>> bodytuesdayPMEnabled = null, Expression<Func<bool>> bodywednesdayAMEnabled = null, Expression<Func<bool>> bodywednesdayPMEnabled = null, Expression<Func<bool>> bodythursdayAMEnabled = null, Expression<Func<bool>> bodythursdayPMEnabled = null, Expression<Func<bool>> bodyfridayAMEnabled = null, Expression<Func<bool>> bodyfridayPMEnabled = null, Expression<Func<bool>> bodysaturdayAMEnabled = null, Expression<Func<bool>> bodysaturdayPMEnabled = null, Expression<Func<bool>> bodysundayAMEnabled = null, Expression<Func<bool>> bodysundayPMEnabled = null)
        {
            var apiCallPath = String.Format("/v1/members/{0}/schedule", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfromDate != null)
            {
                body["from"] = ExpressionConverter.ConvertO(bodyfromDate);
                bodypropCount++;
            }

            if (bodymondayAMEnabled != null)
            {
                body["monday_am_enabled"] = ExpressionConverter.ConvertO(bodymondayAMEnabled);
                bodypropCount++;
            }

            if (bodymondayPMEnabled != null)
            {
                body["monday_pm_enabled"] = ExpressionConverter.ConvertO(bodymondayPMEnabled);
                bodypropCount++;
            }

            if (bodytuesdayAMEnabled != null)
            {
                body["tuesday_am_enabled"] = ExpressionConverter.ConvertO(bodytuesdayAMEnabled);
                bodypropCount++;
            }

            if (bodytuesdayPMEnabled != null)
            {
                body["tuesday_pm_enabled"] = ExpressionConverter.ConvertO(bodytuesdayPMEnabled);
                bodypropCount++;
            }

            if (bodywednesdayAMEnabled != null)
            {
                body["wednesday_am_enabled"] = ExpressionConverter.ConvertO(bodywednesdayAMEnabled);
                bodypropCount++;
            }

            if (bodywednesdayPMEnabled != null)
            {
                body["wednesday_pm_enabled"] = ExpressionConverter.ConvertO(bodywednesdayPMEnabled);
                bodypropCount++;
            }

            if (bodythursdayAMEnabled != null)
            {
                body["thursday_am_enabled"] = ExpressionConverter.ConvertO(bodythursdayAMEnabled);
                bodypropCount++;
            }

            if (bodythursdayPMEnabled != null)
            {
                body["thursday_pm_enabled"] = ExpressionConverter.ConvertO(bodythursdayPMEnabled);
                bodypropCount++;
            }

            if (bodyfridayAMEnabled != null)
            {
                body["friday_am_enabled"] = ExpressionConverter.ConvertO(bodyfridayAMEnabled);
                bodypropCount++;
            }

            if (bodyfridayPMEnabled != null)
            {
                body["friday_pm_enabled"] = ExpressionConverter.ConvertO(bodyfridayPMEnabled);
                bodypropCount++;
            }

            if (bodysaturdayAMEnabled != null)
            {
                body["saturday_am_enabled"] = ExpressionConverter.ConvertO(bodysaturdayAMEnabled);
                bodypropCount++;
            }

            if (bodysaturdayPMEnabled != null)
            {
                body["saturday_pm_enabled"] = ExpressionConverter.ConvertO(bodysaturdayPMEnabled);
                bodypropCount++;
            }

            if (bodysundayAMEnabled != null)
            {
                body["sunday_am_enabled"] = ExpressionConverter.ConvertO(bodysundayAMEnabled);
                bodypropCount++;
            }

            if (bodysundayPMEnabled != null)
            {
                body["sunday_pm_enabled"] = ExpressionConverter.ConvertO(bodysundayPMEnabled);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<Department[]> GetDepartments()
        {
            var apiCallPath = "/v1/departments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Department[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> CreateDepartment(Expression<Func<string>> bodyname)
        {
            var apiCallPath = "/v1/departments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> DeleteDepartment(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> UpdateDepartment(Expression<Func<string>> id, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = String.Format("/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<LeaveType[]> GetLeaveTypes()
        {
            var apiCallPath = "/v1/leave_types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LeaveType[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> CreateLeaveType(Expression<Func<string>> bodyname, Expression<Func<bodyleaveUnitInput>> bodyleaveUnit = null, Expression<Func<string>> bodycolor = null, Expression<Func<string>> bodyicon = null)
        {
            var apiCallPath = "/v1/leave_types";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyleaveUnit != null)
            {
                body["leave_unit"] = ExpressionConverter.ConvertO(bodyleaveUnit);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodyicon != null)
            {
                body["icon"] = ExpressionConverter.ConvertO(bodyicon);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> DeleteLeaveType(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/leave_types/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> UpdateLeaveType(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<bodyleaveUnitInput>> bodyleaveUnit = null, Expression<Func<string>> bodycolor = null, Expression<Func<string>> bodyicon = null)
        {
            var apiCallPath = String.Format("/v1/leave_types/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyleaveUnit != null)
            {
                body["leave_unit"] = ExpressionConverter.ConvertO(bodyleaveUnit);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodyicon != null)
            {
                body["icon"] = ExpressionConverter.ConvertO(bodyicon);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<Request[]> GetRequests(Expression<Func<string>> memberId = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> startFrom = null, Expression<Func<string>> startTo = null, Expression<Func<string>> endFrom = null, Expression<Func<string>> endTo = null, Expression<Func<string>> leaveTypeId = null, Expression<Func<string>> departmentId = null)
        {
            var apiCallPath = "/v1/requests";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (memberId != null)
                callPayload.Queries["member_id"] = ExpressionConverter.Convert(memberId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (startFrom != null)
                callPayload.Queries["start_from"] = ExpressionConverter.Convert(startFrom);
            if (startTo != null)
                callPayload.Queries["start_to"] = ExpressionConverter.Convert(startTo);
            if (endFrom != null)
                callPayload.Queries["end_from"] = ExpressionConverter.Convert(endFrom);
            if (endTo != null)
                callPayload.Queries["end_to"] = ExpressionConverter.Convert(endTo);
            if (leaveTypeId != null)
                callPayload.Queries["leave_type_id"] = ExpressionConverter.Convert(leaveTypeId);
            if (departmentId != null)
                callPayload.Queries["department_id"] = ExpressionConverter.Convert(departmentId);
            return new ApiConnectionAction<Request[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> CreateRequest(Expression<Func<string>> bodymemberID, Expression<Func<string>> bodyleaveTypeID, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<bodystartTimeInput>> bodystartTime = null, Expression<Func<bodyendTimeInput>> bodyendTime = null, Expression<Func<string>> bodyreason = null)
        {
            var apiCallPath = "/v1/requests";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["member_id"] = ExpressionConverter.ConvertO(bodymemberID);
            bodypropCount++;
            body["leave_type_id"] = ExpressionConverter.ConvertO(bodyleaveTypeID);
            bodypropCount++;
            body["start"] = ExpressionConverter.ConvertO(bodystartDate);
            if (bodystartTime != null)
            {
                body["start_at"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            bodypropCount++;
            body["end"] = ExpressionConverter.ConvertO(bodyendDate);
            if (bodyendTime != null)
            {
                body["end_at"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<Request> GetRequestById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Request>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> DeleteRequest(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> UpdateRequest(Expression<Func<string>> id, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodyreason = null)
        {
            var apiCallPath = String.Format("/v1/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<PublicHolidayCalendar[]> GetPublicHolidays()
        {
            var apiCallPath = "/v1/public_holidays";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PublicHolidayCalendar[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> CreatePublicHoliday(Expression<Func<string>> bodyname, Expression<Func<string>> bodycountry = null)
        {
            var apiCallPath = "/v1/public_holidays";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<PublicHolidayCalendarDetail> GetPublicHolidayById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/public_holidays/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PublicHolidayCalendarDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> DeletePublicHoliday(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/public_holidays/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<string> UpdatePublicHoliday(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycountry = null)
        {
            var apiCallPath = String.Format("/v1/public_holidays/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<Workspace> GetWorkspace()
        {
            var apiCallPath = "/v1/workspace";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Workspace>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "absentify")]
        public IBodyWorkflowAction<Absence[]> GetAbsences(Expression<Func<string>> start, Expression<Func<string>> end, Expression<Func<string>> memberId = null, Expression<Func<string>> departmentId = null)
        {
            var apiCallPath = "/v1/absences";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            if (memberId != null)
                callPayload.Queries["member_id"] = ExpressionConverter.Convert(memberId);
            if (departmentId != null)
                callPayload.Queries["department_id"] = ExpressionConverter.Convert(departmentId);
            return new ApiConnectionAction<Absence[]>(callPayload);
        }
    }

    public class AbsentifyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerRequestCreatedV2(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/manage_ms_webhook/request_created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["payload_version"] = "v2";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerRequestStatusChangedV2(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/manage_ms_webhook/request_status_changed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["payload_version"] = "v2";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class Member
    {
        [JsonProperty("id")]
        public string MemberID { get; set; }

        [JsonProperty("custom_id")]
        public string CustomID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("status")]
        public MemberStatusType Status { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("employment_start_date")]
        public string EmploymentStartDate { get; set; }

        [JsonProperty("employment_end_date")]
        public string EmploymentEndDate { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("approval_process")]
        public MemberApprovalProcessType ApprovalProcess { get; set; }

        [JsonProperty("departments")]
        public MemberDepartment[] Departments { get; set; }

        [JsonProperty("allowances")]
        public MemberAllowance[] Allowances { get; set; }
    }

    public enum MemberStatusType
    {
        INACTIVE,
        ACTIVE,
        ARCHIVED
    }

    public enum MemberApprovalProcessType
    {
        [EnumMember(Value = "Linear_all_have_to_agree")]
        LinearAllHaveToAgree,
        [EnumMember(Value = "Linear_one_has_to_agree")]
        LinearOneHasToAgree,
        [EnumMember(Value = "Parallel_all_have_to_agree")]
        ParallelAllHaveToAgree,
        [EnumMember(Value = "Parallel_one_has_to_agree")]
        ParallelOneHasToAgree
    }

    public class MemberDepartment
    {
        [JsonProperty("id")]
        public string DepartmentID { get; set; }

        [JsonProperty("name")]
        public string DepartmentName { get; set; }

        [JsonProperty("manager_type")]
        public MemberDepartmentManagerTypeType ManagerType { get; set; }
    }

    public enum MemberDepartmentManagerTypeType
    {
        Member,
        Manager
    }

    public class MemberAllowance
    {
        [JsonProperty("id")]
        public string AllowanceID { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("allowance")]
        public double Allowance { get; set; }

        [JsonProperty("taken")]
        public double Taken { get; set; }

        [JsonProperty("remaining")]
        public double Remaining { get; set; }

        [JsonProperty("brought_forward")]
        public double BroughtForward { get; set; }

        [JsonProperty("compensatory_time_off")]
        public double CompensatoryTimeOff { get; set; }

        [JsonProperty("allowance_type")]
        public AllowanceTypeV2 AllowanceType { get; set; }
    }

    public class AllowanceTypeV2
    {
        [JsonProperty("id")]
        public string AllowanceTypeID { get; set; }

        [JsonProperty("name")]
        public string AllowanceTypeName { get; set; }

        [JsonProperty("ignore_allowance_limit")]
        public bool IgnoreLimit { get; set; }

        [JsonProperty("allowance_unit")]
        public AllowanceTypeV2AllowanceUnitType AllowanceUnit { get; set; }
    }

    public enum AllowanceTypeV2AllowanceUnitType
    {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours
    }

    public enum statusInput
    {
        PENDING,
        APPROVED,
        DECLINED,
        CANCELED
    }

    public enum approvalProcessInput
    {
        [EnumMember(Value = "Linear_all_have_to_agree")]
        LinearAllHaveToAgree,
        [EnumMember(Value = "Linear_one_has_to_agree")]
        LinearOneHasToAgree,
        [EnumMember(Value = "Parallel_all_have_to_agree")]
        ParallelAllHaveToAgree,
        [EnumMember(Value = "Parallel_one_has_to_agree")]
        ParallelOneHasToAgree
    }

    public enum managerTypeInput
    {
        Member,
        Manager
    }

    public class bodydepartmentIDsInputItem
    {
        [JsonProperty("id")]
        public string DepartmentID { get; set; }
    }

    public class MemberDetail
    {
        [JsonProperty("id")]
        public string MemberID { get; set; }

        [JsonProperty("custom_id")]
        public string CustomID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("status")]
        public MemberDetailStatusType Status { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("employment_start_date")]
        public string EmploymentStartDate { get; set; }

        [JsonProperty("employment_end_date")]
        public string EmploymentEndDate { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("approval_process")]
        public MemberDetailApprovalProcessType ApprovalProcess { get; set; }

        [JsonProperty("departments")]
        public MemberDepartment[] Departments { get; set; }

        [JsonProperty("allowances")]
        public MemberAllowance[] Allowances { get; set; }

        [JsonProperty("has_approvers")]
        public ApproverInfo[] HasApprovers { get; set; }

        [JsonProperty("schedules")]
        public Schedule[] Schedules { get; set; }
    }

    public enum MemberDetailStatusType
    {
        INACTIVE,
        ACTIVE,
        ARCHIVED
    }

    public enum MemberDetailApprovalProcessType
    {
        [EnumMember(Value = "Linear_all_have_to_agree")]
        LinearAllHaveToAgree,
        [EnumMember(Value = "Linear_one_has_to_agree")]
        LinearOneHasToAgree,
        [EnumMember(Value = "Parallel_all_have_to_agree")]
        ParallelAllHaveToAgree,
        [EnumMember(Value = "Parallel_one_has_to_agree")]
        ParallelOneHasToAgree
    }

    public class ApproverInfo
    {
        [JsonProperty("member")]
        public MemberReference Member { get; set; }
    }

    public class MemberReference
    {
        [JsonProperty("id")]
        public string MemberID { get; set; }

        [JsonProperty("custom_id")]
        public string CustomID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Schedule
    {
        [JsonProperty("id")]
        public string ScheduleID { get; set; }

        [JsonProperty("from")]
        public string FromDate { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public enum bodystatusInput
    {
        APPROVED,
        DECLINED,
        CANCELED
    }

    public enum bodyapprovalProcessInput
    {
        [EnumMember(Value = "Linear_all_have_to_agree")]
        LinearAllHaveToAgree,
        [EnumMember(Value = "Linear_one_has_to_agree")]
        LinearOneHasToAgree,
        [EnumMember(Value = "Parallel_all_have_to_agree")]
        ParallelAllHaveToAgree,
        [EnumMember(Value = "Parallel_one_has_to_agree")]
        ParallelOneHasToAgree
    }

    public class bodyapproversInputItem
    {
        [JsonProperty("member_id")]
        public string MemberID { get; set; }

        [JsonProperty("predecessor_manager_id")]
        public string PredecessorManagerID { get; set; }
    }

    public class Department
    {
        [JsonProperty("id")]
        public string DepartmentID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class LeaveType
    {
        [JsonProperty("id")]
        public string LeaveTypeID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("leave_unit")]
        public LeaveTypeLeaveUnitType LeaveUnit { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public enum LeaveTypeLeaveUnitType
    {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours
    }

    public enum bodyleaveUnitInput
    {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours
    }

    public class Request
    {
        [JsonProperty("id")]
        public string RequestID { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("start_at")]
        public RequestStartTimeType StartTime { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }

        [JsonProperty("end_at")]
        public RequestEndTimeType EndTime { get; set; }

        [JsonProperty("status")]
        public RequestStatusType Status { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("workday_absence_duration")]
        public double WorkdayDuration { get; set; }

        [JsonProperty("leave_unit")]
        public RequestLeaveUnitType LeaveUnit { get; set; }

        [JsonProperty("requester_member")]
        public MemberReference RequesterMember { get; set; }

        [JsonProperty("leave_type")]
        public LeaveTypeV2 LeaveType { get; set; }

        [JsonProperty("request_approvers")]
        public RequestApproverV2[] RequestApprovers { get; set; }
    }

    public enum RequestStartTimeType
    {
        [EnumMember(Value = "morning")]
        Morning,
        [EnumMember(Value = "afternoon")]
        Afternoon
    }

    public enum RequestEndTimeType
    {
        [EnumMember(Value = "lunchtime")]
        Lunchtime,
        [EnumMember(Value = "end_of_day")]
        EndOfDay
    }

    public enum RequestStatusType
    {
        PENDING,
        APPROVED,
        DECLINED,
        CANCELED
    }

    public enum RequestLeaveUnitType
    {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours
    }

    public class LeaveTypeV2
    {
        [JsonProperty("id")]
        public string LeaveTypeID { get; set; }

        [JsonProperty("name")]
        public string LeaveTypeName { get; set; }

        [JsonProperty("leave_unit")]
        public LeaveTypeV2LeaveUnitType LeaveUnit { get; set; }
    }

    public enum LeaveTypeV2LeaveUnitType
    {
        [EnumMember(Value = "days")]
        Days,
        [EnumMember(Value = "hours")]
        Hours
    }

    public class RequestApproverV2
    {
        [JsonProperty("status")]
        public RequestApproverV2ApproverStatusType ApproverStatus { get; set; }

        [JsonProperty("reason")]
        public string ApproverReason { get; set; }

        [JsonProperty("status_changed_date")]
        public string StatusChangedDate { get; set; }

        [JsonProperty("status_changed_by_member")]
        public MemberReference StatusChangedByMember { get; set; }

        [JsonProperty("approver_member")]
        public MemberReference ApproverMember { get; set; }
    }

    public enum RequestApproverV2ApproverStatusType
    {
        PENDING,
        APPROVED,
        DECLINED
    }

    public enum bodystartTimeInput
    {
        [EnumMember(Value = "morning")]
        Morning,
        [EnumMember(Value = "afternoon")]
        Afternoon
    }

    public enum bodyendTimeInput
    {
        [EnumMember(Value = "lunchtime")]
        Lunchtime,
        [EnumMember(Value = "end_of_day")]
        EndOfDay
    }

    public class PublicHolidayCalendar
    {
        [JsonProperty("id")]
        public string CalendarID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class PublicHolidayCalendarDetail
    {
        [JsonProperty("id")]
        public string CalendarID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("holidays")]
        public PublicHoliday[] Holidays { get; set; }
    }

    public class PublicHoliday
    {
        [JsonProperty("id")]
        public string HolidayID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }
    }

    public class Workspace
    {
        [JsonProperty("id")]
        public string WorkspaceID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class Absence
    {
        [JsonProperty("id")]
        public string AbsenceID { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("member")]
        public MemberReference Member { get; set; }

        [JsonProperty("leave_type")]
        public LeaveTypeV2 LeaveType { get; set; }

        [JsonProperty("request_id")]
        public string RequestID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Absentify;

    public partial class WorkflowManagedActions
    {
        public AbsentifyActions Absentify(string connectionId) => new AbsentifyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbsentifyTriggers Absentify(string connectionId) => new AbsentifyTriggers(connectionId);
    }
}