//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workstemau
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkstemauActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _001addFixedSalaryData([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodypayrollItemId, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<double> bodytotalLimitAmount = null, [WorkflowExpression] Func<double> bodypaidAmount = null, [WorkflowExpression] Func<double> bodysurplusAmount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/addFixedSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["payrollItemId"] = SourceExpressionConverter.ConvertToken(bodypayrollItemId);
                if (bodymoney != null)
                {
                    body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodytotalLimitAmount != null)
                {
                    body["totalLimitAmount"] = SourceExpressionConverter.ConvertToken(bodytotalLimitAmount);
                    bodypropCount++;
                }

                if (bodypaidAmount != null)
                {
                    body["paidAmount"] = SourceExpressionConverter.ConvertToken(bodypaidAmount);
                    bodypropCount++;
                }

                if (bodysurplusAmount != null)
                {
                    body["surplusAmount"] = SourceExpressionConverter.ConvertToken(bodysurplusAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3TenantResp> _001getCompanyInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getCompanyInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3TenantResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _002deleteFixedSalaryDataById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/deleteFixedSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3SysEnterpriseUserResp> _002getUserList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getUserList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV3SysEnterpriseUserResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3SysEnterpriseUserResp> _003getUserInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getUserInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3SysEnterpriseUserResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _003updateFixedSalaryDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodypayrollItemId = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<double> bodytotalLimitAmount = null, [WorkflowExpression] Func<double> bodypaidAmount = null, [WorkflowExpression] Func<double> bodysurplusAmount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/updateFixedSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypayrollItemId != null)
                {
                    body["payrollItemId"] = SourceExpressionConverter.ConvertToken(bodypayrollItemId);
                    bodypropCount++;
                }

                if (bodymoney != null)
                {
                    body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodytotalLimitAmount != null)
                {
                    body["totalLimitAmount"] = SourceExpressionConverter.ConvertToken(bodytotalLimitAmount);
                    bodypropCount++;
                }

                if (bodypaidAmount != null)
                {
                    body["paidAmount"] = SourceExpressionConverter.ConvertToken(bodypaidAmount);
                    bodypropCount++;
                }

                if (bodysurplusAmount != null)
                {
                    body["surplusAmount"] = SourceExpressionConverter.ConvertToken(bodysurplusAmount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _004addLocationInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<double> bodylongitude, [WorkflowExpression] Func<double> bodylatitude, [WorkflowExpression] Func<string> bodyareaCode, [WorkflowExpression] Func<int> bodyregion = null, [WorkflowExpression] Func<bool> bodyisEnableGps = null, [WorkflowExpression] Func<bool> bodyisEnableBluetooth = null, [WorkflowExpression] Func<string> bodyattendanceAddressCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymapType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/addLocationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
                body["longitude"] = SourceExpressionConverter.ConvertToken(bodylongitude);
                bodypropCount++;
                body["latitude"] = SourceExpressionConverter.ConvertToken(bodylatitude);
                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodyisEnableGps != null)
                {
                    body["isEnableGps"] = SourceExpressionConverter.ConvertToken(bodyisEnableGps);
                    bodypropCount++;
                }

                if (bodyisEnableBluetooth != null)
                {
                    body["isEnableBluetooth"] = SourceExpressionConverter.ConvertToken(bodyisEnableBluetooth);
                    bodypropCount++;
                }

                if (bodyattendanceAddressCode != null)
                {
                    body["attendanceAddressCode"] = SourceExpressionConverter.ConvertToken(bodyattendanceAddressCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodymapType != null)
                {
                    body["mapType"] = SourceExpressionConverter.ConvertToken(bodymapType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["areaCode"] = SourceExpressionConverter.ConvertToken(bodyareaCode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3PayrollFixedResp> _004getFixedSalaryDataByEmployeeId([WorkflowExpression] Func<string> employeeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getFixedSalaryDataByEmployeeId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV3PayrollFixedResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _005addVariableSalaryData([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodypayrollItemId, [WorkflowExpression] Func<double> bodymoney, [WorkflowExpression] Func<string> bodypayrollDate, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodydataType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/addVariableSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["payrollItemId"] = SourceExpressionConverter.ConvertToken(bodypayrollItemId);
                bodypropCount++;
                body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                bodypropCount++;
                body["payrollDate"] = SourceExpressionConverter.ConvertToken(bodypayrollDate);
                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodydataType != null)
                {
                    body["dataType"] = SourceExpressionConverter.ConvertToken(bodydataType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _005deleteLocationById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/deleteLocationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _006deleteVariableSalaryDataById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/deleteVariableSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _006updateLocationById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<double> bodylongitude = null, [WorkflowExpression] Func<double> bodylatitude = null, [WorkflowExpression] Func<int> bodyregion = null, [WorkflowExpression] Func<bool> bodyisEnableGps = null, [WorkflowExpression] Func<bool> bodyisEnableBluetooth = null, [WorkflowExpression] Func<string> bodyattendanceAddressCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymapType = null, [WorkflowExpression] Func<string> bodyareaCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/updateLocationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodylongitude != null)
                {
                    body["longitude"] = SourceExpressionConverter.ConvertToken(bodylongitude);
                    bodypropCount++;
                }

                if (bodylatitude != null)
                {
                    body["latitude"] = SourceExpressionConverter.ConvertToken(bodylatitude);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodyisEnableGps != null)
                {
                    body["isEnableGps"] = SourceExpressionConverter.ConvertToken(bodyisEnableGps);
                    bodypropCount++;
                }

                if (bodyisEnableBluetooth != null)
                {
                    body["isEnableBluetooth"] = SourceExpressionConverter.ConvertToken(bodyisEnableBluetooth);
                    bodypropCount++;
                }

                if (bodyattendanceAddressCode != null)
                {
                    body["attendanceAddressCode"] = SourceExpressionConverter.ConvertToken(bodyattendanceAddressCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodymapType != null)
                {
                    body["mapType"] = SourceExpressionConverter.ConvertToken(bodymapType);
                    bodypropCount++;
                }

                if (bodyareaCode != null)
                {
                    body["areaCode"] = SourceExpressionConverter.ConvertToken(bodyareaCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3AttAddressResp> _007getLocationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getLocationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3AttAddressResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _007updateVariableSalaryDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/updateVariableSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodymoney != null)
                {
                    body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AttAddressResp> _008getLocationInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getLocationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3AttAddressResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollNonFixedResp> _008getVariableSalaryDataList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> payrollDateFilter = null, [WorkflowExpression] Func<string> moneyFilter = null, [WorkflowExpression] Func<string> payrollItemIdFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> bizLabelIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getVariableSalaryDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = SourceExpressionConverter.ConvertO(hireTypeFilter);
                if (payrollDateFilter != null)
                    callPayload.Queries["payrollDateFilter"] = SourceExpressionConverter.ConvertO(payrollDateFilter);
                if (moneyFilter != null)
                    callPayload.Queries["moneyFilter"] = SourceExpressionConverter.ConvertO(moneyFilter);
                if (payrollItemIdFilter != null)
                    callPayload.Queries["payrollItemIdFilter"] = SourceExpressionConverter.ConvertO(payrollItemIdFilter);
                if (calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = SourceExpressionConverter.ConvertO(calculateSalaryTypeFilter);
                if (bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = SourceExpressionConverter.ConvertO(bizLabelIds);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3PayrollNonFixedResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _009addExternalSalaryData([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodybusinessSalaryItemId, [WorkflowExpression] Func<double> bodymoney, [WorkflowExpression] Func<string> bodyoccurrenceDate, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/addExternalSalaryData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["businessSalaryItemId"] = SourceExpressionConverter.ConvertToken(bodybusinessSalaryItemId);
                bodypropCount++;
                body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                bodypropCount++;
                body["occurrenceDate"] = SourceExpressionConverter.ConvertToken(bodyoccurrenceDate);
                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodyexpirationDate != null)
                {
                    body["expirationDate"] = SourceExpressionConverter.ConvertToken(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AttRuleResp> _009getLocationAttendanceRulesById([WorkflowExpression] Func<string> workLocationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getLocationAttendanceRulesById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workLocationId"] = SourceExpressionConverter.ConvertO(workLocationId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3AttRuleResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _010addDepartmentInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydepartmentCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/addDepartmentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydepartmentCode != null)
                {
                    body["departmentCode"] = SourceExpressionConverter.ConvertToken(bodydepartmentCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _010deleteExternalSalaryDataById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/deleteExternalSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _011deleteDepartmentById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/deleteDepartmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _011updateExternalSalaryDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyemployeeId = null, [WorkflowExpression] Func<string> bodybusinessSalaryItemId = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyoccurrenceDate = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/updateExternalSalaryDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyemployeeId != null)
                {
                    body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                    bodypropCount++;
                }

                if (bodybusinessSalaryItemId != null)
                {
                    body["businessSalaryItemId"] = SourceExpressionConverter.ConvertToken(bodybusinessSalaryItemId);
                    bodypropCount++;
                }

                if (bodymoney != null)
                {
                    body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                    bodypropCount++;
                }

                if (bodyoccurrenceDate != null)
                {
                    body["occurrenceDate"] = SourceExpressionConverter.ConvertToken(bodyoccurrenceDate);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodyexpirationDate != null)
                {
                    body["expirationDate"] = SourceExpressionConverter.ConvertToken(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayrollResp> _012getExternalSalaryDataList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> businessSalaryItemFilter = null, [WorkflowExpression] Func<string> occurrenceDateFilter = null, [WorkflowExpression] Func<string> moneyFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> labelFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getExternalSalaryDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = SourceExpressionConverter.ConvertO(hireTypeFilter);
                if (businessSalaryItemFilter != null)
                    callPayload.Queries["businessSalaryItemFilter"] = SourceExpressionConverter.ConvertO(businessSalaryItemFilter);
                if (occurrenceDateFilter != null)
                    callPayload.Queries["occurrenceDateFilter"] = SourceExpressionConverter.ConvertO(occurrenceDateFilter);
                if (moneyFilter != null)
                    callPayload.Queries["moneyFilter"] = SourceExpressionConverter.ConvertO(moneyFilter);
                if (calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = SourceExpressionConverter.ConvertO(calculateSalaryTypeFilter);
                if (labelFilter != null)
                    callPayload.Queries["labelFilter"] = SourceExpressionConverter.ConvertO(labelFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3ExternalPayrollResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _012updateDepartmentById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydepartmentCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/updateDepartmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydepartmentCode != null)
                {
                    body["departmentCode"] = SourceExpressionConverter.ConvertToken(bodydepartmentCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3DepartmentResp> _013getDepartmentList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getDepartmentList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3DepartmentResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanResp> _013getPayrollRunList([WorkflowExpression] Func<string> status, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getPayrollRunList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3PayrollPlanResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _014addPositionInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/addPositionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypositionCode != null)
                {
                    body["positionCode"] = SourceExpressionConverter.ConvertToken(bodypositionCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollPlanDetailResp> _014getPayrollRunDataList([WorkflowExpression] Func<string> planId, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getPayrollRunDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["planId"] = SourceExpressionConverter.ConvertO(planId);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3PayrollPlanDetailResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _015deletePositionById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/deletePositionById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3PayrollPlanDetailResp> _015getPayrollDetailsInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getPayrollDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV3PayrollPlanDetailResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollRegResp> _016getPayrollPolicyList([WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> q = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getPayrollPolicyList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3PayrollRegResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _016updatePositionById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/updatePositionById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypositionCode != null)
                {
                    body["positionCode"] = SourceExpressionConverter.ConvertToken(bodypositionCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3PayrollRegResp> _017getPayrollPolicyInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getPayrollPolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3PayrollRegResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PositionResp> _017getPositionList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getPositionList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3PositionResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _018addCostCenterInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/addCostCenterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodycostCenterCode != null)
                {
                    body["costCenterCode"] = SourceExpressionConverter.ConvertToken(bodycostCenterCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3PayrollItemResp> _018getPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> nameFilter = null, [WorkflowExpression] Func<string> paymentTypeFilter = null, [WorkflowExpression] Func<string> payrollItemTypeId = null, [WorkflowExpression] Func<string> statusFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (nameFilter != null)
                    callPayload.Queries["nameFilter"] = SourceExpressionConverter.ConvertO(nameFilter);
                if (paymentTypeFilter != null)
                    callPayload.Queries["paymentTypeFilter"] = SourceExpressionConverter.ConvertO(paymentTypeFilter);
                if (payrollItemTypeId != null)
                    callPayload.Queries["payrollItemTypeId"] = SourceExpressionConverter.ConvertO(payrollItemTypeId);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3PayrollItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _019deleteCostCenterById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/deleteCostCenterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3PayrollItemResp> _019getPayItemInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3PayrollItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddEmployeeResp> _01addEmployeeInfo([WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodyenglishName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyemployeeStatus = null, [WorkflowExpression] Func<string> bodysex = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyidentityCard = null, [WorkflowExpression] Func<string> bodychineseName = null, [WorkflowExpression] Func<string> bodysurnameEnglish = null, [WorkflowExpression] Func<string> bodypersonalNameEnglish = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodyemergencyContactName = null, [WorkflowExpression] Func<string> bodyemergencyContactRelation = null, [WorkflowExpression] Func<string> bodyemergencyContactPhone = null, [WorkflowExpression] Func<string> bodybankCode = null, [WorkflowExpression] Func<string> bodybankBranchNumber = null, [WorkflowExpression] Func<string> bodybankAccountNo = null, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodydate1 = null, [WorkflowExpression] Func<string> bodydate2 = null, [WorkflowExpression] Func<string> bodydate3 = null, [WorkflowExpression] Func<string> bodydate4 = null, [WorkflowExpression] Func<string> bodytext1 = null, [WorkflowExpression] Func<string> bodytext2 = null, [WorkflowExpression] Func<string> bodytext3 = null, [WorkflowExpression] Func<string> bodytext4 = null, [WorkflowExpression] Func<string> bodytext5 = null, [WorkflowExpression] Func<string> bodytext6 = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodymobileCardCalType = null, [WorkflowExpression] Func<string> bodyregularType = null, [WorkflowExpression] Func<string> bodyinsurePlanName = null, [WorkflowExpression] Func<string> bodybizLabelIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/addEmployeeInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entryDate"] = SourceExpressionConverter.ConvertToken(bodyentryDate);
                bodypropCount++;
                body["englishName"] = SourceExpressionConverter.ConvertToken(bodyenglishName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyemployeeStatus != null)
                {
                    body["employeeStatus"] = SourceExpressionConverter.ConvertToken(bodyemployeeStatus);
                    bodypropCount++;
                }

                if (bodysex != null)
                {
                    body["sex"] = SourceExpressionConverter.ConvertToken(bodysex);
                    bodypropCount++;
                }

                if (bodynationality != null)
                {
                    body["nationality"] = SourceExpressionConverter.ConvertToken(bodynationality);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["maritalStatus"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                if (bodycountryCode != null)
                {
                    body["countryCode"] = SourceExpressionConverter.ConvertToken(bodycountryCode);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = SourceExpressionConverter.ConvertToken(bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (bodyworkDate != null)
                {
                    body["workDate"] = SourceExpressionConverter.ConvertToken(bodyworkDate);
                    bodypropCount++;
                }

                if (bodybasicPay != null)
                {
                    body["basicPay"] = SourceExpressionConverter.ConvertToken(bodybasicPay);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyidentityCard != null)
                {
                    body["identityCard"] = SourceExpressionConverter.ConvertToken(bodyidentityCard);
                    bodypropCount++;
                }

                if (bodychineseName != null)
                {
                    body["chineseName"] = SourceExpressionConverter.ConvertToken(bodychineseName);
                    bodypropCount++;
                }

                if (bodysurnameEnglish != null)
                {
                    body["surnameEnglish"] = SourceExpressionConverter.ConvertToken(bodysurnameEnglish);
                    bodypropCount++;
                }

                if (bodypersonalNameEnglish != null)
                {
                    body["personalNameEnglish"] = SourceExpressionConverter.ConvertToken(bodypersonalNameEnglish);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = SourceExpressionConverter.ConvertToken(bodybirthday);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactName);
                    bodypropCount++;
                }

                if (bodyemergencyContactRelation != null)
                {
                    body["emergencyContactRelation"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactRelation);
                    bodypropCount++;
                }

                if (bodyemergencyContactPhone != null)
                {
                    body["emergencyContactPhone"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactPhone);
                    bodypropCount++;
                }

                if (bodybankCode != null)
                {
                    body["bankCode"] = SourceExpressionConverter.ConvertToken(bodybankCode);
                    bodypropCount++;
                }

                if (bodybankBranchNumber != null)
                {
                    body["bankBranchNumber"] = SourceExpressionConverter.ConvertToken(bodybankBranchNumber);
                    bodypropCount++;
                }

                if (bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = SourceExpressionConverter.ConvertToken(bodybankAccountNo);
                    bodypropCount++;
                }

                if (bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = SourceExpressionConverter.ConvertToken(bodyconfirmationDate);
                    bodypropCount++;
                }

                if (bodydate1 != null)
                {
                    body["date1"] = SourceExpressionConverter.ConvertToken(bodydate1);
                    bodypropCount++;
                }

                if (bodydate2 != null)
                {
                    body["date2"] = SourceExpressionConverter.ConvertToken(bodydate2);
                    bodypropCount++;
                }

                if (bodydate3 != null)
                {
                    body["date3"] = SourceExpressionConverter.ConvertToken(bodydate3);
                    bodypropCount++;
                }

                if (bodydate4 != null)
                {
                    body["date4"] = SourceExpressionConverter.ConvertToken(bodydate4);
                    bodypropCount++;
                }

                if (bodytext1 != null)
                {
                    body["text1"] = SourceExpressionConverter.ConvertToken(bodytext1);
                    bodypropCount++;
                }

                if (bodytext2 != null)
                {
                    body["text2"] = SourceExpressionConverter.ConvertToken(bodytext2);
                    bodypropCount++;
                }

                if (bodytext3 != null)
                {
                    body["text3"] = SourceExpressionConverter.ConvertToken(bodytext3);
                    bodypropCount++;
                }

                if (bodytext4 != null)
                {
                    body["text4"] = SourceExpressionConverter.ConvertToken(bodytext4);
                    bodypropCount++;
                }

                if (bodytext5 != null)
                {
                    body["text5"] = SourceExpressionConverter.ConvertToken(bodytext5);
                    bodypropCount++;
                }

                if (bodytext6 != null)
                {
                    body["text6"] = SourceExpressionConverter.ConvertToken(bodytext6);
                    bodypropCount++;
                }

                if (bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = SourceExpressionConverter.ConvertToken(bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodypositionId != null)
                {
                    body["positionId"] = SourceExpressionConverter.ConvertToken(bodypositionId);
                    bodypropCount++;
                }

                if (bodyhireType != null)
                {
                    body["hireType"] = SourceExpressionConverter.ConvertToken(bodyhireType);
                    bodypropCount++;
                }

                if (bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = SourceExpressionConverter.ConvertToken(bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = SourceExpressionConverter.ConvertToken(bodyattendCalculationId);
                    bodypropCount++;
                }

                if (bodymobileCardCalType != null)
                {
                    body["mobileCardCalType"] = SourceExpressionConverter.ConvertToken(bodymobileCardCalType);
                    bodypropCount++;
                }

                if (bodyregularType != null)
                {
                    body["regularType"] = SourceExpressionConverter.ConvertToken(bodyregularType);
                    bodypropCount++;
                }

                if (bodyinsurePlanName != null)
                {
                    body["insurePlanName"] = SourceExpressionConverter.ConvertToken(bodyinsurePlanName);
                    bodypropCount++;
                }

                if (bodybizLabelIds != null)
                {
                    body["bizLabelIds"] = SourceExpressionConverter.ConvertToken(bodybizLabelIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3AddEmployeeResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _01addLeaveBalanceAdjustInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyholidayType, [WorkflowExpression] Func<string> bodyoccurrenceTime, [WorkflowExpression] Func<string> bodycause, [WorkflowExpression] Func<string> bodyadjust)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/addLeaveBalanceAdjustInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["holidayType"] = SourceExpressionConverter.ConvertToken(bodyholidayType);
                bodypropCount++;
                body["occurrenceTime"] = SourceExpressionConverter.ConvertToken(bodyoccurrenceTime);
                bodypropCount++;
                body["cause"] = SourceExpressionConverter.ConvertToken(bodycause);
                bodypropCount++;
                body["adjust"] = SourceExpressionConverter.ConvertToken(bodyadjust);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _01addRosterInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyattendDay, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodyshiftTemplateId = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<double> bodyhourlyRate = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<double> bodytierRate = null, [WorkflowExpression] Func<double> bodyscheduledAmount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/addRosterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["attendDay"] = SourceExpressionConverter.ConvertToken(bodyattendDay);
                if (bodyshiftTemplateId != null)
                {
                    body["shiftTemplateId"] = SourceExpressionConverter.ConvertToken(bodyshiftTemplateId);
                    bodypropCount++;
                }

                if (bodyaddressCardId != null)
                {
                    body["addressCardId"] = SourceExpressionConverter.ConvertToken(bodyaddressCardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftIn"] = SourceExpressionConverter.ConvertToken(bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = SourceExpressionConverter.ConvertToken(bodyshiftOff);
                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyshiftStatus != null)
                {
                    body["shiftStatus"] = SourceExpressionConverter.ConvertToken(bodyshiftStatus);
                    bodypropCount++;
                }

                if (bodydateType != null)
                {
                    body["dateType"] = SourceExpressionConverter.ConvertToken(bodydateType);
                    bodypropCount++;
                }

                if (bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = SourceExpressionConverter.ConvertToken(bodyattendanceItemId);
                    bodypropCount++;
                }

                if (bodyhourlyRate != null)
                {
                    body["hourlyRate"] = SourceExpressionConverter.ConvertToken(bodyhourlyRate);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodytierRate != null)
                {
                    body["tierRate"] = SourceExpressionConverter.ConvertToken(bodytierRate);
                    bodypropCount++;
                }

                if (bodyscheduledAmount != null)
                {
                    body["scheduledAmount"] = SourceExpressionConverter.ConvertToken(bodyscheduledAmount);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3CalAttendanceResp> _01attendanceSummaryCalculate([WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<string[]> bodyemployeeIds = null, [WorkflowExpression] Func<string[]> bodydepartmentIds = null, [WorkflowExpression] Func<string[]> bodypositionIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/attendanceSummaryCalculate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
                body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                if (bodyemployeeIds != null)
                {
                    body["employeeIds"] = SourceExpressionConverter.ConvertToken(bodyemployeeIds);
                    bodypropCount++;
                }

                if (bodydepartmentIds != null)
                {
                    body["departmentIds"] = SourceExpressionConverter.ConvertToken(bodydepartmentIds);
                    bodypropCount++;
                }

                if (bodypositionIds != null)
                {
                    body["positionIds"] = SourceExpressionConverter.ConvertToken(bodypositionIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3CalAttendanceResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizAttendanceConfigureResp> _01getAttendanceConfigurationList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/settings/getAttendanceConfigurationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3BizAttendanceConfigureResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementTypeResp> _01getExpenseTypeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/expense/getExpenseTypeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3BizReimbursementTypeResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ExternalPayItemResp> _020getExternalPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getExternalPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3ExternalPayItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _020updateCostCenterById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/updateCostCenterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycostCenterCode != null)
                {
                    body["costCenterCode"] = SourceExpressionConverter.ConvertToken(bodycostCenterCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3CostCenterResp> _021getCostCenterList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getCostCenterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3CostCenterResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3ExternalPayItemResp> _021getExternalPayItemInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getExternalPayItemInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3ExternalPayItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _022addTagInfo([WorkflowExpression] Func<string> bodylabelName, [WorkflowExpression] Func<string> bodylabelCode = null, [WorkflowExpression] Func<int> bodylabelStatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/addTagInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylabelCode != null)
                {
                    body["labelCode"] = SourceExpressionConverter.ConvertToken(bodylabelCode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["labelName"] = SourceExpressionConverter.ConvertToken(bodylabelName);
                if (bodylabelStatus != null)
                {
                    body["labelStatus"] = SourceExpressionConverter.ConvertToken(bodylabelStatus);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _022addWorkPatternInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyworkHoursForDay, [WorkflowExpression] Func<double> bodyworkHoursForWeek, [WorkflowExpression] Func<double> bodyworkHoursForYear, [WorkflowExpression] Func<double> bodytotalHours, [WorkflowExpression] Func<string> bodycycleType, [WorkflowExpression] Func<string> bodyadvancedSetting = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<string> bodyfte = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodysalaryCalculationStyle = null, [WorkflowExpression] Func<int> bodyworkTime = null, [WorkflowExpression] Func<string> bodydoubleWeekBaseDate = null, [WorkflowExpression] Func<string> bodyweekSalaryType = null, [WorkflowExpression] Func<int> bodyisThisWeek = null, [WorkflowExpression] Func<V3TermsSettingInsert[]> bodysettingList = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/addWorkPatternInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyadvancedSetting != null)
                {
                    body["advancedSetting"] = SourceExpressionConverter.ConvertToken(bodyadvancedSetting);
                    bodypropCount++;
                }

                if (bodynumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["workHoursForDay"] = SourceExpressionConverter.ConvertToken(bodyworkHoursForDay);
                bodypropCount++;
                body["workHoursForWeek"] = SourceExpressionConverter.ConvertToken(bodyworkHoursForWeek);
                bodypropCount++;
                body["workHoursForYear"] = SourceExpressionConverter.ConvertToken(bodyworkHoursForYear);
                bodypropCount++;
                body["totalHours"] = SourceExpressionConverter.ConvertToken(bodytotalHours);
                bodypropCount++;
                body["cycleType"] = SourceExpressionConverter.ConvertToken(bodycycleType);
                if (bodyfte != null)
                {
                    body["fte"] = SourceExpressionConverter.ConvertToken(bodyfte);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodysalaryCalculationStyle != null)
                {
                    body["salaryCalculationStyle"] = SourceExpressionConverter.ConvertToken(bodysalaryCalculationStyle);
                    bodypropCount++;
                }

                if (bodyworkTime != null)
                {
                    body["workTime"] = SourceExpressionConverter.ConvertToken(bodyworkTime);
                    bodypropCount++;
                }

                if (bodydoubleWeekBaseDate != null)
                {
                    body["doubleWeekBaseDate"] = SourceExpressionConverter.ConvertToken(bodydoubleWeekBaseDate);
                    bodypropCount++;
                }

                if (bodyweekSalaryType != null)
                {
                    body["weekSalaryType"] = SourceExpressionConverter.ConvertToken(bodyweekSalaryType);
                    bodypropCount++;
                }

                if (bodyisThisWeek != null)
                {
                    body["isThisWeek"] = SourceExpressionConverter.ConvertToken(bodyisThisWeek);
                    bodypropCount++;
                }

                if (bodysettingList != null)
                {
                    body["settingList"] = SourceExpressionConverter.ConvertToken(bodysettingList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _023deleteTagById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/deleteTagById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _023updateWorkPatternById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyadvancedSetting = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<double> bodyworkHoursForDay = null, [WorkflowExpression] Func<double> bodyworkHoursForWeek = null, [WorkflowExpression] Func<double> bodyworkHoursForYear = null, [WorkflowExpression] Func<double> bodytotalHours = null, [WorkflowExpression] Func<string> bodycycleType = null, [WorkflowExpression] Func<string> bodyfte = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodysalaryCalculationStyle = null, [WorkflowExpression] Func<int> bodyworkTime = null, [WorkflowExpression] Func<string> bodydoubleWeekBaseDate = null, [WorkflowExpression] Func<string> bodyweekSalaryType = null, [WorkflowExpression] Func<int> bodyisThisWeek = null, [WorkflowExpression] Func<string> bodytermsWorkDefaultId = null, [WorkflowExpression] Func<V3TermsSettingUpdate[]> bodysettingList = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/updateWorkPatternById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyadvancedSetting != null)
                {
                    body["advancedSetting"] = SourceExpressionConverter.ConvertToken(bodyadvancedSetting);
                    bodypropCount++;
                }

                if (bodynumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyworkHoursForDay != null)
                {
                    body["workHoursForDay"] = SourceExpressionConverter.ConvertToken(bodyworkHoursForDay);
                    bodypropCount++;
                }

                if (bodyworkHoursForWeek != null)
                {
                    body["workHoursForWeek"] = SourceExpressionConverter.ConvertToken(bodyworkHoursForWeek);
                    bodypropCount++;
                }

                if (bodyworkHoursForYear != null)
                {
                    body["workHoursForYear"] = SourceExpressionConverter.ConvertToken(bodyworkHoursForYear);
                    bodypropCount++;
                }

                if (bodytotalHours != null)
                {
                    body["totalHours"] = SourceExpressionConverter.ConvertToken(bodytotalHours);
                    bodypropCount++;
                }

                if (bodycycleType != null)
                {
                    body["cycleType"] = SourceExpressionConverter.ConvertToken(bodycycleType);
                    bodypropCount++;
                }

                if (bodyfte != null)
                {
                    body["fte"] = SourceExpressionConverter.ConvertToken(bodyfte);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodysalaryCalculationStyle != null)
                {
                    body["salaryCalculationStyle"] = SourceExpressionConverter.ConvertToken(bodysalaryCalculationStyle);
                    bodypropCount++;
                }

                if (bodyworkTime != null)
                {
                    body["workTime"] = SourceExpressionConverter.ConvertToken(bodyworkTime);
                    bodypropCount++;
                }

                if (bodydoubleWeekBaseDate != null)
                {
                    body["doubleWeekBaseDate"] = SourceExpressionConverter.ConvertToken(bodydoubleWeekBaseDate);
                    bodypropCount++;
                }

                if (bodyweekSalaryType != null)
                {
                    body["weekSalaryType"] = SourceExpressionConverter.ConvertToken(bodyweekSalaryType);
                    bodypropCount++;
                }

                if (bodyisThisWeek != null)
                {
                    body["isThisWeek"] = SourceExpressionConverter.ConvertToken(bodyisThisWeek);
                    bodypropCount++;
                }

                if (bodytermsWorkDefaultId != null)
                {
                    body["termsWorkDefaultId"] = SourceExpressionConverter.ConvertToken(bodytermsWorkDefaultId);
                    bodypropCount++;
                }

                if (bodysettingList != null)
                {
                    body["settingList"] = SourceExpressionConverter.ConvertToken(bodysettingList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _024deleteWorkPatternById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/deleteWorkPatternById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _024updateTagById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylabelCode = null, [WorkflowExpression] Func<string> bodylabelName = null, [WorkflowExpression] Func<int> bodylabelStatus = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/updateTagById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodylabelCode != null)
                {
                    body["labelCode"] = SourceExpressionConverter.ConvertToken(bodylabelCode);
                    bodypropCount++;
                }

                if (bodylabelName != null)
                {
                    body["labelName"] = SourceExpressionConverter.ConvertToken(bodylabelName);
                    bodypropCount++;
                }

                if (bodylabelStatus != null)
                {
                    body["labelStatus"] = SourceExpressionConverter.ConvertToken(bodylabelStatus);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LabelResp> _025getTagList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getTagList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LabelResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3WorkPatternSummaryResp> _025getWorkPatternList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getWorkPatternList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3WorkPatternSummaryResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3DeviceResp> _026getDeviceList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/company/getDeviceList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3DeviceResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3WorkPatternResp> _026getWorkPatternInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/payroll/getWorkPatternInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3WorkPatternResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizReimbursementInsertResp> _02addExpenseApplicationInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyreimbursementType, [WorkflowExpression] Func<string> bodyreimbursementDate, [WorkflowExpression] Func<string> bodyreimbursementName, [WorkflowExpression] Func<double> bodyamount, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/expense/addExpenseApplicationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["reimbursementType"] = SourceExpressionConverter.ConvertToken(bodyreimbursementType);
                bodypropCount++;
                body["reimbursementDate"] = SourceExpressionConverter.ConvertToken(bodyreimbursementDate);
                bodypropCount++;
                body["reimbursementName"] = SourceExpressionConverter.ConvertToken(bodyreimbursementName);
                bodypropCount++;
                body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3BizReimbursementInsertResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _02batchSaveRosterInfo([WorkflowExpression] Func<string[]> bodyemployeeIds, [WorkflowExpression] Func<string[]> bodydates, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodyshiftTemplateId = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<double> bodyhourlyRate = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<bool> bodyreplaceOriginal = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/batchSaveRosterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeIds"] = SourceExpressionConverter.ConvertToken(bodyemployeeIds);
                bodypropCount++;
                body["dates"] = SourceExpressionConverter.ConvertToken(bodydates);
                if (bodyshiftTemplateId != null)
                {
                    body["shiftTemplateId"] = SourceExpressionConverter.ConvertToken(bodyshiftTemplateId);
                    bodypropCount++;
                }

                if (bodyaddressCardId != null)
                {
                    body["addressCardId"] = SourceExpressionConverter.ConvertToken(bodyaddressCardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftIn"] = SourceExpressionConverter.ConvertToken(bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = SourceExpressionConverter.ConvertToken(bodyshiftOff);
                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyshiftStatus != null)
                {
                    body["shiftStatus"] = SourceExpressionConverter.ConvertToken(bodyshiftStatus);
                    bodypropCount++;
                }

                if (bodydateType != null)
                {
                    body["dateType"] = SourceExpressionConverter.ConvertToken(bodydateType);
                    bodypropCount++;
                }

                if (bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = SourceExpressionConverter.ConvertToken(bodyattendanceItemId);
                    bodypropCount++;
                }

                if (bodyhourlyRate != null)
                {
                    body["hourlyRate"] = SourceExpressionConverter.ConvertToken(bodyhourlyRate);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyreplaceOriginal != null)
                {
                    body["replaceOriginal"] = SourceExpressionConverter.ConvertToken(bodyreplaceOriginal);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _02deleteEmployeeById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/deleteAllData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _02deleteLeaveBalanceAdjustmentById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/deleteLeaveBalanceAdjustmentById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceListResp> _02getAttendanceSummaryList([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> unit, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> attendCalculationFilter = null, [WorkflowExpression] Func<string> employeeFilter = null, [WorkflowExpression] Func<string> labelFilter = null, [WorkflowExpression] Func<string> payrollRegulationFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> attendanceTypeFilter = null, [WorkflowExpression] Func<string> shiftTypeFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getAttendanceSummaryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Queries["unit"] = SourceExpressionConverter.ConvertO(unit);
                if (departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = SourceExpressionConverter.ConvertO(departmentFilter);
                if (positionFilter != null)
                    callPayload.Queries["positionFilter"] = SourceExpressionConverter.ConvertO(positionFilter);
                if (attendCalculationFilter != null)
                    callPayload.Queries["attendCalculationFilter"] = SourceExpressionConverter.ConvertO(attendCalculationFilter);
                if (employeeFilter != null)
                    callPayload.Queries["employeeFilter"] = SourceExpressionConverter.ConvertO(employeeFilter);
                if (labelFilter != null)
                    callPayload.Queries["labelFilter"] = SourceExpressionConverter.ConvertO(labelFilter);
                if (payrollRegulationFilter != null)
                    callPayload.Queries["payrollRegulationFilter"] = SourceExpressionConverter.ConvertO(payrollRegulationFilter);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = SourceExpressionConverter.ConvertO(hireTypeFilter);
                if (calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = SourceExpressionConverter.ConvertO(calculateSalaryTypeFilter);
                if (attendanceTypeFilter != null)
                    callPayload.Queries["attendanceTypeFilter"] = SourceExpressionConverter.ConvertO(attendanceTypeFilter);
                if (shiftTypeFilter != null)
                    callPayload.Queries["shiftTypeFilter"] = SourceExpressionConverter.ConvertO(shiftTypeFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3AttendanceListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryResp> _02getDataDictionaryList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/settings/getDataDictionaryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _03deleteExpenseApplicationById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/expense/deleteExpenseApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _03deleteRosterById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/deleteRosterById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3BizCustomizeDictionaryItemResp> _03GetDataDictionaryDetailsInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/settings/getDataDictionaryDetailsInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV3BizCustomizeDictionaryItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3AttendanceDetailListResp> _03getEmployeeDailyAttendanceList([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> attendStatusFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getEmployeeDailyAttendanceList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (attendStatusFilter != null)
                    callPayload.Queries["attendStatusFilter"] = SourceExpressionConverter.ConvertO(attendStatusFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV3AttendanceDetailListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayBalanceResp> _03getLeaveBalanceAdjustmentList([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> holidayType, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceAdjustmentList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                callPayload.Queries["holidayType"] = SourceExpressionConverter.ConvertO(holidayType);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LeaveHolidayBalanceResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _03updateEmployeeById([WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodyenglishName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyemployeeStatus = null, [WorkflowExpression] Func<string> bodysex = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyidentityCard = null, [WorkflowExpression] Func<string> bodychineseName = null, [WorkflowExpression] Func<string> bodysurnameEnglish = null, [WorkflowExpression] Func<string> bodypersonalNameEnglish = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodyemergencyContactName = null, [WorkflowExpression] Func<string> bodyemergencyContactRelation = null, [WorkflowExpression] Func<string> bodyemergencyContactPhone = null, [WorkflowExpression] Func<string> bodybankCode = null, [WorkflowExpression] Func<string> bodybankBranchNumber = null, [WorkflowExpression] Func<string> bodybankAccountNo = null, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodydate1 = null, [WorkflowExpression] Func<string> bodydate2 = null, [WorkflowExpression] Func<string> bodydate3 = null, [WorkflowExpression] Func<string> bodydate4 = null, [WorkflowExpression] Func<string> bodytext1 = null, [WorkflowExpression] Func<string> bodytext2 = null, [WorkflowExpression] Func<string> bodytext3 = null, [WorkflowExpression] Func<string> bodytext4 = null, [WorkflowExpression] Func<string> bodytext5 = null, [WorkflowExpression] Func<string> bodytext6 = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodymobileCardCalType = null, [WorkflowExpression] Func<string> bodyregularType = null, [WorkflowExpression] Func<string> bodyinsurePlanName = null, [WorkflowExpression] Func<string> bodybizLabelIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/updateEmployeeById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entryDate"] = SourceExpressionConverter.ConvertToken(bodyentryDate);
                bodypropCount++;
                body["englishName"] = SourceExpressionConverter.ConvertToken(bodyenglishName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyemployeeStatus != null)
                {
                    body["employeeStatus"] = SourceExpressionConverter.ConvertToken(bodyemployeeStatus);
                    bodypropCount++;
                }

                if (bodysex != null)
                {
                    body["sex"] = SourceExpressionConverter.ConvertToken(bodysex);
                    bodypropCount++;
                }

                if (bodynationality != null)
                {
                    body["nationality"] = SourceExpressionConverter.ConvertToken(bodynationality);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["maritalStatus"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                if (bodycountryCode != null)
                {
                    body["countryCode"] = SourceExpressionConverter.ConvertToken(bodycountryCode);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = SourceExpressionConverter.ConvertToken(bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (bodyworkDate != null)
                {
                    body["workDate"] = SourceExpressionConverter.ConvertToken(bodyworkDate);
                    bodypropCount++;
                }

                if (bodybasicPay != null)
                {
                    body["basicPay"] = SourceExpressionConverter.ConvertToken(bodybasicPay);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyidentityCard != null)
                {
                    body["identityCard"] = SourceExpressionConverter.ConvertToken(bodyidentityCard);
                    bodypropCount++;
                }

                if (bodychineseName != null)
                {
                    body["chineseName"] = SourceExpressionConverter.ConvertToken(bodychineseName);
                    bodypropCount++;
                }

                if (bodysurnameEnglish != null)
                {
                    body["surnameEnglish"] = SourceExpressionConverter.ConvertToken(bodysurnameEnglish);
                    bodypropCount++;
                }

                if (bodypersonalNameEnglish != null)
                {
                    body["personalNameEnglish"] = SourceExpressionConverter.ConvertToken(bodypersonalNameEnglish);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = SourceExpressionConverter.ConvertToken(bodybirthday);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactName);
                    bodypropCount++;
                }

                if (bodyemergencyContactRelation != null)
                {
                    body["emergencyContactRelation"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactRelation);
                    bodypropCount++;
                }

                if (bodyemergencyContactPhone != null)
                {
                    body["emergencyContactPhone"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactPhone);
                    bodypropCount++;
                }

                if (bodybankCode != null)
                {
                    body["bankCode"] = SourceExpressionConverter.ConvertToken(bodybankCode);
                    bodypropCount++;
                }

                if (bodybankBranchNumber != null)
                {
                    body["bankBranchNumber"] = SourceExpressionConverter.ConvertToken(bodybankBranchNumber);
                    bodypropCount++;
                }

                if (bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = SourceExpressionConverter.ConvertToken(bodybankAccountNo);
                    bodypropCount++;
                }

                if (bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = SourceExpressionConverter.ConvertToken(bodyconfirmationDate);
                    bodypropCount++;
                }

                if (bodydate1 != null)
                {
                    body["date1"] = SourceExpressionConverter.ConvertToken(bodydate1);
                    bodypropCount++;
                }

                if (bodydate2 != null)
                {
                    body["date2"] = SourceExpressionConverter.ConvertToken(bodydate2);
                    bodypropCount++;
                }

                if (bodydate3 != null)
                {
                    body["date3"] = SourceExpressionConverter.ConvertToken(bodydate3);
                    bodypropCount++;
                }

                if (bodydate4 != null)
                {
                    body["date4"] = SourceExpressionConverter.ConvertToken(bodydate4);
                    bodypropCount++;
                }

                if (bodytext1 != null)
                {
                    body["text1"] = SourceExpressionConverter.ConvertToken(bodytext1);
                    bodypropCount++;
                }

                if (bodytext2 != null)
                {
                    body["text2"] = SourceExpressionConverter.ConvertToken(bodytext2);
                    bodypropCount++;
                }

                if (bodytext3 != null)
                {
                    body["text3"] = SourceExpressionConverter.ConvertToken(bodytext3);
                    bodypropCount++;
                }

                if (bodytext4 != null)
                {
                    body["text4"] = SourceExpressionConverter.ConvertToken(bodytext4);
                    bodypropCount++;
                }

                if (bodytext5 != null)
                {
                    body["text5"] = SourceExpressionConverter.ConvertToken(bodytext5);
                    bodypropCount++;
                }

                if (bodytext6 != null)
                {
                    body["text6"] = SourceExpressionConverter.ConvertToken(bodytext6);
                    bodypropCount++;
                }

                if (bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = SourceExpressionConverter.ConvertToken(bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodypositionId != null)
                {
                    body["positionId"] = SourceExpressionConverter.ConvertToken(bodypositionId);
                    bodypropCount++;
                }

                if (bodyhireType != null)
                {
                    body["hireType"] = SourceExpressionConverter.ConvertToken(bodyhireType);
                    bodypropCount++;
                }

                if (bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = SourceExpressionConverter.ConvertToken(bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = SourceExpressionConverter.ConvertToken(bodyattendCalculationId);
                    bodypropCount++;
                }

                if (bodymobileCardCalType != null)
                {
                    body["mobileCardCalType"] = SourceExpressionConverter.ConvertToken(bodymobileCardCalType);
                    bodypropCount++;
                }

                if (bodyregularType != null)
                {
                    body["regularType"] = SourceExpressionConverter.ConvertToken(bodyregularType);
                    bodypropCount++;
                }

                if (bodyinsurePlanName != null)
                {
                    body["insurePlanName"] = SourceExpressionConverter.ConvertToken(bodyinsurePlanName);
                    bodypropCount++;
                }

                if (bodybizLabelIds != null)
                {
                    body["bizLabelIds"] = SourceExpressionConverter.ConvertToken(bodybizLabelIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddMobileCardResp> _04addAttendanceDataInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodymode, [WorkflowExpression] Func<string> bodycardType = null, [WorkflowExpression] Func<double> bodyactualLongitude = null, [WorkflowExpression] Func<double> bodyactualLatitude = null, [WorkflowExpression] Func<string> bodydeviceName = null, [WorkflowExpression] Func<string> bodycodeSource = null, [WorkflowExpression] Func<string> bodylocationName = null, [WorkflowExpression] Func<string> bodyworkLocationId = null, [WorkflowExpression] Func<string> bodydeviceId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/addAttendanceDataInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["mode"] = SourceExpressionConverter.ConvertToken(bodymode);
                if (bodycardType != null)
                {
                    body["cardType"] = SourceExpressionConverter.ConvertToken(bodycardType);
                    bodypropCount++;
                }

                if (bodyactualLongitude != null)
                {
                    body["actualLongitude"] = SourceExpressionConverter.ConvertToken(bodyactualLongitude);
                    bodypropCount++;
                }

                if (bodyactualLatitude != null)
                {
                    body["actualLatitude"] = SourceExpressionConverter.ConvertToken(bodyactualLatitude);
                    bodypropCount++;
                }

                if (bodydeviceName != null)
                {
                    body["deviceName"] = SourceExpressionConverter.ConvertToken(bodydeviceName);
                    bodypropCount++;
                }

                if (bodycodeSource != null)
                {
                    body["codeSource"] = SourceExpressionConverter.ConvertToken(bodycodeSource);
                    bodypropCount++;
                }

                if (bodylocationName != null)
                {
                    body["locationName"] = SourceExpressionConverter.ConvertToken(bodylocationName);
                    bodypropCount++;
                }

                if (bodyworkLocationId != null)
                {
                    body["workLocationId"] = SourceExpressionConverter.ConvertToken(bodyworkLocationId);
                    bodypropCount++;
                }

                if (bodydeviceId != null)
                {
                    body["deviceId"] = SourceExpressionConverter.ConvertToken(bodydeviceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3AddMobileCardResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _04calculationLeaveBalance([WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bool> bodyisForceCal = null, [WorkflowExpression] Func<string[]> bodyemployeeIdsList = null, [WorkflowExpression] Func<string[]> bodyposition = null, [WorkflowExpression] Func<string[]> bodydept = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/calculationLeaveBalance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyisForceCal != null)
                {
                    body["isForceCal"] = SourceExpressionConverter.ConvertToken(bodyisForceCal);
                    bodypropCount++;
                }

                if (bodyemployeeIdsList != null)
                {
                    body["employeeIdsList"] = SourceExpressionConverter.ConvertToken(bodyemployeeIdsList);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodydept != null)
                {
                    body["dept"] = SourceExpressionConverter.ConvertToken(bodydept);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3BizEmployeeCustomizationResp> _04getCustomizeUserFieldList([WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/settings/getCustomizeUserFieldList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3BizEmployeeCustomizationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeListResp> _04getEmployeeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<string> sex = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> hireType = null, [WorkflowExpression] Func<string> calculateSalaryType = null, [WorkflowExpression] Func<string> costCenterId = null, [WorkflowExpression] Func<string> payrollRegulationId = null, [WorkflowExpression] Func<string> regularType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/getEmployeeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (departmentId != null)
                    callPayload.Queries["departmentId"] = SourceExpressionConverter.ConvertO(departmentId);
                if (positionId != null)
                    callPayload.Queries["positionId"] = SourceExpressionConverter.ConvertO(positionId);
                if (sex != null)
                    callPayload.Queries["sex"] = SourceExpressionConverter.ConvertO(sex);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (hireType != null)
                    callPayload.Queries["hireType"] = SourceExpressionConverter.ConvertO(hireType);
                if (calculateSalaryType != null)
                    callPayload.Queries["calculateSalaryType"] = SourceExpressionConverter.ConvertO(calculateSalaryType);
                if (costCenterId != null)
                    callPayload.Queries["costCenterId"] = SourceExpressionConverter.ConvertO(costCenterId);
                if (payrollRegulationId != null)
                    callPayload.Queries["payrollRegulationId"] = SourceExpressionConverter.ConvertO(payrollRegulationId);
                if (regularType != null)
                    callPayload.Queries["regularType"] = SourceExpressionConverter.ConvertO(regularType);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3EmployeeListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _04updateExpenseApplicationById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyreimbursementType = null, [WorkflowExpression] Func<string> bodyreimbursementDate = null, [WorkflowExpression] Func<string> bodyreimbursementName = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/expense/updateExpenseApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyreimbursementType != null)
                {
                    body["reimbursementType"] = SourceExpressionConverter.ConvertToken(bodyreimbursementType);
                    bodypropCount++;
                }

                if (bodyreimbursementDate != null)
                {
                    body["reimbursementDate"] = SourceExpressionConverter.ConvertToken(bodyreimbursementDate);
                    bodypropCount++;
                }

                if (bodyreimbursementName != null)
                {
                    body["reimbursementName"] = SourceExpressionConverter.ConvertToken(bodyreimbursementName);
                    bodypropCount++;
                }

                if (bodyamount != null)
                {
                    body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _04updateRosterInfoById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodyshiftTemplateId = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<double> bodyhourlyRate = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<double> bodytierRate = null, [WorkflowExpression] Func<double> bodyscheduledAmount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/updateRosterInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyshiftTemplateId != null)
                {
                    body["shiftTemplateId"] = SourceExpressionConverter.ConvertToken(bodyshiftTemplateId);
                    bodypropCount++;
                }

                if (bodyaddressCardId != null)
                {
                    body["addressCardId"] = SourceExpressionConverter.ConvertToken(bodyaddressCardId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftIn"] = SourceExpressionConverter.ConvertToken(bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = SourceExpressionConverter.ConvertToken(bodyshiftOff);
                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyshiftStatus != null)
                {
                    body["shiftStatus"] = SourceExpressionConverter.ConvertToken(bodyshiftStatus);
                    bodypropCount++;
                }

                if (bodydateType != null)
                {
                    body["dateType"] = SourceExpressionConverter.ConvertToken(bodydateType);
                    bodypropCount++;
                }

                if (bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = SourceExpressionConverter.ConvertToken(bodyattendanceItemId);
                    bodypropCount++;
                }

                if (bodyhourlyRate != null)
                {
                    body["hourlyRate"] = SourceExpressionConverter.ConvertToken(bodyhourlyRate);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodytierRate != null)
                {
                    body["tierRate"] = SourceExpressionConverter.ConvertToken(bodytierRate);
                    bodypropCount++;
                }

                if (bodyscheduledAmount != null)
                {
                    body["scheduledAmount"] = SourceExpressionConverter.ConvertToken(bodyscheduledAmount);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _05deleteAttendanceDataById([WorkflowExpression] Func<string> ids)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/deleteAttendanceDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizEmployeeCustomizationResp> _05getCustomizeUserFieldInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/settings/getCustomizeUserFieldInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3BizEmployeeCustomizationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3EmployeeInfoResp> _05getEmployeeInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/getEmployeeInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3EmployeeInfoResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3BizReimbursementResp> _05GetExpenseApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> dateFilter = null, [WorkflowExpression] Func<string> reimbursementStatusFilter = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/expense/getExpenseApplicationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = SourceExpressionConverter.ConvertO(departmentFilter);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (dateFilter != null)
                    callPayload.Queries["dateFilter"] = SourceExpressionConverter.ConvertO(dateFilter);
                if (reimbursementStatusFilter != null)
                    callPayload.Queries["reimbursementStatusFilter"] = SourceExpressionConverter.ConvertO(reimbursementStatusFilter);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3BizReimbursementResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveBalanceResp> _05getLeaveBalanceList([WorkflowExpression] Func<string> holidayType, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> regularTypeFilter = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> sexFilter = null, [WorkflowExpression] Func<string> leaveHolidayBalanceStatusFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> bizLabelIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["holidayType"] = SourceExpressionConverter.ConvertO(holidayType);
                if (regularTypeFilter != null)
                    callPayload.Queries["regularTypeFilter"] = SourceExpressionConverter.ConvertO(regularTypeFilter);
                if (departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = SourceExpressionConverter.ConvertO(departmentFilter);
                if (positionFilter != null)
                    callPayload.Queries["positionFilter"] = SourceExpressionConverter.ConvertO(positionFilter);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (sexFilter != null)
                    callPayload.Queries["sexFilter"] = SourceExpressionConverter.ConvertO(sexFilter);
                if (leaveHolidayBalanceStatusFilter != null)
                    callPayload.Queries["leaveHolidayBalanceStatusFilter"] = SourceExpressionConverter.ConvertO(leaveHolidayBalanceStatusFilter);
                if (calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = SourceExpressionConverter.ConvertO(calculateSalaryTypeFilter);
                if (hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = SourceExpressionConverter.ConvertO(hireTypeFilter);
                if (bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = SourceExpressionConverter.ConvertO(bizLabelIds);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LeaveBalanceResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3RosterListResp> _05getRosterList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendDay = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> attendStatus = null, [WorkflowExpression] Func<string> dateType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getRosterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (attendDay != null)
                    callPayload.Queries["attendDay"] = SourceExpressionConverter.ConvertO(attendDay);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (attendStatus != null)
                    callPayload.Queries["attendStatus"] = SourceExpressionConverter.ConvertO(attendStatus);
                if (dateType != null)
                    callPayload.Queries["dateType"] = SourceExpressionConverter.ConvertO(dateType);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3RosterListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveWorkFlowDefinitionResp> _06getApproveProcessList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/settings/getApproveProcessList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LeaveWorkFlowDefinitionResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3BizReimbursementDetailResp> _06GetExpenseApplicationById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/expense/getExpenseApplicationById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3BizReimbursementDetailResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeaveBalanceDetailResp> _06GetLeaveBalanceInfoById([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> holidayType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeaveBalanceInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                callPayload.Queries["holidayType"] = SourceExpressionConverter.ConvertO(holidayType);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3LeaveBalanceDetailResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3RosterInfoResp> _06getRosterInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getRosterInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3RosterInfoResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _06resign([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylastWorkingDate, [WorkflowExpression] Func<string> bodyreasonsLeave, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/resign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["lastWorkingDate"] = SourceExpressionConverter.ConvertToken(bodylastWorkingDate);
                bodypropCount++;
                body["reasonsLeave"] = SourceExpressionConverter.ConvertToken(bodyreasonsLeave);
                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _06updateAttendanceDataById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodymode = null, [WorkflowExpression] Func<string> bodycardType = null, [WorkflowExpression] Func<double> bodyactualLongitude = null, [WorkflowExpression] Func<double> bodyactualLatitude = null, [WorkflowExpression] Func<string> bodydeviceName = null, [WorkflowExpression] Func<string> bodycodeSource = null, [WorkflowExpression] Func<string> bodylocationName = null, [WorkflowExpression] Func<string> bodyworkLocationId = null, [WorkflowExpression] Func<string> bodydeviceId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/updateAttendanceDataById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodymode != null)
                {
                    body["mode"] = SourceExpressionConverter.ConvertToken(bodymode);
                    bodypropCount++;
                }

                if (bodycardType != null)
                {
                    body["cardType"] = SourceExpressionConverter.ConvertToken(bodycardType);
                    bodypropCount++;
                }

                if (bodyactualLongitude != null)
                {
                    body["actualLongitude"] = SourceExpressionConverter.ConvertToken(bodyactualLongitude);
                    bodypropCount++;
                }

                if (bodyactualLatitude != null)
                {
                    body["actualLatitude"] = SourceExpressionConverter.ConvertToken(bodyactualLatitude);
                    bodypropCount++;
                }

                if (bodydeviceName != null)
                {
                    body["deviceName"] = SourceExpressionConverter.ConvertToken(bodydeviceName);
                    bodypropCount++;
                }

                if (bodycodeSource != null)
                {
                    body["codeSource"] = SourceExpressionConverter.ConvertToken(bodycodeSource);
                    bodypropCount++;
                }

                if (bodylocationName != null)
                {
                    body["locationName"] = SourceExpressionConverter.ConvertToken(bodylocationName);
                    bodypropCount++;
                }

                if (bodyworkLocationId != null)
                {
                    body["workLocationId"] = SourceExpressionConverter.ConvertToken(bodyworkLocationId);
                    bodypropCount++;
                }

                if (bodydeviceId != null)
                {
                    body["deviceId"] = SourceExpressionConverter.ConvertToken(bodydeviceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddEmployeeHistoryResp> _07addEmployeeHistory([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodytakeEffectType, [WorkflowExpression] Func<string> bodytakeEffectDate, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<string> bodycause = null, [WorkflowExpression] Func<string> bodymajorWorkLocationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/addEmployeeHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["entryDate"] = SourceExpressionConverter.ConvertToken(bodyentryDate);
                if (bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = SourceExpressionConverter.ConvertToken(bodyconfirmationDate);
                    bodypropCount++;
                }

                if (bodyhireType != null)
                {
                    body["hireType"] = SourceExpressionConverter.ConvertToken(bodyhireType);
                    bodypropCount++;
                }

                if (bodypositionId != null)
                {
                    body["positionId"] = SourceExpressionConverter.ConvertToken(bodypositionId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = SourceExpressionConverter.ConvertToken(bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = SourceExpressionConverter.ConvertToken(bodyattendCalculationId);
                    bodypropCount++;
                }

                if (bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = SourceExpressionConverter.ConvertToken(bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (bodybasicPay != null)
                {
                    body["basicPay"] = SourceExpressionConverter.ConvertToken(bodybasicPay);
                    bodypropCount++;
                }

                if (bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = SourceExpressionConverter.ConvertToken(bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyworkDate != null)
                {
                    body["workDate"] = SourceExpressionConverter.ConvertToken(bodyworkDate);
                    bodypropCount++;
                }

                if (bodycause != null)
                {
                    body["cause"] = SourceExpressionConverter.ConvertToken(bodycause);
                    bodypropCount++;
                }

                if (bodymajorWorkLocationId != null)
                {
                    body["majorWorkLocationId"] = SourceExpressionConverter.ConvertToken(bodymajorWorkLocationId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["takeEffectType"] = SourceExpressionConverter.ConvertToken(bodytakeEffectType);
                bodypropCount++;
                body["takeEffectDate"] = SourceExpressionConverter.ConvertToken(bodytakeEffectDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3AddEmployeeHistoryResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayInsertResp> _07addLeaveApplicationInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyholidayType, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<double> bodyleaveTime = null, [WorkflowExpression] Func<string> bodytimeType = null, [WorkflowExpression] Func<string> bodyholidayDate = null, [WorkflowExpression] Func<string> bodytime = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/addLeaveApplicationInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["holidayType"] = SourceExpressionConverter.ConvertToken(bodyholidayType);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodyleaveTime != null)
                {
                    body["leaveTime"] = SourceExpressionConverter.ConvertToken(bodyleaveTime);
                    bodypropCount++;
                }

                if (bodytimeType != null)
                {
                    body["timeType"] = SourceExpressionConverter.ConvertToken(bodytimeType);
                    bodypropCount++;
                }

                if (bodyholidayDate != null)
                {
                    body["holidayDate"] = SourceExpressionConverter.ConvertToken(bodyholidayDate);
                    bodypropCount++;
                }

                if (bodytime != null)
                {
                    body["time"] = SourceExpressionConverter.ConvertToken(bodytime);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3LeaveHolidayInsertResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _07addShitTemplateInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceAddressId = null, [WorkflowExpression] Func<int> bodymealTime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/addShitTemplateInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["shiftIn"] = SourceExpressionConverter.ConvertToken(bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = SourceExpressionConverter.ConvertToken(bodyshiftOff);
                if (bodydateType != null)
                {
                    body["dateType"] = SourceExpressionConverter.ConvertToken(bodydateType);
                    bodypropCount++;
                }

                if (bodyattendanceAddressId != null)
                {
                    body["attendanceAddressId"] = SourceExpressionConverter.ConvertToken(bodyattendanceAddressId);
                    bodypropCount++;
                }

                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3MobileCardListResp> _07getAttendanceDataList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> attendCalculationId = null, [WorkflowExpression] Func<string> bizLabelIds = null, [WorkflowExpression] Func<string> hireTypeFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getAttendanceDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = SourceExpressionConverter.ConvertO(departmentFilter);
                if (positionFilter != null)
                    callPayload.Queries["positionFilter"] = SourceExpressionConverter.ConvertO(positionFilter);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (attendCalculationId != null)
                    callPayload.Queries["attendCalculationId"] = SourceExpressionConverter.ConvertO(attendCalculationId);
                if (bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = SourceExpressionConverter.ConvertO(bizLabelIds);
                if (hireTypeFilter != null)
                    callPayload.Queries["hireTypeFilter"] = SourceExpressionConverter.ConvertO(hireTypeFilter);
                if (calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = SourceExpressionConverter.ConvertO(calculateSalaryTypeFilter);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3MobileCardListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteEmployeeHistoryById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/deleteEmployeeHistoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteLeaveApplicationById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/deleteLeaveApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _08deleteShiftTemplateById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/deleteShiftTemplateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3MobileCardInfoResp> _08getAttendanceDataInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getAttendanceDataInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3MobileCardInfoResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3AttendanceItemListResp> _09getAttendanceItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getAttendanceItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3AttendanceItemListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _09updateEmployeeHistoryById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyentryDate, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodyhireType = null, [WorkflowExpression] Func<string> bodypositionId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodydirectSupervisorId = null, [WorkflowExpression] Func<string> bodyattendCalculationId = null, [WorkflowExpression] Func<string> bodypayrollRegulationId = null, [WorkflowExpression] Func<double> bodybasicPay = null, [WorkflowExpression] Func<string> bodycalculateSalaryType = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<string> bodycause = null, [WorkflowExpression] Func<string> bodymajorWorkLocationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/updateEmployeeHistoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["entryDate"] = SourceExpressionConverter.ConvertToken(bodyentryDate);
                if (bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = SourceExpressionConverter.ConvertToken(bodyconfirmationDate);
                    bodypropCount++;
                }

                if (bodyhireType != null)
                {
                    body["hireType"] = SourceExpressionConverter.ConvertToken(bodyhireType);
                    bodypropCount++;
                }

                if (bodypositionId != null)
                {
                    body["positionId"] = SourceExpressionConverter.ConvertToken(bodypositionId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["departmentId"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodydirectSupervisorId != null)
                {
                    body["directSupervisorId"] = SourceExpressionConverter.ConvertToken(bodydirectSupervisorId);
                    bodypropCount++;
                }

                if (bodyattendCalculationId != null)
                {
                    body["attendCalculationId"] = SourceExpressionConverter.ConvertToken(bodyattendCalculationId);
                    bodypropCount++;
                }

                if (bodypayrollRegulationId != null)
                {
                    body["payrollRegulationId"] = SourceExpressionConverter.ConvertToken(bodypayrollRegulationId);
                    bodypropCount++;
                }

                if (bodybasicPay != null)
                {
                    body["basicPay"] = SourceExpressionConverter.ConvertToken(bodybasicPay);
                    bodypropCount++;
                }

                if (bodycalculateSalaryType != null)
                {
                    body["calculateSalaryType"] = SourceExpressionConverter.ConvertToken(bodycalculateSalaryType);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyworkDate != null)
                {
                    body["workDate"] = SourceExpressionConverter.ConvertToken(bodyworkDate);
                    bodypropCount++;
                }

                if (bodycause != null)
                {
                    body["cause"] = SourceExpressionConverter.ConvertToken(bodycause);
                    bodypropCount++;
                }

                if (bodymajorWorkLocationId != null)
                {
                    body["majorWorkLocationId"] = SourceExpressionConverter.ConvertToken(bodymajorWorkLocationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _09updateLeaveApplicationById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyholidayType = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<double> bodyleaveTime = null, [WorkflowExpression] Func<string> bodytimeType = null, [WorkflowExpression] Func<string> bodyholidayDate = null, [WorkflowExpression] Func<string> bodytime = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/updateLeaveApplicationById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyholidayType != null)
                {
                    body["holidayType"] = SourceExpressionConverter.ConvertToken(bodyholidayType);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodyleaveTime != null)
                {
                    body["leaveTime"] = SourceExpressionConverter.ConvertToken(bodyleaveTime);
                    bodypropCount++;
                }

                if (bodytimeType != null)
                {
                    body["timeType"] = SourceExpressionConverter.ConvertToken(bodytimeType);
                    bodypropCount++;
                }

                if (bodyholidayDate != null)
                {
                    body["holidayDate"] = SourceExpressionConverter.ConvertToken(bodyholidayDate);
                    bodypropCount++;
                }

                if (bodytime != null)
                {
                    body["time"] = SourceExpressionConverter.ConvertToken(bodytime);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _09updateShiftTemplateById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyshiftIn, [WorkflowExpression] Func<string> bodyshiftOff, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyattendanceAddressId = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/updateShiftTemplateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["shiftIn"] = SourceExpressionConverter.ConvertToken(bodyshiftIn);
                bodypropCount++;
                body["shiftOff"] = SourceExpressionConverter.ConvertToken(bodyshiftOff);
                if (bodydateType != null)
                {
                    body["dateType"] = SourceExpressionConverter.ConvertToken(bodydateType);
                    bodypropCount++;
                }

                if (bodyattendanceAddressId != null)
                {
                    body["attendanceAddressId"] = SourceExpressionConverter.ConvertToken(bodyattendanceAddressId);
                    bodypropCount++;
                }

                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddTimesheetResp> _10addTimesheetInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string> bodyworkOverTimeType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/addTimesheetInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                if (bodyworkOverTimeType != null)
                {
                    body["workOverTimeType"] = SourceExpressionConverter.ConvertToken(bodyworkOverTimeType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
                body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyaddressCardId != null)
                {
                    body["addressCardId"] = SourceExpressionConverter.ConvertToken(bodyaddressCardId);
                    bodypropCount++;
                }

                if (bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = SourceExpressionConverter.ConvertToken(bodyattendanceItemId);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3AddTimesheetResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3EmployeeHistoryListResp> _10getEmployeeHistoryList([WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/employee/getEmployeeHistoryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3EmployeeHistoryListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveHolidayResp> _10getLeaveApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> employeeFilter = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> holidayTypeFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> recordStatusFilter = null, [WorkflowExpression] Func<string> attendCalculationId = null, [WorkflowExpression] Func<string> bizLabelIds = null, [WorkflowExpression] Func<string> startDateFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = SourceExpressionConverter.ConvertO(departmentFilter);
                if (employeeFilter != null)
                    callPayload.Queries["employeeFilter"] = SourceExpressionConverter.ConvertO(employeeFilter);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (holidayTypeFilter != null)
                    callPayload.Queries["holidayTypeFilter"] = SourceExpressionConverter.ConvertO(holidayTypeFilter);
                if (calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = SourceExpressionConverter.ConvertO(calculateSalaryTypeFilter);
                if (recordStatusFilter != null)
                    callPayload.Queries["recordStatusFilter"] = SourceExpressionConverter.ConvertO(recordStatusFilter);
                if (attendCalculationId != null)
                    callPayload.Queries["attendCalculationId"] = SourceExpressionConverter.ConvertO(attendCalculationId);
                if (bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = SourceExpressionConverter.ConvertO(bizLabelIds);
                if (startDateFilter != null)
                    callPayload.Queries["startDateFilter"] = SourceExpressionConverter.ConvertO(startDateFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LeaveHolidayResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ShiftTemplateListResp> _10getShiftTemplateList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendanceAddressId = null, [WorkflowExpression] Func<string> dateType = null, [WorkflowExpression] Func<string> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getShiftTemplateList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (attendanceAddressId != null)
                    callPayload.Queries["attendanceAddressId"] = SourceExpressionConverter.ConvertO(attendanceAddressId);
                if (dateType != null)
                    callPayload.Queries["dateType"] = SourceExpressionConverter.ConvertO(dateType);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3ShiftTemplateListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _11addOpenShiftInfo([WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<int> bodyempPlanNo, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyshiftType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/addOpenShiftInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                if (bodylocationId != null)
                {
                    body["locationId"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodyshiftType != null)
                {
                    body["shiftType"] = SourceExpressionConverter.ConvertToken(bodyshiftType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
                body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
                body["hourlyRate"] = SourceExpressionConverter.ConvertToken(bodyhourlyRate);
                bodypropCount++;
                body["empPlanNo"] = SourceExpressionConverter.ConvertToken(bodyempPlanNo);
                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _11deleteTimesheetById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/deleteTimesheetById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeaveHolidayDetailResp> _11getLeaveApplicationInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3LeaveHolidayDetailResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _12deleteOpenShiftById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/deleteOpenShiftById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV3LeaveProcessResp> _12getLeaveApplicationApproveProcessById([WorkflowExpression] Func<string> recordId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeaveApplicationApproveProcessById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordId"] = SourceExpressionConverter.ConvertO(recordId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV3LeaveProcessResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _12updateTimesheetById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string> bodyworkOverTimeType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<string> bodyattendanceItemId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/updateTimesheetById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                if (bodyworkOverTimeType != null)
                {
                    body["workOverTimeType"] = SourceExpressionConverter.ConvertToken(bodyworkOverTimeType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
                body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyaddressCardId != null)
                {
                    body["addressCardId"] = SourceExpressionConverter.ConvertToken(bodyaddressCardId);
                    bodypropCount++;
                }

                if (bodyattendanceItemId != null)
                {
                    body["attendanceItemId"] = SourceExpressionConverter.ConvertToken(bodyattendanceItemId);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeaveTypeResp> _13getLeaveTypeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> shortName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeaveTypeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (shortName != null)
                    callPayload.Queries["shortName"] = SourceExpressionConverter.ConvertO(shortName);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LeaveTypeResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3TimesheetListResp> _13getTimesheetList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> departmentFilter = null, [WorkflowExpression] Func<string> positionFilter = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> bizLabelIds = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> calculateSalaryTypeFilter = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> addressCardId = null, [WorkflowExpression] Func<string> typeFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getTimesheetList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = SourceExpressionConverter.ConvertO(departmentFilter);
                if (positionFilter != null)
                    callPayload.Queries["positionFilter"] = SourceExpressionConverter.ConvertO(positionFilter);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (bizLabelIds != null)
                    callPayload.Queries["bizLabelIds"] = SourceExpressionConverter.ConvertO(bizLabelIds);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (calculateSalaryTypeFilter != null)
                    callPayload.Queries["calculateSalaryTypeFilter"] = SourceExpressionConverter.ConvertO(calculateSalaryTypeFilter);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (addressCardId != null)
                    callPayload.Queries["addressCardId"] = SourceExpressionConverter.ConvertO(addressCardId);
                if (typeFilter != null)
                    callPayload.Queries["typeFilter"] = SourceExpressionConverter.ConvertO(typeFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3TimesheetListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _13updateOpenShiftById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<int> bodyempPlanNo, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyshiftType = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/updateOpenShiftById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                if (bodylocationId != null)
                {
                    body["locationId"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodyshiftType != null)
                {
                    body["shiftType"] = SourceExpressionConverter.ConvertToken(bodyshiftType);
                    bodypropCount++;
                }

                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
                body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
                body["hourlyRate"] = SourceExpressionConverter.ConvertToken(bodyhourlyRate);
                bodypropCount++;
                body["empPlanNo"] = SourceExpressionConverter.ConvertToken(bodyempPlanNo);
                if (bodycostCenterId != null)
                {
                    body["costCenterId"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyResp> _14getLeavePolicyList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeavePolicyList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LeavePolicyResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3OpenShiftListResp> _14getOpenShiftList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> projectId = null, [WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<string> costCenterId = null, [WorkflowExpression] Func<string> date = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getOpenShiftList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (locationId != null)
                    callPayload.Queries["locationId"] = SourceExpressionConverter.ConvertO(locationId);
                if (costCenterId != null)
                    callPayload.Queries["costCenterId"] = SourceExpressionConverter.ConvertO(costCenterId);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3OpenShiftListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3TimesheetInfoResp> _14getTimesheetInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getTimesheetInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3TimesheetInfoResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3AddCalendarRemarkInfoResp> _15addCalendarRemarkInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyemployeeStatus, [WorkflowExpression] Func<string> bodytimeType, [WorkflowExpression] Func<string> bodyexpectWorkStartTime, [WorkflowExpression] Func<string> bodyexpectWorkEndTime, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyrecordDate = null, [WorkflowExpression] Func<string> bodyexpectWorkLocation = null, [WorkflowExpression] Func<string> bodyexpectWorkTimeTemplate = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/addCalendarRemarkInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["employeeStatus"] = SourceExpressionConverter.ConvertToken(bodyemployeeStatus);
                bodypropCount++;
                body["timeType"] = SourceExpressionConverter.ConvertToken(bodytimeType);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyrecordDate != null)
                {
                    body["recordDate"] = SourceExpressionConverter.ConvertToken(bodyrecordDate);
                    bodypropCount++;
                }

                if (bodyexpectWorkLocation != null)
                {
                    body["expectWorkLocation"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkLocation);
                    bodypropCount++;
                }

                if (bodyexpectWorkTimeTemplate != null)
                {
                    body["expectWorkTimeTemplate"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkTimeTemplate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expectWorkStartTime"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkStartTime);
                bodypropCount++;
                body["expectWorkEndTime"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkEndTime);
                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3AddCalendarRemarkInfoResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3LeavePolicyDetailResp> _15getLeavePolicyInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeavePolicyInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3LeavePolicyDetailResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3OpenShiftInfoResp> _15getOpenShiftInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getOpenShiftInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3OpenShiftInfoResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _16addProjectCategoryInfo([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCategoryInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _16deleteCalendarRemarkById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/deleteCalendarRemarkById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3LeavePolicyTypeResp> _16getLeavePolicyTypeList([WorkflowExpression] Func<string> regulationId, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> holidayId = null, [WorkflowExpression] Func<string> generationFrequency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/leave/getLeavePolicyTypeList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Queries["regulationId"] = SourceExpressionConverter.ConvertO(regulationId);
                if (holidayId != null)
                    callPayload.Queries["holidayId"] = SourceExpressionConverter.ConvertO(holidayId);
                if (generationFrequency != null)
                    callPayload.Queries["generationFrequency"] = SourceExpressionConverter.ConvertO(generationFrequency);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3LeavePolicyTypeResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _17deleteProjectCategoryById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCategoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _17updateCalendarRemarkById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyemployeeStatus, [WorkflowExpression] Func<string> bodytimeType, [WorkflowExpression] Func<string> bodyexpectWorkStartTime, [WorkflowExpression] Func<string> bodyexpectWorkEndTime, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyrecordDate = null, [WorkflowExpression] Func<string> bodyexpectWorkLocation = null, [WorkflowExpression] Func<string> bodyexpectWorkTimeTemplate = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/updateCalendarRemarkById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["employeeStatus"] = SourceExpressionConverter.ConvertToken(bodyemployeeStatus);
                bodypropCount++;
                body["timeType"] = SourceExpressionConverter.ConvertToken(bodytimeType);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyrecordDate != null)
                {
                    body["recordDate"] = SourceExpressionConverter.ConvertToken(bodyrecordDate);
                    bodypropCount++;
                }

                if (bodyexpectWorkLocation != null)
                {
                    body["expectWorkLocation"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkLocation);
                    bodypropCount++;
                }

                if (bodyexpectWorkTimeTemplate != null)
                {
                    body["expectWorkTimeTemplate"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkTimeTemplate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expectWorkStartTime"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkStartTime);
                bodypropCount++;
                body["expectWorkEndTime"] = SourceExpressionConverter.ConvertToken(bodyexpectWorkEndTime);
                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3StatusFlagListResp> _18getCalendarRemarkList([WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIds = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendance/getCalendarRemarkList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeIds != null)
                    callPayload.Queries["employeeIds"] = SourceExpressionConverter.ConvertO(employeeIds);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3StatusFlagListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _18updateProjectCategoryById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectCategoryById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ScheduleProjectCategoryListResp> _19getProjectCategoryList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getProjectCategoryList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3ScheduleProjectCategoryListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _20addProjectInfo([WorkflowExpression] Func<string> bodycode, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<double> bodyminRate = null, [WorkflowExpression] Func<double> bodymaxRate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/addProjectInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                if (bodycategoryId != null)
                {
                    body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["hourlyRate"] = SourceExpressionConverter.ConvertToken(bodyhourlyRate);
                if (bodyminRate != null)
                {
                    body["minRate"] = SourceExpressionConverter.ConvertToken(bodyminRate);
                    bodypropCount++;
                }

                if (bodymaxRate != null)
                {
                    body["maxRate"] = SourceExpressionConverter.ConvertToken(bodymaxRate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _21deleteProjectById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _22updateProjectById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodycode, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyhourlyRate, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<double> bodyminRate = null, [WorkflowExpression] Func<double> bodymaxRate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                if (bodycategoryId != null)
                {
                    body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["hourlyRate"] = SourceExpressionConverter.ConvertToken(bodyhourlyRate);
                if (bodyminRate != null)
                {
                    body["minRate"] = SourceExpressionConverter.ConvertToken(bodyminRate);
                    bodypropCount++;
                }

                if (bodymaxRate != null)
                {
                    body["maxRate"] = SourceExpressionConverter.ConvertToken(bodymaxRate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ProjectListResp> _23getProjectList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getProjectList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3ProjectListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV3ProjectInfoResp> _24getProjectInfoById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getProjectInfoById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV3ProjectInfoResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _25addProjectCertificateInfo([WorkflowExpression] Func<string> bodyemployeeId, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<double> bodyshiftHours, [WorkflowExpression] Func<double> bodyworkedHours, [WorkflowExpression] Func<string> bodytier = null, [WorkflowExpression] Func<double> bodytierRate = null, [WorkflowExpression] Func<string> bodyreason = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCertificateInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["employeeId"] = SourceExpressionConverter.ConvertToken(bodyemployeeId);
                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                if (bodytier != null)
                {
                    body["tier"] = SourceExpressionConverter.ConvertToken(bodytier);
                    bodypropCount++;
                }

                if (bodytierRate != null)
                {
                    body["tierRate"] = SourceExpressionConverter.ConvertToken(bodytierRate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shiftHours"] = SourceExpressionConverter.ConvertToken(bodyshiftHours);
                bodypropCount++;
                body["workedHours"] = SourceExpressionConverter.ConvertToken(bodyworkedHours);
                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _26updateProjectCertificateById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodytier = null, [WorkflowExpression] Func<double> bodytierRate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/updateProjectCertificateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodytier != null)
                {
                    body["tier"] = SourceExpressionConverter.ConvertToken(bodytier);
                    bodypropCount++;
                }

                if (bodytierRate != null)
                {
                    body["tierRate"] = SourceExpressionConverter.ConvertToken(bodytierRate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateListResp> _27getProjectCertificateList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> hireType = null, [WorkflowExpression] Func<string> projectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getProjectCertificateList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (departmentId != null)
                    callPayload.Queries["departmentId"] = SourceExpressionConverter.ConvertO(departmentId);
                if (positionId != null)
                    callPayload.Queries["positionId"] = SourceExpressionConverter.ConvertO(positionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (hireType != null)
                    callPayload.Queries["hireType"] = SourceExpressionConverter.ConvertO(hireType);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3ProjectCertificateListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _28addProjectCertificateHours([WorkflowExpression] Func<string> bodyprojectCertificateId, [WorkflowExpression] Func<string> bodyoccurrenceTime, [WorkflowExpression] Func<double> bodybalance, [WorkflowExpression] Func<string> bodyreason)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/addProjectCertificateHours";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["projectCertificateId"] = SourceExpressionConverter.ConvertToken(bodyprojectCertificateId);
                bodypropCount++;
                body["occurrenceTime"] = SourceExpressionConverter.ConvertToken(bodyoccurrenceTime);
                bodypropCount++;
                body["balance"] = SourceExpressionConverter.ConvertToken(bodybalance);
                bodypropCount++;
                body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> _29deleteProjectCertificateHoursById([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/deleteProjectCertificateHoursById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV3ProjectCertificateHoursListResp> _30getProjectCertificateHourList([WorkflowExpression] Func<string> projectCertificateId, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/attendCalculation/getProjectCertificateHourList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectCertificateId"] = SourceExpressionConverter.ConvertO(projectCertificateId);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV3ProjectCertificateHoursListResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2AttendanceResp> GetAttendCalculationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendDay = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> attendStatus = null, [WorkflowExpression] Func<string> type = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/attendance/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (attendDay != null)
                    callPayload.Queries["attendDay"] = SourceExpressionConverter.ConvertO(attendDay);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (attendStatus != null)
                    callPayload.Queries["attendStatus"] = SourceExpressionConverter.ConvertO(attendStatus);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2AttendanceResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2CostCenterResp> GetCostCenterList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> costCenterCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/getCostCenterList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (costCenterCode != null)
                    callPayload.Queries["costCenterCode"] = SourceExpressionConverter.ConvertO(costCenterCode);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2CostCenterResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2DepartmentResp> GetDepartmentList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> departmentCode = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/department/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (departmentCode != null)
                    callPayload.Queries["departmentCode"] = SourceExpressionConverter.ConvertO(departmentCode);
                if (parentId != null)
                    callPayload.Queries["parentId"] = SourceExpressionConverter.ConvertO(parentId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2DepartmentResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2EmployeeResp> GetEmployeeList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> englishName = null, [WorkflowExpression] Func<string> chineseName = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> education = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<string> hireType = null, [WorkflowExpression] Func<string> bankCode = null, [WorkflowExpression] Func<string> costCenterId = null, [WorkflowExpression] Func<string> payrollRegulationId = null, [WorkflowExpression] Func<string> workDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/employee/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (englishName != null)
                    callPayload.Queries["englishName"] = SourceExpressionConverter.ConvertO(englishName);
                if (chineseName != null)
                    callPayload.Queries["chineseName"] = SourceExpressionConverter.ConvertO(chineseName);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.ConvertO(countryCode);
                if (phone != null)
                    callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (code != null)
                    callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (education != null)
                    callPayload.Queries["education"] = SourceExpressionConverter.ConvertO(education);
                if (departmentId != null)
                    callPayload.Queries["departmentId"] = SourceExpressionConverter.ConvertO(departmentId);
                if (positionId != null)
                    callPayload.Queries["positionId"] = SourceExpressionConverter.ConvertO(positionId);
                if (hireType != null)
                    callPayload.Queries["hireType"] = SourceExpressionConverter.ConvertO(hireType);
                if (bankCode != null)
                    callPayload.Queries["bankCode"] = SourceExpressionConverter.ConvertO(bankCode);
                if (costCenterId != null)
                    callPayload.Queries["costCenterId"] = SourceExpressionConverter.ConvertO(costCenterId);
                if (payrollRegulationId != null)
                    callPayload.Queries["payrollRegulationId"] = SourceExpressionConverter.ConvertO(payrollRegulationId);
                if (workDate != null)
                    callPayload.Queries["workDate"] = SourceExpressionConverter.ConvertO(workDate);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2EmployeeResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2ExpenseResp> GetExpenseApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> reimbursementStatusFilter = null, [WorkflowExpression] Func<string> reimbursementName = null, [WorkflowExpression] Func<string> departmentFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/getExpenseApplicationList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (reimbursementStatusFilter != null)
                    callPayload.Queries["reimbursementStatusFilter"] = SourceExpressionConverter.ConvertO(reimbursementStatusFilter);
                if (reimbursementName != null)
                    callPayload.Queries["reimbursementName"] = SourceExpressionConverter.ConvertO(reimbursementName);
                if (departmentFilter != null)
                    callPayload.Queries["departmentFilter"] = SourceExpressionConverter.ConvertO(departmentFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2ExpenseResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2ExternalPayItemResp> GetExtPayItemData([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> employeeCode = null, [WorkflowExpression] Func<string> businessSalaryItemId = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> businessSalaryItemFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/getExtPayItemData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (employeeCode != null)
                    callPayload.Queries["employeeCode"] = SourceExpressionConverter.ConvertO(employeeCode);
                if (businessSalaryItemId != null)
                    callPayload.Queries["businessSalaryItemId"] = SourceExpressionConverter.ConvertO(businessSalaryItemId);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (businessSalaryItemFilter != null)
                    callPayload.Queries["businessSalaryItemFilter"] = SourceExpressionConverter.ConvertO(businessSalaryItemFilter);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2ExternalPayItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2ExtPayItemResp> GetExtPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> paymentType = null, [WorkflowExpression] Func<string> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/getExtPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (paymentType != null)
                    callPayload.Queries["paymentType"] = SourceExpressionConverter.ConvertO(paymentType);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2ExtPayItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2FixedPayItemResp> GetFixedPayItemData([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> payrollItemId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/getFixedPayItemData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (payrollItemId != null)
                    callPayload.Queries["payrollItemId"] = SourceExpressionConverter.ConvertO(payrollItemId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2FixedPayItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2LabelResp> GetLabelList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> labelCode = null, [WorkflowExpression] Func<string> labelName = null, [WorkflowExpression] Func<int> labelStatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/label/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (labelCode != null)
                    callPayload.Queries["labelCode"] = SourceExpressionConverter.ConvertO(labelCode);
                if (labelName != null)
                    callPayload.Queries["labelName"] = SourceExpressionConverter.ConvertO(labelName);
                if (labelStatus != null)
                    callPayload.Queries["labelStatus"] = SourceExpressionConverter.ConvertO(labelStatus);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2LabelResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2LeaveApplicationResp> GetLeaveApplicationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> holidayType = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> holidayDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/leave/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (holidayType != null)
                    callPayload.Queries["holidayType"] = SourceExpressionConverter.ConvertO(holidayType);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (holidayDate != null)
                    callPayload.Queries["holidayDate"] = SourceExpressionConverter.ConvertO(holidayDate);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2LeaveApplicationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2PayItemResp> GetPayItemList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/getPayItemList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2PayItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2PayrollPlanResp> GetPayrunList([WorkflowExpression] Func<string> status, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/getPayrunList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2PayrollPlanResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2PositionResp> GetPositionList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> positionCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/getPositionList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (positionCode != null)
                    callPayload.Queries["positionCode"] = SourceExpressionConverter.ConvertO(positionCode);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2PositionResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultListV2RosterResp> GetRosterDataList([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> attendCalculationId = null, [WorkflowExpression] Func<string> departmentId = null, [WorkflowExpression] Func<string> positionId = null, [WorkflowExpression] Func<string> statusFilter = null, [WorkflowExpression] Func<string> englishName = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> surnameEnglish = null, [WorkflowExpression] Func<string> personalNameEnglish = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/getRosterDataList";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (attendCalculationId != null)
                    callPayload.Queries["attendCalculationId"] = SourceExpressionConverter.ConvertO(attendCalculationId);
                callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (departmentId != null)
                    callPayload.Queries["departmentId"] = SourceExpressionConverter.ConvertO(departmentId);
                if (positionId != null)
                    callPayload.Queries["positionId"] = SourceExpressionConverter.ConvertO(positionId);
                if (statusFilter != null)
                    callPayload.Queries["statusFilter"] = SourceExpressionConverter.ConvertO(statusFilter);
                if (englishName != null)
                    callPayload.Queries["englishName"] = SourceExpressionConverter.ConvertO(englishName);
                if (code != null)
                    callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                if (surnameEnglish != null)
                    callPayload.Queries["surnameEnglish"] = SourceExpressionConverter.ConvertO(surnameEnglish);
                if (personalNameEnglish != null)
                    callPayload.Queries["personalNameEnglish"] = SourceExpressionConverter.ConvertO(personalNameEnglish);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListV2RosterResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultV2TenantResp> GetTenantInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenant/getById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultV2TenantResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2TimesheetResp> GetTimesheetList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/timesheet/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2TimesheetResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2VarPayItemResp> GetVarPayItemData([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> employeeId = null, [WorkflowExpression] Func<string> payrollItemId = null, [WorkflowExpression] Func<string> employeeIdFilter = null, [WorkflowExpression] Func<string> payrollItemIdFilter = null, [WorkflowExpression] Func<string> payrollPlanId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/getVarPayItemData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (employeeId != null)
                    callPayload.Queries["employeeId"] = SourceExpressionConverter.ConvertO(employeeId);
                if (payrollItemId != null)
                    callPayload.Queries["payrollItemId"] = SourceExpressionConverter.ConvertO(payrollItemId);
                if (employeeIdFilter != null)
                    callPayload.Queries["employeeIdFilter"] = SourceExpressionConverter.ConvertO(employeeIdFilter);
                if (payrollItemIdFilter != null)
                    callPayload.Queries["payrollItemIdFilter"] = SourceExpressionConverter.ConvertO(payrollItemIdFilter);
                if (payrollPlanId != null)
                    callPayload.Queries["payrollPlanId"] = SourceExpressionConverter.ConvertO(payrollPlanId);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2VarPayItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultIPageV2WorkLocationResp> GetWorkLocationList([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> current = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> attendanceAddressCode = null, [WorkflowExpression] Func<string> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/workLocation/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (current != null)
                    callPayload.Queries["current"] = SourceExpressionConverter.ConvertO(current);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (attendanceAddressCode != null)
                    callPayload.Queries["attendanceAddressCode"] = SourceExpressionConverter.ConvertO(attendanceAddressCode);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<ResultIPageV2WorkLocationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateCardById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyisInValid = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/attendance/updateCardById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyisInValid != null)
                {
                    body["isInValid"] = SourceExpressionConverter.ConvertToken(bodyisInValid);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateCostCenterInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/updateCostCenterInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycostCenterCode != null)
                {
                    body["costCenterCode"] = SourceExpressionConverter.ConvertToken(bodycostCenterCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateDepartmentInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydepartmentCode = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/department/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydepartmentCode != null)
                {
                    body["departmentCode"] = SourceExpressionConverter.ConvertToken(bodydepartmentCode);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateEmployeeInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyenglishName = null, [WorkflowExpression] Func<string> bodychineseName = null, [WorkflowExpression] Func<string> bodysex = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyidentityCard = null, [WorkflowExpression] Func<string> bodybankCard = null, [WorkflowExpression] Func<string> bodynickName = null, [WorkflowExpression] Func<string> bodyeducation = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<string> bodyemergencyContactName = null, [WorkflowExpression] Func<string> bodyemergencyContactRelation = null, [WorkflowExpression] Func<string> bodyemergencyContactPhone = null, [WorkflowExpression] Func<string> bodybankName = null, [WorkflowExpression] Func<string> bodybankBranchNumber = null, [WorkflowExpression] Func<string> bodybankAccountNo = null, [WorkflowExpression] Func<string> bodybankCode = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyregionCode = null, [WorkflowExpression] Func<string> bodyidentityCardHk = null, [WorkflowExpression] Func<string> bodypassportNumber = null, [WorkflowExpression] Func<string> bodypassportIssuingPlace = null, [WorkflowExpression] Func<string> bodyspouseName = null, [WorkflowExpression] Func<string> bodyspouseIdentityCardHk = null, [WorkflowExpression] Func<string> bodyspousePassportNumber = null, [WorkflowExpression] Func<string> bodyspousePassportIssuingPlace = null, [WorkflowExpression] Func<string> bodypostalAddress = null, [WorkflowExpression] Func<string> bodyemployerName = null, [WorkflowExpression] Func<string> bodyhometown = null, [WorkflowExpression] Func<string> bodynation = null, [WorkflowExpression] Func<string> bodypoliticalStatus = null, [WorkflowExpression] Func<string> bodyhighestEducation = null, [WorkflowExpression] Func<string> bodyworkDate = null, [WorkflowExpression] Func<string> bodyconfirmationDate = null, [WorkflowExpression] Func<string> bodyprobation = null, [WorkflowExpression] Func<bool> bodyisDisabled = null, [WorkflowExpression] Func<bool> bodyisForeignNationality = null, [WorkflowExpression] Func<string> bodydomicileLocation = null, [WorkflowExpression] Func<string> bodycertificateType = null, [WorkflowExpression] Func<string> bodycertificateNumber = null, [WorkflowExpression] Func<bool> bodyisMartyrDependents = null, [WorkflowExpression] Func<string> bodyoccupationTaxNumber = null, [WorkflowExpression] Func<string> bodynonLocalBlueCardNumber = null, [WorkflowExpression] Func<bool> bodyisForeignEmployees = null, [WorkflowExpression] Func<string> bodyweeklyLeaveWorkAgreement = null, [WorkflowExpression] Func<string> bodyemployeeType = null, [WorkflowExpression] Func<string> bodyjobLevel = null, [WorkflowExpression] Func<string> bodypost = null, [WorkflowExpression] Func<string> bodysalaryScale = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodyrecruitmentSource = null, [WorkflowExpression] Func<string> bodygraduatedSchool = null, [WorkflowExpression] Func<string> bodyprofession = null, [WorkflowExpression] Func<string> bodyappellation = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyhomePhone = null, [WorkflowExpression] Func<string> bodyofficePhone = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyprovince = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodypostcode = null, [WorkflowExpression] Func<string> bodycontractEndDate = null, [WorkflowExpression] Func<string> bodytaxIdentity = null, [WorkflowExpression] Func<string> bodyotherIncomeName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/employee/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyenglishName != null)
                {
                    body["englishName"] = SourceExpressionConverter.ConvertToken(bodyenglishName);
                    bodypropCount++;
                }

                if (bodychineseName != null)
                {
                    body["chineseName"] = SourceExpressionConverter.ConvertToken(bodychineseName);
                    bodypropCount++;
                }

                if (bodysex != null)
                {
                    body["sex"] = SourceExpressionConverter.ConvertToken(bodysex);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyidentityCard != null)
                {
                    body["identityCard"] = SourceExpressionConverter.ConvertToken(bodyidentityCard);
                    bodypropCount++;
                }

                if (bodybankCard != null)
                {
                    body["bankCard"] = SourceExpressionConverter.ConvertToken(bodybankCard);
                    bodypropCount++;
                }

                if (bodynickName != null)
                {
                    body["nickName"] = SourceExpressionConverter.ConvertToken(bodynickName);
                    bodypropCount++;
                }

                if (bodyeducation != null)
                {
                    body["education"] = SourceExpressionConverter.ConvertToken(bodyeducation);
                    bodypropCount++;
                }

                if (bodynationality != null)
                {
                    body["nationality"] = SourceExpressionConverter.ConvertToken(bodynationality);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["maritalStatus"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                if (bodyemergencyContactName != null)
                {
                    body["emergencyContactName"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactName);
                    bodypropCount++;
                }

                if (bodyemergencyContactRelation != null)
                {
                    body["emergencyContactRelation"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactRelation);
                    bodypropCount++;
                }

                if (bodyemergencyContactPhone != null)
                {
                    body["emergencyContactPhone"] = SourceExpressionConverter.ConvertToken(bodyemergencyContactPhone);
                    bodypropCount++;
                }

                if (bodybankName != null)
                {
                    body["bankName"] = SourceExpressionConverter.ConvertToken(bodybankName);
                    bodypropCount++;
                }

                if (bodybankBranchNumber != null)
                {
                    body["bankBranchNumber"] = SourceExpressionConverter.ConvertToken(bodybankBranchNumber);
                    bodypropCount++;
                }

                if (bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = SourceExpressionConverter.ConvertToken(bodybankAccountNo);
                    bodypropCount++;
                }

                if (bodybankCode != null)
                {
                    body["bankCode"] = SourceExpressionConverter.ConvertToken(bodybankCode);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodyregionCode != null)
                {
                    body["regionCode"] = SourceExpressionConverter.ConvertToken(bodyregionCode);
                    bodypropCount++;
                }

                if (bodyidentityCardHk != null)
                {
                    body["identityCardHk"] = SourceExpressionConverter.ConvertToken(bodyidentityCardHk);
                    bodypropCount++;
                }

                if (bodypassportNumber != null)
                {
                    body["passportNumber"] = SourceExpressionConverter.ConvertToken(bodypassportNumber);
                    bodypropCount++;
                }

                if (bodypassportIssuingPlace != null)
                {
                    body["passportIssuingPlace"] = SourceExpressionConverter.ConvertToken(bodypassportIssuingPlace);
                    bodypropCount++;
                }

                if (bodyspouseName != null)
                {
                    body["spouseName"] = SourceExpressionConverter.ConvertToken(bodyspouseName);
                    bodypropCount++;
                }

                if (bodyspouseIdentityCardHk != null)
                {
                    body["spouseIdentityCardHk"] = SourceExpressionConverter.ConvertToken(bodyspouseIdentityCardHk);
                    bodypropCount++;
                }

                if (bodyspousePassportNumber != null)
                {
                    body["spousePassportNumber"] = SourceExpressionConverter.ConvertToken(bodyspousePassportNumber);
                    bodypropCount++;
                }

                if (bodyspousePassportIssuingPlace != null)
                {
                    body["spousePassportIssuingPlace"] = SourceExpressionConverter.ConvertToken(bodyspousePassportIssuingPlace);
                    bodypropCount++;
                }

                if (bodypostalAddress != null)
                {
                    body["postalAddress"] = SourceExpressionConverter.ConvertToken(bodypostalAddress);
                    bodypropCount++;
                }

                if (bodyemployerName != null)
                {
                    body["employerName"] = SourceExpressionConverter.ConvertToken(bodyemployerName);
                    bodypropCount++;
                }

                if (bodyhometown != null)
                {
                    body["hometown"] = SourceExpressionConverter.ConvertToken(bodyhometown);
                    bodypropCount++;
                }

                if (bodynation != null)
                {
                    body["nation"] = SourceExpressionConverter.ConvertToken(bodynation);
                    bodypropCount++;
                }

                if (bodypoliticalStatus != null)
                {
                    body["politicalStatus"] = SourceExpressionConverter.ConvertToken(bodypoliticalStatus);
                    bodypropCount++;
                }

                if (bodyhighestEducation != null)
                {
                    body["highestEducation"] = SourceExpressionConverter.ConvertToken(bodyhighestEducation);
                    bodypropCount++;
                }

                if (bodyworkDate != null)
                {
                    body["workDate"] = SourceExpressionConverter.ConvertToken(bodyworkDate);
                    bodypropCount++;
                }

                if (bodyconfirmationDate != null)
                {
                    body["confirmationDate"] = SourceExpressionConverter.ConvertToken(bodyconfirmationDate);
                    bodypropCount++;
                }

                if (bodyprobation != null)
                {
                    body["probation"] = SourceExpressionConverter.ConvertToken(bodyprobation);
                    bodypropCount++;
                }

                if (bodyisDisabled != null)
                {
                    body["isDisabled"] = SourceExpressionConverter.ConvertToken(bodyisDisabled);
                    bodypropCount++;
                }

                if (bodyisForeignNationality != null)
                {
                    body["isForeignNationality"] = SourceExpressionConverter.ConvertToken(bodyisForeignNationality);
                    bodypropCount++;
                }

                if (bodydomicileLocation != null)
                {
                    body["domicileLocation"] = SourceExpressionConverter.ConvertToken(bodydomicileLocation);
                    bodypropCount++;
                }

                if (bodycertificateType != null)
                {
                    body["certificateType"] = SourceExpressionConverter.ConvertToken(bodycertificateType);
                    bodypropCount++;
                }

                if (bodycertificateNumber != null)
                {
                    body["certificateNumber"] = SourceExpressionConverter.ConvertToken(bodycertificateNumber);
                    bodypropCount++;
                }

                if (bodyisMartyrDependents != null)
                {
                    body["isMartyrDependents"] = SourceExpressionConverter.ConvertToken(bodyisMartyrDependents);
                    bodypropCount++;
                }

                if (bodyoccupationTaxNumber != null)
                {
                    body["occupationTaxNumber"] = SourceExpressionConverter.ConvertToken(bodyoccupationTaxNumber);
                    bodypropCount++;
                }

                if (bodynonLocalBlueCardNumber != null)
                {
                    body["nonLocalBlueCardNumber"] = SourceExpressionConverter.ConvertToken(bodynonLocalBlueCardNumber);
                    bodypropCount++;
                }

                if (bodyisForeignEmployees != null)
                {
                    body["isForeignEmployees"] = SourceExpressionConverter.ConvertToken(bodyisForeignEmployees);
                    bodypropCount++;
                }

                if (bodyweeklyLeaveWorkAgreement != null)
                {
                    body["weeklyLeaveWorkAgreement"] = SourceExpressionConverter.ConvertToken(bodyweeklyLeaveWorkAgreement);
                    bodypropCount++;
                }

                if (bodyemployeeType != null)
                {
                    body["employeeType"] = SourceExpressionConverter.ConvertToken(bodyemployeeType);
                    bodypropCount++;
                }

                if (bodyjobLevel != null)
                {
                    body["jobLevel"] = SourceExpressionConverter.ConvertToken(bodyjobLevel);
                    bodypropCount++;
                }

                if (bodypost != null)
                {
                    body["post"] = SourceExpressionConverter.ConvertToken(bodypost);
                    bodypropCount++;
                }

                if (bodysalaryScale != null)
                {
                    body["salaryScale"] = SourceExpressionConverter.ConvertToken(bodysalaryScale);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodyrecruitmentSource != null)
                {
                    body["recruitmentSource"] = SourceExpressionConverter.ConvertToken(bodyrecruitmentSource);
                    bodypropCount++;
                }

                if (bodygraduatedSchool != null)
                {
                    body["graduatedSchool"] = SourceExpressionConverter.ConvertToken(bodygraduatedSchool);
                    bodypropCount++;
                }

                if (bodyprofession != null)
                {
                    body["profession"] = SourceExpressionConverter.ConvertToken(bodyprofession);
                    bodypropCount++;
                }

                if (bodyappellation != null)
                {
                    body["appellation"] = SourceExpressionConverter.ConvertToken(bodyappellation);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middleName"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodyhomePhone != null)
                {
                    body["homePhone"] = SourceExpressionConverter.ConvertToken(bodyhomePhone);
                    bodypropCount++;
                }

                if (bodyofficePhone != null)
                {
                    body["officePhone"] = SourceExpressionConverter.ConvertToken(bodyofficePhone);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyprovince != null)
                {
                    body["province"] = SourceExpressionConverter.ConvertToken(bodyprovince);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodypostcode != null)
                {
                    body["postcode"] = SourceExpressionConverter.ConvertToken(bodypostcode);
                    bodypropCount++;
                }

                if (bodycontractEndDate != null)
                {
                    body["contractEndDate"] = SourceExpressionConverter.ConvertToken(bodycontractEndDate);
                    bodypropCount++;
                }

                if (bodytaxIdentity != null)
                {
                    body["taxIdentity"] = SourceExpressionConverter.ConvertToken(bodytaxIdentity);
                    bodypropCount++;
                }

                if (bodyotherIncomeName != null)
                {
                    body["otherIncomeName"] = SourceExpressionConverter.ConvertToken(bodyotherIncomeName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateExpenseApplication([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyreimbursementName = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/updateExpenseApplication";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyreimbursementName != null)
                {
                    body["reimbursementName"] = SourceExpressionConverter.ConvertToken(bodyreimbursementName);
                    bodypropCount++;
                }

                if (bodyamount != null)
                {
                    body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateExternalSalary([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyoccurrenceDate = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/updateExternalSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodymoney != null)
                {
                    body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                    bodypropCount++;
                }

                if (bodyoccurrenceDate != null)
                {
                    body["occurrenceDate"] = SourceExpressionConverter.ConvertToken(bodyoccurrenceDate);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodyexpirationDate != null)
                {
                    body["expirationDate"] = SourceExpressionConverter.ConvertToken(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateFixedSalary([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodypayrollItemId = null, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/updateFixedSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypayrollItemId != null)
                {
                    body["payrollItemId"] = SourceExpressionConverter.ConvertToken(bodypayrollItemId);
                    bodypropCount++;
                }

                if (bodymoney != null)
                {
                    body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateLabelInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylabelCode = null, [WorkflowExpression] Func<string> bodylabelName = null, [WorkflowExpression] Func<int> bodylabelStatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/label/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodylabelCode != null)
                {
                    body["labelCode"] = SourceExpressionConverter.ConvertToken(bodylabelCode);
                    bodypropCount++;
                }

                if (bodylabelName != null)
                {
                    body["labelName"] = SourceExpressionConverter.ConvertToken(bodylabelName);
                    bodypropCount++;
                }

                if (bodylabelStatus != null)
                {
                    body["labelStatus"] = SourceExpressionConverter.ConvertToken(bodylabelStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateLeaveApplication([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyholidayType = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<double> bodyleaveTime = null, [WorkflowExpression] Func<string> bodytimeType = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyholidayDate = null, [WorkflowExpression] Func<string> bodytime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/leave/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyholidayType != null)
                {
                    body["holidayType"] = SourceExpressionConverter.ConvertToken(bodyholidayType);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodyleaveTime != null)
                {
                    body["leaveTime"] = SourceExpressionConverter.ConvertToken(bodyleaveTime);
                    bodypropCount++;
                }

                if (bodytimeType != null)
                {
                    body["timeType"] = SourceExpressionConverter.ConvertToken(bodytimeType);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodyholidayDate != null)
                {
                    body["holidayDate"] = SourceExpressionConverter.ConvertToken(bodyholidayDate);
                    bodypropCount++;
                }

                if (bodytime != null)
                {
                    body["time"] = SourceExpressionConverter.ConvertToken(bodytime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdatePositionInfo([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/updatePositionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypositionCode != null)
                {
                    body["positionCode"] = SourceExpressionConverter.ConvertToken(bodypositionCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterData([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyshiftIn = null, [WorkflowExpression] Func<string> bodyshiftOff = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyshiftStatus = null, [WorkflowExpression] Func<string> bodyaddressCardId = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodyacrossTheNight = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenants/updateRosterData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyshiftIn != null)
                {
                    body["shiftIn"] = SourceExpressionConverter.ConvertToken(bodyshiftIn);
                    bodypropCount++;
                }

                if (bodyshiftOff != null)
                {
                    body["shiftOff"] = SourceExpressionConverter.ConvertToken(bodyshiftOff);
                    bodypropCount++;
                }

                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyshiftStatus != null)
                {
                    body["shiftStatus"] = SourceExpressionConverter.ConvertToken(bodyshiftStatus);
                    bodypropCount++;
                }

                if (bodyaddressCardId != null)
                {
                    body["addressCardId"] = SourceExpressionConverter.ConvertToken(bodyaddressCardId);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodydateType != null)
                {
                    body["dateType"] = SourceExpressionConverter.ConvertToken(bodydateType);
                    bodypropCount++;
                }

                if (bodyacrossTheNight != null)
                {
                    body["acrossTheNight"] = SourceExpressionConverter.ConvertToken(bodyacrossTheNight);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateRosterItem([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/attendance/updateRosterItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateShiftTemplate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyshiftIn = null, [WorkflowExpression] Func<string> bodyshiftOff = null, [WorkflowExpression] Func<int> bodymealTime = null, [WorkflowExpression] Func<string> bodyattendanceAddressId = null, [WorkflowExpression] Func<string> bodydateType = null, [WorkflowExpression] Func<string> bodylunchStartTime = null, [WorkflowExpression] Func<string> bodylunchEndTime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/attendance/updateShiftTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyshiftIn != null)
                {
                    body["shiftIn"] = SourceExpressionConverter.ConvertToken(bodyshiftIn);
                    bodypropCount++;
                }

                if (bodyshiftOff != null)
                {
                    body["shiftOff"] = SourceExpressionConverter.ConvertToken(bodyshiftOff);
                    bodypropCount++;
                }

                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodyattendanceAddressId != null)
                {
                    body["attendanceAddressId"] = SourceExpressionConverter.ConvertToken(bodyattendanceAddressId);
                    bodypropCount++;
                }

                if (bodydateType != null)
                {
                    body["dateType"] = SourceExpressionConverter.ConvertToken(bodydateType);
                    bodypropCount++;
                }

                if (bodylunchStartTime != null)
                {
                    body["lunchStartTime"] = SourceExpressionConverter.ConvertToken(bodylunchStartTime);
                    bodypropCount++;
                }

                if (bodylunchEndTime != null)
                {
                    body["lunchEndTime"] = SourceExpressionConverter.ConvertToken(bodylunchEndTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateTenantInfo([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodybusinessRegistrationNumber = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodybankName = null, [WorkflowExpression] Func<string> bodybankBranchCode = null, [WorkflowExpression] Func<string> bodybankAccountNo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/tenant/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodybusinessRegistrationNumber != null)
                {
                    body["businessRegistrationNumber"] = SourceExpressionConverter.ConvertToken(bodybusinessRegistrationNumber);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodybankName != null)
                {
                    body["bankName"] = SourceExpressionConverter.ConvertToken(bodybankName);
                    bodypropCount++;
                }

                if (bodybankBranchCode != null)
                {
                    body["bankBranchCode"] = SourceExpressionConverter.ConvertToken(bodybankBranchCode);
                    bodypropCount++;
                }

                if (bodybankAccountNo != null)
                {
                    body["bankAccountNo"] = SourceExpressionConverter.ConvertToken(bodybankAccountNo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateTimesheet([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bool> bodyisCrossTheSky = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<int> bodymealTime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/timesheet/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyisCrossTheSky != null)
                {
                    body["isCrossTheSky"] = SourceExpressionConverter.ConvertToken(bodyisCrossTheSky);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodymealTime != null)
                {
                    body["mealTime"] = SourceExpressionConverter.ConvertToken(bodymealTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateVarSalary([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<double> bodymoney = null, [WorkflowExpression] Func<string> bodyremark = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/payroll/updateVarSalary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodymoney != null)
                {
                    body["money"] = SourceExpressionConverter.ConvertToken(bodymoney);
                    bodypropCount++;
                }

                if (bodyremark != null)
                {
                    body["remark"] = SourceExpressionConverter.ConvertToken(bodyremark);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workstemau")]
        public IBodyWorkflowAction<ResultBoolean> UpdateWorkLocation([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodyregion = null, [WorkflowExpression] Func<string> bodyattendanceAddressCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyareaCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/workLocation/updateById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodyattendanceAddressCode != null)
                {
                    body["attendanceAddressCode"] = SourceExpressionConverter.ConvertToken(bodyattendanceAddressCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyareaCode != null)
                {
                    body["areaCode"] = SourceExpressionConverter.ConvertToken(bodyareaCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResultBoolean>(BuildSourceInput);
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