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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDepartmentsResponseItem[]> __BuildGetDepartments(WorkflowValue<string> company)
        {
            WorkflowValue.Validate(company, nameof(company), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLeaveTypesResponseItem[]> __BuildGetLeaveTypes(WorkflowValue<string> company)
        {
            WorkflowValue.Validate(company, nameof(company), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllowanceSummaryResponse> __BuildGetAllowanceSummary(WorkflowValue<string> company, WorkflowValue<string> date, WorkflowValue<int> page, WorkflowValue<string> employee = null, WorkflowValue<string> department = null, WorkflowValue<string> allowanceType = null)
        {
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(page, nameof(page), required: true);
            WorkflowValue.Validate(employee, nameof(employee), required: false);
            WorkflowValue.Validate(department, nameof(department), required: false);
            WorkflowValue.Validate(allowanceType, nameof(allowanceType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEmployeesResponseItem[]> __BuildGetEmployees(WorkflowValue<string> company, WorkflowValue<string> departmentId = null)
        {
            WorkflowValue.Validate(company, nameof(company), required: true);
            WorkflowValue.Validate(departmentId, nameof(departmentId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddEmploymentResponse> __BuildAddEmployment(WorkflowValue<string> bodyfullName, WorkflowValue<string> bodyemail, WorkflowValue<string> bodycompanyId, WorkflowValue<string> bodyjobTitle = null, WorkflowValue<string> bodytimezone = null, WorkflowValue<string> bodyapproverId = null, WorkflowValue<string> bodydepartmentId = null, WorkflowValue<string> bodyemployeeCode = null, WorkflowValue<bool> bodyisAdmin = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodyholidayLocation = null, WorkflowValue<string> bodyallowanceUnitIsDays = null, WorkflowValue<string> bodyminutesPerWorkingDay = null)
        {
            WorkflowValue.Validate(bodyfullName, nameof(bodyfullName), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowValue.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowValue.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowValue.Validate(bodytimezone, nameof(bodytimezone), required: false);
            WorkflowValue.Validate(bodyapproverId, nameof(bodyapproverId), required: false);
            WorkflowValue.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowValue.Validate(bodyemployeeCode, nameof(bodyemployeeCode), required: false);
            WorkflowValue.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyholidayLocation, nameof(bodyholidayLocation), required: false);
            WorkflowValue.Validate(bodyallowanceUnitIsDays, nameof(bodyallowanceUnitIsDays), required: false);
            WorkflowValue.Validate(bodyminutesPerWorkingDay, nameof(bodyminutesPerWorkingDay), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDetailsEmployeeResponse> __BuildGetDetailsEmployee(WorkflowValue<string> id, WorkflowValue<string> company)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteEmployment(WorkflowValue<string> id, WorkflowValue<string> bodycompanyId)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateEmploymentResponse> __BuildUpdateEmployment(WorkflowValue<string> id, WorkflowValue<string> bodyfullName, WorkflowValue<string> bodyemail, WorkflowValue<string> bodycompanyId, WorkflowValue<string> bodyjobTitle = null, WorkflowValue<string> bodytimezone = null, WorkflowValue<string> bodyapproverId = null, WorkflowValue<string> bodydepartmentId = null, WorkflowValue<string> bodyemployeeCode = null, WorkflowValue<bool> bodyisAdmin = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodyholidayLocation = null, WorkflowValue<string> bodyallowanceUnitIsDays = null, WorkflowValue<string> bodyminutesPerWorkingDay = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodyfullName, nameof(bodyfullName), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowValue.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowValue.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowValue.Validate(bodytimezone, nameof(bodytimezone), required: false);
            WorkflowValue.Validate(bodyapproverId, nameof(bodyapproverId), required: false);
            WorkflowValue.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowValue.Validate(bodyemployeeCode, nameof(bodyemployeeCode), required: false);
            WorkflowValue.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyholidayLocation, nameof(bodyholidayLocation), required: false);
            WorkflowValue.Validate(bodyallowanceUnitIsDays, nameof(bodyallowanceUnitIsDays), required: false);
            WorkflowValue.Validate(bodyminutesPerWorkingDay, nameof(bodyminutesPerWorkingDay), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLeaveDetailsResponse> __BuildGetLeaveDetails(WorkflowValue<string> id, WorkflowValue<string> company)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildUpdateLeave(WorkflowValue<string> id, WorkflowValue<string> bodycompanyId, WorkflowValue<string> bodytypeId, WorkflowValue<string> bodyfrom = null, WorkflowValue<string> bodyto = null, WorkflowValue<string> bodyreason = null, WorkflowValue<bodyleaveBreakdownsInputItem[]> bodyleaveBreakdowns = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowValue.Validate(bodytypeId, nameof(bodytypeId), required: true);
            WorkflowValue.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowValue.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowValue.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowValue.Validate(bodyleaveBreakdowns, nameof(bodyleaveBreakdowns), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildRequestLeave(WorkflowValue<string> bodycompanyId, WorkflowValue<string> bodyfrom, WorkflowValue<string> bodyto, WorkflowValue<string> bodytypeId, WorkflowValue<string> bodyreason = null, WorkflowValue<bool> bodyisPrivate = null, WorkflowValue<bodyleaveBreakdownsInputItem2[]> bodyleaveBreakdowns = null)
        {
            WorkflowValue.Validate(bodycompanyId, nameof(bodycompanyId), required: true);
            WorkflowValue.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowValue.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowValue.Validate(bodytypeId, nameof(bodytypeId), required: true);
            WorkflowValue.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowValue.Validate(bodyleaveBreakdowns, nameof(bodyleaveBreakdowns), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApproveLeave(WorkflowValue<string> id, WorkflowValue<string> company)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelLeave(WorkflowValue<string> id, WorkflowValue<string> company)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
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
