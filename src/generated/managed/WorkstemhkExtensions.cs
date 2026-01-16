//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workstemhk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkstemhkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _001addFixedSalaryDataV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodypayrollItemId, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<double>> bodytotalLimitAmount = null, Expression<Func<double>> bodypaidAmount = null, Expression<Func<double>> bodysurplusAmount = null)
        {
            var apiCallPath = "/v3/payroll/addFixedSalaryData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["payrollItemId"] = ExpressionConverter.ConvertO(bodypayrollItemId);
            if (bodymoney != null)
            {
                body["money"] = ExpressionConverter.ConvertO(bodymoney);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodytotalLimitAmount != null)
            {
                body["totalLimitAmount"] = ExpressionConverter.ConvertO(bodytotalLimitAmount);
                bodypropCount++;
            }

            if (bodypaidAmount != null)
            {
                body["paidAmount"] = ExpressionConverter.ConvertO(bodypaidAmount);
                bodypropCount++;
            }

            if (bodysurplusAmount != null)
            {
                body["surplusAmount"] = ExpressionConverter.ConvertO(bodysurplusAmount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _002deleteFixedSalaryDataByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/deleteFixedSalaryDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _003updateFixedSalaryDataByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodypayrollItemId = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<double>> bodytotalLimitAmount = null, Expression<Func<double>> bodypaidAmount = null, Expression<Func<double>> bodysurplusAmount = null)
        {
            var apiCallPath = "/v3/payroll/updateFixedSalaryDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypayrollItemId != null)
            {
                body["payrollItemId"] = ExpressionConverter.ConvertO(bodypayrollItemId);
                bodypropCount++;
            }

            if (bodymoney != null)
            {
                body["money"] = ExpressionConverter.ConvertO(bodymoney);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodytotalLimitAmount != null)
            {
                body["totalLimitAmount"] = ExpressionConverter.ConvertO(bodytotalLimitAmount);
                bodypropCount++;
            }

            if (bodypaidAmount != null)
            {
                body["paidAmount"] = ExpressionConverter.ConvertO(bodypaidAmount);
                bodypropCount++;
            }

            if (bodysurplusAmount != null)
            {
                body["surplusAmount"] = ExpressionConverter.ConvertO(bodysurplusAmount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3PayrollFixedResp> _004getFixedSalaryDataByEmployeeIdV3(Expression<Func<string>> employeeId)
        {
            var apiCallPath = "/v3/payroll/getFixedSalaryDataByEmployeeId";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            return new ApiConnectionAction<ResultListV3PayrollFixedResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _005addVariableSalaryDataV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodypayrollItemId, Expression<Func<double>> bodymoney, Expression<Func<string>> bodypayrollDate, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodydataType = null)
        {
            var apiCallPath = "/v3/payroll/addVariableSalaryData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["payrollItemId"] = ExpressionConverter.ConvertO(bodypayrollItemId);
            bodypropCount++;
            body["money"] = ExpressionConverter.ConvertO(bodymoney);
            bodypropCount++;
            body["payrollDate"] = ExpressionConverter.ConvertO(bodypayrollDate);
            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodydataType != null)
            {
                body["dataType"] = ExpressionConverter.ConvertO(bodydataType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _006deleteVariableSalaryDataByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/deleteVariableSalaryDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _007updateVariableSalaryDataByIdV3(Expression<Func<string>> bodyid, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/payroll/updateVariableSalaryDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodymoney != null)
            {
                body["money"] = ExpressionConverter.ConvertO(bodymoney);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollNonFixedResp> _008getVariableSalaryDataListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> payrollDateFilter = null, Expression<Func<string>> moneyFilter = null, Expression<Func<string>> payrollItemIdFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> bizLabelIds = null)
        {
            var apiCallPath = "/v3/payroll/getVariableSalaryDataList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (hireTypeFilter != null)
                callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(hireTypeFilter);
            if (payrollDateFilter != null)
                callPayload.Queries["payrollDateFilter"] = ExpressionConverter.Convert(payrollDateFilter);
            if (moneyFilter != null)
                callPayload.Queries["moneyFilter"] = ExpressionConverter.Convert(moneyFilter);
            if (payrollItemIdFilter != null)
                callPayload.Queries["payrollItemIdFilter"] = ExpressionConverter.Convert(payrollItemIdFilter);
            if (calculateSalaryTypeFilter != null)
                callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(calculateSalaryTypeFilter);
            if (bizLabelIds != null)
                callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(bizLabelIds);
            return new ApiConnectionAction<ResultIPageV3PayrollNonFixedResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _009addExternalSalaryDataV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodybusinessSalaryItemId, Expression<Func<double>> bodymoney, Expression<Func<string>> bodyoccurrenceDate, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var apiCallPath = "/v3/payroll/addExternalSalaryData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["businessSalaryItemId"] = ExpressionConverter.ConvertO(bodybusinessSalaryItemId);
            bodypropCount++;
            body["money"] = ExpressionConverter.ConvertO(bodymoney);
            bodypropCount++;
            body["occurrenceDate"] = ExpressionConverter.ConvertO(bodyoccurrenceDate);
            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodyexpirationDate != null)
            {
                body["expirationDate"] = ExpressionConverter.ConvertO(bodyexpirationDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _010deleteExternalSalaryDataByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/deleteExternalSalaryDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _011updateExternalSalaryDataByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyemployeeId = null, Expression<Func<string>> bodybusinessSalaryItemId = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyoccurrenceDate = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var apiCallPath = "/v3/payroll/updateExternalSalaryDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodyemployeeId != null)
            {
                body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
                bodypropCount++;
            }

            if (bodybusinessSalaryItemId != null)
            {
                body["businessSalaryItemId"] = ExpressionConverter.ConvertO(bodybusinessSalaryItemId);
                bodypropCount++;
            }

            if (bodymoney != null)
            {
                body["money"] = ExpressionConverter.ConvertO(bodymoney);
                bodypropCount++;
            }

            if (bodyoccurrenceDate != null)
            {
                body["occurrenceDate"] = ExpressionConverter.ConvertO(bodyoccurrenceDate);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodyexpirationDate != null)
            {
                body["expirationDate"] = ExpressionConverter.ConvertO(bodyexpirationDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayrollResp> _012getExternalSalaryDataListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> businessSalaryItemFilter = null, Expression<Func<string>> occurrenceDateFilter = null, Expression<Func<string>> moneyFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> labelFilter = null)
        {
            var apiCallPath = "/v3/payroll/getExternalSalaryDataList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (hireTypeFilter != null)
                callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(hireTypeFilter);
            if (businessSalaryItemFilter != null)
                callPayload.Queries["businessSalaryItemFilter"] = ExpressionConverter.Convert(businessSalaryItemFilter);
            if (occurrenceDateFilter != null)
                callPayload.Queries["occurrenceDateFilter"] = ExpressionConverter.Convert(occurrenceDateFilter);
            if (moneyFilter != null)
                callPayload.Queries["moneyFilter"] = ExpressionConverter.Convert(moneyFilter);
            if (calculateSalaryTypeFilter != null)
                callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(calculateSalaryTypeFilter);
            if (labelFilter != null)
                callPayload.Queries["labelFilter"] = ExpressionConverter.Convert(labelFilter);
            return new ApiConnectionAction<ResultIPageV3ExternalPayrollResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanResp> _013getPayrollRunListV3(Expression<Func<string>> status, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/payroll/getPayrollRunList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3PayrollPlanResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanDetailResp> _014getPayrollRunDataListV3(Expression<Func<string>> planId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/payroll/getPayrollRunDataList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["planId"] = ExpressionConverter.Convert(planId);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3PayrollPlanDetailResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3PayrollPlanDetailResp> _015getPayrollDetailsInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/getPayrollDetailsInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultListV3PayrollPlanDetailResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollRegResp> _016getPayrollPolicyListV3(Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = "/v3/payroll/getPayrollPolicyList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<ResultIPageV3PayrollRegResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3PayrollRegResp> _017getPayrollPolicyInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/getPayrollPolicyInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3PayrollRegResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollItemResp> _018getPayItemListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> nameFilter = null, Expression<Func<string>> paymentTypeFilter = null, Expression<Func<string>> payrollItemTypeId = null, Expression<Func<string>> statusFilter = null)
        {
            var apiCallPath = "/v3/payroll/getPayItemList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (nameFilter != null)
                callPayload.Queries["nameFilter"] = ExpressionConverter.Convert(nameFilter);
            if (paymentTypeFilter != null)
                callPayload.Queries["paymentTypeFilter"] = ExpressionConverter.Convert(paymentTypeFilter);
            if (payrollItemTypeId != null)
                callPayload.Queries["payrollItemTypeId"] = ExpressionConverter.Convert(payrollItemTypeId);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            return new ApiConnectionAction<ResultIPageV3PayrollItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3PayrollItemResp> _019getPayItemInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/getPayItemInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3PayrollItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayItemResp> _020getExternalPayItemListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/payroll/getExternalPayItemList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3ExternalPayItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3ExternalPayItemResp> _021getExternalPayItemInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/getExternalPayItemInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3ExternalPayItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _022addWorkPatternInfoV3(Expression<Func<string>> bodyname, Expression<Func<double>> bodyworkHoursForDay, Expression<Func<double>> bodyworkHoursForWeek, Expression<Func<double>> bodyworkHoursForYear, Expression<Func<double>> bodytotalHours, Expression<Func<string>> bodycycleType, Expression<Func<string>> bodyadvancedSetting = null, Expression<Func<string>> bodynumber = null, Expression<Func<string>> bodyfte = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodysalaryCalculationStyle = null, Expression<Func<int>> bodyworkTime = null, Expression<Func<string>> bodydoubleWeekBaseDate = null, Expression<Func<string>> bodyweekSalaryType = null, Expression<Func<int>> bodyisThisWeek = null, Expression<Func<V3TermsSettingInsert[]>> bodysettingList = null)
        {
            var apiCallPath = "/v3/payroll/addWorkPatternInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyadvancedSetting != null)
            {
                body["advancedSetting"] = ExpressionConverter.ConvertO(bodyadvancedSetting);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["workHoursForDay"] = ExpressionConverter.ConvertO(bodyworkHoursForDay);
            bodypropCount++;
            body["workHoursForWeek"] = ExpressionConverter.ConvertO(bodyworkHoursForWeek);
            bodypropCount++;
            body["workHoursForYear"] = ExpressionConverter.ConvertO(bodyworkHoursForYear);
            bodypropCount++;
            body["totalHours"] = ExpressionConverter.ConvertO(bodytotalHours);
            bodypropCount++;
            body["cycleType"] = ExpressionConverter.ConvertO(bodycycleType);
            if (bodyfte != null)
            {
                body["fte"] = ExpressionConverter.ConvertO(bodyfte);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodysalaryCalculationStyle != null)
            {
                body["salaryCalculationStyle"] = ExpressionConverter.ConvertO(bodysalaryCalculationStyle);
                bodypropCount++;
            }

            if (bodyworkTime != null)
            {
                body["workTime"] = ExpressionConverter.ConvertO(bodyworkTime);
                bodypropCount++;
            }

            if (bodydoubleWeekBaseDate != null)
            {
                body["doubleWeekBaseDate"] = ExpressionConverter.ConvertO(bodydoubleWeekBaseDate);
                bodypropCount++;
            }

            if (bodyweekSalaryType != null)
            {
                body["weekSalaryType"] = ExpressionConverter.ConvertO(bodyweekSalaryType);
                bodypropCount++;
            }

            if (bodyisThisWeek != null)
            {
                body["isThisWeek"] = ExpressionConverter.ConvertO(bodyisThisWeek);
                bodypropCount++;
            }

            if (bodysettingList != null)
            {
                body["settingList"] = ExpressionConverter.ConvertO(bodysettingList);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _023updateWorkPatternByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyadvancedSetting = null, Expression<Func<string>> bodynumber = null, Expression<Func<string>> bodyname = null, Expression<Func<double>> bodyworkHoursForDay = null, Expression<Func<double>> bodyworkHoursForWeek = null, Expression<Func<double>> bodyworkHoursForYear = null, Expression<Func<double>> bodytotalHours = null, Expression<Func<string>> bodycycleType = null, Expression<Func<string>> bodyfte = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodysalaryCalculationStyle = null, Expression<Func<int>> bodyworkTime = null, Expression<Func<string>> bodydoubleWeekBaseDate = null, Expression<Func<string>> bodyweekSalaryType = null, Expression<Func<int>> bodyisThisWeek = null, Expression<Func<string>> bodytermsWorkDefaultId = null, Expression<Func<V3TermsSettingUpdate[]>> bodysettingList = null)
        {
            var apiCallPath = "/v3/payroll/updateWorkPatternById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyadvancedSetting != null)
            {
                body["advancedSetting"] = ExpressionConverter.ConvertO(bodyadvancedSetting);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyworkHoursForDay != null)
            {
                body["workHoursForDay"] = ExpressionConverter.ConvertO(bodyworkHoursForDay);
                bodypropCount++;
            }

            if (bodyworkHoursForWeek != null)
            {
                body["workHoursForWeek"] = ExpressionConverter.ConvertO(bodyworkHoursForWeek);
                bodypropCount++;
            }

            if (bodyworkHoursForYear != null)
            {
                body["workHoursForYear"] = ExpressionConverter.ConvertO(bodyworkHoursForYear);
                bodypropCount++;
            }

            if (bodytotalHours != null)
            {
                body["totalHours"] = ExpressionConverter.ConvertO(bodytotalHours);
                bodypropCount++;
            }

            if (bodycycleType != null)
            {
                body["cycleType"] = ExpressionConverter.ConvertO(bodycycleType);
                bodypropCount++;
            }

            if (bodyfte != null)
            {
                body["fte"] = ExpressionConverter.ConvertO(bodyfte);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodysalaryCalculationStyle != null)
            {
                body["salaryCalculationStyle"] = ExpressionConverter.ConvertO(bodysalaryCalculationStyle);
                bodypropCount++;
            }

            if (bodyworkTime != null)
            {
                body["workTime"] = ExpressionConverter.ConvertO(bodyworkTime);
                bodypropCount++;
            }

            if (bodydoubleWeekBaseDate != null)
            {
                body["doubleWeekBaseDate"] = ExpressionConverter.ConvertO(bodydoubleWeekBaseDate);
                bodypropCount++;
            }

            if (bodyweekSalaryType != null)
            {
                body["weekSalaryType"] = ExpressionConverter.ConvertO(bodyweekSalaryType);
                bodypropCount++;
            }

            if (bodyisThisWeek != null)
            {
                body["isThisWeek"] = ExpressionConverter.ConvertO(bodyisThisWeek);
                bodypropCount++;
            }

            if (bodytermsWorkDefaultId != null)
            {
                body["termsWorkDefaultId"] = ExpressionConverter.ConvertO(bodytermsWorkDefaultId);
                bodypropCount++;
            }

            if (bodysettingList != null)
            {
                body["settingList"] = ExpressionConverter.ConvertO(bodysettingList);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _024deleteWorkPatternByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/deleteWorkPatternById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3WorkPatternSummaryResp> _025getWorkPatternListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/payroll/getWorkPatternList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3WorkPatternSummaryResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3WorkPatternResp> _026getWorkPatternInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/payroll/getWorkPatternInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3WorkPatternResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3TenantResp> _001getCompanyInfoV3()
        {
            var apiCallPath = "/v3/company/getCompanyInfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultV3TenantResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3SysEnterpriseUserResp> _002getUserListV3()
        {
            var apiCallPath = "/v3/company/getUserList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultListV3SysEnterpriseUserResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3SysEnterpriseUserResp> _003getUserInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/company/getUserInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3SysEnterpriseUserResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _004addLocationInfoV3(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddress, Expression<Func<double>> bodylongitude, Expression<Func<double>> bodylatitude, Expression<Func<string>> bodyareaCode, Expression<Func<int>> bodyregion = null, Expression<Func<bool>> bodyisEnableGps = null, Expression<Func<bool>> bodyisEnableBluetooth = null, Expression<Func<string>> bodyattendanceAddressCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymapType = null)
        {
            var apiCallPath = "/v3/company/addLocationInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["address"] = ExpressionConverter.ConvertO(bodyaddress);
            bodypropCount++;
            body["longitude"] = ExpressionConverter.ConvertO(bodylongitude);
            bodypropCount++;
            body["latitude"] = ExpressionConverter.ConvertO(bodylatitude);
            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodyisEnableGps != null)
            {
                body["isEnableGps"] = ExpressionConverter.ConvertO(bodyisEnableGps);
                bodypropCount++;
            }

            if (bodyisEnableBluetooth != null)
            {
                body["isEnableBluetooth"] = ExpressionConverter.ConvertO(bodyisEnableBluetooth);
                bodypropCount++;
            }

            if (bodyattendanceAddressCode != null)
            {
                body["attendanceAddressCode"] = ExpressionConverter.ConvertO(bodyattendanceAddressCode);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodymapType != null)
            {
                body["mapType"] = ExpressionConverter.ConvertO(bodymapType);
                bodypropCount++;
            }

            bodypropCount++;
            body["areaCode"] = ExpressionConverter.ConvertO(bodyareaCode);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _005deleteLocationByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/company/deleteLocationById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _006updateLocationByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyaddress = null, Expression<Func<double>> bodylongitude = null, Expression<Func<double>> bodylatitude = null, Expression<Func<int>> bodyregion = null, Expression<Func<bool>> bodyisEnableGps = null, Expression<Func<bool>> bodyisEnableBluetooth = null, Expression<Func<string>> bodyattendanceAddressCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymapType = null, Expression<Func<string>> bodyareaCode = null)
        {
            var apiCallPath = "/v3/company/updateLocationById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodylongitude != null)
            {
                body["longitude"] = ExpressionConverter.ConvertO(bodylongitude);
                bodypropCount++;
            }

            if (bodylatitude != null)
            {
                body["latitude"] = ExpressionConverter.ConvertO(bodylatitude);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodyisEnableGps != null)
            {
                body["isEnableGps"] = ExpressionConverter.ConvertO(bodyisEnableGps);
                bodypropCount++;
            }

            if (bodyisEnableBluetooth != null)
            {
                body["isEnableBluetooth"] = ExpressionConverter.ConvertO(bodyisEnableBluetooth);
                bodypropCount++;
            }

            if (bodyattendanceAddressCode != null)
            {
                body["attendanceAddressCode"] = ExpressionConverter.ConvertO(bodyattendanceAddressCode);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodymapType != null)
            {
                body["mapType"] = ExpressionConverter.ConvertO(bodymapType);
                bodypropCount++;
            }

            if (bodyareaCode != null)
            {
                body["areaCode"] = ExpressionConverter.ConvertO(bodyareaCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3AttAddressResp> _007getLocationListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/company/getLocationList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3AttAddressResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AttAddressResp> _008getLocationInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/company/getLocationInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3AttAddressResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AttRuleResp> _009getLocationAttendanceRulesByIdV3(Expression<Func<string>> workLocationId)
        {
            var apiCallPath = "/v3/company/getLocationAttendanceRulesById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workLocationId"] = ExpressionConverter.Convert(workLocationId);
            return new ApiConnectionAction<ResultV3AttRuleResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _010addDepartmentInfoV3(Expression<Func<string>> bodyname, Expression<Func<string>> bodydepartmentCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var apiCallPath = "/v3/company/addDepartmentInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydepartmentCode != null)
            {
                body["departmentCode"] = ExpressionConverter.ConvertO(bodydepartmentCode);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _011deleteDepartmentByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/company/deleteDepartmentById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _012updateDepartmentByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydepartmentCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var apiCallPath = "/v3/company/updateDepartmentById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydepartmentCode != null)
            {
                body["departmentCode"] = ExpressionConverter.ConvertO(bodydepartmentCode);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3DepartmentResp> _013getDepartmentListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/company/getDepartmentList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3DepartmentResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _014addPositionInfoV3(Expression<Func<string>> bodyname, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = "/v3/company/addPositionInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypositionCode != null)
            {
                body["positionCode"] = ExpressionConverter.ConvertO(bodypositionCode);
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

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _015deletePositionByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/company/deletePositionById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _016updatePositionByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = "/v3/company/updatePositionById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypositionCode != null)
            {
                body["positionCode"] = ExpressionConverter.ConvertO(bodypositionCode);
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

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PositionResp> _017getPositionListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/company/getPositionList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3PositionResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _018addCostCenterInfoV3(Expression<Func<string>> bodyname, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = "/v3/company/addCostCenterInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodycostCenterCode != null)
            {
                body["costCenterCode"] = ExpressionConverter.ConvertO(bodycostCenterCode);
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

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _019deleteCostCenterByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/company/deleteCostCenterById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _020updateCostCenterByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = "/v3/company/updateCostCenterById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycostCenterCode != null)
            {
                body["costCenterCode"] = ExpressionConverter.ConvertO(bodycostCenterCode);
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

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3CostCenterResp> _021getCostCenterListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/company/getCostCenterList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3CostCenterResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _022addTagInfoV3(Expression<Func<string>> bodylabelName, Expression<Func<string>> bodylabelCode = null, Expression<Func<int>> bodylabelStatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var apiCallPath = "/v3/company/addTagInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylabelCode != null)
            {
                body["labelCode"] = ExpressionConverter.ConvertO(bodylabelCode);
                bodypropCount++;
            }

            bodypropCount++;
            body["labelName"] = ExpressionConverter.ConvertO(bodylabelName);
            if (bodylabelStatus != null)
            {
                body["labelStatus"] = ExpressionConverter.ConvertO(bodylabelStatus);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _023deleteTagByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/company/deleteTagById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _024updateTagByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodylabelCode = null, Expression<Func<string>> bodylabelName = null, Expression<Func<int>> bodylabelStatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var apiCallPath = "/v3/company/updateTagById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodylabelCode != null)
            {
                body["labelCode"] = ExpressionConverter.ConvertO(bodylabelCode);
                bodypropCount++;
            }

            if (bodylabelName != null)
            {
                body["labelName"] = ExpressionConverter.ConvertO(bodylabelName);
                bodypropCount++;
            }

            if (bodylabelStatus != null)
            {
                body["labelStatus"] = ExpressionConverter.ConvertO(bodylabelStatus);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LabelResp> _025getTagListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/company/getTagList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3LabelResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3DeviceResp> _026getDeviceListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/company/getDeviceList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3DeviceResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddEmployeeResp> _01addEmployeeInfoV3(Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodyenglishName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyemployeeStatus = null, Expression<Func<string>> bodysex = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyidentityCard = null, Expression<Func<string>> bodychineseName = null, Expression<Func<string>> bodysurnameEnglish = null, Expression<Func<string>> bodypersonalNameEnglish = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<string>> bodyemergencyContactRelation = null, Expression<Func<string>> bodyemergencyContactPhone = null, Expression<Func<string>> bodybankCode = null, Expression<Func<string>> bodybankBranchNumber = null, Expression<Func<string>> bodybankAccountNo = null, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodydate1 = null, Expression<Func<string>> bodydate2 = null, Expression<Func<string>> bodydate3 = null, Expression<Func<string>> bodydate4 = null, Expression<Func<string>> bodytext1 = null, Expression<Func<string>> bodytext2 = null, Expression<Func<string>> bodytext3 = null, Expression<Func<string>> bodytext4 = null, Expression<Func<string>> bodytext5 = null, Expression<Func<string>> bodytext6 = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodymobileCardCalType = null, Expression<Func<string>> bodyregularType = null, Expression<Func<string>> bodyinsurePlanName = null, Expression<Func<string>> bodybizLabelIds = null)
        {
            var apiCallPath = "/v3/employee/addEmployeeInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["entryDate"] = ExpressionConverter.ConvertO(bodyentryDate);
            bodypropCount++;
            body["englishName"] = ExpressionConverter.ConvertO(bodyenglishName);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodyemployeeStatus != null)
            {
                body["employeeStatus"] = ExpressionConverter.ConvertO(bodyemployeeStatus);
                bodypropCount++;
            }

            if (bodysex != null)
            {
                body["sex"] = ExpressionConverter.ConvertO(bodysex);
                bodypropCount++;
            }

            if (bodynationality != null)
            {
                body["nationality"] = ExpressionConverter.ConvertO(bodynationality);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["maritalStatus"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            if (bodycountryCode != null)
            {
                body["countryCode"] = ExpressionConverter.ConvertO(bodycountryCode);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
            }

            if (bodycalculateSalaryType != null)
            {
                body["calculateSalaryType"] = ExpressionConverter.ConvertO(bodycalculateSalaryType);
                bodypropCount++;
            }

            if (bodyworkDate != null)
            {
                body["workDate"] = ExpressionConverter.ConvertO(bodyworkDate);
                bodypropCount++;
            }

            if (bodybasicPay != null)
            {
                body["basicPay"] = ExpressionConverter.ConvertO(bodybasicPay);
                bodypropCount++;
            }

            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodyidentityCard != null)
            {
                body["identityCard"] = ExpressionConverter.ConvertO(bodyidentityCard);
                bodypropCount++;
            }

            if (bodychineseName != null)
            {
                body["chineseName"] = ExpressionConverter.ConvertO(bodychineseName);
                bodypropCount++;
            }

            if (bodysurnameEnglish != null)
            {
                body["surnameEnglish"] = ExpressionConverter.ConvertO(bodysurnameEnglish);
                bodypropCount++;
            }

            if (bodypersonalNameEnglish != null)
            {
                body["personalNameEnglish"] = ExpressionConverter.ConvertO(bodypersonalNameEnglish);
                bodypropCount++;
            }

            if (bodybirthday != null)
            {
                body["birthday"] = ExpressionConverter.ConvertO(bodybirthday);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodyemergencyContactName != null)
            {
                body["emergencyContactName"] = ExpressionConverter.ConvertO(bodyemergencyContactName);
                bodypropCount++;
            }

            if (bodyemergencyContactRelation != null)
            {
                body["emergencyContactRelation"] = ExpressionConverter.ConvertO(bodyemergencyContactRelation);
                bodypropCount++;
            }

            if (bodyemergencyContactPhone != null)
            {
                body["emergencyContactPhone"] = ExpressionConverter.ConvertO(bodyemergencyContactPhone);
                bodypropCount++;
            }

            if (bodybankCode != null)
            {
                body["bankCode"] = ExpressionConverter.ConvertO(bodybankCode);
                bodypropCount++;
            }

            if (bodybankBranchNumber != null)
            {
                body["bankBranchNumber"] = ExpressionConverter.ConvertO(bodybankBranchNumber);
                bodypropCount++;
            }

            if (bodybankAccountNo != null)
            {
                body["bankAccountNo"] = ExpressionConverter.ConvertO(bodybankAccountNo);
                bodypropCount++;
            }

            if (bodyconfirmationDate != null)
            {
                body["confirmationDate"] = ExpressionConverter.ConvertO(bodyconfirmationDate);
                bodypropCount++;
            }

            if (bodydate1 != null)
            {
                body["date1"] = ExpressionConverter.ConvertO(bodydate1);
                bodypropCount++;
            }

            if (bodydate2 != null)
            {
                body["date2"] = ExpressionConverter.ConvertO(bodydate2);
                bodypropCount++;
            }

            if (bodydate3 != null)
            {
                body["date3"] = ExpressionConverter.ConvertO(bodydate3);
                bodypropCount++;
            }

            if (bodydate4 != null)
            {
                body["date4"] = ExpressionConverter.ConvertO(bodydate4);
                bodypropCount++;
            }

            if (bodytext1 != null)
            {
                body["text1"] = ExpressionConverter.ConvertO(bodytext1);
                bodypropCount++;
            }

            if (bodytext2 != null)
            {
                body["text2"] = ExpressionConverter.ConvertO(bodytext2);
                bodypropCount++;
            }

            if (bodytext3 != null)
            {
                body["text3"] = ExpressionConverter.ConvertO(bodytext3);
                bodypropCount++;
            }

            if (bodytext4 != null)
            {
                body["text4"] = ExpressionConverter.ConvertO(bodytext4);
                bodypropCount++;
            }

            if (bodytext5 != null)
            {
                body["text5"] = ExpressionConverter.ConvertO(bodytext5);
                bodypropCount++;
            }

            if (bodytext6 != null)
            {
                body["text6"] = ExpressionConverter.ConvertO(bodytext6);
                bodypropCount++;
            }

            if (bodydirectSupervisorId != null)
            {
                body["directSupervisorId"] = ExpressionConverter.ConvertO(bodydirectSupervisorId);
                bodypropCount++;
            }

            if (bodydepartmentId != null)
            {
                body["departmentId"] = ExpressionConverter.ConvertO(bodydepartmentId);
                bodypropCount++;
            }

            if (bodypositionId != null)
            {
                body["positionId"] = ExpressionConverter.ConvertO(bodypositionId);
                bodypropCount++;
            }

            if (bodyhireType != null)
            {
                body["hireType"] = ExpressionConverter.ConvertO(bodyhireType);
                bodypropCount++;
            }

            if (bodypayrollRegulationId != null)
            {
                body["payrollRegulationId"] = ExpressionConverter.ConvertO(bodypayrollRegulationId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyattendCalculationId != null)
            {
                body["attendCalculationId"] = ExpressionConverter.ConvertO(bodyattendCalculationId);
                bodypropCount++;
            }

            if (bodymobileCardCalType != null)
            {
                body["mobileCardCalType"] = ExpressionConverter.ConvertO(bodymobileCardCalType);
                bodypropCount++;
            }

            if (bodyregularType != null)
            {
                body["regularType"] = ExpressionConverter.ConvertO(bodyregularType);
                bodypropCount++;
            }

            if (bodyinsurePlanName != null)
            {
                body["insurePlanName"] = ExpressionConverter.ConvertO(bodyinsurePlanName);
                bodypropCount++;
            }

            if (bodybizLabelIds != null)
            {
                body["bizLabelIds"] = ExpressionConverter.ConvertO(bodybizLabelIds);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3AddEmployeeResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _02deleteEmployeeByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/employee/deleteAllData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _03updateEmployeeByIdV3(Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodyenglishName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyemployeeStatus = null, Expression<Func<string>> bodysex = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyidentityCard = null, Expression<Func<string>> bodychineseName = null, Expression<Func<string>> bodysurnameEnglish = null, Expression<Func<string>> bodypersonalNameEnglish = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<string>> bodyemergencyContactRelation = null, Expression<Func<string>> bodyemergencyContactPhone = null, Expression<Func<string>> bodybankCode = null, Expression<Func<string>> bodybankBranchNumber = null, Expression<Func<string>> bodybankAccountNo = null, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodydate1 = null, Expression<Func<string>> bodydate2 = null, Expression<Func<string>> bodydate3 = null, Expression<Func<string>> bodydate4 = null, Expression<Func<string>> bodytext1 = null, Expression<Func<string>> bodytext2 = null, Expression<Func<string>> bodytext3 = null, Expression<Func<string>> bodytext4 = null, Expression<Func<string>> bodytext5 = null, Expression<Func<string>> bodytext6 = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodymobileCardCalType = null, Expression<Func<string>> bodyregularType = null, Expression<Func<string>> bodyinsurePlanName = null, Expression<Func<string>> bodybizLabelIds = null)
        {
            var apiCallPath = "/v3/employee/updateEmployeeById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["entryDate"] = ExpressionConverter.ConvertO(bodyentryDate);
            bodypropCount++;
            body["englishName"] = ExpressionConverter.ConvertO(bodyenglishName);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodyemployeeStatus != null)
            {
                body["employeeStatus"] = ExpressionConverter.ConvertO(bodyemployeeStatus);
                bodypropCount++;
            }

            if (bodysex != null)
            {
                body["sex"] = ExpressionConverter.ConvertO(bodysex);
                bodypropCount++;
            }

            if (bodynationality != null)
            {
                body["nationality"] = ExpressionConverter.ConvertO(bodynationality);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["maritalStatus"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            if (bodycountryCode != null)
            {
                body["countryCode"] = ExpressionConverter.ConvertO(bodycountryCode);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
            }

            if (bodycalculateSalaryType != null)
            {
                body["calculateSalaryType"] = ExpressionConverter.ConvertO(bodycalculateSalaryType);
                bodypropCount++;
            }

            if (bodyworkDate != null)
            {
                body["workDate"] = ExpressionConverter.ConvertO(bodyworkDate);
                bodypropCount++;
            }

            if (bodybasicPay != null)
            {
                body["basicPay"] = ExpressionConverter.ConvertO(bodybasicPay);
                bodypropCount++;
            }

            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodyidentityCard != null)
            {
                body["identityCard"] = ExpressionConverter.ConvertO(bodyidentityCard);
                bodypropCount++;
            }

            if (bodychineseName != null)
            {
                body["chineseName"] = ExpressionConverter.ConvertO(bodychineseName);
                bodypropCount++;
            }

            if (bodysurnameEnglish != null)
            {
                body["surnameEnglish"] = ExpressionConverter.ConvertO(bodysurnameEnglish);
                bodypropCount++;
            }

            if (bodypersonalNameEnglish != null)
            {
                body["personalNameEnglish"] = ExpressionConverter.ConvertO(bodypersonalNameEnglish);
                bodypropCount++;
            }

            if (bodybirthday != null)
            {
                body["birthday"] = ExpressionConverter.ConvertO(bodybirthday);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodyemergencyContactName != null)
            {
                body["emergencyContactName"] = ExpressionConverter.ConvertO(bodyemergencyContactName);
                bodypropCount++;
            }

            if (bodyemergencyContactRelation != null)
            {
                body["emergencyContactRelation"] = ExpressionConverter.ConvertO(bodyemergencyContactRelation);
                bodypropCount++;
            }

            if (bodyemergencyContactPhone != null)
            {
                body["emergencyContactPhone"] = ExpressionConverter.ConvertO(bodyemergencyContactPhone);
                bodypropCount++;
            }

            if (bodybankCode != null)
            {
                body["bankCode"] = ExpressionConverter.ConvertO(bodybankCode);
                bodypropCount++;
            }

            if (bodybankBranchNumber != null)
            {
                body["bankBranchNumber"] = ExpressionConverter.ConvertO(bodybankBranchNumber);
                bodypropCount++;
            }

            if (bodybankAccountNo != null)
            {
                body["bankAccountNo"] = ExpressionConverter.ConvertO(bodybankAccountNo);
                bodypropCount++;
            }

            if (bodyconfirmationDate != null)
            {
                body["confirmationDate"] = ExpressionConverter.ConvertO(bodyconfirmationDate);
                bodypropCount++;
            }

            if (bodydate1 != null)
            {
                body["date1"] = ExpressionConverter.ConvertO(bodydate1);
                bodypropCount++;
            }

            if (bodydate2 != null)
            {
                body["date2"] = ExpressionConverter.ConvertO(bodydate2);
                bodypropCount++;
            }

            if (bodydate3 != null)
            {
                body["date3"] = ExpressionConverter.ConvertO(bodydate3);
                bodypropCount++;
            }

            if (bodydate4 != null)
            {
                body["date4"] = ExpressionConverter.ConvertO(bodydate4);
                bodypropCount++;
            }

            if (bodytext1 != null)
            {
                body["text1"] = ExpressionConverter.ConvertO(bodytext1);
                bodypropCount++;
            }

            if (bodytext2 != null)
            {
                body["text2"] = ExpressionConverter.ConvertO(bodytext2);
                bodypropCount++;
            }

            if (bodytext3 != null)
            {
                body["text3"] = ExpressionConverter.ConvertO(bodytext3);
                bodypropCount++;
            }

            if (bodytext4 != null)
            {
                body["text4"] = ExpressionConverter.ConvertO(bodytext4);
                bodypropCount++;
            }

            if (bodytext5 != null)
            {
                body["text5"] = ExpressionConverter.ConvertO(bodytext5);
                bodypropCount++;
            }

            if (bodytext6 != null)
            {
                body["text6"] = ExpressionConverter.ConvertO(bodytext6);
                bodypropCount++;
            }

            if (bodydirectSupervisorId != null)
            {
                body["directSupervisorId"] = ExpressionConverter.ConvertO(bodydirectSupervisorId);
                bodypropCount++;
            }

            if (bodydepartmentId != null)
            {
                body["departmentId"] = ExpressionConverter.ConvertO(bodydepartmentId);
                bodypropCount++;
            }

            if (bodypositionId != null)
            {
                body["positionId"] = ExpressionConverter.ConvertO(bodypositionId);
                bodypropCount++;
            }

            if (bodyhireType != null)
            {
                body["hireType"] = ExpressionConverter.ConvertO(bodyhireType);
                bodypropCount++;
            }

            if (bodypayrollRegulationId != null)
            {
                body["payrollRegulationId"] = ExpressionConverter.ConvertO(bodypayrollRegulationId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyattendCalculationId != null)
            {
                body["attendCalculationId"] = ExpressionConverter.ConvertO(bodyattendCalculationId);
                bodypropCount++;
            }

            if (bodymobileCardCalType != null)
            {
                body["mobileCardCalType"] = ExpressionConverter.ConvertO(bodymobileCardCalType);
                bodypropCount++;
            }

            if (bodyregularType != null)
            {
                body["regularType"] = ExpressionConverter.ConvertO(bodyregularType);
                bodypropCount++;
            }

            if (bodyinsurePlanName != null)
            {
                body["insurePlanName"] = ExpressionConverter.ConvertO(bodyinsurePlanName);
                bodypropCount++;
            }

            if (bodybizLabelIds != null)
            {
                body["bizLabelIds"] = ExpressionConverter.ConvertO(bodybizLabelIds);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeListResp> _04getEmployeeListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> id = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> sex = null, Expression<Func<int>> status = null, Expression<Func<string>> hireType = null, Expression<Func<string>> calculateSalaryType = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> payrollRegulationId = null, Expression<Func<string>> regularType = null)
        {
            var apiCallPath = "/v3/employee/getEmployeeList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (departmentId != null)
                callPayload.Queries["departmentId"] = ExpressionConverter.Convert(departmentId);
            if (positionId != null)
                callPayload.Queries["positionId"] = ExpressionConverter.Convert(positionId);
            if (sex != null)
                callPayload.Queries["sex"] = ExpressionConverter.Convert(sex);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (hireType != null)
                callPayload.Queries["hireType"] = ExpressionConverter.Convert(hireType);
            if (calculateSalaryType != null)
                callPayload.Queries["calculateSalaryType"] = ExpressionConverter.Convert(calculateSalaryType);
            if (costCenterId != null)
                callPayload.Queries["costCenterId"] = ExpressionConverter.Convert(costCenterId);
            if (payrollRegulationId != null)
                callPayload.Queries["payrollRegulationId"] = ExpressionConverter.Convert(payrollRegulationId);
            if (regularType != null)
                callPayload.Queries["regularType"] = ExpressionConverter.Convert(regularType);
            return new ApiConnectionAction<ResultIPageV3EmployeeListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3EmployeeInfoResp> _05getEmployeeInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/employee/getEmployeeInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3EmployeeInfoResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _06resignV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodylastWorkingDate, Expression<Func<string>> bodyreasonsLeave, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/employee/resign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["lastWorkingDate"] = ExpressionConverter.ConvertO(bodylastWorkingDate);
            bodypropCount++;
            body["reasonsLeave"] = ExpressionConverter.ConvertO(bodyreasonsLeave);
            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddEmployeeHistoryResp> _07addEmployeeHistoryV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodytakeEffectType, Expression<Func<string>> bodytakeEffectDate, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<string>> bodycause = null, Expression<Func<string>> bodymajorWorkLocationId = null)
        {
            var apiCallPath = "/v3/employee/addEmployeeHistory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["entryDate"] = ExpressionConverter.ConvertO(bodyentryDate);
            if (bodyconfirmationDate != null)
            {
                body["confirmationDate"] = ExpressionConverter.ConvertO(bodyconfirmationDate);
                bodypropCount++;
            }

            if (bodyhireType != null)
            {
                body["hireType"] = ExpressionConverter.ConvertO(bodyhireType);
                bodypropCount++;
            }

            if (bodypositionId != null)
            {
                body["positionId"] = ExpressionConverter.ConvertO(bodypositionId);
                bodypropCount++;
            }

            if (bodydepartmentId != null)
            {
                body["departmentId"] = ExpressionConverter.ConvertO(bodydepartmentId);
                bodypropCount++;
            }

            if (bodydirectSupervisorId != null)
            {
                body["directSupervisorId"] = ExpressionConverter.ConvertO(bodydirectSupervisorId);
                bodypropCount++;
            }

            if (bodyattendCalculationId != null)
            {
                body["attendCalculationId"] = ExpressionConverter.ConvertO(bodyattendCalculationId);
                bodypropCount++;
            }

            if (bodypayrollRegulationId != null)
            {
                body["payrollRegulationId"] = ExpressionConverter.ConvertO(bodypayrollRegulationId);
                bodypropCount++;
            }

            if (bodybasicPay != null)
            {
                body["basicPay"] = ExpressionConverter.ConvertO(bodybasicPay);
                bodypropCount++;
            }

            if (bodycalculateSalaryType != null)
            {
                body["calculateSalaryType"] = ExpressionConverter.ConvertO(bodycalculateSalaryType);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyworkDate != null)
            {
                body["workDate"] = ExpressionConverter.ConvertO(bodyworkDate);
                bodypropCount++;
            }

            if (bodycause != null)
            {
                body["cause"] = ExpressionConverter.ConvertO(bodycause);
                bodypropCount++;
            }

            if (bodymajorWorkLocationId != null)
            {
                body["majorWorkLocationId"] = ExpressionConverter.ConvertO(bodymajorWorkLocationId);
                bodypropCount++;
            }

            bodypropCount++;
            body["takeEffectType"] = ExpressionConverter.ConvertO(bodytakeEffectType);
            bodypropCount++;
            body["takeEffectDate"] = ExpressionConverter.ConvertO(bodytakeEffectDate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3AddEmployeeHistoryResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteEmployeeHistoryByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/employee/deleteEmployeeHistoryById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _09updateEmployeeHistoryByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<string>> bodycause = null, Expression<Func<string>> bodymajorWorkLocationId = null)
        {
            var apiCallPath = "/v3/employee/updateEmployeeHistoryById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["entryDate"] = ExpressionConverter.ConvertO(bodyentryDate);
            if (bodyconfirmationDate != null)
            {
                body["confirmationDate"] = ExpressionConverter.ConvertO(bodyconfirmationDate);
                bodypropCount++;
            }

            if (bodyhireType != null)
            {
                body["hireType"] = ExpressionConverter.ConvertO(bodyhireType);
                bodypropCount++;
            }

            if (bodypositionId != null)
            {
                body["positionId"] = ExpressionConverter.ConvertO(bodypositionId);
                bodypropCount++;
            }

            if (bodydepartmentId != null)
            {
                body["departmentId"] = ExpressionConverter.ConvertO(bodydepartmentId);
                bodypropCount++;
            }

            if (bodydirectSupervisorId != null)
            {
                body["directSupervisorId"] = ExpressionConverter.ConvertO(bodydirectSupervisorId);
                bodypropCount++;
            }

            if (bodyattendCalculationId != null)
            {
                body["attendCalculationId"] = ExpressionConverter.ConvertO(bodyattendCalculationId);
                bodypropCount++;
            }

            if (bodypayrollRegulationId != null)
            {
                body["payrollRegulationId"] = ExpressionConverter.ConvertO(bodypayrollRegulationId);
                bodypropCount++;
            }

            if (bodybasicPay != null)
            {
                body["basicPay"] = ExpressionConverter.ConvertO(bodybasicPay);
                bodypropCount++;
            }

            if (bodycalculateSalaryType != null)
            {
                body["calculateSalaryType"] = ExpressionConverter.ConvertO(bodycalculateSalaryType);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyworkDate != null)
            {
                body["workDate"] = ExpressionConverter.ConvertO(bodyworkDate);
                bodypropCount++;
            }

            if (bodycause != null)
            {
                body["cause"] = ExpressionConverter.ConvertO(bodycause);
                bodypropCount++;
            }

            if (bodymajorWorkLocationId != null)
            {
                body["majorWorkLocationId"] = ExpressionConverter.ConvertO(bodymajorWorkLocationId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeHistoryListResp> _10getEmployeeHistoryListV3(Expression<Func<string>> employeeId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/employee/getEmployeeHistoryList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3EmployeeHistoryListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _01addLeaveBalanceAdjustInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyholidayType, Expression<Func<string>> bodyoccurrenceTime, Expression<Func<string>> bodycause, Expression<Func<string>> bodyadjust)
        {
            var apiCallPath = "/v3/leave/addLeaveBalanceAdjustInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["holidayType"] = ExpressionConverter.ConvertO(bodyholidayType);
            bodypropCount++;
            body["occurrenceTime"] = ExpressionConverter.ConvertO(bodyoccurrenceTime);
            bodypropCount++;
            body["cause"] = ExpressionConverter.ConvertO(bodycause);
            bodypropCount++;
            body["adjust"] = ExpressionConverter.ConvertO(bodyadjust);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _02deleteLeaveBalanceAdjustmentByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/leave/deleteLeaveBalanceAdjustmentById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayBalanceResp> _03getLeaveBalanceAdjustmentListV3(Expression<Func<string>> employeeId, Expression<Func<string>> holidayType, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/leave/getLeaveBalanceAdjustmentList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            callPayload.Queries["holidayType"] = ExpressionConverter.Convert(holidayType);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3LeaveHolidayBalanceResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _04calculationLeaveBalanceV3(Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodyisForceCal = null, Expression<Func<string[]>> bodyemployeeIdsList = null, Expression<Func<string[]>> bodyposition = null, Expression<Func<string[]>> bodydept = null)
        {
            var apiCallPath = "/v3/leave/calculationLeaveBalance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyisForceCal != null)
            {
                body["isForceCal"] = ExpressionConverter.ConvertO(bodyisForceCal);
                bodypropCount++;
            }

            if (bodyemployeeIdsList != null)
            {
                body["employeeIdsList"] = ExpressionConverter.ConvertO(bodyemployeeIdsList);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodyposition);
                bodypropCount++;
            }

            if (bodydept != null)
            {
                body["dept"] = ExpressionConverter.ConvertO(bodydept);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveBalanceResp> _05getLeaveBalanceListV3(Expression<Func<string>> holidayType, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> regularTypeFilter = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> sexFilter = null, Expression<Func<string>> leaveHolidayBalanceStatusFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> bizLabelIds = null)
        {
            var apiCallPath = "/v3/leave/getLeaveBalanceList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["holidayType"] = ExpressionConverter.Convert(holidayType);
            if (regularTypeFilter != null)
                callPayload.Queries["regularTypeFilter"] = ExpressionConverter.Convert(regularTypeFilter);
            if (departmentFilter != null)
                callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(departmentFilter);
            if (positionFilter != null)
                callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(positionFilter);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (sexFilter != null)
                callPayload.Queries["sexFilter"] = ExpressionConverter.Convert(sexFilter);
            if (leaveHolidayBalanceStatusFilter != null)
                callPayload.Queries["leaveHolidayBalanceStatusFilter"] = ExpressionConverter.Convert(leaveHolidayBalanceStatusFilter);
            if (calculateSalaryTypeFilter != null)
                callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(calculateSalaryTypeFilter);
            if (hireTypeFilter != null)
                callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(hireTypeFilter);
            if (bizLabelIds != null)
                callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(bizLabelIds);
            return new ApiConnectionAction<ResultIPageV3LeaveBalanceResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeaveBalanceDetailResp> _06GetLeaveBalanceInfoByIdV3(Expression<Func<string>> employeeId, Expression<Func<string>> holidayType)
        {
            var apiCallPath = "/v3/leave/getLeaveBalanceInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            callPayload.Queries["holidayType"] = ExpressionConverter.Convert(holidayType);
            return new ApiConnectionAction<ResultV3LeaveBalanceDetailResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayInsertResp> _07addLeaveApplicationInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyholidayType, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<double>> bodyleaveTime = null, Expression<Func<string>> bodytimeType = null, Expression<Func<string>> bodyholidayDate = null, Expression<Func<string>> bodytime = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/leave/addLeaveApplicationInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["holidayType"] = ExpressionConverter.ConvertO(bodyholidayType);
            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodyleaveTime != null)
            {
                body["leaveTime"] = ExpressionConverter.ConvertO(bodyleaveTime);
                bodypropCount++;
            }

            if (bodytimeType != null)
            {
                body["timeType"] = ExpressionConverter.ConvertO(bodytimeType);
                bodypropCount++;
            }

            if (bodyholidayDate != null)
            {
                body["holidayDate"] = ExpressionConverter.ConvertO(bodyholidayDate);
                bodypropCount++;
            }

            if (bodytime != null)
            {
                body["time"] = ExpressionConverter.ConvertO(bodytime);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3LeaveHolidayInsertResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteLeaveApplicationByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/leave/deleteLeaveApplicationById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _09updateLeaveApplicationByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyholidayType = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<double>> bodyleaveTime = null, Expression<Func<string>> bodytimeType = null, Expression<Func<string>> bodyholidayDate = null, Expression<Func<string>> bodytime = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/leave/updateLeaveApplicationById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyholidayType != null)
            {
                body["holidayType"] = ExpressionConverter.ConvertO(bodyholidayType);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodyleaveTime != null)
            {
                body["leaveTime"] = ExpressionConverter.ConvertO(bodyleaveTime);
                bodypropCount++;
            }

            if (bodytimeType != null)
            {
                body["timeType"] = ExpressionConverter.ConvertO(bodytimeType);
                bodypropCount++;
            }

            if (bodyholidayDate != null)
            {
                body["holidayDate"] = ExpressionConverter.ConvertO(bodyholidayDate);
                bodypropCount++;
            }

            if (bodytime != null)
            {
                body["time"] = ExpressionConverter.ConvertO(bodytime);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayResp> _10getLeaveApplicationListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> employeeFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> holidayTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> recordStatusFilter = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> startDateFilter = null)
        {
            var apiCallPath = "/v3/leave/getLeaveApplicationList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (departmentFilter != null)
                callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(departmentFilter);
            if (employeeFilter != null)
                callPayload.Queries["employeeFilter"] = ExpressionConverter.Convert(employeeFilter);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (holidayTypeFilter != null)
                callPayload.Queries["holidayTypeFilter"] = ExpressionConverter.Convert(holidayTypeFilter);
            if (calculateSalaryTypeFilter != null)
                callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(calculateSalaryTypeFilter);
            if (recordStatusFilter != null)
                callPayload.Queries["recordStatusFilter"] = ExpressionConverter.Convert(recordStatusFilter);
            if (attendCalculationId != null)
                callPayload.Queries["attendCalculationId"] = ExpressionConverter.Convert(attendCalculationId);
            if (bizLabelIds != null)
                callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(bizLabelIds);
            if (startDateFilter != null)
                callPayload.Queries["startDateFilter"] = ExpressionConverter.Convert(startDateFilter);
            return new ApiConnectionAction<ResultIPageV3LeaveHolidayResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayDetailResp> _11getLeaveApplicationInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/leave/getLeaveApplicationInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3LeaveHolidayDetailResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3LeaveProcessResp> _12getLeaveApplicationApproveProcessByIdV3(Expression<Func<string>> recordId)
        {
            var apiCallPath = "/v3/leave/getLeaveApplicationApproveProcessById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordId"] = ExpressionConverter.Convert(recordId);
            return new ApiConnectionAction<ResultListV3LeaveProcessResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveTypeResp> _13getLeaveTypeListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> shortName = null)
        {
            var apiCallPath = "/v3/leave/getLeaveTypeList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (shortName != null)
                callPayload.Queries["shortName"] = ExpressionConverter.Convert(shortName);
            return new ApiConnectionAction<ResultIPageV3LeaveTypeResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyResp> _14getLeavePolicyListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null)
        {
            var apiCallPath = "/v3/leave/getLeavePolicyList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<ResultIPageV3LeavePolicyResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeavePolicyDetailResp> _15getLeavePolicyInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/leave/getLeavePolicyInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3LeavePolicyDetailResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyTypeResp> _16getLeavePolicyTypeListV3(Expression<Func<string>> regulationId, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> id = null, Expression<Func<string>> holidayId = null, Expression<Func<string>> generationFrequency = null)
        {
            var apiCallPath = "/v3/leave/getLeavePolicyTypeList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["regulationId"] = ExpressionConverter.Convert(regulationId);
            if (holidayId != null)
                callPayload.Queries["holidayId"] = ExpressionConverter.Convert(holidayId);
            if (generationFrequency != null)
                callPayload.Queries["generationFrequency"] = ExpressionConverter.Convert(generationFrequency);
            return new ApiConnectionAction<ResultIPageV3LeavePolicyTypeResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _01addRosterInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyattendDay, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodyshiftTemplateId = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<double>> bodyhourlyRate = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<double>> bodytierRate = null, Expression<Func<double>> bodyscheduledAmount = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendCalculation/addRosterInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["attendDay"] = ExpressionConverter.ConvertO(bodyattendDay);
            if (bodyshiftTemplateId != null)
            {
                body["shiftTemplateId"] = ExpressionConverter.ConvertO(bodyshiftTemplateId);
                bodypropCount++;
            }

            if (bodyaddressCardId != null)
            {
                body["addressCardId"] = ExpressionConverter.ConvertO(bodyaddressCardId);
                bodypropCount++;
            }

            bodypropCount++;
            body["shiftIn"] = ExpressionConverter.ConvertO(bodyshiftIn);
            bodypropCount++;
            body["shiftOff"] = ExpressionConverter.ConvertO(bodyshiftOff);
            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyshiftStatus != null)
            {
                body["shiftStatus"] = ExpressionConverter.ConvertO(bodyshiftStatus);
                bodypropCount++;
            }

            if (bodydateType != null)
            {
                body["dateType"] = ExpressionConverter.ConvertO(bodydateType);
                bodypropCount++;
            }

            if (bodyattendanceItemId != null)
            {
                body["attendanceItemId"] = ExpressionConverter.ConvertO(bodyattendanceItemId);
                bodypropCount++;
            }

            if (bodyhourlyRate != null)
            {
                body["hourlyRate"] = ExpressionConverter.ConvertO(bodyhourlyRate);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodytierRate != null)
            {
                body["tierRate"] = ExpressionConverter.ConvertO(bodytierRate);
                bodypropCount++;
            }

            if (bodyscheduledAmount != null)
            {
                body["scheduledAmount"] = ExpressionConverter.ConvertO(bodyscheduledAmount);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _02batchSaveRosterInfoV3(Expression<Func<string[]>> bodyemployeeIds, Expression<Func<string[]>> bodydates, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodyshiftTemplateId = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<double>> bodyhourlyRate = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<bool>> bodyreplaceOriginal = null)
        {
            var apiCallPath = "/v3/attendCalculation/batchSaveRosterInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeIds"] = ExpressionConverter.ConvertO(bodyemployeeIds);
            bodypropCount++;
            body["dates"] = ExpressionConverter.ConvertO(bodydates);
            if (bodyshiftTemplateId != null)
            {
                body["shiftTemplateId"] = ExpressionConverter.ConvertO(bodyshiftTemplateId);
                bodypropCount++;
            }

            if (bodyaddressCardId != null)
            {
                body["addressCardId"] = ExpressionConverter.ConvertO(bodyaddressCardId);
                bodypropCount++;
            }

            bodypropCount++;
            body["shiftIn"] = ExpressionConverter.ConvertO(bodyshiftIn);
            bodypropCount++;
            body["shiftOff"] = ExpressionConverter.ConvertO(bodyshiftOff);
            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyshiftStatus != null)
            {
                body["shiftStatus"] = ExpressionConverter.ConvertO(bodyshiftStatus);
                bodypropCount++;
            }

            if (bodydateType != null)
            {
                body["dateType"] = ExpressionConverter.ConvertO(bodydateType);
                bodypropCount++;
            }

            if (bodyattendanceItemId != null)
            {
                body["attendanceItemId"] = ExpressionConverter.ConvertO(bodyattendanceItemId);
                bodypropCount++;
            }

            if (bodyhourlyRate != null)
            {
                body["hourlyRate"] = ExpressionConverter.ConvertO(bodyhourlyRate);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyreplaceOriginal != null)
            {
                body["replaceOriginal"] = ExpressionConverter.ConvertO(bodyreplaceOriginal);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _03deleteRosterByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/deleteRosterById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _04updateRosterInfoByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodyshiftTemplateId = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<double>> bodyhourlyRate = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<double>> bodytierRate = null, Expression<Func<double>> bodyscheduledAmount = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendCalculation/updateRosterInfoById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyshiftTemplateId != null)
            {
                body["shiftTemplateId"] = ExpressionConverter.ConvertO(bodyshiftTemplateId);
                bodypropCount++;
            }

            if (bodyaddressCardId != null)
            {
                body["addressCardId"] = ExpressionConverter.ConvertO(bodyaddressCardId);
                bodypropCount++;
            }

            bodypropCount++;
            body["shiftIn"] = ExpressionConverter.ConvertO(bodyshiftIn);
            bodypropCount++;
            body["shiftOff"] = ExpressionConverter.ConvertO(bodyshiftOff);
            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyshiftStatus != null)
            {
                body["shiftStatus"] = ExpressionConverter.ConvertO(bodyshiftStatus);
                bodypropCount++;
            }

            if (bodydateType != null)
            {
                body["dateType"] = ExpressionConverter.ConvertO(bodydateType);
                bodypropCount++;
            }

            if (bodyattendanceItemId != null)
            {
                body["attendanceItemId"] = ExpressionConverter.ConvertO(bodyattendanceItemId);
                bodypropCount++;
            }

            if (bodyhourlyRate != null)
            {
                body["hourlyRate"] = ExpressionConverter.ConvertO(bodyhourlyRate);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodytierRate != null)
            {
                body["tierRate"] = ExpressionConverter.ConvertO(bodytierRate);
                bodypropCount++;
            }

            if (bodyscheduledAmount != null)
            {
                body["scheduledAmount"] = ExpressionConverter.ConvertO(bodyscheduledAmount);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3RosterListResp> _05getRosterListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendDay = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> attendStatus = null, Expression<Func<string>> dateType = null)
        {
            var apiCallPath = "/v3/attendCalculation/getRosterList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (attendDay != null)
                callPayload.Queries["attendDay"] = ExpressionConverter.Convert(attendDay);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (attendStatus != null)
                callPayload.Queries["attendStatus"] = ExpressionConverter.Convert(attendStatus);
            if (dateType != null)
                callPayload.Queries["dateType"] = ExpressionConverter.Convert(dateType);
            return new ApiConnectionAction<ResultIPageV3RosterListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3RosterInfoResp> _06getRosterInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/getRosterInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3RosterInfoResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _07addShitTemplateInfoV3(Expression<Func<string>> bodyname, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceAddressId = null, Expression<Func<int>> bodymealTime = null)
        {
            var apiCallPath = "/v3/attendCalculation/addShitTemplateInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["shiftIn"] = ExpressionConverter.ConvertO(bodyshiftIn);
            bodypropCount++;
            body["shiftOff"] = ExpressionConverter.ConvertO(bodyshiftOff);
            if (bodydateType != null)
            {
                body["dateType"] = ExpressionConverter.ConvertO(bodydateType);
                bodypropCount++;
            }

            if (bodyattendanceAddressId != null)
            {
                body["attendanceAddressId"] = ExpressionConverter.ConvertO(bodyattendanceAddressId);
                bodypropCount++;
            }

            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteShiftTemplateByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/deleteShiftTemplateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _09updateShiftTemplateByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceAddressId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendCalculation/updateShiftTemplateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["shiftIn"] = ExpressionConverter.ConvertO(bodyshiftIn);
            bodypropCount++;
            body["shiftOff"] = ExpressionConverter.ConvertO(bodyshiftOff);
            if (bodydateType != null)
            {
                body["dateType"] = ExpressionConverter.ConvertO(bodydateType);
                bodypropCount++;
            }

            if (bodyattendanceAddressId != null)
            {
                body["attendanceAddressId"] = ExpressionConverter.ConvertO(bodyattendanceAddressId);
                bodypropCount++;
            }

            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ShiftTemplateListResp> _10getShiftTemplateListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendanceAddressId = null, Expression<Func<string>> dateType = null, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/v3/attendCalculation/getShiftTemplateList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (attendanceAddressId != null)
                callPayload.Queries["attendanceAddressId"] = ExpressionConverter.Convert(attendanceAddressId);
            if (dateType != null)
                callPayload.Queries["dateType"] = ExpressionConverter.Convert(dateType);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ResultIPageV3ShiftTemplateListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _11addOpenShiftInfoV3(Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodydate, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<double>> bodyhourlyRate, Expression<Func<int>> bodyempPlanNo, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodyshiftType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendCalculation/addOpenShiftInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            bodypropCount++;
            body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
            if (bodylocationId != null)
            {
                body["locationId"] = ExpressionConverter.ConvertO(bodylocationId);
                bodypropCount++;
            }

            if (bodyshiftType != null)
            {
                body["shiftType"] = ExpressionConverter.ConvertO(bodyshiftType);
                bodypropCount++;
            }

            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            bodypropCount++;
            body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
            bodypropCount++;
            body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
            bodypropCount++;
            body["hourlyRate"] = ExpressionConverter.ConvertO(bodyhourlyRate);
            bodypropCount++;
            body["empPlanNo"] = ExpressionConverter.ConvertO(bodyempPlanNo);
            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _12deleteOpenShiftByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/deleteOpenShiftById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _13updateOpenShiftByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<double>> bodyhourlyRate, Expression<Func<int>> bodyempPlanNo, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodyshiftType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendCalculation/updateOpenShiftById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            bodypropCount++;
            body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
            if (bodylocationId != null)
            {
                body["locationId"] = ExpressionConverter.ConvertO(bodylocationId);
                bodypropCount++;
            }

            if (bodyshiftType != null)
            {
                body["shiftType"] = ExpressionConverter.ConvertO(bodyshiftType);
                bodypropCount++;
            }

            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            bodypropCount++;
            body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
            bodypropCount++;
            body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
            bodypropCount++;
            body["hourlyRate"] = ExpressionConverter.ConvertO(bodyhourlyRate);
            bodypropCount++;
            body["empPlanNo"] = ExpressionConverter.ConvertO(bodyempPlanNo);
            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3OpenShiftListResp> _14getOpenShiftListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> projectId = null, Expression<Func<string>> locationId = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> date = null)
        {
            var apiCallPath = "/v3/attendCalculation/getOpenShiftList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (locationId != null)
                callPayload.Queries["locationId"] = ExpressionConverter.Convert(locationId);
            if (costCenterId != null)
                callPayload.Queries["costCenterId"] = ExpressionConverter.Convert(costCenterId);
            if (date != null)
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            return new ApiConnectionAction<ResultIPageV3OpenShiftListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3OpenShiftInfoResp> _15getOpenShiftInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/getOpenShiftInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3OpenShiftInfoResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _16addProjectCategoryInfoV3(Expression<Func<string>> bodyname, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyparentId = null)
        {
            var apiCallPath = "/v3/attendCalculation/addProjectCategoryInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _17deleteProjectCategoryByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/deleteProjectCategoryById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _18updateProjectCategoryByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyparentId = null)
        {
            var apiCallPath = "/v3/attendCalculation/updateProjectCategoryById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ScheduleProjectCategoryListResp> _19getProjectCategoryListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/attendCalculation/getProjectCategoryList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3ScheduleProjectCategoryListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _20addProjectInfoV3(Expression<Func<string>> bodycode, Expression<Func<string>> bodyname, Expression<Func<double>> bodyhourlyRate, Expression<Func<string>> bodycategoryId = null, Expression<Func<double>> bodyminRate = null, Expression<Func<double>> bodymaxRate = null)
        {
            var apiCallPath = "/v3/attendCalculation/addProjectInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["code"] = ExpressionConverter.ConvertO(bodycode);
            if (bodycategoryId != null)
            {
                body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["hourlyRate"] = ExpressionConverter.ConvertO(bodyhourlyRate);
            if (bodyminRate != null)
            {
                body["minRate"] = ExpressionConverter.ConvertO(bodyminRate);
                bodypropCount++;
            }

            if (bodymaxRate != null)
            {
                body["maxRate"] = ExpressionConverter.ConvertO(bodymaxRate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _21deleteProjectByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/deleteProjectById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _22updateProjectByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodycode, Expression<Func<string>> bodyname, Expression<Func<double>> bodyhourlyRate, Expression<Func<string>> bodycategoryId = null, Expression<Func<double>> bodyminRate = null, Expression<Func<double>> bodymaxRate = null)
        {
            var apiCallPath = "/v3/attendCalculation/updateProjectById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["code"] = ExpressionConverter.ConvertO(bodycode);
            if (bodycategoryId != null)
            {
                body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["hourlyRate"] = ExpressionConverter.ConvertO(bodyhourlyRate);
            if (bodyminRate != null)
            {
                body["minRate"] = ExpressionConverter.ConvertO(bodyminRate);
                bodypropCount++;
            }

            if (bodymaxRate != null)
            {
                body["maxRate"] = ExpressionConverter.ConvertO(bodymaxRate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ProjectListResp> _23getProjectListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/attendCalculation/getProjectList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3ProjectListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3ProjectInfoResp> _24getProjectInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/getProjectInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3ProjectInfoResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _25addProjectCertificateInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyprojectId, Expression<Func<double>> bodyshiftHours, Expression<Func<double>> bodyworkedHours, Expression<Func<string>> bodytier = null, Expression<Func<double>> bodytierRate = null, Expression<Func<string>> bodyreason = null)
        {
            var apiCallPath = "/v3/attendCalculation/addProjectCertificateInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
            if (bodytier != null)
            {
                body["tier"] = ExpressionConverter.ConvertO(bodytier);
                bodypropCount++;
            }

            if (bodytierRate != null)
            {
                body["tierRate"] = ExpressionConverter.ConvertO(bodytierRate);
                bodypropCount++;
            }

            bodypropCount++;
            body["shiftHours"] = ExpressionConverter.ConvertO(bodyshiftHours);
            bodypropCount++;
            body["workedHours"] = ExpressionConverter.ConvertO(bodyworkedHours);
            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _26updateProjectCertificateByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodytier = null, Expression<Func<double>> bodytierRate = null)
        {
            var apiCallPath = "/v3/attendCalculation/updateProjectCertificateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodytier != null)
            {
                body["tier"] = ExpressionConverter.ConvertO(bodytier);
                bodypropCount++;
            }

            if (bodytierRate != null)
            {
                body["tierRate"] = ExpressionConverter.ConvertO(bodytierRate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateListResp> _27getProjectCertificateListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<int>> status = null, Expression<Func<string>> hireType = null, Expression<Func<string>> projectId = null)
        {
            var apiCallPath = "/v3/attendCalculation/getProjectCertificateList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (departmentId != null)
                callPayload.Queries["departmentId"] = ExpressionConverter.Convert(departmentId);
            if (positionId != null)
                callPayload.Queries["positionId"] = ExpressionConverter.Convert(positionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (hireType != null)
                callPayload.Queries["hireType"] = ExpressionConverter.Convert(hireType);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<ResultIPageV3ProjectCertificateListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _28addProjectCertificateHoursV3(Expression<Func<string>> bodyprojectCertificateId, Expression<Func<string>> bodyoccurrenceTime, Expression<Func<double>> bodybalance, Expression<Func<string>> bodyreason)
        {
            var apiCallPath = "/v3/attendCalculation/addProjectCertificateHours";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["projectCertificateId"] = ExpressionConverter.ConvertO(bodyprojectCertificateId);
            bodypropCount++;
            body["occurrenceTime"] = ExpressionConverter.ConvertO(bodyoccurrenceTime);
            bodypropCount++;
            body["balance"] = ExpressionConverter.ConvertO(bodybalance);
            bodypropCount++;
            body["reason"] = ExpressionConverter.ConvertO(bodyreason);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _29deleteProjectCertificateHoursByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendCalculation/deleteProjectCertificateHoursById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateHoursListResp> _30getProjectCertificateHourListV3(Expression<Func<string>> projectCertificateId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/attendCalculation/getProjectCertificateHourList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectCertificateId"] = ExpressionConverter.Convert(projectCertificateId);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3ProjectCertificateHoursListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3CalAttendanceResp> _01attendanceSummaryCalculateV3(Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<string[]>> bodyemployeeIds = null, Expression<Func<string[]>> bodydepartmentIds = null, Expression<Func<string[]>> bodypositionIds = null)
        {
            var apiCallPath = "/v3/attendance/attendanceSummaryCalculate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
            bodypropCount++;
            body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
            if (bodyemployeeIds != null)
            {
                body["employeeIds"] = ExpressionConverter.ConvertO(bodyemployeeIds);
                bodypropCount++;
            }

            if (bodydepartmentIds != null)
            {
                body["departmentIds"] = ExpressionConverter.ConvertO(bodydepartmentIds);
                bodypropCount++;
            }

            if (bodypositionIds != null)
            {
                body["positionIds"] = ExpressionConverter.ConvertO(bodypositionIds);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3CalAttendanceResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceListResp> _02getAttendanceSummaryListV3(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> unit, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> attendCalculationFilter = null, Expression<Func<string>> employeeFilter = null, Expression<Func<string>> labelFilter = null, Expression<Func<string>> payrollRegulationFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> attendanceTypeFilter = null, Expression<Func<string>> shiftTypeFilter = null)
        {
            var apiCallPath = "/v3/attendance/getAttendanceSummaryList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            callPayload.Queries["unit"] = ExpressionConverter.Convert(unit);
            if (departmentFilter != null)
                callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(departmentFilter);
            if (positionFilter != null)
                callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(positionFilter);
            if (attendCalculationFilter != null)
                callPayload.Queries["attendCalculationFilter"] = ExpressionConverter.Convert(attendCalculationFilter);
            if (employeeFilter != null)
                callPayload.Queries["employeeFilter"] = ExpressionConverter.Convert(employeeFilter);
            if (labelFilter != null)
                callPayload.Queries["labelFilter"] = ExpressionConverter.Convert(labelFilter);
            if (payrollRegulationFilter != null)
                callPayload.Queries["payrollRegulationFilter"] = ExpressionConverter.Convert(payrollRegulationFilter);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (hireTypeFilter != null)
                callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(hireTypeFilter);
            if (calculateSalaryTypeFilter != null)
                callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(calculateSalaryTypeFilter);
            if (attendanceTypeFilter != null)
                callPayload.Queries["attendanceTypeFilter"] = ExpressionConverter.Convert(attendanceTypeFilter);
            if (shiftTypeFilter != null)
                callPayload.Queries["shiftTypeFilter"] = ExpressionConverter.Convert(shiftTypeFilter);
            return new ApiConnectionAction<ResultIPageV3AttendanceListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3AttendanceDetailListResp> _03getEmployeeDailyAttendanceListV3(Expression<Func<string>> employeeId, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> attendStatusFilter = null)
        {
            var apiCallPath = "/v3/attendance/getEmployeeDailyAttendanceList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            if (attendStatusFilter != null)
                callPayload.Queries["attendStatusFilter"] = ExpressionConverter.Convert(attendStatusFilter);
            return new ApiConnectionAction<ResultListV3AttendanceDetailListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddMobileCardResp> _04addAttendanceDataInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodydate, Expression<Func<string>> bodymode, Expression<Func<string>> bodycardType = null, Expression<Func<double>> bodyactualLongitude = null, Expression<Func<double>> bodyactualLatitude = null, Expression<Func<string>> bodydeviceName = null, Expression<Func<string>> bodycodeSource = null, Expression<Func<string>> bodylocationName = null, Expression<Func<string>> bodyworkLocationId = null, Expression<Func<string>> bodydeviceId = null)
        {
            var apiCallPath = "/v3/attendance/addAttendanceDataInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            bodypropCount++;
            body["mode"] = ExpressionConverter.ConvertO(bodymode);
            if (bodycardType != null)
            {
                body["cardType"] = ExpressionConverter.ConvertO(bodycardType);
                bodypropCount++;
            }

            if (bodyactualLongitude != null)
            {
                body["actualLongitude"] = ExpressionConverter.ConvertO(bodyactualLongitude);
                bodypropCount++;
            }

            if (bodyactualLatitude != null)
            {
                body["actualLatitude"] = ExpressionConverter.ConvertO(bodyactualLatitude);
                bodypropCount++;
            }

            if (bodydeviceName != null)
            {
                body["deviceName"] = ExpressionConverter.ConvertO(bodydeviceName);
                bodypropCount++;
            }

            if (bodycodeSource != null)
            {
                body["codeSource"] = ExpressionConverter.ConvertO(bodycodeSource);
                bodypropCount++;
            }

            if (bodylocationName != null)
            {
                body["locationName"] = ExpressionConverter.ConvertO(bodylocationName);
                bodypropCount++;
            }

            if (bodyworkLocationId != null)
            {
                body["workLocationId"] = ExpressionConverter.ConvertO(bodyworkLocationId);
                bodypropCount++;
            }

            if (bodydeviceId != null)
            {
                body["deviceId"] = ExpressionConverter.ConvertO(bodydeviceId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3AddMobileCardResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _05deleteAttendanceDataByIdV3(Expression<Func<string>> ids)
        {
            var apiCallPath = "/v3/attendance/deleteAttendanceDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _06updateAttendanceDataByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodymode = null, Expression<Func<string>> bodycardType = null, Expression<Func<double>> bodyactualLongitude = null, Expression<Func<double>> bodyactualLatitude = null, Expression<Func<string>> bodydeviceName = null, Expression<Func<string>> bodycodeSource = null, Expression<Func<string>> bodylocationName = null, Expression<Func<string>> bodyworkLocationId = null, Expression<Func<string>> bodydeviceId = null)
        {
            var apiCallPath = "/v3/attendance/updateAttendanceDataById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
            }

            if (bodycardType != null)
            {
                body["cardType"] = ExpressionConverter.ConvertO(bodycardType);
                bodypropCount++;
            }

            if (bodyactualLongitude != null)
            {
                body["actualLongitude"] = ExpressionConverter.ConvertO(bodyactualLongitude);
                bodypropCount++;
            }

            if (bodyactualLatitude != null)
            {
                body["actualLatitude"] = ExpressionConverter.ConvertO(bodyactualLatitude);
                bodypropCount++;
            }

            if (bodydeviceName != null)
            {
                body["deviceName"] = ExpressionConverter.ConvertO(bodydeviceName);
                bodypropCount++;
            }

            if (bodycodeSource != null)
            {
                body["codeSource"] = ExpressionConverter.ConvertO(bodycodeSource);
                bodypropCount++;
            }

            if (bodylocationName != null)
            {
                body["locationName"] = ExpressionConverter.ConvertO(bodylocationName);
                bodypropCount++;
            }

            if (bodyworkLocationId != null)
            {
                body["workLocationId"] = ExpressionConverter.ConvertO(bodyworkLocationId);
                bodypropCount++;
            }

            if (bodydeviceId != null)
            {
                body["deviceId"] = ExpressionConverter.ConvertO(bodydeviceId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3MobileCardListResp> _07getAttendanceDataListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var apiCallPath = "/v3/attendance/getAttendanceDataList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (departmentFilter != null)
                callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(departmentFilter);
            if (positionFilter != null)
                callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(positionFilter);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (attendCalculationId != null)
                callPayload.Queries["attendCalculationId"] = ExpressionConverter.Convert(attendCalculationId);
            if (bizLabelIds != null)
                callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(bizLabelIds);
            if (hireTypeFilter != null)
                callPayload.Queries["hireTypeFilter"] = ExpressionConverter.Convert(hireTypeFilter);
            if (calculateSalaryTypeFilter != null)
                callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(calculateSalaryTypeFilter);
            if (startDate != null)
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            return new ApiConnectionAction<ResultIPageV3MobileCardListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3MobileCardInfoResp> _08getAttendanceDataInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendance/getAttendanceDataInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3MobileCardInfoResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceItemListResp> _09getAttendanceItemListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/attendance/getAttendanceItemList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3AttendanceItemListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddTimesheetResp> _10addTimesheetInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<string>> bodyworkOverTimeType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendance/addTimesheetInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyworkOverTimeType != null)
            {
                body["workOverTimeType"] = ExpressionConverter.ConvertO(bodyworkOverTimeType);
                bodypropCount++;
            }

            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            bodypropCount++;
            body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
            bodypropCount++;
            body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyaddressCardId != null)
            {
                body["addressCardId"] = ExpressionConverter.ConvertO(bodyaddressCardId);
                bodypropCount++;
            }

            if (bodyattendanceItemId != null)
            {
                body["attendanceItemId"] = ExpressionConverter.ConvertO(bodyattendanceItemId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3AddTimesheetResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _11deleteTimesheetByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendance/deleteTimesheetById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _12updateTimesheetByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<string>> bodyworkOverTimeType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendance/updateTimesheetById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyworkOverTimeType != null)
            {
                body["workOverTimeType"] = ExpressionConverter.ConvertO(bodyworkOverTimeType);
                bodypropCount++;
            }

            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            bodypropCount++;
            body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
            bodypropCount++;
            body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyaddressCardId != null)
            {
                body["addressCardId"] = ExpressionConverter.ConvertO(bodyaddressCardId);
                bodypropCount++;
            }

            if (bodyattendanceItemId != null)
            {
                body["attendanceItemId"] = ExpressionConverter.ConvertO(bodyattendanceItemId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3TimesheetListResp> _13getTimesheetListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> addressCardId = null, Expression<Func<string>> typeFilter = null)
        {
            var apiCallPath = "/v3/attendance/getTimesheetList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (departmentFilter != null)
                callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(departmentFilter);
            if (positionFilter != null)
                callPayload.Queries["positionFilter"] = ExpressionConverter.Convert(positionFilter);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (bizLabelIds != null)
                callPayload.Queries["bizLabelIds"] = ExpressionConverter.Convert(bizLabelIds);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (calculateSalaryTypeFilter != null)
                callPayload.Queries["calculateSalaryTypeFilter"] = ExpressionConverter.Convert(calculateSalaryTypeFilter);
            if (startDate != null)
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            if (addressCardId != null)
                callPayload.Queries["addressCardId"] = ExpressionConverter.Convert(addressCardId);
            if (typeFilter != null)
                callPayload.Queries["typeFilter"] = ExpressionConverter.Convert(typeFilter);
            return new ApiConnectionAction<ResultIPageV3TimesheetListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3TimesheetInfoResp> _14getTimesheetInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendance/getTimesheetInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3TimesheetInfoResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddCalendarRemarkInfoResp> _15addCalendarRemarkInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyemployeeStatus, Expression<Func<string>> bodytimeType, Expression<Func<string>> bodyexpectWorkStartTime, Expression<Func<string>> bodyexpectWorkEndTime, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrecordDate = null, Expression<Func<string>> bodyexpectWorkLocation = null, Expression<Func<string>> bodyexpectWorkTimeTemplate = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendance/addCalendarRemarkInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["employeeStatus"] = ExpressionConverter.ConvertO(bodyemployeeStatus);
            bodypropCount++;
            body["timeType"] = ExpressionConverter.ConvertO(bodytimeType);
            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyrecordDate != null)
            {
                body["recordDate"] = ExpressionConverter.ConvertO(bodyrecordDate);
                bodypropCount++;
            }

            if (bodyexpectWorkLocation != null)
            {
                body["expectWorkLocation"] = ExpressionConverter.ConvertO(bodyexpectWorkLocation);
                bodypropCount++;
            }

            if (bodyexpectWorkTimeTemplate != null)
            {
                body["expectWorkTimeTemplate"] = ExpressionConverter.ConvertO(bodyexpectWorkTimeTemplate);
                bodypropCount++;
            }

            bodypropCount++;
            body["expectWorkStartTime"] = ExpressionConverter.ConvertO(bodyexpectWorkStartTime);
            bodypropCount++;
            body["expectWorkEndTime"] = ExpressionConverter.ConvertO(bodyexpectWorkEndTime);
            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3AddCalendarRemarkInfoResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _16deleteCalendarRemarkByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/attendance/deleteCalendarRemarkById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _17updateCalendarRemarkByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyemployeeStatus, Expression<Func<string>> bodytimeType, Expression<Func<string>> bodyexpectWorkStartTime, Expression<Func<string>> bodyexpectWorkEndTime, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrecordDate = null, Expression<Func<string>> bodyexpectWorkLocation = null, Expression<Func<string>> bodyexpectWorkTimeTemplate = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/attendance/updateCalendarRemarkById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["employeeStatus"] = ExpressionConverter.ConvertO(bodyemployeeStatus);
            bodypropCount++;
            body["timeType"] = ExpressionConverter.ConvertO(bodytimeType);
            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyrecordDate != null)
            {
                body["recordDate"] = ExpressionConverter.ConvertO(bodyrecordDate);
                bodypropCount++;
            }

            if (bodyexpectWorkLocation != null)
            {
                body["expectWorkLocation"] = ExpressionConverter.ConvertO(bodyexpectWorkLocation);
                bodypropCount++;
            }

            if (bodyexpectWorkTimeTemplate != null)
            {
                body["expectWorkTimeTemplate"] = ExpressionConverter.ConvertO(bodyexpectWorkTimeTemplate);
                bodypropCount++;
            }

            bodypropCount++;
            body["expectWorkStartTime"] = ExpressionConverter.ConvertO(bodyexpectWorkStartTime);
            bodypropCount++;
            body["expectWorkEndTime"] = ExpressionConverter.ConvertO(bodyexpectWorkEndTime);
            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3StatusFlagListResp> _18getCalendarRemarkListV3(Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIds = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var apiCallPath = "/v3/attendance/getCalendarRemarkList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeIds != null)
                callPayload.Queries["employeeIds"] = ExpressionConverter.Convert(employeeIds);
            if (startDate != null)
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            return new ApiConnectionAction<ResultIPageV3StatusFlagListResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizAttendanceConfigureResp> _01getAttendanceConfigurationListV3()
        {
            var apiCallPath = "/v3/settings/getAttendanceConfigurationList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultV3BizAttendanceConfigureResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryResp> _02getDataDictionaryListV3()
        {
            var apiCallPath = "/v3/settings/getDataDictionaryList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryItemResp> _03GetDataDictionaryDetailsInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/settings/getDataDictionaryDetailsInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3BizEmployeeCustomizationResp> _04getCustomizeUserFieldListV3(Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/settings/getCustomizeUserFieldList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3BizEmployeeCustomizationResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizEmployeeCustomizationResp> _05getCustomizeUserFieldInfoByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/settings/getCustomizeUserFieldInfoById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3BizEmployeeCustomizationResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveWorkFlowDefinitionResp> _06getApproveProcessListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/settings/getApproveProcessList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3LeaveWorkFlowDefinitionResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementTypeResp> _01getExpenseTypeListV3(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/expense/getExpenseTypeList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3BizReimbursementTypeResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizReimbursementInsertResp> _02addExpenseApplicationInfoV3(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyreimbursementType, Expression<Func<string>> bodyreimbursementDate, Expression<Func<string>> bodyreimbursementName, Expression<Func<double>> bodyamount, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/expense/addExpenseApplicationInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["employeeId"] = ExpressionConverter.ConvertO(bodyemployeeId);
            bodypropCount++;
            body["reimbursementType"] = ExpressionConverter.ConvertO(bodyreimbursementType);
            bodypropCount++;
            body["reimbursementDate"] = ExpressionConverter.ConvertO(bodyreimbursementDate);
            bodypropCount++;
            body["reimbursementName"] = ExpressionConverter.ConvertO(bodyreimbursementName);
            bodypropCount++;
            body["amount"] = ExpressionConverter.ConvertO(bodyamount);
            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultV3BizReimbursementInsertResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _03deleteExpenseApplicationByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/expense/deleteExpenseApplicationById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _04updateExpenseApplicationByIdV3(Expression<Func<string>> bodyid, Expression<Func<string>> bodyreimbursementType = null, Expression<Func<string>> bodyreimbursementDate = null, Expression<Func<string>> bodyreimbursementName = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v3/expense/updateExpenseApplicationById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyreimbursementType != null)
            {
                body["reimbursementType"] = ExpressionConverter.ConvertO(bodyreimbursementType);
                bodypropCount++;
            }

            if (bodyreimbursementDate != null)
            {
                body["reimbursementDate"] = ExpressionConverter.ConvertO(bodyreimbursementDate);
                bodypropCount++;
            }

            if (bodyreimbursementName != null)
            {
                body["reimbursementName"] = ExpressionConverter.ConvertO(bodyreimbursementName);
                bodypropCount++;
            }

            if (bodyamount != null)
            {
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementResp> _05GetExpenseApplicationListV3(Expression<Func<string>> q = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> dateFilter = null, Expression<Func<string>> reimbursementStatusFilter = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v3/expense/getExpenseApplicationList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (departmentFilter != null)
                callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(departmentFilter);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (dateFilter != null)
                callPayload.Queries["dateFilter"] = ExpressionConverter.Convert(dateFilter);
            if (reimbursementStatusFilter != null)
                callPayload.Queries["reimbursementStatusFilter"] = ExpressionConverter.Convert(reimbursementStatusFilter);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ResultIPageV3BizReimbursementResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizReimbursementDetailResp> _06GetExpenseApplicationByIdV3(Expression<Func<string>> id)
        {
            var apiCallPath = "/v3/expense/getExpenseApplicationById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<ResultV3BizReimbursementDetailResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2AttendanceResp> GetAttendCalculationListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendDay = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> attendStatus = null, Expression<Func<string>> type = null)
        {
            var apiCallPath = "/v2/attendance/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (attendDay != null)
                callPayload.Queries["attendDay"] = ExpressionConverter.Convert(attendDay);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (attendStatus != null)
                callPayload.Queries["attendStatus"] = ExpressionConverter.Convert(attendStatus);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<ResultIPageV2AttendanceResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV2RosterResp> GetRosterDataListV2(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> englishName = null, Expression<Func<string>> code = null, Expression<Func<string>> surnameEnglish = null, Expression<Func<string>> personalNameEnglish = null)
        {
            var apiCallPath = "/v2/tenants/getRosterDataList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (attendCalculationId != null)
                callPayload.Queries["attendCalculationId"] = ExpressionConverter.Convert(attendCalculationId);
            callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            if (departmentId != null)
                callPayload.Queries["departmentId"] = ExpressionConverter.Convert(departmentId);
            if (positionId != null)
                callPayload.Queries["positionId"] = ExpressionConverter.Convert(positionId);
            if (statusFilter != null)
                callPayload.Queries["statusFilter"] = ExpressionConverter.Convert(statusFilter);
            if (englishName != null)
                callPayload.Queries["englishName"] = ExpressionConverter.Convert(englishName);
            if (code != null)
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
            if (surnameEnglish != null)
                callPayload.Queries["surnameEnglish"] = ExpressionConverter.Convert(surnameEnglish);
            if (personalNameEnglish != null)
                callPayload.Queries["personalNameEnglish"] = ExpressionConverter.Convert(personalNameEnglish);
            return new ApiConnectionAction<ResultListV2RosterResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateCardByIdV2(Expression<Func<string>> bodyid, Expression<Func<bool>> bodyisInValid = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v2/attendance/updateCardById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyisInValid != null)
            {
                body["isInValid"] = ExpressionConverter.ConvertO(bodyisInValid);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterDataV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyshiftIn = null, Expression<Func<string>> bodyshiftOff = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyacrossTheNight = null)
        {
            var apiCallPath = "/v2/tenants/updateRosterData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyshiftIn != null)
            {
                body["shiftIn"] = ExpressionConverter.ConvertO(bodyshiftIn);
                bodypropCount++;
            }

            if (bodyshiftOff != null)
            {
                body["shiftOff"] = ExpressionConverter.ConvertO(bodyshiftOff);
                bodypropCount++;
            }

            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyshiftStatus != null)
            {
                body["shiftStatus"] = ExpressionConverter.ConvertO(bodyshiftStatus);
                bodypropCount++;
            }

            if (bodyaddressCardId != null)
            {
                body["addressCardId"] = ExpressionConverter.ConvertO(bodyaddressCardId);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodydateType != null)
            {
                body["dateType"] = ExpressionConverter.ConvertO(bodydateType);
                bodypropCount++;
            }

            if (bodyacrossTheNight != null)
            {
                body["acrossTheNight"] = ExpressionConverter.ConvertO(bodyacrossTheNight);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterItemV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycode = null)
        {
            var apiCallPath = "/v2/attendance/updateRosterItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateShiftTemplateV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyshiftIn = null, Expression<Func<string>> bodyshiftOff = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyattendanceAddressId = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodylunchStartTime = null, Expression<Func<string>> bodylunchEndTime = null)
        {
            var apiCallPath = "/v2/attendance/updateShiftTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyshiftIn != null)
            {
                body["shiftIn"] = ExpressionConverter.ConvertO(bodyshiftIn);
                bodypropCount++;
            }

            if (bodyshiftOff != null)
            {
                body["shiftOff"] = ExpressionConverter.ConvertO(bodyshiftOff);
                bodypropCount++;
            }

            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodyattendanceAddressId != null)
            {
                body["attendanceAddressId"] = ExpressionConverter.ConvertO(bodyattendanceAddressId);
                bodypropCount++;
            }

            if (bodydateType != null)
            {
                body["dateType"] = ExpressionConverter.ConvertO(bodydateType);
                bodypropCount++;
            }

            if (bodylunchStartTime != null)
            {
                body["lunchStartTime"] = ExpressionConverter.ConvertO(bodylunchStartTime);
                bodypropCount++;
            }

            if (bodylunchEndTime != null)
            {
                body["lunchEndTime"] = ExpressionConverter.ConvertO(bodylunchEndTime);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2CostCenterResp> GetCostCenterListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> costCenterCode = null)
        {
            var apiCallPath = "/v2/tenants/getCostCenterList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (costCenterCode != null)
                callPayload.Queries["costCenterCode"] = ExpressionConverter.Convert(costCenterCode);
            return new ApiConnectionAction<ResultIPageV2CostCenterResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateCostCenterInfoV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = "/v2/tenants/updateCostCenterInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycostCenterCode != null)
            {
                body["costCenterCode"] = ExpressionConverter.ConvertO(bodycostCenterCode);
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

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2DepartmentResp> GetDepartmentListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> departmentCode = null, Expression<Func<string>> parentId = null, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/v2/department/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (departmentCode != null)
                callPayload.Queries["departmentCode"] = ExpressionConverter.Convert(departmentCode);
            if (parentId != null)
                callPayload.Queries["parentId"] = ExpressionConverter.Convert(parentId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ResultIPageV2DepartmentResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateDepartmentInfoV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydepartmentCode = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = "/v2/department/updateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydepartmentCode != null)
            {
                body["departmentCode"] = ExpressionConverter.ConvertO(bodydepartmentCode);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
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

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2EmployeeResp> GetEmployeeListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> englishName = null, Expression<Func<string>> chineseName = null, Expression<Func<string>> email = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> phone = null, Expression<Func<string>> code = null, Expression<Func<int>> status = null, Expression<Func<string>> education = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> hireType = null, Expression<Func<string>> bankCode = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> payrollRegulationId = null, Expression<Func<string>> workDate = null)
        {
            var apiCallPath = "/v2/employee/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (englishName != null)
                callPayload.Queries["englishName"] = ExpressionConverter.Convert(englishName);
            if (chineseName != null)
                callPayload.Queries["chineseName"] = ExpressionConverter.Convert(chineseName);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (countryCode != null)
                callPayload.Queries["countryCode"] = ExpressionConverter.Convert(countryCode);
            if (phone != null)
                callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            if (code != null)
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (education != null)
                callPayload.Queries["education"] = ExpressionConverter.Convert(education);
            if (departmentId != null)
                callPayload.Queries["departmentId"] = ExpressionConverter.Convert(departmentId);
            if (positionId != null)
                callPayload.Queries["positionId"] = ExpressionConverter.Convert(positionId);
            if (hireType != null)
                callPayload.Queries["hireType"] = ExpressionConverter.Convert(hireType);
            if (bankCode != null)
                callPayload.Queries["bankCode"] = ExpressionConverter.Convert(bankCode);
            if (costCenterId != null)
                callPayload.Queries["costCenterId"] = ExpressionConverter.Convert(costCenterId);
            if (payrollRegulationId != null)
                callPayload.Queries["payrollRegulationId"] = ExpressionConverter.Convert(payrollRegulationId);
            if (workDate != null)
                callPayload.Queries["workDate"] = ExpressionConverter.Convert(workDate);
            return new ApiConnectionAction<ResultIPageV2EmployeeResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateEmployeeInfoV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyenglishName = null, Expression<Func<string>> bodychineseName = null, Expression<Func<string>> bodysex = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyidentityCard = null, Expression<Func<string>> bodybankCard = null, Expression<Func<string>> bodynickName = null, Expression<Func<string>> bodyeducation = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<string>> bodyemergencyContactRelation = null, Expression<Func<string>> bodyemergencyContactPhone = null, Expression<Func<string>> bodybankName = null, Expression<Func<string>> bodybankBranchNumber = null, Expression<Func<string>> bodybankAccountNo = null, Expression<Func<string>> bodybankCode = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyregionCode = null, Expression<Func<string>> bodyidentityCardHk = null, Expression<Func<string>> bodypassportNumber = null, Expression<Func<string>> bodypassportIssuingPlace = null, Expression<Func<string>> bodyspouseName = null, Expression<Func<string>> bodyspouseIdentityCardHk = null, Expression<Func<string>> bodyspousePassportNumber = null, Expression<Func<string>> bodyspousePassportIssuingPlace = null, Expression<Func<string>> bodypostalAddress = null, Expression<Func<string>> bodyemployerName = null, Expression<Func<string>> bodyhometown = null, Expression<Func<string>> bodynation = null, Expression<Func<string>> bodypoliticalStatus = null, Expression<Func<string>> bodyhighestEducation = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodyprobation = null, Expression<Func<bool>> bodyisDisabled = null, Expression<Func<bool>> bodyisForeignNationality = null, Expression<Func<string>> bodydomicileLocation = null, Expression<Func<string>> bodycertificateType = null, Expression<Func<string>> bodycertificateNumber = null, Expression<Func<bool>> bodyisMartyrDependents = null, Expression<Func<string>> bodyoccupationTaxNumber = null, Expression<Func<string>> bodynonLocalBlueCardNumber = null, Expression<Func<bool>> bodyisForeignEmployees = null, Expression<Func<string>> bodyweeklyLeaveWorkAgreement = null, Expression<Func<string>> bodyemployeeType = null, Expression<Func<string>> bodyjobLevel = null, Expression<Func<string>> bodypost = null, Expression<Func<string>> bodysalaryScale = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyrecruitmentSource = null, Expression<Func<string>> bodygraduatedSchool = null, Expression<Func<string>> bodyprofession = null, Expression<Func<string>> bodyappellation = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyhomePhone = null, Expression<Func<string>> bodyofficePhone = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyprovince = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycontractEndDate = null, Expression<Func<string>> bodytaxIdentity = null, Expression<Func<string>> bodyotherIncomeName = null)
        {
            var apiCallPath = "/v2/employee/updateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyenglishName != null)
            {
                body["englishName"] = ExpressionConverter.ConvertO(bodyenglishName);
                bodypropCount++;
            }

            if (bodychineseName != null)
            {
                body["chineseName"] = ExpressionConverter.ConvertO(bodychineseName);
                bodypropCount++;
            }

            if (bodysex != null)
            {
                body["sex"] = ExpressionConverter.ConvertO(bodysex);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodyidentityCard != null)
            {
                body["identityCard"] = ExpressionConverter.ConvertO(bodyidentityCard);
                bodypropCount++;
            }

            if (bodybankCard != null)
            {
                body["bankCard"] = ExpressionConverter.ConvertO(bodybankCard);
                bodypropCount++;
            }

            if (bodynickName != null)
            {
                body["nickName"] = ExpressionConverter.ConvertO(bodynickName);
                bodypropCount++;
            }

            if (bodyeducation != null)
            {
                body["education"] = ExpressionConverter.ConvertO(bodyeducation);
                bodypropCount++;
            }

            if (bodynationality != null)
            {
                body["nationality"] = ExpressionConverter.ConvertO(bodynationality);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["maritalStatus"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            if (bodyemergencyContactName != null)
            {
                body["emergencyContactName"] = ExpressionConverter.ConvertO(bodyemergencyContactName);
                bodypropCount++;
            }

            if (bodyemergencyContactRelation != null)
            {
                body["emergencyContactRelation"] = ExpressionConverter.ConvertO(bodyemergencyContactRelation);
                bodypropCount++;
            }

            if (bodyemergencyContactPhone != null)
            {
                body["emergencyContactPhone"] = ExpressionConverter.ConvertO(bodyemergencyContactPhone);
                bodypropCount++;
            }

            if (bodybankName != null)
            {
                body["bankName"] = ExpressionConverter.ConvertO(bodybankName);
                bodypropCount++;
            }

            if (bodybankBranchNumber != null)
            {
                body["bankBranchNumber"] = ExpressionConverter.ConvertO(bodybankBranchNumber);
                bodypropCount++;
            }

            if (bodybankAccountNo != null)
            {
                body["bankAccountNo"] = ExpressionConverter.ConvertO(bodybankAccountNo);
                bodypropCount++;
            }

            if (bodybankCode != null)
            {
                body["bankCode"] = ExpressionConverter.ConvertO(bodybankCode);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodyregionCode != null)
            {
                body["regionCode"] = ExpressionConverter.ConvertO(bodyregionCode);
                bodypropCount++;
            }

            if (bodyidentityCardHk != null)
            {
                body["identityCardHk"] = ExpressionConverter.ConvertO(bodyidentityCardHk);
                bodypropCount++;
            }

            if (bodypassportNumber != null)
            {
                body["passportNumber"] = ExpressionConverter.ConvertO(bodypassportNumber);
                bodypropCount++;
            }

            if (bodypassportIssuingPlace != null)
            {
                body["passportIssuingPlace"] = ExpressionConverter.ConvertO(bodypassportIssuingPlace);
                bodypropCount++;
            }

            if (bodyspouseName != null)
            {
                body["spouseName"] = ExpressionConverter.ConvertO(bodyspouseName);
                bodypropCount++;
            }

            if (bodyspouseIdentityCardHk != null)
            {
                body["spouseIdentityCardHk"] = ExpressionConverter.ConvertO(bodyspouseIdentityCardHk);
                bodypropCount++;
            }

            if (bodyspousePassportNumber != null)
            {
                body["spousePassportNumber"] = ExpressionConverter.ConvertO(bodyspousePassportNumber);
                bodypropCount++;
            }

            if (bodyspousePassportIssuingPlace != null)
            {
                body["spousePassportIssuingPlace"] = ExpressionConverter.ConvertO(bodyspousePassportIssuingPlace);
                bodypropCount++;
            }

            if (bodypostalAddress != null)
            {
                body["postalAddress"] = ExpressionConverter.ConvertO(bodypostalAddress);
                bodypropCount++;
            }

            if (bodyemployerName != null)
            {
                body["employerName"] = ExpressionConverter.ConvertO(bodyemployerName);
                bodypropCount++;
            }

            if (bodyhometown != null)
            {
                body["hometown"] = ExpressionConverter.ConvertO(bodyhometown);
                bodypropCount++;
            }

            if (bodynation != null)
            {
                body["nation"] = ExpressionConverter.ConvertO(bodynation);
                bodypropCount++;
            }

            if (bodypoliticalStatus != null)
            {
                body["politicalStatus"] = ExpressionConverter.ConvertO(bodypoliticalStatus);
                bodypropCount++;
            }

            if (bodyhighestEducation != null)
            {
                body["highestEducation"] = ExpressionConverter.ConvertO(bodyhighestEducation);
                bodypropCount++;
            }

            if (bodyworkDate != null)
            {
                body["workDate"] = ExpressionConverter.ConvertO(bodyworkDate);
                bodypropCount++;
            }

            if (bodyconfirmationDate != null)
            {
                body["confirmationDate"] = ExpressionConverter.ConvertO(bodyconfirmationDate);
                bodypropCount++;
            }

            if (bodyprobation != null)
            {
                body["probation"] = ExpressionConverter.ConvertO(bodyprobation);
                bodypropCount++;
            }

            if (bodyisDisabled != null)
            {
                body["isDisabled"] = ExpressionConverter.ConvertO(bodyisDisabled);
                bodypropCount++;
            }

            if (bodyisForeignNationality != null)
            {
                body["isForeignNationality"] = ExpressionConverter.ConvertO(bodyisForeignNationality);
                bodypropCount++;
            }

            if (bodydomicileLocation != null)
            {
                body["domicileLocation"] = ExpressionConverter.ConvertO(bodydomicileLocation);
                bodypropCount++;
            }

            if (bodycertificateType != null)
            {
                body["certificateType"] = ExpressionConverter.ConvertO(bodycertificateType);
                bodypropCount++;
            }

            if (bodycertificateNumber != null)
            {
                body["certificateNumber"] = ExpressionConverter.ConvertO(bodycertificateNumber);
                bodypropCount++;
            }

            if (bodyisMartyrDependents != null)
            {
                body["isMartyrDependents"] = ExpressionConverter.ConvertO(bodyisMartyrDependents);
                bodypropCount++;
            }

            if (bodyoccupationTaxNumber != null)
            {
                body["occupationTaxNumber"] = ExpressionConverter.ConvertO(bodyoccupationTaxNumber);
                bodypropCount++;
            }

            if (bodynonLocalBlueCardNumber != null)
            {
                body["nonLocalBlueCardNumber"] = ExpressionConverter.ConvertO(bodynonLocalBlueCardNumber);
                bodypropCount++;
            }

            if (bodyisForeignEmployees != null)
            {
                body["isForeignEmployees"] = ExpressionConverter.ConvertO(bodyisForeignEmployees);
                bodypropCount++;
            }

            if (bodyweeklyLeaveWorkAgreement != null)
            {
                body["weeklyLeaveWorkAgreement"] = ExpressionConverter.ConvertO(bodyweeklyLeaveWorkAgreement);
                bodypropCount++;
            }

            if (bodyemployeeType != null)
            {
                body["employeeType"] = ExpressionConverter.ConvertO(bodyemployeeType);
                bodypropCount++;
            }

            if (bodyjobLevel != null)
            {
                body["jobLevel"] = ExpressionConverter.ConvertO(bodyjobLevel);
                bodypropCount++;
            }

            if (bodypost != null)
            {
                body["post"] = ExpressionConverter.ConvertO(bodypost);
                bodypropCount++;
            }

            if (bodysalaryScale != null)
            {
                body["salaryScale"] = ExpressionConverter.ConvertO(bodysalaryScale);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                bodypropCount++;
            }

            if (bodyrecruitmentSource != null)
            {
                body["recruitmentSource"] = ExpressionConverter.ConvertO(bodyrecruitmentSource);
                bodypropCount++;
            }

            if (bodygraduatedSchool != null)
            {
                body["graduatedSchool"] = ExpressionConverter.ConvertO(bodygraduatedSchool);
                bodypropCount++;
            }

            if (bodyprofession != null)
            {
                body["profession"] = ExpressionConverter.ConvertO(bodyprofession);
                bodypropCount++;
            }

            if (bodyappellation != null)
            {
                body["appellation"] = ExpressionConverter.ConvertO(bodyappellation);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middleName"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodyhomePhone != null)
            {
                body["homePhone"] = ExpressionConverter.ConvertO(bodyhomePhone);
                bodypropCount++;
            }

            if (bodyofficePhone != null)
            {
                body["officePhone"] = ExpressionConverter.ConvertO(bodyofficePhone);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyprovince != null)
            {
                body["province"] = ExpressionConverter.ConvertO(bodyprovince);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodypostcode != null)
            {
                body["postcode"] = ExpressionConverter.ConvertO(bodypostcode);
                bodypropCount++;
            }

            if (bodycontractEndDate != null)
            {
                body["contractEndDate"] = ExpressionConverter.ConvertO(bodycontractEndDate);
                bodypropCount++;
            }

            if (bodytaxIdentity != null)
            {
                body["taxIdentity"] = ExpressionConverter.ConvertO(bodytaxIdentity);
                bodypropCount++;
            }

            if (bodyotherIncomeName != null)
            {
                body["otherIncomeName"] = ExpressionConverter.ConvertO(bodyotherIncomeName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2ExpenseResp> GetExpenseApplicationListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> reimbursementStatusFilter = null, Expression<Func<string>> reimbursementName = null, Expression<Func<string>> departmentFilter = null)
        {
            var apiCallPath = "/v2/tenants/getExpenseApplicationList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (reimbursementStatusFilter != null)
                callPayload.Queries["reimbursementStatusFilter"] = ExpressionConverter.Convert(reimbursementStatusFilter);
            if (reimbursementName != null)
                callPayload.Queries["reimbursementName"] = ExpressionConverter.Convert(reimbursementName);
            if (departmentFilter != null)
                callPayload.Queries["departmentFilter"] = ExpressionConverter.Convert(departmentFilter);
            return new ApiConnectionAction<ResultIPageV2ExpenseResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateExpenseApplicationV2(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyreimbursementName = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v2/tenants/updateExpenseApplication";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyreimbursementName != null)
            {
                body["reimbursementName"] = ExpressionConverter.ConvertO(bodyreimbursementName);
                bodypropCount++;
            }

            if (bodyamount != null)
            {
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2ExternalPayItemResp> GetExtPayItemDataV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> employeeCode = null, Expression<Func<string>> businessSalaryItemId = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> businessSalaryItemFilter = null)
        {
            var apiCallPath = "/v2/payroll/getExtPayItemData";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (employeeCode != null)
                callPayload.Queries["employeeCode"] = ExpressionConverter.Convert(employeeCode);
            if (businessSalaryItemId != null)
                callPayload.Queries["businessSalaryItemId"] = ExpressionConverter.Convert(businessSalaryItemId);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (businessSalaryItemFilter != null)
                callPayload.Queries["businessSalaryItemFilter"] = ExpressionConverter.Convert(businessSalaryItemFilter);
            return new ApiConnectionAction<ResultIPageV2ExternalPayItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2ExtPayItemResp> GetExtPayItemListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> paymentType = null, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/v2/payroll/getExtPayItemList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (paymentType != null)
                callPayload.Queries["paymentType"] = ExpressionConverter.Convert(paymentType);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ResultIPageV2ExtPayItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2FixedPayItemResp> GetFixedPayItemDataV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> payrollItemId = null)
        {
            var apiCallPath = "/v2/payroll/getFixedPayItemData";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (payrollItemId != null)
                callPayload.Queries["payrollItemId"] = ExpressionConverter.Convert(payrollItemId);
            return new ApiConnectionAction<ResultIPageV2FixedPayItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2PayItemResp> GetPayItemListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/v2/payroll/getPayItemList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ResultIPageV2PayItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2PayrollPlanResp> GetPayrunListV2(Expression<Func<string>> status, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v2/payroll/getPayrunList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ResultIPageV2PayrollPlanResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2VarPayItemResp> GetVarPayItemDataV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> payrollItemId = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> payrollItemIdFilter = null, Expression<Func<string>> payrollPlanId = null)
        {
            var apiCallPath = "/v2/payroll/getVarPayItemData";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (payrollItemId != null)
                callPayload.Queries["payrollItemId"] = ExpressionConverter.Convert(payrollItemId);
            if (employeeIdFilter != null)
                callPayload.Queries["employeeIdFilter"] = ExpressionConverter.Convert(employeeIdFilter);
            if (payrollItemIdFilter != null)
                callPayload.Queries["payrollItemIdFilter"] = ExpressionConverter.Convert(payrollItemIdFilter);
            if (payrollPlanId != null)
                callPayload.Queries["payrollPlanId"] = ExpressionConverter.Convert(payrollPlanId);
            return new ApiConnectionAction<ResultIPageV2VarPayItemResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateExternalSalaryV2(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodycode = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyoccurrenceDate = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var apiCallPath = "/v2/payroll/updateExternalSalary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodymoney != null)
            {
                body["money"] = ExpressionConverter.ConvertO(bodymoney);
                bodypropCount++;
            }

            if (bodyoccurrenceDate != null)
            {
                body["occurrenceDate"] = ExpressionConverter.ConvertO(bodyoccurrenceDate);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodyexpirationDate != null)
            {
                body["expirationDate"] = ExpressionConverter.ConvertO(bodyexpirationDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateFixedSalaryV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodypayrollItemId = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var apiCallPath = "/v2/payroll/updateFixedSalary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypayrollItemId != null)
            {
                body["payrollItemId"] = ExpressionConverter.ConvertO(bodypayrollItemId);
                bodypropCount++;
            }

            if (bodymoney != null)
            {
                body["money"] = ExpressionConverter.ConvertO(bodymoney);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateVarSalaryV2(Expression<Func<string>> bodyid, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyremark = null)
        {
            var apiCallPath = "/v2/payroll/updateVarSalary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodymoney != null)
            {
                body["money"] = ExpressionConverter.ConvertO(bodymoney);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2LabelResp> GetLabelListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> labelCode = null, Expression<Func<string>> labelName = null, Expression<Func<int>> labelStatus = null)
        {
            var apiCallPath = "/v2/label/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (labelCode != null)
                callPayload.Queries["labelCode"] = ExpressionConverter.Convert(labelCode);
            if (labelName != null)
                callPayload.Queries["labelName"] = ExpressionConverter.Convert(labelName);
            if (labelStatus != null)
                callPayload.Queries["labelStatus"] = ExpressionConverter.Convert(labelStatus);
            return new ApiConnectionAction<ResultIPageV2LabelResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateLabelInfoV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodylabelCode = null, Expression<Func<string>> bodylabelName = null, Expression<Func<int>> bodylabelStatus = null)
        {
            var apiCallPath = "/v2/label/update";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodylabelCode != null)
            {
                body["labelCode"] = ExpressionConverter.ConvertO(bodylabelCode);
                bodypropCount++;
            }

            if (bodylabelName != null)
            {
                body["labelName"] = ExpressionConverter.ConvertO(bodylabelName);
                bodypropCount++;
            }

            if (bodylabelStatus != null)
            {
                body["labelStatus"] = ExpressionConverter.ConvertO(bodylabelStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2LeaveApplicationResp> GetLeaveApplicationListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> holidayType = null, Expression<Func<string>> status = null, Expression<Func<string>> holidayDate = null)
        {
            var apiCallPath = "/v2/leave/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (holidayType != null)
                callPayload.Queries["holidayType"] = ExpressionConverter.Convert(holidayType);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (holidayDate != null)
                callPayload.Queries["holidayDate"] = ExpressionConverter.Convert(holidayDate);
            return new ApiConnectionAction<ResultIPageV2LeaveApplicationResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateLeaveApplicationV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyholidayType = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<double>> bodyleaveTime = null, Expression<Func<string>> bodytimeType = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyholidayDate = null, Expression<Func<string>> bodytime = null)
        {
            var apiCallPath = "/v2/leave/updateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyholidayType != null)
            {
                body["holidayType"] = ExpressionConverter.ConvertO(bodyholidayType);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodyleaveTime != null)
            {
                body["leaveTime"] = ExpressionConverter.ConvertO(bodyleaveTime);
                bodypropCount++;
            }

            if (bodytimeType != null)
            {
                body["timeType"] = ExpressionConverter.ConvertO(bodytimeType);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodyholidayDate != null)
            {
                body["holidayDate"] = ExpressionConverter.ConvertO(bodyholidayDate);
                bodypropCount++;
            }

            if (bodytime != null)
            {
                body["time"] = ExpressionConverter.ConvertO(bodytime);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2PositionResp> GetPositionListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> positionCode = null)
        {
            var apiCallPath = "/v2/tenants/getPositionList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (positionCode != null)
                callPayload.Queries["positionCode"] = ExpressionConverter.Convert(positionCode);
            return new ApiConnectionAction<ResultIPageV2PositionResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdatePositionInfoV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = "/v2/tenants/updatePositionInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypositionCode != null)
            {
                body["positionCode"] = ExpressionConverter.ConvertO(bodypositionCode);
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

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV2TenantResp> GetTenantInfoV2()
        {
            var apiCallPath = "/v2/tenant/getById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultV2TenantResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateTenantInfoV2(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodybusinessRegistrationNumber = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodybankName = null, Expression<Func<string>> bodybankBranchCode = null, Expression<Func<string>> bodybankAccountNo = null)
        {
            var apiCallPath = "/v2/tenant/updateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodybusinessRegistrationNumber != null)
            {
                body["businessRegistrationNumber"] = ExpressionConverter.ConvertO(bodybusinessRegistrationNumber);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodybankName != null)
            {
                body["bankName"] = ExpressionConverter.ConvertO(bodybankName);
                bodypropCount++;
            }

            if (bodybankBranchCode != null)
            {
                body["bankBranchCode"] = ExpressionConverter.ConvertO(bodybankBranchCode);
                bodypropCount++;
            }

            if (bodybankAccountNo != null)
            {
                body["bankAccountNo"] = ExpressionConverter.ConvertO(bodybankAccountNo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2TimesheetResp> GetTimesheetListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> type = null, Expression<Func<string>> date = null, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/v2/timesheet/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (employeeId != null)
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (date != null)
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ResultIPageV2TimesheetResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateTimesheetV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodyisCrossTheSky = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<int>> bodymealTime = null)
        {
            var apiCallPath = "/v2/timesheet/updateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyisCrossTheSky != null)
            {
                body["isCrossTheSky"] = ExpressionConverter.ConvertO(bodyisCrossTheSky);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodymealTime != null)
            {
                body["mealTime"] = ExpressionConverter.ConvertO(bodymealTime);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2WorkLocationResp> GetWorkLocationListV2(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> attendanceAddressCode = null, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/v2/workLocation/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (current != null)
                callPayload.Queries["current"] = ExpressionConverter.Convert(current);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (attendanceAddressCode != null)
                callPayload.Queries["attendanceAddressCode"] = ExpressionConverter.Convert(attendanceAddressCode);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<ResultIPageV2WorkLocationResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateWorkLocationV2(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyregion = null, Expression<Func<string>> bodyattendanceAddressCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyareaCode = null)
        {
            var apiCallPath = "/v2/workLocation/updateById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodyattendanceAddressCode != null)
            {
                body["attendanceAddressCode"] = ExpressionConverter.ConvertO(bodyattendanceAddressCode);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyareaCode != null)
            {
                body["areaCode"] = ExpressionConverter.ConvertO(bodyareaCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResultBoolean>(callPayload);
        }
    }

    public class WorkstemhkTriggers([ConnectionName] string connectionId)
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

    public class ResultV3PayrollRegResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3PayrollRegResp Data { get; set; }
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

    public class ResultV3ExternalPayItemResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3ExternalPayItemResp Data { get; set; }
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

    public class ResultV3AttAddressResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3AttAddressResp Data { get; set; }
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

    public class ResultV3BizEmployeeCustomizationResp
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public V3BizEmployeeCustomizationResp Data { get; set; }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workstemhk;

    public partial class WorkflowManagedActions
    {
        public WorkstemhkActions Workstemhk(string connectionId) => new WorkstemhkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkstemhkTriggers Workstemhk(string connectionId) => new WorkstemhkTriggers(connectionId);
    }
}