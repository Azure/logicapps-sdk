//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workstemhk
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkstemhkActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_001addFixedSalaryData))]
        public IBodyWorkflowAction<ResultBoolean> _001addFixedSalaryData([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodypayrollItemId, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<double> bodytotalLimitAmount = null, [WorkflowExpression] Func<double> bodypaidAmount = null, [WorkflowExpression] Func<double> bodysurplusAmount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_001addFixedSalaryData(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodypayrollItemId, WorkflowExpression<double> bodymoney = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<double> bodytotalLimitAmount = null, WorkflowExpression<double> bodypaidAmount = null, WorkflowExpression<double> bodysurplusAmount = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodypayrollItemId, nameof(bodypayrollItemId), required: true);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodytotalLimitAmount, nameof(bodytotalLimitAmount), required: false);
            WorkflowExpression.Validate(bodypaidAmount, nameof(bodypaidAmount), required: false);
            WorkflowExpression.Validate(bodysurplusAmount, nameof(bodysurplusAmount), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
        [WorkflowExpressionFactory(nameof(__Build_002deleteFixedSalaryDataById))]
        public IBodyWorkflowAction<ResultBoolean> _002deleteFixedSalaryDataById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_002deleteFixedSalaryDataById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteFixedSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
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
        [WorkflowExpressionFactory(nameof(__Build_003getUserInfoById))]
        public IBodyWorkflowAction<ResultV3SysEnterpriseUserResp> _003getUserInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3SysEnterpriseUserResp> __Build_003getUserInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3SysEnterpriseUserResp>(() =>
            {
                var apiCallPath = "/v3/company/getUserInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3SysEnterpriseUserResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_003updateFixedSalaryDataById))]
        public IBodyWorkflowAction<ResultBoolean> _003updateFixedSalaryDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodypayrollItemId = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<double> bodytotalLimitAmount = null, [WorkflowExpression] Func<double> bodypaidAmount = null, [WorkflowExpression] Func<double> bodysurplusAmount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_003updateFixedSalaryDataById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodypayrollItemId = null, WorkflowExpression<double> bodymoney = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<double> bodytotalLimitAmount = null, WorkflowExpression<double> bodypaidAmount = null, WorkflowExpression<double> bodysurplusAmount = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodypayrollItemId, nameof(bodypayrollItemId), required: false);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodytotalLimitAmount, nameof(bodytotalLimitAmount), required: false);
            WorkflowExpression.Validate(bodypaidAmount, nameof(bodypaidAmount), required: false);
            WorkflowExpression.Validate(bodysurplusAmount, nameof(bodysurplusAmount), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_004addLocationInfo))]
        public IBodyWorkflowAction<ResultBoolean> _004addLocationInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<double> bodylongitude, [WorkflowExpression] Func<double> bodylatitude, [WorkflowExpression] Func<string> bodyareaCode, [WorkflowExpression] Func<int> bodyregion = null, [WorkflowExpression] Func<bool> bodyisEnableGps = null, [WorkflowExpression] Func<bool> bodyisEnableBluetooth = null, [WorkflowExpression] Func<string> bodyattendanceAddressCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymapType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_004addLocationInfo(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyaddress, WorkflowExpression<double> bodylongitude, WorkflowExpression<double> bodylatitude, WorkflowExpression<string> bodyareaCode, WorkflowExpression<int> bodyregion = null, WorkflowExpression<bool> bodyisEnableGps = null, WorkflowExpression<bool> bodyisEnableBluetooth = null, WorkflowExpression<string> bodyattendanceAddressCode = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymapType = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: true);
            WorkflowExpression.Validate(bodylongitude, nameof(bodylongitude), required: true);
            WorkflowExpression.Validate(bodylatitude, nameof(bodylatitude), required: true);
            WorkflowExpression.Validate(bodyareaCode, nameof(bodyareaCode), required: true);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            WorkflowExpression.Validate(bodyisEnableGps, nameof(bodyisEnableGps), required: false);
            WorkflowExpression.Validate(bodyisEnableBluetooth, nameof(bodyisEnableBluetooth), required: false);
            WorkflowExpression.Validate(bodyattendanceAddressCode, nameof(bodyattendanceAddressCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymapType, nameof(bodymapType), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_004getFixedSalaryDataByEmployeeId))]
        public IBodyWorkflowAction<ResultListV3PayrollFixedResp> _004getFixedSalaryDataByEmployeeId([WorkflowExpression] Func<string> employeeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultListV3PayrollFixedResp> __Build_004getFixedSalaryDataByEmployeeId(WorkflowExpression<string> employeeId)
        {
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: true);
            return new DeferredBodyAction<ResultListV3PayrollFixedResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getFixedSalaryDataByEmployeeId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
                return new ApiConnectionAction<ResultListV3PayrollFixedResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_005addVariableSalaryData))]
        public IBodyWorkflowAction<ResultBoolean> _005addVariableSalaryData([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodypayrollItemId, [WorkflowExpression] Func<double> bodymoney, [WorkflowExpression] Func<string> bodypayrollDate, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodydataType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_005addVariableSalaryData(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodypayrollItemId, WorkflowExpression<double> bodymoney, WorkflowExpression<string> bodypayrollDate, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodydataType = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodypayrollItemId, nameof(bodypayrollItemId), required: true);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: true);
            WorkflowExpression.Validate(bodypayrollDate, nameof(bodypayrollDate), required: true);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodydataType, nameof(bodydataType), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_005deleteLocationById))]
        public IBodyWorkflowAction<ResultBoolean> _005deleteLocationById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_005deleteLocationById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteLocationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_006deleteVariableSalaryDataById))]
        public IBodyWorkflowAction<ResultBoolean> _006deleteVariableSalaryDataById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_006deleteVariableSalaryDataById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteVariableSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_006updateLocationById))]
        public IBodyWorkflowAction<ResultBoolean> _006updateLocationById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<double> bodylongitude = null, [WorkflowExpression] Func<double> bodylatitude = null, [WorkflowExpression] Func<int> bodyregion = null, [WorkflowExpression] Func<bool> bodyisEnableGps = null, [WorkflowExpression] Func<bool> bodyisEnableBluetooth = null, [WorkflowExpression] Func<string> bodyattendanceAddressCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymapType = null, [WorkflowExpression] Func<string> bodyareaCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_006updateLocationById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<double> bodylongitude = null, WorkflowExpression<double> bodylatitude = null, WorkflowExpression<int> bodyregion = null, WorkflowExpression<bool> bodyisEnableGps = null, WorkflowExpression<bool> bodyisEnableBluetooth = null, WorkflowExpression<string> bodyattendanceAddressCode = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymapType = null, WorkflowExpression<string> bodyareaCode = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodylongitude, nameof(bodylongitude), required: false);
            WorkflowExpression.Validate(bodylatitude, nameof(bodylatitude), required: false);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            WorkflowExpression.Validate(bodyisEnableGps, nameof(bodyisEnableGps), required: false);
            WorkflowExpression.Validate(bodyisEnableBluetooth, nameof(bodyisEnableBluetooth), required: false);
            WorkflowExpression.Validate(bodyattendanceAddressCode, nameof(bodyattendanceAddressCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymapType, nameof(bodymapType), required: false);
            WorkflowExpression.Validate(bodyareaCode, nameof(bodyareaCode), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_007getLocationList))]
        public IBodyWorkflowAction<ResultIPageV3AttAddressResp> _007getLocationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3AttAddressResp> __Build_007getLocationList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3AttAddressResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_007updateVariableSalaryDataById))]
        public IBodyWorkflowAction<ResultBoolean> _007updateVariableSalaryDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_007updateVariableSalaryDataById(WorkflowExpression<string> bodyid, WorkflowExpression<double> bodymoney = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_008getLocationInfoById))]
        public IBodyWorkflowAction<ResultV3AttAddressResp> _008getLocationInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3AttAddressResp> __Build_008getLocationInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3AttAddressResp>(() =>
            {
                var apiCallPath = "/v3/company/getLocationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3AttAddressResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_008getVariableSalaryDataList))]
        public IBodyWorkflowAction<ResultIPageV3PayrollNonFixedResp> _008getVariableSalaryDataList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> payrollDateFilter = null, [WorkflowExpression] Func<string> moneyFilter = null, [WorkflowExpression] Func<string> payrollItemIdFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> bizLabelIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3PayrollNonFixedResp> __Build_008getVariableSalaryDataList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> hireTypeFilter = null, WorkflowExpression<string> payrollDateFilter = null, WorkflowExpression<string> moneyFilter = null, WorkflowExpression<string> payrollItemIdFilter = null, WorkflowExpression<string> calculateSalaryTypeFilter = null, WorkflowExpression<string> bizLabelIds = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(hireTypeFilter, nameof(hireTypeFilter), required: false);
            WorkflowExpression.Validate(payrollDateFilter, nameof(payrollDateFilter), required: false);
            WorkflowExpression.Validate(moneyFilter, nameof(moneyFilter), required: false);
            WorkflowExpression.Validate(payrollItemIdFilter, nameof(payrollItemIdFilter), required: false);
            WorkflowExpression.Validate(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            WorkflowExpression.Validate(bizLabelIds, nameof(bizLabelIds), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollNonFixedResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_009addExternalSalaryData))]
        public IBodyWorkflowAction<ResultBoolean> _009addExternalSalaryData([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodybusinessSalaryItemId, [WorkflowExpression] Func<double> bodymoney, [WorkflowExpression] Func<string> bodyoccurrenceDate, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_009addExternalSalaryData(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodybusinessSalaryItemId, WorkflowExpression<double> bodymoney, WorkflowExpression<string> bodyoccurrenceDate, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodyexpirationDate = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodybusinessSalaryItemId, nameof(bodybusinessSalaryItemId), required: true);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: true);
            WorkflowExpression.Validate(bodyoccurrenceDate, nameof(bodyoccurrenceDate), required: true);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_009getLocationAttendanceRulesById))]
        public IBodyWorkflowAction<ResultV3AttRuleResp> _009getLocationAttendanceRulesById([WorkflowExpression] Func<string> workLocationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3AttRuleResp> __Build_009getLocationAttendanceRulesById(WorkflowExpression<string> workLocationId)
        {
            WorkflowExpression.Validate(workLocationId, nameof(workLocationId), required: true);
            return new DeferredBodyAction<ResultV3AttRuleResp>(() =>
            {
                var apiCallPath = "/v3/company/getLocationAttendanceRulesById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workLocationId"] = ExpressionConverter.Convert(workLocationId);
                return new ApiConnectionAction<ResultV3AttRuleResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_010addDepartmentInfo))]
        public IBodyWorkflowAction<ResultBoolean> _010addDepartmentInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydepartmentCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_010addDepartmentInfo(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodydepartmentCode = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydepartmentCode, nameof(bodydepartmentCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_010deleteExternalSalaryDataById))]
        public IBodyWorkflowAction<ResultBoolean> _010deleteExternalSalaryDataById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_010deleteExternalSalaryDataById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteExternalSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_011deleteDepartmentById))]
        public IBodyWorkflowAction<ResultBoolean> _011deleteDepartmentById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_011deleteDepartmentById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteDepartmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_011updateExternalSalaryDataById))]
        public IBodyWorkflowAction<ResultBoolean> _011updateExternalSalaryDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyemployeeId = null, [WorkflowExpression] Func<string> bodybusinessSalaryItemId = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyoccurrenceDate = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_011updateExternalSalaryDataById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyemployeeId = null, WorkflowExpression<string> bodybusinessSalaryItemId = null, WorkflowExpression<double> bodymoney = null, WorkflowExpression<string> bodyoccurrenceDate = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodyexpirationDate = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: false);
            WorkflowExpression.Validate(bodybusinessSalaryItemId, nameof(bodybusinessSalaryItemId), required: false);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: false);
            WorkflowExpression.Validate(bodyoccurrenceDate, nameof(bodyoccurrenceDate), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_012getExternalSalaryDataList))]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayrollResp> _012getExternalSalaryDataList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> businessSalaryItemFilter = null, [WorkflowExpression] Func<string> occurrenceDateFilter = null, [WorkflowExpression] Func<string> moneyFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> labelFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayrollResp> __Build_012getExternalSalaryDataList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> hireTypeFilter = null, WorkflowExpression<string> businessSalaryItemFilter = null, WorkflowExpression<string> occurrenceDateFilter = null, WorkflowExpression<string> moneyFilter = null, WorkflowExpression<string> calculateSalaryTypeFilter = null, WorkflowExpression<string> labelFilter = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(hireTypeFilter, nameof(hireTypeFilter), required: false);
            WorkflowExpression.Validate(businessSalaryItemFilter, nameof(businessSalaryItemFilter), required: false);
            WorkflowExpression.Validate(occurrenceDateFilter, nameof(occurrenceDateFilter), required: false);
            WorkflowExpression.Validate(moneyFilter, nameof(moneyFilter), required: false);
            WorkflowExpression.Validate(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            WorkflowExpression.Validate(labelFilter, nameof(labelFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3ExternalPayrollResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_012updateDepartmentById))]
        public IBodyWorkflowAction<ResultBoolean> _012updateDepartmentById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydepartmentCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_012updateDepartmentById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodydepartmentCode = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodydepartmentCode, nameof(bodydepartmentCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_013getDepartmentList))]
        public IBodyWorkflowAction<ResultIPageV3DepartmentResp> _013getDepartmentList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3DepartmentResp> __Build_013getDepartmentList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3DepartmentResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_013getPayrollRunList))]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanResp> _013getPayrollRunList([WorkflowExpression] Func<string> status, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanResp> __Build_013getPayrollRunList(WorkflowExpression<string> status, WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollPlanResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_014addPositionInfo))]
        public IBodyWorkflowAction<ResultBoolean> _014addPositionInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_014addPositionInfo(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodypositionCode = null, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodypositionCode, nameof(bodypositionCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_014getPayrollRunDataList))]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanDetailResp> _014getPayrollRunDataList([WorkflowExpression] Func<string> planId, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanDetailResp> __Build_014getPayrollRunDataList(WorkflowExpression<string> planId, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(planId, nameof(planId), required: true);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollPlanDetailResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_015deletePositionById))]
        public IBodyWorkflowAction<ResultBoolean> _015deletePositionById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_015deletePositionById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deletePositionById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_015getPayrollDetailsInfoById))]
        public IBodyWorkflowAction<ResultListV3PayrollPlanDetailResp> _015getPayrollDetailsInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultListV3PayrollPlanDetailResp> __Build_015getPayrollDetailsInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultListV3PayrollPlanDetailResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultListV3PayrollPlanDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_016getPayrollPolicyList))]
        public IBodyWorkflowAction<ResultIPageV3PayrollRegResp> _016getPayrollPolicyList([WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> q = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3PayrollRegResp> __Build_016getPayrollPolicyList(WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> q = null)
        {
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollRegResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_016updatePositionById))]
        public IBodyWorkflowAction<ResultBoolean> _016updatePositionById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_016updatePositionById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodypositionCode = null, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodypositionCode, nameof(bodypositionCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_017getPayrollPolicyInfoById))]
        public IBodyWorkflowAction<ResultV3PayrollRegResp> _017getPayrollPolicyInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3PayrollRegResp> __Build_017getPayrollPolicyInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3PayrollRegResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayrollPolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3PayrollRegResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_017getPositionList))]
        public IBodyWorkflowAction<ResultIPageV3PositionResp> _017getPositionList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3PositionResp> __Build_017getPositionList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3PositionResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_018addCostCenterInfo))]
        public IBodyWorkflowAction<ResultBoolean> _018addCostCenterInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_018addCostCenterInfo(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodycostCenterCode = null, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_018getPayItemList))]
        public IBodyWorkflowAction<ResultIPageV3PayrollItemResp> _018getPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> nameFilter = null, [WorkflowExpression] Func<string> paymentTypeFilter = null, [WorkflowExpression] Func<string> payrollItemTypeId = null, [WorkflowExpression] Func<string> statusFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3PayrollItemResp> __Build_018getPayItemList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> nameFilter = null, WorkflowExpression<string> paymentTypeFilter = null, WorkflowExpression<string> payrollItemTypeId = null, WorkflowExpression<string> statusFilter = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(nameFilter, nameof(nameFilter), required: false);
            WorkflowExpression.Validate(paymentTypeFilter, nameof(paymentTypeFilter), required: false);
            WorkflowExpression.Validate(payrollItemTypeId, nameof(payrollItemTypeId), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3PayrollItemResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_019deleteCostCenterById))]
        public IBodyWorkflowAction<ResultBoolean> _019deleteCostCenterById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_019deleteCostCenterById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteCostCenterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_019getPayItemInfoById))]
        public IBodyWorkflowAction<ResultV3PayrollItemResp> _019getPayItemInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3PayrollItemResp> __Build_019getPayItemInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3PayrollItemResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3PayrollItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_01addEmployeeInfo))]
        public IBodyWorkflowAction<ResultV3AddEmployeeResp> _01addEmployeeInfo([WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodyenglishName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyemployeeStatus = null, [WorkflowExpression] Func<string> bodysex = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyidentityCard = null, [WorkflowExpression] Func<string> bodychineseName = null, [WorkflowExpression] Func<string> bodysurnameEnglish = null, [WorkflowExpression] Func<string> bodypersonalNameEnglish = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodyemergencyContactName = null, [WorkflowExpression] Func<string> bodyemergencyContactRelation = null, [WorkflowExpression] Func<string> bodyemergencyContactPhone = null, [WorkflowExpression] Func<string> bodybankCode = null, [WorkflowExpression] Func<string> bodybankBranchNumber = null, [WorkflowExpression] Func<string> bodybankAccountNo = null, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodydate1 = null, [WorkflowExpression] Func<string> bodydate2 = null, [WorkflowExpression] Func<string> bodydate3 = null, [WorkflowExpression] Func<string> bodydate4 = null, [WorkflowExpression] Func<string> bodytext1 = null, [WorkflowExpression] Func<string> bodytext2 = null, [WorkflowExpression] Func<string> bodytext3 = null, [WorkflowExpression] Func<string> bodytext4 = null, [WorkflowExpression] Func<string> bodytext5 = null, [WorkflowExpression] Func<string> bodytext6 = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodymobileCardCalType = null, [WorkflowExpression] Func<string> bodyregularType = null, [WorkflowExpression] Func<string> bodyinsurePlanName = null, [WorkflowExpression] Func<string> bodybizLabelIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3AddEmployeeResp> __Build_01addEmployeeInfo(WorkflowExpression<string> bodyentryDate, WorkflowExpression<string> bodyenglishName, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyemployeeStatus = null, WorkflowExpression<string> bodysex = null, WorkflowExpression<string> bodynationality = null, WorkflowExpression<string> bodymaritalStatus = null, WorkflowExpression<string> bodycountryCode = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodycalculateSalaryType = null, WorkflowExpression<string> bodyworkDate = null, WorkflowExpression<double> bodybasicPay = null, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyidentityCard = null, WorkflowExpression<string> bodychineseName = null, WorkflowExpression<string> bodysurnameEnglish = null, WorkflowExpression<string> bodypersonalNameEnglish = null, WorkflowExpression<string> bodybirthday = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodyemergencyContactName = null, WorkflowExpression<string> bodyemergencyContactRelation = null, WorkflowExpression<string> bodyemergencyContactPhone = null, WorkflowExpression<string> bodybankCode = null, WorkflowExpression<string> bodybankBranchNumber = null, WorkflowExpression<string> bodybankAccountNo = null, WorkflowExpression<string> bodyconfirmationDate = null, WorkflowExpression<string> bodydate1 = null, WorkflowExpression<string> bodydate2 = null, WorkflowExpression<string> bodydate3 = null, WorkflowExpression<string> bodydate4 = null, WorkflowExpression<string> bodytext1 = null, WorkflowExpression<string> bodytext2 = null, WorkflowExpression<string> bodytext3 = null, WorkflowExpression<string> bodytext4 = null, WorkflowExpression<string> bodytext5 = null, WorkflowExpression<string> bodytext6 = null, WorkflowExpression<string> bodydirectSupervisorId = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodypositionId = null, WorkflowExpression<string> bodyhireType = null, WorkflowExpression<string> bodypayrollRegulationId = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyattendCalculationId = null, WorkflowExpression<string> bodymobileCardCalType = null, WorkflowExpression<string> bodyregularType = null, WorkflowExpression<string> bodyinsurePlanName = null, WorkflowExpression<string> bodybizLabelIds = null)
        {
            WorkflowExpression.Validate(bodyentryDate, nameof(bodyentryDate), required: true);
            WorkflowExpression.Validate(bodyenglishName, nameof(bodyenglishName), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyemployeeStatus, nameof(bodyemployeeStatus), required: false);
            WorkflowExpression.Validate(bodysex, nameof(bodysex), required: false);
            WorkflowExpression.Validate(bodynationality, nameof(bodynationality), required: false);
            WorkflowExpression.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            WorkflowExpression.Validate(bodycountryCode, nameof(bodycountryCode), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            WorkflowExpression.Validate(bodyworkDate, nameof(bodyworkDate), required: false);
            WorkflowExpression.Validate(bodybasicPay, nameof(bodybasicPay), required: false);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyidentityCard, nameof(bodyidentityCard), required: false);
            WorkflowExpression.Validate(bodychineseName, nameof(bodychineseName), required: false);
            WorkflowExpression.Validate(bodysurnameEnglish, nameof(bodysurnameEnglish), required: false);
            WorkflowExpression.Validate(bodypersonalNameEnglish, nameof(bodypersonalNameEnglish), required: false);
            WorkflowExpression.Validate(bodybirthday, nameof(bodybirthday), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            WorkflowExpression.Validate(bodyemergencyContactRelation, nameof(bodyemergencyContactRelation), required: false);
            WorkflowExpression.Validate(bodyemergencyContactPhone, nameof(bodyemergencyContactPhone), required: false);
            WorkflowExpression.Validate(bodybankCode, nameof(bodybankCode), required: false);
            WorkflowExpression.Validate(bodybankBranchNumber, nameof(bodybankBranchNumber), required: false);
            WorkflowExpression.Validate(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            WorkflowExpression.Validate(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            WorkflowExpression.Validate(bodydate1, nameof(bodydate1), required: false);
            WorkflowExpression.Validate(bodydate2, nameof(bodydate2), required: false);
            WorkflowExpression.Validate(bodydate3, nameof(bodydate3), required: false);
            WorkflowExpression.Validate(bodydate4, nameof(bodydate4), required: false);
            WorkflowExpression.Validate(bodytext1, nameof(bodytext1), required: false);
            WorkflowExpression.Validate(bodytext2, nameof(bodytext2), required: false);
            WorkflowExpression.Validate(bodytext3, nameof(bodytext3), required: false);
            WorkflowExpression.Validate(bodytext4, nameof(bodytext4), required: false);
            WorkflowExpression.Validate(bodytext5, nameof(bodytext5), required: false);
            WorkflowExpression.Validate(bodytext6, nameof(bodytext6), required: false);
            WorkflowExpression.Validate(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodypositionId, nameof(bodypositionId), required: false);
            WorkflowExpression.Validate(bodyhireType, nameof(bodyhireType), required: false);
            WorkflowExpression.Validate(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            WorkflowExpression.Validate(bodymobileCardCalType, nameof(bodymobileCardCalType), required: false);
            WorkflowExpression.Validate(bodyregularType, nameof(bodyregularType), required: false);
            WorkflowExpression.Validate(bodyinsurePlanName, nameof(bodyinsurePlanName), required: false);
            WorkflowExpression.Validate(bodybizLabelIds, nameof(bodybizLabelIds), required: false);
            return new DeferredBodyAction<ResultV3AddEmployeeResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_01addLeaveBalanceAdjustInfo))]
        public IBodyWorkflowAction<ResultBoolean> _01addLeaveBalanceAdjustInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyholidayType, [WorkflowExpression] Func<string> bodyoccurrenceTime, [WorkflowExpression] Func<string> bodycause, [WorkflowExpression] Func<string> bodyadjust)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_01addLeaveBalanceAdjustInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyholidayType, WorkflowExpression<string> bodyoccurrenceTime, WorkflowExpression<string> bodycause, WorkflowExpression<string> bodyadjust)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyholidayType, nameof(bodyholidayType), required: true);
            WorkflowExpression.Validate(bodyoccurrenceTime, nameof(bodyoccurrenceTime), required: true);
            WorkflowExpression.Validate(bodycause, nameof(bodycause), required: true);
            WorkflowExpression.Validate(bodyadjust, nameof(bodyadjust), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_01addRosterInfo))]
        public IBodyWorkflowAction<ResultBoolean> _01addRosterInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyattendDay, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodyshiftTemplateId = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<double> bodyhourlyRate = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<double> bodytierRate = null, [WorkflowExpression] Func<double> bodyscheduledAmount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_01addRosterInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyattendDay, WorkflowExpression<string> bodyshiftIn, WorkflowExpression<string> bodyshiftOff, WorkflowExpression<string> bodyshiftTemplateId = null, WorkflowExpression<string> bodyaddressCardId = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyshiftStatus = null, WorkflowExpression<string> bodydateType = null, WorkflowExpression<string> bodyattendanceItemId = null, WorkflowExpression<double> bodyhourlyRate = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<double> bodytierRate = null, WorkflowExpression<double> bodyscheduledAmount = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyattendDay, nameof(bodyattendDay), required: true);
            WorkflowExpression.Validate(bodyshiftIn, nameof(bodyshiftIn), required: true);
            WorkflowExpression.Validate(bodyshiftOff, nameof(bodyshiftOff), required: true);
            WorkflowExpression.Validate(bodyshiftTemplateId, nameof(bodyshiftTemplateId), required: false);
            WorkflowExpression.Validate(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            WorkflowExpression.Validate(bodydateType, nameof(bodydateType), required: false);
            WorkflowExpression.Validate(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            WorkflowExpression.Validate(bodyhourlyRate, nameof(bodyhourlyRate), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodytierRate, nameof(bodytierRate), required: false);
            WorkflowExpression.Validate(bodyscheduledAmount, nameof(bodyscheduledAmount), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_01attendanceSummaryCalculate))]
        public IBodyWorkflowAction<ResultV3CalAttendanceResp> _01attendanceSummaryCalculate([WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<string[]> bodyemployeeIds = null, [WorkflowExpression] Func<string[]> bodydepartmentIds = null, [WorkflowExpression] Func<string[]> bodypositionIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3CalAttendanceResp> __Build_01attendanceSummaryCalculate(WorkflowExpression<string> bodystartDate, WorkflowExpression<string> bodyendDate, WorkflowExpression<string[]> bodyemployeeIds = null, WorkflowExpression<string[]> bodydepartmentIds = null, WorkflowExpression<string[]> bodypositionIds = null)
        {
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            WorkflowExpression.Validate(bodyemployeeIds, nameof(bodyemployeeIds), required: false);
            WorkflowExpression.Validate(bodydepartmentIds, nameof(bodydepartmentIds), required: false);
            WorkflowExpression.Validate(bodypositionIds, nameof(bodypositionIds), required: false);
            return new DeferredBodyAction<ResultV3CalAttendanceResp>(() =>
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
        [WorkflowExpressionFactory(nameof(__Build_01getExpenseTypeList))]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementTypeResp> _01getExpenseTypeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementTypeResp> __Build_01getExpenseTypeList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizReimbursementTypeResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_020getExternalPayItemList))]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayItemResp> _020getExternalPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayItemResp> __Build_020getExternalPayItemList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ExternalPayItemResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_020updateCostCenterById))]
        public IBodyWorkflowAction<ResultBoolean> _020updateCostCenterById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_020updateCostCenterById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodycostCenterCode = null, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_021getCostCenterList))]
        public IBodyWorkflowAction<ResultIPageV3CostCenterResp> _021getCostCenterList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3CostCenterResp> __Build_021getCostCenterList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3CostCenterResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_021getExternalPayItemInfoById))]
        public IBodyWorkflowAction<ResultV3ExternalPayItemResp> _021getExternalPayItemInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3ExternalPayItemResp> __Build_021getExternalPayItemInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3ExternalPayItemResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getExternalPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3ExternalPayItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_022addTagInfo))]
        public IBodyWorkflowAction<ResultBoolean> _022addTagInfo([WorkflowExpression] Func<string> bodylabelName, [WorkflowExpression] Func<string> bodylabelCode = null, [WorkflowExpression] Func<int> bodylabelStatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_022addTagInfo(WorkflowExpression<string> bodylabelName, WorkflowExpression<string> bodylabelCode = null, WorkflowExpression<int> bodylabelStatus = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodylabelName, nameof(bodylabelName), required: true);
            WorkflowExpression.Validate(bodylabelCode, nameof(bodylabelCode), required: false);
            WorkflowExpression.Validate(bodylabelStatus, nameof(bodylabelStatus), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_022addWorkPatternInfo))]
        public IBodyWorkflowAction<ResultBoolean> _022addWorkPatternInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyworkHoursForDay, [WorkflowExpression] Func<double> bodyworkHoursForWeek, [WorkflowExpression] Func<double> bodyworkHoursForYear, [WorkflowExpression] Func<double> bodytotalHours, [WorkflowExpression] Func<string> bodycycleType, [WorkflowExpression] Func<string> bodyadvancedSetting = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<string> bodyfte = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodysalaryCalculationStyle = null, [WorkflowExpression] Func<int> bodyworkTime = null, [WorkflowExpression] Func<string> bodydoubleWeekBaseDate = null, [WorkflowExpression] Func<string> bodyweekSalaryType = null, [WorkflowExpression] Func<int> bodyisThisWeek = null, [WorkflowExpression] Func<V3TermsSettingInsert[]> bodysettingList = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_022addWorkPatternInfo(WorkflowExpression<string> bodyname, WorkflowExpression<double> bodyworkHoursForDay, WorkflowExpression<double> bodyworkHoursForWeek, WorkflowExpression<double> bodyworkHoursForYear, WorkflowExpression<double> bodytotalHours, WorkflowExpression<string> bodycycleType, WorkflowExpression<string> bodyadvancedSetting = null, WorkflowExpression<string> bodynumber = null, WorkflowExpression<string> bodyfte = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<int> bodysalaryCalculationStyle = null, WorkflowExpression<int> bodyworkTime = null, WorkflowExpression<string> bodydoubleWeekBaseDate = null, WorkflowExpression<string> bodyweekSalaryType = null, WorkflowExpression<int> bodyisThisWeek = null, WorkflowExpression<V3TermsSettingInsert[]> bodysettingList = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyworkHoursForDay, nameof(bodyworkHoursForDay), required: true);
            WorkflowExpression.Validate(bodyworkHoursForWeek, nameof(bodyworkHoursForWeek), required: true);
            WorkflowExpression.Validate(bodyworkHoursForYear, nameof(bodyworkHoursForYear), required: true);
            WorkflowExpression.Validate(bodytotalHours, nameof(bodytotalHours), required: true);
            WorkflowExpression.Validate(bodycycleType, nameof(bodycycleType), required: true);
            WorkflowExpression.Validate(bodyadvancedSetting, nameof(bodyadvancedSetting), required: false);
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: false);
            WorkflowExpression.Validate(bodyfte, nameof(bodyfte), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodysalaryCalculationStyle, nameof(bodysalaryCalculationStyle), required: false);
            WorkflowExpression.Validate(bodyworkTime, nameof(bodyworkTime), required: false);
            WorkflowExpression.Validate(bodydoubleWeekBaseDate, nameof(bodydoubleWeekBaseDate), required: false);
            WorkflowExpression.Validate(bodyweekSalaryType, nameof(bodyweekSalaryType), required: false);
            WorkflowExpression.Validate(bodyisThisWeek, nameof(bodyisThisWeek), required: false);
            WorkflowExpression.Validate(bodysettingList, nameof(bodysettingList), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_023deleteTagById))]
        public IBodyWorkflowAction<ResultBoolean> _023deleteTagById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_023deleteTagById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/company/deleteTagById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_023updateWorkPatternById))]
        public IBodyWorkflowAction<ResultBoolean> _023updateWorkPatternById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyadvancedSetting = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<double> bodyworkHoursForDay = null, [WorkflowExpression] Func<double> bodyworkHoursForWeek = null, [WorkflowExpression] Func<double> bodyworkHoursForYear = null, [WorkflowExpression] Func<double> bodytotalHours = null, [WorkflowExpression] Func<string> bodycycleType = null, [WorkflowExpression] Func<string> bodyfte = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodysalaryCalculationStyle = null, [WorkflowExpression] Func<int> bodyworkTime = null, [WorkflowExpression] Func<string> bodydoubleWeekBaseDate = null, [WorkflowExpression] Func<string> bodyweekSalaryType = null, [WorkflowExpression] Func<int> bodyisThisWeek = null, [WorkflowExpression] Func<string> bodytermsWorkDefaultId = null, [WorkflowExpression] Func<V3TermsSettingUpdate[]> bodysettingList = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_023updateWorkPatternById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyadvancedSetting = null, WorkflowExpression<string> bodynumber = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<double> bodyworkHoursForDay = null, WorkflowExpression<double> bodyworkHoursForWeek = null, WorkflowExpression<double> bodyworkHoursForYear = null, WorkflowExpression<double> bodytotalHours = null, WorkflowExpression<string> bodycycleType = null, WorkflowExpression<string> bodyfte = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<int> bodysalaryCalculationStyle = null, WorkflowExpression<int> bodyworkTime = null, WorkflowExpression<string> bodydoubleWeekBaseDate = null, WorkflowExpression<string> bodyweekSalaryType = null, WorkflowExpression<int> bodyisThisWeek = null, WorkflowExpression<string> bodytermsWorkDefaultId = null, WorkflowExpression<V3TermsSettingUpdate[]> bodysettingList = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyadvancedSetting, nameof(bodyadvancedSetting), required: false);
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyworkHoursForDay, nameof(bodyworkHoursForDay), required: false);
            WorkflowExpression.Validate(bodyworkHoursForWeek, nameof(bodyworkHoursForWeek), required: false);
            WorkflowExpression.Validate(bodyworkHoursForYear, nameof(bodyworkHoursForYear), required: false);
            WorkflowExpression.Validate(bodytotalHours, nameof(bodytotalHours), required: false);
            WorkflowExpression.Validate(bodycycleType, nameof(bodycycleType), required: false);
            WorkflowExpression.Validate(bodyfte, nameof(bodyfte), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodysalaryCalculationStyle, nameof(bodysalaryCalculationStyle), required: false);
            WorkflowExpression.Validate(bodyworkTime, nameof(bodyworkTime), required: false);
            WorkflowExpression.Validate(bodydoubleWeekBaseDate, nameof(bodydoubleWeekBaseDate), required: false);
            WorkflowExpression.Validate(bodyweekSalaryType, nameof(bodyweekSalaryType), required: false);
            WorkflowExpression.Validate(bodyisThisWeek, nameof(bodyisThisWeek), required: false);
            WorkflowExpression.Validate(bodytermsWorkDefaultId, nameof(bodytermsWorkDefaultId), required: false);
            WorkflowExpression.Validate(bodysettingList, nameof(bodysettingList), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_024deleteWorkPatternById))]
        public IBodyWorkflowAction<ResultBoolean> _024deleteWorkPatternById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_024deleteWorkPatternById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/payroll/deleteWorkPatternById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_024updateTagById))]
        public IBodyWorkflowAction<ResultBoolean> _024updateTagById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylabelCode = null, [WorkflowExpression] Func<string> bodylabelName = null, [WorkflowExpression] Func<int> bodylabelStatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_024updateTagById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodylabelCode = null, WorkflowExpression<string> bodylabelName = null, WorkflowExpression<int> bodylabelStatus = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodylabelCode, nameof(bodylabelCode), required: false);
            WorkflowExpression.Validate(bodylabelName, nameof(bodylabelName), required: false);
            WorkflowExpression.Validate(bodylabelStatus, nameof(bodylabelStatus), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_025getTagList))]
        public IBodyWorkflowAction<ResultIPageV3LabelResp> _025getTagList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LabelResp> __Build_025getTagList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LabelResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_025getWorkPatternList))]
        public IBodyWorkflowAction<ResultIPageV3WorkPatternSummaryResp> _025getWorkPatternList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3WorkPatternSummaryResp> __Build_025getWorkPatternList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3WorkPatternSummaryResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_026getDeviceList))]
        public IBodyWorkflowAction<ResultIPageV3DeviceResp> _026getDeviceList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3DeviceResp> __Build_026getDeviceList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3DeviceResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_026getWorkPatternInfoById))]
        public IBodyWorkflowAction<ResultV3WorkPatternResp> _026getWorkPatternInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3WorkPatternResp> __Build_026getWorkPatternInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3WorkPatternResp>(() =>
            {
                var apiCallPath = "/v3/payroll/getWorkPatternInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3WorkPatternResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_02addExpenseApplicationInfo))]
        public IBodyWorkflowAction<ResultV3BizReimbursementInsertResp> _02addExpenseApplicationInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyreimbursementType, [WorkflowExpression] Func<string> bodyreimbursementDate, [WorkflowExpression] Func<string> bodyreimbursementName, [WorkflowExpression] Func<double> bodyamount, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3BizReimbursementInsertResp> __Build_02addExpenseApplicationInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyreimbursementType, WorkflowExpression<string> bodyreimbursementDate, WorkflowExpression<string> bodyreimbursementName, WorkflowExpression<double> bodyamount, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyreimbursementType, nameof(bodyreimbursementType), required: true);
            WorkflowExpression.Validate(bodyreimbursementDate, nameof(bodyreimbursementDate), required: true);
            WorkflowExpression.Validate(bodyreimbursementName, nameof(bodyreimbursementName), required: true);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: true);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3BizReimbursementInsertResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_02batchSaveRosterInfo))]
        public IBodyWorkflowAction<ResultBoolean> _02batchSaveRosterInfo([WorkflowExpression] Func<string[]> bodyemployeeIds, [WorkflowExpression] Func<string[]> bodydates, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodyshiftTemplateId = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<double> bodyhourlyRate = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<bool> bodyreplaceOriginal = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_02batchSaveRosterInfo(WorkflowExpression<string[]> bodyemployeeIds, WorkflowExpression<string[]> bodydates, WorkflowExpression<string> bodyshiftIn, WorkflowExpression<string> bodyshiftOff, WorkflowExpression<string> bodyshiftTemplateId = null, WorkflowExpression<string> bodyaddressCardId = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyshiftStatus = null, WorkflowExpression<string> bodydateType = null, WorkflowExpression<string> bodyattendanceItemId = null, WorkflowExpression<double> bodyhourlyRate = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<bool> bodyreplaceOriginal = null)
        {
            WorkflowExpression.Validate(bodyemployeeIds, nameof(bodyemployeeIds), required: true);
            WorkflowExpression.Validate(bodydates, nameof(bodydates), required: true);
            WorkflowExpression.Validate(bodyshiftIn, nameof(bodyshiftIn), required: true);
            WorkflowExpression.Validate(bodyshiftOff, nameof(bodyshiftOff), required: true);
            WorkflowExpression.Validate(bodyshiftTemplateId, nameof(bodyshiftTemplateId), required: false);
            WorkflowExpression.Validate(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            WorkflowExpression.Validate(bodydateType, nameof(bodydateType), required: false);
            WorkflowExpression.Validate(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            WorkflowExpression.Validate(bodyhourlyRate, nameof(bodyhourlyRate), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyreplaceOriginal, nameof(bodyreplaceOriginal), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_02deleteEmployeeById))]
        public IBodyWorkflowAction<ResultBoolean> _02deleteEmployeeById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_02deleteEmployeeById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/employee/deleteAllData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_02deleteLeaveBalanceAdjustmentById))]
        public IBodyWorkflowAction<ResultBoolean> _02deleteLeaveBalanceAdjustmentById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_02deleteLeaveBalanceAdjustmentById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/leave/deleteLeaveBalanceAdjustmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_02getAttendanceSummaryList))]
        public IBodyWorkflowAction<ResultIPageV3AttendanceListResp> _02getAttendanceSummaryList([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> unit, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> attendCalculationFilter = null, [WorkflowExpression] Func<string> employeeFilter = null, [WorkflowExpression] Func<string> labelFilter = null, [WorkflowExpression] Func<string> payrollRegulationFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> attendanceTypeFilter = null, [WorkflowExpression] Func<string> shiftTypeFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3AttendanceListResp> __Build_02getAttendanceSummaryList(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> unit, WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> departmentFilter = null, WorkflowExpression<string> positionFilter = null, WorkflowExpression<string> attendCalculationFilter = null, WorkflowExpression<string> employeeFilter = null, WorkflowExpression<string> labelFilter = null, WorkflowExpression<string> payrollRegulationFilter = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> hireTypeFilter = null, WorkflowExpression<string> calculateSalaryTypeFilter = null, WorkflowExpression<string> attendanceTypeFilter = null, WorkflowExpression<string> shiftTypeFilter = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(unit, nameof(unit), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(departmentFilter, nameof(departmentFilter), required: false);
            WorkflowExpression.Validate(positionFilter, nameof(positionFilter), required: false);
            WorkflowExpression.Validate(attendCalculationFilter, nameof(attendCalculationFilter), required: false);
            WorkflowExpression.Validate(employeeFilter, nameof(employeeFilter), required: false);
            WorkflowExpression.Validate(labelFilter, nameof(labelFilter), required: false);
            WorkflowExpression.Validate(payrollRegulationFilter, nameof(payrollRegulationFilter), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(hireTypeFilter, nameof(hireTypeFilter), required: false);
            WorkflowExpression.Validate(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            WorkflowExpression.Validate(attendanceTypeFilter, nameof(attendanceTypeFilter), required: false);
            WorkflowExpression.Validate(shiftTypeFilter, nameof(shiftTypeFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3AttendanceListResp>(() =>
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
        [WorkflowExpressionFactory(nameof(__Build_03deleteExpenseApplicationById))]
        public IBodyWorkflowAction<ResultBoolean> _03deleteExpenseApplicationById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_03deleteExpenseApplicationById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/expense/deleteExpenseApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_03deleteRosterById))]
        public IBodyWorkflowAction<ResultBoolean> _03deleteRosterById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_03deleteRosterById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteRosterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_03GetDataDictionaryDetailsInfoById))]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryItemResp> _03GetDataDictionaryDetailsInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryItemResp> __Build_03GetDataDictionaryDetailsInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultListV3BizCustomizeDictionaryItemResp>(() =>
            {
                var apiCallPath = "/v3/settings/getDataDictionaryDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_03getEmployeeDailyAttendanceList))]
        public IBodyWorkflowAction<ResultListV3AttendanceDetailListResp> _03getEmployeeDailyAttendanceList([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> attendStatusFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultListV3AttendanceDetailListResp> __Build_03getEmployeeDailyAttendanceList(WorkflowExpression<string> employeeId, WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> attendStatusFilter = null)
        {
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: true);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(attendStatusFilter, nameof(attendStatusFilter), required: false);
            return new DeferredBodyAction<ResultListV3AttendanceDetailListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_03getLeaveBalanceAdjustmentList))]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayBalanceResp> _03getLeaveBalanceAdjustmentList([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> holidayType, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayBalanceResp> __Build_03getLeaveBalanceAdjustmentList(WorkflowExpression<string> employeeId, WorkflowExpression<string> holidayType, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: true);
            WorkflowExpression.Validate(holidayType, nameof(holidayType), required: true);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveHolidayBalanceResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_03updateEmployeeById))]
        public IBodyWorkflowAction<ResultBoolean> _03updateEmployeeById([WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodyenglishName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyemployeeStatus = null, [WorkflowExpression] Func<string> bodysex = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyidentityCard = null, [WorkflowExpression] Func<string> bodychineseName = null, [WorkflowExpression] Func<string> bodysurnameEnglish = null, [WorkflowExpression] Func<string> bodypersonalNameEnglish = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodyemergencyContactName = null, [WorkflowExpression] Func<string> bodyemergencyContactRelation = null, [WorkflowExpression] Func<string> bodyemergencyContactPhone = null, [WorkflowExpression] Func<string> bodybankCode = null, [WorkflowExpression] Func<string> bodybankBranchNumber = null, [WorkflowExpression] Func<string> bodybankAccountNo = null, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodydate1 = null, [WorkflowExpression] Func<string> bodydate2 = null, [WorkflowExpression] Func<string> bodydate3 = null, [WorkflowExpression] Func<string> bodydate4 = null, [WorkflowExpression] Func<string> bodytext1 = null, [WorkflowExpression] Func<string> bodytext2 = null, [WorkflowExpression] Func<string> bodytext3 = null, [WorkflowExpression] Func<string> bodytext4 = null, [WorkflowExpression] Func<string> bodytext5 = null, [WorkflowExpression] Func<string> bodytext6 = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodymobileCardCalType = null, [WorkflowExpression] Func<string> bodyregularType = null, [WorkflowExpression] Func<string> bodyinsurePlanName = null, [WorkflowExpression] Func<string> bodybizLabelIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_03updateEmployeeById(WorkflowExpression<string> bodyentryDate, WorkflowExpression<string> bodyenglishName, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyemployeeStatus = null, WorkflowExpression<string> bodysex = null, WorkflowExpression<string> bodynationality = null, WorkflowExpression<string> bodymaritalStatus = null, WorkflowExpression<string> bodycountryCode = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodycalculateSalaryType = null, WorkflowExpression<string> bodyworkDate = null, WorkflowExpression<double> bodybasicPay = null, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyidentityCard = null, WorkflowExpression<string> bodychineseName = null, WorkflowExpression<string> bodysurnameEnglish = null, WorkflowExpression<string> bodypersonalNameEnglish = null, WorkflowExpression<string> bodybirthday = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodyemergencyContactName = null, WorkflowExpression<string> bodyemergencyContactRelation = null, WorkflowExpression<string> bodyemergencyContactPhone = null, WorkflowExpression<string> bodybankCode = null, WorkflowExpression<string> bodybankBranchNumber = null, WorkflowExpression<string> bodybankAccountNo = null, WorkflowExpression<string> bodyconfirmationDate = null, WorkflowExpression<string> bodydate1 = null, WorkflowExpression<string> bodydate2 = null, WorkflowExpression<string> bodydate3 = null, WorkflowExpression<string> bodydate4 = null, WorkflowExpression<string> bodytext1 = null, WorkflowExpression<string> bodytext2 = null, WorkflowExpression<string> bodytext3 = null, WorkflowExpression<string> bodytext4 = null, WorkflowExpression<string> bodytext5 = null, WorkflowExpression<string> bodytext6 = null, WorkflowExpression<string> bodydirectSupervisorId = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodypositionId = null, WorkflowExpression<string> bodyhireType = null, WorkflowExpression<string> bodypayrollRegulationId = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyattendCalculationId = null, WorkflowExpression<string> bodymobileCardCalType = null, WorkflowExpression<string> bodyregularType = null, WorkflowExpression<string> bodyinsurePlanName = null, WorkflowExpression<string> bodybizLabelIds = null)
        {
            WorkflowExpression.Validate(bodyentryDate, nameof(bodyentryDate), required: true);
            WorkflowExpression.Validate(bodyenglishName, nameof(bodyenglishName), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyemployeeStatus, nameof(bodyemployeeStatus), required: false);
            WorkflowExpression.Validate(bodysex, nameof(bodysex), required: false);
            WorkflowExpression.Validate(bodynationality, nameof(bodynationality), required: false);
            WorkflowExpression.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            WorkflowExpression.Validate(bodycountryCode, nameof(bodycountryCode), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            WorkflowExpression.Validate(bodyworkDate, nameof(bodyworkDate), required: false);
            WorkflowExpression.Validate(bodybasicPay, nameof(bodybasicPay), required: false);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyidentityCard, nameof(bodyidentityCard), required: false);
            WorkflowExpression.Validate(bodychineseName, nameof(bodychineseName), required: false);
            WorkflowExpression.Validate(bodysurnameEnglish, nameof(bodysurnameEnglish), required: false);
            WorkflowExpression.Validate(bodypersonalNameEnglish, nameof(bodypersonalNameEnglish), required: false);
            WorkflowExpression.Validate(bodybirthday, nameof(bodybirthday), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            WorkflowExpression.Validate(bodyemergencyContactRelation, nameof(bodyemergencyContactRelation), required: false);
            WorkflowExpression.Validate(bodyemergencyContactPhone, nameof(bodyemergencyContactPhone), required: false);
            WorkflowExpression.Validate(bodybankCode, nameof(bodybankCode), required: false);
            WorkflowExpression.Validate(bodybankBranchNumber, nameof(bodybankBranchNumber), required: false);
            WorkflowExpression.Validate(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            WorkflowExpression.Validate(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            WorkflowExpression.Validate(bodydate1, nameof(bodydate1), required: false);
            WorkflowExpression.Validate(bodydate2, nameof(bodydate2), required: false);
            WorkflowExpression.Validate(bodydate3, nameof(bodydate3), required: false);
            WorkflowExpression.Validate(bodydate4, nameof(bodydate4), required: false);
            WorkflowExpression.Validate(bodytext1, nameof(bodytext1), required: false);
            WorkflowExpression.Validate(bodytext2, nameof(bodytext2), required: false);
            WorkflowExpression.Validate(bodytext3, nameof(bodytext3), required: false);
            WorkflowExpression.Validate(bodytext4, nameof(bodytext4), required: false);
            WorkflowExpression.Validate(bodytext5, nameof(bodytext5), required: false);
            WorkflowExpression.Validate(bodytext6, nameof(bodytext6), required: false);
            WorkflowExpression.Validate(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodypositionId, nameof(bodypositionId), required: false);
            WorkflowExpression.Validate(bodyhireType, nameof(bodyhireType), required: false);
            WorkflowExpression.Validate(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            WorkflowExpression.Validate(bodymobileCardCalType, nameof(bodymobileCardCalType), required: false);
            WorkflowExpression.Validate(bodyregularType, nameof(bodyregularType), required: false);
            WorkflowExpression.Validate(bodyinsurePlanName, nameof(bodyinsurePlanName), required: false);
            WorkflowExpression.Validate(bodybizLabelIds, nameof(bodybizLabelIds), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_04addAttendanceDataInfo))]
        public IBodyWorkflowAction<ResultV3AddMobileCardResp> _04addAttendanceDataInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodymode, [WorkflowExpression] Func<string> bodycardType = null, [WorkflowExpression] Func<double> bodyactualLongitude = null, [WorkflowExpression] Func<double> bodyactualLatitude = null, [WorkflowExpression] Func<string> bodydeviceName = null, [WorkflowExpression] Func<string> bodycodeSource = null, [WorkflowExpression] Func<string> bodylocationName = null, [WorkflowExpression] Func<string> bodyworkLocationId = null, [WorkflowExpression] Func<string> bodydeviceId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3AddMobileCardResp> __Build_04addAttendanceDataInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodydate, WorkflowExpression<string> bodymode, WorkflowExpression<string> bodycardType = null, WorkflowExpression<double> bodyactualLongitude = null, WorkflowExpression<double> bodyactualLatitude = null, WorkflowExpression<string> bodydeviceName = null, WorkflowExpression<string> bodycodeSource = null, WorkflowExpression<string> bodylocationName = null, WorkflowExpression<string> bodyworkLocationId = null, WorkflowExpression<string> bodydeviceId = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: true);
            WorkflowExpression.Validate(bodycardType, nameof(bodycardType), required: false);
            WorkflowExpression.Validate(bodyactualLongitude, nameof(bodyactualLongitude), required: false);
            WorkflowExpression.Validate(bodyactualLatitude, nameof(bodyactualLatitude), required: false);
            WorkflowExpression.Validate(bodydeviceName, nameof(bodydeviceName), required: false);
            WorkflowExpression.Validate(bodycodeSource, nameof(bodycodeSource), required: false);
            WorkflowExpression.Validate(bodylocationName, nameof(bodylocationName), required: false);
            WorkflowExpression.Validate(bodyworkLocationId, nameof(bodyworkLocationId), required: false);
            WorkflowExpression.Validate(bodydeviceId, nameof(bodydeviceId), required: false);
            return new DeferredBodyAction<ResultV3AddMobileCardResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_04calculationLeaveBalance))]
        public IBodyWorkflowAction<ResultBoolean> _04calculationLeaveBalance([WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bool> bodyisForceCal = null, [WorkflowExpression] Func<string[]> bodyemployeeIdsList = null, [WorkflowExpression] Func<string[]> bodyposition = null, [WorkflowExpression] Func<string[]> bodydept = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_04calculationLeaveBalance(WorkflowExpression<string> bodydate = null, WorkflowExpression<bool> bodyisForceCal = null, WorkflowExpression<string[]> bodyemployeeIdsList = null, WorkflowExpression<string[]> bodyposition = null, WorkflowExpression<string[]> bodydept = null)
        {
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodyisForceCal, nameof(bodyisForceCal), required: false);
            WorkflowExpression.Validate(bodyemployeeIdsList, nameof(bodyemployeeIdsList), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodydept, nameof(bodydept), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_04getCustomizeUserFieldList))]
        public IBodyWorkflowAction<ResultIPageV3BizEmployeeCustomizationResp> _04getCustomizeUserFieldList([WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3BizEmployeeCustomizationResp> __Build_04getCustomizeUserFieldList(WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizEmployeeCustomizationResp>(() =>
            {
                var apiCallPath = "/v3/settings/getCustomizeUserFieldList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(current);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                return new ApiConnectionAction<ResultIPageV3BizEmployeeCustomizationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_04getEmployeeList))]
        public IBodyWorkflowAction<ResultIPageV3EmployeeListResp> _04getEmployeeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<string> sex = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> hireType = null, [WorkflowExpression] Func<string> calculateSalaryType = null, [WorkflowExpression] Func<string> costCenterId = null, [WorkflowExpression] Func<string> payrollRegulationId = null, [WorkflowExpression] Func<string> regularType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3EmployeeListResp> __Build_04getEmployeeList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> id = null, WorkflowExpression<string> departmentId = null, WorkflowExpression<string> positionId = null, WorkflowExpression<string> sex = null, WorkflowExpression<int> status = null, WorkflowExpression<string> hireType = null, WorkflowExpression<string> calculateSalaryType = null, WorkflowExpression<string> costCenterId = null, WorkflowExpression<string> payrollRegulationId = null, WorkflowExpression<string> regularType = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(departmentId, nameof(departmentId), required: false);
            WorkflowExpression.Validate(positionId, nameof(positionId), required: false);
            WorkflowExpression.Validate(sex, nameof(sex), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(hireType, nameof(hireType), required: false);
            WorkflowExpression.Validate(calculateSalaryType, nameof(calculateSalaryType), required: false);
            WorkflowExpression.Validate(costCenterId, nameof(costCenterId), required: false);
            WorkflowExpression.Validate(payrollRegulationId, nameof(payrollRegulationId), required: false);
            WorkflowExpression.Validate(regularType, nameof(regularType), required: false);
            return new DeferredBodyAction<ResultIPageV3EmployeeListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_04updateExpenseApplicationById))]
        public IBodyWorkflowAction<ResultBoolean> _04updateExpenseApplicationById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyreimbursementType = null, [WorkflowExpression] Func<string> bodyreimbursementDate = null, [WorkflowExpression] Func<string> bodyreimbursementName = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_04updateExpenseApplicationById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyreimbursementType = null, WorkflowExpression<string> bodyreimbursementDate = null, WorkflowExpression<string> bodyreimbursementName = null, WorkflowExpression<double> bodyamount = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyreimbursementType, nameof(bodyreimbursementType), required: false);
            WorkflowExpression.Validate(bodyreimbursementDate, nameof(bodyreimbursementDate), required: false);
            WorkflowExpression.Validate(bodyreimbursementName, nameof(bodyreimbursementName), required: false);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_04updateRosterInfoById))]
        public IBodyWorkflowAction<ResultBoolean> _04updateRosterInfoById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodyshiftTemplateId = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<double> bodyhourlyRate = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<double> bodytierRate = null, [WorkflowExpression] Func<double> bodyscheduledAmount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_04updateRosterInfoById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyshiftIn, WorkflowExpression<string> bodyshiftOff, WorkflowExpression<string> bodyshiftTemplateId = null, WorkflowExpression<string> bodyaddressCardId = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyshiftStatus = null, WorkflowExpression<string> bodydateType = null, WorkflowExpression<string> bodyattendanceItemId = null, WorkflowExpression<double> bodyhourlyRate = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<double> bodytierRate = null, WorkflowExpression<double> bodyscheduledAmount = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyshiftIn, nameof(bodyshiftIn), required: true);
            WorkflowExpression.Validate(bodyshiftOff, nameof(bodyshiftOff), required: true);
            WorkflowExpression.Validate(bodyshiftTemplateId, nameof(bodyshiftTemplateId), required: false);
            WorkflowExpression.Validate(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            WorkflowExpression.Validate(bodydateType, nameof(bodydateType), required: false);
            WorkflowExpression.Validate(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            WorkflowExpression.Validate(bodyhourlyRate, nameof(bodyhourlyRate), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodytierRate, nameof(bodytierRate), required: false);
            WorkflowExpression.Validate(bodyscheduledAmount, nameof(bodyscheduledAmount), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_05deleteAttendanceDataById))]
        public IBodyWorkflowAction<ResultBoolean> _05deleteAttendanceDataById([WorkflowExpression] Func<string> ids)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_05deleteAttendanceDataById(WorkflowExpression<string> ids)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteAttendanceDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_05getCustomizeUserFieldInfoById))]
        public IBodyWorkflowAction<ResultV3BizEmployeeCustomizationResp> _05getCustomizeUserFieldInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3BizEmployeeCustomizationResp> __Build_05getCustomizeUserFieldInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3BizEmployeeCustomizationResp>(() =>
            {
                var apiCallPath = "/v3/settings/getCustomizeUserFieldInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3BizEmployeeCustomizationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_05getEmployeeInfoById))]
        public IBodyWorkflowAction<ResultV3EmployeeInfoResp> _05getEmployeeInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3EmployeeInfoResp> __Build_05getEmployeeInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3EmployeeInfoResp>(() =>
            {
                var apiCallPath = "/v3/employee/getEmployeeInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3EmployeeInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_05GetExpenseApplicationList))]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementResp> _05GetExpenseApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> dateFilter = null, [WorkflowExpression] Func<string> reimbursementStatusFilter = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementResp> __Build_05GetExpenseApplicationList(WorkflowExpression<string> q = null, WorkflowExpression<string> departmentFilter = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> dateFilter = null, WorkflowExpression<string> reimbursementStatusFilter = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(departmentFilter, nameof(departmentFilter), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(dateFilter, nameof(dateFilter), required: false);
            WorkflowExpression.Validate(reimbursementStatusFilter, nameof(reimbursementStatusFilter), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3BizReimbursementResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_05getLeaveBalanceList))]
        public IBodyWorkflowAction<ResultIPageV3LeaveBalanceResp> _05getLeaveBalanceList([WorkflowExpression] Func<string> holidayType, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> regularTypeFilter = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> sexFilter = null, [WorkflowExpression] Func<string> leaveHolidayBalanceStatusFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> bizLabelIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LeaveBalanceResp> __Build_05getLeaveBalanceList(WorkflowExpression<string> holidayType, WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> regularTypeFilter = null, WorkflowExpression<string> departmentFilter = null, WorkflowExpression<string> positionFilter = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> sexFilter = null, WorkflowExpression<string> leaveHolidayBalanceStatusFilter = null, WorkflowExpression<string> calculateSalaryTypeFilter = null, WorkflowExpression<string> hireTypeFilter = null, WorkflowExpression<string> bizLabelIds = null)
        {
            WorkflowExpression.Validate(holidayType, nameof(holidayType), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(regularTypeFilter, nameof(regularTypeFilter), required: false);
            WorkflowExpression.Validate(departmentFilter, nameof(departmentFilter), required: false);
            WorkflowExpression.Validate(positionFilter, nameof(positionFilter), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(sexFilter, nameof(sexFilter), required: false);
            WorkflowExpression.Validate(leaveHolidayBalanceStatusFilter, nameof(leaveHolidayBalanceStatusFilter), required: false);
            WorkflowExpression.Validate(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            WorkflowExpression.Validate(hireTypeFilter, nameof(hireTypeFilter), required: false);
            WorkflowExpression.Validate(bizLabelIds, nameof(bizLabelIds), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveBalanceResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_05getRosterList))]
        public IBodyWorkflowAction<ResultIPageV3RosterListResp> _05getRosterList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendDay = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> attendStatus = null, [WorkflowExpression] Func<string> dateType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3RosterListResp> __Build_05getRosterList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> attendDay = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> attendStatus = null, WorkflowExpression<string> dateType = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(attendDay, nameof(attendDay), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(attendStatus, nameof(attendStatus), required: false);
            WorkflowExpression.Validate(dateType, nameof(dateType), required: false);
            return new DeferredBodyAction<ResultIPageV3RosterListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_06getApproveProcessList))]
        public IBodyWorkflowAction<ResultIPageV3LeaveWorkFlowDefinitionResp> _06getApproveProcessList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LeaveWorkFlowDefinitionResp> __Build_06getApproveProcessList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveWorkFlowDefinitionResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_06GetExpenseApplicationById))]
        public IBodyWorkflowAction<ResultV3BizReimbursementDetailResp> _06GetExpenseApplicationById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3BizReimbursementDetailResp> __Build_06GetExpenseApplicationById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3BizReimbursementDetailResp>(() =>
            {
                var apiCallPath = "/v3/expense/getExpenseApplicationById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3BizReimbursementDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_06GetLeaveBalanceInfoById))]
        public IBodyWorkflowAction<ResultV3LeaveBalanceDetailResp> _06GetLeaveBalanceInfoById([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> holidayType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3LeaveBalanceDetailResp> __Build_06GetLeaveBalanceInfoById(WorkflowExpression<string> employeeId, WorkflowExpression<string> holidayType)
        {
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: true);
            WorkflowExpression.Validate(holidayType, nameof(holidayType), required: true);
            return new DeferredBodyAction<ResultV3LeaveBalanceDetailResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = ExpressionConverter.Convert(employeeId);
                callPayload.Queries["holidayType"] = ExpressionConverter.Convert(holidayType);
                return new ApiConnectionAction<ResultV3LeaveBalanceDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_06getRosterInfoById))]
        public IBodyWorkflowAction<ResultV3RosterInfoResp> _06getRosterInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3RosterInfoResp> __Build_06getRosterInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3RosterInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getRosterInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3RosterInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_06resign))]
        public IBodyWorkflowAction<ResultBoolean> _06resign([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylastWorkingDate, [WorkflowExpression] Func<string> bodyreasonsLeave, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_06resign(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodylastWorkingDate, WorkflowExpression<string> bodyreasonsLeave, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodylastWorkingDate, nameof(bodylastWorkingDate), required: true);
            WorkflowExpression.Validate(bodyreasonsLeave, nameof(bodyreasonsLeave), required: true);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_06updateAttendanceDataById))]
        public IBodyWorkflowAction<ResultBoolean> _06updateAttendanceDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodymode = null, [WorkflowExpression] Func<string> bodycardType = null, [WorkflowExpression] Func<double> bodyactualLongitude = null, [WorkflowExpression] Func<double> bodyactualLatitude = null, [WorkflowExpression] Func<string> bodydeviceName = null, [WorkflowExpression] Func<string> bodycodeSource = null, [WorkflowExpression] Func<string> bodylocationName = null, [WorkflowExpression] Func<string> bodyworkLocationId = null, [WorkflowExpression] Func<string> bodydeviceId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_06updateAttendanceDataById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodydate = null, WorkflowExpression<string> bodymode = null, WorkflowExpression<string> bodycardType = null, WorkflowExpression<double> bodyactualLongitude = null, WorkflowExpression<double> bodyactualLatitude = null, WorkflowExpression<string> bodydeviceName = null, WorkflowExpression<string> bodycodeSource = null, WorkflowExpression<string> bodylocationName = null, WorkflowExpression<string> bodyworkLocationId = null, WorkflowExpression<string> bodydeviceId = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: false);
            WorkflowExpression.Validate(bodycardType, nameof(bodycardType), required: false);
            WorkflowExpression.Validate(bodyactualLongitude, nameof(bodyactualLongitude), required: false);
            WorkflowExpression.Validate(bodyactualLatitude, nameof(bodyactualLatitude), required: false);
            WorkflowExpression.Validate(bodydeviceName, nameof(bodydeviceName), required: false);
            WorkflowExpression.Validate(bodycodeSource, nameof(bodycodeSource), required: false);
            WorkflowExpression.Validate(bodylocationName, nameof(bodylocationName), required: false);
            WorkflowExpression.Validate(bodyworkLocationId, nameof(bodyworkLocationId), required: false);
            WorkflowExpression.Validate(bodydeviceId, nameof(bodydeviceId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_07addEmployeeHistory))]
        public IBodyWorkflowAction<ResultV3AddEmployeeHistoryResp> _07addEmployeeHistory([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodytakeEffectType, [WorkflowExpression] Func<string> bodytakeEffectDate, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<string> bodycause = null, [WorkflowExpression] Func<string> bodymajorWorkLocationId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3AddEmployeeHistoryResp> __Build_07addEmployeeHistory(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyentryDate, WorkflowExpression<string> bodytakeEffectType, WorkflowExpression<string> bodytakeEffectDate, WorkflowExpression<string> bodyconfirmationDate = null, WorkflowExpression<string> bodyhireType = null, WorkflowExpression<string> bodypositionId = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodydirectSupervisorId = null, WorkflowExpression<string> bodyattendCalculationId = null, WorkflowExpression<string> bodypayrollRegulationId = null, WorkflowExpression<double> bodybasicPay = null, WorkflowExpression<string> bodycalculateSalaryType = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyworkDate = null, WorkflowExpression<string> bodycause = null, WorkflowExpression<string> bodymajorWorkLocationId = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyentryDate, nameof(bodyentryDate), required: true);
            WorkflowExpression.Validate(bodytakeEffectType, nameof(bodytakeEffectType), required: true);
            WorkflowExpression.Validate(bodytakeEffectDate, nameof(bodytakeEffectDate), required: true);
            WorkflowExpression.Validate(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            WorkflowExpression.Validate(bodyhireType, nameof(bodyhireType), required: false);
            WorkflowExpression.Validate(bodypositionId, nameof(bodypositionId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            WorkflowExpression.Validate(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            WorkflowExpression.Validate(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            WorkflowExpression.Validate(bodybasicPay, nameof(bodybasicPay), required: false);
            WorkflowExpression.Validate(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyworkDate, nameof(bodyworkDate), required: false);
            WorkflowExpression.Validate(bodycause, nameof(bodycause), required: false);
            WorkflowExpression.Validate(bodymajorWorkLocationId, nameof(bodymajorWorkLocationId), required: false);
            return new DeferredBodyAction<ResultV3AddEmployeeHistoryResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_07addLeaveApplicationInfo))]
        public IBodyWorkflowAction<ResultV3LeaveHolidayInsertResp> _07addLeaveApplicationInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyholidayType, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<double> bodyleaveTime = null, [WorkflowExpression] Func<string> bodytimeType = null, [WorkflowExpression] Func<string> bodyholidayDate = null, [WorkflowExpression] Func<string> bodytime = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3LeaveHolidayInsertResp> __Build_07addLeaveApplicationInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyholidayType, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<double> bodyleaveTime = null, WorkflowExpression<string> bodytimeType = null, WorkflowExpression<string> bodyholidayDate = null, WorkflowExpression<string> bodytime = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyholidayType, nameof(bodyholidayType), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodyleaveTime, nameof(bodyleaveTime), required: false);
            WorkflowExpression.Validate(bodytimeType, nameof(bodytimeType), required: false);
            WorkflowExpression.Validate(bodyholidayDate, nameof(bodyholidayDate), required: false);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3LeaveHolidayInsertResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_07addShitTemplateInfo))]
        public IBodyWorkflowAction<ResultBoolean> _07addShitTemplateInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceAddressId = null, [WorkflowExpression] Func<int> bodymealTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_07addShitTemplateInfo(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyshiftIn, WorkflowExpression<string> bodyshiftOff, WorkflowExpression<string> bodydateType = null, WorkflowExpression<string> bodyattendanceAddressId = null, WorkflowExpression<int> bodymealTime = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyshiftIn, nameof(bodyshiftIn), required: true);
            WorkflowExpression.Validate(bodyshiftOff, nameof(bodyshiftOff), required: true);
            WorkflowExpression.Validate(bodydateType, nameof(bodydateType), required: false);
            WorkflowExpression.Validate(bodyattendanceAddressId, nameof(bodyattendanceAddressId), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_07getAttendanceDataList))]
        public IBodyWorkflowAction<ResultIPageV3MobileCardListResp> _07getAttendanceDataList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> attendCalculationId = null, [WorkflowExpression] Func<string> bizLabelIds = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3MobileCardListResp> __Build_07getAttendanceDataList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> departmentFilter = null, WorkflowExpression<string> positionFilter = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> attendCalculationId = null, WorkflowExpression<string> bizLabelIds = null, WorkflowExpression<string> hireTypeFilter = null, WorkflowExpression<string> calculateSalaryTypeFilter = null, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(departmentFilter, nameof(departmentFilter), required: false);
            WorkflowExpression.Validate(positionFilter, nameof(positionFilter), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(attendCalculationId, nameof(attendCalculationId), required: false);
            WorkflowExpression.Validate(bizLabelIds, nameof(bizLabelIds), required: false);
            WorkflowExpression.Validate(hireTypeFilter, nameof(hireTypeFilter), required: false);
            WorkflowExpression.Validate(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<ResultIPageV3MobileCardListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_08deleteEmployeeHistoryById))]
        public IBodyWorkflowAction<ResultBoolean> _08deleteEmployeeHistoryById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_08deleteEmployeeHistoryById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/employee/deleteEmployeeHistoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_08deleteLeaveApplicationById))]
        public IBodyWorkflowAction<ResultBoolean> _08deleteLeaveApplicationById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_08deleteLeaveApplicationById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/leave/deleteLeaveApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_08deleteShiftTemplateById))]
        public IBodyWorkflowAction<ResultBoolean> _08deleteShiftTemplateById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_08deleteShiftTemplateById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteShiftTemplateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_08getAttendanceDataInfoById))]
        public IBodyWorkflowAction<ResultV3MobileCardInfoResp> _08getAttendanceDataInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3MobileCardInfoResp> __Build_08getAttendanceDataInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3MobileCardInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendance/getAttendanceDataInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3MobileCardInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_09getAttendanceItemList))]
        public IBodyWorkflowAction<ResultIPageV3AttendanceItemListResp> _09getAttendanceItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3AttendanceItemListResp> __Build_09getAttendanceItemList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3AttendanceItemListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_09updateEmployeeHistoryById))]
        public IBodyWorkflowAction<ResultBoolean> _09updateEmployeeHistoryById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<string> bodycause = null, [WorkflowExpression] Func<string> bodymajorWorkLocationId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_09updateEmployeeHistoryById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyentryDate, WorkflowExpression<string> bodyconfirmationDate = null, WorkflowExpression<string> bodyhireType = null, WorkflowExpression<string> bodypositionId = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodydirectSupervisorId = null, WorkflowExpression<string> bodyattendCalculationId = null, WorkflowExpression<string> bodypayrollRegulationId = null, WorkflowExpression<double> bodybasicPay = null, WorkflowExpression<string> bodycalculateSalaryType = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyworkDate = null, WorkflowExpression<string> bodycause = null, WorkflowExpression<string> bodymajorWorkLocationId = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyentryDate, nameof(bodyentryDate), required: true);
            WorkflowExpression.Validate(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            WorkflowExpression.Validate(bodyhireType, nameof(bodyhireType), required: false);
            WorkflowExpression.Validate(bodypositionId, nameof(bodypositionId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodydirectSupervisorId, nameof(bodydirectSupervisorId), required: false);
            WorkflowExpression.Validate(bodyattendCalculationId, nameof(bodyattendCalculationId), required: false);
            WorkflowExpression.Validate(bodypayrollRegulationId, nameof(bodypayrollRegulationId), required: false);
            WorkflowExpression.Validate(bodybasicPay, nameof(bodybasicPay), required: false);
            WorkflowExpression.Validate(bodycalculateSalaryType, nameof(bodycalculateSalaryType), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyworkDate, nameof(bodyworkDate), required: false);
            WorkflowExpression.Validate(bodycause, nameof(bodycause), required: false);
            WorkflowExpression.Validate(bodymajorWorkLocationId, nameof(bodymajorWorkLocationId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_09updateLeaveApplicationById))]
        public IBodyWorkflowAction<ResultBoolean> _09updateLeaveApplicationById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyholidayType = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<double> bodyleaveTime = null, [WorkflowExpression] Func<string> bodytimeType = null, [WorkflowExpression] Func<string> bodyholidayDate = null, [WorkflowExpression] Func<string> bodytime = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_09updateLeaveApplicationById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyholidayType = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<double> bodyleaveTime = null, WorkflowExpression<string> bodytimeType = null, WorkflowExpression<string> bodyholidayDate = null, WorkflowExpression<string> bodytime = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyholidayType, nameof(bodyholidayType), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodyleaveTime, nameof(bodyleaveTime), required: false);
            WorkflowExpression.Validate(bodytimeType, nameof(bodytimeType), required: false);
            WorkflowExpression.Validate(bodyholidayDate, nameof(bodyholidayDate), required: false);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_09updateShiftTemplateById))]
        public IBodyWorkflowAction<ResultBoolean> _09updateShiftTemplateById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceAddressId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_09updateShiftTemplateById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyshiftIn, WorkflowExpression<string> bodyshiftOff, WorkflowExpression<string> bodydateType = null, WorkflowExpression<string> bodyattendanceAddressId = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyshiftIn, nameof(bodyshiftIn), required: true);
            WorkflowExpression.Validate(bodyshiftOff, nameof(bodyshiftOff), required: true);
            WorkflowExpression.Validate(bodydateType, nameof(bodydateType), required: false);
            WorkflowExpression.Validate(bodyattendanceAddressId, nameof(bodyattendanceAddressId), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_10addTimesheetInfo))]
        public IBodyWorkflowAction<ResultV3AddTimesheetResp> _10addTimesheetInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string> bodyworkOverTimeType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3AddTimesheetResp> __Build_10addTimesheetInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodydate, WorkflowExpression<string> bodystartTime, WorkflowExpression<string> bodyendTime, WorkflowExpression<string> bodyworkOverTimeType = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyaddressCardId = null, WorkflowExpression<string> bodyattendanceItemId = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: true);
            WorkflowExpression.Validate(bodyworkOverTimeType, nameof(bodyworkOverTimeType), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            WorkflowExpression.Validate(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3AddTimesheetResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_10getEmployeeHistoryList))]
        public IBodyWorkflowAction<ResultIPageV3EmployeeHistoryListResp> _10getEmployeeHistoryList([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3EmployeeHistoryListResp> __Build_10getEmployeeHistoryList(WorkflowExpression<string> employeeId, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: true);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3EmployeeHistoryListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_10getLeaveApplicationList))]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayResp> _10getLeaveApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> employeeFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> holidayTypeFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> recordStatusFilter = null, [WorkflowExpression] Func<string> attendCalculationId = null, [WorkflowExpression] Func<string> bizLabelIds = null, [WorkflowExpression] Func<string> startDateFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayResp> __Build_10getLeaveApplicationList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> departmentFilter = null, WorkflowExpression<string> employeeFilter = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> holidayTypeFilter = null, WorkflowExpression<string> calculateSalaryTypeFilter = null, WorkflowExpression<string> recordStatusFilter = null, WorkflowExpression<string> attendCalculationId = null, WorkflowExpression<string> bizLabelIds = null, WorkflowExpression<string> startDateFilter = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(departmentFilter, nameof(departmentFilter), required: false);
            WorkflowExpression.Validate(employeeFilter, nameof(employeeFilter), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(holidayTypeFilter, nameof(holidayTypeFilter), required: false);
            WorkflowExpression.Validate(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            WorkflowExpression.Validate(recordStatusFilter, nameof(recordStatusFilter), required: false);
            WorkflowExpression.Validate(attendCalculationId, nameof(attendCalculationId), required: false);
            WorkflowExpression.Validate(bizLabelIds, nameof(bizLabelIds), required: false);
            WorkflowExpression.Validate(startDateFilter, nameof(startDateFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveHolidayResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_10getShiftTemplateList))]
        public IBodyWorkflowAction<ResultIPageV3ShiftTemplateListResp> _10getShiftTemplateList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendanceAddressId = null, [WorkflowExpression] Func<string> dateType = null, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3ShiftTemplateListResp> __Build_10getShiftTemplateList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> attendanceAddressId = null, WorkflowExpression<string> dateType = null, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(attendanceAddressId, nameof(attendanceAddressId), required: false);
            WorkflowExpression.Validate(dateType, nameof(dateType), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV3ShiftTemplateListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_11addOpenShiftInfo))]
        public IBodyWorkflowAction<ResultBoolean> _11addOpenShiftInfo([WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<int> bodyempPlanNo, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyshiftType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_11addOpenShiftInfo(WorkflowExpression<string> bodyprojectId, WorkflowExpression<string> bodydate, WorkflowExpression<string> bodystartTime, WorkflowExpression<string> bodyendTime, WorkflowExpression<double> bodyhourlyRate, WorkflowExpression<int> bodyempPlanNo, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodylocationId = null, WorkflowExpression<string> bodyshiftType = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: true);
            WorkflowExpression.Validate(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            WorkflowExpression.Validate(bodyempPlanNo, nameof(bodyempPlanNo), required: true);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            WorkflowExpression.Validate(bodyshiftType, nameof(bodyshiftType), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_11deleteTimesheetById))]
        public IBodyWorkflowAction<ResultBoolean> _11deleteTimesheetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_11deleteTimesheetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteTimesheetById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_11getLeaveApplicationInfoById))]
        public IBodyWorkflowAction<ResultV3LeaveHolidayDetailResp> _11getLeaveApplicationInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3LeaveHolidayDetailResp> __Build_11getLeaveApplicationInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3LeaveHolidayDetailResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3LeaveHolidayDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_12deleteOpenShiftById))]
        public IBodyWorkflowAction<ResultBoolean> _12deleteOpenShiftById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_12deleteOpenShiftById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteOpenShiftById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_12getLeaveApplicationApproveProcessById))]
        public IBodyWorkflowAction<ResultListV3LeaveProcessResp> _12getLeaveApplicationApproveProcessById([WorkflowExpression] Func<string> recordId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultListV3LeaveProcessResp> __Build_12getLeaveApplicationApproveProcessById(WorkflowExpression<string> recordId)
        {
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<ResultListV3LeaveProcessResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationApproveProcessById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordId"] = ExpressionConverter.Convert(recordId);
                return new ApiConnectionAction<ResultListV3LeaveProcessResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_12updateTimesheetById))]
        public IBodyWorkflowAction<ResultBoolean> _12updateTimesheetById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string> bodyworkOverTimeType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_12updateTimesheetById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodydate, WorkflowExpression<string> bodystartTime, WorkflowExpression<string> bodyendTime, WorkflowExpression<string> bodyworkOverTimeType = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyaddressCardId = null, WorkflowExpression<string> bodyattendanceItemId = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: true);
            WorkflowExpression.Validate(bodyworkOverTimeType, nameof(bodyworkOverTimeType), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            WorkflowExpression.Validate(bodyattendanceItemId, nameof(bodyattendanceItemId), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_13getLeaveTypeList))]
        public IBodyWorkflowAction<ResultIPageV3LeaveTypeResp> _13getLeaveTypeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> shortName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LeaveTypeResp> __Build_13getLeaveTypeList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> name = null, WorkflowExpression<string> shortName = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(shortName, nameof(shortName), required: false);
            return new DeferredBodyAction<ResultIPageV3LeaveTypeResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_13getTimesheetList))]
        public IBodyWorkflowAction<ResultIPageV3TimesheetListResp> _13getTimesheetList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> bizLabelIds = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> addressCardId = null, [WorkflowExpression] Func<string> typeFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3TimesheetListResp> __Build_13getTimesheetList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> departmentFilter = null, WorkflowExpression<string> positionFilter = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> bizLabelIds = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> calculateSalaryTypeFilter = null, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> addressCardId = null, WorkflowExpression<string> typeFilter = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(departmentFilter, nameof(departmentFilter), required: false);
            WorkflowExpression.Validate(positionFilter, nameof(positionFilter), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(bizLabelIds, nameof(bizLabelIds), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(calculateSalaryTypeFilter, nameof(calculateSalaryTypeFilter), required: false);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(addressCardId, nameof(addressCardId), required: false);
            WorkflowExpression.Validate(typeFilter, nameof(typeFilter), required: false);
            return new DeferredBodyAction<ResultIPageV3TimesheetListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_13updateOpenShiftById))]
        public IBodyWorkflowAction<ResultBoolean> _13updateOpenShiftById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<int> bodyempPlanNo, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyshiftType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_13updateOpenShiftById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyprojectId, WorkflowExpression<string> bodystartTime, WorkflowExpression<string> bodyendTime, WorkflowExpression<double> bodyhourlyRate, WorkflowExpression<int> bodyempPlanNo, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodylocationId = null, WorkflowExpression<string> bodyshiftType = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: true);
            WorkflowExpression.Validate(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            WorkflowExpression.Validate(bodyempPlanNo, nameof(bodyempPlanNo), required: true);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            WorkflowExpression.Validate(bodyshiftType, nameof(bodyshiftType), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_14getLeavePolicyList))]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyResp> _14getLeavePolicyList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyResp> __Build_14getLeavePolicyList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> name = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            return new DeferredBodyAction<ResultIPageV3LeavePolicyResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_14getOpenShiftList))]
        public IBodyWorkflowAction<ResultIPageV3OpenShiftListResp> _14getOpenShiftList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<string> costCenterId = null, [WorkflowExpression] Func<string> date = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3OpenShiftListResp> __Build_14getOpenShiftList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> projectId = null, WorkflowExpression<string> locationId = null, WorkflowExpression<string> costCenterId = null, WorkflowExpression<string> date = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: false);
            WorkflowExpression.Validate(locationId, nameof(locationId), required: false);
            WorkflowExpression.Validate(costCenterId, nameof(costCenterId), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            return new DeferredBodyAction<ResultIPageV3OpenShiftListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_14getTimesheetInfoById))]
        public IBodyWorkflowAction<ResultV3TimesheetInfoResp> _14getTimesheetInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3TimesheetInfoResp> __Build_14getTimesheetInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3TimesheetInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendance/getTimesheetInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3TimesheetInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_15addCalendarRemarkInfo))]
        public IBodyWorkflowAction<ResultV3AddCalendarRemarkInfoResp> _15addCalendarRemarkInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyemployeeStatus, [WorkflowExpression] Func<string> bodytimeType, [WorkflowExpression] Func<string> bodyexpectWorkStartTime, [WorkflowExpression] Func<string> bodyexpectWorkEndTime, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyrecordDate = null, [WorkflowExpression] Func<string> bodyexpectWorkLocation = null, [WorkflowExpression] Func<string> bodyexpectWorkTimeTemplate = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3AddCalendarRemarkInfoResp> __Build_15addCalendarRemarkInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyemployeeStatus, WorkflowExpression<string> bodytimeType, WorkflowExpression<string> bodyexpectWorkStartTime, WorkflowExpression<string> bodyexpectWorkEndTime, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyrecordDate = null, WorkflowExpression<string> bodyexpectWorkLocation = null, WorkflowExpression<string> bodyexpectWorkTimeTemplate = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyemployeeStatus, nameof(bodyemployeeStatus), required: true);
            WorkflowExpression.Validate(bodytimeType, nameof(bodytimeType), required: true);
            WorkflowExpression.Validate(bodyexpectWorkStartTime, nameof(bodyexpectWorkStartTime), required: true);
            WorkflowExpression.Validate(bodyexpectWorkEndTime, nameof(bodyexpectWorkEndTime), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyrecordDate, nameof(bodyrecordDate), required: false);
            WorkflowExpression.Validate(bodyexpectWorkLocation, nameof(bodyexpectWorkLocation), required: false);
            WorkflowExpression.Validate(bodyexpectWorkTimeTemplate, nameof(bodyexpectWorkTimeTemplate), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultV3AddCalendarRemarkInfoResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_15getLeavePolicyInfoById))]
        public IBodyWorkflowAction<ResultV3LeavePolicyDetailResp> _15getLeavePolicyInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3LeavePolicyDetailResp> __Build_15getLeavePolicyInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3LeavePolicyDetailResp>(() =>
            {
                var apiCallPath = "/v3/leave/getLeavePolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3LeavePolicyDetailResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_15getOpenShiftInfoById))]
        public IBodyWorkflowAction<ResultV3OpenShiftInfoResp> _15getOpenShiftInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3OpenShiftInfoResp> __Build_15getOpenShiftInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3OpenShiftInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getOpenShiftInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3OpenShiftInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_16addProjectCategoryInfo))]
        public IBodyWorkflowAction<ResultBoolean> _16addProjectCategoryInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_16addProjectCategoryInfo(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_16deleteCalendarRemarkById))]
        public IBodyWorkflowAction<ResultBoolean> _16deleteCalendarRemarkById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_16deleteCalendarRemarkById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendance/deleteCalendarRemarkById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_16getLeavePolicyTypeList))]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyTypeResp> _16getLeavePolicyTypeList([WorkflowExpression] Func<string> regulationId, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> holidayId = null, [WorkflowExpression] Func<string> generationFrequency = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyTypeResp> __Build_16getLeavePolicyTypeList(WorkflowExpression<string> regulationId, WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> id = null, WorkflowExpression<string> holidayId = null, WorkflowExpression<string> generationFrequency = null)
        {
            WorkflowExpression.Validate(regulationId, nameof(regulationId), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(holidayId, nameof(holidayId), required: false);
            WorkflowExpression.Validate(generationFrequency, nameof(generationFrequency), required: false);
            return new DeferredBodyAction<ResultIPageV3LeavePolicyTypeResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_17deleteProjectCategoryById))]
        public IBodyWorkflowAction<ResultBoolean> _17deleteProjectCategoryById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_17deleteProjectCategoryById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCategoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_17updateCalendarRemarkById))]
        public IBodyWorkflowAction<ResultBoolean> _17updateCalendarRemarkById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyemployeeStatus, [WorkflowExpression] Func<string> bodytimeType, [WorkflowExpression] Func<string> bodyexpectWorkStartTime, [WorkflowExpression] Func<string> bodyexpectWorkEndTime, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyrecordDate = null, [WorkflowExpression] Func<string> bodyexpectWorkLocation = null, [WorkflowExpression] Func<string> bodyexpectWorkTimeTemplate = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_17updateCalendarRemarkById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyemployeeStatus, WorkflowExpression<string> bodytimeType, WorkflowExpression<string> bodyexpectWorkStartTime, WorkflowExpression<string> bodyexpectWorkEndTime, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyrecordDate = null, WorkflowExpression<string> bodyexpectWorkLocation = null, WorkflowExpression<string> bodyexpectWorkTimeTemplate = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyemployeeStatus, nameof(bodyemployeeStatus), required: true);
            WorkflowExpression.Validate(bodytimeType, nameof(bodytimeType), required: true);
            WorkflowExpression.Validate(bodyexpectWorkStartTime, nameof(bodyexpectWorkStartTime), required: true);
            WorkflowExpression.Validate(bodyexpectWorkEndTime, nameof(bodyexpectWorkEndTime), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyrecordDate, nameof(bodyrecordDate), required: false);
            WorkflowExpression.Validate(bodyexpectWorkLocation, nameof(bodyexpectWorkLocation), required: false);
            WorkflowExpression.Validate(bodyexpectWorkTimeTemplate, nameof(bodyexpectWorkTimeTemplate), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_18getCalendarRemarkList))]
        public IBodyWorkflowAction<ResultIPageV3StatusFlagListResp> _18getCalendarRemarkList([WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIds = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3StatusFlagListResp> __Build_18getCalendarRemarkList(WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeIds = null, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null)
        {
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeIds, nameof(employeeIds), required: false);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<ResultIPageV3StatusFlagListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_18updateProjectCategoryById))]
        public IBodyWorkflowAction<ResultBoolean> _18updateProjectCategoryById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_18updateProjectCategoryById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_19getProjectCategoryList))]
        public IBodyWorkflowAction<ResultIPageV3ScheduleProjectCategoryListResp> _19getProjectCategoryList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3ScheduleProjectCategoryListResp> __Build_19getProjectCategoryList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ScheduleProjectCategoryListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_20addProjectInfo))]
        public IBodyWorkflowAction<ResultBoolean> _20addProjectInfo([WorkflowExpression] Func<string> bodycode, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<double> bodyminRate = null, [WorkflowExpression] Func<double> bodymaxRate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_20addProjectInfo(WorkflowExpression<string> bodycode, WorkflowExpression<string> bodyname, WorkflowExpression<double> bodyhourlyRate, WorkflowExpression<string> bodycategoryId = null, WorkflowExpression<double> bodyminRate = null, WorkflowExpression<double> bodymaxRate = null)
        {
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            WorkflowExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            WorkflowExpression.Validate(bodyminRate, nameof(bodyminRate), required: false);
            WorkflowExpression.Validate(bodymaxRate, nameof(bodymaxRate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_21deleteProjectById))]
        public IBodyWorkflowAction<ResultBoolean> _21deleteProjectById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_21deleteProjectById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_22updateProjectById))]
        public IBodyWorkflowAction<ResultBoolean> _22updateProjectById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodycode, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<double> bodyminRate = null, [WorkflowExpression] Func<double> bodymaxRate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_22updateProjectById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodycode, WorkflowExpression<string> bodyname, WorkflowExpression<double> bodyhourlyRate, WorkflowExpression<string> bodycategoryId = null, WorkflowExpression<double> bodyminRate = null, WorkflowExpression<double> bodymaxRate = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyhourlyRate, nameof(bodyhourlyRate), required: true);
            WorkflowExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            WorkflowExpression.Validate(bodyminRate, nameof(bodyminRate), required: false);
            WorkflowExpression.Validate(bodymaxRate, nameof(bodymaxRate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_23getProjectList))]
        public IBodyWorkflowAction<ResultIPageV3ProjectListResp> _23getProjectList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3ProjectListResp> __Build_23getProjectList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_24getProjectInfoById))]
        public IBodyWorkflowAction<ResultV3ProjectInfoResp> _24getProjectInfoById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultV3ProjectInfoResp> __Build_24getProjectInfoById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultV3ProjectInfoResp>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/getProjectInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultV3ProjectInfoResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_25addProjectCertificateInfo))]
        public IBodyWorkflowAction<ResultBoolean> _25addProjectCertificateInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<double> bodyshiftHours, [WorkflowExpression] Func<double> bodyworkedHours, [WorkflowExpression] Func<string> bodytier = null, [WorkflowExpression] Func<double> bodytierRate = null, [WorkflowExpression] Func<string> bodyreason = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_25addProjectCertificateInfo(WorkflowExpression<string> bodyemployeeId, WorkflowExpression<string> bodyprojectId, WorkflowExpression<double> bodyshiftHours, WorkflowExpression<double> bodyworkedHours, WorkflowExpression<string> bodytier = null, WorkflowExpression<double> bodytierRate = null, WorkflowExpression<string> bodyreason = null)
        {
            WorkflowExpression.Validate(bodyemployeeId, nameof(bodyemployeeId), required: true);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            WorkflowExpression.Validate(bodyshiftHours, nameof(bodyshiftHours), required: true);
            WorkflowExpression.Validate(bodyworkedHours, nameof(bodyworkedHours), required: true);
            WorkflowExpression.Validate(bodytier, nameof(bodytier), required: false);
            WorkflowExpression.Validate(bodytierRate, nameof(bodytierRate), required: false);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_26updateProjectCertificateById))]
        public IBodyWorkflowAction<ResultBoolean> _26updateProjectCertificateById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodytier = null, [WorkflowExpression] Func<double> bodytierRate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_26updateProjectCertificateById(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodytier = null, WorkflowExpression<double> bodytierRate = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodytier, nameof(bodytier), required: false);
            WorkflowExpression.Validate(bodytierRate, nameof(bodytierRate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_27getProjectCertificateList))]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateListResp> _27getProjectCertificateList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> hireType = null, [WorkflowExpression] Func<string> projectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateListResp> __Build_27getProjectCertificateList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> departmentId = null, WorkflowExpression<string> positionId = null, WorkflowExpression<int> status = null, WorkflowExpression<string> hireType = null, WorkflowExpression<string> projectId = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(departmentId, nameof(departmentId), required: false);
            WorkflowExpression.Validate(positionId, nameof(positionId), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(hireType, nameof(hireType), required: false);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectCertificateListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_28addProjectCertificateHours))]
        public IBodyWorkflowAction<ResultBoolean> _28addProjectCertificateHours([WorkflowExpression] Func<string> bodyprojectCertificateId, [WorkflowExpression] Func<string> bodyoccurrenceTime, [WorkflowExpression] Func<double> bodybalance, [WorkflowExpression] Func<string> bodyreason)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_28addProjectCertificateHours(WorkflowExpression<string> bodyprojectCertificateId, WorkflowExpression<string> bodyoccurrenceTime, WorkflowExpression<double> bodybalance, WorkflowExpression<string> bodyreason)
        {
            WorkflowExpression.Validate(bodyprojectCertificateId, nameof(bodyprojectCertificateId), required: true);
            WorkflowExpression.Validate(bodyoccurrenceTime, nameof(bodyoccurrenceTime), required: true);
            WorkflowExpression.Validate(bodybalance, nameof(bodybalance), required: true);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_29deleteProjectCertificateHoursById))]
        public IBodyWorkflowAction<ResultBoolean> _29deleteProjectCertificateHoursById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __Build_29deleteProjectCertificateHoursById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultBoolean>(() =>
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCertificateHoursById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<ResultBoolean>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__Build_30getProjectCertificateHourList))]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateHoursListResp> _30getProjectCertificateHourList([WorkflowExpression] Func<string> projectCertificateId, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateHoursListResp> __Build_30getProjectCertificateHourList(WorkflowExpression<string> projectCertificateId, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(projectCertificateId, nameof(projectCertificateId), required: true);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV3ProjectCertificateHoursListResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttendCalculationList))]
        public IBodyWorkflowAction<ResultIPageV2AttendanceResp> GetAttendCalculationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendDay = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> attendStatus = null, [WorkflowExpression] Func<string> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2AttendanceResp> __BuildGetAttendCalculationList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> attendDay = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> attendStatus = null, WorkflowExpression<string> type = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(attendDay, nameof(attendDay), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(attendStatus, nameof(attendStatus), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<ResultIPageV2AttendanceResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetCostCenterList))]
        public IBodyWorkflowAction<ResultIPageV2CostCenterResp> GetCostCenterList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> costCenterCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2CostCenterResp> __BuildGetCostCenterList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> name = null, WorkflowExpression<string> costCenterCode = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(costCenterCode, nameof(costCenterCode), required: false);
            return new DeferredBodyAction<ResultIPageV2CostCenterResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetDepartmentList))]
        public IBodyWorkflowAction<ResultIPageV2DepartmentResp> GetDepartmentList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> departmentCode = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2DepartmentResp> __BuildGetDepartmentList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> name = null, WorkflowExpression<string> departmentCode = null, WorkflowExpression<string> parentId = null, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(departmentCode, nameof(departmentCode), required: false);
            WorkflowExpression.Validate(parentId, nameof(parentId), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2DepartmentResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmployeeList))]
        public IBodyWorkflowAction<ResultIPageV2EmployeeResp> GetEmployeeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> englishName = null, [WorkflowExpression] Func<string> chineseName = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> education = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<string> hireType = null, [WorkflowExpression] Func<string> bankCode = null, [WorkflowExpression] Func<string> costCenterId = null, [WorkflowExpression] Func<string> payrollRegulationId = null, [WorkflowExpression] Func<string> workDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2EmployeeResp> __BuildGetEmployeeList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> englishName = null, WorkflowExpression<string> chineseName = null, WorkflowExpression<string> email = null, WorkflowExpression<string> countryCode = null, WorkflowExpression<string> phone = null, WorkflowExpression<string> code = null, WorkflowExpression<int> status = null, WorkflowExpression<string> education = null, WorkflowExpression<string> departmentId = null, WorkflowExpression<string> positionId = null, WorkflowExpression<string> hireType = null, WorkflowExpression<string> bankCode = null, WorkflowExpression<string> costCenterId = null, WorkflowExpression<string> payrollRegulationId = null, WorkflowExpression<string> workDate = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(englishName, nameof(englishName), required: false);
            WorkflowExpression.Validate(chineseName, nameof(chineseName), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: false);
            WorkflowExpression.Validate(phone, nameof(phone), required: false);
            WorkflowExpression.Validate(code, nameof(code), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(education, nameof(education), required: false);
            WorkflowExpression.Validate(departmentId, nameof(departmentId), required: false);
            WorkflowExpression.Validate(positionId, nameof(positionId), required: false);
            WorkflowExpression.Validate(hireType, nameof(hireType), required: false);
            WorkflowExpression.Validate(bankCode, nameof(bankCode), required: false);
            WorkflowExpression.Validate(costCenterId, nameof(costCenterId), required: false);
            WorkflowExpression.Validate(payrollRegulationId, nameof(payrollRegulationId), required: false);
            WorkflowExpression.Validate(workDate, nameof(workDate), required: false);
            return new DeferredBodyAction<ResultIPageV2EmployeeResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetExpenseApplicationList))]
        public IBodyWorkflowAction<ResultIPageV2ExpenseResp> GetExpenseApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> reimbursementStatusFilter = null, [WorkflowExpression] Func<string> reimbursementName = null, [WorkflowExpression] Func<string> departmentFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2ExpenseResp> __BuildGetExpenseApplicationList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> reimbursementStatusFilter = null, WorkflowExpression<string> reimbursementName = null, WorkflowExpression<string> departmentFilter = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(reimbursementStatusFilter, nameof(reimbursementStatusFilter), required: false);
            WorkflowExpression.Validate(reimbursementName, nameof(reimbursementName), required: false);
            WorkflowExpression.Validate(departmentFilter, nameof(departmentFilter), required: false);
            return new DeferredBodyAction<ResultIPageV2ExpenseResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetExtPayItemData))]
        public IBodyWorkflowAction<ResultIPageV2ExternalPayItemResp> GetExtPayItemData([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> employeeCode = null, [WorkflowExpression] Func<string> businessSalaryItemId = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> businessSalaryItemFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2ExternalPayItemResp> __BuildGetExtPayItemData(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> employeeCode = null, WorkflowExpression<string> businessSalaryItemId = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> businessSalaryItemFilter = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(employeeCode, nameof(employeeCode), required: false);
            WorkflowExpression.Validate(businessSalaryItemId, nameof(businessSalaryItemId), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(businessSalaryItemFilter, nameof(businessSalaryItemFilter), required: false);
            return new DeferredBodyAction<ResultIPageV2ExternalPayItemResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetExtPayItemList))]
        public IBodyWorkflowAction<ResultIPageV2ExtPayItemResp> GetExtPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> paymentType = null, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2ExtPayItemResp> __BuildGetExtPayItemList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> paymentType = null, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(paymentType, nameof(paymentType), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2ExtPayItemResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetFixedPayItemData))]
        public IBodyWorkflowAction<ResultIPageV2FixedPayItemResp> GetFixedPayItemData([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> payrollItemId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2FixedPayItemResp> __BuildGetFixedPayItemData(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> payrollItemId = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(payrollItemId, nameof(payrollItemId), required: false);
            return new DeferredBodyAction<ResultIPageV2FixedPayItemResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetLabelList))]
        public IBodyWorkflowAction<ResultIPageV2LabelResp> GetLabelList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> labelCode = null, [WorkflowExpression] Func<string> labelName = null, [WorkflowExpression] Func<int> labelStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2LabelResp> __BuildGetLabelList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> labelCode = null, WorkflowExpression<string> labelName = null, WorkflowExpression<int> labelStatus = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(labelCode, nameof(labelCode), required: false);
            WorkflowExpression.Validate(labelName, nameof(labelName), required: false);
            WorkflowExpression.Validate(labelStatus, nameof(labelStatus), required: false);
            return new DeferredBodyAction<ResultIPageV2LabelResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetLeaveApplicationList))]
        public IBodyWorkflowAction<ResultIPageV2LeaveApplicationResp> GetLeaveApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> holidayType = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> holidayDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2LeaveApplicationResp> __BuildGetLeaveApplicationList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> holidayType = null, WorkflowExpression<string> status = null, WorkflowExpression<string> holidayDate = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(holidayType, nameof(holidayType), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(holidayDate, nameof(holidayDate), required: false);
            return new DeferredBodyAction<ResultIPageV2LeaveApplicationResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetPayItemList))]
        public IBodyWorkflowAction<ResultIPageV2PayItemResp> GetPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2PayItemResp> __BuildGetPayItemList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> name = null, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2PayItemResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetPayrunList))]
        public IBodyWorkflowAction<ResultIPageV2PayrollPlanResp> GetPayrunList([WorkflowExpression] Func<string> status, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2PayrollPlanResp> __BuildGetPayrunList(WorkflowExpression<string> status, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: true);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<ResultIPageV2PayrollPlanResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetPositionList))]
        public IBodyWorkflowAction<ResultIPageV2PositionResp> GetPositionList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> positionCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2PositionResp> __BuildGetPositionList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> name = null, WorkflowExpression<string> positionCode = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(positionCode, nameof(positionCode), required: false);
            return new DeferredBodyAction<ResultIPageV2PositionResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetRosterDataList))]
        public IBodyWorkflowAction<ResultListV2RosterResp> GetRosterDataList([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendCalculationId = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> englishName = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> surnameEnglish = null, [WorkflowExpression] Func<string> personalNameEnglish = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultListV2RosterResp> __BuildGetRosterDataList(WorkflowExpression<string> startDate, WorkflowExpression<string> endDate, WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> attendCalculationId = null, WorkflowExpression<string> departmentId = null, WorkflowExpression<string> positionId = null, WorkflowExpression<string> statusFilter = null, WorkflowExpression<string> englishName = null, WorkflowExpression<string> code = null, WorkflowExpression<string> surnameEnglish = null, WorkflowExpression<string> personalNameEnglish = null)
        {
            WorkflowExpression.Validate(startDate, nameof(startDate), required: true);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(attendCalculationId, nameof(attendCalculationId), required: false);
            WorkflowExpression.Validate(departmentId, nameof(departmentId), required: false);
            WorkflowExpression.Validate(positionId, nameof(positionId), required: false);
            WorkflowExpression.Validate(statusFilter, nameof(statusFilter), required: false);
            WorkflowExpression.Validate(englishName, nameof(englishName), required: false);
            WorkflowExpression.Validate(code, nameof(code), required: false);
            WorkflowExpression.Validate(surnameEnglish, nameof(surnameEnglish), required: false);
            WorkflowExpression.Validate(personalNameEnglish, nameof(personalNameEnglish), required: false);
            return new DeferredBodyAction<ResultListV2RosterResp>(() =>
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
        [WorkflowExpressionFactory(nameof(__BuildGetTimesheetList))]
        public IBodyWorkflowAction<ResultIPageV2TimesheetResp> GetTimesheetList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2TimesheetResp> __BuildGetTimesheetList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> type = null, WorkflowExpression<string> date = null, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2TimesheetResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetVarPayItemData))]
        public IBodyWorkflowAction<ResultIPageV2VarPayItemResp> GetVarPayItemData([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> payrollItemId = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> payrollItemIdFilter = null, [WorkflowExpression] Func<string> payrollPlanId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2VarPayItemResp> __BuildGetVarPayItemData(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> employeeId = null, WorkflowExpression<string> payrollItemId = null, WorkflowExpression<string> employeeIdFilter = null, WorkflowExpression<string> payrollItemIdFilter = null, WorkflowExpression<string> payrollPlanId = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: false);
            WorkflowExpression.Validate(payrollItemId, nameof(payrollItemId), required: false);
            WorkflowExpression.Validate(employeeIdFilter, nameof(employeeIdFilter), required: false);
            WorkflowExpression.Validate(payrollItemIdFilter, nameof(payrollItemIdFilter), required: false);
            WorkflowExpression.Validate(payrollPlanId, nameof(payrollPlanId), required: false);
            return new DeferredBodyAction<ResultIPageV2VarPayItemResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkLocationList))]
        public IBodyWorkflowAction<ResultIPageV2WorkLocationResp> GetWorkLocationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> attendanceAddressCode = null, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultIPageV2WorkLocationResp> __BuildGetWorkLocationList(WorkflowExpression<string> q = null, WorkflowExpression<int> current = null, WorkflowExpression<int> size = null, WorkflowExpression<string> name = null, WorkflowExpression<string> attendanceAddressCode = null, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(attendanceAddressCode, nameof(attendanceAddressCode), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<ResultIPageV2WorkLocationResp>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCardById))]
        public IBodyWorkflowAction<ResultBoolean> UpdateCardById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyisInValid = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateCardById(WorkflowExpression<string> bodyid, WorkflowExpression<bool> bodyisInValid = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyisInValid, nameof(bodyisInValid), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCostCenterInfo))]
        public IBodyWorkflowAction<ResultBoolean> UpdateCostCenterInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateCostCenterInfo(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodycostCenterCode = null, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDepartmentInfo))]
        public IBodyWorkflowAction<ResultBoolean> UpdateDepartmentInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydepartmentCode = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateDepartmentInfo(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodydepartmentCode = null, WorkflowExpression<string> bodyparentId = null, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodydepartmentCode, nameof(bodydepartmentCode), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEmployeeInfo))]
        public IBodyWorkflowAction<ResultBoolean> UpdateEmployeeInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyenglishName = null, [WorkflowExpression] Func<string> bodychineseName = null, [WorkflowExpression] Func<string> bodysex = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyidentityCard = null, [WorkflowExpression] Func<string> bodybankCard = null, [WorkflowExpression] Func<string> bodynickName = null, [WorkflowExpression] Func<string> bodyeducation = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<string> bodyemergencyContactName = null, [WorkflowExpression] Func<string> bodyemergencyContactRelation = null, [WorkflowExpression] Func<string> bodyemergencyContactPhone = null, [WorkflowExpression] Func<string> bodybankName = null, [WorkflowExpression] Func<string> bodybankBranchNumber = null, [WorkflowExpression] Func<string> bodybankAccountNo = null, [WorkflowExpression] Func<string> bodybankCode = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyregionCode = null, [WorkflowExpression] Func<string> bodyidentityCardHk = null, [WorkflowExpression] Func<string> bodypassportNumber = null, [WorkflowExpression] Func<string> bodypassportIssuingPlace = null, [WorkflowExpression] Func<string> bodyspouseName = null, [WorkflowExpression] Func<string> bodyspouseIdentityCardHk = null, [WorkflowExpression] Func<string> bodyspousePassportNumber = null, [WorkflowExpression] Func<string> bodyspousePassportIssuingPlace = null, [WorkflowExpression] Func<string> bodypostalAddress = null, [WorkflowExpression] Func<string> bodyemployerName = null, [WorkflowExpression] Func<string> bodyhometown = null, [WorkflowExpression] Func<string> bodynation = null, [WorkflowExpression] Func<string> bodypoliticalStatus = null, [WorkflowExpression] Func<string> bodyhighestEducation = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodyprobation = null, [WorkflowExpression] Func<bool> bodyisDisabled = null, [WorkflowExpression] Func<bool> bodyisForeignNationality = null, [WorkflowExpression] Func<string> bodydomicileLocation = null, [WorkflowExpression] Func<string> bodycertificateType = null, [WorkflowExpression] Func<string> bodycertificateNumber = null, [WorkflowExpression] Func<bool> bodyisMartyrDependents = null, [WorkflowExpression] Func<string> bodyoccupationTaxNumber = null, [WorkflowExpression] Func<string> bodynonLocalBlueCardNumber = null, [WorkflowExpression] Func<bool> bodyisForeignEmployees = null, [WorkflowExpression] Func<string> bodyweeklyLeaveWorkAgreement = null, [WorkflowExpression] Func<string> bodyemployeeType = null, [WorkflowExpression] Func<string> bodyjobLevel = null, [WorkflowExpression] Func<string> bodypost = null, [WorkflowExpression] Func<string> bodysalaryScale = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodyrecruitmentSource = null, [WorkflowExpression] Func<string> bodygraduatedSchool = null, [WorkflowExpression] Func<string> bodyprofession = null, [WorkflowExpression] Func<string> bodyappellation = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyhomePhone = null, [WorkflowExpression] Func<string> bodyofficePhone = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyprovince = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycontractEndDate = null, [WorkflowExpression] Func<string> bodytaxIdentity = null, [WorkflowExpression] Func<string> bodyotherIncomeName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateEmployeeInfo(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyenglishName = null, WorkflowExpression<string> bodychineseName = null, WorkflowExpression<string> bodysex = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyidentityCard = null, WorkflowExpression<string> bodybankCard = null, WorkflowExpression<string> bodynickName = null, WorkflowExpression<string> bodyeducation = null, WorkflowExpression<string> bodynationality = null, WorkflowExpression<string> bodymaritalStatus = null, WorkflowExpression<string> bodyemergencyContactName = null, WorkflowExpression<string> bodyemergencyContactRelation = null, WorkflowExpression<string> bodyemergencyContactPhone = null, WorkflowExpression<string> bodybankName = null, WorkflowExpression<string> bodybankBranchNumber = null, WorkflowExpression<string> bodybankAccountNo = null, WorkflowExpression<string> bodybankCode = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodyregionCode = null, WorkflowExpression<string> bodyidentityCardHk = null, WorkflowExpression<string> bodypassportNumber = null, WorkflowExpression<string> bodypassportIssuingPlace = null, WorkflowExpression<string> bodyspouseName = null, WorkflowExpression<string> bodyspouseIdentityCardHk = null, WorkflowExpression<string> bodyspousePassportNumber = null, WorkflowExpression<string> bodyspousePassportIssuingPlace = null, WorkflowExpression<string> bodypostalAddress = null, WorkflowExpression<string> bodyemployerName = null, WorkflowExpression<string> bodyhometown = null, WorkflowExpression<string> bodynation = null, WorkflowExpression<string> bodypoliticalStatus = null, WorkflowExpression<string> bodyhighestEducation = null, WorkflowExpression<string> bodyworkDate = null, WorkflowExpression<string> bodyconfirmationDate = null, WorkflowExpression<string> bodyprobation = null, WorkflowExpression<bool> bodyisDisabled = null, WorkflowExpression<bool> bodyisForeignNationality = null, WorkflowExpression<string> bodydomicileLocation = null, WorkflowExpression<string> bodycertificateType = null, WorkflowExpression<string> bodycertificateNumber = null, WorkflowExpression<bool> bodyisMartyrDependents = null, WorkflowExpression<string> bodyoccupationTaxNumber = null, WorkflowExpression<string> bodynonLocalBlueCardNumber = null, WorkflowExpression<bool> bodyisForeignEmployees = null, WorkflowExpression<string> bodyweeklyLeaveWorkAgreement = null, WorkflowExpression<string> bodyemployeeType = null, WorkflowExpression<string> bodyjobLevel = null, WorkflowExpression<string> bodypost = null, WorkflowExpression<string> bodysalaryScale = null, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodyrecruitmentSource = null, WorkflowExpression<string> bodygraduatedSchool = null, WorkflowExpression<string> bodyprofession = null, WorkflowExpression<string> bodyappellation = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodyhomePhone = null, WorkflowExpression<string> bodyofficePhone = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodyprovince = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodypostcode = null, WorkflowExpression<string> bodycontractEndDate = null, WorkflowExpression<string> bodytaxIdentity = null, WorkflowExpression<string> bodyotherIncomeName = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyenglishName, nameof(bodyenglishName), required: false);
            WorkflowExpression.Validate(bodychineseName, nameof(bodychineseName), required: false);
            WorkflowExpression.Validate(bodysex, nameof(bodysex), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyidentityCard, nameof(bodyidentityCard), required: false);
            WorkflowExpression.Validate(bodybankCard, nameof(bodybankCard), required: false);
            WorkflowExpression.Validate(bodynickName, nameof(bodynickName), required: false);
            WorkflowExpression.Validate(bodyeducation, nameof(bodyeducation), required: false);
            WorkflowExpression.Validate(bodynationality, nameof(bodynationality), required: false);
            WorkflowExpression.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            WorkflowExpression.Validate(bodyemergencyContactName, nameof(bodyemergencyContactName), required: false);
            WorkflowExpression.Validate(bodyemergencyContactRelation, nameof(bodyemergencyContactRelation), required: false);
            WorkflowExpression.Validate(bodyemergencyContactPhone, nameof(bodyemergencyContactPhone), required: false);
            WorkflowExpression.Validate(bodybankName, nameof(bodybankName), required: false);
            WorkflowExpression.Validate(bodybankBranchNumber, nameof(bodybankBranchNumber), required: false);
            WorkflowExpression.Validate(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            WorkflowExpression.Validate(bodybankCode, nameof(bodybankCode), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodyregionCode, nameof(bodyregionCode), required: false);
            WorkflowExpression.Validate(bodyidentityCardHk, nameof(bodyidentityCardHk), required: false);
            WorkflowExpression.Validate(bodypassportNumber, nameof(bodypassportNumber), required: false);
            WorkflowExpression.Validate(bodypassportIssuingPlace, nameof(bodypassportIssuingPlace), required: false);
            WorkflowExpression.Validate(bodyspouseName, nameof(bodyspouseName), required: false);
            WorkflowExpression.Validate(bodyspouseIdentityCardHk, nameof(bodyspouseIdentityCardHk), required: false);
            WorkflowExpression.Validate(bodyspousePassportNumber, nameof(bodyspousePassportNumber), required: false);
            WorkflowExpression.Validate(bodyspousePassportIssuingPlace, nameof(bodyspousePassportIssuingPlace), required: false);
            WorkflowExpression.Validate(bodypostalAddress, nameof(bodypostalAddress), required: false);
            WorkflowExpression.Validate(bodyemployerName, nameof(bodyemployerName), required: false);
            WorkflowExpression.Validate(bodyhometown, nameof(bodyhometown), required: false);
            WorkflowExpression.Validate(bodynation, nameof(bodynation), required: false);
            WorkflowExpression.Validate(bodypoliticalStatus, nameof(bodypoliticalStatus), required: false);
            WorkflowExpression.Validate(bodyhighestEducation, nameof(bodyhighestEducation), required: false);
            WorkflowExpression.Validate(bodyworkDate, nameof(bodyworkDate), required: false);
            WorkflowExpression.Validate(bodyconfirmationDate, nameof(bodyconfirmationDate), required: false);
            WorkflowExpression.Validate(bodyprobation, nameof(bodyprobation), required: false);
            WorkflowExpression.Validate(bodyisDisabled, nameof(bodyisDisabled), required: false);
            WorkflowExpression.Validate(bodyisForeignNationality, nameof(bodyisForeignNationality), required: false);
            WorkflowExpression.Validate(bodydomicileLocation, nameof(bodydomicileLocation), required: false);
            WorkflowExpression.Validate(bodycertificateType, nameof(bodycertificateType), required: false);
            WorkflowExpression.Validate(bodycertificateNumber, nameof(bodycertificateNumber), required: false);
            WorkflowExpression.Validate(bodyisMartyrDependents, nameof(bodyisMartyrDependents), required: false);
            WorkflowExpression.Validate(bodyoccupationTaxNumber, nameof(bodyoccupationTaxNumber), required: false);
            WorkflowExpression.Validate(bodynonLocalBlueCardNumber, nameof(bodynonLocalBlueCardNumber), required: false);
            WorkflowExpression.Validate(bodyisForeignEmployees, nameof(bodyisForeignEmployees), required: false);
            WorkflowExpression.Validate(bodyweeklyLeaveWorkAgreement, nameof(bodyweeklyLeaveWorkAgreement), required: false);
            WorkflowExpression.Validate(bodyemployeeType, nameof(bodyemployeeType), required: false);
            WorkflowExpression.Validate(bodyjobLevel, nameof(bodyjobLevel), required: false);
            WorkflowExpression.Validate(bodypost, nameof(bodypost), required: false);
            WorkflowExpression.Validate(bodysalaryScale, nameof(bodysalaryScale), required: false);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodyrecruitmentSource, nameof(bodyrecruitmentSource), required: false);
            WorkflowExpression.Validate(bodygraduatedSchool, nameof(bodygraduatedSchool), required: false);
            WorkflowExpression.Validate(bodyprofession, nameof(bodyprofession), required: false);
            WorkflowExpression.Validate(bodyappellation, nameof(bodyappellation), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodyhomePhone, nameof(bodyhomePhone), required: false);
            WorkflowExpression.Validate(bodyofficePhone, nameof(bodyofficePhone), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodyprovince, nameof(bodyprovince), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodypostcode, nameof(bodypostcode), required: false);
            WorkflowExpression.Validate(bodycontractEndDate, nameof(bodycontractEndDate), required: false);
            WorkflowExpression.Validate(bodytaxIdentity, nameof(bodytaxIdentity), required: false);
            WorkflowExpression.Validate(bodyotherIncomeName, nameof(bodyotherIncomeName), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateExpenseApplication))]
        public IBodyWorkflowAction<ResultBoolean> UpdateExpenseApplication([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyreimbursementName = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateExpenseApplication(WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodyreimbursementName = null, WorkflowExpression<double> bodyamount = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodyreimbursementName, nameof(bodyreimbursementName), required: false);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateExternalSalary))]
        public IBodyWorkflowAction<ResultBoolean> UpdateExternalSalary([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyoccurrenceDate = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateExternalSalary(WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodycode = null, WorkflowExpression<double> bodymoney = null, WorkflowExpression<string> bodyoccurrenceDate = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodyexpirationDate = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: false);
            WorkflowExpression.Validate(bodyoccurrenceDate, nameof(bodyoccurrenceDate), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFixedSalary))]
        public IBodyWorkflowAction<ResultBoolean> UpdateFixedSalary([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodypayrollItemId = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateFixedSalary(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodypayrollItemId = null, WorkflowExpression<double> bodymoney = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodypayrollItemId, nameof(bodypayrollItemId), required: false);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLabelInfo))]
        public IBodyWorkflowAction<ResultBoolean> UpdateLabelInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylabelCode = null, [WorkflowExpression] Func<string> bodylabelName = null, [WorkflowExpression] Func<int> bodylabelStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateLabelInfo(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodylabelCode = null, WorkflowExpression<string> bodylabelName = null, WorkflowExpression<int> bodylabelStatus = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodylabelCode, nameof(bodylabelCode), required: false);
            WorkflowExpression.Validate(bodylabelName, nameof(bodylabelName), required: false);
            WorkflowExpression.Validate(bodylabelStatus, nameof(bodylabelStatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLeaveApplication))]
        public IBodyWorkflowAction<ResultBoolean> UpdateLeaveApplication([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyholidayType = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<double> bodyleaveTime = null, [WorkflowExpression] Func<string> bodytimeType = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyholidayDate = null, [WorkflowExpression] Func<string> bodytime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateLeaveApplication(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyholidayType = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<double> bodyleaveTime = null, WorkflowExpression<string> bodytimeType = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodyholidayDate = null, WorkflowExpression<string> bodytime = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyholidayType, nameof(bodyholidayType), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodyleaveTime, nameof(bodyleaveTime), required: false);
            WorkflowExpression.Validate(bodytimeType, nameof(bodytimeType), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodyholidayDate, nameof(bodyholidayDate), required: false);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePositionInfo))]
        public IBodyWorkflowAction<ResultBoolean> UpdatePositionInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdatePositionInfo(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodypositionCode = null, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodypositionCode, nameof(bodypositionCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRosterData))]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterData([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyshiftIn = null, [WorkflowExpression] Func<string> bodyshiftOff = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyacrossTheNight = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateRosterData(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyshiftIn = null, WorkflowExpression<string> bodyshiftOff = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyshiftStatus = null, WorkflowExpression<string> bodyaddressCardId = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodydateType = null, WorkflowExpression<string> bodyacrossTheNight = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyshiftIn, nameof(bodyshiftIn), required: false);
            WorkflowExpression.Validate(bodyshiftOff, nameof(bodyshiftOff), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyshiftStatus, nameof(bodyshiftStatus), required: false);
            WorkflowExpression.Validate(bodyaddressCardId, nameof(bodyaddressCardId), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodydateType, nameof(bodydateType), required: false);
            WorkflowExpression.Validate(bodyacrossTheNight, nameof(bodyacrossTheNight), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRosterItem))]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterItem([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateRosterItem(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodycode = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateShiftTemplate))]
        public IBodyWorkflowAction<ResultBoolean> UpdateShiftTemplate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyshiftIn = null, [WorkflowExpression] Func<string> bodyshiftOff = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyattendanceAddressId = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodylunchStartTime = null, [WorkflowExpression] Func<string> bodylunchEndTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateShiftTemplate(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyshiftIn = null, WorkflowExpression<string> bodyshiftOff = null, WorkflowExpression<int> bodymealTime = null, WorkflowExpression<string> bodyattendanceAddressId = null, WorkflowExpression<string> bodydateType = null, WorkflowExpression<string> bodylunchStartTime = null, WorkflowExpression<string> bodylunchEndTime = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyshiftIn, nameof(bodyshiftIn), required: false);
            WorkflowExpression.Validate(bodyshiftOff, nameof(bodyshiftOff), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            WorkflowExpression.Validate(bodyattendanceAddressId, nameof(bodyattendanceAddressId), required: false);
            WorkflowExpression.Validate(bodydateType, nameof(bodydateType), required: false);
            WorkflowExpression.Validate(bodylunchStartTime, nameof(bodylunchStartTime), required: false);
            WorkflowExpression.Validate(bodylunchEndTime, nameof(bodylunchEndTime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTenantInfo))]
        public IBodyWorkflowAction<ResultBoolean> UpdateTenantInfo([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodybusinessRegistrationNumber = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodybankName = null, [WorkflowExpression] Func<string> bodybankBranchCode = null, [WorkflowExpression] Func<string> bodybankAccountNo = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateTenantInfo(WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodybusinessRegistrationNumber = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodybankName = null, WorkflowExpression<string> bodybankBranchCode = null, WorkflowExpression<string> bodybankAccountNo = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodybusinessRegistrationNumber, nameof(bodybusinessRegistrationNumber), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodybankName, nameof(bodybankName), required: false);
            WorkflowExpression.Validate(bodybankBranchCode, nameof(bodybankBranchCode), required: false);
            WorkflowExpression.Validate(bodybankAccountNo, nameof(bodybankAccountNo), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTimesheet))]
        public IBodyWorkflowAction<ResultBoolean> UpdateTimesheet([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bool> bodyisCrossTheSky = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<int> bodymealTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateTimesheet(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodydate = null, WorkflowExpression<bool> bodyisCrossTheSky = null, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<int> bodymealTime = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodyisCrossTheSky, nameof(bodyisCrossTheSky), required: false);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodymealTime, nameof(bodymealTime), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateVarSalary))]
        public IBodyWorkflowAction<ResultBoolean> UpdateVarSalary([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateVarSalary(WorkflowExpression<string> bodyid, WorkflowExpression<double> bodymoney = null, WorkflowExpression<string> bodyremark = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodymoney, nameof(bodymoney), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkLocation))]
        public IBodyWorkflowAction<ResultBoolean> UpdateWorkLocation([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyregion = null, [WorkflowExpression] Func<string> bodyattendanceAddressCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyareaCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemhk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultBoolean> __BuildUpdateWorkLocation(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyname = null, WorkflowExpression<int> bodyregion = null, WorkflowExpression<string> bodyattendanceAddressCode = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyareaCode = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            WorkflowExpression.Validate(bodyattendanceAddressCode, nameof(bodyattendanceAddressCode), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyareaCode, nameof(bodyareaCode), required: false);
            return new DeferredBodyAction<ResultBoolean>(() =>
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