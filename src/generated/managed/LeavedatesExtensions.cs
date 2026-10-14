//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leavedates
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            return new DeferredBodyAction<GetDepartmentsResponseItem[]>(() =>
            {
                var apiCallPath = "/departments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                return new ApiConnectionAction<GetDepartmentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetLeaveTypesResponseItem[]> GetLeaveTypes(Expression<Func<string>> company)
        {
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            return new DeferredBodyAction<GetLeaveTypesResponseItem[]>(() =>
            {
                var apiCallPath = "/leave-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                return new ApiConnectionAction<GetLeaveTypesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetAllowanceSummaryResponse> GetAllowanceSummary(Expression<Func<string>> company, Expression<Func<string>> date, Expression<Func<int>> page, Expression<Func<string>> employee = null, Expression<Func<string>> department = null, Expression<Func<string>> allowanceType = null)
        {
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: true);
            var __workflow_employee = employee == null ? null : WorkflowExpression.Compile(employee);
            WorkflowExpression.Validate(__workflow_employee, nameof(employee), required: false);
            var __workflow_department = department == null ? null : WorkflowExpression.Compile(department);
            WorkflowExpression.Validate(__workflow_department, nameof(department), required: false);
            var __workflow_allowanceType = allowanceType == null ? null : WorkflowExpression.Compile(allowanceType);
            WorkflowExpression.Validate(__workflow_allowanceType, nameof(allowanceType), required: false);
            return new DeferredBodyAction<GetAllowanceSummaryResponse>(() =>
            {
                var apiCallPath = "/reports/summary-allowances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_employee != null)
                    callPayload.Queries["employee"] = ExpressionConverter.Convert(__workflow_employee);
                if (__workflow_department != null)
                    callPayload.Queries["department"] = ExpressionConverter.Convert(__workflow_department);
                if (__workflow_allowanceType != null)
                    callPayload.Queries["allowance_type"] = ExpressionConverter.Convert(__workflow_allowanceType);
                return new ApiConnectionAction<GetAllowanceSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetEmployeesResponseItem[]> GetEmployees(Expression<Func<string>> company, Expression<Func<string>> departmentId = null)
        {
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            var __workflow_departmentId = departmentId == null ? null : WorkflowExpression.Compile(departmentId);
            WorkflowExpression.Validate(__workflow_departmentId, nameof(departmentId), required: false);
            return new DeferredBodyAction<GetEmployeesResponseItem[]>(() =>
            {
                var apiCallPath = "/employments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_departmentId != null)
                    callPayload.Queries["department_id"] = ExpressionConverter.Convert(__workflow_departmentId);
                return new ApiConnectionAction<GetEmployeesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<AddEmploymentResponse> AddEmployment(Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyapproverId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodyemployeeCode = null, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyholidayLocation = null, Expression<Func<string>> bodyallowanceUnitIsDays = null, Expression<Func<string>> bodyminutesPerWorkingDay = null)
        {
            var __workflow_bodyfullName = bodyfullName == null ? null : WorkflowExpression.Compile(bodyfullName);
            WorkflowExpression.Validate(__workflow_bodyfullName, nameof(bodyfullName), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodycompanyId = bodycompanyId == null ? null : WorkflowExpression.Compile(bodycompanyId);
            WorkflowExpression.Validate(__workflow_bodycompanyId, nameof(bodycompanyId), required: true);
            var __workflow_bodyjobTitle = bodyjobTitle == null ? null : WorkflowExpression.Compile(bodyjobTitle);
            WorkflowExpression.Validate(__workflow_bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodytimezone = bodytimezone == null ? null : WorkflowExpression.Compile(bodytimezone);
            WorkflowExpression.Validate(__workflow_bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyapproverId = bodyapproverId == null ? null : WorkflowExpression.Compile(bodyapproverId);
            WorkflowExpression.Validate(__workflow_bodyapproverId, nameof(bodyapproverId), required: false);
            var __workflow_bodydepartmentId = bodydepartmentId == null ? null : WorkflowExpression.Compile(bodydepartmentId);
            WorkflowExpression.Validate(__workflow_bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyemployeeCode = bodyemployeeCode == null ? null : WorkflowExpression.Compile(bodyemployeeCode);
            WorkflowExpression.Validate(__workflow_bodyemployeeCode, nameof(bodyemployeeCode), required: false);
            var __workflow_bodyisAdmin = bodyisAdmin == null ? null : WorkflowExpression.Compile(bodyisAdmin);
            WorkflowExpression.Validate(__workflow_bodyisAdmin, nameof(bodyisAdmin), required: false);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = bodyendDate == null ? null : WorkflowExpression.Compile(bodyendDate);
            WorkflowExpression.Validate(__workflow_bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyholidayLocation = bodyholidayLocation == null ? null : WorkflowExpression.Compile(bodyholidayLocation);
            WorkflowExpression.Validate(__workflow_bodyholidayLocation, nameof(bodyholidayLocation), required: false);
            var __workflow_bodyallowanceUnitIsDays = bodyallowanceUnitIsDays == null ? null : WorkflowExpression.Compile(bodyallowanceUnitIsDays);
            WorkflowExpression.Validate(__workflow_bodyallowanceUnitIsDays, nameof(bodyallowanceUnitIsDays), required: false);
            var __workflow_bodyminutesPerWorkingDay = bodyminutesPerWorkingDay == null ? null : WorkflowExpression.Compile(bodyminutesPerWorkingDay);
            WorkflowExpression.Validate(__workflow_bodyminutesPerWorkingDay, nameof(bodyminutesPerWorkingDay), required: false);
            return new DeferredBodyAction<AddEmploymentResponse>(() =>
            {
                var apiCallPath = "/employments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyjobTitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["full_name"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                if (__workflow_bodyapproverId != null)
                {
                    body["approver_id"] = ExpressionConverter.ConvertO(__workflow_bodyapproverId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyemployeeCode != null)
                {
                    body["employee_code"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeCode);
                    bodypropCount++;
                }

                if (__workflow_bodyisAdmin != null)
                {
                    if (__workflow_bodyisAdmin != null)
                    {
                        body["is_admin"] = ExpressionConverter.ConvertO(__workflow_bodyisAdmin);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_admin"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyholidayLocation != null)
                {
                    body["holiday_location"] = ExpressionConverter.ConvertO(__workflow_bodyholidayLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyallowanceUnitIsDays != null)
                {
                    body["allowance_unit_is_days"] = ExpressionConverter.ConvertO(__workflow_bodyallowanceUnitIsDays);
                    bodypropCount++;
                }

                if (__workflow_bodyminutesPerWorkingDay != null)
                {
                    body["minutes_per_working_day"] = ExpressionConverter.ConvertO(__workflow_bodyminutesPerWorkingDay);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddEmploymentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetDetailsEmployeeResponse> GetDetailsEmployee(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            return new DeferredBodyAction<GetDetailsEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/employments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                return new ApiConnectionAction<GetDetailsEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<JToken> DeleteEmployment(Expression<Func<string>> id, Expression<Func<string>> bodycompanyId)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodycompanyId = bodycompanyId == null ? null : WorkflowExpression.Compile(bodycompanyId);
            WorkflowExpression.Validate(__workflow_bodycompanyId, nameof(bodycompanyId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/employments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<UpdateEmploymentResponse> UpdateEmployment(Expression<Func<string>> id, Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodyapproverId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodyemployeeCode = null, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyholidayLocation = null, Expression<Func<string>> bodyallowanceUnitIsDays = null, Expression<Func<string>> bodyminutesPerWorkingDay = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyfullName = bodyfullName == null ? null : WorkflowExpression.Compile(bodyfullName);
            WorkflowExpression.Validate(__workflow_bodyfullName, nameof(bodyfullName), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodycompanyId = bodycompanyId == null ? null : WorkflowExpression.Compile(bodycompanyId);
            WorkflowExpression.Validate(__workflow_bodycompanyId, nameof(bodycompanyId), required: true);
            var __workflow_bodyjobTitle = bodyjobTitle == null ? null : WorkflowExpression.Compile(bodyjobTitle);
            WorkflowExpression.Validate(__workflow_bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodytimezone = bodytimezone == null ? null : WorkflowExpression.Compile(bodytimezone);
            WorkflowExpression.Validate(__workflow_bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyapproverId = bodyapproverId == null ? null : WorkflowExpression.Compile(bodyapproverId);
            WorkflowExpression.Validate(__workflow_bodyapproverId, nameof(bodyapproverId), required: false);
            var __workflow_bodydepartmentId = bodydepartmentId == null ? null : WorkflowExpression.Compile(bodydepartmentId);
            WorkflowExpression.Validate(__workflow_bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyemployeeCode = bodyemployeeCode == null ? null : WorkflowExpression.Compile(bodyemployeeCode);
            WorkflowExpression.Validate(__workflow_bodyemployeeCode, nameof(bodyemployeeCode), required: false);
            var __workflow_bodyisAdmin = bodyisAdmin == null ? null : WorkflowExpression.Compile(bodyisAdmin);
            WorkflowExpression.Validate(__workflow_bodyisAdmin, nameof(bodyisAdmin), required: false);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = bodyendDate == null ? null : WorkflowExpression.Compile(bodyendDate);
            WorkflowExpression.Validate(__workflow_bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyholidayLocation = bodyholidayLocation == null ? null : WorkflowExpression.Compile(bodyholidayLocation);
            WorkflowExpression.Validate(__workflow_bodyholidayLocation, nameof(bodyholidayLocation), required: false);
            var __workflow_bodyallowanceUnitIsDays = bodyallowanceUnitIsDays == null ? null : WorkflowExpression.Compile(bodyallowanceUnitIsDays);
            WorkflowExpression.Validate(__workflow_bodyallowanceUnitIsDays, nameof(bodyallowanceUnitIsDays), required: false);
            var __workflow_bodyminutesPerWorkingDay = bodyminutesPerWorkingDay == null ? null : WorkflowExpression.Compile(bodyminutesPerWorkingDay);
            WorkflowExpression.Validate(__workflow_bodyminutesPerWorkingDay, nameof(bodyminutesPerWorkingDay), required: false);
            return new DeferredBodyAction<UpdateEmploymentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/employments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyjobTitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["full_name"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                if (__workflow_bodyapproverId != null)
                {
                    body["approver_id"] = ExpressionConverter.ConvertO(__workflow_bodyapproverId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyemployeeCode != null)
                {
                    body["employee_code"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeCode);
                    bodypropCount++;
                }

                if (__workflow_bodyisAdmin != null)
                {
                    if (__workflow_bodyisAdmin != null)
                    {
                        body["is_admin"] = ExpressionConverter.ConvertO(__workflow_bodyisAdmin);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_admin"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyholidayLocation != null)
                {
                    body["holiday_location"] = ExpressionConverter.ConvertO(__workflow_bodyholidayLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyallowanceUnitIsDays != null)
                {
                    body["allowance_unit_is_days"] = ExpressionConverter.ConvertO(__workflow_bodyallowanceUnitIsDays);
                    bodypropCount++;
                }

                if (__workflow_bodyminutesPerWorkingDay != null)
                {
                    body["minutes_per_working_day"] = ExpressionConverter.ConvertO(__workflow_bodyminutesPerWorkingDay);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEmploymentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<GetLeaveDetailsResponse> GetLeaveDetails(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            return new DeferredBodyAction<GetLeaveDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                return new ApiConnectionAction<GetLeaveDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<string[]> UpdateLeave(Expression<Func<string>> id, Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodytypeId, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodyreason = null, Expression<Func<bodyleaveBreakdownsInputItem[]>> bodyleaveBreakdowns = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodycompanyId = bodycompanyId == null ? null : WorkflowExpression.Compile(bodycompanyId);
            WorkflowExpression.Validate(__workflow_bodycompanyId, nameof(bodycompanyId), required: true);
            var __workflow_bodytypeId = bodytypeId == null ? null : WorkflowExpression.Compile(bodytypeId);
            WorkflowExpression.Validate(__workflow_bodytypeId, nameof(bodytypeId), required: true);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodyreason = bodyreason == null ? null : WorkflowExpression.Compile(bodyreason);
            WorkflowExpression.Validate(__workflow_bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodyleaveBreakdowns = bodyleaveBreakdowns == null ? null : WorkflowExpression.Compile(bodyleaveBreakdowns);
            WorkflowExpression.Validate(__workflow_bodyleaveBreakdowns, nameof(bodyleaveBreakdowns), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                bodypropCount++;
                body["type_id"] = ExpressionConverter.ConvertO(__workflow_bodytypeId);
                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodyleaveBreakdowns != null)
                {
                    body["leave_breakdowns"] = ExpressionConverter.ConvertO(__workflow_bodyleaveBreakdowns);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IBodyWorkflowAction<string[]> RequestLeave(Expression<Func<string>> bodycompanyId, Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodytypeId, Expression<Func<string>> bodyreason = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<bodyleaveBreakdownsInputItem2[]>> bodyleaveBreakdowns = null)
        {
            var __workflow_bodycompanyId = bodycompanyId == null ? null : WorkflowExpression.Compile(bodycompanyId);
            WorkflowExpression.Validate(__workflow_bodycompanyId, nameof(bodycompanyId), required: true);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodytypeId = bodytypeId == null ? null : WorkflowExpression.Compile(bodytypeId);
            WorkflowExpression.Validate(__workflow_bodytypeId, nameof(bodytypeId), required: true);
            var __workflow_bodyreason = bodyreason == null ? null : WorkflowExpression.Compile(bodyreason);
            WorkflowExpression.Validate(__workflow_bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodyisPrivate = bodyisPrivate == null ? null : WorkflowExpression.Compile(bodyisPrivate);
            WorkflowExpression.Validate(__workflow_bodyisPrivate, nameof(bodyisPrivate), required: false);
            var __workflow_bodyleaveBreakdowns = bodyleaveBreakdowns == null ? null : WorkflowExpression.Compile(bodyleaveBreakdowns);
            WorkflowExpression.Validate(__workflow_bodyleaveBreakdowns, nameof(bodyleaveBreakdowns), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = "/leaves";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                bodypropCount++;
                body["type_id"] = ExpressionConverter.ConvertO(__workflow_bodytypeId);
                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    if (__workflow_bodyisPrivate != null)
                    {
                        body["is_private"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_private"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyleaveBreakdowns != null)
                {
                    body["leave_breakdowns"] = ExpressionConverter.ConvertO(__workflow_bodyleaveBreakdowns);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IWorkflowAction ApproveLeave(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}/approve", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        public IWorkflowAction CancelLeave(Expression<Func<string>> id, Expression<Func<string>> company)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}/cancel", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                return new ApiConnectionAction(callPayload);
            });
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
