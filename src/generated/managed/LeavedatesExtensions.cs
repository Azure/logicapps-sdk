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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllCompaniesAuthenticatedUserResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetDepartmentsResponseItem[]> GetDepartments([WorkflowExpression] Func<string> company)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/departments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                return callPayload;
            }

            return new ApiConnectionAction<GetDepartmentsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetLeaveTypesResponseItem[]> GetLeaveTypes([WorkflowExpression] Func<string> company)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/leave-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                return callPayload;
            }

            return new ApiConnectionAction<GetLeaveTypesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetAllowanceSummaryResponse> GetAllowanceSummary([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<int> page, [WorkflowExpression] Func<string> employee = null, [WorkflowExpression] Func<string> department = null, [WorkflowExpression] Func<string> allowanceType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports/summary-allowances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (employee != null)
                    callPayload.Queries["employee"] = SourceExpressionConverter.ConvertO(employee);
                if (department != null)
                    callPayload.Queries["department"] = SourceExpressionConverter.ConvertO(department);
                if (allowanceType != null)
                    callPayload.Queries["allowance_type"] = SourceExpressionConverter.ConvertO(allowanceType);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllowanceSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetEmployeesResponseItem[]> GetEmployees([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> departmentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/employments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                if (departmentId != null)
                    callPayload.Queries["department_id"] = SourceExpressionConverter.ConvertO(departmentId);
                return callPayload;
            }

            return new ApiConnectionAction<GetEmployeesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<AddEmploymentResponse> AddEmployment([WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyapproverId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodyemployeeCode = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyholidayLocation = null, [WorkflowExpression] Func<string> bodyallowanceUnitIsDays = null, [WorkflowExpression] Func<string> bodyminutesPerWorkingDay = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/employments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["job_title"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["full_name"] = SourceExpressionConverter.ConvertToken(bodyfullName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                if (bodyapproverId != null)
                {
                    body["approver_id"] = SourceExpressionConverter.ConvertToken(bodyapproverId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyemployeeCode != null)
                {
                    body["employee_code"] = SourceExpressionConverter.ConvertToken(bodyemployeeCode);
                    bodypropCount++;
                }

                if (bodyisAdmin != null)
                {
                    if (bodyisAdmin != null)
                    {
                        body["is_admin"] = SourceExpressionConverter.ConvertToken(bodyisAdmin);
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
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyholidayLocation != null)
                {
                    body["holiday_location"] = SourceExpressionConverter.ConvertToken(bodyholidayLocation);
                    bodypropCount++;
                }

                if (bodyallowanceUnitIsDays != null)
                {
                    body["allowance_unit_is_days"] = SourceExpressionConverter.ConvertToken(bodyallowanceUnitIsDays);
                    bodypropCount++;
                }

                if (bodyminutesPerWorkingDay != null)
                {
                    body["minutes_per_working_day"] = SourceExpressionConverter.ConvertToken(bodyminutesPerWorkingDay);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddEmploymentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetDetailsEmployeeResponse> GetDetailsEmployee([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/employments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                return callPayload;
            }

            return new ApiConnectionAction<GetDetailsEmployeeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<JToken> DeleteEmployment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycompanyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/employments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<UpdateEmploymentResponse> UpdateEmployment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyapproverId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodyemployeeCode = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyholidayLocation = null, [WorkflowExpression] Func<string> bodyallowanceUnitIsDays = null, [WorkflowExpression] Func<string> bodyminutesPerWorkingDay = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/employments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["job_title"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["full_name"] = SourceExpressionConverter.ConvertToken(bodyfullName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                if (bodyapproverId != null)
                {
                    body["approver_id"] = SourceExpressionConverter.ConvertToken(bodyapproverId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyemployeeCode != null)
                {
                    body["employee_code"] = SourceExpressionConverter.ConvertToken(bodyemployeeCode);
                    bodypropCount++;
                }

                if (bodyisAdmin != null)
                {
                    if (bodyisAdmin != null)
                    {
                        body["is_admin"] = SourceExpressionConverter.ConvertToken(bodyisAdmin);
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
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyholidayLocation != null)
                {
                    body["holiday_location"] = SourceExpressionConverter.ConvertToken(bodyholidayLocation);
                    bodypropCount++;
                }

                if (bodyallowanceUnitIsDays != null)
                {
                    body["allowance_unit_is_days"] = SourceExpressionConverter.ConvertToken(bodyallowanceUnitIsDays);
                    bodypropCount++;
                }

                if (bodyminutesPerWorkingDay != null)
                {
                    body["minutes_per_working_day"] = SourceExpressionConverter.ConvertToken(bodyminutesPerWorkingDay);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEmploymentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetLeaveDetailsResponse> GetLeaveDetails([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/leaves/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                return callPayload;
            }

            return new ApiConnectionAction<GetLeaveDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<string[]> UpdateLeave([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodytypeId, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<bodyleaveBreakdownsInputItem[]> bodyleaveBreakdowns = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/leaves/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                bodypropCount++;
                body["type_id"] = SourceExpressionConverter.ConvertToken(bodytypeId);
                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodyleaveBreakdowns != null)
                {
                    body["leave_breakdowns"] = SourceExpressionConverter.ConvertToken(bodyleaveBreakdowns);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<string[]> RequestLeave([WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodytypeId, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<bodyleaveBreakdownsInputItem2[]> bodyleaveBreakdowns = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/leaves";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["type_id"] = SourceExpressionConverter.ConvertToken(bodytypeId);
                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    if (bodyisPrivate != null)
                    {
                        body["is_private"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
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
                    body["leave_breakdowns"] = SourceExpressionConverter.ConvertToken(bodyleaveBreakdowns);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IWorkflowAction ApproveLeave([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/leaves/{0}/approve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IWorkflowAction CancelLeave([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/leaves/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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