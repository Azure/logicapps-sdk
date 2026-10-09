//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leavedates
{
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
        [WorkflowExpressionFactory(nameof(__BuildGetDepartments))]
        public IBodyWorkflowAction<GetDepartmentsResponseItem[]> GetDepartments([WorkflowExpression] Func<string> company)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDepartmentsResponseItem[]> __BuildGetDepartments(WorkflowExpression<string> company)
        {
            WorkflowExpression.Validate(company, nameof(company), required: true);
            return new DeferredBodyAction<GetDepartmentsResponseItem[]>(() =>
            {
                var apiCallPath = "/departments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                return new ApiConnectionAction<GetDepartmentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildGetLeaveTypes))]
        public IBodyWorkflowAction<GetLeaveTypesResponseItem[]> GetLeaveTypes([WorkflowExpression] Func<string> company)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLeaveTypesResponseItem[]> __BuildGetLeaveTypes(WorkflowExpression<string> company)
        {
            WorkflowExpression.Validate(company, nameof(company), required: true);
            return new DeferredBodyAction<GetLeaveTypesResponseItem[]>(() =>
            {
                var apiCallPath = "/leave-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                return new ApiConnectionAction<GetLeaveTypesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllowanceSummary))]
        public IBodyWorkflowAction<GetAllowanceSummaryResponse> GetAllowanceSummary([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> date, [WorkflowExpression] Func<int> page, [WorkflowExpression] Func<string> employee = null, [WorkflowExpression] Func<string> department = null, [WorkflowExpression] Func<string> allowanceType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllowanceSummaryResponse> __BuildGetAllowanceSummary(WorkflowExpression<string> company, WorkflowExpression<string> date, WorkflowExpression<int> page, WorkflowExpression<string> employee = null, WorkflowExpression<string> department = null, WorkflowExpression<string> allowanceType = null)
        {
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(date, nameof(date), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: true);
            WorkflowExpression.Validate(employee, nameof(employee), required: false);
            WorkflowExpression.Validate(department, nameof(department), required: false);
            WorkflowExpression.Validate(allowanceType, nameof(allowanceType), required: false);
            return new DeferredBodyAction<GetAllowanceSummaryResponse>(() =>
            {
                var apiCallPath = "/reports/summary-allowances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (employee != null)
                    callPayload.Queries["employee"] = ExpressionConverter.Convert(employee);
                if (department != null)
                    callPayload.Queries["department"] = ExpressionConverter.Convert(department);
                if (allowanceType != null)
                    callPayload.Queries["allowance_type"] = ExpressionConverter.Convert(allowanceType);
                return new ApiConnectionAction<GetAllowanceSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmployees))]
        public IBodyWorkflowAction<GetEmployeesResponseItem[]> GetEmployees([WorkflowExpression] Func<string> company, [WorkflowExpression] Func<string> departmentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEmployeesResponseItem[]> __BuildGetEmployees(WorkflowExpression<string> company, WorkflowExpression<string> departmentId = null)
        {
            WorkflowExpression.Validate(company, nameof(company), required: true);
            WorkflowExpression.Validate(departmentId, nameof(departmentId), required: false);
            return new DeferredBodyAction<GetEmployeesResponseItem[]>(() =>
            {
                var apiCallPath = "/employments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                if (departmentId != null)
                    callPayload.Queries["department_id"] = ExpressionConverter.Convert(departmentId);
                return new ApiConnectionAction<GetEmployeesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildAddEmployment))]
        public IBodyWorkflowAction<AddEmploymentResponse> AddEmployment([WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyapproverId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodyemployeeCode = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyholidayLocation = null, [WorkflowExpression] Func<string> bodyallowanceUnitIsDays = null, [WorkflowExpression] Func<string> bodyminutesPerWorkingDay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddEmploymentResponse> __BuildAddEmployment(WorkflowExpression<string> bodyfullName, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodycompanyId, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodytimezone = null, WorkflowExpression<string> bodyapproverId = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodyemployeeCode = null, WorkflowExpression<bool> bodyisAdmin = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyholidayLocation = null, WorkflowExpression<string> bodyallowanceUnitIsDays = null, WorkflowExpression<string> bodyminutesPerWorkingDay = null)
        {
            WorkflowExpression.Validate(bodyfullName, nameof(bodyfullName), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            WorkflowExpression.Validate(bodyapproverId, nameof(bodyapproverId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodyemployeeCode, nameof(bodyemployeeCode), required: false);
            WorkflowExpression.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyholidayLocation, nameof(bodyholidayLocation), required: false);
            WorkflowExpression.Validate(bodyallowanceUnitIsDays, nameof(bodyallowanceUnitIsDays), required: false);
            WorkflowExpression.Validate(bodyminutesPerWorkingDay, nameof(bodyminutesPerWorkingDay), required: false);
            return new DeferredBodyAction<AddEmploymentResponse>(() =>
            {
                var apiCallPath = "/employments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(bodyjobTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["full_name"] = ExpressionConverter.ConvertO(bodyfullName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                if (bodyapproverId != null)
                {
                    body["approver_id"] = ExpressionConverter.ConvertO(bodyapproverId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyemployeeCode != null)
                {
                    body["employee_code"] = ExpressionConverter.ConvertO(bodyemployeeCode);
                    bodypropCount++;
                }

                if (bodyisAdmin != null)
                {
                    if (bodyisAdmin != null)
                    {
                        body["is_admin"] = ExpressionConverter.ConvertO(bodyisAdmin);
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
                    body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                    bodypropCount++;
                }

                if (bodyholidayLocation != null)
                {
                    body["holiday_location"] = ExpressionConverter.ConvertO(bodyholidayLocation);
                    bodypropCount++;
                }

                if (bodyallowanceUnitIsDays != null)
                {
                    body["allowance_unit_is_days"] = ExpressionConverter.ConvertO(bodyallowanceUnitIsDays);
                    bodypropCount++;
                }

                if (bodyminutesPerWorkingDay != null)
                {
                    body["minutes_per_working_day"] = ExpressionConverter.ConvertO(bodyminutesPerWorkingDay);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDetailsEmployee))]
        public IBodyWorkflowAction<GetDetailsEmployeeResponse> GetDetailsEmployee([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDetailsEmployeeResponse> __BuildGetDetailsEmployee(WorkflowExpression<string> id, WorkflowExpression<string> company)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            return new DeferredBodyAction<GetDetailsEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/employments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                return new ApiConnectionAction<GetDetailsEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEmployment))]
        public IBodyWorkflowAction<JToken> DeleteEmployment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycompanyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteEmployment(WorkflowExpression<string> id, WorkflowExpression<string> bodycompanyId)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/employments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEmployment))]
        public IBodyWorkflowAction<UpdateEmploymentResponse> UpdateEmployment([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyapproverId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodyemployeeCode = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyholidayLocation = null, [WorkflowExpression] Func<string> bodyallowanceUnitIsDays = null, [WorkflowExpression] Func<string> bodyminutesPerWorkingDay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateEmploymentResponse> __BuildUpdateEmployment(WorkflowExpression<string> id, WorkflowExpression<string> bodyfullName, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodycompanyId, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodytimezone = null, WorkflowExpression<string> bodyapproverId = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodyemployeeCode = null, WorkflowExpression<bool> bodyisAdmin = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyholidayLocation = null, WorkflowExpression<string> bodyallowanceUnitIsDays = null, WorkflowExpression<string> bodyminutesPerWorkingDay = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyfullName, nameof(bodyfullName), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            WorkflowExpression.Validate(bodyapproverId, nameof(bodyapproverId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodyemployeeCode, nameof(bodyemployeeCode), required: false);
            WorkflowExpression.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyholidayLocation, nameof(bodyholidayLocation), required: false);
            WorkflowExpression.Validate(bodyallowanceUnitIsDays, nameof(bodyallowanceUnitIsDays), required: false);
            WorkflowExpression.Validate(bodyminutesPerWorkingDay, nameof(bodyminutesPerWorkingDay), required: false);
            return new DeferredBodyAction<UpdateEmploymentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/employments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(bodyjobTitle);
                    bodypropCount++;
                }

                bodypropCount++;
                body["full_name"] = ExpressionConverter.ConvertO(bodyfullName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                if (bodyapproverId != null)
                {
                    body["approver_id"] = ExpressionConverter.ConvertO(bodyapproverId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyemployeeCode != null)
                {
                    body["employee_code"] = ExpressionConverter.ConvertO(bodyemployeeCode);
                    bodypropCount++;
                }

                if (bodyisAdmin != null)
                {
                    if (bodyisAdmin != null)
                    {
                        body["is_admin"] = ExpressionConverter.ConvertO(bodyisAdmin);
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
                    body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                    bodypropCount++;
                }

                if (bodyholidayLocation != null)
                {
                    body["holiday_location"] = ExpressionConverter.ConvertO(bodyholidayLocation);
                    bodypropCount++;
                }

                if (bodyallowanceUnitIsDays != null)
                {
                    body["allowance_unit_is_days"] = ExpressionConverter.ConvertO(bodyallowanceUnitIsDays);
                    bodypropCount++;
                }

                if (bodyminutesPerWorkingDay != null)
                {
                    body["minutes_per_working_day"] = ExpressionConverter.ConvertO(bodyminutesPerWorkingDay);
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
        [WorkflowExpressionFactory(nameof(__BuildGetLeaveDetails))]
        public IBodyWorkflowAction<GetLeaveDetailsResponse> GetLeaveDetails([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLeaveDetailsResponse> __BuildGetLeaveDetails(WorkflowExpression<string> id, WorkflowExpression<string> company)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            return new DeferredBodyAction<GetLeaveDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                return new ApiConnectionAction<GetLeaveDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLeave))]
        public IBodyWorkflowAction<string[]> UpdateLeave([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodytypeId, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<bodyleaveBreakdownsInputItem[]> bodyleaveBreakdowns = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildUpdateLeave(WorkflowExpression<string> id, WorkflowExpression<string> bodycompanyId, WorkflowExpression<string> bodytypeId, WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodyreason = null, WorkflowExpression<bodyleaveBreakdownsInputItem[]> bodyleaveBreakdowns = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowExpression.Validate(bodytypeId, nameof(bodytypeId), required: true);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowExpression.Validate(bodyleaveBreakdowns, nameof(bodyleaveBreakdowns), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                bodypropCount++;
                body["type_id"] = ExpressionConverter.ConvertO(bodytypeId);
                if (bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                    bodypropCount++;
                }

                if (bodyleaveBreakdowns != null)
                {
                    body["leave_breakdowns"] = ExpressionConverter.ConvertO(bodyleaveBreakdowns);
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
        [WorkflowExpressionFactory(nameof(__BuildRequestLeave))]
        public IBodyWorkflowAction<string[]> RequestLeave([WorkflowExpression] Func<string> bodycompanyId, [WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodytypeId, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<bodyleaveBreakdownsInputItem2[]> bodyleaveBreakdowns = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildRequestLeave(WorkflowExpression<string> bodycompanyId, WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodytypeId, WorkflowExpression<string> bodyreason = null, WorkflowExpression<bool> bodyisPrivate = null, WorkflowExpression<bodyleaveBreakdownsInputItem2[]> bodyleaveBreakdowns = null)
        {
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodytypeId, nameof(bodytypeId), required: true);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowExpression.Validate(bodyleaveBreakdowns, nameof(bodyleaveBreakdowns), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = "/leaves";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["type_id"] = ExpressionConverter.ConvertO(bodytypeId);
                if (bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    if (bodyisPrivate != null)
                    {
                        body["is_private"] = ExpressionConverter.ConvertO(bodyisPrivate);
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
                    body["leave_breakdowns"] = ExpressionConverter.ConvertO(bodyleaveBreakdowns);
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
        [WorkflowExpressionFactory(nameof(__BuildApproveLeave))]
        public IWorkflowAction ApproveLeave([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApproveLeave(WorkflowExpression<string> id, WorkflowExpression<string> company)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}/approve", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leavedates")]
        [WorkflowExpressionFactory(nameof(__BuildCancelLeave))]
        public IWorkflowAction CancelLeave([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> company)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelLeave(WorkflowExpression<string> id, WorkflowExpression<string> company)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(company, nameof(company), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/leaves/{0}/cancel", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
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