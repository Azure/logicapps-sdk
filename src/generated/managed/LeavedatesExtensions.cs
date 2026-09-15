//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leavedates
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeavedatesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetAllCompaniesAuthenticatedUserResponseItem[]> GetAllCompaniesAuthenticatedUser()
        {
            var apiCallPath = "/companies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllCompaniesAuthenticatedUserResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetDepartmentsResponseItem[]> GetDepartments(Expression<Func<string>> company)
        {
            var apiCallPath = "/departments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            return new ApiConnectionAction<GetDepartmentsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetLeaveTypesResponseItem[]> GetLeaveTypes(Expression<Func<string>> company)
        {
            var apiCallPath = "/leave-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            return new ApiConnectionAction<GetLeaveTypesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetAllowanceSummaryResponse> GetAllowanceSummary(Expression<Func<string>> company, Expression<Func<string>> date, Expression<Func<int>> page, Expression<Func<string>> employee = null, Expression<Func<string>> department = null, Expression<Func<string>> allowanceType = null)
        {
            var apiCallPath = "/reports/summary-allowances";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            callPayload.Queries["date"] = CSharpExpressionConverter.ConvertO(date);
            callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (employee != null)
                callPayload.Queries["employee"] = CSharpExpressionConverter.ConvertO(employee);
            if (department != null)
                callPayload.Queries["department"] = CSharpExpressionConverter.ConvertO(department);
            if (allowanceType != null)
                callPayload.Queries["allowance_type"] = CSharpExpressionConverter.ConvertO(allowanceType);
            return new ApiConnectionAction<GetAllowanceSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetEmployeesResponseItem[]> GetEmployees(Expression<Func<string>> company, Expression<Func<string>> departmentId = null)
        {
            var apiCallPath = "/employments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            if (departmentId != null)
                callPayload.Queries["department_id"] = CSharpExpressionConverter.ConvertO(departmentId);
            return new ApiConnectionAction<GetEmployeesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<AddEmploymentResponse> AddEmployment(Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyapproverId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodyemployeeCode = null, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyholidayLocation = null, Expression<Func<string>> bodyallowanceUnitIsDays = null, Expression<Func<string>> bodyminutesPerWorkingDay = null)
        {
            var apiCallPath = "/employments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyjobTitle != null)
            {
                body["job_title"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            bodypropCount++;
            body["full_name"] = CSharpExpressionConverter.ConvertToken(bodyfullName);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodytimezone != null)
            {
                body["timezone"] = CSharpExpressionConverter.ConvertToken(bodytimezone);
                bodypropCount++;
            }

            bodypropCount++;
            body["company_id"] = CSharpExpressionConverter.ConvertToken(bodycompanyId);
            if (bodyapproverId != null)
            {
                body["approver_id"] = CSharpExpressionConverter.ConvertToken(bodyapproverId);
                bodypropCount++;
            }

            if (bodydepartmentId != null)
            {
                body["department_id"] = CSharpExpressionConverter.ConvertToken(bodydepartmentId);
                bodypropCount++;
            }

            if (bodyemployeeCode != null)
            {
                body["employee_code"] = CSharpExpressionConverter.ConvertToken(bodyemployeeCode);
                bodypropCount++;
            }

            if (bodyisAdmin != null)
            {
                if (bodyisAdmin != null)
                {
                    body["is_admin"] = CSharpExpressionConverter.ConvertToken(bodyisAdmin);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["is_admin"] = false;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyholidayLocation != null)
            {
                body["holiday_location"] = CSharpExpressionConverter.ConvertToken(bodyholidayLocation);
                bodypropCount++;
            }

            if (bodyallowanceUnitIsDays != null)
            {
                body["allowance_unit_is_days"] = CSharpExpressionConverter.ConvertToken(bodyallowanceUnitIsDays);
                bodypropCount++;
            }

            if (bodyminutesPerWorkingDay != null)
            {
                body["minutes_per_working_day"] = CSharpExpressionConverter.ConvertToken(bodyminutesPerWorkingDay);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddEmploymentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetDetailsEmployeeResponse> GetDetailsEmployee(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/employments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            return new ApiConnectionAction<GetDetailsEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<JToken> DeleteEmployment(Expression<Func<string>> id, Expression<Func<string>> bodycompanyId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/employments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["company_id"] = CSharpExpressionConverter.ConvertToken(bodycompanyId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<UpdateEmploymentResponse> UpdateEmployment(Expression<Func<string>> id, Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyapproverId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodyemployeeCode = null, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyholidayLocation = null, Expression<Func<string>> bodyallowanceUnitIsDays = null, Expression<Func<string>> bodyminutesPerWorkingDay = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/employments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyjobTitle != null)
            {
                body["job_title"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            bodypropCount++;
            body["full_name"] = CSharpExpressionConverter.ConvertToken(bodyfullName);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodytimezone != null)
            {
                body["timezone"] = CSharpExpressionConverter.ConvertToken(bodytimezone);
                bodypropCount++;
            }

            bodypropCount++;
            body["company_id"] = CSharpExpressionConverter.ConvertToken(bodycompanyId);
            if (bodyapproverId != null)
            {
                body["approver_id"] = CSharpExpressionConverter.ConvertToken(bodyapproverId);
                bodypropCount++;
            }

            if (bodydepartmentId != null)
            {
                body["department_id"] = CSharpExpressionConverter.ConvertToken(bodydepartmentId);
                bodypropCount++;
            }

            if (bodyemployeeCode != null)
            {
                body["employee_code"] = CSharpExpressionConverter.ConvertToken(bodyemployeeCode);
                bodypropCount++;
            }

            if (bodyisAdmin != null)
            {
                if (bodyisAdmin != null)
                {
                    body["is_admin"] = CSharpExpressionConverter.ConvertToken(bodyisAdmin);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["is_admin"] = false;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyholidayLocation != null)
            {
                body["holiday_location"] = CSharpExpressionConverter.ConvertToken(bodyholidayLocation);
                bodypropCount++;
            }

            if (bodyallowanceUnitIsDays != null)
            {
                body["allowance_unit_is_days"] = CSharpExpressionConverter.ConvertToken(bodyallowanceUnitIsDays);
                bodypropCount++;
            }

            if (bodyminutesPerWorkingDay != null)
            {
                body["minutes_per_working_day"] = CSharpExpressionConverter.ConvertToken(bodyminutesPerWorkingDay);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEmploymentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetLeaveDetailsResponse> GetLeaveDetails(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/leaves/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            return new ApiConnectionAction<GetLeaveDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<string[]> UpdateLeave(Expression<Func<string>> id, Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodytypeId, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodyreason = null, Expression<Func<bodyleaveBreakdownsInputItem[]>> bodyleaveBreakdowns = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/leaves/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["company_id"] = CSharpExpressionConverter.ConvertToken(bodycompanyId);
            if (bodyfrom != null)
            {
                body["from"] = CSharpExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
            }

            if (bodyto != null)
            {
                body["to"] = CSharpExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
            }

            bodypropCount++;
            body["type_id"] = CSharpExpressionConverter.ConvertToken(bodytypeId);
            if (bodyreason != null)
            {
                body["reason"] = CSharpExpressionConverter.ConvertToken(bodyreason);
                bodypropCount++;
            }

            if (bodyleaveBreakdowns != null)
            {
                body["leave_breakdowns"] = CSharpExpressionConverter.ConvertToken(bodyleaveBreakdowns);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<string[]> RequestLeave(Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodytypeId, Expression<Func<string>> bodyreason = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<bodyleaveBreakdownsInputItem2[]>> bodyleaveBreakdowns = null)
        {
            var apiCallPath = "/leaves";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["company_id"] = CSharpExpressionConverter.ConvertToken(bodycompanyId);
            bodypropCount++;
            body["from"] = CSharpExpressionConverter.ConvertToken(bodyfrom);
            bodypropCount++;
            body["to"] = CSharpExpressionConverter.ConvertToken(bodyto);
            bodypropCount++;
            body["type_id"] = CSharpExpressionConverter.ConvertToken(bodytypeId);
            if (bodyreason != null)
            {
                body["reason"] = CSharpExpressionConverter.ConvertToken(bodyreason);
                bodypropCount++;
            }

            if (bodyisPrivate != null)
            {
                if (bodyisPrivate != null)
                {
                    body["is_private"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["is_private"] = false;
                bodypropCount++;
            }

            if (bodyleaveBreakdowns != null)
            {
                body["leave_breakdowns"] = CSharpExpressionConverter.ConvertToken(bodyleaveBreakdowns);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IWorkflowAction ApproveLeave(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/leaves/{0}/approve", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IWorkflowAction CancelLeave(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/leaves/{0}/cancel", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class LeavedatesTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllCompaniesAuthenticatedUserResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("employments_count")]
        public int EmploymentsCount { get; set; }
    }

    public class GetDepartmentsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("employments_count")]
        public int EmploymentsCount { get; set; }
    }

    public class GetLeaveTypesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetAllowanceSummaryResponse
    {
        [JsonProperty("data")]
        public GetAllowanceSummaryResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class GetAllowanceSummaryResponseDataTypeItem
    {
        [JsonProperty("allowance_type")]
        public GetAllowanceSummaryResponseDataTypeItemAllowanceTypeType AllowanceType { get; set; }

        [JsonProperty("calendar")]
        public GetAllowanceSummaryResponseDataTypeItemCalendarType Calendar { get; set; }

        [JsonProperty("allowance_unit")]
        public string AllowanceUnit { get; set; }

        [JsonProperty("is_unlimited")]
        public int IsUnlimited { get; set; }

        [JsonProperty("total_allowance")]
        public int TotalAllowance { get; set; }

        [JsonProperty("annual_allowance")]
        public int AnnualAllowance { get; set; }

        [JsonProperty("booked_allowance")]
        public double BookedAllowance { get; set; }

        [JsonProperty("remaining_to_book")]
        public double RemainingToBook { get; set; }
    }

    public class GetAllowanceSummaryResponseDataTypeItemAllowanceTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetAllowanceSummaryResponseDataTypeItemCalendarType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class GetEmployeesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AddEmploymentResponse
    {
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("employee_code")]
        public string EmployeeCode { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetDetailsEmployeeResponse
    {
        [JsonProperty("user")]
        public GetDetailsEmployeeResponseUserType User { get; set; }
    }

    public class GetDetailsEmployeeResponseUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("verification_pending_email")]
        public string VerificationPendingEmail { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
    }

    public class UpdateEmploymentResponse
    {
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("employee_code")]
        public string EmployeeCode { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetLeaveDetailsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("owner")]
        public GetLeaveDetailsResponseOwnerType Owner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("leave_breakdowns")]
        public GetLeaveDetailsResponseLeaveBreakdownsTypeItem[] LeaveBreakdowns { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("type")]
        public GetLeaveDetailsResponseTypeType Type { get; set; }
    }

    public class GetLeaveDetailsResponseOwnerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public class GetLeaveDetailsResponseLeaveBreakdownsTypeItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetLeaveDetailsResponseTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyleaveBreakdownsInputItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class bodyleaveBreakdownsInputItem2
    {
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("breakdowns")]
        public bodyleaveBreakdownsInputItemBreakdownsTypeItem[] Breakdowns { get; set; }
    }

    public class bodyleaveBreakdownsInputItemBreakdownsTypeItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Leavedates;

    public partial class WorkflowManagedActions
    {
        public LeavedatesActions Leavedates(string connectionId) => new LeavedatesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LeavedatesTriggers Leavedates(string connectionId) => new LeavedatesTriggers(connectionId);
    }
}