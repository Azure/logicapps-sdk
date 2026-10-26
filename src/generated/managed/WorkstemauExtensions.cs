//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workstemau
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkstemauActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _001addFixedSalaryData(Expression<Func<_001addFixedSalaryDataV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/addFixedSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3TenantResp, ApiConnectionActionConfiguration> _001getCompanyInfo()
        {
            return new DeferredBodyAction<ResultV3TenantResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getCompanyInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultV3TenantResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _002deleteFixedSalaryDataById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteFixedSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3SysEnterpriseUserResp, ApiConnectionActionConfiguration> _002getUserList()
        {
            return new DeferredBodyAction<ResultListV3SysEnterpriseUserResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getUserList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultListV3SysEnterpriseUserResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3SysEnterpriseUserResp, ApiConnectionActionConfiguration> _003getUserInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3SysEnterpriseUserResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getUserInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3SysEnterpriseUserResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _003updateFixedSalaryDataById(Expression<Func<_003updateFixedSalaryDataByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/updateFixedSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _004addLocationInfo(Expression<Func<_004addLocationInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/addLocationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3PayrollFixedResp, ApiConnectionActionConfiguration> _004getFixedSalaryDataByEmployeeId(Expression<Func<string>> employeeId)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            return new DeferredBodyAction<ResultListV3PayrollFixedResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getFixedSalaryDataByEmployeeId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                return new ApiConnectionAction<ResultListV3PayrollFixedResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _005addVariableSalaryData(Expression<Func<_005addVariableSalaryDataV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/addVariableSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _005deleteLocationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/deleteLocationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _006deleteVariableSalaryDataById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteVariableSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _006updateLocationById(Expression<Func<_006updateLocationByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/updateLocationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3AttAddressResp, ApiConnectionActionConfiguration> _007getLocationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3AttAddressResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getLocationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3AttAddressResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _007updateVariableSalaryDataById(Expression<Func<_007updateVariableSalaryDataByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/updateVariableSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AttAddressResp, ApiConnectionActionConfiguration> _008getLocationInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3AttAddressResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getLocationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3AttAddressResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollNonFixedResp, ApiConnectionActionConfiguration> _008getVariableSalaryDataList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> payrollDateFilter = null, Expression<Func<string>> moneyFilter = null, Expression<Func<string>> payrollItemIdFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> bizLabelIds = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_hireTypeFilter = WorkflowExpression.Compile(hireTypeFilter, nameof(hireTypeFilter), required: false);
            var __workflow_payrollDateFilter = WorkflowExpression.Compile(payrollDateFilter, nameof(payrollDateFilter), required: false);
            var __workflow_moneyFilter = WorkflowExpression.Compile(moneyFilter, nameof(moneyFilter), required: false);
            var __workflow_payrollItemIdFilter = WorkflowExpression.Compile(payrollItemIdFilter, nameof(payrollItemIdFilter), required: false);
            var __workflow_calculateSalaryTypeFilter = WorkflowExpression.Compile(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            var __workflow_bizLabelIds = WorkflowExpression.Compile(bizLabelIds, nameof(bizLabelIds), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollNonFixedResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getVariableSalaryDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(__workflow_hireTypeFilter);
                if (__workflow_payrollDateFilter != null)
                    callPayload.Queries["payrollDateFilter"] = ExpressionConverter.Convert(__workflow_payrollDateFilter);
                if (__workflow_moneyFilter != null)
                    callPayload.Queries["moneyFilter"] = ExpressionConverter.Convert(__workflow_moneyFilter);
                if (__workflow_payrollItemIdFilter != null)
                    callPayload.Queries["payrollItemIdFilter"] = ExpressionConverter.Convert(__workflow_payrollItemIdFilter);
                if (__workflow_calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(__workflow_calculateSalaryTypeFilter);
                if (__workflow_bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(__workflow_bizLabelIds);
                return new ApiConnectionAction<ResultIPageV3PayrollNonFixedResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _009addExternalSalaryData(Expression<Func<_009addExternalSalaryDataV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/addExternalSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AttRuleResp, ApiConnectionActionConfiguration> _009getLocationAttendanceRulesById(Expression<Func<string>> workLocationId)
        {
            var __workflow_workLocationId = WorkflowExpression.Compile(workLocationId, nameof(workLocationId), required: true);
            return new DeferredBodyAction<ResultV3AttRuleResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getLocationAttendanceRulesById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workLocationId"] = ExpressionConverter.Convert(__workflow_workLocationId);
                return new ApiConnectionAction<ResultV3AttRuleResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _010addDepartmentInfo(Expression<Func<_010addDepartmentInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/addDepartmentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _010deleteExternalSalaryDataById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteExternalSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _011deleteDepartmentById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/deleteDepartmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _011updateExternalSalaryDataById(Expression<Func<_011updateExternalSalaryDataByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/updateExternalSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayrollResp, ApiConnectionActionConfiguration> _012getExternalSalaryDataList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> businessSalaryItemFilter = null, Expression<Func<string>> occurrenceDateFilter = null, Expression<Func<string>> moneyFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> labelFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_hireTypeFilter = WorkflowExpression.Compile(hireTypeFilter, nameof(hireTypeFilter), required: false);
            var __workflow_businessSalaryItemFilter = WorkflowExpression.Compile(businessSalaryItemFilter, nameof(businessSalaryItemFilter), required: false);
            var __workflow_occurrenceDateFilter = WorkflowExpression.Compile(occurrenceDateFilter, nameof(occurrenceDateFilter), required: false);
            var __workflow_moneyFilter = WorkflowExpression.Compile(moneyFilter, nameof(moneyFilter), required: false);
            var __workflow_calculateSalaryTypeFilter = WorkflowExpression.Compile(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            var __workflow_labelFilter = WorkflowExpression.Compile(labelFilter, nameof(labelFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3ExternalPayrollResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getExternalSalaryDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(__workflow_hireTypeFilter);
                if (__workflow_businessSalaryItemFilter != null)
                    callPayload.Queries["businessSalaryItemFilter"] = ExpressionConverter.Convert(__workflow_businessSalaryItemFilter);
                if (__workflow_occurrenceDateFilter != null)
                    callPayload.Queries["occurrenceDateFilter"] = ExpressionConverter.Convert(__workflow_occurrenceDateFilter);
                if (__workflow_moneyFilter != null)
                    callPayload.Queries["moneyFilter"] = ExpressionConverter.Convert(__workflow_moneyFilter);
                if (__workflow_calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(__workflow_calculateSalaryTypeFilter);
                if (__workflow_labelFilter != null)
                    callPayload.Queries["labelFilter"] = ExpressionConverter.Convert(__workflow_labelFilter);
                return new ApiConnectionAction<ResultIPageV3ExternalPayrollResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _012updateDepartmentById(Expression<Func<_012updateDepartmentByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/updateDepartmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3DepartmentResp, ApiConnectionActionConfiguration> _013getDepartmentList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3DepartmentResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getDepartmentList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3DepartmentResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanResp, ApiConnectionActionConfiguration> _013getPayrollRunList(Expression<Func<string>> status, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollPlanResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollRunList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3PayrollPlanResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _014addPositionInfo(Expression<Func<_014addPositionInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/addPositionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanDetailResp, ApiConnectionActionConfiguration> _014getPayrollRunDataList(Expression<Func<string>> planId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollPlanDetailResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollRunDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["planId"] = ExpressionConverter.Convert(__workflow_planId);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3PayrollPlanDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _015deletePositionById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/deletePositionById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3PayrollPlanDetailResp, ApiConnectionActionConfiguration> _015getPayrollDetailsInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultListV3PayrollPlanDetailResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultListV3PayrollPlanDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollRegResp, ApiConnectionActionConfiguration> _016getPayrollPolicyList(Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> q = null)
        {
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollRegResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollPolicyList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<ResultIPageV3PayrollRegResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _016updatePositionById(Expression<Func<_016updatePositionByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/updatePositionById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3PayrollRegResp, ApiConnectionActionConfiguration> _017getPayrollPolicyInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3PayrollRegResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollPolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3PayrollRegResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PositionResp, ApiConnectionActionConfiguration> _017getPositionList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PositionResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getPositionList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3PositionResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _018addCostCenterInfo(Expression<Func<_018addCostCenterInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/addCostCenterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollItemResp, ApiConnectionActionConfiguration> _018getPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> nameFilter = null, Expression<Func<string>> paymentTypeFilter = null, Expression<Func<string>> payrollItemTypeId = null, Expression<Func<string>> statusFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_nameFilter = WorkflowExpression.Compile(nameFilter, nameof(nameFilter), required: false);
            var __workflow_paymentTypeFilter = WorkflowExpression.Compile(paymentTypeFilter, nameof(paymentTypeFilter), required: false);
            var __workflow_payrollItemTypeId = WorkflowExpression.Compile(payrollItemTypeId, nameof(payrollItemTypeId), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_nameFilter != null)
                    callPayload.Queries["nameFilter"] = ExpressionConverter.Convert(__workflow_nameFilter);
                if (__workflow_paymentTypeFilter != null)
                    callPayload.Queries["paymentTypeFilter"] = ExpressionConverter.Convert(__workflow_paymentTypeFilter);
                if (__workflow_payrollItemTypeId != null)
                    callPayload.Queries["payrollItemTypeId"] = ExpressionConverter.Convert(__workflow_payrollItemTypeId);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                return new ApiConnectionAction<ResultIPageV3PayrollItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _019deleteCostCenterById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/deleteCostCenterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3PayrollItemResp, ApiConnectionActionConfiguration> _019getPayItemInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3PayrollItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3PayrollItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddEmployeeResp, ApiConnectionActionConfiguration> _01addEmployeeInfo(Expression<Func<_01addEmployeeInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3AddEmployeeResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/addEmployeeInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3AddEmployeeResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _01addLeaveBalanceAdjustInfo(Expression<Func<_01addLeaveBalanceAdjustInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/addLeaveBalanceAdjustInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _01addRosterInfo(Expression<Func<_01addRosterInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addRosterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3CalAttendanceResp, ApiConnectionActionConfiguration> _01attendanceSummaryCalculate(Expression<Func<_01attendanceSummaryCalculateV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3CalAttendanceResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/attendanceSummaryCalculate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3CalAttendanceResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizAttendanceConfigureResp, ApiConnectionActionConfiguration> _01getAttendanceConfigurationList()
        {
            return new DeferredBodyAction<ResultV3BizAttendanceConfigureResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/settings/getAttendanceConfigurationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultV3BizAttendanceConfigureResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementTypeResp, ApiConnectionActionConfiguration> _01getExpenseTypeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizReimbursementTypeResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/expense/getExpenseTypeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3BizReimbursementTypeResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayItemResp, ApiConnectionActionConfiguration> _020getExternalPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ExternalPayItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getExternalPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3ExternalPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _020updateCostCenterById(Expression<Func<_020updateCostCenterByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/updateCostCenterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3CostCenterResp, ApiConnectionActionConfiguration> _021getCostCenterList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3CostCenterResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getCostCenterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3CostCenterResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3ExternalPayItemResp, ApiConnectionActionConfiguration> _021getExternalPayItemInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3ExternalPayItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getExternalPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3ExternalPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _022addTagInfo(Expression<Func<_022addTagInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/addTagInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _022addWorkPatternInfo(Expression<Func<_022addWorkPatternInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/addWorkPatternInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _023deleteTagById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/deleteTagById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _023updateWorkPatternById(Expression<Func<_023updateWorkPatternByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/updateWorkPatternById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _024deleteWorkPatternById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteWorkPatternById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _024updateTagById(Expression<Func<_024updateTagByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/updateTagById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LabelResp, ApiConnectionActionConfiguration> _025getTagList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LabelResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getTagList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3LabelResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3WorkPatternSummaryResp, ApiConnectionActionConfiguration> _025getWorkPatternList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3WorkPatternSummaryResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getWorkPatternList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3WorkPatternSummaryResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3DeviceResp, ApiConnectionActionConfiguration> _026getDeviceList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3DeviceResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/company/getDeviceList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3DeviceResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3WorkPatternResp, ApiConnectionActionConfiguration> _026getWorkPatternInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3WorkPatternResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/payroll/getWorkPatternInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3WorkPatternResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizReimbursementInsertResp, ApiConnectionActionConfiguration> _02addExpenseApplicationInfo(Expression<Func<_02addExpenseApplicationInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3BizReimbursementInsertResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/expense/addExpenseApplicationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3BizReimbursementInsertResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _02batchSaveRosterInfo(Expression<Func<_02batchSaveRosterInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/batchSaveRosterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _02deleteEmployeeById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/deleteAllData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _02deleteLeaveBalanceAdjustmentById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/deleteLeaveBalanceAdjustmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceListResp, ApiConnectionActionConfiguration> _02getAttendanceSummaryList(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> unit, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> attendCalculationFilter = null, Expression<Func<string>> employeeFilter = null, Expression<Func<string>> labelFilter = null, Expression<Func<string>> payrollRegulationFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> attendanceTypeFilter = null, Expression<Func<string>> shiftTypeFilter = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_unit = WorkflowExpression.Compile(unit, nameof(unit), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            var __workflow_positionFilter = WorkflowExpression.Compile(positionFilter, nameof(positionFilter), required: false);
            var __workflow_attendCalculationFilter = WorkflowExpression.Compile(attendCalculationFilter, nameof(attendCalculationFilter), required: false);
            var __workflow_employeeFilter = WorkflowExpression.Compile(employeeFilter, nameof(employeeFilter), required: false);
            var __workflow_labelFilter = WorkflowExpression.Compile(labelFilter, nameof(labelFilter), required: false);
            var __workflow_payrollRegulationFilter = WorkflowExpression.Compile(payrollRegulationFilter, nameof(payrollRegulationFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_hireTypeFilter = WorkflowExpression.Compile(hireTypeFilter, nameof(hireTypeFilter), required: false);
            var __workflow_calculateSalaryTypeFilter = WorkflowExpression.Compile(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            var __workflow_attendanceTypeFilter = WorkflowExpression.Compile(attendanceTypeFilter, nameof(attendanceTypeFilter), required: false);
            var __workflow_shiftTypeFilter = WorkflowExpression.Compile(shiftTypeFilter, nameof(shiftTypeFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3AttendanceListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getAttendanceSummaryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Queries["unit"] = ExpressionConverter.Convert(__workflow_unit);
                if (__workflow_departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(__workflow_departmentFilter);
                if (__workflow_positionFilter != null)
                    callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(__workflow_positionFilter);
                if (__workflow_attendCalculationFilter != null)
                    callPayload.Queries["attendCalculationFilter"] = ExpressionConverter.Convert(__workflow_attendCalculationFilter);
                if (__workflow_employeeFilter != null)
                    callPayload.Queries["employeeFilter"] = ExpressionConverter.Convert(__workflow_employeeFilter);
                if (__workflow_labelFilter != null)
                    callPayload.Queries["labelFilter"] = ExpressionConverter.Convert(__workflow_labelFilter);
                if (__workflow_payrollRegulationFilter != null)
                    callPayload.Queries["payrollRegulationFilter"] = ExpressionConverter.Convert(__workflow_payrollRegulationFilter);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(__workflow_hireTypeFilter);
                if (__workflow_calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(__workflow_calculateSalaryTypeFilter);
                if (__workflow_attendanceTypeFilter != null)
                    callPayload.Queries["attendanceTypeFilter"] = ExpressionConverter.Convert(__workflow_attendanceTypeFilter);
                if (__workflow_shiftTypeFilter != null)
                    callPayload.Queries["shiftTypeFilter"] = ExpressionConverter.Convert(__workflow_shiftTypeFilter);
                return new ApiConnectionAction<ResultIPageV3AttendanceListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryResp, ApiConnectionActionConfiguration> _02getDataDictionaryList()
        {
            return new DeferredBodyAction<ResultListV3BizCustomizeDictionaryResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/settings/getDataDictionaryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _03deleteExpenseApplicationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/expense/deleteExpenseApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _03deleteRosterById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteRosterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryItemResp, ApiConnectionActionConfiguration> _03GetDataDictionaryDetailsInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultListV3BizCustomizeDictionaryItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/settings/getDataDictionaryDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3AttendanceDetailListResp, ApiConnectionActionConfiguration> _03getEmployeeDailyAttendanceList(Expression<Func<string>> employeeId, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> attendStatusFilter = null)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_attendStatusFilter = WorkflowExpression.Compile(attendStatusFilter, nameof(attendStatusFilter), required: false);
            return new DeferredBodyAction<ResultListV3AttendanceDetailListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getEmployeeDailyAttendanceList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_attendStatusFilter != null)
                    callPayload.Queries["attendStatusFilter"] = ExpressionConverter.Convert(__workflow_attendStatusFilter);
                return new ApiConnectionAction<ResultListV3AttendanceDetailListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayBalanceResp, ApiConnectionActionConfiguration> _03getLeaveBalanceAdjustmentList(Expression<Func<string>> employeeId, Expression<Func<string>> holidayType, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_holidayType = WorkflowExpression.Compile(holidayType, nameof(holidayType), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveHolidayBalanceResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceAdjustmentList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                callPayload.Queries["holidayType"] = ExpressionConverter.Convert(__workflow_holidayType);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3LeaveHolidayBalanceResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _03updateEmployeeById(Expression<Func<_03updateEmployeeByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/updateEmployeeById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddMobileCardResp, ApiConnectionActionConfiguration> _04addAttendanceDataInfo(Expression<Func<_04addAttendanceDataInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3AddMobileCardResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/addAttendanceDataInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3AddMobileCardResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _04calculationLeaveBalance(Expression<Func<_04calculationLeaveBalanceV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/calculationLeaveBalance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3BizEmployeeCustomizationResp, ApiConnectionActionConfiguration> _04getCustomizeUserFieldList(Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizEmployeeCustomizationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/settings/getCustomizeUserFieldList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3BizEmployeeCustomizationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeListResp, ApiConnectionActionConfiguration> _04getEmployeeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> id = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> sex = null, Expression<Func<int>> status = null, Expression<Func<string>> hireType = null, Expression<Func<string>> calculateSalaryType = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> payrollRegulationId = null, Expression<Func<string>> regularType = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_departmentId = WorkflowExpression.Compile(departmentId, nameof(departmentId), required: false);
            var __workflow_positionId = WorkflowExpression.Compile(positionId, nameof(positionId), required: false);
            var __workflow_sex = WorkflowExpression.Compile(sex, nameof(sex), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_hireType = WorkflowExpression.Compile(hireType, nameof(hireType), required: false);
            var __workflow_calculateSalaryType = WorkflowExpression.Compile(calculateSalaryType, nameof(calculateSalaryType), required: false);
            var __workflow_costCenterId = WorkflowExpression.Compile(costCenterId, nameof(costCenterId), required: false);
            var __workflow_payrollRegulationId = WorkflowExpression.Compile(payrollRegulationId, nameof(payrollRegulationId), required: false);
            var __workflow_regularType = WorkflowExpression.Compile(regularType, nameof(regularType), required: false);
            return new DeferredBodyAction<ResultIPageV3EmployeeListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/getEmployeeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_departmentId != null)
                    callPayload.Queries["departmentId"] = ExpressionConverter.Convert(__workflow_departmentId);
                if (__workflow_positionId != null)
                    callPayload.Queries["positionId"] = ExpressionConverter.Convert(__workflow_positionId);
                if (__workflow_sex != null)
                    callPayload.Queries["sex"] = ExpressionConverter.Convert(__workflow_sex);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_hireType != null)
                    callPayload.Queries["hireType"] = ExpressionConverter.Convert(__workflow_hireType);
                if (__workflow_calculateSalaryType != null)
                    callPayload.Queries["calculateSalaryType"] = ExpressionConverter.Convert(__workflow_calculateSalaryType);
                if (__workflow_costCenterId != null)
                    callPayload.Queries["costCenterId"] = ExpressionConverter.Convert(__workflow_costCenterId);
                if (__workflow_payrollRegulationId != null)
                    callPayload.Queries["payrollRegulationId"] = ExpressionConverter.Convert(__workflow_payrollRegulationId);
                if (__workflow_regularType != null)
                    callPayload.Queries["regularType"] = ExpressionConverter.Convert(__workflow_regularType);
                return new ApiConnectionAction<ResultIPageV3EmployeeListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _04updateExpenseApplicationById(Expression<Func<_04updateExpenseApplicationByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/expense/updateExpenseApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _04updateRosterInfoById(Expression<Func<_04updateRosterInfoByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateRosterInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _05deleteAttendanceDataById(Expression<Func<string>> ids)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteAttendanceDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizEmployeeCustomizationResp, ApiConnectionActionConfiguration> _05getCustomizeUserFieldInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3BizEmployeeCustomizationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/settings/getCustomizeUserFieldInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3BizEmployeeCustomizationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3EmployeeInfoResp, ApiConnectionActionConfiguration> _05getEmployeeInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3EmployeeInfoResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/getEmployeeInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3EmployeeInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementResp, ApiConnectionActionConfiguration> _05GetExpenseApplicationList(Expression<Func<string>> q = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> dateFilter = null, Expression<Func<string>> reimbursementStatusFilter = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_dateFilter = WorkflowExpression.Compile(dateFilter, nameof(dateFilter), required: false);
            var __workflow_reimbursementStatusFilter = WorkflowExpression.Compile(reimbursementStatusFilter, nameof(reimbursementStatusFilter), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizReimbursementResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/expense/getExpenseApplicationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(__workflow_departmentFilter);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_dateFilter != null)
                    callPayload.Queries["dateFilter"] = ExpressionConverter.Convert(__workflow_dateFilter);
                if (__workflow_reimbursementStatusFilter != null)
                    callPayload.Queries["reimbursementStatusFilter"] = ExpressionConverter.Convert(__workflow_reimbursementStatusFilter);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3BizReimbursementResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveBalanceResp, ApiConnectionActionConfiguration> _05getLeaveBalanceList(Expression<Func<string>> holidayType, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> regularTypeFilter = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> sexFilter = null, Expression<Func<string>> leaveHolidayBalanceStatusFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> bizLabelIds = null)
        {
            var __workflow_holidayType = WorkflowExpression.Compile(holidayType, nameof(holidayType), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_regularTypeFilter = WorkflowExpression.Compile(regularTypeFilter, nameof(regularTypeFilter), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            var __workflow_positionFilter = WorkflowExpression.Compile(positionFilter, nameof(positionFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_sexFilter = WorkflowExpression.Compile(sexFilter, nameof(sexFilter), required: false);
            var __workflow_leaveHolidayBalanceStatusFilter = WorkflowExpression.Compile(leaveHolidayBalanceStatusFilter, nameof(leaveHolidayBalanceStatusFilter), required: false);
            var __workflow_calculateSalaryTypeFilter = WorkflowExpression.Compile(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            var __workflow_hireTypeFilter = WorkflowExpression.Compile(hireTypeFilter, nameof(hireTypeFilter), required: false);
            var __workflow_bizLabelIds = WorkflowExpression.Compile(bizLabelIds, nameof(bizLabelIds), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveBalanceResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["holidayType"] = ExpressionConverter.Convert(__workflow_holidayType);
                if (__workflow_regularTypeFilter != null)
                    callPayload.Queries["regularTypeFilter"] = ExpressionConverter.Convert(__workflow_regularTypeFilter);
                if (__workflow_departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(__workflow_departmentFilter);
                if (__workflow_positionFilter != null)
                    callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(__workflow_positionFilter);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_sexFilter != null)
                    callPayload.Queries["sexFilter"] = ExpressionConverter.Convert(__workflow_sexFilter);
                if (__workflow_leaveHolidayBalanceStatusFilter != null)
                    callPayload.Queries["leaveHolidayBalanceStatusFilter"] = ExpressionConverter.Convert(__workflow_leaveHolidayBalanceStatusFilter);
                if (__workflow_calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(__workflow_calculateSalaryTypeFilter);
                if (__workflow_hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(__workflow_hireTypeFilter);
                if (__workflow_bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(__workflow_bizLabelIds);
                return new ApiConnectionAction<ResultIPageV3LeaveBalanceResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3RosterListResp, ApiConnectionActionConfiguration> _05getRosterList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendDay = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> attendStatus = null, Expression<Func<string>> dateType = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_attendDay = WorkflowExpression.Compile(attendDay, nameof(attendDay), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_attendStatus = WorkflowExpression.Compile(attendStatus, nameof(attendStatus), required: false);
            var __workflow_dateType = WorkflowExpression.Compile(dateType, nameof(dateType), required: false);
            return new DeferredBodyAction<ResultIPageV3RosterListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getRosterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_attendDay != null)
                    callPayload.Queries["attendDay"] = ExpressionConverter.Convert(__workflow_attendDay);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_attendStatus != null)
                    callPayload.Queries["attendStatus"] = ExpressionConverter.Convert(__workflow_attendStatus);
                if (__workflow_dateType != null)
                    callPayload.Queries["dateType"] = ExpressionConverter.Convert(__workflow_dateType);
                return new ApiConnectionAction<ResultIPageV3RosterListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveWorkFlowDefinitionResp, ApiConnectionActionConfiguration> _06getApproveProcessList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveWorkFlowDefinitionResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/settings/getApproveProcessList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3LeaveWorkFlowDefinitionResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizReimbursementDetailResp, ApiConnectionActionConfiguration> _06GetExpenseApplicationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3BizReimbursementDetailResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/expense/getExpenseApplicationById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3BizReimbursementDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeaveBalanceDetailResp, ApiConnectionActionConfiguration> _06GetLeaveBalanceInfoById(Expression<Func<string>> employeeId, Expression<Func<string>> holidayType)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_holidayType = WorkflowExpression.Compile(holidayType, nameof(holidayType), required: true);
            return new DeferredBodyAction<ResultV3LeaveBalanceDetailResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                callPayload.Queries["holidayType"] = ExpressionConverter.Convert(__workflow_holidayType);
                return new ApiConnectionAction<ResultV3LeaveBalanceDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3RosterInfoResp, ApiConnectionActionConfiguration> _06getRosterInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3RosterInfoResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getRosterInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3RosterInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _06resign(Expression<Func<_06resignV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/resign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _06updateAttendanceDataById(Expression<Func<_06updateAttendanceDataByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/updateAttendanceDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddEmployeeHistoryResp, ApiConnectionActionConfiguration> _07addEmployeeHistory(Expression<Func<_07addEmployeeHistoryV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3AddEmployeeHistoryResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/addEmployeeHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3AddEmployeeHistoryResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayInsertResp, ApiConnectionActionConfiguration> _07addLeaveApplicationInfo(Expression<Func<_07addLeaveApplicationInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3LeaveHolidayInsertResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/addLeaveApplicationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3LeaveHolidayInsertResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _07addShitTemplateInfo(Expression<Func<_07addShitTemplateInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addShitTemplateInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3MobileCardListResp, ApiConnectionActionConfiguration> _07getAttendanceDataList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            var __workflow_positionFilter = WorkflowExpression.Compile(positionFilter, nameof(positionFilter), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_attendCalculationId = WorkflowExpression.Compile(attendCalculationId, nameof(attendCalculationId), required: false);
            var __workflow_bizLabelIds = WorkflowExpression.Compile(bizLabelIds, nameof(bizLabelIds), required: false);
            var __workflow_hireTypeFilter = WorkflowExpression.Compile(hireTypeFilter, nameof(hireTypeFilter), required: false);
            var __workflow_calculateSalaryTypeFilter = WorkflowExpression.Compile(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<ResultIPageV3MobileCardListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getAttendanceDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(__workflow_departmentFilter);
                if (__workflow_positionFilter != null)
                    callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(__workflow_positionFilter);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_attendCalculationId != null)
                    callPayload.Queries["attendCalculationId"] = ExpressionConverter.Convert(__workflow_attendCalculationId);
                if (__workflow_bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(__workflow_bizLabelIds);
                if (__workflow_hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(__workflow_hireTypeFilter);
                if (__workflow_calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(__workflow_calculateSalaryTypeFilter);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<ResultIPageV3MobileCardListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _08deleteEmployeeHistoryById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/deleteEmployeeHistoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _08deleteLeaveApplicationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/deleteLeaveApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _08deleteShiftTemplateById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteShiftTemplateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3MobileCardInfoResp, ApiConnectionActionConfiguration> _08getAttendanceDataInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3MobileCardInfoResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getAttendanceDataInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3MobileCardInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceItemListResp, ApiConnectionActionConfiguration> _09getAttendanceItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3AttendanceItemListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getAttendanceItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3AttendanceItemListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _09updateEmployeeHistoryById(Expression<Func<_09updateEmployeeHistoryByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/updateEmployeeHistoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _09updateLeaveApplicationById(Expression<Func<_09updateLeaveApplicationByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/updateLeaveApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _09updateShiftTemplateById(Expression<Func<_09updateShiftTemplateByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateShiftTemplateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddTimesheetResp, ApiConnectionActionConfiguration> _10addTimesheetInfo(Expression<Func<_10addTimesheetInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3AddTimesheetResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/addTimesheetInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3AddTimesheetResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeHistoryListResp, ApiConnectionActionConfiguration> _10getEmployeeHistoryList(Expression<Func<string>> employeeId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3EmployeeHistoryListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/employee/getEmployeeHistoryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3EmployeeHistoryListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayResp, ApiConnectionActionConfiguration> _10getLeaveApplicationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> employeeFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> holidayTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> recordStatusFilter = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> startDateFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            var __workflow_employeeFilter = WorkflowExpression.Compile(employeeFilter, nameof(employeeFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_holidayTypeFilter = WorkflowExpression.Compile(holidayTypeFilter, nameof(holidayTypeFilter), required: false);
            var __workflow_calculateSalaryTypeFilter = WorkflowExpression.Compile(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            var __workflow_recordStatusFilter = WorkflowExpression.Compile(recordStatusFilter, nameof(recordStatusFilter), required: false);
            var __workflow_attendCalculationId = WorkflowExpression.Compile(attendCalculationId, nameof(attendCalculationId), required: false);
            var __workflow_bizLabelIds = WorkflowExpression.Compile(bizLabelIds, nameof(bizLabelIds), required: false);
            var __workflow_startDateFilter = WorkflowExpression.Compile(startDateFilter, nameof(startDateFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveHolidayResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(__workflow_departmentFilter);
                if (__workflow_employeeFilter != null)
                    callPayload.Queries["employeeFilter"] = ExpressionConverter.Convert(__workflow_employeeFilter);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_holidayTypeFilter != null)
                    callPayload.Queries["holidayTypeFilter"] = ExpressionConverter.Convert(__workflow_holidayTypeFilter);
                if (__workflow_calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(__workflow_calculateSalaryTypeFilter);
                if (__workflow_recordStatusFilter != null)
                    callPayload.Queries["recordStatusFilter"] = ExpressionConverter.Convert(__workflow_recordStatusFilter);
                if (__workflow_attendCalculationId != null)
                    callPayload.Queries["attendCalculationId"] = ExpressionConverter.Convert(__workflow_attendCalculationId);
                if (__workflow_bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(__workflow_bizLabelIds);
                if (__workflow_startDateFilter != null)
                    callPayload.Queries["startDateFilter"] = ExpressionConverter.Convert(__workflow_startDateFilter);
                return new ApiConnectionAction<ResultIPageV3LeaveHolidayResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ShiftTemplateListResp, ApiConnectionActionConfiguration> _10getShiftTemplateList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendanceAddressId = null, Expression<Func<string>> dateType = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_attendanceAddressId = WorkflowExpression.Compile(attendanceAddressId, nameof(attendanceAddressId), required: false);
            var __workflow_dateType = WorkflowExpression.Compile(dateType, nameof(dateType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV3ShiftTemplateListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getShiftTemplateList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_attendanceAddressId != null)
                    callPayload.Queries["attendanceAddressId"] = ExpressionConverter.Convert(__workflow_attendanceAddressId);
                if (__workflow_dateType != null)
                    callPayload.Queries["dateType"] = ExpressionConverter.Convert(__workflow_dateType);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ResultIPageV3ShiftTemplateListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _11addOpenShiftInfo(Expression<Func<_11addOpenShiftInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addOpenShiftInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _11deleteTimesheetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteTimesheetById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayDetailResp, ApiConnectionActionConfiguration> _11getLeaveApplicationInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3LeaveHolidayDetailResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3LeaveHolidayDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _12deleteOpenShiftById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteOpenShiftById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3LeaveProcessResp, ApiConnectionActionConfiguration> _12getLeaveApplicationApproveProcessById(Expression<Func<string>> recordId)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<ResultListV3LeaveProcessResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationApproveProcessById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordId"] = ExpressionConverter.Convert(__workflow_recordId);
                return new ApiConnectionAction<ResultListV3LeaveProcessResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _12updateTimesheetById(Expression<Func<_12updateTimesheetByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/updateTimesheetById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveTypeResp, ApiConnectionActionConfiguration> _13getLeaveTypeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> shortName = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_shortName = WorkflowExpression.Compile(shortName, nameof(shortName), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveTypeResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveTypeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_shortName != null)
                    callPayload.Queries["shortName"] = ExpressionConverter.Convert(__workflow_shortName);
                return new ApiConnectionAction<ResultIPageV3LeaveTypeResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3TimesheetListResp, ApiConnectionActionConfiguration> _13getTimesheetList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> addressCardId = null, Expression<Func<string>> typeFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            var __workflow_positionFilter = WorkflowExpression.Compile(positionFilter, nameof(positionFilter), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_bizLabelIds = WorkflowExpression.Compile(bizLabelIds, nameof(bizLabelIds), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_calculateSalaryTypeFilter = WorkflowExpression.Compile(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_addressCardId = WorkflowExpression.Compile(addressCardId, nameof(addressCardId), required: false);
            var __workflow_typeFilter = WorkflowExpression.Compile(typeFilter, nameof(typeFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3TimesheetListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getTimesheetList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(__workflow_departmentFilter);
                if (__workflow_positionFilter != null)
                    callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(__workflow_positionFilter);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(__workflow_bizLabelIds);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(__workflow_calculateSalaryTypeFilter);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_addressCardId != null)
                    callPayload.Queries["addressCardId"] = ExpressionConverter.Convert(__workflow_addressCardId);
                if (__workflow_typeFilter != null)
                    callPayload.Queries["typeFilter"] = ExpressionConverter.Convert(__workflow_typeFilter);
                return new ApiConnectionAction<ResultIPageV3TimesheetListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _13updateOpenShiftById(Expression<Func<_13updateOpenShiftByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateOpenShiftById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyResp, ApiConnectionActionConfiguration> _14getLeavePolicyList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredBodyAction<ResultIPageV3LeavePolicyResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeavePolicyList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<ResultIPageV3LeavePolicyResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3OpenShiftListResp, ApiConnectionActionConfiguration> _14getOpenShiftList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> projectId = null, Expression<Func<string>> locationId = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> date = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_costCenterId = WorkflowExpression.Compile(costCenterId, nameof(costCenterId), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            return new DeferredBodyAction<ResultIPageV3OpenShiftListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getOpenShiftList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_locationId != null)
                    callPayload.Queries["locationId"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_costCenterId != null)
                    callPayload.Queries["costCenterId"] = ExpressionConverter.Convert(__workflow_costCenterId);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                return new ApiConnectionAction<ResultIPageV3OpenShiftListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3TimesheetInfoResp, ApiConnectionActionConfiguration> _14getTimesheetInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3TimesheetInfoResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getTimesheetInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3TimesheetInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddCalendarRemarkInfoResp, ApiConnectionActionConfiguration> _15addCalendarRemarkInfo(Expression<Func<_15addCalendarRemarkInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultV3AddCalendarRemarkInfoResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/addCalendarRemarkInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultV3AddCalendarRemarkInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeavePolicyDetailResp, ApiConnectionActionConfiguration> _15getLeavePolicyInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3LeavePolicyDetailResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeavePolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3LeavePolicyDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3OpenShiftInfoResp, ApiConnectionActionConfiguration> _15getOpenShiftInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3OpenShiftInfoResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getOpenShiftInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3OpenShiftInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _16addProjectCategoryInfo(Expression<Func<_16addProjectCategoryInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCategoryInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _16deleteCalendarRemarkById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteCalendarRemarkById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyTypeResp, ApiConnectionActionConfiguration> _16getLeavePolicyTypeList(Expression<Func<string>> regulationId, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> id = null, Expression<Func<string>> holidayId = null, Expression<Func<string>> generationFrequency = null)
        {
            var __workflow_regulationId = WorkflowExpression.Compile(regulationId, nameof(regulationId), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_holidayId = WorkflowExpression.Compile(holidayId, nameof(holidayId), required: false);
            var __workflow_generationFrequency = WorkflowExpression.Compile(generationFrequency, nameof(generationFrequency), required: false);
            return new DeferredBodyAction<ResultIPageV3LeavePolicyTypeResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/leave/getLeavePolicyTypeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["regulationId"] = ExpressionConverter.Convert(__workflow_regulationId);
                if (__workflow_holidayId != null)
                    callPayload.Queries["holidayId"] = ExpressionConverter.Convert(__workflow_holidayId);
                if (__workflow_generationFrequency != null)
                    callPayload.Queries["generationFrequency"] = ExpressionConverter.Convert(__workflow_generationFrequency);
                return new ApiConnectionAction<ResultIPageV3LeavePolicyTypeResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _17deleteProjectCategoryById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCategoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _17updateCalendarRemarkById(Expression<Func<_17updateCalendarRemarkByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/updateCalendarRemarkById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3StatusFlagListResp, ApiConnectionActionConfiguration> _18getCalendarRemarkList(Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIds = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeIds = WorkflowExpression.Compile(employeeIds, nameof(employeeIds), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<ResultIPageV3StatusFlagListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendance/getCalendarRemarkList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeIds != null)
                    callPayload.Queries["employeeIds"] = ExpressionConverter.Convert(__workflow_employeeIds);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<ResultIPageV3StatusFlagListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _18updateProjectCategoryById(Expression<Func<_18updateProjectCategoryByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectCategoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ScheduleProjectCategoryListResp, ApiConnectionActionConfiguration> _19getProjectCategoryList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ScheduleProjectCategoryListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getProjectCategoryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3ScheduleProjectCategoryListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _20addProjectInfo(Expression<Func<_20addProjectInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _21deleteProjectById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _22updateProjectById(Expression<Func<_22updateProjectByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ProjectListResp, ApiConnectionActionConfiguration> _23getProjectList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getProjectList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3ProjectListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3ProjectInfoResp, ApiConnectionActionConfiguration> _24getProjectInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3ProjectInfoResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getProjectInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3ProjectInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _25addProjectCertificateInfo(Expression<Func<_25addProjectCertificateInfoV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCertificateInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _26updateProjectCertificateById(Expression<Func<_26updateProjectCertificateByIdV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectCertificateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateListResp, ApiConnectionActionConfiguration> _27getProjectCertificateList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<int>> status = null, Expression<Func<string>> hireType = null, Expression<Func<string>> projectId = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_departmentId = WorkflowExpression.Compile(departmentId, nameof(departmentId), required: false);
            var __workflow_positionId = WorkflowExpression.Compile(positionId, nameof(positionId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_hireType = WorkflowExpression.Compile(hireType, nameof(hireType), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectCertificateListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getProjectCertificateList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_departmentId != null)
                    callPayload.Queries["departmentId"] = ExpressionConverter.Convert(__workflow_departmentId);
                if (__workflow_positionId != null)
                    callPayload.Queries["positionId"] = ExpressionConverter.Convert(__workflow_positionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_hireType != null)
                    callPayload.Queries["hireType"] = ExpressionConverter.Convert(__workflow_hireType);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<ResultIPageV3ProjectCertificateListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _28addProjectCertificateHours(Expression<Func<_28addProjectCertificateHoursV3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCertificateHours";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> _29deleteProjectCertificateHoursById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCertificateHoursById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateHoursListResp, ApiConnectionActionConfiguration> _30getProjectCertificateHourList(Expression<Func<string>> projectCertificateId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_projectCertificateId = WorkflowExpression.Compile(projectCertificateId, nameof(projectCertificateId), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectCertificateHoursListResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getProjectCertificateHourList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectCertificateId"] = ExpressionConverter.Convert(__workflow_projectCertificateId);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ResultIPageV3ProjectCertificateHoursListResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2AttendanceResp, ApiConnectionActionConfiguration> GetAttendCalculationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendDay = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> attendStatus = null, Expression<Func<string>> type = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_attendDay = WorkflowExpression.Compile(attendDay, nameof(attendDay), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_attendStatus = WorkflowExpression.Compile(attendStatus, nameof(attendStatus), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<ResultIPageV2AttendanceResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/attendance/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_attendDay != null)
                    callPayload.Queries["attendDay"] = ExpressionConverter.Convert(__workflow_attendDay);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_attendStatus != null)
                    callPayload.Queries["attendStatus"] = ExpressionConverter.Convert(__workflow_attendStatus);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<ResultIPageV2AttendanceResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2CostCenterResp, ApiConnectionActionConfiguration> GetCostCenterList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> costCenterCode = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_costCenterCode = WorkflowExpression.Compile(costCenterCode, nameof(costCenterCode), required: false);
            return new DeferredBodyAction<ResultIPageV2CostCenterResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/getCostCenterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_costCenterCode != null)
                    callPayload.Queries["costCenterCode"] = ExpressionConverter.Convert(__workflow_costCenterCode);
                return new ApiConnectionAction<ResultIPageV2CostCenterResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2DepartmentResp, ApiConnectionActionConfiguration> GetDepartmentList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> departmentCode = null, Expression<Func<string>> parentId = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_departmentCode = WorkflowExpression.Compile(departmentCode, nameof(departmentCode), required: false);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2DepartmentResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/department/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_departmentCode != null)
                    callPayload.Queries["departmentCode"] = ExpressionConverter.Convert(__workflow_departmentCode);
                if (__workflow_parentId != null)
                    callPayload.Queries["parentId"] = ExpressionConverter.Convert(__workflow_parentId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ResultIPageV2DepartmentResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2EmployeeResp, ApiConnectionActionConfiguration> GetEmployeeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> englishName = null, Expression<Func<string>> chineseName = null, Expression<Func<string>> email = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> phone = null, Expression<Func<string>> code = null, Expression<Func<int>> status = null, Expression<Func<string>> education = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> hireType = null, Expression<Func<string>> bankCode = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> payrollRegulationId = null, Expression<Func<string>> workDate = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_englishName = WorkflowExpression.Compile(englishName, nameof(englishName), required: false);
            var __workflow_chineseName = WorkflowExpression.Compile(chineseName, nameof(chineseName), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_education = WorkflowExpression.Compile(education, nameof(education), required: false);
            var __workflow_departmentId = WorkflowExpression.Compile(departmentId, nameof(departmentId), required: false);
            var __workflow_positionId = WorkflowExpression.Compile(positionId, nameof(positionId), required: false);
            var __workflow_hireType = WorkflowExpression.Compile(hireType, nameof(hireType), required: false);
            var __workflow_bankCode = WorkflowExpression.Compile(bankCode, nameof(bankCode), required: false);
            var __workflow_costCenterId = WorkflowExpression.Compile(costCenterId, nameof(costCenterId), required: false);
            var __workflow_payrollRegulationId = WorkflowExpression.Compile(payrollRegulationId, nameof(payrollRegulationId), required: false);
            var __workflow_workDate = WorkflowExpression.Compile(workDate, nameof(workDate), required: false);
            return new DeferredBodyAction<ResultIPageV2EmployeeResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/employee/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_englishName != null)
                    callPayload.Queries["englishName"] = ExpressionConverter.Convert(__workflow_englishName);
                if (__workflow_chineseName != null)
                    callPayload.Queries["chineseName"] = ExpressionConverter.Convert(__workflow_chineseName);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_countryCode != null)
                    callPayload.Queries["countryCode"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_phone != null)
                    callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_code != null)
                    callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_education != null)
                    callPayload.Queries["education"] = ExpressionConverter.Convert(__workflow_education);
                if (__workflow_departmentId != null)
                    callPayload.Queries["departmentId"] = ExpressionConverter.Convert(__workflow_departmentId);
                if (__workflow_positionId != null)
                    callPayload.Queries["positionId"] = ExpressionConverter.Convert(__workflow_positionId);
                if (__workflow_hireType != null)
                    callPayload.Queries["hireType"] = ExpressionConverter.Convert(__workflow_hireType);
                if (__workflow_bankCode != null)
                    callPayload.Queries["bankCode"] = ExpressionConverter.Convert(__workflow_bankCode);
                if (__workflow_costCenterId != null)
                    callPayload.Queries["costCenterId"] = ExpressionConverter.Convert(__workflow_costCenterId);
                if (__workflow_payrollRegulationId != null)
                    callPayload.Queries["payrollRegulationId"] = ExpressionConverter.Convert(__workflow_payrollRegulationId);
                if (__workflow_workDate != null)
                    callPayload.Queries["workDate"] = ExpressionConverter.Convert(__workflow_workDate);
                return new ApiConnectionAction<ResultIPageV2EmployeeResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2ExpenseResp, ApiConnectionActionConfiguration> GetExpenseApplicationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> reimbursementStatusFilter = null, Expression<Func<string>> reimbursementName = null, Expression<Func<string>> departmentFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_reimbursementStatusFilter = WorkflowExpression.Compile(reimbursementStatusFilter, nameof(reimbursementStatusFilter), required: false);
            var __workflow_reimbursementName = WorkflowExpression.Compile(reimbursementName, nameof(reimbursementName), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            return new DeferredBodyAction<ResultIPageV2ExpenseResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/getExpenseApplicationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_reimbursementStatusFilter != null)
                    callPayload.Queries["reimbursementStatusFilter"] = ExpressionConverter.Convert(__workflow_reimbursementStatusFilter);
                if (__workflow_reimbursementName != null)
                    callPayload.Queries["reimbursementName"] = ExpressionConverter.Convert(__workflow_reimbursementName);
                if (__workflow_departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(__workflow_departmentFilter);
                return new ApiConnectionAction<ResultIPageV2ExpenseResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2ExternalPayItemResp, ApiConnectionActionConfiguration> GetExtPayItemData(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> employeeCode = null, Expression<Func<string>> businessSalaryItemId = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> businessSalaryItemFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_employeeCode = WorkflowExpression.Compile(employeeCode, nameof(employeeCode), required: false);
            var __workflow_businessSalaryItemId = WorkflowExpression.Compile(businessSalaryItemId, nameof(businessSalaryItemId), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_businessSalaryItemFilter = WorkflowExpression.Compile(businessSalaryItemFilter, nameof(businessSalaryItemFilter), required: false);
            return new DeferredBodyAction<ResultIPageV2ExternalPayItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/getExtPayItemData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_employeeCode != null)
                    callPayload.Queries["employeeCode"] = ExpressionConverter.Convert(__workflow_employeeCode);
                if (__workflow_businessSalaryItemId != null)
                    callPayload.Queries["businessSalaryItemId"] = ExpressionConverter.Convert(__workflow_businessSalaryItemId);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_businessSalaryItemFilter != null)
                    callPayload.Queries["businessSalaryItemFilter"] = ExpressionConverter.Convert(__workflow_businessSalaryItemFilter);
                return new ApiConnectionAction<ResultIPageV2ExternalPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2ExtPayItemResp, ApiConnectionActionConfiguration> GetExtPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> paymentType = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_paymentType = WorkflowExpression.Compile(paymentType, nameof(paymentType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2ExtPayItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/getExtPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_paymentType != null)
                    callPayload.Queries["paymentType"] = ExpressionConverter.Convert(__workflow_paymentType);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ResultIPageV2ExtPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2FixedPayItemResp, ApiConnectionActionConfiguration> GetFixedPayItemData(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> payrollItemId = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_payrollItemId = WorkflowExpression.Compile(payrollItemId, nameof(payrollItemId), required: false);
            return new DeferredBodyAction<ResultIPageV2FixedPayItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/getFixedPayItemData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_payrollItemId != null)
                    callPayload.Queries["payrollItemId"] = ExpressionConverter.Convert(__workflow_payrollItemId);
                return new ApiConnectionAction<ResultIPageV2FixedPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2LabelResp, ApiConnectionActionConfiguration> GetLabelList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> labelCode = null, Expression<Func<string>> labelName = null, Expression<Func<int>> labelStatus = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_labelCode = WorkflowExpression.Compile(labelCode, nameof(labelCode), required: false);
            var __workflow_labelName = WorkflowExpression.Compile(labelName, nameof(labelName), required: false);
            var __workflow_labelStatus = WorkflowExpression.Compile(labelStatus, nameof(labelStatus), required: false);
            return new DeferredBodyAction<ResultIPageV2LabelResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/label/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_labelCode != null)
                    callPayload.Queries["labelCode"] = ExpressionConverter.Convert(__workflow_labelCode);
                if (__workflow_labelName != null)
                    callPayload.Queries["labelName"] = ExpressionConverter.Convert(__workflow_labelName);
                if (__workflow_labelStatus != null)
                    callPayload.Queries["labelStatus"] = ExpressionConverter.Convert(__workflow_labelStatus);
                return new ApiConnectionAction<ResultIPageV2LabelResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2LeaveApplicationResp, ApiConnectionActionConfiguration> GetLeaveApplicationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> holidayType = null, Expression<Func<string>> status = null, Expression<Func<string>> holidayDate = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_holidayType = WorkflowExpression.Compile(holidayType, nameof(holidayType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_holidayDate = WorkflowExpression.Compile(holidayDate, nameof(holidayDate), required: false);
            return new DeferredBodyAction<ResultIPageV2LeaveApplicationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/leave/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_holidayType != null)
                    callPayload.Queries["holidayType"] = ExpressionConverter.Convert(__workflow_holidayType);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_holidayDate != null)
                    callPayload.Queries["holidayDate"] = ExpressionConverter.Convert(__workflow_holidayDate);
                return new ApiConnectionAction<ResultIPageV2LeaveApplicationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2PayItemResp, ApiConnectionActionConfiguration> GetPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2PayItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/getPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ResultIPageV2PayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2PayrollPlanResp, ApiConnectionActionConfiguration> GetPayrunList(Expression<Func<string>> status, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV2PayrollPlanResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/getPayrunList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ResultIPageV2PayrollPlanResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2PositionResp, ApiConnectionActionConfiguration> GetPositionList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> positionCode = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_positionCode = WorkflowExpression.Compile(positionCode, nameof(positionCode), required: false);
            return new DeferredBodyAction<ResultIPageV2PositionResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/getPositionList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_positionCode != null)
                    callPayload.Queries["positionCode"] = ExpressionConverter.Convert(__workflow_positionCode);
                return new ApiConnectionAction<ResultIPageV2PositionResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV2RosterResp, ApiConnectionActionConfiguration> GetRosterDataList(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> englishName = null, Expression<Func<string>> code = null, Expression<Func<string>> surnameEnglish = null, Expression<Func<string>> personalNameEnglish = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_attendCalculationId = WorkflowExpression.Compile(attendCalculationId, nameof(attendCalculationId), required: false);
            var __workflow_departmentId = WorkflowExpression.Compile(departmentId, nameof(departmentId), required: false);
            var __workflow_positionId = WorkflowExpression.Compile(positionId, nameof(positionId), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_englishName = WorkflowExpression.Compile(englishName, nameof(englishName), required: false);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: false);
            var __workflow_surnameEnglish = WorkflowExpression.Compile(surnameEnglish, nameof(surnameEnglish), required: false);
            var __workflow_personalNameEnglish = WorkflowExpression.Compile(personalNameEnglish, nameof(personalNameEnglish), required: false);
            return new DeferredBodyAction<ResultListV2RosterResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/getRosterDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_attendCalculationId != null)
                    callPayload.Queries["attendCalculationId"] = ExpressionConverter.Convert(__workflow_attendCalculationId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_departmentId != null)
                    callPayload.Queries["departmentId"] = ExpressionConverter.Convert(__workflow_departmentId);
                if (__workflow_positionId != null)
                    callPayload.Queries["positionId"] = ExpressionConverter.Convert(__workflow_positionId);
                if (__workflow_statusFilter != null)
                    callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(__workflow_statusFilter);
                if (__workflow_englishName != null)
                    callPayload.Queries["englishName"] = ExpressionConverter.Convert(__workflow_englishName);
                if (__workflow_code != null)
                    callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_surnameEnglish != null)
                    callPayload.Queries["surnameEnglish"] = ExpressionConverter.Convert(__workflow_surnameEnglish);
                if (__workflow_personalNameEnglish != null)
                    callPayload.Queries["personalNameEnglish"] = ExpressionConverter.Convert(__workflow_personalNameEnglish);
                return new ApiConnectionAction<ResultListV2RosterResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV2TenantResp, ApiConnectionActionConfiguration> GetTenantInfo()
        {
            return new DeferredBodyAction<ResultV2TenantResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenant/getById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultV2TenantResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2TimesheetResp, ApiConnectionActionConfiguration> GetTimesheetList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> type = null, Expression<Func<string>> date = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2TimesheetResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/timesheet/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ResultIPageV2TimesheetResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2VarPayItemResp, ApiConnectionActionConfiguration> GetVarPayItemData(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> payrollItemId = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> payrollItemIdFilter = null, Expression<Func<string>> payrollPlanId = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_payrollItemId = WorkflowExpression.Compile(payrollItemId, nameof(payrollItemId), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_payrollItemIdFilter = WorkflowExpression.Compile(payrollItemIdFilter, nameof(payrollItemIdFilter), required: false);
            var __workflow_payrollPlanId = WorkflowExpression.Compile(payrollPlanId, nameof(payrollPlanId), required: false);
            return new DeferredBodyAction<ResultIPageV2VarPayItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/getVarPayItemData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_employeeId != null)
                    callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                if (__workflow_payrollItemId != null)
                    callPayload.Queries["payrollItemId"] = ExpressionConverter.Convert(__workflow_payrollItemId);
                if (__workflow_employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(__workflow_employeeIdFilter);
                if (__workflow_payrollItemIdFilter != null)
                    callPayload.Queries["payrollItemIdFilter"] = ExpressionConverter.Convert(__workflow_payrollItemIdFilter);
                if (__workflow_payrollPlanId != null)
                    callPayload.Queries["payrollPlanId"] = ExpressionConverter.Convert(__workflow_payrollPlanId);
                return new ApiConnectionAction<ResultIPageV2VarPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2WorkLocationResp, ApiConnectionActionConfiguration> GetWorkLocationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> attendanceAddressCode = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_attendanceAddressCode = WorkflowExpression.Compile(attendanceAddressCode, nameof(attendanceAddressCode), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2WorkLocationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/workLocation/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(__workflow_current);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_attendanceAddressCode != null)
                    callPayload.Queries["attendanceAddressCode"] = ExpressionConverter.Convert(__workflow_attendanceAddressCode);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<ResultIPageV2WorkLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateCardById(Expression<Func<UpdateCardByIdV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/attendance/updateCardById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateCostCenterInfo(Expression<Func<UpdateCostCenterInfoV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/updateCostCenterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateDepartmentInfo(Expression<Func<UpdateDepartmentInfoV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/department/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateEmployeeInfo(Expression<Func<UpdateEmployeeInfoV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/employee/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateExpenseApplication(Expression<Func<UpdateExpenseApplicationV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/updateExpenseApplication";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateExternalSalary(Expression<Func<UpdateExternalSalaryV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/updateExternalSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateFixedSalary(Expression<Func<UpdateFixedSalaryV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/updateFixedSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateLabelInfo(Expression<Func<UpdateLabelInfoV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/label/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateLeaveApplication(Expression<Func<UpdateLeaveApplicationV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/leave/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdatePositionInfo(Expression<Func<UpdatePositionInfoV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/updatePositionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateRosterData(Expression<Func<UpdateRosterDataV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenants/updateRosterData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateRosterItem(Expression<Func<UpdateRosterItemV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/attendance/updateRosterItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateShiftTemplate(Expression<Func<UpdateShiftTemplateV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/attendance/updateShiftTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateTenantInfo(Expression<Func<UpdateTenantInfoV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tenant/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateTimesheet(Expression<Func<UpdateTimesheetV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/timesheet/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateVarSalary(Expression<Func<UpdateVarSalaryV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/payroll/updateVarSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean, ApiConnectionActionConfiguration> UpdateWorkLocation(Expression<Func<UpdateWorkLocationV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ResultBoolean, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/workLocation/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }
    }

    public class WorkstemauTriggers([ConnectionName] string connectionId)
    {
    }

    public class ResultBoolean
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public bool Data { get; set; }
    }

    public class _001addFixedSalaryDataV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("payrollItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PayrollItemId { get; set; }

        [JsonProperty("money")]
        public double? Money { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("totalLimitAmount")]
        public double? TotalLimitAmount { get; set; }

        [JsonProperty("paidAmount")]
        public double? PaidAmount { get; set; }

        [JsonProperty("surplusAmount")]
        public double? SurplusAmount { get; set; }
    }

    public class ResultV3TenantResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3TenantResp Data { get; set; }
    }

    public class V3TenantResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("bmsId")]
        public string BmsId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("businessRegistrationNumber")]
        public string BusinessRegistrationNumber { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("realTimeZone")]
        public string RealTimeZone { get; set; }

        [JsonProperty("zoneName")]
        public string ZoneName { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankBranchCode")]
        public string BankBranchCode { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }

        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [JsonProperty("employerPosition")]
        public string EmployerPosition { get; set; }

        [JsonProperty("employerFileNumber")]
        public string EmployerFileNumber { get; set; }

        [JsonProperty("mainLanguage")]
        public string MainLanguage { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("paymentCode")]
        public string PaymentCode { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("legalNameOfEnterprise")]
        public string LegalNameOfEnterprise { get; set; }

        [JsonProperty("area")]
        public string Area { get; set; }

        [JsonProperty("is57ACompany")]
        public string Is57ACompany { get; set; }

        [JsonProperty("branchNum")]
        public string BranchNum { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        [JsonProperty("agencyBusinessNum")]
        public string AgencyBusinessNum { get; set; }

        [JsonProperty("registeredAgentNum")]
        public string RegisteredAgentNum { get; set; }

        [JsonProperty("agentContactName")]
        public string AgentContactName { get; set; }

        [JsonProperty("agentEmail")]
        public string AgentEmail { get; set; }

        [JsonProperty("agentTel")]
        public string AgentTel { get; set; }

        [JsonProperty("hasAgentCompany")]
        public string HasAgentCompany { get; set; }

        [JsonProperty("ausAbn")]
        public string AusAbn { get; set; }
    }

    public class ResultListV3SysEnterpriseUserResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3SysEnterpriseUserResp[] Data { get; set; }
    }

    public class V3SysEnterpriseUserResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("isEnabled")]
        public int IsEnabled { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("emailConfirmed")]
        public bool EmailConfirmed { get; set; }

        [JsonProperty("lastSendTime")]
        public string LastSendTime { get; set; }

        [JsonProperty("roleList")]
        public V3SysRoleResp[] RoleList { get; set; }
    }

    public class V3SysRoleResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isEnabled")]
        public int IsEnabled { get; set; }
    }

    public class ResultV3SysEnterpriseUserResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3SysEnterpriseUserResp Data { get; set; }
    }

    public class _003updateFixedSalaryDataByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("payrollItemId")]
        public string PayrollItemId { get; set; }

        [JsonProperty("money")]
        public double? Money { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("totalLimitAmount")]
        public double? TotalLimitAmount { get; set; }

        [JsonProperty("paidAmount")]
        public double? PaidAmount { get; set; }

        [JsonProperty("surplusAmount")]
        public double? SurplusAmount { get; set; }
    }

    public class _004addLocationInfoV3Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Longitude { get; set; }

        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Latitude { get; set; }

        [JsonProperty("region")]
        public int? Region { get; set; }

        [JsonProperty("isEnableGps")]
        public bool? IsEnableGps { get; set; }

        [JsonProperty("isEnableBluetooth")]
        public bool? IsEnableBluetooth { get; set; }

        [JsonProperty("attendanceAddressCode")]
        public string AttendanceAddressCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("mapType")]
        public string MapType { get; set; }

        [JsonProperty("areaCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AreaCode { get; set; }
    }

    public class ResultListV3PayrollFixedResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3PayrollFixedResp[] Data { get; set; }
    }

    public class V3PayrollFixedResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("payrollItemId")]
        public string PayrollItemId { get; set; }

        [JsonProperty("money")]
        public double Money { get; set; }

        [JsonProperty("payrollItemName")]
        public string PayrollItemName { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("totalLimitAmount")]
        public double TotalLimitAmount { get; set; }

        [JsonProperty("paidAmount")]
        public double PaidAmount { get; set; }

        [JsonProperty("surplusAmount")]
        public double SurplusAmount { get; set; }
    }

    public class _005addVariableSalaryDataV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("payrollItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PayrollItemId { get; set; }

        [JsonProperty("money", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Money { get; set; }

        [JsonProperty("payrollDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PayrollDate { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }
    }

    public class _006updateLocationByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("region")]
        public int? Region { get; set; }

        [JsonProperty("isEnableGps")]
        public bool? IsEnableGps { get; set; }

        [JsonProperty("isEnableBluetooth")]
        public bool? IsEnableBluetooth { get; set; }

        [JsonProperty("attendanceAddressCode")]
        public string AttendanceAddressCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("mapType")]
        public string MapType { get; set; }

        [JsonProperty("areaCode")]
        public string AreaCode { get; set; }
    }

    public class ResultIPageV3AttAddressResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3AttAddressResp Data { get; set; }
    }

    public class IPageV3AttAddressResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3AttAddressResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3AttAddressResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("isEnableGps")]
        public bool IsEnableGps { get; set; }

        [JsonProperty("isEnableBluetooth")]
        public bool IsEnableBluetooth { get; set; }

        [JsonProperty("attendanceAddressCode")]
        public string AttendanceAddressCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("mapType")]
        public string MapType { get; set; }

        [JsonProperty("areaCode")]
        public string AreaCode { get; set; }
    }

    public class _007updateVariableSalaryDataByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("money")]
        public double? Money { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultV3AttAddressResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AttAddressResp Data { get; set; }
    }

    public class ResultIPageV3PayrollNonFixedResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3PayrollNonFixedResp Data { get; set; }
    }

    public class IPageV3PayrollNonFixedResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3PayrollNonFixedResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3PayrollNonFixedResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("payrollItemId")]
        public string PayrollItemId { get; set; }

        [JsonProperty("money")]
        public double Money { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("payrollDate")]
        public string PayrollDate { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("payrollItemName")]
        public string PayrollItemName { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("payrollPlanId")]
        public string PayrollPlanId { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("payrollPlanName")]
        public string PayrollPlanName { get; set; }
    }

    public class _009addExternalSalaryDataV3Input
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("businessSalaryItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BusinessSalaryItemId { get; set; }

        [JsonProperty("money", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Money { get; set; }

        [JsonProperty("occurrenceDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OccurrenceDate { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class ResultV3AttRuleResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AttRuleResp Data { get; set; }
    }

    public class V3AttRuleResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("workLocation")]
        public string WorkLocation { get; set; }

        [JsonProperty("minIntervalTime")]
        public int MinIntervalTime { get; set; }

        [JsonProperty("shiftInRange")]
        public int ShiftInRange { get; set; }

        [JsonProperty("shiftOffRange")]
        public int ShiftOffRange { get; set; }

        [JsonProperty("beLateRange")]
        public int BeLateRange { get; set; }

        [JsonProperty("leaveEarlyRange")]
        public int LeaveEarlyRange { get; set; }

        [JsonProperty("workingHoursRounding")]
        public int WorkingHoursRounding { get; set; }

        [JsonProperty("shiftInStandard")]
        public bool ShiftInStandard { get; set; }

        [JsonProperty("shiftOffStandard")]
        public bool ShiftOffStandard { get; set; }

        [JsonProperty("scheduleTemplate")]
        public string ScheduleTemplate { get; set; }

        [JsonProperty("whetherUpdateClock")]
        public bool WhetherUpdateClock { get; set; }

        [JsonProperty("prohibitClockingInOutsideTheOpenRange")]
        public bool ProhibitClockingInOutsideTheOpenRange { get; set; }
    }

    public class _010addDepartmentInfoV3Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class _011updateExternalSalaryDataByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("businessSalaryItemId")]
        public string BusinessSalaryItemId { get; set; }

        [JsonProperty("money")]
        public double? Money { get; set; }

        [JsonProperty("occurrenceDate")]
        public string OccurrenceDate { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class ResultIPageV3ExternalPayrollResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3ExternalPayrollResp Data { get; set; }
    }

    public class IPageV3ExternalPayrollResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3ExternalPayrollResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3ExternalPayrollResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeCode")]
        public string EmployeeCode { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("businessSalaryItemId")]
        public string BusinessSalaryItemId { get; set; }

        [JsonProperty("money")]
        public double Money { get; set; }

        [JsonProperty("occurrenceDate")]
        public string OccurrenceDate { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class _012updateDepartmentByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class ResultIPageV3DepartmentResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3DepartmentResp Data { get; set; }
    }

    public class IPageV3DepartmentResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3DepartmentResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3DepartmentResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("parentName")]
        public string ParentName { get; set; }
    }

    public class ResultIPageV3PayrollPlanResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3PayrollPlanResp Data { get; set; }
    }

    public class IPageV3PayrollPlanResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3PayrollPlanResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3PayrollPlanResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("periodStartDate")]
        public string PeriodStartDate { get; set; }

        [JsonProperty("periodEndDate")]
        public string PeriodEndDate { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("actualSalary")]
        public double ActualSalary { get; set; }

        [JsonProperty("payrollDate")]
        public string PayrollDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("attendCalculationStartDate")]
        public string AttendCalculationStartDate { get; set; }

        [JsonProperty("attendCalculationEndDate")]
        public string AttendCalculationEndDate { get; set; }

        [JsonProperty("timeDefinedFlag")]
        public bool TimeDefinedFlag { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("isIncludeBasicSalary")]
        public bool IsIncludeBasicSalary { get; set; }

        [JsonProperty("isIncludeNonFixedSalary")]
        public bool IsIncludeNonFixedSalary { get; set; }

        [JsonProperty("isIncludeAttendCalculation")]
        public bool IsIncludeAttendCalculation { get; set; }

        [JsonProperty("isIncludeLeaveSalary")]
        public bool IsIncludeLeaveSalary { get; set; }

        [JsonProperty("isIncludeFixedSalary")]
        public bool IsIncludeFixedSalary { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("step")]
        public int Step { get; set; }

        [JsonProperty("isAutoLoadStaff")]
        public bool IsAutoLoadStaff { get; set; }

        [JsonProperty("payrollTimeType")]
        public string PayrollTimeType { get; set; }

        [JsonProperty("temporaryOperationName")]
        public string TemporaryOperationName { get; set; }

        [JsonProperty("employeeScopeType")]
        public string EmployeeScopeType { get; set; }

        [JsonProperty("degreeStr")]
        public string DegreeStr { get; set; }

        [JsonProperty("payrollPeriodId")]
        public string PayrollPeriodId { get; set; }
    }

    public class _014addPositionInfoV3Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultIPageV3PayrollPlanDetailResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3PayrollPlanDetailResp Data { get; set; }
    }

    public class IPageV3PayrollPlanDetailResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3PayrollPlanDetailResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3PayrollPlanDetailResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("payrollPlanId")]
        public string PayrollPlanId { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("paymentDate")]
        public string PaymentDate { get; set; }

        [JsonProperty("paymentMode")]
        public string PaymentMode { get; set; }
    }

    public class ResultListV3PayrollPlanDetailResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3PayrollPlanDetailResp[] Data { get; set; }
    }

    public class ResultIPageV3PayrollRegResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3PayrollRegResp Data { get; set; }
    }

    public class IPageV3PayrollRegResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3PayrollRegResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3PayrollRegResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payrollType")]
        public string PayrollType { get; set; }

        [JsonProperty("totalDays")]
        public string TotalDays { get; set; }

        [JsonProperty("firstDay")]
        public string FirstDay { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("isDefaultInPayrollRegulation")]
        public bool IsDefaultInPayrollRegulation { get; set; }

        [JsonProperty("payrollTimeType")]
        public string PayrollTimeType { get; set; }

        [JsonProperty("firstPeriodStartDate")]
        public string FirstPeriodStartDate { get; set; }

        [JsonProperty("payrollPolicyId")]
        public string PayrollPolicyId { get; set; }
    }

    public class _016updatePositionByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultV3PayrollRegResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3PayrollRegResp Data { get; set; }
    }

    public class ResultIPageV3PositionResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3PositionResp Data { get; set; }
    }

    public class IPageV3PositionResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3PositionResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3PositionResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class _018addCostCenterInfoV3Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultIPageV3PayrollItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3PayrollItemResp Data { get; set; }
    }

    public class IPageV3PayrollItemResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3PayrollItemResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3PayrollItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("payrollItemTypeId")]
        public string PayrollItemTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("carryRule")]
        public string CarryRule { get; set; }

        [JsonProperty("decimalDigits")]
        public int DecimalDigits { get; set; }

        [JsonProperty("taxIncomeId")]
        public string TaxIncomeId { get; set; }

        [JsonProperty("socialSecurityIncomeId")]
        public string SocialSecurityIncomeId { get; set; }

        [JsonProperty("averagePayrollIncomeId")]
        public string AveragePayrollIncomeId { get; set; }

        [JsonProperty("isBuildIn")]
        public string IsBuildIn { get; set; }

        [JsonProperty("payrollItemDefaultId")]
        public string PayrollItemDefaultId { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("isExistRegulationRules")]
        public bool IsExistRegulationRules { get; set; }

        [JsonProperty("regulationRules")]
        public string RegulationRules { get; set; }

        [JsonProperty("step")]
        public int Step { get; set; }

        [JsonProperty("payrollRegulationIdSet")]
        public string PayrollRegulationIdSet { get; set; }

        [JsonProperty("calculationOrder")]
        public string CalculationOrder { get; set; }

        [JsonProperty("regulationRulesAlias")]
        public string RegulationRulesAlias { get; set; }

        [JsonProperty("isEditable")]
        public bool IsEditable { get; set; }

        [JsonProperty("zoneOfApplication")]
        public string ZoneOfApplication { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("limitRules")]
        public string LimitRules { get; set; }

        [JsonProperty("salaryElement")]
        public string SalaryElement { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("ratio")]
        public string Ratio { get; set; }

        [JsonProperty("payrollItemTypeName")]
        public string PayrollItemTypeName { get; set; }
    }

    public class ResultV3PayrollItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3PayrollItemResp Data { get; set; }
    }

    public class ResultV3AddEmployeeResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AddEmployeeResp Data { get; set; }
    }

    public class V3AddEmployeeResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class _01addEmployeeInfoV3Input
    {
        [JsonProperty("entryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryDate { get; set; }

        [JsonProperty("englishName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnglishName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("employeeStatus")]
        public string EmployeeStatus { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("basicPay")]
        public double? BasicPay { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("identityCard")]
        public string IdentityCard { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("surnameEnglish")]
        public string SurnameEnglish { get; set; }

        [JsonProperty("personalNameEnglish")]
        public string PersonalNameEnglish { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName { get; set; }

        [JsonProperty("emergencyContactRelation")]
        public string EmergencyContactRelation { get; set; }

        [JsonProperty("emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("bankBranchNumber")]
        public string BankBranchNumber { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("date1")]
        public string Date1 { get; set; }

        [JsonProperty("date2")]
        public string Date2 { get; set; }

        [JsonProperty("date3")]
        public string Date3 { get; set; }

        [JsonProperty("date4")]
        public string Date4 { get; set; }

        [JsonProperty("text1")]
        public string Text1 { get; set; }

        [JsonProperty("text2")]
        public string Text2 { get; set; }

        [JsonProperty("text3")]
        public string Text3 { get; set; }

        [JsonProperty("text4")]
        public string Text4 { get; set; }

        [JsonProperty("text5")]
        public string Text5 { get; set; }

        [JsonProperty("text6")]
        public string Text6 { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("mobileCardCalType")]
        public string MobileCardCalType { get; set; }

        [JsonProperty("regularType")]
        public string RegularType { get; set; }

        [JsonProperty("insurePlanName")]
        public string InsurePlanName { get; set; }

        [JsonProperty("bizLabelIds")]
        public string BizLabelIds { get; set; }
    }

    public class _01addLeaveBalanceAdjustInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("holidayType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HolidayType { get; set; }

        [JsonProperty("occurrenceTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OccurrenceTime { get; set; }

        [JsonProperty("cause", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Cause { get; set; }

        [JsonProperty("adjust", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Adjust { get; set; }
    }

    public class _01addRosterInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("attendDay", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttendDay { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("shiftIn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftOff { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("shiftStatus")]
        public string ShiftStatus { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("hourlyRate")]
        public double? HourlyRate { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("tierRate")]
        public double? TierRate { get; set; }

        [JsonProperty("scheduledAmount")]
        public double? ScheduledAmount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultV3CalAttendanceResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3CalAttendanceResp Data { get; set; }
    }

    public class V3CalAttendanceResp
    {
        [JsonProperty("calId")]
        public string CalId { get; set; }
    }

    public class _01attendanceSummaryCalculateV3Input
    {
        [JsonProperty("startDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }

        [JsonProperty("endDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndDate { get; set; }

        [JsonProperty("employeeIds")]
        public string[] EmployeeIds { get; set; }

        [JsonProperty("departmentIds")]
        public string[] DepartmentIds { get; set; }

        [JsonProperty("positionIds")]
        public string[] PositionIds { get; set; }
    }

    public class ResultV3BizAttendanceConfigureResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3BizAttendanceConfigureResp Data { get; set; }
    }

    public class V3BizAttendanceConfigureResp
    {
        [JsonProperty("isAllowViewSchedule")]
        public bool IsAllowViewSchedule { get; set; }

        [JsonProperty("isAllowViewLeave")]
        public bool IsAllowViewLeave { get; set; }

        [JsonProperty("isAllowSubstitute")]
        public bool IsAllowSubstitute { get; set; }

        [JsonProperty("isAllowEmployeeEditDevice")]
        public bool IsAllowEmployeeEditDevice { get; set; }

        [JsonProperty("isAllowCreateCode")]
        public bool IsAllowCreateCode { get; set; }

        [JsonProperty("isEnableFieldWork")]
        public bool IsEnableFieldWork { get; set; }

        [JsonProperty("isEnableDeviceBind")]
        public bool IsEnableDeviceBind { get; set; }

        [JsonProperty("attendanceManageOpenshift")]
        public bool AttendanceManageOpenshift { get; set; }

        [JsonProperty("attendanceManageProjectPro")]
        public bool AttendanceManageProjectPro { get; set; }

        [JsonProperty("workingBreakPairing")]
        public bool WorkingBreakPairing { get; set; }

        [JsonProperty("forceOpenshiftSchedule")]
        public bool ForceOpenshiftSchedule { get; set; }
    }

    public class ResultIPageV3BizReimbursementTypeResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3BizReimbursementTypeResp Data { get; set; }
    }

    public class IPageV3BizReimbursementTypeResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3BizReimbursementTypeResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3BizReimbursementTypeResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ResultIPageV3ExternalPayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3ExternalPayItemResp Data { get; set; }
    }

    public class IPageV3ExternalPayItemResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3ExternalPayItemResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3ExternalPayItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customItemTypeId")]
        public string CustomItemTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("carryRule")]
        public string CarryRule { get; set; }

        [JsonProperty("decimalDigits")]
        public int DecimalDigits { get; set; }

        [JsonProperty("formulaAlias")]
        public string FormulaAlias { get; set; }
    }

    public class _020updateCostCenterByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultIPageV3CostCenterResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3CostCenterResp Data { get; set; }
    }

    public class IPageV3CostCenterResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3CostCenterResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3CostCenterResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultV3ExternalPayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3ExternalPayItemResp Data { get; set; }
    }

    public class _022addTagInfoV3Input
    {
        [JsonProperty("labelCode")]
        public string LabelCode { get; set; }

        [JsonProperty("labelName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LabelName { get; set; }

        [JsonProperty("labelStatus")]
        public int? LabelStatus { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class _022addWorkPatternInfoV3Input
    {
        [JsonProperty("advancedSetting")]
        public string AdvancedSetting { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("workHoursForDay", DefaultValueHandling = DefaultValueHandling.Include)]
        public double WorkHoursForDay { get; set; }

        [JsonProperty("workHoursForWeek", DefaultValueHandling = DefaultValueHandling.Include)]
        public double WorkHoursForWeek { get; set; }

        [JsonProperty("workHoursForYear", DefaultValueHandling = DefaultValueHandling.Include)]
        public double WorkHoursForYear { get; set; }

        [JsonProperty("totalHours", DefaultValueHandling = DefaultValueHandling.Include)]
        public double TotalHours { get; set; }

        [JsonProperty("cycleType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CycleType { get; set; }

        [JsonProperty("fte")]
        public string Fte { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("salaryCalculationStyle")]
        public int? SalaryCalculationStyle { get; set; }

        [JsonProperty("workTime")]
        public int? WorkTime { get; set; }

        [JsonProperty("doubleWeekBaseDate")]
        public string DoubleWeekBaseDate { get; set; }

        [JsonProperty("weekSalaryType")]
        public string WeekSalaryType { get; set; }

        [JsonProperty("isThisWeek")]
        public int? IsThisWeek { get; set; }

        [JsonProperty("settingList")]
        public V3TermsSettingInsert[] SettingList { get; set; }
    }

    public class V3TermsSettingInsert
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("workHours")]
        public double WorkHours { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("daySign")]
        public string DaySign { get; set; }
    }

    public class _023updateWorkPatternByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("advancedSetting")]
        public string AdvancedSetting { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workHoursForDay")]
        public double? WorkHoursForDay { get; set; }

        [JsonProperty("workHoursForWeek")]
        public double? WorkHoursForWeek { get; set; }

        [JsonProperty("workHoursForYear")]
        public double? WorkHoursForYear { get; set; }

        [JsonProperty("totalHours")]
        public double? TotalHours { get; set; }

        [JsonProperty("cycleType")]
        public string CycleType { get; set; }

        [JsonProperty("fte")]
        public string Fte { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("salaryCalculationStyle")]
        public int? SalaryCalculationStyle { get; set; }

        [JsonProperty("workTime")]
        public int? WorkTime { get; set; }

        [JsonProperty("doubleWeekBaseDate")]
        public string DoubleWeekBaseDate { get; set; }

        [JsonProperty("weekSalaryType")]
        public string WeekSalaryType { get; set; }

        [JsonProperty("isThisWeek")]
        public int? IsThisWeek { get; set; }

        [JsonProperty("termsWorkDefaultId")]
        public string TermsWorkDefaultId { get; set; }

        [JsonProperty("settingList")]
        public V3TermsSettingUpdate[] SettingList { get; set; }
    }

    public class V3TermsSettingUpdate
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("workHours")]
        public double WorkHours { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("daySign")]
        public string DaySign { get; set; }
    }

    public class _024updateTagByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("labelCode")]
        public string LabelCode { get; set; }

        [JsonProperty("labelName")]
        public string LabelName { get; set; }

        [JsonProperty("labelStatus")]
        public int? LabelStatus { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class ResultIPageV3LabelResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LabelResp Data { get; set; }
    }

    public class IPageV3LabelResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LabelResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LabelResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("labelCode")]
        public string LabelCode { get; set; }

        [JsonProperty("labelName")]
        public string LabelName { get; set; }

        [JsonProperty("labelStatus")]
        public int LabelStatus { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("parentName")]
        public string ParentName { get; set; }
    }

    public class ResultIPageV3WorkPatternSummaryResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3WorkPatternSummaryResp Data { get; set; }
    }

    public class IPageV3WorkPatternSummaryResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3WorkPatternSummaryResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3WorkPatternSummaryResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workHoursForDay")]
        public double WorkHoursForDay { get; set; }

        [JsonProperty("workHoursForWeek")]
        public double WorkHoursForWeek { get; set; }

        [JsonProperty("workHoursForYear")]
        public double WorkHoursForYear { get; set; }

        [JsonProperty("totalHours")]
        public double TotalHours { get; set; }

        [JsonProperty("cycleType")]
        public string CycleType { get; set; }

        [JsonProperty("fte")]
        public string Fte { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultIPageV3DeviceResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3DeviceResp Data { get; set; }
    }

    public class IPageV3DeviceResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3DeviceResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3DeviceResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        [JsonProperty("major")]
        public string Major { get; set; }

        [JsonProperty("minor")]
        public string Minor { get; set; }

        [JsonProperty("isRestrictLocation")]
        public string IsRestrictLocation { get; set; }

        [JsonProperty("addressId")]
        public string AddressId { get; set; }

        [JsonProperty("addressName")]
        public string AddressName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }
    }

    public class ResultV3WorkPatternResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3WorkPatternResp Data { get; set; }
    }

    public class V3WorkPatternResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workHoursForDay")]
        public double WorkHoursForDay { get; set; }

        [JsonProperty("workHoursForWeek")]
        public double WorkHoursForWeek { get; set; }

        [JsonProperty("workHoursForYear")]
        public double WorkHoursForYear { get; set; }

        [JsonProperty("totalHours")]
        public double TotalHours { get; set; }

        [JsonProperty("cycleType")]
        public string CycleType { get; set; }

        [JsonProperty("fte")]
        public string Fte { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("salaryCalculationStyle")]
        public int SalaryCalculationStyle { get; set; }

        [JsonProperty("workTime")]
        public int WorkTime { get; set; }

        [JsonProperty("doubleWeekBaseDate")]
        public string DoubleWeekBaseDate { get; set; }

        [JsonProperty("weekSalaryType")]
        public string WeekSalaryType { get; set; }

        [JsonProperty("isThisWeek")]
        public int IsThisWeek { get; set; }

        [JsonProperty("advancedSetting")]
        public string AdvancedSetting { get; set; }

        [JsonProperty("isInternal")]
        public bool IsInternal { get; set; }

        [JsonProperty("termsWorkDefaultId")]
        public string TermsWorkDefaultId { get; set; }

        [JsonProperty("settingList")]
        public V3TermsSettingResp[] SettingList { get; set; }
    }

    public class V3TermsSettingResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("workHours")]
        public double WorkHours { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("termsWorkId")]
        public string TermsWorkId { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }

        [JsonProperty("daySign")]
        public string DaySign { get; set; }

        [JsonProperty("workPlaceId")]
        public string WorkPlaceId { get; set; }

        [JsonProperty("salaryProject")]
        public string SalaryProject { get; set; }

        [JsonProperty("salaryType")]
        public int SalaryType { get; set; }

        [JsonProperty("shiftTemplateName")]
        public string ShiftTemplateName { get; set; }

        [JsonProperty("salaryProjectName")]
        public string SalaryProjectName { get; set; }

        [JsonProperty("workPlaceName")]
        public string WorkPlaceName { get; set; }
    }

    public class ResultV3BizReimbursementInsertResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3BizReimbursementInsertResp Data { get; set; }
    }

    public class V3BizReimbursementInsertResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("reimbursementType")]
        public string ReimbursementType { get; set; }

        [JsonProperty("reimbursementTypeName")]
        public string ReimbursementTypeName { get; set; }

        [JsonProperty("reimbursementDate")]
        public string ReimbursementDate { get; set; }

        [JsonProperty("reimbursementName")]
        public string ReimbursementName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }
    }

    public class _02addExpenseApplicationInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("reimbursementType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReimbursementType { get; set; }

        [JsonProperty("reimbursementDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReimbursementDate { get; set; }

        [JsonProperty("reimbursementName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReimbursementName { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class _02batchSaveRosterInfoV3Input
    {
        [JsonProperty("employeeIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] EmployeeIds { get; set; }

        [JsonProperty("dates", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Dates { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("shiftIn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftOff { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("shiftStatus")]
        public string ShiftStatus { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("hourlyRate")]
        public double? HourlyRate { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("replaceOriginal")]
        public bool? ReplaceOriginal { get; set; }
    }

    public class ResultIPageV3AttendanceListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3AttendanceListResp Data { get; set; }
    }

    public class IPageV3AttendanceListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3AttendanceListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3AttendanceListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("shiftLabor")]
        public double ShiftLabor { get; set; }

        [JsonProperty("laborLength")]
        public double LaborLength { get; set; }

        [JsonProperty("workingOvertime")]
        public double WorkingOvertime { get; set; }

        [JsonProperty("dayOffOvertime")]
        public double DayOffOvertime { get; set; }

        [JsonProperty("holidayOvertime")]
        public double HolidayOvertime { get; set; }

        [JsonProperty("beLateLength")]
        public double BeLateLength { get; set; }

        [JsonProperty("leaveEarlyLength")]
        public double LeaveEarlyLength { get; set; }

        [JsonProperty("leaveTime")]
        public double LeaveTime { get; set; }

        [JsonProperty("absenceLength")]
        public double AbsenceLength { get; set; }

        [JsonProperty("adjust")]
        public double Adjust { get; set; }
    }

    public class ResultListV3BizCustomizeDictionaryResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3BizCustomizeDictionaryResp[] Data { get; set; }
    }

    public class V3BizCustomizeDictionaryResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("isInternal")]
        public bool IsInternal { get; set; }

        [JsonProperty("area")]
        public string Area { get; set; }
    }

    public class ResultListV3BizCustomizeDictionaryItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3BizCustomizeDictionaryItemResp[] Data { get; set; }
    }

    public class V3BizCustomizeDictionaryItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("addedValue1")]
        public string AddedValue1 { get; set; }

        [JsonProperty("addedValue2")]
        public string AddedValue2 { get; set; }

        [JsonProperty("addedValue3")]
        public string AddedValue3 { get; set; }

        [JsonProperty("addedValue4")]
        public string AddedValue4 { get; set; }

        [JsonProperty("addedValue5")]
        public string AddedValue5 { get; set; }

        [JsonProperty("mpfCode")]
        public string MpfCode { get; set; }

        [JsonProperty("isEnable")]
        public bool IsEnable { get; set; }
    }

    public class ResultListV3AttendanceDetailListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AttendanceDetailListResp[] Data { get; set; }
    }

    public class V3AttendanceDetailListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dataStatus")]
        public string DataStatus { get; set; }

        [JsonProperty("attendDay")]
        public string AttendDay { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("actualIn")]
        public string ActualIn { get; set; }

        [JsonProperty("actualOff")]
        public string ActualOff { get; set; }

        [JsonProperty("workingOvertime")]
        public double WorkingOvertime { get; set; }

        [JsonProperty("holidayOvertime")]
        public double HolidayOvertime { get; set; }

        [JsonProperty("dayOffOvertime")]
        public double DayOffOvertime { get; set; }

        [JsonProperty("beLateLength")]
        public double BeLateLength { get; set; }

        [JsonProperty("leaveEarlyLength")]
        public double LeaveEarlyLength { get; set; }

        [JsonProperty("leaveTime")]
        public double LeaveTime { get; set; }

        [JsonProperty("adjust")]
        public double Adjust { get; set; }

        [JsonProperty("afterAdjust")]
        public double AfterAdjust { get; set; }

        [JsonProperty("attendStatus")]
        public string AttendStatus { get; set; }
    }

    public class ResultIPageV3LeaveHolidayBalanceResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LeaveHolidayBalanceResp Data { get; set; }
    }

    public class IPageV3LeaveHolidayBalanceResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LeaveHolidayBalanceResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LeaveHolidayBalanceResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("holidayRule")]
        public string HolidayRule { get; set; }

        [JsonProperty("occurrenceTime")]
        public string OccurrenceTime { get; set; }

        [JsonProperty("recordId")]
        public string RecordId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("adjust")]
        public string Adjust { get; set; }

        [JsonProperty("afterAdjust")]
        public string AfterAdjust { get; set; }
    }

    public class _03updateEmployeeByIdV3Input
    {
        [JsonProperty("entryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryDate { get; set; }

        [JsonProperty("englishName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnglishName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("employeeStatus")]
        public string EmployeeStatus { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("basicPay")]
        public double? BasicPay { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("identityCard")]
        public string IdentityCard { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("surnameEnglish")]
        public string SurnameEnglish { get; set; }

        [JsonProperty("personalNameEnglish")]
        public string PersonalNameEnglish { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName { get; set; }

        [JsonProperty("emergencyContactRelation")]
        public string EmergencyContactRelation { get; set; }

        [JsonProperty("emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("bankBranchNumber")]
        public string BankBranchNumber { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("date1")]
        public string Date1 { get; set; }

        [JsonProperty("date2")]
        public string Date2 { get; set; }

        [JsonProperty("date3")]
        public string Date3 { get; set; }

        [JsonProperty("date4")]
        public string Date4 { get; set; }

        [JsonProperty("text1")]
        public string Text1 { get; set; }

        [JsonProperty("text2")]
        public string Text2 { get; set; }

        [JsonProperty("text3")]
        public string Text3 { get; set; }

        [JsonProperty("text4")]
        public string Text4 { get; set; }

        [JsonProperty("text5")]
        public string Text5 { get; set; }

        [JsonProperty("text6")]
        public string Text6 { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("mobileCardCalType")]
        public string MobileCardCalType { get; set; }

        [JsonProperty("regularType")]
        public string RegularType { get; set; }

        [JsonProperty("insurePlanName")]
        public string InsurePlanName { get; set; }

        [JsonProperty("bizLabelIds")]
        public string BizLabelIds { get; set; }
    }

    public class ResultV3AddMobileCardResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AddMobileCardResp Data { get; set; }
    }

    public class V3AddMobileCardResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class _04addAttendanceDataInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Mode { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("actualLongitude")]
        public double? ActualLongitude { get; set; }

        [JsonProperty("actualLatitude")]
        public double? ActualLatitude { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("codeSource")]
        public string CodeSource { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("workLocationId")]
        public string WorkLocationId { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }

    public class _04calculationLeaveBalanceV3Input
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("isForceCal")]
        public bool? IsForceCal { get; set; }

        [JsonProperty("employeeIdsList")]
        public string[] EmployeeIdsList { get; set; }

        [JsonProperty("position")]
        public string[] Position { get; set; }

        [JsonProperty("dept")]
        public string[] Dept { get; set; }
    }

    public class ResultIPageV3BizEmployeeCustomizationResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3BizEmployeeCustomizationResp Data { get; set; }
    }

    public class IPageV3BizEmployeeCustomizationResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3BizEmployeeCustomizationResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3BizEmployeeCustomizationResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("projectType")]
        public string ProjectType { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("formulaAlias")]
        public string FormulaAlias { get; set; }

        [JsonProperty("dictionaryType")]
        public string DictionaryType { get; set; }

        [JsonProperty("dictionaryCode")]
        public string DictionaryCode { get; set; }

        [JsonProperty("dictionaryTypeName")]
        public string DictionaryTypeName { get; set; }
    }

    public class ResultIPageV3EmployeeListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3EmployeeListResp Data { get; set; }
    }

    public class IPageV3EmployeeListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3EmployeeListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3EmployeeListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("headFile")]
        public string HeadFile { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("surnameEnglish")]
        public string SurnameEnglish { get; set; }

        [JsonProperty("personalNameEnglish")]
        public string PersonalNameEnglish { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("directSupervisorEnglishName")]
        public string DirectSupervisorEnglishName { get; set; }

        [JsonProperty("directSupervisorCode")]
        public string DirectSupervisorCode { get; set; }

        [JsonProperty("entryDate")]
        public string EntryDate { get; set; }

        [JsonProperty("lastWorkingDate")]
        public string LastWorkingDate { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("attendCalculationName")]
        public string AttendCalculationName { get; set; }

        [JsonProperty("attendCalculationCode")]
        public string AttendCalculationCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("regularType")]
        public string RegularType { get; set; }

        [JsonProperty("regularTypeName")]
        public string RegularTypeName { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("payrollRegulationName")]
        public string PayrollRegulationName { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }
    }

    public class _04updateExpenseApplicationByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("reimbursementType")]
        public string ReimbursementType { get; set; }

        [JsonProperty("reimbursementDate")]
        public string ReimbursementDate { get; set; }

        [JsonProperty("reimbursementName")]
        public string ReimbursementName { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class _04updateRosterInfoByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("shiftIn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftOff { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("shiftStatus")]
        public string ShiftStatus { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("hourlyRate")]
        public double? HourlyRate { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("tierRate")]
        public double? TierRate { get; set; }

        [JsonProperty("scheduledAmount")]
        public double? ScheduledAmount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultV3BizEmployeeCustomizationResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3BizEmployeeCustomizationResp Data { get; set; }
    }

    public class ResultV3EmployeeInfoResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3EmployeeInfoResp Data { get; set; }
    }

    public class V3EmployeeInfoResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("identityCard")]
        public string IdentityCard { get; set; }

        [JsonProperty("bankCard")]
        public string BankCard { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("flag")]
        public int Flag { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("expectedArea")]
        public string ExpectedArea { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("arrivalDate")]
        public string ArrivalDate { get; set; }

        [JsonProperty("salary")]
        public int Salary { get; set; }

        [JsonProperty("education")]
        public string Education { get; set; }

        [JsonProperty("comApplication")]
        public string ComApplication { get; set; }

        [JsonProperty("otherApplication")]
        public string OtherApplication { get; set; }

        [JsonProperty("chineseTyping")]
        public string ChineseTyping { get; set; }

        [JsonProperty("chineseOther")]
        public string ChineseOther { get; set; }

        [JsonProperty("englishTyping")]
        public string EnglishTyping { get; set; }

        [JsonProperty("chineseWpm")]
        public int ChineseWpm { get; set; }

        [JsonProperty("englishWpm")]
        public int EnglishWpm { get; set; }

        [JsonProperty("cantonese")]
        public string Cantonese { get; set; }

        [JsonProperty("english")]
        public string English { get; set; }

        [JsonProperty("mandarin")]
        public string Mandarin { get; set; }

        [JsonProperty("otherLanguage")]
        public string OtherLanguage { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("entryDate")]
        public string EntryDate { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("directSupervisorEnglishName")]
        public string DirectSupervisorEnglishName { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("attendCalculationName")]
        public string AttendCalculationName { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("basicPay")]
        public double BasicPay { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("takeEffectDate")]
        public string TakeEffectDate { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName { get; set; }

        [JsonProperty("emergencyContactRelation")]
        public string EmergencyContactRelation { get; set; }

        [JsonProperty("emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankBranchNumber")]
        public string BankBranchNumber { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }

        [JsonProperty("lastWorkingDate")]
        public string LastWorkingDate { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("regularType")]
        public string RegularType { get; set; }

        [JsonProperty("regularTypeName")]
        public string RegularTypeName { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("payrollRegulationName")]
        public string PayrollRegulationName { get; set; }

        [JsonProperty("identityCardHk")]
        public string IdentityCardHk { get; set; }

        [JsonProperty("passportNumber")]
        public string PassportNumber { get; set; }

        [JsonProperty("passportIssuingPlace")]
        public string PassportIssuingPlace { get; set; }

        [JsonProperty("spouseName")]
        public string SpouseName { get; set; }

        [JsonProperty("spouseIdentityCardHk")]
        public string SpouseIdentityCardHk { get; set; }

        [JsonProperty("spousePassportNumber")]
        public string SpousePassportNumber { get; set; }

        [JsonProperty("spousePassportIssuingPlace")]
        public string SpousePassportIssuingPlace { get; set; }

        [JsonProperty("postalAddress")]
        public string PostalAddress { get; set; }

        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [JsonProperty("reasonsLeave")]
        public string ReasonsLeave { get; set; }

        [JsonProperty("isForDeparture")]
        public string IsForDeparture { get; set; }

        [JsonProperty("hometown")]
        public string Hometown { get; set; }

        [JsonProperty("nation")]
        public string Nation { get; set; }

        [JsonProperty("politicalStatus")]
        public string PoliticalStatus { get; set; }

        [JsonProperty("highestEducation")]
        public string HighestEducation { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("probation")]
        public string Probation { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("isForeignNationality")]
        public bool IsForeignNationality { get; set; }

        [JsonProperty("domicileLocation")]
        public string DomicileLocation { get; set; }

        [JsonProperty("certificateType")]
        public string CertificateType { get; set; }

        [JsonProperty("certificateNumber")]
        public string CertificateNumber { get; set; }

        [JsonProperty("isMartyrDependents")]
        public bool IsMartyrDependents { get; set; }

        [JsonProperty("occupationTaxNumber")]
        public string OccupationTaxNumber { get; set; }

        [JsonProperty("nonLocalBlueCardNumber")]
        public string NonLocalBlueCardNumber { get; set; }

        [JsonProperty("isForeignEmployees")]
        public bool IsForeignEmployees { get; set; }

        [JsonProperty("weeklyLeaveWorkAgreement")]
        public string WeeklyLeaveWorkAgreement { get; set; }

        [JsonProperty("workHours")]
        public double WorkHours { get; set; }

        [JsonProperty("employeeType")]
        public string EmployeeType { get; set; }

        [JsonProperty("jobLevel")]
        public string JobLevel { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("salaryScale")]
        public string SalaryScale { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("recruitmentSource")]
        public string RecruitmentSource { get; set; }

        [JsonProperty("graduatedSchool")]
        public string GraduatedSchool { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("calculateSalaryTypeText")]
        public string CalculateSalaryTypeText { get; set; }

        [JsonProperty("hireTypeText")]
        public string HireTypeText { get; set; }

        [JsonProperty("termsOfWork")]
        public string TermsOfWork { get; set; }

        [JsonProperty("totalHours")]
        public double TotalHours { get; set; }

        [JsonProperty("payrollPackageFte")]
        public double PayrollPackageFte { get; set; }

        [JsonProperty("payrollPackageProData")]
        public double PayrollPackageProData { get; set; }

        [JsonProperty("hourlyWagePercent")]
        public double HourlyWagePercent { get; set; }

        [JsonProperty("terminationCompensationDate")]
        public string TerminationCompensationDate { get; set; }

        [JsonProperty("terminationEmployedLength")]
        public double TerminationEmployedLength { get; set; }

        [JsonProperty("ageOfTermination")]
        public int AgeOfTermination { get; set; }

        [JsonProperty("appellation")]
        public string Appellation { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("officePhone")]
        public string OfficePhone { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("contractEndDate")]
        public string ContractEndDate { get; set; }

        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [JsonProperty("taxpayerStatus")]
        public string TaxpayerStatus { get; set; }

        [JsonProperty("isRequirementsThreshold")]
        public string IsRequirementsThreshold { get; set; }

        [JsonProperty("isSupportingAccount")]
        public string IsSupportingAccount { get; set; }

        [JsonProperty("exemptionMedicalInsuranceTax")]
        public string ExemptionMedicalInsuranceTax { get; set; }

        [JsonProperty("tfnSignDate")]
        public string TfnSignDate { get; set; }

        [JsonProperty("taxIdentity")]
        public string TaxIdentity { get; set; }

        [JsonProperty("otherIncomeName")]
        public string OtherIncomeName { get; set; }

        [JsonProperty("mobileCardCalType")]
        public string MobileCardCalType { get; set; }

        [JsonProperty("termsOfWorkName")]
        public string TermsOfWorkName { get; set; }

        [JsonProperty("insurePlanName")]
        public string InsurePlanName { get; set; }

        [JsonProperty("majorWorkLocationId")]
        public string MajorWorkLocationId { get; set; }

        [JsonProperty("majorWorkLocationName")]
        public string MajorWorkLocationName { get; set; }

        [JsonProperty("whetherResidence")]
        public string WhetherResidence { get; set; }

        [JsonProperty("award")]
        public string Award { get; set; }

        [JsonProperty("employeeRateType")]
        public string EmployeeRateType { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("payrollTemplateId")]
        public string PayrollTemplateId { get; set; }

        [JsonProperty("beneficiaryType")]
        public string BeneficiaryType { get; set; }

        [JsonProperty("surnameEnglish")]
        public string SurnameEnglish { get; set; }

        [JsonProperty("personalNameEnglish")]
        public string PersonalNameEnglish { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("directSupervisorCode")]
        public string DirectSupervisorCode { get; set; }

        [JsonProperty("attendCalculationCode")]
        public string AttendCalculationCode { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }
    }

    public class ResultIPageV3BizReimbursementResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3BizReimbursementResp Data { get; set; }
    }

    public class IPageV3BizReimbursementResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3BizReimbursementResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3BizReimbursementResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("reimbursementType")]
        public string ReimbursementType { get; set; }

        [JsonProperty("reimbursementTypeName")]
        public string ReimbursementTypeName { get; set; }

        [JsonProperty("reimbursementDate")]
        public string ReimbursementDate { get; set; }

        [JsonProperty("reimbursementName")]
        public string ReimbursementName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }
    }

    public class ResultIPageV3LeaveBalanceResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LeaveBalanceResp Data { get; set; }
    }

    public class IPageV3LeaveBalanceResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LeaveBalanceResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LeaveBalanceResp
    {
        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("holidayRule")]
        public string HolidayRule { get; set; }

        [JsonProperty("holidayRuleName")]
        public string HolidayRuleName { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("planing")]
        public double Planing { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }
    }

    public class ResultIPageV3RosterListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3RosterListResp Data { get; set; }
    }

    public class IPageV3RosterListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3RosterListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3RosterListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeEnglishName")]
        public string EmployeeEnglishName { get; set; }

        [JsonProperty("attendDay")]
        public string AttendDay { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("shiftTemplateName")]
        public string ShiftTemplateName { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("actualIn")]
        public string ActualIn { get; set; }

        [JsonProperty("actualOff")]
        public string ActualOff { get; set; }

        [JsonProperty("beLateLength")]
        public double BeLateLength { get; set; }

        [JsonProperty("leaveEarlyLength")]
        public double LeaveEarlyLength { get; set; }

        [JsonProperty("shiftLabor")]
        public double ShiftLabor { get; set; }

        [JsonProperty("laborLength")]
        public double LaborLength { get; set; }

        [JsonProperty("attendStatus")]
        public string AttendStatus { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("shiftStatus")]
        public string ShiftStatus { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("attendanceItemName")]
        public string AttendanceItemName { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }
    }

    public class ResultIPageV3LeaveWorkFlowDefinitionResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LeaveWorkFlowDefinitionResp Data { get; set; }
    }

    public class IPageV3LeaveWorkFlowDefinitionResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LeaveWorkFlowDefinitionResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LeaveWorkFlowDefinitionResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isEnabled")]
        public string IsEnabled { get; set; }

        [JsonProperty("isInternallyInstalled")]
        public bool IsInternallyInstalled { get; set; }

        [JsonProperty("allowCustomApprover")]
        public bool AllowCustomApprover { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("workLocation")]
        public string WorkLocation { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("employee")]
        public string Employee { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("takeEffectIndex")]
        public int TakeEffectIndex { get; set; }

        [JsonProperty("includeAll")]
        public bool IncludeAll { get; set; }
    }

    public class ResultV3BizReimbursementDetailResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3BizReimbursementDetailResp Data { get; set; }
    }

    public class V3BizReimbursementDetailResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("reimbursementType")]
        public string ReimbursementType { get; set; }

        [JsonProperty("reimbursementTypeName")]
        public string ReimbursementTypeName { get; set; }

        [JsonProperty("reimbursementDate")]
        public string ReimbursementDate { get; set; }

        [JsonProperty("reimbursementName")]
        public string ReimbursementName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultV3LeaveBalanceDetailResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3LeaveBalanceDetailResp Data { get; set; }
    }

    public class V3LeaveBalanceDetailResp
    {
        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("holidayTypeName")]
        public string HolidayTypeName { get; set; }

        [JsonProperty("regularType")]
        public string RegularType { get; set; }

        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("planing")]
        public double Planing { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class ResultV3RosterInfoResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3RosterInfoResp Data { get; set; }
    }

    public class V3RosterInfoResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeEnglishName")]
        public string EmployeeEnglishName { get; set; }

        [JsonProperty("attendDay")]
        public string AttendDay { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("shiftTemplateName")]
        public string ShiftTemplateName { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("actualIn")]
        public string ActualIn { get; set; }

        [JsonProperty("actualOff")]
        public string ActualOff { get; set; }

        [JsonProperty("beLateLength")]
        public double BeLateLength { get; set; }

        [JsonProperty("leaveEarlyLength")]
        public double LeaveEarlyLength { get; set; }

        [JsonProperty("shiftLabor")]
        public double ShiftLabor { get; set; }

        [JsonProperty("laborLength")]
        public double LaborLength { get; set; }

        [JsonProperty("attendStatus")]
        public string AttendStatus { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("shiftStatus")]
        public string ShiftStatus { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("attendanceItemName")]
        public string AttendanceItemName { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }
    }

    public class _06resignV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("lastWorkingDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastWorkingDate { get; set; }

        [JsonProperty("reasonsLeave", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReasonsLeave { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class _06updateAttendanceDataByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("actualLongitude")]
        public double? ActualLongitude { get; set; }

        [JsonProperty("actualLatitude")]
        public double? ActualLatitude { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("codeSource")]
        public string CodeSource { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("workLocationId")]
        public string WorkLocationId { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }

    public class ResultV3AddEmployeeHistoryResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AddEmployeeHistoryResp Data { get; set; }
    }

    public class V3AddEmployeeHistoryResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class _07addEmployeeHistoryV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("entryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryDate { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("basicPay")]
        public double? BasicPay { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("majorWorkLocationId")]
        public string MajorWorkLocationId { get; set; }

        [JsonProperty("takeEffectType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TakeEffectType { get; set; }

        [JsonProperty("takeEffectDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TakeEffectDate { get; set; }
    }

    public class ResultV3LeaveHolidayInsertResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3LeaveHolidayInsertResp Data { get; set; }
    }

    public class V3LeaveHolidayInsertResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("holidayTypeName")]
        public string HolidayTypeName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("leaveTime")]
        public double LeaveTime { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("holidayDate")]
        public string HolidayDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class _07addLeaveApplicationInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("holidayType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HolidayType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("leaveTime")]
        public double? LeaveTime { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("holidayDate")]
        public string HolidayDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class _07addShitTemplateInfoV3Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("shiftIn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftOff { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("attendanceAddressId")]
        public string AttendanceAddressId { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }
    }

    public class ResultIPageV3MobileCardListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3MobileCardListResp Data { get; set; }
    }

    public class IPageV3MobileCardListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3MobileCardListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3MobileCardListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeCode")]
        public string EmployeeCode { get; set; }

        [JsonProperty("employeeEnglishName")]
        public string EmployeeEnglishName { get; set; }

        [JsonProperty("employeeDeptName")]
        public string EmployeeDeptName { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("workLocationId")]
        public string WorkLocationId { get; set; }

        [JsonProperty("workLocationName")]
        public string WorkLocationName { get; set; }

        [JsonProperty("actualLongitude")]
        public double ActualLongitude { get; set; }

        [JsonProperty("actualLatitude")]
        public double ActualLatitude { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("codeSource")]
        public string CodeSource { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }

    public class ResultV3MobileCardInfoResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3MobileCardInfoResp Data { get; set; }
    }

    public class V3MobileCardInfoResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeCode")]
        public string EmployeeCode { get; set; }

        [JsonProperty("employeeEnglishName")]
        public string EmployeeEnglishName { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("attendDate")]
        public string AttendDate { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("workLocationId")]
        public string WorkLocationId { get; set; }

        [JsonProperty("workLocationName")]
        public string WorkLocationName { get; set; }

        [JsonProperty("actualLongitude")]
        public double ActualLongitude { get; set; }

        [JsonProperty("actualLatitude")]
        public double ActualLatitude { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("codeSource")]
        public string CodeSource { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }

    public class ResultIPageV3AttendanceItemListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3AttendanceItemListResp Data { get; set; }
    }

    public class IPageV3AttendanceItemListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3AttendanceItemListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3AttendanceItemListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hkName")]
        public string HkName { get; set; }

        [JsonProperty("enName")]
        public string EnName { get; set; }

        [JsonProperty("cnName")]
        public string CnName { get; set; }

        [JsonProperty("defaultId")]
        public string DefaultId { get; set; }

        [JsonProperty("regulationRulesAlias")]
        public string RegulationRulesAlias { get; set; }

        [JsonProperty("decimalDigits")]
        public int DecimalDigits { get; set; }

        [JsonProperty("carryRule")]
        public string CarryRule { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("isExistRegulationRules")]
        public int IsExistRegulationRules { get; set; }

        [JsonProperty("regulationRules")]
        public string RegulationRules { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("calculationOrder")]
        public int CalculationOrder { get; set; }
    }

    public class _09updateEmployeeHistoryByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("entryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryDate { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("basicPay")]
        public double? BasicPay { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("majorWorkLocationId")]
        public string MajorWorkLocationId { get; set; }
    }

    public class _09updateLeaveApplicationByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("leaveTime")]
        public double? LeaveTime { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("holidayDate")]
        public string HolidayDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class _09updateShiftTemplateByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("shiftIn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShiftOff { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("attendanceAddressId")]
        public string AttendanceAddressId { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultV3AddTimesheetResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AddTimesheetResp Data { get; set; }
    }

    public class V3AddTimesheetResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class _10addTimesheetInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("workOverTimeType")]
        public string WorkOverTimeType { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("startTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultIPageV3EmployeeHistoryListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3EmployeeHistoryListResp Data { get; set; }
    }

    public class IPageV3EmployeeHistoryListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3EmployeeHistoryListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3EmployeeHistoryListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("entryDate")]
        public string EntryDate { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("directSupervisorName")]
        public string DirectSupervisorName { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("attendCalculationName")]
        public string AttendCalculationName { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("basicPay")]
        public double BasicPay { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("takeEffectStatus")]
        public string TakeEffectStatus { get; set; }

        [JsonProperty("takeEffectDate")]
        public string TakeEffectDate { get; set; }

        [JsonProperty("regularType")]
        public string RegularType { get; set; }

        [JsonProperty("regularTypeName")]
        public string RegularTypeName { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("payrollRegulationName")]
        public string PayrollRegulationName { get; set; }

        [JsonProperty("lastWorkingDate")]
        public string LastWorkingDate { get; set; }

        [JsonProperty("employeeStatus")]
        public int EmployeeStatus { get; set; }

        [JsonProperty("majorWorkLocationId")]
        public string MajorWorkLocationId { get; set; }

        [JsonProperty("majorWorkLocationName")]
        public string MajorWorkLocationName { get; set; }
    }

    public class ResultIPageV3LeaveHolidayResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LeaveHolidayResp Data { get; set; }
    }

    public class IPageV3LeaveHolidayResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LeaveHolidayResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LeaveHolidayResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("holidayTypeName")]
        public string HolidayTypeName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("leaveTime")]
        public double LeaveTime { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("holidayDate")]
        public string HolidayDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class ResultIPageV3ShiftTemplateListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3ShiftTemplateListResp Data { get; set; }
    }

    public class IPageV3ShiftTemplateListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3ShiftTemplateListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3ShiftTemplateListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("attendanceAddressId")]
        public string AttendanceAddressId { get; set; }

        [JsonProperty("attendanceAddressName")]
        public string AttendanceAddressName { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("isDeductionMealTime")]
        public bool IsDeductionMealTime { get; set; }

        [JsonProperty("lunchStartTime")]
        public string LunchStartTime { get; set; }

        [JsonProperty("lunchEndTime")]
        public string LunchEndTime { get; set; }
    }

    public class _11addOpenShiftInfoV3Input
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("shiftType")]
        public string ShiftType { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("startTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("hourlyRate", DefaultValueHandling = DefaultValueHandling.Include)]
        public double HourlyRate { get; set; }

        [JsonProperty("empPlanNo", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EmpPlanNo { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultV3LeaveHolidayDetailResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3LeaveHolidayDetailResp Data { get; set; }
    }

    public class V3LeaveHolidayDetailResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("holidayTypeName")]
        public string HolidayTypeName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("leaveTime")]
        public double LeaveTime { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("holidayDate")]
        public string HolidayDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class ResultListV3LeaveProcessResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3LeaveProcessResp[] Data { get; set; }
    }

    public class V3LeaveProcessResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recordId")]
        public string RecordId { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("workFlowOrder")]
        public int WorkFlowOrder { get; set; }

        [JsonProperty("recordType")]
        public string RecordType { get; set; }

        [JsonProperty("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class _12updateTimesheetByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("workOverTimeType")]
        public string WorkOverTimeType { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("startTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultIPageV3LeaveTypeResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LeaveTypeResp Data { get; set; }
    }

    public class IPageV3LeaveTypeResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LeaveTypeResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LeaveTypeResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("isSalary")]
        public string IsSalary { get; set; }

        [JsonProperty("displayBalance")]
        public string DisplayBalance { get; set; }

        [JsonProperty("isIncludePublicHoliday")]
        public string IsIncludePublicHoliday { get; set; }

        [JsonProperty("isExistsLimit")]
        public string IsExistsLimit { get; set; }

        [JsonProperty("isBuiltIn")]
        public string IsBuiltIn { get; set; }

        [JsonProperty("availabilityOfEmployees")]
        public string AvailabilityOfEmployees { get; set; }

        [JsonProperty("updateSpecies")]
        public string UpdateSpecies { get; set; }

        [JsonProperty("builtInId")]
        public string BuiltInId { get; set; }

        [JsonProperty("leaveToCash")]
        public string LeaveToCash { get; set; }
    }

    public class ResultIPageV3TimesheetListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3TimesheetListResp Data { get; set; }
    }

    public class IPageV3TimesheetListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3TimesheetListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3TimesheetListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workOverTimeType")]
        public string WorkOverTimeType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("times")]
        public double Times { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("addressCardName")]
        public string AddressCardName { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("finalApprover")]
        public string FinalApprover { get; set; }

        [JsonProperty("finalApproverName")]
        public string FinalApproverName { get; set; }

        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class _13updateOpenShiftByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("shiftType")]
        public string ShiftType { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("startTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("hourlyRate", DefaultValueHandling = DefaultValueHandling.Include)]
        public double HourlyRate { get; set; }

        [JsonProperty("empPlanNo", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EmpPlanNo { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultIPageV3LeavePolicyResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LeavePolicyResp Data { get; set; }
    }

    public class IPageV3LeavePolicyResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LeavePolicyResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LeavePolicyResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workDays")]
        public string WorkDays { get; set; }

        [JsonProperty("workHours")]
        public double WorkHours { get; set; }

        [JsonProperty("holidaysId")]
        public string HolidaysId { get; set; }

        [JsonProperty("createTime")]
        public string CreateTime { get; set; }
    }

    public class ResultIPageV3OpenShiftListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3OpenShiftListResp Data { get; set; }
    }

    public class IPageV3OpenShiftListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3OpenShiftListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3OpenShiftListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("hourlyRate")]
        public double HourlyRate { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("scheduleHours")]
        public double ScheduleHours { get; set; }

        [JsonProperty("empPlanNo")]
        public int EmpPlanNo { get; set; }

        [JsonProperty("empScheduleNo")]
        public int EmpScheduleNo { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("shiftType")]
        public string ShiftType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("scheduledAmount")]
        public double ScheduledAmount { get; set; }

        [JsonProperty("planAmount")]
        public double PlanAmount { get; set; }
    }

    public class ResultV3TimesheetInfoResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3TimesheetInfoResp Data { get; set; }
    }

    public class V3TimesheetInfoResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("workOverTimeType")]
        public string WorkOverTimeType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("times")]
        public double Times { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("addressCardName")]
        public string AddressCardName { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("attendanceItemName")]
        public string AttendanceItemName { get; set; }

        [JsonProperty("hourlyRate")]
        public double HourlyRate { get; set; }

        [JsonProperty("tierRate")]
        public double TierRate { get; set; }

        [JsonProperty("actualAmount")]
        public double ActualAmount { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultV3AddCalendarRemarkInfoResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AddCalendarRemarkInfoResp Data { get; set; }
    }

    public class V3AddCalendarRemarkInfoResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class _15addCalendarRemarkInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeStatus { get; set; }

        [JsonProperty("timeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("recordDate")]
        public string RecordDate { get; set; }

        [JsonProperty("expectWorkLocation")]
        public string ExpectWorkLocation { get; set; }

        [JsonProperty("expectWorkTimeTemplate")]
        public string ExpectWorkTimeTemplate { get; set; }

        [JsonProperty("expectWorkStartTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpectWorkStartTime { get; set; }

        [JsonProperty("expectWorkEndTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpectWorkEndTime { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultV3LeavePolicyDetailResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3LeavePolicyDetailResp Data { get; set; }
    }

    public class V3LeavePolicyDetailResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workDays")]
        public string WorkDays { get; set; }

        [JsonProperty("workHours")]
        public double WorkHours { get; set; }

        [JsonProperty("holidaysId")]
        public string HolidaysId { get; set; }

        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        [JsonProperty("leavePublicName")]
        public string LeavePublicName { get; set; }

        [JsonProperty("leavePublicTotalDays")]
        public int LeavePublicTotalDays { get; set; }

        [JsonProperty("leaveTypeNameList")]
        public string[] LeaveTypeNameList { get; set; }

        [JsonProperty("leaveTypeCount")]
        public int LeaveTypeCount { get; set; }
    }

    public class ResultV3OpenShiftInfoResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3OpenShiftInfoResp Data { get; set; }
    }

    public class V3OpenShiftInfoResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("hourlyRate")]
        public double HourlyRate { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("scheduleHours")]
        public double ScheduleHours { get; set; }

        [JsonProperty("empPlanNo")]
        public int EmpPlanNo { get; set; }

        [JsonProperty("empScheduleNo")]
        public int EmpScheduleNo { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("shiftType")]
        public string ShiftType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("scheduledAmount")]
        public double ScheduledAmount { get; set; }

        [JsonProperty("planAmount")]
        public double PlanAmount { get; set; }
    }

    public class _16addProjectCategoryInfoV3Input
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class ResultIPageV3LeavePolicyTypeResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3LeavePolicyTypeResp Data { get; set; }
    }

    public class IPageV3LeavePolicyTypeResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3LeavePolicyTypeResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3LeavePolicyTypeResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("regulationId")]
        public string RegulationId { get; set; }

        [JsonProperty("holidayId")]
        public string HolidayId { get; set; }

        [JsonProperty("usedEntry")]
        public int UsedEntry { get; set; }

        [JsonProperty("minLength")]
        public double MinLength { get; set; }

        [JsonProperty("disposableTotal")]
        public double DisposableTotal { get; set; }

        [JsonProperty("yearTotal")]
        public double YearTotal { get; set; }

        [JsonProperty("ruleStartTime")]
        public string RuleStartTime { get; set; }

        [JsonProperty("basicEntry")]
        public string BasicEntry { get; set; }

        [JsonProperty("generationFrequency")]
        public string GenerationFrequency { get; set; }

        [JsonProperty("totalDays")]
        public string TotalDays { get; set; }

        [JsonProperty("decimalDigits")]
        public int DecimalDigits { get; set; }

        [JsonProperty("carryRule")]
        public string CarryRule { get; set; }

        [JsonProperty("checkTime")]
        public string CheckTime { get; set; }

        [JsonProperty("isCarryOver")]
        public string IsCarryOver { get; set; }

        [JsonProperty("maxTransfer")]
        public double MaxTransfer { get; set; }

        [JsonProperty("isOvered")]
        public string IsOvered { get; set; }

        [JsonProperty("isIncludeRest")]
        public string IsIncludeRest { get; set; }

        [JsonProperty("frequencyOfOnce")]
        public string FrequencyOfOnce { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("isSalary")]
        public string IsSalary { get; set; }

        [JsonProperty("updateSpecies")]
        public string UpdateSpecies { get; set; }

        [JsonProperty("generationType")]
        public string GenerationType { get; set; }

        [JsonProperty("minAge")]
        public int MinAge { get; set; }

        [JsonProperty("maxAge")]
        public int MaxAge { get; set; }

        [JsonProperty("minMonthToApply")]
        public int MinMonthToApply { get; set; }

        [JsonProperty("deferCarryover")]
        public string DeferCarryover { get; set; }

        [JsonProperty("deferCarryoverMonth")]
        public int DeferCarryoverMonth { get; set; }
    }

    public class _17updateCalendarRemarkByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeStatus { get; set; }

        [JsonProperty("timeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("recordDate")]
        public string RecordDate { get; set; }

        [JsonProperty("expectWorkLocation")]
        public string ExpectWorkLocation { get; set; }

        [JsonProperty("expectWorkTimeTemplate")]
        public string ExpectWorkTimeTemplate { get; set; }

        [JsonProperty("expectWorkStartTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpectWorkStartTime { get; set; }

        [JsonProperty("expectWorkEndTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpectWorkEndTime { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class ResultIPageV3StatusFlagListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3StatusFlagListResp Data { get; set; }
    }

    public class IPageV3StatusFlagListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3StatusFlagListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3StatusFlagListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("employeeStatus")]
        public string EmployeeStatus { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("recordDate")]
        public string RecordDate { get; set; }

        [JsonProperty("expectWorkLocation")]
        public string ExpectWorkLocation { get; set; }

        [JsonProperty("expectWorkLocationName")]
        public string ExpectWorkLocationName { get; set; }

        [JsonProperty("expectWorkTimeTemplate")]
        public string ExpectWorkTimeTemplate { get; set; }

        [JsonProperty("expectWorkTimeTemplateName")]
        public string ExpectWorkTimeTemplateName { get; set; }

        [JsonProperty("expectWorkStartTime")]
        public string ExpectWorkStartTime { get; set; }

        [JsonProperty("expectWorkEndTime")]
        public string ExpectWorkEndTime { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class _18updateProjectCategoryByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class ResultIPageV3ScheduleProjectCategoryListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3ScheduleProjectCategoryListResp Data { get; set; }
    }

    public class IPageV3ScheduleProjectCategoryListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3ScheduleProjectCategoryListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3ScheduleProjectCategoryListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("parentName")]
        public string ParentName { get; set; }
    }

    public class _20addProjectInfoV3Input
    {
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("hourlyRate", DefaultValueHandling = DefaultValueHandling.Include)]
        public double HourlyRate { get; set; }

        [JsonProperty("minRate")]
        public double? MinRate { get; set; }

        [JsonProperty("maxRate")]
        public double? MaxRate { get; set; }
    }

    public class _22updateProjectByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("hourlyRate", DefaultValueHandling = DefaultValueHandling.Include)]
        public double HourlyRate { get; set; }

        [JsonProperty("minRate")]
        public double? MinRate { get; set; }

        [JsonProperty("maxRate")]
        public double? MaxRate { get; set; }
    }

    public class ResultIPageV3ProjectListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3ProjectListResp Data { get; set; }
    }

    public class IPageV3ProjectListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3ProjectListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3ProjectListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("attendanceItemStatus")]
        public int AttendanceItemStatus { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("hourlyRate")]
        public double HourlyRate { get; set; }

        [JsonProperty("minRate")]
        public double MinRate { get; set; }

        [JsonProperty("maxRate")]
        public double MaxRate { get; set; }
    }

    public class ResultV3ProjectInfoResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3ProjectInfoResp Data { get; set; }
    }

    public class V3ProjectInfoResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("attendanceItemStatus")]
        public int AttendanceItemStatus { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("hourlyRate")]
        public double HourlyRate { get; set; }

        [JsonProperty("minRate")]
        public double MinRate { get; set; }

        [JsonProperty("maxRate")]
        public double MaxRate { get; set; }
    }

    public class _25addProjectCertificateInfoV3Input
    {
        [JsonProperty("employeeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmployeeId { get; set; }

        [JsonProperty("projectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("tierRate")]
        public double? TierRate { get; set; }

        [JsonProperty("shiftHours", DefaultValueHandling = DefaultValueHandling.Include)]
        public double ShiftHours { get; set; }

        [JsonProperty("workedHours", DefaultValueHandling = DefaultValueHandling.Include)]
        public double WorkedHours { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class _26updateProjectCertificateByIdV3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("tierRate")]
        public double? TierRate { get; set; }
    }

    public class ResultIPageV3ProjectCertificateListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3ProjectCertificateListResp Data { get; set; }
    }

    public class IPageV3ProjectCertificateListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3ProjectCertificateListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3ProjectCertificateListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("tierRate")]
        public double TierRate { get; set; }

        [JsonProperty("shiftHours")]
        public double ShiftHours { get; set; }

        [JsonProperty("workedHours")]
        public double WorkedHours { get; set; }
    }

    public class _28addProjectCertificateHoursV3Input
    {
        [JsonProperty("projectCertificateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectCertificateId { get; set; }

        [JsonProperty("occurrenceTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OccurrenceTime { get; set; }

        [JsonProperty("balance", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Balance { get; set; }

        [JsonProperty("reason", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Reason { get; set; }
    }

    public class ResultIPageV3ProjectCertificateHoursListResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV3ProjectCertificateHoursListResp Data { get; set; }
    }

    public class IPageV3ProjectCertificateHoursListResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V3ProjectCertificateHoursListResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V3ProjectCertificateHoursListResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("projectCertificateId")]
        public string ProjectCertificateId { get; set; }

        [JsonProperty("occurrenceTime")]
        public string OccurrenceTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("payrollPlanId")]
        public string PayrollPlanId { get; set; }

        [JsonProperty("payrollPlanName")]
        public string PayrollPlanName { get; set; }

        [JsonProperty("shiftHour")]
        public double ShiftHour { get; set; }
    }

    public class ResultIPageV2AttendanceResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2AttendanceResp Data { get; set; }
    }

    public class IPageV2AttendanceResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2AttendanceResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2AttendanceResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attendDay")]
        public string AttendDay { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("shiftLabor")]
        public double ShiftLabor { get; set; }

        [JsonProperty("actualIn")]
        public string ActualIn { get; set; }

        [JsonProperty("actualOff")]
        public string ActualOff { get; set; }

        [JsonProperty("attendStatus")]
        public string AttendStatus { get; set; }

        [JsonProperty("standardLaborTime")]
        public string StandardLaborTime { get; set; }

        [JsonProperty("laborLength")]
        public double LaborLength { get; set; }

        [JsonProperty("earliestCard")]
        public string EarliestCard { get; set; }

        [JsonProperty("lateCard")]
        public string LateCard { get; set; }

        [JsonProperty("confirm")]
        public string Confirm { get; set; }

        [JsonProperty("afterAdjust")]
        public double AfterAdjust { get; set; }

        [JsonProperty("adjust")]
        public double Adjust { get; set; }

        [JsonProperty("beLateLength")]
        public double BeLateLength { get; set; }

        [JsonProperty("leaveEarlyLength")]
        public double LeaveEarlyLength { get; set; }

        [JsonProperty("beLateTime")]
        public double BeLateTime { get; set; }

        [JsonProperty("leaveEarlyTime")]
        public double LeaveEarlyTime { get; set; }

        [JsonProperty("workingOvertime")]
        public double WorkingOvertime { get; set; }

        [JsonProperty("holidayOvertime")]
        public double HolidayOvertime { get; set; }

        [JsonProperty("dayOffOvertime")]
        public double DayOffOvertime { get; set; }

        [JsonProperty("paidLeave")]
        public double PaidLeave { get; set; }

        [JsonProperty("statutoryLeave")]
        public double StatutoryLeave { get; set; }

        [JsonProperty("annualLeave")]
        public double AnnualLeave { get; set; }

        [JsonProperty("sickLeave")]
        public double SickLeave { get; set; }

        [JsonProperty("unpaidLeave")]
        public double UnpaidLeave { get; set; }

        [JsonProperty("unpaidSickLeave")]
        public double UnpaidSickLeave { get; set; }

        [JsonProperty("adjustmentLeave")]
        public double AdjustmentLeave { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("leaveTime")]
        public double LeaveTime { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("absenceLength")]
        public double AbsenceLength { get; set; }

        [JsonProperty("ordinaryHours")]
        public double OrdinaryHours { get; set; }

        [JsonProperty("satHours")]
        public double SatHours { get; set; }

        [JsonProperty("sunHours")]
        public double SunHours { get; set; }

        [JsonProperty("publicHolidayHours")]
        public double PublicHolidayHours { get; set; }

        [JsonProperty("morningShiftHours")]
        public double MorningShiftHours { get; set; }

        [JsonProperty("afternoonShiftHours")]
        public double AfternoonShiftHours { get; set; }

        [JsonProperty("nightShiftHours")]
        public double NightShiftHours { get; set; }

        [JsonProperty("mealBreakTimes")]
        public double MealBreakTimes { get; set; }

        [JsonProperty("otBefore")]
        public double OtBefore { get; set; }

        [JsonProperty("otAfter")]
        public double OtAfter { get; set; }

        [JsonProperty("ordinaryRates")]
        public double OrdinaryRates { get; set; }

        [JsonProperty("satRates")]
        public double SatRates { get; set; }

        [JsonProperty("sunRates")]
        public double SunRates { get; set; }

        [JsonProperty("publicHolidayRates")]
        public double PublicHolidayRates { get; set; }

        [JsonProperty("morningShiftRates")]
        public double MorningShiftRates { get; set; }

        [JsonProperty("afternoonShiftRates")]
        public double AfternoonShiftRates { get; set; }

        [JsonProperty("nightShiftRates")]
        public double NightShiftRates { get; set; }

        [JsonProperty("otBeforeRates")]
        public double OtBeforeRates { get; set; }

        [JsonProperty("otAfterRates")]
        public double OtAfterRates { get; set; }

        [JsonProperty("ordinaryPenalty")]
        public double OrdinaryPenalty { get; set; }

        [JsonProperty("satPenalty")]
        public double SatPenalty { get; set; }

        [JsonProperty("sunPenalty")]
        public double SunPenalty { get; set; }

        [JsonProperty("publicHolidayPenalty")]
        public double PublicHolidayPenalty { get; set; }

        [JsonProperty("morningShiftPenalty")]
        public double MorningShiftPenalty { get; set; }

        [JsonProperty("afternoonShiftPenalty")]
        public double AfternoonShiftPenalty { get; set; }

        [JsonProperty("nightShiftPenalty")]
        public double NightShiftPenalty { get; set; }

        [JsonProperty("otBeforePenalty")]
        public double OtBeforePenalty { get; set; }

        [JsonProperty("otAfterPenalty")]
        public double OtAfterPenalty { get; set; }

        [JsonProperty("overtimeSaturdayFirstHours")]
        public double OvertimeSaturdayFirstHours { get; set; }

        [JsonProperty("overtimeSaturdayAfterHours")]
        public double OvertimeSaturdayAfterHours { get; set; }

        [JsonProperty("overtimeSundayFirstHours")]
        public double OvertimeSundayFirstHours { get; set; }

        [JsonProperty("overtimeSundayAfterHours")]
        public double OvertimeSundayAfterHours { get; set; }

        [JsonProperty("overtimePublicHolidayFirstHours")]
        public double OvertimePublicHolidayFirstHours { get; set; }

        [JsonProperty("overtimePublicHolidayAfterHours")]
        public double OvertimePublicHolidayAfterHours { get; set; }

        [JsonProperty("overtimeSaturdayFirstHourlyRate")]
        public double OvertimeSaturdayFirstHourlyRate { get; set; }

        [JsonProperty("overtimeSaturdayAfterHourlyRate")]
        public double OvertimeSaturdayAfterHourlyRate { get; set; }

        [JsonProperty("overtimeSundayFirstHourlyRate")]
        public double OvertimeSundayFirstHourlyRate { get; set; }

        [JsonProperty("overtimeSundayAfterHourlyRate")]
        public double OvertimeSundayAfterHourlyRate { get; set; }

        [JsonProperty("overtimePublicHolidayFirstHourlyRate")]
        public double OvertimePublicHolidayFirstHourlyRate { get; set; }

        [JsonProperty("overtimePublicHolidayAfterHourlyRate")]
        public double OvertimePublicHolidayAfterHourlyRate { get; set; }

        [JsonProperty("overtimeSaturdayFirstHoursPay")]
        public double OvertimeSaturdayFirstHoursPay { get; set; }

        [JsonProperty("overtimeSaturdayAfterHoursPay")]
        public double OvertimeSaturdayAfterHoursPay { get; set; }

        [JsonProperty("overtimeSundayFirstHoursPay")]
        public double OvertimeSundayFirstHoursPay { get; set; }

        [JsonProperty("overtimeSundayAfterHoursPay")]
        public double OvertimeSundayAfterHoursPay { get; set; }

        [JsonProperty("overtimePublicHolidayFirstHoursPay")]
        public double OvertimePublicHolidayFirstHoursPay { get; set; }

        [JsonProperty("overtimePublicHolidayAfterHoursPay")]
        public double OvertimePublicHolidayAfterHoursPay { get; set; }

        [JsonProperty("timeOffInLieu")]
        public double TimeOffInLieu { get; set; }

        [JsonProperty("attendReviewStatus")]
        public bool AttendReviewStatus { get; set; }

        [JsonProperty("attendReviewer")]
        public string AttendReviewer { get; set; }

        [JsonProperty("attendReviewTime")]
        public string AttendReviewTime { get; set; }

        [JsonProperty("payrollReviewStatus")]
        public bool PayrollReviewStatus { get; set; }

        [JsonProperty("payrollReviewer")]
        public string PayrollReviewer { get; set; }

        [JsonProperty("payrollReviewTime")]
        public string PayrollReviewTime { get; set; }

        [JsonProperty("dataStatus")]
        public string DataStatus { get; set; }

        [JsonProperty("attendReviewerName")]
        public string AttendReviewerName { get; set; }

        [JsonProperty("payrollReviewerName")]
        public string PayrollReviewerName { get; set; }
    }

    public class ResultIPageV2CostCenterResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2CostCenterResp Data { get; set; }
    }

    public class IPageV2CostCenterResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2CostCenterResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2CostCenterResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultIPageV2DepartmentResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2DepartmentResp Data { get; set; }
    }

    public class IPageV2DepartmentResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2DepartmentResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2DepartmentResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("parentName")]
        public string ParentName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultIPageV2EmployeeResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2EmployeeResp Data { get; set; }
    }

    public class IPageV2EmployeeResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2EmployeeResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2EmployeeResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("identityCard")]
        public string IdentityCard { get; set; }

        [JsonProperty("bankCard")]
        public string BankCard { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("flag")]
        public int Flag { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("expectedArea")]
        public string ExpectedArea { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("arrivalDate")]
        public string ArrivalDate { get; set; }

        [JsonProperty("salary")]
        public int Salary { get; set; }

        [JsonProperty("education")]
        public string Education { get; set; }

        [JsonProperty("comApplication")]
        public string ComApplication { get; set; }

        [JsonProperty("otherApplication")]
        public string OtherApplication { get; set; }

        [JsonProperty("chineseTyping")]
        public string ChineseTyping { get; set; }

        [JsonProperty("chineseOther")]
        public string ChineseOther { get; set; }

        [JsonProperty("englishTyping")]
        public string EnglishTyping { get; set; }

        [JsonProperty("chineseWpm")]
        public int ChineseWpm { get; set; }

        [JsonProperty("englishWpm")]
        public int EnglishWpm { get; set; }

        [JsonProperty("cantonese")]
        public string Cantonese { get; set; }

        [JsonProperty("english")]
        public string English { get; set; }

        [JsonProperty("mandarin")]
        public string Mandarin { get; set; }

        [JsonProperty("otherLanguage")]
        public string OtherLanguage { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("positionId")]
        public string PositionId { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("entryDate")]
        public string EntryDate { get; set; }

        [JsonProperty("directSupervisorId")]
        public string DirectSupervisorId { get; set; }

        [JsonProperty("directSupervisorEnglishName")]
        public string DirectSupervisorEnglishName { get; set; }

        [JsonProperty("attendCalculationId")]
        public string AttendCalculationId { get; set; }

        [JsonProperty("hireType")]
        public string HireType { get; set; }

        [JsonProperty("basicPay")]
        public double BasicPay { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("takeEffectDate")]
        public string TakeEffectDate { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName { get; set; }

        [JsonProperty("emergencyContactRelation")]
        public string EmergencyContactRelation { get; set; }

        [JsonProperty("emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankBranchNumber")]
        public string BankBranchNumber { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }

        [JsonProperty("lastWorkingDate")]
        public string LastWorkingDate { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("regularType")]
        public string RegularType { get; set; }

        [JsonProperty("regularTypeName")]
        public string RegularTypeName { get; set; }

        [JsonProperty("costCenterId")]
        public string CostCenterId { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("payrollRegulationName")]
        public string PayrollRegulationName { get; set; }

        [JsonProperty("personalNameEnglish")]
        public string PersonalNameEnglish { get; set; }

        [JsonProperty("identityCardHk")]
        public string IdentityCardHk { get; set; }

        [JsonProperty("passportNumber")]
        public string PassportNumber { get; set; }

        [JsonProperty("passportIssuingPlace")]
        public string PassportIssuingPlace { get; set; }

        [JsonProperty("spouseName")]
        public string SpouseName { get; set; }

        [JsonProperty("spouseIdentityCardHk")]
        public string SpouseIdentityCardHk { get; set; }

        [JsonProperty("spousePassportNumber")]
        public string SpousePassportNumber { get; set; }

        [JsonProperty("spousePassportIssuingPlace")]
        public string SpousePassportIssuingPlace { get; set; }

        [JsonProperty("postalAddress")]
        public string PostalAddress { get; set; }

        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [JsonProperty("reasonsLeave")]
        public string ReasonsLeave { get; set; }

        [JsonProperty("isForDeparture")]
        public string IsForDeparture { get; set; }

        [JsonProperty("hometown")]
        public string Hometown { get; set; }

        [JsonProperty("nation")]
        public string Nation { get; set; }

        [JsonProperty("politicalStatus")]
        public string PoliticalStatus { get; set; }

        [JsonProperty("highestEducation")]
        public string HighestEducation { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("probation")]
        public string Probation { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("isForeignNationality")]
        public bool IsForeignNationality { get; set; }

        [JsonProperty("domicileLocation")]
        public string DomicileLocation { get; set; }

        [JsonProperty("certificateType")]
        public string CertificateType { get; set; }

        [JsonProperty("certificateNumber")]
        public string CertificateNumber { get; set; }

        [JsonProperty("isMartyrDependents")]
        public bool IsMartyrDependents { get; set; }

        [JsonProperty("occupationTaxNumber")]
        public string OccupationTaxNumber { get; set; }

        [JsonProperty("nonLocalBlueCardNumber")]
        public string NonLocalBlueCardNumber { get; set; }

        [JsonProperty("isForeignEmployees")]
        public bool IsForeignEmployees { get; set; }

        [JsonProperty("weeklyLeaveWorkAgreement")]
        public string WeeklyLeaveWorkAgreement { get; set; }

        [JsonProperty("workHours")]
        public double WorkHours { get; set; }

        [JsonProperty("employeeType")]
        public string EmployeeType { get; set; }

        [JsonProperty("jobLevel")]
        public string JobLevel { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("salaryScale")]
        public string SalaryScale { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("recruitmentSource")]
        public string RecruitmentSource { get; set; }

        [JsonProperty("graduatedSchool")]
        public string GraduatedSchool { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("calculateSalaryTypeText")]
        public string CalculateSalaryTypeText { get; set; }

        [JsonProperty("hireTypeText")]
        public string HireTypeText { get; set; }

        [JsonProperty("termsOfWork")]
        public string TermsOfWork { get; set; }

        [JsonProperty("totalHours")]
        public double TotalHours { get; set; }

        [JsonProperty("payrollPackageFte")]
        public double PayrollPackageFte { get; set; }

        [JsonProperty("payrollPackageProData")]
        public double PayrollPackageProData { get; set; }

        [JsonProperty("hourlyWagePercent")]
        public double HourlyWagePercent { get; set; }

        [JsonProperty("terminationCompensationDate")]
        public string TerminationCompensationDate { get; set; }

        [JsonProperty("terminationEmployedLength")]
        public double TerminationEmployedLength { get; set; }

        [JsonProperty("ageOfTermination")]
        public int AgeOfTermination { get; set; }

        [JsonProperty("appellation")]
        public string Appellation { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("officePhone")]
        public string OfficePhone { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("contractEndDate")]
        public string ContractEndDate { get; set; }

        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [JsonProperty("taxpayerStatus")]
        public string TaxpayerStatus { get; set; }

        [JsonProperty("isRequirementsThreshold")]
        public string IsRequirementsThreshold { get; set; }

        [JsonProperty("isSupportingAccount")]
        public string IsSupportingAccount { get; set; }

        [JsonProperty("exemptionMedicalInsuranceTax")]
        public string ExemptionMedicalInsuranceTax { get; set; }

        [JsonProperty("tfnSignDate")]
        public string TfnSignDate { get; set; }

        [JsonProperty("taxIdentity")]
        public string TaxIdentity { get; set; }

        [JsonProperty("otherIncomeName")]
        public string OtherIncomeName { get; set; }

        [JsonProperty("mobileCardCalType")]
        public string MobileCardCalType { get; set; }

        [JsonProperty("termsOfWorkName")]
        public string TermsOfWorkName { get; set; }

        [JsonProperty("insurePlanName")]
        public string InsurePlanName { get; set; }

        [JsonProperty("majorWorkLocationId")]
        public string MajorWorkLocationId { get; set; }

        [JsonProperty("majorWorkLocationName")]
        public string MajorWorkLocationName { get; set; }

        [JsonProperty("whetherResidence")]
        public string WhetherResidence { get; set; }

        [JsonProperty("award")]
        public string Award { get; set; }

        [JsonProperty("employeeRateType")]
        public string EmployeeRateType { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("payrollTemplateId")]
        public string PayrollTemplateId { get; set; }

        [JsonProperty("beneficiaryType")]
        public string BeneficiaryType { get; set; }

        [JsonProperty("attendCalculationName")]
        public string AttendCalculationName { get; set; }
    }

    public class ResultIPageV2ExpenseResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2ExpenseResp Data { get; set; }
    }

    public class IPageV2ExpenseResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2ExpenseResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2ExpenseResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("reimbursementType")]
        public string ReimbursementType { get; set; }

        [JsonProperty("reimbursementTypeName")]
        public string ReimbursementTypeName { get; set; }

        [JsonProperty("reimbursementDate")]
        public string ReimbursementDate { get; set; }

        [JsonProperty("reimbursementName")]
        public string ReimbursementName { get; set; }

        [JsonProperty("reimbursementCode")]
        public string ReimbursementCode { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("employeeCode")]
        public string EmployeeCode { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }
    }

    public class ResultIPageV2ExternalPayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2ExternalPayItemResp Data { get; set; }
    }

    public class IPageV2ExternalPayItemResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2ExternalPayItemResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2ExternalPayItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeCode")]
        public string EmployeeCode { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("businessSalaryItemId")]
        public string BusinessSalaryItemId { get; set; }

        [JsonProperty("businessSalaryItemName")]
        public string BusinessSalaryItemName { get; set; }

        [JsonProperty("money")]
        public double Money { get; set; }

        [JsonProperty("occurrenceDate")]
        public string OccurrenceDate { get; set; }

        [JsonProperty("payType")]
        public string PayType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class ResultIPageV2ExtPayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2ExtPayItemResp Data { get; set; }
    }

    public class IPageV2ExtPayItemResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2ExtPayItemResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2ExtPayItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("carryRule")]
        public string CarryRule { get; set; }

        [JsonProperty("decimalDigits")]
        public int DecimalDigits { get; set; }

        [JsonProperty("formulaAlias")]
        public string FormulaAlias { get; set; }
    }

    public class ResultIPageV2FixedPayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2FixedPayItemResp Data { get; set; }
    }

    public class IPageV2FixedPayItemResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2FixedPayItemResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2FixedPayItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("payrollItemId")]
        public string PayrollItemId { get; set; }

        [JsonProperty("money")]
        public double Money { get; set; }

        [JsonProperty("payrollItemName")]
        public string PayrollItemName { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class ResultIPageV2LabelResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2LabelResp Data { get; set; }
    }

    public class IPageV2LabelResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2LabelResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2LabelResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("labelCode")]
        public string LabelCode { get; set; }

        [JsonProperty("labelName")]
        public string LabelName { get; set; }

        [JsonProperty("labelStatus")]
        public int LabelStatus { get; set; }
    }

    public class ResultIPageV2LeaveApplicationResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2LeaveApplicationResp Data { get; set; }
    }

    public class IPageV2LeaveApplicationResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2LeaveApplicationResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2LeaveApplicationResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("holidayTypeName")]
        public string HolidayTypeName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("leaveTime")]
        public double LeaveTime { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("holidayDate")]
        public string HolidayDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class ResultIPageV2PayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2PayItemResp Data { get; set; }
    }

    public class IPageV2PayItemResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2PayItemResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2PayItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payrollItemTypeName")]
        public string PayrollItemTypeName { get; set; }

        [JsonProperty("calculationOrder")]
        public string CalculationOrder { get; set; }

        [JsonProperty("regulationRulesAlias")]
        public string RegulationRulesAlias { get; set; }

        [JsonProperty("salaryElement")]
        public string SalaryElement { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("ratio")]
        public string Ratio { get; set; }
    }

    public class ResultIPageV2PayrollPlanResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2PayrollPlanResp Data { get; set; }
    }

    public class IPageV2PayrollPlanResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2PayrollPlanResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2PayrollPlanResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payrollRegulationId")]
        public string PayrollRegulationId { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("periodStartDate")]
        public string PeriodStartDate { get; set; }

        [JsonProperty("periodEndDate")]
        public string PeriodEndDate { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("actualSalary")]
        public double ActualSalary { get; set; }

        [JsonProperty("payrollDate")]
        public string PayrollDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("attendCalculationStartDate")]
        public string AttendCalculationStartDate { get; set; }

        [JsonProperty("attendCalculationEndDate")]
        public string AttendCalculationEndDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("temporaryOperationName")]
        public string TemporaryOperationName { get; set; }

        [JsonProperty("employeeScopeType")]
        public string EmployeeScopeType { get; set; }

        [JsonProperty("payrollTimeType")]
        public string PayrollTimeType { get; set; }
    }

    public class ResultIPageV2PositionResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2PositionResp Data { get; set; }
    }

    public class IPageV2PositionResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2PositionResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2PositionResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResultListV2RosterResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V2RosterResp[] Data { get; set; }
    }

    public class V2RosterResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("employeeEnglishName")]
        public string EmployeeEnglishName { get; set; }

        [JsonProperty("employeeCode")]
        public string EmployeeCode { get; set; }

        [JsonProperty("attendDay")]
        public string AttendDay { get; set; }

        [JsonProperty("shiftTemplateId")]
        public string ShiftTemplateId { get; set; }

        [JsonProperty("shiftTemplateName")]
        public string ShiftTemplateName { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("lateStart")]
        public int LateStart { get; set; }

        [JsonProperty("earlyStart")]
        public int EarlyStart { get; set; }

        [JsonProperty("earliestCard")]
        public string EarliestCard { get; set; }

        [JsonProperty("lateCard")]
        public string LateCard { get; set; }

        [JsonProperty("actualIn")]
        public string ActualIn { get; set; }

        [JsonProperty("actualOff")]
        public string ActualOff { get; set; }

        [JsonProperty("beLateLength")]
        public double BeLateLength { get; set; }

        [JsonProperty("leaveEarlyLength")]
        public double LeaveEarlyLength { get; set; }

        [JsonProperty("shiftLabor")]
        public double ShiftLabor { get; set; }

        [JsonProperty("laborLength")]
        public double LaborLength { get; set; }

        [JsonProperty("attendStatus")]
        public string AttendStatus { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("shiftStatus")]
        public string ShiftStatus { get; set; }

        [JsonProperty("acrossTheNight")]
        public string AcrossTheNight { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("isLeave")]
        public int IsLeave { get; set; }

        [JsonProperty("scheduleInfo")]
        public string ScheduleInfo { get; set; }

        [JsonProperty("attendanceItemId")]
        public string AttendanceItemId { get; set; }

        [JsonProperty("attendanceItemName")]
        public string AttendanceItemName { get; set; }

        [JsonProperty("actualDuration")]
        public string ActualDuration { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("existsTimesheet")]
        public bool ExistsTimesheet { get; set; }

        [JsonProperty("existsLeave")]
        public bool ExistsLeave { get; set; }

        [JsonProperty("existsStatutoryLeave")]
        public bool ExistsStatutoryLeave { get; set; }
    }

    public class ResultV2TenantResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V2TenantResp Data { get; set; }
    }

    public class V2TenantResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("businessRegistrationNumber")]
        public string BusinessRegistrationNumber { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("realTimeZone")]
        public string RealTimeZone { get; set; }

        [JsonProperty("zoneName")]
        public string ZoneName { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankBranchCode")]
        public string BankBranchCode { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }

        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [JsonProperty("employerPosition")]
        public string EmployerPosition { get; set; }

        [JsonProperty("employerFileNumber")]
        public string EmployerFileNumber { get; set; }

        [JsonProperty("mainLanguage")]
        public string MainLanguage { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("paymentCode")]
        public string PaymentCode { get; set; }

        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        [JsonProperty("legalNameOfEnterprise")]
        public string LegalNameOfEnterprise { get; set; }

        [JsonProperty("area")]
        public string Area { get; set; }

        [JsonProperty("is57ACompany")]
        public string Is57ACompany { get; set; }

        [JsonProperty("branchNum")]
        public string BranchNum { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        [JsonProperty("agencyBusinessNum")]
        public string AgencyBusinessNum { get; set; }

        [JsonProperty("registeredAgentNum")]
        public string RegisteredAgentNum { get; set; }

        [JsonProperty("agentContactName")]
        public string AgentContactName { get; set; }

        [JsonProperty("agentEmail")]
        public string AgentEmail { get; set; }

        [JsonProperty("agentTel")]
        public string AgentTel { get; set; }

        [JsonProperty("hasAgentCompany")]
        public string HasAgentCompany { get; set; }

        [JsonProperty("ausAbn")]
        public string AusAbn { get; set; }
    }

    public class ResultIPageV2TimesheetResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2TimesheetResp Data { get; set; }
    }

    public class IPageV2TimesheetResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2TimesheetResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2TimesheetResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("isCrossTheSky")]
        public bool IsCrossTheSky { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("times")]
        public double Times { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("mealTime")]
        public int MealTime { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("addressCardName")]
        public string AddressCardName { get; set; }
    }

    public class ResultIPageV2VarPayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2VarPayItemResp Data { get; set; }
    }

    public class IPageV2VarPayItemResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2VarPayItemResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2VarPayItemResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("payrollItemId")]
        public string PayrollItemId { get; set; }

        [JsonProperty("money")]
        public double Money { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("payrollDate")]
        public string PayrollDate { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("positionName")]
        public string PositionName { get; set; }

        [JsonProperty("payrollItemName")]
        public string PayrollItemName { get; set; }

        [JsonProperty("costCenterName")]
        public string CostCenterName { get; set; }

        [JsonProperty("calculateSalaryType")]
        public string CalculateSalaryType { get; set; }

        [JsonProperty("payrollPlanId")]
        public string PayrollPlanId { get; set; }

        [JsonProperty("payrollPlanName")]
        public string PayrollPlanName { get; set; }
    }

    public class ResultIPageV2WorkLocationResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public IPageV2WorkLocationResp Data { get; set; }
    }

    public class IPageV2WorkLocationResp
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("records")]
        public V2WorkLocationResp[] Records { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class V2WorkLocationResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("isEnableGps")]
        public bool IsEnableGps { get; set; }

        [JsonProperty("isEnableBluetooth")]
        public bool IsEnableBluetooth { get; set; }

        [JsonProperty("attendanceAddressCode")]
        public string AttendanceAddressCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("areaType")]
        public string AreaType { get; set; }
    }

    public class UpdateCardByIdV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("isInValid")]
        public bool? IsInValid { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class UpdateCostCenterInfoV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("costCenterCode")]
        public string CostCenterCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateDepartmentInfoV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateEmployeeInfoV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("englishName")]
        public string EnglishName { get; set; }

        [JsonProperty("chineseName")]
        public string ChineseName { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("identityCard")]
        public string IdentityCard { get; set; }

        [JsonProperty("bankCard")]
        public string BankCard { get; set; }

        [JsonProperty("nickName")]
        public string NickName { get; set; }

        [JsonProperty("education")]
        public string Education { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("maritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName { get; set; }

        [JsonProperty("emergencyContactRelation")]
        public string EmergencyContactRelation { get; set; }

        [JsonProperty("emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankBranchNumber")]
        public string BankBranchNumber { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("identityCardHk")]
        public string IdentityCardHk { get; set; }

        [JsonProperty("passportNumber")]
        public string PassportNumber { get; set; }

        [JsonProperty("passportIssuingPlace")]
        public string PassportIssuingPlace { get; set; }

        [JsonProperty("spouseName")]
        public string SpouseName { get; set; }

        [JsonProperty("spouseIdentityCardHk")]
        public string SpouseIdentityCardHk { get; set; }

        [JsonProperty("spousePassportNumber")]
        public string SpousePassportNumber { get; set; }

        [JsonProperty("spousePassportIssuingPlace")]
        public string SpousePassportIssuingPlace { get; set; }

        [JsonProperty("postalAddress")]
        public string PostalAddress { get; set; }

        [JsonProperty("employerName")]
        public string EmployerName { get; set; }

        [JsonProperty("hometown")]
        public string Hometown { get; set; }

        [JsonProperty("nation")]
        public string Nation { get; set; }

        [JsonProperty("politicalStatus")]
        public string PoliticalStatus { get; set; }

        [JsonProperty("highestEducation")]
        public string HighestEducation { get; set; }

        [JsonProperty("workDate")]
        public string WorkDate { get; set; }

        [JsonProperty("confirmationDate")]
        public string ConfirmationDate { get; set; }

        [JsonProperty("probation")]
        public string Probation { get; set; }

        [JsonProperty("isDisabled")]
        public bool? IsDisabled { get; set; }

        [JsonProperty("isForeignNationality")]
        public bool? IsForeignNationality { get; set; }

        [JsonProperty("domicileLocation")]
        public string DomicileLocation { get; set; }

        [JsonProperty("certificateType")]
        public string CertificateType { get; set; }

        [JsonProperty("certificateNumber")]
        public string CertificateNumber { get; set; }

        [JsonProperty("isMartyrDependents")]
        public bool? IsMartyrDependents { get; set; }

        [JsonProperty("occupationTaxNumber")]
        public string OccupationTaxNumber { get; set; }

        [JsonProperty("nonLocalBlueCardNumber")]
        public string NonLocalBlueCardNumber { get; set; }

        [JsonProperty("isForeignEmployees")]
        public bool? IsForeignEmployees { get; set; }

        [JsonProperty("weeklyLeaveWorkAgreement")]
        public string WeeklyLeaveWorkAgreement { get; set; }

        [JsonProperty("employeeType")]
        public string EmployeeType { get; set; }

        [JsonProperty("jobLevel")]
        public string JobLevel { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("salaryScale")]
        public string SalaryScale { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("recruitmentSource")]
        public string RecruitmentSource { get; set; }

        [JsonProperty("graduatedSchool")]
        public string GraduatedSchool { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("appellation")]
        public string Appellation { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("officePhone")]
        public string OfficePhone { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("contractEndDate")]
        public string ContractEndDate { get; set; }

        [JsonProperty("taxIdentity")]
        public string TaxIdentity { get; set; }

        [JsonProperty("otherIncomeName")]
        public string OtherIncomeName { get; set; }
    }

    public class UpdateExpenseApplicationV2Input
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reimbursementName")]
        public string ReimbursementName { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class UpdateExternalSalaryV2Input
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("money")]
        public double? Money { get; set; }

        [JsonProperty("occurrenceDate")]
        public string OccurrenceDate { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class UpdateFixedSalaryV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("payrollItemId")]
        public string PayrollItemId { get; set; }

        [JsonProperty("money")]
        public double? Money { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class UpdateLabelInfoV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("labelCode")]
        public string LabelCode { get; set; }

        [JsonProperty("labelName")]
        public string LabelName { get; set; }

        [JsonProperty("labelStatus")]
        public int? LabelStatus { get; set; }
    }

    public class UpdateLeaveApplicationV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("holidayType")]
        public string HolidayType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("leaveTime")]
        public double? LeaveTime { get; set; }

        [JsonProperty("timeType")]
        public string TimeType { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("holidayDate")]
        public string HolidayDate { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class UpdatePositionInfoV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateRosterDataV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("shiftStatus")]
        public string ShiftStatus { get; set; }

        [JsonProperty("addressCardId")]
        public string AddressCardId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("acrossTheNight")]
        public string AcrossTheNight { get; set; }
    }

    public class UpdateRosterItemV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class UpdateShiftTemplateV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shiftIn")]
        public string ShiftIn { get; set; }

        [JsonProperty("shiftOff")]
        public string ShiftOff { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }

        [JsonProperty("attendanceAddressId")]
        public string AttendanceAddressId { get; set; }

        [JsonProperty("dateType")]
        public string DateType { get; set; }

        [JsonProperty("lunchStartTime")]
        public string LunchStartTime { get; set; }

        [JsonProperty("lunchEndTime")]
        public string LunchEndTime { get; set; }
    }

    public class UpdateTenantInfoV2Input
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("businessRegistrationNumber")]
        public string BusinessRegistrationNumber { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankBranchCode")]
        public string BankBranchCode { get; set; }

        [JsonProperty("bankAccountNo")]
        public string BankAccountNo { get; set; }
    }

    public class UpdateTimesheetV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("isCrossTheSky")]
        public bool? IsCrossTheSky { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("mealTime")]
        public int? MealTime { get; set; }
    }

    public class UpdateVarSalaryV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("money")]
        public double? Money { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class UpdateWorkLocationV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public int? Region { get; set; }

        [JsonProperty("attendanceAddressCode")]
        public string AttendanceAddressCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("areaCode")]
        public string AreaCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workstemau;

    public partial class WorkflowManagedActions
    {
        public WorkstemauActions Workstemau(string connectionId) => new WorkstemauActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkstemauTriggers Workstemau(string connectionId) => new WorkstemauTriggers(connectionId);
    }
}