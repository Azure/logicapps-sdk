//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workstemhk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkstemhkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _001addFixedSalaryData(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodypayrollItemId, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<double>> bodytotalLimitAmount = null, Expression<Func<double>> bodypaidAmount = null, Expression<Func<double>> bodysurplusAmount = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodypayrollItemId = WorkflowExpression.Compile(bodypayrollItemId, nameof(bodypayrollItemId), required: true);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodytotalLimitAmount = WorkflowExpression.Compile(bodytotalLimitAmount, nameof(bodytotalLimitAmount), required: false);
            var __workflow_bodypaidAmount = WorkflowExpression.Compile(bodypaidAmount, nameof(bodypaidAmount), required: false);
            var __workflow_bodysurplusAmount = WorkflowExpression.Compile(bodysurplusAmount, nameof(bodysurplusAmount), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/addFixedSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["payrollItemId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollItemId);
                if (__workflow_bodymoney != null)
                {
                    body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodytotalLimitAmount != null)
                {
                    body["totalLimitAmount"] = ExpressionConverter.ConvertO(__workflow_bodytotalLimitAmount);
                    bodypropCount++;
                }

                if (__workflow_bodypaidAmount != null)
                {
                    body["paidAmount"] = ExpressionConverter.ConvertO(__workflow_bodypaidAmount);
                    bodypropCount++;
                }

                if (__workflow_bodysurplusAmount != null)
                {
                    body["surplusAmount"] = ExpressionConverter.ConvertO(__workflow_bodysurplusAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3TenantResp> _001getCompanyInfo()
        {
            var apiCallPath = "/v3/company/getCompanyInfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultV3TenantResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _002deleteFixedSalaryDataById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteFixedSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3SysEnterpriseUserResp> _002getUserList()
        {
            var apiCallPath = "/v3/company/getUserList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultListV3SysEnterpriseUserResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3SysEnterpriseUserResp> _003getUserInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3SysEnterpriseUserResp>(() =>
            {
                var apiCallPath = "/v3/company/getUserInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3SysEnterpriseUserResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _003updateFixedSalaryDataById(Expression<Func<string>> bodyid, Expression<Func<string>> bodypayrollItemId = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<double>> bodytotalLimitAmount = null, Expression<Func<double>> bodypaidAmount = null, Expression<Func<double>> bodysurplusAmount = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodypayrollItemId = WorkflowExpression.Compile(bodypayrollItemId, nameof(bodypayrollItemId), required: false);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodytotalLimitAmount = WorkflowExpression.Compile(bodytotalLimitAmount, nameof(bodytotalLimitAmount), required: false);
            var __workflow_bodypaidAmount = WorkflowExpression.Compile(bodypaidAmount, nameof(bodypaidAmount), required: false);
            var __workflow_bodysurplusAmount = WorkflowExpression.Compile(bodysurplusAmount, nameof(bodysurplusAmount), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/updateFixedSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodypayrollItemId != null)
                {
                    body["payrollItemId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollItemId);
                    bodypropCount++;
                }

                if (__workflow_bodymoney != null)
                {
                    body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodytotalLimitAmount != null)
                {
                    body["totalLimitAmount"] = ExpressionConverter.ConvertO(__workflow_bodytotalLimitAmount);
                    bodypropCount++;
                }

                if (__workflow_bodypaidAmount != null)
                {
                    body["paidAmount"] = ExpressionConverter.ConvertO(__workflow_bodypaidAmount);
                    bodypropCount++;
                }

                if (__workflow_bodysurplusAmount != null)
                {
                    body["surplusAmount"] = ExpressionConverter.ConvertO(__workflow_bodysurplusAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _004addLocationInfo(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddress, Expression<Func<double>> bodylongitude, Expression<Func<double>> bodylatitude, Expression<Func<string>> bodyareaCode, Expression<Func<int>> bodyregion = null, Expression<Func<bool>> bodyisEnableGps = null, Expression<Func<bool>> bodyisEnableBluetooth = null, Expression<Func<string>> bodyattendanceAddressCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymapType = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: true);
            var __workflow_bodylongitude = WorkflowExpression.Compile(bodylongitude, nameof(bodylongitude), required: true);
            var __workflow_bodylatitude = WorkflowExpression.Compile(bodylatitude, nameof(bodylatitude), required: true);
            var __workflow_bodyareaCode = WorkflowExpression.Compile(bodyareaCode, nameof(bodyareaCode), required: true);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodyisEnableGps = WorkflowExpression.Compile(bodyisEnableGps, nameof(bodyisEnableGps), required: false);
            var __workflow_bodyisEnableBluetooth = WorkflowExpression.Compile(bodyisEnableBluetooth, nameof(bodyisEnableBluetooth), required: false);
            var __workflow_bodyattendanceAddressCode = WorkflowExpression.Compile(bodyattendanceAddressCode, nameof(bodyattendanceAddressCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymapType = WorkflowExpression.Compile(bodymapType, nameof(bodymapType), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/addLocationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                bodypropCount++;
                body["longitude"] = ExpressionConverter.ConvertO(__workflow_bodylongitude);
                bodypropCount++;
                body["latitude"] = ExpressionConverter.ConvertO(__workflow_bodylatitude);
                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodyisEnableGps != null)
                {
                    body["isEnableGps"] = ExpressionConverter.ConvertO(__workflow_bodyisEnableGps);
                    bodypropCount++;
                }

                if (__workflow_bodyisEnableBluetooth != null)
                {
                    body["isEnableBluetooth"] = ExpressionConverter.ConvertO(__workflow_bodyisEnableBluetooth);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceAddressCode != null)
                {
                    body["attendanceAddressCode"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceAddressCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodymapType != null)
                {
                    body["mapType"] = ExpressionConverter.ConvertO(__workflow_bodymapType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["areaCode"] = ExpressionConverter.ConvertO(__workflow_bodyareaCode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3PayrollFixedResp> _004getFixedSalaryDataByEmployeeId(Expression<Func<string>> employeeId)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            return new DeferredBodyAction<ResultListV3PayrollFixedResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getFixedSalaryDataByEmployeeId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                return new ApiConnectionAction<ResultListV3PayrollFixedResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _005addVariableSalaryData(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodypayrollItemId, Expression<Func<double>> bodymoney, Expression<Func<string>> bodypayrollDate, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodydataType = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodypayrollItemId = WorkflowExpression.Compile(bodypayrollItemId, nameof(bodypayrollItemId), required: true);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: true);
            var __workflow_bodypayrollDate = WorkflowExpression.Compile(bodypayrollDate, nameof(bodypayrollDate), required: true);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodydataType = WorkflowExpression.Compile(bodydataType, nameof(bodydataType), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/addVariableSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["payrollItemId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollItemId);
                bodypropCount++;
                body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                bodypropCount++;
                body["payrollDate"] = ExpressionConverter.ConvertO(__workflow_bodypayrollDate);
                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodydataType != null)
                {
                    body["dataType"] = ExpressionConverter.ConvertO(__workflow_bodydataType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _005deleteLocationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteLocationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _006deleteVariableSalaryDataById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteVariableSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _006updateLocationById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyaddress = null, Expression<Func<double>> bodylongitude = null, Expression<Func<double>> bodylatitude = null, Expression<Func<int>> bodyregion = null, Expression<Func<bool>> bodyisEnableGps = null, Expression<Func<bool>> bodyisEnableBluetooth = null, Expression<Func<string>> bodyattendanceAddressCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymapType = null, Expression<Func<string>> bodyareaCode = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodylongitude = WorkflowExpression.Compile(bodylongitude, nameof(bodylongitude), required: false);
            var __workflow_bodylatitude = WorkflowExpression.Compile(bodylatitude, nameof(bodylatitude), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodyisEnableGps = WorkflowExpression.Compile(bodyisEnableGps, nameof(bodyisEnableGps), required: false);
            var __workflow_bodyisEnableBluetooth = WorkflowExpression.Compile(bodyisEnableBluetooth, nameof(bodyisEnableBluetooth), required: false);
            var __workflow_bodyattendanceAddressCode = WorkflowExpression.Compile(bodyattendanceAddressCode, nameof(bodyattendanceAddressCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymapType = WorkflowExpression.Compile(bodymapType, nameof(bodymapType), required: false);
            var __workflow_bodyareaCode = WorkflowExpression.Compile(bodyareaCode, nameof(bodyareaCode), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/updateLocationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodylongitude != null)
                {
                    body["longitude"] = ExpressionConverter.ConvertO(__workflow_bodylongitude);
                    bodypropCount++;
                }

                if (__workflow_bodylatitude != null)
                {
                    body["latitude"] = ExpressionConverter.ConvertO(__workflow_bodylatitude);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodyisEnableGps != null)
                {
                    body["isEnableGps"] = ExpressionConverter.ConvertO(__workflow_bodyisEnableGps);
                    bodypropCount++;
                }

                if (__workflow_bodyisEnableBluetooth != null)
                {
                    body["isEnableBluetooth"] = ExpressionConverter.ConvertO(__workflow_bodyisEnableBluetooth);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceAddressCode != null)
                {
                    body["attendanceAddressCode"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceAddressCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodymapType != null)
                {
                    body["mapType"] = ExpressionConverter.ConvertO(__workflow_bodymapType);
                    bodypropCount++;
                }

                if (__workflow_bodyareaCode != null)
                {
                    body["areaCode"] = ExpressionConverter.ConvertO(__workflow_bodyareaCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3AttAddressResp> _007getLocationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3AttAddressResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _007updateVariableSalaryDataById(Expression<Func<string>> bodyid, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/updateVariableSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodymoney != null)
                {
                    body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AttAddressResp> _008getLocationInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3AttAddressResp>(() =>
            {
                var apiCallPath = "/v3/company/getLocationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3AttAddressResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollNonFixedResp> _008getVariableSalaryDataList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> payrollDateFilter = null, Expression<Func<string>> moneyFilter = null, Expression<Func<string>> payrollItemIdFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> bizLabelIds = null)
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
            return new DeferredBodyAction<ResultIPageV3PayrollNonFixedResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _009addExternalSalaryData(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodybusinessSalaryItemId, Expression<Func<double>> bodymoney, Expression<Func<string>> bodyoccurrenceDate, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodybusinessSalaryItemId = WorkflowExpression.Compile(bodybusinessSalaryItemId, nameof(bodybusinessSalaryItemId), required: true);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: true);
            var __workflow_bodyoccurrenceDate = WorkflowExpression.Compile(bodyoccurrenceDate, nameof(bodyoccurrenceDate), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodyexpirationDate = WorkflowExpression.Compile(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/addExternalSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["businessSalaryItemId"] = ExpressionConverter.ConvertO(__workflow_bodybusinessSalaryItemId);
                bodypropCount++;
                body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                bodypropCount++;
                body["occurrenceDate"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceDate);
                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodyexpirationDate != null)
                {
                    body["expirationDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AttRuleResp> _009getLocationAttendanceRulesById(Expression<Func<string>> workLocationId)
        {
            var __workflow_workLocationId = WorkflowExpression.Compile(workLocationId, nameof(workLocationId), required: true);
            return new DeferredBodyAction<ResultV3AttRuleResp>(() =>
            {
                var apiCallPath = "/v3/company/getLocationAttendanceRulesById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workLocationId"] = ExpressionConverter.Convert(__workflow_workLocationId);
                return new ApiConnectionAction<ResultV3AttRuleResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _010addDepartmentInfo(Expression<Func<string>> bodyname, Expression<Func<string>> bodydepartmentCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydepartmentCode = WorkflowExpression.Compile(bodydepartmentCode, nameof(bodydepartmentCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/addDepartmentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydepartmentCode != null)
                {
                    body["departmentCode"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _010deleteExternalSalaryDataById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteExternalSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _011deleteDepartmentById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteDepartmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _011updateExternalSalaryDataById(Expression<Func<string>> bodyid, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyemployeeId = null, Expression<Func<string>> bodybusinessSalaryItemId = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyoccurrenceDate = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: false);
            var __workflow_bodybusinessSalaryItemId = WorkflowExpression.Compile(bodybusinessSalaryItemId, nameof(bodybusinessSalaryItemId), required: false);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: false);
            var __workflow_bodyoccurrenceDate = WorkflowExpression.Compile(bodyoccurrenceDate, nameof(bodyoccurrenceDate), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodyexpirationDate = WorkflowExpression.Compile(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/updateExternalSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyemployeeId != null)
                {
                    body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                    bodypropCount++;
                }

                if (__workflow_bodybusinessSalaryItemId != null)
                {
                    body["businessSalaryItemId"] = ExpressionConverter.ConvertO(__workflow_bodybusinessSalaryItemId);
                    bodypropCount++;
                }

                if (__workflow_bodymoney != null)
                {
                    body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                    bodypropCount++;
                }

                if (__workflow_bodyoccurrenceDate != null)
                {
                    body["occurrenceDate"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceDate);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodyexpirationDate != null)
                {
                    body["expirationDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayrollResp> _012getExternalSalaryDataList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> businessSalaryItemFilter = null, Expression<Func<string>> occurrenceDateFilter = null, Expression<Func<string>> moneyFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> labelFilter = null)
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
            return new DeferredBodyAction<ResultIPageV3ExternalPayrollResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _012updateDepartmentById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydepartmentCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydepartmentCode = WorkflowExpression.Compile(bodydepartmentCode, nameof(bodydepartmentCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/updateDepartmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentCode != null)
                {
                    body["departmentCode"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3DepartmentResp> _013getDepartmentList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3DepartmentResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanResp> _013getPayrollRunList(Expression<Func<string>> status, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollPlanResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _014addPositionInfo(Expression<Func<string>> bodyname, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypositionCode = WorkflowExpression.Compile(bodypositionCode, nameof(bodypositionCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/addPositionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodypositionCode != null)
                {
                    body["positionCode"] = ExpressionConverter.ConvertO(__workflow_bodypositionCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanDetailResp> _014getPayrollRunDataList(Expression<Func<string>> planId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollPlanDetailResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _015deletePositionById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deletePositionById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3PayrollPlanDetailResp> _015getPayrollDetailsInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultListV3PayrollPlanDetailResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultListV3PayrollPlanDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollRegResp> _016getPayrollPolicyList(Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> q = null)
        {
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollRegResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _016updatePositionById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodypositionCode = WorkflowExpression.Compile(bodypositionCode, nameof(bodypositionCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/updatePositionById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodypositionCode != null)
                {
                    body["positionCode"] = ExpressionConverter.ConvertO(__workflow_bodypositionCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3PayrollRegResp> _017getPayrollPolicyInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3PayrollRegResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollPolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3PayrollRegResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PositionResp> _017getPositionList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PositionResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _018addCostCenterInfo(Expression<Func<string>> bodyname, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycostCenterCode = WorkflowExpression.Compile(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/addCostCenterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodycostCenterCode != null)
                {
                    body["costCenterCode"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3PayrollItemResp> _018getPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> nameFilter = null, Expression<Func<string>> paymentTypeFilter = null, Expression<Func<string>> payrollItemTypeId = null, Expression<Func<string>> statusFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_nameFilter = WorkflowExpression.Compile(nameFilter, nameof(nameFilter), required: false);
            var __workflow_paymentTypeFilter = WorkflowExpression.Compile(paymentTypeFilter, nameof(paymentTypeFilter), required: false);
            var __workflow_payrollItemTypeId = WorkflowExpression.Compile(payrollItemTypeId, nameof(payrollItemTypeId), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollItemResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _019deleteCostCenterById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteCostCenterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3PayrollItemResp> _019getPayItemInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3PayrollItemResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3PayrollItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddEmployeeResp> _01addEmployeeInfo(Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodyenglishName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyemployeeStatus = null, Expression<Func<string>> bodysex = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyidentityCard = null, Expression<Func<string>> bodychineseName = null, Expression<Func<string>> bodysurnameEnglish = null, Expression<Func<string>> bodypersonalNameEnglish = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<string>> bodyemergencyContactRelation = null, Expression<Func<string>> bodyemergencyContactPhone = null, Expression<Func<string>> bodybankCode = null, Expression<Func<string>> bodybankBranchNumber = null, Expression<Func<string>> bodybankAccountNo = null, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodydate1 = null, Expression<Func<string>> bodydate2 = null, Expression<Func<string>> bodydate3 = null, Expression<Func<string>> bodydate4 = null, Expression<Func<string>> bodytext1 = null, Expression<Func<string>> bodytext2 = null, Expression<Func<string>> bodytext3 = null, Expression<Func<string>> bodytext4 = null, Expression<Func<string>> bodytext5 = null, Expression<Func<string>> bodytext6 = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodymobileCardCalType = null, Expression<Func<string>> bodyregularType = null, Expression<Func<string>> bodyinsurePlanName = null, Expression<Func<string>> bodybizLabelIds = null)
        {
            var __workflow_bodyentryDate = WorkflowExpression.Compile(bodyentryDate, nameof(bodyentryDate), required: true);
            var __workflow_bodyenglishName = WorkflowExpression.Compile(bodyenglishName, nameof(bodyenglishName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyemployeeStatus = WorkflowExpression.Compile(bodyemployeeStatus, nameof(bodyemployeeStatus), required: false);
            var __workflow_bodysex = WorkflowExpression.Compile(bodysex, nameof(bodysex), required: false);
            var __workflow_bodynationality = WorkflowExpression.Compile(bodynationality, nameof(bodynationality), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodycountryCode = WorkflowExpression.Compile(bodycountryCode, nameof(bodycountryCode), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodycalculateSalaryType = WorkflowExpression.Compile(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            var __workflow_bodyworkDate = WorkflowExpression.Compile(bodyworkDate, nameof(bodyworkDate), required: false);
            var __workflow_bodybasicPay = WorkflowExpression.Compile(bodybasicPay, nameof(bodybasicPay), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyidentityCard = WorkflowExpression.Compile(bodyidentityCard, nameof(bodyidentityCard), required: false);
            var __workflow_bodychineseName = WorkflowExpression.Compile(bodychineseName, nameof(bodychineseName), required: false);
            var __workflow_bodysurnameEnglish = WorkflowExpression.Compile(bodysurnameEnglish, nameof(bodysurnameEnglish), required: false);
            var __workflow_bodypersonalNameEnglish = WorkflowExpression.Compile(bodypersonalNameEnglish, nameof(bodypersonalNameEnglish), required: false);
            var __workflow_bodybirthday = WorkflowExpression.Compile(bodybirthday, nameof(bodybirthday), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodyemergencyContactName = WorkflowExpression.Compile(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            var __workflow_bodyemergencyContactRelation = WorkflowExpression.Compile(bodyemergencyContactRelation, nameof(bodyemergencyContactRelation), required: false);
            var __workflow_bodyemergencyContactPhone = WorkflowExpression.Compile(bodyemergencyContactPhone, nameof(bodyemergencyContactPhone), required: false);
            var __workflow_bodybankCode = WorkflowExpression.Compile(bodybankCode, nameof(bodybankCode), required: false);
            var __workflow_bodybankBranchNumber = WorkflowExpression.Compile(bodybankBranchNumber, nameof(bodybankBranchNumber), required: false);
            var __workflow_bodybankAccountNo = WorkflowExpression.Compile(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            var __workflow_bodyconfirmationDate = WorkflowExpression.Compile(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            var __workflow_bodydate1 = WorkflowExpression.Compile(bodydate1, nameof(bodydate1), required: false);
            var __workflow_bodydate2 = WorkflowExpression.Compile(bodydate2, nameof(bodydate2), required: false);
            var __workflow_bodydate3 = WorkflowExpression.Compile(bodydate3, nameof(bodydate3), required: false);
            var __workflow_bodydate4 = WorkflowExpression.Compile(bodydate4, nameof(bodydate4), required: false);
            var __workflow_bodytext1 = WorkflowExpression.Compile(bodytext1, nameof(bodytext1), required: false);
            var __workflow_bodytext2 = WorkflowExpression.Compile(bodytext2, nameof(bodytext2), required: false);
            var __workflow_bodytext3 = WorkflowExpression.Compile(bodytext3, nameof(bodytext3), required: false);
            var __workflow_bodytext4 = WorkflowExpression.Compile(bodytext4, nameof(bodytext4), required: false);
            var __workflow_bodytext5 = WorkflowExpression.Compile(bodytext5, nameof(bodytext5), required: false);
            var __workflow_bodytext6 = WorkflowExpression.Compile(bodytext6, nameof(bodytext6), required: false);
            var __workflow_bodydirectSupervisorId = WorkflowExpression.Compile(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodypositionId = WorkflowExpression.Compile(bodypositionId, nameof(bodypositionId), required: false);
            var __workflow_bodyhireType = WorkflowExpression.Compile(bodyhireType, nameof(bodyhireType), required: false);
            var __workflow_bodypayrollRegulationId = WorkflowExpression.Compile(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyattendCalculationId = WorkflowExpression.Compile(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            var __workflow_bodymobileCardCalType = WorkflowExpression.Compile(bodymobileCardCalType, nameof(bodymobileCardCalType), required: false);
            var __workflow_bodyregularType = WorkflowExpression.Compile(bodyregularType, nameof(bodyregularType), required: false);
            var __workflow_bodyinsurePlanName = WorkflowExpression.Compile(bodyinsurePlanName, nameof(bodyinsurePlanName), required: false);
            var __workflow_bodybizLabelIds = WorkflowExpression.Compile(bodybizLabelIds, nameof(bodybizLabelIds), required: false);
            return new DeferredBodyAction<ResultV3AddEmployeeResp>(() =>
            {
                var apiCallPath = "/v3/employee/addEmployeeInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entryDate"] = ExpressionConverter.ConvertO(__workflow_bodyentryDate);
                bodypropCount++;
                body["englishName"] = ExpressionConverter.ConvertO(__workflow_bodyenglishName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyemployeeStatus != null)
                {
                    body["employeeStatus"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeStatus);
                    bodypropCount++;
                }

                if (__workflow_bodysex != null)
                {
                    body["sex"] = ExpressionConverter.ConvertO(__workflow_bodysex);
                    bodypropCount++;
                }

                if (__workflow_bodynationality != null)
                {
                    body["nationality"] = ExpressionConverter.ConvertO(__workflow_bodynationality);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["maritalStatus"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodycountryCode != null)
                {
                    body["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodycountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = ExpressionConverter.ConvertO(__workflow_bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (__workflow_bodyworkDate != null)
                {
                    body["workDate"] = ExpressionConverter.ConvertO(__workflow_bodyworkDate);
                    bodypropCount++;
                }

                if (__workflow_bodybasicPay != null)
                {
                    body["basicPay"] = ExpressionConverter.ConvertO(__workflow_bodybasicPay);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyidentityCard != null)
                {
                    body["identityCard"] = ExpressionConverter.ConvertO(__workflow_bodyidentityCard);
                    bodypropCount++;
                }

                if (__workflow_bodychineseName != null)
                {
                    body["chineseName"] = ExpressionConverter.ConvertO(__workflow_bodychineseName);
                    bodypropCount++;
                }

                if (__workflow_bodysurnameEnglish != null)
                {
                    body["surnameEnglish"] = ExpressionConverter.ConvertO(__workflow_bodysurnameEnglish);
                    bodypropCount++;
                }

                if (__workflow_bodypersonalNameEnglish != null)
                {
                    body["personalNameEnglish"] = ExpressionConverter.ConvertO(__workflow_bodypersonalNameEnglish);
                    bodypropCount++;
                }

                if (__workflow_bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(__workflow_bodybirthday);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactName);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactRelation != null)
                {
                    body["emergencyContactRelation"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactRelation);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactPhone != null)
                {
                    body["emergencyContactPhone"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactPhone);
                    bodypropCount++;
                }

                if (__workflow_bodybankCode != null)
                {
                    body["bankCode"] = ExpressionConverter.ConvertO(__workflow_bodybankCode);
                    bodypropCount++;
                }

                if (__workflow_bodybankBranchNumber != null)
                {
                    body["bankBranchNumber"] = ExpressionConverter.ConvertO(__workflow_bodybankBranchNumber);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountNo);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationDate);
                    bodypropCount++;
                }

                if (__workflow_bodydate1 != null)
                {
                    body["date1"] = ExpressionConverter.ConvertO(__workflow_bodydate1);
                    bodypropCount++;
                }

                if (__workflow_bodydate2 != null)
                {
                    body["date2"] = ExpressionConverter.ConvertO(__workflow_bodydate2);
                    bodypropCount++;
                }

                if (__workflow_bodydate3 != null)
                {
                    body["date3"] = ExpressionConverter.ConvertO(__workflow_bodydate3);
                    bodypropCount++;
                }

                if (__workflow_bodydate4 != null)
                {
                    body["date4"] = ExpressionConverter.ConvertO(__workflow_bodydate4);
                    bodypropCount++;
                }

                if (__workflow_bodytext1 != null)
                {
                    body["text1"] = ExpressionConverter.ConvertO(__workflow_bodytext1);
                    bodypropCount++;
                }

                if (__workflow_bodytext2 != null)
                {
                    body["text2"] = ExpressionConverter.ConvertO(__workflow_bodytext2);
                    bodypropCount++;
                }

                if (__workflow_bodytext3 != null)
                {
                    body["text3"] = ExpressionConverter.ConvertO(__workflow_bodytext3);
                    bodypropCount++;
                }

                if (__workflow_bodytext4 != null)
                {
                    body["text4"] = ExpressionConverter.ConvertO(__workflow_bodytext4);
                    bodypropCount++;
                }

                if (__workflow_bodytext5 != null)
                {
                    body["text5"] = ExpressionConverter.ConvertO(__workflow_bodytext5);
                    bodypropCount++;
                }

                if (__workflow_bodytext6 != null)
                {
                    body["text6"] = ExpressionConverter.ConvertO(__workflow_bodytext6);
                    bodypropCount++;
                }

                if (__workflow_bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = ExpressionConverter.ConvertO(__workflow_bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodypositionId != null)
                {
                    body["positionId"] = ExpressionConverter.ConvertO(__workflow_bodypositionId);
                    bodypropCount++;
                }

                if (__workflow_bodyhireType != null)
                {
                    body["hireType"] = ExpressionConverter.ConvertO(__workflow_bodyhireType);
                    bodypropCount++;
                }

                if (__workflow_bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = ExpressionConverter.ConvertO(__workflow_bodyattendCalculationId);
                    bodypropCount++;
                }

                if (__workflow_bodymobileCardCalType != null)
                {
                    body["mobileCardCalType"] = ExpressionConverter.ConvertO(__workflow_bodymobileCardCalType);
                    bodypropCount++;
                }

                if (__workflow_bodyregularType != null)
                {
                    body["regularType"] = ExpressionConverter.ConvertO(__workflow_bodyregularType);
                    bodypropCount++;
                }

                if (__workflow_bodyinsurePlanName != null)
                {
                    body["insurePlanName"] = ExpressionConverter.ConvertO(__workflow_bodyinsurePlanName);
                    bodypropCount++;
                }

                if (__workflow_bodybizLabelIds != null)
                {
                    body["bizLabelIds"] = ExpressionConverter.ConvertO(__workflow_bodybizLabelIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3AddEmployeeResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _01addLeaveBalanceAdjustInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyholidayType, Expression<Func<string>> bodyoccurrenceTime, Expression<Func<string>> bodycause, Expression<Func<string>> bodyadjust)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyholidayType = WorkflowExpression.Compile(bodyholidayType, nameof(bodyholidayType), required: true);
            var __workflow_bodyoccurrenceTime = WorkflowExpression.Compile(bodyoccurrenceTime, nameof(bodyoccurrenceTime), required: true);
            var __workflow_bodycause = WorkflowExpression.Compile(bodycause, nameof(bodycause), required: true);
            var __workflow_bodyadjust = WorkflowExpression.Compile(bodyadjust, nameof(bodyadjust), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/leave/addLeaveBalanceAdjustInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["holidayType"] = ExpressionConverter.ConvertO(__workflow_bodyholidayType);
                bodypropCount++;
                body["occurrenceTime"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceTime);
                bodypropCount++;
                body["cause"] = ExpressionConverter.ConvertO(__workflow_bodycause);
                bodypropCount++;
                body["adjust"] = ExpressionConverter.ConvertO(__workflow_bodyadjust);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _01addRosterInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyattendDay, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodyshiftTemplateId = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<double>> bodyhourlyRate = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<double>> bodytierRate = null, Expression<Func<double>> bodyscheduledAmount = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyattendDay = WorkflowExpression.Compile(bodyattendDay, nameof(bodyattendDay), required: true);
            var __workflow_bodyshiftIn = WorkflowExpression.Compile(bodyshiftIn, nameof(bodyshiftIn), required: true);
            var __workflow_bodyshiftOff = WorkflowExpression.Compile(bodyshiftOff, nameof(bodyshiftOff), required: true);
            var __workflow_bodyshiftTemplateId = WorkflowExpression.Compile(bodyshiftTemplateId, nameof(bodyshiftTemplateId), required: false);
            var __workflow_bodyaddressCardId = WorkflowExpression.Compile(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyshiftStatus = WorkflowExpression.Compile(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            var __workflow_bodydateType = WorkflowExpression.Compile(bodydateType, nameof(bodydateType), required: false);
            var __workflow_bodyattendanceItemId = WorkflowExpression.Compile(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            var __workflow_bodyhourlyRate = WorkflowExpression.Compile(bodyhourlyRate, nameof(bodyhourlyRate), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodytierRate = WorkflowExpression.Compile(bodytierRate, nameof(bodytierRate), required: false);
            var __workflow_bodyscheduledAmount = WorkflowExpression.Compile(bodyscheduledAmount, nameof(bodyscheduledAmount), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addRosterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["attendDay"] = ExpressionConverter.ConvertO(__workflow_bodyattendDay);
                if (__workflow_bodyshiftTemplateId != null)
                {
                    body["shiftTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyshiftTemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCardId != null)
                {
                    body["addressCardId"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftIn"] = ExpressionConverter.ConvertO(__workflow_bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = ExpressionConverter.ConvertO(__workflow_bodyshiftOff);
                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftStatus != null)
                {
                    body["shiftStatus"] = ExpressionConverter.ConvertO(__workflow_bodyshiftStatus);
                    bodypropCount++;
                }

                if (__workflow_bodydateType != null)
                {
                    body["dateType"] = ExpressionConverter.ConvertO(__workflow_bodydateType);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodyhourlyRate != null)
                {
                    body["hourlyRate"] = ExpressionConverter.ConvertO(__workflow_bodyhourlyRate);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodytierRate != null)
                {
                    body["tierRate"] = ExpressionConverter.ConvertO(__workflow_bodytierRate);
                    bodypropCount++;
                }

                if (__workflow_bodyscheduledAmount != null)
                {
                    body["scheduledAmount"] = ExpressionConverter.ConvertO(__workflow_bodyscheduledAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3CalAttendanceResp> _01attendanceSummaryCalculate(Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate, Expression<Func<string[]>> bodyemployeeIds = null, Expression<Func<string[]>> bodydepartmentIds = null, Expression<Func<string[]>> bodypositionIds = null)
        {
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: true);
            var __workflow_bodyemployeeIds = WorkflowExpression.Compile(bodyemployeeIds, nameof(bodyemployeeIds), required: false);
            var __workflow_bodydepartmentIds = WorkflowExpression.Compile(bodydepartmentIds, nameof(bodydepartmentIds), required: false);
            var __workflow_bodypositionIds = WorkflowExpression.Compile(bodypositionIds, nameof(bodypositionIds), required: false);
            return new DeferredBodyAction<ResultV3CalAttendanceResp>(() =>
            {
                var apiCallPath = "/v3/attendance/attendanceSummaryCalculate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                bodypropCount++;
                body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                if (__workflow_bodyemployeeIds != null)
                {
                    body["employeeIds"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeIds);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentIds != null)
                {
                    body["departmentIds"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentIds);
                    bodypropCount++;
                }

                if (__workflow_bodypositionIds != null)
                {
                    body["positionIds"] = ExpressionConverter.ConvertO(__workflow_bodypositionIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3CalAttendanceResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizAttendanceConfigureResp> _01getAttendanceConfigurationList()
        {
            var apiCallPath = "/v3/settings/getAttendanceConfigurationList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultV3BizAttendanceConfigureResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementTypeResp> _01getExpenseTypeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizReimbursementTypeResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayItemResp> _020getExternalPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ExternalPayItemResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _020updateCostCenterById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycostCenterCode = WorkflowExpression.Compile(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/updateCostCenterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterCode != null)
                {
                    body["costCenterCode"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3CostCenterResp> _021getCostCenterList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3CostCenterResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3ExternalPayItemResp> _021getExternalPayItemInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3ExternalPayItemResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getExternalPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3ExternalPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _022addTagInfo(Expression<Func<string>> bodylabelName, Expression<Func<string>> bodylabelCode = null, Expression<Func<int>> bodylabelStatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodylabelName = WorkflowExpression.Compile(bodylabelName, nameof(bodylabelName), required: true);
            var __workflow_bodylabelCode = WorkflowExpression.Compile(bodylabelCode, nameof(bodylabelCode), required: false);
            var __workflow_bodylabelStatus = WorkflowExpression.Compile(bodylabelStatus, nameof(bodylabelStatus), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/addTagInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylabelCode != null)
                {
                    body["labelCode"] = ExpressionConverter.ConvertO(__workflow_bodylabelCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["labelName"] = ExpressionConverter.ConvertO(__workflow_bodylabelName);
                if (__workflow_bodylabelStatus != null)
                {
                    body["labelStatus"] = ExpressionConverter.ConvertO(__workflow_bodylabelStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _022addWorkPatternInfo(Expression<Func<string>> bodyname, Expression<Func<double>> bodyworkHoursForDay, Expression<Func<double>> bodyworkHoursForWeek, Expression<Func<double>> bodyworkHoursForYear, Expression<Func<double>> bodytotalHours, Expression<Func<string>> bodycycleType, Expression<Func<string>> bodyadvancedSetting = null, Expression<Func<string>> bodynumber = null, Expression<Func<string>> bodyfte = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodysalaryCalculationStyle = null, Expression<Func<int>> bodyworkTime = null, Expression<Func<string>> bodydoubleWeekBaseDate = null, Expression<Func<string>> bodyweekSalaryType = null, Expression<Func<int>> bodyisThisWeek = null, Expression<Func<V3TermsSettingInsert[]>> bodysettingList = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyworkHoursForDay = WorkflowExpression.Compile(bodyworkHoursForDay, nameof(bodyworkHoursForDay), required: true);
            var __workflow_bodyworkHoursForWeek = WorkflowExpression.Compile(bodyworkHoursForWeek, nameof(bodyworkHoursForWeek), required: true);
            var __workflow_bodyworkHoursForYear = WorkflowExpression.Compile(bodyworkHoursForYear, nameof(bodyworkHoursForYear), required: true);
            var __workflow_bodytotalHours = WorkflowExpression.Compile(bodytotalHours, nameof(bodytotalHours), required: true);
            var __workflow_bodycycleType = WorkflowExpression.Compile(bodycycleType, nameof(bodycycleType), required: true);
            var __workflow_bodyadvancedSetting = WorkflowExpression.Compile(bodyadvancedSetting, nameof(bodyadvancedSetting), required: false);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: false);
            var __workflow_bodyfte = WorkflowExpression.Compile(bodyfte, nameof(bodyfte), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodysalaryCalculationStyle = WorkflowExpression.Compile(bodysalaryCalculationStyle, nameof(bodysalaryCalculationStyle), required: false);
            var __workflow_bodyworkTime = WorkflowExpression.Compile(bodyworkTime, nameof(bodyworkTime), required: false);
            var __workflow_bodydoubleWeekBaseDate = WorkflowExpression.Compile(bodydoubleWeekBaseDate, nameof(bodydoubleWeekBaseDate), required: false);
            var __workflow_bodyweekSalaryType = WorkflowExpression.Compile(bodyweekSalaryType, nameof(bodyweekSalaryType), required: false);
            var __workflow_bodyisThisWeek = WorkflowExpression.Compile(bodyisThisWeek, nameof(bodyisThisWeek), required: false);
            var __workflow_bodysettingList = WorkflowExpression.Compile(bodysettingList, nameof(bodysettingList), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/addWorkPatternInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyadvancedSetting != null)
                {
                    body["advancedSetting"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedSetting);
                    bodypropCount++;
                }

                if (__workflow_bodynumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["workHoursForDay"] = ExpressionConverter.ConvertO(__workflow_bodyworkHoursForDay);
                bodypropCount++;
                body["workHoursForWeek"] = ExpressionConverter.ConvertO(__workflow_bodyworkHoursForWeek);
                bodypropCount++;
                body["workHoursForYear"] = ExpressionConverter.ConvertO(__workflow_bodyworkHoursForYear);
                bodypropCount++;
                body["totalHours"] = ExpressionConverter.ConvertO(__workflow_bodytotalHours);
                bodypropCount++;
                body["cycleType"] = ExpressionConverter.ConvertO(__workflow_bodycycleType);
                if (__workflow_bodyfte != null)
                {
                    body["fte"] = ExpressionConverter.ConvertO(__workflow_bodyfte);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodysalaryCalculationStyle != null)
                {
                    body["salaryCalculationStyle"] = ExpressionConverter.ConvertO(__workflow_bodysalaryCalculationStyle);
                    bodypropCount++;
                }

                if (__workflow_bodyworkTime != null)
                {
                    body["workTime"] = ExpressionConverter.ConvertO(__workflow_bodyworkTime);
                    bodypropCount++;
                }

                if (__workflow_bodydoubleWeekBaseDate != null)
                {
                    body["doubleWeekBaseDate"] = ExpressionConverter.ConvertO(__workflow_bodydoubleWeekBaseDate);
                    bodypropCount++;
                }

                if (__workflow_bodyweekSalaryType != null)
                {
                    body["weekSalaryType"] = ExpressionConverter.ConvertO(__workflow_bodyweekSalaryType);
                    bodypropCount++;
                }

                if (__workflow_bodyisThisWeek != null)
                {
                    body["isThisWeek"] = ExpressionConverter.ConvertO(__workflow_bodyisThisWeek);
                    bodypropCount++;
                }

                if (__workflow_bodysettingList != null)
                {
                    body["settingList"] = ExpressionConverter.ConvertO(__workflow_bodysettingList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _023deleteTagById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteTagById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _023updateWorkPatternById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyadvancedSetting = null, Expression<Func<string>> bodynumber = null, Expression<Func<string>> bodyname = null, Expression<Func<double>> bodyworkHoursForDay = null, Expression<Func<double>> bodyworkHoursForWeek = null, Expression<Func<double>> bodyworkHoursForYear = null, Expression<Func<double>> bodytotalHours = null, Expression<Func<string>> bodycycleType = null, Expression<Func<string>> bodyfte = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodysalaryCalculationStyle = null, Expression<Func<int>> bodyworkTime = null, Expression<Func<string>> bodydoubleWeekBaseDate = null, Expression<Func<string>> bodyweekSalaryType = null, Expression<Func<int>> bodyisThisWeek = null, Expression<Func<string>> bodytermsWorkDefaultId = null, Expression<Func<V3TermsSettingUpdate[]>> bodysettingList = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyadvancedSetting = WorkflowExpression.Compile(bodyadvancedSetting, nameof(bodyadvancedSetting), required: false);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyworkHoursForDay = WorkflowExpression.Compile(bodyworkHoursForDay, nameof(bodyworkHoursForDay), required: false);
            var __workflow_bodyworkHoursForWeek = WorkflowExpression.Compile(bodyworkHoursForWeek, nameof(bodyworkHoursForWeek), required: false);
            var __workflow_bodyworkHoursForYear = WorkflowExpression.Compile(bodyworkHoursForYear, nameof(bodyworkHoursForYear), required: false);
            var __workflow_bodytotalHours = WorkflowExpression.Compile(bodytotalHours, nameof(bodytotalHours), required: false);
            var __workflow_bodycycleType = WorkflowExpression.Compile(bodycycleType, nameof(bodycycleType), required: false);
            var __workflow_bodyfte = WorkflowExpression.Compile(bodyfte, nameof(bodyfte), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodysalaryCalculationStyle = WorkflowExpression.Compile(bodysalaryCalculationStyle, nameof(bodysalaryCalculationStyle), required: false);
            var __workflow_bodyworkTime = WorkflowExpression.Compile(bodyworkTime, nameof(bodyworkTime), required: false);
            var __workflow_bodydoubleWeekBaseDate = WorkflowExpression.Compile(bodydoubleWeekBaseDate, nameof(bodydoubleWeekBaseDate), required: false);
            var __workflow_bodyweekSalaryType = WorkflowExpression.Compile(bodyweekSalaryType, nameof(bodyweekSalaryType), required: false);
            var __workflow_bodyisThisWeek = WorkflowExpression.Compile(bodyisThisWeek, nameof(bodyisThisWeek), required: false);
            var __workflow_bodytermsWorkDefaultId = WorkflowExpression.Compile(bodytermsWorkDefaultId, nameof(bodytermsWorkDefaultId), required: false);
            var __workflow_bodysettingList = WorkflowExpression.Compile(bodysettingList, nameof(bodysettingList), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/updateWorkPatternById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyadvancedSetting != null)
                {
                    body["advancedSetting"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedSetting);
                    bodypropCount++;
                }

                if (__workflow_bodynumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyworkHoursForDay != null)
                {
                    body["workHoursForDay"] = ExpressionConverter.ConvertO(__workflow_bodyworkHoursForDay);
                    bodypropCount++;
                }

                if (__workflow_bodyworkHoursForWeek != null)
                {
                    body["workHoursForWeek"] = ExpressionConverter.ConvertO(__workflow_bodyworkHoursForWeek);
                    bodypropCount++;
                }

                if (__workflow_bodyworkHoursForYear != null)
                {
                    body["workHoursForYear"] = ExpressionConverter.ConvertO(__workflow_bodyworkHoursForYear);
                    bodypropCount++;
                }

                if (__workflow_bodytotalHours != null)
                {
                    body["totalHours"] = ExpressionConverter.ConvertO(__workflow_bodytotalHours);
                    bodypropCount++;
                }

                if (__workflow_bodycycleType != null)
                {
                    body["cycleType"] = ExpressionConverter.ConvertO(__workflow_bodycycleType);
                    bodypropCount++;
                }

                if (__workflow_bodyfte != null)
                {
                    body["fte"] = ExpressionConverter.ConvertO(__workflow_bodyfte);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodysalaryCalculationStyle != null)
                {
                    body["salaryCalculationStyle"] = ExpressionConverter.ConvertO(__workflow_bodysalaryCalculationStyle);
                    bodypropCount++;
                }

                if (__workflow_bodyworkTime != null)
                {
                    body["workTime"] = ExpressionConverter.ConvertO(__workflow_bodyworkTime);
                    bodypropCount++;
                }

                if (__workflow_bodydoubleWeekBaseDate != null)
                {
                    body["doubleWeekBaseDate"] = ExpressionConverter.ConvertO(__workflow_bodydoubleWeekBaseDate);
                    bodypropCount++;
                }

                if (__workflow_bodyweekSalaryType != null)
                {
                    body["weekSalaryType"] = ExpressionConverter.ConvertO(__workflow_bodyweekSalaryType);
                    bodypropCount++;
                }

                if (__workflow_bodyisThisWeek != null)
                {
                    body["isThisWeek"] = ExpressionConverter.ConvertO(__workflow_bodyisThisWeek);
                    bodypropCount++;
                }

                if (__workflow_bodytermsWorkDefaultId != null)
                {
                    body["termsWorkDefaultId"] = ExpressionConverter.ConvertO(__workflow_bodytermsWorkDefaultId);
                    bodypropCount++;
                }

                if (__workflow_bodysettingList != null)
                {
                    body["settingList"] = ExpressionConverter.ConvertO(__workflow_bodysettingList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _024deleteWorkPatternById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteWorkPatternById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _024updateTagById(Expression<Func<string>> bodyid, Expression<Func<string>> bodylabelCode = null, Expression<Func<string>> bodylabelName = null, Expression<Func<int>> bodylabelStatus = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylabelCode = WorkflowExpression.Compile(bodylabelCode, nameof(bodylabelCode), required: false);
            var __workflow_bodylabelName = WorkflowExpression.Compile(bodylabelName, nameof(bodylabelName), required: false);
            var __workflow_bodylabelStatus = WorkflowExpression.Compile(bodylabelStatus, nameof(bodylabelStatus), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/updateTagById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodylabelCode != null)
                {
                    body["labelCode"] = ExpressionConverter.ConvertO(__workflow_bodylabelCode);
                    bodypropCount++;
                }

                if (__workflow_bodylabelName != null)
                {
                    body["labelName"] = ExpressionConverter.ConvertO(__workflow_bodylabelName);
                    bodypropCount++;
                }

                if (__workflow_bodylabelStatus != null)
                {
                    body["labelStatus"] = ExpressionConverter.ConvertO(__workflow_bodylabelStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LabelResp> _025getTagList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LabelResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3WorkPatternSummaryResp> _025getWorkPatternList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3WorkPatternSummaryResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3DeviceResp> _026getDeviceList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3DeviceResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3WorkPatternResp> _026getWorkPatternInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3WorkPatternResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getWorkPatternInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3WorkPatternResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizReimbursementInsertResp> _02addExpenseApplicationInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyreimbursementType, Expression<Func<string>> bodyreimbursementDate, Expression<Func<string>> bodyreimbursementName, Expression<Func<double>> bodyamount, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyreimbursementType = WorkflowExpression.Compile(bodyreimbursementType, nameof(bodyreimbursementType), required: true);
            var __workflow_bodyreimbursementDate = WorkflowExpression.Compile(bodyreimbursementDate, nameof(bodyreimbursementDate), required: true);
            var __workflow_bodyreimbursementName = WorkflowExpression.Compile(bodyreimbursementName, nameof(bodyreimbursementName), required: true);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: true);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3BizReimbursementInsertResp>(() =>
            {
                var apiCallPath = "/v3/expense/addExpenseApplicationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["reimbursementType"] = ExpressionConverter.ConvertO(__workflow_bodyreimbursementType);
                bodypropCount++;
                body["reimbursementDate"] = ExpressionConverter.ConvertO(__workflow_bodyreimbursementDate);
                bodypropCount++;
                body["reimbursementName"] = ExpressionConverter.ConvertO(__workflow_bodyreimbursementName);
                bodypropCount++;
                body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3BizReimbursementInsertResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _02batchSaveRosterInfo(Expression<Func<string[]>> bodyemployeeIds, Expression<Func<string[]>> bodydates, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodyshiftTemplateId = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<double>> bodyhourlyRate = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<bool>> bodyreplaceOriginal = null)
        {
            var __workflow_bodyemployeeIds = WorkflowExpression.Compile(bodyemployeeIds, nameof(bodyemployeeIds), required: true);
            var __workflow_bodydates = WorkflowExpression.Compile(bodydates, nameof(bodydates), required: true);
            var __workflow_bodyshiftIn = WorkflowExpression.Compile(bodyshiftIn, nameof(bodyshiftIn), required: true);
            var __workflow_bodyshiftOff = WorkflowExpression.Compile(bodyshiftOff, nameof(bodyshiftOff), required: true);
            var __workflow_bodyshiftTemplateId = WorkflowExpression.Compile(bodyshiftTemplateId, nameof(bodyshiftTemplateId), required: false);
            var __workflow_bodyaddressCardId = WorkflowExpression.Compile(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyshiftStatus = WorkflowExpression.Compile(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            var __workflow_bodydateType = WorkflowExpression.Compile(bodydateType, nameof(bodydateType), required: false);
            var __workflow_bodyattendanceItemId = WorkflowExpression.Compile(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            var __workflow_bodyhourlyRate = WorkflowExpression.Compile(bodyhourlyRate, nameof(bodyhourlyRate), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyreplaceOriginal = WorkflowExpression.Compile(bodyreplaceOriginal, nameof(bodyreplaceOriginal), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/batchSaveRosterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeIds"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeIds);
                bodypropCount++;
                body["dates"] = ExpressionConverter.ConvertO(__workflow_bodydates);
                if (__workflow_bodyshiftTemplateId != null)
                {
                    body["shiftTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyshiftTemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCardId != null)
                {
                    body["addressCardId"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftIn"] = ExpressionConverter.ConvertO(__workflow_bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = ExpressionConverter.ConvertO(__workflow_bodyshiftOff);
                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftStatus != null)
                {
                    body["shiftStatus"] = ExpressionConverter.ConvertO(__workflow_bodyshiftStatus);
                    bodypropCount++;
                }

                if (__workflow_bodydateType != null)
                {
                    body["dateType"] = ExpressionConverter.ConvertO(__workflow_bodydateType);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodyhourlyRate != null)
                {
                    body["hourlyRate"] = ExpressionConverter.ConvertO(__workflow_bodyhourlyRate);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyreplaceOriginal != null)
                {
                    body["replaceOriginal"] = ExpressionConverter.ConvertO(__workflow_bodyreplaceOriginal);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _02deleteEmployeeById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/employee/deleteAllData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _02deleteLeaveBalanceAdjustmentById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/leave/deleteLeaveBalanceAdjustmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceListResp> _02getAttendanceSummaryList(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> unit, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> attendCalculationFilter = null, Expression<Func<string>> employeeFilter = null, Expression<Func<string>> labelFilter = null, Expression<Func<string>> payrollRegulationFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> attendanceTypeFilter = null, Expression<Func<string>> shiftTypeFilter = null)
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
            return new DeferredBodyAction<ResultIPageV3AttendanceListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryResp> _02getDataDictionaryList()
        {
            var apiCallPath = "/v3/settings/getDataDictionaryList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _03deleteExpenseApplicationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/expense/deleteExpenseApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _03deleteRosterById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteRosterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryItemResp> _03GetDataDictionaryDetailsInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultListV3BizCustomizeDictionaryItemResp>(() =>
            {
                var apiCallPath = "/v3/settings/getDataDictionaryDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3AttendanceDetailListResp> _03getEmployeeDailyAttendanceList(Expression<Func<string>> employeeId, Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> attendStatusFilter = null)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_attendStatusFilter = WorkflowExpression.Compile(attendStatusFilter, nameof(attendStatusFilter), required: false);
            return new DeferredBodyAction<ResultListV3AttendanceDetailListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayBalanceResp> _03getLeaveBalanceAdjustmentList(Expression<Func<string>> employeeId, Expression<Func<string>> holidayType, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_holidayType = WorkflowExpression.Compile(holidayType, nameof(holidayType), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveHolidayBalanceResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _03updateEmployeeById(Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodyenglishName, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyemployeeStatus = null, Expression<Func<string>> bodysex = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyidentityCard = null, Expression<Func<string>> bodychineseName = null, Expression<Func<string>> bodysurnameEnglish = null, Expression<Func<string>> bodypersonalNameEnglish = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<string>> bodyemergencyContactRelation = null, Expression<Func<string>> bodyemergencyContactPhone = null, Expression<Func<string>> bodybankCode = null, Expression<Func<string>> bodybankBranchNumber = null, Expression<Func<string>> bodybankAccountNo = null, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodydate1 = null, Expression<Func<string>> bodydate2 = null, Expression<Func<string>> bodydate3 = null, Expression<Func<string>> bodydate4 = null, Expression<Func<string>> bodytext1 = null, Expression<Func<string>> bodytext2 = null, Expression<Func<string>> bodytext3 = null, Expression<Func<string>> bodytext4 = null, Expression<Func<string>> bodytext5 = null, Expression<Func<string>> bodytext6 = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodymobileCardCalType = null, Expression<Func<string>> bodyregularType = null, Expression<Func<string>> bodyinsurePlanName = null, Expression<Func<string>> bodybizLabelIds = null)
        {
            var __workflow_bodyentryDate = WorkflowExpression.Compile(bodyentryDate, nameof(bodyentryDate), required: true);
            var __workflow_bodyenglishName = WorkflowExpression.Compile(bodyenglishName, nameof(bodyenglishName), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyemployeeStatus = WorkflowExpression.Compile(bodyemployeeStatus, nameof(bodyemployeeStatus), required: false);
            var __workflow_bodysex = WorkflowExpression.Compile(bodysex, nameof(bodysex), required: false);
            var __workflow_bodynationality = WorkflowExpression.Compile(bodynationality, nameof(bodynationality), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodycountryCode = WorkflowExpression.Compile(bodycountryCode, nameof(bodycountryCode), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodycalculateSalaryType = WorkflowExpression.Compile(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            var __workflow_bodyworkDate = WorkflowExpression.Compile(bodyworkDate, nameof(bodyworkDate), required: false);
            var __workflow_bodybasicPay = WorkflowExpression.Compile(bodybasicPay, nameof(bodybasicPay), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyidentityCard = WorkflowExpression.Compile(bodyidentityCard, nameof(bodyidentityCard), required: false);
            var __workflow_bodychineseName = WorkflowExpression.Compile(bodychineseName, nameof(bodychineseName), required: false);
            var __workflow_bodysurnameEnglish = WorkflowExpression.Compile(bodysurnameEnglish, nameof(bodysurnameEnglish), required: false);
            var __workflow_bodypersonalNameEnglish = WorkflowExpression.Compile(bodypersonalNameEnglish, nameof(bodypersonalNameEnglish), required: false);
            var __workflow_bodybirthday = WorkflowExpression.Compile(bodybirthday, nameof(bodybirthday), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodyemergencyContactName = WorkflowExpression.Compile(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            var __workflow_bodyemergencyContactRelation = WorkflowExpression.Compile(bodyemergencyContactRelation, nameof(bodyemergencyContactRelation), required: false);
            var __workflow_bodyemergencyContactPhone = WorkflowExpression.Compile(bodyemergencyContactPhone, nameof(bodyemergencyContactPhone), required: false);
            var __workflow_bodybankCode = WorkflowExpression.Compile(bodybankCode, nameof(bodybankCode), required: false);
            var __workflow_bodybankBranchNumber = WorkflowExpression.Compile(bodybankBranchNumber, nameof(bodybankBranchNumber), required: false);
            var __workflow_bodybankAccountNo = WorkflowExpression.Compile(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            var __workflow_bodyconfirmationDate = WorkflowExpression.Compile(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            var __workflow_bodydate1 = WorkflowExpression.Compile(bodydate1, nameof(bodydate1), required: false);
            var __workflow_bodydate2 = WorkflowExpression.Compile(bodydate2, nameof(bodydate2), required: false);
            var __workflow_bodydate3 = WorkflowExpression.Compile(bodydate3, nameof(bodydate3), required: false);
            var __workflow_bodydate4 = WorkflowExpression.Compile(bodydate4, nameof(bodydate4), required: false);
            var __workflow_bodytext1 = WorkflowExpression.Compile(bodytext1, nameof(bodytext1), required: false);
            var __workflow_bodytext2 = WorkflowExpression.Compile(bodytext2, nameof(bodytext2), required: false);
            var __workflow_bodytext3 = WorkflowExpression.Compile(bodytext3, nameof(bodytext3), required: false);
            var __workflow_bodytext4 = WorkflowExpression.Compile(bodytext4, nameof(bodytext4), required: false);
            var __workflow_bodytext5 = WorkflowExpression.Compile(bodytext5, nameof(bodytext5), required: false);
            var __workflow_bodytext6 = WorkflowExpression.Compile(bodytext6, nameof(bodytext6), required: false);
            var __workflow_bodydirectSupervisorId = WorkflowExpression.Compile(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodypositionId = WorkflowExpression.Compile(bodypositionId, nameof(bodypositionId), required: false);
            var __workflow_bodyhireType = WorkflowExpression.Compile(bodyhireType, nameof(bodyhireType), required: false);
            var __workflow_bodypayrollRegulationId = WorkflowExpression.Compile(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyattendCalculationId = WorkflowExpression.Compile(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            var __workflow_bodymobileCardCalType = WorkflowExpression.Compile(bodymobileCardCalType, nameof(bodymobileCardCalType), required: false);
            var __workflow_bodyregularType = WorkflowExpression.Compile(bodyregularType, nameof(bodyregularType), required: false);
            var __workflow_bodyinsurePlanName = WorkflowExpression.Compile(bodyinsurePlanName, nameof(bodyinsurePlanName), required: false);
            var __workflow_bodybizLabelIds = WorkflowExpression.Compile(bodybizLabelIds, nameof(bodybizLabelIds), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/employee/updateEmployeeById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entryDate"] = ExpressionConverter.ConvertO(__workflow_bodyentryDate);
                bodypropCount++;
                body["englishName"] = ExpressionConverter.ConvertO(__workflow_bodyenglishName);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyemployeeStatus != null)
                {
                    body["employeeStatus"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeStatus);
                    bodypropCount++;
                }

                if (__workflow_bodysex != null)
                {
                    body["sex"] = ExpressionConverter.ConvertO(__workflow_bodysex);
                    bodypropCount++;
                }

                if (__workflow_bodynationality != null)
                {
                    body["nationality"] = ExpressionConverter.ConvertO(__workflow_bodynationality);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["maritalStatus"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodycountryCode != null)
                {
                    body["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodycountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = ExpressionConverter.ConvertO(__workflow_bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (__workflow_bodyworkDate != null)
                {
                    body["workDate"] = ExpressionConverter.ConvertO(__workflow_bodyworkDate);
                    bodypropCount++;
                }

                if (__workflow_bodybasicPay != null)
                {
                    body["basicPay"] = ExpressionConverter.ConvertO(__workflow_bodybasicPay);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyidentityCard != null)
                {
                    body["identityCard"] = ExpressionConverter.ConvertO(__workflow_bodyidentityCard);
                    bodypropCount++;
                }

                if (__workflow_bodychineseName != null)
                {
                    body["chineseName"] = ExpressionConverter.ConvertO(__workflow_bodychineseName);
                    bodypropCount++;
                }

                if (__workflow_bodysurnameEnglish != null)
                {
                    body["surnameEnglish"] = ExpressionConverter.ConvertO(__workflow_bodysurnameEnglish);
                    bodypropCount++;
                }

                if (__workflow_bodypersonalNameEnglish != null)
                {
                    body["personalNameEnglish"] = ExpressionConverter.ConvertO(__workflow_bodypersonalNameEnglish);
                    bodypropCount++;
                }

                if (__workflow_bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(__workflow_bodybirthday);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactName);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactRelation != null)
                {
                    body["emergencyContactRelation"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactRelation);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactPhone != null)
                {
                    body["emergencyContactPhone"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactPhone);
                    bodypropCount++;
                }

                if (__workflow_bodybankCode != null)
                {
                    body["bankCode"] = ExpressionConverter.ConvertO(__workflow_bodybankCode);
                    bodypropCount++;
                }

                if (__workflow_bodybankBranchNumber != null)
                {
                    body["bankBranchNumber"] = ExpressionConverter.ConvertO(__workflow_bodybankBranchNumber);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountNo);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationDate);
                    bodypropCount++;
                }

                if (__workflow_bodydate1 != null)
                {
                    body["date1"] = ExpressionConverter.ConvertO(__workflow_bodydate1);
                    bodypropCount++;
                }

                if (__workflow_bodydate2 != null)
                {
                    body["date2"] = ExpressionConverter.ConvertO(__workflow_bodydate2);
                    bodypropCount++;
                }

                if (__workflow_bodydate3 != null)
                {
                    body["date3"] = ExpressionConverter.ConvertO(__workflow_bodydate3);
                    bodypropCount++;
                }

                if (__workflow_bodydate4 != null)
                {
                    body["date4"] = ExpressionConverter.ConvertO(__workflow_bodydate4);
                    bodypropCount++;
                }

                if (__workflow_bodytext1 != null)
                {
                    body["text1"] = ExpressionConverter.ConvertO(__workflow_bodytext1);
                    bodypropCount++;
                }

                if (__workflow_bodytext2 != null)
                {
                    body["text2"] = ExpressionConverter.ConvertO(__workflow_bodytext2);
                    bodypropCount++;
                }

                if (__workflow_bodytext3 != null)
                {
                    body["text3"] = ExpressionConverter.ConvertO(__workflow_bodytext3);
                    bodypropCount++;
                }

                if (__workflow_bodytext4 != null)
                {
                    body["text4"] = ExpressionConverter.ConvertO(__workflow_bodytext4);
                    bodypropCount++;
                }

                if (__workflow_bodytext5 != null)
                {
                    body["text5"] = ExpressionConverter.ConvertO(__workflow_bodytext5);
                    bodypropCount++;
                }

                if (__workflow_bodytext6 != null)
                {
                    body["text6"] = ExpressionConverter.ConvertO(__workflow_bodytext6);
                    bodypropCount++;
                }

                if (__workflow_bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = ExpressionConverter.ConvertO(__workflow_bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodypositionId != null)
                {
                    body["positionId"] = ExpressionConverter.ConvertO(__workflow_bodypositionId);
                    bodypropCount++;
                }

                if (__workflow_bodyhireType != null)
                {
                    body["hireType"] = ExpressionConverter.ConvertO(__workflow_bodyhireType);
                    bodypropCount++;
                }

                if (__workflow_bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = ExpressionConverter.ConvertO(__workflow_bodyattendCalculationId);
                    bodypropCount++;
                }

                if (__workflow_bodymobileCardCalType != null)
                {
                    body["mobileCardCalType"] = ExpressionConverter.ConvertO(__workflow_bodymobileCardCalType);
                    bodypropCount++;
                }

                if (__workflow_bodyregularType != null)
                {
                    body["regularType"] = ExpressionConverter.ConvertO(__workflow_bodyregularType);
                    bodypropCount++;
                }

                if (__workflow_bodyinsurePlanName != null)
                {
                    body["insurePlanName"] = ExpressionConverter.ConvertO(__workflow_bodyinsurePlanName);
                    bodypropCount++;
                }

                if (__workflow_bodybizLabelIds != null)
                {
                    body["bizLabelIds"] = ExpressionConverter.ConvertO(__workflow_bodybizLabelIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddMobileCardResp> _04addAttendanceDataInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodydate, Expression<Func<string>> bodymode, Expression<Func<string>> bodycardType = null, Expression<Func<double>> bodyactualLongitude = null, Expression<Func<double>> bodyactualLatitude = null, Expression<Func<string>> bodydeviceName = null, Expression<Func<string>> bodycodeSource = null, Expression<Func<string>> bodylocationName = null, Expression<Func<string>> bodyworkLocationId = null, Expression<Func<string>> bodydeviceId = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: true);
            var __workflow_bodycardType = WorkflowExpression.Compile(bodycardType, nameof(bodycardType), required: false);
            var __workflow_bodyactualLongitude = WorkflowExpression.Compile(bodyactualLongitude, nameof(bodyactualLongitude), required: false);
            var __workflow_bodyactualLatitude = WorkflowExpression.Compile(bodyactualLatitude, nameof(bodyactualLatitude), required: false);
            var __workflow_bodydeviceName = WorkflowExpression.Compile(bodydeviceName, nameof(bodydeviceName), required: false);
            var __workflow_bodycodeSource = WorkflowExpression.Compile(bodycodeSource, nameof(bodycodeSource), required: false);
            var __workflow_bodylocationName = WorkflowExpression.Compile(bodylocationName, nameof(bodylocationName), required: false);
            var __workflow_bodyworkLocationId = WorkflowExpression.Compile(bodyworkLocationId, nameof(bodyworkLocationId), required: false);
            var __workflow_bodydeviceId = WorkflowExpression.Compile(bodydeviceId, nameof(bodydeviceId), required: false);
            return new DeferredBodyAction<ResultV3AddMobileCardResp>(() =>
            {
                var apiCallPath = "/v3/attendance/addAttendanceDataInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                if (__workflow_bodycardType != null)
                {
                    body["cardType"] = ExpressionConverter.ConvertO(__workflow_bodycardType);
                    bodypropCount++;
                }

                if (__workflow_bodyactualLongitude != null)
                {
                    body["actualLongitude"] = ExpressionConverter.ConvertO(__workflow_bodyactualLongitude);
                    bodypropCount++;
                }

                if (__workflow_bodyactualLatitude != null)
                {
                    body["actualLatitude"] = ExpressionConverter.ConvertO(__workflow_bodyactualLatitude);
                    bodypropCount++;
                }

                if (__workflow_bodydeviceName != null)
                {
                    body["deviceName"] = ExpressionConverter.ConvertO(__workflow_bodydeviceName);
                    bodypropCount++;
                }

                if (__workflow_bodycodeSource != null)
                {
                    body["codeSource"] = ExpressionConverter.ConvertO(__workflow_bodycodeSource);
                    bodypropCount++;
                }

                if (__workflow_bodylocationName != null)
                {
                    body["locationName"] = ExpressionConverter.ConvertO(__workflow_bodylocationName);
                    bodypropCount++;
                }

                if (__workflow_bodyworkLocationId != null)
                {
                    body["workLocationId"] = ExpressionConverter.ConvertO(__workflow_bodyworkLocationId);
                    bodypropCount++;
                }

                if (__workflow_bodydeviceId != null)
                {
                    body["deviceId"] = ExpressionConverter.ConvertO(__workflow_bodydeviceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3AddMobileCardResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _04calculationLeaveBalance(Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodyisForceCal = null, Expression<Func<string[]>> bodyemployeeIdsList = null, Expression<Func<string[]>> bodyposition = null, Expression<Func<string[]>> bodydept = null)
        {
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyisForceCal = WorkflowExpression.Compile(bodyisForceCal, nameof(bodyisForceCal), required: false);
            var __workflow_bodyemployeeIdsList = WorkflowExpression.Compile(bodyemployeeIdsList, nameof(bodyemployeeIdsList), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodydept = WorkflowExpression.Compile(bodydept, nameof(bodydept), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/leave/calculationLeaveBalance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyisForceCal != null)
                {
                    body["isForceCal"] = ExpressionConverter.ConvertO(__workflow_bodyisForceCal);
                    bodypropCount++;
                }

                if (__workflow_bodyemployeeIdsList != null)
                {
                    body["employeeIdsList"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeIdsList);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodydept != null)
                {
                    body["dept"] = ExpressionConverter.ConvertO(__workflow_bodydept);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3BizEmployeeCustomizationResp> _04getCustomizeUserFieldList(Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizEmployeeCustomizationResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeListResp> _04getEmployeeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> id = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> sex = null, Expression<Func<int>> status = null, Expression<Func<string>> hireType = null, Expression<Func<string>> calculateSalaryType = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> payrollRegulationId = null, Expression<Func<string>> regularType = null)
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
            return new DeferredBodyAction<ResultIPageV3EmployeeListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _04updateExpenseApplicationById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyreimbursementType = null, Expression<Func<string>> bodyreimbursementDate = null, Expression<Func<string>> bodyreimbursementName = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyreimbursementType = WorkflowExpression.Compile(bodyreimbursementType, nameof(bodyreimbursementType), required: false);
            var __workflow_bodyreimbursementDate = WorkflowExpression.Compile(bodyreimbursementDate, nameof(bodyreimbursementDate), required: false);
            var __workflow_bodyreimbursementName = WorkflowExpression.Compile(bodyreimbursementName, nameof(bodyreimbursementName), required: false);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/expense/updateExpenseApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyreimbursementType != null)
                {
                    body["reimbursementType"] = ExpressionConverter.ConvertO(__workflow_bodyreimbursementType);
                    bodypropCount++;
                }

                if (__workflow_bodyreimbursementDate != null)
                {
                    body["reimbursementDate"] = ExpressionConverter.ConvertO(__workflow_bodyreimbursementDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreimbursementName != null)
                {
                    body["reimbursementName"] = ExpressionConverter.ConvertO(__workflow_bodyreimbursementName);
                    bodypropCount++;
                }

                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _04updateRosterInfoById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodyshiftTemplateId = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<double>> bodyhourlyRate = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<double>> bodytierRate = null, Expression<Func<double>> bodyscheduledAmount = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyshiftIn = WorkflowExpression.Compile(bodyshiftIn, nameof(bodyshiftIn), required: true);
            var __workflow_bodyshiftOff = WorkflowExpression.Compile(bodyshiftOff, nameof(bodyshiftOff), required: true);
            var __workflow_bodyshiftTemplateId = WorkflowExpression.Compile(bodyshiftTemplateId, nameof(bodyshiftTemplateId), required: false);
            var __workflow_bodyaddressCardId = WorkflowExpression.Compile(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyshiftStatus = WorkflowExpression.Compile(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            var __workflow_bodydateType = WorkflowExpression.Compile(bodydateType, nameof(bodydateType), required: false);
            var __workflow_bodyattendanceItemId = WorkflowExpression.Compile(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            var __workflow_bodyhourlyRate = WorkflowExpression.Compile(bodyhourlyRate, nameof(bodyhourlyRate), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodytierRate = WorkflowExpression.Compile(bodytierRate, nameof(bodytierRate), required: false);
            var __workflow_bodyscheduledAmount = WorkflowExpression.Compile(bodyscheduledAmount, nameof(bodyscheduledAmount), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateRosterInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyshiftTemplateId != null)
                {
                    body["shiftTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyshiftTemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCardId != null)
                {
                    body["addressCardId"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftIn"] = ExpressionConverter.ConvertO(__workflow_bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = ExpressionConverter.ConvertO(__workflow_bodyshiftOff);
                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftStatus != null)
                {
                    body["shiftStatus"] = ExpressionConverter.ConvertO(__workflow_bodyshiftStatus);
                    bodypropCount++;
                }

                if (__workflow_bodydateType != null)
                {
                    body["dateType"] = ExpressionConverter.ConvertO(__workflow_bodydateType);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodyhourlyRate != null)
                {
                    body["hourlyRate"] = ExpressionConverter.ConvertO(__workflow_bodyhourlyRate);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodytierRate != null)
                {
                    body["tierRate"] = ExpressionConverter.ConvertO(__workflow_bodytierRate);
                    bodypropCount++;
                }

                if (__workflow_bodyscheduledAmount != null)
                {
                    body["scheduledAmount"] = ExpressionConverter.ConvertO(__workflow_bodyscheduledAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _05deleteAttendanceDataById(Expression<Func<string>> ids)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteAttendanceDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizEmployeeCustomizationResp> _05getCustomizeUserFieldInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3BizEmployeeCustomizationResp>(() =>
            {
                var apiCallPath = "/v3/settings/getCustomizeUserFieldInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3BizEmployeeCustomizationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3EmployeeInfoResp> _05getEmployeeInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3EmployeeInfoResp>(() =>
            {
                var apiCallPath = "/v3/employee/getEmployeeInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3EmployeeInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementResp> _05GetExpenseApplicationList(Expression<Func<string>> q = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> dateFilter = null, Expression<Func<string>> reimbursementStatusFilter = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_statusFilter = WorkflowExpression.Compile(statusFilter, nameof(statusFilter), required: false);
            var __workflow_dateFilter = WorkflowExpression.Compile(dateFilter, nameof(dateFilter), required: false);
            var __workflow_reimbursementStatusFilter = WorkflowExpression.Compile(reimbursementStatusFilter, nameof(reimbursementStatusFilter), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizReimbursementResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveBalanceResp> _05getLeaveBalanceList(Expression<Func<string>> holidayType, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> regularTypeFilter = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> sexFilter = null, Expression<Func<string>> leaveHolidayBalanceStatusFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> bizLabelIds = null)
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
            return new DeferredBodyAction<ResultIPageV3LeaveBalanceResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3RosterListResp> _05getRosterList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendDay = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> attendStatus = null, Expression<Func<string>> dateType = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_attendDay = WorkflowExpression.Compile(attendDay, nameof(attendDay), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_attendStatus = WorkflowExpression.Compile(attendStatus, nameof(attendStatus), required: false);
            var __workflow_dateType = WorkflowExpression.Compile(dateType, nameof(dateType), required: false);
            return new DeferredBodyAction<ResultIPageV3RosterListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveWorkFlowDefinitionResp> _06getApproveProcessList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveWorkFlowDefinitionResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3BizReimbursementDetailResp> _06GetExpenseApplicationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3BizReimbursementDetailResp>(() =>
            {
                var apiCallPath = "/v3/expense/getExpenseApplicationById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3BizReimbursementDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeaveBalanceDetailResp> _06GetLeaveBalanceInfoById(Expression<Func<string>> employeeId, Expression<Func<string>> holidayType)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_holidayType = WorkflowExpression.Compile(holidayType, nameof(holidayType), required: true);
            return new DeferredBodyAction<ResultV3LeaveBalanceDetailResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(__workflow_employeeId);
                callPayload.Queries["holidayType"] = ExpressionConverter.Convert(__workflow_holidayType);
                return new ApiConnectionAction<ResultV3LeaveBalanceDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3RosterInfoResp> _06getRosterInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3RosterInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getRosterInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3RosterInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _06resign(Expression<Func<string>> bodyid, Expression<Func<string>> bodylastWorkingDate, Expression<Func<string>> bodyreasonsLeave, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylastWorkingDate = WorkflowExpression.Compile(bodylastWorkingDate, nameof(bodylastWorkingDate), required: true);
            var __workflow_bodyreasonsLeave = WorkflowExpression.Compile(bodyreasonsLeave, nameof(bodyreasonsLeave), required: true);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/employee/resign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["lastWorkingDate"] = ExpressionConverter.ConvertO(__workflow_bodylastWorkingDate);
                bodypropCount++;
                body["reasonsLeave"] = ExpressionConverter.ConvertO(__workflow_bodyreasonsLeave);
                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _06updateAttendanceDataById(Expression<Func<string>> bodyid, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodymode = null, Expression<Func<string>> bodycardType = null, Expression<Func<double>> bodyactualLongitude = null, Expression<Func<double>> bodyactualLatitude = null, Expression<Func<string>> bodydeviceName = null, Expression<Func<string>> bodycodeSource = null, Expression<Func<string>> bodylocationName = null, Expression<Func<string>> bodyworkLocationId = null, Expression<Func<string>> bodydeviceId = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: false);
            var __workflow_bodycardType = WorkflowExpression.Compile(bodycardType, nameof(bodycardType), required: false);
            var __workflow_bodyactualLongitude = WorkflowExpression.Compile(bodyactualLongitude, nameof(bodyactualLongitude), required: false);
            var __workflow_bodyactualLatitude = WorkflowExpression.Compile(bodyactualLatitude, nameof(bodyactualLatitude), required: false);
            var __workflow_bodydeviceName = WorkflowExpression.Compile(bodydeviceName, nameof(bodydeviceName), required: false);
            var __workflow_bodycodeSource = WorkflowExpression.Compile(bodycodeSource, nameof(bodycodeSource), required: false);
            var __workflow_bodylocationName = WorkflowExpression.Compile(bodylocationName, nameof(bodylocationName), required: false);
            var __workflow_bodyworkLocationId = WorkflowExpression.Compile(bodyworkLocationId, nameof(bodyworkLocationId), required: false);
            var __workflow_bodydeviceId = WorkflowExpression.Compile(bodydeviceId, nameof(bodydeviceId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/updateAttendanceDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodymode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                    bodypropCount++;
                }

                if (__workflow_bodycardType != null)
                {
                    body["cardType"] = ExpressionConverter.ConvertO(__workflow_bodycardType);
                    bodypropCount++;
                }

                if (__workflow_bodyactualLongitude != null)
                {
                    body["actualLongitude"] = ExpressionConverter.ConvertO(__workflow_bodyactualLongitude);
                    bodypropCount++;
                }

                if (__workflow_bodyactualLatitude != null)
                {
                    body["actualLatitude"] = ExpressionConverter.ConvertO(__workflow_bodyactualLatitude);
                    bodypropCount++;
                }

                if (__workflow_bodydeviceName != null)
                {
                    body["deviceName"] = ExpressionConverter.ConvertO(__workflow_bodydeviceName);
                    bodypropCount++;
                }

                if (__workflow_bodycodeSource != null)
                {
                    body["codeSource"] = ExpressionConverter.ConvertO(__workflow_bodycodeSource);
                    bodypropCount++;
                }

                if (__workflow_bodylocationName != null)
                {
                    body["locationName"] = ExpressionConverter.ConvertO(__workflow_bodylocationName);
                    bodypropCount++;
                }

                if (__workflow_bodyworkLocationId != null)
                {
                    body["workLocationId"] = ExpressionConverter.ConvertO(__workflow_bodyworkLocationId);
                    bodypropCount++;
                }

                if (__workflow_bodydeviceId != null)
                {
                    body["deviceId"] = ExpressionConverter.ConvertO(__workflow_bodydeviceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddEmployeeHistoryResp> _07addEmployeeHistory(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodytakeEffectType, Expression<Func<string>> bodytakeEffectDate, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<string>> bodycause = null, Expression<Func<string>> bodymajorWorkLocationId = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyentryDate = WorkflowExpression.Compile(bodyentryDate, nameof(bodyentryDate), required: true);
            var __workflow_bodytakeEffectType = WorkflowExpression.Compile(bodytakeEffectType, nameof(bodytakeEffectType), required: true);
            var __workflow_bodytakeEffectDate = WorkflowExpression.Compile(bodytakeEffectDate, nameof(bodytakeEffectDate), required: true);
            var __workflow_bodyconfirmationDate = WorkflowExpression.Compile(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            var __workflow_bodyhireType = WorkflowExpression.Compile(bodyhireType, nameof(bodyhireType), required: false);
            var __workflow_bodypositionId = WorkflowExpression.Compile(bodypositionId, nameof(bodypositionId), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodydirectSupervisorId = WorkflowExpression.Compile(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            var __workflow_bodyattendCalculationId = WorkflowExpression.Compile(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            var __workflow_bodypayrollRegulationId = WorkflowExpression.Compile(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            var __workflow_bodybasicPay = WorkflowExpression.Compile(bodybasicPay, nameof(bodybasicPay), required: false);
            var __workflow_bodycalculateSalaryType = WorkflowExpression.Compile(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyworkDate = WorkflowExpression.Compile(bodyworkDate, nameof(bodyworkDate), required: false);
            var __workflow_bodycause = WorkflowExpression.Compile(bodycause, nameof(bodycause), required: false);
            var __workflow_bodymajorWorkLocationId = WorkflowExpression.Compile(bodymajorWorkLocationId, nameof(bodymajorWorkLocationId), required: false);
            return new DeferredBodyAction<ResultV3AddEmployeeHistoryResp>(() =>
            {
                var apiCallPath = "/v3/employee/addEmployeeHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["entryDate"] = ExpressionConverter.ConvertO(__workflow_bodyentryDate);
                if (__workflow_bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyhireType != null)
                {
                    body["hireType"] = ExpressionConverter.ConvertO(__workflow_bodyhireType);
                    bodypropCount++;
                }

                if (__workflow_bodypositionId != null)
                {
                    body["positionId"] = ExpressionConverter.ConvertO(__workflow_bodypositionId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = ExpressionConverter.ConvertO(__workflow_bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (__workflow_bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = ExpressionConverter.ConvertO(__workflow_bodyattendCalculationId);
                    bodypropCount++;
                }

                if (__workflow_bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (__workflow_bodybasicPay != null)
                {
                    body["basicPay"] = ExpressionConverter.ConvertO(__workflow_bodybasicPay);
                    bodypropCount++;
                }

                if (__workflow_bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = ExpressionConverter.ConvertO(__workflow_bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyworkDate != null)
                {
                    body["workDate"] = ExpressionConverter.ConvertO(__workflow_bodyworkDate);
                    bodypropCount++;
                }

                if (__workflow_bodycause != null)
                {
                    body["cause"] = ExpressionConverter.ConvertO(__workflow_bodycause);
                    bodypropCount++;
                }

                if (__workflow_bodymajorWorkLocationId != null)
                {
                    body["majorWorkLocationId"] = ExpressionConverter.ConvertO(__workflow_bodymajorWorkLocationId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["takeEffectType"] = ExpressionConverter.ConvertO(__workflow_bodytakeEffectType);
                bodypropCount++;
                body["takeEffectDate"] = ExpressionConverter.ConvertO(__workflow_bodytakeEffectDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3AddEmployeeHistoryResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayInsertResp> _07addLeaveApplicationInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyholidayType, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<double>> bodyleaveTime = null, Expression<Func<string>> bodytimeType = null, Expression<Func<string>> bodyholidayDate = null, Expression<Func<string>> bodytime = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyholidayType = WorkflowExpression.Compile(bodyholidayType, nameof(bodyholidayType), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodyleaveTime = WorkflowExpression.Compile(bodyleaveTime, nameof(bodyleaveTime), required: false);
            var __workflow_bodytimeType = WorkflowExpression.Compile(bodytimeType, nameof(bodytimeType), required: false);
            var __workflow_bodyholidayDate = WorkflowExpression.Compile(bodyholidayDate, nameof(bodyholidayDate), required: false);
            var __workflow_bodytime = WorkflowExpression.Compile(bodytime, nameof(bodytime), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3LeaveHolidayInsertResp>(() =>
            {
                var apiCallPath = "/v3/leave/addLeaveApplicationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["holidayType"] = ExpressionConverter.ConvertO(__workflow_bodyholidayType);
                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodyleaveTime != null)
                {
                    body["leaveTime"] = ExpressionConverter.ConvertO(__workflow_bodyleaveTime);
                    bodypropCount++;
                }

                if (__workflow_bodytimeType != null)
                {
                    body["timeType"] = ExpressionConverter.ConvertO(__workflow_bodytimeType);
                    bodypropCount++;
                }

                if (__workflow_bodyholidayDate != null)
                {
                    body["holidayDate"] = ExpressionConverter.ConvertO(__workflow_bodyholidayDate);
                    bodypropCount++;
                }

                if (__workflow_bodytime != null)
                {
                    body["time"] = ExpressionConverter.ConvertO(__workflow_bodytime);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3LeaveHolidayInsertResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _07addShitTemplateInfo(Expression<Func<string>> bodyname, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceAddressId = null, Expression<Func<int>> bodymealTime = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyshiftIn = WorkflowExpression.Compile(bodyshiftIn, nameof(bodyshiftIn), required: true);
            var __workflow_bodyshiftOff = WorkflowExpression.Compile(bodyshiftOff, nameof(bodyshiftOff), required: true);
            var __workflow_bodydateType = WorkflowExpression.Compile(bodydateType, nameof(bodydateType), required: false);
            var __workflow_bodyattendanceAddressId = WorkflowExpression.Compile(bodyattendanceAddressId, nameof(bodyattendanceAddressId), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addShitTemplateInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["shiftIn"] = ExpressionConverter.ConvertO(__workflow_bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = ExpressionConverter.ConvertO(__workflow_bodyshiftOff);
                if (__workflow_bodydateType != null)
                {
                    body["dateType"] = ExpressionConverter.ConvertO(__workflow_bodydateType);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceAddressId != null)
                {
                    body["attendanceAddressId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceAddressId);
                    bodypropCount++;
                }

                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3MobileCardListResp> _07getAttendanceDataList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> hireTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
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
            return new DeferredBodyAction<ResultIPageV3MobileCardListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteEmployeeHistoryById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/employee/deleteEmployeeHistoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteLeaveApplicationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/leave/deleteLeaveApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteShiftTemplateById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteShiftTemplateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3MobileCardInfoResp> _08getAttendanceDataInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3MobileCardInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendance/getAttendanceDataInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3MobileCardInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceItemListResp> _09getAttendanceItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3AttendanceItemListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _09updateEmployeeHistoryById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyentryDate, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodyhireType = null, Expression<Func<string>> bodypositionId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodydirectSupervisorId = null, Expression<Func<string>> bodyattendCalculationId = null, Expression<Func<string>> bodypayrollRegulationId = null, Expression<Func<double>> bodybasicPay = null, Expression<Func<string>> bodycalculateSalaryType = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<string>> bodycause = null, Expression<Func<string>> bodymajorWorkLocationId = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyentryDate = WorkflowExpression.Compile(bodyentryDate, nameof(bodyentryDate), required: true);
            var __workflow_bodyconfirmationDate = WorkflowExpression.Compile(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            var __workflow_bodyhireType = WorkflowExpression.Compile(bodyhireType, nameof(bodyhireType), required: false);
            var __workflow_bodypositionId = WorkflowExpression.Compile(bodypositionId, nameof(bodypositionId), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodydirectSupervisorId = WorkflowExpression.Compile(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            var __workflow_bodyattendCalculationId = WorkflowExpression.Compile(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            var __workflow_bodypayrollRegulationId = WorkflowExpression.Compile(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            var __workflow_bodybasicPay = WorkflowExpression.Compile(bodybasicPay, nameof(bodybasicPay), required: false);
            var __workflow_bodycalculateSalaryType = WorkflowExpression.Compile(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyworkDate = WorkflowExpression.Compile(bodyworkDate, nameof(bodyworkDate), required: false);
            var __workflow_bodycause = WorkflowExpression.Compile(bodycause, nameof(bodycause), required: false);
            var __workflow_bodymajorWorkLocationId = WorkflowExpression.Compile(bodymajorWorkLocationId, nameof(bodymajorWorkLocationId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/employee/updateEmployeeHistoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["entryDate"] = ExpressionConverter.ConvertO(__workflow_bodyentryDate);
                if (__workflow_bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyhireType != null)
                {
                    body["hireType"] = ExpressionConverter.ConvertO(__workflow_bodyhireType);
                    bodypropCount++;
                }

                if (__workflow_bodypositionId != null)
                {
                    body["positionId"] = ExpressionConverter.ConvertO(__workflow_bodypositionId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["departmentId"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = ExpressionConverter.ConvertO(__workflow_bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (__workflow_bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = ExpressionConverter.ConvertO(__workflow_bodyattendCalculationId);
                    bodypropCount++;
                }

                if (__workflow_bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (__workflow_bodybasicPay != null)
                {
                    body["basicPay"] = ExpressionConverter.ConvertO(__workflow_bodybasicPay);
                    bodypropCount++;
                }

                if (__workflow_bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = ExpressionConverter.ConvertO(__workflow_bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyworkDate != null)
                {
                    body["workDate"] = ExpressionConverter.ConvertO(__workflow_bodyworkDate);
                    bodypropCount++;
                }

                if (__workflow_bodycause != null)
                {
                    body["cause"] = ExpressionConverter.ConvertO(__workflow_bodycause);
                    bodypropCount++;
                }

                if (__workflow_bodymajorWorkLocationId != null)
                {
                    body["majorWorkLocationId"] = ExpressionConverter.ConvertO(__workflow_bodymajorWorkLocationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _09updateLeaveApplicationById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyholidayType = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<double>> bodyleaveTime = null, Expression<Func<string>> bodytimeType = null, Expression<Func<string>> bodyholidayDate = null, Expression<Func<string>> bodytime = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyholidayType = WorkflowExpression.Compile(bodyholidayType, nameof(bodyholidayType), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodyleaveTime = WorkflowExpression.Compile(bodyleaveTime, nameof(bodyleaveTime), required: false);
            var __workflow_bodytimeType = WorkflowExpression.Compile(bodytimeType, nameof(bodytimeType), required: false);
            var __workflow_bodyholidayDate = WorkflowExpression.Compile(bodyholidayDate, nameof(bodyholidayDate), required: false);
            var __workflow_bodytime = WorkflowExpression.Compile(bodytime, nameof(bodytime), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/leave/updateLeaveApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyholidayType != null)
                {
                    body["holidayType"] = ExpressionConverter.ConvertO(__workflow_bodyholidayType);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodyleaveTime != null)
                {
                    body["leaveTime"] = ExpressionConverter.ConvertO(__workflow_bodyleaveTime);
                    bodypropCount++;
                }

                if (__workflow_bodytimeType != null)
                {
                    body["timeType"] = ExpressionConverter.ConvertO(__workflow_bodytimeType);
                    bodypropCount++;
                }

                if (__workflow_bodyholidayDate != null)
                {
                    body["holidayDate"] = ExpressionConverter.ConvertO(__workflow_bodyholidayDate);
                    bodypropCount++;
                }

                if (__workflow_bodytime != null)
                {
                    body["time"] = ExpressionConverter.ConvertO(__workflow_bodytime);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _09updateShiftTemplateById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodyshiftIn, Expression<Func<string>> bodyshiftOff, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyattendanceAddressId = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyshiftIn = WorkflowExpression.Compile(bodyshiftIn, nameof(bodyshiftIn), required: true);
            var __workflow_bodyshiftOff = WorkflowExpression.Compile(bodyshiftOff, nameof(bodyshiftOff), required: true);
            var __workflow_bodydateType = WorkflowExpression.Compile(bodydateType, nameof(bodydateType), required: false);
            var __workflow_bodyattendanceAddressId = WorkflowExpression.Compile(bodyattendanceAddressId, nameof(bodyattendanceAddressId), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateShiftTemplateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["shiftIn"] = ExpressionConverter.ConvertO(__workflow_bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = ExpressionConverter.ConvertO(__workflow_bodyshiftOff);
                if (__workflow_bodydateType != null)
                {
                    body["dateType"] = ExpressionConverter.ConvertO(__workflow_bodydateType);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceAddressId != null)
                {
                    body["attendanceAddressId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceAddressId);
                    bodypropCount++;
                }

                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddTimesheetResp> _10addTimesheetInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<string>> bodyworkOverTimeType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: true);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: true);
            var __workflow_bodyworkOverTimeType = WorkflowExpression.Compile(bodyworkOverTimeType, nameof(bodyworkOverTimeType), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyaddressCardId = WorkflowExpression.Compile(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            var __workflow_bodyattendanceItemId = WorkflowExpression.Compile(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3AddTimesheetResp>(() =>
            {
                var apiCallPath = "/v3/attendance/addTimesheetInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyworkOverTimeType != null)
                {
                    body["workOverTimeType"] = ExpressionConverter.ConvertO(__workflow_bodyworkOverTimeType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCardId != null)
                {
                    body["addressCardId"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCardId);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3AddTimesheetResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeHistoryListResp> _10getEmployeeHistoryList(Expression<Func<string>> employeeId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3EmployeeHistoryListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayResp> _10getLeaveApplicationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> employeeFilter = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> holidayTypeFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> recordStatusFilter = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> startDateFilter = null)
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
            return new DeferredBodyAction<ResultIPageV3LeaveHolidayResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ShiftTemplateListResp> _10getShiftTemplateList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendanceAddressId = null, Expression<Func<string>> dateType = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_attendanceAddressId = WorkflowExpression.Compile(attendanceAddressId, nameof(attendanceAddressId), required: false);
            var __workflow_dateType = WorkflowExpression.Compile(dateType, nameof(dateType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV3ShiftTemplateListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _11addOpenShiftInfo(Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodydate, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<double>> bodyhourlyRate, Expression<Func<int>> bodyempPlanNo, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodyshiftType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: true);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: true);
            var __workflow_bodyhourlyRate = WorkflowExpression.Compile(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            var __workflow_bodyempPlanNo = WorkflowExpression.Compile(bodyempPlanNo, nameof(bodyempPlanNo), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodylocationId = WorkflowExpression.Compile(bodylocationId, nameof(bodylocationId), required: false);
            var __workflow_bodyshiftType = WorkflowExpression.Compile(bodyshiftType, nameof(bodyshiftType), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addOpenShiftInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                if (__workflow_bodylocationId != null)
                {
                    body["locationId"] = ExpressionConverter.ConvertO(__workflow_bodylocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftType != null)
                {
                    body["shiftType"] = ExpressionConverter.ConvertO(__workflow_bodyshiftType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                bodypropCount++;
                body["hourlyRate"] = ExpressionConverter.ConvertO(__workflow_bodyhourlyRate);
                bodypropCount++;
                body["empPlanNo"] = ExpressionConverter.ConvertO(__workflow_bodyempPlanNo);
                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _11deleteTimesheetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteTimesheetById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayDetailResp> _11getLeaveApplicationInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3LeaveHolidayDetailResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3LeaveHolidayDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _12deleteOpenShiftById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteOpenShiftById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV3LeaveProcessResp> _12getLeaveApplicationApproveProcessById(Expression<Func<string>> recordId)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<ResultListV3LeaveProcessResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationApproveProcessById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordId"] = ExpressionConverter.Convert(__workflow_recordId);
                return new ApiConnectionAction<ResultListV3LeaveProcessResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _12updateTimesheetById(Expression<Func<string>> bodyid, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<string>> bodyworkOverTimeType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<string>> bodyattendanceItemId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: true);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: true);
            var __workflow_bodyworkOverTimeType = WorkflowExpression.Compile(bodyworkOverTimeType, nameof(bodyworkOverTimeType), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyaddressCardId = WorkflowExpression.Compile(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            var __workflow_bodyattendanceItemId = WorkflowExpression.Compile(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/updateTimesheetById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyworkOverTimeType != null)
                {
                    body["workOverTimeType"] = ExpressionConverter.ConvertO(__workflow_bodyworkOverTimeType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCardId != null)
                {
                    body["addressCardId"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCardId);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeaveTypeResp> _13getLeaveTypeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> shortName = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_shortName = WorkflowExpression.Compile(shortName, nameof(shortName), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveTypeResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3TimesheetListResp> _13getTimesheetList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> departmentFilter = null, Expression<Func<string>> positionFilter = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> bizLabelIds = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> calculateSalaryTypeFilter = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> addressCardId = null, Expression<Func<string>> typeFilter = null)
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
            return new DeferredBodyAction<ResultIPageV3TimesheetListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _13updateOpenShiftById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyprojectId, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<double>> bodyhourlyRate, Expression<Func<int>> bodyempPlanNo, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodyshiftType = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: true);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: true);
            var __workflow_bodyhourlyRate = WorkflowExpression.Compile(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            var __workflow_bodyempPlanNo = WorkflowExpression.Compile(bodyempPlanNo, nameof(bodyempPlanNo), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodylocationId = WorkflowExpression.Compile(bodylocationId, nameof(bodylocationId), required: false);
            var __workflow_bodyshiftType = WorkflowExpression.Compile(bodyshiftType, nameof(bodyshiftType), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateOpenShiftById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                if (__workflow_bodylocationId != null)
                {
                    body["locationId"] = ExpressionConverter.ConvertO(__workflow_bodylocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftType != null)
                {
                    body["shiftType"] = ExpressionConverter.ConvertO(__workflow_bodyshiftType);
                    bodypropCount++;
                }

                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                bodypropCount++;
                body["hourlyRate"] = ExpressionConverter.ConvertO(__workflow_bodyhourlyRate);
                bodypropCount++;
                body["empPlanNo"] = ExpressionConverter.ConvertO(__workflow_bodyempPlanNo);
                if (__workflow_bodycostCenterId != null)
                {
                    body["costCenterId"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyResp> _14getLeavePolicyList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredBodyAction<ResultIPageV3LeavePolicyResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3OpenShiftListResp> _14getOpenShiftList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> projectId = null, Expression<Func<string>> locationId = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> date = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_costCenterId = WorkflowExpression.Compile(costCenterId, nameof(costCenterId), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            return new DeferredBodyAction<ResultIPageV3OpenShiftListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3TimesheetInfoResp> _14getTimesheetInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3TimesheetInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendance/getTimesheetInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3TimesheetInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3AddCalendarRemarkInfoResp> _15addCalendarRemarkInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyemployeeStatus, Expression<Func<string>> bodytimeType, Expression<Func<string>> bodyexpectWorkStartTime, Expression<Func<string>> bodyexpectWorkEndTime, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrecordDate = null, Expression<Func<string>> bodyexpectWorkLocation = null, Expression<Func<string>> bodyexpectWorkTimeTemplate = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyemployeeStatus = WorkflowExpression.Compile(bodyemployeeStatus, nameof(bodyemployeeStatus), required: true);
            var __workflow_bodytimeType = WorkflowExpression.Compile(bodytimeType, nameof(bodytimeType), required: true);
            var __workflow_bodyexpectWorkStartTime = WorkflowExpression.Compile(bodyexpectWorkStartTime, nameof(bodyexpectWorkStartTime), required: true);
            var __workflow_bodyexpectWorkEndTime = WorkflowExpression.Compile(bodyexpectWorkEndTime, nameof(bodyexpectWorkEndTime), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyrecordDate = WorkflowExpression.Compile(bodyrecordDate, nameof(bodyrecordDate), required: false);
            var __workflow_bodyexpectWorkLocation = WorkflowExpression.Compile(bodyexpectWorkLocation, nameof(bodyexpectWorkLocation), required: false);
            var __workflow_bodyexpectWorkTimeTemplate = WorkflowExpression.Compile(bodyexpectWorkTimeTemplate, nameof(bodyexpectWorkTimeTemplate), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3AddCalendarRemarkInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendance/addCalendarRemarkInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["employeeStatus"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeStatus);
                bodypropCount++;
                body["timeType"] = ExpressionConverter.ConvertO(__workflow_bodytimeType);
                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordDate != null)
                {
                    body["recordDate"] = ExpressionConverter.ConvertO(__workflow_bodyrecordDate);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectWorkLocation != null)
                {
                    body["expectWorkLocation"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectWorkTimeTemplate != null)
                {
                    body["expectWorkTimeTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkTimeTemplate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expectWorkStartTime"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkStartTime);
                bodypropCount++;
                body["expectWorkEndTime"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkEndTime);
                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultV3AddCalendarRemarkInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3LeavePolicyDetailResp> _15getLeavePolicyInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3LeavePolicyDetailResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeavePolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3LeavePolicyDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3OpenShiftInfoResp> _15getOpenShiftInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3OpenShiftInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getOpenShiftInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3OpenShiftInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _16addProjectCategoryInfo(Expression<Func<string>> bodyname, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCategoryInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _16deleteCalendarRemarkById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteCalendarRemarkById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyTypeResp> _16getLeavePolicyTypeList(Expression<Func<string>> regulationId, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> id = null, Expression<Func<string>> holidayId = null, Expression<Func<string>> generationFrequency = null)
        {
            var __workflow_regulationId = WorkflowExpression.Compile(regulationId, nameof(regulationId), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_holidayId = WorkflowExpression.Compile(holidayId, nameof(holidayId), required: false);
            var __workflow_generationFrequency = WorkflowExpression.Compile(generationFrequency, nameof(generationFrequency), required: false);
            return new DeferredBodyAction<ResultIPageV3LeavePolicyTypeResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _17deleteProjectCategoryById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCategoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _17updateCalendarRemarkById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyemployeeStatus, Expression<Func<string>> bodytimeType, Expression<Func<string>> bodyexpectWorkStartTime, Expression<Func<string>> bodyexpectWorkEndTime, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrecordDate = null, Expression<Func<string>> bodyexpectWorkLocation = null, Expression<Func<string>> bodyexpectWorkTimeTemplate = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyemployeeStatus = WorkflowExpression.Compile(bodyemployeeStatus, nameof(bodyemployeeStatus), required: true);
            var __workflow_bodytimeType = WorkflowExpression.Compile(bodytimeType, nameof(bodytimeType), required: true);
            var __workflow_bodyexpectWorkStartTime = WorkflowExpression.Compile(bodyexpectWorkStartTime, nameof(bodyexpectWorkStartTime), required: true);
            var __workflow_bodyexpectWorkEndTime = WorkflowExpression.Compile(bodyexpectWorkEndTime, nameof(bodyexpectWorkEndTime), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyrecordDate = WorkflowExpression.Compile(bodyrecordDate, nameof(bodyrecordDate), required: false);
            var __workflow_bodyexpectWorkLocation = WorkflowExpression.Compile(bodyexpectWorkLocation, nameof(bodyexpectWorkLocation), required: false);
            var __workflow_bodyexpectWorkTimeTemplate = WorkflowExpression.Compile(bodyexpectWorkTimeTemplate, nameof(bodyexpectWorkTimeTemplate), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/updateCalendarRemarkById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["employeeStatus"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeStatus);
                bodypropCount++;
                body["timeType"] = ExpressionConverter.ConvertO(__workflow_bodytimeType);
                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordDate != null)
                {
                    body["recordDate"] = ExpressionConverter.ConvertO(__workflow_bodyrecordDate);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectWorkLocation != null)
                {
                    body["expectWorkLocation"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectWorkTimeTemplate != null)
                {
                    body["expectWorkTimeTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkTimeTemplate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expectWorkStartTime"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkStartTime);
                bodypropCount++;
                body["expectWorkEndTime"] = ExpressionConverter.ConvertO(__workflow_bodyexpectWorkEndTime);
                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3StatusFlagListResp> _18getCalendarRemarkList(Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIds = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeIds = WorkflowExpression.Compile(employeeIds, nameof(employeeIds), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<ResultIPageV3StatusFlagListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _18updateProjectCategoryById(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectCategoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ScheduleProjectCategoryListResp> _19getProjectCategoryList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ScheduleProjectCategoryListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _20addProjectInfo(Expression<Func<string>> bodycode, Expression<Func<string>> bodyname, Expression<Func<double>> bodyhourlyRate, Expression<Func<string>> bodycategoryId = null, Expression<Func<double>> bodyminRate = null, Expression<Func<double>> bodymaxRate = null)
        {
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyhourlyRate = WorkflowExpression.Compile(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodyminRate = WorkflowExpression.Compile(bodyminRate, nameof(bodyminRate), required: false);
            var __workflow_bodymaxRate = WorkflowExpression.Compile(bodymaxRate, nameof(bodymaxRate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                if (__workflow_bodycategoryId != null)
                {
                    body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["hourlyRate"] = ExpressionConverter.ConvertO(__workflow_bodyhourlyRate);
                if (__workflow_bodyminRate != null)
                {
                    body["minRate"] = ExpressionConverter.ConvertO(__workflow_bodyminRate);
                    bodypropCount++;
                }

                if (__workflow_bodymaxRate != null)
                {
                    body["maxRate"] = ExpressionConverter.ConvertO(__workflow_bodymaxRate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _21deleteProjectById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _22updateProjectById(Expression<Func<string>> bodyid, Expression<Func<string>> bodycode, Expression<Func<string>> bodyname, Expression<Func<double>> bodyhourlyRate, Expression<Func<string>> bodycategoryId = null, Expression<Func<double>> bodyminRate = null, Expression<Func<double>> bodymaxRate = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyhourlyRate = WorkflowExpression.Compile(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodyminRate = WorkflowExpression.Compile(bodyminRate, nameof(bodyminRate), required: false);
            var __workflow_bodymaxRate = WorkflowExpression.Compile(bodymaxRate, nameof(bodymaxRate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                if (__workflow_bodycategoryId != null)
                {
                    body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["hourlyRate"] = ExpressionConverter.ConvertO(__workflow_bodyhourlyRate);
                if (__workflow_bodyminRate != null)
                {
                    body["minRate"] = ExpressionConverter.ConvertO(__workflow_bodyminRate);
                    bodypropCount++;
                }

                if (__workflow_bodymaxRate != null)
                {
                    body["maxRate"] = ExpressionConverter.ConvertO(__workflow_bodymaxRate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ProjectListResp> _23getProjectList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV3ProjectInfoResp> _24getProjectInfoById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3ProjectInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getProjectInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultV3ProjectInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _25addProjectCertificateInfo(Expression<Func<string>> bodyemployeeId, Expression<Func<string>> bodyprojectId, Expression<Func<double>> bodyshiftHours, Expression<Func<double>> bodyworkedHours, Expression<Func<string>> bodytier = null, Expression<Func<double>> bodytierRate = null, Expression<Func<string>> bodyreason = null)
        {
            var __workflow_bodyemployeeId = WorkflowExpression.Compile(bodyemployeeId, nameof(bodyemployeeId), required: true);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: true);
            var __workflow_bodyshiftHours = WorkflowExpression.Compile(bodyshiftHours, nameof(bodyshiftHours), required: true);
            var __workflow_bodyworkedHours = WorkflowExpression.Compile(bodyworkedHours, nameof(bodyworkedHours), required: true);
            var __workflow_bodytier = WorkflowExpression.Compile(bodytier, nameof(bodytier), required: false);
            var __workflow_bodytierRate = WorkflowExpression.Compile(bodytierRate, nameof(bodytierRate), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCertificateInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeId);
                bodypropCount++;
                body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                if (__workflow_bodytier != null)
                {
                    body["tier"] = ExpressionConverter.ConvertO(__workflow_bodytier);
                    bodypropCount++;
                }

                if (__workflow_bodytierRate != null)
                {
                    body["tierRate"] = ExpressionConverter.ConvertO(__workflow_bodytierRate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftHours"] = ExpressionConverter.ConvertO(__workflow_bodyshiftHours);
                bodypropCount++;
                body["workedHours"] = ExpressionConverter.ConvertO(__workflow_bodyworkedHours);
                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _26updateProjectCertificateById(Expression<Func<string>> bodyid, Expression<Func<string>> bodytier = null, Expression<Func<double>> bodytierRate = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodytier = WorkflowExpression.Compile(bodytier, nameof(bodytier), required: false);
            var __workflow_bodytierRate = WorkflowExpression.Compile(bodytierRate, nameof(bodytierRate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectCertificateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodytier != null)
                {
                    body["tier"] = ExpressionConverter.ConvertO(__workflow_bodytier);
                    bodypropCount++;
                }

                if (__workflow_bodytierRate != null)
                {
                    body["tierRate"] = ExpressionConverter.ConvertO(__workflow_bodytierRate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateListResp> _27getProjectCertificateList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<int>> status = null, Expression<Func<string>> hireType = null, Expression<Func<string>> projectId = null)
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
            return new DeferredBodyAction<ResultIPageV3ProjectCertificateListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _28addProjectCertificateHours(Expression<Func<string>> bodyprojectCertificateId, Expression<Func<string>> bodyoccurrenceTime, Expression<Func<double>> bodybalance, Expression<Func<string>> bodyreason)
        {
            var __workflow_bodyprojectCertificateId = WorkflowExpression.Compile(bodyprojectCertificateId, nameof(bodyprojectCertificateId), required: true);
            var __workflow_bodyoccurrenceTime = WorkflowExpression.Compile(bodyoccurrenceTime, nameof(bodyoccurrenceTime), required: true);
            var __workflow_bodybalance = WorkflowExpression.Compile(bodybalance, nameof(bodybalance), required: true);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCertificateHours";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["projectCertificateId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCertificateId);
                bodypropCount++;
                body["occurrenceTime"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceTime);
                bodypropCount++;
                body["balance"] = ExpressionConverter.ConvertO(__workflow_bodybalance);
                bodypropCount++;
                body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> _29deleteProjectCertificateHoursById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCertificateHoursById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateHoursListResp> _30getProjectCertificateHourList(Expression<Func<string>> projectCertificateId, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_projectCertificateId = WorkflowExpression.Compile(projectCertificateId, nameof(projectCertificateId), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectCertificateHoursListResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2AttendanceResp> GetAttendCalculationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendDay = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> attendStatus = null, Expression<Func<string>> type = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_attendDay = WorkflowExpression.Compile(attendDay, nameof(attendDay), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_attendStatus = WorkflowExpression.Compile(attendStatus, nameof(attendStatus), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<ResultIPageV2AttendanceResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2CostCenterResp> GetCostCenterList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> costCenterCode = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_costCenterCode = WorkflowExpression.Compile(costCenterCode, nameof(costCenterCode), required: false);
            return new DeferredBodyAction<ResultIPageV2CostCenterResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2DepartmentResp> GetDepartmentList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> departmentCode = null, Expression<Func<string>> parentId = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_departmentCode = WorkflowExpression.Compile(departmentCode, nameof(departmentCode), required: false);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2DepartmentResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2EmployeeResp> GetEmployeeList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> englishName = null, Expression<Func<string>> chineseName = null, Expression<Func<string>> email = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> phone = null, Expression<Func<string>> code = null, Expression<Func<int>> status = null, Expression<Func<string>> education = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> hireType = null, Expression<Func<string>> bankCode = null, Expression<Func<string>> costCenterId = null, Expression<Func<string>> payrollRegulationId = null, Expression<Func<string>> workDate = null)
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
            return new DeferredBodyAction<ResultIPageV2EmployeeResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2ExpenseResp> GetExpenseApplicationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> reimbursementStatusFilter = null, Expression<Func<string>> reimbursementName = null, Expression<Func<string>> departmentFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_reimbursementStatusFilter = WorkflowExpression.Compile(reimbursementStatusFilter, nameof(reimbursementStatusFilter), required: false);
            var __workflow_reimbursementName = WorkflowExpression.Compile(reimbursementName, nameof(reimbursementName), required: false);
            var __workflow_departmentFilter = WorkflowExpression.Compile(departmentFilter, nameof(departmentFilter), required: false);
            return new DeferredBodyAction<ResultIPageV2ExpenseResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2ExternalPayItemResp> GetExtPayItemData(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> employeeCode = null, Expression<Func<string>> businessSalaryItemId = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> businessSalaryItemFilter = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_employeeCode = WorkflowExpression.Compile(employeeCode, nameof(employeeCode), required: false);
            var __workflow_businessSalaryItemId = WorkflowExpression.Compile(businessSalaryItemId, nameof(businessSalaryItemId), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_businessSalaryItemFilter = WorkflowExpression.Compile(businessSalaryItemFilter, nameof(businessSalaryItemFilter), required: false);
            return new DeferredBodyAction<ResultIPageV2ExternalPayItemResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2ExtPayItemResp> GetExtPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> paymentType = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_paymentType = WorkflowExpression.Compile(paymentType, nameof(paymentType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2ExtPayItemResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2FixedPayItemResp> GetFixedPayItemData(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> payrollItemId = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_payrollItemId = WorkflowExpression.Compile(payrollItemId, nameof(payrollItemId), required: false);
            return new DeferredBodyAction<ResultIPageV2FixedPayItemResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2LabelResp> GetLabelList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> labelCode = null, Expression<Func<string>> labelName = null, Expression<Func<int>> labelStatus = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_labelCode = WorkflowExpression.Compile(labelCode, nameof(labelCode), required: false);
            var __workflow_labelName = WorkflowExpression.Compile(labelName, nameof(labelName), required: false);
            var __workflow_labelStatus = WorkflowExpression.Compile(labelStatus, nameof(labelStatus), required: false);
            return new DeferredBodyAction<ResultIPageV2LabelResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2LeaveApplicationResp> GetLeaveApplicationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> holidayType = null, Expression<Func<string>> status = null, Expression<Func<string>> holidayDate = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_holidayType = WorkflowExpression.Compile(holidayType, nameof(holidayType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_holidayDate = WorkflowExpression.Compile(holidayDate, nameof(holidayDate), required: false);
            return new DeferredBodyAction<ResultIPageV2LeaveApplicationResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2PayItemResp> GetPayItemList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2PayItemResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2PayrollPlanResp> GetPayrunList(Expression<Func<string>> status, Expression<Func<int>> current = null, Expression<Func<int>> size = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV2PayrollPlanResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2PositionResp> GetPositionList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> positionCode = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_positionCode = WorkflowExpression.Compile(positionCode, nameof(positionCode), required: false);
            return new DeferredBodyAction<ResultIPageV2PositionResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultListV2RosterResp> GetRosterDataList(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> attendCalculationId = null, Expression<Func<string>> departmentId = null, Expression<Func<string>> positionId = null, Expression<Func<string>> statusFilter = null, Expression<Func<string>> englishName = null, Expression<Func<string>> code = null, Expression<Func<string>> surnameEnglish = null, Expression<Func<string>> personalNameEnglish = null)
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
            return new DeferredBodyAction<ResultListV2RosterResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultV2TenantResp> GetTenantInfo()
        {
            var apiCallPath = "/v2/tenant/getById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResultV2TenantResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2TimesheetResp> GetTimesheetList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> type = null, Expression<Func<string>> date = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2TimesheetResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2VarPayItemResp> GetVarPayItemData(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> employeeId = null, Expression<Func<string>> payrollItemId = null, Expression<Func<string>> employeeIdFilter = null, Expression<Func<string>> payrollItemIdFilter = null, Expression<Func<string>> payrollPlanId = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: false);
            var __workflow_payrollItemId = WorkflowExpression.Compile(payrollItemId, nameof(payrollItemId), required: false);
            var __workflow_employeeIdFilter = WorkflowExpression.Compile(employeeIdFilter, nameof(employeeIdFilter), required: false);
            var __workflow_payrollItemIdFilter = WorkflowExpression.Compile(payrollItemIdFilter, nameof(payrollItemIdFilter), required: false);
            var __workflow_payrollPlanId = WorkflowExpression.Compile(payrollPlanId, nameof(payrollPlanId), required: false);
            return new DeferredBodyAction<ResultIPageV2VarPayItemResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultIPageV2WorkLocationResp> GetWorkLocationList(Expression<Func<string>> q = null, Expression<Func<int>> current = null, Expression<Func<int>> size = null, Expression<Func<string>> name = null, Expression<Func<string>> attendanceAddressCode = null, Expression<Func<string>> status = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_current = WorkflowExpression.Compile(current, nameof(current), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_attendanceAddressCode = WorkflowExpression.Compile(attendanceAddressCode, nameof(attendanceAddressCode), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2WorkLocationResp>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateCardById(Expression<Func<string>> bodyid, Expression<Func<bool>> bodyisInValid = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyisInValid = WorkflowExpression.Compile(bodyisInValid, nameof(bodyisInValid), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/attendance/updateCardById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyisInValid != null)
                {
                    body["isInValid"] = ExpressionConverter.ConvertO(__workflow_bodyisInValid);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateCostCenterInfo(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycostCenterCode = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycostCenterCode = WorkflowExpression.Compile(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/tenants/updateCostCenterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterCode != null)
                {
                    body["costCenterCode"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateDepartmentInfo(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydepartmentCode = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydepartmentCode = WorkflowExpression.Compile(bodydepartmentCode, nameof(bodydepartmentCode), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/department/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentCode != null)
                {
                    body["departmentCode"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentCode);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateEmployeeInfo(Expression<Func<string>> bodyid, Expression<Func<string>> bodyenglishName = null, Expression<Func<string>> bodychineseName = null, Expression<Func<string>> bodysex = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyidentityCard = null, Expression<Func<string>> bodybankCard = null, Expression<Func<string>> bodynickName = null, Expression<Func<string>> bodyeducation = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<string>> bodyemergencyContactName = null, Expression<Func<string>> bodyemergencyContactRelation = null, Expression<Func<string>> bodyemergencyContactPhone = null, Expression<Func<string>> bodybankName = null, Expression<Func<string>> bodybankBranchNumber = null, Expression<Func<string>> bodybankAccountNo = null, Expression<Func<string>> bodybankCode = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyregionCode = null, Expression<Func<string>> bodyidentityCardHk = null, Expression<Func<string>> bodypassportNumber = null, Expression<Func<string>> bodypassportIssuingPlace = null, Expression<Func<string>> bodyspouseName = null, Expression<Func<string>> bodyspouseIdentityCardHk = null, Expression<Func<string>> bodyspousePassportNumber = null, Expression<Func<string>> bodyspousePassportIssuingPlace = null, Expression<Func<string>> bodypostalAddress = null, Expression<Func<string>> bodyemployerName = null, Expression<Func<string>> bodyhometown = null, Expression<Func<string>> bodynation = null, Expression<Func<string>> bodypoliticalStatus = null, Expression<Func<string>> bodyhighestEducation = null, Expression<Func<string>> bodyworkDate = null, Expression<Func<string>> bodyconfirmationDate = null, Expression<Func<string>> bodyprobation = null, Expression<Func<bool>> bodyisDisabled = null, Expression<Func<bool>> bodyisForeignNationality = null, Expression<Func<string>> bodydomicileLocation = null, Expression<Func<string>> bodycertificateType = null, Expression<Func<string>> bodycertificateNumber = null, Expression<Func<bool>> bodyisMartyrDependents = null, Expression<Func<string>> bodyoccupationTaxNumber = null, Expression<Func<string>> bodynonLocalBlueCardNumber = null, Expression<Func<bool>> bodyisForeignEmployees = null, Expression<Func<string>> bodyweeklyLeaveWorkAgreement = null, Expression<Func<string>> bodyemployeeType = null, Expression<Func<string>> bodyjobLevel = null, Expression<Func<string>> bodypost = null, Expression<Func<string>> bodysalaryScale = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyrecruitmentSource = null, Expression<Func<string>> bodygraduatedSchool = null, Expression<Func<string>> bodyprofession = null, Expression<Func<string>> bodyappellation = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyhomePhone = null, Expression<Func<string>> bodyofficePhone = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyprovince = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodypostcode = null, Expression<Func<string>> bodycontractEndDate = null, Expression<Func<string>> bodytaxIdentity = null, Expression<Func<string>> bodyotherIncomeName = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyenglishName = WorkflowExpression.Compile(bodyenglishName, nameof(bodyenglishName), required: false);
            var __workflow_bodychineseName = WorkflowExpression.Compile(bodychineseName, nameof(bodychineseName), required: false);
            var __workflow_bodysex = WorkflowExpression.Compile(bodysex, nameof(bodysex), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyidentityCard = WorkflowExpression.Compile(bodyidentityCard, nameof(bodyidentityCard), required: false);
            var __workflow_bodybankCard = WorkflowExpression.Compile(bodybankCard, nameof(bodybankCard), required: false);
            var __workflow_bodynickName = WorkflowExpression.Compile(bodynickName, nameof(bodynickName), required: false);
            var __workflow_bodyeducation = WorkflowExpression.Compile(bodyeducation, nameof(bodyeducation), required: false);
            var __workflow_bodynationality = WorkflowExpression.Compile(bodynationality, nameof(bodynationality), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodyemergencyContactName = WorkflowExpression.Compile(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            var __workflow_bodyemergencyContactRelation = WorkflowExpression.Compile(bodyemergencyContactRelation, nameof(bodyemergencyContactRelation), required: false);
            var __workflow_bodyemergencyContactPhone = WorkflowExpression.Compile(bodyemergencyContactPhone, nameof(bodyemergencyContactPhone), required: false);
            var __workflow_bodybankName = WorkflowExpression.Compile(bodybankName, nameof(bodybankName), required: false);
            var __workflow_bodybankBranchNumber = WorkflowExpression.Compile(bodybankBranchNumber, nameof(bodybankBranchNumber), required: false);
            var __workflow_bodybankAccountNo = WorkflowExpression.Compile(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            var __workflow_bodybankCode = WorkflowExpression.Compile(bodybankCode, nameof(bodybankCode), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodyregionCode = WorkflowExpression.Compile(bodyregionCode, nameof(bodyregionCode), required: false);
            var __workflow_bodyidentityCardHk = WorkflowExpression.Compile(bodyidentityCardHk, nameof(bodyidentityCardHk), required: false);
            var __workflow_bodypassportNumber = WorkflowExpression.Compile(bodypassportNumber, nameof(bodypassportNumber), required: false);
            var __workflow_bodypassportIssuingPlace = WorkflowExpression.Compile(bodypassportIssuingPlace, nameof(bodypassportIssuingPlace), required: false);
            var __workflow_bodyspouseName = WorkflowExpression.Compile(bodyspouseName, nameof(bodyspouseName), required: false);
            var __workflow_bodyspouseIdentityCardHk = WorkflowExpression.Compile(bodyspouseIdentityCardHk, nameof(bodyspouseIdentityCardHk), required: false);
            var __workflow_bodyspousePassportNumber = WorkflowExpression.Compile(bodyspousePassportNumber, nameof(bodyspousePassportNumber), required: false);
            var __workflow_bodyspousePassportIssuingPlace = WorkflowExpression.Compile(bodyspousePassportIssuingPlace, nameof(bodyspousePassportIssuingPlace), required: false);
            var __workflow_bodypostalAddress = WorkflowExpression.Compile(bodypostalAddress, nameof(bodypostalAddress), required: false);
            var __workflow_bodyemployerName = WorkflowExpression.Compile(bodyemployerName, nameof(bodyemployerName), required: false);
            var __workflow_bodyhometown = WorkflowExpression.Compile(bodyhometown, nameof(bodyhometown), required: false);
            var __workflow_bodynation = WorkflowExpression.Compile(bodynation, nameof(bodynation), required: false);
            var __workflow_bodypoliticalStatus = WorkflowExpression.Compile(bodypoliticalStatus, nameof(bodypoliticalStatus), required: false);
            var __workflow_bodyhighestEducation = WorkflowExpression.Compile(bodyhighestEducation, nameof(bodyhighestEducation), required: false);
            var __workflow_bodyworkDate = WorkflowExpression.Compile(bodyworkDate, nameof(bodyworkDate), required: false);
            var __workflow_bodyconfirmationDate = WorkflowExpression.Compile(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            var __workflow_bodyprobation = WorkflowExpression.Compile(bodyprobation, nameof(bodyprobation), required: false);
            var __workflow_bodyisDisabled = WorkflowExpression.Compile(bodyisDisabled, nameof(bodyisDisabled), required: false);
            var __workflow_bodyisForeignNationality = WorkflowExpression.Compile(bodyisForeignNationality, nameof(bodyisForeignNationality), required: false);
            var __workflow_bodydomicileLocation = WorkflowExpression.Compile(bodydomicileLocation, nameof(bodydomicileLocation), required: false);
            var __workflow_bodycertificateType = WorkflowExpression.Compile(bodycertificateType, nameof(bodycertificateType), required: false);
            var __workflow_bodycertificateNumber = WorkflowExpression.Compile(bodycertificateNumber, nameof(bodycertificateNumber), required: false);
            var __workflow_bodyisMartyrDependents = WorkflowExpression.Compile(bodyisMartyrDependents, nameof(bodyisMartyrDependents), required: false);
            var __workflow_bodyoccupationTaxNumber = WorkflowExpression.Compile(bodyoccupationTaxNumber, nameof(bodyoccupationTaxNumber), required: false);
            var __workflow_bodynonLocalBlueCardNumber = WorkflowExpression.Compile(bodynonLocalBlueCardNumber, nameof(bodynonLocalBlueCardNumber), required: false);
            var __workflow_bodyisForeignEmployees = WorkflowExpression.Compile(bodyisForeignEmployees, nameof(bodyisForeignEmployees), required: false);
            var __workflow_bodyweeklyLeaveWorkAgreement = WorkflowExpression.Compile(bodyweeklyLeaveWorkAgreement, nameof(bodyweeklyLeaveWorkAgreement), required: false);
            var __workflow_bodyemployeeType = WorkflowExpression.Compile(bodyemployeeType, nameof(bodyemployeeType), required: false);
            var __workflow_bodyjobLevel = WorkflowExpression.Compile(bodyjobLevel, nameof(bodyjobLevel), required: false);
            var __workflow_bodypost = WorkflowExpression.Compile(bodypost, nameof(bodypost), required: false);
            var __workflow_bodysalaryScale = WorkflowExpression.Compile(bodysalaryScale, nameof(bodysalaryScale), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodyrecruitmentSource = WorkflowExpression.Compile(bodyrecruitmentSource, nameof(bodyrecruitmentSource), required: false);
            var __workflow_bodygraduatedSchool = WorkflowExpression.Compile(bodygraduatedSchool, nameof(bodygraduatedSchool), required: false);
            var __workflow_bodyprofession = WorkflowExpression.Compile(bodyprofession, nameof(bodyprofession), required: false);
            var __workflow_bodyappellation = WorkflowExpression.Compile(bodyappellation, nameof(bodyappellation), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyhomePhone = WorkflowExpression.Compile(bodyhomePhone, nameof(bodyhomePhone), required: false);
            var __workflow_bodyofficePhone = WorkflowExpression.Compile(bodyofficePhone, nameof(bodyofficePhone), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyprovince = WorkflowExpression.Compile(bodyprovince, nameof(bodyprovince), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodypostcode = WorkflowExpression.Compile(bodypostcode, nameof(bodypostcode), required: false);
            var __workflow_bodycontractEndDate = WorkflowExpression.Compile(bodycontractEndDate, nameof(bodycontractEndDate), required: false);
            var __workflow_bodytaxIdentity = WorkflowExpression.Compile(bodytaxIdentity, nameof(bodytaxIdentity), required: false);
            var __workflow_bodyotherIncomeName = WorkflowExpression.Compile(bodyotherIncomeName, nameof(bodyotherIncomeName), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/employee/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyenglishName != null)
                {
                    body["englishName"] = ExpressionConverter.ConvertO(__workflow_bodyenglishName);
                    bodypropCount++;
                }

                if (__workflow_bodychineseName != null)
                {
                    body["chineseName"] = ExpressionConverter.ConvertO(__workflow_bodychineseName);
                    bodypropCount++;
                }

                if (__workflow_bodysex != null)
                {
                    body["sex"] = ExpressionConverter.ConvertO(__workflow_bodysex);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyidentityCard != null)
                {
                    body["identityCard"] = ExpressionConverter.ConvertO(__workflow_bodyidentityCard);
                    bodypropCount++;
                }

                if (__workflow_bodybankCard != null)
                {
                    body["bankCard"] = ExpressionConverter.ConvertO(__workflow_bodybankCard);
                    bodypropCount++;
                }

                if (__workflow_bodynickName != null)
                {
                    body["nickName"] = ExpressionConverter.ConvertO(__workflow_bodynickName);
                    bodypropCount++;
                }

                if (__workflow_bodyeducation != null)
                {
                    body["education"] = ExpressionConverter.ConvertO(__workflow_bodyeducation);
                    bodypropCount++;
                }

                if (__workflow_bodynationality != null)
                {
                    body["nationality"] = ExpressionConverter.ConvertO(__workflow_bodynationality);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["maritalStatus"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactName);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactRelation != null)
                {
                    body["emergencyContactRelation"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactRelation);
                    bodypropCount++;
                }

                if (__workflow_bodyemergencyContactPhone != null)
                {
                    body["emergencyContactPhone"] = ExpressionConverter.ConvertO(__workflow_bodyemergencyContactPhone);
                    bodypropCount++;
                }

                if (__workflow_bodybankName != null)
                {
                    body["bankName"] = ExpressionConverter.ConvertO(__workflow_bodybankName);
                    bodypropCount++;
                }

                if (__workflow_bodybankBranchNumber != null)
                {
                    body["bankBranchNumber"] = ExpressionConverter.ConvertO(__workflow_bodybankBranchNumber);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountNo);
                    bodypropCount++;
                }

                if (__workflow_bodybankCode != null)
                {
                    body["bankCode"] = ExpressionConverter.ConvertO(__workflow_bodybankCode);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodyregionCode != null)
                {
                    body["regionCode"] = ExpressionConverter.ConvertO(__workflow_bodyregionCode);
                    bodypropCount++;
                }

                if (__workflow_bodyidentityCardHk != null)
                {
                    body["identityCardHk"] = ExpressionConverter.ConvertO(__workflow_bodyidentityCardHk);
                    bodypropCount++;
                }

                if (__workflow_bodypassportNumber != null)
                {
                    body["passportNumber"] = ExpressionConverter.ConvertO(__workflow_bodypassportNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypassportIssuingPlace != null)
                {
                    body["passportIssuingPlace"] = ExpressionConverter.ConvertO(__workflow_bodypassportIssuingPlace);
                    bodypropCount++;
                }

                if (__workflow_bodyspouseName != null)
                {
                    body["spouseName"] = ExpressionConverter.ConvertO(__workflow_bodyspouseName);
                    bodypropCount++;
                }

                if (__workflow_bodyspouseIdentityCardHk != null)
                {
                    body["spouseIdentityCardHk"] = ExpressionConverter.ConvertO(__workflow_bodyspouseIdentityCardHk);
                    bodypropCount++;
                }

                if (__workflow_bodyspousePassportNumber != null)
                {
                    body["spousePassportNumber"] = ExpressionConverter.ConvertO(__workflow_bodyspousePassportNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyspousePassportIssuingPlace != null)
                {
                    body["spousePassportIssuingPlace"] = ExpressionConverter.ConvertO(__workflow_bodyspousePassportIssuingPlace);
                    bodypropCount++;
                }

                if (__workflow_bodypostalAddress != null)
                {
                    body["postalAddress"] = ExpressionConverter.ConvertO(__workflow_bodypostalAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyemployerName != null)
                {
                    body["employerName"] = ExpressionConverter.ConvertO(__workflow_bodyemployerName);
                    bodypropCount++;
                }

                if (__workflow_bodyhometown != null)
                {
                    body["hometown"] = ExpressionConverter.ConvertO(__workflow_bodyhometown);
                    bodypropCount++;
                }

                if (__workflow_bodynation != null)
                {
                    body["nation"] = ExpressionConverter.ConvertO(__workflow_bodynation);
                    bodypropCount++;
                }

                if (__workflow_bodypoliticalStatus != null)
                {
                    body["politicalStatus"] = ExpressionConverter.ConvertO(__workflow_bodypoliticalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyhighestEducation != null)
                {
                    body["highestEducation"] = ExpressionConverter.ConvertO(__workflow_bodyhighestEducation);
                    bodypropCount++;
                }

                if (__workflow_bodyworkDate != null)
                {
                    body["workDate"] = ExpressionConverter.ConvertO(__workflow_bodyworkDate);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyprobation != null)
                {
                    body["probation"] = ExpressionConverter.ConvertO(__workflow_bodyprobation);
                    bodypropCount++;
                }

                if (__workflow_bodyisDisabled != null)
                {
                    body["isDisabled"] = ExpressionConverter.ConvertO(__workflow_bodyisDisabled);
                    bodypropCount++;
                }

                if (__workflow_bodyisForeignNationality != null)
                {
                    body["isForeignNationality"] = ExpressionConverter.ConvertO(__workflow_bodyisForeignNationality);
                    bodypropCount++;
                }

                if (__workflow_bodydomicileLocation != null)
                {
                    body["domicileLocation"] = ExpressionConverter.ConvertO(__workflow_bodydomicileLocation);
                    bodypropCount++;
                }

                if (__workflow_bodycertificateType != null)
                {
                    body["certificateType"] = ExpressionConverter.ConvertO(__workflow_bodycertificateType);
                    bodypropCount++;
                }

                if (__workflow_bodycertificateNumber != null)
                {
                    body["certificateNumber"] = ExpressionConverter.ConvertO(__workflow_bodycertificateNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyisMartyrDependents != null)
                {
                    body["isMartyrDependents"] = ExpressionConverter.ConvertO(__workflow_bodyisMartyrDependents);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupationTaxNumber != null)
                {
                    body["occupationTaxNumber"] = ExpressionConverter.ConvertO(__workflow_bodyoccupationTaxNumber);
                    bodypropCount++;
                }

                if (__workflow_bodynonLocalBlueCardNumber != null)
                {
                    body["nonLocalBlueCardNumber"] = ExpressionConverter.ConvertO(__workflow_bodynonLocalBlueCardNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyisForeignEmployees != null)
                {
                    body["isForeignEmployees"] = ExpressionConverter.ConvertO(__workflow_bodyisForeignEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodyweeklyLeaveWorkAgreement != null)
                {
                    body["weeklyLeaveWorkAgreement"] = ExpressionConverter.ConvertO(__workflow_bodyweeklyLeaveWorkAgreement);
                    bodypropCount++;
                }

                if (__workflow_bodyemployeeType != null)
                {
                    body["employeeType"] = ExpressionConverter.ConvertO(__workflow_bodyemployeeType);
                    bodypropCount++;
                }

                if (__workflow_bodyjobLevel != null)
                {
                    body["jobLevel"] = ExpressionConverter.ConvertO(__workflow_bodyjobLevel);
                    bodypropCount++;
                }

                if (__workflow_bodypost != null)
                {
                    body["post"] = ExpressionConverter.ConvertO(__workflow_bodypost);
                    bodypropCount++;
                }

                if (__workflow_bodysalaryScale != null)
                {
                    body["salaryScale"] = ExpressionConverter.ConvertO(__workflow_bodysalaryScale);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyrecruitmentSource != null)
                {
                    body["recruitmentSource"] = ExpressionConverter.ConvertO(__workflow_bodyrecruitmentSource);
                    bodypropCount++;
                }

                if (__workflow_bodygraduatedSchool != null)
                {
                    body["graduatedSchool"] = ExpressionConverter.ConvertO(__workflow_bodygraduatedSchool);
                    bodypropCount++;
                }

                if (__workflow_bodyprofession != null)
                {
                    body["profession"] = ExpressionConverter.ConvertO(__workflow_bodyprofession);
                    bodypropCount++;
                }

                if (__workflow_bodyappellation != null)
                {
                    body["appellation"] = ExpressionConverter.ConvertO(__workflow_bodyappellation);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodyhomePhone != null)
                {
                    body["homePhone"] = ExpressionConverter.ConvertO(__workflow_bodyhomePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyofficePhone != null)
                {
                    body["officePhone"] = ExpressionConverter.ConvertO(__workflow_bodyofficePhone);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyprovince != null)
                {
                    body["province"] = ExpressionConverter.ConvertO(__workflow_bodyprovince);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodypostcode != null)
                {
                    body["postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostcode);
                    bodypropCount++;
                }

                if (__workflow_bodycontractEndDate != null)
                {
                    body["contractEndDate"] = ExpressionConverter.ConvertO(__workflow_bodycontractEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodytaxIdentity != null)
                {
                    body["taxIdentity"] = ExpressionConverter.ConvertO(__workflow_bodytaxIdentity);
                    bodypropCount++;
                }

                if (__workflow_bodyotherIncomeName != null)
                {
                    body["otherIncomeName"] = ExpressionConverter.ConvertO(__workflow_bodyotherIncomeName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateExpenseApplication(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyreimbursementName = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyreimbursementName = WorkflowExpression.Compile(bodyreimbursementName, nameof(bodyreimbursementName), required: false);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/tenants/updateExpenseApplication";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyreimbursementName != null)
                {
                    body["reimbursementName"] = ExpressionConverter.ConvertO(__workflow_bodyreimbursementName);
                    bodypropCount++;
                }

                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateExternalSalary(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodycode = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyoccurrenceDate = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: false);
            var __workflow_bodyoccurrenceDate = WorkflowExpression.Compile(bodyoccurrenceDate, nameof(bodyoccurrenceDate), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodyexpirationDate = WorkflowExpression.Compile(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/payroll/updateExternalSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodymoney != null)
                {
                    body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                    bodypropCount++;
                }

                if (__workflow_bodyoccurrenceDate != null)
                {
                    body["occurrenceDate"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceDate);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodyexpirationDate != null)
                {
                    body["expirationDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateFixedSalary(Expression<Func<string>> bodyid, Expression<Func<string>> bodypayrollItemId = null, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodypayrollItemId = WorkflowExpression.Compile(bodypayrollItemId, nameof(bodypayrollItemId), required: false);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/payroll/updateFixedSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodypayrollItemId != null)
                {
                    body["payrollItemId"] = ExpressionConverter.ConvertO(__workflow_bodypayrollItemId);
                    bodypropCount++;
                }

                if (__workflow_bodymoney != null)
                {
                    body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateLabelInfo(Expression<Func<string>> bodyid, Expression<Func<string>> bodylabelCode = null, Expression<Func<string>> bodylabelName = null, Expression<Func<int>> bodylabelStatus = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodylabelCode = WorkflowExpression.Compile(bodylabelCode, nameof(bodylabelCode), required: false);
            var __workflow_bodylabelName = WorkflowExpression.Compile(bodylabelName, nameof(bodylabelName), required: false);
            var __workflow_bodylabelStatus = WorkflowExpression.Compile(bodylabelStatus, nameof(bodylabelStatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/label/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodylabelCode != null)
                {
                    body["labelCode"] = ExpressionConverter.ConvertO(__workflow_bodylabelCode);
                    bodypropCount++;
                }

                if (__workflow_bodylabelName != null)
                {
                    body["labelName"] = ExpressionConverter.ConvertO(__workflow_bodylabelName);
                    bodypropCount++;
                }

                if (__workflow_bodylabelStatus != null)
                {
                    body["labelStatus"] = ExpressionConverter.ConvertO(__workflow_bodylabelStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateLeaveApplication(Expression<Func<string>> bodyid, Expression<Func<string>> bodyholidayType = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<double>> bodyleaveTime = null, Expression<Func<string>> bodytimeType = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyholidayDate = null, Expression<Func<string>> bodytime = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyholidayType = WorkflowExpression.Compile(bodyholidayType, nameof(bodyholidayType), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodyleaveTime = WorkflowExpression.Compile(bodyleaveTime, nameof(bodyleaveTime), required: false);
            var __workflow_bodytimeType = WorkflowExpression.Compile(bodytimeType, nameof(bodytimeType), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodyholidayDate = WorkflowExpression.Compile(bodyholidayDate, nameof(bodyholidayDate), required: false);
            var __workflow_bodytime = WorkflowExpression.Compile(bodytime, nameof(bodytime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/leave/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyholidayType != null)
                {
                    body["holidayType"] = ExpressionConverter.ConvertO(__workflow_bodyholidayType);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodyleaveTime != null)
                {
                    body["leaveTime"] = ExpressionConverter.ConvertO(__workflow_bodyleaveTime);
                    bodypropCount++;
                }

                if (__workflow_bodytimeType != null)
                {
                    body["timeType"] = ExpressionConverter.ConvertO(__workflow_bodytimeType);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodyholidayDate != null)
                {
                    body["holidayDate"] = ExpressionConverter.ConvertO(__workflow_bodyholidayDate);
                    bodypropCount++;
                }

                if (__workflow_bodytime != null)
                {
                    body["time"] = ExpressionConverter.ConvertO(__workflow_bodytime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdatePositionInfo(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodypositionCode = WorkflowExpression.Compile(bodypositionCode, nameof(bodypositionCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/tenants/updatePositionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodypositionCode != null)
                {
                    body["positionCode"] = ExpressionConverter.ConvertO(__workflow_bodypositionCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterData(Expression<Func<string>> bodyid, Expression<Func<string>> bodyshiftIn = null, Expression<Func<string>> bodyshiftOff = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyshiftStatus = null, Expression<Func<string>> bodyaddressCardId = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodyacrossTheNight = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyshiftIn = WorkflowExpression.Compile(bodyshiftIn, nameof(bodyshiftIn), required: false);
            var __workflow_bodyshiftOff = WorkflowExpression.Compile(bodyshiftOff, nameof(bodyshiftOff), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyshiftStatus = WorkflowExpression.Compile(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            var __workflow_bodyaddressCardId = WorkflowExpression.Compile(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            var __workflow_bodydateType = WorkflowExpression.Compile(bodydateType, nameof(bodydateType), required: false);
            var __workflow_bodyacrossTheNight = WorkflowExpression.Compile(bodyacrossTheNight, nameof(bodyacrossTheNight), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/tenants/updateRosterData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyshiftIn != null)
                {
                    body["shiftIn"] = ExpressionConverter.ConvertO(__workflow_bodyshiftIn);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftOff != null)
                {
                    body["shiftOff"] = ExpressionConverter.ConvertO(__workflow_bodyshiftOff);
                    bodypropCount++;
                }

                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftStatus != null)
                {
                    body["shiftStatus"] = ExpressionConverter.ConvertO(__workflow_bodyshiftStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCardId != null)
                {
                    body["addressCardId"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCardId);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (__workflow_bodydateType != null)
                {
                    body["dateType"] = ExpressionConverter.ConvertO(__workflow_bodydateType);
                    bodypropCount++;
                }

                if (__workflow_bodyacrossTheNight != null)
                {
                    body["acrossTheNight"] = ExpressionConverter.ConvertO(__workflow_bodyacrossTheNight);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterItem(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycode = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/attendance/updateRosterItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateShiftTemplate(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyshiftIn = null, Expression<Func<string>> bodyshiftOff = null, Expression<Func<int>> bodymealTime = null, Expression<Func<string>> bodyattendanceAddressId = null, Expression<Func<string>> bodydateType = null, Expression<Func<string>> bodylunchStartTime = null, Expression<Func<string>> bodylunchEndTime = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyshiftIn = WorkflowExpression.Compile(bodyshiftIn, nameof(bodyshiftIn), required: false);
            var __workflow_bodyshiftOff = WorkflowExpression.Compile(bodyshiftOff, nameof(bodyshiftOff), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            var __workflow_bodyattendanceAddressId = WorkflowExpression.Compile(bodyattendanceAddressId, nameof(bodyattendanceAddressId), required: false);
            var __workflow_bodydateType = WorkflowExpression.Compile(bodydateType, nameof(bodydateType), required: false);
            var __workflow_bodylunchStartTime = WorkflowExpression.Compile(bodylunchStartTime, nameof(bodylunchStartTime), required: false);
            var __workflow_bodylunchEndTime = WorkflowExpression.Compile(bodylunchEndTime, nameof(bodylunchEndTime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/attendance/updateShiftTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftIn != null)
                {
                    body["shiftIn"] = ExpressionConverter.ConvertO(__workflow_bodyshiftIn);
                    bodypropCount++;
                }

                if (__workflow_bodyshiftOff != null)
                {
                    body["shiftOff"] = ExpressionConverter.ConvertO(__workflow_bodyshiftOff);
                    bodypropCount++;
                }

                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceAddressId != null)
                {
                    body["attendanceAddressId"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceAddressId);
                    bodypropCount++;
                }

                if (__workflow_bodydateType != null)
                {
                    body["dateType"] = ExpressionConverter.ConvertO(__workflow_bodydateType);
                    bodypropCount++;
                }

                if (__workflow_bodylunchStartTime != null)
                {
                    body["lunchStartTime"] = ExpressionConverter.ConvertO(__workflow_bodylunchStartTime);
                    bodypropCount++;
                }

                if (__workflow_bodylunchEndTime != null)
                {
                    body["lunchEndTime"] = ExpressionConverter.ConvertO(__workflow_bodylunchEndTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateTenantInfo(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodybusinessRegistrationNumber = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodybankName = null, Expression<Func<string>> bodybankBranchCode = null, Expression<Func<string>> bodybankAccountNo = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodybusinessRegistrationNumber = WorkflowExpression.Compile(bodybusinessRegistrationNumber, nameof(bodybusinessRegistrationNumber), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodybankName = WorkflowExpression.Compile(bodybankName, nameof(bodybankName), required: false);
            var __workflow_bodybankBranchCode = WorkflowExpression.Compile(bodybankBranchCode, nameof(bodybankBranchCode), required: false);
            var __workflow_bodybankAccountNo = WorkflowExpression.Compile(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/tenant/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodybusinessRegistrationNumber != null)
                {
                    body["businessRegistrationNumber"] = ExpressionConverter.ConvertO(__workflow_bodybusinessRegistrationNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodybankName != null)
                {
                    body["bankName"] = ExpressionConverter.ConvertO(__workflow_bodybankName);
                    bodypropCount++;
                }

                if (__workflow_bodybankBranchCode != null)
                {
                    body["bankBranchCode"] = ExpressionConverter.ConvertO(__workflow_bodybankBranchCode);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountNo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateTimesheet(Expression<Func<string>> bodyid, Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodyisCrossTheSky = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<int>> bodymealTime = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyisCrossTheSky = WorkflowExpression.Compile(bodyisCrossTheSky, nameof(bodyisCrossTheSky), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodymealTime = WorkflowExpression.Compile(bodymealTime, nameof(bodymealTime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/timesheet/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyisCrossTheSky != null)
                {
                    body["isCrossTheSky"] = ExpressionConverter.ConvertO(__workflow_bodyisCrossTheSky);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodymealTime != null)
                {
                    body["mealTime"] = ExpressionConverter.ConvertO(__workflow_bodymealTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateVarSalary(Expression<Func<string>> bodyid, Expression<Func<double>> bodymoney = null, Expression<Func<string>> bodyremark = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodymoney = WorkflowExpression.Compile(bodymoney, nameof(bodymoney), required: false);
            var __workflow_bodyremark = WorkflowExpression.Compile(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/payroll/updateVarSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodymoney != null)
                {
                    body["money"] = ExpressionConverter.ConvertO(__workflow_bodymoney);
                    bodypropCount++;
                }

                if (__workflow_bodyremark != null)
                {
                    body["remark"] = ExpressionConverter.ConvertO(__workflow_bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        public IBodyWorkflowAction<ResultBoolean> UpdateWorkLocation(Expression<Func<string>> bodyid, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyregion = null, Expression<Func<string>> bodyattendanceAddressCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyareaCode = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodyattendanceAddressCode = WorkflowExpression.Compile(bodyattendanceAddressCode, nameof(bodyattendanceAddressCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyareaCode = WorkflowExpression.Compile(bodyareaCode, nameof(bodyareaCode), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v2/workLocation/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodyattendanceAddressCode != null)
                {
                    body["attendanceAddressCode"] = ExpressionConverter.ConvertO(__workflow_bodyattendanceAddressCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyareaCode != null)
                {
                    body["areaCode"] = ExpressionConverter.ConvertO(__workflow_bodyareaCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
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
